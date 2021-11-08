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

End Class
