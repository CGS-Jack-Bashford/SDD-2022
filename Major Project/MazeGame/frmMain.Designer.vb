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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMazeSize = New System.Windows.Forms.Label()
        Me.lblMazeSize10 = New System.Windows.Forms.Label()
        Me.lblMazeSize20 = New System.Windows.Forms.Label()
        Me.lblMazeSize30 = New System.Windows.Forms.Label()
        Me.lblMazeSeed = New System.Windows.Forms.Label()
        Me.txtMazeSeed = New System.Windows.Forms.TextBox()
        Me.btnMazeSize10Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize10 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize20 = New MazeGame.ButtonEllipse()
        Me.btnMazeSize20Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize30Back = New MazeGame.ButtonEllipse()
        Me.btnMazeSize30 = New MazeGame.ButtonEllipse()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnHighscores = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlEnterName = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMazeSizeRandom = New MazeGame.ButtonEllipse()
        Me.btnMazeSizeRandomBack = New MazeGame.ButtonEllipse()
        Me.lblMazeSizeRandom = New System.Windows.Forms.Label()
        Me.pnlEnterName.SuspendLayout()
        Me.SuspendLayout()

        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2511, 1555)
        Me.Controls.Add(Me.lblMazeSizeRandom)
        Me.Controls.Add(Me.pnlEnterName)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnHighscores)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnMazeSize10)
        Me.Controls.Add(Me.btnMazeSize20)
        Me.Controls.Add(Me.btnMazeSize30)
        Me.Controls.Add(Me.btnMazeSizeRandom)
        Me.Controls.Add(Me.btnMazeSize10Back)
        Me.Controls.Add(Me.btnMazeSize20Back)
        Me.Controls.Add(Me.btnMazeSize30Back)
        Me.Controls.Add(Me.btnMazeSizeRandomBack)
        Me.Controls.Add(Me.txtMazeSeed)
        Me.Controls.Add(Me.lblMazeSeed)
        Me.Controls.Add(Me.lblMazeSize10)
        Me.Controls.Add(Me.lblMazeSize20)
        Me.Controls.Add(Me.lblMazeSize30)
        Me.Controls.Add(Me.lblMazeSize)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Maze Game"
        Me.pnlEnterName.ResumeLayout(False)
        Me.pnlEnterName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMazeSize As Label
    Friend WithEvents lblMazeSize10 As Label
    Friend WithEvents lblMazeSize20 As Label
    Friend WithEvents lblMazeSize30 As Label
    Friend WithEvents lblMazeSeed As Label
    Friend WithEvents txtMazeSeed As TextBox
    Friend WithEvents btnMazeSize10Back As ButtonEllipse
    Friend WithEvents btnMazeSize10 As ButtonEllipse
    Friend WithEvents btnMazeSize20 As ButtonEllipse
    Friend WithEvents btnMazeSize20Back As ButtonEllipse
    Friend WithEvents btnMazeSize30Back As ButtonEllipse
    Friend WithEvents btnMazeSize30 As ButtonEllipse
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnHighscores As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents pnlEnterName As TableLayoutPanel
    Friend WithEvents btnMazeSizeRandom As ButtonEllipse
    Friend WithEvents btnMazeSizeRandomBack As ButtonEllipse
    Friend WithEvents lblMazeSizeRandom As Label
End Class
