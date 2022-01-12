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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.black10x10 = New MazeGame.ButtonEllipse()
        Me.white10x10 = New MazeGame.ButtonEllipse()
        Me.white20x20 = New MazeGame.ButtonEllipse()
        Me.black20x20 = New MazeGame.ButtonEllipse()
        Me.black30x30 = New MazeGame.ButtonEllipse()
        Me.white30x30 = New MazeGame.ButtonEllipse()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maze", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(486, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maze Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(38, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Maze Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(105, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "10x10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(105, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "20x20"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(107, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "30x30"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(38, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Maze Seed"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(38, 438)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "Enter Seed"
        Me.TextBox1.Size = New System.Drawing.Size(166, 36)
        Me.TextBox1.TabIndex = 6
        '
        'black10x10
        '
        Me.black10x10.BackColor = System.Drawing.Color.Black
        Me.black10x10.FlatAppearance.BorderSize = 0
        Me.black10x10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.black10x10.Location = New System.Drawing.Point(65, 150)
        Me.black10x10.Name = "black10x10"
        Me.black10x10.Size = New System.Drawing.Size(34, 34)
        Me.black10x10.TabIndex = 7
        Me.black10x10.UseVisualStyleBackColor = False
        '
        'white10x10
        '
        Me.white10x10.BackColor = System.Drawing.Color.White
        Me.white10x10.FlatAppearance.BorderSize = 0
        Me.white10x10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.white10x10.Location = New System.Drawing.Point(66, 151)
        Me.white10x10.Name = "white10x10"
        Me.white10x10.Size = New System.Drawing.Size(32, 32)
        Me.white10x10.TabIndex = 7
        Me.white10x10.UseVisualStyleBackColor = False
        '
        'white20x20
        '
        Me.white20x20.BackColor = System.Drawing.Color.White
        Me.white20x20.FlatAppearance.BorderSize = 0
        Me.white20x20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.white20x20.Location = New System.Drawing.Point(66, 201)
        Me.white20x20.Name = "white20x20"
        Me.white20x20.Size = New System.Drawing.Size(32, 32)
        Me.white20x20.TabIndex = 8
        Me.white20x20.UseVisualStyleBackColor = False
        '
        'black20x20
        '
        Me.black20x20.BackColor = System.Drawing.Color.Black
        Me.black20x20.FlatAppearance.BorderSize = 0
        Me.black20x20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.black20x20.Location = New System.Drawing.Point(65, 200)
        Me.black20x20.Name = "black20x20"
        Me.black20x20.Size = New System.Drawing.Size(34, 34)
        Me.black20x20.TabIndex = 9
        Me.black20x20.UseVisualStyleBackColor = False
        '
        'black30x30
        '
        Me.black30x30.BackColor = System.Drawing.Color.Black
        Me.black30x30.FlatAppearance.BorderSize = 0
        Me.black30x30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.black30x30.Location = New System.Drawing.Point(65, 250)
        Me.black30x30.Name = "black30x30"
        Me.black30x30.Size = New System.Drawing.Size(34, 34)
        Me.black30x30.TabIndex = 10
        Me.black30x30.UseVisualStyleBackColor = False
        '
        'white30x30
        '
        Me.white30x30.BackColor = System.Drawing.Color.White
        Me.white30x30.FlatAppearance.BorderSize = 0
        Me.white30x30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.white30x30.Location = New System.Drawing.Point(66, 251)
        Me.white30x30.Name = "white30x30"
        Me.white30x30.Size = New System.Drawing.Size(32, 32)
        Me.white30x30.TabIndex = 11
        Me.white30x30.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.white10x10)
        Me.Controls.Add(Me.white20x20)
        Me.Controls.Add(Me.white30x30)
        Me.Controls.Add(Me.black10x10)
        Me.Controls.Add(Me.black20x20)
        Me.Controls.Add(Me.black30x30)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents black10x10 As ButtonEllipse
    Friend WithEvents white10x10 As ButtonEllipse
    Friend WithEvents white20x20 As ButtonEllipse
    Friend WithEvents black20x20 As ButtonEllipse
    Friend WithEvents black30x30 As ButtonEllipse
    Friend WithEvents white30x30 As ButtonEllipse
End Class
