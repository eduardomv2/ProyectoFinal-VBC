Public Class SubMenuCircularQueue
    Public Shared Name As String = "Circular Queue"
    Public Shared ReadOnly _Random As New Random()
    Public Shared ReadOnly _Information As New Information()
    Public Shared ReadOnly _ShowMenuStructures As New MenuStructures()
    Public Shared ReadOnly _Items As New CircularQueue(20)
    Public Shared ReadOnly _OptionList As String() = _Information.Queue

    Public Sub New()
    End Sub

    Public Sub MenuOption(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_OptionList, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _OptionList.Length - 1
    End Sub

    Private Function Options([option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x = CType([option], EnumOperationsQueue)
        Console.Clear()
        Methos(x)
        Return [option]
    End Function

    Public Sub Methos(Stack As EnumOperationsQueue)
        Dim Data As Integer = 0
        Select Case Stack
            Case EnumOperationsQueue.Generate
                Console.Write("Generate: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                For i As Integer = 0 To Data - 1
                    _Items.Enqueue(_Random.Next(100000))
                Next
                Console.WriteLine("Finish")
                Console.ReadKey()
                Exit Select

            Case EnumOperationsQueue.Enqueue
                Console.WriteLine("Data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Enqueue(Data)
                Exit Select

            Case EnumOperationsQueue.Dequeue
                _Items.Dequeue()
                Exit Select

            Case EnumOperationsQueue.Show
                _Items.Show()
                Console.ReadKey()
                Exit Select

            Case EnumOperationsQueue.Clear
                _Items.Clear()
                Exit Select
        End Select
    End Sub
End Class
