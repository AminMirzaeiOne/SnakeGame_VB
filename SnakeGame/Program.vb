Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Public Module Program

    Public Sub Main()

start:
        System.Console.Write("Play Or Settings : ")
        Dim x As String = System.Console.ReadLine().ToLower()
        If x = "play" Then
            Play()
        ElseIf x = "settings" Then
            Settings()
        Else
            System.Console.WriteLine("The entered word is invalid, it should be (Play or Settings).")
            GoTo start
        End If

    End Sub

    Public Sub Play()
        Dim finished As Boolean = False
        Dim board As SnakeGame.Board = New SnakeGame.Board()
        Dim snake As SnakeGame.Snake = New SnakeGame.Snake()
        Dim food As SnakeGame.Food = New Food()

        board.BoardConstructor()
        snake.SnakeConstructor()
        System.Console.Write("Press Enter.")
        System.Console.Read()

        While Not finished
            Board.DrawBoard()
            Snake.Input()
            Food.DrawFood()
            Snake.DrawSnake()
            Snake.MoveSnake()
            Snake.SnakeGrow(Food.FoodLocation(), Food)
        End While
    End Sub

    Public Sub Settings()
        SnakeGame.Themes.QuestionTheme()
        System.Console.BackgroundColor = SnakeGame.Themes.backColor
        System.Console.Clear()
        System.Console.ForegroundColor = SnakeGame.Themes.foreColor
        SnakeGame.Themes.QuestionThemeColor()
        SnakeGame.Options.QuestionBoardSize()
        SnakeGame.Options.QuestionCharBoard()
        SnakeGame.Options.QuestionCharSnake()
        System.Console.WriteLine("Press Keyboard Key To Play Snake Game : ")
        Console.Read()
        Play()

    End Sub

End Module