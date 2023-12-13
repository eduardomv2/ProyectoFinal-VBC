Friend Class BinarytreeNode
    Public Value As Integer
    Public Left, Right As BinarytreeNode

    Public Sub New(ByVal value As Integer)
        Me.Value = value
        Left = Nothing
        Right = Nothing
    End Sub
End Class

Public Class Binarytreesort
    Private root As BinarytreeNode

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr As Integer())
        ' Construir el árbol binario
        For Each value In arr
            root = Insert(root, value)
        Next

        ' Recorrer el árbol en orden para obtener los elementos ordenados
        Dim index As Integer = 0
        InOrderTraversal(root, arr, index)
    End Sub

    Private Function Insert(ByVal node As BinarytreeNode, ByVal value As Integer) As BinarytreeNode
        If node Is Nothing Then
            Return New BinarytreeNode(value)
        End If

        If value < node.Value Then
            node.Left = Insert(node.Left, value)
        ElseIf value > node.Value Then
            node.Right = Insert(node.Right, value)
        End If

        Return node
    End Function

    Private Sub InOrderTraversal(ByVal node As BinarytreeNode, ByVal arr As Integer(), ByRef index As Integer)
        If node IsNot Nothing Then
            InOrderTraversal(node.Left, arr, index)
            arr(index) = node.Value
            index += 1
            InOrderTraversal(node.Right, arr, index)
        End If
    End Sub
End Class
