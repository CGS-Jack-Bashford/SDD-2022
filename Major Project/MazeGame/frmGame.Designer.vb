<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMazeSizeDisp = New MazeGame.ButtonEllipse()
        Me.btnMazeSizeDispBack = New MazeGame.ButtonEllipse()
        Me.lblMazeSizeDisp = New System.Windows.Forms.Label()
        Me.lblMazeSize = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.tmrTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblMazeSeed = New System.Windows.Forms.Label()
        Me.txtMazeSeed = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveDown)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lbl_Time)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.btnMazeSizeDisp)
        Me.Controls.Add(Me.btnMazeSizeDispBack)
        Me.Controls.Add(Me.lblMazeSizeDisp)
        Me.Controls.Add(Me.lblMazeSize)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtMazeSeed)
        Me.Controls.Add(Me.lblMazeSeed)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGame"
        Me.Text = "Maze Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMazeSizeDisp As ButtonEllipse
    Friend WithEvents btnMazeSizeDispBack As ButtonEllipse
    Friend WithEvents lblMazeSizeDisp As Label
    Friend WithEvents lblMazeSize As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents pnlGame As Panel
    Friend WithEvents lbl_Time As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnMoveUp As Button
    Friend WithEvents btnMoveLeft As Button
    Friend WithEvents btnMoveDown As Button
    Friend WithEvents btnMoveRight As Button
    Friend WithEvents tmrTick As Timer
    Friend WithEvents lblMazeSeed As Label
    Friend WithEvents txtMazeSeed As TextBox
End Class
