Imports System.CodeDom.Compiler

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'iniciar richtexbox con una matriz de ejemplo'
        RichTextBox1.Text = "0,0,0,1; " & Environment.NewLine &
                            "0,0,1,0; " & Environment.NewLine &
                            "0,1,0,0; " & Environment.NewLine &
                            "1,0,0,0" 'matriz antisimetrica de ejemplo'

        'iniciar richtexbox con una matriz de ejemplo que si es antisimetrica'
        RichTextBox1.Text = "0,-1,-1; " & Environment.NewLine &
                            "1,0,-4; " & Environment.NewLine &
                            "1,4,0 " & Environment.NewLine
        'matriz antisimetrica de ejemplo'

    End Sub

    Public Function EsAntisimetrica(matriz As Array) As String
        Dim filas As Integer = matriz.GetLength(0)
        Dim columnas As Integer = matriz.GetLength(1)
        'verificar si la matriz es cuadrada'
        If filas <> columnas Then
            Return "No es cuadrada, no se puede verificar si es antisimetrica"
        End If
        'verificar si la matriz es antisimetrica'
        For i As Integer = 0 To filas - 1
            For j As Integer = 0 To columnas - 1
                If i <> j AndAlso matriz.GetValue(i, j) <> -matriz.GetValue(j, i) Then
                    Return "No es antisimetrica"
                End If
            Next
        Next
        Return "Es antisimetrica"
    End Function

    Public Function EsUnica(matriz As Array) As String
        Dim filas As Integer = matriz.GetLength(0)
        Dim columnas As Integer = matriz.GetLength(1)
        'verificar si la matriz es cuadrada'
        If filas <> columnas Then
            Return "No es cuadrada, no se puede verificar si es unica"
        End If
        'verificar si la solo hay solo 0 y 1 en la matriz'
        For i As Integer = 0 To filas - 1
            Dim suma As Double = 0
            For j As Integer = 0 To columnas - 1
                Dim valor As Double = Convert.ToDouble(matriz.GetValue(i, j))
                If valor <> 0 AndAlso valor <> 1 Then
                    Return "No es unica"
                End If
                suma += valor

            Next

            'verificar si la suma de cada fila es igual a 1'
            If suma <> 1 Then
                Return "No es unica"
            End If
            suma = 0 'reiniciar la suma para la siguiente fila
        Next
        Return "Es unica"
    End Function

    Function convertirMatriz(texto As String) As Array
        'separado  y por '
        Dim filas As String() = Split(texto, ";")
        Dim matriz As Array = Nothing
        Dim tem As String()


        For elemento As Integer = 0 To filas.Length - 1

            tem = Split(filas(elemento), ",")

            For i As Integer = 0 To tem.Length - 1

                tem(i) = tem(i).Trim() 'eliminar espacios en blanco
                ' MessageBox.Show(tem(i))
                'rellenar la matriz con los valores convertidos a double'
                If matriz Is Nothing Then
                    matriz = New Double(filas.Length - 1, tem.Length - 1) {}
                End If

                matriz.SetValue(Convert.ToDouble(tem(i)), elemento, i)



            Next

            'MessageBox.Show(matriz.ToString)

        Next

        Return matriz

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'capturar el texto del richtextbox'
        Dim texto As String = RichTextBox1.Text
        Dim matriz As Array = convertirMatriz(texto)

        'llamar a las funciones para verificar si es antisimetrica o unica'
        Dim resultadoAntisimetrica As String = EsAntisimetrica(matriz)
        Dim resultadoUnica As String = EsUnica(matriz)

        'mostrar los resultados en un messagebox'
        MessageBox.Show("Resultado de antisimetrica: " & resultadoAntisimetrica & Environment.NewLine &
                        "Resultado de unica: " & resultadoUnica, "Resultados")





    End Sub


End Class
