Module frmMainDesigner

    Public Sub configureFrmMain()
        '
        'lblTitle
        '
        frmMain.lblTitle.AutoSize = True
        frmMain.lblTitle.BackColor = System.Drawing.Color.Transparent
        frmMain.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmMain.lblTitle.Location = New System.Drawing.Point(446, 20)
        frmMain.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        frmMain.lblTitle.Name = "lblTitle"
        frmMain.lblTitle.Size = New System.Drawing.Size(477, 64)
        frmMain.lblTitle.TabIndex = 0
        frmMain.lblTitle.Text = "Maze Game"
        '
        'lblMazeSize
        '
        frmMain.lblMazeSize.AutoSize = True
        frmMain.lblMazeSize.BackColor = System.Drawing.Color.Transparent
        frmMain.lblMazeSize.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.lblMazeSize.Location = New System.Drawing.Point(55, 184)
        frmMain.lblMazeSize.Name = "lblMazeSize"
        frmMain.lblMazeSize.Size = New System.Drawing.Size(168, 32)
        frmMain.lblMazeSize.TabIndex = 1
        frmMain.lblMazeSize.Text = "Maze Size"
        '
        'lblMazeSize10
        '
        frmMain.lblMazeSize10.AutoSize = True
        frmMain.lblMazeSize10.BackColor = System.Drawing.Color.Transparent
        frmMain.lblMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.lblMazeSize10.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.lblMazeSize10.Location = New System.Drawing.Point(122, 234)
        frmMain.lblMazeSize10.Name = "lblMazeSize10"
        frmMain.lblMazeSize10.Size = New System.Drawing.Size(99, 32)
        frmMain.lblMazeSize10.TabIndex = 2
        frmMain.lblMazeSize10.Text = "10x10"
        '
        'lblMazeSize20
        '
        frmMain.lblMazeSize20.AutoSize = True
        frmMain.lblMazeSize20.BackColor = System.Drawing.Color.Transparent
        frmMain.lblMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.lblMazeSize20.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.lblMazeSize20.Location = New System.Drawing.Point(122, 284)
        frmMain.lblMazeSize20.Name = "lblMazeSize20"
        frmMain.lblMazeSize20.Size = New System.Drawing.Size(101, 32)
        frmMain.lblMazeSize20.TabIndex = 3
        frmMain.lblMazeSize20.Text = "20x20"
        '
        'lblMazeSize30
        '
        frmMain.lblMazeSize30.AutoSize = True
        frmMain.lblMazeSize30.BackColor = System.Drawing.Color.Transparent
        frmMain.lblMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.lblMazeSize30.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.lblMazeSize30.Location = New System.Drawing.Point(124, 334)
        frmMain.lblMazeSize30.Name = "lblMazeSize30"
        frmMain.lblMazeSize30.Size = New System.Drawing.Size(99, 32)
        frmMain.lblMazeSize30.TabIndex = 4
        frmMain.lblMazeSize30.Text = "30x30"
        '
        'lblMazeSizeRandom
        '
        frmMain.lblMazeSizeRandom.AutoSize = True
        frmMain.lblMazeSizeRandom.BackColor = System.Drawing.Color.Transparent
        frmMain.lblMazeSizeRandom.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.lblMazeSizeRandom.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.lblMazeSizeRandom.Location = New System.Drawing.Point(122, 384)
        frmMain.lblMazeSizeRandom.Name = "lblMazeSizeRandom"
        frmMain.lblMazeSizeRandom.Size = New System.Drawing.Size(99, 32)
        frmMain.lblMazeSizeRandom.TabIndex = 4
        frmMain.lblMazeSizeRandom.Text = "Random"
        '
        'lblMazeSeed
        '
        frmMain.lblMazeSeed.AutoSize = True
        frmMain.lblMazeSeed.BackColor = System.Drawing.Color.Transparent
        frmMain.lblMazeSeed.Enabled = False
        frmMain.lblMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.lblMazeSeed.Location = New System.Drawing.Point(55, 476)
        frmMain.lblMazeSeed.Name = "lblMazeSeed"
        frmMain.lblMazeSeed.Size = New System.Drawing.Size(168, 32)
        frmMain.lblMazeSeed.TabIndex = 5
        frmMain.lblMazeSeed.Text = "Maze Seed"
        '
        'txtMazeSeed
        '
        frmMain.txtMazeSeed.Enabled = False
        frmMain.txtMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.txtMazeSeed.Location = New System.Drawing.Point(55, 522)
        frmMain.txtMazeSeed.Name = "txtMazeSeed"
        frmMain.txtMazeSeed.PlaceholderText = "Enter Seed"
        frmMain.txtMazeSeed.Size = New System.Drawing.Size(166, 36)
        frmMain.txtMazeSeed.TabIndex = 6
        '
        'btnMazeSize10Back
        '
        frmMain.btnMazeSize10Back.BackColor = System.Drawing.Color.Black
        frmMain.btnMazeSize10Back.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSize10Back.Enabled = False
        frmMain.btnMazeSize10Back.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSize10Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSize10Back.Location = New System.Drawing.Point(82, 234)
        frmMain.btnMazeSize10Back.Name = "btnMazeSize10Back"
        frmMain.btnMazeSize10Back.Size = New System.Drawing.Size(34, 34)
        frmMain.btnMazeSize10Back.TabIndex = 7
        frmMain.btnMazeSize10Back.TabStop = False
        frmMain.btnMazeSize10Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize10
        '
        frmMain.btnMazeSize10.BackColor = System.Drawing.Color.White
        frmMain.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSize10.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSize10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        frmMain.btnMazeSize10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        frmMain.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSize10.Location = New System.Drawing.Point(83, 235)
        frmMain.btnMazeSize10.Name = "btnMazeSize10"
        frmMain.btnMazeSize10.Size = New System.Drawing.Size(32, 32)
        frmMain.btnMazeSize10.TabIndex = 7
        frmMain.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize20
        '
        frmMain.btnMazeSize20.BackColor = System.Drawing.Color.White
        frmMain.btnMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSize20.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSize20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        frmMain.btnMazeSize20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        frmMain.btnMazeSize20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSize20.Location = New System.Drawing.Point(83, 285)
        frmMain.btnMazeSize20.Name = "btnMazeSize20"
        frmMain.btnMazeSize20.Size = New System.Drawing.Size(32, 32)
        frmMain.btnMazeSize20.TabIndex = 8
        frmMain.btnMazeSize20.UseVisualStyleBackColor = False
        '
        'btnMazeSize20Back
        '
        frmMain.btnMazeSize20Back.BackColor = System.Drawing.Color.Black
        frmMain.btnMazeSize20Back.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSize20Back.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSize20Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSize20Back.Location = New System.Drawing.Point(82, 284)
        frmMain.btnMazeSize20Back.Name = "btnMazeSize20Back"
        frmMain.btnMazeSize20Back.Size = New System.Drawing.Size(34, 34)
        frmMain.btnMazeSize20Back.TabIndex = 9
        frmMain.btnMazeSize20Back.TabStop = False
        frmMain.btnMazeSize20Back.UseVisualStyleBackColor = False
        '
        'btnMazeSize30
        '
        frmMain.btnMazeSize30.BackColor = System.Drawing.Color.White
        frmMain.btnMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSize30.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSize30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        frmMain.btnMazeSize30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        frmMain.btnMazeSize30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSize30.Location = New System.Drawing.Point(83, 335)
        frmMain.btnMazeSize30.Name = "btnMazeSize30"
        frmMain.btnMazeSize30.Size = New System.Drawing.Size(32, 32)
        frmMain.btnMazeSize30.TabIndex = 11
        frmMain.btnMazeSize30.UseVisualStyleBackColor = False
        '
        'btnMazeSize30Back
        '
        frmMain.btnMazeSize30Back.BackColor = System.Drawing.Color.Black
        frmMain.btnMazeSize30Back.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSize30Back.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSize30Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSize30Back.Location = New System.Drawing.Point(82, 334)
        frmMain.btnMazeSize30Back.Name = "btnMazeSize30Back"
        frmMain.btnMazeSize30Back.Size = New System.Drawing.Size(34, 34)
        frmMain.btnMazeSize30Back.TabIndex = 10
        frmMain.btnMazeSize30Back.TabStop = False
        frmMain.btnMazeSize30Back.UseVisualStyleBackColor = False
        '
        'btnMazeSizeRandom
        '
        frmMain.btnMazeSizeRandom.BackColor = System.Drawing.Color.White
        frmMain.btnMazeSizeRandom.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSizeRandom.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSizeRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        frmMain.btnMazeSizeRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        frmMain.btnMazeSizeRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSizeRandom.Location = New System.Drawing.Point(83, 385)
        frmMain.btnMazeSizeRandom.Name = "btnMazeSizeRandom"
        frmMain.btnMazeSizeRandom.Size = New System.Drawing.Size(32, 32)
        frmMain.btnMazeSizeRandom.TabIndex = 11
        frmMain.btnMazeSizeRandom.UseVisualStyleBackColor = False
        '
        'btnMazeSizeRandomBack
        '
        frmMain.btnMazeSizeRandomBack.BackColor = System.Drawing.Color.Black
        frmMain.btnMazeSizeRandomBack.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnMazeSizeRandomBack.FlatAppearance.BorderSize = 0
        frmMain.btnMazeSizeRandomBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmMain.btnMazeSizeRandomBack.Location = New System.Drawing.Point(82, 384)
        frmMain.btnMazeSizeRandomBack.Name = "btnMazeSizeRandomBack"
        frmMain.btnMazeSizeRandomBack.Size = New System.Drawing.Size(34, 34)
        frmMain.btnMazeSizeRandomBack.TabIndex = 10
        frmMain.btnMazeSizeRandomBack.TabStop = False
        frmMain.btnMazeSizeRandomBack.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        frmMain.btnInstructions.BackColor = System.Drawing.Color.White
        frmMain.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnInstructions.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.btnInstructions.Location = New System.Drawing.Point(520, 266)
        frmMain.btnInstructions.Name = "btnInstructions"
        frmMain.btnInstructions.Size = New System.Drawing.Size(300, 70)
        frmMain.btnInstructions.TabIndex = 12
        frmMain.btnInstructions.Text = "Instructions"
        frmMain.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnHighscores
        '
        frmMain.btnHighscores.BackColor = System.Drawing.Color.White
        frmMain.btnHighscores.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnHighscores.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.btnHighscores.Location = New System.Drawing.Point(859, 266)
        frmMain.btnHighscores.Name = "btnHighscores"
        frmMain.btnHighscores.Size = New System.Drawing.Size(300, 70)
        frmMain.btnHighscores.TabIndex = 13
        frmMain.btnHighscores.Text = "Highscores"
        frmMain.btnHighscores.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        frmMain.btnPlay.BackColor = System.Drawing.Color.White
        frmMain.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        frmMain.btnPlay.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.btnPlay.Location = New System.Drawing.Point(859, 396)
        frmMain.btnPlay.Name = "btnPlay"
        frmMain.btnPlay.Size = New System.Drawing.Size(300, 70)
        frmMain.btnPlay.TabIndex = 14
        frmMain.btnPlay.Text = "Play"
        frmMain.btnPlay.UseVisualStyleBackColor = False
        '
        'txtName
        '
        frmMain.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        frmMain.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        frmMain.txtName.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmMain.txtName.Location = New System.Drawing.Point(4, 21)
        frmMain.txtName.Name = "txtName"
        frmMain.txtName.PlaceholderText = "Enter Name"
        frmMain.txtName.Size = New System.Drawing.Size(292, 27)
        frmMain.txtName.TabIndex = 15
        frmMain.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlEnterName
        '
        frmMain.pnlEnterName.BackColor = System.Drawing.Color.White
        frmMain.pnlEnterName.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        frmMain.pnlEnterName.ColumnCount = 1
        frmMain.pnlEnterName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        frmMain.pnlEnterName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        frmMain.pnlEnterName.Controls.Add(frmMain.txtName, 0, 0)
        frmMain.pnlEnterName.Location = New System.Drawing.Point(520, 396)
        frmMain.pnlEnterName.Name = "pnlEnterName"
        frmMain.pnlEnterName.RowCount = 1
        frmMain.pnlEnterName.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        frmMain.pnlEnterName.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        frmMain.pnlEnterName.Size = New System.Drawing.Size(300, 70)
        frmMain.pnlEnterName.TabIndex = 16
        '
        'frmMain
        '
        frmMain.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        frmMain.ClientSize = New System.Drawing.Size(1352, 729)
    End Sub

End Module
