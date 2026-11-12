Imports Microsoft.Reporting.WinForms

Public Class FrmCuotasError
    Private Sub FrmCuotasError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSetCuotas.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.fallero' Puede moverla o quitarla según sea necesario.
        Me.falleroTableAdapter.FillByErrorCuotas(Me.DataSetCuotas.fallero)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
        ' Parámetro para pasar al informe .rdlc
        Dim sfiltro As String
        sfiltro = "errónea según comisión"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub TsError_Click(sender As Object, e As EventArgs) Handles TsError.Click
        Me.falleroTableAdapter.FillByErrorCuotas(Me.DataSetCuotas.fallero)
        Dim sfiltro As String
        sfiltro = "errónea según comisión"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TsCero_Click(sender As Object, e As EventArgs) Handles TsCero.Click
        Me.falleroTableAdapter.FillByCuotaCero(Me.DataSetCuotas.fallero)
        Dim sfiltro As String
        sfiltro = "a cero"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TsCerrar_Click(sender As Object, e As EventArgs) Handles TsCerrar.Click
        Me.Close()

    End Sub

    Private Sub Cuota03AñosVencidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Cuota03AñosVencidaToolStripMenuItem.Click
        Me.Pase0_3DateTimePicker.Visible = True
        Dim dFecha As Date
        dFecha = Pase0_3DateTimePicker.Value
        Me.Pase0_3DateTimePicker.Visible = False
        Me.falleroTableAdapter.FillByCuota03Vencida(Me.DataSetCuotas.fallero, dFecha)
        Dim sfiltro As String
        sfiltro = "0 a 3 años vencida"
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class