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
        Me.lstInputs = New System.Windows.Forms.ListBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lstExpected = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstInputs
        '
        Me.lstInputs.FormattingEnabled = True
        Me.lstInputs.ItemHeight = 15
        Me.lstInputs.Location = New System.Drawing.Point(6, 30)
        Me.lstInputs.Name = "lstInputs"
        Me.lstInputs.Size = New System.Drawing.Size(148, 199)
        Me.lstInputs.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(566, 8)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Run Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(160, 30)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(120, 199)
        Me.lstOutput.TabIndex = 2
        '
        'lstExpected
        '
        Me.lstExpected.FormattingEnabled = True
        Me.lstExpected.ItemHeight = 15
        Me.lstExpected.Location = New System.Drawing.Point(335, 30)
        Me.lstExpected.Name = "lstExpected"
        Me.lstExpected.Size = New System.Drawing.Size(120, 199)
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
        Me.Label1.Location = New System.Drawing.Point(335, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Expected Output"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Output Data"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lstExpected)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lstInputs)
        Me.Name = "Form1"
        Me.Text = "Testing - ValidateName"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstInputs As ListBox
    Friend WithEvents btnTest As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents lstExpected As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
