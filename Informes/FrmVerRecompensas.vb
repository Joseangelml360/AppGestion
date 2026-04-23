Imports Microsoft.Reporting.WinForms

Public Class FrmVerRecompensas

    Private sfiltro As String


    Private Sub FrmVerRecompensas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensasejercicio' Puede moverla o quitarla según sea necesario.
        Me.recompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        sfiltro = Me.LblFiltro.Text
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)

        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
        ContarRecompensas()
        Me.LblFiltro.Text = "Todas las recompensas"
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub ContarRecompensas()

        Dim i, nRecsFalla, nRecsJCF, nCodREC As Integer
        Dim nJCF1, nJCF2, nJCF3, nJCF4, nJCF5, nJCF11, nJCF12, nJCF13 As Integer
        Dim nFal1, nFal2, nFal3, nFal4, nFal6, nFal8 As Integer

        Dim dtRecs As DataTable = (DataSet1.recompensasejercicio)

        For i = 0 To dtRecs.Rows.Count - 1
            If Val(dtRecs.Rows(i)("RECJF".ToString)) > 0 Then
                nCodREC = Val(dtRecs.Rows(i)("RECJF".ToString))
                nRecsJCF += 1
                Select Case nCodREC
                    Case 1
                        nJCF1 += 1
                    Case 2
                        nJCF2 += 1
                    Case 3
                        nJCF3 += 1
                    Case 4
                        nJCF4 += 1
                    Case 5
                        nJCF5 += 1
                    Case 11
                        nJCF11 += 1
                    Case 12
                        nJCF12 += 1
                    Case 13
                        nJCF13 += 1
                End Select
            End If

            If Val(dtRecs.Rows(i)("RECFALLA".ToString)) > 0 Then
                nRecsFalla += 1
                nCodREC = Val(dtRecs.Rows(i)("RECFALLA".ToString))
                Select Case nCodREC
                    Case 1
                        nFal1 += 1
                    Case 2
                        nFal2 += 1
                    Case 3
                        nFal3 += 1
                    Case 4
                        nFal4 += 1
                    Case 6
                        nFal6 += 1
                    Case 8
                        nFal8 += 1
                End Select
            End If

        Next
        Me.LblRecsFalla.Text = "Nº Recompensas Falla: " + nRecsFalla.ToString
        Me.LblRecsJCF.Text = "Nº Recompensas JCF: " + nRecsJCF.ToString
        Me.LblF1.Text = nFal1
        Me.LblF2.Text = nFal2
        Me.LblF3.Text = nFal3
        Me.LblF4.Text = nFal4
        Me.LblF6.Text = nFal6
        Me.LblF8.Text = nFal8
        Me.LblJ1.Text = nJCF1
        Me.LblJ2.Text = nJCF2
        Me.LblJ3.Text = nJCF3
        Me.LblJ4.Text = nJCF4
        Me.LblJ5.Text = nJCF5
        Me.LblJ11.Text = nJCF11
        Me.LblJ12.Text = nJCF12
        Me.LblJ13.Text = nJCF13
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click

        If RbtFalla.Checked = True And RbtInfantiles.Checked = True Then
            Me.recompensasejercicioTableAdapter.FillByInfFalla(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Infantiles Falla"
            sfiltro = Me.LblFiltro.Text
            Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
            Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
            Me.ReportViewer1.RefreshReport()

        End If
        If RbtFalla.Checked = True And RbtMayores.Checked = True Then
            Me.recompensasejercicioTableAdapter.FillByMayFalla(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Mayores Falla"
            sfiltro = Me.LblFiltro.Text
            Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
            Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
            Me.ReportViewer1.RefreshReport()

        End If
        If RbtJCF.Checked = True And RbtInfantiles.Checked = True Then
            Me.recompensasejercicioTableAdapter.FillByInfJCF(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Infantiles JCF"
            sfiltro = Me.LblFiltro.Text
            Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
            Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
            Me.ReportViewer1.RefreshReport()

        End If
        If RbtJCF.Checked = True And RbtMayores.Checked = True Then
            Me.recompensasejercicioTableAdapter.FillByMayJCF(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Mayores JCF"
            sfiltro = Me.LblFiltro.Text
            Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
            Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
            Me.ReportViewer1.RefreshReport()

        End If
        If RbtFallaJCF.Checked = True And RbtMayores.Checked = True Then
            Me.recompensasejercicioTableAdapter.FillByMayores(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Mayores todas"
            sfiltro = Me.LblFiltro.Text
            Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
            Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
            Me.ReportViewer1.RefreshReport()

        End If
        If RbtFallaJCF.Checked = True And RbtInfantiles.Checked = True Then
            Me.recompensasejercicioTableAdapter.FillByInfantiles(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Infantiles todas"
            sfiltro = Me.LblFiltro.Text
            Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
            Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
            Me.ReportViewer1.RefreshReport()

        End If

        ContarRecompensas()
    End Sub

    Private Sub BtnBorrarFiltro_Click(sender As Object, e As EventArgs) Handles BtnBorrarFiltro.Click
        Me.recompensasejercicioTableAdapter.Fill(DataSet1.recompensasejercicio)
        Me.LblFiltro.Text = "Todas las recompensas"
        sfiltro = Me.LblFiltro.Text
        Dim parametroFiltro As New ReportParameter("FiltroAplicado", sfiltro)
        Me.ReportViewer1.LocalReport.SetParameters(parametroFiltro)
        Me.ReportViewer1.RefreshReport()
        Me.RbtMayores.Checked = False
        Me.RbtInfantiles.Checked = False
        Me.RbtFalla.Checked = False
        Me.RbtJCF.Checked = False
        Me.RbtFallaJCF.Checked = False
        ContarRecompensas()
    End Sub
End Class