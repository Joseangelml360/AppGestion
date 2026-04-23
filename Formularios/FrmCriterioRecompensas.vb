Public Class FrmCriterioRecompensas

    Dim i As Integer

    Private Sub FrmCriterioRecompensas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DataSet1.recompensas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.criteriorecomp' Puede moverla o quitarla según sea necesario.
        Me.CriteriorecompTableAdapter.Fill(Me.DataSet1.criteriorecomp)

        For Each c As Control In Me.GroupBox1.Controls
            c.Visible = False
        Next

        Me.CriteriorecompDataGridView.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        For Each c As Control In GroupBox1.Controls
            c.Visible = True
        Next
        i = 1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim nRec, nEjeJCF, nEjeCargo, nMinEjeCargo, nRecFalla As Integer
        nRec = Val(Me.CODRECTextBox.Text)
        nEjeJCF = Val(Me.NUMEJEFALLEROTextBox.Text)
        nEjeCargo = Val(Me.NUMEJECARGOTextBox.Text)
        nMinEjeCargo = Val(Me.MINEJECARGOTextBox.Text)
        nRecFalla = Val(Me.RECOMFALLATextBox.Text)
        Try
            If i = 1 Then
                CriteriorecompTableAdapter.GuardarCambios(nEjeJCF, nEjeCargo, nMinEjeCargo, nRecFalla, nRec)
            ElseIf i = 2 Then
                CriteriorecompTableAdapter.InsertQuery(nRec, nEjeJCF, nEjeCargo, nMinEjeCargo, nRecFalla)
            Else
                MsgBox("no hay cambios que guardar")

            End If
        Catch ex As Exception
            MsgBox("error al guardar")
        End Try
        For Each c As Control In GroupBox1.Controls
            c.Visible = False
        Next
        i = 0
        Me.CriteriorecompTableAdapter.Fill(DataSet1.criteriorecomp)
        Me.CriteriorecompDataGridView.Refresh()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        For Each c As Control In GroupBox1.Controls
            c.Visible = False
        Next
        i = 0
        Me.CriteriorecompDataGridView.Refresh()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        i = 2
        For Each c As Control In GroupBox1.Controls
            c.Visible = True
        Next

        Dim text As Object
        For Each text In GroupBox1.Controls
            If TypeOf text Is TextBox Then
                Dim txtTemp As TextBox = CType(text, TextBox)
                txtTemp.Clear()
            End If
        Next


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim nId As Integer
        nId = Me.CriteriorecompDataGridView.CurrentRow.Cells(0).Value
        Try
            CriteriorecompTableAdapter.DeleteQuery(nId)
        Catch ex As Exception
            MsgBox("Error, no se ha eliminado el registro")
        End Try
        Me.CriteriorecompTableAdapter.Fill(Me.DataSet1.criteriorecomp)
        Me.CriteriorecompDataGridView.Refresh()

    End Sub
End Class