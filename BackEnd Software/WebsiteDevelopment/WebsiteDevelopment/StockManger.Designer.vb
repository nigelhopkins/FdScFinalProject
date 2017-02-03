<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockManager
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstStockList = New System.Windows.Forms.ListBox()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.StockImg = New System.Windows.Forms.PictureBox()
        Me.bntPicture = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.lblStockManager = New System.Windows.Forms.Label()
        Me.btnStockManager = New System.Windows.Forms.Button()
        Me.SelectImg = New System.Windows.Forms.OpenFileDialog()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grp1.SuspendLayout()
        CType(Me.StockImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.Location = New System.Drawing.Point(12, 214)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(234, 169)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New Item"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.Location = New System.Drawing.Point(319, 214)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(234, 169)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit Stock Item"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Location = New System.Drawing.Point(627, 214)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(234, 169)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Stock Items"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lstStockList
        '
        Me.lstStockList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstStockList.FormattingEnabled = True
        Me.lstStockList.Location = New System.Drawing.Point(12, 366)
        Me.lstStockList.Name = "lstStockList"
        Me.lstStockList.Size = New System.Drawing.Size(849, 134)
        Me.lstStockList.TabIndex = 4
        Me.lstStockList.Visible = False
        '
        'grp1
        '
        Me.grp1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grp1.Controls.Add(Me.txtProductCode)
        Me.grp1.Controls.Add(Me.StockImg)
        Me.grp1.Controls.Add(Me.bntPicture)
        Me.grp1.Controls.Add(Me.txtTitle)
        Me.grp1.Controls.Add(Me.txtPrice)
        Me.grp1.Controls.Add(Me.txtDescription)
        Me.grp1.Controls.Add(Me.Label4)
        Me.grp1.Controls.Add(Me.Label3)
        Me.grp1.Controls.Add(Me.lblName)
        Me.grp1.Controls.Add(Me.lblStockID)
        Me.grp1.Location = New System.Drawing.Point(12, 138)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(848, 217)
        Me.grp1.TabIndex = 5
        Me.grp1.TabStop = False
        Me.grp1.Visible = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(70, 14)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(100, 20)
        Me.txtProductCode.TabIndex = 1
        '
        'StockImg
        '
        Me.StockImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StockImg.Location = New System.Drawing.Point(607, 16)
        Me.StockImg.Name = "StockImg"
        Me.StockImg.Size = New System.Drawing.Size(226, 152)
        Me.StockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StockImg.TabIndex = 9
        Me.StockImg.TabStop = False
        '
        'bntPicture
        '
        Me.bntPicture.Location = New System.Drawing.Point(607, 174)
        Me.bntPicture.Name = "bntPicture"
        Me.bntPicture.Size = New System.Drawing.Size(227, 36)
        Me.bntPicture.TabIndex = 5
        Me.bntPicture.Text = "Select Image"
        Me.bntPicture.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTitle.Location = New System.Drawing.Point(70, 57)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(156, 20)
        Me.txtTitle.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.Location = New System.Drawing.Point(70, 97)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(156, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescription.Location = New System.Drawing.Point(70, 141)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(475, 70)
        Me.txtDescription.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price :"
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Title :"
        '
        'lblStockID
        '
        Me.lblStockID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Location = New System.Drawing.Point(6, 16)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(55, 13)
        Me.lblStockID.TabIndex = 0
        Me.lblStockID.Text = "Stock ID :"
        '
        'lblStockManager
        '
        Me.lblStockManager.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStockManager.AutoSize = True
        Me.lblStockManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.25!)
        Me.lblStockManager.Location = New System.Drawing.Point(202, 28)
        Me.lblStockManager.Name = "lblStockManager"
        Me.lblStockManager.Size = New System.Drawing.Size(468, 74)
        Me.lblStockManager.TabIndex = 6
        Me.lblStockManager.Text = "Stock Manager"
        '
        'btnStockManager
        '
        Me.btnStockManager.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStockManager.Location = New System.Drawing.Point(561, 514)
        Me.btnStockManager.Name = "btnStockManager"
        Me.btnStockManager.Size = New System.Drawing.Size(147, 71)
        Me.btnStockManager.TabIndex = 7
        Me.btnStockManager.Text = "Stock Manager"
        Me.btnStockManager.UseVisualStyleBackColor = True
        Me.btnStockManager.Visible = False
        '
        'SelectImg
        '
        Me.SelectImg.FileName = "OpenFileDialog1"
        '
        'lblEdit
        '
        Me.lblEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(409, 102)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(55, 29)
        Me.lblEdit.TabIndex = 8
        Me.lblEdit.Text = "Edit"
        Me.lblEdit.Visible = False
        '
        'lblAdd
        '
        Me.lblAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(409, 102)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(56, 29)
        Me.lblAdd.TabIndex = 9
        Me.lblAdd.Text = "Add"
        Me.lblAdd.Visible = False
        '
        'lblDelete
        '
        Me.lblDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDelete.AutoSize = True
        Me.lblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.Location = New System.Drawing.Point(394, 102)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(84, 29)
        Me.lblDelete.TabIndex = 10
        Me.lblDelete.Text = "Delete"
        Me.lblDelete.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Location = New System.Drawing.Point(410, 514)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(147, 71)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemove.Location = New System.Drawing.Point(257, 514)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(147, 71)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "Delete Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'frmStockManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 597)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.btnStockManager)
        Me.Controls.Add(Me.lblStockManager)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lstStockList)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Manager"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.StockImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lstStockList As System.Windows.Forms.ListBox
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStockID As System.Windows.Forms.Label
    Friend WithEvents lblStockManager As System.Windows.Forms.Label
    Friend WithEvents btnStockManager As System.Windows.Forms.Button
    Friend WithEvents StockImg As System.Windows.Forms.PictureBox
    Friend WithEvents bntPicture As System.Windows.Forms.Button
    Friend WithEvents SelectImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblEdit As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblDelete As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
End Class
