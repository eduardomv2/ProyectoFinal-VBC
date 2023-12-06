Public Class Shellsort
    Public Sub New()
    End Sub

    Public Sub ShellSort(ByVal array As Integer())
        ' Se obtiene la longitud del array
        Dim n As Integer = array.Length
        ' Se obtiene el tamaño de espacio entre elementos
        Dim gap As Integer = n \ 2

        Console.WriteLine(vbLf & "Inicio del algoritmo Shell Sort:")

        ' Mientras el espacio entre elementos sea mayor que 0
        While gap > 0
            Console.WriteLine($"{vbLf}Gap actual: {gap}")

            ' Aplicar el algoritmo de inserción para cada "subarray" con el tamaño de gap
            For i As Integer = gap To n - 1
                ' Guardar el valor actual del elemento en una variable temporal
                Dim temp As Integer = array(i)
                Dim j As Integer = i

                Console.WriteLine($"{vbLf}Comparando {temp} con los elementos en su subarray:")

                ' Realizar la inserción
                While j >= gap AndAlso array(j - gap) > temp
                    ' Desplazar elementos hacia la derecha hasta encontrar la posición correcta
                    array(j) = array(j - gap)
                    j -= gap

                    PrintArray(array)
                End While

                ' Colocar el valor temporal en la posición correcta en el subarray
                array(j) = temp
                Console.WriteLine($"Insertar {temp} en la posición {j} del subarray:")
                PrintArray(array)
            Next

            ' Reducir el espacio entre elementos a la mitad en cada iteración
            gap \= 2
        End While

        Console.WriteLine($"{vbLf}Fin del algoritmo Shell Sort:")
    End Sub

    Private Sub PrintArray(ByVal array As Integer())
        For Each num As Integer In array
            Console.Write(num & " ")
        Next
        Console.WriteLine()
    End Sub
End Class
