
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

End Module
