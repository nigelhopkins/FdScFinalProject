Imports MySql.Data.MySqlClient
Imports System.Net

Public Class frmStockManager

    Dim img As String
    Dim con As New MySqlConnection
    Dim dbprovider As String
    Dim dbusername As String
    Dim dbpassword As String
    Dim dbtype As String
    Dim FileName As String
    Dim tempFileName As String
    Dim DelFileName As String

    Dim ds As New DataSet
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ID As Integer

    Public Sub ProductCode()

        MsgBox("Please enter a product code!")
        txtProductCode.SelectAll()
        txtProductCode.Focus()
        txtProductCode.BackColor = Color.Red
        txtProductCode.ForeColor = Color.White

    End Sub
    Public Sub Title()

        txtTitle.SelectAll()
        MsgBox("Please enter a product name!")
        txtTitle.Focus()
        txtTitle.BackColor = Color.Red
        txtTitle.ForeColor = Color.White

    End Sub
    Public Sub Price()

        txtPrice.SelectAll()
        MsgBox("Please enter a product price!")
        txtPrice.Focus()
        txtPrice.BackColor = Color.Red
        txtPrice.ForeColor = Color.White

    End Sub
    Public Sub Description()

        txtDescription.SelectAll()
        MsgBox("Please enter a product description!")
        txtDescription.Focus()
        txtDescription.BackColor = Color.Red
        txtDescription.ForeColor = Color.White

    End Sub
    Public Sub Image()

        MsgBox("Please select product picture!")
        bntPicture.Focus()
        bntPicture.BackColor = Color.Red
        bntPicture.ForeColor = Color.White

    End Sub

    'http://www.dotnetblogger.info/check-file-exists-ftp-server/

    Public Function IsFileExistsInFtpServer(ByVal sFilePath As String) As Boolean
        Dim fwr As FtpWebRequest = WebRequest.Create(sFilePath)
        Dim fRes As FtpWebResponse
        fwr.Credentials = New NetworkCredential("a3867008", "aa412lta")
        fwr.Method = WebRequestMethods.Ftp.GetFileSize
        Try
            fRes = fwr.GetResponse()
            'no error occured then the file is exists  
            Return True
        Catch ex As WebException
            fRes = ex.Response
            'Error occured then the file doesn't exists  
            If FtpStatusCode.ActionNotTakenFileUnavailable = fRes.StatusCode Then
                Return False
            Else
                'there might be other errors you need to handle here  
                'like server might be down; in that case you cannot tell that  
                'whether the file is exists or not  
                Return True
            End If
        End Try
    End Function

    Public Sub UploadPicture()

        'to copy file to local test directory
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\EasyPHP-DevServer-14.1VC11\data\localweb\projects\img\CartItems\" + FileName) Then
        Else
            FileCopy(SelectImg.FileName.ToString, "C:\Program Files (x86)\EasyPHP-DevServer-14.1VC11\data\localweb\projects\img\CartItems\" + FileName)
        End If
        
    End Sub
    Public Sub DeletePicture()

        If My.Computer.FileSystem.FileExists("C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\img\CartItems\" + DelFileName) Then
            Kill("C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\img\CartItems\" + DelFileName)
        End If

    End Sub
    Public Sub OpenConnection()

        dbprovider = "Host=localhost;"
        dbusername = "User=Owner;"
        dbpassword = "Password=S8h462NGcUJbNDSu;"
        dbtype = "Database=websitedevelopment"


        con.ConnectionString = dbprovider & dbusername & dbpassword & dbtype
        con.Open()

    End Sub

    Public Sub MembersTable()

        sql = "SELECT * FROM members "

    End Sub

    Public Sub Products()

        sql = "SELECT * FROM products"

    End Sub

    Public Sub CloseConnection()

        con.Close()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmMainMenu.MdiParent = MDIParent1
        frmMainMenu.Dock = DockStyle.Fill
        frmMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False

        lblStockID.Visible = True
        lblStockManager.Visible = True
        lblEdit.Visible = False
        lblAdd.Visible = True
        lblDelete.Visible = False

        txtDescription.Visible = True
        txtPrice.Visible = True
        txtTitle.Visible = True

        lstStockList.Visible = False
        grp1.Visible = True

        btnStockManager.Visible = True
        btnRemove.Visible = False
        btnSave.Visible = True

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False

        lblStockID.Visible = True
        lblStockManager.Visible = True
        lblEdit.Visible = True
        lblAdd.Visible = False
        lblDelete.Visible = False

        txtDescription.Visible = True
        txtPrice.Visible = True
        txtTitle.Visible = True

        lstStockList.Visible = True
        grp1.Visible = True

        btnStockManager.Visible = True
        btnRemove.Visible = False
        btnSave.Visible = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False

        lblStockID.Visible = True
        lblStockManager.Visible = True
        lblEdit.Visible = False
        lblAdd.Visible = False
        lblDelete.Visible = True

        txtDescription.Visible = True
        txtPrice.Visible = True
        txtTitle.Visible = True

        lstStockList.Visible = True
        grp1.Visible = True

        btnStockManager.Visible = True
        btnRemove.Visible = True
        btnSave.Visible = False


    End Sub

    Private Sub btnStockManager_Click(sender As Object, e As EventArgs) Handles btnStockManager.Click
        btnAdd.Visible = True
        btnEdit.Visible = True
        btnDelete.Visible = True

        txtProductCode.Text = ""
        txtDescription.Text = ""
        txtPrice.Text = ""
        txtTitle.Text = ""
        StockImg.ImageLocation = ""

        lblStockID.Visible = False
        lblStockManager.Visible = True
        lblEdit.Visible = False
        lblAdd.Visible = False
        lblDelete.Visible = False

        txtDescription.Visible = False
        txtPrice.Visible = False
        txtTitle.Visible = False

        lstStockList.Visible = False
        grp1.Visible = False

        btnStockManager.Visible = False
        btnRemove.Visible = False
        btnSave.Visible = False

    End Sub

    Private Sub bntPicture_Click(sender As Object, e As EventArgs) Handles bntPicture.Click

        SelectImg.Title = "Please select a photo"
        SelectImg.InitialDirectory = Environ$("USERPROFILE") & "\Pictures\"
        SelectImg.ShowDialog()
        FileName = SelectImg.SafeFileName
        StockImg.ImageLocation = SelectImg.FileName.ToString
        StockImg.Visible = True
        StockImg.SizeMode = PictureBoxSizeMode.Zoom
        SelectImg.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|All Files (*.*)|*.*"
        SelectImg.FilterIndex = 1
    End Sub
    Private Sub frmStockManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        Products()

        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "products")

        For Each row As DataRow In ds.Tables("products").Rows
            lstStockList.Items.Add(row.Item("product_name"))
        Next row

        CloseConnection()
    End Sub

    Private Sub lstStockList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStockList.SelectedIndexChanged

        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        If lstStockList.SelectedItem Is Nothing Then
            Return
        End If
        Dim Item As String = lstStockList.SelectedItem.ToString()
        OpenConnection()

        Try

            Dim Query As String
            Query = "SELECT * FROM products WHERE product_name='" & lstStockList.Text & "'"

            COMMAND = New MySqlCommand(Query, con)
            READER = COMMAND.ExecuteReader
            While READER.Read
                ID = READER.Item("id")
                txtProductCode.Text = READER.Item("product_code")
                txtTitle.Text = READER.Item("product_name")
                txtPrice.Text = READER.Item("price")
                txtDescription.Text = READER.Item("product_desc")
                StockImg.ImageLocation = "C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\img\CartItems\" & READER.Item("product_img_name")
                DelFileName = READER.Item("product_img_name")
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        CloseConnection()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If txtProductCode.Text = "" Then
            ProductCode()
        ElseIf txtTitle.Text = "" Then
            Title()
        ElseIf txtPrice.Text = "" Or Not IsNumeric(txtPrice.Text) Then
            Price()
        ElseIf txtDescription.Text = "" Then
            Description()
        ElseIf FileName = "" Then
            Image()
        ElseIf lstStockList.Items.Contains(txtTitle.Text) Then

            tempFileName = FileName

            Dim sql = "update products set product_code = @p2, product_name = @p3, product_desc = @p4, product_img_name = @p5, price = @p6 Where product_code = '" & txtProductCode.Text & "'"
            Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbtype)
                Using cmd = New MySqlCommand(sql, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p2", txtProductCode.Text)
                    cmd.Parameters.AddWithValue("@p3", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@p4", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@p5", FileName)
                    cmd.Parameters.AddWithValue("@p6", txtPrice.Text)
                    cmd.ExecuteNonQuery()
                End Using
                UploadPicture()

                MsgBox("Update Done")
            End Using
        Else
            dbprovider = "Host=localhost;"
            dbusername = "User=Owner;"
            dbpassword = "Password=S8h462NGcUJbNDSu;"
            dbtype = "Database=websitedevelopment"

            Dim sql = "INSERT INTO products(product_code, product_name, product_desc, product_img_name, price)" & _
                "VALUES(?,?,?,?,?)"
            Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbtype)
                Using cmd = New MySqlCommand(sql, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p2", txtProductCode.Text)
                    cmd.Parameters.AddWithValue("@p3", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@p4", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@p5", FileName)
                    cmd.Parameters.AddWithValue("@p6", txtPrice.Text)
                    cmd.ExecuteNonQuery()
                End Using
                UploadPicture()
                MsgBox("Item Saved")
                lstStockList.Items.Add(txtTitle.Text)
            End Using
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        OpenConnection()
        Dim sql = "DELETE FROM products Where product_code ='" & txtProductCode.Text & "'"
        Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbtype)
            Using cmd = New MySqlCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", txtProductCode.Text)
                cmd.ExecuteNonQuery()

            End Using
            DeletePicture()
            MsgBox("Delete Done")

            lstStockList.Items.Remove(txtTitle.Text)
            txtDescription.Text = ""
            txtPrice.Text = ""
            txtTitle.Text = ""
            txtProductCode.Text = ""
            StockImg.ImageLocation = ""
        End Using
        CloseConnection()
    End Sub

End Class