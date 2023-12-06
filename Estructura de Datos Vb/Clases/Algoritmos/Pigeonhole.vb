Public Class Pigeonhole
    Public Sub New()
    End Sub

    Public Sub PigeonholeSort(ByVal arr As Integer())
        Dim min As Integer = arr(0)
        Dim max As Integer = arr(0)
        Dim range, i, j, index As Integer

        For a As Integer = 1 To arr.Length - 1
            If arr(a) > max Then
                max = arr(a)
            End If
            If arr(a) < min Then
                min = arr(a)
            End If
        Next

        range = max - min + 1
        Dim pigeonholes(range - 1) As Integer

        For i = 0 To arr.Length - 1
            pigeonholes(i) = 0
        Next

        For i = 0 To arr.Length - 1
            pigeonholes(arr(i) - min) += 1
        Next

        index = 0

        For j = 0 To range - 1
            While pigeonholes(j) > 0
                arr(index) = j + min
                pigeonholes(j) -= 1
                index += 1
            End While
        Next
    End Sub

    Public Sub PrintArray(ByVal arr As Integer())
        For Each num As Integer In arr
            Console.Write(num & " ")
        Next
        Console.WriteLine()
    End Sub
End Class
