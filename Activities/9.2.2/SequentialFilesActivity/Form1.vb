Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current As (Integer, Integer)

        FileOpen(1, "array1.txt", OpenMode.Input)
        FileOpen(2, "array2.txt", OpenMode.Input)
        FileOpen(3, "output.txt", OpenMode.Output)

        While Not EOF(1) And Not EOF(2)

            Dim line1 As String
            Dim line2 As String

            Input(1, line1)
            Input(2, line2)

            If current.Item1 = 0 Then

                current.Item1 = Int(line1)

            End If

            If Int(line1) = current.Item1 Then

                current.Item2 += Int(line2)

            Else

                PrintLine(3, current.Item1 & "," & current.Item2)
                current = (Int(line1), 0)

            End If

        End While

        FileClose(1)
        FileClose(2)
        FileClose(3)

    End Sub
End Class
