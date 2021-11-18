Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arrTemp(20, 12) As Single

        arrTemp(0, 1) = 34.8
        arrTemp(0, 2) = 35.4
        arrTemp(0, 3) = 34
        arrTemp(0, 4) = 26.6
        arrTemp(0, 5) = 22
        arrTemp(0, 6) = 17.1
        arrTemp(0, 7) = 15.7
        arrTemp(0, 8) = 17.8
        arrTemp(0, 9) = 25
        arrTemp(0, 10) = 28.8
        arrTemp(0, 11) = 33.2
        arrTemp(0, 12) = 35.2
        arrTemp(1, 1) = 39.6
        arrTemp(1, 2) = 34.7
        arrTemp(1, 3) = 29.3
        arrTemp(1, 4) = 28.1
        arrTemp(1, 5) = 21.3
        arrTemp(1, 6) = 19
        arrTemp(1, 7) = 17.8
        arrTemp(1, 8) = 20.2
        arrTemp(1, 9) = 25.2
        arrTemp(1, 10) = 25.8
        arrTemp(1, 11) = 28.2
        arrTemp(1, 12) = 34.1
        arrTemp(2, 1) = 34.8
        arrTemp(2, 2) = 30.4
        arrTemp(2, 3) = 33.4
        arrTemp(2, 4) = 27.1
        arrTemp(2, 5) = 22.9
        arrTemp(2, 6) = 19
        arrTemp(2, 7) = 17
        arrTemp(2, 8) = 20.6
        arrTemp(2, 9) = 23.6
        arrTemp(2, 10) = 29.5
        arrTemp(2, 11) = 34.6
        arrTemp(2, 12) = 37.1
        arrTemp(3, 1) = 39.7
        arrTemp(3, 2) = 34.3
        arrTemp(3, 3) = 28.2
        arrTemp(3, 4) = 24.4
        arrTemp(3, 5) = 22.8
        arrTemp(3, 6) = 17
        arrTemp(3, 7) = 16.6
        arrTemp(3, 8) = 15.8
        arrTemp(3, 9) = 25.9
        arrTemp(3, 10) = 24.5
        arrTemp(3, 11) = 33.3
        arrTemp(3, 12) = 35
        arrTemp(4, 1) = 38.1
        arrTemp(4, 2) = 39.8
        arrTemp(4, 3) = 33.3
        arrTemp(4, 4) = 30.6
        arrTemp(4, 5) = 19.9
        arrTemp(4, 6) = 17.3
        arrTemp(4, 7) = 15.6
        arrTemp(4, 8) = 21.4
        arrTemp(4, 9) = 23.5
        arrTemp(4, 10) = 30.4
        arrTemp(4, 11) = 36.7
        arrTemp(4, 12) = 33.7
        arrTemp(5, 1) = 38.8
        arrTemp(5, 2) = 34.6
        arrTemp(5, 3) = 34
        arrTemp(5, 4) = 29.7
        arrTemp(5, 5) = 24.5
        arrTemp(5, 6) = 19.4
        arrTemp(5, 7) = 18.1
        arrTemp(5, 8) = 21
        arrTemp(5, 9) = 23.4
        arrTemp(5, 10) = 26.4
        arrTemp(5, 11) = 28.7
        arrTemp(5, 12) = 38.3
        arrTemp(6, 1) = 39.2
        arrTemp(6, 2) = 38.4
        arrTemp(6, 3) = 33.8
        arrTemp(6, 4) = 25.3
        arrTemp(6, 5) = 19.1
        arrTemp(6, 6) = 15.4
        arrTemp(6, 7) = 15.6
        arrTemp(6, 8) = 19.9
        arrTemp(6, 9) = 24.8
        arrTemp(6, 10) = 31.8
        arrTemp(6, 11) = 35.2
        arrTemp(6, 12) = 36.1
        arrTemp(7, 1) = 39.3
        arrTemp(7, 2) = 34.1
        arrTemp(7, 3) = 33.7
        arrTemp(7, 4) = 27.4
        arrTemp(7, 5) = 22.2
        arrTemp(7, 6) = 14.6
        arrTemp(7, 7) = 16.7
        arrTemp(7, 8) = 22.5
        arrTemp(7, 9) = 22.5
        arrTemp(7, 10) = 31.1
        arrTemp(7, 11) = 33.4
        arrTemp(7, 12) = 35
        arrTemp(8, 1) = 35.3
        arrTemp(8, 2) = 29.8
        arrTemp(8, 3) = 35.8
        arrTemp(8, 4) = 24.1
        arrTemp(8, 5) = 21.1
        arrTemp(8, 6) = 16.7
        arrTemp(8, 7) = 16.6
        arrTemp(8, 8) = 17.2
        arrTemp(8, 9) = 26
        arrTemp(8, 10) = 29.7
        arrTemp(8, 11) = 32.3
        arrTemp(8, 12) = 30.9
        arrTemp(9, 1) = 38.2
        arrTemp(9, 2) = 39.9
        arrTemp(9, 3) = 31.7
        arrTemp(9, 4) = 28.1
        arrTemp(9, 5) = 19.7
        arrTemp(9, 6) = 16.3
        arrTemp(9, 7) = 17
        arrTemp(9, 8) = 19.1
        arrTemp(9, 9) = 24.9
        arrTemp(9, 10) = 28.9
        arrTemp(9, 11) = 37.9
        arrTemp(9, 12) = 38.2
        arrTemp(10, 1) = 38.6
        arrTemp(10, 2) = 33.4
        arrTemp(10, 3) = 29.3
        arrTemp(10, 4) = 25.5
        arrTemp(10, 5) = 21.7
        arrTemp(10, 6) = 16.8
        arrTemp(10, 7) = 15.5
        arrTemp(10, 8) = 15.3
        arrTemp(10, 9) = 21.6
        arrTemp(10, 10) = 24.7
        arrTemp(10, 11) = 28.2
        arrTemp(10, 12) = 34.8
        arrTemp(11, 1) = 37.6
        arrTemp(11, 2) = 36.8
        arrTemp(11, 3) = 29
        arrTemp(11, 4) = 24.5
        arrTemp(11, 5) = 20.8
        arrTemp(11, 6) = 17
        arrTemp(11, 7) = 15.9
        arrTemp(11, 8) = 21.2
        arrTemp(11, 9) = 26
        arrTemp(11, 10) = 28.9
        arrTemp(11, 11) = 32.1
        arrTemp(11, 12) = 29.2
        arrTemp(12, 1) = 33.9
        arrTemp(12, 2) = 30.7
        arrTemp(12, 3) = 27.3
        arrTemp(12, 4) = 26.7
        arrTemp(12, 5) = 22.8
        arrTemp(12, 6) = 16.2
        arrTemp(12, 7) = 16.2
        arrTemp(12, 8) = 18.4
        arrTemp(12, 9) = 23.7
        arrTemp(12, 10) = 29.7
        arrTemp(12, 11) = 34.5
        arrTemp(12, 12) = 34.2
        arrTemp(13, 1) = 40.1
        arrTemp(13, 2) = 35.5
        arrTemp(13, 3) = 31
        arrTemp(13, 4) = 27.6
        arrTemp(13, 5) = 23.3
        arrTemp(13, 6) = 16.4
        arrTemp(13, 7) = 16.5
        arrTemp(13, 8) = 20.2
        arrTemp(13, 9) = 25.4
        arrTemp(13, 10) = 31.4
        arrTemp(13, 11) = 31.7
        arrTemp(13, 12) = 37.1
        arrTemp(14, 1) = 40
        arrTemp(14, 2) = 38.4
        arrTemp(14, 3) = 28.7
        arrTemp(14, 4) = 25.9
        arrTemp(14, 5) = 22
        arrTemp(14, 6) = 16
        arrTemp(14, 7) = 16.9
        arrTemp(14, 8) = 17.8
        arrTemp(14, 9) = 25.4
        arrTemp(14, 10) = 31.7
        arrTemp(14, 11) = 37.8
        arrTemp(14, 12) = 32.6
        arrTemp(15, 1) = 34.1
        arrTemp(15, 2) = 33.9
        arrTemp(15, 3) = 31.5
        arrTemp(15, 4) = 26.4
        arrTemp(15, 5) = 22.8
        arrTemp(15, 6) = 17.1
        arrTemp(15, 7) = 14.9
        arrTemp(15, 8) = 20.8
        arrTemp(15, 9) = 22.1
        arrTemp(15, 10) = 32.7
        arrTemp(15, 11) = 34.5
        arrTemp(15, 12) = 36.6
        arrTemp(16, 1) = 38.7
        arrTemp(16, 2) = 36.9
        arrTemp(16, 3) = 34.8
        arrTemp(16, 4) = 29.9
        arrTemp(16, 5) = 22.9
        arrTemp(16, 6) = 15.3
        arrTemp(16, 7) = 18.7
        arrTemp(16, 8) = 18.7
        arrTemp(16, 9) = 19.9
        arrTemp(16, 10) = 25.2
        arrTemp(16, 11) = 31.6
        arrTemp(16, 12) = 33.2
        arrTemp(17, 1) = 38.4
        arrTemp(17, 2) = 41.1
        arrTemp(17, 3) = 31.6
        arrTemp(17, 4) = 24.2
        arrTemp(17, 5) = 19.5
        arrTemp(17, 6) = 16.9
        arrTemp(17, 7) = 16.5
        arrTemp(17, 8) = 18.9
        arrTemp(17, 9) = 29.4
        arrTemp(17, 10) = 27.2
        arrTemp(17, 11) = 30
        arrTemp(17, 12) = 33.7
        arrTemp(18, 1) = 39.4
        arrTemp(18, 2) = 35.9
        arrTemp(18, 3) = 33.3
        arrTemp(18, 4) = 31.6
        arrTemp(18, 5) = 24.1
        arrTemp(18, 6) = 16.1
        arrTemp(18, 7) = 18.7
        arrTemp(18, 8) = 18.5
        arrTemp(18, 9) = 23.9
        arrTemp(18, 10) = 30.8
        arrTemp(18, 11) = 33
        arrTemp(18, 12) = 36.9
        arrTemp(19, 1) = 40.8
        arrTemp(19, 2) = 35.6
        arrTemp(19, 3) = 34.6
        arrTemp(19, 4) = 26.5
        arrTemp(19, 5) = 22.7
        arrTemp(19, 6) = 17.6
        arrTemp(19, 7) = 17.1
        arrTemp(19, 8) = 17.9
        arrTemp(19, 9) = 24.9
        arrTemp(19, 10) = 31.2
        arrTemp(19, 11) = 38
        arrTemp(19, 12) = 39.8
        arrTemp(20, 1) = 43.3
        arrTemp(20, 2) = 41.5
        arrTemp(20, 3) = 30.2
        arrTemp(20, 4) = 25.7
        arrTemp(20, 5) = 19.8
        arrTemp(20, 6) = 16.8
        arrTemp(20, 7) = 16
        arrTemp(20, 8) = 18.9
        arrTemp(20, 9) = 23.7
        arrTemp(20, 10) = 26.0
        arrTemp(20, 11) = 34.9
        arrTemp(20, 12) = 33.6

        Dim maxTemp As Single = arrTemp(0, 1)
        Dim minTemp As Single = arrTemp(0, 1)
        Dim totalTemp As Single = 0
        Dim octMax As Single = arrTemp(0, 10)

        Dim maxTempArr(12) As (Single, Integer)

        Dim year As Integer
        Dim month As Integer
        Dim temp As Single

        For year = 0 To 20 Step 1

            For month = 1 To 12 Step 1

                temp = arrTemp(year, month)

                If temp > maxTemp Then
                    maxTemp = temp
                End If

                If temp < minTemp Then
                    minTemp = temp
                End If

                If temp > maxTempArr(month).Item1 Then
                    maxTempArr(month) = (temp, year)
                End If

                If month = 10 AndAlso temp > octMax Then
                    octMax = temp
                End If

                totalTemp = totalTemp + temp

            Next month

        Next year

        Dim averageTemp As Single = totalTemp / (21 * 12)

        Debug.Print("Maximum temperature recorded: " & maxTemp)
        Debug.Print("Minimum temperature recorded: " & minTemp)
        Debug.Print("Average temperature recorded: " & averageTemp)
        Debug.Print("Maximum October temperature recorded: " & octMax)
        Debug.Print("-- Maximum temperatures for each month --")

        Dim monthNamesArr As String() = {"", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For month = 1 To 12 Step 1

            Debug.Print("The maximum " & monthNamesArr(month) & " temperature is " & maxTempArr(month).Item1 & ". This occurred in " & (maxTempArr(month).Item2) + 2000)

        Next month

    End Sub

End Class
