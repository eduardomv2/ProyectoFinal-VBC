﻿Public Class QuickSort
    Private Shared _Random As New Random()

    Private Shared _Option, _ContainExchange, _ContainPartition, _ContainRecursive As Integer

    Public Sub New()
    End Sub

    Private Sub Swap(ByRef IndexOnew As Integer, ByRef IndexTwo As Integer)
        Dim Temporary As Integer = IndexOnew
        IndexOnew = IndexTwo
        IndexTwo = Temporary
    End Sub

    Private Function Partition(ByRef Array As Integer(), ByVal FirstIndex As Integer, ByVal LastIndex As Integer) As Integer
        _ContainPartition += 1
        Dim IndexPivot As Integer
        Select Case _Option
            Case 1
                IndexPivot = FirstIndex
            Case 2
                IndexPivot = CInt(Math.Floor(CDbl((LastIndex + FirstIndex) / 2)))
            Case 3
                IndexPivot = LastIndex
            Case Else
                IndexPivot = _Random.Next(FirstIndex, LastIndex)
        End Select
        Swap(Array(FirstIndex), Array(IndexPivot))
        PrintSwap(Array, FirstIndex, IndexPivot)
        _ContainExchange += 1
        Dim Pivot As Integer = Array(FirstIndex)
        Dim Left As Integer = FirstIndex + 1
        Dim Right As Integer = LastIndex
        While True
            While Left <= Right AndAlso Array(Left) <= Pivot
                Left += 1
            End While
            While Left <= Right AndAlso Array(Right) >= Pivot
                Right -= 1
            End While
            If Right < Left Then
                Exit While
            End If
            Swap(Array(Left), Array(Right))
            PrintSwap(Array, Left, Right)
            _ContainExchange += 1
            Left += 1
            Right -= 1
        End While
        Swap(Array(FirstIndex), Array(Right))
        PrintSwap(Array, FirstIndex, Right)
        _ContainExchange += 1
        Return Right
    End Function

    Public Sub quicksort(ByRef Array As Integer(), ByVal FirstIndex As Integer, ByVal LastIndex As Integer)
        If FirstIndex < LastIndex Then
            _ContainRecursive += 1
            Dim IndexPivot As Integer = Partition(Array, FirstIndex, LastIndex)
            quicksort(Array, FirstIndex, IndexPivot - 1)
            quicksort(Array, IndexPivot + 1, LastIndex)
        End If
    End Sub

    Public Sub Print(ByRef arr As Integer())
        quicksort(arr, 0, arr.Length - 1)
        Console.Write($"\nResult: [ {String.Join(", ", arr)} ]")
        Console.WriteLine($"\nSwap: {_ContainExchange}\nParticiones: {_ContainPartition}\nRecursividad: {_ContainRecursive}")
        _ContainExchange = 0
        _ContainPartition = 0
        _ContainRecursive = 0
    End Sub

    Private Sub PrintSwap(ByRef array As Integer(), ByVal Left As Integer, ByVal Right As Integer)
        Console.Write("[ ")
        For i As Integer = 0 To array.Length - 1
            If Right = i AndAlso Left = i Then
                Console.ForegroundColor = ConsoleColor.DarkYellow
                Console.Write(array(i))
                Console.ResetColor()
            ElseIf i = Left OrElse i = Right Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(array(i))
                Console.ResetColor()
            Else
                Console.Write(array(i))
            End If
            If i < array.Length - 1 Then
                Console.Write(", ")
            End If
        Next
        Console.Write(" ]\n")
    End Sub

    Public Shared Function GenerarVector(ByVal Minon As Integer, ByVal Lenght As Integer, Optional ByVal Val As Integer = 5) As Integer()
        Dim _List As New List(Of Integer)()
        For i As Integer = Minon To Lenght - 1
            If i < Val Then
                Dim NewValor As Integer = _Random.Next(Minon, Lenght + 1)
                If _List.Contains(NewValor) Then
                    i -= 1
                    Continue For
                End If
                _List.Add(NewValor)
            Else
                Exit For
            End If
        Next
        Return _List.ToArray()
    End Function
End Class
