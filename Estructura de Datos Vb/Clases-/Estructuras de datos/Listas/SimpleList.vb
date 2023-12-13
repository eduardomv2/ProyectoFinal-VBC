Public Class SimpleList(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As Node(Of T)

    Public Property Lenght As Integer

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        Dim NewNode As New Node(Of T)(data)

        If IsEmpty() Then
            Head = NewNode
            Lenght += 1
            Return
        End If

        If Exist(NewNode.Data) Then
            Return
        End If

        If NewNode.CompareTo(Head) <= 0 Then
            NewNode.Next = Head
            Head = NewNode
            Lenght += 1
            Return
        End If

        Dim CurrentNode As Node(Of T) = Head

        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.CompareTo(NewNode) < 0
            CurrentNode = CurrentNode.Next
        End While

        NewNode.Next = CurrentNode.Next
        CurrentNode.Next = NewNode
        Lenght += 1
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Head = Head.Next
            Console.WriteLine($"- Data [{data}] remove from List...")
            Lenght -= 1
            Return
        End If

        Dim CurrentNode As Node(Of T) = Head

        While CurrentNode.Next IsNot Nothing AndAlso Not Object.Equals(CurrentNode.Next.Data, data)
            CurrentNode = CurrentNode.Next
        End While

        If CurrentNode.Next IsNot Nothing AndAlso Object.Equals(CurrentNode.Next.Data, data) Then
            CurrentNode.Next = CurrentNode.Next.Next
            Console.WriteLine($"- Data [{data}] remove from List...")
            Lenght -= 1
            Return
        End If

        Console.WriteLine($"- Data [{data}] not removed from List...")
    End Sub

    Public Sub Search(data As T) Implements ImethodLists(Of T).Search
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Console.WriteLine($"- Data [{data}] exists in List...")
            Return
        End If

        Dim CurrentNode As Node(Of T) = Head

        While CurrentNode.Next IsNot Nothing AndAlso Not Object.Equals(CurrentNode.Next.Data, data)
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

        Dim i As Integer = 0
        Dim CurrentNode As Node(Of T) = Head

        Console.WriteLine("=== My Simple List ===")

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

        Dim CurrentNode As Node(Of T) = Head
        Dim x As Integer = 0

        Console.WriteLine("=== My Simple List Revers ===")

        For i As Integer = Lenght - 1 To 0 Step -1
            CurrentNode = Head
            x = 0

            While CurrentNode IsNot Nothing AndAlso x <> i
                CurrentNode = CurrentNode.Next
                x += 1
            End While

            Console.WriteLine($"- Node [{i}] and Data: " & CurrentNode.Data.ToString())
        Next
    End Sub

    Public Function Exist(data As T) As Boolean Implements ImethodLists(Of T).Exist
        If IsEmpty() Then
            Return False
        End If

        If Object.Equals(Head.Data, data) Then
            Return True
        End If

        Dim CurrentNode As Node(Of T) = Head

        While CurrentNode.Next IsNot Nothing AndAlso Not Object.Equals(CurrentNode.Next.Data, data)
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
    End Sub
End Class
