Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmMain

    ''' <summary>
    ''' Configure the form's UI, load initial high scores from the highscores.txt file, and setup click handlers
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub SetupForm(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown

        ' Add and configure all UI elements and controls, as well as loading all highscores from the highscores.txt file
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
    ''' Add the click handlers in bulk for the maze size selection buttons and labels
    ''' </summary>
    Private Sub AddMazeSizeButtonHandlers()

        ' Setup all of the handlers for the difficulty buttons and their corresponding labels

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
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    ''' <summary>
    ''' Load the highscores into arrHighscores from the file highscores.txt. Handles cases where the file does not exist or is empty as well.
    ''' </summary>
    ''' <param name="arrHighscores">The array of highscores, to be modified by reference</param>
    Private Sub LoadHighscoresFromFile(ByRef arrHighscores As Highscore()())

        ' Initialize the three components of the jagged array arrHighscores to be empty
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

        Dim rawLine As String = ""
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
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    ''' <summary>
    ''' Handles the setup of the game, and sends the player to frmGame if all checks are passed
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub SetupGame(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim allChecksPassed As Boolean

        ' Check the name, seed, and difficulty values are all valid
        Dim seedCheckPassed As Boolean = CheckSeed(mazeSeed)
        Dim nameCheckPassed As Boolean = ValidateName(txtName.Text, playerName)
        Dim difficultyCheckPassed As Boolean = CheckDifficulty(difficulty, mazeSize)

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
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
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
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
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
    ''' <returns>True if the difficulty selected was valid, False if it was invalid</returns>
    Private Function CheckDifficulty(ByRef difficulty As Integer, ByRef mazeSize As Integer) As Boolean

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
                ' Otherwise, we adjust the difficulty by an offset of -1 to obtain the relevant mazeSize
                mazeSize = difficulty - 1
            End If

        End If

        Return checkPassed

    End Function

    ''' <summary>
    ''' Check if the entered seed is valid
    ''' </summary>
    ''' <returns>True if the seed was either valid or auto-generated, False if the seed was invalid</returns>
    Private Function CheckSeed(ByRef mazeSeed As ULong) As Boolean

        Dim checkPassed As Boolean = True

        ' If a seed was entered, validate it and store the result in checkPassed
        If SeedEntered(txtMazeSeed) Then

            Dim enteredSeed As String = txtMazeSeed.Text
            If ValidateSeed(enteredSeed) Then
                mazeSeed = Convert.ToUInt64(enteredSeed, 16)
            Else
                checkPassed = False
            End If

        Else

            ' If a seed was not entered, generate one (and reset the current maze seed)
            mazeSeed = GenerateSeed(mazeSeed)

        End If

        Return checkPassed

    End Function

    ''' <summary>
    ''' Ensure a seed was entered into the textbox
    ''' </summary>
    ''' <returns>True if the seed was entered, False if a seed was not entered</returns>
    Private Function SeedEntered(txtMazeSeed As TextBox) As Boolean

        Return Not String.IsNullOrEmpty(txtMazeSeed.Text)

    End Function

    ''' <summary>
    ''' Validates a seed string against the regex pattern of a valid seed
    ''' </summary>
    ''' <param name="enteredSeed">The seed string to validate</param>
    ''' <returns>True if the seed is valid, False if the seed is invalid</returns>
    Private Function ValidateSeed(enteredSeed As String) As Boolean

        ' The pattern describes any hexadecimal digit (upper and lower case), 1-10 digits in length, making up the entirety of the string
        Dim pattern As Regex = New Regex("^[0-9a-fA-F]{1,10}$")
        Return pattern.IsMatch(enteredSeed)

    End Function

    ''' <summary>
    ''' Generates a random seed (unsigned 64-bit integer) by concatenating several hexadecimal digits together
    ''' </summary>
    ''' <returns>A randomly 64-bit unsigned integer</returns>
    Private Function GenerateSeed(ByRef mazeSeed As ULong) As ULong

        mazeSeed = 0

        Dim seedRnd As New Random()

        Dim seedStr As String = ""
        Dim seedInt As ULong

        Dim i As Integer,
            currentVal As Integer,
            currentChar As Char

        ' Generate a random hexadecimal digit, and append it to the seed string
        For i = 1 To 10 Step 1

            currentVal = seedRnd.Next(0, 16)
            currentChar = Convert.ToString(currentVal, 16)
            seedStr = seedStr & currentChar

        Next i

        ' Parse the seed string from hexadecimal to a UInt64 and return it
        seedInt = Convert.ToUInt64(seedStr, 16)

        Return seedInt

    End Function

    ''' <summary>
    ''' Validates the player's entered name
    ''' </summary>
    ''' <returns>True if the player entered a valid name, False otherwise</returns>
    Private Function ValidateName(ByVal enteredName As String, ByRef playerName As String) As Boolean

        Dim checkPassed As Boolean = True

        ' Match the entered name against the pattern describing alphanumeric digits or underscores, 1-16 characters, for the entire string (i.e. not a substring, the whole string)

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")
        If Not validNamePattern.IsMatch(enteredName) Then
            checkPassed = False
        Else
            ' If the name is valid, assign it to the playerName variable and return True
            playerName = enteredName
        End If

        Return checkPassed

    End Function

    ''' <summary>
    ''' Validate the user input text boxes to be valid, instantly (this is run on a change of contents in either textbox to allow live updates)
    ''' </summary>
    Private Sub ValidateTextBoxes()

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")
        Dim validSeedPattern As Regex = New Regex("^[0-9a-fA-F]{0,10}$")

        ' Enable the Play button only if both text boxes are valid

        If Not (validNamePattern.IsMatch(txtName.Text) And validSeedPattern.IsMatch(txtMazeSeed.Text)) Then
            btnPlay.Enabled = False
        Else
            btnPlay.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Validate both text boxes when either of them changes
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub TextBoxChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtMazeSeed.TextChanged
        ValidateTextBoxes()
    End Sub

    ''' <summary>
    ''' Generate the maze based off of the given size and seed, mutating the arrGameBoard array by reference
    ''' </summary>
    ''' <param name="arrGameBoard">The array that will store the cell values of the maze</param>
    ''' <param name="mazeSeed">The seed to generate the maze based off of</param>
    ''' <param name="mazeSize">The size of the maze (0 = 10x10, 1 = 20x20, 2 = 30x30)</param>
    Private Sub GenerateMaze(ByRef arrGameBoard As Integer(,), mazeSeed As ULong, mazeSize As Integer)

        ' Fill the game board with zeroes after redimensioning
        InitializeGameBoard(arrGameBoard, mazeSize)
        ' Create the Random object to generate the maze with, using the maze seed (the modulus is required to ensure the value fits in the Int32 data type)
        Dim mazeRnd As Random = New Random(mazeSeed Mod (Integer.MaxValue))
        ' Begin recursively generating the maze from the top-left corner of the board
        RecursePassage(arrGameBoard, 0, 0, mazeRnd)

    End Sub

    ''' <summary>
    ''' Recursively generates the maze, beginning from a given x and y position and moving to any free cells (or backtracking if none are available)
    ''' </summary>
    ''' <param name="arrGameBoard">The arrGameBoard array which stores all of the cell wall values, mutated by reference</param>
    ''' <param name="cy">The current X value (to start moving from)</param>
    ''' <param name="cx">The current Y value (to start moving from)</param>
    ''' <param name="mazeRnd">The Random object that ensures the same maze is generated from the same input seed</param>
    Private Sub RecursePassage(ByRef arrGameBoard As Integer(,), cy As Integer, cx As Integer, mazeRnd As Random)

        ' Each of the four directions that the player can move. This is shuffled to produce random pathing
        Dim arrDirections As Integer() = {N, S, E, W}

        Dim nx As Integer
        Dim ny As Integer
        Dim direction As Integer

        ' Shuffle the directions using the Random object
        ShuffleDirections(arrDirections, mazeRnd)

        ' Loop over each index in arrDirections
        For i = 0 To 3 Step 1

            ' Initialize the new X and new Y positions
            nx = cx
            ny = cy

            direction = arrDirections(i)

            ' Add the vertical and horizontal components of the direction of movement to their respective variables
            ny = ny + Vertical(direction)
            nx = nx + Horizontal(direction)

            ' Boolean values representing whether the new X and new Y coordinates are in the valid range of values (they must stay within the bounds of the array)
            Dim verticalRange As Boolean = ny >= 0 And ny < arrGameBoard.GetLength(0)
            Dim horizontalRange As Boolean = nx >= 0 And nx < arrGameBoard.GetLength(1)

            ' If the values are in the valid range, and the cell that they point to is unvisited (cell values of 0 have no open walls and are thus unvisited)
            If verticalRange AndAlso horizontalRange AndAlso arrGameBoard(ny, nx) = 0 Then

                ' Use a bitwise Or to open the walls between the current cell and the new cell.
                arrGameBoard(cy, cx) = (arrGameBoard(cy, cx) Or direction)
                arrGameBoard(ny, nx) = (arrGameBoard(ny, nx) Or Opposite(direction))

                ' Begin recursively generating again from the new cell
                RecursePassage(arrGameBoard, ny, nx, mazeRnd)

            End If

        Next i

        ' If the cell has no valid unvisited neighbors, then the recursion will fall back to the previous case here and continue in the directions loop of the previous cell

    End Sub

    ''' <summary>
    ''' Shuffles the array of directions using a given Random object
    ''' </summary>
    ''' <param name="arrDirections">The array of directions to shufle (length 1)</param>
    ''' <param name="rndShuffle">The Random object to shuffle the array with</param>
    Private Sub ShuffleDirections(ByRef arrDirections As Integer(), ByRef rndShuffle As Random)

        Dim temp As Integer
        Dim j As Integer

        ' Standard Fisher-Yates shuffle algorithm, pick a random index and swap with the current index of iteration (reverse looping is used for concise code)
        For i = 3 To 0 Step -1

            j = rndShuffle.Next(i + 1)

            temp = arrDirections(i)
            arrDirections(i) = arrDirections(j)
            arrDirections(j) = temp

        Next i

    End Sub

    ''' <summary>
    ''' Redimension and fill the arrGameBoard array with zeroes
    ''' </summary>
    ''' <param name="arrGameBoard">The arrGameBoard array to initialize, mutated by reference</param>
    ''' <param name="mazeSize">The size to redimension the arrGameBoard array to</param>
    Private Sub InitializeGameBoard(ByRef arrGameBoard As Integer(,), mazeSize As Integer)

        ' Define the edge length of the array based on the maze size
        Dim edgeLength As Integer = (mazeSize + 1) * 10

        ReDim arrGameBoard(edgeLength - 1, edgeLength - 1)

        ' Fill each array element with a 0
        For i = 0 To edgeLength - 1 Step 1
            For j = 0 To edgeLength - 1 Step 1
                arrGameBoard(i, j) = 0
            Next j
        Next i

    End Sub

    ''' <summary>
    ''' Show the Instructions form when the Instructions button is clicked (closing the Highscores form if this is open)
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub ShowInstructions(sender As Object, e As EventArgs) Handles btnInstructions.Click

        If frmHighscores.Visible Then
            frmHighscores.Close()
        End If

        frmInstructions.Show()
        frmInstructions.Focus()

    End Sub

    ''' <summary>
    ''' Show the Highscores form when the Instructions button is clicked (closing the Instructions form if this is open)
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub ShowHighscores(sender As Object, e As EventArgs) Handles btnHighscores.Click

        If frmInstructions.Visible Then
            frmInstructions.Close()
        End If

        frmHighscores.Show()
        frmHighscores.Focus()

    End Sub

End Class