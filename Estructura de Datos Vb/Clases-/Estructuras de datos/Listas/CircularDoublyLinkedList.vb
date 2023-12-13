Public Class CircularDoublyLinkedList(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As DoubleNode(Of T)
    Private Property LastNode As DoubleNode(Of T)

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        Dim NewNode As New DoubleNode(Of T)(data)
        If IsEmpty() Then
            Head = NewNode
            LastNode = NewNode
            Head.Back = LastNode
            LastNode.Next = Head
            Return
        End If
        If Exist(NewNode.Data) Then
            Return
        End If
        If NewNode.CompareTo(Head) <= 0 Then
            NewNode.Next = Head
            NewNode.Back = LastNode
            Head.Back = NewNode
            Head = NewNode
            LastNode.Next = Head
            Return
        End If
        If NewNode.CompareTo(LastNode) >= 0 Then
            LastNode.Next = NewNode
            NewNode.Back = LastNode
            NewNode.Next = Head
            LastNode = NewNode
            Head.Back = LastNode
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Head AndAlso CurrentNode.Next.CompareTo(NewNode) <= 0
            CurrentNode = CurrentNode.Next
        End While
        NewNode.Next = CurrentNode.Next
        NewNode.Back = CurrentNode
        CurrentNode.Next.Back = NewNode
        CurrentNode.Next = NewNode
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        If IsEmpty() Then
            Return
        End If
        If Object.Equals(Head.Data, LastNode.Data) Then
            Clear()
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If
        If Object.Equals(Head.Data, data) Then
            Head = Head.Next
            Head.Back = LastNode
            LastNode.Next = Head
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If
        If Object.Equals(LastNode.Data, data) Then
            LastNode = LastNode.Back
            LastNode.Next = Head
            Head.Back = LastNode
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Head AndAlso Not Object.Equals(CurrentNode.Next.Data, data)
            CurrentNode = CurrentNode.Next
        End While
        If Object.Equals(CurrentNode.Next.Data, data) Then
            CurrentNode.Next.Next.Back = CurrentNode
            CurrentNode.Next = CurrentNode.Next.Next
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If
        Console.WriteLine($"- Data [{data}] no remove from List...")
    End Sub

    Public Sub Search(data As T) Implements ImethodLists(Of T).Search
        If IsEmpty() Then
            Return
        End If
        If Object.Equals(Head.Data, data) Then
            Console.WriteLine($"- Data [{data}] exist in List...")
            Return
        End If
        If Object.Equals(LastNode.Data, data) Then
            Console.WriteLine($"- Data [{data}] exist in List...")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Head AndAlso Not Object.Equals(CurrentNode.Next.Data, data)
            CurrentNode = CurrentNode.Next
        End While
        If Object.Equals(CurrentNode.Data, data) Then
            Console.WriteLine($"- Data [{data}] exist in List...")
            Return
        End If
        Console.WriteLine($"- Data [{data}] does not exist in List...")
    End Sub

    Public Sub Show() Implements ImethodLists(Of T).Show
        If IsEmpty() Then
            Console.WriteLine("Void List")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        Dim i As Integer = 0
        Console.WriteLine("=== My Cicular Doubly Linked List ===")
        Do
            Console.WriteLine($"- Node [{i}] and Data: " & CurrentNode.Data.ToString())
            CurrentNode = CurrentNode.Next
            i += 1
        Loop While CurrentNode IsNot Head
    End Sub

    Public Sub ShowRevers() Implements ImethodLists(Of T).ShowRevers
        If IsEmpty() Then
            Console.WriteLine("Void List")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = LastNode
        Dim i As Integer = 0
        Console.WriteLine("=== My Cicular Doubly Linked List Revers===")
        Do
            Console.WriteLine($"- Node [{i}] and Data: " & CurrentNode.Data.ToString())
            CurrentNode = CurrentNode.Back
            i += 1
        Loop While CurrentNode IsNot LastNode
    End Sub

    Public Function Exist(data As T) As Boolean Implements ImethodLists(Of T).Exist
        If IsEmpty() Then
            Return False
        End If
        If Object.Equals(Head.Data, data) Then
            Return True
        End If
        If Object.Equals(LastNode.Data, data) Then
            Return True
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Head AndAlso Not Object.Equals(CurrentNode.Data, data)
            CurrentNode = CurrentNode.Next
        End While
        If Object.Equals(CurrentNode.Data, data) Then
            Return True
        End If
        Return False
    End Function

    Public Function IsEmpty() As Boolean Implements ImethodLists(Of T).IsEmpty
        Return Head Is Nothing
    End Function

    Public Sub Clear() Implements ImethodLists(Of T).Clear
        Head = Nothing
        LastNode = Nothing
    End Sub
End Class
