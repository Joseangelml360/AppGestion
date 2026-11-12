Public Class FrmAcreedores
    Private Sub FrmAcreedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.Deudores' Puede moverla o quitarla según sea necesario.
        Me.DeudoresTableAdapter.FillByAcreedores(Me.ReportsDataSet.Deudores)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class