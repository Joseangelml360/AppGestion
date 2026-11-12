Public Class FrmGenerarRemesa
    Private Sub FrmGenerarRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.FalleroDetalleRemesa' Puede moverla o quitarla según sea necesario.
        Me.FalleroDetalleRemesaTableAdapter.Fill(Me.DataSet1.FalleroDetalleRemesa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.detalles_de_remesa' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_remesaTableAdapter.Fill(Me.DataSet1.detalles_de_remesa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Detalles_de_remesaDataGridView.DefaultCellStyle.Font = New Font("Calibri", 8)
        Me.Chkestado.Enabled = False
        Me.ConsolidarRemesaCheckBox.Enabled = False
        Me.EnviarRemesaCheckBox.Enabled = False
        Me.ProgressBar1.Visible = False
        Me.Label12.Text = ""

        For Each c As Control In GroupBox3.Controls
            c.Enabled = False
        Next

        Select Case Me.TxtTipoRemesa.Text
            Case 1
                Me.TxtNombreRemesa.Text = "Mensual"
            Case 2
                Me.TxtNombreRemesa.Text = "Anual"
            Case 3
                Me.TxtNombreRemesa.Text = "Anual/Mensual"
            Case Else
                Me.TxtNombreRemesa.Text = "No definido"
        End Select

        If Me.Chkestado.Checked = False Then
            Me.LblEstado.Text = "Sin generar"
            Me.Detalles_de_remesaDataGridView.Visible = False
            Me.BtnCalcular.Enabled = False
            Me.BtnEditar.Enabled = False
            Me.BtnAddFallero.Enabled = False
            Me.BtnBorrar.Enabled = False
            If Me.TxtNombreRemesa.Text = "No definido" Then
                MsgBox("No se ha iniciado nueva Remesa")
                Me.LblEstado.Text = "Sin generar"
                Me.Detalles_de_remesaDataGridView.Visible = False
                Me.BtnCalcular.Enabled = False
                Me.BtnEditar.Enabled = False
                Me.BtnAddFallero.Enabled = False
                Me.BtnBorrar.Enabled = False
                Me.BtnAddRegistros.Enabled = False
                Me.BtnRefresh.Enabled = False
                For Each c As Control In GroupBox2.Controls
                    c.Enabled = False
                Next
                Me.Button1.Focus()
            End If
        Else
            Me.LblEstado.Text = "Generado"
            Me.BtnAddRegistros.Enabled = False
            Me.BtnCalcular.Enabled = False
            Me.BtnEditar.Enabled = True
            Me.TxtNPagos.Text = Me.Detalles_de_remesaDataGridView.Rows(0).Cells(5).Value
            Me.TxtId.Text = Me.Detalles_de_remesaDataGridView.Rows(0).Cells(16).Value
            Me.DtpFechaCrea.Value = Me.Detalles_de_remesaDataGridView.Rows(0).Cells(17).Value
            Me.DtpFechaCgo.Value = Me.Detalles_de_remesaDataGridView.Rows(0).Cells(18).Value
            Me.TxtValdev.Text = Me.Detalles_de_remesaDataGridView.Rows(0).Cells(12).Value
            Me.TxtNombreRemesa.Text = "Remesa generada"
            Totales()
            If Me.ConsolidarRemesaCheckBox.Checked = True Then
                Me.LblConsolidar.Text = "Consolidada"
                Me.BtnAddRegistros.Enabled = False
                Me.BtnCalcular.Enabled = False
                Me.BtnEditar.Enabled = False
                Me.BtnBorrar.Enabled = False
                Me.BtnAddFallero.Enabled = False
                For Each c As Control In GroupBox2.Controls
                    c.Enabled = False
                Next
            End If
            If Me.EnviarRemesaCheckBox.Checked = True Then
                Me.LblEnviar.Text = "Enviada"
                Me.BtnAddRegistros.Enabled = False
                Me.BtnCalcular.Enabled = False
                Me.BtnEditar.Enabled = False
                Me.BtnBorrar.Enabled = False
                Me.BtnAddFallero.Enabled = False
                For Each c As Control In GroupBox2.Controls
                    c.Enabled = False
                Next
            End If
        End If

    End Sub

    Private Sub Totales()
        Me.Detalles_de_remesaTableAdapter.Fill(DataSet1.detalles_de_remesa)
        Me.Detalles_de_remesaDataGridView.Refresh()
        Me.TxtNumRecibos.Text = Me.Detalles_de_remesaDataGridView.Rows.Count
        Dim Dgv As New DataGridView
        Dim nSumCargo As Double
        Dim nSumAbono As Double
        Dim nTotRemesa As Double
        Dgv = Detalles_de_remesaDataGridView
        For i = 0 To Dgv.Rows.Count - 1
            nSumCargo += Val(Dgv.Rows(i).Cells(13).Value.ToString)
            nSumAbono += Val(Dgv.Rows(i).Cells(9).Value.ToString)
            nTotRemesa += Val(Dgv.Rows(i).Cells(15).Value.ToString)
        Next
        Me.TxtCargos.Text = Math.Round(nSumCargo, 2)
        Me.TxtAbonos.Text = Math.Round(nSumAbono, 2)
        Me.TxtTotalRemesa.Text = Math.Round(nTotRemesa, 2)
    End Sub

    Private Sub Calcular()
        Dim nTotCuota, nOtrosCargos, nRecDev, nValDev, nSumaCargos, nNumPagos, nPagos, nBenef, nCod, nDeuda As Double
        Dim nDevbenef, nAcuenta, nAbonobenefi, nResto, nTotalAbonos, nTotalRecibo, nTotalCargo, nCuotasAño, nRecEmitidos As Double
        Dim cont As Integer
        '
        'Asignar valores fijos
        '
        Me.Detalles_de_remesaDataGridView.Visible = True
        nValDev = Val(Me.TxtValdev.Text)
        nPagos = Val(Me.TxtNPagos.Text)
        Me.TxtId.Text = Detalles_de_remesaDataGridView.Rows(0).Cells("Id").Value.ToString
        '
        '
        'Asignar valores a variables para el cálculo fila a fila
        '
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Maximum = Detalles_de_remesaDataGridView.Rows.Count
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Visible = True
        cont = Me.Detalles_de_remesaDataGridView.Rows.Count - 1

        For i = 0 To cont
            nRecEmitidos = Val(Me.TxtRecEmitidos.Text)
            If Me.Detalles_de_remesaDataGridView.Rows(i).Cells("TIPO_CUOTA").Value = "ANUAL" Then
                nRecEmitidos = 0
            End If
            nCuotasAño = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("NumCuotas").Value
            nRecDev = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("Recdev").Value
            nNumPagos = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("NumPagos").Value + nRecEmitidos + nPagos - nCuotasAño

            nCod = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("FALLERO_CODIGO").Value
            nDeuda = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("parcial1").Value
            nTotCuota = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("PAGO").Value * nNumPagos
            '           If nTotCuota > nDeuda Then
            '          nTotCuota = nDeuda
            '         End If
            nOtrosCargos = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("OtrosCargos").Value
            nSumaCargos = nTotCuota + nOtrosCargos + (nRecDev * nValDev)
            nAcuenta = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("EntregasAcuenta").Value
            nBenef = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("BENEFICIOS").Value
            nDevbenef = Me.Detalles_de_remesaDataGridView.Rows(i).Cells("DEV_BENEFI").Value
            nResto = Math.Round(nBenef - nDevbenef, 2)
            nTotalAbonos = Math.Round(nAcuenta + nResto, 2)
            nTotalCargo = Math.Round(nSumaCargos - nTotalAbonos, 2)

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

                Me.Detalles_de_remesaTableAdapter.UpdateFilas(nResto, nAcuenta, nValDev, nTotCuota, nTotalCargo, nTotalAbonos,
                                             nAbonobenefi, nSumaCargos, nTotalRecibo, nNumPagos, nOtrosCargos, nRecDev, nCod)
            Catch ex As Exception
                MsgBox("Error en el cálculo")
            End Try
            Me.ProgressBar1.Value += 1

        Next

        MsgBox("Nuevos valores asignados")
        Me.EstadoTableAdapter.UpdateGenerarRemesa(True)
        Me.Chkestado.Checked = True
        Me.LblEstado.Text = "Generada"
        Me.BtnEditar.Enabled = True
        Me.BtnAddRegistros.Enabled = False
        Me.BtnCalcular.Enabled = False
        Me.BtnAddFallero.Enabled = True
        Me.BtnBorrar.Enabled = True
        Me.ProgressBar1.Visible = False
        Me.Label12.Text = ""
        Totales()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnAddRegistros_Click(sender As Object, e As EventArgs) Handles BtnAddRegistros.Click
        Dim sCuota As String

        If Me.Chkestado.Checked = False Then
            Me.Detalles_de_remesaTableAdapter.DeleteQuery()
            Me.Detalles_de_remesaTableAdapter.InsertDetalleRemesa3()
            Try
                If Me.TxtTipoRemesa.Text = 3 Then
                    Me.Detalles_de_remesaDataGridView.Refresh()
                ElseIf Me.TxtTipoRemesa.Text = 2 Then
                    sCuota = "MENSUAL"
                    Me.Detalles_de_remesaTableAdapter.DeleteTipoCuota(sCuota)
                    Me.Detalles_de_remesaDataGridView.Refresh()
                ElseIf Me.TxtTipoRemesa.Text = 1 Then
                    sCuota = "ANUAL"
                    Me.Detalles_de_remesaTableAdapter.DeleteTipoCuota(sCuota)
                    Me.Detalles_de_remesaDataGridView.Refresh()
                Else
                    MsgBox("No está definido el tipo de remesa, revise Tipo Remesa")
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox("Error en la cláusula SQL")
            End Try

            Try
                Dim dFechCrea, dFechCgo As String
                dFechCrea = FormatDateTime(Me.DtpFechaCrea.Value, DateFormat.ShortDate)
                dFechCgo = FormatDateTime(Me.DtpFechaCgo.Value, DateFormat.ShortDate)

                Me.Detalles_de_remesaTableAdapter.UpdateDetRemInicio(Val(Me.TxtValdev.Text),
                    Val(Me.TxtId.Text), dFechCrea, dFechCgo)
                Me.Detalles_de_remesaTableAdapter.Fill(DataSet1.detalles_de_remesa)
                Me.Detalles_de_remesaDataGridView.Visible = True
                Me.Detalles_de_remesaDataGridView.Refresh()
                Me.BtnAddRegistros.Enabled = False
                Me.BtnCalcular.Enabled = True
                EstadoTableAdapter.UpdateEnviarRemesa(False)
                EstadoTableAdapter.UpdateConsolidar(False)
            Catch ex As Exception
                MsgBox("No se han añadidos valores de inicio a la tabla")
            End Try
        End If




    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Me.Label12.Text = "Calculando"
        Calcular()
        Me.Button1.Text = "Salir"
        Me.Button1.Image = My.Resources.door_out
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim frm As New FrmEditarLineaRemesa
        frm.TxtCodigo.Text = Detalles_de_remesaDataGridView.CurrentRow.Cells(1).Value
        frm.ShowDialog()
        Totales()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim nCod As Double = Detalles_de_remesaDataGridView.CurrentRow.Cells(1).Value
        Dim cNom, cApe As String
        cNom = Detalles_de_remesaDataGridView.CurrentRow.Cells(2).Value
        cApe = Detalles_de_remesaDataGridView.CurrentRow.Cells(3).Value
        Dim nResult As Integer

        nResult = MsgBox("Eliminar de la remesa a Fallero: " & nCod & vbCrLf & cNom & " " & cApe, vbYesNo)

        If nResult = 6 Then
            Detalles_de_remesaTableAdapter.DeleteByCodigo(nCod)

            Totales()
        End If

    End Sub


    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Totales()
    End Sub

    Private Sub BtnAddFallero_Click(sender As Object, e As EventArgs) Handles BtnAddFallero.Click
        Dim frm As New FrmSelectFalleroDetRemesa
        frm.TxtId.Text = Me.TxtId.Text
        frm.TxtNumPagos.Text = Me.TxtNPagos.Text
        frm.TxtValDev.Text = Me.TxtValdev.Text
        frm.DtpFechaCrea.Value = Me.DtpFechaCrea.Value
        frm.DtpFechaCargo.Value = Me.DtpFechaCgo.Value
        frm.ShowDialog()
        Totales()
    End Sub

    Private Sub TxtNPagos_Leave(sender As Object, e As EventArgs) Handles TxtNPagos.Leave
        If Me.Detalles_de_remesaDataGridView.Rows(0).Cells(5).Value.ToString <> Me.TxtNPagos.Text Then
            Me.Label12.Text = "Calculando ... "
            Calcular()
        End If

    End Sub

    Private Sub TxtValdev_Leave(sender As Object, e As EventArgs) Handles TxtValdev.Leave
        If Me.Detalles_de_remesaDataGridView.Rows(0).Cells(12).Value.ToString <> Me.TxtValdev.Text Then
            Me.Label12.Text = "Calculando ... "
            Calcular()
        End If

    End Sub

    Private Sub DtpFechaCrea_Leave(sender As Object, e As EventArgs) Handles DtpFechaCrea.Leave
        If Me.Detalles_de_remesaDataGridView.Rows(0).Cells(17).Value <> Me.DtpFechaCrea.Value Then
            CambiarFecha()
            MsgBox("Fecha de creación cambiada")
        End If

    End Sub

    Private Sub DtpFechaCgo_Leave(sender As Object, e As EventArgs) Handles DtpFechaCgo.Leave
        If Me.Detalles_de_remesaDataGridView.Rows(0).Cells(18).Value <> Me.DtpFechaCgo.Value Then
            CambiarFecha()
            MsgBox("Fecha de cargo cambiada")
        End If

    End Sub

    Private Sub CambiarFecha()
        Dim sFechCrea, sFechCgo As String
        sFechCrea = Me.DtpFechaCrea.Value.ToString
        sFechCgo = Me.DtpFechaCgo.Value.ToString
        Try
            Detalles_de_remesaTableAdapter.UpdateFecha(sFechCrea, sFechCgo)
            Detalles_de_remesaTableAdapter.Fill(DataSet1.detalles_de_remesa)
            Me.Detalles_de_remesaDataGridView.Refresh()
        Catch ex As Exception
            MsgBox("No se ha realizado actualización de fechas")
        End Try
    End Sub

End Class