Public Module Themes
    Dim theme As String = "None"
    Dim themeColor As String = "Blue"
    Dim backColor As ConsoleColor = ConsoleColor.Black
    Dim foreColor As ConsoleColor = ConsoleColor.White
    Dim boardColor As ConsoleColor = ConsoleColor.Blue
    Dim snakeColor As ConsoleColor = ConsoleColor.DarkCyan
    Dim foodColor As ConsoleColor = ConsoleColor.Cyan
    Public Sub QuestionTheme()
        System.Console.Write("Specify the Theme of the app (Light or Dark) : ")
        theme = System.Console.ReadLine()
        Select Case theme
            Case "light".ToLower()
                backColor = ConsoleColor.White
                foreColor = ConsoleColor.Black
            Case "dark".ToLower()
                backColor = ConsoleColor.Black
                foreColor = ConsoleColor.White
        End Select
    End Sub

    Public Sub QuestionThemeColor()
        System.Console.Write("Specify the Theme Color of the app (Blue,Red,Yello,Green,Magenta) : ")
        themeColor = System.Console.ReadLine()
        Select Case themeColor
            Case "blue".ToLower()
                snakeColor = ConsoleColor.DarkCyan
                boardColor = ConsoleColor.Blue
                foodColor = ConsoleColor.Cyan
            Case "red".ToLower()
                snakeColor = ConsoleColor.DarkRed
                boardColor = ConsoleColor.Red
                foodColor = ConsoleColor.DarkRed

            Case "Yellow".ToLower()
                snakeColor = ConsoleColor.DarkYellow
                boardColor = ConsoleColor.Yellow
                foodColor = ConsoleColor.DarkYellow

            Case "green".ToLower()
                snakeColor = ConsoleColor.DarkGreen
                boardColor = ConsoleColor.Green
                foodColor = ConsoleColor.DarkGreen

            Case "magenta".ToLower()
                snakeColor = ConsoleColor.DarkMagenta
                boardColor = ConsoleColor.Magenta
                foodColor = ConsoleColor.DarkMagenta
        End Select
    End Sub
End Module
