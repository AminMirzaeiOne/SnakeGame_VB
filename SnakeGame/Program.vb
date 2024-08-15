Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Public Module Program
    Public Property Width As Integer
    Public Property Height As Integer

    Dim ifno As ConsoleKeyInfo = New ConsoleKeyInfo()

    Public Sub Main()
        Dim finished As Boolean = False
        Width = 100
        Height = 50
        While Not finished
            DrawBoard()
            System.Console.Read()
        End While

    End Sub

    Public Sub DrawBoard()
        System.Console.Clear()

        For i As Integer = 0 To Width - 1
            System.Console.SetCursorPosition(i, 0)
            System.Console.Write("-")
        Next

        For i As Integer = 0 To Width - 1
            System.Console.SetCursorPosition(i, Height)
            System.Console.Write("-")
        Next

        For i As Integer = 0 To Height - 1
            System.Console.SetCursorPosition(0, i)
            System.Console.Write("-")
        Next

        For i As Integer = 0 To Height - 1
            System.Console.SetCursorPosition(Width, i)
            System.Console.Write("-")
        Next
    End Sub

End Module