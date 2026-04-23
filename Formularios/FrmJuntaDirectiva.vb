Public Class FrmJuntaDirectiva
    Private Sub FrmJuntaDirectiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CboComision.Text = "Mayores"
        Me.JuntaDirectivaTableAdapter.FillJuntaDirectiva(Me.DataSetFallero.JuntaDirectiva, 1)
        Me.LblComision.Text = "Mayores"
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CboComision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboComision.SelectedIndexChanged
        Dim nCom As Integer
        nCom = CboComision.SelectedIndex
        If nCom = 0 Then
            Me.JuntaDirectivaTableAdapter.FillJuntaDirectiva(Me.DataSetFallero.JuntaDirectiva, 1)
            Me.LblComision.Text = "Mayores"
        Else
            Me.JuntaDirectivaTableAdapter.FillJuntaDirectiva(Me.DataSetFallero.JuntaDirectiva, 2)
            Me.LblComision.Text = "Infantiles"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmDirectiva.Show()

    End Sub

End Class