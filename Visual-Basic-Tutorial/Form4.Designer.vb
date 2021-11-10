<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnUpdateWEnum = New System.Windows.Forms.Button()
        Me.btnUpdateWStruct = New System.Windows.Forms.Button()
        Me.btnUpdateWOOPDog = New System.Windows.Forms.Button()
        Me.btnUpdateWOOPCat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(12, 12)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(616, 254)
        Me.txtContent.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 273)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 59)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update W List"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdateWEnum
        '
        Me.btnUpdateWEnum.Location = New System.Drawing.Point(136, 273)
        Me.btnUpdateWEnum.Name = "btnUpdateWEnum"
        Me.btnUpdateWEnum.Size = New System.Drawing.Size(118, 59)
        Me.btnUpdateWEnum.TabIndex = 2
        Me.btnUpdateWEnum.Text = "Update W Enum"
        Me.btnUpdateWEnum.UseVisualStyleBackColor = True
        '
        'btnUpdateWStruct
        '
        Me.btnUpdateWStruct.Location = New System.Drawing.Point(260, 273)
        Me.btnUpdateWStruct.Name = "btnUpdateWStruct"
        Me.btnUpdateWStruct.Size = New System.Drawing.Size(118, 59)
        Me.btnUpdateWStruct.TabIndex = 3
        Me.btnUpdateWStruct.Text = "Update W Struct"
        Me.btnUpdateWStruct.UseVisualStyleBackColor = True
        '
        'btnUpdateWOOPDog
        '
        Me.btnUpdateWOOPDog.Location = New System.Drawing.Point(384, 273)
        Me.btnUpdateWOOPDog.Name = "btnUpdateWOOPDog"
        Me.btnUpdateWOOPDog.Size = New System.Drawing.Size(118, 59)
        Me.btnUpdateWOOPDog.TabIndex = 4
        Me.btnUpdateWOOPDog.Text = "Update W OOP Dog"
        Me.btnUpdateWOOPDog.UseVisualStyleBackColor = True
        '
        'btnUpdateWOOPCat
        '
        Me.btnUpdateWOOPCat.Location = New System.Drawing.Point(508, 273)
        Me.btnUpdateWOOPCat.Name = "btnUpdateWOOPCat"
        Me.btnUpdateWOOPCat.Size = New System.Drawing.Size(118, 59)
        Me.btnUpdateWOOPCat.TabIndex = 5
        Me.btnUpdateWOOPCat.Text = "Update W OOP Cat"
        Me.btnUpdateWOOPCat.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 344)
        Me.Controls.Add(Me.btnUpdateWOOPCat)
        Me.Controls.Add(Me.btnUpdateWOOPDog)
        Me.Controls.Add(Me.btnUpdateWStruct)
        Me.Controls.Add(Me.btnUpdateWEnum)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtContent)
        Me.KeyPreview = True
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnUpdateWEnum As Button
    Friend WithEvents btnUpdateWStruct As Button
    Friend WithEvents btnUpdateWOOPDog As Button
    Friend WithEvents btnUpdateWOOPCat As Button
End Class
