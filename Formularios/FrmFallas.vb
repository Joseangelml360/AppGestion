Public Class FrmFallas
    Private Sub FrmFallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallas' Puede moverla o quitarla según sea necesario.
        Me.FallasTableAdapter.Fill(Me.DbCensos.fallas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Me.FallasTableAdapter.FillByNombre(Me.DbCensos.fallas, TextBox1.Text)
        Catch ex As Exception
            MsgBox("No se ha encontrado")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FallasTableAdapter.Fill(Me.DbCensos.fallas)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.FallasTableAdapter.UpdateFalla(Me.DESFALTextBox.Text, Val(Me.NUMFALTextBox.Text))
            MsgBox("Actualizada Falla: " & NUMFALTextBox.Text)
        Catch ex As Exception
            MsgBox("No se pudo actualizar registro")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each c As Control In GroupBox1.Controls
            c.Enabled = False
        Next

        For Each c As Control In GroupBox2.Controls
            c.Visible = True
        Next

        Me.TxtNumFal.Text = FallasTableAdapter.ScalarUltFalla() + 1
        Me.TxtDesFal.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.TxtDesFal.Text = Nothing Then
            MsgBox("Hay que poner un nombre a la nueva Falla")
            Exit Sub
        Else
            Try
                FallasTableAdapter.InsertFalla(Val(Me.TxtNumFal.Text), Me.TxtDesFal.Text)
                MsgBox("Se ha añadido nuevo registro en Fallas")
            Catch ex As Exception
                MsgBox("Error al añadir nueva Falla")
            End Try
            For Each c As Control In GroupBox1.Controls
                c.Enabled = True
            Next
            For Each c As Control In GroupBox2.Controls
                c.Visible = False
            Next
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TxtDesFal.Text = ""
        Me.TxtNumFal.Text = ""
        For Each c As Control In GroupBox1.Controls
            c.Enabled = True
        Next
        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next
    End Sub

End Class