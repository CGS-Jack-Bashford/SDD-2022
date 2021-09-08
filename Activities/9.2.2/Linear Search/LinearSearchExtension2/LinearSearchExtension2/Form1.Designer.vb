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
        Me.lstNums = New System.Windows.Forms.ListBox()
        Me.btnGetNums = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNums
        '
        Me.lstNums.FormattingEnabled = True
        Me.lstNums.ItemHeight = 32
        Me.lstNums.Location = New System.Drawing.Point(12, 12)
        Me.lstNums.Name = "lstNums"
        Me.lstNums.Size = New System.Drawing.Size(240, 388)
        Me.lstNums.TabIndex = 0
        '
        'btnGetNums
        '
        Me.btnGetNums.Location = New System.Drawing.Point(361, 79)
        Me.btnGetNums.Name = "btnGetNums"
        Me.btnGetNums.Size = New System.Drawing.Size(170, 46)
        Me.btnGetNums.TabIndex = 1
        Me.btnGetNums.Text = "Get Numbers"
        Me.btnGetNums.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(361, 273)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(170, 46)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Find Number"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 413)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnGetNums)
        Me.Controls.Add(Me.lstNums)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNums As ListBox
    Friend WithEvents btnGetNums As Button
    Friend WithEvents btnSearch As Button
End Class
