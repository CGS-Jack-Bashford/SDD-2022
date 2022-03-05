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
        'btnMazeSize10
        '
        frmGame.btnMazeSize10.BackColor = System.Drawing.Color.White
        frmGame.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        frmGame.btnMazeSize10.Enabled = False
        frmGame.btnMazeSize10.FlatAppearance.BorderSize = 0
        frmGame.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMazeSize10.Location = New System.Drawing.Point(83, 235)
        frmGame.btnMazeSize10.Name = "btnMazeSize10"
        frmGame.btnMazeSize10.Size = New System.Drawing.Size(32, 32)
        frmGame.btnMazeSize10.TabIndex = 10
        frmGame.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize10Back
        '
        frmGame.btnMazeSize10Back.BackColor = System.Drawing.Color.Black
        frmGame.btnMazeSize10Back.Cursor = System.Windows.Forms.Cursors.Hand
        frmGame.btnMazeSize10Back.Enabled = False
        frmGame.btnMazeSize10Back.FlatAppearance.BorderSize = 0
        frmGame.btnMazeSize10Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.btnMazeSize10Back.Location = New System.Drawing.Point(82, 234)
        frmGame.btnMazeSize10Back.Name = "btnMazeSize10Back"
        frmGame.btnMazeSize10Back.Size = New System.Drawing.Size(34, 34)
        frmGame.btnMazeSize10Back.TabIndex = 11
        frmGame.btnMazeSize10Back.TabStop = False
        frmGame.btnMazeSize10Back.UseVisualStyleBackColor = False
        '
        'lblMazeSize10
        '
        frmGame.lblMazeSize10.AutoSize = True
        frmGame.lblMazeSize10.BackColor = System.Drawing.Color.Transparent
        frmGame.lblMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        frmGame.lblMazeSize10.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.lblMazeSize10.Location = New System.Drawing.Point(122, 234)
        frmGame.lblMazeSize10.Name = "lblMazeSize10"
        frmGame.lblMazeSize10.Size = New System.Drawing.Size(99, 32)
        frmGame.lblMazeSize10.TabIndex = 9
        frmGame.lblMazeSize10.Text = "10x10"
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
        'Label1
        '
        frmGame.Label1.AutoSize = True
        frmGame.Label1.BackColor = System.Drawing.Color.Transparent
        frmGame.Label1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Label1.Location = New System.Drawing.Point(55, 96)
        frmGame.Label1.Name = "Label1"
        frmGame.Label1.Size = New System.Drawing.Size(286, 32)
        frmGame.Label1.TabIndex = 12
        frmGame.Label1.Text = "_mac_equivalent_"
        '
        'Panel1
        '
        frmGame.Panel1.BackColor = System.Drawing.Color.White
        frmGame.Panel1.Location = New System.Drawing.Point(384, 96)
        frmGame.Panel1.Name = "Panel1"
        frmGame.Panel1.Size = New System.Drawing.Size(600, 600)
        frmGame.Panel1.TabIndex = 13
        '
        'Label2
        '
        frmGame.Label2.AutoSize = True
        frmGame.Label2.BackColor = System.Drawing.Color.Transparent
        frmGame.Label2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Label2.Location = New System.Drawing.Point(1027, 96)
        frmGame.Label2.Name = "Label2"
        frmGame.Label2.Size = New System.Drawing.Size(100, 32)
        frmGame.Label2.TabIndex = 14
        frmGame.Label2.Text = "Time:"
        '
        'Label3
        '
        frmGame.Label3.AutoSize = True
        frmGame.Label3.BackColor = System.Drawing.Color.Transparent
        frmGame.Label3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Label3.Location = New System.Drawing.Point(1133, 96)
        frmGame.Label3.Name = "Label3"
        frmGame.Label3.Size = New System.Drawing.Size(100, 32)
        frmGame.Label3.TabIndex = 15
        frmGame.Label3.Text = "12:34"
        '
        'Button1
        '
        frmGame.Button1.BackColor = System.Drawing.Color.White
        frmGame.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.Button1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Button1.ForeColor = System.Drawing.Color.Black
        frmGame.Button1.Location = New System.Drawing.Point(1133, 226)
        frmGame.Button1.Name = "Button1"
        frmGame.Button1.Size = New System.Drawing.Size(40, 40)
        frmGame.Button1.TabIndex = 16
        frmGame.Button1.Text = "∧"
        frmGame.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        frmGame.Button3.BackColor = System.Drawing.Color.White
        frmGame.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.Button3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Button3.ForeColor = System.Drawing.Color.Black
        frmGame.Button3.Location = New System.Drawing.Point(1087, 272)
        frmGame.Button3.Name = "Button3"
        frmGame.Button3.Size = New System.Drawing.Size(40, 40)
        frmGame.Button3.TabIndex = 18
        frmGame.Button3.Text = "<"
        frmGame.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        frmGame.Button4.BackColor = System.Drawing.Color.White
        frmGame.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.Button4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Button4.ForeColor = System.Drawing.Color.Black
        frmGame.Button4.Location = New System.Drawing.Point(1133, 318)
        frmGame.Button4.Name = "Button4"
        frmGame.Button4.Size = New System.Drawing.Size(40, 40)
        frmGame.Button4.TabIndex = 19
        frmGame.Button4.Text = "∨"
        frmGame.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        frmGame.Button5.BackColor = System.Drawing.Color.White
        frmGame.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        frmGame.Button5.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        frmGame.Button5.ForeColor = System.Drawing.Color.Black
        frmGame.Button5.Location = New System.Drawing.Point(1179, 272)
        frmGame.Button5.Name = "Button5"
        frmGame.Button5.Size = New System.Drawing.Size(40, 40)
        frmGame.Button5.TabIndex = 20
        frmGame.Button5.Text = ">"
        frmGame.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        frmGame.Button5.UseVisualStyleBackColor = False

    End Sub

End Module
