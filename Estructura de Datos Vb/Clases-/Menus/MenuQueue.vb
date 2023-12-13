Public Class MenuQueue
    Public Shared Name As String = "Queue"
    Private Shared _Information As New Information()
    Private Shared _ShowMenuStructures As New MenuStructures()
    Private Shared _SubMenuQueue As New SubMenuQueue()
    Private Shared _SubMenuCircular As New SubMenuCircularQueue()
    Private Shared _SubMenuPriorityQueue As New SubMenuPriorityQueue()

    Private Shared _TypeQueue As String() = _Information.TypeQueue

    Public Sub New()
    End Sub

    Public Sub CycleQueue(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_TypeQueue, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _TypeQueue.Length
    End Sub

    Private Function Options([option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumTypeQueue = DirectCast([option], EnumTypeQueue)
        Console.Clear()
        Menu([option], x)
        Return [option]
    End Function

    Private Sub Menu(Numer As Integer, Stacks As EnumTypeQueue)
        Select Case Stacks
            Case EnumTypeQueue.Queue
                _SubMenuQueue.MenuOption(Numer)
                Exit Select

            Case EnumTypeQueue.CircularQueue
                _SubMenuCircular.MenuOption(Numer)
                Exit Select

            Case EnumTypeQueue.PriorityQueues
                _SubMenuPriorityQueue.MenuOption(Numer)
                Exit Select
        End Select
    End Sub
End Class
