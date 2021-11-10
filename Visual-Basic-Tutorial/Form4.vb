Public Class Form4

    ' Const
    Private Const PI As Decimal = 3.14159

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim txtOutput As String = ""

        Dim customers As New List(Of String)
        customers.Add("john")
        customers.Add("andre")
        customers.Add("frank")

        txtOutput &= "Count: " & customers.Count & Environment.NewLine

        customers.Insert(0, "joao")
        customers.Remove("andre")
        customers.Sort()

        txtOutput &= "Contains joao: " & customers.Contains("joao") &
            Environment.NewLine

        txtOutput &= "index joao2: " & customers.IndexOf("joao2") &
            Environment.NewLine

        For Each customer As String In customers
            txtOutput &= customer & Environment.NewLine
        Next

        customers.Clear()

        txtContent.Text = txtOutput
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Enum Season As Integer
        Spring = 0
        Summer = 1
        Fall = 2
        Winter = 3
    End Enum

    Private Sub btnUpdateWEnum_Click(sender As Object, e As EventArgs) Handles btnUpdateWEnum.Click
        Dim txtOutput As String = ""

        Dim currentSeason As Season = Season.Fall

        txtOutput &= "Current Season is " & currentSeason.ToString & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Public Structure Employee
        Public Name As String
        Public Position As String
        Public Salary As Decimal

        Public ReadOnly Property FullInfo() As String
            Get
                Return Name & " is a " & Position & " and makes $" & Salary
            End Get
        End Property
    End Structure

    ' Struct stores data with diferent datatypes
    Private Sub btnUpdateWStruct_Click(sender As Object, e As EventArgs) Handles btnUpdateWStruct.Click
        Dim txtOutput As String = ""

        Dim bobSmith As Employee
        bobSmith.Name = "Bob Smith"
        bobSmith.Position = "Manager"
        bobSmith.Salary = 2000.0

        txtOutput &= bobSmith.Name & " is a " & bobSmith.Position & " and makes $" & bobSmith.Salary &
            Environment.NewLine

        txtOutput &= bobSmith.FullInfo & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    ' https://stackoverflow.com/questions/13049/whats-the-difference-between-struct-and-class-in-net

    Private Sub btnUpdateWOOP_Click(sender As Object, e As EventArgs) Handles btnUpdateWOOPDog.Click
        Dim txtOutput As String = ""

        Dim dog As New Animal With {
            .Height = 77.2,
            .Weight = 33.1,
            .Speed = 30.0
        }

        dog.SetName("Kin")

        txtOutput &= "The dog is named " & dog.GetName & $", and weights {dog.Weight} lbs" &
            Environment.NewLine

        txtOutput &= dog.Run() & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Private Sub btnUpdateWOOPCat_Click(sender As Object, e As EventArgs) Handles btnUpdateWOOPCat.Click
        Dim txtOutput As String = ""

        ' Dim cat As New Cat(9, 9, 9, 10)
        Dim cat As New Animal(9, 9, 9, 10)

        txtOutput &= "The cat is named " & cat.GetName & $", and weights {cat.Weight} lbs" &
            Environment.NewLine

        txtOutput &= cat.Run() & Environment.NewLine

        txtOutput &= Environment.NewLine

        Dim kitty As New Cat With {
            .Height = 30,
            .Weight = 50,
            .Speed = 25}

        kitty.SetName("cystal")

        txtOutput &= kitty.Run() & Environment.NewLine

        txtOutput &= kitty.Clean() & Environment.NewLine

        txtOutput &= Showinfo(cat) & Environment.NewLine

        txtOutput &= Showinfo(kitty) & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Public Function Showinfo(animal As Animal)
        Return $"{animal.GetName} is a {animal.GetType().Name}, weights {animal.Weight}, " &
            $"and runs at {animal.Speed} MPH"
    End Function
End Class