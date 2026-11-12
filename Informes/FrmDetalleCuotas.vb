Public Class FrmDetalleCuotas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmDetalleCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.fallero' Puede moverla o quitarla según sea necesario.
        Me.falleroTableAdapter.Fill(Me.DataSetCuotas.fallero)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class