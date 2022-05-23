Public Class frmHelp

    ''' <summary>
    ''' Configure the UI when the form loads, and handle maximization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmHelp()

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

    End Sub

    ''' <summary>
    ''' Hide the form when the Close button is clicked, or when the form is closed manually
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles btnClose.Click, Me.Closing

        Me.Hide()

    End Sub

End Class