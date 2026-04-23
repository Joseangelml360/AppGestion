Public Class FrmEditarHistorial
    Private Sub FrmEditarHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter.FillByFallero(Me.DbCensos.historfa, Val(Me.TxtAnoCen.Text), Val(Me.TxtCodFalla.Text))
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.RecompensasAgrupacion' Puede moverla o quitarla según sea necesario.
        Me.RecompensasAgrupacionTableAdapter.Fill(Me.DbCensos.RecompensasAgrupacion)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.RecompensasFalla' Puede moverla o quitarla según sea necesario.
        Me.RecompensasFallaTableAdapter.Fill(Me.DbCensos.RecompensasFalla)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DbCensos.recompensas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.DbCensos.cargo)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallas' Puede moverla o quitarla según sea necesario.
        Me.FallasTableAdapter.Fill(Me.DbCensos.fallas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim nCod, nAnoCen, nFalla, nCargo, nRecJCF, nTipFal, nCodFalla, nRecFal, nRecAgrup As Integer
        Dim cDNI, cObserv As String
        Dim nfechaMax, nfechaMin As Double
        nfechaMin = 1900
        nfechaMax = Val(HistorfaTableAdapter.ScalarUltCenso.ToString)
        nCodFalla = Val(Me.TxtCodFalla.Text)
        nCod = Val(Me.TxtCodJCF.Text)
        nAnoCen = Val(Me.TxtAnoCen.Text)
        nFalla = Val(Me.TxtFalCen.Text)
        nTipFal = Val(Me.TxtComision.Text)
        nCargo = Val(Me.TxtCargo.Text)
        nRecFal = Val(Me.TxtRecFal.Text)
        nRecJCF = Val(Me.TxtRecJCF.Text)
        nRecAgrup = Val(Me.TxtRecAgrup.Text)
        cDNI = Me.TxtDNI.Text
        cObserv = Me.TxtObserv.Text

        If (nAnoCen = Nothing) Or (nTipFal = Nothing) Or (nFalla = Nothing) Or (nCargo = Nothing) Then
            MsgBox("Es obligatorio rellenar los campos: AÑO CENSO, FALLA CENSO, COMISIÓN O CARGO")
        Else
            If (Val(Me.TxtAnoCen.Text) < nfechaMin) OrElse (Val(Me.TxtAnoCen.Text) > nfechaMax) Then
                MessageBox.Show("Fecha errónea, el dato introducido no es un año válido")
                Exit Sub
            Else
                nAnoCen = Val(Me.TxtAnoCen.Text)
            End If

            If IsNumeric(Val(Me.TxtFalCen.Text)) = False Then
                MsgBox("Falla errónea, introduce una falla con ayuda del desplegable")
                Exit Sub
            End If

            If nFalla = 0 Then
                MsgBox("Falla errónea, introduce una falla con ayuda del desplegable")
                Exit Sub
            End If

            If (Val(Me.TxtComision.Text) < 1) Or (Val(Me.TxtComision.Text) > 3) Then
                MsgBox("La Comisión solo puede ser 1: Mayores, 3; Juveniles ó 2: Infantiles")
                Exit Sub
            Else
                nTipFal = Val(Me.TxtComision.Text)
            End If

            If Val(Me.TxtCargo.Text) > 24 Or Val(Me.TxtCargo.Text) < 1 Then
                MsgBox("El cargo no está en el rango permitido. Selecciona cargo desde el desplegable")
                Exit Sub
            Else
                nCargo = Val(Me.TxtCargo.Text)
            End If

            If cDNI = Nothing Then
                cDNI = "0000000T"
            End If
        End If

        Try
            HistorfaTableAdapter.UpdateLineaHistorial(nFalla, nCargo, nRecJCF, nTipFal, nRecFal, nRecAgrup, cObserv, cDNI, nCodFalla, nAnoCen)
            MsgBox("Guardado")
        Catch ex As Exception
            MsgBox("Error al guardar línea de histórico")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedIndex.ToString <> Nothing Then
            Me.TxtFalCen.Text = Me.ComboBox1.SelectedValue
        Else
            MsgBox("valor asignado a falla Censo no es correcto")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Me.ComboBox2.SelectedIndex.ToString <> Nothing Then
            If Me.ComboBox2.Text = "Mayores" Then
                Me.TxtComision.Text = 1
            ElseIf Me.ComboBox2.Text = "Juveniles" Then
                Me.TxtComision.Text = 3
            Else
                Me.TxtComision.Text = 2
            End If
        Else
            MsgBox("valor asignado a COMISION no es correcto")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Me.ComboBox3.SelectedIndex.ToString <> Nothing Then
            Me.TxtCargo.Text = Me.ComboBox3.SelectedValue
        Else
            MsgBox("valor asignado a Cargo no es correcto")
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If Me.ComboBox4.SelectedIndex.ToString <> Nothing Then
            Me.TxtRecJCF.Text = Me.ComboBox4.SelectedValue
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If Me.ComboBox5.SelectedIndex.ToString <> Nothing Then
            Me.TxtRecFal.Text = Me.ComboBox5.SelectedValue
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If Me.ComboBox6.SelectedIndex.ToString <> Nothing Then
            Me.TxtRecAgrup.Text = Me.ComboBox6.SelectedValue
        End If
    End Sub

End Class