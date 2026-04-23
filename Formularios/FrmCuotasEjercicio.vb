Public Class FrmCuotasEjercicio
    Private Sub FrmCuotasEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.Fill(Me.DataSetCuotas.fallero)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Dim nTotal, nPos, nNeg As Double

        Me.TxtCuotas.Text = Me.FalleroTableAdapter.ScalarQueryTotalCuotas().ToString
        nTotal = Val(Me.TxtCuotas.Text)
        Me.TxtCuotas.Text = FormatCurrency(TxtCuotas.Text)
        Me.TxtLotMay.Text = Me.FalleroTableAdapter.ScalarQueryCuotasLoteriaMayores().ToString
        nTotal += Val(TxtLotMay.Text)
        Me.TxtLotMay.Text = FormatCurrency(TxtLotMay.Text)
        If Me.FalleroTableAdapter.ScalarQueryCuotasLoteriaJuveniles() IsNot Nothing Then
            Me.TxtLotJuv.Text = Me.FalleroTableAdapter.ScalarQueryCuotasLoteriaJuveniles().ToString
        Else
            Me.TxtLotJuv.Text = 0
        End If
        nTotal += Val(TxtLotJuv.Text)
        Me.TxtLotJuv.Text = FormatCurrency(TxtLotJuv.Text)
        Me.TxtDeudas.Text = Me.FalleroTableAdapter.ScalarQueryDeudasEjeAnt().ToString
        nTotal += Val(TxtDeudas.Text)
        nPos = nTotal
        Me.TxtDeudas.Text = FormatCurrency(TxtDeudas.Text)
        Me.TxtBenef.Text = Me.FalleroTableAdapter.ScalarQueryTotalBeneficios().ToString
        nNeg = Val(TxtBenef.Text)
        nTotal -= Val(TxtBenef.Text)
        Me.TxtBenef.Text = FormatCurrency(TxtBenef.Text)
        Me.TxtAbonos.Text = Me.FalleroTableAdapter.ScalarQueryAbonosEjeAnt().ToString
        nNeg += Val(TxtAbonos.Text)
        nTotal -= Val(TxtAbonos.Text)
        Me.TxtAbonos.Text = FormatCurrency(TxtAbonos.Text)
        Me.TxtTotal.Text = FormatCurrency(nTotal)
        Me.TxtPositivo.Text = FormatCurrency(nPos)
        Me.TxtNegativo.Text = FormatCurrency(nNeg)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class