Imports MySql.Data.MySqlClient

Public Class FrmAplicarDevoluciones
    Private Sub FrmAplicarDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carga inicial de datos desde Aiven
        Me.Fallero1TableAdapter.Fill(Me.DataSet1.Fallero1)
        Me.RemesasTableAdapter.FillRemesas(Me.ReportsDataSet.remesas)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Dim cId, cFecha, cItem As String
        Dim dt As DataTable = ReportsDataSet.remesas

        ' Rellenamos el selector de remesas
        For i As Integer = 0 To dt.Rows.Count - 1
            cId = dt.Rows(i)("IdRemesa").ToString()
            cFecha = dt.Rows(i)("FechaCargo").ToString()
            cItem = cId & "  -  " & cFecha
            CboSelect.Items.Add(cItem)
        Next

        ' Inicialización oculta de controles
        Me.DgvTitular.Visible = False
        Me.DgvDevolucion.Visible = False
        Me.BtnAplicar.Visible = False
        Me.Label2.Visible = False
        Me.TextBox1.Visible = False
    End Sub

    Private Sub CboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSelect.SelectedIndexChanged
        If CboSelect.SelectedIndex = -1 Then Exit Sub

        ' Refrescamos el listado de remesas de forma segura
        Me.RemesasTableAdapter.FillRemesas(ReportsDataSet.remesas)
        Me.DgvTitular.Refresh()
    End Sub

    Private Sub TxtTitular_TextChanged(sender As Object, e As EventArgs) Handles TxtTitular.TextChanged
        If CboSelect.SelectedIndex = -1 Then Exit Sub

        ' 🔥 REPARACIÓN: Extraemos el ID real cortando el texto antes del guion 
        ' Evita descuadres si el índice físico de la lista no coincide con la base de datos
        Dim textoSeleccionado As String = CboSelect.SelectedItem.ToString()
        Dim idRealRemesa As Integer = Val(textoSeleccionado.Split("-"c)(0).Trim())

        Me.RemesasTableAdapter.FillByNumeroRemesa(ReportsDataSet.remesas, idRealRemesa, Me.TxtTitular.Text)
        Me.DgvTitular.Refresh()
        Me.DgvTitular.Visible = True
    End Sub

    Private Sub DgvTitular_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTitular.CellContentClick
        If DgvTitular.CurrentRow Is Nothing Then Exit Sub

        Dim nCod As Double = DgvTitular.CurrentRow.Cells(0).Value
        Dim cTit As String = DgvTitular.CurrentRow.Cells(2).Value.ToString()

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

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        Dim Dgv As DataGridView = Me.DgvDevolucion

        If Dgv.Rows.Count = 0 Then
            MsgBox("No se ha seleccionado ningún recibo para aplicar devolución", MsgBoxStyle.Information, "Atención")
            Exit Sub
        End If

        Dim nId, nCod, nRecDev, nOtrosCargos, nAcuenta, nPagos, nAbonoBenefi, nDeuda As Double
        Dim nFalleRecDev, nFalleOtroscargos, nFalleAcuenta, nFallePago, nFalleNumPagos, nFalleDevBenefi, nFalleBenefi As Double
        Dim r As Integer = 0
        Dim n As Integer = 0
        Dim cTit As String = DgvTitular.CurrentRow.Cells(2).Value.ToString()

        Me.TextBox1.Text = cTit

        ' Control transaccional seguro con la nube de Aiven
        Using conexion As New MySqlConnection(My.Settings.dbcensosConnectionString)
            Dim transaccion As MySqlTransaction = Nothing

            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                Me.Fallero1TableAdapter.Connection = conexion
                Me.Remesas1TableAdapter.Connection = conexion

                For Each row As DataGridViewRow In Dgv.Rows
                    If row.IsNewRow Then Continue For

                    ' Si ya está devuelto, avisamos y saltamos al siguiente sin romper el bucle masivo
                    If row.Cells("devolucion").Value = True Then
                        MsgBox("Fallero " & row.Cells("Cod").Value.ToString() & " ya tiene aplicada la devolución. Se omitirá.", MsgBoxStyle.Information, "Registro Omitido")
                        Continue For
                    End If

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

                    ' Procesamiento en memoria RAM de los saldos del fallero
                    Me.Fallero1TableAdapter.FillRemesaByCodigo(Me.DataSet1.Fallero1, nCod)

                    If Me.DataSet1.Fallero1.Rows.Count > 0 Then
                        Dim filaFallero As DataRow = Me.DataSet1.Fallero1.Rows(0)

                        nFalleDevBenefi = Val(filaFallero("DEV_BENEFI")) - nAbonoBenefi
                        nFalleRecDev = Val(filaFallero("RECDEV")) + nRecDev
                        nFalleOtroscargos = Val(filaFallero("OtrosCargos")) + nOtrosCargos
                        nFalleAcuenta = Val(filaFallero("EntregasAcuenta")) + nAcuenta
                        nFallePago = Val(filaFallero("PAGO"))
                        nFalleNumPagos = Val(filaFallero("NUM_PAGOS")) + nPagos
                        nFalleBenefi = Val(filaFallero("BENEFICIOS"))

                        nDeuda = nFallePago * nFalleNumPagos + nFalleOtroscargos - (nFalleBenefi - nFalleDevBenefi) - nFalleAcuenta

                        ' Guardado preventivo en modo borrador
                        Me.Fallero1TableAdapter.UpdateRemesa(nFalleDevBenefi, nFalleRecDev, nFalleOtroscargos, nFalleAcuenta, nFalleNumPagos, nDeuda, nCod)
                        Me.Remesas1TableAdapter.UpdateBloqueo(True, True, nId, nCod)
                    End If
                Next

                ' 🔥 ¡COMMIT FINAL!: Si el lote completo se procesó bien, guardamos en bloque
                transaccion.Commit()

                If n > 0 Then
                    MsgBox("Aplicada devolución a Titular " & Me.TextBox1.Text & " con éxito de forma segura.", MsgBoxStyle.Information, "Éxito")
                    Me.BtnAplicar.Enabled = False
                Else
                    MsgBox("No se procesó ninguna devolución nueva.", MsgBoxStyle.Exclamation, "Proceso Finalizado")
                End If

            Catch ex As Exception
                ' Si falla la red, el Rollback deja la remesa intacta en Aiven
                If transaccion IsNot Nothing Then
                    transaccion.Rollback()
                End If

                MsgBox("Error crítico: No se pudieron aplicar las devoluciones. Los datos no sufrieron modificaciones." & vbCrLf &
                       "Detalle técnico: " & ex.Message, MsgBoxStyle.Critical, "Operación Cancelada")
            Finally
                conexion.Close()
                ' 2. 🔥 RESTAURAR CONEXION: Le devolvemos a los TableAdapters su conexión limpia por defecto de Visual Studio
                ' Esto evita que se queden apuntando al objeto destruido por el 'Using'
                Me.Fallero1TableAdapter.Connection = New MySqlConnection(My.Settings.dbcensosConnectionString)
                Me.Remesas1TableAdapter.Connection = New MySqlConnection(My.Settings.dbcensosConnectionString)
            End Try
        End Using

        ' Refrescos gráficos fuera de la transacción para optimizar recursos
        If Me.BtnAplicar.Enabled = False Then
            Try
                Me.Remesas1TableAdapter.FillByDevolución(ReportsDataSet.remesas1, nId, cTit)
                Me.DgvDevolucion.Refresh()
            Catch : End Try
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
