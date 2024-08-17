Public Class Board
    Public Property Width As Integer
    Public Property Height As Integer

    Public Sub New()
        Me.Width = SnakeGame.Options.BoardSize
        Me.Height = SnakeGame.Options.BoardSize
        System.Console.CursorVisible = False
    End Sub

    Public Sub BoardConstructor()
        Me.Width = SnakeGame.Options.BoardSize
        Me.Height = SnakeGame.Options.BoardSize
        System.Console.CursorVisible = False
    End Sub

    Public Sub DrawBoard()
        System.Console.Clear()
        System.Console.ForegroundColor = SnakeGame.Themes.boardColor
        For i As Integer = 0 To Me.Width - 1
            System.Console.SetCursorPosition(i, 0)
            System.Console.Write("-")
        Next

        For i As Integer = 0 To Me.Width - 1
            System.Console.SetCursorPosition(i, Me.Height)
            System.Console.Write("-")
        Next

        For i As Integer = 0 To Me.Height - 1
            System.Console.SetCursorPosition(0, i)
            System.Console.Write("-")
        Next

        For i As Integer = 0 To Me.Height - 1
            System.Console.SetCursorPosition(Me.Width, i)
            System.Console.Write("-")
        Next
    End Sub
End Class
