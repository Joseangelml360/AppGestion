Public Class FrmConsolidar
    Private Sub FrmConsolidar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Fallero1' Puede moverla o quitarla según sea necesario.
        Me.Fallero1TableAdapter.Fill(Me.DataSet1.Fallero1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.Detalles_de_remesaTableAdapter.FillByConsolidar(Me.DataSet1.detalles_de_remesa)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.ConsolidarRemesaCheckBox.Checked = True Then
            Me.Label1.Text = "Consolidada"
        Else
            Me.Label1.Text = " Sin consolidar"
        End If
        Me.ConsolidarRemesaCheckBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Dim nCod, nRecDev, nOtrosCargos, nAcuenta, nPagos, nAbonoBenefi, nDeuda As Double
        Dim nFalleRecDev, nFalleOtroscargos, nFalleAcuenta, nFallePago, nFalleNumPagos, nFalleDevBenefi, nFalleBenefi As Double
        Dim r As Integer = 0
        Dim Dgv, Dgv1 As New DataGridView
        Dgv = Me.Detalles_de_remesaDataGridView
        Dgv1 = Me.FALLERO1DataGridView
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = Dgv.Rows.Count

        For Each row As DataGridViewRow In Dgv.Rows
            Me.ProgressBar1.Value += 1
            nCod = row.Cells(0).Value
            nPagos = row.Cells(1).Value
            nOtrosCargos = row.Cells(2).Value
            nAcuenta = row.Cells(3).Value
            nRecDev = row.Cells(4).Value
            nAbonoBenefi = row.Cells(5).Value
            Me.Fallero1TableAdapter.FillRemesaByCodigo(Me.DataSet1.Fallero1, nCod)
            Dgv1.Refresh()
            nFalleBenefi = Dgv1.CurrentRow.Cells(1).Value
            nFalleDevBenefi = Dgv1.CurrentRow.Cells(2).Value + nAbonoBenefi
            nFalleRecDev = Dgv1.CurrentRow.Cells(3).Value - nRecDev
            nFalleOtroscargos = Dgv1.CurrentRow.Cells(4).Value - nOtrosCargos
            nFalleAcuenta = Dgv1.CurrentRow.Cells(5).Value - nAcuenta
            nFallePago = Dgv1.CurrentRow.Cells(6).Value
            nFalleNumPagos = Dgv1.CurrentRow.Cells(7).Value - nPagos
            nDeuda = nFallePago * nFalleNumPagos + nFalleOtroscargos - (nFalleBenefi - nFalleDevBenefi) - nFalleAcuenta
            Try
                Fallero1TableAdapter.UpdateRemesa(nFalleDevBenefi, nFalleRecDev, nFalleOtroscargos, nFalleAcuenta,
                                                    nFalleNumPagos, nDeuda, nCod)
            Catch ex As Exception
                MsgBox("Error, remesa no consolidada")
                Exit Sub
            End Try
            Me.FALLERO1DataGridView.Refresh()
        Next

        MsgBox("remesa consolidada con éxito")
        Me.EstadoTableAdapter.UpdateConsolidar(True)
        Me.ConsolidarRemesaCheckBox.Checked = True
        Me.Label1.Text = "Consolidada"
        Me.BtnEjecutar.Enabled = False
        Me.BtnSalir.Focus()
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.Image = My.Resources.door_out

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class