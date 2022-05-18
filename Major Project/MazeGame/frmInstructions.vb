Public Class frmInstructions
    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmInstructions()

    End Sub

    Private Sub BackToStart(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        frmMain.Focus()

    End Sub

End Class