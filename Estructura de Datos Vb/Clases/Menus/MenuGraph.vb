Public Class MenuGraph
    Public Shared Name As String = "Graph"
    Public Shared _Information As New Information()
    Public Shared _ShowMenuStructures As New MenuStructures()
    Public Shared _SubMenuDirectedGraph As New SubMenuDirectedGraph()
    Public Shared _SubMenuUndirectedGraph As New SubMenuUndirectedGraph()

    Public Shared _TypeGraph() As String = _Information.TypeGraph

    Public Sub New()
    End Sub

    Public Sub CycleGraph(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_TypeGraph, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _TypeGraph.Length
    End Sub

    Private Function Options(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumTypeGraph = CType([option], EnumTypeGraph)
        Console.Clear()
        Methos([option], x)
        Return [option]
    End Function

    Private Sub Methos([option] As Integer, Graph As EnumTypeGraph)
        Select Case Graph
            Case EnumTypeGraph.DirectedGraph
                _SubMenuDirectedGraph.Menu([option])

            Case EnumTypeGraph.UndirectedGraph
                _SubMenuUndirectedGraph.Menu([option])
        End Select
    End Sub
End Class
