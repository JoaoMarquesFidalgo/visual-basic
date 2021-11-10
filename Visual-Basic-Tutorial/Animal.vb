Public Class Animal
    Public Height As Decimal = 0.0
    Public Weight As Decimal = 0.0
    Public Speed As Decimal = 0.0

    Private Name As String

    ' Getters and Setters
    Public ReadOnly Property GetName As String
        Get
            Return Name
        End Get
    End Property

    Public Sub SetName(value As String)
        If IsNumeric(value) Then
            MessageBox.Show("Input name is wrong", "Error")
            Name = "Animal"
        Else
            Name = value
        End If
    End Sub

    ' Constructors
    Public Sub New(Optional height As Decimal = 0.0,
                   Optional weight As Decimal = 0.0,
                   Optional speed As Decimal = 0.0,
                   Optional name As String = "Animal")
        Me.Height = height
        Me.Weight = weight
        Me.Speed = speed
        SetName(name)
    End Sub

    Public Overridable Function Run() As String
        Return Name & " runs at " & Speed & " kmh."
    End Function
End Class
