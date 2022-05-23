Public Class frmInstructions
    ''' <summary>
    ''' Configure the UI when the form loads, and handle maximization
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub SetupForm(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmInstructions()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    ''' <summary>
    ''' When the Back button is clicked, return to the main form (as it is the only form that can access this one). Do the same if the form is closed manually
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>

    Private Sub BackToStart(sender As Object, e As EventArgs) Handles btnBack.Click, Me.Closing

        Me.Hide()
        frmMain.Focus()

    End Sub

    ''' <summary>
    ''' Display the help form when F1 is pressed
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>

    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

End Class