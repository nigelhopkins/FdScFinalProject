<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAccountManager
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAccountManager = New System.Windows.Forms.Button()
        Me.bntSave = New System.Windows.Forms.Button()
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.grpAccountDetails = New System.Windows.Forms.GroupBox()
        Me.pnlAccountNav = New System.Windows.Forms.Panel()
        Me.btnPasswordReset = New System.Windows.Forms.Button()
        Me.btnUploadFiles = New System.Windows.Forms.Button()
        Me.bntDisplayAccountDetails = New System.Windows.Forms.Button()
        Me.pnlEnterDetails = New System.Windows.Forms.Panel()
        Me.lblNewAccountID = New System.Windows.Forms.Label()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblBuildingNumber = New System.Windows.Forms.Label()
        Me.txtBuildingNumber = New System.Windows.Forms.TextBox()
        Me.lblLoadAccount = New System.Windows.Forms.Label()
        Me.lstAccounts = New System.Windows.Forms.ListBox()
        Me.bntBack = New System.Windows.Forms.Button()
        Me.grpUpload = New System.Windows.Forms.GroupBox()
        Me.txtDesDir = New System.Windows.Forms.TextBox()
        Me.txtSourceDir = New System.Windows.Forms.TextBox()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnSourceBack = New System.Windows.Forms.Button()
        Me.btnDestinationBack = New System.Windows.Forms.Button()
        Me.grpAccountDetails.SuspendLayout()
        Me.pnlAccountNav.SuspendLayout()
        Me.pnlEnterDetails.SuspendLayout()
        Me.grpUpload.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMainMenu.Location = New System.Drawing.Point(714, 514)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(147, 71)
        Me.btnMainMenu.TabIndex = 3
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.25!)
        Me.lblTitle.Location = New System.Drawing.Point(166, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(540, 74)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Account Manager"
        '
        'btnAccountManager
        '
        Me.btnAccountManager.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAccountManager.Location = New System.Drawing.Point(561, 514)
        Me.btnAccountManager.Name = "btnAccountManager"
        Me.btnAccountManager.Size = New System.Drawing.Size(147, 71)
        Me.btnAccountManager.TabIndex = 16
        Me.btnAccountManager.Text = "Account Manager"
        Me.btnAccountManager.UseVisualStyleBackColor = True
        '
        'bntSave
        '
        Me.bntSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bntSave.Location = New System.Drawing.Point(408, 514)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(147, 71)
        Me.bntSave.TabIndex = 17
        Me.bntSave.Text = "Save"
        Me.bntSave.UseVisualStyleBackColor = True
        Me.bntSave.Visible = False
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteAccount.Location = New System.Drawing.Point(255, 514)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(147, 71)
        Me.btnDeleteAccount.TabIndex = 18
        Me.btnDeleteAccount.Text = "Delete Account"
        Me.btnDeleteAccount.UseVisualStyleBackColor = True
        Me.btnDeleteAccount.Visible = False
        '
        'grpAccountDetails
        '
        Me.grpAccountDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpAccountDetails.Controls.Add(Me.pnlAccountNav)
        Me.grpAccountDetails.Controls.Add(Me.pnlEnterDetails)
        Me.grpAccountDetails.Controls.Add(Me.lblLoadAccount)
        Me.grpAccountDetails.Controls.Add(Me.lstAccounts)
        Me.grpAccountDetails.Location = New System.Drawing.Point(11, 122)
        Me.grpAccountDetails.Name = "grpAccountDetails"
        Me.grpAccountDetails.Size = New System.Drawing.Size(850, 386)
        Me.grpAccountDetails.TabIndex = 19
        Me.grpAccountDetails.TabStop = False
        Me.grpAccountDetails.Text = "New Account"
        '
        'pnlAccountNav
        '
        Me.pnlAccountNav.Controls.Add(Me.btnPasswordReset)
        Me.pnlAccountNav.Controls.Add(Me.btnUploadFiles)
        Me.pnlAccountNav.Controls.Add(Me.bntDisplayAccountDetails)
        Me.pnlAccountNav.Location = New System.Drawing.Point(79, 23)
        Me.pnlAccountNav.Name = "pnlAccountNav"
        Me.pnlAccountNav.Size = New System.Drawing.Size(692, 186)
        Me.pnlAccountNav.TabIndex = 34
        '
        'btnPasswordReset
        '
        Me.btnPasswordReset.Location = New System.Drawing.Point(492, 28)
        Me.btnPasswordReset.Name = "btnPasswordReset"
        Me.btnPasswordReset.Size = New System.Drawing.Size(183, 130)
        Me.btnPasswordReset.TabIndex = 2
        Me.btnPasswordReset.Text = "Password Reset"
        Me.btnPasswordReset.UseVisualStyleBackColor = True
        '
        'btnUploadFiles
        '
        Me.btnUploadFiles.Location = New System.Drawing.Point(256, 28)
        Me.btnUploadFiles.Name = "btnUploadFiles"
        Me.btnUploadFiles.Size = New System.Drawing.Size(183, 130)
        Me.btnUploadFiles.TabIndex = 1
        Me.btnUploadFiles.Text = "Upload Files"
        Me.btnUploadFiles.UseVisualStyleBackColor = True
        '
        'bntDisplayAccountDetails
        '
        Me.bntDisplayAccountDetails.Location = New System.Drawing.Point(20, 28)
        Me.bntDisplayAccountDetails.Name = "bntDisplayAccountDetails"
        Me.bntDisplayAccountDetails.Size = New System.Drawing.Size(183, 130)
        Me.bntDisplayAccountDetails.TabIndex = 0
        Me.bntDisplayAccountDetails.Text = "Account Details"
        Me.bntDisplayAccountDetails.UseVisualStyleBackColor = True
        '
        'pnlEnterDetails
        '
        Me.pnlEnterDetails.Controls.Add(Me.lblNewAccountID)
        Me.pnlEnterDetails.Controls.Add(Me.lblAccountID)
        Me.pnlEnterDetails.Controls.Add(Me.lblEmail)
        Me.pnlEnterDetails.Controls.Add(Me.txtEmail)
        Me.pnlEnterDetails.Controls.Add(Me.lblPostalCode)
        Me.pnlEnterDetails.Controls.Add(Me.txtPostalCode)
        Me.pnlEnterDetails.Controls.Add(Me.lblCounty)
        Me.pnlEnterDetails.Controls.Add(Me.txtCounty)
        Me.pnlEnterDetails.Controls.Add(Me.lblCity)
        Me.pnlEnterDetails.Controls.Add(Me.txtCity)
        Me.pnlEnterDetails.Controls.Add(Me.lblStreetName)
        Me.pnlEnterDetails.Controls.Add(Me.txtStreetName)
        Me.pnlEnterDetails.Controls.Add(Me.lblPhoneNumber)
        Me.pnlEnterDetails.Controls.Add(Me.txtPhoneNumber)
        Me.pnlEnterDetails.Controls.Add(Me.lblCompanyName)
        Me.pnlEnterDetails.Controls.Add(Me.txtCompanyName)
        Me.pnlEnterDetails.Controls.Add(Me.lblLastName)
        Me.pnlEnterDetails.Controls.Add(Me.txtLastName)
        Me.pnlEnterDetails.Controls.Add(Me.lblFirstName)
        Me.pnlEnterDetails.Controls.Add(Me.txtFirstName)
        Me.pnlEnterDetails.Controls.Add(Me.lblBuildingNumber)
        Me.pnlEnterDetails.Controls.Add(Me.txtBuildingNumber)
        Me.pnlEnterDetails.Location = New System.Drawing.Point(79, 23)
        Me.pnlEnterDetails.Name = "pnlEnterDetails"
        Me.pnlEnterDetails.Size = New System.Drawing.Size(692, 186)
        Me.pnlEnterDetails.TabIndex = 33
        '
        'lblNewAccountID
        '
        Me.lblNewAccountID.AutoSize = True
        Me.lblNewAccountID.Location = New System.Drawing.Point(102, 19)
        Me.lblNewAccountID.Name = "lblNewAccountID"
        Me.lblNewAccountID.Size = New System.Drawing.Size(0, 13)
        Me.lblNewAccountID.TabIndex = 71
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Location = New System.Drawing.Point(17, 19)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(21, 13)
        Me.lblAccountID.TabIndex = 70
        Me.lblAccountID.Text = "ID "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 150)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 69
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(105, 147)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(218, 20)
        Me.txtEmail.TabIndex = 54
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(368, 150)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(64, 13)
        Me.lblPostalCode.TabIndex = 68
        Me.lblPostalCode.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(458, 147)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(218, 20)
        Me.txtPostalCode.TabIndex = 61
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(368, 124)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 67
        Me.lblCounty.Text = "County"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(458, 121)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(218, 20)
        Me.txtCounty.TabIndex = 60
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(368, 98)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 66
        Me.lblCity.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(458, 95)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(218, 20)
        Me.txtCity.TabIndex = 58
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.Location = New System.Drawing.Point(368, 72)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(66, 13)
        Me.lblStreetName.TabIndex = 65
        Me.lblStreetName.Text = "Street Name"
        '
        'txtStreetName
        '
        Me.txtStreetName.Location = New System.Drawing.Point(458, 69)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(218, 20)
        Me.txtStreetName.TabIndex = 57
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(17, 121)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 64
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(105, 118)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(218, 20)
        Me.txtPhoneNumber.TabIndex = 53
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(17, 43)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 63
        Me.lblCompanyName.Text = "Company Name"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(105, 40)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(218, 20)
        Me.txtCompanyName.TabIndex = 50
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(17, 95)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 62
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(105, 92)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(218, 20)
        Me.txtLastName.TabIndex = 52
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(17, 69)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 59
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(105, 66)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(218, 20)
        Me.txtFirstName.TabIndex = 51
        '
        'lblBuildingNumber
        '
        Me.lblBuildingNumber.AutoSize = True
        Me.lblBuildingNumber.Location = New System.Drawing.Point(368, 46)
        Me.lblBuildingNumber.Name = "lblBuildingNumber"
        Me.lblBuildingNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblBuildingNumber.TabIndex = 56
        Me.lblBuildingNumber.Text = "Building Number"
        '
        'txtBuildingNumber
        '
        Me.txtBuildingNumber.Location = New System.Drawing.Point(458, 43)
        Me.txtBuildingNumber.Name = "txtBuildingNumber"
        Me.txtBuildingNumber.Size = New System.Drawing.Size(218, 20)
        Me.txtBuildingNumber.TabIndex = 55
        '
        'lblLoadAccount
        '
        Me.lblLoadAccount.AutoSize = True
        Me.lblLoadAccount.Location = New System.Drawing.Point(4, 217)
        Me.lblLoadAccount.Name = "lblLoadAccount"
        Me.lblLoadAccount.Size = New System.Drawing.Size(74, 13)
        Me.lblLoadAccount.TabIndex = 31
        Me.lblLoadAccount.Text = "Load Account"
        Me.lblLoadAccount.Visible = False
        '
        'lstAccounts
        '
        Me.lstAccounts.FormattingEnabled = True
        Me.lstAccounts.Location = New System.Drawing.Point(6, 233)
        Me.lstAccounts.MultiColumn = True
        Me.lstAccounts.Name = "lstAccounts"
        Me.lstAccounts.Size = New System.Drawing.Size(839, 147)
        Me.lstAccounts.TabIndex = 30
        '
        'bntBack
        '
        Me.bntBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bntBack.Location = New System.Drawing.Point(102, 514)
        Me.bntBack.Name = "bntBack"
        Me.bntBack.Size = New System.Drawing.Size(147, 71)
        Me.bntBack.TabIndex = 20
        Me.bntBack.Text = "Back"
        Me.bntBack.UseVisualStyleBackColor = True
        Me.bntBack.Visible = False
        '
        'grpUpload
        '
        Me.grpUpload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpUpload.Controls.Add(Me.btnDestinationBack)
        Me.grpUpload.Controls.Add(Me.btnSourceBack)
        Me.grpUpload.Controls.Add(Me.txtDesDir)
        Me.grpUpload.Controls.Add(Me.txtSourceDir)
        Me.grpUpload.Controls.Add(Me.WebBrowser2)
        Me.grpUpload.Controls.Add(Me.WebBrowser1)
        Me.grpUpload.Location = New System.Drawing.Point(11, 122)
        Me.grpUpload.Name = "grpUpload"
        Me.grpUpload.Size = New System.Drawing.Size(850, 386)
        Me.grpUpload.TabIndex = 21
        Me.grpUpload.TabStop = False
        Me.grpUpload.Text = "Upload"
        Me.grpUpload.Visible = False
        '
        'txtDesDir
        '
        Me.txtDesDir.Location = New System.Drawing.Point(482, 28)
        Me.txtDesDir.Name = "txtDesDir"
        Me.txtDesDir.ReadOnly = True
        Me.txtDesDir.Size = New System.Drawing.Size(360, 20)
        Me.txtDesDir.TabIndex = 25
        '
        'txtSourceDir
        '
        Me.txtSourceDir.Location = New System.Drawing.Point(62, 28)
        Me.txtSourceDir.Name = "txtSourceDir"
        Me.txtSourceDir.ReadOnly = True
        Me.txtSourceDir.Size = New System.Drawing.Size(360, 20)
        Me.txtSourceDir.TabIndex = 24
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(428, 54)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(414, 277)
        Me.WebBrowser2.TabIndex = 23
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(8, 54)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(414, 277)
        Me.WebBrowser1.TabIndex = 22
        '
        'btnSourceBack
        '
        Me.btnSourceBack.Location = New System.Drawing.Point(8, 25)
        Me.btnSourceBack.Name = "btnSourceBack"
        Me.btnSourceBack.Size = New System.Drawing.Size(48, 23)
        Me.btnSourceBack.TabIndex = 26
        Me.btnSourceBack.Text = "<--"
        Me.btnSourceBack.UseVisualStyleBackColor = True
        '
        'btnDestinationBack
        '
        Me.btnDestinationBack.Location = New System.Drawing.Point(428, 25)
        Me.btnDestinationBack.Name = "btnDestinationBack"
        Me.btnDestinationBack.Size = New System.Drawing.Size(48, 23)
        Me.btnDestinationBack.TabIndex = 27
        Me.btnDestinationBack.Text = "<--"
        Me.btnDestinationBack.UseVisualStyleBackColor = True
        '
        'frmNewAccountManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 597)
        Me.Controls.Add(Me.grpUpload)
        Me.Controls.Add(Me.bntBack)
        Me.Controls.Add(Me.grpAccountDetails)
        Me.Controls.Add(Me.btnDeleteAccount)
        Me.Controls.Add(Me.bntSave)
        Me.Controls.Add(Me.btnAccountManager)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewAccountManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainMenu"
        Me.grpAccountDetails.ResumeLayout(False)
        Me.grpAccountDetails.PerformLayout()
        Me.pnlAccountNav.ResumeLayout(False)
        Me.pnlEnterDetails.ResumeLayout(False)
        Me.pnlEnterDetails.PerformLayout()
        Me.grpUpload.ResumeLayout(False)
        Me.grpUpload.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAccountManager As System.Windows.Forms.Button
    Friend WithEvents bntSave As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAccount As System.Windows.Forms.Button
    Friend WithEvents grpAccountDetails As System.Windows.Forms.GroupBox
    Friend WithEvents bntBack As System.Windows.Forms.Button
    Friend WithEvents pnlAccountNav As System.Windows.Forms.Panel
    Friend WithEvents btnPasswordReset As System.Windows.Forms.Button
    Friend WithEvents btnUploadFiles As System.Windows.Forms.Button
    Friend WithEvents bntDisplayAccountDetails As System.Windows.Forms.Button
    Friend WithEvents pnlEnterDetails As System.Windows.Forms.Panel
    Friend WithEvents lblNewAccountID As System.Windows.Forms.Label
    Friend WithEvents lblAccountID As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblStreetName As System.Windows.Forms.Label
    Friend WithEvents txtStreetName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblBuildingNumber As System.Windows.Forms.Label
    Friend WithEvents txtBuildingNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblLoadAccount As System.Windows.Forms.Label
    Friend WithEvents lstAccounts As System.Windows.Forms.ListBox
    Friend WithEvents grpUpload As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtDesDir As System.Windows.Forms.TextBox
    Friend WithEvents txtSourceDir As System.Windows.Forms.TextBox
    Friend WithEvents btnDestinationBack As System.Windows.Forms.Button
    Friend WithEvents btnSourceBack As System.Windows.Forms.Button
End Class
