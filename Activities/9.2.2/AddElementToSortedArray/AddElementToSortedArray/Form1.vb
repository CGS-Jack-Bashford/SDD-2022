Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        InsertElement()
        Debug.Print(String.Join(" ", Names))

    End Sub

    Dim Names As String() = {"Al", "Bob", "Cam", "Dave", "Ed"}
    Dim NewName As String = "Ben"

    Private Sub InsertElement()

        Dim Position As Integer
        LinearSearch(NewName, Position)
        'this returns the position in the array of names where the new name is to be inserted

        Dim First = 0
        Dim Last = Names.Length - 1
        Dim i = Last

        ReDim Preserve Names(Names.Length)

        Debug.Print(String.Join(" ", Names))

        While i >= Position
            Names(i + 1) = Names(i)
            i = i - 1
            Debug.Print(String.Join(" ", Names))
        End While

        Names(Position) = NewName
        'put the new name into its correct place

    End Sub

    Private Sub LinearSearch(ByVal RequiredName, ByRef i)
        i = 0
        Dim Found = False
        While Not Found And i < Names.Length
            If Names(i) < RequiredName Then
                i = i + 1
            Else
                Found = True
            End If
        End While
        If Not Found Then
            i = Names.Length
        End If
    End Sub

End Class
