<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStockManger = New System.Windows.Forms.Button()
        Me.btnAccountManger = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.Location = New System.Drawing.Point(714, 514)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(147, 71)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnStockManger
        '
        Me.btnStockManger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStockManger.Location = New System.Drawing.Point(131, 214)
        Me.btnStockManger.Name = "btnStockManger"
        Me.btnStockManger.Size = New System.Drawing.Size(234, 169)
        Me.btnStockManger.TabIndex = 0
        Me.btnStockManger.Text = "Stock Manager"
        Me.btnStockManger.UseVisualStyleBackColor = True
        '
        'btnAccountManger
        '
        Me.btnAccountManger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAccountManger.Location = New System.Drawing.Point(508, 214)
        Me.btnAccountManger.Name = "btnAccountManger"
        Me.btnAccountManger.Size = New System.Drawing.Size(234, 169)
        Me.btnAccountManger.TabIndex = 1
        Me.btnAccountManger.Text = "Account Manager"
        Me.btnAccountManger.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(733, 59)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Website Development Manager"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 597)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAccountManger)
        Me.Controls.Add(Me.btnStockManger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnStockManger As System.Windows.Forms.Button
    Friend WithEvents btnAccountManger As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
