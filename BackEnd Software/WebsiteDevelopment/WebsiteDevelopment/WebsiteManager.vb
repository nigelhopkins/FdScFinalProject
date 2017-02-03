Public Class frmWebsiteManager

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmMainMenu.MdiParent = MDIParent1
        frmMainMenu.Dock = DockStyle.Fill
        frmMainMenu.Show()
        Me.Close()
    End Sub
End Class