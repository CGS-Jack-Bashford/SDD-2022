Public Class Form1

    Dim randArr(51) As Integer

    Private Sub UpdateListBox()

        ListBox1.Items.Clear()

        For i = 0 To randArr.Length - 1 Step 1

            ListBox1.Items.Add(randArr(i))

        Next i

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Array.Clear(randArr, 0, randArr.Length)
        CheckPrevious(52, randArr)
        updateListBox()

    End Sub

    Private Sub CheckPrevious(n As Integer, ByRef arr As Integer())

        Dim count As Integer
        Dim temp As Integer

        For count = 0 To n - 1 Step 1

            Do

                temp = RandBetween(1, n)

            Loop Until LinearSearch(arr, temp) = -1

            arr(count) = temp

        Next count

    End Sub

    Function RandBetween(Low As Integer, High As Integer) As Integer

        Return Math.Ceiling(Rnd() * (High - Low)) + Low

    End Function

    Function LinearSearch(ByRef arr As Integer(), toFind As Integer) As Integer

        Dim idx As Integer = 0
        Dim found As Boolean = False

        While idx < arr.Length And Not found

            If arr(idx) = toFind Then

                found = True

            End If

            idx = idx + 1

        End While

        If found Then

            Return idx

        Else

            Return -1

        End If

    End Function

End Class
