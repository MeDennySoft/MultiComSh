'''''''''''''''''''''''''''''''''''''''''''''''''
'CREADO POR MEDENNYSOFT.COM
'CONTACTO@MEDENNYSOFT.COM
'''''''''''''''''''''''''''''''''''''''''''''''''
Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class EncriptaFile
    Private sSecretKey As String = ""
    Const encriptar As Integer = 0
    Const desencriptar As Integer = 1

    Public Sub inicio(ByVal clavePrivada As String, ByVal tipo As Integer, ByVal InputFIleName As String, ByVal OutPutFileName As String)
        sSecretKey = clavePrivada

        If tipo = encriptar Then

        End If

        If tipo = desencriptar Then


        End If
    End Sub

    Sub EncryptFile(ByVal sInputFilename As String, _
                  ByVal sOutputFilename As String, _
                  ByVal sKey As String)

        Dim fsInput As New FileStream(sInputFilename, _
                                    FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, _
                                    FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()

        'Establecer la clave secreta para el algoritmo DES.
        'Se necesita una clave de 64 bits y IV para este proveedor
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Establecer el vector de inicialización.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'crear cifrado DES a partir de esta instancia
        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        'Crear una secuencia de cifrado que transforma la secuencia
        'de archivos mediante cifrado DES
        Dim cryptostream As New CryptoStream(fsEncrypted, _
                                            desencrypt, _
                                            CryptoStreamMode.Write)

        'Leer el texto del archivo en la matriz de bytes
        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        'Escribir el archivo cifrado con DES
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
    End Sub

    Sub DecryptFile(ByVal sInputFilename As String, _
        ByVal sOutputFilename As String, _
        ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        'Se requiere una clave de 64 bits y IV para este proveedor.
        'Establecer la clave secreta para el algoritmo DES.
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        'Establecer el vector de inicialización.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'crear la secuencia de archivos para volver a leer el archivo cifrado
        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        'crear descriptor DES a partir de nuestra instancia de DES
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        'crear conjunto de secuencias de cifrado para leer y realizar 
        'una transformación de descifrado DES en los bytes entrantes
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        'imprimir el contenido de archivo descifrado
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
    End Sub

End Class
