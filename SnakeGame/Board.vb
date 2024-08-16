﻿Public Class Board
    Public Property Width As Integer
    Public Property Height As Integer
    Public Sub BoardConstructor()
        Me.Width = 100
        Me.Height = 50

    End Sub

    Public Sub DrawBoard()
        System.Console.Clear()

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
