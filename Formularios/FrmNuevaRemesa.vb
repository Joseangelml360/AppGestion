Public Class FrmNuevaRemesa
    Dim nTipoRemesa As Integer

    Private Sub FrmNuevaRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.Fill(Me.DbCensos.remesas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.banco_remesa' Puede moverla o quitarla según sea necesario.
        Me.Banco_remesaTableAdapter.Fill(Me.DbCensos.banco_remesa)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        For Each c As Control In GroupBox2.Controls
            c.Enabled = False
        Next

        For Each c As Control In Me.GroupBoxNueva.Controls
            c.Visible = False
        Next

        If Me.ConsolidarRemesaCheckBox.Checked = True Then
            Me.BtnFijar.Enabled = False
            Me.BtnGenerar.Enabled = False
            Me.BtnVer.Enabled = False
            Me.TxtUltRemesa.Enabled = False
            Me.ComboBox1.Enabled = False
            Me.DTFechaCargo.Enabled = False
            Me.DTFechaCreac.Enabled = False
            Me.BtnSalir.Focus()
            MsgBox("No se puede generar remesa nueva. La remesa actual está sin enviar al banco")

        Else
            Me.TxtUltRemesa.Text = Val(Me.TxtUltRemesa.Text) + 1
            Me.DTFechaCargo.Value = Me.DTFechaCreac.Value.AddDays(1)
            Me.RadioButton1.Checked = True
            Me.TxtImpRecDev.Text = 2
            Me.TxtnCuotas.Text = 1
            If Me.GenerarRemesaNuevaCheckBox.Checked = False Then
                Me.BtnVer.Enabled = False
                Me.BtnFijar.Enabled = True
                Me.BtnGenerar.Enabled = False
            Else
                Me.GenerarRemesaNuevaCheckBox.Text = "Generada"
                Me.BtnVer.Enabled = True
                Me.BtnGenerar.Enabled = True
                Me.BtnFijar.Enabled = False
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        nTipoRemesa = 1

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        nTipoRemesa = 2

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        nTipoRemesa = 3

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dim nres, msj As Integer

        If GenerarRemesaNuevaCheckBox.Checked = True Then

            nres = MsgBox("Ya hay una remesa generada sin enviar al banco" & vbCrLf &
                  "Si solo quieres hacer modificaciones pulsa NO" & vbCrLf &
                  "Para generar nueva y eliminar la actual, pulsa SI", vbYesNo, "Remesa Generada")
            If nres = vbNo Then
                BtnGenerar.Enabled = False
                'BtnVer.Text = "Modificar Remesa"
                'BtnVer.Image = My.Resources.Modificar
                Exit Sub
            Else
                msj = MsgBox("Antes de iniciar remesa debes repasar la siguiente lista de acciones:" & vbCrLf & vbCrLf &
                   "1. Haz copia de seguridad de la base de datos antes de iniciar la generación de remesa nueva." & vbCrLf &
                   "2. Comprobar devoluciones remesa anterior y aplicar las que correspondan." & vbCrLf &
                   "3. Verificar altas nuevas, opciones de cuota y comprobar si hay cuenta asignada." & vbCrLf &
                   "4. Comprobar descuentos especiales y/o cantidades a cuenta.",
                   vbOKCancel, "COMPROBACIONES PREVIAS")
                If msj = vbCancel Then
                    Exit Sub
                End If
                For Each c As Control In Me.GroupBoxNueva.Controls
                    c.Visible = True
                Next

                Me.EstadoTableAdapter.UpdateGenerarRemesaFalse()
                Me.EstadoTableAdapter.Fill(DataSet1.estado)
                Me.BtnVer.Enabled = False
                Me.BtnGenerar.Enabled = False
                Me.BtnFijar.Enabled = True

            End If
        Else

            For Each c As Control In Me.GroupBoxNueva.Controls
                c.Visible = True
            Next
            If MsgBox("¿Generar ahora?", vbYesNo) = vbYes Then
                If Me.TxtRecPagados.Text = Nothing Then
                    MsgBox("Error en Recibos pagados." & vbCrLf & "Debes introducir el nº de recibos pagados hasta esta remesa")
                    Me.TxtRecPagados.Focus()
                    Exit Sub
                End If

                Dim frm As New FrmGenerarRemesa
                frm.TxtId.Text = Val(Me.TxtUltRemesa.Text)
                frm.TxtTipoRemesa.Text = nTipoRemesa
                frm.DtpFechaCgo.Value = Me.DTFechaCargo.Value
                frm.DtpFechaCrea.Value = Me.DTFechaCreac.Value
                frm.TxtValdev.Text = Me.TxtImpRecDev.Text
                frm.TxtNPagos.Text = Me.TxtnCuotas.Text
                frm.NumCuotasAñoTextBox.Text = Me.NumcuotasmesTextBox.Text
                frm.TxtRecEmitidos.Text = Me.TxtRecPagados.Text
                frm.TxtTipoRemesa.Text = nTipoRemesa
                frm.MdiParent = MDIParent1
                frm.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles BtnVer.Click
        Dim frm As New FrmGenerarRemesa
        frm.MdiParent = MDIParent1
        frm.Show()
    End Sub

    Private Sub BtnFijar_Click(sender As Object, e As EventArgs) Handles BtnFijar.Click
        For Each c As Control In Me.GroupBoxNueva.Controls
            c.Visible = True
        Next
        Me.BtnFijar.Enabled = False
        Me.BtnGenerar.Enabled = True
    End Sub

    Private Sub Cerrar()
        Me.Close()
    End Sub
End Class