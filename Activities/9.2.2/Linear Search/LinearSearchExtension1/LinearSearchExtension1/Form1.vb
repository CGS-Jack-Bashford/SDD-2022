Public Class Form1

    Dim arrNum As Integer() = {23, 56, 32, 87, -1005, 60000, -512}
    Dim toFind As Integer = 3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.Print(locateIndex(arrNum, toFind))

    End Sub

    Function locateIndex(ByRef arr As Integer(), ByVal search As Integer) As Integer

        Dim found As Boolean = False
        Dim idx As Integer = 0

        While idx < arr.Length And Not found

            If arr(idx) = search Then

                found = True

            Else

                idx += 1

            End If

        End While

        If Not found Then
            Return -1
        Else
            Return idx
        End If

    End Function

End Class
