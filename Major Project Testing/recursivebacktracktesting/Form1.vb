Public Class Form1

    Dim N = 1
    Dim E = 2
    Dim W = 4
    Dim S = 8

    'Dim Vertical = New Dictionary(Of Integer, Integer) From {
    '    {N, 1}, {E, 0}, {S, -1}, {W, 0}
    '}

    'Dim Horizontal = New Dictionary(Of Integer, Integer) From {
    '    {N, 0}, {E, 1}, {S, 0}, {W, -1}
    '}

    Dim Vertical = New Dictionary(Of Integer, Integer) From {
        {N, -1}, {E, 0}, {S, 1}, {W, 0}
    }

    Dim Horizontal = New Dictionary(Of Integer, Integer) From {
        {N, 0}, {E, 1}, {S, 0}, {W, -1}
    }

    Dim Opposite = New Dictionary(Of Integer, Integer) From {
        {N, S}, {E, W}, {S, N}, {W, E}
    }

    Dim mazeSize = 10

    Private Sub InitializeGameBoard(ByRef arr As Integer(,))

        ' Mazesize 10

        ReDim arr(9, 9)

        For i = 0 To 9 Step 1
            For j = 0 To 9 Step 1
                arr(i, j) = 0
            Next j
        Next i

    End Sub
    Private Sub GenerateMaze(arrGameBoard As Integer(,), mazeSeed As ULong, mazeSize As Integer)

        InitializeGameBoard(arrGameBoard)

        Dim mazeRnd As Random = New Random(mazeSeed)

        RecursePassage(arrGameBoard, 0, 0, mazeRnd)

        'For y = 0 To 9 Step 1
        '    Dim Str As String = ""
        '    For x = 0 To 9 Step 1
        '        Str &= arrGameBoard(y, x).ToString("X1")
        '    Next
        '    Debug.Print(Str)
        'Next

        Debug.Print(" " & Strings.StrDup(mazeSize * 2 - 1, "_"))
        For y = 0 To mazeSize - 1 Step 1
            Dim str As String = ""
            str &= "|"
            For x = 0 To mazeSize - 1 Step 1
                If arrGameBoard(y, x) And S <> 0 Then
                    str += " "
                Else
                    str += "_"
                End If
                If arrGameBoard(y, x) And E <> 0 Then
                    If x < 9 AndAlso (arrGameBoard(y, x) Or arrGameBoard(y, x + 1)) And S <> 0 Then
                        str += " "
                    Else
                        str += "_"
                    End If
                Else
                    str += "|"
                End If
            Next
            Debug.Print(str)
        Next

    End Sub

    Private Sub RecursePassage(arrGameBoard As Integer(,), cy As Integer, cx As Integer, mazeRnd As Random)

        Debug.Print("cy cx " & cx & " " & cy)

        Dim arrDirections As Integer() = {N, S, E, W}

        Dim nx As Integer
        Dim ny As Integer

        ShuffleDirections(arrDirections, mazeRnd)

        Debug.Print("order of directions: " & String.Join(",", arrDirections))

        For i = 0 To 3 Step 1

            nx = cx
            ny = cy

            Dim direction As Integer = arrDirections(i)

            'ny += Vertical(direction)
            'nx += Horizontal(direction)

            Select Case direction
                Case N
                    ny -= 1
                Case E
                    nx += 1
                Case S
                    ny += 1
                Case W
                    nx -= 1
            End Select

            Dim verticalRange As Boolean = ny >= 0 And ny < mazeSize
            Dim horizontalRange As Boolean = nx >= 0 And nx < mazeSize

            Debug.Print("ny nx " & ny & " " & nx)

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arr(9, 9) As Integer
        Dim seed = 3
        Dim size = 10

        GenerateMaze(arr, seed, size)

    End Sub
End Class
