Public Class Snake
    Public keyInfo As System.ConsoleKeyInfo
    Public key As Char = "w"

    Public Sub Input()
        If System.Console.KeyAvailable Then
            Me.key = Me.keyInfo.KeyChar
        End If
    End Sub
End Class
