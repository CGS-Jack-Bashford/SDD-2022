Public Class Form1

    Dim gameResults(4, 4) As Integer ' Team <idx1> scored <idx1, idx2> points against team <idx2>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadResults()

        Dim points(4) As Integer
        ' Dim result As Integer

        Dim teamXscored As Integer
        Dim teamYscored As Integer

        For x = 1 To 4 Step 1
            For y = x To 4 Step 1

                teamXscored = gameResults(x, y)
                teamYscored = gameResults(y, x)

                Debug.Print("Team " & x & " scored " & teamXscored & " points, team " & y & " scored " & teamYscored & " points")

                If y <> x Then

                    If teamXscored > teamYscored Then
                        points(x) = points(x) + 2
                    Else
                        If teamXscored < teamYscored Then
                            points(y) = points(y) + 2
                        Else
                            points(x) = points(x) + 1
                            points(y) = points(y) + 1
                        End If
                    End If
                End If

            Next y
        Next x

    End Sub

    Sub loadResults()

        gameResults(1, 1) = -1
        gameResults(2, 2) = -1
        gameResults(3, 3) = -1
        gameResults(4, 4) = -1

        gameResults(1, 2) = 1
        gameResults(1, 3) = 2
        gameResults(1, 4) = 9

        gameResults(2, 1) = 3
        gameResults(2, 3) = 4
        gameResults(2, 4) = 8

        gameResults(3, 1) = 5
        gameResults(3, 2) = 1
        gameResults(3, 4) = 0

        gameResults(4, 1) = 7
        gameResults(4, 2) = 6
        gameResults(4, 3) = 0

    End Sub

End Class
