Public Class Snake
    Public keyInfo As System.ConsoleKeyInfo
    Public key As Char = "w"
    Public Property x As Integer
    Public Property y As Integer

    Dim snakeBody As System.Collections.Generic.List(Of SnakeGame.Position)

    Public Sub SnakeConstructor()
        Me.x = 20
        Me.y = 20
        Me.snakeBody = New List(Of SnakeGame.Position)()
        Me.snakeBody.Add(New Position(x, y))
    End Sub

    Public Sub DrawSnake()
        For Each pos As Position In snakeBody
            System.Console.SetCursorPosition(pos.x, pos.y)
            System.Console.Write("▀")
        Next

    End Sub

    Public Sub Input()
        If System.Console.KeyAvailable = True Then
            Me.key = Me.keyInfo.KeyChar
        End If
    End Sub
End Class
