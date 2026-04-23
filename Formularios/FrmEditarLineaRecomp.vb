Public Class FrmEditarLineaRecomp

    Private Sub FrmEditarLineaRecomp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.RecompensasAgrupacion' Puede moverla o quitarla según sea necesario.
        Me.RecompensasAgrupacionTableAdapter.Fill(Me.DbCensos.RecompensasAgrupacion)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.RecompensasFalla' Puede moverla o quitarla según sea necesario.
        Me.RecompensasFallaTableAdapter.Fill(Me.DbCensos.RecompensasFalla)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter1.Fill(Me.DbCensos.recompensas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DataSet1.recompensas)
        Dim nCodJCF As Integer
        nCodJCF = Val(Me.TxtCodFal.Text)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensasejercicio' Puede moverla o quitarla según sea necesario.
        Me.RecompensasejercicioTableAdapter.FillByRecFallero(Me.DataSet1.recompensasejercicio, nCodJCF)


    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CboRecFalla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboRecFalla.SelectedIndexChanged
        If Me.CboRecFalla.SelectedIndex.ToString <> "" Then
            Me.TxtRecFalla.Text = Me.CboRecFalla.SelectedValue

        End If
    End Sub

    Private Sub CboRecJCF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboRecJCF.SelectedIndexChanged
        If Me.CboRecJCF.SelectedIndex.ToString <> "" Then
            Me.TxtRecJCF.Text = Me.CboRecJCF.SelectedValue
        End If
    End Sub

    Private Sub CboRecAgrup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboRecAgrup.SelectedIndexChanged
        If Me.CboRecAgrup.SelectedItem.ToString <> "" Then
            Me.TxtRecAgrup.Text = Me.CboRecAgrup.SelectedValue
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim nRecFal, nRecJCF, nRecAgrup, nCodFal As Integer
        Dim nValoresJCF As Integer() = {0, 1, 2, 3, 4, 5, 11, 12, 13}
        Dim nValoresFalla As Integer() = {0, 1, 2, 3, 4, 6, 7}
        Dim nValoresAgrup As Integer() = {0, 1, 2, 3, 6}
        nRecFal = Val(Me.TxtRecFalla.Text)
        nRecJCF = Val(Me.TxtRecJCF.Text)
        nRecAgrup = Val(Me.TxtRecAgrup.Text)
        nCodFal = Val(Me.TxtCodFal.Text)


        'VAlidación de datos
        If Not nValoresFalla.Contains(nRecFal) Then
            MsgBox("No existe la recompensa de falla asignada")
            Exit Sub
        End If

        If Not nValoresJCF.Contains(nRecJCF) Then

            MsgBox("No existe la recompensa de JCF asignada")
            Exit Sub
        End If

        If Not nValoresAgrup.Contains(nRecAgrup) Then
            MsgBox("No existe la recompensa de Agrupación asignada")
            Exit Sub
        End If

        Try
            Me.RecompensasejercicioTableAdapter.UpdateQueryRec(nRecJCF, nRecFal, nRecAgrup, nCodFal)
            MsgBox("Guardado")

            Exit Sub
        Catch ex As Exception
            MsgBox("Ha ocurrido un error y no se ha guardado el registro")
        End Try
    End Sub
End Class