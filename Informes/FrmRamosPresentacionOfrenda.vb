Public Class FrmRamosPresentacionOfrenda
    Private Sub FrmRamosPresentacionOfrenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.FalleroComisionTableAdapter.FillByMujeres(Me.DataSetFallero.FalleroComision)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSCerrar_Click(sender As Object, e As EventArgs) Handles TSCerrar.Click
        Me.Close()
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        Me.FalleroComisionTableAdapter.FillByNiñas(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        Me.FalleroComisionTableAdapter.FillByMujeres(Me.DataSetFallero.FalleroComision)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class