'''''''''''''''''''''''''''''''''''''''''''''''''
'CREADO POR MEDENNYSOFT.COM
'CONTACTO@MEDENNYSOFT.COM
'''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.IO
Imports MultiCom.cripografiaAlgoritmica
Public Class Encriptador
    'Funciones o metodos generales
    Public Sub guardarArchivo(ByRef direccion)
        Dim myStream As Stream
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
        SaveFileDialog1.Title = "Guardar archivo de texto"
        SaveFileDialog1.FileName = "ArchivoDeTextoPlano"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = SaveFileDialog1.OpenFile()
            Using sw As StreamWriter = New StreamWriter(myStream)
                sw.Write(direccion)
                sw.Close()
            End Using
        End If
    End Sub

    Public Sub LeerArchivo()
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim myStream As Stream
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
        OpenFileDialog1.Title = "Abrir archivo de texto"
        OpenFileDialog1.FileName = "ArchivoDeTextoPlano"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = OpenFileDialog1.OpenFile()
            Using objReader As StreamReader = New StreamReader(myStream)
                Do
                    sLine = objReader.ReadLine()
                    If Not sLine Is Nothing Then
                        arrText.Add(sLine)
                    End If
                Loop Until sLine Is Nothing
                objReader.Close()

                For Each sLine In arrText
                    TextBox2.Text &= sLine & vbCrLf
                Next


            End Using
        End If
    End Sub

    Public Function comprobarNulos() As String
        If RadioButton4.Checked = True Then
            If TextBox2.Text.Length = 0 Then
                Return False
            Else
                Return True
            End If
        Else

            If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Then
                Return False
            Else
                Return True
            End If
        End If

        Return False
    End Function

    Public Function tipoAlgoritmo(ByVal texto, ByVal opcion) As String
        Dim resultado As String = ""
        Dim claveGlobalPublica As String
        Dim sopa As AsciiB = New AsciiB
        ' Dim objBase As Base64 = New Base64()
        Dim objAes As AES = New AES()
        claveGlobalPublica = TextBox1.Text

        '------------------Aes--------------------
        If RadioButton2.Checked = True Then

            Dim passPhrase As String
            passPhrase = claveGlobalPublica
            resultado = objAes.principio(texto, passPhrase, opcion)
        End If
        '------------
        If RadioButton3.Checked = True Then
            resultado = sopa.AsciiB(opcion, texto, claveGlobalPublica)
        End If
        ''------------------Base64------------------
        If RadioButton4.Checked = True Then
            resultado = Base64.principio(texto, opcion)
        End If
        '-----------------------------------
        Return resultado
    End Function
    'Botones
    '--------------------------Botones de funcionalidad-----------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim seguir As Boolean
        seguir = comprobarNulos()

        If seguir = False Then
            MsgBox("Error: No puede ser nulo el campo a Desencriptar y/o falta la clave")
        Else
            'Funcionalidad
            Try
                TextBox3.Text = tipoAlgoritmo(TextBox2.Text, 0)
            Catch ex As Exception
                MsgBox("Error, la contraseña o el tipo de cifrado no coincide:" & vbCrLf & ex.Message)
            End Try

        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim seguir As Boolean
        seguir = comprobarNulos()

        If seguir = False Then
            MsgBox("Error: No puede ser nulo el campo a Desencriptar y/o falta la clave")
        Else
            'Funcionalidad
            Try
                TextBox3.Text = tipoAlgoritmo(TextBox2.Text, 1)
            Catch ex As Exception
                MsgBox("Error, la contraseña o el tipo de cifrado no coincide:" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If



    End Sub
    '--------------------------------------------------------------------------------
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text.Length = 0 Then
            MsgBox("Error: No puede ser nulo el campo a copiar")
        Else
            TextBox2.SelectAll()
            Clipboard.SetText(TextBox2.SelectedText)
        End If

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        guardarArchivo(TextBox2.Text)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        guardarArchivo(TextBox3.Text)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If TextBox3.Text.Length = 0 Then
            MsgBox("Error: No puede ser nulo el campo a copiar")
        Else
            TextBox3.SelectAll()
            Clipboard.SetText(TextBox3.SelectedText)
        End If
    End Sub
    'Radios
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label3.Text = "Alto"
            TextBox1.Enabled = True
        End If
    End Sub

    

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Label3.Text = "Fuerte"
            TextBox3.Text = "Este algoritmo es de prueba, tiene fallas y solo es recomendado para encriptación de numeros"
           
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Label3.Text = "Basico"
            TextBox1.Enabled = False
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = False
            TextBox1.Text = Aleatorio.GetSimpleUserPassword()
            TextBox1.SelectAll()
            Clipboard.SetText(TextBox1.SelectedText)
            MsgBox("Esta clave sera usada para encriptar: " & TextBox1.Text & vbCrLf & " Note usted que ya se copio al portapapeles: CTRL + V")

        Else
            If RadioButton4.Checked = False Then
                TextBox1.Enabled = True
            Else
                TextBox1.Enabled = False
            End If

            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox2.Text = ""
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.LeerArchivo()
    End Sub
End Class