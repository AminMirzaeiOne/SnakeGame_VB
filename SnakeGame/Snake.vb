Public Class Snake
    Public keyInfo As System.ConsoleKeyInfo
    Public key As Char = "w"
    Public Property x As Integer
    Public Property y As Integer

    Public Sub SnakeConstructor()
        Me.x = 20
        Me.y = 20
    End Sub

    Public Sub Input()
        If System.Console.KeyAvailable = True Then
            Me.key = Me.keyInfo.KeyChar
        End If
    End Sub
End Class
