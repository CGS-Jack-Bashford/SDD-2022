﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNums
        '
        Me.lstNums.FormattingEnabled = True
        Me.lstNums.ItemHeight = 32
        Me.lstNums.Location = New System.Drawing.Point(13, 13)
        Me.lstNums.Name = "lstNums"
        Me.lstNums.Size = New System.Drawing.Size(240, 420)
        Me.lstNums.TabIndex = 0
        '
        'btnGetNums
        '
        Me.btnGetNums.Location = New System.Drawing.Point(441, 147)
        Me.btnGetNums.Name = "btnGetNums"
        Me.btnGetNums.Size = New System.Drawing.Size(168, 46)
        Me.btnGetNums.TabIndex = 1
        Me.btnGetNums.Text = "Get Numbers"
        Me.btnGetNums.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(441, 210)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(168, 46)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find Value"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnGetNums)
        Me.Controls.Add(Me.lstNums)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNums As ListBox
    Friend WithEvents btnGetNums As Button
    Friend WithEvents btnFind As Button
End Class
