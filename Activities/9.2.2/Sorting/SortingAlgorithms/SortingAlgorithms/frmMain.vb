Public Class frmMain

    Dim nums() As Integer

    Private Sub updateListBox()

        lstNums.Items.Clear()

        For i As Integer = 0 To nums.Length - 1 Step 1

            lstNums.Items.Add(nums(i))

        Next

    End Sub
    Private Sub btnGetNums_Click(sender As Object, e As EventArgs) Handles btnGetNums.Click

        Dim len As Integer = Int(InputBox("How many integers would you like the list to contain?"))
        ReDim nums(len - 1)

        For i As Integer = 0 To len - 1 Step 1

            nums(i) = Int(InputBox("Please enter number " & (i + 1)))

        Next i

        updateListBox()

    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click

        Dim rnd As New Random()
        Dim i As Integer
        Dim j As Integer

        For i = nums.Length - 1 To 0 Step -1

            j = rnd.Next(0, i + 1)

            Swap(nums(j), nums(i))

        Next

        updateListBox()

    End Sub

    Private Sub btnBubbleSort_Click(sender As Object, e As EventArgs) Handles btnBubbleSort.Click

        Dim last As Integer = nums.Length - 1
        Dim swapped As Boolean = True

        While swapped

            swapped = False
            Dim i As Integer = 0

            While i < last

                If nums(i) > nums(i + 1) Then

                    Swap(nums(i), nums(i + 1))
                    swapped = True

                End If

                i += 1

            End While

            last -= 1

        End While

        updateListBox()

    End Sub

    Private Sub Swap(ByRef A As Integer, ByRef B As Integer)

        Dim temp As Integer = A
        A = B
        B = temp

    End Sub

End Class
