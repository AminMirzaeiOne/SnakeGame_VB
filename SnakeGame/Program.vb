Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Public Module Program

    Public Sub Main()
        Dim finished As Boolean = False
        Dim board As SnakeGame.Board = New SnakeGame.Board()
        Dim snake As SnakeGame.Snake = New SnakeGame.Snake()

        board.BoardConstructor()
        snake.SnakeConstructor()
        System.Console.Write("Press Enter.")
        System.Console.Read()
        While Not finished
            board.DrawBoard()
            snake.Input()
            snake.DrawSnake()
            snake.MoveSnake()
        End While

    End Sub

End Module