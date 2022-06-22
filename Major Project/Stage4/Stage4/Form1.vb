Imports System.Text.RegularExpressions

Public Class Form1

    Private Function ValidateName(ByVal enteredName As String, ByRef playerName As String) As Boolean

        Dim checkPassed As Boolean = True

        ' Match the entered name against the pattern describing alphanumeric digits or underscores, 1-16 characters, for the entire string (i.e. not a substring, the whole string)

        Dim validNamePattern As Regex = New Regex("^[a-zA-Z0-9_]{1,16}$")
        If Not validNamePattern.IsMatch(enteredName) Then
            checkPassed = False
        Else
            ' If the name is valid, assign it to the playerName variable and return True
            playerName = enteredName
        End If

        Return checkPassed

    End Function

    Private Sub TestValidateName()

        Dim testDataArr As String() = {
        "", " ", "a", "abcdefghijklmno", "abcdefghijklmnop", "abcdefghijklmnopq", "abCDEF_1234_"
    }

        Dim expectedOutputArr As Boolean() = {
        False, False, True, True, True, False, True, True, False, True, True, True
    }

        Dim playerName As String

        For i = 0 To testDataArr.Length - 1 Step 1
            playerName = "Unassigned"
            lstInput1.Items.Add("""" & testDataArr(i) & """")
            lstOutput1.Items.Add(ValidateName(testDataArr(i), playerName))
            lstExpected1.Items.Add(expectedOutputArr(i))
            ListBox1.Items.Add(playerName)
        Next

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs)

        TestValidateName()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestValidateName()
    End Sub
End Class