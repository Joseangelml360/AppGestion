Public Class FrmFallerosConLoteria
    Private Sub FrmFallerosConLoteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFallero.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.FalleroComisionTableAdapter.Fill(Me.DataSetFallero.FalleroComision)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TsCerrar_Click(sender As Object, e As EventArgs) Handles TsCerrar.Click
        Me.Close()
    End Sub
End Class