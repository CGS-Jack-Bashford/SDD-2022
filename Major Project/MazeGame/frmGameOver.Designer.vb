<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameOver))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.lbl_seed = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblMazeSize = New System.Windows.Forms.Label()
        Me.lblMazeSeed = New System.Windows.Forms.Label()
        Me.lblGameTime = New System.Windows.Forms.Label()
        Me.btnMazeSize10 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize10Back = New MazeGame.ButtonEllipse()
        Me.btnToHighscores = New System.Windows.Forms.Button()
        Me.btnToStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'frmGameOver
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.btnToHighscores)
        Me.Controls.Add(Me.btnToStart)
        Me.Controls.Add(Me.btnMazeSize10)
        Me.Controls.Add(Me.btnMazeSize10Back)
        Me.Controls.Add(Me.lblGameTime)
        Me.Controls.Add(Me.lblMazeSeed)
        Me.Controls.Add(Me.lblMazeSize)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_seed)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmGameOver"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents lbl_seed As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblMazeSize As Label
    Friend WithEvents lblMazeSeed As Label
    Friend WithEvents lblGameTime As Label
    Friend WithEvents btnMazeSize10 As ButtonEllipse
    Friend WithEvents btnMazeSize10Back As ButtonEllipse
    Friend WithEvents btnToHighscores As Button
    Friend WithEvents btnToStart As Button
End Class
