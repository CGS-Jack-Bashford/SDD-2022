Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        Debug.Print(Rnd())
        Randomize(1)
        Debug.Print(Rnd())

    End Sub
End Class
