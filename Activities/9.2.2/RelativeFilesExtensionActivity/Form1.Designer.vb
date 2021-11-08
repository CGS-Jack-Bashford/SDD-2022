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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCheckCredentials = New System.Windows.Forms.Button()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.txtChangeOld = New System.Windows.Forms.TextBox()
        Me.txtChangeUser = New System.Windows.Forms.TextBox()
        Me.txtChangeNew = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(13, 13)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 23)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(13, 43)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 23)
        Me.txtPassword.TabIndex = 1
        '
        'btnCheckCredentials
        '
        Me.btnCheckCredentials.Location = New System.Drawing.Point(13, 73)
        Me.btnCheckCredentials.Name = "btnCheckCredentials"
        Me.btnCheckCredentials.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckCredentials.TabIndex = 2
        Me.btnCheckCredentials.Text = "CheckValid"
        Me.btnCheckCredentials.UseVisualStyleBackColor = True
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(158, 43)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(100, 23)
        Me.txtNewPass.TabIndex = 4
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(158, 13)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(100, 23)
        Me.txtNewName.TabIndex = 3
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(158, 73)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 23)
        Me.btnAddUser.TabIndex = 5
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(299, 100)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(81, 23)
        Me.btnChangePass.TabIndex = 8
        Me.btnChangePass.Text = "ChangePass"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'txtChangeOld
        '
        Me.txtChangeOld.Location = New System.Drawing.Point(299, 42)
        Me.txtChangeOld.Name = "txtChangeOld"
        Me.txtChangeOld.Size = New System.Drawing.Size(100, 23)
        Me.txtChangeOld.TabIndex = 7
        '
        'txtChangeUser
        '
        Me.txtChangeUser.Location = New System.Drawing.Point(299, 12)
        Me.txtChangeUser.Name = "txtChangeUser"
        Me.txtChangeUser.Size = New System.Drawing.Size(100, 23)
        Me.txtChangeUser.TabIndex = 6
        '
        'txtChangeNew
        '
        Me.txtChangeNew.Location = New System.Drawing.Point(299, 71)
        Me.txtChangeNew.Name = "txtChangeNew"
        Me.txtChangeNew.Size = New System.Drawing.Size(100, 23)
        Me.txtChangeNew.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtChangeNew)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.txtChangeOld)
        Me.Controls.Add(Me.txtChangeUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.btnCheckCredentials)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCheckCredentials As Button
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtNewName As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnChangePass As Button
    Friend WithEvents txtChangeOld As TextBox
    Friend WithEvents txtChangeUser As TextBox
    Friend WithEvents txtChangeNew As TextBox
End Class
