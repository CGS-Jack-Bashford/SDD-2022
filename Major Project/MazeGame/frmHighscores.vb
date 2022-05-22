Public Class frmHighscores

    Private SelectedMazeSize As Integer = 0
    Private Sub frmHighscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        configureFrmHighscores()

        SetupUI()

        Dim buttonList As Button() = {btnMazeSize10, btnMazeSize10Back, btnMazeSize20, btnMazeSize20Back, btnMazeSize30, btnMazeSize30Back}

        For i = 0 To buttonList.Length - 1 Step 1

            AddHandler buttonList(i).Click, AddressOf ChangeHighscoresViewBtn

        Next i

        Dim labelList As Label() = {lblMazeSize10, lblMazeSize20, lblMazeSize30}

        For i = 0 To labelList.Length - 1 Step 1

            AddHandler labelList(i).Click, AddressOf ChangeHighscoresViewLbl

        Next

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

        btnMazeSize10.BackColor = applicationColors("green")
        btnMazeSize10.FlatAppearance.MouseOverBackColor = applicationColors("green")
        btnMazeSize10.FlatAppearance.MouseDownBackColor = applicationColors("green")

        UpdateView(SelectedMazeSize)

    End Sub

    Private Sub ToFront(sender As Object, e As EventArgs) Handles MyBase.LostFocus

        Me.BringToFront()

    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub ChangeHighscoresViewBtn(sender As Object, e As EventArgs)

        Dim buttonClicked As Button = sender
        Dim newMazeSize As Integer = CInt(buttonClicked.Name(11).ToString()) - 1

        If newMazeSize <> SelectedMazeSize Then

            SelectedMazeSize = newMazeSize
            UpdateView(SelectedMazeSize)

        End If

    End Sub

    Private Sub ChangeHighscoresViewLbl(sender As Object, e As EventArgs)

        Dim labelClicked As Label = sender
        Dim newMazeSize As Integer = CInt(labelClicked.Name(11).ToString()) - 1

        If newMazeSize <> SelectedMazeSize Then

            UpdateView(newMazeSize)
            SelectedMazeSize = newMazeSize

        End If

    End Sub

    Public Sub UpdateView(newMazeSize As Integer)

        Dim highScoresToDisplay As Highscore() = arrHighscores(newMazeSize)

        Dim rankingLabels As Label()() = New Label(4)() {}
        rankingLabels(0) = {lblNameRanking1, lblTimeRanking1}
        rankingLabels(1) = {lblNameRanking2, lblTimeRanking2}
        rankingLabels(2) = {lblNameRanking3, lblTimeRanking3}
        rankingLabels(3) = {lblNameRanking4, lblTimeRanking4}
        rankingLabels(4) = {lblNameRanking5, lblTimeRanking5}

        Dim currHighscore As Highscore

        For i = 0 To 4 Step 1

            If i < highScoresToDisplay.Length Then

                currHighscore = highScoresToDisplay(i)
                rankingLabels(i)(0).Text = currHighscore.playerName
                rankingLabels(i)(1).Text = (currHighscore.gameTime \ 60).ToString().PadLeft(2, "0") & ":" & (currHighscore.gameTime Mod 60).ToString().PadLeft(2, "0")

            Else

                rankingLabels(i)(0).Text = ""
                rankingLabels(i)(1).Text = ""

            End If

        Next i

        UpdateButtonColor(newMazeSize)

    End Sub

    Public Sub UpdateButtonColor(newMazeSize As Integer)

        Dim buttonList As Button() = {btnMazeSize10, btnMazeSize20, btnMazeSize30}
        Dim colorList As Color() = {applicationColors("green"), applicationColors("yellow"), applicationColors("red")}

        Dim selectedButton As Button = buttonList(newMazeSize)
        Dim selectedColor As Color = colorList(newMazeSize)

        selectedButton.BackColor = selectedColor
        selectedButton.FlatAppearance.MouseDownBackColor = selectedColor
        selectedButton.FlatAppearance.MouseOverBackColor = selectedColor

        Dim oldButton As Button = buttonList(SelectedMazeSize)
        Dim white As Color = Color.White

    End Sub

    Private Sub FocusOtherForm(sender As Object, e As EventArgs) Handles Me.Closing, Me.Closed

        If frmMain.Visible Then
            frmMain.Focus()
        ElseIf frmGameOver.Visible Then
            frmGameOver.Focus()
        End If

    End Sub

End Class