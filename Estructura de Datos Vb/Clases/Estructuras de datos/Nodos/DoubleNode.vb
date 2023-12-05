Public Class DoubleNode(Of T)
    Implements IComparable(Of DoubleNode(Of T))

    Public Property Back As DoubleNode(Of T)
    Public Property [Next] As DoubleNode(Of T)
    Public Property Data As T

    Public Sub New(data As T)
        Me.Data = data
        Me.Next = Nothing
        Me.Back = Nothing
    End Sub

    Public Function CompareTo(anotherNode As DoubleNode(Of T)) As Integer Implements IComparable(Of DoubleNode(Of T)).CompareTo
        ' Case 1: Both types are numeric
        If IsNumeric(Data) AndAlso IsNumeric(anotherNode.Data) Then
            Dim value1 As Long = Convert.ToInt64(Data)
            Dim value2 As Long = Convert.ToInt64(anotherNode.Data)
            Return value1.CompareTo(value2)
        End If

        ' Case 2: Only the data of the comparing node is numeric
        If IsNumeric(Data) AndAlso (TypeOf anotherNode.Data Is String OrElse TypeOf anotherNode.Data Is Char) Then
            Dim value1 As Long = Convert.ToInt64(Data)
            Dim value2 As Long = Convert.ToInt64(anotherNode.Data.ToString().Length)
            Return value1.CompareTo(value2)
        End If

        ' Case 3: Only the data of the node to compare is numeric
        If IsNumeric(anotherNode.Data) AndAlso (TypeOf Data Is String OrElse TypeOf Data Is Char) Then
            Dim value1 As Long = Convert.ToInt64(Data.ToString().Length)
            Dim value2 As Long = Convert.ToInt64(anotherNode.Data)
            Return value1.CompareTo(value2)
        End If

        ' Case 4: They are different types that can be compared
        If TypeOf Data Is IComparable AndAlso TypeOf anotherNode.Data Is IComparable Then
            Return DirectCast(Data, IComparable).ToString().Length.CompareTo(DirectCast(anotherNode.Data, IComparable).ToString().Length)
        End If

        Return 0
    End Function

    Public Function CompareTo(anotherData As T) As Integer
        ' Case 1: Both types are numeric
        If IsNumeric(Data) AndAlso IsNumeric(anotherData) Then
            Dim value1 As Long = Convert.ToInt64(Data)
            Dim value2 As Long = Convert.ToInt64(anotherData)
            Return value1.CompareTo(value2)
        End If

        ' Case 2: Only the data of the comparing node is numeric
        If IsNumeric(Data) AndAlso (TypeOf anotherData Is String OrElse TypeOf anotherData Is Char) Then
            Dim value1 As Long = Convert.ToInt64(Data)
            Dim value2 As Long = Convert.ToInt64(anotherData.ToString().Length)
            Return value1.CompareTo(value2)
        End If

        ' Case 3: Only the data of the node to compare is numeric
        If IsNumeric(anotherData) AndAlso (TypeOf Data Is String OrElse TypeOf Data Is Char) Then
            Dim value1 As Long = Convert.ToInt64(Data.ToString().Length)
            Dim value2 As Long = Convert.ToInt64(anotherData)
            Return value1.CompareTo(value2)
        End If

        ' Case 4: They are different types that can be compared
        If TypeOf Data Is IComparable AndAlso TypeOf anotherData Is IComparable Then
            Return DirectCast(Data, IComparable).ToString().Length.CompareTo(DirectCast(anotherData, IComparable).ToString().Length)
        End If

        Return 0
    End Function

    Private Function IsNumeric(value As Object) As Boolean
        Return TypeOf value Is SByte OrElse TypeOf value Is Byte OrElse TypeOf value Is Short OrElse TypeOf value Is UShort OrElse
               TypeOf value Is Integer OrElse TypeOf value Is UInteger OrElse TypeOf value Is Long OrElse TypeOf value Is ULong OrElse
               TypeOf value Is Single OrElse TypeOf value Is Double OrElse TypeOf value Is Decimal
    End Function
End Class
