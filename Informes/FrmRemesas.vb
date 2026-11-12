Public Class FrmRemesas
    Private Sub FrmRemesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.FillRemesas(Me.ReportsDataSet.remesas)
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.remesas1' Puede moverla o quitarla según sea necesario.
        Me.remesas1TableAdapter.FillNumRemesas(Me.ReportsDataSet.remesas1, 1)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()

        Dim cId, cFecha, cItem As String
        Dim dt As DataTable = ReportsDataSet.remesas

        For i = 0 To dt.Rows.Count - 1
            cId = dt.Rows(i)("IdRemesa".ToString)
            cFecha = dt.Rows(i)("FechaCargo".ToString)
            cItem = cId & "  -  " & cFecha
            TsRemesaselect.Items.Add(cItem)
        Next

    End Sub

    Private Sub TsCajaTransf_Click(sender As Object, e As EventArgs) Handles TsCajaTransf.Click
        Me.remesas1TableAdapter.FillNumRemesas(Me.ReportsDataSet.remesas1, -1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()

    End Sub

    Private Sub TsRemesaselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TsRemesaselect.SelectedIndexChanged
        Me.remesas1TableAdapter.FillNumRemesas(Me.ReportsDataSet.remesas1, Me.TsRemesaselect.SelectedIndex + 1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TsTodas_Click(sender As Object, e As EventArgs) Handles TsTodas.Click
        Me.remesas1TableAdapter.FillByTodas(Me.ReportsDataSet.remesas1)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class