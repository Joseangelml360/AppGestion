Imports System.Text

Module funciones

    Function ValidarIBAN(ByVal IBAN As String) As Boolean
        ' Eliminar espacios en blanco
        IBAN = IBAN.Replace(" ", String.Empty)

        ' Verificar longitud mínima
        If IBAN.Length < 15 OrElse IBAN.Length > 34 Then
            Return False
        End If

        ' Mover los primeros cuatro caracteres al final del string
        IBAN = IBAN.Substring(4) & IBAN.Substring(0, 4)

        ' Convertir letras a números (A=10, B=11, ..., Z=35)
        Dim numericIban As New StringBuilder()
        For Each ch As Char In IBAN
            If Char.IsLetter(ch) Then
                numericIban.Append(Asc(ch) - Asc("A"c) + 10)
            Else
                numericIban.Append(ch)
            End If
        Next

        ' Convertir el string a un número entero grande y calcular el módulo 97
        Dim bigInt As New System.Numerics.BigInteger(Convert.ToDecimal(numericIban.ToString()))
        Return bigInt Mod 97 = 1

    End Function

    Sub LimpiarCampos(ByVal formulario As Form)
        Dim text As Object
        For Each text In formulario.Controls
            If TypeOf text Is TextBox Then
                Dim txtTemp As TextBox = CType(text, TextBox)
                txtTemp.Clear()
            End If
        Next
    End Sub

    Sub LimpiarGroupBox(groupBox As GroupBox)
        For Each ctrl As Control In groupBox.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
        Next
    End Sub
End Module
