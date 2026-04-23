Public Class FrmFallerosDescuentoFamilia
    Private Sub FrmFallerosDescuentoFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.fallero' Puede moverla o quitarla según sea necesario.
        Me.falleroTableAdapter.FillByDescuentosPorFamilia(Me.ReportsDataSet.fallero)
        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet1.Bajas' Puede moverla o quitarla según sea necesario.
        Me.BajasTableAdapter.Fill(Me.dbcensosDataSet1.Bajas)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class