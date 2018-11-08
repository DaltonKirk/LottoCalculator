Public Class LottoChecker
    Public Shared Function HasWon(selectedNumbers As List(Of Integer), lottoDraw As List(Of Integer)) As Boolean

        Dim amountMatched = 0
        For Each selectedNumber In selectedNumbers
            For Each drawnNumber In lottoDraw
                If selectedNumber = drawnNumber Then
                    amountMatched = amountMatched + 1
                End If
            Next
        Next

        If (amountMatched = selectedNumbers.Count) Then
            Return True
        End If
        Return False
    End Function
End Class
