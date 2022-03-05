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
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(100, 23)
        Me.lblTitle.TabIndex = 5
        '
        'lblInstructions1
        '
        Me.lblInstructions1.Location = New System.Drawing.Point(0, 0)
        Me.lblInstructions1.Name = "lblInstructions1"
        Me.lblInstructions1.Size = New System.Drawing.Size(100, 23)
        Me.lblInstructions1.TabIndex = 4
        '
        'lblInstructions2
        '
        Me.lblInstructions2.Location = New System.Drawing.Point(0, 0)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(100, 23)
        Me.lblInstructions2.TabIndex = 3
        '
        'lblInstructions3
        '
        Me.lblInstructions3.Location = New System.Drawing.Point(0, 0)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(100, 23)
        Me.lblInstructions3.TabIndex = 2
        '
        'lblInstructions4
        '
        Me.lblInstructions4.Location = New System.Drawing.Point(0, 0)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(100, 23)
        Me.lblInstructions4.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
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

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions1 As Label
    Friend WithEvents lblInstructions2 As Label
    Friend WithEvents lblInstructions3 As Label
    Friend WithEvents lblInstructions4 As Label
    Friend WithEvents btnBack As Button
End Class
