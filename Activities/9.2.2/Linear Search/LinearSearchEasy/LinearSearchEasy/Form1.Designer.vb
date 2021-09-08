<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_toFind = New System.Windows.Forms.Label()
        Me.nupToFind = New System.Windows.Forms.NumericUpDown()
        Me.btnFind = New System.Windows.Forms.Button()
        CType(Me.nupToFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_toFind
        '
        Me.lbl_toFind.AutoSize = True
        Me.lbl_toFind.Location = New System.Drawing.Point(345, 135)
        Me.lbl_toFind.Name = "lbl_toFind"
        Me.lbl_toFind.Size = New System.Drawing.Size(149, 32)
        Me.lbl_toFind.TabIndex = 0
        Me.lbl_toFind.Text = "Num to Find"
        '
        'nupToFind
        '
        Me.nupToFind.Location = New System.Drawing.Point(296, 180)
        Me.nupToFind.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nupToFind.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.nupToFind.Name = "nupToFind"
        Me.nupToFind.Size = New System.Drawing.Size(240, 39)
        Me.nupToFind.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(339, 240)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(150, 46)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Search"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.nupToFind)
        Me.Controls.Add(Me.lbl_toFind)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nupToFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_toFind As Label
    Friend WithEvents nupToFind As NumericUpDown
    Friend WithEvents btnFind As Button
End Class
