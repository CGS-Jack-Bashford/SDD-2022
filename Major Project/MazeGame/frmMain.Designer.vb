<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMazeSize = New System.Windows.Forms.Label()
        Me.lblMazeSize10 = New System.Windows.Forms.Label()
        Me.lblMazeSize20 = New System.Windows.Forms.Label()
        Me.lblMazeSize30 = New System.Windows.Forms.Label()
        Me.lblMazeSeed = New System.Windows.Forms.Label()
        Me.txtMazeSeed = New System.Windows.Forms.TextBox()
        Me.btnMazeSize10Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize10 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize20 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize20Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize30Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize30 = New MazeGame.ButtonEllipse()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnHighscores = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlEnterName = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMazeSizeRandom = New MazeGame.ButtonEllipse()
        Me.btnMazeSizeRandomBack = New MazeGame.ButtonEllipse()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlEnterName.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(828, 43)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(960, 128)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Maze Game"
        '
        'lblMazeSize
        '
        Me.lblMazeSize.AutoSize = True
        Me.lblMazeSize.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize.Location = New System.Drawing.Point(102, 393)
        Me.lblMazeSize.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMazeSize.Name = "lblMazeSize"
        Me.lblMazeSize.Size = New System.Drawing.Size(342, 64)
        Me.lblMazeSize.TabIndex = 1
        Me.lblMazeSize.Text = "Maze Size"
        '
        'lblMazeSize10
        '
        Me.lblMazeSize10.AutoSize = True
        Me.lblMazeSize10.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMazeSize10.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize10.Location = New System.Drawing.Point(227, 499)
        Me.lblMazeSize10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMazeSize10.Name = "lblMazeSize10"
        Me.lblMazeSize10.Size = New System.Drawing.Size(202, 64)
        Me.lblMazeSize10.TabIndex = 2
        Me.lblMazeSize10.Text = "10x10"
        '
        'lblMazeSize20
        '
        Me.lblMazeSize20.AutoSize = True
        Me.lblMazeSize20.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMazeSize20.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize20.Location = New System.Drawing.Point(227, 606)
        Me.lblMazeSize20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMazeSize20.Name = "lblMazeSize20"
        Me.lblMazeSize20.Size = New System.Drawing.Size(202, 64)
        Me.lblMazeSize20.TabIndex = 3
        Me.lblMazeSize20.Text = "20x20"
        '
        'lblMazeSize30
        '
        Me.lblMazeSize30.AutoSize = True
        Me.lblMazeSize30.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMazeSize30.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize30.Location = New System.Drawing.Point(230, 713)
        Me.lblMazeSize30.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMazeSize30.Name = "lblMazeSize30"
        Me.lblMazeSize30.Size = New System.Drawing.Size(202, 64)
        Me.lblMazeSize30.TabIndex = 4
        Me.lblMazeSize30.Text = "30x30"
        '
        'lblMazeSeed
        '
        Me.lblMazeSeed.AutoSize = True
        Me.lblMazeSeed.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSeed.Enabled = False
        Me.lblMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSeed.Location = New System.Drawing.Point(102, 1015)
        Me.lblMazeSeed.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMazeSeed.Name = "lblMazeSeed"
        Me.lblMazeSeed.Size = New System.Drawing.Size(342, 64)
        Me.lblMazeSeed.TabIndex = 5
        Me.lblMazeSeed.Text = "Maze Seed"
        '
        'txtMazeSeed
        '
        Me.txtMazeSeed.Enabled = False
        Me.txtMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMazeSeed.Location = New System.Drawing.Point(102, 1114)
        Me.txtMazeSeed.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMazeSeed.Name = "txtMazeSeed"
        Me.txtMazeSeed.PlaceholderText = "Enter Seed"
        Me.txtMazeSeed.Size = New System.Drawing.Size(305, 65)
        Me.txtMazeSeed.TabIndex = 6
        '
        'btnMazeSize10Back
        '
        Me.btnMazeSize10Back.BackColor = System.Drawing.Color.Black
        Me.btnMazeSize10Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10Back.Enabled = False
        Me.btnMazeSize10Back.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10Back.Location = New System.Drawing.Point(152, 499)
        Me.btnMazeSize10Back.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSize10Back.Name = "btnMazeSize10Back"
        Me.btnMazeSize10Back.Size = New System.Drawing.Size(63, 73)
        Me.btnMazeSize10Back.TabIndex = 7
        Me.btnMazeSize10Back.TabStop = False
        Me.btnMazeSize10Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize10
        '
        Me.btnMazeSize10.BackColor = System.Drawing.Color.White
        Me.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMazeSize10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10.Location = New System.Drawing.Point(154, 501)
        Me.btnMazeSize10.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSize10.Name = "btnMazeSize10"
        Me.btnMazeSize10.Size = New System.Drawing.Size(59, 68)
        Me.btnMazeSize10.TabIndex = 7
        Me.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize20
        '
        Me.btnMazeSize20.BackColor = System.Drawing.Color.White
        Me.btnMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize20.FlatAppearance.BorderSize = 0
        Me.btnMazeSize20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMazeSize20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMazeSize20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize20.Location = New System.Drawing.Point(154, 608)
        Me.btnMazeSize20.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSize20.Name = "btnMazeSize20"
        Me.btnMazeSize20.Size = New System.Drawing.Size(59, 68)
        Me.btnMazeSize20.TabIndex = 8
        Me.btnMazeSize20.UseVisualStyleBackColor = False
        '
        'btnMazeSize20Back
        '
        Me.btnMazeSize20Back.BackColor = System.Drawing.Color.Black
        Me.btnMazeSize20Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize20Back.FlatAppearance.BorderSize = 0
        Me.btnMazeSize20Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize20Back.Location = New System.Drawing.Point(152, 606)
        Me.btnMazeSize20Back.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSize20Back.Name = "btnMazeSize20Back"
        Me.btnMazeSize20Back.Size = New System.Drawing.Size(63, 73)
        Me.btnMazeSize20Back.TabIndex = 9
        Me.btnMazeSize20Back.TabStop = False
        Me.btnMazeSize20Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize30Back
        '
        Me.btnMazeSize30Back.BackColor = System.Drawing.Color.Black
        Me.btnMazeSize30Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize30Back.FlatAppearance.BorderSize = 0
        Me.btnMazeSize30Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize30Back.Location = New System.Drawing.Point(152, 713)
        Me.btnMazeSize30Back.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSize30Back.Name = "btnMazeSize30Back"
        Me.btnMazeSize30Back.Size = New System.Drawing.Size(63, 73)
        Me.btnMazeSize30Back.TabIndex = 10
        Me.btnMazeSize30Back.TabStop = False
        Me.btnMazeSize30Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize30
        '
        Me.btnMazeSize30.BackColor = System.Drawing.Color.White
        Me.btnMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize30.FlatAppearance.BorderSize = 0
        Me.btnMazeSize30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMazeSize30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMazeSize30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize30.Location = New System.Drawing.Point(154, 715)
        Me.btnMazeSize30.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSize30.Name = "btnMazeSize30"
        Me.btnMazeSize30.Size = New System.Drawing.Size(59, 68)
        Me.btnMazeSize30.TabIndex = 11
        Me.btnMazeSize30.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.White
        Me.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInstructions.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInstructions.Location = New System.Drawing.Point(966, 567)
        Me.btnInstructions.Margin = New System.Windows.Forms.Padding(6)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(557, 149)
        Me.btnInstructions.TabIndex = 12
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnHighscores
        '
        Me.btnHighscores.BackColor = System.Drawing.Color.White
        Me.btnHighscores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHighscores.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHighscores.Location = New System.Drawing.Point(1595, 567)
        Me.btnHighscores.Margin = New System.Windows.Forms.Padding(6)
        Me.btnHighscores.Name = "btnHighscores"
        Me.btnHighscores.Size = New System.Drawing.Size(557, 149)
        Me.btnHighscores.TabIndex = 13
        Me.btnHighscores.Text = "Highscores"
        Me.btnHighscores.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.Location = New System.Drawing.Point(1595, 845)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(557, 149)
        Me.btnPlay.TabIndex = 14
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(7, 47)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = "Enter Name"
        Me.txtName.Size = New System.Drawing.Size(543, 54)
        Me.txtName.TabIndex = 15
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlEnterName
        '
        Me.pnlEnterName.BackColor = System.Drawing.Color.White
        Me.pnlEnterName.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pnlEnterName.ColumnCount = 1
        Me.pnlEnterName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEnterName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.pnlEnterName.Controls.Add(Me.txtName, 0, 0)
        Me.pnlEnterName.Location = New System.Drawing.Point(966, 845)
        Me.pnlEnterName.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlEnterName.Name = "pnlEnterName"
        Me.pnlEnterName.RowCount = 1
        Me.pnlEnterName.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEnterName.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.pnlEnterName.Size = New System.Drawing.Size(557, 149)
        Me.pnlEnterName.TabIndex = 16
        '
        'btnMazeSizeRandom
        '
        Me.btnMazeSizeRandom.BackColor = System.Drawing.Color.White
        Me.btnMazeSizeRandom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSizeRandom.FlatAppearance.BorderSize = 0
        Me.btnMazeSizeRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMazeSizeRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMazeSizeRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSizeRandom.Location = New System.Drawing.Point(154, 821)
        Me.btnMazeSizeRandom.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSizeRandom.Name = "btnMazeSizeRandom"
        Me.btnMazeSizeRandom.Size = New System.Drawing.Size(59, 68)
        Me.btnMazeSizeRandom.TabIndex = 19
        Me.btnMazeSizeRandom.UseVisualStyleBackColor = False
        '
        'btnMazeSizeRandomBack
        '
        Me.btnMazeSizeRandomBack.BackColor = System.Drawing.Color.Black
        Me.btnMazeSizeRandomBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSizeRandomBack.FlatAppearance.BorderSize = 0
        Me.btnMazeSizeRandomBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSizeRandomBack.Location = New System.Drawing.Point(152, 819)
        Me.btnMazeSizeRandomBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMazeSizeRandomBack.Name = "btnMazeSizeRandomBack"
        Me.btnMazeSizeRandomBack.Size = New System.Drawing.Size(63, 73)
        Me.btnMazeSizeRandomBack.TabIndex = 18
        Me.btnMazeSizeRandomBack.TabStop = False
        Me.btnMazeSizeRandomBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(230, 819)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 64)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Random"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2511, 1555)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlEnterName)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnHighscores)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnMazeSize10)
        Me.Controls.Add(Me.btnMazeSize20)
        Me.Controls.Add(Me.btnMazeSize30)
        Me.Controls.Add(Me.btnMazeSizeRandom)
        Me.Controls.Add(Me.btnMazeSize10Back)
        Me.Controls.Add(Me.btnMazeSize20Back)
        Me.Controls.Add(Me.btnMazeSize30Back)
        Me.Controls.Add(Me.btnMazeSizeRandomBack)
        Me.Controls.Add(Me.txtMazeSeed)
        Me.Controls.Add(Me.lblMazeSeed)
        Me.Controls.Add(Me.lblMazeSize10)
        Me.Controls.Add(Me.lblMazeSize20)
        Me.Controls.Add(Me.lblMazeSize30)
        Me.Controls.Add(Me.lblMazeSize)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Maze Game"
        Me.pnlEnterName.ResumeLayout(False)
        Me.pnlEnterName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMazeSize As Label
    Friend WithEvents lblMazeSize10 As Label
    Friend WithEvents lblMazeSize20 As Label
    Friend WithEvents lblMazeSize30 As Label
    Friend WithEvents lblMazeSeed As Label
    Friend WithEvents txtMazeSeed As TextBox
    Friend WithEvents btnMazeSize10Back As ButtonEllipse
    Friend WithEvents btnMazeSize10 As ButtonEllipse
    Friend WithEvents btnMazeSize20 As ButtonEllipse
    Friend WithEvents btnMazeSize20Back As ButtonEllipse
    Friend WithEvents btnMazeSize30Back As ButtonEllipse
    Friend WithEvents btnMazeSize30 As ButtonEllipse
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnHighscores As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents pnlEnterName As TableLayoutPanel
    Friend WithEvents btnMazeSizeRandom As ButtonEllipse
    Friend WithEvents btnMazeSizeRandomBack As ButtonEllipse
    Friend WithEvents Label1 As Label
End Class
