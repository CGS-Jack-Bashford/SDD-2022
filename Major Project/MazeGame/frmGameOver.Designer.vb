<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameOver))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMazeSize10 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize10Back = New MazeGame.ButtonEllipse()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(458, 20)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(452, 64)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Game Over"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(488, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(488, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Size:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(487, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seed:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(488, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(593, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "_mac_equivalent_"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(644, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 32)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "_mac_equivale"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(593, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 32)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "_mac_equivalent_"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(593, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(286, 32)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "_mac_equivalent_"
        '
        'btnMazeSize10
        '
        Me.btnMazeSize10.BackColor = System.Drawing.Color.White
        Me.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10.Enabled = False
        Me.btnMazeSize10.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10.Location = New System.Drawing.Point(595, 285)
        Me.btnMazeSize10.Name = "btnMazeSize10"
        Me.btnMazeSize10.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize10.TabIndex = 10
        Me.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize10Back
        '
        Me.btnMazeSize10Back.BackColor = System.Drawing.Color.Black
        Me.btnMazeSize10Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10Back.Enabled = False
        Me.btnMazeSize10Back.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10Back.Location = New System.Drawing.Point(594, 284)
        Me.btnMazeSize10Back.Name = "btnMazeSize10Back"
        Me.btnMazeSize10Back.Size = New System.Drawing.Size(34, 34)
        Me.btnMazeSize10Back.TabIndex = 11
        Me.btnMazeSize10Back.TabStop = False
        Me.btnMazeSize10Back.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(734, 529)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 70)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Highscores"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.White
        Me.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInstructions.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInstructions.Location = New System.Drawing.Point(334, 529)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(300, 70)
        Me.btnInstructions.TabIndex = 13
        Me.btnInstructions.Text = "Back to Start"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnMazeSize10)
        Me.Controls.Add(Me.btnMazeSize10Back)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmGameOver"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMazeSize10 As ButtonEllipse
    Friend WithEvents btnMazeSize10Back As ButtonEllipse
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInstructions As Button
End Class
