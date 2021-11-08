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
        Me.cmdRelativeRead = New System.Windows.Forms.Button()
        Me.cmdRelativeWrite = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdRelativeRead
        '
        Me.cmdRelativeRead.Location = New System.Drawing.Point(635, 57)
        Me.cmdRelativeRead.Name = "cmdRelativeRead"
        Me.cmdRelativeRead.Size = New System.Drawing.Size(150, 46)
        Me.cmdRelativeRead.TabIndex = 0
        Me.cmdRelativeRead.Text = "Button1"
        Me.cmdRelativeRead.UseVisualStyleBackColor = True
        '
        'cmdRelativeWrite
        '
        Me.cmdRelativeWrite.Location = New System.Drawing.Point(635, 121)
        Me.cmdRelativeWrite.Name = "cmdRelativeWrite"
        Me.cmdRelativeWrite.Size = New System.Drawing.Size(150, 46)
        Me.cmdRelativeWrite.TabIndex = 1
        Me.cmdRelativeWrite.Text = "Button1"
        Me.cmdRelativeWrite.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 32
        Me.lstOutput.Location = New System.Drawing.Point(13, 13)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(240, 164)
        Me.lstOutput.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.cmdRelativeWrite)
        Me.Controls.Add(Me.cmdRelativeRead)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdRelativeRead As Button
    Friend WithEvents cmdRelativeWrite As Button
    Friend WithEvents lstOutput As ListBox
End Class
