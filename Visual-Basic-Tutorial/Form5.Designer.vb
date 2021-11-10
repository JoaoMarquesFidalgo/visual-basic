<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.btnMessageBox = New System.Windows.Forms.Button()
        Me.btnOpenFileDialog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(12, 12)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(690, 242)
        Me.txtContent.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(13, 261)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 66)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Location = New System.Drawing.Point(137, 261)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(118, 66)
        Me.btnCreateFile.TabIndex = 2
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'btnMessageBox
        '
        Me.btnMessageBox.Location = New System.Drawing.Point(261, 261)
        Me.btnMessageBox.Name = "btnMessageBox"
        Me.btnMessageBox.Size = New System.Drawing.Size(118, 66)
        Me.btnMessageBox.TabIndex = 3
        Me.btnMessageBox.Text = "Message Box"
        Me.btnMessageBox.UseVisualStyleBackColor = True
        '
        'btnOpenFileDialog
        '
        Me.btnOpenFileDialog.Location = New System.Drawing.Point(385, 261)
        Me.btnOpenFileDialog.Name = "btnOpenFileDialog"
        Me.btnOpenFileDialog.Size = New System.Drawing.Size(118, 66)
        Me.btnOpenFileDialog.TabIndex = 4
        Me.btnOpenFileDialog.Text = "Open File Dialog"
        Me.btnOpenFileDialog.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 339)
        Me.Controls.Add(Me.btnOpenFileDialog)
        Me.Controls.Add(Me.btnMessageBox)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtContent)
        Me.KeyPreview = True
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreateFile As Button
    Friend WithEvents btnMessageBox As Button
    Friend WithEvents btnOpenFileDialog As Button
End Class
