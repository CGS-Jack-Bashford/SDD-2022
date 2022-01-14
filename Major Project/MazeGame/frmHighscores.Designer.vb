<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighscores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighscores))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMazeSize10 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize20 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize30 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize10Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize20Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize30Back = New MazeGame.ButtonEllipse()
        Me.lblMazeSize10 = New System.Windows.Forms.Label()
        Me.lblMazeSize20 = New System.Windows.Forms.Label()
        Me.lblMazeSize30 = New System.Windows.Forms.Label()
        Me.lblMazeSize = New System.Windows.Forms.Label()
        Me.lblTimeTitle = New System.Windows.Forms.Label()
        Me.lblTimeRanking1 = New System.Windows.Forms.Label()
        Me.lblTimeRanking2 = New System.Windows.Forms.Label()
        Me.lblTimeRanking3 = New System.Windows.Forms.Label()
        Me.lblTimeRanking4 = New System.Windows.Forms.Label()
        Me.lblTimeRanking5 = New System.Windows.Forms.Label()
        Me.btn_ranking1White = New MazeGame.ButtonEllipse()
        Me.btn_ranking1Black = New MazeGame.ButtonEllipse()
        Me.btn_ranking2Black = New MazeGame.ButtonEllipse()
        Me.btn_ranking2White = New MazeGame.ButtonEllipse()
        Me.btn_ranking3Black = New MazeGame.ButtonEllipse()
        Me.btn_ranking3White = New MazeGame.ButtonEllipse()
        Me.btn_ranking4Black = New MazeGame.ButtonEllipse()
        Me.btn_ranking4White = New MazeGame.ButtonEllipse()
        Me.btn_ranking5Black = New MazeGame.ButtonEllipse()
        Me.btn_ranking5White = New MazeGame.ButtonEllipse()
        Me.lblNameRanking1 = New System.Windows.Forms.Label()
        Me.lblNameRanking2 = New System.Windows.Forms.Label()
        Me.lblNameRanking3 = New System.Windows.Forms.Label()
        Me.lblNameRanking4 = New System.Windows.Forms.Label()
        Me.lblNameRanking5 = New System.Windows.Forms.Label()
        Me.lblNameTitle = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lbl_ranking2 = New System.Windows.Forms.Label()
        Me.lbl_ranking3 = New System.Windows.Forms.Label()
        Me.lbl_ranking4 = New System.Windows.Forms.Label()
        Me.lbl_ranking5 = New System.Windows.Forms.Label()
        Me.lbl_ranking1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(447, 20)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(473, 64)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Highscores"
        '
        'btnMazeSize10
        '
        Me.btnMazeSize10.BackColor = System.Drawing.Color.White
        Me.btnMazeSize10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize10.Enabled = False
        Me.btnMazeSize10.FlatAppearance.BorderSize = 0
        Me.btnMazeSize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize10.Location = New System.Drawing.Point(83, 235)
        Me.btnMazeSize10.Name = "btnMazeSize10"
        Me.btnMazeSize10.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize10.TabIndex = 16
        Me.btnMazeSize10.UseVisualStyleBackColor = False
        '
        'btnMazeSize20
        '
        Me.btnMazeSize20.BackColor = System.Drawing.Color.White
        Me.btnMazeSize20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize20.Enabled = False
        Me.btnMazeSize20.FlatAppearance.BorderSize = 0
        Me.btnMazeSize20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize20.Location = New System.Drawing.Point(83, 285)
        Me.btnMazeSize20.Name = "btnMazeSize20"
        Me.btnMazeSize20.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize20.TabIndex = 18
        Me.btnMazeSize20.UseVisualStyleBackColor = False
        '
        'btnMazeSize30
        '
        Me.btnMazeSize30.BackColor = System.Drawing.Color.White
        Me.btnMazeSize30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMazeSize30.Enabled = False
        Me.btnMazeSize30.FlatAppearance.BorderSize = 0
        Me.btnMazeSize30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMazeSize30.Location = New System.Drawing.Point(83, 335)
        Me.btnMazeSize30.Name = "btnMazeSize30"
        Me.btnMazeSize30.Size = New System.Drawing.Size(32, 32)
        Me.btnMazeSize30.TabIndex = 21
        Me.btnMazeSize30.UseVisualStyleBackColor = False
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
        Me.btnMazeSize10Back.TabIndex = 17
        Me.btnMazeSize10Back.TabStop = False
        Me.btnMazeSize10Back.UseVisualStyleBackColor = False
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
        Me.btnMazeSize20Back.TabIndex = 19
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
        Me.btnMazeSize30Back.TabIndex = 20
        Me.btnMazeSize30Back.TabStop = False
        Me.btnMazeSize30Back.UseVisualStyleBackColor = False
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
        Me.lblMazeSize10.TabIndex = 13
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
        Me.lblMazeSize20.TabIndex = 14
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
        Me.lblMazeSize30.TabIndex = 15
        Me.lblMazeSize30.Text = "30x30"
        '
        'lblMazeSize
        '
        Me.lblMazeSize.AutoSize = True
        Me.lblMazeSize.BackColor = System.Drawing.Color.Transparent
        Me.lblMazeSize.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMazeSize.Location = New System.Drawing.Point(55, 184)
        Me.lblMazeSize.Name = "lblMazeSize"
        Me.lblMazeSize.Size = New System.Drawing.Size(168, 32)
        Me.lblMazeSize.TabIndex = 12
        Me.lblMazeSize.Text = "Maze Size"
        '
        'lblTimeTitle
        '
        Me.lblTimeTitle.AutoSize = True
        Me.lblTimeTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeTitle.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeTitle.Location = New System.Drawing.Point(545, 188)
        Me.lblTimeTitle.Name = "lblTimeTitle"
        Me.lblTimeTitle.Size = New System.Drawing.Size(83, 32)
        Me.lblTimeTitle.TabIndex = 22
        Me.lblTimeTitle.Text = "Time"
        '
        'lblTimeRanking1
        '
        Me.lblTimeRanking1.AutoSize = True
        Me.lblTimeRanking1.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeRanking1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeRanking1.Location = New System.Drawing.Point(528, 228)
        Me.lblTimeRanking1.Name = "lblTimeRanking1"
        Me.lblTimeRanking1.Size = New System.Drawing.Size(100, 32)
        Me.lblTimeRanking1.TabIndex = 23
        Me.lblTimeRanking1.Text = "12:34"
        '
        'lblTimeRanking2
        '
        Me.lblTimeRanking2.AutoSize = True
        Me.lblTimeRanking2.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeRanking2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeRanking2.Location = New System.Drawing.Point(528, 280)
        Me.lblTimeRanking2.Name = "lblTimeRanking2"
        Me.lblTimeRanking2.Size = New System.Drawing.Size(100, 32)
        Me.lblTimeRanking2.TabIndex = 23
        Me.lblTimeRanking2.Text = "12:34"
        '
        'lblTimeRanking3
        '
        Me.lblTimeRanking3.AutoSize = True
        Me.lblTimeRanking3.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeRanking3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeRanking3.Location = New System.Drawing.Point(528, 332)
        Me.lblTimeRanking3.Name = "lblTimeRanking3"
        Me.lblTimeRanking3.Size = New System.Drawing.Size(100, 32)
        Me.lblTimeRanking3.TabIndex = 23
        Me.lblTimeRanking3.Text = "12:34"
        '
        'lblTimeRanking4
        '
        Me.lblTimeRanking4.AutoSize = True
        Me.lblTimeRanking4.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeRanking4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeRanking4.Location = New System.Drawing.Point(528, 384)
        Me.lblTimeRanking4.Name = "lblTimeRanking4"
        Me.lblTimeRanking4.Size = New System.Drawing.Size(100, 32)
        Me.lblTimeRanking4.TabIndex = 23
        Me.lblTimeRanking4.Text = "12:34"
        '
        'lblTimeRanking5
        '
        Me.lblTimeRanking5.AutoSize = True
        Me.lblTimeRanking5.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeRanking5.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeRanking5.Location = New System.Drawing.Point(528, 436)
        Me.lblTimeRanking5.Name = "lblTimeRanking5"
        Me.lblTimeRanking5.Size = New System.Drawing.Size(100, 32)
        Me.lblTimeRanking5.TabIndex = 23
        Me.lblTimeRanking5.Text = "12:34"
        '
        'btn_ranking1White
        '
        Me.btn_ranking1White.BackColor = System.Drawing.Color.White
        Me.btn_ranking1White.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking1White.Enabled = False
        Me.btn_ranking1White.FlatAppearance.BorderSize = 0
        Me.btn_ranking1White.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking1White.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ranking1White.Location = New System.Drawing.Point(490, 228)
        Me.btn_ranking1White.Name = "btn_ranking1White"
        Me.btn_ranking1White.Size = New System.Drawing.Size(32, 32)
        Me.btn_ranking1White.TabIndex = 24
        Me.btn_ranking1White.UseVisualStyleBackColor = False
        '
        'btn_ranking1Black
        '
        Me.btn_ranking1Black.BackColor = System.Drawing.Color.Black
        Me.btn_ranking1Black.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking1Black.Enabled = False
        Me.btn_ranking1Black.FlatAppearance.BorderSize = 0
        Me.btn_ranking1Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking1Black.Location = New System.Drawing.Point(489, 227)
        Me.btn_ranking1Black.Name = "btn_ranking1Black"
        Me.btn_ranking1Black.Size = New System.Drawing.Size(34, 34)
        Me.btn_ranking1Black.TabIndex = 25
        Me.btn_ranking1Black.TabStop = False
        Me.btn_ranking1Black.UseVisualStyleBackColor = False
        '
        'btn_ranking2Black
        '
        Me.btn_ranking2Black.BackColor = System.Drawing.Color.Black
        Me.btn_ranking2Black.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking2Black.Enabled = False
        Me.btn_ranking2Black.FlatAppearance.BorderSize = 0
        Me.btn_ranking2Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking2Black.Location = New System.Drawing.Point(490, 279)
        Me.btn_ranking2Black.Name = "btn_ranking2Black"
        Me.btn_ranking2Black.Size = New System.Drawing.Size(34, 34)
        Me.btn_ranking2Black.TabIndex = 25
        Me.btn_ranking2Black.TabStop = False
        Me.btn_ranking2Black.UseVisualStyleBackColor = False
        '
        'btn_ranking2White
        '
        Me.btn_ranking2White.BackColor = System.Drawing.Color.White
        Me.btn_ranking2White.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking2White.Enabled = False
        Me.btn_ranking2White.FlatAppearance.BorderSize = 0
        Me.btn_ranking2White.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking2White.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ranking2White.Location = New System.Drawing.Point(491, 280)
        Me.btn_ranking2White.Name = "btn_ranking2White"
        Me.btn_ranking2White.Size = New System.Drawing.Size(32, 32)
        Me.btn_ranking2White.TabIndex = 24
        Me.btn_ranking2White.UseVisualStyleBackColor = False
        '
        'btn_ranking3Black
        '
        Me.btn_ranking3Black.BackColor = System.Drawing.Color.Black
        Me.btn_ranking3Black.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking3Black.Enabled = False
        Me.btn_ranking3Black.FlatAppearance.BorderSize = 0
        Me.btn_ranking3Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking3Black.Location = New System.Drawing.Point(490, 331)
        Me.btn_ranking3Black.Name = "btn_ranking3Black"
        Me.btn_ranking3Black.Size = New System.Drawing.Size(34, 34)
        Me.btn_ranking3Black.TabIndex = 25
        Me.btn_ranking3Black.TabStop = False
        Me.btn_ranking3Black.UseVisualStyleBackColor = False
        '
        'btn_ranking3White
        '
        Me.btn_ranking3White.BackColor = System.Drawing.Color.White
        Me.btn_ranking3White.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking3White.Enabled = False
        Me.btn_ranking3White.FlatAppearance.BorderSize = 0
        Me.btn_ranking3White.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking3White.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ranking3White.Location = New System.Drawing.Point(491, 332)
        Me.btn_ranking3White.Name = "btn_ranking3White"
        Me.btn_ranking3White.Size = New System.Drawing.Size(32, 32)
        Me.btn_ranking3White.TabIndex = 24
        Me.btn_ranking3White.UseVisualStyleBackColor = False
        '
        'btn_ranking4Black
        '
        Me.btn_ranking4Black.BackColor = System.Drawing.Color.Black
        Me.btn_ranking4Black.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking4Black.Enabled = False
        Me.btn_ranking4Black.FlatAppearance.BorderSize = 0
        Me.btn_ranking4Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking4Black.Location = New System.Drawing.Point(491, 383)
        Me.btn_ranking4Black.Name = "btn_ranking4Black"
        Me.btn_ranking4Black.Size = New System.Drawing.Size(34, 34)
        Me.btn_ranking4Black.TabIndex = 25
        Me.btn_ranking4Black.TabStop = False
        Me.btn_ranking4Black.UseVisualStyleBackColor = False
        '
        'btn_ranking4White
        '
        Me.btn_ranking4White.BackColor = System.Drawing.Color.White
        Me.btn_ranking4White.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking4White.Enabled = False
        Me.btn_ranking4White.FlatAppearance.BorderSize = 0
        Me.btn_ranking4White.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking4White.Location = New System.Drawing.Point(492, 384)
        Me.btn_ranking4White.Name = "btn_ranking4White"
        Me.btn_ranking4White.Size = New System.Drawing.Size(32, 32)
        Me.btn_ranking4White.TabIndex = 24
        Me.btn_ranking4White.UseVisualStyleBackColor = False
        '
        'btn_ranking5Black
        '
        Me.btn_ranking5Black.BackColor = System.Drawing.Color.Black
        Me.btn_ranking5Black.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking5Black.Enabled = False
        Me.btn_ranking5Black.FlatAppearance.BorderSize = 0
        Me.btn_ranking5Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking5Black.Location = New System.Drawing.Point(492, 435)
        Me.btn_ranking5Black.Name = "btn_ranking5Black"
        Me.btn_ranking5Black.Size = New System.Drawing.Size(34, 34)
        Me.btn_ranking5Black.TabIndex = 25
        Me.btn_ranking5Black.TabStop = False
        Me.btn_ranking5Black.UseVisualStyleBackColor = False
        '
        'btn_ranking5White
        '
        Me.btn_ranking5White.BackColor = System.Drawing.Color.White
        Me.btn_ranking5White.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ranking5White.Enabled = False
        Me.btn_ranking5White.FlatAppearance.BorderSize = 0
        Me.btn_ranking5White.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ranking5White.Location = New System.Drawing.Point(493, 436)
        Me.btn_ranking5White.Name = "btn_ranking5White"
        Me.btn_ranking5White.Size = New System.Drawing.Size(32, 32)
        Me.btn_ranking5White.TabIndex = 24
        Me.btn_ranking5White.UseVisualStyleBackColor = False
        '
        'lblNameRanking1
        '
        Me.lblNameRanking1.AutoSize = True
        Me.lblNameRanking1.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanking1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameRanking1.Location = New System.Drawing.Point(634, 229)
        Me.lblNameRanking1.Name = "lblNameRanking1"
        Me.lblNameRanking1.Size = New System.Drawing.Size(286, 32)
        Me.lblNameRanking1.TabIndex = 23
        Me.lblNameRanking1.Text = "_mac_equivalent_"
        '
        'lblNameRanking2
        '
        Me.lblNameRanking2.AutoSize = True
        Me.lblNameRanking2.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanking2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameRanking2.Location = New System.Drawing.Point(634, 281)
        Me.lblNameRanking2.Name = "lblNameRanking2"
        Me.lblNameRanking2.Size = New System.Drawing.Size(286, 32)
        Me.lblNameRanking2.TabIndex = 23
        Me.lblNameRanking2.Text = "_mac_equivalent_"
        '
        'lblNameRanking3
        '
        Me.lblNameRanking3.AutoSize = True
        Me.lblNameRanking3.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanking3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameRanking3.Location = New System.Drawing.Point(634, 333)
        Me.lblNameRanking3.Name = "lblNameRanking3"
        Me.lblNameRanking3.Size = New System.Drawing.Size(286, 32)
        Me.lblNameRanking3.TabIndex = 23
        Me.lblNameRanking3.Text = "_mac_equivalent_"
        '
        'lblNameRanking4
        '
        Me.lblNameRanking4.AutoSize = True
        Me.lblNameRanking4.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanking4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameRanking4.Location = New System.Drawing.Point(634, 385)
        Me.lblNameRanking4.Name = "lblNameRanking4"
        Me.lblNameRanking4.Size = New System.Drawing.Size(286, 32)
        Me.lblNameRanking4.TabIndex = 23
        Me.lblNameRanking4.Text = "_mac_equivalent_"
        '
        'lblNameRanking5
        '
        Me.lblNameRanking5.AutoSize = True
        Me.lblNameRanking5.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanking5.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameRanking5.Location = New System.Drawing.Point(634, 437)
        Me.lblNameRanking5.Name = "lblNameRanking5"
        Me.lblNameRanking5.Size = New System.Drawing.Size(286, 32)
        Me.lblNameRanking5.TabIndex = 23
        Me.lblNameRanking5.Text = "_mac_equivalent_"
        '
        'lblNameTitle
        '
        Me.lblNameTitle.AutoSize = True
        Me.lblNameTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblNameTitle.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameTitle.Location = New System.Drawing.Point(634, 188)
        Me.lblNameTitle.Name = "lblNameTitle"
        Me.lblNameTitle.Size = New System.Drawing.Size(82, 32)
        Me.lblNameTitle.TabIndex = 22
        Me.lblNameTitle.Text = "Name"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.Location = New System.Drawing.Point(526, 551)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(300, 70)
        Me.btnPlay.TabIndex = 26
        Me.btnPlay.Text = "Back"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'lbl_ranking2
        '
        Me.lbl_ranking2.AutoSize = True
        Me.lbl_ranking2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ranking2.Font = New System.Drawing.Font("Maze", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ranking2.Location = New System.Drawing.Point(496, 286)
        Me.lbl_ranking2.Name = "lbl_ranking2"
        Me.lbl_ranking2.Size = New System.Drawing.Size(24, 21)
        Me.lbl_ranking2.TabIndex = 28
        Me.lbl_ranking2.Text = "2"
        '
        'lbl_ranking3
        '
        Me.lbl_ranking3.AutoSize = True
        Me.lbl_ranking3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ranking3.Font = New System.Drawing.Font("Maze", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ranking3.Location = New System.Drawing.Point(496, 338)
        Me.lbl_ranking3.Name = "lbl_ranking3"
        Me.lbl_ranking3.Size = New System.Drawing.Size(24, 21)
        Me.lbl_ranking3.TabIndex = 29
        Me.lbl_ranking3.Text = "3"
        '
        'lbl_ranking4
        '
        Me.lbl_ranking4.AutoSize = True
        Me.lbl_ranking4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ranking4.Font = New System.Drawing.Font("Maze", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ranking4.Location = New System.Drawing.Point(497, 390)
        Me.lbl_ranking4.Name = "lbl_ranking4"
        Me.lbl_ranking4.Size = New System.Drawing.Size(24, 21)
        Me.lbl_ranking4.TabIndex = 30
        Me.lbl_ranking4.Text = "4"
        '
        'lbl_ranking5
        '
        Me.lbl_ranking5.AutoSize = True
        Me.lbl_ranking5.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ranking5.Font = New System.Drawing.Font("Maze", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ranking5.Location = New System.Drawing.Point(497, 442)
        Me.lbl_ranking5.Name = "lbl_ranking5"
        Me.lbl_ranking5.Size = New System.Drawing.Size(24, 21)
        Me.lbl_ranking5.TabIndex = 31
        Me.lbl_ranking5.Text = "5"
        '
        'lbl_ranking1
        '
        Me.lbl_ranking1.AutoSize = True
        Me.lbl_ranking1.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_ranking1.Font = New System.Drawing.Font("Maze", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ranking1.Location = New System.Drawing.Point(497, 234)
        Me.lbl_ranking1.Name = "lbl_ranking1"
        Me.lbl_ranking1.Size = New System.Drawing.Size(18, 21)
        Me.lbl_ranking1.TabIndex = 32
        Me.lbl_ranking1.Text = "1"
        '
        'frmHighscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.lbl_ranking1)
        Me.Controls.Add(Me.lbl_ranking2)
        Me.Controls.Add(Me.lbl_ranking3)
        Me.Controls.Add(Me.lbl_ranking4)
        Me.Controls.Add(Me.lbl_ranking5)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btn_ranking1White)
        Me.Controls.Add(Me.btn_ranking2White)
        Me.Controls.Add(Me.btn_ranking3White)
        Me.Controls.Add(Me.btn_ranking4White)
        Me.Controls.Add(Me.btn_ranking5White)
        Me.Controls.Add(Me.btn_ranking1Black)
        Me.Controls.Add(Me.btn_ranking2Black)
        Me.Controls.Add(Me.btn_ranking3Black)
        Me.Controls.Add(Me.btn_ranking4Black)
        Me.Controls.Add(Me.btn_ranking5Black)
        Me.Controls.Add(Me.lblTimeRanking1)
        Me.Controls.Add(Me.lblTimeRanking2)
        Me.Controls.Add(Me.lblTimeRanking3)
        Me.Controls.Add(Me.lblTimeRanking4)
        Me.Controls.Add(Me.lblTimeRanking5)
        Me.Controls.Add(Me.lblNameRanking1)
        Me.Controls.Add(Me.lblNameRanking2)
        Me.Controls.Add(Me.lblNameRanking3)
        Me.Controls.Add(Me.lblNameRanking4)
        Me.Controls.Add(Me.lblNameRanking5)
        Me.Controls.Add(Me.lblNameTitle)
        Me.Controls.Add(Me.lblTimeTitle)
        Me.Controls.Add(Me.btnMazeSize10)
        Me.Controls.Add(Me.btnMazeSize20)
        Me.Controls.Add(Me.btnMazeSize30)
        Me.Controls.Add(Me.btnMazeSize10Back)
        Me.Controls.Add(Me.btnMazeSize20Back)
        Me.Controls.Add(Me.btnMazeSize30Back)
        Me.Controls.Add(Me.lblMazeSize10)
        Me.Controls.Add(Me.lblMazeSize20)
        Me.Controls.Add(Me.lblMazeSize30)
        Me.Controls.Add(Me.lblMazeSize)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmHighscores"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMazeSize10 As ButtonEllipse
    Friend WithEvents btnMazeSize20 As ButtonEllipse
    Friend WithEvents btnMazeSize30 As ButtonEllipse
    Friend WithEvents btnMazeSize10Back As ButtonEllipse
    Friend WithEvents btnMazeSize20Back As ButtonEllipse
    Friend WithEvents btnMazeSize30Back As ButtonEllipse
    Friend WithEvents lblMazeSize10 As Label
    Friend WithEvents lblMazeSize20 As Label
    Friend WithEvents lblMazeSize30 As Label
    Friend WithEvents lblMazeSize As Label
    Friend WithEvents lblTimeTitle As Label
    Friend WithEvents lblTimeRanking1 As Label
    Friend WithEvents lblTimeRanking2 As Label
    Friend WithEvents lblTimeRanking3 As Label
    Friend WithEvents lblTimeRanking4 As Label
    Friend WithEvents lblTimeRanking5 As Label
    Friend WithEvents btn_ranking1White As ButtonEllipse
    Friend WithEvents btn_ranking1Black As ButtonEllipse
    Friend WithEvents btn_ranking2Black As ButtonEllipse
    Friend WithEvents btn_ranking2White As ButtonEllipse
    Friend WithEvents btn_ranking3Black As ButtonEllipse
    Friend WithEvents btn_ranking3White As ButtonEllipse
    Friend WithEvents btn_ranking4Black As ButtonEllipse
    Friend WithEvents btn_ranking4White As ButtonEllipse
    Friend WithEvents btn_ranking5Black As ButtonEllipse
    Friend WithEvents btn_ranking5White As ButtonEllipse
    Friend WithEvents lblNameRanking1 As Label
    Friend WithEvents lblNameRanking2 As Label
    Friend WithEvents lblNameRanking3 As Label
    Friend WithEvents lblNameRanking4 As Label
    Friend WithEvents lblNameRanking5 As Label
    Friend WithEvents lblNameTitle As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents lbl_ranking2 As Label
    Friend WithEvents lbl_ranking3 As Label
    Friend WithEvents lbl_ranking4 As Label
    Friend WithEvents lbl_ranking5 As Label
    Friend WithEvents lbl_ranking1 As Label
End Class
