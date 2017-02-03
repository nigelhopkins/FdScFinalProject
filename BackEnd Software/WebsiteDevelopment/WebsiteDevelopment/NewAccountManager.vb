Imports System.Windows.Forms
Imports System.Security
Imports System.Text
Imports System.Security.Cryptography.SHA512Managed
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class frmNewAccountManager



    Dim ds As New DataSet
    Dim sql As String
    Dim da As IDataAdapter
    Dim con As New MySqlConnection
    Dim dbprovider As String
    Dim dbusername As String
    Dim dbpassword As String
    Dim dbType As String
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim username As String
    Dim pin As String
    Dim ID As Integer
    Dim FirstName As String
    Dim LastName As String
    Dim AccountDetails As String
    Public NewWindows As String
    Dim SetupType As String

    Public Sub CreateDirectory()
        Dim defaultPath As String = "C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\parts\UserArea\master\"
        Dim FolderName As String = txtFirstName.Text & txtLastName.Text
        Dim path As String = "C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\parts\UserArea" & "\" & txtFirstName.Text & txtLastName.Text

        If Directory.Exists(path) Then
            MsgBox("Directory already exists")
        Else
            Directory.CreateDirectory(path)
            Directory.CreateDirectory(path + "\img")
            FileCopy(defaultPath + "index.php", "C:\Program Files (x86)\EasyPHP-DevServer-14.1VC11\data\localweb\projects\parts\UserArea\" & FolderName & "\index.php")
        End If
    End Sub

    Public Sub DeleteDirectory()

        Dim path As String = "C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\parts\UserArea\" & txtFirstName.Text & txtLastName.Text & "\"



        If Directory.Exists(path) Then
            System.IO.Directory.Delete(path, True)
        Else
            MsgBox("No directory found")
        End If
    End Sub


    Public Sub SendDetails()

        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("nhwebsitedevelopment@gmail.com", "Website Development")
            EmailMessage.To.Add(txtEmail.Text)
            EmailMessage.Subject = "Please complete Website development registration!"
            EmailMessage.IsBodyHtml = True
            EmailMessage.Body = "Hi & txtFirstName.Text & " & txtLastName.Text & "<br>" & "<br>" & _
                                "Email Address :" & txtEmail.Text & _
                                "<p> Pin Number :" & pin & "</p>" & _
                                SetupType & _
                                "<p> Inorder to login into your account you will need to set a password. To do this please click the link below and use the email address used to register and the pin number show at the top o this email" & _
                                "please follow the link below to set your password. </p>" & _
                                "<p>" & "http://127.0.0.1:8081/projects/register.php" & "</p>" & _
                                "<p>Kind Regards</p>" & _
                                "N Hopkins"
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("nhwebsitedevelopment@gmail.com", "aa412lta")
            SMTP.Send(EmailMessage)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PinNumber()
        Dim number As Integer
        number = (Int(999999 / Rnd()))
        pin = number.ToString
    End Sub
    Public Sub ChangePin()

        PinNumber()

        Dim sql = "update members set Pin = @p15 Where id = '" & ID & "' & username = '" & username & "'"
        Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbType)
            Using cmd = New MySqlCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p15", pin)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Update Done")
        End Using

    End Sub




    Public Sub ConnectionDeatails()

        dbprovider = "Host=localhost;"
        dbusername = "User=Owner;"
        dbpassword = "Password=S8h462NGcUJbNDSu;"
        dbType = "Database=websitedevelopment"

    End Sub

    Public Sub OpenConnection()

        ConnectionDeatails()

        con.ConnectionString = dbprovider & dbusername & dbpassword & dbType
        con.Open()

    End Sub

    Public Sub CloseConnection()
        con.Close()
    End Sub

    Public Sub ReadFromDatbase()
        OpenConnection()
        Try
            Dim Query As String
            Query = "SELECT * FROM members WHERE id = '" & lblNewAccountID.Text & "' & username ='" & txtEmail.Text & "'"
            COMMAND = New MySqlCommand(Query, con)
            READER = COMMAND.ExecuteReader
            While READER.Read
                ID = READER.Item("id")
                lblNewAccountID.Text = READER.Item("id")
                txtCompanyName.Text = READER.Item("CompanyName")
                txtFirstName.Text = READER.Item("FirstName")
                txtLastName.Text = READER.Item("LastName")
                txtEmail.Text = READER.Item("email")
                txtPhoneNumber.Text = READER.Item("PhoneNumber")
                txtBuildingNumber.Text = READER.Item("BuildingNumber")
                txtStreetName.Text = READER.Item("StreetName")
                txtCity.Text = READER.Item("City")
                txtCounty.Text = READER.Item("County")
                txtPostalCode.Text = READER.Item("PostalCode")
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Public Sub SaveToDatabase()
        Dim sql = "INSERT INTO members(username, email, CompanyName, FirstName, LastName, PhoneNumber, BuildingNumber, StreetName, City, County, PostalCode, pin)" & _
            "VALUES(?,?,?,?,?,?,?,?,?,?,?, ?)"
        Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbType)
            Using cmd = New MySqlCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p2", username)
                cmd.Parameters.AddWithValue("@p3", txtEmail.Text)
                cmd.Parameters.AddWithValue("@p6", txtCompanyName.Text)
                cmd.Parameters.AddWithValue("@p7", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@p8", txtLastName.Text)
                cmd.Parameters.AddWithValue("@p9", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@p10", txtBuildingNumber.Text)
                cmd.Parameters.AddWithValue("@p11", txtStreetName.Text)
                cmd.Parameters.AddWithValue("@p12", txtCity.Text)
                cmd.Parameters.AddWithValue("@p13", txtCounty.Text)
                cmd.Parameters.AddWithValue("@p14", txtPostalCode.Text)
                cmd.Parameters.AddWithValue("@p15", pin)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        CloseConnection()
    End Sub
    Public Sub UpdateDatabase()
        Dim sql = "update members set username = @p2, email = @p3, CompanyName = @p6, FirstName = @p7, LastName = @p8, PhoneNumber = @p9, BuildingNumber = @p10, StreetName = @p11, City = @p12, County = @p13, PostalCode = @p14 Where id = '" & ID & "' & username = '" & username & "'"
        Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbType)
            Using cmd = New MySqlCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p2", username)
                cmd.Parameters.AddWithValue("@p3", txtEmail.Text)
                cmd.Parameters.AddWithValue("@p6", txtCompanyName.Text)
                cmd.Parameters.AddWithValue("@p7", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@p8", txtLastName.Text)
                cmd.Parameters.AddWithValue("@p9", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@p10", txtBuildingNumber.Text)
                cmd.Parameters.AddWithValue("@p11", txtStreetName.Text)
                cmd.Parameters.AddWithValue("@p12", txtCity.Text)
                cmd.Parameters.AddWithValue("@p13", txtCounty.Text)
                cmd.Parameters.AddWithValue("@p14", txtPostalCode.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Update Done")
        End Using

        Dim Query As String
        Query = "SELECT * FROM members WHERE FirstName = '" & txtFirstName.Text & "' & LastName ='" & txtLastName.Text & "'"
        COMMAND = New MySqlCommand(Query, con)
        READER = COMMAND.ExecuteReader
        While READER.Read
            ID = READER.Item("id")
            FirstName = READER.Item("FirstName")
            LastName = READER.Item("LastName")
        End While
        AccountDetails = ID & " : " & FirstName & " " & LastName

        CloseConnection()

    End Sub
    Public Sub DeleteFromDatabase()

        Dim sql = "DELETE FROM members WHERE id ='" & lblNewAccountID.Text & "'"
        Using con = New MySqlConnection(dbprovider & dbusername & dbpassword & dbType)
            Using cmd = New MySqlCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", lblNewAccountID.Text)
                cmd.ExecuteNonQuery()

            End Using

        End Using
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmMainMenu.MdiParent = MDIParent1
        frmMainMenu.Dock = DockStyle.Fill
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmAccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If NewWindows = "NewAccount" Then

            bntSave.Visible = True
            grpAccountDetails.Visible = True
            lstAccounts.Visible = False
            grpAccountDetails.Text = NewWindows
            pnlEnterDetails.Location = New Point(79, 100)

        ElseIf NewWindows = "DeleteAccount" Then

            bntSave.Visible = True
            btnDeleteAccount.Visible = True
            grpAccountDetails.Visible = True
            grpAccountDetails.Text = NewWindows
            lstAccounts.Visible = True
        ElseIf NewWindows = "AccountLookup" Then

            grpAccountDetails.Text = NewWindows
            bntSave.Visible = True
            grpAccountDetails.Visible = True
            lstAccounts.Visible = True
            pnlEnterDetails.Visible = False

        End If

        OpenConnection()
        sql = "SELECT * FROM members"

        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "members")

        For Each row As DataRow In ds.Tables("members").Rows
            ID = row.Item("id")
            FirstName = row.Item("FirstName")
            LastName = row.Item("LastName")
            AccountDetails = ID & " : " & FirstName & " " & LastName
            lstAccounts.Items.Add(AccountDetails)
        Next row

        CloseConnection()

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

        OpenConnection()
        username = txtEmail.Text
        SetupType = "<p>Your new account has been setup</p>"
        PinNumber()
        SaveToDatabase()
        CreateDirectory()
        SendDetails()
        MsgBox("Pin : " + pin + vbCrLf + "Username : " + username & vbCrLf & "Item Saved")
        CloseConnection()

        frmAccountManager.MdiParent = MDIParent1
        frmAccountManager.Dock = DockStyle.Fill
        frmAccountManager.Show()
        Me.Close()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs)
        username = txtEmail.Text
    End Sub

    Private Sub lstAccounts_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstAccounts.SelectedIndexChanged
        If lstAccounts.SelectedItem Is Nothing Then
            Return
        End If
        Dim Item As String = lstAccounts.SelectedItem.ToString

        OpenConnection()

        Dim Query As String
        Query = "SELECT * FROM members WHERE id = '" & lstAccounts.Text & "'"
        COMMAND = New MySqlCommand(Query, con)
        READER = COMMAND.ExecuteReader
        While READER.Read
            ID = READER.Item("id")
            lblNewAccountID.Text = READER.Item("id")
            txtCompanyName.Text = READER.Item("CompanyName")
            txtFirstName.Text = READER.Item("FirstName")
            txtLastName.Text = READER.Item("LastName")
            txtEmail.Text = READER.Item("email")
            txtPhoneNumber.Text = READER.Item("PhoneNumber")
            txtBuildingNumber.Text = READER.Item("BuildingNumber")
            txtStreetName.Text = READER.Item("StreetName")
            txtCity.Text = READER.Item("City")
            txtCounty.Text = READER.Item("County")
            txtPostalCode.Text = READER.Item("PostalCode")
            pin = READER.Item("Pin")
        End While

        CloseConnection()

    End Sub

    Private Sub btnAccountManager_Click(sender As Object, e As EventArgs) Handles btnAccountManager.Click

        frmAccountManager.MdiParent = MDIParent1
        frmAccountManager.Dock = DockStyle.Fill
        frmAccountManager.Show()
        Me.Close()

    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click

        OpenConnection()
        DeleteFromDatabase()
        CloseConnection()
        DeleteDirectory()
        MsgBox("Delete Done")
        lblNewAccountID.Text = " "
        txtFirstName.Text = " "
        txtLastName.Text = " "
        txtEmail.Text = " "
        txtPhoneNumber.Text = " "
        txtCompanyName.Text = " "
        txtBuildingNumber.Text = " "
        txtStreetName.Text = " "
        txtCity.Text = " "
        txtCounty.Text = " "
        txtPostalCode.Text = " "

        frmAccountManager.MdiParent = MDIParent1
        frmAccountManager.Dock = DockStyle.Fill
        frmAccountManager.Show()
        Me.Close()
    End Sub

    Private Sub bntDisplayAccountDetails_Click(sender As Object, e As EventArgs) Handles bntDisplayAccountDetails.Click


        If lstAccounts.SelectedItems.Count < 1 Then
            MsgBox("No user selected!")
        Else
            pnlEnterDetails.Visible = True
            pnlAccountNav.Visible = False
            bntBack.Visible = True

        End If



    End Sub

    Private Sub btnPannelNav_Click(sender As Object, e As EventArgs)

        pnlAccountNav.Visible = True

    End Sub

    
    Private Sub bntBack_Click(sender As Object, e As EventArgs) Handles bntBack.Click

        grpUpload.Visible = False
        pnlAccountNav.Visible = True

    End Sub

    Private Sub CmbLoaclDirectories_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        txtSourceDir.Text = WebBrowser1.Url.AbsolutePath
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        txtDesDir.Text = WebBrowser2.Url.AbsolutePath
    End Sub

    Private Sub btnUploadFiles_Click(sender As Object, e As EventArgs) Handles btnUploadFiles.Click

        WebBrowser1.Navigate("C:\PROGRA~2\EASYPH~1.1VC\data\localweb\projects\parts\UserArea\" & txtFirstName.Text & txtLastName.Text)

        WebBrowser2.Navigate(Environ$("USERPROFILE"))

        If lstAccounts.SelectedItems.Count < 1 Then
            MsgBox("No user selected!")
        Else
            grpUpload.Visible = True
            pnlEnterDetails.Visible = False
            pnlAccountNav.Visible = False
            bntBack.Visible = True

        End If
    End Sub

    Private Sub btnSourceBack_Click(sender As Object, e As EventArgs) Handles btnSourceBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnDestinationBack_Click(sender As Object, e As EventArgs) Handles btnDestinationBack.Click
        WebBrowser2.GoBack()
    End Sub

    Private Sub btnPasswordReset_Click(sender As Object, e As EventArgs) Handles btnPasswordReset.Click

        SetupType = "<p>Your password has been reset</p>"
        username = txtEmail.Text
        ChangePin()
        SendDetails()
        MsgBox("Email : " & txtEmail.Text & vbCrLf & "Pin : " & pin & vbCrLf & "Details has been sent!")
    End Sub
End Class