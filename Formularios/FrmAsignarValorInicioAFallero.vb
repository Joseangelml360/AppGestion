Imports System.ComponentModel

Public Class FrmAsignarValorInicioAFallero
    Public nReg As Integer
    Private Sub FrmAsignarValorInicioAFallero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True

        AddHandler BackgroundWorker1.DoWork, AddressOf BackgroundWorker1_DoWork
        AddHandler BackgroundWorker1.ProgressChanged, AddressOf BackgroundWorker1_ProgressChanged
        AddHandler BackgroundWorker1.RunWorkerCompleted, AddressOf BackgroundWorker1_RunWorkerCompleted

        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.EjercicioTableAdapter.Fill(Me.DataSetCuotas.ejercicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.fallero' Puede moverla o quitarla según sea necesario.
        Me.FalleroTableAdapter.Fill(Me.DataSetCuotas.fallero)
        Me.AsignarValoresFalleroCheckBox.Enabled = False
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.AsignarValoresFalleroCheckBox.Checked = True Then
            Me.AsignarValoresFalleroCheckBox.Text = "Asignado"
            MsgBox("Los valores nuevos de cuota ya han sido sido asignados")
            'Me.Button1.Enabled = False
        End If
        Me.ProgressBar1.Visible = False
        Me.TxtNumRegistros.Visible = False
        Me.Label2.Text = ""

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim nNumCuotas, nAnoCen As Integer


        '1. Actualizar campo NUM_CUOTAS, según TIPOCUOTA, con el valor de la tabla EJERCICIO
        '2. Actualizar NUM_PAGOS a cero
        '3. En el evento DoWork: Recorrer el Datgridview y para cada registro de código de fallero:
        '       Asignar a las variables el valor de: CUOTA, ValorDto, NUM_CUOTAS
        '       Calcular: PAGO, TOTAL_CUOTA (DEUDA=TOTAL_CUOTA)
        '       Actualizar FALLERO con su TableAdapter.UpdateCuotas(,,,,,,,,)
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Enabled = False
        Me.TxtNumRegistros.Visible = True

        nNumCuotas = Val(Me.NumcuotasmesTextBox.Text)
        nAnoCen = Val(Me.AñoejeTextBox.Text)
        Me.ProgressBar1.Maximum = FALLERODataGridView.Rows.Count
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Visible = True


        Try
            FalleroTableAdapter.UpdateNumPagos()  'Pagos a cero
            FalleroTableAdapter.UpdateNumCuotas(nNumCuotas, nNumCuotas, "MENSUAL") 'Num_Cuotas/NumPagos
            FalleroTableAdapter.UpdateNumCuotas(1, 1, "ANUAL")
            FalleroTableAdapter.UpdateAnoCen(nAnoCen)

        Catch ex As Exception
            MsgBox("Error actualización: NUM_CUOTAS/NUM_PAGOS")
        End Try

        Me.FalleroTableAdapter.Fill(DataSetCuotas.fallero)
        Me.FALLERODataGridView.Refresh()

        If Not BackgroundWorker1.IsBusy Then ' Llamar al evento DoWork
            BackgroundWorker1.RunWorkerAsync()
        End If



    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)
        'Throw New NotImplementedException()

        Dim nCod, nNumCuotas, nNumPagos, nRec, r As Integer
        Dim nValCuota, nDto, nPago, nTotCuota, nCargos, nAbonos, nDeuda, nAcuenta, nBenef As Double

        nReg = 0
        r = FALLERODataGridView.Rows.Count
        If r > 0 Then


            For Each fila As DataGridViewRow In FALLERODataGridView.Rows
                If BackgroundWorker1.CancellationPending Then  'Comprobar si se ha pulsado el botón Cancelar
                    e.Cancel = True
                    Exit For
                End If
                If Not fila Is Nothing Then

                    nCod = fila.Cells("FALLERO_CODIGO").Value
                    nValCuota = fila.Cells("CUOTA").Value
                    nDto = fila.Cells("ValorDto").Value
                    nNumCuotas = fila.Cells("NUM_CUOTAS").Value
                    nNumPagos = fila.Cells("NUM_PAGOS").Value
                    nBenef = fila.Cells("BENEFICIOS").Value - fila.Cells("DEV_BENEFI").Value
                    nCargos = fila.Cells("OtrosCargos").Value + fila.Cells("DEUDA").Value
                    nAcuenta = fila.Cells("A_CUENTA").Value
                    nRec = fila.Cells("RECDEV").Value
                    nAbonos = nBenef + nAcuenta
                    If nNumPagos > 0 Then
                        nCargos = fila.Cells("DEUDA").Value
                        nAbonos = 0
                    End If
                    nPago = Math.Round(nValCuota * (1 - nDto / 100), 2)
                    nTotCuota = nPago * nNumCuotas
                    nDeuda = nTotCuota + nCargos - nAbonos
                    nAcuenta = nAbonos
                    If nCargos < 0 Then
                        nAcuenta = -nCargos
                        nCargos = 0
                    End If

                    Try
                        FalleroTableAdapter.UpdateCuotas(nValCuota, nNumCuotas, nDto, nTotCuota, nDeuda, nPago, nCargos, nAcuenta, nCod)
                    Catch ex As Exception
                        MsgBox("Error en la actualización de Cuotas")
                    End Try
                Else
                    MsgBox("Error al aplicar valores de cuotas. El proceso no se ha realizado")
                End If
                nReg += 1
                BackgroundWorker1.ReportProgress(nReg, $"Actualizando registro {nReg} de {r}")

            Next
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        ' Throw New NotImplementedException()


        Me.FalleroTableAdapter.Fill(DataSetCuotas.fallero)
        Me.FALLERODataGridView.Refresh()

        Try
            EstadoTableAdapter.UpdateEstadoValoresFallero()
            EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Catch ex As Exception
            MsgBox("No se actualizado estado de cambio")
        End Try

        MsgBox("Registros actualizados", 64, "COMPLETADO")

        If e.Cancelled Then
            Me.Label2.Text = "Actualización cancelada"
            Me.Label2.ForeColor = Color.Red
        ElseIf e.Error IsNot Nothing Then
            Me.Label2.Text = "Error durante la actualización"
            Me.Label2.ForeColor = Color.Red
        Else

            Me.AsignarValoresFalleroCheckBox.Checked = True
            Me.BtnActualizar.Enabled = False
            Me.BtnSalir.Text = "Salir"
            Me.BtnSalir.Image = My.Resources.door_out
            Me.TxtNumRegistros.Text = "total registros= " + CType(nReg, String)
            Me.Label2.Visible = True
            Me.Label2.Text = "Actualización completada"

        End If

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        'Throw New NotImplementedException()
        Me.ProgressBar1.Value += 1
        Me.Label2.Text = CType(e.UserState, String)
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
End Class