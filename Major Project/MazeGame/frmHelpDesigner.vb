Module frmHelpDesigner

    Public Sub configureFrmHelp()
        '
        'lblTitle
        '
        frmHelp.lblTitle.AutoSize = True
        frmHelp.lblTitle.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblTitle.Location = New System.Drawing.Point(411, 20)
        frmHelp.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        frmHelp.lblTitle.Name = "lblTitle"
        frmHelp.lblTitle.Size = New System.Drawing.Size(547, 64)
        frmHelp.lblTitle.TabIndex = 1
        frmHelp.lblTitle.Text = "Help"
        '
        'lblInstructions1
        '
        frmHelp.lblHelp1.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp1.Location = New System.Drawing.Point(337, 119)
        frmHelp.lblHelp1.Name = "lblHelp1"
        frmHelp.lblHelp1.Size = New System.Drawing.Size(694, 104)
        frmHelp.lblHelp1.TabIndex = 2
        frmHelp.lblHelp1.Text = "If the arrow keys are not working, try restarting the application or checking you" &
    "r keyboard" &
    " well)"
        '
        'lblInstructions2
        '
        frmHelp.lblHelp2.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp2.Location = New System.Drawing.Point(337, 253)
        frmHelp.lblHelp2.Name = "lblHelp2"
        frmHelp.lblHelp2.Size = New System.Drawing.Size(694, 107)
        frmHelp.lblHelp2.TabIndex = 3
        frmHelp.lblHelp2.Text = "Then use arrow keys or the on—screen controls to navigate through the maze from t" &
    "he starting square to the ending square. Try to get through the maze as fast as " &
    "possible! "
        '
        'lblInstructions3
        '
        frmHelp.lblHelp3.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp3.Location = New System.Drawing.Point(337, 390)
        frmHelp.lblHelp3.Name = "lblHelp3"
        frmHelp.lblHelp3.Size = New System.Drawing.Size(694, 79)
        frmHelp.lblHelp3.TabIndex = 4
        frmHelp.lblHelp3.Text = "You can't move into a square blocked from your current square by a wall, and you " &
    "can't move beyond the boundaries of the maze."
        '
        'lblInstructions4
        '
        frmHelp.lblHelp4.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp4.Location = New System.Drawing.Point(337, 499)
        frmHelp.lblHelp4.Name = "lblHelp4"
        frmHelp.lblHelp4.Size = New System.Drawing.Size(694, 77)
        frmHelp.lblHelp4.TabIndex = 5
        frmHelp.lblHelp4.Text = "Once you're through the maze, you can copy your seed to play the same maze and tr" &
    "y for a faster time. "
        '
        'btnBack
        '
        frmHelp.btnBack.BackColor = System.Drawing.Color.White
        frmHelp.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        frmHelp.btnBack.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmHelp.btnBack.Location = New System.Drawing.Point(595, 604)
        frmHelp.btnBack.Name = "btnBack"
        frmHelp.btnBack.Size = New System.Drawing.Size(179, 72)
        frmHelp.btnBack.TabIndex = 6
        frmHelp.btnBack.Text = "Back"
        frmHelp.btnBack.UseVisualStyleBackColor = False
        '
        'frmHelp
        '
        frmHelp.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        frmHelp.ClientSize = New System.Drawing.Size(1352, 729)
    End Sub

End Module
