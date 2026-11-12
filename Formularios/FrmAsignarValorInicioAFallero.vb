Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FrmAsignarValorInicioAFallero
    Public nReg As Integer

    Private Sub FrmAsignarValorInicioAFallero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carga inicial de configuraciones y tablas desde Aiven
        Me.EjercicioTableAdapter.Fill(Me.DataSetCuotas.ejercicio)
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.FalleroTableAdapter.Fill(Me.DataSetCuotas.fallero)

        Me.AsignarValoresFalleroCheckBox.Enabled = False
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        ' Validación visual inicial de bloqueo preventivo
        If Me.AsignarValoresFalleroCheckBox.Checked = True Then
            Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
            MsgBox("Los valores nuevos de cuota ya han sido asignados.", MsgBoxStyle.Information, "Información")
            Me.BtnActualizar.Enabled = False
            Me.BtnSalir.Focus()
        Else
            Me.BtnActualizar.Enabled = True
        End If

        Me.ProgressBar1.Visible = False
        Me.TxtNumRegistros.Visible = False
        Me.Label2.Text = ""
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim nNumCuotas, nAnoCen As Integer
        Dim nCod, nNumCuotasFila, nNumPagos, nRec As Integer
        Dim nValCuota, nDto, nPago, nTotCuota, nCargos, nAbonos, nDeuda, nAcuenta, nBenef As Double

        Dim dtFalleros As DataTable = Me.DataSetCuotas.fallero
        Dim r As Integer = dtFalleros.Rows.Count

        If r = 0 Then
            MsgBox("No hay registros de falleros activos para procesar.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        ' Interfaz gráfica inicial
        Me.BtnActualizar.Enabled = False
        Me.TxtNumRegistros.Visible = True
        nNumCuotas = Val(Me.NumcuotasmesTextBox.Text)
        nAnoCen = Val(Me.AñoejeTextBox.Text)

        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = r
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        Me.Label2.Visible = True
        Me.Label2.Text = "Iniciando actualización masiva..."

        ' Forzamos el pintado inicial de la interfaz
        Application.DoEvents()

        ' 1. Abrimos conexión y transacción atómica con la nube de Aiven
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)
            Dim transaccion As MySqlTransaction = Nothing

            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' 🔥 Vinculamos los adaptadores al canal de la transacción
                Me.FalleroTableAdapter.Connection = conexion
                Me.EstadoTableAdapter.Connection = conexion

                ' Ejecutamos los reseteos masivos iniciales (Borrador seguro)
                Me.FalleroTableAdapter.UpdateNumPagos()  ' Pagos a cero
                Me.FalleroTableAdapter.UpdateNumCuotas(nNumCuotas, nNumCuotas, "MENSUAL")
                Me.FalleroTableAdapter.UpdateNumCuotas(1, 1, "ANUAL")
                Me.FalleroTableAdapter.UpdateAnoCen(nAnoCen)

                ' Volvemos a cargar internamente el buffer de datos bajo la transacción activa
                Me.FalleroTableAdapter.Fill(DataSetCuotas.fallero)

                ' 2. 🔥 PROCESAMIENTO OPTIMIZADO: Recorremos las filas directamente en memoria RAM
                nReg = 0
                For i As Integer = 0 To r - 1
                    Dim fila As DataRow = dtFalleros.Rows(i)

                    ' Extraemos los valores de las columnas directamente del DataSet
                    nCod = Val(fila("FALLERO_CODIGO"))
                    nValCuota = Val(fila("CUOTA"))
                    nDto = Val(fila("ValorDto"))
                    nNumCuotasFila = Val(fila("NUM_CUOTAS"))
                    nNumPagos = Val(fila("NUM_PAGOS"))

                    nBenef = Val(fila("BENEFICIOS")) - Val(fila("DEV_BENEFI"))
                    nCargos = Val(fila("OtrosCargos")) + Val(fila("DEUDA"))
                    nAcuenta = Val(fila("A_CUENTA"))
                    nRec = Val(fila("RECDEV"))

                    nAbonos = nBenef + nAcuenta

                    If nNumPagos > 0 Then
                        nCargos = Val(fila("DEUDA"))
                        nAbonos = 0
                    End If

                    nPago = Math.Round(nValCuota * (1 - nDto / 100), 2)
                    nTotCuota = nPago * nNumCuotasFila
                    nDeuda = nTotCuota + nCargos - nAbonos
                    nAcuenta = nAbonos

                    If nCargos < 0 Then
                        nAcuenta = -nCargos
                        nCargos = 0
                    End If

                    ' Ejecutamos la consulta individual (viaja cifrada en ráfaga a Aiven)
                    Me.FalleroTableAdapter.UpdateCuotas(nValCuota, nNumCuotasFila, nDto, nTotCuota, nDeuda, nPago, nCargos, nAcuenta, nCod)

                    ' 📈 CONTROL GRÁFICO EN TIEMPO REAL: Actualización fluida sin BackgroundWorker
                    nReg += 1
                    Me.ProgressBar1.Value = nReg
                    Me.Label2.Text = $"Actualizando registro {nReg} de {r}"

                    ' 🔥 EL TRUCO MAGNÍFICO: Ordena a Windows redibujar la pantalla al instante
                    Application.DoEvents()
                Next

                ' Actualizamos el estado global del indicador de cambio en el servidor
                Me.EstadoTableAdapter.UpdateEstadoValoresFallero()

                ' 🔥 ¡COMMIT FINAL!: Si el bucle procesó todos los socios sin caídas, consolidamos todo de golpe
                transaccion.Commit()

                ' 3. Transición visual de Éxito (SOLO si la base de datos se guardó)
                Me.AsignarValoresFalleroCheckBox.Checked = True
                Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
                Me.Label2.Text = "Actualización completada con éxito de forma segura."
                Me.TxtNumRegistros.Text = "Total registros = " & nReg.ToString()

                MsgBox("Todos los valores de inicio se han asignado correctamente a los falleros.", MsgBoxStyle.Information, "COMPLETADO")

                Me.BtnSalir.Text = "Salir"
                Me.BtnSalir.Image = My.Resources.door_out
                Me.BtnSalir.Focus()

            Catch ex As Exception
                ' ❌ ABORTO COMPLETO: Si hay un error, el Rollback deja las deudas tal y como estaban antes de empezar
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                MsgBox("Error crítico durante la asignación de cuotas. El proceso se ha cancelado y la base de datos NO sufrió modificaciones." & vbCrLf &
                       "Detalle técnico: " & ex.Message, MsgBoxStyle.Critical, "Proceso Cancelado")

                Me.Label2.Text = "Actualización cancelada por error"
                Me.ProgressBar1.Value = 0
                Me.BtnActualizar.Enabled = True ' Reactivamos para permitir el reintento
            Finally
                conexion.Close()
            End Try
        End Using

        ' 4. Refrescos finales visuales de las rejillas en pantalla (Fuera de la transacción)
        Try
            Me.FalleroTableAdapter.Fill(DataSetCuotas.fallero)
            Me.FALLERODataGridView.Refresh()
            Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Catch : End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
