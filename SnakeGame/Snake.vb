Public Class Snake
    Public keyInfo As System.ConsoleKeyInfo
    Public key As Char = "w"
    Public Property x As Integer
    Public Property y As Integer

    Dim snakePosition As System.Collections.Generic.List(Of SnakeGame.Position)

    Public Sub SnakeConstructor()
        Me.x = 20
        Me.y = 20
        Me.snakePosition = New List(Of SnakeGame.Position)()
        Me.snakePosition.Add(New Position(x, y))
    End Sub

    Public Sub DrawSnake()
        System.Console.SetCursorPosition(x, y)
        System.Console.Write("▀")
    End Sub

    Public Sub Input()
        If System.Console.KeyAvailable = True Then
            Me.key = Me.keyInfo.KeyChar
        End If
    End Sub
End Class
