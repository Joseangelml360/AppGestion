Imports System.ComponentModel

Public Class FrmCambiarCuotas
    Public nReg As Integer

    Private Sub FrmCambiarCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True

        AddHandler BackgroundWorker1.DoWork, AddressOf BackgroundWorker1_DoWork
        AddHandler BackgroundWorker1.ProgressChanged, AddressOf BackgroundWorker1_ProgressChanged
        AddHandler BackgroundWorker1.RunWorkerCompleted, AddressOf BackgroundWorker1_RunWorkerCompleted

        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.Fill(Me.DataSetCuotas.fallero)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSet1.ejercicio)

        Me.TxtNumCuotasActual.Text = FalleroTableAdapter.ScalarNumCuotasAnterior

        Me.AsignarValoresFalleroCheckBox.Enabled = False
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.AsignarValoresFalleroCheckBox.Checked = True Then
            Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
            MsgBox("Los valores nuevos de cuota ya han sido sido asignados")
            Me.BtnActualizar.Enabled = False
        End If
        Me.ProgressBar1.Visible = False
        Me.TxtNumRegistros.Visible = False
        Me.Label2.Text = ""

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)
        'Throw New NotImplementedException()
        Dim nCod, nNumCuotas, nNumPagos, nPagosRealizados, nRec, r As Integer
        Dim nValCuota, nDto, nPago, nTotCuota, nCargos, nAbonos, nNewDeuda, nPagado, nAcuenta, nBenef, nDevBenef As Double
        Dim cTipoCuota As String

        r = FalleroDataGridView.Rows.Count
        nReg = 0
        If r > 0 Then
            For Each fila As DataGridViewRow In FalleroDataGridView.Rows

                If BackgroundWorker1.CancellationPending Then  'Comprobar si se ha pulsado el botón Cancelar
                    e.Cancel = True
                    Exit For
                End If

                If Not fila Is Nothing Then
                    ' Cargar datos de lo abonado antes del cambio
                    nPagosRealizados = fila.Cells("CP").Value 'Campo CP: Cuotas Pendientes
                    nCod = fila.Cells("CODIGO").Value  'Campo FALLERO_CODIGO
                    nPagado = fila.Cells("PAGO").Value * nPagosRealizados 'Campo PAGO, se calcula lo pagado sobre el valor de cuota anterior al cambio
                    'Calcular cuánto se debería haber pagado y la diferencia pasarla a Otros cargos
                    nValCuota = fila.Cells("CUOTA").Value   ' Nueva cuota, campo CUOTA
                    nDto = fila.Cells("ValorDto").Value     ' Descuento nuevo, campo ValorDto
                    nPago = Math.Round(nValCuota * (1 - nDto / 100), 2)    ' nuevo valor de PAGO
                    nCargos = fila.Cells("OtrosCargos").Value + nPago * nPagosRealizados - nPagado 'Campo otrosCargos. Se suma a otros cargos el diferencial
                    nBenef = fila.Cells("BENEFICIOS").Value 'Campo BENEFICIOS
                    nDevBenef = fila.Cells("DEV_BENEFI").Value - 'Campo DEV_BENEFI
                    nAcuenta = fila.Cells("A_CUENTA").Value  ' campo A_CUENTA
                    nRec = fila.Cells("REC_DEV").Value   'campo RECDEV
                    cTipoCuota = fila.Cells("TIPO_CUOTA").Value ' Tipo de cuota
                    If cTipoCuota = "ANUAL" Then
                        nNumCuotas = 1
                    Else
                        nNumCuotas = Val(NumcuotasmesTextBox.Text)
                    End If
                    nNumPagos = nNumCuotas - nPagosRealizados
                    nAbonos = nBenef + nAcuenta - nDevBenef
                    nTotCuota = nPago * nNumCuotas
                    nNewDeuda = nTotCuota + nCargos - nAbonos - nPagado


                    Try
                        FalleroTableAdapter.UpdateNewCuotas(nValCuota, nNumCuotas, nDto, nTotCuota, nNewDeuda, nPago, nCargos, nAcuenta, nCod)
                        FalleroTableAdapter.UpdateNumPagosPdtes(nNumPagos, nCod)
                    Catch ex As Exception
                        MsgBox("Error en la actualización de Cuotas")
                    End Try
                Else
                    MsgBox("Error al aplicar valores de cuotas. El proceso no se ha realizado")
                End If
                nReg += 1
                BackgroundWorker1.ReportProgress(nReg, $"Actualizando registro {nReg} de {r}")

                'If nCod > 20 Then
                '    Exit For
                'End If
            Next

        End If

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        'Throw New NotImplementedException()
        Me.ProgressBar1.Value += 1
        Me.Label2.Text = CType(e.UserState, String)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        'Throw New NotImplementedException()
        Me.FalleroTableAdapter.Fill(DataSetCuotas.fallero)
        Me.FalleroDataGridView.Refresh()

        If e.Cancelled Then
            Me.Label2.Text = "Actualización cancelada"
            Me.Label2.ForeColor = Color.Red
        ElseIf e.Error IsNot Nothing Then
            Me.Label2.Text = "Error durante la actualización"
            Me.Label2.ForeColor = Color.Red
        Else
            MsgBox("Registros actualizados", 64, "COMPLETADO")
            Me.AsignarValoresFalleroCheckBox.Checked = True
            Me.BtnActualizar.Enabled = False
            Me.BtnSalir.Text = "Salir"
            Me.BtnSalir.Image = My.Resources.door_out
            Me.TxtNumRegistros.Text = "total registros= " + CType(nReg, String)
            Me.Label2.Visible = True
            Me.Label2.Text = "Actualización completada"

        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim nAnoCen As Integer


        '1. Actualizar campo NUM_CUOTAS, según TIPOCUOTA, con el valor de la tabla EJERCICIO
        '2. Actualizar NUM_PAGOS a cero
        '3. Recorrer el Datgridview y para cada registro de código de fallero:
        '       Asignar a las variables el valor de: CUOTA, ValorDto, NUM_CUOTAS
        '       Calcular: PAGO, TOTAL_CUOTA (DEUDA=TOTAL_CUOTA)
        '       Actualizar FALLERO con su TableAdapter.UpdateCuotas(,,,,,,,,)

        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Enabled = False
        Me.TxtNumCuotasActual.Text = FalleroTableAdapter.ScalarNumCuotasAnterior
        Me.ProgressBar1.Maximum = FalleroDataGridView.Rows.Count
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Visible = True
        Me.TxtNumRegistros.Visible = True
        nAnoCen = Val(Me.AñoejeTextBox.Text)

        If Not BackgroundWorker1.IsBusy Then ' Llamar al evento DoWork
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

End Class