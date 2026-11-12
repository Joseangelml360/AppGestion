Public Class FrmFallerosSinBanco
    Private Sub FalleroSinBancoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FalleroSinBancoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReportsDataSet)

    End Sub

    Private Sub FrmFallerosSinBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.falleroSinBanco' Puede moverla o quitarla según sea necesario.
        Me.FalleroSinBancoTableAdapter.FillBySinBanco(Me.ReportsDataSet.falleroSinBanco)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class