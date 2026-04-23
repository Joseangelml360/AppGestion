Imports System.IO

Public Class FrmEnviarRemesa
    Private Sub FrmEnviarRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.adeudos' Puede moverla o quitarla según sea necesario.
        Me.AdeudosTableAdapter.Fill(Me.DbCensos.adeudos)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DbCensos.clientes)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.banco_remesa' Puede moverla o quitarla según sea necesario.
        Me.Banco_remesaTableAdapter.Fill(Me.DbCensos.banco_remesa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.detalles_de_remesa' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_remesaTableAdapter.Fill(Me.DataSet1.detalles_de_remesa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.remesas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTableAdapter.FillUltimaRemesa(Me.DataSet1.remesas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        For Each c As Control In GroupBox1.Controls
            c.Enabled = False
        Next

        Me.Label7.Visible = False

        If Me.IdRemesaTextBox.Text = Me.IdTextBox.Text Then
            MsgBox("Todas las remesas actuales están enviadas." & vbCrLf & "Tienes que generar una remesa nueva")
            Me.BtnConsolidar.Enabled = False
            Me.BtnDeshacer.Enabled = False
            Me.BtnEnviar.Enabled = False
            Me.BtnInforme.Enabled = False
            Me.Button5.Focus()
        Else
            If Me.ConsolidarRemesaCheckBox.Checked = True Then
                Me.TxtConsolidar.Text = "CONSOLIDADA"
                Me.BtnDeshacer.Enabled = True
                Me.BtnEnviar.Enabled = True
                Me.BtnConsolidar.Enabled = False
                If Me.EnviarRemesaCheckBox.Checked = True Then
                    Me.TxtEnviar.Text = "ENVIADA"
                    Me.BtnDeshacer.Enabled = False
                    Me.BtnEnviar.Enabled = False
                    Me.BtnConsolidar.Enabled = False
                Else
                    Me.TxtEnviar.Text = "PENDIENTE"
                    Me.BtnDeshacer.Enabled = True
                    Me.BtnEnviar.Enabled = True
                    Me.BtnConsolidar.Enabled = False
                End If
            Else
                Me.TxtConsolidar.Text = "SIN CONSOLIDAR"
                Me.TxtEnviar.Text = "PENDIENTE"
                Me.BtnDeshacer.Enabled = False
                Me.BtnEnviar.Enabled = False
                Me.BtnConsolidar.Enabled = True
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub BtnConsolidar_Click(sender As Object, e As EventArgs) Handles BtnConsolidar.Click
        Dim frm As New FrmConsolidar
        frm.ShowDialog()
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.TxtConsolidar.Text = "CONSOLIDADA"
        Me.BtnConsolidar.Enabled = False
        Me.BtnDeshacer.Enabled = True
        Me.BtnEnviar.Enabled = True
    End Sub

    Private Sub BtnDeshacer_Click(sender As Object, e As EventArgs) Handles BtnDeshacer.Click
        Dim frm As New FrmDeshacerRemesa
        frm.ShowDialog()
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.TxtConsolidar.Text = "SIN CONSOLIDAR"
        Me.BtnConsolidar.Enabled = True
        Me.BtnDeshacer.Enabled = False
        Me.BtnEnviar.Enabled = False
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        'Crear Tabla Clientes (Se pasan los datos de Detalles de Remesa)
        'Crear Tabla Adeudos    (Primero se crean las lineas 1 y 2, a partir de la 3 se pasan los campos de Clientes a una sola linea, se finaiza con
        'los totales en la penúltima y última línea)
        'Crear fichero de texto según norma 19 para enviar remesa al Banco, a partir de la tabla Adeudos
        '
        If Me.ConsolidarRemesaCheckBox.Checked = False Then
            MsgBox("Antes de enviar la remesa es necesario que esté consolidada")
            Exit Sub
        End If
        Dim sConcepto, sMssg, sTitulo, sDefault, linea, TITULAR, NumReg, NumDomi, Plaza, CodPost, nImporte As String
        Dim Importe As Long
        Dim cRef, cTitular, cEnt, cOf, cDC, cNumC As String
        Dim nlinea, nReg, nImporteTotal, nContar, nContar2 As Double
        Dim nSufPres, nEntPres, nOfPres, nCIF, nSufOrd, nEntOrd, nOfOrd, nDCOrd, nCuentaOrd As String
        Dim sNombrePres, sOrdenante As String
        Dim dFechaCreacion, dFechaCargo, sCuenta As String

        'linea = ""
        nlinea = 0
        'Importe = 0

        'Borrar Tabla ‘Clientes’ 
        ClientesTableAdapter.DeleteQuery()
        'Añadir registros a Tabla Clientes, valores de Banco_Remesa y Detalles_de_remesa

        nCIF = DbCensos.banco_remesa.Rows(0)("CIF".ToString)
        nSufPres = DbCensos.banco_remesa.Rows(0)("SufOrd".ToString)
        Dim unusued As New DataTable
        Dim dt As DataTable = DataSet1.detalles_de_remesa

        Dim n As Integer = dt.Rows.Count - 1
        Dim i As Integer
        Dim nImporteNuevo As Double
        Dim cTitularNuevo As String

        Try
            Me.ProgressBar1.Visible = True
            Me.ProgressBar1.Maximum = dt.Rows.Count
            Me.ProgressBar1.Minimum = 0
            cRef = dt.Rows(0)("FALLERO_CODIGO".ToString)
            cTitular = dt.Rows(0)("TITULAR".ToString)
            nImporteTotal = Convert.ToDouble(dt.Rows(i)("totalrecibo".ToString))
            sCuenta = dt.Rows(0)("CUENTA".ToString)
            cEnt = Mid(sCuenta, 5, 4)
            cOf = Mid(sCuenta, 9, 4)
            cDC = Mid(sCuenta, 13, 2)
            cNumC = Mid(sCuenta, 15, 10)
            Me.ClientesTableAdapter.InsertRecord(nCIF, nSufPres, cRef, cTitular, cEnt, cOf, cDC, cNumC, cTitular, "", "", "", "", nImporteTotal, "", "", "", "", "01")
            Me.ProgressBar1.Value += 1
            nImporteNuevo = nImporteTotal
            cTitularNuevo = cTitular

            For i = 1 To n
                If dt.Rows(i)("TITULAR".ToString) <> cTitularNuevo Then
                    cRef = dt.Rows(i)("FALLERO_CODIGO".ToString)
                    cTitular = dt.Rows(i)("TITULAR".ToString)
                    nImporteTotal = Convert.ToDouble(dt.Rows(i)("totalrecibo".ToString))
                    sCuenta = dt.Rows(i)("CUENTA".ToString)
                    cEnt = Mid(sCuenta, 5, 4)
                    cOf = Mid(sCuenta, 9, 4)
                    cDC = Mid(sCuenta, 13, 2)
                    cNumC = Mid(sCuenta, 15, 10)
                    Me.ClientesTableAdapter.InsertRecord(nCIF, nSufPres, cRef, cTitular, cEnt, cOf, cDC, cNumC, cTitular, "", "", "", "", nImporteTotal, "", "", "", "", "01")
                    Me.ProgressBar1.Value += 1
                    cTitularNuevo = cTitular
                    nImporteNuevo = nImporteTotal
                Else
                    nImporteTotal = Convert.ToDouble(dt.Rows(i)("totalrecibo".ToString)) + nImporteNuevo
                    Me.ClientesTableAdapter.UpdateAdeudo(nImporteTotal, cTitular)
                    If i < n Then
                        If dt.Rows(i + 1)("TITULAR".ToString) <> cTitular Then
                            nImporteNuevo = 0
                        Else
                            nImporteNuevo = nImporteTotal
                        End If
                    End If
                End If
            Next i
        Catch ex As Exception
            MsgBox("Error al añadir registros a tabla Clientes" & vbCrLf & ex.Message)
        End Try
        Me.ClientesTableAdapter.DeletePagoCero()

        Me.ProgressBar1.Visible = False
        Me.Label7.Visible = False

        'Crear la tabla Adeudos
        'Vaciar registros de Adeudos
        AdeudosTableAdapter.DeleteAdeudos()
        'Añadir registros a la Tabla Adeudos desde Clientes
        Me.ClientesTableAdapter.Fill(DbCensos.clientes)

        'Extraer de InputBox el concepto para los recibos
        sMssg = "Escribe el texto para el concepto de la Remesa. Por ejemplo: CUOTAS FALLA MARZO 2021"
        sDefault = "CUOTAS FALLA " & MonthName(Month(Me.DtpFechCgoGen.Value)) & " " & Year(DtpFechCgoGen.Value)
        sDefault = sDefault.ToUpper
        sTitulo = "Input Descripción remesa"
        sConcepto = InputBox(sMssg, sTitulo, sDefault, 600, 300)
        If sConcepto = "" Then
            MsgBox("Se debe introducir el concepto para los recibos")
            Exit Sub
        End If

        '1ª linea del fichero Q19, adeudos para el banco
        'linea = ""
        dFechaCreacion = dt.Rows(0)("FechaCreacion".ToString)
        sNombrePres = DbCensos.banco_remesa.Rows(0)("Nombre Pres".ToString)
        nEntPres = DbCensos.banco_remesa.Rows(0)("EntPres".ToString)
        nOfPres = DbCensos.banco_remesa.Rows(0)("OfPres".ToString)
        linea = "5180" + nCIF + nSufPres + Mid(dFechaCreacion, 1, 2) + Mid(dFechaCreacion, 4, 2) + Mid(dFechaCreacion, 9, 2)
        linea = linea + Space(6) + sNombrePres + Space(40 - Len(sNombrePres))
        linea = linea + Space(20) + nEntPres + nOfPres + Space(66)
        Try
            Me.AdeudosTableAdapter.InsertLinea(linea)
        Catch ex As Exception
            MsgBox(ex.Message & "Error al escribir linea nº: " & nlinea)
        End Try
        '2ª línea del fichero Q19, adeudos para el banco
        'nlinea = 1
        nSufOrd = DbCensos.banco_remesa.Rows(0)("SufOrd".ToString)
        dFechaCargo = dt.Rows(0)("FechaCargo".ToString)
        sOrdenante = DbCensos.banco_remesa.Rows(0)("Ordenante".ToString)
        nEntOrd = DbCensos.banco_remesa.Rows(0)("EntOrd".ToString)
        nOfOrd = DbCensos.banco_remesa.Rows(0)("OfOrd".ToString)
        nDCOrd = DbCensos.banco_remesa.Rows(0)("DCOrd".ToString)
        nCuentaOrd = DbCensos.banco_remesa.Rows(0)("CuentaOrd".ToString)
        'linea = ""
        linea = "5380" + nCIF + nSufOrd + Mid(dFechaCreacion, 1, 2) + Mid(dFechaCreacion, 4, 2) + Mid(dFechaCreacion, 9, 2)
        linea = linea + Mid(dFechaCargo, 1, 2) + Mid(dFechaCargo, 4, 2) + Mid(dFechaCargo, 9, 2)
        linea = linea + sOrdenante + Space(40 - Len(sOrdenante)) + nEntOrd + nOfOrd + nDCOrd + Trim(nCuentaOrd)
        linea = linea + Space(8) + "01" + Space(64)
        nlinea = 2
        Try
            Me.AdeudosTableAdapter.InsertLinea(linea)
        Catch ex As Exception
            MsgBox(ex.Message & "Error al escribir linea nº: " & nlinea)
        End Try

        'A partir de la 3ª linea, volcamos datos de la tabla Clientes registro a registro

        Dim unused As New DataTable
        Dim dc As DataTable = DbCensos.clientes

        n = dc.Rows.Count - 1

        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        Me.ProgressBar1.Maximum = dc.Rows.Count
        Me.ProgressBar1.Minimum = 0
        nImporteTotal = 0
        For i = 0 To n
            Importe = Val(dc.Rows(i)("Adeudos".ToString)) * 100
            nImporte = Trim(Str(Importe))
            nImporte = Mid("0000000000", 1, 10 - Len(nImporte)) + nImporte
            TITULAR = dc.Rows(i)("NombreTitularDomiciliacion".ToString)
            nContar = 40 - Len(TITULAR)
            cRef = Trim(dc.Rows(i)("CodigoReferencia".ToString))
            cEnt = Trim(dc.Rows(i)("Entidad".ToString))
            cOf = Trim(dc.Rows(i)("Oficina".ToString))
            cDC = Trim(dc.Rows(i)("DC".ToString))
            cNumC = Trim(dc.Rows(i)("NumeroCuenta".ToString))
            If dc.Rows(i)("Domicilio".ToString) = "" Then
                NumDomi = ""
            Else
                NumDomi = Trim(dc.Rows(i)("Domicilio".ToString))
            End If

            Plaza = Trim(dc.Rows(i)("Plaza".ToString))
            CodPost = Trim(dc.Rows(i)("CodigoPostal".ToString))
            linea = "5680" + nCIF + nSufOrd + Mid("000000000000", 1, 12 - Len(cRef)) + cRef
            linea += TITULAR + Space(nContar) + cEnt + cOf + cDC + cNumC
            linea += nImporte
            linea += Space(16) + sConcepto + Space(40 - Len(sConcepto)) + Space(8)
            Me.AdeudosTableAdapter.InsertLinea(linea)

            nImporteTotal += Val(Importe)
            nlinea += 1

            ' 2ª Linea de cada registro de la tabla Clientes

            linea = "5686" + nCIF + nSufOrd + Mid("000000000000", 1, 12 - Len(cRef)) + cRef
            linea += TITULAR + Space(nContar) + NumDomi
            linea += Plaza + CodPost
            linea += Space(162 - Len(linea))
            Me.AdeudosTableAdapter.InsertLinea(linea)
            nlinea += 1
            nReg += 1
            Me.ProgressBar1.Value += 1
        Next i

        Me.ProgressBar1.Visible = False

        ' Penúltima línea, equivale a total ordenante

        Importe = Trim(nImporteTotal)
        nImporte = Trim(Str(Importe))
        nImporte = Mid("0000000000", 1, 10 - Len(nImporte)) + nImporte
        nContar = nReg
        nContar2 = nlinea
        NumDomi = Trim(nContar)
        NumDomi = Mid("000000000", 1, 10 - Len(NumDomi)) + NumDomi
        NumReg = Trim(nContar2)
        NumReg = Mid("000000000", 1, 10 - Len(NumReg)) + NumReg

        linea = "5880" + nCIF + nSufOrd + Space(72) + nImporte + Space(6) + NumDomi + NumReg + Space(38)
        Me.AdeudosTableAdapter.InsertLinea(linea)
        nlinea += 1

        ' Última línea, equivale al total general y cierra el archivo

        nContar2 = nlinea + 1
        NumReg = Trim(nContar2)
        NumReg = Mid("000000000", 1, 10 - Len(NumReg)) + NumReg
        linea = "5980" + nCIF + nSufOrd + Space(12) + "V-17/12/2008" + Space(28) + "0001"
        linea += Space(16) + nImporte + Space(6) + NumDomi + NumReg + Space(38)
        Me.AdeudosTableAdapter.InsertLinea(linea)
        Me.AdeudosTableAdapter.Fill(DbCensos.adeudos)
        '
        'Escribir el acrhivo de texto.q19
        Dim cNomAdeudos As String
        cNomAdeudos = "Adeudos" & Mid(dFechaCargo, 1, 2) & MonthName(Month(Me.DtpFechCgoGen.Value)) & Year(DtpFechCgoGen.Value)
        Dim ruta As String = "C:\Remesas\" & cNomAdeudos & ".q19"

        If File.Exists(ruta) = True Then
            File.Delete(ruta)  'Borrar el archivo q19 si existe
        Else
            MsgBox("No existe fichero " & ruta & " se ceará uno nuevo con este nombre")
        End If

        'código nuevo para escribir en ANSI
        Dim txtLinea As StreamWriter = New StreamWriter(ruta, True, System.Text.Encoding.Default)
        ' Fin código nuevo

        Try
            n = DbCensos.adeudos.Rows.Count - 1
            For i = 0 To n
                linea = DbCensos.adeudos.Rows(i)("linea".ToString)
                txtLinea.WriteLine(linea)
            Next i
            txtLinea.Flush()
            txtLinea.Close()
            MsgBox("Archivo q19 creado correctamente (" & ruta & ")")

        Catch ex As Exception
            MsgBox("Error en la escritura del archivo: " & ruta)
        End Try

        'Añadir a Remesas el detalle de la Remesa enviada al banco
        Dim nId, nCod, nPago, nNumCuotas, nBenef, nDevBenef, nOtrosCgos, nEntAcuenta, nResto, nTotCuotaAnual As Double
        Dim nNumPagos, nRecdev, nValdev, nTotCuota, ntotCgo, nAbonobenef, nSumCgo, nTotRecibo As Double
        Dim dFechaCrea, dFechaCgo As DateTime
        Dim cTit, cNom, cApe, cTipoCuota, cCuenta As String
        Dim bFijar, bDev, bBloq As Boolean

        Me.ProgressBar1.Visible = True
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Maximum = dt.Rows.Count
        Me.ProgressBar1.Minimum = 0

        For i = 0 To dt.Rows.Count - 1
            nId = dt.Rows(i)("Id")
            nCod = dt.Rows(i)("FALLERO_CODIGO")
            nPago = dt.Rows(i)("PAGO")
            nNumCuotas = dt.Rows(i)("NumCuotas")
            nBenef = dt.Rows(i)("BENEFICIOS")
            nDevBenef = dt.Rows(i)("DEV_BENEFI")
            nOtrosCgos = dt.Rows(i)("OtrosCargos")
            nEntAcuenta = dt.Rows(i)("EntregasAcuenta")
            nResto = dt.Rows(i)("RestoBeneficio")
            nNumPagos = dt.Rows(i)("NumPagos")
            nRecdev = dt.Rows(i)("Recdev")
            nValdev = dt.Rows(i)("valordev")
            nTotCuota = dt.Rows(i)("totalCuota")
            ntotCgo = dt.Rows(i)("totalCargo")
            nAbonobenef = dt.Rows(i)("abonobenefi")
            nSumCgo = dt.Rows(i)("SumaCargos")
            nTotRecibo = dt.Rows(i)("totalrecibo")
            dFechaCgo = Convert.ToDateTime(dt.Rows(i)("FechaCargo".ToString))
            dFechaCrea = Convert.ToDateTime(dt.Rows(i)("FechaCreacion".ToString))
            cTit = dt.Rows(i)("TITULAR".ToString)
            cNom = dt.Rows(i)("NOMBRE".ToString)
            cApe = dt.Rows(i)("APELLIDOS".ToString)
            cTipoCuota = dt.Rows(i)("TIPO_CUOTA".ToString)
            cCuenta = dt.Rows(i)("CUENTA")
            Try
                Me.RemesasTableAdapter.InsertRow(nId, dFechaCrea, dFechaCgo, bFijar, cTit, nCod, cNom, cApe, cTipoCuota,
                nPago, nNumCuotas, nBenef, nDevBenef, nTotCuotaAnual, nOtrosCgos, nEntAcuenta, cCuenta, nResto, nNumPagos,
                nRecdev, nValdev, nTotCuota, ntotCgo, nAbonobenef, nSumCgo, nTotRecibo, bDev, bBloq)
            Catch ex As Exception
                MsgBox("Error al insertar fila " & i)
            End Try
            Me.ProgressBar1.Value += 1
        Next i

        Try
            'Me.Detalles_de_remesaTableAdapter.InsertIntoRemesas()
            Me.EstadoTableAdapter.UpdateEnviarRemesa(True)
            Me.EnviarRemesaCheckBox.Checked = True
            Me.TxtEnviar.Text = "ENVIADA"
            Me.BtnEnviar.Enabled = False
            Me.BtnDeshacer.Enabled = False
            MsgBox("Fin del Proceso." & vbCrLf & "Puedes encontrar el fichero para enviar en " & ruta)
            Me.EstadoTableAdapter.UpdateGenerarRemesa(False)
            Me.EstadoTableAdapter.UpdateConsolidar(False)
            Me.EstadoTableAdapter.UpdateEnviarRemesa(False)
        Catch ex As Exception
            MsgBox("Error en la creación del fichero para enviar al banco")
            Me.EstadoTableAdapter.UpdateEnviarRemesa(False)
        End Try

        Me.ProgressBar1.Visible = False

    End Sub

    Private Sub BtnInforme_Click(sender As Object, e As EventArgs) Handles BtnInforme.Click
        Dim frm As New FrmRemesaGenerada
        frm.Show()
    End Sub

End Class