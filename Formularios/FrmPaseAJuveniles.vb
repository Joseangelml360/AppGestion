Public Class FrmPaseAJuveniles
    Private Sub FrmPaseAJuveniles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.FECHA_NACToolStripTextBox.Text = PasejuvenilTextBox.Text
        Me.Label1.Text = "Pase Infantil a Juvenil"
        Try
            Me.InfantilPaseJuvenilTableAdapter.FillPaseJuvenil(Me.ReportsDataSet.InfantilPaseJuvenil,
                                                               CType(FECHA_NACToolStripTextBox.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
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
        Else
            EstadoTableAdapter.UpdateEstadoCambioComision()
            EstadoTableAdapter.Fill(DataSet1.estado)
            AsignarCambioComisiónInfCheckBox.Text = "Juveniles asignado"
            AsignarCambioComisionJuvCheckBox.Text = "Mayores asignado"

        End If

        Try
            InfantilPaseJuvenilTableAdapter.UpdateInfantilAJuvenil(CType(PasejuvenilTextBox.Text, Date))
            InfantilPaseJuvenilTableAdapter.UpdateJuvenilAMayor(CType(PasemayorTextBox.Text, Date))

        Catch ex As Exception
            MsgBox("Cambio de comision realizado")
        End Try
    End Sub

End Class