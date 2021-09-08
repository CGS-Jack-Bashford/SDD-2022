Public Class Form1

    Dim nums As Integer() = {}

    Private Sub btnGetNums_Click(sender As Object, e As EventArgs) Handles btnGetNums.Click

        Dim lengthArr As Integer = Int(InputBox("How many numbers would you like to add to the array?"))
        ReDim Preserve nums(nums.Length + lengthArr - 1)
        MsgBox("Please enter your numbers in ascending order.")

        For i As Integer = 0 To lengthArr - 1

            Dim newNum As Integer = Int(InputBox("Please enter number " & (i + 1)))
            nums(i) = newNum
            lstNums.Items.Add(newNum)

        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim toFind As Integer = Int(InputBox("What number would you like to find? "))
        Dim idx As Integer = BinarySearch(nums, nums.Length, toFind)

        If idx = -1 Then

            MsgBox("The number " & toFind & " was not found in the array.")

        Else

            MsgBox("The number " & toFind & " was found in the array at position " & (idx + 1))
            lstNums.SelectedIndex = idx

        End If

    End Sub

    Private Function BinarySearch(ByRef arr As Integer(), ByVal len As Integer, ByVal item As Integer) As Integer

        Dim lower As Integer = 0
        Dim upper As Integer = len - 1
        Dim found As Boolean = False
        Dim idx = -1

        Do

            Dim mid As Integer = Math.Floor((lower + upper) / 2)

            Debug.Print(mid & " " & arr(mid))

            If item = arr(mid) Then

                found = True
                idx = mid

            Else

                If item < arr(mid) Then '

                    upper = mid - 1

                Else

                    lower = mid + 1

                End If

            End If

        Loop Until found Or lower > upper

        Return idx

    End Function

End Class
