Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Public Module Program

    Public Sub Main()
        Dim finished As Boolean = False
        Dim board As Board = New Board()
        board.BoardConstructor()
        While Not finished
            board.DrawBoard()
            System.Console.Read()
        End While
    End Sub

End Module