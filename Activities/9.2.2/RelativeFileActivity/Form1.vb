Public Class Form1

    Private Sub cmdRelativeWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelativeWrite.Click
        Dim counter As Integer
        Dim names(4) As String

        names(1) = "james"
        names(2) = "john"
        names(3) = "joshua"
        names(4) = "justin"
        lstOutput.Items.Add("writing to file ...")

        For counter = 1 To 4
            lstOutput.Items.Add(names(counter))
        Next

        FileSystem.FileOpen(1, "textout.txt", OpenMode.Random)
        FileSystem.FilePut(1, names(1), 1)
        FileSystem.FilePut(1, names(4), 4)
        FileSystem.FilePut(1, names(3), 3)
        FileSystem.FilePut(1, names(2), 2)
        FileSystem.FileClose(1)

    End Sub


    Private Sub cmdRelativeRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelativeRead.Click
        Dim counter As Integer
        Dim names(4) As String

        FileSystem.FileOpen(1, "textout.txt", OpenMode.Random)
        FileSystem.FileGet(1, names(4), 4)
        FileSystem.FileGet(1, names(2), 2)
        FileSystem.FileGet(1, names(3), 3)
        FileSystem.FileGet(1, names(1), 1)
        FileSystem.FileClose(1)

        lstOutput.Items.Add("reading from file ...")

        For counter = 1 To 4
            lstOutput.Items.Add(names(counter))
        Next

    End Sub

End Class
