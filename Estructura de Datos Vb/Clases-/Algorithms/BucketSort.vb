Public Class BucketSort
    Private Shared _rand As New Random()

    Public Sub New()
    End Sub

    Public Sub BucketSort_double(array As Double())
        ' Crear buckets vacíos
        Dim buckets(array.Length - 1) As List(Of Double)
        For i As Integer = 0 To buckets.Length - 1
            buckets(i) = New List(Of Double)()
        Next

        ' Insertar elementos en sus respectivos buckets
        For Each element As Double In array
            buckets(CInt(element * array.Length)).Add(element)
        Next

        ' Imprimir el estado de los buckets después de la inserción
        PrintBucketState(buckets)

        ' Ordenar los elementos de cada cubo
        For i As Integer = 0 To array.Length - 1
            buckets(i).Sort()
        Next

        ' Imprimir el estado de los buckets después de la ordenación
        PrintBucketState(buckets)

        ' Obtener los elementos ordenados
        Dim k As Integer = 0
        For i As Integer = 0 To array.Length - 1
            For Each item As Double In buckets(i)
                array(k) = item
                k += 1
            Next
        Next
    End Sub

    Private Sub PrintBucketState(buckets As List(Of Double)())
        Console.WriteLine("Current state of buckets:")
        For i As Integer = 0 To buckets.Length - 1
            Console.Write($"Bucket {i}: ")
            For Each item As Double In buckets(i)
                Console.Write($"{item} ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
    End Sub

End Class
