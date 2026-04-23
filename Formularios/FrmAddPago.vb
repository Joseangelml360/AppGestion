Public Class FrmAddPago

    Private Sub FrmAddPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.Fill(Me.DbCensos.remesas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        'Datos de cabecera del recibo
        Me.Button3.Enabled = False
        Me.TxtCUENTA.Text = "Caja Falla"
        Me.TxtIdRemesa.Text = -1
        Me.DTPFecha.Value = Now

        'Datos de inicio Cuotas
        Me.TxtTotCuotaAnual.Text = Val(Me.TxtNumCuotas.Text) * Val(Me.TxtPago.Text)

        'Datos de inicio Cargos
        Me.TxtTotCuota.Text = Val(TxtPago.Text) * Val(TxtMesesDeuda.Text)
        Me.TxtValorDev.Text = 3
        Me.TxtRestoBenef.Text = Val(Me.TxtBeneficios.Text) - Val(Me.TxtBenefAbonado.Text)
        Me.TxtTotalcargo.Text = Val(TxtTotCuota.Text) + Val(TxtCargos.Text) + (Val(TxtRecDev.Text) * Val(TxtValorDev.Text))
        Me.TxtSumaAbonos.Text = Val(TxtAcuenta.Text) + Val(TxtRestoBenef.Text)
        Me.TxtTotalrecibo.Text = Val(Me.TxtTotalcargo.Text) - Val(TxtSumaAbonos.Text)
        Me.TxtAbonoBenefRecibo.Text = Val(Me.TxtRestoBenef.Text)

        Me.Button2.Enabled = True
        Me.Button3.Enabled = False
        Me.RadioButton1.Checked = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarCampos(Me)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nTotCuota, nOtroscargos, nRecDev, nValdev, nSumaCargos As Double
        Dim nAcuenta, nAbonoBenefi, nTotalAbonos, nDeuda, nTotFinalRecibo As Double

        nTotCuota = Val(TxtPago.Text) * Val(TxtNumMeses.Text)
        Me.TxtCuotasRecibo.Text = nTotCuota
        nOtroscargos = Val(TxtCargos.Text)
        Me.TxtOtrosCargosRecibo.Text = nOtroscargos
        nRecDev = Val(TxtRecDev.Text)
        nValdev = Val(TxtValorDev.Text)
        If nRecDev > 0 And nValdev < 1 Then
            Do While nValdev < 1
                nValdev = InputBox("Introduce el importe actual de recibo devuelto",)
                If nValdev < 1 Then
                    MsgBox("El importe debe ser mayor de 1")
                End If
            Loop
        End If

        Me.TxtRecDevRecibo.Text = nRecDev
        Me.TxtValorDevRecibo.Text = nValdev
        nDeuda = Val(TxtDeuda.Text)
        nSumaCargos = nOtroscargos + (nRecDev * nValdev) + nTotCuota
        Me.TxtSumaCargosRecibo.Text = nSumaCargos
        nAcuenta = Val(TxtAcuenta.Text)
        Me.TxtAcuentaRecibo.Text = nAcuenta
        nAbonoBenefi = Val(Me.TxtAbonoBenefRecibo.Text)
        nTotalAbonos = nAcuenta + nAbonoBenefi
        Me.TxtSumaAbonoRecibo.Text = nTotalAbonos
        nTotFinalRecibo = nSumaCargos - nTotalAbonos
        Me.TxtTotalFinalrecibo.Text = nTotFinalRecibo

        If nSumaCargos > nTotalAbonos Then

            Me.TxtTotalFinalrecibo.Text = nTotFinalRecibo

        Else
            If nSumaCargos > nAcuenta Then
                nTotFinalRecibo += nAcuenta
                nSumaCargos -= nAcuenta
            Else
                Me.TxtAcuentaRecibo.Text = nSumaCargos
                nSumaCargos = 0
                nTotFinalRecibo = 0
            End If

            If nSumaCargos > nAbonoBenefi Then
                nTotFinalRecibo += nAbonoBenefi
                nSumaCargos -= nAbonoBenefi
            Else
                Me.TxtAbonoBenefRecibo.Text = nSumaCargos
                nSumaCargos = 0
                nTotFinalRecibo = 0
            End If

            Me.TxtSumaAbonoRecibo.Text = Val(TxtAcuentaRecibo.Text) + nAbonoBenefi
            Me.TxtTotalFinalrecibo.Text = nTotFinalRecibo

        End If

        Me.Button3.Enabled = True

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.TxtCUENTA.Text = "Caja Falla"
        Else
            Me.TxtCUENTA.Text = "Transferencia"
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = False Then
            Me.TxtCUENTA.Text = "Caja Falla"
        Else
            Me.TxtCUENTA.Text = "Transferencia"
        End If

    End Sub

    Private Sub RemesasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RemesasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbCensos)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Actualizar los datos que han cambiado de FALLERO
        Dim nBenef, nAcuenta, nMeses, nCargos, ndev, nResto, nDeuda, nTotalCuota As Double

        nBenef = Val(Me.TxtBenefAbonado.Text) + Val(Me.TxtAbonoBenefRecibo.Text) 'DEV_BENEFI
        nAcuenta = Val(Me.TxtAcuenta.Text) - Val(Me.TxtAcuentaRecibo.Text)  'A_CUENTA
        nMeses = Val(Me.TxtMesesDeuda.Text) - Val(Me.TxtNumMeses.Text)  'NUM_PAGOS
        nCargos = Val(Me.TxtCargos.Text) - Val(Me.TxtOtrosCargosRecibo.Text)  'OTROS_CARGOS
        ndev = Val(Me.TxtRecDev.Text) - Val(Me.TxtRecDevRecibo.Text)  'REC_DEV
        nResto = Val(Me.TxtBeneficios.Text) - nBenef  'RESTO
        nDeuda = Val(Me.TxtPago.Text) * nMeses + Val(Me.TxtCargos.Text) - nAcuenta - nResto  'DEUDA
        nTotalCuota = Val(Me.TxtPago.Text) * nMeses  'TOTAL_CUOTA

        Try
            FalleroTableAdapter.UpdatePagoCaja(nBenef, ndev, nMeses, nDeuda, nTotalCuota, nAcuenta, ndev, Val(Me.TxtCodigo.Text))
            MsgBox("Aplicada actualización a ficha de fallero")
        Catch ex As Exception
            MsgBox("Ficha fallero no se ha actualizado")
        End Try

        'Añadir registro a tabla Remesas

        Dim nId, nCod, nIC, nMA, nBen, nDv, nTCA, nOC, nEA, nRB, nPP, nRDv, nVDv, nTC, nTCgo, nAB, nSOC, nTR As Double
        Dim dFCr, dFCg As Date
        Dim bFD, bDev, bBloq As Boolean
        Dim sTit, sNom, sApe, sTipC, sCtaB As String

        nId = -1
        dFCr = Me.DTPFecha.Value
        dFCg = Me.DTPFecha.Value
        bFD = False
        sTit = Me.TxtTitular.Text
        nCod = Me.TxtCodigo.Text
        sNom = Me.TxtNombre.Text
        sApe = Me.TxtApellidos.Text
        sTipC = Me.TxtTipoCuota.Text
        nIC = Val(Me.TxtPago.Text)
        nMA = Val(Me.TxtNumMeses.Text)
        nBen = Val(Me.TxtBeneficios.Text)
        nDv = Val(Me.TxtBenefAbonado.Text)
        nTCA = Val(Me.TxtTotCuotaAnual.Text)
        nOC = Val(Me.TxtOtrosCargosRecibo.Text)
        nEA = Val(Me.TxtAcuentaRecibo.Text)
        sCtaB = Me.TxtCUENTA.Text
        nRB = Val(TxtRestoBenef.Text)
        nPP = Val(Me.TxtNumMeses.Text)
        nRDv = Val(Me.TxtRecDevRecibo.Text)
        nVDv = Val(Me.TxtValorDevRecibo.Text)
        nTC = Val(Me.TxtCuotasRecibo.Text)
        nTCgo = Val(Me.TxtSumaCargosRecibo.Text)
        nAB = Val(Me.TxtAbonoBenefRecibo.Text)
        nSOC = Val(Me.TxtOtrosCargosRecibo.Text)
        nTR = Val(Me.TxtTotalFinalrecibo.Text)
        bDev = False
        bBloq = False

        Try
            Me.RemesasTableAdapter.InsertRecord(nId, dFCr, dFCg, bFD, sTit, nCod, sNom, sApe, sTipC, nIC, nMA, nBen,
                                                         nDv, nTCA, nOC, nEA, sCtaB, nRB, nPP, nRDv, nVDv, nTC, nTCgo, nAB, nSOC,
                                                         nTR, bDev, bBloq)

            Me.Validate()
            Me.RemesasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbCensos)
            Me.DbCensos.AcceptChanges()
            MsgBox(" Añadido registro a la tabla 'Remesas'")
            Button2.Enabled = False
            Button3.Enabled = False

        Catch ex As Exception
            MsgBox("No se ha registrado el pago en la tabla 'Remesas'")
        End Try


    End Sub

    Private Sub TxtAbonoBenefRecibo_TextChanged(sender As Object, e As EventArgs) Handles TxtAbonoBenefRecibo.TextChanged
        If Val(TxtAbonoBenefRecibo.Text) > Val(TxtRestoBenef.Text) Then
            TxtAbonoBenefRecibo.Text = Val(TxtRestoBenef.Text)
        End If
    End Sub

    Private Sub TxtValorDev_TextChanged(sender As Object, e As EventArgs) Handles TxtValorDev.TextChanged
        Me.TxtTotCuota.Text = Val(TxtPago.Text) * Val(TxtMesesDeuda.Text)

        Me.TxtRestoBenef.Text = Val(Me.TxtBeneficios.Text) - Val(Me.TxtBenefAbonado.Text)
        Me.TxtTotalcargo.Text = Val(TxtTotCuota.Text) + Val(TxtCargos.Text) + (Val(TxtRecDev.Text) * Val(TxtValorDev.Text))
        Me.TxtSumaAbonos.Text = Val(TxtAcuenta.Text) + Val(TxtRestoBenef.Text)
        Me.TxtTotalrecibo.Text = Val(Me.TxtTotalcargo.Text) - Val(TxtSumaAbonos.Text)
        Me.TxtAbonoBenefRecibo.Text = Val(Me.TxtRestoBenef.Text)

        Me.Button2.Enabled = True
        Me.Button3.Enabled = False
        Me.RadioButton1.Checked = True

    End Sub
End Class