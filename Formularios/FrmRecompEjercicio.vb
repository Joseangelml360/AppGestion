Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports System.Text

Public Class FrmRecompEjercicio

    Private Sub FrmRecompEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.BtnCancelar.Visible = False
        Me.BtnGenerar.Visible = True

        ' Carga inicial de datos desde Aiven en los TableAdapters
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        Me.Fallero1TableAdapter.FillByActivos(Me.DataSet1.Fallero1)
        Me.HistorfaTableAdapter.Fill(Me.DataSet1.historfa)
        Me.CriteriorecompTableAdapter.Fill(Me.DataSet1.criteriorecomp)
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)

        Size = New Drawing.Size(750, 700)
        Me.ProgressBar1.Visible = False
        Me.Label2.Text = "Recompensas del ejercicio " + AnoejeTextBox.Text
        Me.LblProgreso.Visible = False
        Me.LblFiltro.Text = "Todas las recompensas"

        ContarRecompensas()
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dim dt As DataTable = DataSet1.Fallero1
        Dim dt1 As DataTable = DataSet1.criteriorecomp

        If dt.Rows.Count = 0 Then
            MsgBox("No hay registros de falleros activos para procesar el cálculo.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = dt.Rows.Count
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True

        Me.LblProgreso.Visible = True
        Me.LblProgreso.ForeColor = Color.FromArgb(0, 192, 0)
        Me.LblProgreso.Text = "Iniciando cálculo de recompensas..."

        Me.RecompensasejercicioTableAdapter.DeleteQuery()
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()

        Me.BtnGenerar.Visible = False
        Me.BtnCancelar.Visible = False

        Application.DoEvents()

        ' Variables de control del algoritmo
        Dim nFUltRecJCF, nFUltRecFal, nRecFal, nRecJCF, nRecAgrup, nNumEjeJCF, nNumEjeFal, nNumEjeCargo As Integer
        Dim nEje, nFTipFal, nFCargo, nCRCodRec, nCRNumeje, nCRNumcargo, nCRMinCargo, nFalCen As Integer
        Dim cFNom, cFApelli, cFDNI As String
        Dim r, i, h As Integer
        Dim nFCodJCF, nFCodFal As Double
        Dim ValRecJCF, ValRecFal As Integer

        ' 🔥 COLECCIÓN DE RESCATE: Registra los socios con datos corruptos
        Dim sociosConError As New StringBuilder()
        Dim contadorErrores As Integer = 0

        nEje = Val(Me.AnoejeTextBox.Text)
        r = dt.Rows.Count - 1

        ' 2. 🔥 PROCESAMIENTO LINEAL DIRECTO EN MEMORIA RAM
        For i = 0 To r Step 1
            nFCodFal = 0
            cFNom = "Desconocido"
            cFApelli = ""

            Try
                Dim filaFallero As DataRow = dt.Rows(i)

                nFTipFal = Val(filaFallero("TIPFAL"))
                nFCodFal = Val(filaFallero("FALLERO_CODIGO"))
                nFCargo = Val(filaFallero("ULTCAR"))
                cFNom = filaFallero("NOMBRE").ToString()
                cFApelli = filaFallero("APELLIDOS").ToString()
                nFalCen = Val(filaFallero("FAL_CEN"))
                cFDNI = filaFallero("DNI").ToString()

                If String.IsNullOrEmpty(cFDNI) Then
                    cFDNI = "00000000T"
                End If

                If IsDBNull(filaFallero("COD_JCF")) Then
                    nFCodJCF = 0
                Else
                    nFCodJCF = Val(filaFallero("COD_JCF"))
                End If

                If IsDBNull(filaFallero("COD_REC")) Then
                    nFUltRecJCF = 0
                    Throw New Exception("Falta Recompensa de JCF en la ficha")
                Else
                    nFUltRecJCF = Val(filaFallero("COD_REC"))
                End If


                ValRecFal = 0
                ValRecJCF = 0

                ' === Bloque A: Cálculo de recompensas de JCF ===
                nRecJCF = 0
                Select Case nFTipFal
                    Case 1
                        ValRecJCF = 0
                        If nFUltRecJCF < 5 AndAlso nFCargo < 22 AndAlso nFCodJCF > 0 Then
                            nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 1) + 1 + HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 3)
                            nNumEjeCargo = HistorfaTableAdapter.ScalarEjerConCargo(nFCodJCF, 1) + HistorfaTableAdapter.ScalarEjerConCargo(nFCodJCF, 3)

                            If (nFCargo < 20 OrElse nFCargo = 21) AndAlso nFCargo > 0 Then
                                nNumEjeCargo += 1
                            End If

                            For h = 0 To dt1.Rows.Count - 1
                                nCRCodRec = Val(dt1.Rows(h)("CODREC"))

                                If nFUltRecJCF = 0 AndAlso nCRCodRec = 1 Then
                                    If nNumEjeJCF > 1 Then
                                        nRecJCF = 1
                                        ValRecJCF = 1
                                    Else
                                        nRecJCF = 0
                                        ValRecJCF = 0
                                    End If
                                    Exit For
                                End If

                                If nFUltRecJCF > 0 AndAlso (nCRCodRec = nFUltRecJCF + 1) Then
                                    nCRNumeje = Val(dt1.Rows(h)("NUMEJEFALLERO"))
                                    nCRNumcargo = Val(dt1.Rows(h)("NUMEJECARGO"))
                                    nCRMinCargo = Val(dt1.Rows(h)("MINEJECARGO"))

                                    If nNumEjeCargo < nCRMinCargo Then
                                        If nNumEjeJCF >= nCRNumeje Then
                                            ValRecJCF = 1
                                            nRecJCF = nCRCodRec
                                        End If
                                    End If
                                    If nNumEjeCargo >= nCRMinCargo AndAlso nNumEjeJCF >= nCRNumcargo Then
                                        ValRecJCF = 1
                                        nRecJCF = nCRCodRec
                                    End If
                                End If

                                If ValRecJCF = 1 Then
                                    Exit For
                                End If
                            Next
                        End If

                    Case 3
                        ValRecJCF = 0
                        nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1

                        If nNumEjeJCF > 1 Then
                            Select Case nFUltRecJCF
                                Case 12
                                    ValRecJCF = 1
                                    nRecJCF = 13
                                Case Else
                                    If nFUltRecJCF > 10 OrElse nFUltRecJCF = 0 Then
                                        ValRecJCF = 1
                                        nRecJCF = 1
                                    End If
                            End Select
                        End If

                    Case 2
                        ValRecJCF = 0
                        nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1

                        If nFUltRecJCF = 0 Then
                            If nFCargo = 1 OrElse nFCargo = 21 Then
                                ValRecJCF = 1
                                nRecJCF = 11
                            End If
                            If nNumEjeJCF > 1 Then
                                ValRecJCF = 1
                                nRecJCF = 11
                            End If
                        ElseIf nFUltRecJCF = 11 Then
                            nCRNumeje = Val(dt1.Rows(7)("NUMEJEFALLERO"))
                            nCRNumcargo = Val(dt1.Rows(7)("NUMEJECARGO"))
                            nCRMinCargo = Val(dt1.Rows(7)("MINEJECARGO"))

                            If nFCargo = 1 OrElse nFCargo = 21 Then
                                If nCRMinCargo <= nNumEjeCargo AndAlso nCRNumcargo >= 4 Then
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

                            If nFCargo = 1 OrElse nFCargo = 21 Then
                                If nCRMinCargo <= nNumEjeCargo AndAlso nCRNumcargo >= 6 Then
                                    ValRecJCF = 1
                                    nRecJCF = 13
                                End If
                            End If
                        ElseIf nFUltRecJCF = 13 Then
                            ValRecJCF = 0
                        End If
                End Select

                ' === Bloque B: Cálculo de recompensas de la Falla ===
                nNumEjeFal = HistorfaTableAdapter.ScalarEjeFalla(nFCodJCF) + 1

                If nFTipFal = 1 Then
                    nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1 + HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, 3)
                ElseIf nFTipFal = 2 OrElse nFTipFal = 3 Then
                    nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nFCodJCF, nFTipFal) + 1
                End If

                If IsDBNull(filaFallero("REC_FAL")) Then
                    nFUltRecFal = 0
                    Throw New Exception("Falta Recompensa de la falla en la ficha")
                Else
                    nFUltRecFal = Val(filaFallero("REC_FAL"))
                End If

                nRecFal = 0
                Select Case nFUltRecFal
                    Case 0
                        If nNumEjeFal > 1 AndAlso nFCargo < 22 Then
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
                        If nRecJCF = 5 AndAlso nFUltRecFal <> 4 Then
                            nRecFal = 4
                            ValRecFal = 1
                        Else
                            nRecFal = 0
                            ValRecFal = 0
                        End If
                End Select

                If nNumEjeFal > 49 AndAlso nFUltRecFal <> 8 AndAlso nNumEjeJCF > 49 Then
                    nRecFal = 8
                    ValRecFal = 1
                End If

                ' === Bloque C: Cálculo de recompensas de la Agrupación ===
                If nFCargo = 21 Then
                    nRecAgrup = 2
                Else
                    nRecAgrup = 0
                End If

                If nFTipFal = 2 AndAlso nFCargo = 1 Then
                    nRecAgrup = 2
                End If

                If nFCargo = 22 Then
                    ValRecJCF = 0
                    ValRecFal = 0
                End If

                ' Inserción final en la base de datos de Aiven
                If (ValRecJCF = 1 OrElse ValRecFal = 1) AndAlso (nFCodJCF > 0) Then
                    Me.RecompensasejercicioTableAdapter.InsertQuery(nFCodJCF, cFNom, cFApelli, nFTipFal, nRecJCF, nRecFal, nRecAgrup, nEje,
                                                                   nFCodFal, cFDNI, nFalCen, nNumEjeJCF, nNumEjeCargo, nFUltRecFal, nFUltRecJCF, nFCargo, nNumEjeFal)
                End If

            Catch ex As Exception
                ' Captura de error individual por socio corrupto sin romper el bucle general
                contadorErrores += 1
                sociosConError.AppendLine($"- Código: {nFCodFal} | Nombre: {cFNom} {cFApelli} | Detalle: {ex.Message}")
            End Try

            ' Actualización de la ProgressBar en tiempo real
            Me.ProgressBar1.Value = i + 1
            Me.LblProgreso.Text = $"Analizando fallero {i + 1} de {dt.Rows.Count}"

            Application.DoEvents()
        Next

        ' === 3. CONCLUSIÓN DEL PROCESO ===
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        Me.DataGridView1.Refresh()
        ContarRecompensas()

        Me.BtnCancelar.Visible = False
        Me.BtnGenerar.Visible = True

        If contadorErrores > 0 Then
            ' 📂 Averigua la ruta del Escritorio de Windows de forma dinámica en cualquier PC
            Dim rutaEscritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            ' Combinamos esa ruta con el nombre de tu archivo de texto
            Dim rutaInforme As String = Path.Combine(rutaEscritorio, "Socios_Omisiones_Recompensas.txt")

            'Escribe el archivo .txt
            File.WriteAllText(rutaInforme, sociosConError.ToString(), Encoding.UTF8)

            MessageBox.Show($"Cálculo de recompensas finalizado con omisiones.{vbCrLf}{vbCrLf}" &
                            $"Se procesaron con éxito {ProgressBar1.Value - contadorErrores} registros.{vbCrLf}" &
                            $"⚠️ Se saltaron {contadorErrores} socios por falta de datos.{vbCrLf}{vbCrLf}" &
                            $"El informe detallado está listo en: {vbCrLf}{rutaInforme}",
                            "Proceso Completado con Advertencias", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' 4. 🔥 Lanzamos el Bloc de notas en el monitor de forma inmediata
            Try
                Process.Start(rutaInforme)
            Catch : End Try
        Else
            MsgBox("Generar Recompensas ha finalizado con éxito total de forma segura.", MsgBoxStyle.Information, "Recompensas Asignadas")
        End If

        Me.LblProgreso.Text = "Registros analizados con éxito = " + (ProgressBar1.Value - contadorErrores).ToString()
    End Sub

    Private Sub ContarRecompensas()
        Dim i, nRecsFalla, nRecsJCF, nCodREC As Integer
        Dim nJCF1, nJCF2, nJCF3, nJCF4, nJCF5, nJCF11, nJCF12, nJCF13 As Integer
        Dim nFal1, nFal2, nFal3, nFal4, nFal6, nFal8 As Integer

        Dim dtRecs As DataTable = (DataSet1.recompensasejercicio)

        For i = 0 To dtRecs.Rows.Count - 1
            If Val(dtRecs.Rows(i)("RECJF").ToString) > 0 Then
                nCodREC = Val(dtRecs.Rows(i)("RECJF").ToString)
                nRecsJCF += 1
                Select Case nCodREC
                    Case 1 : nJCF1 += 1
                    Case 2 : nJCF2 += 1
                    Case 3 : nJCF3 += 1
                    Case 4 : nJCF4 += 1
                    Case 5 : nJCF5 += 1
                    Case 11 : nJCF11 += 1
                    Case 12 : nJCF12 += 1
                    Case 13 : nJCF13 += 1
                End Select
            End If

            If Val(dtRecs.Rows(i)("RECFALLA").ToString) > 0 Then
                nRecsFalla += 1
                nCodREC = Val(dtRecs.Rows(i)("RECFALLA").ToString)
                Select Case nCodREC
                    Case 1 : nFal1 += 1
                    Case 2 : nFal2 += 1
                    Case 3 : nFal3 += 1
                    Case 4 : nFal4 += 1
                    Case 6 : nFal6 += 1
                    Case 8 : nFal8 += 1
                End Select
            End If
        Next

        Me.LblRecsFalla.Text = "Nº Recompensas Falla: " + nRecsFalla.ToString
        Me.LblRecsJCF.Text = "Nº Recompensas JCF: " + nRecsJCF.ToString
        Me.LblF1.Text = nFal1.ToString()
        Me.LblF2.Text = nFal2.ToString()
        Me.LblF3.Text = nFal3.ToString()
        Me.LblF4.Text = nFal4.ToString()
        Me.LblF6.Text = nFal6.ToString()
        Me.LblF8.Text = nFal8.ToString()
        Me.LblJ1.Text = nJCF1.ToString()
        Me.LblJ2.Text = nJCF2.ToString()
        Me.LblJ3.Text = nJCF3.ToString()
        Me.LblJ4.Text = nJCF4.ToString()
        Me.LblJ5.Text = nJCF5.ToString()
        Me.LblJ11.Text = nJCF11.ToString()
        Me.LblJ12.Text = nJCF12.ToString()
        Me.LblJ13.Text = nJCF13.ToString()
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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalr.Click
        Me.Close()
    End Sub

    Private Sub BtnListado_Click(sender As Object, e As EventArgs) Handles BtnListado.Click
        Dim frm As New FrmVerRecompensas
        frm.ShowDialog()
    End Sub

End Class