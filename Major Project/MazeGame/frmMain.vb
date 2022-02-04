Imports System.Text.RegularExpressions
Imports MazeGame.MazeConstants

Public Class frmMain

    Private Sub SetupGame(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim allChecksPassed As Boolean = True

        'TODO Temporary code

        ' CheckSeed(allChecksPassed)
        ' ValidateName(allChecksPassed)
        ' CheckDifficulty(allChecksPassed)

        mazeSize = 10
        mazeSeed = 5

        If allChecksPassed Then

            GenerateMaze(Globals.arrGameBoard, Globals.mazeSeed, Globals.mazeSize)

        End If

    End Sub

    Private Sub CheckSeed(ByRef checkPassed As Boolean)

        If SeedEntered() Then

            Dim enteredSeed As String = txtMazeSeed.Text

            If ValidateSeed(enteredSeed) Then

                Globals.mazeSeed = Convert.ToUInt64(enteredSeed, 16)

            Else

                MsgBox("That seed is invalid. Please provide a 1-10 digit hexadecimal number.")

                checkPassed = False

            End If

        Else

            Dim generatedSeed As ULong = GenerateSeed()

            Globals.mazeSeed = generatedSeed

        End If

    End Sub

    Private Function SeedEntered() As Boolean

        Return Not String.IsNullOrEmpty(txtMazeSeed.Text)

    End Function

    Private Function ValidateSeed(enteredSeed As String) As Boolean

        Dim pattern As Regex = New Regex("^[0-9a-fA-F]{1,10}$")

        Return pattern.IsMatch(enteredSeed)

    End Function

    Private Function GenerateSeed() As ULong

        Dim seedRnd As New Random()

        Dim seedStr As String = ""
        Dim seedInt As ULong

        Dim i As Integer,
            currentVal As Integer,
            currentChar As Char

        For i = 1 To 10 Step 1

            currentVal = seedRnd.Next(0, 16)
            currentChar = Convert.ToString(currentVal, 16)
            seedStr = seedStr & currentChar

        Next i

        seedInt = Convert.ToUInt64(seedStr, 16)

        Return seedInt

    End Function

    Private Sub ValidateName(ByRef checkPassed As Boolean)

        Dim enteredName As String = txtName.Text

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")

        If Not validNamePattern.IsMatch(enteredName) Then

            MsgBox("That name is invalid. Please enter a string 1-16 characters, consisting of alphanumeric/underscore characters.")

            checkPassed = False

        End If

    End Sub

    Private Sub CheckDifficulty(ByRef checkPassed As Boolean)

        Dim validDifficulties As Integer() = {0, 1, 2, 3}

        If IsNothing(Globals.difficulty) Then

            checkPassed = False

        ElseIf Not validDifficulties.Contains(Globals.difficulty) Then

            checkPassed = False

        End If

    End Sub

    Private Sub GenerateMaze(arrGameBoard As Integer(,), mazeSeed As ULong, mazeSize As Integer)

        InitializeGameBoard(arrGameBoard, mazeSize)

        Dim mazeRnd As Random = New Random(mazeSeed)

        RecursePassage(arrGameBoard, (y:=0, x:=0), mazeRnd)

        For y = 0 To 9 Step 1
            Dim Str As String = ""
            For x = 0 To 9 Step 1
                Str &= arrGameBoard(y, x).ToString()
            Next
            Debug.Print(Str)
        Next

        'Debug.Print(" " & Strings.StrDup(mazeSize * 2 - 1, "_"))

        'For y = 0 To mazeSize Step 1

        '    Dim str As String = ""
        '    str &= "|"

        '    For x = 0 To mazeSize Step 1

        '        If arrGameBoard(y, x) And S <> 0 Then

        '            str += " "

        '        Else

        '            str += "_"

        '        End If

        '        If arrGameBoard(y, x) And E <> 0 Then

        '            If (arrGameBoard(y, x) Or arrGameBoard(y, x + 1)) And S <> 0 Then

        '                str += " "

        '            Else

        '                str += "_"

        '            End If

        '        Else

        '            str += "|"

        '        End If

        '    Next

        '    Debug.Print(str)

        'Next

    End Sub

    Private Sub RecursePassage(arrGameBoard As Integer(,), currentCoordinates As (y As Integer, x As Integer), mazeRnd As Random)

        Debug.Print(currentCoordinates.x & " " & currentCoordinates.y)

        Dim arrDirections As Integer() = {N, S, E, W}

        Dim cx As Integer = currentCoordinates.x
        Dim cy As Integer = currentCoordinates.y
        Dim nx As Integer = currentCoordinates.x
        Dim ny As Integer = currentCoordinates.y

        ShuffleDirections(arrDirections, mazeRnd)

        For i = 0 To 3 Step 1

            Dim direction As Integer = arrDirections(i)

            ny += Vertical(direction)
            nx += Horizontal(direction)

            Dim verticalRange As Boolean = ny >= 0 And ny < mazeSize
            Dim horizontalRange As Boolean = nx >= 0 And nx < mazeSize

            If verticalRange AndAlso horizontalRange AndAlso arrGameBoard(ny, nx) = 0 Then

                arrGameBoard(cy, cx) = arrGameBoard(cy, cx) Or direction
                arrGameBoard(ny, nx) = arrGameBoard(ny, nx) Or Opposite(direction)

                RecursePassage(arrGameBoard, (y:=ny, x:=nx), mazeRnd)

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

    Private Sub InitializeGameBoard(ByRef arrGameBoard As Integer(,), mazeSize As Integer)

        If mazeSize <> 30 Then

            ReDim arrGameBoard(mazeSize - 1, mazeSize - 1)

        End If

        For i = 0 To mazeSize - 1 Step 1
            For j = 0 To mazeSize - 1 Step 1

                arrGameBoard(i, j) = 0

            Next j
        Next i

    End Sub

End Class