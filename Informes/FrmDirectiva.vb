Public Class FrmDirectiva
    Private Sub FrmDirectiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.JuntaDirectiva' Puede moverla o quitarla según sea necesario.
        Me.JuntaDirectivaTableAdapter.FillJuntaDirectiva(Me.DataSetFallero.JuntaDirectiva, 1)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSMayores_Click(sender As Object, e As EventArgs) Handles TSMayores.Click
        Me.JuntaDirectivaTableAdapter.FillJuntaDirectiva(Me.DataSetFallero.JuntaDirectiva, 1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSInfantiles_Click(sender As Object, e As EventArgs) Handles TSInfantiles.Click
        Me.JuntaDirectivaTableAdapter.FillJuntaDirectiva(Me.DataSetFallero.JuntaDirectiva, 2)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSCerrar_Click(sender As Object, e As EventArgs) Handles TSCerrar.Click
        Me.Close()

    End Sub
End Class