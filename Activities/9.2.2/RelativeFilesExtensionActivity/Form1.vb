Public Class Form1

    Public Structure recUserDetails

        Public UserName As Integer
        Public Password As String

    End Structure

    Private Sub btnCheckCredentials_Click(sender As Object, e As EventArgs) Handles btnCheckCredentials.Click

        FileOpen(1, "users.txt", OpenMode.Random)

        Dim enteredUsername As Integer

        Dim enteredPassword As String = txtPassword.Text
        Integer.TryParse(txtUsername.Text, enteredUsername)

        Dim userDetails As recUserDetails
        FileGet(1, userDetails, enteredUsername)

        MsgBox(userDetails.Password = enteredPassword)

        FileClose(1)

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        FileOpen(1, "users.txt", OpenMode.Random)

        Dim enteredNewUsername As Integer
        Integer.TryParse(txtNewName.Text, enteredNewUsername)

        Dim enteredNewPassword As String = txtNewPass.Text

        Dim newUserRecord As recUserDetails
        newUserRecord.UserName = enteredNewUsername
        newUserRecord.Password = enteredNewPassword

        FilePut(1, newUserRecord, enteredNewUsername)

        FileClose(1)

    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click

        FileOpen(1, "users.txt", OpenMode.Random)

        Dim enteredUsername As Integer
        Integer.TryParse(txtChangeUser.Text, enteredUsername)

        Dim userRec As recUserDetails
        FileGet(1, userRec, enteredUsername)

        Dim enteredOldPassword As String = txtChangeOld.Text

        If enteredOldPassword = userRec.Password Then

            Dim enteredNewPassword As String = txtChangeNew.Text
            userRec.Password = enteredNewPassword

            FilePut(1, userRec, enteredUsername)

        End If

        FileClose(1)

    End Sub

    Function getSHA(ByVal strToHash As String) As String

        Dim SHA As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        Dim strResult As String = ""

        bytesToHash = SHA.ComputeHash(bytesToHash)

        For Each b As Byte In bytesToHash
            strResult = strResult + b.ToString("x2")
        Next b

        Return strResult

    End Function

    Private Sub btnHash_Click(sender As Object, e As EventArgs) Handles btnHash.Click

        FileOpen(1, "users.txt", OpenMode.Random)
        FileOpen(2, "hashed.txt", OpenMode.Random)

        Dim userRec As recUserDetails

        For i = 1 To 1000 Step 1

            FileGet(1, userRec, i)
            userRec.Password = getSHA(userRec.Password)
            FilePut(2, userRec, i)

        Next i

        FileClose(1)
        FileClose(2)

    End Sub

End Class
