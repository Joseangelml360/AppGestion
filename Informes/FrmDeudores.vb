Public Class Deudores
    Private Sub FrmDeudores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.Deudores' Puede moverla o quitarla según sea necesario.
        Me.DeudoresTableAdapter.UpdateDeuda()
        Me.DeudoresTableAdapter.FillDeudores(Me.ReportsDataSet.Deudores)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        Dim nNum As Integer
        nNum = Val(Me.ToolStripTextBox1.Text) + 1
        Me.DeudoresTableAdapter.FillDeudoresByMesesDeuda(Me.ReportsDataSet.Deudores, nNum, nNum)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim nNum As Integer
        nNum = Val(Me.ToolStripTextBox1.Text) + 1
        Me.DeudoresTableAdapter.FillDeudoresByMesesDeuda(Me.ReportsDataSet.Deudores, nNum, nNum)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class