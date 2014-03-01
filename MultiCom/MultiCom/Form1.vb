'''''''''''''''''''''''''''''''''''''''''''''''''
'CREADO POR MEDENNYSOFT.COM
'CONTACTO@MEDENNYSOFT.COM
'''''''''''''''''''''''''''''''''''''''''''''''''
Public Class Principal
    Private Shared Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Encriptador.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim cadena As String = "Esta cadena va a convertirse en un array de bytes"
        'Dim bytes() As Byte = System.Text.Encoding.Unicode.GetBytes(cadena)
        'Dim otro As String
        ''otro = Convert.ToBase64String(bytes)
        'MsgBox(Chr(255))

        Encriptador.TextBox2.Text = Me.TextBox5.Text
        
    End Sub

   
    



    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class


