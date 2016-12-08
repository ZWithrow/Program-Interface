<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.msgTextBox1 = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(12, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name"
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(12, 58)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(18, 13)
        Me.idLabel.TabIndex = 1
        Me.idLabel.Text = "ID"
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Location = New System.Drawing.Point(12, 108)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(50, 13)
        Me.msgLabel.TabIndex = 2
        Me.msgLabel.Text = "Message"
        '
        'nameTextBox1
        '
        Me.nameTextBox1.Location = New System.Drawing.Point(120, 6)
        Me.nameTextBox1.Name = "nameTextBox1"
        Me.nameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.nameTextBox1.TabIndex = 3
        '
        'IDTextBox1
        '
        Me.IDTextBox1.Location = New System.Drawing.Point(120, 58)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox1.TabIndex = 4
        '
        'msgTextBox1
        '
        Me.msgTextBox1.Location = New System.Drawing.Point(120, 101)
        Me.msgTextBox1.Name = "msgTextBox1"
        Me.msgTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.msgTextBox1.TabIndex = 5
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(15, 208)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 6
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'viewButton
        '
        Me.viewButton.Location = New System.Drawing.Point(145, 208)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(75, 23)
        Me.viewButton.TabIndex = 7
        Me.viewButton.Text = "VIew"
        Me.viewButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.msgTextBox1)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(Me.nameTextBox1)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents idLabel As Label
    Friend WithEvents msgLabel As Label
    Friend WithEvents nameTextBox1 As TextBox
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents msgTextBox1 As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents viewButton As Button
End Class
