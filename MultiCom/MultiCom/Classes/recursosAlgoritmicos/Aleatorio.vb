Namespace cripografiaAlgoritmica
    Public Class Aleatorio
        Public Shared Function GetSimpleUserPassword(Optional ByVal length As Int16 = 8) As String
            'Get the GUID
            Dim guidResult As String = System.Guid.NewGuid().ToString()
            'Remove the hyphens
            guidResult = guidResult.Replace("-", String.Empty)
            'Make sure length is valid
            If length <= 0 OrElse length > guidResult.Length Then
                Return guidResult
            Else
                'Return the first length bytes
                Return guidResult.Substring(0, length)
            End If

        End Function
    End Class
End Namespace