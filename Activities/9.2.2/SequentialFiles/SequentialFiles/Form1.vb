Public Class frmMain
    'NOTE: NO ARRAYS ALLOWED!!!!
    Private Sub btnWrite_Click(sender As System.Object, e As System.EventArgs) Handles btnWrite.Click
        lstOutput.Items.Add("writing the numbers 1 to 10 to the file")

        FileOpen(1, "file.txt", OpenMode.Output)

        Dim i As Integer

        For i = 1 To 10 Step 1

            WriteLine(1, i)

        Next i

        FileClose(1)

    End Sub

    Private Sub btnAppend_Click(sender As System.Object, e As System.EventArgs) Handles btnAppend.Click
        lstOutput.Items.Add("appending the number 99 to the end of the file")
        'must use file mode of append

        FileOpen(1, "file.txt", OpenMode.Append)

        WriteLine(1, "99")

        FileClose(1)

    End Sub

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click

        lstOutput.Items.Add("reading and printing the contents of the file")

        FileOpen(1, "file.txt", OpenMode.Input)

        Dim line As String

        While Not EOF(1)

            Input(1, line)
            lstOutput.Items.Add(line)

        End While

        FileClose(1)

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
