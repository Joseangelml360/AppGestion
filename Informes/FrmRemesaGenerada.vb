Public Class FrmRemesaGenerada
    Private Sub FrmRemesaGenerada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.detalles_de_remesa' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_remesaTableAdapter.Fill(Me.DataSet1.detalles_de_remesa)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CerrarInformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarInformeToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class