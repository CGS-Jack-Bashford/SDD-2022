Module frmGameOverDesigner

    Public Sub configureFrmGameOver()

        '
        'lblTitle
        '
        frmGameOver.lblTitle.AutoSize = True
        frmGameOver.lblTitle.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lblTitle.Location = New System.Drawing.Point(458, 20)
        frmGameOver.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        frmGameOver.lblTitle.Name = "lblTitle"
        frmGameOver.lblTitle.Size = New System.Drawing.Size(452, 64)
        frmGameOver.lblTitle.TabIndex = 1
        frmGameOver.lblTitle.Text = "Game Over"
        '
        'Label1
        '
        frmGameOver.lbl_name.AutoSize = True
        frmGameOver.lbl_name.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lbl_name.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lbl_name.Location = New System.Drawing.Point(488, 224)
        frmGameOver.lbl_name.Name = "Label1"
        frmGameOver.lbl_name.Size = New System.Drawing.Size(99, 32)
        frmGameOver.lbl_name.TabIndex = 2
        frmGameOver.lbl_name.Text = "Name:"
        '
        'Label2
        '
        frmGameOver.lbl_size.AutoSize = True
        frmGameOver.lbl_size.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lbl_size.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lbl_size.Location = New System.Drawing.Point(488, 284)
        frmGameOver.lbl_size.Name = "Label2"
        frmGameOver.lbl_size.Size = New System.Drawing.Size(100, 32)
        frmGameOver.lbl_size.TabIndex = 3
        frmGameOver.lbl_size.Text = "Size:"
        '
        'Label3
        '
        frmGameOver.lbl_seed.AutoSize = True
        frmGameOver.lbl_seed.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lbl_seed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lbl_seed.Location = New System.Drawing.Point(487, 344)
        frmGameOver.lbl_seed.Name = "Label3"
        frmGameOver.lbl_seed.Size = New System.Drawing.Size(100, 32)
        frmGameOver.lbl_seed.TabIndex = 4
        frmGameOver.lbl_seed.Text = "Seed:"
        '
        'Label4
        '
        frmGameOver.lbl_time.AutoSize = True
        frmGameOver.lbl_time.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lbl_time.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lbl_time.Location = New System.Drawing.Point(488, 404)
        frmGameOver.lbl_time.Name = "Label4"
        frmGameOver.lbl_time.Size = New System.Drawing.Size(100, 32)
        frmGameOver.lbl_time.TabIndex = 5
        frmGameOver.lbl_time.Text = "Time:"
        '
        'Label5
        '
        frmGameOver.lblPlayerName.AutoSize = True
        frmGameOver.lblPlayerName.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lblPlayerName.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lblPlayerName.Location = New System.Drawing.Point(593, 224)
        frmGameOver.lblPlayerName.Name = "Label5"
        frmGameOver.lblPlayerName.Size = New System.Drawing.Size(286, 32)
        frmGameOver.lblPlayerName.TabIndex = 6
        frmGameOver.lblPlayerName.Text = "_mac_equivalent_"
        '
        'Label6
        '
        frmGameOver.lblMazeSize.AutoSize = True
        frmGameOver.lblMazeSize.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lblMazeSize.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lblMazeSize.Location = New System.Drawing.Point(644, 285)
        frmGameOver.lblMazeSize.Name = "Label6"
        frmGameOver.lblMazeSize.Size = New System.Drawing.Size(235, 32)
        frmGameOver.lblMazeSize.TabIndex = 7
        frmGameOver.lblMazeSize.Text = "_mac_equivale"
        '
        'Label7
        '
        frmGameOver.lblMazeSeed.AutoSize = True
        frmGameOver.lblMazeSeed.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lblMazeSeed.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lblMazeSeed.Location = New System.Drawing.Point(593, 344)
        frmGameOver.lblMazeSeed.Name = "Label7"
        frmGameOver.lblMazeSeed.Size = New System.Drawing.Size(286, 32)
        frmGameOver.lblMazeSeed.TabIndex = 8
        frmGameOver.lblMazeSeed.Text = "_mac_equivalent_"
        '
        'Label8
        '
        frmGameOver.lblGameTime.AutoSize = True
        frmGameOver.lblGameTime.BackColor = System.Drawing.Color.Transparent
        frmGameOver.lblGameTime.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.lblGameTime.Location = New System.Drawing.Point(593, 404)
        frmGameOver.lblGameTime.Name = "Label8"
        frmGameOver.lblGameTime.Size = New System.Drawing.Size(286, 32)
        frmGameOver.lblGameTime.TabIndex = 9
        frmGameOver.lblGameTime.Text = "_mac_equivalent_"
        '
        'btnMazeSize10
        '
        frmGameOver.btnMazeSize10.BackColor = System.Drawing.Color.White
        frmGameOver.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        frmGameOver.btnMazeSize10.Enabled = False
        frmGameOver.btnMazeSize10.FlatAppearance.BorderSize = 0
        frmGameOver.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGameOver.btnMazeSize10.Location = New System.Drawing.Point(595, 285)
        frmGameOver.btnMazeSize10.Name = "btnMazeSize10"
        frmGameOver.btnMazeSize10.Size = New System.Drawing.Size(32, 32)
        frmGameOver.btnMazeSize10.TabIndex = 10
        frmGameOver.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize10Back
        '
        frmGameOver.btnMazeSize10Back.BackColor = System.Drawing.Color.Black
        frmGameOver.btnMazeSize10Back.Cursor = System.Windows.Forms.Cursors.Hand
        frmGameOver.btnMazeSize10Back.Enabled = False
        frmGameOver.btnMazeSize10Back.FlatAppearance.BorderSize = 0
        frmGameOver.btnMazeSize10Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGameOver.btnMazeSize10Back.Location = New System.Drawing.Point(594, 284)
        frmGameOver.btnMazeSize10Back.Name = "btnMazeSize10Back"
        frmGameOver.btnMazeSize10Back.Size = New System.Drawing.Size(34, 34)
        frmGameOver.btnMazeSize10Back.TabIndex = 11
        frmGameOver.btnMazeSize10Back.TabStop = False
        frmGameOver.btnMazeSize10Back.UseVisualStyleBackColor = False
        '
        'btnToHighscores
        '
        frmGameOver.btnToHighscores.BackColor = System.Drawing.Color.White
        frmGameOver.btnToHighscores.Cursor = System.Windows.Forms.Cursors.Hand
        frmGameOver.btnToHighscores.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.btnToHighscores.Location = New System.Drawing.Point(734, 529)
        frmGameOver.btnToHighscores.Name = "Button1"
        frmGameOver.btnToHighscores.Size = New System.Drawing.Size(300, 70)
        frmGameOver.btnToHighscores.TabIndex = 14
        frmGameOver.btnToHighscores.Text = "Highscores"
        frmGameOver.btnToHighscores.UseVisualStyleBackColor = False
        '
        'btnToStart
        '
        frmGameOver.btnToStart.BackColor = System.Drawing.Color.White
        frmGameOver.btnToStart.Cursor = System.Windows.Forms.Cursors.Hand
        frmGameOver.btnToStart.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGameOver.btnToStart.Location = New System.Drawing.Point(334, 529)
        frmGameOver.btnToStart.Name = "btnInstructions"
        frmGameOver.btnToStart.Size = New System.Drawing.Size(300, 70)
        frmGameOver.btnToStart.TabIndex = 13
        frmGameOver.btnToStart.Text = "Back to Start"
        frmGameOver.btnToStart.UseVisualStyleBackColor = False
        '
        'frmGameOver
        '
        frmGameOver.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        frmGameOver.ClientSize = New System.Drawing.Size(1352, 729)
    End Sub

End Module
