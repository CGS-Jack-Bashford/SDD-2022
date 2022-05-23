Public Class frmHighscores

    ' This form-scoped variable indicates which maze size is currently being viewed

    Private SelectedMazeSize As Integer = 0

    ''' <summary>
    ''' Configure all UI elements, and add event handlers in bulk
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub frmHighscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Add and configure all UI elements and controls

        configureFrmHighscores()
        SetupUI()

        AddMazeSizeButtonHandlers

    End Sub

    ''' <summary>
    ''' Add the click handlers for the maze size buttons and labels
    ''' </summary>

    Private Sub AddMazeSizeButtonHandlers()

        ' Add all handlers for the maze size selection buttons

        Dim buttonList As Button() = {btnMazeSize10, btnMazeSize10Back, btnMazeSize20, btnMazeSize20Back, btnMazeSize30, btnMazeSize30Back}

        For i = 0 To buttonList.Length - 1 Step 1

            AddHandler buttonList(i).Click, AddressOf ChangeHighscoresViewBtn

        Next i

        ' Add handlers for the labels of the buttons as well

        Dim labelList As Label() = {lblMazeSize10, lblMazeSize20, lblMazeSize30}

        For i = 0 To labelList.Length - 1 Step 1

            AddHandler labelList(i).Click, AddressOf ChangeHighscoresViewLbl

        Next i

    End Sub

    ''' <summary>
    ''' Show the help form when F1 is pressed
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>

    Private Sub ShowHelpForm(sender As Object, e As EventArgs) Handles Me.HelpRequested

        frmHelp.Show()

    End Sub

    ''' <summary>
    ''' Setup the maze size selection buttons and prevent maximization
    ''' </summary>

    Private Sub SetupUI()

        ' Setup the user interface by initializing the colors of the maze selection buttons

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

        ' Ensure maximizing the window does not actually maximize it, to avoid scaling issues.

        Me.MaximizedBounds = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Normal

        UpdateView(SelectedMazeSize)

    End Sub

    ''' <summary>
    ''' Close the form if the 'Close' button is clicked
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Change the maze size view if the button that was clicked is different to the currently selected maze size view. Button variant
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub ChangeHighscoresViewBtn(sender As Object, e As EventArgs)

        Dim buttonClicked As Button = sender
        Dim newMazeSize As Integer = CInt(buttonClicked.Name(11).ToString()) - 1

        If newMazeSize <> SelectedMazeSize Then

            UpdateView(newMazeSize)
            SelectedMazeSize = newMazeSize

        End If

    End Sub

    ''' <summary>
    ''' Change the maze size view if the button that was clicked is different to the currently selected maze size view. Label variant
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub ChangeHighscoresViewLbl(sender As Object, e As EventArgs)

        Dim labelClicked As Label = sender
        Dim newMazeSize As Integer = CInt(labelClicked.Name(11).ToString()) - 1

        If newMazeSize <> SelectedMazeSize Then

            UpdateView(newMazeSize)
            SelectedMazeSize = newMazeSize

        End If

    End Sub

    ''' <summary>
    ''' Update the maze size view with the selected maze size display.
    ''' </summary>
    ''' <param name="newMazeSize">The new maze size to display highscores for</param>
    Public Sub UpdateView(newMazeSize As Integer)

        ' Select the dimension of arrHighscores with the maze size that we need to display

        Dim highScoresToDisplay As Highscore() = arrHighscores(newMazeSize)

        ' Construct an array of ranking labels to change the text of.
        Dim rankingLabels As Label()() = New Label(4)() {}
        rankingLabels(0) = {lblNameRanking1, lblTimeRanking1}
        rankingLabels(1) = {lblNameRanking2, lblTimeRanking2}
        rankingLabels(2) = {lblNameRanking3, lblTimeRanking3}
        rankingLabels(3) = {lblNameRanking4, lblTimeRanking4}
        rankingLabels(4) = {lblNameRanking5, lblTimeRanking5}

        ' The current high score, that will be assigned as a temporary variable on each iteration.
        Dim currHighscore As Highscore

        For i = 0 To 4 Step 1

            ' If there are more highscores to display then we fill in the corresponding data for that row.

            If i < highScoresToDisplay.Length Then

                currHighscore = highScoresToDisplay(i)
                rankingLabels(i)(0).Text = currHighscore.playerName
                rankingLabels(i)(1).Text = (currHighscore.gameTime \ 60).ToString().PadLeft(2, "0") & ":" & (currHighscore.gameTime Mod 60).ToString().PadLeft(2, "0")

            Else

                ' If there are less than 5 highscores to display, we empty the bottom rows which do not have any highscore results.

                rankingLabels(i)(0).Text = ""
                rankingLabels(i)(1).Text = ""

            End If

        Next i

        ' Update the color of the correspondingly clicked button to indicate which maze size is being displayed.

        UpdateButtonColor(newMazeSize)

    End Sub

    ''' <summary>
    ''' Change the indicator color of the maze size buttons
    ''' </summary>
    ''' <param name="newMazeSize"></param>
    Public Sub UpdateButtonColor(newMazeSize As Integer)

        ' Create a list of buttons and colors to access via indices for simplicity
        Dim buttonList As Button() = {btnMazeSize10, btnMazeSize20, btnMazeSize30}
        Dim colorList As Color() = {applicationColors("green"), applicationColors("yellow"), applicationColors("red")}

        Dim oldButton As Button = buttonList(SelectedMazeSize)
        Dim white As Color = Color.White

        ' Make the button that was previously selected all white
        oldButton.BackColor = white
        oldButton.FlatAppearance.MouseDownBackColor = white
        oldButton.FlatAppearance.MouseOverBackColor = white

        Dim selectedButton As Button = buttonList(newMazeSize)
        Dim selectedColor As Color = colorList(newMazeSize)

        ' Make the newly selected button its correct color
        selectedButton.BackColor = selectedColor
        selectedButton.FlatAppearance.MouseDownBackColor = selectedColor
        selectedButton.FlatAppearance.MouseOverBackColor = selectedColor

    End Sub

    ''' <summary>
    ''' When the form is closed, switch focus to the form that displayed it (either frmMain or frmGameOver)
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event which caused this subroutine to be called</param>
    Private Sub FocusOtherForm(sender As Object, e As EventArgs) Handles Me.Closing, Me.Closed

        If frmMain.Visible Then
            frmMain.Focus()
        ElseIf frmGameOver.Visible Then
            frmGameOver.Focus()
        End If

    End Sub

End Class