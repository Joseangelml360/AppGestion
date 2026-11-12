Public Class FrmActualizarCuenta
    Private Sub FrmActualizarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.Titulares' Puede moverla o quitarla según sea necesario.
        Me.TitularesTableAdapter.Fill(Me.DataSetCuotas.Titulares)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cTitular, cCuenta As String
        cTitular = Me.TITULARTextBox.Text
        cCuenta = Me.MaskedTextBox1.Text.Replace(" ", "")

        ' Comprobar si el IBAN es válido
        Dim sCta As String = cCuenta
        Dim result As Boolean
        If Len(sCta) < 12 Then
            MsgBox("La longitud de la cuenta no es correcta. Introduce un valor correcto.")
            Me.MaskedTextBox1.Focus()
            Exit Sub
        End If

        result = funciones.ValidarIBAN(sCta)

        If result = "False" Then
            MsgBox("El IBAN No es válido." & vbCrLf & "La cuenta no es correcta.")
            Me.MaskedTextBox1.Focus()
            Exit Sub
        End If

        'Guardar valores nuevos
        Try
            Me.TitularesTableAdapter.UpdateCuentaBanco(cCuenta, cTitular)
            MsgBox("Registro actualizado")
            Me.MaskedTextBox1.Text = ""
            Me.TitularesTableAdapter.Fill(Me.DataSetCuotas.Titulares)
            Me.TitularesDataGridView.Refresh()
        Catch ex As Exception
            MsgBox("Error al actualizar la cuenta")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Me.TitularesTableAdapter.FillByTitular(Me.DataSetCuotas.Titulares, TextBox1.Text)
        Catch ex As Exception
            MsgBox("Error en la búsqueda de Titular")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TitularesTableAdapter.Fill(Me.DataSetCuotas.Titulares)
    End Sub

End Class