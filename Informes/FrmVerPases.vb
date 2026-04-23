Imports Microsoft.Reporting.WinForms

Public Class FrmVerPases
    Private Sub FrmVerPases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.FillAñoPase(Me.ReportsDataSet.ejercicio)
        Me.TSTxtFecha.Text = PasejuvenilTextBox.Text
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.InfantilPaseJuvenil' Puede moverla o quitarla según sea necesario.
        Me.InfantilPaseJuvenilTableAdapter.FillPaseJuvenil(Me.ReportsDataSet.InfantilPaseJuvenil, CType(Me.TSTxtFecha.Text, Date))
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        Dim sfiltro As String
        sfiltro = "Pasa a Juveniles"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSAJuveniles_Click(sender As Object, e As EventArgs) Handles TSAJuveniles.Click
        Me.TSTxtFecha.Text = Me.PasejuvenilTextBox.Text
        Me.InfantilPaseJuvenilTableAdapter.FillPaseJuvenil(Me.ReportsDataSet.InfantilPaseJuvenil, CType(Me.TSTxtFecha.Text, Date))
        Dim sfiltro As String
        sfiltro = "Pasa a Juveniles"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSAMayores_Click(sender As Object, e As EventArgs) Handles TSAMayores.Click
        Me.TSTxtFecha.Text = Me.PasemayorTextBox.Text
        Me.InfantilPaseJuvenilTableAdapter.FillByPaseMayor(Me.ReportsDataSet.InfantilPaseJuvenil, CType(Me.TSTxtFecha.Text, Date))
        Dim sfiltro As String
        sfiltro = "Pasa a Mayores"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSA03_Click(sender As Object, e As EventArgs) Handles TSA03.Click
        Me.TSTxtFecha.Text = Me.Pase03Textbox.Text
        Me.InfantilPaseJuvenilTableAdapter.FillByPase03Infantil(Me.ReportsDataSet.InfantilPaseJuvenil, CType(Me.TSTxtFecha.Text, Date))
        Dim sfiltro As String
        sfiltro = "cuota 0-3 años vencida"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TSCerrar_Click(sender As Object, e As EventArgs) Handles TSCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnEjercicioSiguiente_Click(sender As Object, e As EventArgs) Handles BtnEjercicioSiguiente.Click
        Dim dFechaJuv, dFechaMay, dFecha03 As Date

        If Me.BtnEjercicioSiguiente.Text = "Ejercicio siguiente" Then
            dFechaJuv = CType(Me.PasejuvenilTextBox.Text, Date).AddYears(1)
            dFechaMay = CType(Me.PasemayorTextBox.Text, Date).AddYears(1)
            dFecha03 = CType(Me.Pase03Textbox.Text, Date).AddYears(1)
            Me.PasejuvenilTextBox.Text = dFechaJuv
            Me.PasemayorTextBox.Text = dFechaMay
            Me.Pase03Textbox.Text = dFecha03
            Me.BtnEjercicioSiguiente.Text = "Ejercicio actual"
        Else
            dFechaJuv = CType(Me.PasejuvenilTextBox.Text, Date).AddYears(-1)
            dFechaMay = CType(Me.PasemayorTextBox.Text, Date).AddYears(-1)
            dFecha03 = CType(Me.Pase03Textbox.Text, Date).AddYears(-1)
            Me.PasejuvenilTextBox.Text = dFechaJuv
            Me.PasemayorTextBox.Text = dFechaMay
            Me.Pase03Textbox.Text = dFecha03
            Me.BtnEjercicioSiguiente.Text = "Ejercicio siguiente"
        End If



    End Sub


End Class