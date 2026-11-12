Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FrmAñadirCensoAHistorfa
    Private Sub FrmAñadirCensoAHistorfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        ' Carga inicial de datos de los TableAdapters
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSetFallero.recompensasejercicio)
        Me.CensoTableAdapter.FillCenso(Me.DataSetFallero.Censo)
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)

        ' Ajuste visual del estado del censo
        If Me.CopiarCensoAHistorialCheckBox.Checked = True Then
            Me.CopiarCensoAHistorialCheckBox.Text = "Copia efectuada"
            Me.CopiarCensoAHistorialCheckBox.Enabled = False
            Me.BtnCopiarCenso.Visible = False
        Else
            Me.CopiarCensoAHistorialCheckBox.Text = "Sin copiar"
            Me.CopiarCensoAHistorialCheckBox.Enabled = True
            Me.BtnCopiarCenso.Visible = True
        End If

        Me.ProgressBar1.Visible = False
    End Sub

    Private Sub BtnCopiarCenso_Click(sender As Object, e As EventArgs) Handles BtnCopiarCenso.Click
        ' 1. Validaciones previas visuales
        If Me.CopiarCensoAHistorialCheckBox.Checked = True Then
            MsgBox("Los registros ya han sido copiados, continúa con el siguiente paso", MsgBoxStyle.Information, "Información")
            Exit Sub
        End If

        Dim bExp As Boolean = True
        Dim bElim As Boolean = True
        Dim bCopiar As Boolean = True
        Dim nCodF, nRecJcf, nRecFal, nRecAgrup, nTotalCenso, n As Integer
        Dim nFal, nEje As Double

        Dim dtRecompensas As DataTable = DataSetFallero.recompensasejercicio
        nEje = Val(LblAnoCen.Text)
        n = dtRecompensas.Rows.Count - 1

        ' Inicialización de controles gráficos en pantalla
        Me.LblAcción.Visible = True
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = dtRecompensas.Rows.Count
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        Me.LblAcción.Text = "Añadiendo Censo actual a historial..."
        Me.lblBW.Text = "Iniciando proceso..."

        ' 🔥 Forzamos el redibujado inicial en la ventana
        Application.DoEvents()

        ' 2. Iniciamos el canal de conexión seguro con la transacción
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)
            Dim transaccion As MySqlTransaction = Nothing

            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' 🔥 Vinculamos de forma estricta todos los adaptadores a la transacción
                Me.HistorfaTableAdapter.Connection = conexion
                Me.EstadoTableAdapter.Connection = conexion
                Me.FalleroTableAdapter.Connection = conexion

                ' === PASO 1: Copiar registros generales a la tabla Historfa ===
                Me.HistorfaTableAdapter.InsertCensoFromFallero()
                Me.EstadoTableAdapter.UpdateEstadoFinalizar(bExp, bElim, bCopiar)

                nTotalCenso = Me.HistorfaTableAdapter.ScalarNumFalleros(nEje)

                ' === PASO 2: Procesamiento masivo de Recompensas del Ejercicio ===
                Me.LblAcción.Text = "Registrando recompensas en los falleros..."

                For i As Integer = 0 To n
                    ' Extraemos los datos de la fila del DataSet en memoria
                    nCodF = dtRecompensas.Rows(i)("CODFALLA")
                    nEje = dtRecompensas.Rows(i)("EJERCICIO")
                    nRecJcf = dtRecompensas.Rows(i)("RECJF")
                    nRecFal = dtRecompensas.Rows(i)("RECFALLA")
                    nRecAgrup = dtRecompensas.Rows(i)("RECAGRUP")

                    ' Ejecutamos las consultas de actualización (viajan en modo borrador seguro)
                    Me.HistorfaTableAdapter.UpdateRecompensas(nRecJcf, nRecFal, nRecAgrup, nCodF, nEje)
                    nFal = Me.FalleroTableAdapter.ScalarNumFalla(nCodF)

                    If nRecFal > 0 And nRecJcf > 0 Then
                        If nRecFal < 6 Then
                            Me.FalleroTableAdapter.UpdateRecomAñoTodas(nRecJcf, nEje, nFal, nRecFal, nCodF)
                        End If
                    ElseIf nRecFal > 0 And nRecJcf < 1 Then
                        If nRecFal < 6 Or nRecFal = 8 Then
                            Me.FalleroTableAdapter.UpdateRecomAñoFalla(nRecFal, nCodF)
                        End If
                    ElseIf nRecFal < 1 And nRecJcf > 0 Then
                        Me.FalleroTableAdapter.UpdateRecomAñoJCF(nRecJcf, nEje, nFal, nCodF)
                    End If

                    ' 📈 REFRESCO EN TIEMPO REAL: Actualizamos los controles con cada registro sin BackgroundWorker
                    Me.ProgressBar1.Value = i + 1
                    Me.lblBW.Text = $"Actualizando registro {i + 1} de {dtRecompensas.Rows.Count}"

                    ' 🔥 EL TRUCO MAGNÍFICO: Ordena a Windows pintar los labels en la pantalla al instante
                    Application.DoEvents()
                Next

                ' 🔥 ¡COMMIT FINAL!: Si todo el bucle termina con éxito, consolidamos el cierre en la nube de Aiven
                transaccion.Commit()

                ' Cambios visuales definitivos tras confirmar el éxito real en la BD
                MsgBox("Registros de Censo copiados a Historial con éxito de forma segura." & vbCrLf &
                       "Nº de falleros pasados a historial: " & nTotalCenso, MsgBoxStyle.Information, "Copia Finalizada")

                Me.lblBW.Text = "Actualización completada"
                Me.ProgressBar1.Visible = False
                Me.BtnSalir.Enabled = True
                Me.LblAcción.Text = "Historial y recompensas han sido actualizados, pulsa salir"
                Me.BtnSalir.Image = My.Resources.door_out
                Me.BtnSalir.Text = "Salir"

                Me.CopiarCensoAHistorialCheckBox.Checked = True
                Me.CopiarCensoAHistorialCheckBox.Text = "Censo copiado"
                Me.CopiarCensoAHistorialCheckBox.Enabled = False
                Me.BtnCopiarCenso.Visible = False

            Catch ex As Exception
                ' ❌ ABORTO ANTE FALLO: Si un registro da error, deshacemos el cierre de año por completo
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                bCopiar = False
                ' Intentamos registrar el fallo de copia de forma aislada
                Try : Me.EstadoTableAdapter.UpdateEstadoFinalizar(bExp, bElim, bCopiar) : Catch : End Try

                MsgBox("Error crítico, no se pudo realizar la acción de copiar registros de censo ni recompensas. La base de datos no fue modificada." & vbCrLf & "Detalle: " & ex.Message, MsgBoxStyle.Critical, "Error Grave")

                Me.lblBW.Text = "Actualización cancelada por error"
                Me.ProgressBar1.Value = 0
            Finally
                conexion.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
