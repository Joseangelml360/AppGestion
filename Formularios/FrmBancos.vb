Public Class FrmBancos
    Private Sub FrmBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.banco_remesa' Puede moverla o quitarla según sea necesario.
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.Banco_remesaTableAdapter.Fill(Me.DbCensos.banco_remesa)
        Me.BtnCancelar.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Me.Validate()
        Me.BancoremesaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbCensos)
        Me.DbCensos.AcceptChanges()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click

        If Me.BtnAñadir.Text = "Añadir Nuevo" Then
            Dim text As Object
            For Each text In GroupBox1.Controls
                If TypeOf text Is TextBox Then
                    Dim txtTemp As TextBox = CType(text, TextBox)
                    txtTemp.Clear()
                End If
            Next

            For Each text In GroupBox2.Controls
                If TypeOf text Is TextBox Then
                    Dim txtTemp As TextBox = CType(text, TextBox)
                    txtTemp.Clear()
                End If
            Next

            Me.IdTextBox.Text = Banco_remesaTableAdapter.ScalarUltimoId() + 1
            Me.BancoTextBox.Text = ""
            Me.SufOrdTextBox.Text = Nothing
            Me.EntOrdTextBox.Text = Nothing
            Me.OfOrdTextBox.Text = Nothing
            Me.DCOrdTextBox.Text = Nothing
            Me.CuentaOrdTextBox.Text = Nothing
            Me.SufPresTextBox.Text = Nothing
            Me.EntPresTextBox.Text = Nothing
            Me.EntPresTextBox.Text = Nothing
            Me.OfPresTextBox.Text = Nothing
            Me.BtnCancelar.Visible = True
            Me.BtnEditar.Enabled = False
            Me.BtnAñadir.Text = "Guardar"
            Exit Sub
        End If

        If Me.BtnAñadir.Text = "Guardar" Then

            Dim nId As Decimal
            Dim cOSuf, cOEnt, cOOfi, cODC, cOCta, cPsuf, cPEnt, cPOfi As String
            Dim cBan, cOrd, cLoc, cPres, cOCIF, cPCIF As String

            nId = Val(Me.IdTextBox.Text)
            cOSuf = Me.SufOrdTextBox.Text
            cOEnt = Me.EntOrdTextBox.Text
            cOOfi = Me.OfOrdTextBox.Text
            cODC = Me.DCOrdTextBox.Text
            cOCta = Me.CuentaOrdTextBox.Text
            cPsuf = Me.SufPresTextBox.Text
            cPEnt = Me.EntPresTextBox.Text
            cPOfi = Me.OfPresTextBox.Text
            cOCIF = Me.CIFTextBox.Text
            cBan = Me.BancoTextBox.Text
            cOrd = Me.OrdenanteTextBox.Text
            cLoc = Me.LocalidadTextBox.Text
            cPres = Me.Nombre_PresTextBox.Text
            cPCIF = Me.CIFPresTextBox.Text

            Try
                Me.Banco_remesaTableAdapter.InsertBanco(nId, cBan, cOrd, cOCIF, cOSuf, cOEnt, cOOfi,
                                           cODC, cOCta, cLoc, cPCIF, cPsuf, cPres, cPEnt, cPOfi)
                MsgBox("Registro añadido")
                Me.Banco_remesaTableAdapter.Fill(Me.DbCensos.banco_remesa)
                Me.BtnAñadir.Text = "Añadir"
                Me.BtnCancelar.Visible = False

            Catch ex As Exception
                MsgBox("Error: revise datos introducidos, no se ha podido añadir registro")
            End Try

        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Banco_remesaTableAdapter.Fill(Me.DbCensos.banco_remesa)
        Me.BtnCancelar.Visible = False
        Me.BtnAñadir.Text = "Añadir Nuevo"
        Me.BtnEditar.Enabled = True
    End Sub

End Class