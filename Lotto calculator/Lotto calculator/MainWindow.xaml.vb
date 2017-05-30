Class MainWindow

    Private numbersSelected As Integer
    Private maxNumbers As Integer = 6
    Private selectedNumbers As List(Of Integer) = New List(Of Integer)
    Private selectedButtons As List(Of Button) = New List(Of Button)
    Private isCalculating As Boolean

    Private Sub SelectNumber(button As Button, buttonNumber As Integer, pressedButton As Button)
        If button.Background IsNot System.Windows.Media.Brushes.Red And numbersSelected < maxNumbers And isCalculating = False Then
            'Colour the button red
            button.Background = System.Windows.Media.Brushes.Red
            'Increase amount of numbers selected
            numbersSelected = numbersSelected + 1
            'add selected number to our list so we can check against it later
            selectedNumbers.Add(buttonNumber)
            'Add button to list of buttons so the clear method knows what buttons to re-colour
            selectedButtons.Add(pressedButton)
        ElseIf button.Background Is System.Windows.Media.Brushes.Red And isCalculating = False Then
            'if button red make it grey
            button.Background = System.Windows.Media.Brushes.LightGray
            'decrease number selected
            numbersSelected = numbersSelected - 1
            'remove number from list
            Dim i As Integer = 0
            While numbersSelected = 6
                If buttonNumber = selectedNumbers(i) Then
                    selectedNumbers.Remove(i)
                    selectedButtons.Remove(pressedButton)
                End If
                i = i + 1
            End While

        ElseIf isCalculating = True Then
            errorLabel.Content = "Can't change numbers when calculating"
        End If
    End Sub

    Private Sub button_1_Click(sender As Object, e As RoutedEventArgs) Handles button_1.Click
        SelectNumber(button_1, 1, button_1)
    End Sub
    Private Sub button_2_Click(sender As Object, e As RoutedEventArgs) Handles button_2.Click
        SelectNumber(button_2, 2, button_2)
    End Sub
    Private Sub button_3_Click(sender As Object, e As RoutedEventArgs) Handles button_3.Click
        SelectNumber(button_3, 3, button_3)
    End Sub
    Private Sub button_4_Click(sender As Object, e As RoutedEventArgs) Handles button_4.Click
        SelectNumber(button_4, 4, button_4)
    End Sub
    Private Sub button_5_Click(sender As Object, e As RoutedEventArgs) Handles button_5.Click
        SelectNumber(button_5, 5, button_5)
    End Sub

    Private Sub button_6_Click(sender As Object, e As RoutedEventArgs) Handles button_6.Click
        SelectNumber(button_6, 6, button_6)
    End Sub

    Private Sub button_7_Click(sender As Object, e As RoutedEventArgs) Handles button_7.Click
        SelectNumber(button_7, 7, button_7)
    End Sub

    Private Sub button_8_Click(sender As Object, e As RoutedEventArgs) Handles button_8.Click
        SelectNumber(button_8, 8, button_8)
    End Sub

    Private Sub button_9_Click(sender As Object, e As RoutedEventArgs) Handles button_9.Click
        SelectNumber(button_9, 9, button_9)
    End Sub

    Private Sub button_10_Click(sender As Object, e As RoutedEventArgs) Handles button_10.Click
        SelectNumber(button_10, 10, button_10)
    End Sub

    Private Sub button_11_Click(sender As Object, e As RoutedEventArgs) Handles button_11.Click
        SelectNumber(button_11, 11, button_11)
    End Sub

    Private Sub button_12_Click(sender As Object, e As RoutedEventArgs) Handles button_12.Click
        SelectNumber(button_12, 12, button_12)
    End Sub

    Private Sub button_13_Click(sender As Object, e As RoutedEventArgs) Handles button_13.Click
        SelectNumber(button_13, 13, button_13)
    End Sub

    Private Sub button_14_Click(sender As Object, e As RoutedEventArgs) Handles button_14.Click
        SelectNumber(button_14, 14, button_14)
    End Sub

    Private Sub button_15_Click(sender As Object, e As RoutedEventArgs) Handles button_15.Click
        SelectNumber(button_15, 15, button_15)
    End Sub

    Private Sub button_16_Click(sender As Object, e As RoutedEventArgs) Handles button_16.Click
        SelectNumber(button_16, 16, button_16)
    End Sub

    Private Sub button_17_Click(sender As Object, e As RoutedEventArgs) Handles button_17.Click
        SelectNumber(button_17, 17, button_17)
    End Sub

    Private Sub button_18_Click(sender As Object, e As RoutedEventArgs) Handles button_18.Click
        SelectNumber(button_18, 18, button_18)
    End Sub

    Private Sub button_19_Click(sender As Object, e As RoutedEventArgs) Handles button_19.Click
        SelectNumber(button_19, 19, button_19)
    End Sub

    Private Sub button_20_Click(sender As Object, e As RoutedEventArgs) Handles button_20.Click
        SelectNumber(button_20, 20, button_20)
    End Sub

    Private Sub button_21_Click(sender As Object, e As RoutedEventArgs) Handles button_21.Click
        SelectNumber(button_21, 21, button_21)
    End Sub

    Private Sub button_22_Click(sender As Object, e As RoutedEventArgs) Handles button_22.Click
        SelectNumber(button_22, 22, button_22)
    End Sub

    Private Sub button_23_Click(sender As Object, e As RoutedEventArgs) Handles button_23.Click
        SelectNumber(button_23, 23, button_23)
    End Sub

    Private Sub button_24_Click(sender As Object, e As RoutedEventArgs) Handles button_24.Click
        SelectNumber(button_24, 24, button_24)
    End Sub

    Private Sub button_25_Click(sender As Object, e As RoutedEventArgs) Handles button_25.Click
        SelectNumber(button_25, 25, button_25)
    End Sub

    Private Sub button_26_Click(sender As Object, e As RoutedEventArgs) Handles button_26.Click
        SelectNumber(button_26, 26, button_26)
    End Sub

    Private Sub button_27_Click(sender As Object, e As RoutedEventArgs) Handles button_27.Click
        SelectNumber(button_27, 27, button_27)
    End Sub

    Private Sub button_28_Click(sender As Object, e As RoutedEventArgs) Handles button_28.Click
        SelectNumber(button_28, 28, button_28)
    End Sub

    Private Sub button_29_Click(sender As Object, e As RoutedEventArgs) Handles button_29.Click
        SelectNumber(button_29, 29, button_29)
    End Sub

    Private Sub button_30_Click(sender As Object, e As RoutedEventArgs) Handles button_30.Click
        SelectNumber(button_30, 30, button_30)
    End Sub

    Private Sub button_31_Click(sender As Object, e As RoutedEventArgs) Handles button_31.Click
        SelectNumber(button_31, 31, button_31)
    End Sub

    Private Sub button_32_Click(sender As Object, e As RoutedEventArgs) Handles button_32.Click
        SelectNumber(button_32, 32, button_32)
    End Sub

    Private Sub button_33_Click(sender As Object, e As RoutedEventArgs) Handles button_33.Click
        SelectNumber(button_33, 33, button_33)
    End Sub

    Private Sub button_34_Click(sender As Object, e As RoutedEventArgs) Handles button_34.Click
        SelectNumber(button_34, 34, button_34)
    End Sub

    Private Sub button_35_Click(sender As Object, e As RoutedEventArgs) Handles button_35.Click
        SelectNumber(button_35, 35, button_35)
    End Sub

    Private Sub button_36_Click(sender As Object, e As RoutedEventArgs) Handles button_36.Click
        SelectNumber(button_36, 36, button_36)
    End Sub

    Private Sub button_37_Click(sender As Object, e As RoutedEventArgs) Handles button_37.Click
        SelectNumber(button_37, 37, button_37)
    End Sub

    Private Sub button_38_Click(sender As Object, e As RoutedEventArgs) Handles button_38.Click
        SelectNumber(button_38, 38, button_38)
    End Sub

    Private Sub button_39_Click(sender As Object, e As RoutedEventArgs) Handles button_39.Click
        SelectNumber(button_39, 39, button_39)
    End Sub

    Private Sub button_40_Click(sender As Object, e As RoutedEventArgs) Handles button_40.Click
        SelectNumber(button_40, 40, button_40)
    End Sub

    Private Sub button_41_Click(sender As Object, e As RoutedEventArgs) Handles button_41.Click
        SelectNumber(button_41, 41, button_41)
    End Sub

    Private Sub button_42_Click(sender As Object, e As RoutedEventArgs) Handles button_42.Click
        SelectNumber(button_42, 42, button_42)
    End Sub

    Private Sub button_43_Click(sender As Object, e As RoutedEventArgs) Handles button_43.Click
        SelectNumber(button_43, 43, button_43)
    End Sub

    Private Sub button_44_Click(sender As Object, e As RoutedEventArgs) Handles button_44.Click
        SelectNumber(button_44, 44, button_44)
    End Sub

    Private Sub button_45_Click(sender As Object, e As RoutedEventArgs) Handles button_45.Click
        SelectNumber(button_45, 45, button_45)
    End Sub

    Private Sub button_46_Click(sender As Object, e As RoutedEventArgs) Handles button_46.Click
        SelectNumber(button_46, 46, button_46)
    End Sub

    Private Sub button_47_Click(sender As Object, e As RoutedEventArgs) Handles button_47.Click
        SelectNumber(button_47, 47, button_47)
    End Sub

    Private Sub button_48_Click(sender As Object, e As RoutedEventArgs) Handles button_48.Click
        SelectNumber(button_48, 48, button_48)
    End Sub

    Private Sub button_49_Click(sender As Object, e As RoutedEventArgs) Handles button_49.Click
        SelectNumber(button_49, 49, button_49)
    End Sub

    Private Sub button_50_Click(sender As Object, e As RoutedEventArgs) Handles button_50.Click
        SelectNumber(button_50, 50, button_50)
    End Sub

    Private Sub button_51_Click(sender As Object, e As RoutedEventArgs) Handles button_51.Click
        SelectNumber(button_51, 51, button_51)
    End Sub

    Private Sub button_52_Click(sender As Object, e As RoutedEventArgs) Handles button_52.Click
        SelectNumber(button_52, 52, button_52)
    End Sub

    Private Sub button_53_Click(sender As Object, e As RoutedEventArgs) Handles button_53.Click
        SelectNumber(button_53, 53, button_53)
    End Sub

    Private Sub button_54_Click(sender As Object, e As RoutedEventArgs) Handles button_54.Click
        SelectNumber(button_54, 54, button_54)
    End Sub

    Private Sub button_55_Click(sender As Object, e As RoutedEventArgs) Handles button_55.Click
        SelectNumber(button_55, 55, button_55)
    End Sub

    Private Sub button_56_Click(sender As Object, e As RoutedEventArgs) Handles button_56.Click
        SelectNumber(button_56, 56, button_56)
    End Sub

    Private Sub button_57_Click(sender As Object, e As RoutedEventArgs) Handles button_57.Click
        SelectNumber(button_57, 57, button_57)
    End Sub

    Private Sub button_58_Click(sender As Object, e As RoutedEventArgs) Handles button_58.Click
        SelectNumber(button_58, 58, button_58)
    End Sub

    Private Sub button_59_Click(sender As Object, e As RoutedEventArgs) Handles button_59.Click
        SelectNumber(button_59, 59, button_59)
    End Sub

    Private Sub button_calculate_Click(sender As Object, e As RoutedEventArgs) Handles button_calculate.Click
        If numbersSelected = 6 Then
            errorLabel.Content = "Drawing..."
            Dim allSixMatch As Boolean = False
            Dim amountMatched As Integer = 0
            Dim draw As Integer = 0
            While allSixMatch = False
                amountMatched = 0
                draw = draw + 1
                drawsLabel.Content = "Draws: " + draw.ToString()
                Dim randNumber1 As Integer = CInt(Math.Floor((59 - 1 + 1) * Rnd())) + 1
                Dim randNumber2 As Integer = CInt(Math.Floor((59 - 1 + 1) * Rnd())) + 1
                Dim randNumber3 As Integer = CInt(Math.Floor((59 - 1 + 1) * Rnd())) + 1
                Dim randNumber4 As Integer = CInt(Math.Floor((59 - 1 + 1) * Rnd())) + 1
                Dim randNumber5 As Integer = CInt(Math.Floor((59 - 1 + 1) * Rnd())) + 1
                Dim randNumber6 As Integer = CInt(Math.Floor((59 - 1 + 1) * Rnd())) + 1

                'Check First Number
                For Each number As Integer In selectedNumbers
                    If randNumber1 = number Then
                        amountMatched = amountMatched + 1
                    End If
                Next
                'If no match then stop this method
                '  If amountMatched < 1 Then
                '   Return
                'End If
                'Check Second Number
                For Each number As Integer In selectedNumbers
                    If randNumber2 = number Then
                        amountMatched = amountMatched + 1
                    End If
                Next
                'Check Third Number
                For Each number As Integer In selectedNumbers
                    If randNumber3 = number Then
                        amountMatched = amountMatched + 1
                    End If
                Next
                'Check Fourth Number
                For Each number As Integer In selectedNumbers
                    If randNumber4 = number Then
                        amountMatched = amountMatched + 1
                    End If
                Next
                'Check Fith Number
                For Each number As Integer In selectedNumbers
                    If randNumber5 = number Then
                        amountMatched = amountMatched + 1
                    End If
                Next
                'Check Sixth Number
                For Each number As Integer In selectedNumbers
                    If randNumber6 = number Then
                        amountMatched = amountMatched + 1
                    End If
                Next

                If amountMatched = 6 Then
                    'WIN!!!!!!!
                    drawsLabel.Content = "Draws: " + draw.ToString() + " You Won!!"
                    errorLabel.Content = "Finished"
                    CalculateTicketCost(draw)
                    allSixMatch = True
                End If
            End While
        ElseIf numbersSelected < 6 Then
            errorLabel.Content = "Need 6 Numbers..."
        End If
    End Sub

    Private Sub button_clear_Click(sender As Object, e As RoutedEventArgs) Handles button_clear.Click
        selectedNumbers = New List(Of Integer)()
        For Each button As Button In selectedButtons
            button.Background = System.Windows.Media.Brushes.LightGray
        Next
        selectedButtons = New List(Of Button)()
        numbersSelected = 0
    End Sub
    Private Sub CalculateTicketCost(draws As Integer)
        If IsNumeric(textBox_ticketPrice.Text) Then
            Dim ticketPrice As Double = CDbl(textBox_ticketPrice.Text)
            label_totalCost.Content = "Total cost of tickets = " + (ticketPrice * draws).ToString()
        Else
            label_totalCost.Content = "Ticket price must be a number"
        End If

    End Sub
End Class