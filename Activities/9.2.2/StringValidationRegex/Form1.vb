Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ValidateCode()

    End Sub

    Private Sub ValidateCode()

        Dim code As String
        Dim pattern As Regex = New Regex("^[A-HJ-NP]\d{3}[A-HJ-NP]")

        code = InputBox("Code: ")

        While code <> "AMG"

            If pattern.IsMatch(code) Then

                MsgBox("Valid Code!")

            Else

                MsgBox("Invalid Code :(")

            End If

            code = InputBox("Code: ")

        End While

        Me.Close()

    End Sub

End Class
