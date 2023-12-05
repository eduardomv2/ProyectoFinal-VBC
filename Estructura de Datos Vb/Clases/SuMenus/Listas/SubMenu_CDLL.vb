Public Class SubMenu_CDLL
    Public Shared Name As String = "Circular Doubly Linked List"
    Private Shared _Random As New Random()
    Private Shared _Information As New Information()
    Private Shared _ShowMenuStructures As New MenuStructures()
    Private Shared _Items As New CircularDoublyLinkedList(Of Integer)()

    Private Shared _OptionList As String() = _Information.List

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
        Dim x As EnumOperationsList = DirectCast([option], EnumOperationsList)
        Console.Clear()
        Methos(x)
        Return [option]
    End Function

    Private Sub Methos(Lists As EnumOperationsList)
        Dim Data As Integer = 0
        Select Case Lists
            Case EnumOperationsList.Generate
                Console.Write("Generate: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                For i As Integer = 0 To Data - 1
                    _Items.Add(_Random.Next(100000))
                Next
                Console.WriteLine("Finish")
                Console.ReadKey()
                Exit Select

            Case EnumOperationsList.Add
                Console.Write("Insert one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Add(Data)
                Exit Select

            Case EnumOperationsList.Delete
                Console.Write("Delete one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Delete(Data)
                Exit Select

            Case EnumOperationsList.Search
                Console.Write("Search one data: ")
                Try
                    Data = Integer.Parse(Console.ReadLine())
                Catch
                End Try
                _Items.Search(Data)
                Exit Select

            Case EnumOperationsList.Show
                _Items.Show()
                Console.ReadKey()
                Exit Select

            Case EnumOperationsList.ShowRevers
                _Items.ShowRevers()
                Console.ReadKey()
                Exit Select

            Case EnumOperationsList.Clear
                _Items.Clear()
                Exit Select
        End Select
    End Sub
End Class
