Friend Class Nodo
    Public Property Left As Nodo
    Public Property Right As Nodo
    Public Property Data As Integer

    Public Sub New(valor As Integer)
        Me.Data = valor
        Left = Nothing
        Right = Nothing
    End Sub
End Class

Public Class BinaryTree
    Private Property Root As Nodo

    Public Sub New()
        Root = Nothing
    End Sub

    Public Sub Add(valor As Integer)
        Root = _Add(Root, valor)
    End Sub

    Public Sub Delete(valor As Integer)
        Root = _Delete(Root, valor)
    End Sub

    Public Function Search(valor As Integer) As Boolean
        Return _Search(Root, valor)
    End Function

    Public Sub PreOrden()
        _PreOrden(Root)
        Console.WriteLine()
    End Sub

    Public Sub PostOrden()
        _PostOrder(Root)
        Console.WriteLine()
    End Sub

    Public Sub InOrden()
        _InOrder(Root)
        Console.WriteLine()
    End Sub

    Private Function _Add(nodo As Nodo, valor As Integer) As Nodo
        If nodo Is Nothing Then
            Return New Nodo(valor)
        End If

        If valor < nodo.Data Then
            nodo.Left = _Add(nodo.Left, valor)
        ElseIf valor > nodo.Data Then
            nodo.Right = _Add(nodo.Right, valor)
        End If
        Return nodo
    End Function

    Private Function _Delete(nodo As Nodo, valor As Integer) As Nodo
        If nodo Is Nothing Then
            Return nodo
        End If
        If valor < nodo.Data Then
            nodo.Left = _Delete(nodo.Left, valor)
        ElseIf valor > nodo.Data Then
            nodo.Right = _Delete(nodo.Right, valor)
        Else
            If nodo.Left Is Nothing Then
                Return nodo.Right
            ElseIf nodo.Right Is Nothing Then
                Return nodo.Left
            End If
            nodo.Data = MinValue(nodo.Right)
            nodo.Right = _Delete(nodo.Right, nodo.Data)
        End If
        Return nodo
    End Function

    Private Function MinValue(nodo As Nodo) As Integer
        Dim min As Integer = nodo.Data
        While nodo.Left IsNot Nothing
            min = nodo.Left.Data
            nodo = nodo.Left
        End While
        Return min
    End Function

    Private Function _Search(nodo As Nodo, valor As Integer) As Boolean
        If nodo Is Nothing Then
            Return False
        End If

        If valor = nodo.Data Then
            Return True
        End If

        If valor < nodo.Data Then
            Return _Search(nodo.Left, valor)
        Else
            Return _Search(nodo.Right, valor)
        End If
    End Function

    Private Sub _PreOrden(Tree As Nodo)
        If Tree IsNot Nothing Then
            Console.Write(Tree.Data & " ")
            _PreOrden(Tree.Left)
            _PreOrden(Tree.Right)
        End If
    End Sub

    Private Sub _PostOrder(Tree As Nodo)
        If Tree IsNot Nothing Then
            _PostOrder(Tree.Left)
            _PostOrder(Tree.Right)
            Console.Write(Tree.Data & " ")
        End If
    End Sub

    Private Sub _InOrder(Tree As Nodo)
        If Tree IsNot Nothing Then
            _InOrder(Tree.Left)
            Console.Write(Tree.Data & " ")
            _InOrder(Tree.Right)
        End If
    End Sub
End Class
