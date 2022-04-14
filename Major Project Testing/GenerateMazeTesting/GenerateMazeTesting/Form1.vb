Public Class Form1

    Const N As Integer = 1, E As Integer = 2, S As Integer = 4, W As Integer = 8

    Public Horizontal = New Dictionary(Of Integer, Integer) From {
        {N, 0}, {S, 0}, {E, 1}, {W, -1}
    }

    Public Vertical = New Dictionary(Of Integer, Integer) From {
        {N, -1}, {S, 1}, {E, 0}, {W, 0}
    }

    Public Opposite = New Dictionary(Of Integer, Integer) From {
        {N, S}, {S, N}, {E, W}, {W, E}
    }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim difficulty As Integer = 1
        Dim mazeSize%

        If difficulty = 4 Then
            mazeSize = New Random().Next(0, 3)
        Else
            mazeSize = difficulty - 1
        End If

        Dim mazeSeed As ULong = 3

        Dim arrGameBoard((mazeSize + 1) * 10 - 1, (mazeSize + 1) * 10 - 1) As Integer

        InitializeGameBoard(arrGameBoard, mazeSize)

        GenerateMaze(arrGameBoard, mazeSeed, mazeSize)

    End Sub

    Private Sub GenerateMaze(arrGameBoard As Integer(,), mazeSeed As ULong, mazeSize As Integer)

        InitializeGameBoard(arrGameBoard, mazeSize)

        Dim mazeRnd As New Random(mazeSeed Mod (Integer.MaxValue))

        RecursePassage(arrGameBoard, 0, 0, mazeRnd)

        Dim edgeLength As Integer = (mazeSize + 1) * 10

        Debug.Print(edgeLength)

        For i = 0 To edgeLength - 1 Step 1
            Dim s As String = ""
            For j = 0 To edgeLength - 1 Step 1
                s += arrGameBoard(i, j).ToString("X1")
            Next
            Debug.Print(s)
        Next

        ' All printing code here

        ' This prints the line of '_' characters along the top (the single space offset is because of the pipe characters on the left of the maze)

        Debug.Print(" " & StrDup((edgeLength * 2) - 1, "_"))

        ' The variable that will be storing each line

        Dim str$

        For r = 0 To edgeLength - 1 Step 1

            str = "|"

            For c = 0 To edgeLength - 1 Step 1

                ' If the southern wall is closed, then insert a _, otherwise insert a space.

                If (arrGameBoard(r, c) And S) = 0 Then

                    str &= "_"

                Else

                    str &= " "

                End If

                ' Similarly, if the eastern wall is closed, insert a |, otherwise insert a space.

                If (arrGameBoard(r, c) And E) = 0 Then

                    str &= "|"

                ElseIf ((arrGameBoard(r, c) Or arrGameBoard(r, c + 1)) And S) = 0 Then

                    str &= "_"

                Else

                    str &= " "

                End If

            Next c

            Debug.Print(str)

        Next r

    End Sub

    Private Sub RecursePassage(arrGameBoard As Integer(,), cy As Integer, cx As Integer, mazeRnd As Random)

        Dim arrDirections As Integer() = {N, S, E, W}

        Dim nx As Integer
        Dim ny As Integer

        ShuffleDirections(arrDirections, mazeRnd)

        For i = 0 To 3 Step 1

            nx = cx
            ny = cy

            Dim direction As Integer = arrDirections(i)

            ny += Vertical(direction)
            nx += Horizontal(direction)

            Dim verticalRange As Boolean = ny >= 0 And ny < arrGameBoard.GetLength(0)
            Dim horizontalRange As Boolean = nx >= 0 And nx < arrGameBoard.GetLength(1)

            If verticalRange AndAlso horizontalRange AndAlso arrGameBoard(ny, nx) = 0 Then

                arrGameBoard(cy, cx) = arrGameBoard(cy, cx) Or direction
                arrGameBoard(ny, nx) = arrGameBoard(ny, nx) Or Opposite(direction)

                RecursePassage(arrGameBoard, ny, nx, mazeRnd)

            End If

        Next i

    End Sub

    Private Sub ShuffleDirections(ByRef arrDirections As Integer(), ByRef rndShuffle As Random)

        Dim temp As Integer
        Dim j As Integer

        For i = 3 To 0 Step -1

            j = rndShuffle.Next(i + 1)

            temp = arrDirections(i)
            arrDirections(i) = arrDirections(j)
            arrDirections(j) = temp

        Next i

    End Sub

    Private Sub InitializeGameBoard(ByRef arrGameBoard As Integer(,), ByVal mazeSize As Integer)

        For row = 0 To arrGameBoard.GetLength(0) - 1
            For column = 0 To arrGameBoard.GetLength(1) - 1
                arrGameBoard(row, column) = 0
            Next column
        Next row

    End Sub

End Class