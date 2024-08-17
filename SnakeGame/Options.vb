
Module Options
    Public Enum BoardSizes
        Small = 30
        Medium = 50
        Large = 100
    End Enum

    Public Property BoardSize As SnakeGame.BoardSizes
    Public Property CharBoard As Char = "-"
    Public Property CharSnake As Char = "▀"

    Public Sub QuestionBoardSize()
        System.Console.Write("What is the size of the game board? (Small , Medium , Large) : ")
        Dim x As String = System.Console.ReadLine()
        Select Case x
            Case "small".ToLower()
                BoardSize = BoardSizes.Small
            Case "medium".ToLower()
                BoardSize = BoardSizes.Medium
            Case "large".ToLower()
                BoardSize = BoardSizes.Large
        End Select
    End Sub

    Public Sub QuestionCharBoard()
        System.Console.Write("What is the character of the game Board (Char) : ")
        CharBoard = System.Console.ReadLine()
    End Sub

    Public Sub QuestionCharSnake()
        System.Console.Write("What is the character of the game Snake (Char) : ")
        CharSnake = System.Console.ReadLine()
    End Sub

End Module
