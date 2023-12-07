Public Class MenuAlgorithm
    Public Shared Name As String = "Algorithm"
    Public Shared _Random As New Random()
    Public Shared _Information As New Information()
    Public Shared _MenuStructures As New MenuStructures()
    Public Shared _Bubblesort As New BubbleSortt()
    Public Shared _Cocktailsor As New Cocktailsort()
    Public Shared _Insertionsort As New Insertionsort()
    Public Shared _Bucketsortt As New BucketSort()
    Public Shared _Countingsort As New Countingsort()
    Public Shared _Mergesort As New Mergesort()
    Public Shared _Binarytreesort As New Binarytreesort()
    Public Shared _Pigeonhole As New Pigeonhole()
    Public Shared _Radixsort As New Radixsort()
    Public Shared _Gnomesort As New Gnomesort()
    Public Shared _Shellsort As New Shellsort()
    Public Shared _Combsort As New Combsort()
    Public Shared _Selectionsort As New Selectionsort()
    Public Shared _Heapsort As New Heapsort()
    Public Shared _Quicksort As New QuickSort()

    Public Shared _TypeStack As String() = _Information.TypeAlgorithm

    Public Sub New()
    End Sub

    Public Sub CycleAlgorithm(ByRef Operation As Integer)
        Do
            Operation = 0
            _MenuStructures.PrintArray(_TypeStack, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _TypeStack.Length
    End Sub

    Private Function Options(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumAlgorithm = CType([option], EnumAlgorithm)
        Console.Clear()
        Menu(x)
        Return [option]
    End Function

    Private Sub Menu(DataType As EnumAlgorithm)
        Console.Clear()
        Select Case DataType
            Case EnumAlgorithm.None
            ' No action needed
            Case EnumAlgorithm.Bubblesort
                Name = "Bubblesort"
                Dim a As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(a)
                _Bubblesort.bubbleSort(a)
                Console.WriteLine("Bubblesort: ")
                Print(a)
                Console.ReadKey()
            Case EnumAlgorithm.Cocktailsort
                Name = "Cocktailsort"
                Dim b As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(b)
                _Cocktailsor.Sort(b)
                Console.WriteLine("Cocktailsort: ")
                Print(b)
                Console.ReadKey()
            Case EnumAlgorithm.Insertionsort
                Name = "Insertionsort"
                Dim c As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(c)
                _Insertionsort.InsertionSortAlgorithm(c)
                Console.WriteLine("Insertionsort: ")
                Print(c)
                Console.ReadKey()
            Case EnumAlgorithm.Bucketsort
                Name = "Bucketsort"
                Dim d As Double() = GenerarVectorDouble()
                Console.WriteLine("Original: ")
                Print(d)
                _Bucketsortt.BucketSort_double(d)
                Console.WriteLine("Bucketsort: ")
                Print(d)
                Console.ReadKey()
            Case EnumAlgorithm.Countingsort
                Name = "Countingsort"
                Dim e As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(e)
                _Countingsort.Sort(e)
                Console.WriteLine("Countingsort: ")
                Print(e)
                Console.ReadKey()
            Case EnumAlgorithm.Mergesort
                Name = "Mergesort"
                Dim f As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(f)
                _Mergesort.MergeSort(f)
                Console.WriteLine("Mergesort: ")
                Print(f)
                Console.ReadKey()
            Case EnumAlgorithm.Binarytreesort
                Name = "Binarytreesort"
                Dim g As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(g)
                _Binarytreesort.Sort(g)
                Console.WriteLine("Binarytreesort: ")
                Print(g)
                Console.ReadKey()
            Case EnumAlgorithm.Pigeonhole
                Name = "Pigeonhole"
                Dim h As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(h)
                _Pigeonhole.PigeonholeSort(h)
                Console.WriteLine("Pigeonhole: ")
                Print(h)
                Console.ReadKey()
            Case EnumAlgorithm.Radixsort
                Name = "Radixsort"
                Dim i As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(i)
                _Radixsort.Sort(i)
                Console.WriteLine("Radixsort: ")
                Print(i)
                Console.ReadKey()
            Case EnumAlgorithm.Gnomesort
                Name = "Gnomesort"
                Dim s As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(s)
                _Gnomesort.Sort(s)
                Console.WriteLine("Gnomesort: ")
                Print(s)
                Console.ReadKey()
            Case EnumAlgorithm.Shellsort
                Name = "Shellsort"
                Dim r As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(r)
                _Shellsort.ShellSort(r)
                Console.WriteLine("Shellsort: ")
                Print(r)
                Console.ReadKey()
            Case EnumAlgorithm.Combsort
                Name = "Combsort"
                Dim a As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(a)
                _Combsort.Sort(a)
                Console.WriteLine("Combsort: ")
                Print(a)
                Console.ReadKey()
            Case EnumAlgorithm.Selectionsort
                Name = "Selectionsort"
                Dim e As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(e)
                _Selectionsort.Sort(e)
                Console.WriteLine("Selectionsort: ")
                Print(e)
                Console.ReadKey()
            Case EnumAlgorithm.Heapsort
                Name = "Heapsort"
                Dim l As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(l)
                _Heapsort.Sort(l)
                Console.WriteLine("Heapsort: ")
                Print(l)
                Console.ReadKey()
            Case EnumAlgorithm.Quicksort
                Name = "Quicksort"
                Dim c As Integer() = Multipurpose()
                Console.WriteLine("Original: ")
                Print(c)
                _Quicksort.Quicksort(c, 0, c.Length - 1)
                Console.WriteLine("Quicksort: ")
                Print(c)
                Console.ReadKey()
            Case EnumAlgorithm.Exitt
        End Select
    End Sub

    Private Function Multipurpose() As Integer()
        Dim x As Integer = 0

        Console.Clear()
        Console.Write("Insert one data: ")
        x = Integer.Parse(Console.ReadLine())
        Console.Clear()
        Console.WriteLine(vbTab & "@Israel I22050327 Algorithm: " & Name & vbCrLf)
        Dim array(x - 1) As Integer

        For i As Integer = 0 To array.Length - 1
            array(i) = _Random.Next(10000)
        Next

        Return array
    End Function

    Public Function GenerarVectorDouble() As Double()
        Dim Minon = 0
        Dim Lenght = 0
        Dim values = 5

        Console.Clear()
        Console.Write("Insert one data: ")
        Lenght = Integer.Parse(Console.ReadLine())
        Console.Clear()
        Console.WriteLine(vbTab & "@Israel I22050327 Algorithm: " & Name & vbLf)
        Dim _List As New List(Of Double)()

        For i As Integer = Minon To Lenght - 1
            If i < values Then
                Dim NewValor As Double = _Random.NextDouble()
                _List.Add(NewValor)
            Else
                Exit For
            End If
        Next

        Return _List.ToArray()
    End Function


    Private Sub Print(collection As Array)
        Console.Write("[")
        For Each item In collection
            Console.Write($" {item}, ")
        Next
        Console.Write("]" & vbCrLf & vbCrLf)
    End Sub
End Class
