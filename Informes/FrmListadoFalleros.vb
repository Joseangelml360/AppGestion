Public Class FrmListadoFalleros
    Private Sub FrmListadoFalleros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.FalleroComisionTableAdapter.Fill(Me.DataSetFallero.FalleroComision)
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.FalleroComisionTableAdapter.FillListadoFalleros(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
    End Sub

    Private Sub TSTodos_Click(sender As Object, e As EventArgs) Handles TSTodos.Click
        Me.FalleroComisionTableAdapter.FillListadoFalleros(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSMayores_Click(sender As Object, e As EventArgs) Handles TSMayores.Click
        Me.FalleroComisionTableAdapter.FillByMayores(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSInfantiles_Click(sender As Object, e As EventArgs) Handles TSInfantiles.Click
        Me.FalleroComisionTableAdapter.FillByInfantiles(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSMujeres_Click(sender As Object, e As EventArgs) Handles TSMujeres.Click
        Me.FalleroComisionTableAdapter.FillByMujeres(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSNiñas_Click(sender As Object, e As EventArgs) Handles TSNiñas.Click
        Me.FalleroComisionTableAdapter.FillByNiñas(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSHombres_Click(sender As Object, e As EventArgs) Handles TSHombres.Click
        Me.FalleroComisionTableAdapter.FillByHombres(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSNiños_Click(sender As Object, e As EventArgs) Handles TSNiños.Click
        Me.FalleroComisionTableAdapter.FillByNiños(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSCerrar_Click(sender As Object, e As EventArgs) Handles TSCerrar.Click
        Me.Close()

    End Sub

    Private Sub TSJuveniles_Click(sender As Object, e As EventArgs) Handles TSJuveniles.Click
        Me.FalleroComisionTableAdapter.FillByJuveniles(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class