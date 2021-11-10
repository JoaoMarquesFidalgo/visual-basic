Public Class Form5Animal
    Public Name As String

    ' equal static attributes
    Public Shared numberOfAnimals As Integer = 0

    Public Sub New(Optional name = "Unkown")
        name = name
        numberOfAnimals += 1
    End Sub

    Public Shared Function MakeAnimal(Optional name As String = "Unkown")
        Dim newAnimal As New Form5Animal() With {
            .Name = name}
        Return newAnimal
    End Function
End Class
