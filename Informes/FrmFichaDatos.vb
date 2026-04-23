Public Class FrmFichaDatos
    Dim nCod, nCodFal As Integer
    Private Sub FrmFichaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.falleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        nCod = Val(Me.COD_JCFTextBox.Text)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.historfa' Puede moverla o quitarla según sea necesario.
        Me.historfaTableAdapter.FillByCodigoEjeASC(Me.DbCensos.historfa, nCod)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Me.DataGridView1.Visible = True
        Me.DataGridView1.Height = 350
        Me.falleroTableAdapter.FillByApellidos(Me.DbCensos.fallero, Me.TxtBuscar.Text)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Me.DataGridView1.Visible = False
        nCodFal = Val(Me.FALLERO_CODIGOTextBox.Text)
        Me.falleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, nCodFal)
        nCod = Val(Me.COD_JCFTextBox.Text)

        Me.historfaTableAdapter.FillByCodigoEjeASC(Me.DbCensos.historfa, nCod)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class