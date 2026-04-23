Public Class FrmMensajes
    Dim lVisto As Boolean
    Dim IdMsg As Integer
    Dim DFecha As Date
    Dim TxtMsg As String

    Private Sub FrmMensajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        Me.BtnAceptar.Visible = False
        Me.BtnCancel.Visible = False
        Me.BtnGuardarNuevo.Visible = False
        Me.BtnNuevaNota.Visible = True
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Mensajes' Puede moverla o quitarla según sea necesario.
        Me.MensajesTableAdapter.Fill(Me.DataSet1.Mensajes)

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Mensajes' Puede moverla o quitarla según sea necesario.
        Me.MensajesTableAdapter.FillByNoLeido(Me.DataSet1.Mensajes)

    End Sub

    Private Sub BtnLeidos_Click(sender As Object, e As EventArgs) Handles BtnLeidos.Click
        Me.MensajesTableAdapter.FillByleido(Me.DataSet1.Mensajes)

        Me.DgvMensajes.Refresh()
        Me.BtnNuevaNota.Visible = True
        Me.BtnAceptar.Visible = False
        Me.BtnGuardarNuevo.Visible = False
        Me.BtnCancel.Visible = False

        Limpiar()
    End Sub

    Private Sub BtnNoLeidos_Click(sender As Object, e As EventArgs) Handles BtnNoLeidos.Click
        Me.MensajesTableAdapter.FillByNoLeido(Me.DataSet1.Mensajes)
        Me.DgvMensajes.Refresh()
        Me.BtnNuevaNota.Visible = True
        BtnAceptar.Visible = False
        Me.BtnGuardarNuevo.Visible = False
        Me.BtnCancel.Visible = False
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        IdMsg = Val(Me.TxtId.Text)
        TxtMsg = TxtMensaje.Text
        lVisto = ChkVisto.Checked

        Try
            MensajesTableAdapter.UpdateQuery(TxtMsg, lVisto, IdMsg)
            Me.MensajesTableAdapter.FillByNoLeido(Me.DataSet1.Mensajes)
            Me.DgvMensajes.Refresh()
            Limpiar()
            Me.BtnAceptar.Visible = False
            Me.BtnNuevaNota.Visible = True
            Me.BtnEditar.Visible = True
            Me.BtnCancel.Visible = False

        Catch ex As Exception

            MsgBox("registro no actualizado")
        End Try



    End Sub

    Private Sub BtnNuevaNota_Click(sender As Object, e As EventArgs) Handles BtnNuevaNota.Click
        Limpiar()
        Me.BtnGuardarNuevo.Visible = True
        Me.BtnAceptar.Visible = False
        Me.BtnEditar.Visible = False
        ChkVisto.Visible = False
        LblLeido.Visible = False
        TxtId.Visible = False
        LblId.Visible = False
        BtnCancel.Visible = True
        DtFecha.Text = Today
        LblTexto.Visible = True
        TxtMensaje.Visible = True

    End Sub

    Private Function Limpiar()
        Me.TxtId.Text = ""
        Me.DtFecha.Text = ""
        Me.TxtMensaje.Text = ""
        Me.ChkVisto.CheckState = 0
        Me.TxtId.Visible = False
        Me.LblId.Visible = False
        Me.LblFecha.Visible = False
        Me.DtFecha.Visible = False
        Me.LblTexto.Visible = False
        Me.TxtMensaje.Visible = False
        Me.LblLeido.Visible = False
        Me.ChkVisto.Visible = False
        Return 0
    End Function

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim nReg As Integer = DgvMensajes.Rows.Count

        If nReg > 0 Then
            Me.TxtId.Text = Me.DgvMensajes.CurrentRow.Cells(0).Value
            Me.DtFecha.Text = Me.DgvMensajes.CurrentRow.Cells(1).Value
            Me.TxtMensaje.Text = Me.DgvMensajes.CurrentRow.Cells(2).Value
            Me.ChkVisto.Checked = Me.DgvMensajes.CurrentRow.Cells(3).Value
            Me.BtnAceptar.Visible = True
            Me.BtnCancel.Visible = True
            Me.BtnEditar.Visible = False
            Me.BtnNuevaNota.Visible = False
            ChkVisto.Visible = True
            LblLeido.Visible = True
            TxtId.Visible = True
            LblId.Visible = True
            LblTexto.Visible = True
            TxtMensaje.Visible = True
        Else
            MsgBox("No hay registros para editar")
        End If

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click

        DFecha = Today
        TxtMsg = Me.TxtMensaje.Text
        lVisto = False

        Try
            If TxtMensaje.Text <> "" Then
                Me.MensajesTableAdapter.InsertQuery(DFecha, TxtMsg, lVisto)
                Limpiar()
                Me.BtnGuardarNuevo.Visible = False
                Me.BtnAceptar.Visible = False
                Me.BtnCancel.Visible = False
                Me.BtnEditar.Visible = True
                Me.LblId.Visible = True
                Me.LblFecha.Visible = True
                Me.MensajesTableAdapter.FillByNoLeido(DataSet1.Mensajes)
                Me.DgvMensajes.Refresh()
            Else
                MsgBox("No se puede guardar un mensaje sin texto.")
                Limpiar()
                Me.BtnGuardarNuevo.Visible = True
                Me.BtnAceptar.Visible = False
                Me.BtnEditar.Visible = False
                Me.BtnCancel.Visible = True
                DtFecha.Text = Today
            End If

        Catch ex As Exception
            MsgBox("Error al guardar el registro, inténtalo de nuevo después de corregir el error.")
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Limpiar()
        Me.BtnGuardarNuevo.Visible = False
        Me.BtnAceptar.Visible = False
        Me.BtnCancel.Visible = False
        Me.BtnEditar.Visible = True
        Me.BtnNuevaNota.Visible = True
        Me.MensajesTableAdapter.FillByNoLeido(Me.DataSet1.Mensajes)
        Me.DgvMensajes.Refresh()
    End Sub
End Class