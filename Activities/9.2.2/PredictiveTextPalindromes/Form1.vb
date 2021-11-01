Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReadFile()
        DisplayResults()
        Me.Close()

    End Sub

    Private Sub ReadFile()

        FileOpen(1, "Dictionary.txt", OpenMode.Input)

        While Not EOF(1)

            CheckLine()

        End While

        FileClose(1)

    End Sub

    Private Sub DisplayResults()

        MsgBox("Word: " & longestWord & vbCrLf & "Sequence: " & longestSequence)

    End Sub

    Dim longestWord As String = ""
    Dim longestSequence As String

    Private Sub CheckLine()

        Dim word As String = ""
        Input(1, word)

        Dim isPalindrome As Boolean = CheckPalindrome(word)

        If Not isPalindrome Then

            Dim sequence As String = wordToSequence(word)
            Dim sequencePalindrome As Boolean = CheckPalindrome(sequence)

            If sequencePalindrome And word.Length > longestWord.Length Then

                longestWord = word
                longestSequence = sequence

            End If

        End If

    End Sub

#Region "Functions"

    Function CheckPalindrome(word As String) As Boolean

        Dim firstPtr As Integer = 0
        Dim lastPtr As Integer = word.Length - 1
        Dim charsEqual As Boolean = True

        While charsEqual And firstPtr < lastPtr

            If word(firstPtr) <> word(lastPtr) Then

                charsEqual = False

            End If

            firstPtr = firstPtr + 1
            lastPtr = lastPtr - 1

        End While

        Return charsEqual

    End Function

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

    Function wordToSequence(word As String) As String

        Dim sequence As String = ""

        For i = 0 To word.Length - 1 Step 1

            Dim c As Char = word(i)
            Dim n As Integer = letterToNumber(c)
            sequence = sequence & n.ToString()

        Next i

        Return sequence

    End Function

#End Region

End Class
