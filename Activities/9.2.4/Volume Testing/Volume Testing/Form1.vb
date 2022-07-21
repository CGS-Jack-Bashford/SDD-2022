Public Class Form1

    Private Structure recStudent 'declaring a single record
        Dim StudentID As Integer
        Dim LastName As String
        Dim FirstName As String
        Dim DOB As Date
    End Structure

    Private arrrecStudent(101) As recStudent 'declaring an array of these records

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click

        'these steps are adapted from http://www.dreamincode.net/forums/topic/94609-reading-a-text-file-into-an-array-of-structs/. See post 5 in particular for an excellent explanation.
        Dim i As Integer
        Dim tempString As String

        i = 0
        FileSystem.FileOpen(1, "C:\Users\owner\Downloads\dataJan-13-2016.csv", OpenMode.Input) 'change your filepath

        While Not EOF(1)
            i = i + 1
            tempString = FileSystem.LineInput(1) 'reads a whole line from the file and assigns it to the variable tempString
            Dim str(3) As String
            str = tempString.Split(",") 'this line is cool. It splits tempString into 4 parts (divided by the comma), and writes the 4 parts to str(0), str(1), str(2) and str(3)
            arrrecStudent(i).StudentID = CInt(str(0)) 'CInt converts the student ID to an integer. e.g. "1234" to 1234
            arrrecStudent(i).LastName = str(1)
            arrrecStudent(i).FirstName = str(2)
            arrrecStudent(i).DOB = CDate(str(3))

        End While

        FileSystem.FileClose(1)

        For i = 1 To 100
            lstOutput.Items.Add(i)
            lstOutput.Items.Add(arrrecStudent(i).StudentID)
            lstOutput.Items.Add(arrrecStudent(i).LastName)
            lstOutput.Items.Add(arrrecStudent(i).FirstName)
            lstOutput.Items.Add(arrrecStudent(i).DOB)
            lstOutput.Items.Add("")
        Next i

    End Sub

End Class
