Module Program
    Sub Main(args As String())
        Dim [option] As Integer
        Dim Menu As New MenuStructures()
        Do
            [option] = 0
            Menu.PrintArray(Menu._TypeDataStructures, Menu.Name)
            Console.Write("Write the number of the option: ")
            [option] = Menu.Option([option])
        Loop While [option] <> 7
    End Sub
End Module
