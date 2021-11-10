Imports System
Imports System.IO

Public Class Form5
    Dim txtOutput As String = ""
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtOutput = ""

        Dim spot As New Form5Animal With {
            .Name = "Spot"}

        Dim fluffy = Form5Animal.MakeAnimal("flyffy")

        txtOutput &= "num of animals " & Form5Animal.numberOfAnimals & Environment.NewLine

        txtContent.Text = txtOutput
    End Sub

    Private Sub Form5_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        txtOutput = ""

        Dim lines() As String = {"this is a line of text", "saved to a file"}

        ' Get folder path
        Dim myDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        myDocPath &= Convert.ToString("\randomtext.txt")

        ' Write to file
        Using outputfile As New StreamWriter(myDocPath)
            For Each line As String In lines
                outputfile.WriteLine(line)
            Next
        End Using

        ' Append
        Using outputfile As New StreamWriter(myDocPath, True)
            outputfile.WriteLine("here is more info")
        End Using

        Try
            Using sr As New StreamReader(myDocPath)
                Dim line As String = ""
                line = sr.ReadToEnd()
                txtOutput &= line & Environment.NewLine
            End Using
        Catch ex As Exception
            MessageBox.Show("Couldnt Read File", "Error")
        End Try

        txtContent.Text = txtOutput
    End Sub

    Private Sub btnMessageBox_Click(sender As Object, e As EventArgs) Handles btnMessageBox.Click
        txtOutput = ""

        If MessageBox.Show("Message to Show", "Title", MessageBoxButtons.AbortRetryIgnore,
        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) =
            System.Windows.Forms.DialogResult.Abort Then
            txtOutput &= "Abort was clicked" & Environment.NewLine
        Else
            txtOutput &= "Something else was clicked" & Environment.NewLine
        End If

        txtContent.Text = txtOutput
    End Sub

    Private Sub btnOpenFileDialog_Click(sender As Object, e As EventArgs) Handles btnOpenFileDialog.Click
        txtOutput = ""

        Dim OpenFileDialogEx As New OpenFileDialog() With {
            .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*",
            .FilterIndex = 2,
            .Title = "Open Important File"}

        Dim fileSelected As String

        If OpenFileDialogEx.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                fileSelected = OpenFileDialogEx.FileName
                txtOutput &= "File selected: " & fileSelected & Environment.NewLine
                txtOutput &= Environment.NewLine

                Using sr As New StreamReader(fileSelected)
                    Dim lines As String = ""
                    lines = sr.ReadToEnd()
                    txtOutput &= lines & Environment.NewLine
                End Using
            Catch ex As Exception
                MessageBox.Show("Error getting file", "Error")
            End Try
        End If

        txtContent.Text = txtOutput
    End Sub
End Class