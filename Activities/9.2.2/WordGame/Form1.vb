Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim words As String()
        Dim word As String
        ReadFileIntoArray(words)
        word = LocateWord(words)

    End Sub

    Private Sub ReadFileIntoArray(ByRef words As String())

        FileOpen(1, "Dictionary.txt", OpenMode.Input)

        While Not EOF(1)

            ReDim Preserve words(words.Length)
            FileSystem.Input(1, words(words.Length - 1))

        End While

        FileClose(1)

    End Sub

    Function LocateWord(ByVal words As String()) As String



    End Function

    Function ContainsSelf(ByVal word As String, ByVal words As String()) As Boolean

        Dim idxToRemove

        If BinarySearch(words, word) > -1 Then ' This word is valid itself

            Dim i As Integer

            For i = 0 To word.Length - 1 Step 1

                Dim newWord = word.Remove(i, 1)

                If ContainsSelf(newWord, words) Then

                    idxToRemove = i

                End If

            Next i

        Else

            Return False

        End If

    End Function

    Function BinarySearch(list, toFind) As Integer

        Dim lower = 0
        Dim upper = list.Length - 1
        Dim middle As Integer
        Dim found As Boolean = False
        Dim positionFound As Integer = -1

        Do

            middle = Int((upper + lower) / 2)

            If toFind = list(middle) Then

                found = True
                positionFound = middle

            Else

                If toFind < list(middle) Then

                    upper = middle - 1

                Else

                    lower = middle + 1

                End If

            End If

        Loop Until found Or lower > upper

        Return positionFound

    End Function

End Class
