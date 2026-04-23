Public Class FrmListadoPorFamilias
    Private Sub FrmListadoPorFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.FalleroComisionTableAdapter.Fill(Me.DataSetFallero.FalleroComision)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class