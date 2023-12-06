Public Class BucketSort
    Private Shared _rand As New Random()

    Public Sub New()
    End Sub

    Private Shared Sub PrintBucketState(ByVal buckets As List(Of Integer)())
        Console.WriteLine("Current state of buckets:")
        For i As Integer = 0 To buckets.Length - 1
            Console.Write($"Bucket {i}: ")
            For Each item As Integer In buckets(i)
                Console.Write($"{item} ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
    End Sub

    Public Sub BucketSort_int(ByVal array As Integer())
        ' Encuentra el valor máximo en el array
        Dim maxVal As Integer = array(0)

        For i As Integer = 1 To array.Length - 1
            If array(i) > maxVal Then
                maxVal = array(i)
            End If
        Next

        ' Crea una lista de buckets vacíos
        Dim buckets As List(Of Integer)() = New List(Of Integer)(maxVal) {}

        For i As Integer = 0 To buckets.Length - 1
            buckets(i) = New List(Of Integer)()
        Next

        ' Distribuye los elementos en los buckets
        For i As Integer = 0 To array.Length - 1
            buckets(array(i)).Add(array(i))
        Next

        PrintBucketState(buckets)

        ' Ordena cada cubo individualmente
        For i As Integer = 0 To buckets.Length - 1
            buckets(i).Sort()
        Next

        PrintBucketState(buckets)

        ' Concatena los elementos ordenados de cada cubo
        Dim index As Integer = 0
        For i As Integer = 0 To buckets.Length - 1
            For Each item As Integer In buckets(i)
                array(index) = item
                index += 1
            Next
        Next
    End Sub

    Private Shared Sub PrintArray(ByVal arr As Integer())
        For Each item As Integer In arr
            Console.Write($"{item} ")
        Next
        Console.WriteLine()
    End Sub
End Class
