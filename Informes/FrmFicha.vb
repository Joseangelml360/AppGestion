Public Class FrmFicha
    Private Sub FrmFicha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
End Class