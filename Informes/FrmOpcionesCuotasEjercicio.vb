Public Class FrmOpcionesCuotasEjercicio
    Private Sub FrmOpcionesCuotasEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuotas.ejercicio' Puede moverla o quitarla según sea necesario.
        Me.ejercicioTableAdapter.Fill(Me.DataSetCuotas.ejercicio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class