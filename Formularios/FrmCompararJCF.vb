Imports System.Data.OleDb
Public Class FrmCompararJCF_Falla
    Private Sub FrmCompararJCF_Falla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSelectFile_Click(sender As Object, e As EventArgs) Handles BtnSelectFile.Click
        Dim cNombre As String
        cNombre = ""
        Me.TxtExcelName.Text = SeleccionarArchivoExcel(cNombre)

    End Sub

    Private Function SeleccionarArchivoExcel(cNombre) As String
        Dim ofd As New OpenFileDialog With {
        .Filter = "Archivos Excel|*.xlsx;*.xls",
        .Title = "Seleccionar archivo de censo oficial"
    }

        If ofd.ShowDialog() = DialogResult.OK Then
            cNombre = ofd.FileName
            Return cNombre
        Else
            Return Nothing
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class