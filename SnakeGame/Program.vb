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
        Dim food As SnakeGame.Food = New Food()

        SnakeGame.Themes.QuestionTheme()
        System.Console.BackgroundColor = SnakeGame.Themes.backColor
        System.Console.Clear()
        System.Console.ForegroundColor = SnakeGame.Themes.foreColor
        SnakeGame.Themes.QuestionThemeColor()
        board.BoardConstructor()
        snake.SnakeConstructor()
        System.Console.Write("Press Enter.")
        System.Console.Read()
        While Not finished
            board.DrawBoard()
            snake.Input()
            food.DrawFood()
            snake.DrawSnake()
            snake.MoveSnake()
            snake.SnakeGrow(food.FoodLocation(), food)
        End While

    End Sub

End Module