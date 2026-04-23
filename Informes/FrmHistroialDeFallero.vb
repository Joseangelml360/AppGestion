Public Class FrmHistroialDeFallero
    Dim nCod, nCodFal As Integer

    Private Sub FrmHistroialDeFallero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.historfa' Puede moverla o quitarla según sea necesario.
        Me.historfaTableAdapter.Fill(Me.DbCensos.historfa)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        nCod = Val(Me.COD_JCFTextBox.Text)
        Me.historfaTableAdapter.FillByCodigo(Me.DbCensos.historfa, nCod)
        Me.DgvFalleros.Visible = False

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Me.DgvFalleros.Visible = True
        Me.FalleroTableAdapter.FillByApellidos(Me.DbCensos.fallero, Me.TxtBuscar.Text)
        Me.ReportViewer1.RefreshReport()
        'Me.DgvFalleros.Visible = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub DgvFalleros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFalleros.CellContentClick

        Me.DgvFalleros.Visible = True
        nCodFal = Val(Me.FALLERO_CODIGOTextBox.Text)
        Me.FalleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, nCodFal)
        nCod = Val(Me.COD_JCFTextBox.Text)

        Me.historfaTableAdapter.FillByCodigo(Me.DbCensos.historfa, nCod)
        Me.ReportViewer1.RefreshReport()

        Me.DgvFalleros.Visible = False

    End Sub
End Class