Public Class PriorityQueue(Of T)
    Public Class Element(Of T)
        Public Property Value As T
        Public Property Priority As Integer

        Public Sub New(value As T, priority As Integer)
            Me.Value = value
            Me.Priority = priority
        End Sub
    End Class

    Private Items As List(Of Element(Of T))
    Public Property Count As Integer

    Public Sub New()
        Items = New List(Of Element(Of T))()
    End Sub

    Public Sub Enqueue(value As T, priority As Integer)
        Dim element = New Element(Of T)(value, priority)
        Items.Add(element)
        HeapifyUp(Items.Count - 1)
    End Sub

    Public Function Dequeue() As T
        If Items.Count = 0 Then
            Console.WriteLine("Void Queue")
            Return Nothing
        End If
        Dim result = Items(0).Value
        Items(0) = Items(Items.Count - 1)
        Items.RemoveAt(Items.Count - 1)
        HeapifyDown(0)
        Return result
    End Function

    Private Sub HeapifyUp(Index As Integer)
        While Index > 0
            Dim parentIndex As Integer = (Index - 1) \ 2

            If Items(Index).Priority < Items(parentIndex).Priority Then
                Swap(Index, parentIndex)
                Index = parentIndex
            Else
                Exit While
            End If
        End While
    End Sub

    Private Sub HeapifyDown(Index As Integer)
        Dim leftChild As Integer = 2 * Index + 1
        Dim rightChild As Integer = 2 * Index + 2
        Dim smallest As Integer = Index

        If leftChild < Items.Count AndAlso Items(leftChild).Priority < Items(smallest).Priority Then
            smallest = leftChild
        End If

        If rightChild < Items.Count AndAlso Items(rightChild).Priority < Items(smallest).Priority Then
            smallest = rightChild
        End If

        If smallest <> Index Then
            Swap(Index, smallest)
            HeapifyDown(smallest)
        End If
    End Sub

    Private Sub Swap(Index1 As Integer, Index2 As Integer)
        Dim temp = Items(Index1)
        Items(Index1) = Items(Index2)
        Items(Index2) = temp
    End Sub

    Public Sub Show()
        If Items.Count = 0 Then
            Console.WriteLine("Void Queue")
            Return
        End If
        Console.WriteLine("=== My Priority Queue ===")
        For Each element In Items
            Console.WriteLine($"Data: {element.Value} Priority: {element.Priority}")
        Next
        Console.WriteLine()
    End Sub

    Public Sub Clear()
        Items.Clear()
    End Sub
End Class
