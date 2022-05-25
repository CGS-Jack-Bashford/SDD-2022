<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHelp1 = New System.Windows.Forms.Label()
        Me.lblHelp2 = New System.Windows.Forms.Label()
        Me.lblHelp3 = New System.Windows.Forms.Label()
        Me.lblHelp4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(100, 23)
        Me.lblTitle.TabIndex = 5
        '
        'lblHelp1
        '
        Me.lblHelp1.Location = New System.Drawing.Point(0, 0)
        Me.lblHelp1.Name = "lblHelp1"
        Me.lblHelp1.Size = New System.Drawing.Size(100, 23)
        Me.lblHelp1.TabIndex = 4
        '
        'lblHelp2
        '
        Me.lblHelp2.Location = New System.Drawing.Point(0, 0)
        Me.lblHelp2.Name = "lblHelp2"
        Me.lblHelp2.Size = New System.Drawing.Size(100, 23)
        Me.lblHelp2.TabIndex = 3
        '
        'lblHelp3
        '
        Me.lblHelp3.Location = New System.Drawing.Point(0, 0)
        Me.lblHelp3.Name = "lblHelp3"
        Me.lblHelp3.Size = New System.Drawing.Size(100, 23)
        Me.lblHelp3.TabIndex = 2
        '
        'lblHelp4
        '
        Me.lblHelp4.Location = New System.Drawing.Point(0, 0)
        Me.lblHelp4.Name = "lblHelp4"
        Me.lblHelp4.Size = New System.Drawing.Size(100, 23)
        Me.lblHelp4.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHelp4)
        Me.Controls.Add(Me.lblHelp3)
        Me.Controls.Add(Me.lblHelp2)
        Me.Controls.Add(Me.lblHelp1)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmHelp"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHelp1 As Label
    Friend WithEvents lblHelp2 As Label
    Friend WithEvents lblHelp3 As Label
    Friend WithEvents lblHelp4 As Label
    Friend WithEvents btnClose As Button
End Class
