Public Class FrmDescuentos
    Private Sub FrmDescuentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.descuentos_de_la_cuota' Puede moverla o quitarla según sea necesario.
        Me.Descuentos_de_la_cuotaTableAdapter.Fill(Me.DbCensos.descuentos_de_la_cuota)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.AsignarDtoNuevoCheckBox.Enabled = False
        If Me.AsignarDtoNuevoCheckBox.Checked = True Then
            Me.AsignarDtoNuevoCheckBox.Text = "Asignado"
        Else
            Me.AsignarDtoNuevoCheckBox.Text = "Sin asignar"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.AsignarDtoNuevoCheckBox.Checked = False Then
            Me.Validate()
            Me.DescuentosDeLaCuotaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbCensos)
            Me.DbCensos.AcceptChanges()
            EstadoTableAdapter.UpdateEstadoDescuentos()
            Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
            Me.AsignarDtoNuevoCheckBox.Text = "Asignado"
            MsgBox("Actualizado Descuentos")
            Me.Button2.Image = My.Resources.door_out
            Me.Button2.Text = "Salir"
        Else
            MsgBox("Descuentos ya han sido actualizados")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

End Class