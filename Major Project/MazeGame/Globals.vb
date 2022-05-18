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

    ' Primitive data types

    Public playerName As String = ""
    Public difficulty As Integer     ' Difficulty will be in the range 1-4 inclusive, with 1, 2, and 3 representing 10, 20, and 30 maze sizes, and difficulty 4 representing the random difficulty.
    Public mazeSize As Integer       ' The maze size is stored in the range 0-2 inclusive, 0 represents 10x10 and so on.
    Public mazeSeed As ULong         ' The maze seed is stored as a ULong (unsigned 64-bit Integer), and displayed as a hexadecimal number on forms and in save files. 
    Public gameTime As Integer = 0   ' The game time is stored in seconds, and will be formatted using clean division & modulus operators for display in mm:ss format

    ' Data structures

    Structure Highscore

        Public playerName As String
        Public mazeSeed As Integer
        Public mazeSize As Integer
        Public gameTime As Integer

    End Structure

    Public arrHighscores(3, 5) As Highscore
    Public arrGameBoard(,) As Integer ' We define the gameboard array at the maximum size so that resizing impacts less on performance (since it'll always be a freeing of memory from the array, rather than a relocation and reallocation for the array).

    Public Sub ResetGame()

        playerName = ""
        difficulty = 0
        mazeSize = 0
        mazeSeed = 0
        gameTime = 0

        ReDim arrGameBoard(30, 30)

    End Sub

End Module
