Public Class Food
    Public foodPos As SnakeGame.Position = New SnakeGame.Position()
    Private rnd As System.Random
    Private board As SnakeGame.Board

    Public Sub New()
        Me.foodPos.x = Me.rnd.Next(5, Me.board.Width)
        Me.foodPos.y = Me.rnd.Next(5, Me.board.Height)
    End Sub

    Public Sub DrawFood()

    End Sub
End Class
