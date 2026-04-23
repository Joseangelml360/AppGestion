Public Class FrmRecompensas
    Private Sub FrmRecompensas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DbCensos.recompensas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim cDesRec As String
        Dim nRecom As Integer
        Dim nTipfal As Double
        cDesRec = Me.RecompensaTxt.Text
        nRecom = (Me.IdText.Text)
        nTipfal = Val(Me.ComisionTxt.Text)
        Try
            Me.RecompensasTableAdapter.UpdateRecompensa(cDesRec, nTipfal, nRecom)
            MsgBox("Registro actualizado")
            Me.RecompensasTableAdapter.Fill(Me.DbCensos.recompensas)
            Me.RecompensasDataGridView.Refresh()
        Catch ex As Exception
            MsgBox("Error al actualizar, no se guardaron los cambios")
        End Try

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        For Each c As Control In GroupBox1.Controls
            c.Enabled = False
        Next

        For Each c As Control In GroupBox2.Controls
            c.Visible = True
        Next

        Me.TxtID.Text = ""
        Me.TxtRecompensa.Text = ""
        Me.TxtComision.Text = ""
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.TxtID.Text = ""
        Me.TxtRecompensa.Text = ""
        Me.TxtComision.Text = ""
        For Each c As Control In GroupBox1.Controls
            c.Enabled = True
        Next
        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Dim nId As Integer
        Dim cRec As String
        Dim nTip As Decimal
        nTip = Val(Me.TxtComision.Text)

        If (Me.TxtID.Text = "") Or (IsNumeric(Me.TxtID.Text) = False) Then
            MsgBox("El ID no es válido")
            Exit Sub
        Else
            nId = Val(Me.TxtID.Text)
        End If

        If Me.TxtRecompensa.Text = Nothing Then
            MsgBox("Hace falta una descripción de recompensa")
            Exit Sub
        Else
            cRec = Me.TxtRecompensa.Text
        End If

        If (nTip < 1) Or (nTip > 2) Then
            MsgBox("Comsión es: 1 para Mayores, 2 para Infantiles")
            Exit Sub
        Else
            nTip = Val(Me.TxtComision.Text)
        End If

        Try
            RecompensasTableAdapter.InsertRecompensa(nId, cRec, nTip)
            MsgBox("Registro añadido correctamente")
        Catch ex As Exception
            MsgBox("Error al añadir registro, revise valores")
        End Try

        Me.TxtID.Text = ""
        Me.TxtRecompensa.Text = ""
        Me.TxtComision.Text = ""
        For Each c As Control In GroupBox1.Controls
            c.Enabled = True
        Next
        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next
        RecompensasTableAdapter.Fill(Me.DbCensos.recompensas)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.Text = "Mayores" Then
            Me.ComisionTxt.Text = 1
        ElseIf Me.ComboBox1.Text = "Infantiles" Then
            Me.ComisionTxt.Text = 2
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Me.ComboBox2.Text = "Mayores" Then
            Me.TxtComision.Text = 1
        ElseIf Me.ComboBox2.Text = "Infantiles" Then
            Me.TxtComision.Text = 2
        End If
    End Sub

End Class