Public Class FrmCensoHistorico
    Private Sub FrmCensoHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.CensoHistorico' Puede moverla o quitarla según sea necesario.
        Dim nUltimo As Integer
        nUltimo = Me.CensoHistoricoTableAdapter.ScalarUltimo()

        Me.CensoHistoricoTableAdapter.FillByAño_Tipfal(Me.DataSet1.CensoHistorico, nUltimo, 1)
        Me.HelpProvider1.HelpNamespace = "Ayuda.chm"

        Me.ReportViewer1.RefreshReport()
        Me.Button1.Enabled = False
        Me.ComboBox1.SelectedIndex = 1
        Me.TextBox1.Text = nUltimo
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Dim nAño, nCom As Integer
        Dim nUltimo As Integer
        nUltimo = Me.CensoHistoricoTableAdapter.ScalarUltimo()
        nAño = Val(Me.TextBox1.Text)

        If (nAño < 1947) Or (nAño > nUltimo) Then
            MsgBox("El año de ejercicio introducido no es válido")
            Exit Sub
        Else
            nAño = Val(Me.TextBox1.Text)
        End If

        If ComboBox1.Text = Nothing Then
            nCom = 1
        ElseIf Me.ComboBox1.Text = "Mayores" Then
            nCom = 1
        ElseIf Me.ComboBox1.Text = "Infantiles" Then
            nCom = 2
        End If
        Me.Button1.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nAño, nCom As Integer
        nAño = Val(Me.TextBox1.Text)
        If ComboBox1.Text = Nothing Then
            nCom = 1
        ElseIf Me.ComboBox1.Text = "Mayores" Then
            nCom = 1
        ElseIf Me.ComboBox1.Text = "Infantiles" Then
            nCom = 2
        End If
        'nCom = CType(Val(Me.ComboBox1.Text, Int16)
        Me.CensoHistoricoTableAdapter.FillByAño_Tipfal(Me.DataSet1.CensoHistorico, nAño, nCom)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

End Class