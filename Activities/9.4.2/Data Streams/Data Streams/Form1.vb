Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dataStream$ = TextBox1.Text

        Dim header$ = Strings.Left(dataStream, 8)
        Dim packageStart$ = Strings.Left(header, 3)

        If packageStart <> "101" Then

            MsgBox("Invalid header")

        Else

            Dim numChars = CInt(ConvertBinaryToDecimal(Strings.Right(header, 5)))
            Dim dataLengthInBits = 2 + (7 * numChars)

            Dim dataBlock$ = Strings.Left(Strings.Right(dataStream, 8 + dataLengthInBits), dataLengthInBits)

            Dim formatCode$ = Strings.Left(dataBlock, 2)
            Dim charCodes$ = Strings.Right(dataBlock, dataLengthInBits - 2)

            Dim trailer$ = Strings.Right(dataStream, 8)

            Dim CRC = Strings.Left(trailer, 4)
            Dim EOP = Strings.Right(trailer, 4)

            If EOP <> "1101" Then

                MsgBox("Invalid trailer")

            ElseIf CInt(ConvertBinaryToDecimal(CRC)) <> CountChars(dataBlock, "1") Mod 13 Then

                MsgBox("Corrupt data. Please resend")

            Else

                Select Case formatCode
                    Case "00" : Label1.Font = New Font(Label2.Font, FontStyle.Regular)
                    Case "01" : Label1.Font = New Font(Label2.Font, FontStyle.Bold)
                    Case "10" : Label1.Font = New Font(Label2.Font, FontStyle.Italic)
                    Case "11" : Label1.Font = New Font(Label2.Font.FontFamily, 20)
                End Select

                Label1.Text = ""

                For i = numChars To 0 Step -1

                    Label1.Text = Label1.Text & Chr(ConvertBinaryToDecimal(Strings.Left(Strings.Right(charCodes, i * 7), 7)))

                Next

            End If

        End If

    End Sub

    Public Function CountChars(ByVal s As String, ByVal c As Char) As Integer

        Dim count As Integer = 0

        For i = 0 To s.Length - 1 Step 1
            If s(i) = c Then
                count += 1
            End If
        Next

        Return count

    End Function

    Public Function ConvertDecimalToBinary(ByVal Value As String, Optional ByVal x As Integer = 0) As String
        Dim iVal#, temp#, ret%, i%, Str$
        Dim BinVal%()

        iVal = Value
        Do
            temp = iVal / 2
            ret = InStr(temp, ".")
            If ret > 0 Then
                temp = Strings.Left(temp, ret - 1)
            End If
            ret = iVal Mod 2
            ReDim Preserve BinVal(i)
            BinVal(i) = ret
            i = i + 1
            iVal = temp
        Loop While temp > 0
        For i = UBound(BinVal) To 0 Step -1
            Str = Str + CStr(BinVal(i))
        Next
        If x = 3 Then
            Select Case Len(Str) Mod 3
                Case 1
                    Str = "00" + Str
                Case 2
                    Str = "0" + Str
            End Select
        ElseIf x = 4 Then
            Select Case Len(Str) Mod 4
                Case 1
                    Str = "000" + Str
                Case 2
                    Str = "00" + Str
                Case 3
                    Str = "0" + Str
            End Select
        End If
        ConvertDecimalToBinary = Str

    End Function

    Public Function ConvertBinaryToDecimal(ByVal BinVal As String) As String
        Dim iVal#, temp#, i%, Length%

        Length = Len(BinVal)
        For i = 0 To Length - 1
            temp = CInt(Mid(BinVal, Length - i, 1))
            iVal = iVal + (temp * (2 ^ i))
        Next i
        ConvertBinaryToDecimal = iVal
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim encodedStream$ = "101"

        Dim textToEncode$ = TextBox2.Text

        encodedStream += ConvertDecimalToBinary(textToEncode.Length).PadLeft(5, "0")

        Dim dataBlock$ = ""

        Dim formatting = ConvertDecimalToBinary(ComboBox1.SelectedIndex).PadLeft(2, "0")

        Dim charCodes$ = ""

        For i = 0 To textToEncode.Length - 1

            Dim binaryRepresentation = Strings.Right(ConvertDecimalToBinary(Asc(textToEncode(i))), 7)
            charCodes += binaryRepresentation

        Next

        dataBlock += formatting + charCodes

        Dim CRC% = dataBlock.Replace("0", "").Length Mod 13

        encodedStream += dataBlock + ConvertDecimalToBinary(CRC).PadLeft(4, "0") + "1101"

        Debug.Print(encodedStream)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.SelectedIndex = 0

    End Sub
End Class
