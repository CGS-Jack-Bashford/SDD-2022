﻿Public Class frmGame

    Dim pixelSize As Integer
    Dim rectangleEdges(,) As RectangleF
    Dim mazeDrawn As Boolean = False
    Dim player As RectangleF
    Dim coords As Point
    Dim gameTimer As Stopwatch = New Stopwatch()

    Private Sub InitialiseGameScreen(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.GotFocus

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

        coords.X = 0
        coords.Y = 0
        player = New RectangleF((coords.X * 5 * pixelSize) + pixelSize, (coords.Y * 5 * pixelSize) + pixelSize, 3 * pixelSize, 3 * pixelSize)

    End Sub

    Private Sub SetupUI()

        Dim mazeSizes As String() = {"10x10", "20x20", "30x30"}
        Dim mazeColors As Color() = {applicationColors("green"), applicationColors("yellow"), applicationColors("red"), applicationColors("orange")}

        lblMazeSizeDisp.Text = mazeSizes(mazeSize)
        btnMazeSizeDisp.BackColor = mazeColors(difficulty - 1)
        lblPlayerName.Text = playerName
        lblTime.Text = "00:00"
        txtMazeSeed.Text = Hex(mazeSeed).PadLeft(10, "0")
        lblTitle.Select()

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

        DrawWalls(e)
        DrawTextures(e)
        DrawPlayer(e)

        If mazeDrawn = False Then

            mazeDrawn = True
            tmrTick.Start()
            gameTimer.Start()

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

    Private Sub DrawWalls(e As PaintEventArgs)

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

    Private Sub DrawPlayer(e As PaintEventArgs)

        e.Graphics.FillRectangle(New SolidBrush(Color.CadetBlue), player)

    End Sub

    Private Sub DrawTextures(e As PaintEventArgs)

        Dim begin As RectangleF = New RectangleF(pixelSize, pixelSize, 3 * pixelSize, 3 * pixelSize)
        Dim finish As RectangleF = New RectangleF(600 - (4 * pixelSize), 600 - (4 * pixelSize), 3 * pixelSize, 3 * pixelSize)

        e.Graphics.FillRectangle(New SolidBrush(Color.SeaGreen), begin)
        e.Graphics.FillRectangle(New SolidBrush(Color.Goldenrod), finish)

    End Sub

    Private Sub UpdatePlayerCoords(direction As Char)

        Debug.Print(arrGameBoard.GetLength(0))

        If ValidateMovement(direction) Then

            pnlGame.Invalidate(Rectangle.Round(player))

            Select Case direction
                Case "N" : coords.Y -= 1
                Case "S" : coords.Y += 1
                Case "W" : coords.X -= 1
                Case "E" : coords.X += 1
            End Select

            player = New RectangleF((coords.X * 5 * pixelSize) + pixelSize, (coords.Y * 5 * pixelSize) + pixelSize, 3 * pixelSize, 3 * pixelSize)

            pnlGame.Invalidate(Rectangle.Round(player))

            CheckWin()

        End If

    End Sub

    Function ValidateMovement(dir As Char) As Boolean

        Dim valid As Boolean

        Select Case dir
            Case "N" : valid = coords.Y > 0 AndAlso (arrGameBoard(coords.Y, coords.X) And N) <> 0
            Case "S" : valid = coords.Y < arrGameBoard.GetLength(0) AndAlso (arrGameBoard(coords.Y, coords.X) And S) <> 0
            Case "E" : valid = coords.X < arrGameBoard.GetLength(1) AndAlso (arrGameBoard(coords.Y, coords.X) And E) <> 0
            Case "W" : valid = coords.X > 0 AndAlso (arrGameBoard(coords.Y, coords.X) And W) <> 0
        End Select

        Return valid

    End Function

    Private Sub MovementButton_Click(sender As Object, e As EventArgs) Handles btnMoveN.Click, btnMoveE.Click, btnMoveS.Click, btnMoveW.Click

        Dim buttonClicked As Button = sender

        UpdatePlayerCoords(buttonClicked.Name(7))

    End Sub

    Private Sub CheckWin()

        If coords.X = arrGameBoard.GetLength(1) - 1 And coords.Y = arrGameBoard.GetLength(0) - 1 Then

            tmrTick.Stop()

            CheckHighScore()

            frmGameOver.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub CheckHighScore()



    End Sub

End Class