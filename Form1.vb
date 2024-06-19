Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Load
        dtvMatriz.ColumnCount = 5
        dtvMatriz.Rows.Add(5)
        For i = 0 To 4
            dtvMatriz.Columns(i).Width = 50
        Next
        dtvDiagonal.ColumnCount = 5
        dtvDiagonal.Rows.Add(1)
        For i = 0 To 4
            dtvDiagonal.Columns(i).Width = 50
        Next

        dtvContraDiagonal.ColumnCount = 5
        dtvContraDiagonal.Rows.Add(1)
        For i = 0 To 4
            dtvContraDiagonal.Columns(i).Width = 50

        Next


    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim Matriz(0 To 4, 0 To 4)
        Dim Diagonal(0 To 4) As Integer
        Dim ContraDiagonal(0 To 4) As Integer



        For f = 0 To 4
            For c = 0 To 4
                Matriz(f, c) = dtvMatriz.Item(f, c).Value
                Diagonal(c) = Matriz(c, c)
                ContraDiagonal(c) = Matriz(c, 4 - c)



            Next

        Next
        For f = 0 To 4
            For c = 0 To 4
                dtvDiagonal.Item(c, 0).Value = Diagonal(c)
                dtvContraDiagonal.Item(c, 0).Value = ContraDiagonal(c)

            Next
        Next








    End Sub
End Class
