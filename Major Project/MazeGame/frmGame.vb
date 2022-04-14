Public Class frmGame

    Dim mazeWallsDrawn As Boolean = False
    Dim pixelSize As Integer
    Dim horizontalEdge As Rectangle

    Private Sub InitialiseGameScreen(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmGame()

        Dim mazeSizes As String() = {"10x10", "20x20", "30x30"}
        Dim mazeColors As Color() = {applicationColors("green"), applicationColors("orange"), applicationColors("red")}

        lblMazeSizeDisp.Text = mazeSizes(mazeSize)
        btnMazeSizeDisp.BackColor = mazeColors(mazeSize)
        lblPlayerName.Text = playerName

        Select Case mazeSize
            Case 0 : pixelSize = 12
            Case 1 : pixelSize = 6
            Case 2 : pixelSize = 4
        End Select

        horizontalEdge.X = 0
        horizontalEdge.Y = 0
        horizontalEdge.Width = (mazeSize + 1) * 50 * pixelSize
        horizontalEdge.Height = pixelSize

        pnlGame.Invalidate(horizontalEdge)

    End Sub

    Private Sub frmGame_Close(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint

        ' Calculate each maze border based on the pixelSize :D

        e.Graphics.FillRectangle(New SolidBrush(Color.Black), horizontalEdge)

    End Sub



End Class