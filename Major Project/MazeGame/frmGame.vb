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

        horizontalEdge.X = pnlGame.Location.X
        horizontalEdge.Y = pnlGame.Location.Y
        horizontalEdge.Width = (mazeSize + 1) * 50 * pixelSize
        horizontalEdge.Height = pixelSize

        pnlGame.Invalidate(horizontalEdge)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint

        e.Graphics.FillRectangle(New SolidBrush(Color.Black), horizontalEdge)

        'If Not mazeWallsDrawn Then

        'End If

        'Debug.Print(" " & StrDup(mazeSize * 2 - 1, "_"))
        'For y = 0 To mazeSize - 1 Step 1
        '    Dim str As String = ""
        '    str &= "|"
        '    For x = 0 To mazeSize - 1 Step 1
        '        If (arrGameBoard(y, x) And S) <> 0 Then
        '            str += " "
        '        Else
        '            str += "_"
        '        End If
        '        If (arrGameBoard(y, x) And e) <> 0 Then
        '            If x < 9 AndAlso ((arrGameBoard(y, x) Or arrGameBoard(y, x + 1)) And S <> 0) Then
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



End Class