Module Globals
    ' Information required by all forms is stored here, to avoid messily passing it between forms as parameters.

    ' All the application colors are stored here, in a Dictionary of Color structures accessible via their names (to avoid hard-coding an array's indices, names can be easily found and replaced if necessary throughout the entire program).
    Public applicationColors = New Dictionary(Of String, Color) From {
        {"green", Color.FromArgb(&HFF, &H0, &H64, &H0)},
        {"yellow", Color.FromArgb(&HFF, &HFF, &HFF, &H0)},
        {"red", Color.FromArgb(&HFF, &HFF, &H0, &H0)},
        {"orange", Color.FromArgb(&HFF, &HFF, &HA5, &H0)},
        {"gold", Color.FromArgb(&HFF, &HFF, &HD7, &H0)},
        {"silver", Color.FromArgb(&HFF, &HC0, &HC0, &HC0)},
        {"bronze", Color.FromArgb(&HFF, &HCD, &H7F, &H32)}
    }

    ' Primitive data typed global information required by all forms
    Public playerName As String = ""
    Public difficulty As Integer     ' Difficulty will be in the range 1-4 inclusive, with 1, 2, and 3 representing 10, 20, and 30 maze sizes, and difficulty 4 representing the random difficulty.
    Public mazeSize As Integer       ' The maze size is stored in the range 0-2 inclusive, 0 represents 10x10 and so on.
    Public mazeSeed As ULong         ' The maze seed is stored as a ULong (unsigned 64-bit Integer), and displayed as a hexadecimal number on forms and in the highscores.txt file. 
    Public gameTime As Integer = 0   ' The game time is stored in seconds, and will be formatted using clean division & modulus operators for display in mm:ss format. For this reason, no game longer than 1 hour can exist, hence the timeout in frmGame

    ' Data structures (arrays, records, arrays of records) required by all forms
    Structure Highscore

        Public playerName As String
        Public mazeSeed As ULong
        Public mazeSize As Integer
        Public gameTime As Integer

    End Structure

    Public arrHighscores As Highscore()() = New Highscore(2)() {}
    ' We define the gameboard array at the maximum size so that resizing impacts less on performance (since it'll always be a freeing of memory from the array
    ' rather than a relocation and reallocation for the array).
    Public arrGameBoard(,) As Integer

    ''' <summary>
    ''' A bubble sort of the sub-array of arrHighscores indicated by the index sizeToSort
    ''' </summary>
    ''' <param name="arrHighscores">The jagged 2-dimensional array of highscores to sort</param>
    ''' <param name="sizeToSort">The index of arrHighscores containing the specific maze sizes to sort</param>
    Public Sub SortHighscores(ByRef arrHighscores As Highscore()(), ByVal sizeToSort As Integer)

        ' Define the unsorted partition, a swapped flag (indicating if the array is sorted or not), and the counter for the internal iteration of the array
        Dim last As Integer = arrHighscores(sizeToSort).Length - 1
        Dim swapped As Boolean = True
        Dim i As Integer = 0

        While swapped

            swapped = False
            i = 0

            ' Swap all out-of-order elements in the array, up until the unsorted partition
            While i < last

                If arrHighscores(sizeToSort)(i).gameTime > arrHighscores(sizeToSort)(i + 1).gameTime Then
                    Swap(arrHighscores, sizeToSort, i, i + 1)
                    swapped = True
                End If

                i = i + 1

            End While

            ' Decrement the unsorted partition (increase the size of the sorted section by 1) as the next sorted element has 'bubbled' to the top.
            last = last - 1

        End While

    End Sub

    ''' <summary>
    ''' Swaps the two elements at indices idxA and idxB in arrHighscores(size)
    ''' </summary>
    ''' <param name="size">The maze size / index of arrHighscores to reference</param>
    ''' <param name="idxA">Index 1 to swap</param>
    ''' <param name="idxB">Index 2 to swap</param>
    Public Sub Swap(arrHighscores As Highscore(,)(), size As Integer, idxA As Integer, idxB As Integer)

        Dim temp As Highscore = arrHighscores(size)(idxA)
        arrHighscores(size)(idxA) = arrHighscores(size)(idxB)
        arrHighscores(size)(idxB) = temp

    End Sub

End Module
