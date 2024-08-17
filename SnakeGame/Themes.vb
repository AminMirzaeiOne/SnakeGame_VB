Public Module Themes
    Dim theme As String = "None"
    Dim themeColor As String = "Blue"
    Dim backColor As ConsoleColor = ConsoleColor.Black
    Dim foreColor As ConsoleColor = ConsoleColor.White
    Dim boardColor As ConsoleColor = ConsoleColor.Blue
    Dim snakeColor As ConsoleColor = ConsoleColor.DarkCyan
    Public Sub QuestionTheme()
        System.Console.Write("Specify the theme of the app (Light or Dark) : ")
        theme = System.Console.ReadLine()
        Select Case theme
            Case "light"
                backColor = ConsoleColor.White
                foreColor = ConsoleColor.Black
            Case "dark"
                backColor = ConsoleColor.Black
                foreColor = ConsoleColor.White
        End Select
    End Sub
End Module
