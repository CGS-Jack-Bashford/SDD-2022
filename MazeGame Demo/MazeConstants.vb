Module MazeConstants

    ' Define the four cardinal directions that will be used in the generation and playing of the maze
    Public N As Integer = 1
    Public E As Integer = 2
    Public S As Integer = 4
    Public W As Integer = 8

    ' Separate the directions into their components (x and y) for easy update of player coordinate values
    Public Horizontal = New Dictionary(Of Integer, Integer) From {
        {N, 0}, {S, 0}, {E, 1}, {W, -1}
    }

    Public Vertical = New Dictionary(Of Integer, Integer) From {
        {N, -1}, {S, 1}, {E, 0}, {W, 0}
    }

    ' Map the opposite value so that the generation step is easier (as the opposite wall of the new cell must be broken, relative to the 'normal' direction wall of the current cell)
    Public Opposite = New Dictionary(Of Integer, Integer) From {
        {N, S}, {S, N}, {E, W}, {W, E}
    }

End Module
