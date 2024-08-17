Public Class SnakeExecption
    Dim execption As String = String.Empty
    Public Sub New(message As String)
        Me.execption = message
    End Sub

    Public Function GetExecption()
        Return Me.execption
    End Function
End Class
