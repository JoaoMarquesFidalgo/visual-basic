' Datatypes
' Integer
' Long
' Decimal
' Double
' Boolean

Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        txtName.Text = "Hello " + txtName.Text
    End Sub

    Private Sub txtMessage_Click(sender As Object, e As EventArgs) Handles txtMessage.Click
        MessageBox.Show("Hello " & txtName.Text, "Greetings")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click
        Try
            Dim firstNum As Integer = CInt(txtValue1.Text)
            Dim secondNum As Integer = CInt(txtValue2.Text)
            Dim sum As Integer = firstNum + secondNum
            txtAnswer.Text = $"The sum of {CStr(firstNum)} and {CStr(secondNum)} is equal to {CStr(sum)}"
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter numbers", "Error")
            Console.WriteLine("Cast Error")
        Catch ex As Exception
            MessageBox.Show("An unkown error occurred.", "Error")
        End Try
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Try
            Dim firstNum As Decimal = CDec(txtValue1.Text)
            Dim secondNum As Decimal = CDec(txtValue2.Text)
            If secondNum = 0 Then
                Throw New DivideByZeroException
            End If
            Dim division As Decimal = Math.Round(firstNum / secondNum, 2)
            Console.WriteLine(division)
            txtAnswer.Text = $"The division of {CStr(firstNum)} and {CStr(secondNum)} is equal to {CStr(division)}"
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter numbers", "Error: Cast")
            Console.WriteLine("Cast Error")
        Catch ex As DivideByZeroException
            MessageBox.Show("Cannot divide by zero.", "Error: Divide by zero ")
            Console.WriteLine("Divide by zero Error")
        Catch ex As Exception
            MessageBox.Show("An unkown error occurred.", "Error")
        End Try
    End Sub
End Class
