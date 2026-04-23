Public Class FrmVerPagos
    Private Sub FrmVerPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nCod As Integer
        nCod = Val(Me.CODIGOTextBox.Text)
        ''TODO: esta línea de código carga datos en la tabla 'DbCensos.remesas' Puede moverla o quitarla según sea necesario.
        'Me.RemesasTableAdapter.Fill(Me.DbCensos.remesas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensosDataSet._Remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.FillByCodigo(Me.DbCensos.remesas, nCod)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnVerGrupo.Click
        Me.RemesasTableAdapter.FillByTitular(Me.DbCensos.remesas, Me.TITULARTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnVerFallero.Click
        Dim nCod As Integer
        nCod = Val(Me.CODIGOTextBox.Text)
        Me.RemesasTableAdapter.FillByCodigo(Me.DbCensos.remesas, nCod)

    End Sub

End Class