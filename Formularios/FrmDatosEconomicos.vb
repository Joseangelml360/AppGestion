Imports System.Data
Imports System.Data.OleDb

Public Class FrmDatosEconomicos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DbCensos.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.descuentos_de_la_cuota' Puede moverla o quitarla según sea necesario.
        Me.Descuentos_de_la_cuotaTableAdapter.Fill(Me.DbCensos.descuentos_de_la_cuota)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.tipo_de_cuotas' Puede moverla o quitarla según sea necesario.
        Me.Tipo_de_cuotasTableAdapter.Fill(Me.DbCensos.tipo_de_cuotas)
        Me.DgvFallero.Visible = False
        Me.RESTOTxt.Text = Val(BENEFICIOSTextBox.Text) - Val(DEV_BENEFITextBox.Text)

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If
        Me.Lblfiltro.Text = "Activos"
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

    End Sub

    Private Sub FalleroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FalleroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FalleroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbCensos)

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim nValor, nDto, nNumCuotas, nPago, nResto, nCargos As Double
        Dim nPagosPdtes, nTotalCuota, nDeuda, nAcumulado As Double
        Dim cCuenta = Me.CUENTATextBox.Text.Replace(" ", "")
        Me.CUENTATextBox.Text = cCuenta

        ' Comprobar Titular, cuenta IBAN y el check del Banco
        If Me.BANCOCheckBox.Checked = True Then

            If Me.TITULARTextBox.Text = Nothing Or Me.CUENTATextBox.Text = Nothing Then
                MsgBox("Con el check en 'Banco' introduce Titular y la Cuenta Bancaria")
                Exit Sub
            End If

            ' Llamar a la función que valida el IBAN
            Dim sCta As String = cCuenta
            Dim result As Boolean
            If Len(sCta) < 12 Then
                MsgBox("La longitud de la cuenta no es correcta. Introduce un valor correcto.")
                Me.CUENTATextBox.Focus()
                Exit Sub
            End If

            result = funciones.ValidarIBAN(sCta)

            If result = "False" Then
                MsgBox("El IBAN No es válido." & vbCrLf & "La cuenta no es correcta.")
                Me.CUENTATextBox.Focus()
                Exit Sub
            End If
        End If

        ' Beneficios de Loteria
        Me.RESTOTxt.Text = Val(Me.BENEFICIOSTextBox.Text) - Val(Me.DEV_BENEFITextBox.Text)

        'Recibos devueltos
        If Me.RECDEVTextBox.Text = "" Then
            Me.RECDEVTextBox.Text = 0
        End If

        'Entregas a cuenta
        If Me.A_CUENTATextBox.Text = "" Then
            Me.A_CUENTATextBox.Text = 0
        End If

        'Cálculo de la cuota y deuda
        nValor = Val(Me.VALOR_CUOTATextBox.Text)
        nDto = Val(Me.DESCUENTOTextBox.Text)
        nNumCuotas = Val(Me.NUM_CUOTASTextBox.Text)
        nPagosPdtes = Val(Me.NUM_PAGOSTextBox.Text)
        nAcumulado = Val(Me.A_CUENTATextBox.Text)
        nResto = Val(RESTOTxt.Text)
        nCargos = Val(OTROS_CARGOSTextBox.Text)
        nPago = nValor * (1 - (nDto / 100))
        nTotalCuota = nPago * nNumCuotas
        nDeuda = nPago * nPagosPdtes + nCargos - nAcumulado - nResto

        Me.PAGOTextBox.Text = nPago
        Me.TOTAL_CUOTATextBox.Text = nTotalCuota
        Me.DEUDATextBox.Text = nDeuda

        'Guardar cambios
        Try
            Me.Validate()
            Me.FalleroBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbCensos)
            Me.DbCensos.AcceptChanges()
            MsgBox("Exito en la actualización de datos" & Chr(13) & "Se han guardado los cambios", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("Error en la actualización de datos" & vbCr & "No se han guardado los cambios", vbCritical, "Aviso")
        End Try

        Try
            Me.FalleroTableAdapter.UpdateCuenta(cCuenta, Val(Me.FALLERO_CODIGOTextBox.Text))
        Catch ex As Exception
            MsgBox("Error al guardar la cuenta, revisa el dato")
        End Try

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Id_CUOTAComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Id_CUOTAComboBox.SelectedIndexChanged
        Dim nValor, nCargos As String
        Dim nDesc As String
        Dim nPago, nDeuda, nTotalCuota, nPdte As Double
        Dim nAcumulado, nResto As Double
        Dim IdCta As Integer

        'nCod = Me.Id_CUOTAComboBox.SelectedIndex.ToString
        nValor = Me.Id_CUOTAComboBox.SelectedValue
        nDesc = Me.Id_CUOTAComboBox.Text
        If nDesc = Nothing Then
            IdCta = 0
        Else
            IdCta = Tipo_de_cuotasTableAdapter.ScalarQuery(nDesc)
        End If
        nAcumulado = Val(Me.A_CUENTATextBox.Text)
        nResto = Val(Me.RESTOTxt.Text)
        nCargos = Val(OTROS_CARGOSTextBox.Text)

        Me.Id_cuotaTextBox.Text = IdCta
        Me.DESCRIP_CUOTATextBox.Text = nDesc
        Me.VALOR_CUOTATextBox.Text = Val(nValor)

        Select Case IdCta
            Case 1, 2, 4, 5, 7 To 14, 21
                Me.LOTERIACheckBox.Checked = False
                Me.TIPO_CUOTAComboBox.Text = "ANUAL"
                Me.NUM_CUOTASTextBox.Text = 1

            Case 3, 6, 15 To 18
                Me.LOTERIACheckBox.Checked = False
                Me.TIPO_CUOTAComboBox.Text = "MENSUAL"
                Me.NUM_CUOTASTextBox.Text = Me.NumcuotasmesTextBox.Text

            Case 19, 20
                Me.LOTERIACheckBox.Checked = True
                Me.TIPO_CUOTAComboBox.Text = "MENSUAL"
                Me.NUM_CUOTASTextBox.Text = Me.NumcuotasmesTextBox.Text

        End Select

        nPago = Val(Me.VALOR_CUOTATextBox.Text) * (1 - Val(Me.DESCUENTOTextBox.Text) / 100)
        Me.PAGOTextBox.Text = nPago
        nTotalCuota = Val(Me.PAGOTextBox.Text) * Val(Me.NUM_CUOTASTextBox.Text)
        Me.TOTAL_CUOTATextBox.Text = nTotalCuota
        nPdte = Val(Me.NUM_PAGOSTextBox.Text)
        nDeuda = (nPago * nPdte) + nCargos - nAcumulado - nResto
        Me.DEUDATextBox.Text = nDeuda

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If
    End Sub


    Private Sub Id_DESCUENTOComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Id_DESCUENTOComboBox.SelectedIndexChanged
        Dim nCod, nValor As String
        Dim nDesc As String
        Dim nPago, nDeuda, nTotalCuota, nPdte As Double
        Dim nAcumulado, nResto, nCargos As Double

        nCod = Me.Id_DESCUENTOComboBox.SelectedIndex.ToString
        nValor = Me.Id_DESCUENTOComboBox.SelectedValue
        nDesc = Me.Id_DESCUENTOComboBox.Text
        nAcumulado = Val(Me.A_CUENTATextBox.Text)
        nResto = Val(Me.RESTOTxt.Text)
        nCargos = Val(Me.OTROS_CARGOSTextBox.Text)

        Me.Id_DESCUENTOTextBox.Text = Val(nCod) + 1
        Me.DESCRIP_DESCUENTOTextBox.Text = nDesc
        Me.DESCUENTOTextBox.Text = Val(nValor)

        nPago = Val(Me.VALOR_CUOTATextBox.Text) * (1 - Val(Me.DESCUENTOTextBox.Text) / 100)
        Me.PAGOTextBox.Text = nPago
        nTotalCuota = Val(Me.PAGOTextBox.Text) * Val(Me.NUM_CUOTASTextBox.Text)
        Me.TOTAL_CUOTATextBox.Text = nTotalCuota
        nPdte = Val(Me.NUM_PAGOSTextBox.Text)
        nDeuda = nPago * nPdte + nCargos - nAcumulado - nResto
        Me.DEUDATextBox.Text = nDeuda

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub ENTREGAS_A_CUENTATextBox_Leave(sender As Object, e As EventArgs) Handles ENTREGAS_A_CUENTATextBox.Leave
        Dim nIngreso, nAcumulado As Double

        If IsNumeric(Val(ENTREGAS_A_CUENTATextBox.Text)) Then
            nIngreso = Val(Me.ENTREGAS_A_CUENTATextBox.Text)
        Else
            nIngreso = 0
        End If

        If IsNumeric(Val(A_CUENTATextBox.Text)) Then
            nAcumulado = Val(Me.A_CUENTATextBox.Text)
        Else
            nAcumulado = 0
        End If

        nAcumulado += nIngreso
        Me.A_CUENTATextBox.Text = nAcumulado
        Me.ENTREGAS_A_CUENTATextBox.Text = 0

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub BENEFICIOSTextBox_Enter(sender As Object, e As EventArgs) Handles BENEFICIOSTextBox.Enter
        Dim nBeneficio, ndevBeneficio As Double
        nBeneficio = Val(Me.BENEFICIOSTextBox.Text)
        ndevBeneficio = Val(Me.DEV_BENEFITextBox.Text)
        Me.RESTOTxt.Text = nBeneficio - ndevBeneficio

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub DEV_BENEFITextBox_Leave(sender As Object, e As EventArgs) Handles DEV_BENEFITextBox.Leave
        Dim nBeneficio, ndevBeneficio As Double
        nBeneficio = Val(Me.BENEFICIOSTextBox.Text)
        ndevBeneficio = Val(Me.DEV_BENEFITextBox.Text)
        Me.RESTOTxt.Text = nBeneficio - ndevBeneficio

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub RESTOTxt_DoubleClick(sender As Object, e As EventArgs) Handles RESTOTxt.DoubleClick
        Dim nBeneficio, ndevBeneficio As Double
        nBeneficio = Val(Me.BENEFICIOSTextBox.Text)
        ndevBeneficio = Val(Me.DEV_BENEFITextBox.Text)
        Me.RESTOTxt.Text = nBeneficio - ndevBeneficio

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim nValor, nDto, nNumCuotas, nPago, nResto, nCargo As Double
        Dim nPagosPdtes, nTotalCuota, nDeuda, nAcumulado As Double

        Me.RESTOTxt.Text = Val(Me.BENEFICIOSTextBox.Text) - Val(Me.DEV_BENEFITextBox.Text)

        If Me.RECDEVTextBox.Text = "" Then
            Me.RECDEVTextBox.Text = 0
        End If

        If Me.A_CUENTATextBox.Text = "" Then
            Me.A_CUENTATextBox.Text = 0
        End If

        nValor = Val(Me.VALOR_CUOTATextBox.Text)
        nDto = Val(Me.DESCUENTOTextBox.Text)
        nNumCuotas = Val(Me.NUM_CUOTASTextBox.Text)
        nPagosPdtes = Val(Me.NUM_PAGOSTextBox.Text)
        nAcumulado = Val(Me.A_CUENTATextBox.Text)
        nResto = Val(Me.RESTOTxt.Text)
        nCargo = Val(Me.OTROS_CARGOSTextBox.Text)
        nPago = nValor * (1 - (nDto / 100))
        nTotalCuota = nPago * nNumCuotas
        'MsgBox(nTotalCuota)
        nDeuda = nPago * nPagosPdtes + nCargo - nAcumulado - nResto

        Me.PAGOTextBox.Text = nPago
        Me.TOTAL_CUOTATextBox.Text = nTotalCuota
        Me.DEUDATextBox.Text = nDeuda

        Me.BtnActualizar.Enabled = True
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub ActivosToolStripButton_Click(sender As Object, e As EventArgs) Handles ActivosToolStripButton.Click
        Try
            Me.FalleroTableAdapter.FillByActivos(Me.DbCensos.fallero)
            Me.Lblfiltro.Text = "Activos"
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MayoresToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FalleroTableAdapter.Mayores(Me.DbCensos.fallero)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Mayores"

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.FalleroTableAdapter.Mayores(Me.DbCensos.fallero)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Mayores"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            Me.FalleroTableAdapter.Infantiles(Me.DbCensos.fallero)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Infantiles"
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Try
            Me.FalleroTableAdapter.Anual(Me.DbCensos.fallero)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Anual"
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Try
            Me.FalleroTableAdapter.Mensual(Me.DbCensos.fallero)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Mensual"
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Try
            Me.FalleroTableAdapter.FillByTitular(Me.DbCensos.fallero, Me.TITULARTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Titular"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.FalleroTableAdapter.Bajas(Me.DbCensos.fallero)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Lblfiltro.Text = "Bajas"
    End Sub

    Private Sub DEV_BENEFITextBox_TabIndexChanged(sender As Object, e As EventArgs) Handles DEV_BENEFITextBox.TabIndexChanged
        Me.RESTOTxt.Text = Val(Me.BENEFICIOSTextBox.Text) - Val(Me.DEV_BENEFITextBox.Text)

        Me.BtnActualizar.Enabled = False
        If Val(Me.DEUDATextBox.Text) = 0 Then
            Me.BtnAddPago.Enabled = False
        Else
            Me.BtnAddPago.Enabled = True
        End If

    End Sub

    Private Sub DgvFALLERO_Click(sender As Object, e As EventArgs) Handles DgvFallero.Click
        Me.DgvFallero.Visible = False

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Me.DgvFallero.Visible = True
        Try
            If Me.Lblfiltro.Text = "Infantiles" Then
                Me.FalleroTableAdapter.FillByInfantiles(DbCensos.fallero, TxtBuscar.Text)
                DgvFallero.Refresh()
            ElseIf Me.Lblfiltro.Text = "Mayores" Then
                Me.FalleroTableAdapter.FillByMayores(DbCensos.fallero, TxtBuscar.Text)
                DgvFallero.Refresh()
            ElseIf Me.Lblfiltro.Text = "Bajas" Then
                Me.FalleroTableAdapter.FillByBajas(Me.DbCensos.fallero, TxtBuscar.Text)
                DgvFallero.Refresh()
            ElseIf Me.Lblfiltro.Text = "Anual" Then
                Me.FalleroTableAdapter.FillByAnual(Me.DbCensos.fallero, TxtBuscar.Text)
                DgvFallero.Refresh()
            ElseIf Me.Lblfiltro.Text = "Mensual" Then
                Me.FalleroTableAdapter.FillByMensual(Me.DbCensos.fallero, TxtBuscar.Text)
                DgvFallero.Refresh()
            ElseIf Me.Lblfiltro.Text = "Juveniles" Then
                Me.FalleroTableAdapter.FillByJuveniles(Me.DbCensos.fallero, TxtBuscar.Text)
                Me.DgvFallero.Refresh()
            Else
                Me.FalleroTableAdapter.FillByApellidos(Me.DbCensos.fallero, TxtBuscar.Text)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnVerPagos_Click(sender As Object, e As EventArgs) Handles BtnVerPagos.Click
        Dim Frm As New FrmVerPagos
        Frm.CODIGOTextBox.Text = Val(Me.FALLERO_CODIGOTextBox.Text)
        Frm.Show()
    End Sub

    Private Sub BtnAddPago_Click(sender As Object, e As EventArgs) Handles BtnAddPago.Click
        Dim frm As New FrmAddPago

        frm.TxtCodigo.Text = Me.FALLERO_CODIGOTextBox.Text
        frm.TxtNombre.Text = Me.NOMBRETextBox.Text
        frm.TxtApellidos.Text = Me.APELLIDOSTextBox.Text
        frm.TxtComision.Text = Me.TIPFALTextBox.Text
        frm.TxtTitular.Text = Me.TITULARTextBox.Text
        frm.TxtTipoCuota.Text = Me.TIPO_CUOTAComboBox.SelectedItem
        frm.TxtPago.Text = Me.PAGOTextBox.Text
        frm.TxtNumCuotas.Text = Me.NUM_CUOTASTextBox.Text
        frm.TxtMesesDeuda.Text = Me.NUM_PAGOSTextBox.Text
        frm.TxtDeuda.Text = Me.DEUDATextBox.Text
        frm.TxtCargos.Text = Me.OTROS_CARGOSTextBox.Text
        frm.TxtRecDev.Text = Me.RECDEVTextBox.Text
        frm.TxtAcuenta.Text = Me.A_CUENTATextBox.Text
        frm.TxtBeneficios.Text = Me.BENEFICIOSTextBox.Text
        frm.TxtBenefAbonado.Text = Me.DEV_BENEFITextBox.Text
        frm.TxtRestoBenef.Text = Me.RESTOTxt.Text
        frm.TxtNumMeses.Text = Me.NUM_PAGOSTextBox.Text
        frm.ShowDialog()

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Me.FalleroTableAdapter.Juveniles(DbCensos.fallero)
        Catch ex As Exception
            MsgBox("no se encuentran Juveniles")
        End Try
        Me.Lblfiltro.Text = "Juveniles"
    End Sub

    Private Sub LOTERIACheckBox_MouseHover(sender As Object, e As EventArgs) Handles LOTERIACheckBox.MouseHover
        ToolTip1.SetToolTip(LOTERIACheckBox, "Este campo se marca automáticamente según la opción de cuota")
        ToolTip1.ToolTipTitle = "Lotería"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BtnCalcular_MouseHover(sender As Object, e As EventArgs) Handles BtnCalcular.MouseHover
        ToolTip1.SetToolTip(BtnCalcular, "Pulsa para recalcular totales")
        ToolTip1.ToolTipTitle = "Botón Calcular"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover
        ToolTip1.SetToolTip(BtnActualizar, "Pulsa para guardar cambios después de calcular")
        ToolTip1.ToolTipTitle = "Botón actualizar"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BANCOCheckBox_MouseHover(sender As Object, e As EventArgs) Handles BANCOCheckBox.MouseHover
        ToolTip1.SetToolTip(BANCOCheckBox, "Debe estar marcado para gestionar remesas por banco," & vbCrLf & "TITULAR y CUENTA requieren datos")
        ToolTip1.ToolTipTitle = "Banco"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TxtBuscar_MouseHover(sender As Object, e As EventArgs) Handles TxtBuscar.MouseHover
        ToolTip1.SetToolTip(TxtBuscar, "Escribe el apellido a buscar y selecciona en el desplegable para abrir la ficha")
        ToolTip1.ToolTipTitle = "Buscar fallero por apellidos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FrmSubDatosFiliación
        frm.FALLERO_CODIGOTextBox.Text = Val(Me.FALLERO_CODIGOTextBox.Text)
        frm.Show()
    End Sub

    Private Sub BtnBuscarCodigo_Click(sender As Object, e As EventArgs) Handles BtnBuscarCodigo.Click
        If Val(TxtBuscarCodigo.Text <> "") Then

            Try
                Me.FalleroTableAdapter.FillByCodigo(Me.DbCensos.fallero, Val(TxtBuscarCodigo.Text))
            Catch ex As Exception
                MsgBox("Código de fallero no existe. Intenta de nuevo")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        Me.TxtBuscarCodigo.Text = ""
    End Sub


End Class
