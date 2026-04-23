'Option Explicit On
'Option Strict On
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class FrmRecompEjercicio

    Private Sub FrmRecompEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        Me.BtnCancelar.Visible = False
        Me.BtnGenerar.Visible = True

        AddHandler BackgroundWorker1.DoWork, AddressOf BackgroundWorker1_DoWork
        AddHandler BackgroundWorker1.ProgressChanged, AddressOf BackgroundWorker1_ProgressChanged
        AddHandler BackgroundWorker1.RunWorkerCompleted, AddressOf BackgroundWorker1_RunWorkerCompleted

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Fallero1' Puede moverla o quitarla según sea necesario.
        Me.Fallero1TableAdapter.FillByActivos(Me.DataSet1.Fallero1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter.Fill(Me.DataSet1.historfa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.criteriorecomp' Puede moverla o quitarla según sea necesario.
        Me.CriteriorecompTableAdapter.Fill(Me.DataSet1.criteriorecomp)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensasejercicio' Puede moverla o quitarla según sea necesario.
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Size = New Drawing.Size(750, 700)
        Me.ProgressBar1.Visible = False
        Me.Label2.Text = "Recompensas del ejercicio " + AnoejeTextBox.Text
        Me.LblProgreso.Visible = False
        Me.LblFiltro.Text = "Todas las recompensas"

        ContarRecompensas()

    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click

        Me.ProgressBar1.Value = 0
        Me.RecompensasejercicioTableAdapter.DeleteQuery()
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
        Me.BtnGenerar.Visible = False
        Me.BtnCancelar.Visible = True
        Me.LblProgreso.ForeColor = Color.FromArgb(0, 192, 0)

        If Not BackgroundWorker1.IsBusy Then
            BackgroundWorker1.RunWorkerAsync()
        End If

        ContarRecompensas()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)

        Dim nFUltRecJCF, nFUltRecFal, nRecFal, nRecJCF, nRecAgrup, nNumEjeJCF, nNumEjeFal, nNumEjeCargo As Integer
        Dim nEje, nFTipFal, nFCargo, nCRCodRec, nCRNumeje, nCRNumcargo, nCRMinCargo, nFalCen As Integer
        Dim cFNom, cFApelli, cFDNI
        Dim r, i, h As Integer
        Dim nFCodJCF, nFCodFal As Double
        Dim ValRecJCF, ValRecFal As Integer

        Dim dt As DataTable = DataSet1.Fallero1
        Dim dt1 As DataTable = DataSet1.criteriorecomp
        Dim dt2 As DataTable = DataSet1.recompensasejercicio
        Dim Dgv, Dgv1 As New DataGridView

        Invoke(Sub()
                   Me.ProgressBar1.Maximum = dt.Rows.Count
                   Me.ProgressBar1.Minimum = 0
                   Me.ProgressBar1.Value = 0
                   Me.ProgressBar1.Visible = True
                   LblProgreso.Visible = True
                   LblProgreso.Text = ""

               End Sub)


        nEje = Val(Me.AnoejeTextBox.Text)

        r = dt.Rows.Count - 1
        For i = 0 To r Step 1

            If BackgroundWorker1.CancellationPending Then  'Comprobar si se ha pulsado el botón Cancelar
                e.Cancel = True
                Exit For
            End If

            ValRecFal = 0
            ValRecJCF = 0
            nFTipFal = Val(dt.Rows(i)("TIPFAL".ToString))
            nFCodFal = Val(dt.Rows(i)("FALLERO_CODIGO".ToString))
            nFCargo = Val(dt.Rows(i)("ULTCAR".ToString))
            cFNom = dt.Rows(i)("NOMBRE".ToString)
            cFApelli = dt.Rows(i)("APELLIDOS".ToString)
            nFalCen = Val(dt.Rows(i)("FAL_CEN".ToString))
            cFDNI = dt.Rows(i)("DNI".ToString)
            If String.IsNullOrEmpty(cFDNI) Then
                cFDNI = "00000000T"
            End If

            If IsDBNull(dt.Rows(i)("COD_JCF".ToString)) = True Then
                nFCodJCF = 0
            Else
                nFCodJCF = Val(dt.Rows(i)("COD_JCF".ToString))
            End If

            If Val(dt.Rows(i)("COD_REC".ToString)) = Nothing Then
                nFUltRecJCF = 0
            Else
                nFUltRecJCF = Val(dt.Rows(i)("COD_REC".ToString))
            End If

            'Cálculo de recompensas de JCF
            nRecJCF = 0
            Select Case nFTipFal

                Case 1
                    ValRecJCF = 0

                    If nFUltRecJCF < 5 And nFCargo < 22 And nFCodJCF > 0 Then
                        nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 1) + 1 + HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 3)
                        nNumEjeCargo = HistorfaTableAdapter.ScalarEjerConCargo(nFCodJCF, 1) + HistorfaTableAdapter.ScalarEjerConCargo(nFCodJCF, 3)
                        If (nFCargo < 20 Or nFCargo = 21) And nFCargo > 0 Then
                            nNumEjeCargo += 1
                        End If

                        For h = 0 To dt1.Rows.Count - 1
                            nCRCodRec = Val(dt1.Rows(h)("CODREC"))

                            'Este If es solo para recompensa 1
                            If nFUltRecJCF = 0 And nCRCodRec = 1 Then
                                If nNumEjeJCF > 1 Then
                                    nRecJCF = 1
                                    ValRecJCF = 1
                                Else
                                    nRecJCF = 0
                                    ValRecJCF = 0
                                End If
                                Exit For
                            End If


                            If nFUltRecJCF > 0 And (nCRCodRec = nFUltRecJCF + 1) Then
                                nCRNumeje = Val(dt1.Rows(h)("NUMEJEFALLERO"))
                                nCRNumcargo = Val(dt1.Rows(h)("NUMEJECARGO"))
                                nCRMinCargo = Val(dt1.Rows(h)("MINEJECARGO"))
                                If nNumEjeCargo < nCRMinCargo Then
                                    If nNumEjeJCF >= nCRNumeje Then
                                        ValRecJCF = 1
                                        nRecJCF = nCRCodRec
                                    End If
                                End If
                                If nNumEjeCargo >= nCRMinCargo And nNumEjeJCF >= nCRNumcargo Then
                                    ValRecJCF = 1
                                    nRecJCF = nCRCodRec
                                End If
                            End If
                            If ValRecJCF = 1 Then 'este IF es nuevo, para no continuar analizando otras recompensas
                                Exit For
                            End If
                        Next
                    End If

                Case 3
                    ValRecJCF = 0
                    nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1

                    If nNumEjeJCF > 1 Then
                        Select Case nFUltRecJCF
                            Case <> 12
                                If nFUltRecJCF > 10 Or nFUltRecJCF = 0 Then
                                    ValRecJCF = 1
                                    nRecJCF = 1
                                End If

                            Case 12
                                ValRecJCF = 1
                                nRecJCF = 13
                        End Select
                    End If

                Case 2
                    ValRecJCF = 0
                    'nFCodJCF = Val(dt.Rows(i)("COD_JCF".ToString))
                    nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1
                    'nNumEjeCargo = HistorfaTableAdapter.ScalarEjerConCargo(nFCodJCF, 2)

                    If nFUltRecJCF = 0 Then  'Sin recompensa en JCF

                        If nFUltRecJCF = 0 And (nFCargo = 1 Or nFCargo = 21) Then 'FMi o PteI aunque sea el primer año
                            ValRecJCF = 1
                            nRecJCF = 11
                        End If

                        If nNumEjeJCF > 1 Then 'Si tiene + de 1 ejercicio
                            ValRecJCF = 1
                            nRecJCF = 11
                        End If

                    ElseIf nFUltRecJCF = 11 Then
                        nCRNumeje = Val(dt1.Rows(7)("NUMEJEFALLERO"))
                        nCRNumcargo = Val(dt1.Rows(7)("NUMEJECARGO"))
                        nCRMinCargo = Val(dt1.Rows(7)("MINEJECARGO"))

                        If nFUltRecJCF = 11 And (nFCargo = 1 Or nFCargo = 21) Then 'FMi o PteI actuales
                            If nCRMinCargo <= nNumEjeCargo And nCRNumcargo >= 4 Then
                                ValRecJCF = 1
                                nRecJCF = 12
                            End If
                        End If

                        If nCRNumeje <= nNumEjeJCF Then
                            ValRecJCF = 1
                            nRecJCF = 12
                        End If

                    ElseIf nFUltRecJCF = 12 Then
                        nCRNumeje = Val(dt1.Rows(8)("NUMEJEFALLERO"))
                        nCRNumcargo = Val(dt1.Rows(8)("NUMEJECARGO"))
                        nCRMinCargo = Val(dt1.Rows(8)("MINEJECARGO"))

                        If nNumEjeJCF >= nCRNumeje Then
                            ValRecJCF = 1
                            nRecJCF = 13
                        Else
                            ValRecJCF = 0
                        End If

                        If (nFCargo = 1 Or nFCargo = 21) Then 'FMi o PteI actuales
                            If nCRMinCargo <= nNumEjeCargo And nCRNumcargo >= 6 Then
                                ValRecJCF = 1
                                nRecJCF = 13
                            End If
                        End If

                    ElseIf nFUltRecJCF = 13 Then
                        ValRecJCF = 0

                    End If


            End Select

            'Cálculo de recompensas de la falla

            nNumEjeFal = HistorfaTableAdapter.ScalarEjeFalla(nFCodJCF) + 1 'Número de años en la comisión
            If nFTipFal = 1 Then
                nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1 + HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 3)
            ElseIf nFTipFal = (2 Or 3) Then
                nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1
            End If
            'nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1 + HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 3)
            If dt.Rows(i)("REC_FAL".ToString) = Nothing Then
                nFUltRecFal = 0
            Else
                nFUltRecFal = Val(dt.Rows(i)("REC_FAL".ToString))
            End If
            nRecFal = 0
            Select Case nFUltRecFal
                Case 0
                    If nNumEjeFal > 1 And nFCargo < 22 Then
                        nRecFal = 1
                        ValRecFal = 1
                    End If
                Case 1
                    If nNumEjeFal > 6 Then
                        nRecFal = 2
                        ValRecFal = 1
                    End If
                Case 2
                    If nNumEjeFal > 9 Then
                        nRecFal = 3
                        ValRecFal = 1
                    End If
                Case Else
                    If nRecJCF = 5 And nFUltRecFal <> 4 Then
                        nRecFal = 4
                        ValRecFal = 1 'nuevo
                    Else
                        nRecFal = 0
                        ValRecFal = 0 'nuevo
                    End If
            End Select

            If nNumEjeFal > 49 And nFUltRecFal <> 8 And nNumEjeJCF > 49 Then
                nRecFal = 8
                ValRecFal = 1
            End If
            'Cálculo de recompensas de la Agrupación

            If nFCargo = 21 Then
                nRecAgrup = 2
            Else
                nRecAgrup = 0
            End If

            If nFTipFal = 2 And nFCargo = 1 Then
                nRecAgrup = 2
            End If

            If nFCargo = 22 Then
                ValRecJCF = 0
                ValRecFal = 0
            End If

            Try
                If (ValRecJCF = 1 Or ValRecFal = 1) And (nFCodJCF > 0) Then
                    Me.RecompensasejercicioTableAdapter.InsertQuery(nFCodJCF, cFNom, cFApelli, nFTipFal, nRecJCF, nRecFal, nRecAgrup, nEje,
                    nFCodFal, cFDNI, nFalCen, nNumEjeJCF, nNumEjeCargo, nFUltRecFal, nFUltRecJCF, nFCargo, nNumEjeFal)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString & " Fallero " & nFCodFal)
            End Try

            Invoke(Sub()
                       Me.ProgressBar1.Value += 1

                   End Sub)
            BackgroundWorker1.ReportProgress(i, $"Registros analizados {i + 1} de {r + 1}")

        Next

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)

        If e.Cancelled Then

            Me.LblProgreso.ForeColor = Color.Red
            Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
            Me.DataGridView1.Refresh()
            Me.ProgressBar1.Value = 0
            Me.BtnCancelar.Visible = False
            Me.BtnGenerar.Visible = True
            MsgBox("Se ha cancelado la acción, faltan registros por añadir", 16, "CANCELADO")
        ElseIf e.Error IsNot Nothing Then
            LblProgreso.Text = "Ha ocurrido un error al Generar"
        Else
            MsgBox("Generar Recompensas ha finalizado con éxito", 64, "Recompensas Asignadas")
            Me.BtnCancelar.Visible = False
            Me.BtnGenerar.Visible = True
            Me.LblProgreso.ForeColor = Color.FromArgb(0, 192, 0)
            LblProgreso.Text = "Registros analizados = " + ProgressBar1.Value.ToString()
            Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
            Me.DataGridView1.Refresh()
        End If

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)

        Me.LblProgreso.Text = CType(e.UserState, String)


    End Sub


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalr.Click
        Me.Close()
    End Sub

    Private Sub BtnListado_Click(sender As Object, e As EventArgs) Handles BtnListado.Click
        Dim frm As New FrmVerRecompensas
        frm.ShowDialog()
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
            Me.RecompensasejercicioTableAdapter.FillByInfFalla(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Infantiles Falla"
        End If
        If RbtFalla.Checked = True And RbtMayores.Checked = True Then
            Me.RecompensasejercicioTableAdapter.FillByMayFalla(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Mayores Falla"
        End If
        If RbtJCF.Checked = True And RbtInfantiles.Checked = True Then
            Me.RecompensasejercicioTableAdapter.FillByInfJCF(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Infantiles JCF"
        End If
        If RbtJCF.Checked = True And RbtMayores.Checked = True Then
            Me.RecompensasejercicioTableAdapter.FillByMayJCF(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Mayores JCF"
        End If
        If RbtFallaJCF.Checked = True And RbtMayores.Checked = True Then
            Me.RecompensasejercicioTableAdapter.FillByMayores(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Mayores todas"
        End If
        If RbtFallaJCF.Checked = True And RbtInfantiles.Checked = True Then
            Me.RecompensasejercicioTableAdapter.FillByInfantiles(DataSet1.recompensasejercicio)
            Me.LblFiltro.Text = "Infantiles todas"
        End If
        Me.DataGridView1.Refresh()
        ContarRecompensas()
    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        Me.RecompensasejercicioTableAdapter.Fill(DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
        Me.LblFiltro.Text = "Todas las recompensas"
        Me.RbtMayores.Checked = False
        Me.RbtInfantiles.Checked = False
        Me.RbtFalla.Checked = False
        Me.RbtJCF.Checked = False
        Me.RbtFallaJCF.Checked = False
        ContarRecompensas()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

End Class