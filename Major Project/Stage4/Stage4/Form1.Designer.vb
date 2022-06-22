<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lstInput1 = New System.Windows.Forms.ListBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lstExpected = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstOutput1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstExpected1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstInput1
        '
        Me.lstInput1.FormattingEnabled = True
        Me.lstInput1.ItemHeight = 15
        Me.lstInput1.Location = New System.Drawing.Point(6, 30)
        Me.lstInput1.Name = "lstInput1"
        Me.lstInput1.Size = New System.Drawing.Size(148, 229)
        Me.lstInput1.TabIndex = 0
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(160, 30)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(0, 4)
        Me.lstOutput.TabIndex = 2
        '
        'lstExpected
        '
        Me.lstExpected.FormattingEnabled = True
        Me.lstExpected.ItemHeight = 15
        Me.lstExpected.Location = New System.Drawing.Point(335, 30)
        Me.lstExpected.Name = "lstExpected"
        Me.lstExpected.Size = New System.Drawing.Size(0, 4)
        Me.lstExpected.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(9, 8)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(62, 15)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Input Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Output Data"
        '
        'lstOutput1
        '
        Me.lstOutput1.FormattingEnabled = True
        Me.lstOutput1.ItemHeight = 15
        Me.lstOutput1.Location = New System.Drawing.Point(160, 30)
        Me.lstOutput1.Name = "lstOutput1"
        Me.lstOutput1.Size = New System.Drawing.Size(148, 229)
        Me.lstOutput1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Expected Output"
        '
        'lstExpected1
        '
        Me.lstExpected1.FormattingEnabled = True
        Me.lstExpected1.ItemHeight = 15
        Me.lstExpected1.Location = New System.Drawing.Point(314, 30)
        Me.lstExpected1.Name = "lstExpected1"
        Me.lstExpected1.Size = New System.Drawing.Size(148, 229)
        Me.lstExpected1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PlayerName Value"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(468, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 229)
        Me.ListBox1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(732, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstExpected1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstOutput1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lstExpected)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lstInput1)
        Me.Name = "Form1"
        Me.Text = "Testing - ValidateName"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstInput1 As ListBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents lstExpected As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstOutput1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstExpected1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class
