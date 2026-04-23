Public Class FrmBenefLot
    Private Sub FrmBenefLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.fallero' Puede moverla o quitarla según sea necesario.
        Me.falleroTableAdapter.FillByBenefLot(Me.ReportsDataSet.fallero)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TsCerrar_Click(sender As Object, e As EventArgs) Handles TsCerrar.Click
        Me.Close()
    End Sub
End Class