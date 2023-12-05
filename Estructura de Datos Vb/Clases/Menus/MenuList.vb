Public Class MenuList
    Public Shared Name As String = "List"

    Public Shared _Information As Information = New Information()
    Public Shared _ShowMenuStructures As MenuStructures = New MenuStructures()
    Public Shared _ShowSubMenu_SL As New SubMenu_SL()
    Public Shared _ShowSubMenu_CL As New SubMenu_CL()
    Public Shared _ShowSubMenu_DLL As New SubMenu_DLL()
    Public Shared _ShowSubMenu_CDLL As New SubMenu_CDLL()

    Public _TypeList As String() = _Information.TypeList
    Public Shared _OptionList As String() = _Information.List

    Public Sub New()
    End Sub

    Public Sub CycleList(ByRef Operation As Integer)
        Do
            Operation = 0
            _ShowMenuStructures.PrintArray(_TypeList, Name)
            Console.Write("Select one option: ")
            Operation = Options(Operation)
        Loop While Operation <> _TypeList.Length
        Return
    End Sub

    Private Function Options(ByRef [option] As Integer) As Integer
        Try
            [option] = Integer.Parse(Console.ReadLine())
        Catch
        End Try
        Dim x As EnumTypeList = CType([option], EnumTypeList)
        Console.Clear()
        Menu([option], x)
        Return [option]
    End Function

    Private Sub Menu(ByVal Numer As Integer, ByVal Lists As EnumTypeList)
        Select Case Lists
            Case EnumTypeList.SimpleList
                _ShowSubMenu_SL.MenuOption(Numer)
            Case EnumTypeList.CircularList
                _ShowSubMenu_CL.MenuOption(Numer)
            Case EnumTypeList.DoubleLinkdeList
                _ShowSubMenu_DLL.MenuOption(Numer)
            Case EnumTypeList.CircularDoubleLinkedList
                _ShowSubMenu_CDLL.MenuOption(Numer)
        End Select
    End Sub
End Class
