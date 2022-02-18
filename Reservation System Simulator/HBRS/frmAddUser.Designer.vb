<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUser))
        Me.TextBoxusername = New System.Windows.Forms.TextBox()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.RadioButtonAdmin = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUser = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxverifypassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxusername
        '
        Me.TextBoxusername.Location = New System.Drawing.Point(45, 100)
        Me.TextBoxusername.Multiline = True
        Me.TextBoxusername.Name = "TextBoxusername"
        Me.TextBoxusername.Size = New System.Drawing.Size(209, 29)
        Me.TextBoxusername.TabIndex = 0
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(45, 158)
        Me.TextBoxpassword.Multiline = True
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpassword.Size = New System.Drawing.Size(209, 29)
        Me.TextBoxpassword.TabIndex = 1
        '
        'RadioButtonAdmin
        '
        Me.RadioButtonAdmin.AutoSize = True
        Me.RadioButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonAdmin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAdmin.ForeColor = System.Drawing.Color.White
        Me.RadioButtonAdmin.Location = New System.Drawing.Point(186, 252)
        Me.RadioButtonAdmin.Name = "RadioButtonAdmin"
        Me.RadioButtonAdmin.Size = New System.Drawing.Size(63, 20)
        Me.RadioButtonAdmin.TabIndex = 16
        Me.RadioButtonAdmin.Text = "Admin"
        Me.RadioButtonAdmin.UseVisualStyleBackColor = True
        '
        'RadioButtonUser
        '
        Me.RadioButtonUser.AutoSize = True
        Me.RadioButtonUser.Checked = True
        Me.RadioButtonUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUser.ForeColor = System.Drawing.Color.White
        Me.RadioButtonUser.Location = New System.Drawing.Point(127, 252)
        Me.RadioButtonUser.Name = "RadioButtonUser"
        Me.RadioButtonUser.Size = New System.Drawing.Size(53, 20)
        Me.RadioButtonUser.TabIndex = 15
        Me.RadioButtonUser.TabStop = True
        Me.RadioButtonUser.Text = "User"
        Me.RadioButtonUser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User Type:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UsernameLabel.Location = New System.Drawing.Point(45, 74)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(209, 23)
        Me.UsernameLabel.TabIndex = 17
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PasswordLabel.Location = New System.Drawing.Point(45, 132)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(209, 23)
        Me.PasswordLabel.TabIndex = 18
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel.Location = New System.Drawing.Point(152, 278)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 30)
        Me.Cancel.TabIndex = 20
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OK.Location = New System.Drawing.Point(49, 278)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 30)
        Me.OK.TabIndex = 19
        Me.OK.Text = "&OK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(35, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 31)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Add User Account"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(45, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "&Verify Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxverifypassword
        '
        Me.TextBoxverifypassword.Location = New System.Drawing.Point(45, 216)
        Me.TextBoxverifypassword.Multiline = True
        Me.TextBoxverifypassword.Name = "TextBoxverifypassword"
        Me.TextBoxverifypassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxverifypassword.Size = New System.Drawing.Size(209, 29)
        Me.TextBoxverifypassword.TabIndex = 22
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(298, 328)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxverifypassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.RadioButtonAdmin)
        Me.Controls.Add(Me.RadioButtonUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxpassword)
        Me.Controls.Add(Me.TextBoxusername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add User Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents RadioButtonAdmin As RadioButton
    Friend WithEvents RadioButtonUser As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxverifypassword As TextBox
End Class
