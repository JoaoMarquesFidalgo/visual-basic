Public Class Form2
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim textOutput As String = "Abs(-19) = " & Math.Abs(-19) &
            Environment.NewLine
        textOutput &= "Ceiling(4.5) = " & Math.Ceiling(4.5) &
            Environment.NewLine

        Dim randInt = 10
        randInt += 10

        textOutput &= "10 + 10 = " & randInt &
            Environment.NewLine

        txtContent.Text = textOutput

    End Sub

    Private Sub btnUpdateString_Click(sender As Object, e As EventArgs) Handles btnUpdateString.Click

        Dim txtOutput As String = ""

        Dim randString As String = "ths is a string"

        txtOutput &= randString & Environment.NewLine &
                        "randString lenght: " & randString.Length &
                        Environment.NewLine

        txtOutput &= "1st 3 = " & randString.Substring(0, 3) &
                        Environment.NewLine

        txtOutput &= "replace = " & randString.Replace("this", "that") &
                        Environment.NewLine

        Dim randNum As Decimal = 3221.623312

        ' 3 221,623
        txtOutput &= "value = " & String.Format("{0:n3}", randNum) &
                        Environment.NewLine

        ' 3 221,62 €
        txtOutput &= "currency = " & String.Format("{0:c}", randNum) &
                        Environment.NewLine
        ' 03221,6
        txtOutput &= "random = " & String.Format("{0:00000.0}", randNum) &
                        Environment.NewLine

        ' location of I 
        txtOutput &= "I in string= " & InStr(randString, "i", CompareMethod.Text) &
                        Environment.NewLine

        ' arrays
        Dim arrayEmployees(0 To 2) As String
        arrayEmployees(0) = "paul"
        arrayEmployees(1) = "john"
        arrayEmployees(2) = "ringo"

        Dim strEmployees As String = Join(arrayEmployees, ", ")

        txtOutput &= "Array of employees in string = " &
            strEmployees & Environment.NewLine

        arrayEmployees = Split(strEmployees, ", ")

        ' for
        For i As Integer = 0 To arrayEmployees.Length - 1
            txtOutput &= $"Employee {i + 1} = " &
                arrayEmployees(i) & Environment.NewLine
        Next

        txtOutput &= "Compare dog to cat = " &
                StrComp("dog", "cat", CompareMethod.Text) & Environment.NewLine

        txtOutput &= "Compare dog to dog = " &
                StrComp("dog", "dog", CompareMethod.Text) & Environment.NewLine

        txtOutput &= "trim = " &
                Trim("     String     ") & Environment.NewLine


        txtContent.Text = txtOutput

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim txtOutput As String = ""
        Dim dateCurrent As Date = Now

        txtOutput &= "Date = " & dateCurrent.Date & Environment.NewLine

        txtOutput &= "Day = " & dateCurrent.Day & Environment.NewLine

        txtOutput &= "Day in system language = " & dateCurrent.ToString("dddd") & Environment.NewLine
        ' dddd = day, segunda, terça
        ' MMMM = month, janeiro, fevereiro

        ' custom date
        Dim importantDate As Date = #10-05-1991 11:30:00 AM#

        ' 05/10/1991 11:30:00
        txtOutput &= "Important Date = " & importantDate & Environment.NewLine

        ' 11:30:00
        txtOutput &= "Important Date time = " & importantDate.ToLongTimeString & Environment.NewLine

        ' 5 de outubro de 1991
        txtOutput &= "Important Date date = " & importantDate.ToLongDateString & Environment.NewLine

        txtContent.Text = txtOutput

    End Sub

    ' Method

    Private Sub ShowMessage()
        MessageBox.Show("hi there", "title")
    End Sub

    Private Function GetSum(num1, num2)
        Return num1 + num2
    End Function

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCallMethod_Click(sender As Object, e As EventArgs) Handles btnCallMethod.Click
        ' ShowMessage()
        Dim txtOutput As String = ""

        txtOutput &= "6 + 5 = " & GetSum(6, 5) & Environment.NewLine

        Dim intNum = 10
        changeValue(intNum)
        txtOutput &= "pass by reference = " & intNum & Environment.NewLine

        txtOutput &= "sum of values = " & GetSumMore(1, 2, 3, 4) & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Private Sub changeValue(ByRef intNum As Integer)
        intNum = 30
    End Sub

    Private Function GetSumMore(ByVal ParamArray numbers() As Integer)
        Dim sum As Integer = 0

        For Each item As Integer In numbers
            sum += item
        Next

        Return sum
    End Function
End Class