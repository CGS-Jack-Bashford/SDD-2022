Imports System.Text.RegularExpressions

Public Class Form1

    Structure Highscore
        Public gameTime As Integer
        Public playerName As String
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
        arrHighscores(0) = New Highscore(4) {}
        arrHighscores(1) = New Highscore(4) {}
        arrHighscores(2) = New Highscore(4) {}

        ' Data Set 1

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 50
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstInput1)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput1)

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 50
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstExpected1)

        ' Data Set 2

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 20
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 40
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 21
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 21
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 12
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 12
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstInput2)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput2)

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 20
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 40
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 21
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 21
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 12
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 12
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstExpected2)

        ' Data Set 3

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 50
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 10
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 40
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 20
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 30
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 31
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 41
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 11
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 51
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 21
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 52
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 22
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 32


        DisplayHighscores(arrHighscores, lstInput3)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput3)

        arrHighscores(0)(0).playerName = "Bob"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Damon"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Edvin"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Cheryl"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Alfred"
        arrHighscores(0)(4).gameTime = 50
        arrHighscores(1)(0).playerName = "Henry"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "Jacob"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Frank"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "George"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Isaac"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Monty"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Olivia"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Ludwig"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstExpected3)

        ' Data Set 4

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 50
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 40
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 20
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 10
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 51
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 41
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 21
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 11
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 52
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 42
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 22
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 12


        DisplayHighscores(arrHighscores, lstInput4)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput4)

        arrHighscores(0)(0).playerName = "Edvin"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Damon"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Bob"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Alfred"
        arrHighscores(0)(4).gameTime = 50
        arrHighscores(1)(0).playerName = "Jacob"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "Isaac"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "George"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Frank"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Olivia"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Nathan"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Ludwig"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Kevin"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstExpected4)

        ' Data Set 5

        arrHighscores(0)(0).playerName = "Bob"
        arrHighscores(0)(0).gameTime = 20
        arrHighscores(0)(1).playerName = "Cheryl"
        arrHighscores(0)(1).gameTime = 30
        arrHighscores(0)(2).playerName = "Damon"
        arrHighscores(0)(2).gameTime = 40
        arrHighscores(0)(3).playerName = "Edvin"
        arrHighscores(0)(3).gameTime = 50
        arrHighscores(0)(4).playerName = "Alfred"
        arrHighscores(0)(4).gameTime = 10
        arrHighscores(1)(0).playerName = "George"
        arrHighscores(1)(0).gameTime = 21
        arrHighscores(1)(1).playerName = "Henry"
        arrHighscores(1)(1).gameTime = 31
        arrHighscores(1)(2).playerName = "Isaac"
        arrHighscores(1)(2).gameTime = 41
        arrHighscores(1)(3).playerName = "Jacob"
        arrHighscores(1)(3).gameTime = 51
        arrHighscores(1)(4).playerName = "Frank"
        arrHighscores(1)(4).gameTime = 11
        arrHighscores(2)(0).playerName = "Ludwig"
        arrHighscores(2)(0).gameTime = 22
        arrHighscores(2)(1).playerName = "Monty"
        arrHighscores(2)(1).gameTime = 32
        arrHighscores(2)(2).playerName = "Nathan"
        arrHighscores(2)(2).gameTime = 42
        arrHighscores(2)(3).playerName = "Olivia"
        arrHighscores(2)(3).gameTime = 52
        arrHighscores(2)(4).playerName = "Kevin"
        arrHighscores(2)(4).gameTime = 12


        DisplayHighscores(arrHighscores, lstInput5)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput5)

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 50
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 51
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 52

        DisplayHighscores(arrHighscores, lstExpected5)

        ' Data Set 6

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 10
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 11
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 12

        DisplayHighscores(arrHighscores, lstInput6)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput6)

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Edvin"
        arrHighscores(0)(1).gameTime = 10
        arrHighscores(0)(2).playerName = "Bob"
        arrHighscores(0)(2).gameTime = 20
        arrHighscores(0)(3).playerName = "Cheryl"
        arrHighscores(0)(3).gameTime = 30
        arrHighscores(0)(4).playerName = "Damon"
        arrHighscores(0)(4).gameTime = 40
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "Jacob"
        arrHighscores(1)(1).gameTime = 11
        arrHighscores(1)(2).playerName = "George"
        arrHighscores(1)(2).gameTime = 21
        arrHighscores(1)(3).playerName = "Henry"
        arrHighscores(1)(3).gameTime = 31
        arrHighscores(1)(4).playerName = "Isaac"
        arrHighscores(1)(4).gameTime = 41
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Olivia"
        arrHighscores(2)(1).gameTime = 12
        arrHighscores(2)(2).playerName = "Ludwig"
        arrHighscores(2)(2).gameTime = 22
        arrHighscores(2)(3).playerName = "Monty"
        arrHighscores(2)(3).gameTime = 32
        arrHighscores(2)(4).playerName = "Nathan"
        arrHighscores(2)(4).gameTime = 42

        DisplayHighscores(arrHighscores, lstExpected6)

        ' Data Set 7

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Bob"
        arrHighscores(0)(1).gameTime = 20
        arrHighscores(0)(2).playerName = "Cheryl"
        arrHighscores(0)(2).gameTime = 30
        arrHighscores(0)(3).playerName = "Damon"
        arrHighscores(0)(3).gameTime = 40
        arrHighscores(0)(4).playerName = "Edvin"
        arrHighscores(0)(4).gameTime = 10
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "George"
        arrHighscores(1)(1).gameTime = 21
        arrHighscores(1)(2).playerName = "Henry"
        arrHighscores(1)(2).gameTime = 31
        arrHighscores(1)(3).playerName = "Isaac"
        arrHighscores(1)(3).gameTime = 41
        arrHighscores(1)(4).playerName = "Jacob"
        arrHighscores(1)(4).gameTime = 11
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Ludwig"
        arrHighscores(2)(1).gameTime = 22
        arrHighscores(2)(2).playerName = "Monty"
        arrHighscores(2)(2).gameTime = 32
        arrHighscores(2)(3).playerName = "Nathan"
        arrHighscores(2)(3).gameTime = 42
        arrHighscores(2)(4).playerName = "Olivia"
        arrHighscores(2)(4).gameTime = 12

        DisplayHighscores(arrHighscores, lstInput7)

        For i = 0 To arrHighscores.Length - 1 Step 1
            SortHighscores(arrHighscores, i)
        Next

        DisplayHighscores(arrHighscores, lstOutput7)

        arrHighscores(0)(0).playerName = "Alfred"
        arrHighscores(0)(0).gameTime = 10
        arrHighscores(0)(1).playerName = "Edvin"
        arrHighscores(0)(1).gameTime = 10
        arrHighscores(0)(2).playerName = "Bob"
        arrHighscores(0)(2).gameTime = 20
        arrHighscores(0)(3).playerName = "Cheryl"
        arrHighscores(0)(3).gameTime = 30
        arrHighscores(0)(4).playerName = "Damon"
        arrHighscores(0)(4).gameTime = 40
        arrHighscores(1)(0).playerName = "Frank"
        arrHighscores(1)(0).gameTime = 11
        arrHighscores(1)(1).playerName = "Jacob"
        arrHighscores(1)(1).gameTime = 11
        arrHighscores(1)(2).playerName = "George"
        arrHighscores(1)(2).gameTime = 21
        arrHighscores(1)(3).playerName = "Henry"
        arrHighscores(1)(3).gameTime = 31
        arrHighscores(1)(4).playerName = "Isaac"
        arrHighscores(1)(4).gameTime = 41
        arrHighscores(2)(0).playerName = "Kevin"
        arrHighscores(2)(0).gameTime = 12
        arrHighscores(2)(1).playerName = "Olivia"
        arrHighscores(2)(1).gameTime = 12
        arrHighscores(2)(2).playerName = "Ludwig"
        arrHighscores(2)(2).gameTime = 22
        arrHighscores(2)(3).playerName = "Monty"
        arrHighscores(2)(3).gameTime = 32
        arrHighscores(2)(4).playerName = "Nathan"
        arrHighscores(2)(4).gameTime = 42

        DisplayHighscores(arrHighscores, lstExpected7)

    End Sub

    Private Sub DisplayHighscores(arrHighscores As Highscore()(), lstTarget As ListBox)

        lstTarget.Items.Clear()

        For i = 0 To arrHighscores.Length - 1 Step 1

            For j = 0 To arrHighscores(i).Length - 1 Step 1

                lstTarget.Items.Add(arrHighscores(i)(j).playerName & " | " & arrHighscores(i)(j).gameTime)

            Next j

        Next i

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        TestSortHighscores()

    End Sub

End Class