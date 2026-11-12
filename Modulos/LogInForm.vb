Imports System.IO
Public Class LogInForm
    Private Sub LogInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.control_versiones' Puede moverla o quitarla según sea necesario.
        Me.Control_versionesTableAdapter.FillByUltVersion(Me.DbcensosDataSet.control_versiones)

        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.DbcensosDataSet.rol)
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DbcensosDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DbCensos.ejercicio)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.Label2.Visible = False
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)

        ValidarVersion()
    End Sub

    Private Sub ValidarVersion()
        ' Obtener la versión que tiene este ejecutable ejecutándose ahora mismo
        Dim versionLocal As String = Application.ProductVersion

        Dim versionRemota As String = ""
        Dim urlDescarga As String = ""

        ' Validamos que el DataSet haya traído por lo menos una fila de MariaDB
        If Me.DbcensosDataSet.control_versiones.Rows.Count > 0 Then
            ' Tomamos la primera fila (que gracias a "FillByUltVersion" es la última versión)
            Dim filaVersion As DataRow = Me.DbcensosDataSet.control_versiones.Rows(0)

            ' Extraemos los datos reales de las columnas de tu base de datos
            versionRemota = filaVersion("num_version").ToString()
            urlDescarga = filaVersion("url_zip").ToString()
        Else
            ' Si la tabla en la base de datos está vacía, salimos de la función y no actualizamos
            Exit Sub
        End If

        ' Comparas si la versión de la base de datos es distinta a la local
        If versionRemota <> versionLocal Then
            MessageBox.Show("Hay una nueva versión disponible (" & versionRemota & "). La aplicación se actualizará automáticamente.", "Actualización disponible", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Lanzas el actualizador independiente pasándole la URL de GitHub
            Dim rutaActualizador As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Actualizador.exe")

            If File.Exists(rutaActualizador) Then
                ' Creamos una configuración de arranque avanzada para el proceso
                Dim infoArranque As New ProcessStartInfo()
                infoArranque.FileName = rutaActualizador
                infoArranque.Arguments = """" & urlDescarga & """ ""AppGestion""""" ' Le pasamos la URL de GitHub 

                ' Obliga a Windows a pedir el consentimiento de Administrador (Escudo UAC)
                infoArranque.Verb = "runas"

                ' 🛡️ ESCUDO CONTRA DIRECTIVAS DE WINDOWS:
                ' Envolvemos el arranque para interceptar bloqueos rígidos del sistema operativo (AppLocker/WDAC)
                Try
                    Process.Start(infoArranque)
                    ' Cierras la aplicación principal inmediatamente si el arranque fue exitoso
                    Application.Exit()
                Catch ex As Exception
                    ' Si las directivas de Windows impiden el inicio del proceso, informamos sin romper el programa
                    MessageBox.Show("Una directiva de seguridad de Windows impidió ejecutar la actualización automática." & vbCrLf & vbCrLf &
                                    "Por favor, cierra la aplicación, haz clic derecho sobre 'AppGestion.exe' y selecciona 'Ejecutar como administrador' para permitir la instalación." & vbCrLf &
                                    "Detalle técnico: " & ex.Message, "Control de Aplicaciones Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                MessageBox.Show("No se encuentra el archivo 'Actualizador.exe' en la carpeta.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
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