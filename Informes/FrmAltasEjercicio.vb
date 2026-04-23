Public Class FrmAltasEjercicio
    Private Sub FrmAltasEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet1.Altas_ejercicio' Puede moverla o quitarla según sea necesario.
        Me.Altas_ejercicioTableAdapter.Fill(Me.dbcensosDataSet1.Altas_ejercicio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class