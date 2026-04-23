Public Class FrmCargos
    Private Sub FrmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.cargo' Puede moverla o quitarla según sea necesario.
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.CargoTableAdapter.Fill(Me.DbCensos.cargo)
        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Me.CargoTableAdapter.UpdateCargo(Me.DescripTxt.Text, Val(Me.IdText.Text))
            MsgBox("Actualizado registro")
            Me.CargoTableAdapter.Fill(Me.DbCensos.cargo)
        Catch ex As Exception
            MsgBox("Error al actualizar registro")
        End Try
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim ncar, nUlt As Integer

        For Each c As Control In GroupBox1.Controls
            c.Enabled = False
        Next

        For Each c As Control In GroupBox2.Controls
            c.Visible = True
        Next

        nUlt = Me.CargoTableAdapter.ScalarUltCargo() + 1
        Me.TxtID.Text = nUlt
        ncar = Val(Me.TxtID.Text)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        For Each c As Control In GroupBox1.Controls
            c.Enabled = True
        Next

        For Each c As Control In GroupBox2.Controls
            c.Visible = False
        Next
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Dim nCar, nUlt As Integer
        Dim cDesc As String = Me.TxtDescrip.Text

        nUlt = Me.CargoTableAdapter.ScalarUltCargo() + 1
        nCar = Val(Me.TxtID.Text)

        If nCar < nUlt Then
            MsgBox("Ya existe un cargo con ese código")
            Exit Sub
        ElseIf IsNumeric(nCar) = False Then
            MsgBox("El código de cargo debe ser numérico")
            Exit Sub
        Else
            nCar = Val(Me.TxtID.Text)
        End If

        If cDesc = Nothing Then
            MsgBox("La descripción está vacía, asigna una descripción para el Cargo")
        Else
            cDesc = Me.TxtDescrip.Text
        End If

        Try
            CargoTableAdapter.InsertCargo(nCar, cDesc)
            MsgBox("registro añadido")
            CargoTableAdapter.Fill(Me.DbCensos.cargo)
            Me.IdText.Text = ""
            Me.DescripTxt.Text = ""
            For Each c As Control In GroupBox1.Controls
                c.Enabled = True
            Next

            For Each c As Control In GroupBox2.Controls
                c.Visible = False
            Next
        Catch ex As Exception
            MsgBox("Error: no se ha añadido el registro, revisa valores")
        End Try
    End Sub

End Class