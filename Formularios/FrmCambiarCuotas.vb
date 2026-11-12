Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FrmCambiarCuotas
    Public nReg As Integer

    Private Sub FrmCambiarCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carga inicial de datos desde Aiven
        Me.FalleroTableAdapter.Fill(Me.DataSetCuotas.fallero)
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)

        Me.TxtNumCuotasActual.Text = FalleroTableAdapter.ScalarNumCuotasAnterior().ToString()

        Me.AsignarValoresFalleroCheckBox.Enabled = False
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        ' Bloqueo preventivo visual si ya se ejecutó en el pasado
        If Me.AsignarValoresFalleroCheckBox.Checked = True Then
            Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
            MsgBox("Los valores nuevos de cuota ya han sido asignados.", MsgBoxStyle.Information, "Información")
            Me.BtnActualizar.Enabled = False
            Me.BtnSalir.Focus()
        End If

        Me.ProgressBar1.Visible = False
        Me.TxtNumRegistros.Visible = False
        Me.Label2.Text = ""
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim nCod, nNumCuotas, nPagosRealizados, r As Integer
        Dim nValCuota, nDto, nPago, nTotCuota, nCargos, nAbonos, nNewDeuda, nPagado, nAcuenta, nBenef, nDevBenef As Double
        Dim cTipoCuota As String
        Dim nAnoCen As Integer

        Dim dtFalleros As DataTable = Me.DataSetCuotas.fallero
        r = dtFalleros.Rows.Count

        If r = 0 Then
            MsgBox("No hay registros de falleros activos para procesar.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        ' === CONFIGURACIÓN DE LA INTERFAZ ===
        Me.BtnActualizar.Enabled = False
        Me.TxtNumCuotasActual.Text = FalleroTableAdapter.ScalarNumCuotasAnterior().ToString()
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = r
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        Me.TxtNumRegistros.Visible = True
        Me.Label2.Visible = True
        Me.Label2.Text = "Iniciando recalculo de cuotas diferenciales..."

        nAnoCen = Val(Me.AñoejeTextBox.Text)

        ' Forzamos el redibujado inicial en la ventana
        Application.DoEvents()

        ' 1. Iniciamos el control de la conexión y la transacción manual con Aiven
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)
            Dim transaccion As MySqlTransaction = Nothing

            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' 🔥 Vinculamos de forma estricta los adaptadores a la transacción activa
                Me.FalleroTableAdapter.Connection = conexion

                nReg = 0
                ' 2. 🔥 PROCESAMIENTO ACELERADO: Leemos directamente los registros de la memoria RAM
                For i As Integer = 0 To r - 1
                    Dim fila As DataRow = dtFalleros.Rows(i)

                    ' Cargamos los datos acumulados antes del cambio
                    nPagosRealizados = Val(fila("NUM_PAGOS")) ' Ajusta a "CP" o tu columna de Cuotas Pendientes si difiere
                    nCod = Val(fila("FALLERO_CODIGO"))
                    nPagado = Val(fila("PAGO")) * nPagosRealizados

                    ' Recolectamos e implementamos los nuevos valores económicos calculados
                    nValCuota = Val(fila("CUOTA"))
                    nDto = Val(fila("ValorDto"))
                    nPago = Math.Round(nValCuota * (1 - nDto / 100), 2, MidpointRounding.AwayFromZero)

                    ' Cálculo del diferencial contable corregido
                    nCargos = Math.Round(fila("OtrosCargos") + (nPago * nPagosRealizados) - nPagado, 2, MidpointRounding.AwayFromZero)
                    nBenef = Val(fila("BENEFICIOS"))
                    nDevBenef = Val(fila("DEV_BENEFI")) ' Eliminamos el signo menos suelto
                    nAcuenta = Val(fila("A_CUENTA"))

                    cTipoCuota = fila("TIPO_CUOTA").ToString()

                    If cTipoCuota = "ANUAL" Then
                        nNumCuotas = 1
                    Else
                        nNumCuotas = Val(NumcuotasmesTextBox.Text)
                    End If

                    nAbonos = nBenef + nAcuenta - nDevBenef
                    nTotCuota = nPago * nNumCuotas
                    nNewDeuda = nTotCuota + nCargos - nAbonos - nPagado

                    ' Ejecutamos las dos actualizaciones consecutivas en modo "borrador seguro"
                    Me.FalleroTableAdapter.UpdateNewCuotas(nValCuota, nNumCuotas, nDto, nTotCuota, nNewDeuda, nPago, nCargos, nAcuenta, nCod)

                    ' 📈 FLUIDEZ GRÁFICA EN TIEMPO REAL: Sincronización sin BackgroundWorker
                    nReg += 1
                    Me.ProgressBar1.Value = nReg
                    Me.Label2.Text = $"Actualizando registro {nReg} de {r}"

                    ' Windows pinta los labels en la pantalla al instante
                    Application.DoEvents()
                Next

                ' 🔥 ¡COMMIT FINAL!: Si todo el censo de la comisión se calculó bien, guardamos de golpe
                transaccion.Commit()

                ' 3. Transición visual de Éxito tras consolidar en la nube
                MsgBox("Todos los registros de cuotas y diferenciales de la comisión han sido actualizados con éxito.", MsgBoxStyle.Information, "COMPLETADO")

                Me.AsignarValoresFalleroCheckBox.Checked = True
                Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
                Me.BtnActualizar.Enabled = False
                Me.TxtNumRegistros.Text = "Total registros = " & nReg.ToString()
                Me.Label2.Text = "Actualización completada con éxito."

                Me.BtnSalir.Text = "Salir"
                Me.BtnSalir.Image = My.Resources.door_out
                Me.BtnSalir.Focus()

            Catch ex As Exception
                ' ❌ ABORTO: Si algo falla, el Rollback restaura todo el censo al estado anterior
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                MsgBox("Error crítico durante la actualización de cuotas medias. El proceso se ha cancelado y la base de datos NO sufrió modificaciones." & vbCrLf &
                   "Detalle técnico: " & ex.Message, MsgBoxStyle.Critical, "Proceso Cancelado")

                Me.Label2.Text = "Actualización cancelada por error"
                Me.ProgressBar1.Value = 0
                Me.BtnActualizar.Enabled = True ' Reactivamos para permitir el reintento
            Finally
                conexion.Close()
                Me.FalleroTableAdapter.Connection = New MySqlConnection(My.Settings.dbcensosConnectionString)
            End Try
        End Using

        ' 4. Refrescos finales visuales de las rejillas en pantalla (Fuera de la transacción)
        Try
            Me.FalleroTableAdapter.Fill(DataSetCuotas.fallero)
            Me.FalleroDataGridView.Refresh()
        Catch : End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
