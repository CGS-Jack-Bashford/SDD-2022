Module MazeConstants

    Public N As Integer = 1
    Public E As Integer = 2
    Public S As Integer = 4
    Public W As Integer = 8

    Public Horizontal = New Dictionary(Of Integer, Integer) From {
        {N, 0}, {S, 0}, {E, 1}, {W, -1}
    }

    Public Vertical = New Dictionary(Of Integer, Integer) From {
        {N, 1}, {S, -1}, {E, 0}, {W, 0}
    }

    Public Opposite = New Dictionary(Of Integer, Integer) From {
        {N, S}, {S, N}, {E, W}, {W, E}
    }

End Module
