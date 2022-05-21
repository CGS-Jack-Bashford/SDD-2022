Public Class frmHighscores

    Private SelectedMazeSize As Integer = 0
    Private Sub frmHighscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmHighscores()

        SetupUI()

    End Sub

    Private Sub SetupUI()

        Dim buttonsAndColors = New Dictionary(Of Button, Color) From {
            {btn_ranking1White, applicationColors("gold")},
            {btn_ranking2White, applicationColors("silver")},
            {btn_ranking3White, applicationColors("bronze")}
        }

        For Each kvp As KeyValuePair(Of Button, Color) In buttonsAndColors

            kvp.Key.BackColor = kvp.Value
            kvp.Key.FlatAppearance.MouseOverBackColor = kvp.Value
            kvp.Key.FlatAppearance.MouseDownBackColor = kvp.Value

        Next kvp

        btnMazeSize10Back.BackColor = applicationColors("green")
        btnMazeSize10Back.FlatAppearance.MouseOverBackColor = applicationColors("green")
        btnMazeSize10Back.FlatAppearance.MouseDownBackColor = applicationColors("green")

    End Sub

    Private Sub ToFront(sender As Object, e As EventArgs) Handles MyBase.LostFocus

        Me.BringToFront()

    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub ChangeHighscoresView(sender As Object, e As EventArgs)



    End Sub

    Private Sub FocusOtherForm(sender As Object, e As EventArgs) Handles Me.Closing, Me.Closed

        If frmMain.Visible Then
            frmMain.Focus()
        ElseIf frmGameOver.Visible Then
            frmGameOver.Focus()
        End If

    End Sub

End Class