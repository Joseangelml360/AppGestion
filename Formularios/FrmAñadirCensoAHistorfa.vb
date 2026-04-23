Imports System.ComponentModel


Public Class FrmAñadirCensoAHistorfa
    Private Const V As Boolean = True
    Public nRow As Integer

    Private Sub FrmAñadirCensoAHistorfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True

        AddHandler BackgroundWorker1.DoWork, AddressOf BackgroundWorker1_DoWork
        AddHandler BackgroundWorker1.ProgressChanged, AddressOf BackgroundWorker1_ProgressChanged
        AddHandler BackgroundWorker1.RunWorkerCompleted, AddressOf BackgroundWorker1_RunWorkerCompleted

        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.recompensasejercicio' Puede moverla o quitarla según sea necesario.
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSetFallero.recompensasejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.Censo' Puede moverla o quitarla según sea necesario.
        Me.CensoTableAdapter.FillCenso(Me.DataSetFallero.Censo)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        'Todo esta línea de código carga datos en la tabla 'DatasSetFallero.recompensasejercicio'


        If Me.CopiarCensoAHistorialCheckBox.Checked = True Then
            Me.CopiarCensoAHistorialCheckBox.Text = "Copia efectuada"
            Me.CopiarCensoAHistorialCheckBox.Enabled = False
        Else
            Me.CopiarCensoAHistorialCheckBox.Text = "Sin copiar"
            Me.CopiarCensoAHistorialCheckBox.Enabled = True
        End If

        Dim dt As DataTable = Me.DataSetFallero.Censo
        Dim c As Integer = dt.Rows.Count
        Me.ProgressBar1.Visible = False


    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)

        If e.Cancelled Then
            lblBW.Text = "Actualización cancelada"
        ElseIf e.Error IsNot Nothing Then
            lblBW.Text = "Error durante la actualización"
        Else
            lblBW.Text = "Actualización completada"
            Me.ProgressBar1.Visible = False
            Me.BtnSalir.Enabled = True
            Me.LblAcción.Text = "Historial y recompensas han sido actualizados, pulsa salir"
            Me.BtnSalir.Image = My.Resources.door_out
            Me.BtnSalir.Text = "Salir"

            CopiarCensoAHistorialCheckBox.Checked = True
            Me.CopiarCensoAHistorialCheckBox.Text = "Censo copiado"
            Me.CopiarCensoAHistorialCheckBox.Enabled = False
            Me.BtnCopiarCenso.Visible = False

        End If


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)

        ProgressBar1.Value += 1
        Me.lblBW.Text = CType(e.UserState, String)
        If nRow > 1 Then
            Me.LblAcción.Text = "Registrando recompensas . . ."
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)


        Dim bExp, bElim, bCopiar As Boolean
        Dim nCodF, nRecJcf, nRecFal, nRecAgrup, nTotalCenso, n As Integer
        Dim nFal, nEje As Double
        Dim dt As DataTable = DataSetFallero.recompensasejercicio
        nEje = Val(LblAnoCen.Text)
        n = dt.Rows.Count - 1

        If Me.CopiarCensoAHistorialCheckBox.Checked = False Then

            Try
                bExp = True
                bElim = True
                bCopiar = True
                HistorfaTableAdapter.InsertCensoFromFallero()
                Me.EstadoTableAdapter.UpdateEstadoFinalizar(bExp, bElim, bCopiar)
                nTotalCenso = HistorfaTableAdapter.ScalarNumFalleros(nEje)
                MsgBox("Registros de Censo copiados a Historial. " & "Nº de falleros pasados a historial: " & nTotalCenso, 64, "Copia de CENSO a Historial")

            Catch ex As Exception

                MsgBox("Error, no se pudo realizar la acción de copiar registros", 16, "Error grave")
                bCopiar = False
                Me.EstadoTableAdapter.UpdateEstadoFinalizar(bExp, bElim, bCopiar)
                Exit Sub

            End Try

        Else
            MsgBox("Los registros ya han sido copiados, continúa con el siguiente paso")
        End If

        nRow = 1
        For i = 0 To n
            If BackgroundWorker1.CancellationPending Then
                e.Cancel = True
                Exit For
            End If

            nCodF = dt.Rows(i)("CODFALLA".ToString)
            nEje = dt.Rows(i)("EJERCICIO".ToString)
            nRecJcf = dt.Rows(i)("RECJF".ToString)
            nRecFal = dt.Rows(i)("RECFALLA".ToString)
            nRecAgrup = dt.Rows(i)("RECAGRUP".ToString)

            Try
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

            Catch EX As Exception
                MsgBox("Error, no se pudo realizar la acción de añadir recompensas")
            End Try

            nRow += 1
            BackgroundWorker1.ReportProgress(i, $"Actualizando registro {i} de {n}")
        Next

    End Sub

    Private Sub BtnCopiarCenso_Click(sender As Object, e As EventArgs) Handles BtnCopiarCenso.Click

        Me.LblAcción.Visible = True
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = Me.CensoDataGridView.Rows.Count
        Me.ProgressBar1.Value = 1
        Me.ProgressBar1.Visible = True
        Me.LblAcción.Text = "Añadiendo Censo actual a historial"

        If Not BackgroundWorker1.IsBusy Then
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


End Class