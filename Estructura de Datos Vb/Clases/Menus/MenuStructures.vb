Public Class MenuStructures
    Public Name As String = "None"

    Public Shared _Information As New Information()
    Public Shared _ShowMenuStack As New MenuStack()
    Public Shared _ShowMenuQueue As New MenuQueue()
    Public Shared _ShowMenuList As New MenuList()
    Public Shared _ShowMenuTree As New MenuTree()
    Public Shared _ShowMenuGraph As New MenuGraph()

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
                Console.WriteLine("""Stack's""")
                _ShowMenuStack.CycleStack(Numer)
                Name = "None"
                Exit Select

            Case EnumDataStructures.Queues
                Console.WriteLine("""Queue's""")
                _ShowMenuQueue.CycleQueue(Numer)
                Exit Select

            Case EnumDataStructures.List
                Console.WriteLine("""List's""")
                _ShowMenuList.CycleList(Numer)
                Exit Select

            Case EnumDataStructures.Tree
                Console.WriteLine("""Tree's""")
                _ShowMenuTree.CycleTree(Numer)
                Exit Select

            Case EnumDataStructures.Graph
                Console.WriteLine("""Graph's""")
                _ShowMenuGraph.CycleGraph(Numer)
                Exit Select

            Case EnumDataStructures.Exitt
                Console.WriteLine("Good Bay :)")
                Console.ReadKey()
                Exit Select
        End Select
    End Sub
End Class
