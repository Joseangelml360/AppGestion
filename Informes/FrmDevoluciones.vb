Public Class FrmDevoluciones
    Private Sub FrmDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.Devoluciones' Puede moverla o quitarla según sea necesario.
        Me.DevolucionesTableAdapter.FillDevolucion(Me.ReportsDataSet.Devoluciones)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class