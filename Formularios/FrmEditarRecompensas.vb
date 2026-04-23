Public Class FrmEditarRecompensas
    Private Sub FrmEditarRecompensas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensasejercicio' Puede moverla o quitarla según sea necesario.
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()

    End Sub

    Private Sub BtonDeJCF_Click(sender As Object, e As EventArgs) Handles BtnDeJCF.Click
        Me.RecompensasejercicioTableAdapter.FillByRecJCF(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub BtnDeFalla_Click(sender As Object, e As EventArgs) Handles BtnDeFalla.Click
        Me.RecompensasejercicioTableAdapter.FillByRecFalla(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnTodas_Click(sender As Object, e As EventArgs) Handles BtnTodas.Click
        Me.RecompensasejercicioTableAdapter.FillByRecJCF(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim frm As New FrmEditarLineaRecomp
        frm.TxtCodFal.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        frm.ShowDialog()
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nCod, nResult As Integer
        Dim sNombre, sApelli As String
        nCod = Me.DataGridView1.CurrentRow.Cells(1).Value
        sNombre = Me.DataGridView1.CurrentRow.Cells(2).Value.ToString
        sApelli = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString
        nResult = MsgBox("Eliminar recompensas de " & sNombre & " " & sApelli, vbYesNo)
        If nResult = 6 Then
            Try
                Me.RecompensasejercicioTableAdapter.DeleteRecFallero(nCod)
                MsgBox("Registro eliminado")
                Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
                Me.DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error. No se ha eliminado el registro")
            End Try
        End If

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim frm As New FrmAñadirRegistroRecompensa
        frm.ShowDialog()
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
    End Sub
End Class