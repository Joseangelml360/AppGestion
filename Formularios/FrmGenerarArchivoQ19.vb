Imports System.IO

Public Class FrmGenerarArchivoQ19
    Private Sub AdeudosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdeudosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbCensos)

    End Sub

    Private Sub FrmGenerarArchivoQ19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbCensos.adeudos' Puede moverla o quitarla según sea necesario.
        Me.AdeudosTableAdapter.Fill(Me.DbCensos.adeudos)
        Dim clinea, cFechaCrea, cFechaCargo As String

        ' leer fecha del registro 1 de adeudos a partir de la posición 17, 6 dígitos.

        clinea = DbCensos.adeudos.Rows(1)("linea".ToString)
        cFechaCrea = Mid(clinea, 17, 6)
        cFechaCargo = Mid(clinea, 23, 6)
        Me.TxtFecha.Text = Mid(cFechaCargo, 1, 2) & "/" & Mid(cFechaCargo, 3, 2) & "/" & Mid(cFechaCargo, 5, 2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cNomAdeudos, clinea, linea As String
        Dim cFechaCrea, cFechaCargo As String
        Dim n As Integer
        ' leer fecha del registro 1 a partir de la posición 16, 6 dígitos.

        clinea = DbCensos.adeudos.Rows(1)("linea".ToString)
        cFechaCrea = Mid(clinea, 17, 6)
        cFechaCargo = Mid(clinea, 23, 6)
        cNomAdeudos = "Adeudos" & cFechaCargo

        Dim ruta As String = "C:\Remesas\" & cNomAdeudos & ".q19"

        If File.Exists(ruta) = True Then
            File.Delete(ruta)  'Borrar el archivo q19 si existe
        Else
            MsgBox("No existe fichero " & ruta & " se ceará uno nuevo con este nombre")
        End If

        'código nuevo para escribir en ANSI
        Dim txtLinea As StreamWriter = New StreamWriter(ruta, True, System.Text.Encoding.Default)
        ' Fin código nuevo

        'código que escribe en UTF-8 y da error al convertir el archivo a XML
        'Dim txtLinea As StreamWriter
        'Fin del código con error de lectura por el banco
        Try
            n = DbCensos.adeudos.Rows.Count - 1
            For i = 0 To n
                linea = DbCensos.adeudos.Rows(i)("linea".ToString)
                txtLinea.WriteLine(linea)
            Next i
            txtLinea.Flush()
            txtLinea.Close()
            MsgBox("Archivo q19 creado correctamente (" & ruta & ")")

        Catch ex As Exception
            MsgBox("Error en la escritura del archivo: " & ruta)
        End Try

    End Sub
End Class