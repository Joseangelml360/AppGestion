Public Class FrmEliminarRemesa
    Private Sub FrmEliminarRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.FillBy(Me.DataSet1.remesas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.EliminarRemesaCheckBox.Checked = True Then
            Me.EliminarRemesaCheckBox.Text = "Eliminado"
            Me.EliminarRemesaCheckBox.Enabled = False
        Else
            Me.EliminarRemesaCheckBox.Text = "No eliminada"
            Me.EliminarRemesaCheckBox.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.EliminarRemesaCheckBox.Checked = False Then
            Me.EliminarRemesaCheckBox.Checked = True
            Me.EliminarRemesaCheckBox.Text = "Eliminado"
            Me.EliminarRemesaCheckBox.Enabled = False

            Try
                RemesasTableAdapter.DeleteQuery()
                Me.RemesasTableAdapter.FillBy(Me.DataSet1.remesas)
                Me.EstadoTableAdapter.UpdateEstadoFinalizar(True, True, False)
                MsgBox("Registros de la tabla Remesas eliminados")

            Catch ex As Exception
                MsgBox("Error, no se pudo realizar la acción de eliminar registros")
            End Try
        Else
            MsgBox("Los registros ya han sido eliminados, continúa con el siguiente paso")
        End If
        Me.Button2.Image = My.Resources.door_out
        Me.Button2.Text = "Salir"
    End Sub

End Class