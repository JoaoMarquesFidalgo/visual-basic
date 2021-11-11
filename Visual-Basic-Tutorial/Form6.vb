Imports System
Imports System.IO

Public Class Form6
    Private Sub ArialFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArialFontToolStripMenuItem.Click
        If ArialFontToolStripMenuItem.Checked = True Then
            TimesFontToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub TimesFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesFontToolStripMenuItem.Click
        If TimesFontToolStripMenuItem.Checked = True Then
            ArialFontToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub Form6_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub OpenFormatToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenFormatToolStripButton.Click
        If tspFormat.Visible = True Then
            tspFormat.Visible = False
        Else
            tspFormat.Visible = True
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        txtContent.Text = String.Empty
        txtContent.Focus()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Dim txtOutput As String = ""

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

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim txtOutput As String = ""

        Dim fileToSave As String = ""
        Dim fileSelected As String

        Dim SaveFileDialogEx As New SaveFileDialog() With {
            .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*",
            .FilterIndex = 2,
            .Title = "Save Important File",
            .FileName = fileToSave,
            .DefaultExt = "txt",
            .OverwritePrompt = True}

        If SaveFileDialogEx.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                fileSelected = SaveFileDialogEx.FileName

                Dim textContent As String = txtContent.Text
                Using sw As New StreamWriter(fileSelected)
                    sw.Write(textContent)
                End Using

                txtOutput &= "File saved: " & fileSelected & Environment.NewLine
                txtOutput &= Environment.NewLine

                Using sr As New StreamReader(fileSelected)
                    Dim lines As String = ""
                    lines = sr.ReadToEnd()
                    txtOutput &= lines & Environment.NewLine
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MessageBox.Show("Error saving file", "Error")
            End Try
        End If

        txtContent.Text = txtOutput
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click

        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Undo()
        End If

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        CutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        CopyToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        PasteToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).SelectAll()
        End If
    End Sub
End Class