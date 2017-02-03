<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountManager
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
        Me.btnNewAccount = New System.Windows.Forms.Button()
        Me.btnDelAccount = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAccountLookup = New System.Windows.Forms.Button()
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
        'btnNewAccount
        '
        Me.btnNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNewAccount.Location = New System.Drawing.Point(12, 214)
        Me.btnNewAccount.Name = "btnNewAccount"
        Me.btnNewAccount.Size = New System.Drawing.Size(234, 169)
        Me.btnNewAccount.TabIndex = 0
        Me.btnNewAccount.Text = "New Account"
        Me.btnNewAccount.UseVisualStyleBackColor = True
        '
        'btnDelAccount
        '
        Me.btnDelAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelAccount.Location = New System.Drawing.Point(319, 214)
        Me.btnDelAccount.Name = "btnDelAccount"
        Me.btnDelAccount.Size = New System.Drawing.Size(234, 169)
        Me.btnDelAccount.TabIndex = 1
        Me.btnDelAccount.Text = "Delete Account"
        Me.btnDelAccount.UseVisualStyleBackColor = True
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
        'btnAccountLookup
        '
        Me.btnAccountLookup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAccountLookup.Location = New System.Drawing.Point(627, 214)
        Me.btnAccountLookup.Name = "btnAccountLookup"
        Me.btnAccountLookup.Size = New System.Drawing.Size(234, 169)
        Me.btnAccountLookup.TabIndex = 2
        Me.btnAccountLookup.Text = "Account Lookup"
        Me.btnAccountLookup.UseVisualStyleBackColor = True
        '
        'frmAccountManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 597)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnAccountLookup)
        Me.Controls.Add(Me.btnDelAccount)
        Me.Controls.Add(Me.btnNewAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnNewAccount As System.Windows.Forms.Button
    Friend WithEvents btnDelAccount As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAccountLookup As System.Windows.Forms.Button
End Class
