Public Class FrmAñadirRegistroRecompensa

    'Me.RecompensasejercicioTableAdapter.InsertQuery(nFCodJCF, cFNom, cFApelli, nFTipFal, nRecJCF, nRecFal, nRecAgrup, nEje,
    '                nFCodFal, cFDNI, nFalCen, nNumEjeJCF, nNumEjeCargo, nFUltRecFal, nFUltRecJCF, nFCargo, nNumEjeFal)


    Private Sub FrmAñadirRegistroRecompensa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DataSet1.recompensas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.recompensasejercicio' Puede moverla o quitarla según sea necesario.
        Me.RecompensasejercicioTableAdapter.Fill(Me.DataSet1.recompensasejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.criteriorecomp' Puede moverla o quitarla según sea necesario.
        Me.CriteriorecompTableAdapter.Fill(Me.DataSet1.criteriorecomp)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.historfa' Puede moverla o quitarla según sea necesario.
        Me.HistorfaTableAdapter.Fill(Me.DataSet1.historfa)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.

        Me.DgvFallero.Visible = False
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Me.DgvFallero.Visible = True
        If TxtBuscar.Text <> "" Then
            Try
                Me.FalleroTableAdapter.FillByApellidos(Me.DbCensos.fallero, TxtBuscar.Text)
                ' Me.DgvFallero.Refresh()
            Catch ex As Exception
                MsgBox(TxtBuscar.Text)
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TxtBuscarCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCodigo.TextChanged
        Me.DgvFallero.Visible = True

        Try
            Me.FalleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, Val(TxtBuscarCodigo.Text))
        Catch ex As Exception
            MsgBox(TxtBuscar.Text)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DgvFallero_Click(sender As Object, e As EventArgs) Handles DgvFallero.Click
        Me.DgvFallero.Visible = False
        LimpiarGroupBox(Me.GroupBoxCalculo)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnVerHistorfa_Click(sender As Object, e As EventArgs) Handles BtnVerHistorfa.Click
        Dim frm As New FrmHistorial
        frm.CODIGOTextBox.Text = Me.CODIGOTextBox.Text
        frm.FALLERO_CODIGOTextBox = Me.FALLERO_CODIGOTextBox
        frm.DNITextBox.Text = Me.DNITextBox.Text
        frm.NOMBRETextBox.Text = Me.NOMBRETextBox.Text
        frm.APELLIDOSTextBox.Text = Me.APELLIDOSTextBox.Text

        frm.ShowDialog()

    End Sub

    Private Sub BtnCalculoRec_Click(sender As Object, e As EventArgs) Handles BtnCalculoRec.Click
        ' Llama a la función de cálculo de recompensas y almacena los valores devueltos en una tupla
        Dim resultado As (Integer, Integer) = CalcularRecompensas()
        Dim cMensaje As String
        ' Accede a los valores de la tupla
        Dim nResRecFal As Integer = resultado.Item1
        Dim nResRecJCF As String = resultado.Item2
        cMensaje = ""

        If nResRecFal = 0 Then
            cMensaje = "Según el cálculo de recompesa de Falla no corresponde ninguna este ejercicio." & Chr(13)
        End If
        If nResRecJCF = 0 Then
            cMensaje = cMensaje & "Según el cáculo de recompensa de JCF, no corresponde ninguna este ejercicio"
        End If

        If cMensaje <> "" Then
            cMensaje = cMensaje & Chr(13) & "Revisa y actualiza historial del fallero, es importante para futuros cálculos."
            cMensaje = cMensaje & Chr(13) & "Puedes forzar las recompensas en el grupo de Añadir Recompensas y después pulsa el botón de Guardar cambios"
            MsgBox(cMensaje)
        End If
    End Sub

    Private Sub BtnInsertReg_Click(sender As Object, e As EventArgs) Handles BtnInsertReg.Click
        Dim nCodJCF, nFTipfal, nRecJCF, nRecFal, nRecAgrup, nEje, nFCodFal, nFalCen, nNumEjeJCF, nNumEjeCargo, nFUtlRecFal As Integer
        Dim nFUtlRecJCF, nFCargo, nNumEjeFal As Integer
        Dim cFNom, cFApelli, cFDNI As String

        ' Llama a la función de cálculo de recompensas y almacena los valores devueltos en una tupla
        Dim resultado As (Integer, Integer) = CalcularRecompensas()
        Dim cMensaje As String
        ' Accede a los valores de la tupla
        Dim nResRecFal As Integer = resultado.Item1
        Dim nResRecJCF As String = resultado.Item2
        cMensaje = ""
        If nResRecJCF = 0 Then
            cMensaje = cMensaje & "Según el cáculo de recompensa de JCF, no corresponde ninguna este ejercicio"
        End If
        If nResRecFal = 0 Then
            cMensaje = "Según el cálculo de recompesa de Falla no corresponde ninguna este ejercicio." & Chr(13)
        End If

        If cMensaje <> "" Then
            cMensaje = cMensaje & Chr(13) & "Revisa y actualiza historial del fallero, es importante para futuros cálculos."
            cMensaje = cMensaje & Chr(13) & "Puedes forzar las recompensas en el grupo de Añadir Recompensas y después pulsa el botón de Guardar cambios"
        End If

        nCodJCF = Val(CODIGOTextBox.Text)
        nFTipfal = Val(TIPFALTextBox.Text)
        nRecJCF = Val(TxtRecJCFnew.Text)
        nRecFal = Val(TxtRecFalnew.Text)
        nRecAgrup = Val(TxtRecAgrnew.Text)
        nEje = Val(ANO_CENTextBox.Text)
        nFCodFal = Val(FALLERO_CODIGOTextBox.Text)
        nFalCen = Val(FAL_CENTextBox.Text)
        nNumEjeJCF = Val(TxtNEjeJCF.Text)
        nNumEjeCargo = Val(TxtEjeCargo.Text)
        nFUtlRecFal = Val(REC_FALTextBox.Text)
        nFUtlRecJCF = Val(COD_RECTextBox.Text)
        nFCargo = Val(ULTCARTextBox.Text)
        nNumEjeFal = Val(TxtEjeFalla.Text)
        cFNom = NOMBRETextBox.Text
        cFApelli = APELLIDOSTextBox.Text
        cFDNI = DNITextBox.Text

        If nFCargo = 22 Then
            nResRecJCF = 0
            nResRecFal = 0
        End If
        Me.TxtRecFalla.Text = nRecFal.ToString

        If nRecAgrup > 0 Or nRecFal > 0 Or nRecJCF > 0 Then
            nResRecFal = 1
            nResRecJCF = 1
        End If

        Try
            If nResRecJCF = 1 Or nResRecFal = 1 Then
                Me.RecompensasejercicioTableAdapter.InsertQuery(nCodJCF, cFNom, cFApelli, nFTipfal, nRecJCF, nRecFal, nRecAgrup, nEje,
                nFCodFal, cFDNI, nFalCen, nNumEjeJCF, nNumEjeCargo, nFUtlRecFal, nFUtlRecJCF, nFCargo, nNumEjeFal)
                MsgBox("El registro se ha guardado correctamente")
            End If
        Catch ex As Exception
            MsgBox("Error. No se ha guarddo el registro")
            MsgBox(ex.ToString & " Fallero " & nFCodFal)
        End Try
    End Sub

    Public Function CalcularRecompensas() As (Integer, Integer)
        Dim nFUltRecJCF, nFUltRecFal, nRecFal, nRecJCF, nRecAgrup, nNumEjeJCF, nNumEjeFal, nNumEjeCargo As Integer
        Dim nEje, nFTipFal, nFCargo, nCRCodRec, nCRNumeje, nCRNumcargo, nCRMinCargo, nFalCen As Integer
        Dim cFNom, cFApelli, cFDNI As String
        Dim nFCodFal, nCodJCF As Double
        Dim ValRecJCF, ValRecFal As Integer
        Dim dt1 As DataTable = DataSet1.criteriorecomp
        Dim h As Integer

        If Val(Me.COD_RECTextBox.Text) = Nothing Then
            nFUltRecJCF = 0
        Else
            nFUltRecJCF = Val(Me.COD_RECTextBox.Text)
        End If

        If Val(Me.REC_FALTextBox.Text) = Nothing Then
            nFUltRecFal = 0
        Else
            nFUltRecFal = Val(Me.REC_FALTextBox.Text)
        End If

        nFalCen = FAL_CENTextBox.Text
        cFDNI = Me.DNITextBox.Text
        If String.IsNullOrEmpty(cFDNI) Then
            cFDNI = " "
        Else
            cFDNI = Me.DNITextBox.Text
        End If

        nFCodFal = Val(FALLERO_CODIGOTextBox.Text)
        nCodJCF = Val(CODIGOTextBox.Text)
        nEje = Me.ANO_CENTextBox.Text
        cFNom = Me.NOMBRETextBox.Text
        cFApelli = Me.APELLIDOSTextBox.Text
        nFCargo = Me.ULTCARTextBox.Text
        nFTipFal = Val(TIPFALTextBox.Text)
        nNumEjeFal = HistorfaTableAdapter.ScalarEjeFalla(nCodJCF) + 1
        nNumEjeJCF = HistorfaTableAdapter.ScalarEjeJCF(nCodJCF, nFTipFal) + 1
        If nFCargo > 19 Or nFCargo > 21 Then
            nNumEjeCargo = HistorfaTableAdapter.ScalarEjerConCargo(nCodJCF, nFTipFal)
        Else
            nNumEjeCargo = HistorfaTableAdapter.ScalarEjerConCargo(nCodJCF, nFTipFal) + 1
        End If
        'Comienza cálculo de Recompensas


        'Cálculo de recompensas de JCF
        nRecJCF = 0
        Select Case nFTipFal

            Case 1
                ValRecJCF = 0
                If nFUltRecJCF < 5 And nFCargo <> 22 And nCodJCF > 0 Then
                    'nFCodJCF = Val(dt.Rows(i)("COD_JCF".ToString))
                    If (nFCargo < 20 Or nFCargo = 21) And nFCargo > 0 Then
                        nNumEjeCargo += 1
                    End If

                    For h = 0 To dt1.Rows.Count - 2
                        nCRCodRec = Val(dt1.Rows(h)("CODREC"))

                        If nCRCodRec = nFUltRecJCF + 1 Then
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
                    Next
                End If

            Case 3
                ValRecJCF = 0

                If nNumEjeJCF > 1 Then
                    Select Case nFUltRecJCF
                        Case <> 12
                            If nFUltRecJCF > 10 Or 0 Then
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


                If nFUltRecJCF = 0 And nNumEjeJCF > 1 Then
                    ValRecJCF = 1
                    nRecJCF = 11

                ElseIf nFUltRecJCF = 11 Then
                    nCRNumeje = Val(dt1.Rows(7)("NUMEJEFALLERO"))
                    nCRNumcargo = Val(dt1.Rows(7)("NUMEJECARGO"))
                    nCRMinCargo = Val(dt1.Rows(7)("MINEJECARGO"))

                    If nCRMinCargo <= nNumEjeCargo And nCRNumcargo >= 4 Then
                        ValRecJCF = 1
                        nRecJCF = 12
                    Else
                        If nCRNumeje <= nNumEjeJCF Then
                            ValRecJCF = 1
                            nRecJCF = 12
                        End If
                    End If

                ElseIf nFUltRecJCF = 12 Then
                    nCRNumeje = Val(dt1.Rows(8)("NUMEJEFALLERO"))
                    nCRNumcargo = Val(dt1.Rows(8)("NUMEJECARGO"))
                    nCRMinCargo = Val(dt1.Rows(8)("MINEJECARGO"))

                    If nNumEjeCargo >= nCRMinCargo And nCRNumcargo <= nNumEjeJCF Then
                        ValRecJCF = 1
                        nRecJCF = 13
                    Else
                        If nNumEjeJCF >= nCRNumeje Then
                            ValRecJCF = 1
                            nRecJCF = 13
                        End If
                    End If

                ElseIf nFUltRecJCF = 13 Then
                    ValRecJCF = 0

                End If

        End Select

        Me.TxtEjeCargo.Text = nNumEjeCargo
        Me.TxtEjeFalla.Text = nNumEjeFal
        Me.TxtNEjeJCF.Text = nNumEjeJCF
        If ValRecJCF = 1 Then
            Me.TxtRecJCFnew.Text = nRecJCF
            Me.TxtRecJCF.Text = nRecJCF
        Else
            Me.TxtRecJCFnew.Text = 0
            Me.TxtRecJCF.Text = 0
        End If

        'Cálculo de recompensas de la falla


        nRecFal = 0
        Select Case nFUltRecFal
            Case 0
                If nNumEjeFal > 1 Then
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
                    ValRecFal = 1
                Else
                    nRecFal = 0
                End If
        End Select

        If nNumEjeJCF > 49 Then
            nRecFal = 8
            ValRecFal = 1
        End If

        If ValRecFal = 1 Then
            TxtRecFalnew.Text = nRecFal
            TxtRecFalla.Text = nRecFal
        Else
            TxtRecFalnew.Text = 0
            TxtRecFalla.Text = 0
        End If

        'Cálculo de recompensas de la Agrupación

        If nFCargo = 21 Then
            nRecAgrup = 2
        Else
            nRecAgrup = 0
        End If

        Me.TxtRecAgrnew.Text = nRecAgrup

        Return (ValRecFal, ValRecJCF)

    End Function

End Class