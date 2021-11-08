Public Class Form1

    Public Structure recStudentInfo
        Public skey As String
        Public first As String
        Public last As String
    End Structure

    Dim arrStudents(3) As recStudentInfo

    Private Sub cmdHarderWriteDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHarderWriteDemo.Click
        Dim counter As Integer

        'set up data
        arrStudents(1).skey = "SMITHJ"
        arrStudents(1).last = "Smith"
        arrStudents(1).first = "James"
        arrStudents(2).skey = "WUJ"
        arrStudents(2).last = "Wu"
        arrStudents(2).first = "John"
        arrStudents(3).skey = "JONESJ"
        arrStudents(3).last = "Jones"
        arrStudents(3).first = "Joshua"

        'write to file
        FileSystem.FileOpen(1, "textstudents.txt", OpenMode.Random)
        FileSystem.FilePut(1, arrStudents(1))
        FileSystem.FilePut(1, arrStudents(2))
        FileSystem.FilePut(1, arrStudents(3))
        FileSystem.FileClose(1)

    End Sub

    Private Sub cmdHarderReadDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHarderReadDemo.Click
        FileSystem.FileOpen(1, "textstudents.txt", OpenMode.Random)
        FileSystem.FileGet(1, arrStudents(1))
        FileSystem.FileGet(1, arrStudents(2))
        FileSystem.FileGet(1, arrStudents(3))
        FileSystem.FileClose(1)

        lstOutput.Items.Add("reading records from random file")
        lstOutput.Items.Add("arrstudents(1).skey is " & arrStudents(1).skey)
        lstOutput.Items.Add("arrstudents(3).last is " & arrStudents(3).last)

        'you could also read from anywhere in the file, e.g.
        'FileSystem.FileGet(1, arrStudents(3), 3) will just get the third record
        'and place it in arrStudents(3).
    End Sub

End Class
