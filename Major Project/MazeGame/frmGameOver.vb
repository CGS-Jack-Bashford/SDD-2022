Public Class frmGameOver

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.GotFocus

        configureFrmGameOver()

        InitializeUI()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    Private Sub InitializeUI()

        lblPlayerName.Text = playerName
        lblMazeSeed.Text = mazeSeed.ToString("X1").PadLeft(10, "0")
        lblGameTime.Text = (gameTime \ 60).ToString().PadLeft(2, "0") & ":" & (gameTime Mod 60).ToString.PadLeft(2, "0")

        Dim mazeSizeString As String = (mazeSize + 1).ToString() & "0x" & (mazeSize + 1).ToString() & "0"

        lblMazeSize.Text = mazeSizeString

        SetColor()

    End Sub

    Private Sub SetColor()

        Dim difficultyColor As Color

        Select Case difficulty
            Case 4
                difficultyColor = applicationColors("orange")
            Case 3
                difficultyColor = applicationColors("red")
            Case 2
                difficultyColor = applicationColors("yellow")
            Case 1
                difficultyColor = applicationColors("green")
        End Select

        btnMazeSize10.BackColor = difficultyColor
        btnMazeSize10.FlatAppearance.MouseOverBackColor = difficultyColor
        btnMazeSize10.FlatAppearance.MouseDownBackColor = difficultyColor

    End Sub

    Private Sub CloseGame(sender As Object, e As EventArgs) Handles btnQuit.Click

        Globals.ResetGame()

        If frmHighscores.Visible Then
            frmHighscores.Close()
        End If

        Application.Exit()

    End Sub

    Private Sub ToHighscores(sender As Object, e As EventArgs) Handles btnToHighscores.Click

        frmHighscores.Show()
        frmHighscores.Focus()

    End Sub

    Private Sub frmGameOver_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

End Class