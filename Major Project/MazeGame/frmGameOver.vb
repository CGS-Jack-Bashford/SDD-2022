Public Class frmGameOver

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmGameOver()

        InitializeUI()

    End Sub

    Private Sub InitializeUI()

        lblPlayerName.Text = playerName
        lblMazeSeed.Text = mazeSeed.ToString("X1").PadLeft(10, "0")
        lblGameTime.Text = (gameTime \ 60) & ":" & (gameTime Mod 60)

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

        Dim mazeSizeString As String = (mazeSize + 1).ToString().PadLeft(2, "0") & "0x0" & (mazeSize + 1).ToString().PadLeft(2, "0")

        lblMazeSize.Text = mazeSizeString

    End Sub

End Class