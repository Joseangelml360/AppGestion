Public Class FrmSubDatosFiliación
    Private Sub FrmSubDatosFiliación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nCod As Integer
        nCod = Val(Me.FALLERO_CODIGOTextBox.Text)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallas' Puede moverla o quitarla según sea necesario.
        Me.FallasTableAdapter.Fill(Me.DbCensos.fallas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DbCensos.recompensas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.DbCensos.cargo)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.comision' Puede moverla o quitarla según sea necesario.
        Me.ComisionTableAdapter.Fill(Me.DbCensos.comision)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DbCensos.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, nCod)

        If Me.BAJACheckBox.Checked = True Then
            Me.Button3.Text = "Dar de alta"
        Else
            Me.Button3.Text = "Dar de baja"
        End If

    End Sub

    Private Sub BAJACheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BAJACheckBox.CheckedChanged
        If Me.BAJACheckBox.Checked = True Then
            Me.Button3.Text = "Dar de alta"
        Else
            Me.Button3.Text = "Dar de baja"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.FalleroBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbCensos)
            Me.DbCensos.AcceptChanges()
            MsgBox("Registro Modificado")
        Catch ex As Exception
            MsgBox("no se guardaron los cambios")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sResp
        If Me.BAJACheckBox.Checked = True Then
            sResp = MsgBox("¿Quieres dar de alta a este fallero?", vbYesNo)
        Else
            sResp = MsgBox("¿Quieres dar de baja a este fallero?", vbYesNo)
        End If

        If sResp = 6 Then
            If Me.BAJACheckBox.Checked = False Then
                Me.BAJACheckBox.Checked = True
                MsgBox("Fallero " & Me.FALLERO_CODIGOTextBox.Text & " ha sido marcado para dar de baja" & vbCr & "Pulsa el botón actualizar para guardar los cambios")
            Else
                Me.BAJACheckBox.Checked = False
                MsgBox("Fallero " & Me.FALLERO_CODIGOTextBox.Text & " ha sido marcado para dar de alta" & vbCr & "Pulsa el botón actualizar para guardar los cambios")
            End If
        End If
    End Sub

    Private Sub TIPFALTextBox_Leave(sender As Object, e As EventArgs) Handles TIPFALTextBox.Leave
        Dim dtFechaJuv, dtFechaMay, dtfechaNac As Date
        Dim ntipo As Integer
        ntipo = Val(Me.TIPFALTextBox.Text)
        dtFechaJuv = PasejuvenilTextBox.Text
        dtFechaMay = PasemayorTextBox.Text
        dtfechaNac = FECHA_NACDateTimePicker.Value
        'MsgBox(dtfechaNac & vbCrLf & dtFechaJuv & vbCrLf & dtFechaMay)

        If ntipo < 1 Or ntipo > 3 Then
            MsgBox("El código de comisión debe ser de 1 a 3")
            Exit Sub
        End If
        If ntipo = 1 And dtfechaNac > dtFechaJuv Then
            MsgBox("Según la fecha de nacimiento debe ser infantil = código 2")
            Exit Sub
        End If

        If ntipo = 1 And dtfechaNac > dtFechaMay Then
            MsgBox("Según la fecha de nacimiento debe ser juvenil = código 3")
            Exit Sub
        End If

        If ntipo = 2 And dtfechaNac < dtFechaJuv Then
            MsgBox("Según la fecha de nacimiento no es infantil")
            Exit Sub
        End If

        If ntipo = 3 And dtfechaNac < dtFechaMay Then
            MsgBox("Según la fecha de nacimiento debe ser mayor = código 1")
            Exit Sub
        End If

        If ntipo = 3 And dtfechaNac > dtFechaJuv Then
            MsgBox("según la fecha de nacimiento es infantil = código 2")
            Exit Sub
        End If


    End Sub

    Private Sub CARGOComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CARGOComboBox.SelectedIndexChanged
        Dim nCargo As Integer
        nCargo = Me.CARGOComboBox.SelectedValue
        Me.ULTCARTextBox.Text = nCargo
    End Sub

    Private Sub RECOMComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RECOMComboBox.SelectedIndexChanged
        Dim nRec As Integer
        nRec = Me.RECOMComboBox.SelectedValue
        Me.COD_RECTextBox.Text = nRec
    End Sub

    Private Sub NUMFALComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NUMFALComboBox.SelectedIndexChanged
        Dim nFal As Integer
        nFal = Me.NUMFALComboBox.SelectedValue
        Me.FAL_RECTextBox.Text = nFal

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class