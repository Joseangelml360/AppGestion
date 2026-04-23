Public Class FrmEditarLineaRemesa
    Private Sub FrmEditarLineaRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.detalles_de_remesa' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_remesaTableAdapter.FillByCodigo(Me.DataSet1.detalles_de_remesa, Val(Me.TxtCodigo.Text))
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.BtnActualizar.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim nTotCuota, nOtrosCargos, nRecDev, nValDev, nSumaCargos, nNumPagos, nBenef, nCod As Double
        Dim nDevbenef, nAcuenta, nAbonobenefi, nResto, nTotalAbonos, nTotalRecibo, nTotalCargo As Double

        nNumPagos = Val(Me.NumPagosTextBox.Text)
        nCod = Me.TxtCodigo.Text
        nTotCuota = Val(Me.TotalCuotaTextBox.Text)
        nRecDev = Val(Me.RecdevTextBox.Text)
        nValDev = Val(Me.ValordevTextBox.Text)
        nOtrosCargos = Val(Me.OtrosCargosTextBox.Text)
        nSumaCargos = nTotCuota + nOtrosCargos + (nRecDev * nValDev)
        nAcuenta = Val(Me.EntregasAcuentaTextBox.Text)
        nBenef = Val(Me.BENEFICIOSTextBox.Text)
        nDevbenef = Val(Me.DEV_BENEFITextBox.Text)
        nResto = nBenef - nDevbenef
        nTotalAbonos = nAcuenta + nResto
        nTotalCargo = nSumaCargos - nTotalAbonos

        If nTotalCargo > 0 Then
            nTotalRecibo = nTotalCargo
            'nDevbenef += nResto
            nAbonobenefi = nResto
        Else
            If nTotalCargo > nAcuenta Then
                nAbonobenefi = nResto + nSumaCargos
                'nDevbenef += nAbonobenefi
                nTotalRecibo = 0
            Else
                If nAcuenta < nSumaCargos Then
                    nAbonobenefi = nSumaCargos - nAcuenta
                    nTotalRecibo = 0
                Else
                    nAbonobenefi = 0
                    nAcuenta = nSumaCargos
                    nTotalRecibo = 0
                End If

            End If
        End If
        'Update linea de detalles de recibo para codigo

        Try
            Me.Detalles_de_remesaTableAdapter.UpdateRows(nResto, nAcuenta, nValDev, nTotCuota, nTotalCargo, nTotalAbonos,
                                                                         nAbonobenefi, nSumaCargos, nTotalRecibo, nNumPagos, nOtrosCargos, nRecDev, nCod)
            MsgBox("Actualizada línea de remesa fallero: " & Me.TxtCodigo.Text)
            Me.Close()
        Catch
            MsgBox("Error al guardar, línea no Actualizada")
        End Try
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim nTotCuota, nOtrosCargos, nRecDev, nValDev, nSumaCargos, nNumPagos, nBenef, nCod, nDeuda As Double
        Dim nDevbenef, nAcuenta, nAbonobenefi, nResto, nTotalAbonos, nTotalRecibo, nTotalCargo As Double

        nNumPagos = Val(Me.NumPagosTextBox.Text)
        nCod = Me.TxtCodigo.Text
        nDeuda = Val(Me.TxtDeuda.Text)
        nTotCuota = Val(Me.PAGOTextBox.Text) * nNumPagos
        nRecDev = Val(Me.RecdevTextBox.Text)
        nValDev = Val(Me.ValordevTextBox.Text)
        nOtrosCargos = Val(Me.OtrosCargosTextBox.Text)
        nSumaCargos = nTotCuota + nOtrosCargos + (nRecDev * nValDev)
        nAcuenta = Val(Me.EntregasAcuentaTextBox.Text)
        nBenef = Val(Me.BENEFICIOSTextBox.Text)
        nDevbenef = Val(Me.DEV_BENEFITextBox.Text)
        nResto = nBenef - nDevbenef
        nTotalAbonos = nAcuenta + nResto
        nTotalCargo = nSumaCargos - nTotalAbonos

        If nTotalCargo > 0 Then
            nTotalRecibo = nSumaCargos - nTotalAbonos
            nDevbenef += nResto
        Else
            If nTotalCargo > nAcuenta Then
                nAbonobenefi = nResto + nSumaCargos
                nDevbenef += nAbonobenefi
                nTotalRecibo = 0
            Else
                nAbonobenefi = 0
                nTotalRecibo = 0
            End If
        End If
        Me.TotalCargoTextBox.Text = nTotalCargo
        Me.EntregasAcuentaTextBox.Text = nAcuenta
        Me.SumaCargosTextBox.Text = nSumaCargos
        Me.AbonobenefiTextBox.Text = nAbonobenefi
        Me.TotalreciboTextBox.Text = nTotalRecibo
        Me.TotalCuotaTextBox.Text = nTotCuota
        Me.SumaAbonosTextBox.Text = nTotalAbonos
        Me.BtnActualizar.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

End Class