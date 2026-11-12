Imports MySql.Data.MySqlClient

Public Class FrmConsolidar
    Private Sub FrmConsolidar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Fallero1' Puede moverla o quitarla según sea necesario.
        Me.Fallero1TableAdapter.Fill(Me.DataSet1.Fallero1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.Detalles_de_remesaTableAdapter.FillByConsolidar(Me.DataSet1.detalles_de_remesa)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.ConsolidarRemesaCheckBox.Checked = True Then
            Me.Label1.Text = "Consolidada"
        Else
            Me.Label1.Text = " Sin consolidar"
        End If
        Me.ConsolidarRemesaCheckBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Dim nCod, nRecDev, nOtrosCargos, nAcuenta, nPagos, nAbonoBenefi, nDeuda As Double
        Dim nFalleRecDev, nFalleOtroscargos, nFalleAcuenta, nFallePago, nFalleNumPagos, nFalleDevBenefi, nFalleBenefi As Double
        Dim Dgv As DataGridView = Me.Detalles_de_remesaDataGridView

        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = Dgv.Rows.Count
        Me.ProgressBar1.Value = 0

        ' 1. Creamos la conexión manual para controlar la transacción
        ' Usamos la cadena de conexión de tu configuración (la que ajustamos para Aiven)
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)

            Dim transaccion As MySqlTransaction = Nothing

            Try
                ' Abrimos la conexión y arrancamos la transacción oficial en el servidor
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' 🔥 CLAVE: Asignamos esta conexión y esta transacción a tus TableAdapters
                ' De esta forma, todo lo que hagan dentro del bucle formará parte del "paquete" controlado
                Me.Fallero1TableAdapter.Connection = conexion
                Me.EstadoTableAdapter.Connection = conexion

                For Each row As DataGridViewRow In Dgv.Rows
                    ' Evitamos procesar la fila vacía del final si el DGV la tiene activa
                    If row.IsNewRow Then Continue For

                    Me.ProgressBar1.Value += 1
                    nCod = row.Cells(0).Value
                    nPagos = row.Cells(1).Value
                    nOtrosCargos = row.Cells(2).Value
                    nAcuenta = row.Cells(3).Value
                    nRecDev = row.Cells(4).Value
                    nAbonoBenefi = row.Cells(5).Value

                    ' Cargamos los datos del fallero. Al estar en la transacción, lee el estado real actual
                    Me.Fallero1TableAdapter.FillRemesaByCodigo(Me.DataSet1.Fallero1, nCod)

                    ' 🔥 MEJORA DE RENDIMIENTO Y SEGURIDAD: 
                    ' En lugar de usar el Dgv1 invisible y el "CurrentRow", leemos directamente la fila del DataSet.
                    ' Es muchísimo más rápido porque no obliga a la pantalla a dibujar nada.
                    If Me.DataSet1.Fallero1.Rows.Count > 0 Then
                        Dim filaFallero As DataRow = Me.DataSet1.Fallero1.Rows(0)

                        nFalleBenefi = Val(filaFallero("BENEFICIOS"))
                        nFalleDevBenefi = Val(filaFallero("DEV_BENEFI")) + nAbonoBenefi
                        nFalleRecDev = Val(filaFallero("RECDEV")) - nRecDev
                        nFalleOtroscargos = Val(filaFallero("OtrosCargos")) - nOtrosCargos
                        nFalleAcuenta = Val(filaFallero("EntregasAcuenta")) - nAcuenta
                        nFallePago = Val(filaFallero("PAGO"))
                        nFalleNumPagos = Val(filaFallero("NUM_PAGOS")) - nPagos

                        nDeuda = nFallePago * nFalleNumPagos + nFalleOtroscargos - (nFalleBenefi - nFalleDevBenefi) - nFalleAcuenta

                        ' Ejecutamos la actualización (viaja al servidor en modo "borrador")
                        Fallero1TableAdapter.UpdateRemesa(nFalleDevBenefi, nFalleRecDev, nFalleOtroscargos, nFalleAcuenta,
                                                       nFalleNumPagos, nDeuda, nCod)
                    End If
                Next

                ' Actualizamos el estado de la consolidación (también entra en el borrador)
                Me.EstadoTableAdapter.UpdateConsolidar(True)

                ' 🔥 ¡ÉXITO TOTAL!: Si el código llega aquí sin fallar, guardamos todo de golpe
                transaccion.Commit()

                ' Modificaciones visuales en la pantalla una vez confirmado el éxito en la BD
                MsgBox("Remesa consolidada con éxito de forma segura.", MsgBoxStyle.Information, "Consolidación")
                Me.ConsolidarRemesaCheckBox.Checked = True
                Me.Label1.Text = "Consolidada"
                Me.BtnEjecutar.Enabled = False

            Catch ex As Exception
                ' ❌ ¡FALLO EN ALGÚN REGISTRO!: Si cualquier línea da error, deshacemos TODO al instante
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                ' Avisamos al usuario. La base de datos se queda intacta, como si nada hubiera pasado
                MsgBox("Error crítico durante la consolidación. El proceso se ha cancelado y los datos NO se han modificado." & vbCrLf &
                   "Detalle del error: " & ex.Message, MsgBoxStyle.Critical, "Remesa NO Consolidada")

                ' Reiniciamos la barra de progreso ya que no se aplicó nada
                Me.ProgressBar1.Value = 0
            Finally
                ' Cerramos la conexión de forma limpia pase lo que pase
                conexion.Close()
            End Try
        End Using

        ' Controles finales de la interfaz
        Me.BtnSalir.Focus()
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.Image = My.Resources.door_out
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class