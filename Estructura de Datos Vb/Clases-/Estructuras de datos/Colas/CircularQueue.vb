Public Class CircularQueue
    Private Size, Front, Rear As Integer
    Private Queue As New List(Of Integer)()

    Public Sub New(size As Integer)
        Me.Size = size
        Me.Front = Me.Rear = -1
    End Sub

    Public Sub Enqueue(Value As Integer)
        If (Front = 0 AndAlso Rear = Size - 1) OrElse (Rear = (Front - 1) Mod (Size - 1)) Then
            Console.Write("Queue is Full")
        ElseIf Front = -1 Then
            Front = 0
            Rear = 0
            Queue.Add(Value)
        ElseIf Rear = Size - 1 AndAlso Front <> 0 Then
            Rear = 0
            Queue(Rear) = Value
        Else
            Rear = (Rear + 1)
            If Front <= Rear Then
                Queue.Add(Value)
            Else
                Queue(Rear) = Value
            End If
        End If
    End Sub

    Public Function Dequeue() As Integer
        Dim Temp As Integer
        If Front = -1 Then
            Console.Write("Queue is Empty")
            Return -1
        End If
        Temp = Queue(Front)
        If Front = Rear Then
            Front = -1
            Rear = -1
        ElseIf Front = Size - 1 Then
            Front = 0
        Else
            Front = Front + 1
        End If
        Return Temp
    End Function

    Public Sub Show()
        If Front = -1 Then
            Console.Write("Queue is Empty")
            Return
        ElseIf Queue.Count = 0 Then
            Console.Write("Queue is Empty")
            Return
        End If
        Console.WriteLine("=== My Circular Queue ===")
        If Rear >= Front Then
            For i As Integer = Front To Rear - 1
                Console.WriteLine($"- Node[{i}] and Data: " + Queue(i))
            Next
        Else
            For i As Integer = Front To Size - 1
                Console.WriteLine($"- Node[{i}] and Data: " + Queue(i))
            Next
            For i As Integer = 0 To Rear
                Console.WriteLine($"- Node[{i}] and Data: " + Queue(i))
            Next
        End If
    End Sub

    Public Sub Clear()
        Queue.Clear()
    End Sub
End Class
