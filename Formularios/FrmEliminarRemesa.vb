Imports MySql.Data.MySqlClient

Public Class FrmEliminarRemesa
    Private Sub FrmEliminarRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RemesasTableAdapter.FillBy(Me.DataSet1.remesas)
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        ' Ajuste visual inicial según la base de datos
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

            Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)
                Dim transaccion As MySqlTransaction = Nothing

                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    Me.RemesasTableAdapter.Connection = conexion
                    Me.EstadoTableAdapter.Connection = conexion

                    ' 1. Ejecutamos las consultas de modificación bajo la transacción (Borrador seguro)
                    Me.RemesasTableAdapter.DeleteQuery()
                    Me.EstadoTableAdapter.UpdateEstadoFinalizar(True, True, False)

                    ' 🔥 ¡COMMIT FINAL!: Guardamos de golpe en el servidor de Aiven
                    transaccion.Commit()

                    ' 2. 🔥 NUEVO ORDEN: Tras el éxito real en la BD, actualizamos la interfaz visual
                    Me.EliminarRemesaCheckBox.Checked = True
                    Me.EliminarRemesaCheckBox.Text = "Eliminado"
                    Me.EliminarRemesaCheckBox.Enabled = False

                    MsgBox("Registros de la tabla Remesas eliminados con éxito.", MsgBoxStyle.Information, "Eliminar remesas")

                Catch ex As Exception
                    ' Si algo falla, revertimos y dejamos el CheckBox intacto en "No eliminada"
                    If transaccion IsNot Nothing Then
                        transaccion.Rollback()
                    End If

                    MsgBox("Error crítico, no se pudo realizar la acción de eliminar registros." & vbCrLf & "Detalle: " & ex.Message, MsgBoxStyle.Critical, "Error de actualización")
                Finally
                    conexion.Close()
                End Try
            End Using

            ' 3. 🔥 NUEVO ORDEN: Refrescamos la rejilla con el .FillBy de forma segura FUERA de la transacción
            Try
                Me.RemesasTableAdapter.FillBy(Me.DataSet1.remesas)
            Catch ex As Exception
                ' Falla silenciosa si solo es un refresco visual
            End Try

        Else
            MsgBox("Los registros ya han sido eliminados, continúa con el siguiente paso", MsgBoxStyle.Information, "Eliminar remesas")
        End If

        Me.Button2.Image = My.Resources.door_out
        Me.Button2.Text = "Salir"
    End Sub
End Class
