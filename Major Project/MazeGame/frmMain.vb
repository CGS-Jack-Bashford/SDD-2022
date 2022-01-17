Imports System.Text.RegularExpressions

Public Class frmMain

    Private Sub SetupGame(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim allChecksPassed As Boolean = True

        CheckSeed(allChecksPassed)

    End Sub

    Private Sub CheckSeed(ByRef checkPassed As Boolean)

        If SeedEntered() Then

            Dim enteredSeed As String = txtMazeSeed.Text

            If ValidateSeed(enteredSeed) Then

                Globals.mazeSeed = Convert.ToInt32(enteredSeed, 16)

            Else

                MsgBox("That seed is invalid. Please provide a 1-10 digit hexadecimal number.")

                checkPassed = False

            End If

        Else

            Dim generatedSeed As ULong = GenerateSeed()

            Globals.mazeSeed = generatedSeed

        End If

    End Sub

    Private Function SeedEntered() As Boolean

        Return Not String.IsNullOrEmpty(txtMazeSeed.Text)

    End Function

    Private Function ValidateSeed(enteredSeed As String) As Boolean

        Dim pattern As Regex = New Regex("^[0-9a-fA-F]{1,10}$")

        Return pattern.IsMatch(enteredSeed)

    End Function

    Private Function GenerateSeed() As ULong

        Dim seedRnd As New Random()

        Dim seedStr As String = ""
        Dim seedInt As ULong

        Dim i As Integer,
            currentVal As Integer,
            currentChar As Char

        For i = 1 To 10 Step 1

            currentVal = seedRnd.Next(0, 16)
            currentChar = Convert.ToString(currentVal, 16)
            seedStr = seedStr & currentChar

        Next i

        seedInt = Convert.ToUInt64(seedStr, 16)

        Return seedInt

    End Function

End Class