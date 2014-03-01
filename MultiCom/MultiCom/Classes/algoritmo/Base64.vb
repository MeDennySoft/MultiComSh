'''''''''''''''''''''''''''''''''''''''''''''''''
'Creado Por DANIEL NOE VERA MORALES
'DORANGE.WEBS@GMAIL.COM
'''''''''''''''''''''''''''''''''''''''''''''''''
Namespace cripografiaAlgoritmica
    Public Class Base64
        Const encriptar As Integer = 0
        Const desencriptar As Integer = 1

        Public Shared Function principio(ByRef texto, ByVal tipo) As String
            Dim strModified As String
            Dim strOriginal As String
            Dim valor As String = ""
            If tipo = encriptar Then
                strOriginal = texto
                Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(strOriginal)
                ' convert the byte array to a Base64 string
                strModified = Convert.ToBase64String(byt)
                valor = strModified
            End If

            If tipo = desencriptar Then
                strModified = texto
                Dim b As Byte() = Convert.FromBase64String(strModified)
                strOriginal = System.Text.Encoding.UTF8.GetString(b)
                valor = strOriginal
            End If
            Return valor
        End Function
    End Class
End Namespace