Public Class MenuStack
    Public Shared Name As String = "Stack"

    Public Shared _Information As New Information()
    Public Shared _ShowMenuStructures As New MenuStructures()
    Public Shared _ShowSubMenuStackS As New SubMenuStackS()
    Public Shared _ShowSubMenuStackD As New SubMenuStackD()

    Public Shared _TypeStack() As String = _Information.TypeStack

    Public Sub New()
    End Sub

    Public Sub CycleStack(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_TypeStack, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _TypeStack.Length
    End Sub

    Private Function Options(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumTypeStack = CType([option], EnumTypeStack)
        Console.Clear()
        Menu([option], x)
        Return [option]
    End Function

    Private Sub Menu(Numer As Integer, Stacks As EnumTypeStack)
        Select Case Stacks
            Case EnumTypeStack.StackStatic
                _ShowSubMenuStackS.MenuOption(Numer)
            Case EnumTypeStack.StackDinamic
                _ShowSubMenuStackD.MenuOption(Numer)
        End Select
    End Sub
End Class
