Public Class FrmHistorial
    Private Sub FrmHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter1.Fill(Me.DataSet1.historfa)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos1.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.historfa' Puede moverla o quitarla según sea necesario.
        'Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos.historfa, TxtBuscar.Text)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        'Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        WindowState = FormWindowState.Maximized

        Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))
        Me.HistorfaDataGridView.Visible = True

        calcular()

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Me.DgvFallero.Visible = True
        Me.HistorfaDataGridView.Visible = False

        Try
            Me.FalleroTableAdapter.FillByTodos(Me.DbCensos.fallero, TxtBuscar.Text)
            Me.HistorfaDataGridView.Visible = True
        Catch ex As Exception
            MsgBox(TxtBuscar.Text)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'Me.DgvFallero.Visible = False
    End Sub

    Private Sub DgvFallero_Click(sender As Object, e As EventArgs) Handles DgvFallero.Click

        Me.DgvFallero.Visible = False
        Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))

        calcular()


    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles BtnVer.Click

        If Val(TxtBuscarCodigo.Text <> "") Then

            Me.HistorfaTableAdapter.FillByCodFalla(Me.DbCensos1.historfa, Val(TxtBuscarCodigo.Text))
            Me.FalleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, Val(TxtBuscarCodigo.Text))
            Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))

        End If

        Me.HistorfaDataGridView.Visible = True
        Me.TxtBuscarCodigo.Text = Nothing

        calcular()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim frm As New FrmAñadirHistorial
        frm.TxtCodJCF.Text = Me.CODIGOTextBox.Text
        frm.TxtCodFalla.Text = Me.FALLERO_CODIGOTextBox.Text
        frm.TxtNombre.Text = Me.NOMBRETextBox.Text
        frm.TxtApellidos.Text = Me.APELLIDOSTextBox.Text
        frm.TxtDNI.Text = Me.DNITextBox.Text
        frm.ShowDialog()
        Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))
        Me.HistorfaDataGridView.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New FrmEditarHistorial
        frm.TxtAnoCen.Text = Me.HistorfaDataGridView.CurrentRow.Cells(1).Value
        frm.TxtCodFalla.Text = Me.HistorfaDataGridView.CurrentRow.Cells(7).Value
        frm.TxtNombre.Text = Me.NOMBRETextBox.Text
        frm.TxtApellidos.Text = Me.APELLIDOSTextBox.Text
        frm.ShowDialog()
        Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))
        Me.HistorfaDataGridView.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cString As String
        Dim nResult As Long
        Dim nAnocen, nCod As Double

        cString = "¿Borrar censo año: " & Me.HistorfaDataGridView.CurrentRow.Cells(1).Value & " de "
        cString = cString & Me.NOMBRETextBox.Text & " " & Me.APELLIDOSTextBox.Text & "?"
        nResult = MsgBox(cString, vbYesNo)
        nAnocen = Me.HistorfaDataGridView.CurrentRow.Cells(1).Value
        nCod = Me.HistorfaDataGridView.CurrentRow.Cells(7).Value
        If nResult = 6 Then
            Try
                Me.HistorfaTableAdapter.DeleteLineaFallero(nAnocen, nCod)
                Me.HistorfaTableAdapter.FillByCodigo(Me.DbCensos1.historfa, Val(CODIGOTextBox.Text))
                Me.HistorfaDataGridView.Refresh()
            Catch ex As Exception
                MsgBox("Error al borrar línea de censo")
            End Try

        End If
    End Sub

    Private Function calcular()
        Dim nTipfal, nCargo, nCodigo, nSuma, nEjeCargoM, nEjeCargoI As Integer
        If ChkbBAJA.Checked Then
            nSuma = 0
        Else
            nSuma = 1
        End If


        nCargo = Val(Me.TxtCargo.Text)
        nCodigo = Val(CODIGOTextBox.Text)
        nTipfal = Val(Me.TxtComision.Text)


        Me.TxtEjeFalla.Text = HistorfaTableAdapter1.ScalarEjeFalla(nCodigo) + nSuma


        If nTipfal = 1 Or nTipfal = 3 Then
            Me.TxtEjeJCF.Text = HistorfaTableAdapter1.ScalarEjeJCF(nCodigo, 1) + HistorfaTableAdapter1.ScalarEjeJCF(nCodigo, 3) + nSuma
        ElseIf nTipfal = 2 Then
            Me.TxtEjeJCF.Text = HistorfaTableAdapter1.ScalarEjeJCF(nCodigo, 2) + nSuma
        End If

        nEjeCargoM = HistorfaTableAdapter1.ScalarEjerConCargo(nCodigo, 1) + HistorfaTableAdapter1.ScalarEjerConCargo(nCodigo, 3)
        nEjeCargoI = HistorfaTableAdapter1.ScalarEjerConCargo(nCodigo, 2)

        If nCargo < 20 Or nCargo = 21 Then
            If nTipfal = 1 Or nTipfal = 3 Then
                nEjeCargoM += 1
            ElseIf nTipfal = 2 Then
                If nCargo <> 20 Then
                    nEjeCargoI += 1
                End If

            End If
        End If
        If nTipfal = 2 Then
            Me.TxtEjeCargo.Text = nEjeCargoI
        Else
            Me.TxtEjeCargo.Text = nEjeCargoM
        End If

        Return 0

    End Function

End Class