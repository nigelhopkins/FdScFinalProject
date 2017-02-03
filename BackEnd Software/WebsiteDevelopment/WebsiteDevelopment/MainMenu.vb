Public Class frmMainMenu

    Dim OBJ As New MDIParent1

    Private Sub btnStockManager_Click(sender As Object, e As EventArgs) Handles btnStockManger.Click
        frmStockManager.MdiParent = MDIParent1
        frmStockManager.Dock = DockStyle.Fill
        frmStockManager.Show()
        Me.Close()
    End Sub

    Private Sub btnAccountManager_Click(sender As Object, e As EventArgs) Handles btnAccountManger.Click
        frmAccountManager.MdiParent = MDIParent1
        frmAccountManager.Dock = DockStyle.Fill
        frmAccountManager.Show()
        Me.Close()
    End Sub

    Private Sub btnWebSiteManager_Click(sender As Object, e As EventArgs)
        frmWebsiteManager.MdiParent = MDIParent1
        frmWebsiteManager.Dock = DockStyle.Fill
        frmWebsiteManager.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogon.MdiParent = MDIParent1
        frmLogon.Dock = DockStyle.Fill
        frmLogon.Show()
        MDIParent1.Login = 0
        Me.Close()
    End Sub
End Class