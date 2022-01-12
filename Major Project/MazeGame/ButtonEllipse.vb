Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class ButtonEllipse

    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        Dim newGraphicsPath As GraphicsPath = New GraphicsPath()
        newGraphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New System.Drawing.Region(newGraphicsPath)

        MyBase.OnPaint(pevent)

    End Sub

End Class
