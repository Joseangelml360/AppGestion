Imports MySql.Data.MySqlClient

Public Class FrmIniciarEjercicio
    Private Sub FrmIniciarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.EstablecerValoresInicioCheckBox.Checked = True Then
            Me.EstablecerValoresInicioCheckBox.Text = "Generado"
        End If
        Me.BtnPasarDatos.Enabled = True
        Me.BtnGenerar.Enabled = False
        Me.Label8.Text = ""

    End Sub

    Private Sub BtnPasarDatos_Click(sender As Object, e As EventArgs) Handles BtnPasarDatos.Click
        Me.TxtAñoEjeNew.Text = Val(Me.AñoejeTextBox.Text) + 1
        Me.TxtDiaInf.Text = Me.DiainfantilTextBox.Text
        Me.TxtMesInf.Text = Me.MesinfantilTextBox.Text
        Me.TxtAñoInf.Text = Val(Me.AñoinfantilTextBox.Text) + 1
        Dim sFecha1 As String
        sFecha1 = Me.PasejuvenilDateTimePicker.Value.AddYears(1)
        Me.TxtFechaPaseInf.Text = sFecha1.ToString
        Me.TxtDiaJuv.Text = Me.DiajuvenilTextBox.Text
        Me.TxtMesJuv.Text = Me.MesjuvenilTextBox.Text
        Me.TxtAñoJuv.Text = Val(Me.AñojuvenilTextBox.Text) + 1
        sFecha1 = Me.PasemayorDateTimePicker.Value.AddYears(1)
        Me.TxtAñoPaseJuv.Text = sFecha1.ToString
        Me.TxtAño0_3.Text = Me.Año0_3Textbox.Text + 1
        Me.TxtMes0_3.Text = Me.Mes0_3Textbox.Text
        Me.TxtDia0_3.Text = Me.Dia0_3Textbox.Text
        sFecha1 = Me.Pase0_3DateTimePicker1.Value.AddYears(1)
        Me.TxtFechapase0_3.Text = sFecha1.ToString
        Me.Label8.Text = "Haga click en Generar"
        Me.BtnPasarDatos.Enabled = False
        Me.BtnGenerar.Enabled = True

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub


    Private Sub TxtDiaInf_TextChanged(sender As Object, e As EventArgs) Handles TxtDiaInf.TextChanged
        Datejuv()
    End Sub

    Private Sub Datejuv()
        Dim sfecha As String
        sfecha = Me.TxtDiaInf.Text & "/" & Me.TxtMesInf.Text & "/" & Me.TxtAñoInf.Text
        Me.TxtFechaPaseInf.Text = sfecha
    End Sub

    Private Sub TxtMesInf_TextChanged(sender As Object, e As EventArgs) Handles TxtMesInf.TextChanged
        Datejuv()
    End Sub

    Private Sub TxtAñoInf_TextChanged(sender As Object, e As EventArgs) Handles TxtAñoInf.TextChanged
        Datejuv()
    End Sub

    Private Sub DateMayor()
        Dim sfecha As String
        sfecha = Me.TxtDiaJuv.Text & "/" & Me.TxtMesJuv.Text & "/" & Me.TxtAñoJuv.Text
        Me.TxtAñoPaseJuv.Text = sfecha
    End Sub

    Private Sub TxtDiaJuv_TextChanged(sender As Object, e As EventArgs) Handles TxtDiaJuv.TextChanged
        DateMayor()

    End Sub

    Private Sub TxtMesJuv_TextChanged(sender As Object, e As EventArgs) Handles TxtMesJuv.TextChanged
        DateMayor()

    End Sub

    Private Sub TxtAñoJuv_TextChanged(sender As Object, e As EventArgs) Handles TxtAñoJuv.TextChanged
        DateMayor()

    End Sub

    Private Sub TxtDia0_3_TextChanged(sender As Object, e As EventArgs) Handles TxtDia0_3.TextChanged
        DateInf()

    End Sub

    Private Sub TxtMes0_3_TextChanged(sender As Object, e As EventArgs) Handles TxtMes0_3.TextChanged
        DateInf()

    End Sub

    Private Sub TxtAño0_3_TextChanged(sender As Object, e As EventArgs) Handles TxtAño0_3.TextChanged
        DateInf()

    End Sub

    Private Sub DateInf()
        Dim sfecha As String
        sfecha = Me.TxtDia0_3.Text & "/" & Me.TxtMes0_3.Text & "/" & Me.TxtAño0_3.Text
        Me.TxtFechapase0_3.Text = sfecha
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dim nEje, nResult As Integer
        Dim cdiainf, cmesinf, cañoinf, cdiajuv, cmesjuv, cañojuv, cdia03, cmes03, caño03 As String
        Dim dtPaseInf, dtPaseMay, dtPase03 As Date

        nResult = MsgBox("¿Estas seguro que quieres generar un nuevo ejercicio?." & vbCrLf & "Este proceso es irreversible", vbOKCancel + vbQuestion, "Confirmación")
        If nResult <> vbOK Then
            MsgBox("Cancelado", MsgBoxStyle.Information, "Información")
            Exit Sub ' Usamos Exit Sub en lugar de Close() si el usuario cancela por error
        End If

        nEje = Val(Me.TxtAñoEjeNew.Text)
        cdia03 = Me.TxtDia0_3.Text
        cmes03 = Me.TxtMes0_3.Text
        caño03 = Me.TxtAño0_3.Text
        cdiainf = Me.TxtDiaInf.Text
        cmesinf = Me.TxtMesInf.Text
        cañoinf = Me.TxtAñoInf.Text
        cdiajuv = Me.TxtDiaJuv.Text
        cmesjuv = Me.TxtMesJuv.Text
        cañojuv = Me.TxtAñoJuv.Text

        dtPase03 = CType(TxtFechapase0_3.Text, Date)
        dtPaseInf = CType(TxtFechaPaseInf.Text, Date)
        dtPaseMay = CType(TxtAñoPaseJuv.Text, Date)

        ' 1. Abrimos conexión y transacción con Aiven
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)
            Dim transaccion As MySqlTransaction = Nothing

            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' Vinculamos los adaptadores a la transacción
                Me.EstadoTableAdapter.Connection = conexion
                Me.EjercicioTableAdapter.Connection = conexion

                ' Ejecutamos ambas actualizaciones (Viajan en modo borrador seguro)
                Me.EstadoTableAdapter.UpdateEstadoValoresInicio()

                Me.EjercicioTableAdapter.UpdateInicioPases(nEje, cañoinf, cmesinf, cdiainf, cañojuv, cmesjuv, cdiajuv,
                                                        dtPaseInf, dtPaseMay, cdia03, cmes03, caño03, dtPase03)

                ' 🔥 ¡COMMIT FINAL!: Si ambas queries se ejecutan bien, guardamos de golpe
                transaccion.Commit()

                ' 2. Actualizaciones visuales en los cuadros de texto de la pantalla (SOLO tras el éxito real)
                Me.AñoejeTextBox.Text = nEje
                Me.Dia0_3Textbox.Text = cdia03
                Me.Mes0_3Textbox.Text = cmes03
                Me.Año0_3Textbox.Text = caño03
                Me.DiainfantilTextBox.Text = cdiainf
                Me.MesinfantilTextBox.Text = cmesinf
                Me.AñoinfantilTextBox.Text = cañoinf
                Me.DiajuvenilTextBox.Text = cdiajuv
                Me.MesjuvenilTextBox.Text = cmesjuv
                Me.AñojuvenilTextBox.Text = cañojuv
                Pase0_3DateTimePicker1.Value = dtPase03
                PasejuvenilDateTimePicker.Value = dtPaseInf
                PasemayorDateTimePicker.Value = dtPaseMay

                Me.EstablecerValoresInicioCheckBox.Checked = True
                Me.EstablecerValoresInicioCheckBox.Text = "Generado"
                Me.BtnGenerar.Enabled = False

                ' Limpieza de campos temporales
                Me.TxtAño0_3.Text = ""
                Me.TxtMes0_3.Text = ""
                Me.TxtDia0_3.Text = ""
                Me.TxtFechapase0_3.Text = ""
                Me.TxtAñoEjeNew.Text = ""
                Me.TxtDiaInf.Text = ""
                Me.TxtMesInf.Text = ""
                Me.TxtAñoInf.Text = ""
                Me.TxtFechaPaseInf.Text = ""
                Me.TxtDiaJuv.Text = ""
                Me.TxtMesJuv.Text = ""
                Me.TxtAñoJuv.Text = ""
                Me.TxtAñoPaseJuv.Text = ""

                Me.BtnPasarDatos.Enabled = False
                Me.Label8.Text = ""
                Me.BtnCancelar.Text = "Salir"
                Me.BtnCancelar.Image = My.Resources.door_out

                MsgBox("Valores de inicio establecidos y Ejercicio " & nEje & " generado correctamente.", MsgBoxStyle.Information, "Éxito")

            Catch ex As Exception
                ' ❌ ABORTO: Si algo falla, revertimos y dejamos las tablas intactas
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                MsgBox("Error crítico: No se pudieron establecer los valores de inicio del nuevo ejercicio." & vbCrLf &
                       "Detalle técnico: " & ex.Message, MsgBoxStyle.Critical, "Proceso Abortado")

                ' En caso de error, preferimos mantener el formulario abierto para que puedan reintentar
                Exit Sub
            Finally
                conexion.Close()
            End Try
        End Using

        ' Refrescamos el buffer local del DataSet visual de forma aislada y fuera de la transacción
        Try
            Me.EstadoTableAdapter.Fill(DataSet1.estado)
        Catch : End Try
    End Sub


End Class