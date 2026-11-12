Public Class FrmFinalizarEjercicio
    Private Sub FrmFinalizarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter.Fill(Me.DataSet1.historfa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.Button2.Enabled = True
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False
        Me.BtnNuevo.Visible = False

        If Me.ChkExportRemesas.Checked = True Then
            Me.PictureBox1.Image = My.Resources.aprobado
            Me.Button3.Enabled = True
            Me.Button2.Enabled = False
            If Me.ChkEliminarRemesa.Checked = True Then
                Me.PictureBox2.Image = My.Resources.aprobado
                Me.Button2.Enabled = False
                Me.Button3.Enabled = False
                Me.Button4.Enabled = True
            End If
            If Me.ChkCopiarCenso.Checked = True Then
                Me.PictureBox3.Image = My.Resources.aprobado
                Me.Button4.Enabled = False
            End If
        End If
        For Each c As Control In GroupBox2.Controls
            c.Enabled = False
        Next
        If ChkCopiarCenso.Checked = True Then
            Me.Button6.Enabled = True
        End If

        If EstablecerValoresInicioCheckBox.Checked = True Then
            Button6.Enabled = False
            PictureBox4.Image = My.Resources.aprobado
            If AsignarCambioComisiónInfCheckBox.Checked = True Then
                Button7.Enabled = False
                PictureBox5.Image = My.Resources.aprobado
                If AsignarCambioComisionJuvCheckBox.Checked = True Then
                    Button8.Enabled = False
                    PictureBox6.Image = My.Resources.aprobado
                    If AsignarCuotaNuevaCheckBox.Checked = True Then
                        Button9.Enabled = False
                        PictureBox7.Image = My.Resources.aprobado
                        If AsignarDtoNuevoCheckBox.Checked = True Then
                            Button10.Enabled = False
                            PictureBox8.Image = My.Resources.aprobado
                            If AsignarValoresFalleroCheckBox.Checked = True Then
                                Button11.Enabled = False
                                PictureBox9.Image = My.Resources.aprobado
                            Else
                                Button11.Enabled = True
                                PictureBox9.Image = Nothing
                            End If
                        Else
                            Button10.Enabled = True
                            PictureBox8.Image = Nothing
                            Button11.Enabled = False
                            PictureBox9.Image = Nothing
                        End If
                    Else
                        Button9.Enabled = True
                        PictureBox7.Image = Nothing
                        Button10.Enabled = False
                        PictureBox8.Image = Nothing
                        Button11.Enabled = False
                        PictureBox9.Image = Nothing
                    End If
                Else
                    Button8.Enabled = True
                    PictureBox6.Image = Nothing
                    Button9.Enabled = False
                    PictureBox7.Image = Nothing
                    Button10.Enabled = False
                    PictureBox8.Image = Nothing
                    Button11.Enabled = False
                    PictureBox9.Image = Nothing
                End If

            Else
                Button7.Enabled = True
                PictureBox5.Image = Nothing
                Button8.Enabled = False
                PictureBox6.Image = Nothing
                Button9.Enabled = False
                PictureBox7.Image = Nothing
                Button10.Enabled = False
                PictureBox8.Image = Nothing
                Button11.Enabled = False
                PictureBox9.Image = Nothing
            End If
        Else
            Button6.Enabled = True
            PictureBox4.Image = Nothing
            Button7.Enabled = False
            PictureBox5.Image = Nothing
            Button8.Enabled = False
            PictureBox6.Image = Nothing
            Button9.Enabled = False
            PictureBox7.Image = Nothing
            Button10.Enabled = False
            PictureBox8.Image = Nothing
            Button11.Enabled = False
            PictureBox9.Image = Nothing
        End If
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        Me.PictureBox10.Visible = False
        Dim n As Integer = 0
        For Each c As CheckBox In GroupBox3.Controls
            If c.Checked = True Then
                n += 1
            End If
        Next
        If n = 6 Then
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.PictureBox10.Visible = True
            Me.Button1.Text = "Salir"
            Me.Button1.Image = My.Resources.door_out
            Me.BtnNuevo.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmExportarRemesas.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If Me.ChkExportRemesas.Checked = True Then
            Me.PictureBox1.Image = My.Resources.aprobado
            Me.Button2.Enabled = False
            Me.Button3.Enabled = Enabled

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'FrmEstadoFinalizar.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmEliminarRemesa.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If Me.ChkEliminarRemesa.Checked = True Then
            Me.PictureBox2.Image = My.Resources.aprobado
            Me.Button3.Enabled = False
            Me.Button4.Enabled = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim bExp, bElim, bCopiar As Boolean

        FrmAñadirCensoAHistorfa.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If Me.ChkCopiarCenso.Checked = True Then
            Me.PictureBox3.Image = My.Resources.aprobado
            Me.Button4.Enabled = False
            Me.Button6.Enabled = True
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmIniciarEjercicio.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)


        If EstablecerValoresInicioCheckBox.Checked = True Then
            Me.PictureBox4.Image = My.Resources.aprobado
            EstablecerValoresInicioCheckBox.Enabled = False
            Me.Button6.Enabled = False
            Me.Button7.Enabled = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmPaseAJuveniles.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If AsignarCambioComisiónInfCheckBox.Checked = True Then
            Me.PictureBox5.Image = My.Resources.aprobado
            AsignarCambioComisiónInfCheckBox.Enabled = False
            Me.Button7.Enabled = False
            Me.Button8.Enabled = True
        End If

        If AsignarCambioComisionJuvCheckBox.Checked = True Then
            Me.PictureBox6.Image = My.Resources.aprobado
            AsignarCambioComisionJuvCheckBox.Enabled = False
            Me.Button8.Enabled = False
            Me.Button9.Enabled = True
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FrmAsignarCuotas.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If AsignarCuotaNuevaCheckBox.Checked = True Then
            Me.PictureBox7.Image = My.Resources.aprobado
            AsignarCuotaNuevaCheckBox.Enabled = False
            Me.Button9.Enabled = False
            Me.Button10.Enabled = True
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FrmDescuentos.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If AsignarDtoNuevoCheckBox.Checked = True Then
            Me.PictureBox8.Image = My.Resources.aprobado
            AsignarDtoNuevoCheckBox.Enabled = False
            Me.Button10.Enabled = False
            Me.Button11.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FrmAsignarValorInicioAFallero.ShowDialog()
        Me.EstadoTableAdapter.Fill(DataSet1.estado)

        If AsignarValoresFalleroCheckBox.Checked = True Then
            Me.PictureBox9.Image = My.Resources.aprobado
            AsignarValoresFalleroCheckBox.Enabled = False
        End If
        Me.Label5.Visible = True
        Me.Label6.Visible = True
        Me.PictureBox10.Visible = True
        Me.Button1.Text = "Salir"
        Me.Button1.Image = My.Resources.door_out
        Me.Button11.Enabled = False

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If MsgBox("Iniciar ejercicio NUEVO" & vbCrLf & "¿Estás seguro?. Se inicializarán contadores
                    para cerrar ejercico e iniciar uno nuevo", vbYesNo) = 6 Then
            Try
                EstadoTableAdapter.UpdateIniciar()
                EstadoTableAdapter.Fill(DataSet1.estado)
                Me.Button2.Enabled = True
                Me.PictureBox1.Image = Nothing
                Me.PictureBox2.Image = Nothing
                Me.PictureBox3.Image = Nothing
                Me.PictureBox4.Image = Nothing
                Me.PictureBox5.Image = Nothing
                Me.PictureBox6.Image = Nothing
                Me.PictureBox7.Image = Nothing
                Me.PictureBox8.Image = Nothing
                Me.PictureBox9.Image = Nothing
                Me.PictureBox10.Image = Nothing
                Me.Label5.Visible = False
                Me.Label6.Visible = False

            Catch ex As Exception
                MsgBox("Error al inicializar contadores")
            End Try

        End If
    End Sub

End Class