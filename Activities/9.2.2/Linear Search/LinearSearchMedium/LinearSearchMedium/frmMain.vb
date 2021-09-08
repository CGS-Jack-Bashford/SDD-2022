Public Class frmMain

    Dim arrNum As Integer()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim lengthOfArray As Integer = Int(InputBox("How many items would you like to add?"))

        ReDim arrNum(lengthOfArray - 1)

        GetArrayContents(lengthOfArray - 1)

        Dim itemToFind As Integer = Int(InputBox("What item would you like to find? "))

        Dim count As Integer = linearCount(arrNum, itemToFind, lengthOfArray - 1)

        If count = 1 Then

            MsgBox("The item " & itemToFind & " occurs 1 time in the list.")

        Else

            MsgBox("The item " & itemToFind & " occurs " & count & " times in the list.")

        End If

    End Sub

    Private Sub GetArrayContents(ByVal numElements As Integer)

        Dim idx As Integer

        For idx = 0 To numElements Step 1

            arrNum(idx) = Int(InputBox("Please enter item " & (idx + 1)))

        Next idx

    End Sub

    Function linearCount(ByRef arr As Integer(), ByVal item As Integer, ByVal length As Integer) As Integer

        Dim count As Integer = 0
        Dim idx As Integer

        For idx = 0 To length Step 1

            If arr(idx) = item Then

                count += 1

            End If

        Next

        Return count

    End Function

End Class
