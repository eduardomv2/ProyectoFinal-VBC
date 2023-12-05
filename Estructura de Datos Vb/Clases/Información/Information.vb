Public Enum EnumDataStructures
    None
    Stack
    Queues
    List
    Tree
    Graph
    Exitt
End Enum

#Region "Types"
Public Enum EnumTypeStack
    None
    StackStatic
    StackDinamic
End Enum

Public Enum EnumTypeQueue
    None
    Queue
    CircularQueue
    PriorityQueues
End Enum

Public Enum EnumTypeList
    None
    SimpleList
    CircularList
    DoubleLinkdeList
    CircularDoubleLinkedList
End Enum

Public Enum EnumTypeGraph
    None
    DirectedGraph
    UndirectedGraph
End Enum
#End Region

#Region "Operations"
Public Enum EnumOperationsStack
    Generate
    Push
    Pop
    Peek
    Contains
    Show
End Enum

Public Enum EnumOperationsQueue
    Generate
    Enqueue
    Dequeue
    Show
    Clear
End Enum

Public Enum EnumOperationsList
    Generate
    Add
    Delete
    Search
    Show
    ShowRevers
    Clear
End Enum

Public Enum EnumOperationsTree
    None
    Add
    Delete
    Search
    InOrder
    PosOrder
    PreOrder
End Enum

Public Enum EnumOperationsGraph
    None
    AddVertex
    AddEdge
    RemoveVertex
    RemoveEdge
    ExistVertex
    ExistEdge
    GetAllVertex
    GetAllEdge
    Transverse
    CalculateDegree
    CalculateBFSLevels
End Enum
#End Region

Public Class Information
    Public TypeDataStructures() As String = {"[1]Stack", "[2]Queues", "[3]List", "[4]Tree", "[5]Graph", "[6]Exit"}

#Region "Types"
    Public TypeStack() As String = {"[1]StackStatic", "[2]StackDinamic", "[3]Exit"}

    Public TypeQueue() As String = {"[1]Queue", "[2]CircularQueue", "[3]PriorityQueues", "[4]Exit"}

    Public TypeList() As String = {"[1]SimpleList", "[2]CircularList", "[3]DoubleLikedList", "[4]CirculasDoubleLikedList", "[5]Exit"}

    Public TypeGraph() As String = {"[1]DirectedGraph", "[2]UnidirectedGraph", "[3]Exit"}
#End Region

#Region "Operations"
    Public Stack() As String = {"[0]Geneate", "[1]Push", "[2]Pop", "[3]Peek", "[4]Contains", "[5]Show", "[6]Exit"}

    Public Queue() As String = {"[0]Geneate", "[1]Enqueue", "[2]Dequeue", "[3]Show", "[4]Clear", "[5]Exit"}

    Public List() As String = {"[0]Geneate", "[1]Add", "[2]Delete", "[3]Search", "[4]Show", "[5]Show revers", "[6]Clear", "[7]Exit"}

    Public Tree() As String = {"[1]Add", "[2]Delete", "[3]Search", "[4]InOrder", "[5]PostOrder", "[6]PreOrder", "[7]Exit"}

    Public Graph() As String = {"[1]Add Vertex", "[2]Add Edge", "[3]Remove Vertex", "[4]Remove Edge", "[5]Exist Vertex", "[6]Exist Edge", "[7]Get All Vertex", "[8]Get All Edge", "[9]Transverse", "[10]Calculate Degree", "[11]Calculate BFS Levels", "[12]Exit"}
#End Region

    Public Sub New()
    End Sub
End Class

