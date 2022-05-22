Public Class frmHelp

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmHelp()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()

    End Sub

End Class