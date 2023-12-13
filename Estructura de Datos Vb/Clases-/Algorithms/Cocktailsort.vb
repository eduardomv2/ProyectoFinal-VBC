Public Class Cocktailsort
    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr As Integer())
        Dim swapped As Boolean
        Dim start As Integer = 0
        Dim [end] As Integer = arr.Length

        Do
            ' Fase de ida (de izquierda a derecha)
            swapped = False
            For i As Integer = start To [end] - 2
                If arr(i) > arr(i + 1) Then
                    Swap(arr(i), arr(i + 1))
                    swapped = True
                End If
            Next

            If Not swapped Then
                Exit Do
            End If

            ' Disminuir el límite superior porque el elemento más grande ya está en su posición correcta
            [end] -= 1

            ' Fase de vuelta (de derecha a izquierda)
            swapped = False
            For i As Integer = [end] - 2 To start Step -1
                If arr(i) > arr(i + 1) Then
                    Swap(arr(i), arr(i + 1))
                    swapped = True
                End If
            Next

            ' Aumentar el límite inferior porque el elemento más pequeño ya está en su posición correcta
            start += 1
        Loop While swapped
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class
