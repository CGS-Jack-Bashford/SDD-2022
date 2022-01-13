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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlEnterName.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(446, 20)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(477, 64)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Maze Game"
        '
        'lblMazeSize
        '
        Me.lblMazeSize.AutoSize = True
        Me.lblMazeSize.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize.Location = New System.Drawing.Point(55, 184)
        Me.lblMazeSize.Name = "lblMazeSize"
        Me.lblMazeSize.Size = New System.Drawing.Size(168, 32)
        Me.lblMazeSize.TabIndex = 1
        Me.lblMazeSize.Text = "Maze Size"
        '
        'lblMazeSize10
        '
        Me.lblMazeSize10.AutoSize = True
        Me.lblMazeSize10.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMazeSize10.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize10.Location = New System.Drawing.Point(122, 234)
        Me.lblMazeSize10.Name = "lblMazeSize10"
        Me.lblMazeSize10.Size = New System.Drawing.Size(99, 32)
        Me.lblMazeSize10.TabIndex = 2
        Me.lblMazeSize10.Text = "10x10"
        '
        'lblMazeSize20
        '
        Me.lblMazeSize20.AutoSize = True
        Me.lblMazeSize20.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMazeSize20.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize20.Location = New System.Drawing.Point(122, 284)
        Me.lblMazeSize20.Name = "lblMazeSize20"
        Me.lblMazeSize20.Size = New System.Drawing.Size(101, 32)
        Me.lblMazeSize20.TabIndex = 3
        Me.lblMazeSize20.Text = "20x20"
        '
        'lblMazeSize30
        '
        Me.lblMazeSize30.AutoSize = True
        Me.lblMazeSize30.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMazeSize30.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize30.Location = New System.Drawing.Point(124, 334)
        Me.lblMazeSize30.Name = "lblMazeSize30"
        Me.lblMazeSize30.Size = New System.Drawing.Size(99, 32)
        Me.lblMazeSize30.TabIndex = 4
        Me.lblMazeSize30.Text = "30x30"
        '
        'lblMazeSeed
        '
        Me.lblMazeSeed.AutoSize = True
        Me.lblMazeSeed.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSeed.Enabled = False
        Me.lblMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSeed.Location = New System.Drawing.Point(55, 476)
        Me.lblMazeSeed.Name = "lblMazeSeed"
        Me.lblMazeSeed.Size = New System.Drawing.Size(168, 32)
        Me.lblMazeSeed.TabIndex = 5
        Me.lblMazeSeed.Text = "Maze Seed"
        '
        'txtMazeSeed
        '
        Me.txtMazeSeed.Enabled = False
        Me.txtMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMazeSeed.Location = New System.Drawing.Point(55, 522)
        Me.txtMazeSeed.Name = "txtMazeSeed"
        Me.txtMazeSeed.PlaceholderText = "Enter Seed"
        Me.txtMazeSeed.Size = New System.Drawing.Size(166, 36)
        Me.txtMazeSeed.TabIndex = 6
        '
        'btnMazeSize10Back
        '
        Me.btnMazeSize10Back.BackColor = System.Drawing.Color.Black
        Me.btnMazeSize10Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10Back.Enabled = False
        Me.btnMazeSize10Back.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10Back.Location = New System.Drawing.Point(82, 234)
        Me.btnMazeSize10Back.Name = "btnMazeSize10Back"
        Me.btnMazeSize10Back.Size = New System.Drawing.Size(34, 34)
        Me.btnMazeSize10Back.TabIndex = 7
        Me.btnMazeSize10Back.TabStop = False
        Me.btnMazeSize10Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize10
        '
        Me.btnMazeSize10.BackColor = System.Drawing.Color.White
        Me.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10.Location = New System.Drawing.Point(83, 235)
        Me.btnMazeSize10.Name = "btnMazeSize10"
        Me.btnMazeSize10.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize10.TabIndex = 7
        Me.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize20
        '
        Me.btnMazeSize20.BackColor = System.Drawing.Color.White
        Me.btnMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize20.FlatAppearance.BorderSize = 0
        Me.btnMazeSize20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize20.Location = New System.Drawing.Point(83, 285)
        Me.btnMazeSize20.Name = "btnMazeSize20"
        Me.btnMazeSize20.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize20.TabIndex = 8
        Me.btnMazeSize20.UseVisualStyleBackColor = False
        '
        'btnMazeSize20Back
        '
        Me.btnMazeSize20Back.BackColor = System.Drawing.Color.Black
        Me.btnMazeSize20Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize20Back.FlatAppearance.BorderSize = 0
        Me.btnMazeSize20Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize20Back.Location = New System.Drawing.Point(82, 284)
        Me.btnMazeSize20Back.Name = "btnMazeSize20Back"
        Me.btnMazeSize20Back.Size = New System.Drawing.Size(34, 34)
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
        Me.btnMazeSize30Back.Location = New System.Drawing.Point(82, 334)
        Me.btnMazeSize30Back.Name = "btnMazeSize30Back"
        Me.btnMazeSize30Back.Size = New System.Drawing.Size(34, 34)
        Me.btnMazeSize30Back.TabIndex = 10
        Me.btnMazeSize30Back.TabStop = False
        Me.btnMazeSize30Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize30
        '
        Me.btnMazeSize30.BackColor = System.Drawing.Color.White
        Me.btnMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize30.FlatAppearance.BorderSize = 0
        Me.btnMazeSize30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize30.Location = New System.Drawing.Point(83, 335)
        Me.btnMazeSize30.Name = "btnMazeSize30"
        Me.btnMazeSize30.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize30.TabIndex = 11
        Me.btnMazeSize30.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.White
        Me.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInstructions.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInstructions.Location = New System.Drawing.Point(520, 266)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(300, 70)
        Me.btnInstructions.TabIndex = 12
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnHighscores
        '
        Me.btnHighscores.BackColor = System.Drawing.Color.White
        Me.btnHighscores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHighscores.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHighscores.Location = New System.Drawing.Point(859, 266)
        Me.btnHighscores.Name = "btnHighscores"
        Me.btnHighscores.Size = New System.Drawing.Size(300, 70)
        Me.btnHighscores.TabIndex = 13
        Me.btnHighscores.Text = "Highscores"
        Me.btnHighscores.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.Location = New System.Drawing.Point(859, 396)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(300, 70)
        Me.btnPlay.TabIndex = 14
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(4, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = "Enter Name"
        Me.txtName.Size = New System.Drawing.Size(292, 27)
        Me.txtName.TabIndex = 15
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlEnterName
        '
        Me.pnlEnterName.BackColor = System.Drawing.Color.White
        Me.pnlEnterName.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pnlEnterName.ColumnCount = 1
        Me.pnlEnterName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEnterName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlEnterName.Controls.Add(Me.txtName, 0, 0)
        Me.pnlEnterName.Location = New System.Drawing.Point(520, 396)
        Me.pnlEnterName.Name = "pnlEnterName"
        Me.pnlEnterName.RowCount = 1
        Me.pnlEnterName.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEnterName.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.pnlEnterName.Size = New System.Drawing.Size(300, 70)
        Me.pnlEnterName.TabIndex = 16
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.pnlEnterName)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnHighscores)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnMazeSize10)
        Me.Controls.Add(Me.btnMazeSize20)
        Me.Controls.Add(Me.btnMazeSize30)
        Me.Controls.Add(Me.btnMazeSize10Back)
        Me.Controls.Add(Me.btnMazeSize20Back)
        Me.Controls.Add(Me.btnMazeSize30Back)
        Me.Controls.Add(Me.txtMazeSeed)
        Me.Controls.Add(Me.lblMazeSeed)
        Me.Controls.Add(Me.lblMazeSize10)
        Me.Controls.Add(Me.lblMazeSize20)
        Me.Controls.Add(Me.lblMazeSize30)
        Me.Controls.Add(Me.lblMazeSize)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
