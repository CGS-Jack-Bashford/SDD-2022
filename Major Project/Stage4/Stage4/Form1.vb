Imports System.Text.RegularExpressions

Public Class Form1

    Structure Highscore
        Public gameTime As Integer
        Public playerName As Integer
    End Structure

    Public Sub SortHighscores(ByRef arrHighscores As Highscore()(), ByVal sizeToSort As Integer)
        Dim last As Integer = arrHighscores(sizeToSort).Length - 1
        Dim swapped As Boolean = True
        Dim i As Integer = 0
        While swapped
            swapped = False
            i = 0
            While i < last
                If arrHighscores(sizeToSort)(i).gameTime > arrHighscores(sizeToSort)(i + 1).gameTime Then
                    Swap(arrHighscores, sizeToSort, i, i + 1)
                    swapped = True
                End If
                i = i + 1
            End While
            last = last - 1
        End While
    End Sub
    ' Swap was included as it's a dependency of this function
    Public Sub Swap(arrHighscores As Highscore()(), size As Integer, idxA As Integer, idxB As Integer)
        Dim temp As Highscore = arrHighscores(size)(idxA)
        arrHighscores(size)(idxA) = arrHighscores(size)(idxB)
        arrHighscores(size)(idxB) = temp
    End Sub

    Private Sub TestSortHighscores()

        Dim arrHighscores As Highscore()() = New Highscore(2)() {}
        arrHighscores(0) = New Highscore(5) {}
        arrHighscores(1) = New Highscore(5) {}
        arrHighscores(2) = New Highscore(5) {}

#Region "Assignment of Data Set 1"

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0, 0).gameTime = 10
        arrHighscores(0, 1).playerName = "Bob"
        arrHighscores(0, 1).gameTime = 20
        arrHighscores(0, 2).playerName = "Cheryl"
        arrHighscores(0, 2).gameTime = 30
        arrHighscores(0, 3).playerName = "Damon"
        arrHighscores(0, 3).gameTime = 40
        arrHighscores(0, 4).playerName = "Edvin"
        arrHighscores(0, 4).gameTime = 50
        arrHighscores(1, 0).playerName = "Frank"
        arrHighscores(1, 0).gameTime = 11
        arrHighscores(1, 1).playerName = "George"
        arrHighscores(1, 1).gameTime = 21
        arrHighscores(1, 2).playerName = "Henry"
        arrHighscores(1, 2).gameTime = 31
        arrHighscores(1, 3).playerName = "Isaac"
        arrHighscores(1, 3).gameTime = 41
        arrHighscores(1, 4).playerName = "Jacob"
        arrHighscores(1, 4).gameTime = 51
        arrHighscores(2, 0).playerName = "Kevin"
        arrHighscores(2, 0).gameTime = 12
        arrHighscores(2, 1).playerName = "Ludwig"
        arrHighscores(2, 1).gameTime = 22
        arrHighscores(2, 2).playerName = "Monty"
        arrHighscores(2, 2).gameTime = 32
        arrHighscores(2, 3).playerName = "Nathan"
        arrHighscores(2, 3).gameTime = 42
        arrHighscores(2, 4).playerName = "Olivia"
        arrHighscores(2, 4).gameTime = 52


#End Region

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        TestSortHighscores()

    End Sub
End Class