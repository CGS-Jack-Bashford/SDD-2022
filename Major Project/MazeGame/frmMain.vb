Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        lblMazeSeed.Enabled = Not lblMazeSeed.Enabled
        txtMazeSeed.Enabled = Not txtMazeSeed.Enabled
    End Sub

End Class