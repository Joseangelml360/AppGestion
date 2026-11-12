Imports MySql.Data.MySqlClient

Public Class FrmDeshacerRemesa
    Private Sub FrmDeshacerRemesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.detalles_de_remesa' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_remesaTableAdapter.Fill(Me.DataSet1.detalles_de_remesa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Fallero1' Puede moverla o quitarla según sea necesario.
        Me.Fallero1TableAdapter.Fill(Me.DataSet1.Fallero1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.ConsolidarRemesaCheckBox.Checked = True Then
            Me.Label1.Text = "Consolidada"
        Else
            Me.Label1.Text = " Sin consolidar"
        End If
        Me.ConsolidarRemesaCheckBox.Enabled = False
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Dim nCod, nRecDev, nOtrosCargos, nAcuenta, nPagos, nAbonoBenefi, nDeuda As Double
        Dim nFalleRecDev, nFalleOtroscargos, nFalleAcuenta, nFallePago, nFalleNumPagos, nFalleDevBenefi, nFalleBenefi As Double
        Dim Dgv As DataGridView = Me.Detalles_de_remesaDataGridView

        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = Dgv.Rows.Count
        Me.ProgressBar1.Value = 0

        ' 1. Iniciamos el control de la conexión y la transacción manual
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)

            Dim transaccion As MySqlTransaction = Nothing

            Try
                ' Abrimos la conexión al servidor de Aiven y arrancamos la transacción
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' Asignamos el canal único de la transacción a tus TableAdapters
                Me.Fallero1TableAdapter.Connection = conexion
                Me.EstadoTableAdapter.Connection = conexion

                For Each row As DataGridViewRow In Dgv.Rows
                    ' Omitimos la fila de inserción vacía si existiera en el grid
                    If row.IsNewRow Then Continue For

                    Me.ProgressBar1.Value += 1
                    nCod = row.Cells(0).Value
                    nPagos = row.Cells(1).Value
                    nOtrosCargos = row.Cells(2).Value
                    nAcuenta = row.Cells(3).Value
                    nRecDev = row.Cells(4).Value
                    nAbonoBenefi = row.Cells(5).Value

                    ' Cargamos el estado actual del fallero desde la base de datos
                    Me.Fallero1TableAdapter.FillRemesaByCodigo(Me.DataSet1.Fallero1, nCod)

                    ' LEER DIRECTAMENTE DESDE LA MEMORIA DEL DATASET:
                    ' Es muchísimo más seguro y veloz que el refresco visual de la cuadrícula
                    If Me.DataSet1.Fallero1.Rows.Count > 0 Then
                        Dim filaFallero As DataRow = Me.DataSet1.Fallero1.Rows(0)

                        ' NOTA: Recuerda mantener los nombres exactos de tus columnas entre comillas
                        nFalleBenefi = Val(filaFallero("BENEFICIOS"))
                        nFalleDevBenefi = Val(filaFallero("DEV_BENEFI")) - nAbonoBenefi ' Operación inversa
                        nFalleRecDev = Val(filaFallero("RECDEV")) + nRecDev             ' Operación inversa
                        nFalleOtroscargos = Val(filaFallero("OtrosCargos")) + nOtrosCargos ' Operación inversa
                        nFalleAcuenta = Val(filaFallero("EntregasAcuenta")) + nAcuenta         ' Operación inversa
                        nFallePago = Val(filaFallero("PAGO"))
                        nFalleNumPagos = Val(filaFallero("NUM_PAGOS")) + nPagos         ' Operación inversa

                        nDeuda = nFallePago * nFalleNumPagos + nFalleOtroscargos - (nFalleBenefi - nFalleDevBenefi) - nFalleAcuenta

                        ' Registramos la actualización en el servidor (en modo borrador seguro)
                        Fallero1TableAdapter.UpdateRemesa(nFalleDevBenefi, nFalleRecDev, nFalleOtroscargos, nFalleAcuenta,
                                                       nFalleNumPagos, nDeuda, nCod)
                    End If
                Next

                ' Actualizamos el estado general de la remesa a falso (Sin Consolidar)
                Me.EstadoTableAdapter.UpdateConsolidar(False)

                ' 🔥 ¡ÉXITO TOTAL!: Si todo el bucle termina bien, guardamos los cambios de golpe en el disco
                transaccion.Commit()

                ' Cambios visuales definitivos en la pantalla tras la confirmación de la base de datos
                MsgBox("Remesa revertida con éxito de forma segura.", MsgBoxStyle.Information, "Operación Completada")
                Me.ConsolidarRemesaCheckBox.Checked = False
                Me.Label1.Text = "Sin Consolidar"
                Me.BtnEjecutar.Enabled = False

            Catch ex As Exception
                ' ❌ ¡FALLO EN EL PROCESO!: Si un solo registro da error de red, deshacemos TODO al instante
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                ' Informamos del error manteniendo la base de datos 100% intacta
                MsgBox("Error crítico al revertir la remesa. El proceso se ha cancelado y los datos NO se han modificado." & vbCrLf &
                   "Detalle del error: " & ex.Message, MsgBoxStyle.Critical, "Operación Cancelada")

                Me.ProgressBar1.Value = 0
            Finally
                ' Liberamos la conexión a la nube inmediatamente
                conexion.Close()
            End Try
        End Using

        ' Interfaz final del botón salir
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.Image = My.Resources.door_out
        Me.BtnSalir.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class