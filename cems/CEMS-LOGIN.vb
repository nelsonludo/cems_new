Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports cems.Simple3Des
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Resources
Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security.AccessControl
Imports System.IO

Public Class Form1
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTable As New DataTable
    Dim sqlDataAdaptor As New MySqlDataAdapter
    Dim sqlQuery As String

    Public server As String
    Public username As String
    Public password As String
    Public database As String

    Dim User As New users
    Dim admin As New admin

    Public user_email As String
    Public apacheProcess As New ProcessStartInfo("C:\xampp\apache\bin\httpd.exe")

    Public mysqlProcess As New ProcessStartInfo("C:\xampp\mysql\bin\mysqld.exe")


    'the resourcemanager as it name says helps to manage the resources. In our case these are the translation files found in the language folder 
    Private resourceManager As New ResourceManager("cems.Resources", GetType(Form1).Assembly)

    Dim isFrench As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'this is to start apache server 

        'this is avoid that command line, which appears when the httpd.exe is run (just as in xampp)
        apacheProcess.CreateNoWindow = True
        apacheProcess.UseShellExecute = False

        Process.Start(apacheProcess)

        ' Start mysql
        mysqlProcess.CreateNoWindow = True
        mysqlProcess.UseShellExecute = False
        Process.Start(mysqlProcess)


        TranslateFormControlsFrench(Me)


        'Dim FILE_PATH As String = "C:\cems"

        Dim FILE_NAME As String = "connectionString.txt"

        Dim appDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

        Dim connexionStringDirectory As String = appDir & "\" & FILE_NAME

        Dim uriPath As String = connexionStringDirectory
        Dim localPath As String = New Uri(uriPath).LocalPath


        Dim applicationFolder As String = AppDomain.CurrentDomain.BaseDirectory

        ' Get the current user
        Dim currentUser As String = Environment.UserName

        ' Create a DirectoryInfo object for the application folder
        Dim directoryInfo As New DirectoryInfo(applicationFolder)

        ' Get the DirectorySecurity object for the application folder
        Dim directorySecurity As DirectorySecurity = directoryInfo.GetAccessControl()

        ' Add an access rule to grant full control to the current user
        directorySecurity.AddAccessRule(New FileSystemAccessRule(currentUser, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))

        ' Apply the modified DirectorySecurity to the application folder
        directoryInfo.SetAccessControl(directorySecurity)


        Dim wrapper As New Simple3Des("")

        Dim test As Boolean = False

        emailtxt.Text = ""
        passwordtxt.Text = ""



        If System.IO.File.Exists(localPath) = True Then


            FileOpen(1, localPath, OpenMode.Input)

            While Not EOF(1)
                server = wrapper.DecryptData(LineInput(1))
                username = wrapper.DecryptData(LineInput(1))
                password = wrapper.DecryptData(LineInput(1))
                database = wrapper.DecryptData(LineInput(1))
            End While


            FileClose(1)


            If server <> "" Or username <> "" Or database <> "" Then

                Try
                    connect_db(server, username, password, database)

                    sqlConn.Open()
                    sqlConn.Close()
                Catch ex As Exception
                    'MessageBox.Show(ex.Message, "MySql connexion string", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    test = True
                End Try

                If test Then


                    If isFrench Then
                        connexionErrorMsg.Text = My.Resources.resourcesEnText.InvalidConnectionString

                    Else
                        connexionErrorMsg.Text = My.Resources.resourcesFrText.InvalidConnectionString

                    End If
                    connexionErrorMsg.Visible = True
                    Timer1.Interval = 3000
                    Timer1.Start()

                Else


                    'creating first admin
                    connect_db(server, username, password, database)

                    Dim checkTables As Integer = 0
                    Dim checkuser As Integer = 0

                    Try
                        sqlConn.Open()

                        sqlQuery = "select count(*) from information_schema.tables where table_name = 'cems_users'"


                        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                        sqlReader = sqlCmd.ExecuteReader
                        While (sqlReader.Read())
                            checkTables = sqlReader.Item("count(*)")
                        End While
                        sqlConn.Close()


                        If checkTables > 0 Then
                            sqlConn.Open()

                            sqlQuery = "select count(*) from cems_users"


                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            While (sqlReader.Read())
                                checkuser = sqlReader.Item("count(*)")
                            End While
                            sqlConn.Close()

                            If checkuser > 0 Then
                                connexionStringPanel.Visible = False
                                userAddPanel.Visible = False
                                loginPanel.Visible = True
                            Else
                                connexionStringPanel.Visible = False
                                userAddPanel.Visible = True


                            End If



                        Else
                            'create all tables


                            Try
                                sqlConn.Open()

                                longestQuery()

                                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                                sqlReader = sqlCmd.ExecuteReader

                                sqlConn.Close()

                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "MySql create all tables", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Finally
                                sqlConn.Dispose()

                            End Try


                            userAddPanel.Visible = True
                            connexionStringPanel.Visible = False


                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "MySql counting all the tables to see if there are any", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        sqlConn.Dispose()

                    End Try


                End If

            End If


        Else


            System.IO.File.Create(localPath)
            System.IO.File.SetAttributes(localPath, System.IO.FileAttributes.Hidden) 'FILE_PATH, System.IO.FileAttributes.Hidden)


        End If
    End Sub



    'this is a recurcive function that loops through all the controls(mostly labels and buttons) in the form and translates them to english as set in the resourceEnText.resx file
    Private Sub TranslateFormControlsEnglish(ByVal control As Control)
        For Each childControl As Control In control.Controls
            If TypeOf childControl Is Button OrElse TypeOf childControl Is Label OrElse TypeOf childControl Is TextBox Then
                Dim resourceName As String = childControl.Name
                Dim translatedText As String = My.Resources.resourcesEnText.ResourceManager.GetString(resourceName)
                If Not String.IsNullOrEmpty(translatedText) Then
                    childControl.Text = translatedText
                End If
            End If

            ' Recursively translate child controls
            TranslateFormControlsEnglish(childControl)
        Next

        isFrench = False
    End Sub

    'this is a recurcive function that loops through all the controls(mostly labels and buttons) in the form and translates them to french as set in the resourceFrText.resx file
    Private Sub TranslateFormControlsFrench(ByVal control As Control)
        For Each childControl As Control In control.Controls
            If TypeOf childControl Is Button OrElse TypeOf childControl Is Label OrElse TypeOf childControl Is TextBox Then
                Dim resourceName As String = childControl.Name
                Dim translatedText As String = My.Resources.resourcesFrText.ResourceManager.GetString(resourceName)
                If Not String.IsNullOrEmpty(translatedText) Then
                    childControl.Text = translatedText
                End If
            End If

            ' Recursively translate child controls
            TranslateFormControlsFrench(childControl)
        Next

        isFrench = True
    End Sub



    'translation buttons 
    Private Sub FrenchButton_Click(sender As Object, e As EventArgs) Handles frenchBtn.Click
        frenchBtn.Visible = False
        englishBtn.Visible = True

        TranslateFormControlsFrench(Me)



    End Sub

    Private Sub EnglishButton_Click(sender As Object, e As EventArgs) Handles englishBtn.Click

        frenchBtn.Visible = True
        englishBtn.Visible = False

        TranslateFormControlsEnglish(Me)

    End Sub


    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click

        server = connexionStringServer.Text
        username = connexionStringUserName.Text
        password = connexionStringPwd.Text
        database = connexionStringDatabase.Text

        Dim defaultdatabase As String = "mysql"

        Dim test As Boolean = False

        If server = "" Or username = "" Or database = "" Then

            If isFrench Then
                connexionErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            Else
                connexionErrorMsg.Text = My.Resources.resourcesFrText.EmptyField

            End If

            connexionErrorMsg.Visible = True
            Timer1.Interval = 3000
            Timer1.Start()
        Else

            Try
                connect_db(server, username, password, defaultdatabase)

                sqlQuery = "create database " & database & ""


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql create first database string", MessageBoxButtons.OK, MessageBoxIcon.Information)
                test = True
            End Try

            If test Then


                If isFrench Then
                    connexionErrorMsg.Text = My.Resources.resourcesEnText.InvalidConnectionString

                Else
                    connexionErrorMsg.Text = My.Resources.resourcesFrText.InvalidConnectionString

                End If
                connexionErrorMsg.Visible = True
                Timer1.Interval = 3000
                Timer1.Start()
            Else
                Dim wrapper As New Simple3Des("")

                Dim serverEncr As String = wrapper.EncryptData(server)
                Dim userNameEncr As String = wrapper.EncryptData(username)
                Dim pwdEncr As String = wrapper.EncryptData(password)
                Dim databaseEncr As String = wrapper.EncryptData(database)

                Dim FILE_PATH As String = "C:\cems"

                Dim FILE_NAME As String = "connectionString.txt"

                Dim appDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

                Dim connexionStringDirectory As String = appDir & "\" & FILE_NAME

                Dim uriPath As String = connexionStringDirectory
                Dim localPath As String = New Uri(uriPath).LocalPath


                FileOpen(1, localPath, OpenMode.Append) 'FILE_PATH, OpenMode.append)

                PrintLine(1, serverEncr)
                PrintLine(1, userNameEncr)
                PrintLine(1, pwdEncr)
                PrintLine(1, databaseEncr)

                FileClose(1)

                FileOpen(1, localPath, OpenMode.Input) 'FILE_PATH, OpenMode.Input)

                While Not EOF(1)
                    server = wrapper.DecryptData(LineInput(1))
                    username = wrapper.DecryptData(LineInput(1))
                    password = wrapper.DecryptData(LineInput(1))
                    database = wrapper.DecryptData(LineInput(1))
                End While

                FileClose(1)


                'creating first admin
                connect_db(server, username, password, database)

                Dim checkTables As Integer = 0
                Dim checkUser As Integer = 0

                Try
                    sqlConn.Open()

                    sqlQuery = "select count(*) from information_schema.tables where table_name = 'cems_users'"


                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                        checkTables = sqlReader.Item("count(*)")
                    End While
                    sqlConn.Close()


                    If checkTables > 0 Then
                        sqlConn.Open()

                        sqlQuery = "select count(*) from cems_users"


                        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                        sqlReader = sqlCmd.ExecuteReader
                        While (sqlReader.Read())
                            checkUser = sqlReader.Item("count(*)")
                        End While
                        sqlConn.Close()

                        If checkUser > 0 Then
                            connexionStringPanel.Visible = False
                            userAddPanel.Visible = False
                            loginPanel.Visible = True
                        Else
                            connexionStringPanel.Visible = False
                            userAddPanel.Visible = True
                        End If


                    Else
                        'create all tables

                        userAddPanel.Visible = True
                        connexionStringPanel.Visible = False


                        Try
                            sqlConn.Open()

                            longestQuery()

                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader

                            sqlConn.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "MySql create all tables", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Finally
                            sqlConn.Dispose()

                        End Try


                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql counting all the tables to see if there are any", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()

                End Try


            End If


        End If


    End Sub


    Public Sub connect_db(serverC As String, usernameC As String, passwordC As String, databaseC As String)


        If sqlConn.State = ConnectionState.Closed Then

            sqlConn.ConnectionString = "server =" + serverC + ";" + "user id =" + usernameC + ";" + "password=" + passwordC + ";" + "database =" + databaseC

        End If

    End Sub




    Private Sub userAddValidateBtn_Click(sender As Object, e As EventArgs) Handles userAddValidationBtn.Click 'validate add

        connect_db(server, username, password, database)

        If userUserAddNameInput.Text = "" Or userUserAddEmailInput.Text = "" Or userUserAddPhoneInput.Text = "" Or userUserAddConfirmPwdInput.Text = "" Then

            If isFrench Then
                addUserErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            Else
                addUserErrorMsg.Text = My.Resources.resourcesFrText.EmptyField

            End If

            addUserErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else




            If userUserAddPwdInput.Text <> userUserAddConfirmPwdInput.Text Then
                addUserErrorMsg.Visible = True
                If isFrench Then
                    addUserErrorMsg.Text = My.Resources.resourcesEnText.PwdNotMatch

                Else
                    addUserErrorMsg.Text = My.Resources.resourcesFrText.PwdNotMatch

                End If


                Timer2.Interval = 3000
                Timer2.Start()
            Else
                Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(userUserAddConfirmPwdInput.Text)


                Try
                    sqlConn.Open()
                    sqlQuery = "insert into " & database & ".cems_users(user_name, user_email, user_phone_number, user_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & hashedPassword & "','admin')"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this changes the content of confirmMsg
                    forgotPasswordMessage.ForeColor = Color.Green


                    If isFrench Then
                        forgotPasswordMessage.Text = My.Resources.resourcesEnText.LoginSuccess

                    Else
                        forgotPasswordMessage.Text = My.Resources.resourcesFrText.LoginSuccess

                    End If


                    'this makes the confirm message appear for 3secs
                    forgotPasswordMessage.Visible = True
                    Timer2.Interval = 5000
                    Timer2.Start()


                    'this makes the add panel to disappear
                    userAddPanel.Visible = False
                    loginPanel.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql create first user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            End If

        End If
    End Sub


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick 'this stops the timer and make the messages disappear

        addUserErrorMsg.Visible = False
        forgotPasswordMessage.Visible = False


        Timer2.Stop()
    End Sub

    'password placeholder
    'Private Sub passwordtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.GotFocus
    '    If passwordtxt.Text = "password" Then
    '        passwordtxt.Text = ""
    '    End If
    'End Sub
    'Private Sub passwordtxt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.LostFocus
    '    If passwordtxt.Text = "" Then
    '        passwordtxt.Text = "password"
    '    End If
    'End Sub
    '
    ''password placeholder
    'Private Sub emailtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtxt.GotFocus
    '    If emailtxt.Text = "email" Then
    '        emailtxt.Text = ""
    '    End If
    'End Sub
    'Private Sub emailtxt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtxt.LostFocus
    '    If emailtxt.Text = "" Then
    '        emailtxt.Text = "email"
    '    End If
    'End Sub


    Private Sub login_Click(sender As Object, e As EventArgs) Handles loginBtn.Click


        Dim userLogin As Boolean


        'set the value of the email textbox to the user_email variable of the user class for test in the user login method
        User.user_email = emailtxt.Text

        IsValidEmail(emailtxt.Text)

        If Not IsValidEmail(emailtxt.Text) Then
            If isFrench Then
                forgotPasswordMessage.Text = My.Resources.resourcesEnText.invalidEmail

            Else
                forgotPasswordMessage.Text = My.Resources.resourcesFrText.invalidEmail

            End If
            forgotPasswordMessage.Visible = True
            Timer1.Interval = 3000
            Timer1.Start()
        Else


            userLogin = User.login(passwordtxt.Text, User.user_email, forgotPasswordMessage, Timer1)

        End If

        If userLogin Then
            user_email = emailtxt.Text
        End If


    End Sub

    Private Sub userUserAddConfirmPwdInput_TextChanged(sender As Object, e As KeyEventArgs) Handles userUserAddConfirmPwdInput.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            login_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub
    Private Sub connexionStringDatabase_TextChanged(sender As Object, e As KeyEventArgs) Handles connexionStringDatabase.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            login_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub
    Private Sub passwordtxt_TextChanged(sender As Object, e As KeyEventArgs) Handles passwordtxt.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            login_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub

    Private Sub forgotPasswordBtn_Click(sender As Object, e As EventArgs) Handles forgotPwdBtn.Click
        Dim admin_email As String = ""
        Dim admin_phone_number As String = ""

        connect_db(server, username, password, database)
        Try
            sqlConn.Open()
            'check user info
            sqlQuery = "select user_phone_number, user_email from " & database & ".cems_users where title_id = '1'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            If (sqlReader.Read()) Then
                admin_email = sqlReader.Item("user_email")
                admin_phone_number = sqlReader.Item("user_phone_number")
            End If

            sqlConn.Close()

            If isFrench Then

                forgotPasswordMessage.Text = "Veuillez contacter l'administrateur via ces contacts " & admin_email & " et " & admin_phone_number & " "
            Else
                forgotPasswordMessage.Text = "Please contact the administrator via " & admin_email & " and, or  " & admin_phone_number & " "

            End If

            forgotPasswordMessage.Visible = True
            Timer1.Interval = 3000
            Timer1.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick 'this stops the timer and make the messages disappear
        forgotPasswordMessage.Visible = False
        connexionErrorMsg.Visible = False
        Timer1.Stop()


    End Sub
    Public Sub longestQuery()

        sqlQuery = "
                            --
