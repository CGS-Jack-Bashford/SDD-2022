Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

''' <summary>
''' This class allows for a circular button to be drawn by rendering a circular ellipse as a mask for the button
''' </summary>
Public Class ButtonEllipse

    Inherits Button

    ''' <summary>
    ''' Draws an ellipse around the center of the button, with the button's specified dimensions
    ''' </summary>
    ''' <param name="pevent">The paint event arguments from the form that the control belongs to, which are passed to the default paint handler</param>
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        Dim newGraphicsPath As GraphicsPath = New GraphicsPath()
        newGraphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New System.Drawing.Region(newGraphicsPath)

        MyBase.OnPaint(pevent)

    End Sub

End Class
