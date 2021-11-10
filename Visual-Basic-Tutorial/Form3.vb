Public Class Form3
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim txtOutput As String = ""

        Dim intAge As Integer = 19

        txtOutput &= $"You are {intAge} years old." & Environment.NewLine

        If intAge < 18 Then txtOutput &=
            "You can't vote." & Environment.NewLine : txtOutput &=
            "You will be able to vote in " & 18 - intAge & " years" &
                Environment.NewLine


        ' <> not equal
        If intAge <> 13 Then
            txtOutput &= "Your age is diferent than 13" &
                Environment.NewLine
        Else
            txtOutput &= "Your age is equal to 13" &
                Environment.NewLine
        End If

        If intAge < 5 Then
            txtOutput &= "You are too young to go to school."
        ElseIf intAge < 10 Then
            txtOutput &= "You can go to kindergarden"
        ElseIf intAge > 10 And intAge <= 18 Then
            txtOutput &= "You can go to high school"
        Else
            txtOutput &= "You can do whatever"
        End If
        txtOutput &= Environment.NewLine

        ' Compare strings
        Dim strName As String = "joao"
        If String.Compare("joao", strName, True) = 0 Then
            txtOutput &= "names match" & Environment.NewLine
        Else
            txtOutput &= "names don't match" & Environment.NewLine
        End If

        'Switch
        Select Case intAge
            Case 1, 2, 3, 4
                txtOutput &= "too young for school" & Environment.NewLine
            Case 10 To 18
                txtOutput &= "You can go to high school" & Environment.NewLine
            Case Else
                txtOutput &= "You can do whatever" & Environment.NewLine
        End Select

        ' ternary operator
        Dim boolCanVote As Boolean = If(intAge >= 18, True, False)
        txtOutput &= If(boolCanVote, "You can vote", "you can't vote") & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Private Sub btnUpdateLoop_Click(sender As Object, e As EventArgs) Handles btnUpdateLoop.Click
        Dim txtOutput As String = ""

        For intNum As Integer = 1 To 5
            txtOutput &= intNum & Environment.NewLine
        Next

        txtOutput &= Environment.NewLine

        For intNum As Integer = 0 To 50 Step 10
            txtOutput &= intNum & Environment.NewLine
            ' Break
            If intNum = 40 Then Exit For
        Next

        txtOutput &= Environment.NewLine

        Dim employees = New String() {"Paul", "John", "Ringo"}
        For Each employee As String In employees
            txtOutput &= employee & Environment.NewLine
        Next

        txtContent.Text = txtOutput
    End Sub

    Private Sub btnUpdateRnd_Click(sender As Object, e As EventArgs) Handles btnUpdateRnd.Click
        Dim txtOutput As String = ""
        ' Random
        Dim randValue As Integer = 0
        Dim numberGuessed = 5

        Dim upperBound = 10
        Dim lowerBound = 1

        For intNum As Integer = 0 To 5
            ' randValue = Int((upperBound * Rnd()) + 1)

            ' Int((upperBound - lowerBound + 1) * Rnd() + lowerBound)
            randValue = Int((upperBound - lowerBound + 1) * Rnd() + lowerBound)
            ' txtOutput &= CStr(randValue) & Environment.NewLine
        Next

        Dim numberTries As Integer = 0

        ' Generate real random
        ' https://stackoverflow.com/a/2677819
        Static Generator As System.Random = New System.Random()
        Do
            numberTries += 1
            randValue = Generator.Next(lowerBound, (upperBound + 1))
            txtOutput &= $"PC Number: {randValue} " & Environment.NewLine
            If numberGuessed = randValue Then Exit Do
        Loop

        txtOutput &= Environment.NewLine &
            $"Computer guessed the number {numberGuessed} in {numberTries} tries." &
            Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Private Sub btnUpdateArray_Click(sender As Object, e As EventArgs) Handles btnUpdateArray.Click
        Dim txtOutput As String = ""

        Dim customers() As String = {"John", "Paul", "Jeff"}

        customers(2) = "Andy"

        Array.Sort(customers)
        Array.Reverse(customers)

        ReDim Preserve customers(5)
        customers.SetValue("Joao", 3)

        For Each customer As String In customers
            txtOutput &= customer & Environment.NewLine
        Next

        ' multi-dimension

        Dim multiArray(4, 4) As String

        For i As Integer = 1 To 3
            For j As Integer = 1 To 3
                multiArray(i, j) = i & j & ", "
            Next
        Next

        For i As Integer = 1 To 3
            For j As Integer = 1 To 3
                txtOutput &= multiArray(i, j)
            Next
            txtOutput &= Environment.NewLine
        Next

        txtContent.Text = txtOutput
    End Sub
End Class