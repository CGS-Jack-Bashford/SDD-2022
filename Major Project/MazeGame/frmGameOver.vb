Public Class frmGameOver

    ''' <summary>
    ''' Configure the UI when the form loads (or when it focuses in the event of an unpaint)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.GotFocus

        configureFrmGameOver()

        InitializeUI()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    ''' <summary>
    ''' Show frmHelp when the F1 key is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    ''' <summary>
    ''' Write out the information from the game session to the form controls
    ''' </summary>
    Private Sub InitializeUI()

        lblPlayerName.Text = playerName

        ' The maze seed is converted to hexadecimal and padded to the left with "0"s to reach 10 characters
        lblMazeSeed.Text = mazeSeed.ToString("X1").PadLeft(10, "0")
        ' The game time is formatted in minutes (truncated division of 60) and seconds (modulus of 60), and both are padded and then concatenated
        lblGameTime.Text = (gameTime \ 60).ToString().PadLeft(2, "0") & ":" & (gameTime Mod 60).ToString.PadLeft(2, "0")
        ' The maze size is formatted by appending a 0 to the incremented mazeSize
        lblMazeSize.Text = (mazeSize + 1).ToString() & "0x" & (mazeSize + 1).ToString() & "0"

        ' Set the color of the indicator button
        SetColor(difficulty)

    End Sub

    ''' <summary>
    ''' Set the color of the indicator button according to the difficulty of the maze
    ''' </summary>
    ''' <param name="difficulty">The difficulty of the maze (1 = 10x10, 2 = 20x20, 3 = 30x30, 4 = Random)</param>
    Private Sub SetColor(ByVal difficulty As Integer)

        Dim difficultyColor As Color

        ' Select the appropriate color for the given difficulty
        Select Case difficulty
            Case 1
                difficultyColor = applicationColors("green")
            Case 2
                difficultyColor = applicationColors("yellow")
            Case 3
                difficultyColor = applicationColors("red")
            Case 4
                difficultyColor = applicationColors("orange")
        End Select

        ' Set the button color appropriately
        btnMazeSize10.BackColor = difficultyColor
        btnMazeSize10.FlatAppearance.MouseOverBackColor = difficultyColor
        btnMazeSize10.FlatAppearance.MouseDownBackColor = difficultyColor

    End Sub

    ''' <summary>
    ''' Close the game when the Quit button is clicked, or if the form is closed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseGame(sender As Object, e As EventArgs) Handles btnQuit.Click, Me.Closing

        Application.Exit()

    End Sub

    ''' <summary>
    ''' Show frmHighscores when the Highscores button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToHighscores(sender As Object, e As EventArgs) Handles btnToHighscores.Click

        frmHighscores.Show()
        frmHighscores.Focus()

    End Sub

End Class