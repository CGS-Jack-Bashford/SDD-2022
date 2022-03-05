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
