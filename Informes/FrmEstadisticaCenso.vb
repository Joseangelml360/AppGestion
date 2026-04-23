Public Class FrmEstadisticaCenso
    Private Sub FrmEstadisticaCenso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.CensoHistorico' Puede moverla o quitarla según sea necesario.
        Me.CensoHistoricoTableAdapter.Fill(Me.DataSet1.CensoHistorico)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()

    End Sub
End Class