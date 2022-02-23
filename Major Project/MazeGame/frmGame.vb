Public Class frmGame

    Dim mazeWallsDrawn As Boolean = False
    Dim pixelSize As Integer

    Private Sub InitialiseGameScreen(sender As Object, e As EventArgs) Handles MyBase.

        Select Case mazeSize
            Case 1 : pixelSize = 12
            Case 2 : pixelSize = 6
            Case 3 : pixelSize = 3
        End Select

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        If Not mazeWallsDrawn Then

            Dim rcWallCell As Rectangle
            rcWallCell.X = 0
            rcWallCell.Y = 0
            rcWallCell.Width = pixelSize
            rcWallCell.Height = pixelSize

        End If

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