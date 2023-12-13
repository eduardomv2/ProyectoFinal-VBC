Public Class Insertionsort
    Public Sub New()
    End Sub

    Public Sub InsertionSortAlgorithm(ByVal arr As Integer())
        Dim n As Integer = arr.Length
        For i As Integer = 1 To n - 1
            Dim key As Integer = arr(i)
            Dim j As Integer = i - 1

            ' Mover los elementos del subarreglo arr(0..i-1) que son mayores que key
            ' a una posición adelante de su posición actual
            While j >= 0 AndAlso arr(j) > key
                arr(j + 1) = arr(j)
                j = j - 1
            End While
            arr(j + 1) = key
        Next
    End Sub

    Public Sub PrintArray(ByVal arr As Integer())
        For Each item As Integer In arr
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub
End Class
