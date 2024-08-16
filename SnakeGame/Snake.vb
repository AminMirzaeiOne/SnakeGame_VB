Public Class Snake
    Public keyInfo As System.ConsoleKeyInfo
    Public key As Char = "w"
    Public dir As Char = "u"
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
            Me.keyInfo = System.Console.ReadKey(True)
            Me.key = Me.keyInfo.KeyChar
        End If
    End Sub

    Public Sub Direction()
        If Me.key = "w" AndAlso Me.dir <> "d" Then
            Me.dir = "u"
        ElseIf Me.key = "s" AndAlso Me.dir <> "u" Then
            Me.dir = "d"

        ElseIf Me.key = "d" AndAlso Me.dir <> "l" Then
            Me.dir = "r"

        ElseIf Me.key = "a" AndAlso Me.dir <> "r" Then
            Me.dir = "r"
        End If
    End Sub

    Public Sub MoveSnake()
        Me.Direction()
        If Me.dir = "u" Then
            Me.y = Me.y - 1
        ElseIf Me.dir = "d" Then
            Me.y = Me.y + 1
        ElseIf Me.dir = "r" Then
            Me.x = Me.x + 1
        ElseIf Me.dir = "l" Then
            Me.x = Me.x - 1
        End If

        Me.snakeBody.Add(New SnakeGame.Position(Me.x, Me.y))
        Me.snakeBody.RemoveAt(0)
        System.Threading.Thread.Sleep(100)

    End Sub
End Class
