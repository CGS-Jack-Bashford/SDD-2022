Module frmHelpDesigner

    Public Sub configureFrmHelp()
        frmHelp.lblTitle.AutoSize = True
        frmHelp.lblTitle.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblTitle.Location = New System.Drawing.Point(550, 20)
        frmHelp.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        frmHelp.lblTitle.Name = "lblTitle"
        frmHelp.lblTitle.Size = New System.Drawing.Size(547, 64)
        frmHelp.lblTitle.TabIndex = 1
        frmHelp.lblTitle.Text = "Help"

        frmHelp.lblHelp1.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp1.Location = New System.Drawing.Point(337, 119)
        frmHelp.lblHelp1.Name = "lblHelp1"
        frmHelp.lblHelp1.Size = New System.Drawing.Size(694, 104)
        frmHelp.lblHelp1.TabIndex = 2
        frmHelp.lblHelp1.Text = "If the arrow keys are not working, try restarting the application and checking yo" &
    "ur keyboard connection."

        frmHelp.lblHelp2.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp2.Location = New System.Drawing.Point(337, 253)
        frmHelp.lblHelp2.Name = "lblHelp2"
        frmHelp.lblHelp2.Size = New System.Drawing.Size(694, 107)
        frmHelp.lblHelp2.TabIndex = 3
        frmHelp.lblHelp2.Text = "If the application appears to be scaling incorrectly, or parts of the screen are " &
    "cut off, make sure your display scaling is set to 100% in the Settings app."

        frmHelp.lblHelp3.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp3.Location = New System.Drawing.Point(337, 390)
        frmHelp.lblHelp3.Name = "lblHelp3"
        frmHelp.lblHelp3.Size = New System.Drawing.Size(694, 79)
        frmHelp.lblHelp3.TabIndex = 4
        frmHelp.lblHelp3.Text = "There is a one hour timeout on completing the maze, and the application will clos" &
    "e if you take longer than this."

        frmHelp.lblHelp4.BackColor = System.Drawing.Color.Transparent
        frmHelp.lblHelp4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        frmHelp.lblHelp4.Location = New System.Drawing.Point(337, 499)
        frmHelp.lblHelp4.Name = "lblHelp4"
        frmHelp.lblHelp4.Size = New System.Drawing.Size(694, 77)
        frmHelp.lblHelp4.TabIndex = 5
        frmHelp.lblHelp4.Text = "If the highscores are not persisting, make sure that the highscores.txt file exis" &
    "ts in the same folder as the .exe file."

        frmHelp.btnClose.BackColor = System.Drawing.Color.White
        frmHelp.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        frmHelp.btnClose.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmHelp.btnClose.Location = New System.Drawing.Point(595, 604)
        frmHelp.btnClose.Name = "btnClose"
        frmHelp.btnClose.Size = New System.Drawing.Size(179, 72)
        frmHelp.btnClose.TabIndex = 6
        frmHelp.btnClose.Text = "Back"
        frmHelp.btnClose.UseVisualStyleBackColor = False

        frmHelp.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        frmHelp.ClientSize = New System.Drawing.Size(1352, 729)
    End Sub

End Module
