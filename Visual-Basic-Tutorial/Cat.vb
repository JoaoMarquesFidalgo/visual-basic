Public Class Cat
    Inherits Animal

    Public Function Clean() As String
        Return GetName() & " cleans himself."
    End Function

    Public Overrides Function Run() As String
        Dim random = CInt(Math.Floor((2) * Rnd())) + 1
        If random = 1 Then
            Return GetName & " runs at " & Speed & " MPH"
        Else
            Return GetName & " doesnt feel like running"
        End If
    End Function

    Public Sub New(Optional height As Decimal = 0.0,
                   Optional weight As Decimal = 0.0,
                   Optional speed As Decimal = 0.0,
                   Optional name As String = "Animal")
        MyBase.New(height, weight, speed, name)
    End Sub

End Class
