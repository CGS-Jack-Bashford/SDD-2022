Public Class Form1

    Dim arrNum As Integer() = {25, 18, 10, -3, 400, 2407, -985, 0, 1, 37}

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        Dim entered As Integer = Int(nupToFind.Value)
        Dim idx As Integer = linearSearch(arrNum, entered)

        If idx <> -1 Then
            MsgBox("The item " & entered & " was found at index " & idx)
        Else
            MsgBox("The item " & entered & " was not found in the list of numbers.")
        End If

    End Sub

    Function linearSearch(ByRef arr As Integer(), ByVal item As Integer) As Integer

        Dim found As Boolean = False
        Dim idx As Integer = 0

        While idx < arr.Length And found = False

            Dim currentItem = arr(idx)

            If currentItem = item Then

                found = True

            Else

                idx += 1

            End If

        End While

        If found = True Then
            Return idx
        Else
            Return -1
        End If

    End Function

End Class
