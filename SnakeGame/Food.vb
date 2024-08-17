Public Class Food
    Public foodPos As SnakeGame.Position = New SnakeGame.Position()
    Private rnd As System.Random = New System.Random()
    Private board As SnakeGame.Board = New SnakeGame.Board()

    Public Sub New()
        Me.foodPos.x = Me.rnd.Next(5, Me.board.Width)
        Me.foodPos.y = Me.rnd.Next(5, Me.board.Height)
    End Sub

    Public Sub DrawFood()
        System.Console.SetCursorPosition(Me.foodPos.x, Me.foodPos.y)
        System.Console.Write("f")
    End Sub

    Public Function FoodLocation() As SnakeGame.Position
        Return foodPos
    End Function

    Public Sub FoodNewLocation()
        Me.foodPos.x = Me.rnd.Next(5, Me.board.Width)
        Me.foodPos.y = Me.rnd.Next(5, Me.board.Height)
    End Sub
End Class
