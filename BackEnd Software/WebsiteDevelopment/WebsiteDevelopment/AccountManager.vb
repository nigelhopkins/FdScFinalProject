Public Class frmAccountManager

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmMainMenu.MdiParent = MDIParent1
        frmMainMenu.Dock = DockStyle.Fill
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click

        frmNewAccountManager.NewWindows = "NewAccount"

        frmNewAccountManager.MdiParent = MDIParent1
        frmNewAccountManager.Dock = DockStyle.Fill
        frmNewAccountManager.Show()
        Me.Close()

    End Sub

    Private Sub btnDelAccount_Click(sender As Object, e As EventArgs) Handles btnDelAccount.Click

        frmNewAccountManager.NewWindows = "DeleteAccount"

        frmNewAccountManager.MdiParent = MDIParent1
        frmNewAccountManager.Dock = DockStyle.Fill
        frmNewAccountManager.Show()
        Me.Close()
    End Sub

    Private Sub btnAccountLookup_Click(sender As Object, e As EventArgs) Handles btnAccountLookup.Click

        frmNewAccountManager.NewWindows = "AccountLookup"
        frmNewAccountManager.MdiParent = MDIParent1
        frmNewAccountManager.Dock = DockStyle.Fill
        frmNewAccountManager.Show()
        Me.Close()
    End Sub
End Class