Public Class FrmExportarRemesas
    Private Sub FrmExportarRemesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ReportsDataSet.RemesasTodas' Puede moverla o quitarla según sea necesario.
        Me.RemesasTodasTableAdapter.FillTodasRemesas(Me.ReportsDataSet.RemesasTodas)
        Me.ReportViewer1.RefreshReport()
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.estado)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        If Me.ExportRemesasCheckBox.Checked = True Then
            Me.Label2.Text = "Exportado"
            ExportRemesasCheckBox.Enabled = False
        Else
            Me.Label2.Text = "Sin exportar"
            ExportRemesasCheckBox.Enabled = True
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bExp, bElim, bCopiar As Boolean

        If ExportRemesasCheckBox.Checked = False Then
            Me.ExportRemesasCheckBox.Checked = True
            Me.Label2.Text = "Exportado"
            Me.ExportRemesasCheckBox.Enabled = False
            bExp = True
            bElim = False
            bCopiar = False
            Try
                Me.EstadoTableAdapter.UpdateEstadoFinalizar(bExp, bElim, bCopiar)
                MsgBox("Proceso de exportación finalizado")
            Catch ex As Exception
                MsgBox("Error. No se realizó la exportación")
            End Try
        Else
            MsgBox("El fichero de remesas ya ha sido exportado, continúa con el siguiente paso")
        End If
    End Sub

End Class