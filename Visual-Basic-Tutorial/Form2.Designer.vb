<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnUpdateString = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCallMethod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(12, 12)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(669, 234)
        Me.txtContent.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(13, 253)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 56)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update W Math"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdateString
        '
        Me.btnUpdateString.Location = New System.Drawing.Point(182, 253)
        Me.btnUpdateString.Name = "btnUpdateString"
        Me.btnUpdateString.Size = New System.Drawing.Size(163, 56)
        Me.btnUpdateString.TabIndex = 2
        Me.btnUpdateString.Text = "Update W Strings"
        Me.btnUpdateString.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 56)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update W Dates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCallMethod
        '
        Me.btnCallMethod.Location = New System.Drawing.Point(520, 252)
        Me.btnCallMethod.Name = "btnCallMethod"
        Me.btnCallMethod.Size = New System.Drawing.Size(163, 56)
        Me.btnCallMethod.TabIndex = 4
        Me.btnCallMethod.Text = "Call Method"
        Me.btnCallMethod.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 321)
        Me.Controls.Add(Me.btnCallMethod)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdateString)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtContent)
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnUpdateString As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCallMethod As Button
End Class
