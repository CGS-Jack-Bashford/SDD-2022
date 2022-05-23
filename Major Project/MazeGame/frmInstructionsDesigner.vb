Module frmInstructionsDesigner

    Public Sub configureFrmInstructions()
        '
        'lblTitle
        '
        frmInstructions.lblTitle.AutoSize = True
        frmInstructions.lblTitle.BackColor = System.Drawing.Color.Transparent
        frmInstructions.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmInstructions.lblTitle.Location = New System.Drawing.Point(411, 20)
        frmInstructions.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        frmInstructions.lblTitle.Name = "lblTitle"
        frmInstructions.lblTitle.Size = New System.Drawing.Size(547, 64)
        frmInstructions.lblTitle.TabIndex = 1
        frmInstructions.lblTitle.Text = "Instructions"
        '
        'lblInstructions1
        '
        frmInstructions.lblInstructions1.BackColor = System.Drawing.Color.Transparent
        frmInstructions.lblInstructions1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmInstructions.lblInstructions1.Location = New System.Drawing.Point(337, 119)
        frmInstructions.lblInstructions1.Name = "lblInstructions1"
        frmInstructions.lblInstructions1.Size = New System.Drawing.Size(694, 130)
        frmInstructions.lblInstructions1.TabIndex = 2
        frmInstructions.lblInstructions1.Text = "Choose a name (alphanumeric and underscores, 1-16 characters) and a difficulty (s" &
    "tandard sizes of 10x10, 20x20, or 30x30, and a random choice of those options as" &
    " well)."
        '
        'lblInstructions2
        '
        frmInstructions.lblInstructions2.BackColor = System.Drawing.Color.Transparent
        frmInstructions.lblInstructions2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmInstructions.lblInstructions2.Location = New System.Drawing.Point(337, 235)
        frmInstructions.lblInstructions2.Name = "lblInstructions2"
        frmInstructions.lblInstructions2.Size = New System.Drawing.Size(694, 157)
        frmInstructions.lblInstructions2.TabIndex = 3
        frmInstructions.lblInstructions2.Text = "Then use arrow keys or the on—screen controls to navigate through the maze from t" &
    "he starting square to the ending square. You can't move into a cell blocked from" &
    " your current cell by a wall, and you can't move outside of the maze. Try to get" &
    " through the maze as fast as possible!"
        '
        'lblInstructions3
        '
        frmInstructions.lblInstructions3.BackColor = System.Drawing.Color.Transparent
        frmInstructions.lblInstructions3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmInstructions.lblInstructions3.Location = New System.Drawing.Point(337, 390)
        frmInstructions.lblInstructions3.Name = "lblInstructions3"
        frmInstructions.lblInstructions3.Size = New System.Drawing.Size(694, 158)
        frmInstructions.lblInstructions3.TabIndex = 4
        frmInstructions.lblInstructions3.Text = "The maze seed allows you to choose to play the same maze again - you can enter a " &
    "seed yourself (up to 10 hex digits), or you can allow the game to generate one f" &
    "or you. Entering the same seed and maze size twice will generate the same maze."
        '
        'lblInstructions4
        '
        frmInstructions.lblInstructions4.BackColor = System.Drawing.Color.Transparent
        frmInstructions.lblInstructions4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmInstructions.lblInstructions4.Location = New System.Drawing.Point(337, 520)
        frmInstructions.lblInstructions4.Name = "lblInstructions4"
        frmInstructions.lblInstructions4.Size = New System.Drawing.Size(694, 77)
        frmInstructions.lblInstructions4.TabIndex = 5
        frmInstructions.lblInstructions4.Text = "Once you're through the maze, you can re-enter your seed to play the same maze an" &
    "d try for a faster time. "
        '
        'btnBack
        '
        frmInstructions.btnBack.BackColor = System.Drawing.Color.White
        frmInstructions.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        frmInstructions.btnBack.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmInstructions.btnBack.Location = New System.Drawing.Point(595, 604)
        frmInstructions.btnBack.Name = "btnBack"
        frmInstructions.btnBack.Size = New System.Drawing.Size(179, 72)
        frmInstructions.btnBack.TabIndex = 6
        frmInstructions.btnBack.Text = "Back"
        frmInstructions.btnBack.UseVisualStyleBackColor = False
        '
        'frmInstructions
        '
        frmInstructions.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        frmInstructions.ClientSize = New System.Drawing.Size(1352, 729)
    End Sub

End Module
