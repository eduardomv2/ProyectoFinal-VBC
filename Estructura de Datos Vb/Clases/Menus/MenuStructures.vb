Public Class MenuStructures
    Public Name As String = "None"

    Public Shared _Information As New Information()
    Public Shared _ShowMenuStack As New MenuStack()
    Public Shared _ShowMenuQueue As New MenuQueue()
    Public Shared _ShowMenuList As New MenuList()
    Public Shared _ShowMenuTree As New MenuTree()
    Public Shared _ShowMenuGraph As New MenuGraph()
    Public Shared _ShowAlgorithm As New MenuAlgorithm()

    Public _TypeDataStructures As String() = _Information.TypeDataStructures

    Public Sub New()
    End Sub

    Public Sub PrintArray(array As Array, Name As String)
        Console.Clear()
        Console.WriteLine(vbTab & "@Israel I22050327 Data Structures: " & Name)
        For Each item In array
            Console.WriteLine(item.ToString())
        Next
    End Sub

    Public Function [Option](data As Integer) As Integer
        Try
            data = Integer.Parse(Console.ReadLine())
        Catch
        End Try

        Dim x As EnumDataStructures = CType(data, EnumDataStructures)
        Console.Clear()
        Menu(data, x)
        Return data
    End Function

    Private Sub Menu(Numer As Integer, DataType As EnumDataStructures)
        Console.Clear()
        Select Case DataType
            Case EnumDataStructures.Stack
                _ShowMenuStack.CycleStack(Numer)
                Name = "None"
                Exit Select

            Case EnumDataStructures.Queues
                _ShowMenuQueue.CycleQueue(Numer)
                Exit Select

            Case EnumDataStructures.List
                _ShowMenuList.CycleList(Numer)
                Exit Select

            Case EnumDataStructures.Tree
                _ShowMenuTree.CycleTree(Numer)
                Exit Select

            Case EnumDataStructures.Graph
                _ShowMenuGraph.CycleGraph(Numer)
                Exit Select

            Case EnumDataStructures.Algorithm
                _ShowAlgorithm.CycleAlgorithm(Numer)
                Exit Select

            Case EnumDataStructures.Exitt
                Console.WriteLine("Good Bay :)")
                Console.ReadKey()
                Exit Select
        End Select
    End Sub
End Class
