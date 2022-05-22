Public Class frmInstructions
    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmInstructions()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub BackToStart(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        frmMain.Focus()

    End Sub

    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

End Class