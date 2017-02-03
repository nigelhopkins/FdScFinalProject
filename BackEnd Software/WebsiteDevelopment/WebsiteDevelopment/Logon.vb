Public Class frmLogon



    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged

        If chkPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub frmLogon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkPassword.Checked = True
    End Sub

    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click

        If txtUserName.Text = "username" And txtPassword.Text = "password" Then
            frmMainMenu.MdiParent = MDIParent1
            frmMainMenu.Dock = DockStyle.Fill
            frmMainMenu.Show()
            Me.Close()
            MDIParent1.Login = 1
        Else
            MsgBox("Incorrect username or password entered please try again!", MsgBoxStyle.Information)
            txtPassword.Text = ""
            txtUserName.Text = ""
            Me.txtUserName.Focus()
        End If
    End Sub

    Private Sub txtUserName_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        txtUserName.SelectAll()
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub
End Class