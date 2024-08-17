
Module Options
    Public Enum BoardSizes
        Small = 30
        Medium = 50
        Large = 100
    End Enum

    Public ReadOnly Property BoardSize As SnakeGame.BoardSizes
    Public ReadOnly Property CharBoard As Char = "-"
    Public ReadOnly Property CharSnake As Char = "▀"

    Public Sub QuestionBoardSize()
        System.Console.Write("What is the size of the game board? (Small , Medium , Large) : ")
    End Sub

End Module
