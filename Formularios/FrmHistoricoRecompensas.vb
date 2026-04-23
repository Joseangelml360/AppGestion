Public Class FrmHistoricoRecompensas
    Private Sub FrmRecompensasEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter.Fill(Me.DataSet1.historfa)
        Me.TxtEjercicio.Text = Year(Today) - 1
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.CensoHistorico' Puede moverla o quitarla según sea necesario.
        Me.CensoHistoricoTableAdapter.FillByRecompensasEjercicio(Me.DataSet1.CensoHistorico, Val(Me.TxtEjercicio.Text))
        Me.TxtRecJCF.Text = Me.HistorfaTableAdapter.ScalarRecJCFbyYear(Val(Me.TxtEjercicio.Text))
        Me.TxtRecFalla.Text = Me.HistorfaTableAdapter.ScalarRecFallaByYear(Val(Me.TxtEjercicio.Text))

    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If IsNumeric(CType(Me.TxtEjercicio.Text, Integer)) Then
            Try
                Me.CensoHistoricoTableAdapter.FillByRecompensasEjercicio(Me.DataSet1.CensoHistorico, Val(Me.TxtEjercicio.Text))
                Me.DgvHistoricoRec.Refresh()
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        Me.TxtRecJCF.Text = Me.HistorfaTableAdapter.ScalarRecJCFbyYear(Val(Me.TxtEjercicio.Text))
        Me.TxtRecFalla.Text = Me.HistorfaTableAdapter.ScalarRecFallaByYear(Val(Me.TxtEjercicio.Text))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FrmVerHistoricoRec
        frm.txtEjercicio.Text = Val(Me.TxtEjercicio.Text)
        frm.Show()
    End Sub
End Class