Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim test1 As Integer() = {6, 4, 1, 8, 7, 8, 4, 0, 1, 0}
        Dim test2 As Integer() = {3, 2, -1, 4, 8, 1, 999, 2, 3, 4}
        Dim test3 As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 1}

        Dim arrTestData As Integer()() = {test1, test2, test3}

        Dim arrExpectedValues As Integer() = {8, 999, 9}

        FindMaxDriver(arrTestData, arrExpectedValues)

    End Sub

    Function FindMax(arr As Integer()) As Integer

        Dim max As Integer

        If arr.Length < 1 Then
            max = 0
        Else
            max = arr(0)
        End If

        For i = 0 To arr.Length - 1 Step 1

            If arr(i) > max Then

                max = arr(i)

            End If

        Next i

        Return max

    End Function

    'Sub FindMaxDriver(arrTestData As Integer()(), arrExpectedValues As Integer())

    'For i = 0 To arrTestData.Length - 1 Step 1

    'Dim arr As Integer() = arrTestData(i)

    'Debug.Print("Test case " & i & ", expected value " & arrExpectedValues(i) & " actual output " & FindMax(arrTestData(i)))

    'Next i

    'End Sub

    Private Sub FindMaxDriver()
        Dim ArrInput As Integer(,) = {{1, 2, 3, 4, 5}, {5, 1, 2, 3, 5}, {4, 4, 4, 4, 4}, {-6, -4, -2, -1, -3}, {3, 2, 2, 1, 0}}
        Dim ExpectedOutput As Integer() = {5, 5, 4, -1, 3}

        For i = 0 To 4
            Dim TestArr As Integer() = {}
            For n = 0 To 4
                TestArr(n) = ArrInput(i, n)
            Next n
            Dim Result = FindMax(TestArr)
            Debug.WriteLine(ExpectedOutput(i) & "," & Result)
        Next i
    End Sub

End Class
