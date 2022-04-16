Public Class frmGame

    Dim pixelSize As Integer
    Dim horizontalEdge As Rectangle
    Dim mazeWallsDrawn As Boolean = False
    Dim rectangleEdges(,) As RectangleF

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

        Dim edgeLength As Integer = (mazeSize + 1) * 10

        ReDim rectangleEdges(edgeLength - 1, edgeLength - 1)

        For row = 0 To edgeLength - 1 Step 1

            For column = 0 To edgeLength - 1 Step 1

                rectangleEdges(row, column) = GenerateTopEdge(arrGameBoard(row, column), (row:=row, column:=column))

            Next column

        Next row

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

        If (cell And N) = 0 Then
            edges(i) = New RectangleF((loc.column * 5 * pixelSize), (loc.row * 5 * pixelSize), 5 * pixelSize, pixelSize)
            i += 1
        End If

        If (cell And E) = 0 Then
            edges(i) = New RectangleF((loc.column * 5 * pixelSize) + (4 * pixelSize), (loc.row * 5 * pixelSize), pixelSize, 5 * pixelSize)
            i += 1
        End If

        If (cell And S) = 0 Then
            edges(i) = New RectangleF((loc.column * 5 * pixelSize), (loc.row * 5 * pixelSize) + (4 * pixelSize), 5 * pixelSize, pixelSize)
            i += 1
        End If

        If (cell And W) = 0 Then
            edges(i) = New RectangleF((loc.column * 5 * pixelSize), (loc.row * 5 * pixelSize), pixelSize, 5 * pixelSize)
            i += 1
        End If

        Return (edgesLength:=i - 1, edges)

    End Function

    Private Sub frmGame_Close(sender As Object, e As EventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    Private Sub frmGame_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

    Private Sub pnlGame_Paint(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint

        drawWalls(e)

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

End Class