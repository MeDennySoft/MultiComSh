'''''''''''''''''''''''''''''''''''''''''''''''''
'CREADO POR MEDENNYSOFT.COM
'CONTACTO@MEDENNYSOFT.COM
'''''''''''''''''''''''''''''''''''''''''''''''''
Namespace cripografiaAlgoritmica
    Public Class AsciiB
        Private patron_Busqueda As String
        Private patron_Encripta As String
        Const encriptar As Integer = 0
        Const desencriptar As Integer = 1

        Public Function AsciiB(ByVal tipo As Integer, ByVal texto As String, ByVal pass As String) As String
            ''''''''''''''''''''''''''''
            Dim objAes As AES = New AES()
            ''''''''''''''''''''''''''''
            Dim patron As CPatrones = New CPatrones()
            Dim resultado As String = ""
            Dim Lineas() As String
            Dim i As Integer

            If tipo.Equals(encriptar) Then
                patron_Busqueda = patron.inicial()
                patron_Encripta = patron.inicial()
                resultado = encriptarCadena(texto) + vbCrLf + patron_Busqueda + vbCrLf + patron_Encripta
                '  ''''''''''''''''''''''''''''
                resultado = objAes.principio(resultado, pass, 0)
                ''''''''''''''''''''''''''''
            End If

            If tipo.Equals(desencriptar) Then
                ''''''''''''''''''''''''''''
                texto = objAes.principio(texto, pass, 1)
                ''''''''''''''''''''''''''''
                Lineas = Split(texto, Chr(10))
                patron_Encripta = Lineas(UBound(Lineas))
                patron_Busqueda = Lineas(UBound(Lineas) - 1)
                '''''''''''''''''''''''''''''''''''''''''''''
                Lineas = Split(texto, Chr(10))
                '''''''''''''''''''''''''''''''''''''''''''''
                texto = ""
                For i = 0 To Lineas.Length - 3
                    texto &= Lineas(i)
                Next
                resultado = DesEncriptarCadena(texto)
            End If
            Return resultado
        End Function
        Public Function encriptarCadena(ByVal cadena As String) As String
            Dim idx As Integer
            Dim result As String = ""

            For idx = 0 To cadena.Length - 1
                result += encriptarCaracter(cadena.Substring(idx, 1), cadena.Length, idx)
            Next

            Return result
        End Function

        Public Function encriptarCaracter(ByVal caracter As String, ByVal variable As Integer, ByVal a_indice As Integer) As String
            Dim caracterEncriptado As String = "", indice As Integer

            If patron_Busqueda.IndexOf(caracter) <> -1 Then
                indice = (patron_Busqueda.IndexOf(caracter) + variable + a_indice) Mod patron_Busqueda.Length
                Return patron_Encripta.Substring(indice, 1)
            End If

            Return caracter
        End Function

        Public Function DesEncriptarCadena(ByVal cadena As String) As String
            Dim idx As Integer
            Dim result As String = ""

            For idx = 0 To cadena.Length - 1
                result += DesEncriptarCaracter(cadena.Substring(idx, 1), cadena.Length, idx)
            Next

            Return result
        End Function
        Public Function DesEncriptarCaracter(ByVal caracter As String, ByVal variable As Integer, ByVal a_indice As Integer) As String
            Dim indice As Integer

            If patron_Encripta.IndexOf(caracter) <> -1 Then
                If patron_Encripta.IndexOf(caracter) - variable - a_indice > 0 Then
                    indice = (patron_Encripta.IndexOf(caracter) - variable - a_indice) Mod patron_Encripta.Length
                    Return patron_Encripta.Substring(indice, 1)
                Else
                    indice = (patron_Busqueda.Length) + (patron_Encripta.IndexOf(caracter) - variable - a_indice) Mod patron_Encripta.Length
                End If

                indice = indice Mod patron_Encripta.Length
                Return patron_Busqueda.Substring(indice, 1)
            Else
                Return caracter
            End If

        End Function
    End Class
End Namespace