-- Database: `" & database & "`
--
-- --------------------------------------------------------

use " & database & ";


-- --------------------------------------------------------

--
-- Table structure for table `cems_titles`
--

CREATE TABLE `cems_titles` (
  `title_id` int(11) NOT NULL,
  `title_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cems_titles`
--

INSERT INTO `cems_titles` (`title_id`, `title_name`) VALUES
(1, 'admin'),
(2, 'user');
-- --------------------------------------------------------

--
-- Table structure for table `cems_users`
-- 

CREATE TABLE `cems_users` (
  `user_id` int(11) NOT NULL,
  `user_name` varchar(100) NOT NULL,
  `user_phone_number` varchar(9) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `user_password` varchar(65) NOT NULL,
  `title_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- --------------------------------------------------------

--
-- Table structure for table `cems_halls`
--

CREATE TABLE `cems_halls` (
  `hall_id` int(11) NOT NULL,
  `hall_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `cems_halls` (`hall_id`, `hall_name`) VALUES
(1, 'Hall 0');

-- --------------------------------------------------------

--
-- Table structure for table `cems_posts`
--

CREATE TABLE `cems_posts` (
  `post_id` int(11) NOT NULL,
  `hall_id` int(11) NOT NULL,
  `post_state` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- --------------------------------------------------------

--
-- Indexes for dumped tables
--

-- --------------------------------------------------------

--
-- Table structure for table `cems_equipments`
--

CREATE TABLE `cems_equipments` (
  `equipment_id` int(11) NOT NULL,
  `equipment_type` varchar(100) NOT NULL,
  `equipment_state` varchar(100) NOT NULL,
  `post_id` int(11) NOT NULL,
  `hall_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


--
-- Indexes for table `cems_equipments`
--
ALTER TABLE `cems_equipments`
  ADD PRIMARY KEY (`equipment_id`),
  ADD KEY `post_id` (`post_id`),
  ADD KEY `cems_equipments_ibfk_2` (`hall_id`);

--
-- Indexes for table `cems_halls`
--
ALTER TABLE `cems_halls`
  ADD PRIMARY KEY (`hall_id`);

--
-- Indexes for table `cems_posts`
--
ALTER TABLE `cems_posts`
  ADD PRIMARY KEY (`post_id`),
  ADD KEY `hall_id` (`hall_id`);

--
-- Indexes for table `cems_titles`
--
ALTER TABLE `cems_titles`
  ADD PRIMARY KEY (`title_id`);

--
-- Indexes for table `cems_users`
--
ALTER TABLE `cems_users`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `title_id` (`title_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cems_equipments`
--
ALTER TABLE `cems_equipments`
  MODIFY `equipment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cems_halls`
--
ALTER TABLE `cems_halls`
  MODIFY `hall_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cems_titles`
--
ALTER TABLE `cems_titles`
  MODIFY `title_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `cems_users`
--
ALTER TABLE `cems_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cems_equipments`
--
ALTER TABLE `cems_equipments`
  ADD CONSTRAINT `cems_equipments_ibfk_1` FOREIGN KEY (`post_id`) REFERENCES `cems_posts` (`post_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cems_equipments_ibfk_2` FOREIGN KEY (`hall_id`) REFERENCES `cems_halls` (`hall_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cems_posts`
--
ALTER TABLE `cems_posts`
  ADD CONSTRAINT `cems_posts_ibfk_1` FOREIGN KEY (`hall_id`) REFERENCES `cems_halls` (`hall_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cems_users`
--
ALTER TABLE `cems_users`
  ADD CONSTRAINT `cems_users_ibfk_1` FOREIGN KEY (`title_id`) REFERENCES `cems_titles` (`title_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

--
--
--
ALTER TABLE cems_users
ADD CONSTRAINT atomic_email UNIQUE (user_email);

--
--
--
INSERT INTO `cems_posts` (`post_id`, `hall_id`, `post_state`) VALUES
(1, 1, 'good');

--
-- Dumping data for table `cems_users`
--




                            "
    End Sub

    'close all servers when closing the app
    Private Sub Form1_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Stop Apache
        Dim apacheProcesses() As Process = Process.GetProcessesByName("httpd")
        For Each apacheProcess As Process In apacheProcesses
            If Not apacheProcess.CloseMainWindow() Then
                apacheProcess.Kill()
            End If
        Next

        ' Stop MySQL
        Dim mysqlProcesses() As Process = Process.GetProcessesByName("mysqld")
        For Each mysqlProcess As Process In mysqlProcesses
            If Not mysqlProcess.CloseMainWindow() Then
                mysqlProcess.Kill()
            End If
        Next

    End Sub

    Private Sub emailtxt_TextChanged(sender As Object, e As EventArgs) Handles emailtxt.TextChanged
        textBoxEmail_Validating(emailtxt)
    End Sub


    Private Sub textBoxEmail_Validating(textBoxEmail As TextBox)
        Dim email As String = textBoxEmail.Text

        ' Check for email format
        IsValidEmail(email)

        If Not IsValidEmail(email) Then
            errorProviderEmail.SetError(textBoxEmail, "Invalid email format")
        Else
            errorProviderEmail.SetError(textBoxEmail, "") ' Clear the error message
        End If
    End Sub


    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function


End Class