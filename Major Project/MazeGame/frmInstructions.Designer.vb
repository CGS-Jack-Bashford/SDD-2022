<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions1 = New System.Windows.Forms.Label()
        Me.lblInstructions2 = New System.Windows.Forms.Label()
        Me.lblInstructions3 = New System.Windows.Forms.Label()
        Me.lblInstructions4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Maze", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(411, 20)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(547, 64)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Instructions"
        '
        'lblInstructions1
        '
        Me.lblInstructions1.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions1.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions1.Location = New System.Drawing.Point(337, 119)
        Me.lblInstructions1.Name = "lblInstructions1"
        Me.lblInstructions1.Size = New System.Drawing.Size(694, 104)
        Me.lblInstructions1.TabIndex = 2
        Me.lblInstructions1.Text = "Choose a name (alphanumeric and underscores, 1-16 characters) and a difficulty (s" &
    "tandard sizes of 10x10, 20x20, or 30x30, and a random choice of those options as" &
    " well)"
        '
        'lblInstructions2
        '
        Me.lblInstructions2.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions2.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions2.Location = New System.Drawing.Point(337, 253)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(694, 107)
        Me.lblInstructions2.TabIndex = 3
        Me.lblInstructions2.Text = "Then use arrow keys or the on—screen controls to navigate through the maze from t" &
    "he starting square to the ending square. Try to get through the maze as fast as " &
    "possible! "
        '
        'lblInstructions3
        '
        Me.lblInstructions3.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions3.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions3.Location = New System.Drawing.Point(337, 390)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(694, 79)
        Me.lblInstructions3.TabIndex = 4
        Me.lblInstructions3.Text = "You can't move into a square blocked from your current square by a wall, and you " &
    "can't move beyond the boundaries of the maze."
        '
        'lblInstructions4
        '
        Me.lblInstructions4.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions4.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions4.Location = New System.Drawing.Point(337, 499)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(694, 77)
        Me.lblInstructions4.TabIndex = 5
        Me.lblInstructions4.Text = "Once you're through the maze, you can copy your seed to play the same maze and tr" &
    "y for a faster time. "
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Anonymous Pro for Powerline", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(595, 604)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(179, 72)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblInstructions4)
        Me.Controls.Add(Me.lblInstructions3)
        Me.Controls.Add(Me.lblInstructions2)
        Me.Controls.Add(Me.lblInstructions1)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmInstructions"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions1 As Label
    Friend WithEvents lblInstructions2 As Label
    Friend WithEvents lblInstructions3 As Label
    Friend WithEvents lblInstructions4 As Label
    Friend WithEvents btnBack As Button
End Class
