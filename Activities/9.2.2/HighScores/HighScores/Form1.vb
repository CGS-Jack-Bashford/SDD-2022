﻿Public Class Form1

    Public Structure recHighScore

        Public name As String
        Public score As Integer

    End Structure

    Dim arrHighScores(6) As recHighScore

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        readHighScores()
        addNewScore()
        sortHighScores()
        displayHighScores()
        writeHighScores()

    End Sub

    Private Sub readHighScores()

        Dim i As Integer

        FileSystem.FileOpen(1, "hs.txt", OpenMode.Input)

        For i = 1 To 5 Step 1

            FileSystem.Input(1, arrHighScores(i).name)

        Next i

        For i = 1 To 5 Step 1

            FileSystem.Input(1, arrHighScores(i).score)

        Next i

        FileSystem.FileClose(1)

    End Sub

    Private Sub addNewScore()

        arrHighScores(6).name = "Fred"
        arrHighScores(6).score = 9

    End Sub

    Private Sub sortHighScores()

        Dim last As Integer = 6
        Dim swapped As Boolean = True

        While swapped

            swapped = False
            Dim i As Integer = 1

            While i < last

                If arrHighScores(i).score < arrHighScores(i + 1).score Then

                    Swap(arrHighScores(i), arrHighScores(i + 1))
                    swapped = True

                End If

                i += 1

            End While

            last -= 1

        End While

    End Sub

    Private Sub Swap(ByRef A As recHighScore, ByRef B As recHighScore)

        Dim Temp As recHighScore = A
        A = B
        B = Temp

    End Sub

    Private Sub displayHighScores()

        Dim i As Integer

        For i = 1 To 5 Step 1

            lstOutput.Items.Add(arrHighScores(i).name & ", " & arrHighScores(i).score)

        Next i

    End Sub

    Private Sub writeHighScores()

        FileSystem.FileOpen(1, "hs.txt", OpenMode.Output)

        Dim i As Integer

        For i = 1 To 5 Step 1

            FileSystem.PrintLine(1, arrHighScores(i).name)

        Next i

        For i = 1 To 5 Step 1

            FileSystem.WriteLine(1, arrHighScores(i).score)

        Next i

        FileSystem.FileClose(1)

    End Sub

End Class
