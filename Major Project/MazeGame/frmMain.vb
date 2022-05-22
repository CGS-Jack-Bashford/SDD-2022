Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmMain

    Private Sub SetupForm(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown

        configureFrmMain()

        LoadHighscoresFromFile(arrHighscores)

        ' Setup all of the handlers for the difficulty buttons

        Dim arrDifficultyButtons As Button() = {btnMazeSize10, btnMazeSize10Back, btnMazeSize20, btnMazeSize20Back, btnMazeSize30, btnMazeSize30Back, btnMazeSizeRandom, btnMazeSizeRandomBack}

        For i = 0 To arrDifficultyButtons.Length - 1 Step 1
            AddHandler arrDifficultyButtons(i).Click, AddressOf ChangeDifficultyHandlerBtn
        Next i

        Dim arrDifficultyLabels As Label() = {lblMazeSize10, lblMazeSize20, lblMazeSizeRandom, lblMazeSize30}

        For i = 0 To arrDifficultyLabels.Length - 1 Step 1
            AddHandler arrDifficultyLabels(i).Click, AddressOf ChangeDifficultyHandlerLbl
        Next i

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

        txtName.Text = ""
        txtMazeSeed.Text = ""

    End Sub

    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    Private Sub LoadHighscoresFromFile(ByRef arrHighscores As Highscore()())

        arrHighscores(0) = New Highscore() {}
        arrHighscores(1) = New Highscore() {}
        arrHighscores(2) = New Highscore() {}

        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "highscores.txt") Then

            Dim fs As FileStream = File.Create(Application.StartupPath & "highscores.txt")

            Dim sentinel As Byte() = New UTF8Encoding(True).GetBytes("9999")
            fs.Write(sentinel, 0, sentinel.Length)

            fs.Close()

        End If

        FileOpen(1, "highscores.txt", OpenMode.Input)

        Dim rawLine As String
        Dim scoreComponents As String()
        Dim currentHighscore As Highscore = New Highscore()

        If EOF(1) Then

            FileClose(1)

            FileOpen(2, "highscores.txt", OpenMode.Output)
            PrintLine(2, "9999")
            FileClose(2)

            FileOpen(1, "highscores.txt", OpenMode.Input)

        End If

        Input(1, rawLine)

        rawLine = rawLine.Trim()

        While rawLine <> "9999"

            scoreComponents = rawLine.Split(New Char() {";"c})

            currentHighscore.mazeSize = scoreComponents(0)
            currentHighscore.gameTime = scoreComponents(1)
            currentHighscore.playerName = scoreComponents(2)
            currentHighscore.mazeSeed = Convert.ToUInt64(scoreComponents(3), 16)

            ReDim Preserve arrHighscores(currentHighscore.mazeSize)(arrHighscores(currentHighscore.mazeSize).Length)
            arrHighscores(currentHighscore.mazeSize)(arrHighscores(currentHighscore.mazeSize).Length - 1) = currentHighscore

            Input(1, rawLine)

            rawLine = rawLine.Trim()

        End While

        FileClose(1)

        For sizeToSort = 0 To 2 Step 1

            SortHighscores(arrHighscores, sizeToSort)

        Next sizetosort

    End Sub

    Private Sub frmMain_Close(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    Private Sub SetupGame(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim allChecksPassed As Boolean = True

        Dim seedCheckPassed As Boolean = CheckSeed(allChecksPassed)
        Dim nameCheckPassed As Boolean = ValidateName(allChecksPassed)
        CheckDifficulty(allChecksPassed)

        If Not seedCheckPassed Then

            MsgBox("That seed is invalid. Please provide a 1-10 digit hexadecimal (0-9, A-F) number.")

        End If

        If Not nameCheckPassed Then
            MsgBox("That name is invalid. Please enter a string 1-16 characters, consisting of alphanumeric/underscore characters.")

        End If

        allChecksPassed = allChecksPassed And seedCheckPassed And nameCheckPassed

        If allChecksPassed Then

            GenerateMaze(Globals.arrGameBoard, mazeSeed, mazeSize)

            frmGame.Show()

            If frmHighscores.Visible Then
                frmHighscores.Close()
            End If

            Me.Hide()

        End If

    End Sub

    Private Sub ChangeDifficultyHandlerBtn(sender As Object, e As EventArgs)

        Dim buttonClicked As Button = sender
        Dim newColor As Color

        Select Case buttonClicked.Name(11)
            Case "1"
                difficulty = 1
                newColor = applicationColors("green")
            Case "2"
                difficulty = 2
                newColor = applicationColors("yellow")
            Case "3"
                difficulty = 3
                newColor = applicationColors("red")
            Case "R"
                difficulty = 4
                newColor = applicationColors("orange")

        End Select

        SetDifficultyColor(difficulty - 1, newColor)

    End Sub

    Private Sub ChangeDifficultyHandlerLbl(sender As Object, e As EventArgs)

        Dim labelClicked As Label = sender
        Dim newColor As Color

        Select Case labelClicked.Name(11)
            Case "1"
                difficulty = 1
                newColor = applicationColors("green")
            Case "2"
                difficulty = 2
                newColor = applicationColors("yellow")
            Case "3"
                difficulty = 3
                newColor = applicationColors("red")
            Case "R"
                difficulty = 4
                newColor = applicationColors("orange")

        End Select

        SetDifficultyColor(difficulty - 1, newColor)

    End Sub

    Private Sub SetDifficultyColor(targetButtonIndex As Integer, targetButtonColor As Color)

        Dim buttonsArray As Button() = {btnMazeSize10, btnMazeSize20, btnMazeSize30, btnMazeSizeRandom}

        For i = 0 To buttonsArray.Length - 1 Step 1

            If i <> targetButtonIndex Then

                buttonsArray(i).BackColor = Color.White
                buttonsArray(i).FlatAppearance.MouseOverBackColor = Color.White
                buttonsArray(i).FlatAppearance.MouseDownBackColor = Color.White

            End If

        Next i

        buttonsArray(targetButtonIndex).BackColor = targetButtonColor
        buttonsArray(targetButtonIndex).FlatAppearance.MouseOverBackColor = targetButtonColor
        buttonsArray(targetButtonIndex).FlatAppearance.MouseDownBackColor = targetButtonColor

        txtMazeSeed.Enabled = (difficulty <> 4)
        lblMazeSeed.Enabled = (difficulty <> 4)

        ValidateTextBoxes()

    End Sub

    Private Sub CheckDifficulty(ByRef checkPassed As Boolean)

        Dim validDifficulties As Integer() = {1, 2, 3, 4} ' 4 indicates the Random difficulty, which we handle on its own

        ' If the user hasn't provided a difficulty, or by a typecast issue the difficulty isn't in the validDifficulties array, it doesn't proceed

        If IsNothing(difficulty) Or Not validDifficulties.Contains(difficulty) Then

            checkPassed = False

        Else

            ' If the selected difficulty is "4", or Random, then we generate the random maze size and assign it here

            If difficulty = 4 Then

                mazeSize = New Random().Next(0, 3)

            Else

                ' Otherwise, we adjust the difficulty by an offset of 1 to obtain the relevant mazeSize

                mazeSize = difficulty - 1

            End If

        End If

    End Sub

    Private Function CheckSeed(ByVal checkPassed As Boolean) As Boolean

        If SeedEntered() Then

            Dim enteredSeed As String = txtMazeSeed.Text

            If ValidateSeed(enteredSeed) Then

                mazeSeed = Convert.ToUInt64(enteredSeed, 16)

            Else

                checkPassed = False

            End If

        Else

            Dim generatedSeed As ULong = GenerateSeed()

            mazeSeed = generatedSeed

        End If

        Return checkPassed

    End Function

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

    Private Function ValidateName(ByVal checkPassed As Boolean) As Boolean

        Dim enteredName As String = txtName.Text

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")

        If Not validNamePattern.IsMatch(enteredName) Then

            checkPassed = False

        Else

            playerName = enteredName

        End If

        Return checkPassed

    End Function

    Private Sub ValidateName()

        Dim enteredName As String = txtName.Text

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")

        If Not validNamePattern.IsMatch(enteredName) Then

            btnPlay.Enabled = False

        Else

            btnPlay.Enabled = True

        End If

    End Sub

    Private Sub ValidateSeed()

        Dim pattern As Regex = New Regex("^[0-9a-fA-F]{1,10}$")

        If Not pattern.IsMatch(txtMazeSeed.Text) Then

            btnPlay.Enabled = False

        Else

            btnPlay.Enabled = True

        End If

    End Sub

    Private Sub ValidateTextBoxes()

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")
        Dim validSeedPattern As Regex = New Regex("^[0-9a-fA-F]{0,10}$")

        If Not (validNamePattern.IsMatch(txtName.Text) And validSeedPattern.IsMatch(txtMazeSeed.Text)) Then

            btnPlay.Enabled = False

        Else

            btnPlay.Enabled = True

        End If

    End Sub

    Private Sub TextBoxChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtMazeSeed.TextChanged

        ValidateTextBoxes()

    End Sub

    Private Sub GenerateMaze(ByRef arrGameBoard As Integer(,), mazeSeed As ULong, mazeSize As Integer)

        InitializeGameBoard(arrGameBoard, mazeSize)

        Dim mazeRnd As Random = New Random(mazeSeed Mod (Integer.MaxValue))

        RecursePassage(arrGameBoard, 0, 0, mazeRnd)

    End Sub

    Private Sub RecursePassage(arrGameBoard As Integer(,), cy As Integer, cx As Integer, mazeRnd As Random)

        Dim arrDirections As Integer() = {N, S, E, W}

        Dim nx As Integer
        Dim ny As Integer
        Dim direction As Integer

        ShuffleDirections(arrDirections, mazeRnd)

        For i = 0 To 3 Step 1

            nx = cx
            ny = cy

            direction = arrDirections(i)

            ny += Vertical(direction)
            nx += Horizontal(direction)

            Dim verticalRange As Boolean = ny >= 0 And ny < arrGameBoard.GetLength(0)
            Dim horizontalRange As Boolean = nx >= 0 And nx < arrGameBoard.GetLength(1)

            If verticalRange AndAlso horizontalRange AndAlso arrGameBoard(ny, nx) = 0 Then

                arrGameBoard(cy, cx) = (arrGameBoard(cy, cx) Or direction)
                arrGameBoard(ny, nx) = (arrGameBoard(ny, nx) Or Opposite(direction))

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

    Private Sub InitializeGameBoard(ByRef arrGameBoard As Integer(,), mazeSize As Integer)

        Dim edgeLength As Integer = (mazeSize + 1) * 10

        ReDim arrGameBoard(edgeLength - 1, edgeLength - 1)

        For i = 0 To edgeLength - 1 Step 1
            For j = 0 To edgeLength - 1 Step 1

                arrGameBoard(i, j) = 0

            Next j
        Next i

    End Sub

    Private Sub ShowInstructions(sender As Object, e As EventArgs) Handles btnInstructions.Click

        If frmHighscores.Visible Then
            frmHighscores.Close()
        End If

        frmInstructions.Show()
        frmInstructions.Focus()

    End Sub

    Private Sub ShowHighscores(sender As Object, e As EventArgs) Handles btnHighscores.Click

        If frmInstructions.Visible Then
            frmInstructions.Close()
        End If

        frmHighscores.Show()
        frmHighscores.Focus()

    End Sub

End Class