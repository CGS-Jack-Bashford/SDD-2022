Public Class frmGameOver

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.GotFocus

        configureFrmGameOver()

        InitializeUI()

    End Sub

    Private Sub InitializeUI()

        lblPlayerName.Text = playerName
        lblMazeSeed.Text = mazeSeed.ToString("X1").PadLeft(10, "0")
        lblGameTime.Text = (gameTime \ 60) & ":" & (gameTime Mod 60)

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

    Private Sub BackToStart(sender As Object, e As EventArgs) Handles btnToStart.Click

        Globals.ResetGame()
        frmMain.Show()
        Me.Hide()

    End Sub

End Class