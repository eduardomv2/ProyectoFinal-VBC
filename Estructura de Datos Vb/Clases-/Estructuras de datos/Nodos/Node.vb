Public Class Node(Of T)
    Implements IComparable(Of Node(Of T))

    Public Property [Next] As Node(Of T)
    Public Property Data As T

    Public Sub New(data As T)
        Me.Data = data
        [Next] = Nothing
    End Sub

    Public Function CompareTo(anotherData As Node(Of T)) As Integer Implements IComparable(Of Node(Of T)).CompareTo
        ' Caso 1: Ambos tipos son numéricos
        If IsNumer(Data) AndAlso IsNumer(anotherData.Data) Then
            Dim value1 As Long = Convert.ToInt64(Data)
            Dim value2 As Long = Convert.ToInt64(anotherData.Data)
            Return value1.CompareTo(value2)
        End If

        ' Caso 2: Solo el dato del nodo que está comparando es numérico
        If IsNumer(Data) AndAlso TypeOf anotherData.Data Is String OrElse TypeOf anotherData.Data Is Char Then
            Dim value1 As Long = Convert.ToInt64(Data)
            Dim value2 As Long = Convert.ToInt64(anotherData.Data.ToString().Length)
            Return value1.CompareTo(value2)
        End If

        ' Caso 3: Solo el dato del nodo a comparar es numérico
        If IsNumer(anotherData.Data) AndAlso TypeOf Data Is String OrElse TypeOf Data Is Char Then
            Dim value1 As Long = Convert.ToInt64(Data.ToString().Length)
            Dim value2 As Long = Convert.ToInt64(anotherData.Data)
            Return value1.CompareTo(value2)
        End If

        ' Case 4: Son diferentes tipos que se pueden comparar
        If TypeOf Data Is IComparable AndAlso TypeOf anotherData.Data Is IComparable Then
            Return DirectCast(Data.ToString().Length, IComparable).CompareTo(anotherData.Data.ToString().Length)
        End If

        Return 0
    End Function

    Private Function IsNumer(value As Object) As Boolean
        Return TypeOf value Is SByte OrElse TypeOf value Is Byte OrElse
               TypeOf value Is Short OrElse TypeOf value Is UShort OrElse
               TypeOf value Is Integer OrElse TypeOf value Is UInteger OrElse
               TypeOf value Is Long OrElse TypeOf value Is ULong OrElse
               TypeOf value Is Single OrElse TypeOf value Is Double OrElse
               TypeOf value Is Decimal
    End Function
End Class
