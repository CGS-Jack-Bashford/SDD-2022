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

        FileOpen(1, Application.StartupPath & "input.txt", OpenMode.Input, OpenAccess.Read)

        Dim idx As Integer = 0
        Dim line As String = ""
        Input(1, line)
        toFind = Int(line)

        While Not EOF(1)

            Input(1, line)
            ReDim Preserve outputArr(outputArr.Length)
            outputArr(idx) = Int(line.Trim())
            idx += 1

        End While

        FileClose(1)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Dim toFind As Integer = Int(InputBox("What number would you like to find? "))
        Dim idx As Integer = firstIndex(nums, toFind)

        If idx = -1 Then

            MsgBox("The number " & toFind & " does not occur in the list.")

        Else

            MsgBox("The number " & toFind & " occurs first at position " & idx & " in the list.")

            If lstNums.SelectedIndex <> -1 Then

                lstNums.SetSelected(lstNums.SelectedIndex, False)

            End If

            lstNums.SetSelected(idx, True)

        End If

        Dim maxIdx = findMinMax(nums, 1)
        Dim minIdx = findMinMax(nums, 2)

        MsgBox("The minimum and maximum values occur at positions " & minIdx & " and " & maxIdx & " respectively.")

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

    Function firstIndex(ByRef arr As Integer(), ByVal toFind As Integer) As Integer

        Dim found = False
        Dim idx = 0

        While Not found And idx < arr.Length

            If arr(idx) = toFind Then

                found = True

            Else

                idx += 1

            End If

        End While

        If found Then

            Return idx

        Else

            Return -1

        End If

    End Function

End Class
