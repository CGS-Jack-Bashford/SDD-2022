Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmMain

    ''' <summary>
    ''' Configure the form's UI, load initial high scores from the highscores.txt file, and setup click handlers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SetupForm(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown

        configureFrmMain()

        LoadHighscoresFromFile(arrHighscores)

        AddMazeSizeButtonHandlers()

        SetupUI()

    End Sub

    ''' <summary>
    ''' Setup the UI to prevent maximization, and to reset the textboxes in case they were not already reset
    ''' </summary>
    Private Sub SetupUI()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

        txtName.Text = ""
        txtMazeSeed.Text = ""

    End Sub

    ''' <summary>
    ''' Add the click handlers in bulk for the maze size selection buttons
    ''' </summary>
    Private Sub AddMazeSizeButtonHandlers()

        ' Setup all of the handlers for the difficulty buttons

        Dim arrDifficultyButtons As Button() = {btnMazeSize10, btnMazeSize10Back, btnMazeSize20, btnMazeSize20Back, btnMazeSize30, btnMazeSize30Back, btnMazeSizeRandom, btnMazeSizeRandomBack}

        For i = 0 To arrDifficultyButtons.Length - 1 Step 1
            AddHandler arrDifficultyButtons(i).Click, AddressOf ChangeDifficultyHandlerBtn
        Next i

        Dim arrDifficultyLabels As Label() = {lblMazeSize10, lblMazeSize20, lblMazeSizeRandom, lblMazeSize30}

        For i = 0 To arrDifficultyLabels.Length - 1 Step 1
            AddHandler arrDifficultyLabels(i).Click, AddressOf ChangeDifficultyHandlerLbl
        Next i

    End Sub

    ''' <summary>
    ''' Show the help form when F1 is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    ''' <summary>
    ''' Load the highscores into arrHighscores from the file highscores.txt. Handles cases where the file does not exist or is empty as well.
    ''' </summary>
    ''' <param name="arrHighscores">The array of highscores, to be modified by reference</param>
    Private Sub LoadHighscoresFromFile(ByRef arrHighscores As Highscore()())

        ' Initialize the three components of the jagged array to be empty
        arrHighscores(0) = New Highscore() {}
        arrHighscores(1) = New Highscore() {}
        arrHighscores(2) = New Highscore() {}

        ' Create the file with a sentinel value if it does not exist at the correct location (highscores.txt, in the same folder as the executable)
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

        ' If the file is empty, write the sentinel value to it and close the file

        If EOF(1) Then

            FileClose(1)

            FileOpen(2, "highscores.txt", OpenMode.Output)
            PrintLine(2, "9999")
            FileClose(2)

        Else

            ' Otherwise, read each line from the file, trim it, and split it into its four components (delimited by ;) up until the sentinel value is read

            Input(1, rawLine)

            rawLine = rawLine.Trim()

            While rawLine <> "9999"

                scoreComponents = rawLine.Split(New Char() {";"c})

                currentHighscore.mazeSize = scoreComponents(0)
                currentHighscore.gameTime = scoreComponents(1)
                currentHighscore.playerName = scoreComponents(2)
                currentHighscore.mazeSeed = Convert.ToUInt64(scoreComponents(3), 16)

                ' Append the new highscore value to the end of the current maze size sub-array of the array

                ReDim Preserve arrHighscores(currentHighscore.mazeSize)(arrHighscores(currentHighscore.mazeSize).Length)
                arrHighscores(currentHighscore.mazeSize)(arrHighscores(currentHighscore.mazeSize).Length - 1) = currentHighscore

                ' Read the next line from the file

                Input(1, rawLine)

                rawLine = rawLine.Trim()

            End While

            ' Close the file, and sort arrHighscores (each of the sub-arrays are sorted individually, hence the loop)

            FileClose(1)

            For sizeToSort = 0 To 2 Step 1

                SortHighscores(arrHighscores, sizeToSort)

            Next sizeToSort

        End If

    End Sub

    ''' <summary>
    ''' When the form is closed, quit the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Close(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    ''' <summary>
    ''' Handles the setup of the game, and sends the player to frmGame if all checks are passed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SetupGame(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim allChecksPassed As Boolean

        ' Check the name, seed, and difficulty values are all valid
        Dim seedCheckPassed As Boolean = CheckSeed()
        Dim nameCheckPassed As Boolean = ValidateName()
        Dim difficultyCheckPassed As Boolean = CheckDifficulty()

        ' Alert the user if their entered information is invalid or missing

        If Not seedCheckPassed Then

            MsgBox("That seed is invalid. Please provide a 1-10 digit hexadecimal (0-9, A-F) number.")

        End If

        If Not nameCheckPassed Then

            MsgBox("That name is invalid. Please enter a string 1-16 characters, consisting of alphanumeric/underscore characters.")

        End If

        If Not difficultyCheckPassed Then

            MsgBox("That difficulty is invalid. Please select one of the four difficulties on the left.")

        End If

        allChecksPassed = seedCheckPassed And nameCheckPassed And difficultyCheckPassed

        ' If all of the choices are correct, then generate the game board and proceed to frmGame, closing all other forms if they're open.

        If allChecksPassed Then

            GenerateMaze(Globals.arrGameBoard, mazeSeed, mazeSize)

            frmGame.Show()

            If frmHighscores.Visible Then
                frmHighscores.Close()
            End If

            If frmInstructions.Visible Then
                frmInstructions.Close()
            End If

            Me.Hide()

        End If

    End Sub

    ''' <summary>
    ''' Change the maze difficulty when a maze size button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

        ' Update the buttons with the selected difficulty color

        SetDifficultyColor(difficulty - 1, newColor)

        ValidateTextBoxes()

    End Sub

    ''' <summary>
    ''' Change the maze difficulty when a maze size label is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

        ' Update the buttons with the selected difficulty color

        SetDifficultyColor(difficulty - 1, newColor)

        ValidateTextBoxes()

    End Sub

    ''' <summary>
    ''' Update the target maze size button with its corresponding color
    ''' </summary>
    ''' <param name="targetButtonIndex">The button index to update</param>
    ''' <param name="targetButtonColor">The color to update the button with</param>
    Private Sub SetDifficultyColor(targetButtonIndex As Integer, targetButtonColor As Color)

        Dim buttonsArray As Button() = {btnMazeSize10, btnMazeSize20, btnMazeSize30, btnMazeSizeRandom}

        ' First, reset all of the buttons to white except for the one being updated
        For i = 0 To buttonsArray.Length - 1 Step 1

            If i <> targetButtonIndex Then

                buttonsArray(i).BackColor = Color.White
                buttonsArray(i).FlatAppearance.MouseOverBackColor = Color.White
                buttonsArray(i).FlatAppearance.MouseDownBackColor = Color.White

            End If

        Next i

        ' Updated the required button to its correct color
        buttonsArray(targetButtonIndex).BackColor = targetButtonColor
        buttonsArray(targetButtonIndex).FlatAppearance.MouseOverBackColor = targetButtonColor
        buttonsArray(targetButtonIndex).FlatAppearance.MouseDownBackColor = targetButtonColor

        ' If the random difficulty is selected, disable the mazeSeed fields as they aren't used in this difficulty
        txtMazeSeed.Enabled = (difficulty <> 4)
        lblMazeSeed.Enabled = (difficulty <> 4)

    End Sub

    ''' <summary>
    ''' Check if the difficulty that the player selected is valid (i.e. that they have indeed selected a difficulty)
    ''' </summary>
    ''' <param name="checkPassed">ByRef variable to pass back the result of the check, as well as the function return value</param>
    ''' <returns></returns>
    Private Function CheckDifficulty() As Boolean

        Dim checkPassed As Boolean = True

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

        Return checkPassed

    End Function

    ''' <summary>
    ''' Check if the entered seed is valid
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckSeed() As Boolean

        Dim checkPassed As Boolean = True

        ' If a seed was entered, validate it and store the result in checkPassed

        If SeedEntered() Then

            Dim enteredSeed As String = txtMazeSeed.Text

            If ValidateSeed(enteredSeed) Then

                mazeSeed = Convert.ToUInt64(enteredSeed, 16)

            Else

                checkPassed = False

            End If

        Else

            ' If a seed was not entered, generate one

            Dim generatedSeed As ULong = GenerateSeed()

            mazeSeed = generatedSeed

        End If

        Return checkPassed

    End Function

    ''' <summary>
    ''' Ensure a seed was entered into the textbox
    ''' </summary>
    ''' <returns></returns>
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