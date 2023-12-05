Public Class SubMenuUndirectedGraph
    Public Shared Name As String = "Undirected Graph"

    Public Shared _Information As New Information()
    Public Shared _ShowMenuStructures As New MenuStructures()
    Public Shared _Items As New UndirectedGraph(Of Integer)()

    Public Shared _Option() As String = _Information.Graph

    Public Sub New()
    End Sub

    Public Sub Menu(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_Option, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _Option.Length
    End Sub

    Private Function Options(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumOperationsGraph = CType([option], EnumOperationsGraph)
        Console.Clear()
        Methods(x)
        Return [option]
    End Function

    Private Sub Methods(Stack As EnumOperationsGraph)
        Dim DataF As Integer = 0, DataS As Integer = 0
        Select Case Stack
            Case EnumOperationsGraph.AddVertex
                Console.WriteLine("Insert One data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.AddVertex(DataF)

            Case EnumOperationsGraph.AddEdge
                Console.WriteLine("Insert First data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                Console.WriteLine("Insert Second data: ")
                Try
                    DataS = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.AddEdge(DataF, DataS)

            Case EnumOperationsGraph.RemoveVertex
                Console.WriteLine("Insert One data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.RemoveVertex(DataF)

            Case EnumOperationsGraph.RemoveEdge
                Console.WriteLine("Insert First data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                Console.WriteLine("Insert Second data: ")
                Try
                    DataS = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.RemoveEdge(DataF, DataS)

            Case EnumOperationsGraph.ExistVertex
                Console.WriteLine("Insert One data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.VertexExists(DataF)
                Console.ReadKey()

            Case EnumOperationsGraph.ExistEdge
                Console.WriteLine("Insert First data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                Console.WriteLine("Insert Second data: ")
                Try
                    DataS = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.EdgeExists(DataF, DataS)
                Console.ReadKey()

            Case EnumOperationsGraph.GetAllVertex
                Console.WriteLine("Get All Vertices")
                _Items.GetAllVertices()
                Console.ReadKey()

            Case EnumOperationsGraph.GetAllEdge
                Console.WriteLine("Get All Edges")
                _Items.GetAllEdges()
                Console.ReadKey()

            Case EnumOperationsGraph.Transverse
                Console.WriteLine("Insert One data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.TraverseBFS(DataF)
                Console.ReadKey()

            Case EnumOperationsGraph.CalculateDegree
                Console.WriteLine("Insert One data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.CalculateDegree(DataF)
                Console.ReadKey()

            Case EnumOperationsGraph.CalculateBFSLevels
                Console.WriteLine("Insert One data: ")
                Try
                    DataF = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.CalculateBFSLevels(DataF)
                Console.ReadKey()
        End Select
    End Sub
End Class
