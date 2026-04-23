Public Class FrmVerHistoricoRec
    Private Sub FrmVerHistoricoRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.CensoHistorico' Puede moverla o quitarla según sea necesario.
        Me.CensoHistoricoTableAdapter.FillByRecompensasEjercicio(Me.DataSet1.CensoHistorico, Val(Me.txtEjercicio.Text))

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtEjercicio_TextChanged(sender As Object, e As EventArgs) Handles txtEjercicio.TextChanged
        Me.CensoHistoricoTableAdapter.FillByRecompensasEjercicio(Me.DataSet1.CensoHistorico, Val(Me.txtEjercicio.Text))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class