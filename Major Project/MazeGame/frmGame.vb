Public Class frmGame

    Dim pixelSize As Integer
    Dim mazeDrawn As Boolean = False
    Dim player As RectangleF
    Dim coords As Point

    ''' <summary>
    ''' Configure the game screen and setup all components for the game graphics and UI
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub InitialiseGameScreen(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.GotFocus, MyBase.Shown, Me.VisibleChanged

        ' This is needed so that the keypresses can be nullified after processing
        KeyPreview = True

        configureFrmGame()
        SetupUI()
        SetupComponents()

    End Sub

    ''' <summary>
    ''' Show the help form when the F1 key is pressed
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    ''' <summary>
    ''' Initialize the game screen drawing components
    ''' </summary>
    Private Sub SetupComponents()

        Select Case mazeSize
            Case 0 : pixelSize = 12
            Case 1 : pixelSize = 6
            Case 2 : pixelSize = 4
        End Select

        coords.X = 0
        coords.Y = 0

        player = New RectangleF((coords.X * 5 * pixelSize) + pixelSize, (coords.Y * 5 * pixelSize) + pixelSize, 3 * pixelSize, 3 * pixelSize)

    End Sub

    ''' <summary>
    ''' Setup the UI elements / controls
    ''' </summary>
    Private Sub SetupUI()

        Dim mazeSizes As String() = {"10x10", "20x20", "30x30"}
        Dim mazeColors As Color() = {applicationColors("green"), applicationColors("yellow"), applicationColors("red"), applicationColors("orange")}

        lblMazeSizeDisp.Text = mazeSizes(mazeSize)
        btnMazeSizeDisp.BackColor = mazeColors(difficulty - 1)
        lblPlayerName.Text = playerName
        lblTime.Text = "00:00"
        txtMazeSeed.Text = Hex(mazeSeed).PadLeft(10, "0")
        lblTitle.Select()
        lblTitle.Focus()

        pnlGame.Invalidate()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    ''' <summary>
    ''' Generates the cell wall edges for each cell
    ''' </summary>
    ''' <param name="cell">The cell value (the bitmasked value 0-15)</param>
    ''' <param name="loc">The location of the cell, in format (row, column)</param>
    ''' <returns>An array of rectangles representing the walls/edges of each cell</returns>
    Function GenerateEdges(ByVal cell As Integer, ByVal loc As (row As Integer, column As Integer)) As (edgesLength As Integer, edges As RectangleF())

        ' Only 3 cell walls, at most, can be open
        Dim edges(2) As RectangleF
        Dim i As Integer = 0

        ' The pixel offset of the rows and columns
        Dim rowpx As Integer = loc.row * 5 * pixelSize
        Dim colpx As Integer = loc.column * 5 * pixelSize

        ' Each of the four cases depending on which walls are open
        If (cell And N) = 0 Then
            edges(i) = New RectangleF(colpx, rowpx, 5 * pixelSize, pixelSize)
            i = i + 1
        End If

        If (cell And E) = 0 Then
            edges(i) = New RectangleF(colpx + (4 * pixelSize), rowpx, pixelSize, 5 * pixelSize)
            i = i + 1
        End If

        If (cell And S) = 0 Then
            edges(i) = New RectangleF(colpx, rowpx + (4 * pixelSize), 5 * pixelSize, pixelSize)
            i = i + 1
        End If

        If (cell And W) = 0 Then
            edges(i) = New RectangleF(colpx, rowpx, pixelSize, 5 * pixelSize)
            i = i + 1
        End If

        ' Return a named tuple consisting of the array of rectangular edges and its length
        Return (edgesLength:=i - 1, edges)

    End Function

    ''' <summary>
    ''' Draw each of the on-screen game components
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub PaintGameScreen(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint

        ' Draw the walls and textures underneath the player
        DrawWalls(e)
        DrawTextures(e)
        DrawPlayer(e)

        ' If this is the first paint event, then we start the tick timer to begin timing the gameplay
        If mazeDrawn = False Then

            mazeDrawn = True
            tmrTick.Start()

        End If

    End Sub

    ''' <summary>
    ''' The game timer tick handler - updates the on-screen timer label, and halts the game if the time limit of 1 hour is reached
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub TickHandler(sender As Object, e As EventArgs) Handles tmrTick.Tick

        gameTime = gameTime + 1

        ' The game cannot run for more than one hour due to formatting constraints, so we quit the game if it's reached that time limit
        If gameTime = 3600 Then

            tmrTick.Stop()
            MsgBox("You exceeded the maximum time (60 minutes) for the maze. Try again next time!")

            Application.Exit()

        End If

        ' Display the formatted game time on the lblTime label
        Dim minutes As Integer = gameTime \ 60
        Dim seconds As Integer = gameTime Mod 60

        Dim paddedMinutes As String = minutes.ToString.PadLeft(2, "0")
        Dim paddedSeconds As String = seconds.ToString.PadLeft(2, "0")

        lblTime.Text = paddedMinutes & ":" & paddedSeconds

    End Sub

    ''' <summary>
    ''' Draw the game walls
    ''' </summary>
    ''' <param name="e">The paint event context to draw the maze onto</param>
    Private Sub DrawWalls(e As PaintEventArgs)

        Dim g As Graphics = e.Graphics

        ' Define the brush and edge length to reduce repetitive code
        Dim edgeLength As Integer = (mazeSize + 1) * 10
        Dim blackSolidBrush As SolidBrush = New SolidBrush(Color.Black)

        ' Draw the four outside rectangles to form the maze barrier
        g.FillRectangle(blackSolidBrush, New RectangleF(0F, 0F, (mazeSize + 1) * 50 * pixelSize, pixelSize))
        g.FillRectangle(blackSolidBrush, New RectangleF(0F, 0F, pixelSize, (mazeSize + 1) * 50 * pixelSize))
        g.FillRectangle(blackSolidBrush, New RectangleF(0F, 600 - pixelSize, (mazeSize + 1) * 50 * pixelSize, pixelSize))
        g.FillRectangle(blackSolidBrush, New RectangleF(600 - pixelSize, 0F, pixelSize, (mazeSize + 1) * 50 * pixelSize))

        ' Draw each of the edges for each cell in the game board
        For row = 0 To edgeLength - 1 Step 1

            For column = 0 To edgeLength - 1 Step 1

                Dim cellEdges As (edgesLength As Integer, edges As RectangleF()) = GenerateEdges(arrGameBoard(row, column), (row:=row, column:=column))

                For i = 0 To cellEdges.edgesLength Step 1

                    g.FillRectangle(blackSolidBrush, cellEdges.edges(i))

                Next i

            Next

        Next

    End Sub

    ''' <summary>
    ''' Draw the player in blue at the player's location
    ''' </summary>
    ''' <param name="e">The paint event context to draw with</param>
    Private Sub DrawPlayer(e As PaintEventArgs)

        e.Graphics.FillRectangle(New SolidBrush(Color.CadetBlue), player)

    End Sub

    ''' <summary>
    ''' Draw the start/end squares at their respective locations
    ''' </summary>
    ''' <param name="e">The paint event context to draw with</param>
    Private Sub DrawTextures(e As PaintEventArgs)

        Dim begin As RectangleF = New RectangleF(pixelSize, pixelSize, 3 * pixelSize, 3 * pixelSize)
        Dim finish As RectangleF = New RectangleF(600 - (4 * pixelSize), 600 - (4 * pixelSize), 3 * pixelSize, 3 * pixelSize)

        e.Graphics.FillRectangle(New SolidBrush(Color.SeaGreen), begin)
        e.Graphics.FillRectangle(New SolidBrush(Color.Goldenrod), finish)

    End Sub

    ''' <summary>
    ''' Update the player coordinates when a direction input is provided
    ''' </summary>
    ''' <param name="direction">The direction (N/E/S/W) that the player has requested to move in</param>
    Private Sub UpdatePlayerCoords(direction As Char)

        ' If the movement is valid (doesn't move into a wall or maze barrier) then move the player
        If ValidateMovement(direction) Then

            ' Redraw the player's old position
            pnlGame.Invalidate(Rectangle.Round(player))

            Select Case direction
                Case "N" : coords.Y = coords.Y - 1
                Case "S" : coords.Y = coords.Y + 1
                Case "W" : coords.X = coords.X - 1
                Case "E" : coords.X = coords.X + 1
            End Select

            ' Redefine the player at its new position
            player = New RectangleF((coords.X * 5 * pixelSize) + pixelSize, (coords.Y * 5 * pixelSize) + pixelSize, 3 * pixelSize, 3 * pixelSize)

            ' Redraw the player's new position
            pnlGame.Invalidate(Rectangle.Round(player))

            ' Check if the player has won the game
            CheckWin()

        End If

    End Sub

    ''' <summary>
    ''' Validate the player's movement in a certain direction to ensure it is not moving through a wall or into a maze barrier
    ''' </summary>
    ''' <param name="dir">The direction (N/E/S/W) that the player has requested to move in</param>
    ''' <returns>True if the player's movement is valid, False if it's not valid</returns>
    Function ValidateMovement(dir As Char) As Boolean

        Dim valid As Boolean

        ' Both the maze edges and the cell walls must be checked. AndAlso ensures no out-of-range errors 
        Select Case dir
            Case "N" : valid = coords.Y > 0 AndAlso (arrGameBoard(coords.Y, coords.X) And N) <> 0
            Case "S" : valid = coords.Y < arrGameBoard.GetLength(0) AndAlso (arrGameBoard(coords.Y, coords.X) And S) <> 0
            Case "E" : valid = coords.X < arrGameBoard.GetLength(1) AndAlso (arrGameBoard(coords.Y, coords.X) And E) <> 0
            Case "W" : valid = coords.X > 0 AndAlso (arrGameBoard(coords.Y, coords.X) And W) <> 0
        End Select

        Return valid

    End Function

    ''' <summary>
    ''' When a gamepad movement button is clicked, attempt a movement in the direction of click
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub MovementButton_Click(sender As Object, e As EventArgs) Handles btnMoveN.Click, btnMoveE.Click, btnMoveS.Click, btnMoveW.Click

        Dim buttonClicked As Button = sender

        ' The 8th character of each of the names of the gamepad buttons is the direction (N/E/S/W)
        UpdatePlayerCoords(buttonClicked.Name(7))

    End Sub

    ''' <summary>
    ''' Override default keypresses and ensure that when an arrow key is pressed, a movement request is sent. All other keypresses are ignored.
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Select Case keyData
            Case Keys.Up
                UpdatePlayerCoords("N")
            Case Keys.Down
                UpdatePlayerCoords("S")
            Case Keys.Left
                UpdatePlayerCoords("W")
            Case Keys.Right
                UpdatePlayerCoords("E")
        End Select

        Return False

    End Function

    ''' <summary>
    ''' Check if the player has won (which is true if they are in the bottom right corner of the maze)
    ''' </summary>
    Private Sub CheckWin()

        ' If the player has won the game (they are in the bottom right hand corner of their maze) then
        If coords.X = arrGameBoard.GetLength(1) - 1 And coords.Y = arrGameBoard.GetLength(0) - 1 Then

            ' Stop the game timer
            tmrTick.Stop()
            ' Update arrHighscores with the game result (which will discard it if it's not a highscore)
            HandleHighscore()

            ' Move to frmGameOver
            frmGameOver.Show()
            Me.Hide()

        End If

    End Sub

    ''' <summary>
    ''' Create a Highscore record and pass it along to insert into the arrHighscores array
    ''' </summary>
    Private Sub HandleHighscore()

        ' Create a Highscore record and add it to the array
        Dim currentRound As Highscore = New Highscore()

        currentRound.gameTime = gameTime
        currentRound.mazeSeed = mazeSeed
        currentRound.mazeSize = mazeSize
        currentRound.playerName = playerName

        UpdateHighscores(currentRound)

    End Sub

    ''' <summary>
    ''' Add the new Highscore to the relevant arrHighscores sub-array, sort it, and write out the highscores to highscores.txt
    ''' </summary>
    ''' <param name="currentRound">The new Highscore to potentially save</param>
    Private Sub UpdateHighscores(currentRound As Highscore)

        Dim currMazeSize = currentRound.mazeSize

        ' Redimension the array by 1 value, and append the new highscore to the end of the array
        ReDim Preserve arrHighscores(currMazeSize)(arrHighscores(currMazeSize).Length)
        arrHighscores(currMazeSize)(arrHighscores(currMazeSize).Length - 1) = currentRound

        ' Sort the sub-array of highscores that we just updated
        Globals.SortHighscores(arrHighscores, currentRound.mazeSize)

        ' Write the highscores out to highscores.txt
        WriteHighscoresToFile(arrHighscores)

    End Sub

    ''' <summary>
    ''' Write the array arrHighscores out to the file highscores.txt
    ''' </summary>
    ''' <param name="arrHighscores">The array of highscores to write to the file</param>
    Private Sub WriteHighscoresToFile(ByRef arrHighscores As Highscore()())

        Dim currHighscore As Highscore
        Dim lineToWrite As String

        FileOpen(1, "highscores.txt", OpenMode.Output)

        ' Loop over each sub-array of arrHighscores

        For sizeCounter = 0 To 2 Step 1

            ' If only one highscore exists for the given maze size, write it out to the file correctly formatted
            If arrHighscores(sizeCounter).Length = 1 Then

                currHighscore = arrHighscores(sizeCounter)(0)
                lineToWrite = currHighscore.mazeSize & ";" & currHighscore.gameTime & ";" & currHighscore.playerName & ";" & currHighscore.mazeSeed.ToString("X").PadLeft(10, "0")
                PrintLine(1, lineToWrite)

            Else

                ' Otherwise, write out each highscore to the file (either the first five highscores, or all of them, whichever is less)
                For i = 0 To Math.Min(arrHighscores(sizeCounter).Length - 1, 4) Step 1
                    currHighscore = arrHighscores(sizeCounter)(i)
                    lineToWrite = currHighscore.mazeSize & ";" & currHighscore.gameTime & ";" & currHighscore.playerName & ";" & currHighscore.mazeSeed.ToString("X").PadLeft(10, "0")
                    PrintLine(1, lineToWrite)
                Next i

            End If

        Next sizeCounter

        ' Write the sentinel value and close the file
        PrintLine(1, "9999")
        FileClose(1)

    End Sub

    ''' <summary>
    ''' When the form is closed, quit the application
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

End Class