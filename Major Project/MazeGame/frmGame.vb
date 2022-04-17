Public Class frmGame

    Dim pixelSize As Integer
    Dim rectangleEdges(,) As RectangleF
    Dim mazeDrawn As Boolean = False

    Private Sub InitialiseGameScreen(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmGame()
        SetupUI()

        Select Case mazeSize
            Case 0 : pixelSize = 12
            Case 1 : pixelSize = 6
            Case 2 : pixelSize = 4
        End Select

        Dim edgeLength As Integer = (mazeSize + 1) * 10

        ReDim rectangleEdges(edgeLength - 1, edgeLength - 1)

        For row = 0 To edgeLength - 1 Step 1

            For column = 0 To edgeLength - 1 Step 1

                rectangleEdges(row, column) = GenerateTopEdge(arrGameBoard(row, column), (row:=row, column:=column))

            Next column

        Next row

    End Sub

    Private Sub SetupUI()

        Dim mazeSizes As String() = {"10x10", "20x20", "30x30"}
        Dim mazeColors As Color() = {applicationColors("green"), applicationColors("yellow"), applicationColors("red"), applicationColors("orange")}

        lblMazeSizeDisp.Text = mazeSizes(mazeSize)
        btnMazeSizeDisp.BackColor = mazeColors(difficulty - 1)
        lblPlayerName.Text = playerName
        lblTime.Text = "00:00"
        txtMazeSeed.Text = Hex(mazeSeed).PadLeft(10, "0")

    End Sub

    Function GenerateTopEdge(ByVal cell As Integer, ByVal loc As (row As Integer, column As Integer)) As RectangleF

        Dim edge As RectangleF = New RectangleF(0, 0, 0, 0)

        If (cell And N) = 0 Then

            edge = New RectangleF((loc.column * 5 * pixelSize), (loc.row * 5 * pixelSize), 5 * pixelSize, pixelSize)

        End If

        Return edge

    End Function

    Function GenerateEdges(ByVal cell As Integer, ByVal loc As (row As Integer, column As Integer)) As (edgesLength As Integer, edges As RectangleF())

        Dim edges(2) As RectangleF
        Dim i As Integer = 0

        Dim rowpx As Integer = loc.row * 5 * pixelSize
        Dim colpx As Integer = loc.column * 5 * pixelSize

        If (cell And N) = 0 Then
            edges(i) = New RectangleF(colpx, rowpx, 5 * pixelSize, pixelSize)
            i += 1
        End If

        If (cell And E) = 0 Then
            edges(i) = New RectangleF(colpx + (4 * pixelSize), rowpx, pixelSize, 5 * pixelSize)
            i += 1
        End If

        If (cell And S) = 0 Then
            edges(i) = New RectangleF(colpx, rowpx + (4 * pixelSize), 5 * pixelSize, pixelSize)
            i += 1
        End If

        If (cell And W) = 0 Then
            edges(i) = New RectangleF(colpx, rowpx, pixelSize, 5 * pixelSize)
            i += 1
        End If

        Return (edgesLength:=i - 1, edges)

    End Function

    Private Sub frmGame_Close(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    Private Sub pnlGame_Paint(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint

        drawWalls(e)
        drawPlayer(e)

        If mazeDrawn = False Then

            mazeDrawn = True
            tmrTick.Start()

        End If

    End Sub

    Private Sub TickHandler(sender As Object, e As EventArgs) Handles tmrTick.Tick

        gameTime += 1

        Dim minutes As Integer = gameTime \ 60
        Dim seconds As Integer = gameTime Mod 60

        Dim paddedMinutes As String = minutes.ToString.PadLeft(2, "0")
        Dim paddedSeconds As String = seconds.ToString.PadLeft(2, "0")

        lblTime.Text = paddedMinutes & ":" & paddedSeconds

    End Sub

    Private Sub drawWalls(e As PaintEventArgs)

        Dim edgeLength As Integer = (mazeSize + 1) * 10
        Dim blackSolidBrush As SolidBrush = New SolidBrush(Color.Black)

        e.Graphics.FillRectangle(blackSolidBrush, New RectangleF(0F, 0F, (mazeSize + 1) * 50 * pixelSize, pixelSize))
        e.Graphics.FillRectangle(blackSolidBrush, New RectangleF(0F, 0F, pixelSize, (mazeSize + 1) * 50 * pixelSize))
        e.Graphics.FillRectangle(blackSolidBrush, New RectangleF(0F, 600 - pixelSize, (mazeSize + 1) * 50 * pixelSize, pixelSize))
        e.Graphics.FillRectangle(blackSolidBrush, New RectangleF(600 - pixelSize, 0F, pixelSize, (mazeSize + 1) * 50 * pixelSize))

        For row = 0 To edgeLength - 1 Step 1

            For column = 0 To edgeLength - 1 Step 1

                Dim cellEdges As (edgesLength As Integer, edges As RectangleF()) = GenerateEdges(arrGameBoard(row, column), (row:=row, column:=column))

                For i = 0 To cellEdges.edgesLength Step 1

                    e.Graphics.FillRectangle(blackSolidBrush, cellEdges.edges(i))

                Next i

            Next

        Next

    End Sub

    Private Sub drawPlayer(e As PaintEventArgs)



    End Sub

End Class