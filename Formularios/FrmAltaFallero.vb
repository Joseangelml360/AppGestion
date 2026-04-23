Public Class FrmAltaFallero
    Dim nCod, nEje, nCP, nAnocen, nTipFal, nUltCar, nCodRec, nAnoRec, nFalrec, nFalCen, nRecFal As Double
    Dim nIdCuota, nValcuota, nIdDto, nDto, nPago, nNumPagos, nNumPagosMes, nNumCuotas, nTotalCuotas, nDeuda, nTefono As Double
    Dim sApe, sNombre, sDNI, sSexo, sDirecc, sPoblac, sObserv, sTitular As String
    Dim sCuenta, sDescCuota, stipoCuota, sDescrDto, sEmail As String
    Dim bBaja, bLot, bBanco As Boolean
    Dim dFecha As Date


    Private Sub FrmAltaFallero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.DbCensos.cargo)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.comision' Puede moverla o quitarla según sea necesario.
        Me.ComisionTableAdapter.Fill(Me.DbCensos.comision)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.descuentos_de_la_cuota' Puede moverla o quitarla según sea necesario.
        Me.Descuentos_de_la_cuotaTableAdapter.Fill(Me.DbCensos.descuentos_de_la_cuota)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.tipo_de_cuotas' Puede moverla o quitarla según sea necesario.
        Me.Tipo_de_cuotasTableAdapter.Fill(Me.DbCensos.tipo_de_cuotas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallas' Puede moverla o quitarla según sea necesario.
        Me.FallasTableAdapter.Fill(Me.DbCensos.fallas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.recompensas' Puede moverla o quitarla según sea necesario.
        Me.RecompensasTableAdapter.Fill(Me.DbCensos.recompensas)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DbCensos.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.FillByUltimo(Me.DbCensos.fallero)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.CboCargo.Text = Nothing
        Me.CboComision.Text = Nothing
        Me.CboRecompensa.Text = Nothing
        Me.CboDescCuota.Text = Nothing
        Me.CboFalla.Text = Nothing
        Me.CboDescrDto.Text = Nothing
        Me.CboDescCuota.Text = Nothing
        Me.CboSexo.Text = Nothing
        Me.ChkBanco.Checked = False
        Me.ChkLoteria.Checked = False
        nCod = Val(Me.TxtCodigo.Text) + 1
        Me.TxtCodigo.Text = nCod
        nEje = Val(Me.TxtAñoCenso.Text)
        nAnocen = nEje
        nTipFal = 2
        'nNumPagosMes = Val(Me.txtnCuotas.Text)

    End Sub

    Private Sub CboSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSexo.SelectedIndexChanged
        If Me.CboSexo.SelectedItem = "Hombre" Then
            sSexo = "H"
        Else
            sSexo = "M"
        End If
    End Sub

    Private Sub CboRecompensa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboRecompensa.SelectedIndexChanged
        nCodRec = Me.CboRecompensa.SelectedValue
        Me.TxtRecJCF.Text = nCodRec

    End Sub

    Private Sub CboFalla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFalla.SelectedIndexChanged
        nFalrec = Me.CboFalla.SelectedValue
        Me.TxtFallaRecJCF.Text = nFalrec
    End Sub

    Private Sub CboDescCuota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDescCuota.SelectedIndexChanged

        nNumPagosMes = Val(Me.TxtNumcuotasMensuales.Text)
        sDescCuota = Me.CboDescCuota.Text
        If sDescCuota = Nothing Then
            nIdCuota = 0
        Else
            nIdCuota = Me.Tipo_de_cuotasTableAdapter.ScalarQuery(sDescCuota)
        End If

        nValcuota = Me.CboDescCuota.SelectedValue
        Me.TxtIdCuota.Text = nIdCuota
        Me.TxtValCuota.Text = nValcuota

        Select Case nIdCuota
            Case 1, 2, 4, 5, 7 To 14, 21
                Me.ChkLoteria.Checked = False
                bLot = False
                stipoCuota = "ANUAL"
                Me.TxtTipoCuota.Text = stipoCuota
                nNumPagos = 1
                nNumCuotas = nNumPagos
                Me.TxtNumCuotas.Text = nNumCuotas
                Me.TxtNumPagos.Text = nNumPagos
                bLot = False


            Case 3, 6, 15 To 18
                Me.ChkLoteria.Checked = False
                bLot = False
                stipoCuota = "MENSUAL"
                Me.TxtTipoCuota.Text = stipoCuota
                nNumPagos = nNumPagosMes
                nNumCuotas = nNumPagosMes
                Me.TxtNumCuotas.Text = nNumPagosMes
                Me.TxtNumPagos.Text = nNumPagosMes

                bLot = False

            Case 19, 20
                Me.ChkLoteria.Checked = True
                bLot = True
                stipoCuota = "MENSUAL"
                Me.TxtTipoCuota.Text = stipoCuota
                'nNumPagos = Val(Me.txtnCuotas.Text)
                'nNumCuotas = nNumPagos
                Me.TxtNumCuotas.Text = nNumPagosMes
                Me.TxtNumPagos.Text = nNumPagosMes
        End Select

        If Me.CboDescrDto.Text = Nothing Then
            sDescrDto = " "
            nDto = 0
            nIdDto = 1
        Else
            sDescrDto = CboDescrDto.Text
            nIdDto = CboDescrDto.SelectedIndex + 1
            nDto = Me.CboDescrDto.SelectedValue
        End If
        nPago = nValcuota * (1 - nDto / 100)
        Me.TxtPago.Text = nPago
        nDeuda = nPago * nNumPagos
        Me.TxtDeuda.Text = nDeuda
        nTotalCuotas = nPago * nNumPagos
        Me.TxtTotalCuota.Text = nTotalCuotas


    End Sub

    Private Sub CboDescrDto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDescrDto.SelectedIndexChanged
        sDescrDto = Me.CboDescrDto.Text
        nIdDto = Me.CboDescrDto.SelectedIndex + 1
        nDto = Me.CboDescrDto.SelectedValue
        Me.TxtIdDto.Text = Me.CboDescrDto.SelectedIndex + 1
        Me.TxtDescuento.Text = Me.CboDescrDto.SelectedValue

        nPago = nValcuota * (1 - nDto / 100)
        Me.TxtPago.Text = nPago
        nDeuda = nPago * nNumPagos
        Me.TxtDeuda.Text = nDeuda
        nTotalCuotas = nPago * nNumPagos
        Me.TxtTotalCuota.Text = nTotalCuotas

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (CboComision.Text = "Mayores" And TxtDNI.Text = Nothing) Then
            MsgBox("Es necesario un DNI para la comisión Mayores")
            Exit Sub
        End If
        If (TxtNombre.Text) = Nothing Or TxtApellidos.Text = Nothing Or TxtDireccion.Text = Nothing Or TxtPoblacion.Text = Nothing Then
            MsgBox("Los campos con '*' no pueden estar vacíos")
            Exit Sub
        End If
        If CboSexo.Text = Nothing Or CboComision.Text = Nothing Or CboCargo.Text = Nothing Or CboDescCuota.Text = Nothing Or CboDescrDto.Text = Nothing Then
            MsgBox("Campos desplegables con '*' no pueden estar vacíos, pulse en la flecha y seleccione un valor")
            Exit Sub
        End If
        If DateTimePicker1.Value = Nothing Then
            MsgBox("Introduce la fecha de nacimiento")
            Exit Sub
        End If

        'variables asignadas: nAnocen, nCod, nEje, sSexo, nTipFal, nUltCar, nCodRec, bLot, nIdCuota
        'variables asignadas: sDescCuota, nValCuota, sTipoCuota, nIdDto, sDescrDto, nDto, nPago, nNumPagos
        'variables asignadas: nDeuda, nTotalCuotas, nNumCuotas

        'Asignar valores a variables restantes 
        nAnocen = Val(Me.TxtAñoCenso.Text)
        sNombre = Me.TxtNombre.Text
        sApe = Me.TxtApellidos.Text
        sDNI = Me.TxtDNI.Text
        dFecha = Me.DateTimePicker1.Value
        sDirecc = Me.TxtDireccion.Text
        sPoblac = Me.TxtPoblacion.Text
        If IsNumeric(Me.TxtCP.Text) = True Then
            nCP = Me.TxtCP.Text
        Else
            MsgBox("El Código Postal no puede contener caracteres alfabéticos")
            Exit Sub
        End If
        If IsNumeric(Me.TxtTelefono.Text) = True Then
            nTefono = Me.TxtTelefono.Text
        Else
            MsgBox("El Teléfono no puede contener caracteres alfabéticos")
            Exit Sub
        End If

        bBaja = False

        If Me.CboRecompensa.Text = Nothing Then
            nCodRec = 0
        Else
            nCodRec = Val(Me.TxtRecJCF.Text)
        End If
        If Me.CboFalla.Text = Nothing Then
            nFalrec = 0
        Else
            nFalrec = Me.TxtFallaRecJCF.Text
        End If
        If Me.TxtAñoRecJCF.Text = Nothing Then
            nAnoRec = 0
        Else
            nAnoRec = Val(Me.TxtAñoRecJCF.Text)
        End If
        nFalCen = 193
        nRecFal = 0
        If Me.TxtObservaciones.Text = Nothing Then
            sObserv = ""
        Else
            sObserv = Me.TxtObservaciones.Text
        End If
        If Me.ChkBanco.Checked = False Then
            bBanco = False
        Else
            bBanco = True
        End If
        If Me.TxtTitular.Text = Nothing Then
            If ChkBanco.Checked = True Then
                MsgBox("Con el check en 'Banco' introduce Titular y la Cuenta Bancaria")
                Exit Sub
            End If
            sTitular = ""
        Else
            sTitular = Me.TxtTitular.Text
        End If

        Dim sCta As String = Me.TxtCuenta.Text.Replace(" ", "")
        Dim n As Integer
        Dim result As Boolean

        n = Len(sCta)

        If Me.TxtCuenta.Text = Nothing Or n = 2 Then
            If ChkBanco.Checked = True Then
                MsgBox("Con el check en 'Banco' introduce Titular y la Cuenta Bancaria")
                Exit Sub
            End If
            sCuenta = ""
        Else
            'quitar espacios en blanco del numero de cuenta
            'sCuenta = Me.TxtCuenta.Text.Replace(" ", "")
            'Me.TxtCuenta.Text = sCuenta

            ' Llamar a la función que valida el IBAN

            If n < 12 Then
                MsgBox("La longitud de la cuenta no es correcta. Introduce un valor correcto.")
                Me.TxtCuenta.Focus()
                Exit Sub
            End If

            result = funciones.ValidarIBAN(sCta)
            sCuenta = Me.TxtCuenta.Text.Replace(" ", "")

            If result = "False" Then
                MsgBox("El IBAN No es válido." & vbCrLf & "La cuenta no es correcta.")
                Me.TxtCuenta.Focus()
                Exit Sub
            End If
        End If

        If Me.TxtEmail.Text = Nothing Then
            sEmail = ""
        Else
            sEmail = Me.TxtEmail.Text
        End If

        If Me.DateTimePicker1.Value = Now Then
            MsgBox("La fecha de nacimiento no puede ser la fecha de hoy")
            Exit Sub
        End If
        If TxtValCuota.Text = Nothing Then
            MsgBox("Hay que poner un valor en la cuota")
            Exit Sub
        End If
        If TxtDescuento.Text = Nothing Then
            MsgBox("El descuento debe tener un valor")
        End If

        'Añadir registro nuevo a la tabla Fallero
        Try
            Me.FalleroTableAdapter.InsertQueryfallero(nCod, sApe, sNombre, sDNI, sSexo, dFecha, sDirecc, sPoblac, nCP,
                                                      nTefono, nAnocen, nTipFal, bBaja, nUltCar, nCodRec, nAnoRec, nFalrec,
                                                      nFalCen, nRecFal, sObserv, bBanco, sTitular, sCta, bLot,
                                                      nIdCuota, sDescCuota, nValcuota, stipoCuota, nIdDto, sDescrDto, nDto,
                                                      nPago, nNumPagos, nDeuda, nTotalCuotas, nNumCuotas, sEmail)
            Me.Validate()
            'Me.FALLEROBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.DbCensosDataSet)
            'Me.DbCensosDataSet.AcceptChanges()
            MsgBox("Añadido registro a la tabla 'Fallero'")
            Me.Button2.Enabled = False
            Me.Button1.Text = "Salir"
        Catch ex As Exception
            MsgBox("Error, no se pudo añadir registro nuevo")
        End Try



    End Sub

    Private Sub CboComision_Leave(sender As Object, e As EventArgs) Handles CboComision.Leave

        Dim dtFechaJuv, dtFechaMay, dtfechaNac As Date

        nTipFal = CboComision.SelectedValue
        dtFechaJuv = PasejuvenilTextBox.Text
        dtFechaMay = PasemayorTextBox.Text
        dtfechaNac = DateTimePicker1.Value

        If nTipFal < 1 Or nTipFal > 3 Then
            MsgBox("El código de comisión debe ser de 1 a 3")
            Exit Sub
        End If
        If nTipFal = 1 And dtfechaNac > dtFechaJuv Then
            MsgBox("Según la fecha de nacimiento debe ser infantil = código 2")
            Exit Sub
        End If

        If nTipFal = 1 And dtfechaNac > dtFechaMay Then
            MsgBox("Según la fecha de nacimiento debe ser juvenil = código 3")
            Exit Sub
        End If

        If nTipFal = 2 And dtfechaNac < dtFechaJuv Then
            MsgBox("Según la fecha de nacimiento no es infantil")
            Exit Sub
        End If

        If nTipFal = 3 And dtfechaNac < dtFechaMay Then
            MsgBox("Según la fecha de nacimiento debe ser mayor = código 1")
            Exit Sub
        End If

        If nTipFal = 3 And dtfechaNac > dtFechaJuv Then
            MsgBox("según la fecha de nacimiento es infantil = código 2")
            Exit Sub
        End If

        If nTipFal = 1 Then
            CboDescCuota.DataSource = Tipo_de_cuotasTableAdapter.GetDataBy2()
        ElseIf nTipFal = 2 Then
            CboDescCuota.DataSource = Tipo_de_cuotasTableAdapter.GetDataBy3()
        ElseIf nTipFal = 3 Then
            CboDescCuota.DataSource = Tipo_de_cuotasTableAdapter.GetDataBy4()
        Else
            CboDescCuota.DataSource = Tipo_de_cuotasTableAdapter.GetData()
        End If



    End Sub

    Private Sub CboCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCargo.SelectedIndexChanged
        nUltCar = CboCargo.SelectedValue
        'MsgBox(nUltCar)
    End Sub

    Private Sub TxtDNI_MouseHover(sender As Object, e As EventArgs) Handles TxtDNI.MouseHover
        ToolTip1.ToolTipTitle = "DNI"
        ToolTip1.SetToolTip(TxtDNI, "Introduce el nº de documento de identidad," & vbCrLf & "Obligatorio para mayores de 14 años")
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip1.SetToolTip(Button2, "Pulsa el botón para añadir a la base de datos")
        ToolTip1.ToolTipTitle = "Añadir registro"
    End Sub
End Class