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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_firstName = New System.Windows.Forms.TextBox
        Me.txt_lastName = New System.Windows.Forms.TextBox
        Me.saveButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.listBox_users = New System.Windows.Forms.ListBox
        Me.getButton = New System.Windows.Forms.Button
        Me.deleteButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.saveButton)
        Me.GroupBox1.Controls.Add(Me.txt_lastName)
        Me.GroupBox1.Controls.Add(Me.txt_firstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INSERT DATA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'txt_firstName
        '
        Me.txt_firstName.Location = New System.Drawing.Point(10, 37)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(115, 20)
        Me.txt_firstName.TabIndex = 2
        '
        'txt_lastName
        '
        Me.txt_lastName.Location = New System.Drawing.Point(140, 37)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(112, 20)
        Me.txt_lastName.TabIndex = 3
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(270, 34)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 4
        Me.saveButton.Text = "SAVE"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deleteButton)
        Me.GroupBox2.Controls.Add(Me.getButton)
        Me.GroupBox2.Controls.Add(Me.listBox_users)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 171)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECT DATA"
        '
        'listBox_users
        '
        Me.listBox_users.FormattingEnabled = True
        Me.listBox_users.Location = New System.Drawing.Point(10, 46)
        Me.listBox_users.Name = "listBox_users"
        Me.listBox_users.Size = New System.Drawing.Size(365, 121)
        Me.listBox_users.TabIndex = 0
        '
        'getButton
        '
        Me.getButton.Location = New System.Drawing.Point(300, 17)
        Me.getButton.Name = "getButton"
        Me.getButton.Size = New System.Drawing.Size(75, 23)
        Me.getButton.TabIndex = 1
        Me.getButton.Text = "GET"
        Me.getButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(120, 17)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(132, 23)
        Me.deleteButton.TabIndex = 2
        Me.deleteButton.Text = "DELETE SELECTED"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 269)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "mySQL DB TEST"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents txt_lastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents listBox_users As System.Windows.Forms.ListBox
    Friend WithEvents getButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button

End Class
