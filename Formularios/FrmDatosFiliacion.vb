Public Class FrmDatosFiliacion
    Private Sub FrmDatosFiliacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.RecompensasFalla' Puede moverla o quitarla según sea necesario.
        Me.RecompensasFallaTableAdapter.Fill(Me.DbCensos.RecompensasFalla)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.FalleroComision' Puede moverla o quitarla según sea necesario.
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
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
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        Me.DgvFALLERO.Visible = False
        Me.lblFiltro.Text = "Activos"
        Me.TxtBuscarCodigo.Text = ""

    End Sub

    Private Sub ActivosToolStripButton_Click(sender As Object, e As EventArgs) Handles ActivosToolStripButton.Click
        Try
            Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        Catch ex As Exception

        End Try
        Me.Button3.Text = "Dar de baja"
        Me.lblFiltro.Text = "Activos"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.FalleroTableAdapter.Mayores(DbCensos.fallero)
        Catch ex As Exception

        End Try
        Me.Button3.Text = "Dar de baja"
        Me.lblFiltro.Text = "Mayores"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.FalleroTableAdapter.Infantiles(DbCensos.fallero)
        Catch ex As Exception

        End Try
        Me.Button3.Text = "Dar de baja"
        Me.lblFiltro.Text = "Infantiles"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            Me.FalleroTableAdapter.Familia(DbCensos.fallero, DIRECCIONTextBox.Text)
        Catch ex As Exception

        End Try
        Me.Button3.Text = "Dar de baja"
        Me.lblFiltro.Text = "Por familia"
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Try
            Me.FalleroTableAdapter.Bajas(DbCensos.fallero)
        Catch ex As Exception

        End Try
        Me.Button3.Text = "Dar de alta"
        Me.lblFiltro.Text = "Bajas"
    End Sub

    Private Sub DgvFALLERO_Click(sender As Object, e As EventArgs) Handles DgvFALLERO.Click
        Me.DgvFALLERO.Visible = False

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Me.DgvFALLERO.Visible = True
        Try
            If Me.lblFiltro.Text = "Infantiles" Then
                Me.FalleroTableAdapter.FillByInfantiles(DbCensos.fallero, TxtBuscar.Text)
                DgvFALLERO.Refresh()
            ElseIf Me.lblFiltro.Text = "Mayores" Then
                Me.FalleroTableAdapter.FillByMayores(DbCensos.fallero, TxtBuscar.Text)
                DgvFALLERO.Refresh()
            ElseIf Me.lblFiltro.Text = "Bajas" Then
                Me.FalleroTableAdapter.FillByBajas(Me.DbCensos.fallero, TxtBuscar.Text)
                DgvFALLERO.Refresh()
            ElseIf Me.lblFiltro.Text = "Juveniles" Then
                Me.FalleroTableAdapter.FillByJuveniles(DbCensos.fallero, TxtBuscar.Text)
                DgvFALLERO.Refresh()
            Else
                Me.FalleroTableAdapter.FillByApellidos(Me.DbCensos.fallero, TxtBuscar.Text)
            End If
        Catch ex As Exception
            MsgBox(TxtBuscar.Text)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dtFechaJuv, dtFechaMay, dtfechaNac As Date
        Dim ntipo As Integer
        ntipo = Val(Me.TIPFALTextBox.Text)
        dtFechaJuv = PasejuvenilTextBox.Text
        dtFechaMay = PasemayorTextBox.Text
        dtfechaNac = FECHA_NACDateTimePicker.Value
        'MsgBox(dtfechaNac & vbCrLf & dtFechaJuv & vbCrLf & dtFechaMay)

        If Val(Me.ANO_CENTextBox.Text) <> Val(Me.AñoejeTextBox.Text) Then
            Me.ANO_CENTextBox.Text = Val(Me.AñoejeTextBox.Text)
        End If

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
                MsgBox("Fallero " & Me.FALLERO_CODIGOTextBox.Text & " ha sido marcado para dar de alta" & vbCr &
                       "Pulsa el botón actualizar para guardar los cambios" & vbCr & "Actualiza cuotas de este fallero")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Try
            Me.FalleroTableAdapter.Juveniles(Me.DbCensos.fallero)
        Catch ex As Exception

        End Try
        Me.Button3.Text = "Dar de baja"
        Me.lblFiltro.Text = "Juveniles"
    End Sub

    Private Sub TxtBuscar_MouseHover(sender As Object, e As EventArgs) Handles TxtBuscar.MouseHover
        ToolTip1.SetToolTip(TxtBuscar, "Escribe el apellido a buscar y selecciona en el desplegable para abrir la ficha")
        ToolTip1.ToolTipTitle = "Buscar fallero por apellidos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip1.SetToolTip(Button3, "Pulsar para dar de baja")
        ToolTip1.ToolTipTitle = "Botón baja"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip1.SetToolTip(Button2, "Pulsar aquí para guardar los cambios")
        ToolTip1.ToolTipTitle = "Botón actualizar"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TIPFALTextBox_MouseHover(sender As Object, e As EventArgs) Handles TIPFALTextBox.MouseHover
        ToolTip1.SetToolTip(TIPFALTextBox, "Introduce el nº de la comisión (1,2 ó 3)")
        ToolTip1.ToolTipTitle = "Comisión"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New FrmSubDatosCuotas
        frm.FALLERO_CODIGOTextBox.Text = Val(Me.FALLERO_CODIGOTextBox.Text)
        frm.Show()
    End Sub

    Private Sub BtnBuscarCodigo_Click(sender As Object, e As EventArgs) Handles BtnBuscarCodigo.Click
        If Val(TxtBuscarCodigo.Text <> "") Then

            Try
                Me.FalleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, Val(TxtBuscarCodigo.Text))
            Catch ex As Exception
                MsgBox("Código de fallero no existe. Intenta de nuevo")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        Me.TxtBuscarCodigo.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New FrmHistorial

        frm.FALLERO_CODIGOTextBox.Text = Val(Me.FALLERO_CODIGOTextBox.Text)
        frm.CODIGOTextBox.Text = Val(Me.COD_JCFTextBox.Text)
        frm.DNITextBox.Text = Me.DNITextBox.Text
        frm.NOMBRETextBox.Text = Me.NOMBRETextBox.Text
        frm.APELLIDOSTextBox.Text = Me.APELLIDOSTextBox.Text
        frm.TxtBuscarCodigo.Text = Val(Me.FALLERO_CODIGOTextBox.Text)
        frm.TxtComision.Text = Val(TIPFALTextBox.Text)
        frm.TxtCargo.Text = Me.ULTCARTextBox.Text
        frm.ChkbBAJA.Checked = Me.BAJACheckBox.Checked

        frm.Show()
    End Sub

    Private Sub CboComision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboComision.SelectedIndexChanged
        Dim nTipfal As Integer

        nTipfal = Me.CboComision.SelectedValue
        Me.TIPFALTextBox.Text = nTipfal

    End Sub

End Class