Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim words As String() = {"educated"}

    Function letterToNumber(letter As Char) As Integer

        Dim number As Integer

        Select Case letter
            Case "A" To "C" : number = 2
            Case "D" To "F" : number = 3
            Case "G" To "I" : number = 4
            Case "J" To "L" : number = 5
            Case "M" To "O" : number = 6
            Case "P" To "S" : number = 7
            Case "T" To "V" : number = 8
            Case "W" To "Z" : number = 9
        End Select

        Return number

    End Function

End Class
