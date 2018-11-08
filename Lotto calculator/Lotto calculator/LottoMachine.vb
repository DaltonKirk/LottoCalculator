Public Class LottoMachine

    Private MaximumNumber As Integer
    Private random As Random = New Random

    Sub New(MaximumNumberCanDraw As Integer)
        MaximumNumber = MaximumNumberCanDraw
    End Sub

    Public Function Draw(amountToDraw As Integer) As List(Of Integer)
        Dim drawnNumbers = New List(Of Integer)
        For i = 1 To amountToDraw
            Dim drawnNumber = DrawNumber()
            While NumberAlreadyDrawn(drawnNumber, drawnNumbers)
                drawnNumber = DrawNumber()
            End While
            drawnNumbers.Add(drawnNumber)
        Next
        Return drawnNumbers
    End Function

    Private Function NumberAlreadyDrawn(drawnNumber As Integer, drawnNumbers As List(Of Integer)) As Boolean
        For Each number In drawnNumbers
            If number = drawnNumber
                Return true
            End If
        Next
        Return False
    End Function

    Public Function DrawNumber() As Integer
        Return random.Next(1, MaximumNumber)
    End Function
End Class
