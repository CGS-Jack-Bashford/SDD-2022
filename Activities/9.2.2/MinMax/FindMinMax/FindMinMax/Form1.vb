Imports System.IO
Public Class Form1

    Dim nums As Integer() = {}
    Dim toFind As Integer

    Private Sub btnGetNums_Click(sender As Object, e As EventArgs) Handles btnGetNums.Click

        readNumsFromFile(nums)

        For idx As Integer = 0 To nums.Length - 1 Step 1

            lstNums.Items.Add(nums(idx))

        Next idx

    End Sub

    Private Sub readNumsFromFile(ByRef outputArr As Integer())

        FileOpen(1, Application.StartupPath & "randnums.txt", OpenMode.Input, OpenAccess.Read)

        Dim idx As Integer = 0
        Dim line As String = ""
        Input(1, line)

        While line <> "#"

            ReDim Preserve nums(nums.Length)
            nums(idx) = Int(line.Trim())
            idx += 1
            Input(1, line)

        End While

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        Dim toFind As Integer = Int(InputBox("Enter 1 for maximum, 2 for minimum value. "))
        Dim idx As Integer = findMinMax(nums, toFind)

        If toFind = 1 Then

            MsgBox("The maximum item " & nums(idx) & " first occurred at index " & idx)

        Else

            MsgBox("The minimum item " & nums(idx) & " first occurred at index " & idx)

        End If

        If lstNums.SelectedIndex <> -1 Then

                lstNums.SetSelected(lstNums.SelectedIndex, False)

            End If

            lstNums.SetSelected(idx, True)

    End Sub

    Function findMinMax(ByRef arr As Integer(), ByVal toFind As Integer) As Integer

        Dim idx As Integer = 0

        For i As Integer = 0 To arr.Length - 1 Step 1

            If toFind = 1 Then

                If arr(i) > arr(idx) Then

                    idx = i

                End If

            Else

                If arr(i) < arr(idx) Then

                    idx = i

                End If

            End If

        Next i

        Return idx

    End Function

End Class
