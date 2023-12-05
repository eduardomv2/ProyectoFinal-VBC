Public Class SubMenuStackD
    Public Shared Name As String = "Dinamic Stack"

    Public Shared _Random As New Random()
    Public Shared _Information As New Information()
    Public Shared _ShowMenuStructures As New MenuStructures()
    Public Shared _Items As New StackDinamic(Of Integer)()

    Public Shared _OptionList() As String = _Information.Stack

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

    Private Function Options(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumOperationsStack = CType([option], EnumOperationsStack)
        Console.Clear()
        Methos(x)
        Return [option]
    End Function

    Public Sub Methos(Stack As EnumOperationsStack)
        Dim Data As Integer = 0
        Select Case Stack
            Case EnumOperationsStack.Generate
                Console.Write("Generate: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                For i As Integer = 0 To Data - 1
                    _Items.Push(_Random.Next(100000))
                Next
                Console.WriteLine("Finish")
                Console.ReadKey()

            Case EnumOperationsStack.Push
                Console.WriteLine("Insert one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Push(Data)

            Case EnumOperationsStack.Pop
                _Items.Pop()

            Case EnumOperationsStack.Peek
                Console.WriteLine("Peek")
                _Items.Peek()
                Console.ReadKey()

            Case EnumOperationsStack.Contains
                Console.Write("Contains: " & _Items.Count)
                Console.ReadKey()

            Case EnumOperationsStack.Show
                _Items.Show(_Items)
                Console.ReadKey()
        End Select
    End Sub
End Class
