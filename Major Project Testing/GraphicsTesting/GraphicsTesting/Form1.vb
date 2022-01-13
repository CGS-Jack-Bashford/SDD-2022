Public Class Form1

    Dim RcDraw As Rectangle
    Dim PenWidth = 5
    Dim colour As Color = Color.FromName("Red")

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        RcDraw.X = e.X
        RcDraw.Y = e.Y

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If e.X < RcDraw.X Then

            RcDraw.Width = RcDraw.X - e.X
            RcDraw.X = e.X

        Else

            RcDraw.Width = e.X - RcDraw.X

        End If

        If e.Y < RcDraw.Y Then

            RcDraw.Height = RcDraw.Y - e.Y
            RcDraw.Y = e.Y

        Else

            RcDraw.Height = e.Y - RcDraw.Y

        End If

        Me.Invalidate(RcDraw)

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        e.Graphics.Clear(Color.Green)
        e.Graphics.DrawRectangle(New Pen(colour, PenWidth), RcDraw)
        e.Graphics.FillRectangle(New SolidBrush(colour), RcDraw)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        NewColor()

    End Sub

    Private Sub NewColor()

        colour = Color.FromName(InputBox("What colour would you like? "))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        RcDraw.X = 1
        RcDraw.Y = 1
        RcDraw.Width = MyBase.Width
        RcDraw.Height = MyBase.Height

        Dim oldColour As Color = colour
        colour = Color.White
        Me.Invalidate()

        NewColor()

    End Sub
End Class
