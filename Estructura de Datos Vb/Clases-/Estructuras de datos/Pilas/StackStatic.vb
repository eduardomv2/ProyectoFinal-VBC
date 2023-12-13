Public Class StackStatic(Of T)
    Private Elements As T()
    Public Ability As Integer
    Private Contain As Integer

    Public Sub New(ability As Integer)
        Me.Ability = ability
        Me.Elements = New T(ability - 1) {}
        Me.Contain = 0
    End Sub

    Public Sub Push(element As T)
        If Count < Ability Then
            Elements(Contain) = element
            Contain += 1
        Else
            Console.WriteLine("Stack FULL!!!")
        End If
    End Sub

    Public Function Pop() As T
        If Contain > 0 Then
            Contain -= 1
            Dim elemento As T = Elements(Contain)
            Elements(Contain) = Nothing ' Restablecer el valor a Nothing para el tipo de referencia
            Return elemento
        Else
            Console.WriteLine("Void Stack")
            Return Nothing ' Valor predeterminado para el tipo T (por ejemplo, Nothing para referencias)
        End If
    End Function

    Public Function Peek() As T
        If Contain > 0 Then
            Console.WriteLine(Elements(Contain - 1))
            Return Elements(Contain - 1)
        Else
            Console.WriteLine("Void Stack")
            Return Nothing ' Valor predeterminado para el tipo T
        End If
    End Function

    Public Sub Show(stack As StackStatic(Of T))
        If stack.Count = 0 Then
            Console.WriteLine("Void Stack")
            Return
        End If
        Console.WriteLine("=== My Stack Static ===")
        While stack.Count > 0
            Console.WriteLine(stack.Pop())
        End While
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return Contain
        End Get
    End Property
End Class
