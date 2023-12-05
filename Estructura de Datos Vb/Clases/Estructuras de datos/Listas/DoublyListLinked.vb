Public Class DoublyListLinked(Of T)
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
            Return
        End If
        If Exist(NewNode.Data) Then
            Return
        End If
        If NewNode.CompareTo(Head) <= 0 Then
            Head.Back = NewNode
            NewNode.Next = Head
            Head = NewNode
            Return
        End If
        If NewNode.CompareTo(LastNode) >= 0 Then
            LastNode.Next = NewNode
            NewNode.Back = LastNode
            LastNode = NewNode
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.CompareTo(NewNode) <= 0
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
        If Object.Equals(Head.Data, data) Then
            Head = Head.Next
            If Head IsNot Nothing Then
                Head.Back = Nothing
            End If
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If
        If Object.Equals(LastNode.Data, data) Then
            LastNode = LastNode.Back
            If LastNode IsNot Nothing Then
                LastNode.Next = Nothing
            End If
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.CompareTo(data) <= 0
            CurrentNode = CurrentNode.Next
        End While
        If Object.Equals(CurrentNode.Data, data) Then
            CurrentNode.Back.Next = CurrentNode.Next
            If CurrentNode.Next IsNot Nothing Then
                CurrentNode.Next.Back = CurrentNode.Back
            End If
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
            Console.WriteLine($"- Data [{data}] exists in List...")
            Return
        End If
        If Object.Equals(LastNode.Data, data) Then
            Console.WriteLine($"- Data [{data}] exists in List...")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.Next
        End While
        If Object.Equals(CurrentNode.Data, data) Then
            Console.WriteLine($"- Data [{data}] exists in List...")
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
        Console.WriteLine("=== My Doubly Linked List ===")
        While CurrentNode IsNot Nothing
            Console.WriteLine($"- Node [{i}] and Data: " & CurrentNode.Data.ToString())
            CurrentNode = CurrentNode.Next
            i += 1
        End While
    End Sub

    Public Sub ShowRevers() Implements ImethodLists(Of T).ShowRevers
        If IsEmpty() Then
            Console.WriteLine("Void List")
            Return
        End If
        Dim CurrentNode As DoubleNode(Of T) = LastNode
        Dim i As Integer = 0
        Console.WriteLine("=== My Doubly Linked List Revers ===")
        Do
            Console.WriteLine($"- Node [{i}] and Data: " & CurrentNode.Data.ToString())
            CurrentNode = CurrentNode.Back
            i += 1
        Loop While CurrentNode IsNot Nothing
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
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.CompareTo(data) < 0
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
