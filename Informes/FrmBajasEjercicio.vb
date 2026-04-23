Public Class FrmBajasEjercicio

    Private Sub FrmBajasEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet11.Bajas' Puede moverla o quitarla según sea necesario.
        Me.BajasTableAdapter.Fill(Me.DbcensosDataSet11.Bajas)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class