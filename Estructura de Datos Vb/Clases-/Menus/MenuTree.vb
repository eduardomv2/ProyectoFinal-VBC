Public Class MenuTree
    Public Shared Name As String = "Tree"
    Public Shared _Information As New Information()
    Public Shared _ShowMenuStructures As New MenuStructures()
    Public Shared _Items As New BinaryTree()

    Public Shared _OptionTree() As String = _Information.Tree

    Public Sub New()
    End Sub

    Public Sub CycleTree(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_OptionTree, Name)
            Console.Write("Select one option: ")
            Operation = OptionTree(Operation)
        Loop While Operation <> _OptionTree.Length
    End Sub

    Public Function OptionTree(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumOperationsTree = CType([option], EnumOperationsTree)
        Console.Clear()
        MethosTree(x)
        Return [option]
    End Function

    Public Sub MethosTree(Tree As EnumOperationsTree)
        Dim Data As Integer = 0
        Select Case Tree
            Case EnumOperationsTree.Add
                Console.Write("Insert one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Add(Data)

            Case EnumOperationsTree.Delete
                Console.Write("Delete one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Delete(Data)

            Case EnumOperationsTree.Search
                Console.Write("Insert one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Search(Data)

            Case EnumOperationsTree.InOrder
                _Items.InOrden()
                Console.ReadKey()

            Case EnumOperationsTree.PosOrder
                _Items.PostOrden()
                Console.ReadKey()

            Case EnumOperationsTree.PreOrder
                _Items.PreOrden()
                Console.ReadKey()
        End Select
    End Sub
End Class
