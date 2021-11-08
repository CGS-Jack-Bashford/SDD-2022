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
        Me.cmdHarderWriteDemo = New System.Windows.Forms.Button()
        Me.cmdHarderReadDemo = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdHarderWriteDemo
        '
        Me.cmdHarderWriteDemo.Location = New System.Drawing.Point(540, 74)
        Me.cmdHarderWriteDemo.Name = "cmdHarderWriteDemo"
        Me.cmdHarderWriteDemo.Size = New System.Drawing.Size(75, 23)
        Me.cmdHarderWriteDemo.TabIndex = 0
        Me.cmdHarderWriteDemo.Text = "Button1"
        Me.cmdHarderWriteDemo.UseVisualStyleBackColor = True
        '
        'cmdHarderReadDemo
        '
        Me.cmdHarderReadDemo.Location = New System.Drawing.Point(540, 104)
        Me.cmdHarderReadDemo.Name = "cmdHarderReadDemo"
        Me.cmdHarderReadDemo.Size = New System.Drawing.Size(75, 23)
        Me.cmdHarderReadDemo.TabIndex = 0
        Me.cmdHarderReadDemo.Text = "Button2"
        Me.cmdHarderReadDemo.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(12, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(469, 424)
        Me.lstOutput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.cmdHarderReadDemo)
        Me.Controls.Add(Me.cmdHarderWriteDemo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdHarderWriteDemo As Button
    Friend WithEvents cmdHarderReadDemo As Button
    Friend WithEvents lstOutput As ListBox
End Class
