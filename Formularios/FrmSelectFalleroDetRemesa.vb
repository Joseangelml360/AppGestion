Public Class FrmSelectFalleroDetRemesa
    Private Sub FrmSelectFalleroDetRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.FalleroDetalleRemesa' Puede moverla o quitarla según sea necesario.
        Me.FalleroDetalleRemesaTableAdapter.FillByAddFalleroAremesa(Me.DataSet1.FalleroDetalleRemesa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Detalles_de_remesa' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_remesaTableAdapter.Fill(Me.DataSet1.Detalles_de_remesa)
        'TODO: esta línea de código carga datos en la tabla 'DbCensosDataSet.FALLERO' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByBanco(Me.DbCensos.fallero, TxtBuscar.Text)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

    End Sub

    Private Sub FalleroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FalleroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbCensos)

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            Me.FalleroTableAdapter.FillByBanco(Me.DbCensos.fallero, TxtBuscar.Text)
        Catch ex As Exception
            MsgBox(TxtBuscar.Text)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim nCod, nBenef, nDevBenef, nRecDev, nImpCuota, nNumPagos, nDeuda, nAcuenta, nOtrosCargos, nValdev As Double
        Dim nSumaCargos, nTotalAbonos, nAbonoBenefi, nTotalCargo, nTotalRecibo, nTotalCuota, nResto, nId, nNumCuotas As Double
        Dim cNom, cApe, cTit, cTipoCuota, cCta, cTipFal, dFechCrea, dFechCgo As String

        Dim Dgv As New DataGridView
        Dgv = FalleroDgv
        If Dgv.Rows.Count < 1 Then
            MsgBox("no se ha seleccionado ningún fallero")
            Exit Sub
        End If
        dFechCrea = FormatDateTime(Me.DtpFechaCrea.Value, DateFormat.ShortDate)
        dFechCgo = FormatDateTime(Me.DtpFechaCargo.Value, DateFormat.ShortDate)
        cNom = Dgv.CurrentRow.Cells(1).Value
        cApe = Dgv.CurrentRow.Cells(2).Value
        cTit = Dgv.CurrentRow.Cells(3).Value
        cTipoCuota = Dgv.CurrentRow.Cells(10).Value
        nCod = Dgv.CurrentRow.Cells(0).Value
        nBenef = Dgv.CurrentRow.Cells(6).Value
        nDevBenef = Dgv.CurrentRow.Cells(7).Value
        If Dgv.CurrentRow.Cells(8).Value.ToString = "" Then
            nRecDev = 0
        Else
            nRecDev = Dgv.CurrentRow.Cells(8).Value
        End If
        nImpCuota = Dgv.CurrentRow.Cells(12).Value
        nNumPagos = Val(Me.TxtNumPagos.Text)
        nDeuda = Dgv.CurrentRow.Cells(14).Value
        If Dgv.CurrentRow.Cells(16).Value.ToString = "" Then
            nAcuenta = 0
        Else
            nAcuenta = Dgv.CurrentRow.Cells(16).Value
        End If
        If Dgv.CurrentRow.Cells(17).Value.ToString = "" Then
            nOtrosCargos = 0
        Else
            nOtrosCargos = Dgv.CurrentRow.Cells(17).Value
        End If

        nValdev = Val(Me.TxtValDev.Text)
        nId = Val(Me.TxtId.Text)
        cTipFal = Dgv.CurrentRow.Cells(19).Value
        nNumCuotas = Dgv.CurrentRow.Cells(21).Value
        cCta = Dgv.CurrentRow.Cells(20).Value
        nResto = Math.Round(nBenef - nDevBenef, 2)
        nTotalAbonos = Math.Round(nAcuenta + nResto, 2)
        nTotalCuota = Math.Round(nImpCuota * nNumPagos, 2)
        nSumaCargos = Math.Round(nTotalCuota + nOtrosCargos + (nRecDev * nValdev), 2)
        nTotalCargo = Math.Round(nSumaCargos - nTotalAbonos, 2)

        If nTotalCuota > nDeuda Then
            nTotalCuota = nDeuda
        End If

        If nTotalCargo > 0 Then
            nTotalRecibo = nTotalCargo
            nAbonoBenefi = nResto
        Else
            If nTotalCargo > nAcuenta Then
                nAbonoBenefi = nResto + nSumaCargos
                nTotalRecibo = 0
            Else
                If nAcuenta < nSumaCargos Then
                    nAbonoBenefi = nSumaCargos - nAcuenta
                    nTotalRecibo = 0
                Else
                    nAbonoBenefi = 0
                    nAcuenta = nSumaCargos
                    nTotalRecibo = 0
                End If

            End If
        End If

        Try
            Me.Detalles_de_remesaTableAdapter.AñadirFalleroDetallesRemesa(cTit, nCod, cNom, cApe, cTipFal, nNumCuotas, cCta, cTipoCuota,
            nNumPagos, nImpCuota, nBenef, nDevBenef, nResto, nOtrosCargos, nAcuenta, nRecDev, nValdev, nTotalCuota,
            nTotalCargo, nDeuda, nTotalAbonos, nAbonoBenefi, nSumaCargos, nTotalRecibo, nId, dFechCrea, dFechCgo)
            MsgBox("Se ha añadido linea de remesa de fallero: " & nCod & vbCrLf & cNom & " " & cApe)
        Catch ex As Exception
            MsgBox("Error al añadir fallero a Remesa")
        End Try
        Me.Close()
    End Sub

End Class