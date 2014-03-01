Namespace cripografiaAlgoritmica
    Public Class CPatrones
        Const tamano As Integer = 90
        Const limiteInferior As Integer = 60
        Dim UnArray() As Object

        Dim patron As String
        Public Sub Cpatrones()


        End Sub

       

        Public Function inicial() As String

            Dim i As Integer
            Dim tamanoreal As Integer
            tamanoreal = tamano - limiteInferior
            ReDim UnArray(tamanoreal)
            patron = ""

            For i = 0 To tamanoreal
                UnArray(i) = i + limiteInferior
            Next

            Call Desordenar_array(UnArray, LBound(UnArray), UBound(UnArray))

            For i = LBound(UnArray) To UBound(UnArray)
                patron &= Chr(UnArray(i))
            Next

            Return patron
        End Function

     


        Public Sub Desordenar_array(ByRef vArray As Object, _
                          ByVal startIndex As Object, _
                          ByVal endIndex As Object)

            Dim i As Long
            Dim rndIndex As Long
            Dim Temp As Object

            Randomize()

            startIndex = LBound(vArray)
            endIndex = UBound(vArray)

            For i = startIndex To endIndex
                rndIndex = Int((endIndex - startIndex + 1) * Rnd() + startIndex)

                Temp = vArray(i)
                vArray(i) = vArray(rndIndex)
                vArray(rndIndex) = Temp
            Next
        End Sub

       
    End Class



End Namespace

