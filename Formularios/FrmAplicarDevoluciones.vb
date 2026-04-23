Public Class FrmAplicarDevoluciones
    Private Sub FrmAplicarDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Fallero1' Puede moverla o quitarla según sea necesario.
        Me.Fallero1TableAdapter.Fill(Me.DataSet1.Fallero1)
        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.FillRemesas(Me.ReportsDataSet.remesas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Dim cId, cFecha, cItem As String
        Dim dt As DataTable = ReportsDataSet.remesas

        For i = 0 To dt.Rows.Count - 1
            cId = dt.Rows(i)("IdRemesa".ToString)
            cFecha = dt.Rows(i)("FechaCargo".ToString)
            cItem = cId & "  -  " & cFecha
            CboSelect.Items.Add(cItem)
        Next

        Me.DgvTitular.Visible = False
        Me.DgvDevolucion.Visible = False
        Me.BtnAplicar.Visible = False
        Me.Label2.Visible = False
        Me.TextBox1.Visible = False

    End Sub

    Private Sub CboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSelect.SelectedIndexChanged
        Dim nNumremesa As String
        nNumremesa = Val(Me.CboSelect.Items(0).ToString)
        Me.RemesasTableAdapter.FillRemesas(ReportsDataSet.remesas)
        Me.DgvTitular.Refresh()
    End Sub

    Private Sub TxtTitular_TextChanged(sender As Object, e As EventArgs) Handles TxtTitular.TextChanged
        Me.RemesasTableAdapter.FillByNumeroRemesa(ReportsDataSet.remesas, Me.CboSelect.SelectedIndex + 1, Me.TxtTitular.Text)
        Me.DgvTitular.Refresh()
        Me.DgvTitular.Visible = True
    End Sub

    Private Sub DgvTitular_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTitular.CellContentClick
        Dim nCod As Double
        Dim cTit As String
        nCod = DgvTitular.CurrentRow.Cells(0).Value
        cTit = DgvTitular.CurrentRow.Cells(2).Value.ToString
        Me.DgvTitular.Visible = False
        Me.Remesas1TableAdapter.FillByDevolución(ReportsDataSet.remesas1, nCod, cTit)
        Me.DgvDevolucion.Refresh()
        Me.DgvDevolucion.Visible = True
        Me.BtnAplicar.Visible = True
        Me.BtnAplicar.Enabled = True
        Me.TextBox1.Visible = True
        Me.Label2.Visible = True
        Me.TextBox1.Text = cTit
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        Dim nId, nCod, nRecDev, nOtrosCargos, nAcuenta, nPagos, nAbonoBenefi, nDeuda As Double
        Dim nFalleRecDev, nFalleOtroscargos, nFalleAcuenta, nFallePago, nFalleNumPagos, nFalleDevBenefi, nFalleBenefi As Double
        Dim r, n As Integer
        Dim cTit As String = DgvTitular.CurrentRow.Cells(2).Value.ToString
        Dim Dgv, Dgv1 As New DataGridView
        r = 0
        n = 0
        Me.TextBox1.Text = cTit
        Dgv = Me.DgvDevolucion
        Me.DgvDevolucion.Refresh()
        Dgv1 = Me.DgvFallero

        If Dgv.Rows.Count = 0 Then
            MsgBox("No se ha seleccionado ningún recibo para aplicar devolución")
            Exit Sub
        End If

        For Each row As DataGridViewRow In Dgv.Rows
            If row.Cells("devolucion").Value = True Then
                MsgBox("Fallero " & row.Cells("Cod").Value & " ya ha sido aplicada la devolución")
                Exit Sub
            Else
                n += 1
                nId = row.Cells("Id").Value
                nCod = row.Cells("Cod").Value
                nPagos = row.Cells("Pagos").Value
                nOtrosCargos = row.Cells("Cargos").Value
                nAcuenta = row.Cells("Acuenta").Value
                If r = 0 Then
                    nRecDev = row.Cells("RecDev").Value + 1
                    r = 1
                Else
                    nRecDev = 0
                End If
                nAbonoBenefi = row.Cells("Benef").Value
                Me.Fallero1TableAdapter.FillRemesaByCodigo(Me.DataSet1.Fallero1, nCod)
                Dgv1.Refresh()
                nFalleDevBenefi = Dgv1.CurrentRow.Cells("DevBenef").Value - nAbonoBenefi
                nFalleRecDev = Dgv1.CurrentRow.Cells("ReciboDev").Value + nRecDev
                nFalleOtroscargos = Dgv1.CurrentRow.Cells("OtroCgo").Value + nOtrosCargos
                nFalleAcuenta = Dgv1.CurrentRow.Cells("EntAcuenta").Value + nAcuenta
                nFallePago = Dgv1.CurrentRow.Cells("PAGO").Value
                nFalleNumPagos = Dgv1.CurrentRow.Cells("NumPagos").Value + nPagos
                nDeuda = nFallePago * nFalleNumPagos + nFalleOtroscargos - (nFalleBenefi - nFalleDevBenefi) - nFalleAcuenta
                Try
                    Fallero1TableAdapter.UpdateRemesa(nFalleDevBenefi, nFalleRecDev, nFalleOtroscargos, nFalleAcuenta,
                                                        nFalleNumPagos, nDeuda, nCod)
                    Remesas1TableAdapter.UpdateBloqueo(True, True, nId, nCod)
                Catch ex As Exception
                    MsgBox("Error, no se actualizó la devolucion")
                    Exit Sub
                End Try
                'Me.DgvFallero.Refresh()
            End If
        Next
        If n = Dgv.Rows.Count Then
            MsgBox("Aplicada devolución a Titular " & TextBox1.Text)
            Me.Remesas1TableAdapter.FillByDevolución(ReportsDataSet.remesas1, nId, cTit)
            DgvDevolucion.Refresh()
            Me.BtnAplicar.Enabled = False
        End If
    End Sub

End Class