Imports MySql.Data.MySqlClient

Public Class FrmPaseAJuveniles
    Private Sub FrmPaseAJuveniles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        ' 2. 🔥 NUEVA UBICACIÓN: Validamos el estado actual NADA MÁS ABRIR la ventana
        ' Si en tu base de datos (DataSet1.estado) la bandera indica que ya se hicieron los pases,
        ' bloqueamos el botón y cambiamos los textos de inmediato.
        If Me.AsignarCambioComisionJuvCheckBox.Checked = True AndAlso Me.AsignarCambioComisiónInfCheckBox.Checked = True Then
            Me.BtnCambios.Enabled = False
            Me.AsignarCambioComisiónInfCheckBox.Text = "Juveniles asignado"
            Me.AsignarCambioComisionJuvCheckBox.Text = "Mayores asignado"

            ' Proactivamente enfocamos el botón de cerrar para comodidad del usuario
            'Me.BtnCerrar.focus()
        Else
            ' Si no se han hecho, aseguramos que el botón esté activo para operar
            Me.BtnCambios.Enabled = False
            Me.AsignarCambioComisiónInfCheckBox.Text = "Juveniles sin asignar" ' O el texto por defecto que uses
            Me.AsignarCambioComisionJuvCheckBox.Text = "Mayores sin asignar"

        End If

        Me.FECHA_NACToolStripTextBox.Text = PasejuvenilTextBox.Text
        Me.Label1.Text = "Pase Infantil a Juvenil"
        Try
            Me.InfantilPaseJuvenilTableAdapter.FillPaseJuvenil(Me.ReportsDataSet.InfantilPaseJuvenil,
                                                               CType(FECHA_NACToolStripTextBox.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        MsgBox("Pulsa Ver informe y guarda un pdf de cada para consultar los cambios." & vbCrLf &
                   "Después pulsa el botón Cambios para ejecutar automáticamente los pases")
    End Sub

    Private Sub FillPaseJuvenilToolStripButton_Click(sender As Object, e As EventArgs) Handles FillPaseJuvenilToolStripButton.Click
        Me.FECHA_NACToolStripTextBox.Text = PasejuvenilTextBox.Text
        Me.Label1.Text = "Pase Infantil a Juvenil"
        Try
            Me.InfantilPaseJuvenilTableAdapter.FillPaseJuvenil(Me.ReportsDataSet.InfantilPaseJuvenil, CType(FECHA_NACToolStripTextBox.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmVerPases.Show()
        Me.BtnCambios.Enabled = True

    End Sub

    Private Sub BtnPaseMayor_Click(sender As Object, e As EventArgs) Handles BtnPaseMayor.Click
        Me.FECHA_NACToolStripTextBox.Text = PasemayorTextBox.Text
        Me.Label1.Text = "Pase Juvenil a Mayor"
        Try
            Me.InfantilPaseJuvenilTableAdapter.FillByPaseMayor(Me.ReportsDataSet.InfantilPaseJuvenil, CType(FECHA_NACToolStripTextBox.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub

    Private Sub BtnCambios_Click(sender As Object, e As EventArgs) Handles BtnCambios.Click
        If AsignarCambioComisionJuvCheckBox.Checked = True Then
            If AsignarCambioComisiónInfCheckBox.Checked = True Then
                BtnCambios.Enabled = False
                AsignarCambioComisiónInfCheckBox.Text = "Juveniles asignado"
                AsignarCambioComisionJuvCheckBox.Text = "Mayores asignado"
            End If
        End If

        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)

            Dim transaccion As MySqlTransaction = Nothing

            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Me.InfantilPaseJuvenilTableAdapter.Connection = conexion
                Me.EstadoTableAdapter.Connection = conexion

                InfantilPaseJuvenilTableAdapter.UpdateInfantilAJuvenil(CType(PasejuvenilTextBox.Text, Date))
                InfantilPaseJuvenilTableAdapter.UpdateJuvenilAMayor(CType(PasemayorTextBox.Text, Date))
                EstadoTableAdapter.UpdateEstadoCambioComision()

                transaccion.Commit()

                MsgBox("Pases de comisión realizados con éxito", MsgBoxStyle.Information, "Pases de comisión")

                AsignarCambioComisiónInfCheckBox.Text = "Juveniles asignado"
                AsignarCambioComisionJuvCheckBox.Text = "Mayores asignado"

            Catch ex As Exception
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If
                MsgBox("Pases de comision no realizados", MsgBoxStyle.Critical, "Error en Pases de comisión")
            Finally
                ' Cerramos la conexión de forma limpia pase lo que pase
                conexion.Close()
            End Try
        End Using
        Try
            Me.EstadoTableAdapter.Fill(DataSet1.estado)
            Me.BtnCambios.Enabled = False
        Catch : End Try
    End Sub

End Class