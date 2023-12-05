Public Class StackDinamic(Of T)
    Private Stack As New List(Of T)()
    Public Count As Integer

    Default Public ReadOnly Property Item(index As Integer) As T
        Get
            Return Stack(index)
        End Get
    End Property

    Public Sub New()
        Stack = New List(Of T)()
        Count = 0
    End Sub

    Public Sub Push(item As T)
        Stack.Add(item)
        Count += 1
    End Sub

    Public Function Pop() As T
        If Stack.Count = 0 Then
            Console.WriteLine("Void Stack")
            Return Nothing
        End If

        Dim lastIndex As Integer = Stack.Count - 1
        Dim poppedItem As T = Stack(lastIndex)
        Stack.RemoveAt(lastIndex)
        Count -= 1

        Return poppedItem
    End Function

    Public Function Peek() As T
        If Stack.Count = 0 Then
            Console.WriteLine("Void Stack")
            Return Nothing
        End If

        Console.WriteLine(Stack(Stack.Count - 1))
        Return Stack(Stack.Count - 1)
    End Function

    Public Sub Show(stack As StackDinamic(Of T))
        If stack.Count = 0 Then
            Console.WriteLine("Void Stack")
            Return
        End If

        Console.WriteLine("=== My Stack Dinamic ===")
        Do While stack.Count > 0
            stack.Count -= 1
            Console.WriteLine(stack.Pop())
        Loop
    End Sub
End Class
