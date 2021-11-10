<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnUpdateLoop = New System.Windows.Forms.Button()
        Me.btnUpdateRnd = New System.Windows.Forms.Button()
        Me.btnUpdateArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(13, 13)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(541, 215)
        Me.txtContent.TabIndex = 0
        Me.txtContent.UseWaitCursor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 249)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(127, 44)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update W Cases"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdateLoop
        '
        Me.btnUpdateLoop.Location = New System.Drawing.Point(145, 249)
        Me.btnUpdateLoop.Name = "btnUpdateLoop"
        Me.btnUpdateLoop.Size = New System.Drawing.Size(127, 44)
        Me.btnUpdateLoop.TabIndex = 2
        Me.btnUpdateLoop.Text = "Update W  Loops"
        Me.btnUpdateLoop.UseVisualStyleBackColor = True
        '
        'btnUpdateRnd
        '
        Me.btnUpdateRnd.Location = New System.Drawing.Point(278, 249)
        Me.btnUpdateRnd.Name = "btnUpdateRnd"
        Me.btnUpdateRnd.Size = New System.Drawing.Size(127, 44)
        Me.btnUpdateRnd.TabIndex = 3
        Me.btnUpdateRnd.Text = "Update W  Random"
        Me.btnUpdateRnd.UseVisualStyleBackColor = True
        '
        'btnUpdateArray
        '
        Me.btnUpdateArray.Location = New System.Drawing.Point(411, 249)
        Me.btnUpdateArray.Name = "btnUpdateArray"
        Me.btnUpdateArray.Size = New System.Drawing.Size(127, 44)
        Me.btnUpdateArray.TabIndex = 4
        Me.btnUpdateArray.Text = "Update W  Array"
        Me.btnUpdateArray.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 305)
        Me.Controls.Add(Me.btnUpdateArray)
        Me.Controls.Add(Me.btnUpdateRnd)
        Me.Controls.Add(Me.btnUpdateLoop)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtContent)
        Me.KeyPreview = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnUpdateLoop As Button
    Friend WithEvents btnUpdateRnd As Button
    Friend WithEvents btnUpdateArray As Button
End Class
