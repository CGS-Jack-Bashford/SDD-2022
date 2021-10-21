Public Class frmMain

    Dim nums = {186, 180, 939, 358, 804, 665, 502, 957, 176, 3, 860, 741, 879, 513, 919, 568, 263, 299, 243, 905, 27, 529, 887, 53, 995, 200, 836, 59, 691, 823, 398, 892, 205, 521, 758, 222, 27, 727, 640, 937, 962, 818, 458, 356, 990, 771, 600, 923, 950, 116, 528, 99, 208, 293, 175, 35, 73, 782, 725, 583, 568, 239, 247, 174, 307, 219, 784, 101, 662, 983, 462, 777, 92, 315, 897, 625, 509, 217, 666, 345, 804, 865, 920, 435, 219, 242, 235, 41, 79, 371, 694, 346, 492, 223, 770, 998, 39, 943, 39, 305, 132, 210, 873, 201, 688, 225, 308, 356, 974, 18, 980, 92, 36, 544, 563, 221, 885, 257, 482, 261, 711, 721, 740, 8, 755, 94, 587, 855, 109, 235, 408, 798, 632, 557, 669, 595, 375, 685, 941, 113, 415, 451, 58, 509, 721, 736, 232, 518, 765, 198, 505, 784, 900, 994, 279, 874, 138, 168, 785, 343, 853, 505, 241, 966, 114, 324, 176, 48, 805, 807, 822, 552, 410, 241, 767, 633, 378, 740, 67, 40, 269, 814, 834, 776, 466, 453, 931, 345, 96, 228, 746, 906, 938, 285, 209, 633, 538, 998, 131, 655, 436, 486, 676, 998, 395, 158, 271, 59, 817, 947, 543, 289, 29, 901, 947, 899, 9, 393, 564, 626, 181, 244, 214, 816, 332, 728, 400, 327, 362, 534, 815, 65, 550, 467, 87, 272, 214, 864, 224, 45, 216, 460, 703, 947, 514, 706, 526, 984, 64, 336, 583, 676, 731, 341, 617, 410, 511, 359, 679, 797, 285, 886, 438, 274, 533, 656, 916, 774, 926, 2, 220, 878, 465, 978, 633, 521, 901, 586, 967, 958, 498, 464, 470, 416, 795, 20, 641, 575, 925, 80, 286, 779, 239, 790, 774, 679, 397, 686, 962, 809, 866, 547, 490, 481, 749, 915, 188, 233, 189, 914, 141, 10, 161, 312, 572, 180, 314, 627, 45, 483, 705, 414, 687, 15, 636, 798, 42, 369, 554, 728, 883, 165, 943, 397, 845, 272, 388, 782, 974, 161, 575, 240, 400, 20, 783, 705, 146, 420, 556, 74, 739, 579, 629, 13, 683, 518, 857, 558, 41, 681, 841, 556, 355, 948, 199, 221, 872, 277, 919, 808, 572, 629, 61, 694, 836, 227, 126, 945, 644, 661, 791, 807, 104, 812, 331, 405, 756, 86, 997, 346, 535, 990, 795, 861, 492, 654, 618, 548, 384, 492, 441, 819, 17, 854, 333, 644, 793, 157, 383, 251, 256, 706, 226, 28, 558, 123, 765, 993, 675, 73, 859, 850, 886, 763, 175, 813, 508, 503, 174, 117, 116, 488, 191, 361, 526, 831, 872, 605, 622, 790, 826, 447, 699, 85, 183, 162, 385, 179, 917, 314, 348, 405, 196, 201, 937, 853, 741, 874, 632, 15, 146, 470, 665, 274, 392, 82, 472, 480, 326, 395, 690, 990, 706, 901, 256, 767, 532, 577, 799, 361, 765, 530, 922, 842, 204, 255, 145, 48, 273, 863, 274, 842, 664, 797, 694, 410, 332, 351, 617, 35, 125, 542, 643, 170, 402, 712, 69, 106, 370, 559, 272, 996, 492, 186, 142, 501, 266, 127, 969, 870, 850, 271, 442, 845, 522, 30, 375, 364, 704, 137, 585, 684, 352, 943, 908, 219, 823, 150, 675, 51, 950, 522, 101, 845, 949, 207, 945, 617, 944, 972, 498, 620, 372, 820, 403, 424, 232, 187, 85, 122, 194, 136, 593, 466, 861, 768, 460, 678, 54, 345, 802, 599, 867, 488, 228, 837, 364, 154, 319, 564, 225, 16, 340, 678, 335, 280, 600, 97, 326, 970, 353, 52, 315, 146, 425, 405, 642, 620, 823, 154, 257, 223, 400, 496, 483, 799, 317, 54, 309, 719, 403, 119, 9, 839, 753, 53, 853, 532, 819, 327, 917, 605, 55, 10, 497, 691, 663, 910, 444, 942, 333, 3, 820, 697, 942, 193, 610, 92, 70, 967, 905, 478, 840, 979, 857, 911, 28, 175, 939, 879, 599, 607, 501, 943, 862, 703, 421, 901, 162, 409, 639, 672, 646, 245, 758, 104, 953, 53, 442, 513, 800, 922, 289, 894, 380, 529, 984, 367, 125, 949, 21, 614, 903, 780, 14, 797, 936, 299, 607, 634, 778, 246, 341, 153, 498, 741, 359, 892, 810, 800, 734, 194, 255, 874, 326, 568, 731, 856, 497, 45, 558, 47, 724, 830, 30, 628, 136, 544, 876, 288, 254, 857, 347, 820, 777, 289, 710, 615, 88, 565, 774, 227, 232, 966, 684, 373, 567, 734, 662, 18, 893, 767, 522, 462, 888, 482, 777, 693, 851, 964, 913, 589, 320, 265, 911, 976, 902, 951, 452, 926, 731, 862, 286, 147, 356, 333, 161, 801, 465, 20, 358, 561, 804, 870, 285, 302, 847, 705, 862, 361, 247, 339, 358, 915, 867, 162, 197, 650, 267, 637, 748, 591, 801, 203, 503, 601, 129, 691, 160, 853, 834, 439, 19, 281, 982, 988, 818, 836, 952, 377, 580, 191, 575, 795, 299, 380, 641, 587, 343, 758, 141, 377, 234, 559, 179, 375, 90, 307, 357, 795, 367, 277, 564, 647, 715, 247, 551, 86, 678, 798, 345, 927, 725, 488, 556, 898, 544, 361, 914, 688, 875, 335, 874, 891, 171, 234, 24, 467, 260, 370, 61, 483, 763, 856, 579, 442, 487, 64, 495, 741, 143, 929, 982, 405, 752, 142, 933, 498, 821, 607, 567, 348, 937, 934, 520, 995, 703, 146, 910, 67, 63, 230, 159, 641, 934, 646, 52, 511, 700, 388, 403, 675, 596, 778, 911, 792, 192, 698, 279, 825, 222, 602, 429, 62, 768, 260, 701, 262, 359, 873, 238, 691, 927, 873, 393, 428, 651, 460, 866, 438, 648, 698, 461, 535, 158, 750, 793, 563, 316, 692, 50, 831, 900, 171, 866, 63, 428, 66, 729, 925, 823, 220, 875, 477, 448, 277, 512, 741, 686, 603, 327, 949, 402, 307, 696, 928, 573, 401, 681, 504, 55, 224, 897, 790, 14, 346, 612, 698, 774, 292, 969, 35, 932, 633, 61, 122, 429, 123, 703, 937, 885, 859, 121, 418, 915, 631, 470, 704, 339, 988}

    Private Sub updateListBox(ByVal metrics As (Integer, Integer), ByVal sort As Char, ByVal elapsedMilliseconds As Long)

        Dim sortString As String = ""

        Select Case sort
            Case "B" : sortString = "Bubble sort"
            Case "I" : sortString = "Insertion sort"
            Case "S" : sortString = "Selection sort"
        End Select

        lstMetrics.Items.Clear()
        lstMetrics.Items.Add(sortString)
        lstMetrics.Items.Add("Time elapsed: " & elapsedMilliseconds & "ms")
        lstMetrics.Items.Add("Comparisons: " & metrics.Item2)

        If sort = "I" Then

            lstMetrics.Items.Add("Shuffles/Swaps: " & metrics.Item1)

        Else

            lstMetrics.Items.Add("Swaps: " & metrics.Item1)

        End If

    End Sub

    Private Sub updateListBox()

        lstNums.Items.Clear()

        For i As Integer = 0 To nums.Length - 1 Step 1

            lstNums.Items.Add(nums(i))

        Next

    End Sub

    Private Sub Swap(ByRef A As Integer, ByRef B As Integer)

        Dim temp As Integer = A
        A = B
        B = temp

    End Sub

    Private Sub btnGetNums_Click(sender As Object, e As EventArgs) Handles btnGetNums.Click

        Dim len As Integer = Int(InputBox("How many integers would you like the list to contain?"))
        ReDim nums(len - 1)

        For i As Integer = 0 To len - 1 Step 1

            nums(i) = Int(InputBox("Please enter number " & (i + 1)))

        Next i

        updateListBox()

    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click

        Dim rnd As New Random()
        Dim i As Integer
        Dim j As Integer

        For i = nums.Length - 1 To 0 Step -1

            j = rnd.Next(0, i + 1)

            Swap(nums(j), nums(i))

        Next

        updateListBox()

    End Sub

    Private Sub btnBubbleSort_Click(sender As Object, e As EventArgs) Handles btnBubbleSort.Click

        Dim swapMetrics As (Integer, Integer) = (0, 0)

        Dim t As Stopwatch = New Stopwatch()

        t.Reset()
        t.Start()

        BubbleSort(nums, swapMetrics)

        t.Stop()

        Dim milliseconds As Long = t.ElapsedMilliseconds

        updateListBox(swapMetrics, "B", milliseconds)

    End Sub

    Private Sub btnSelectionSort_Click(sender As Object, e As EventArgs) Handles btnSelectionSort.Click

        Dim swapMetrics As (Integer, Integer) = (0, 0)

        Dim t As Stopwatch = New Stopwatch()

        t.Reset()
        t.Start()

        SelectionSort(nums, swapMetrics)

        t.Stop()

        Dim milliseconds As Long = t.ElapsedMilliseconds

        updateListBox(swapMetrics, "S", milliseconds)

    End Sub

    Private Sub btnInsertionSort_Click(sender As Object, e As EventArgs) Handles btnInsertionSort.Click

        Dim swapMetrics As (Integer, Integer) = (0, 0)

        Dim t As Stopwatch = New Stopwatch()

        t.Reset()
        t.Start()

        InsertionSort(nums, swapMetrics)

        t.Stop()

        Dim milliseconds As Long = t.ElapsedMilliseconds

        updateListBox(swapMetrics, "I", milliseconds)

    End Sub

    Private Sub BubbleSort(ByRef arr As Integer(), ByRef metrics As (Integer, Integer))

        Dim swaps As Integer = 0
        Dim comparisons As Integer = 0

        Dim last As Integer = arr.Length - 1
        Dim swapped As Boolean = True

        While swapped

            swapped = False
            Dim i As Integer = 0

            While i < last

                If arr(i) > arr(i + 1) Then

                    Swap(arr(i), arr(i + 1))
                    swapped = True
                    swaps += 1

                End If

                comparisons += 1

                i += 1

            End While

            last -= 1

        End While

        metrics = (swaps, comparisons)

    End Sub

    Private Sub SelectionSort(ByRef arr As Integer(), ByRef metrics As (Integer, Integer))

        Dim swaps As Integer = 0
        Dim comparisons As Integer = 0

        Dim endUnsorted = arr.Length - 1

        While endUnsorted > 0

            Dim i As Integer = 0
            Dim max As Integer = arr(i)
            Dim idxMax As Integer = i

            While i < endUnsorted

                i += 1
                If arr(i) > max Then
                    max = arr(i)
                    idxMax = i
                End If

                comparisons += 1

            End While

            Swap(arr(i), arr(idxMax))
            endUnsorted -= 1

            swaps += 1

        End While

        metrics = (swaps, comparisons)

    End Sub

    Private Sub InsertionSort(ByRef arr As Integer(), ByRef metrics As (Integer, Integer))

        Dim shuffles As Integer = 0
        Dim comparisons As Integer = 0

        Dim last = arr.Length - 1
        Dim pointToInsert = last - 1

        While pointToInsert >= 0

            Dim nextItem = nums(pointToInsert)
            Dim curr = pointToInsert

            While (curr < last) AndAlso nextItem > nums(curr + 1)

                curr += 1
                nums(curr - 1) = nums(curr)

            End While

            shuffles += (curr - pointToInsert)
            comparisons += (curr - pointToInsert)

            nums(curr) = nextItem
            pointToInsert -= 1

            shuffles += 1

        End While

        metrics = (shuffles, comparisons)

    End Sub

End Class
