Public Class LogInForm
    Private Sub LogInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.DbcensosDataSet.rol)
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DbcensosDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DbCensos.ejercicio)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.Label2.Visible = False

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim nId As Integer
        Dim dt, dt1 As DataTable
        dt = Me.UsuariosTableAdapter.GetDataBy(Me.UsernameTextBox.Text, PasswordTextBox.Text)

        If dt.Rows.Count = 1 Then
            nId = Val(dt.Rows(0)("idusuarios".ToString))

            Try
                nRol = Val(dt.Rows(0)("idrol".ToString))
                dt1 = Me.RolTableAdapter.GetDataBy(nRol)
                user = dt.Rows(0)("nombre".ToString)
                cRol = dt1.Rows(0)("rol".ToString)
                UsuariosTableAdapter.UpdateUserActivo(nId)
                Me.Hide()

                MDIParent1.Show()
                'FrmMensajes.Show()

            Catch ex As Exception
                MsgBox("Usuario o contraseña incorrectos", vbInformation, "Entrada Incorrecta")
            End Try
        Else
            MsgBox("Usuario o contraseña incorrectos", vbInformation, "Entrada Incorrecta")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub EjercicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EjercicioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbCensos)

    End Sub
End Class