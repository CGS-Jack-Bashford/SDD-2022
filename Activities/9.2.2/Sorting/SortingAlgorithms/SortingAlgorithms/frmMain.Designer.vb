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
        Me.lstNums = New System.Windows.Forms.ListBox()
        Me.btnGetNums = New System.Windows.Forms.Button()
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.btnBubbleSort = New System.Windows.Forms.Button()
        Me.btnSelectionSort = New System.Windows.Forms.Button()
        Me.btnInsertionSort = New System.Windows.Forms.Button()
        Me.lstMetrics = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstNums
        '
        Me.lstNums.FormattingEnabled = True
        Me.lstNums.ItemHeight = 32
        Me.lstNums.Location = New System.Drawing.Point(12, 12)
        Me.lstNums.Name = "lstNums"
        Me.lstNums.Size = New System.Drawing.Size(240, 516)
        Me.lstNums.TabIndex = 0
        '
        'btnGetNums
        '
        Me.btnGetNums.Location = New System.Drawing.Point(268, 12)
        Me.btnGetNums.Name = "btnGetNums"
        Me.btnGetNums.Size = New System.Drawing.Size(169, 46)
        Me.btnGetNums.TabIndex = 1
        Me.btnGetNums.Text = "Get Numbers"
        Me.btnGetNums.UseVisualStyleBackColor = True
        '
        'btnShuffle
        '
        Me.btnShuffle.Location = New System.Drawing.Point(443, 12)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(150, 46)
        Me.btnShuffle.TabIndex = 2
        Me.btnShuffle.Text = "Reset Arr"
        Me.btnShuffle.UseVisualStyleBackColor = True
        '
        'btnBubbleSort
        '
        Me.btnBubbleSort.Location = New System.Drawing.Point(268, 93)
        Me.btnBubbleSort.Name = "btnBubbleSort"
        Me.btnBubbleSort.Size = New System.Drawing.Size(150, 46)
        Me.btnBubbleSort.TabIndex = 3
        Me.btnBubbleSort.Text = "Bubble"
        Me.btnBubbleSort.UseVisualStyleBackColor = True
        '
        'btnSelectionSort
        '
        Me.btnSelectionSort.Location = New System.Drawing.Point(420, 93)
        Me.btnSelectionSort.Name = "btnSelectionSort"
        Me.btnSelectionSort.Size = New System.Drawing.Size(150, 46)
        Me.btnSelectionSort.TabIndex = 4
        Me.btnSelectionSort.Text = "Selection"
        Me.btnSelectionSort.UseVisualStyleBackColor = True
        '
        'btnInsertionSort
        '
        Me.btnInsertionSort.Location = New System.Drawing.Point(576, 93)
        Me.btnInsertionSort.Name = "btnInsertionSort"
        Me.btnInsertionSort.Size = New System.Drawing.Size(150, 46)
        Me.btnInsertionSort.TabIndex = 5
        Me.btnInsertionSort.Text = "Insertion"
        Me.btnInsertionSort.UseVisualStyleBackColor = True
        '
        'lstMetrics
        '
        Me.lstMetrics.FormattingEnabled = True
        Me.lstMetrics.ItemHeight = 32
        Me.lstMetrics.Location = New System.Drawing.Point(268, 183)
        Me.lstMetrics.Name = "lstMetrics"
        Me.lstMetrics.Size = New System.Drawing.Size(257, 164)
        Me.lstMetrics.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 539)
        Me.Controls.Add(Me.lstMetrics)
        Me.Controls.Add(Me.btnInsertionSort)
        Me.Controls.Add(Me.btnSelectionSort)
        Me.Controls.Add(Me.btnBubbleSort)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.btnGetNums)
        Me.Controls.Add(Me.lstNums)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNums As ListBox
    Friend WithEvents btnGetNums As Button
    Friend WithEvents btnShuffle As Button
    Friend WithEvents btnBubbleSort As Button
    Friend WithEvents btnSelectionSort As Button
    Friend WithEvents btnInsertionSort As Button
    Friend WithEvents lstMetrics As ListBox
End Class
