Module frmGameDesigner

    Public Sub configureFrmGame()

        frmGame.lblTitle.AutoSize = True
        frmGame.lblTitle.BackColor = System.Drawing.Color.Transparent
        frmGame.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmGame.lblTitle.Location = New System.Drawing.Point(445, 20)
        frmGame.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        frmGame.lblTitle.Name = "lblTitle"
        frmGame.lblTitle.Size = New System.Drawing.Size(477, 64)
        frmGame.lblTitle.TabIndex = 1
        frmGame.lblTitle.Text = "Maze Game"
        '
        'btnMazeSizeDisp
        '
        frmGame.btnMazeSizeDisp.BackColor = System.Drawing.Color.White
        frmGame.btnMazeSizeDisp.Enabled = False
        frmGame.btnMazeSizeDisp.FlatAppearance.BorderSize = 0
        frmGame.btnMazeSizeDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMazeSizeDisp.Location = New System.Drawing.Point(83, 235)
        frmGame.btnMazeSizeDisp.Name = "btnMazeSize10"
        frmGame.btnMazeSizeDisp.Size = New System.Drawing.Size(32, 32)
        frmGame.btnMazeSizeDisp.TabIndex = 10
        frmGame.btnMazeSizeDisp.UseVisualStyleBackColor = False
        '
        'btnMazeSizeDispBack
        '
        frmGame.btnMazeSizeDispBack.BackColor = System.Drawing.Color.Black
        frmGame.btnMazeSizeDispBack.Enabled = False
        frmGame.btnMazeSizeDispBack.FlatAppearance.BorderSize = 0
        frmGame.btnMazeSizeDispBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMazeSizeDispBack.Location = New System.Drawing.Point(82, 234)
        frmGame.btnMazeSizeDispBack.Name = "btnMazeSize10Back"
        frmGame.btnMazeSizeDispBack.Size = New System.Drawing.Size(34, 34)
        frmGame.btnMazeSizeDispBack.TabIndex = 11
        frmGame.btnMazeSizeDispBack.TabStop = False
        frmGame.btnMazeSizeDispBack.UseVisualStyleBackColor = False
        '
        'lblMazeSizeDisp
        '
        frmGame.lblMazeSizeDisp.AutoSize = True
        frmGame.lblMazeSizeDisp.BackColor = System.Drawing.Color.Transparent
        frmGame.lblMazeSizeDisp.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lblMazeSizeDisp.Location = New System.Drawing.Point(122, 234)
        frmGame.lblMazeSizeDisp.Name = "lblMazeSize10"
        frmGame.lblMazeSizeDisp.Size = New System.Drawing.Size(99, 32)
        frmGame.lblMazeSizeDisp.TabIndex = 9
        frmGame.lblMazeSizeDisp.Text = "10x10"
        '
        'lblMazeSize
        '
        frmGame.lblMazeSize.AutoSize = True
        frmGame.lblMazeSize.BackColor = System.Drawing.Color.Transparent
        frmGame.lblMazeSize.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lblMazeSize.Location = New System.Drawing.Point(55, 184)
        frmGame.lblMazeSize.Name = "lblMazeSize"
        frmGame.lblMazeSize.Size = New System.Drawing.Size(168, 32)
        frmGame.lblMazeSize.TabIndex = 8
        frmGame.lblMazeSize.Text = "Maze Size"
        '
        'lblPlayerName
        '
        frmGame.lblPlayerName.AutoSize = True
        frmGame.lblPlayerName.BackColor = System.Drawing.Color.Transparent
        frmGame.lblPlayerName.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lblPlayerName.Location = New System.Drawing.Point(55, 96)
        frmGame.lblPlayerName.Name = "lblPlayerName"
        frmGame.lblPlayerName.Size = New System.Drawing.Size(286, 32)
        frmGame.lblPlayerName.TabIndex = 12
        frmGame.lblPlayerName.Text = "_mac_equivalent_"
        '
        'pnlGame
        '
        frmGame.pnlGame.BackColor = System.Drawing.Color.White
        frmGame.pnlGame.Location = New System.Drawing.Point(384, 96)
        frmGame.pnlGame.Name = "pnlGame"
        frmGame.pnlGame.Size = New System.Drawing.Size(600, 600)
        frmGame.pnlGame.TabIndex = 13
        '
        'lbl_Time
        '
        frmGame.lbl_Time.AutoSize = True
        frmGame.lbl_Time.BackColor = System.Drawing.Color.Transparent
        frmGame.lbl_Time.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lbl_Time.Location = New System.Drawing.Point(1027, 96)
        frmGame.lbl_Time.Name = "lbl_Time"
        frmGame.lbl_Time.Size = New System.Drawing.Size(100, 32)
        frmGame.lbl_Time.TabIndex = 14
        frmGame.lbl_Time.Text = "Time:"
        '
        'lblTime
        '
        frmGame.lblTime.AutoSize = True
        frmGame.lblTime.BackColor = System.Drawing.Color.Transparent
        frmGame.lblTime.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lblTime.Location = New System.Drawing.Point(1133, 96)
        frmGame.lblTime.Name = "lblTime"
        frmGame.lblTime.Size = New System.Drawing.Size(100, 32)
        frmGame.lblTime.TabIndex = 15
        frmGame.lblTime.Text = "12:34"
        '
        'btnMoveUp
        '
        frmGame.btnMoveN.BackColor = System.Drawing.Color.White
        frmGame.btnMoveN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMoveN.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.btnMoveN.ForeColor = System.Drawing.Color.Black
        frmGame.btnMoveN.Location = New System.Drawing.Point(1133, 226)
        frmGame.btnMoveN.Name = "btnMoveN"
        frmGame.btnMoveN.Size = New System.Drawing.Size(40, 40)
        frmGame.btnMoveN.TabIndex = 16
        frmGame.btnMoveN.Text = "∧"
        frmGame.btnMoveN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.btnMoveN.UseVisualStyleBackColor = False
        '
        'btnMoveLeft
        '
        frmGame.btnMoveW.BackColor = System.Drawing.Color.White
        frmGame.btnMoveW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMoveW.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.btnMoveW.ForeColor = System.Drawing.Color.Black
        frmGame.btnMoveW.Location = New System.Drawing.Point(1087, 272)
        frmGame.btnMoveW.Name = "btnMoveW"
        frmGame.btnMoveW.Size = New System.Drawing.Size(40, 40)
        frmGame.btnMoveW.TabIndex = 18
        frmGame.btnMoveW.Text = "<"
        frmGame.btnMoveW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.btnMoveW.UseVisualStyleBackColor = False
        '
        'btnMoveDown
        '
        frmGame.btnMoveS.BackColor = System.Drawing.Color.White
        frmGame.btnMoveS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMoveS.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.btnMoveS.ForeColor = System.Drawing.Color.Black
        frmGame.btnMoveS.Location = New System.Drawing.Point(1133, 318)
        frmGame.btnMoveS.Name = "btnMoveS"
        frmGame.btnMoveS.Size = New System.Drawing.Size(40, 40)
        frmGame.btnMoveS.TabIndex = 19
        frmGame.btnMoveS.Text = "∨"
        frmGame.btnMoveS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.btnMoveS.UseVisualStyleBackColor = False
        '
        'btnMoveRight
        '
        frmGame.btnMoveE.BackColor = System.Drawing.Color.White
        frmGame.btnMoveE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMoveE.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.btnMoveE.ForeColor = System.Drawing.Color.Black
        frmGame.btnMoveE.Location = New System.Drawing.Point(1179, 272)
        frmGame.btnMoveE.Name = "btnMoveE"
        frmGame.btnMoveE.Size = New System.Drawing.Size(40, 40)
        frmGame.btnMoveE.TabIndex = 20
        frmGame.btnMoveE.Text = ">"
        frmGame.btnMoveE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.btnMoveE.UseVisualStyleBackColor = False
        '
        'tmrTick
        '
        frmGame.tmrTick.Enabled = True
        frmGame.tmrTick.Interval = 1000
        '
        'lblMazeSeed
        '
        frmGame.lblMazeSeed.AutoSize = True
        frmGame.lblMazeSeed.BackColor = System.Drawing.Color.Transparent
        frmGame.lblMazeSeed.Enabled = True
        frmGame.lblMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lblMazeSeed.Location = New System.Drawing.Point(55, 282)
        frmGame.lblMazeSeed.Name = "lblMazeSeed"
        frmGame.lblMazeSeed.Size = New System.Drawing.Size(168, 32)
        frmGame.lblMazeSeed.TabIndex = 5
        frmGame.lblMazeSeed.Text = "Maze Seed"
        '
        'txtMazeSeed
        '
        frmGame.txtMazeSeed.Enabled = False
        frmGame.txtMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.txtMazeSeed.Location = New System.Drawing.Point(55, 332)
        frmGame.txtMazeSeed.Name = "txtMazeSeed"
        frmGame.txtMazeSeed.PlaceholderText = "Enter Seed"
        frmGame.txtMazeSeed.Size = New System.Drawing.Size(166, 36)
        frmGame.txtMazeSeed.TabIndex = 6
        frmGame.txtMazeSeed.ReadOnly = True

        frmGame.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        frmGame.ClientSize = New System.Drawing.Size(1352, 729)

    End Sub

End Module
