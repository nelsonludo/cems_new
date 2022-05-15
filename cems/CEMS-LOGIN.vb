Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports cems.Simple3Des

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



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FILE_PATH As String = "C:\Users\ludon\OneDrive\Documents\connectionString.txt"

        Dim FILE_NAME As String = "connectionString.txt"

        Dim appDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

        Dim connexionStringDirectory As String = appDir & "\" & FILE_NAME

        Dim uriPath As String = connexionStringDirectory
        Dim localPath As String = New Uri(uriPath).LocalPath

        Dim wrapper As New Simple3Des("")

        If System.IO.File.Exists(localPath) = True Then 'FILE_PATH) = True Then

            FileOpen(1, localPath, OpenMode.Input) 'FILE_PATH, OpenMode.Input) 

            While Not EOF(1)
                server = wrapper.DecryptData(LineInput(1))
                username = wrapper.DecryptData(LineInput(1))
                password = wrapper.DecryptData(LineInput(1))
                database = wrapper.DecryptData(LineInput(1))
            End While

            FileClose(1)
            If server <> "" Or username <> "" Or database <> "" Then
                connexionStringPanel.Visible = False
            End If
        Else
            System.IO.File.Create(localPath)
            System.IO.File.SetAttributes(localPath, System.IO.FileAttributes.Hidden) 'FILE_PATH, System.IO.FileAttributes.Hidden)
        End If
    End Sub


    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click
        If connexionStringServer.Text = "" Or connexionStringUserName.Text = "" Or connexionStringDatabase.Text = "" Then
            connexionErrorMsg.Text = "Please fill all the fields"
            Timer2.Interval = 3000
            Timer2.Start()
        Else
            Dim wrapper As New Simple3Des("")

<<<<<<< HEAD
        Dim servercb As String = connexionStringServer.Text
        Dim usernamecb As String = connexionStringUserName.Text
        Dim passwordcb As String = connexionStringPwd.Text
        Dim databasecb As String = connexionStringDatabase.Text
        Dim test As Boolean = False

        If servercb = "" Or usernamecb = "" Or databasecb = "" Then
            connexionErrorMsg.Text = "please fill all the fields "

            connexionErrorMsg.Visible = True
            Timer1.Interval = 3000
            Timer1.Start()
        Else

            Try
                connect_db(servercb, usernamecb, passwordcb, databasecb)

                sqlConn.Open()
                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                test = True
            End Try

            If test Then
                connexionErrorMsg.Text = "your connexion string is not valid check your information"

                connexionErrorMsg.Visible = True
                Timer1.Interval = 3000
                Timer1.Start()
            Else
                Dim wrapper As New Simple3Des("")

                Dim serverEncr As String = wrapper.EncryptData(servercb)
                Dim userNameEncr As String = wrapper.EncryptData(usernamecb)
                Dim pwdEncr As String = wrapper.EncryptData(passwordcb)
                Dim databaseEncr As String = wrapper.EncryptData(databasecb)

                Dim FILE_PATH As String = "C:\Users\ludon\OneDrive\Documents\connectionString.txt"

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
                connect_db(servercb, usernamecb, passwordcb, databasecb)

                Dim checkTables As Integer = 0

                Try
                    sqlConn.Open()

                    sqlQuery = "select count(*) from information_schema.tables where table_name = 'cems_admin'"


                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                            checkTables = sqlReader.Item("count(*)")
                    End While
                    sqlConn.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()

                End Try

                If checkTables > 0 Then
                    connexionStringPanel.Visible = False
                    userAddPanel.Visible = False

                Else
                    'create all tables

                    Try
                        sqlConn.Open()

                        longestQuery()

                        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                        sqlReader = sqlCmd.ExecuteReader

                        sqlConn.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        sqlConn.Dispose()

                    End Try

                    'populating the title combobox

                    userUserAddTitleInput.Items.Clear()


                    Try
                        sqlConn.Open()

                        sqlQuery = "select * from  cems.cems_titles"


                        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                        sqlReader = sqlCmd.ExecuteReader
                        While (sqlReader.Read())
                            userUserAddTitleInput.Items.Add(sqlReader.Item("title_name"))

                        End While
                        sqlConn.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        sqlConn.Dispose()

                    End Try

                    userAddPanel.Visible = True
                End If
                connexionStringPanel.Visible = False
            End If


        End If


    End Sub


    Public Sub connect_db(serverC As String, usernameC As String, passwordC As String, databaseC As String)


        If sqlConn.State = ConnectionState.Closed Then

            sqlConn.ConnectionString = "server =" + serverC + ";" + "user id =" + usernameC + ";" + "password=" + passwordC + ";" + "database =" + databaseC

        End If

    End Sub




    Private Sub userAddValidateBtn_Click(sender As Object, e As EventArgs) Handles userAddvalidationBtn.Click 'validate add

        connect_db(server, username, password, database)

        If userUserAddNameInput.Text = "" Or userUserAddEmailInput.Text = "" Or userUserAddPhoneInput.Text = "" Or userUserAddConfirmPwdInput.Text = "" Or userUserAddTitleInput.Text = "" Then
            addUserErrorMsg.Text = "please fill all the fields !"
            addUserErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else

            Dim title_id As Integer
            'SQL Connection'
=======
            Dim serverEncr As String = wrapper.EncryptData(connexionStringServer.Text)
            Dim userNameEncr As String = wrapper.EncryptData(connexionStringUserName.Text)
            Dim pwdEncr As String = wrapper.EncryptData(connexionStringPwd.Text)
            Dim databaseEncr As String = wrapper.EncryptData(connexionStringDatabase.Text)

            Dim FILE_PATH As String = "C:\Users\ludon\OneDrive\Documents\connectionString.txt"

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

            FileOpen(1, localPath, OpenMode.Input) 'FILE_PATH, OpenMode.Input)snake

            While Not EOF(1)
                server = wrapper.DecryptData(LineInput(1))
                username = wrapper.DecryptData(LineInput(1))
                password = wrapper.DecryptData(LineInput(1))
                database = wrapper.DecryptData(LineInput(1))
            End While

            FileClose(1)



            'creating first admin
            connect_db()

            Dim checkTables As Integer
>>>>>>> 6cc17e01643d1c6e2ba74af3c4e2fd5118745a7b

            Try
                sqlConn.Open()

<<<<<<< HEAD
                sqlQuery = "select title_id from  cems.cems_titles where title_name = '" & userUserAddTitleInput.Text & "'"
=======
                sqlQuery = "select count(*) from information_schema.tables where table_name = 'cems_admin'"
>>>>>>> 6cc17e01643d1c6e2ba74af3c4e2fd5118745a7b


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
<<<<<<< HEAD

                While (sqlReader.Read())
                    title_id = sqlReader.Item("title_id")
                End While

                sqlConn.Close()
                MessageBox.Show(title_id)
=======
                While (sqlReader.Read())
                    checkTables = sqlReader.Item("count(*)")
                End While

                sqlConn.Close()

                MsgBox(checkTables)
>>>>>>> 6cc17e01643d1c6e2ba74af3c4e2fd5118745a7b
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try

<<<<<<< HEAD

            If userUserAddPwdInput.Text <> userUserAddConfirmPwdInput.Text Then
                addUserErrorMsg.Visible = True
                addUserErrorMsg.Text = "The password does not correspond"
                Timer2.Interval = 3000
                Timer2.Start()
            Else

                Try
                    sqlConn.Open()
                    sqlQuery = "insert into cems.cems_admin(admin_name, admin_email, admin_phone_number, admin_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & userUserAddConfirmPwdInput.Text & "','" & title_id & "')"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this changes the content of confirmMsg
                    forgotPasswordMessage.ForeColor = Color.Green

                    forgotPasswordMessage.Text = "login with the admin account information ✔"


                    'this makes the confirm message appear for 3secs
                    forgotPasswordMessage.Visible = True
                    Timer2.Interval = 5000
                    Timer2.Start()


                    'this makes the add panel to disappear
                    userAddPanel.Visible = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            End If

        End If
    End Sub


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick 'this stops the timer and make the messages disappear

        addUserErrorMsg.Visible = False

        Timer2.Stop()
    End Sub

    'password placeholder
    Private Sub passwordtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.GotFocus
        If passwordtxt.Text = "password" Then
            passwordtxt.Text = ""
        End If
    End Sub
    Private Sub passwordtxt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.LostFocus
        If passwordtxt.Text = "" Then
            passwordtxt.Text = "password"
        End If
    End Sub

    'password placeholder
    Private Sub emailtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtxt.GotFocus
        If emailtxt.Text = "email" Then
            emailtxt.Text = ""
        End If
    End Sub
    Private Sub emailtxt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtxt.LostFocus
        If emailtxt.Text = "" Then
            emailtxt.Text = "email"
        End If
    End Sub


    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click


        Dim userLogin As Boolean

        userLogin = User.login(passwordtxt.Text, emailtxt.Text, forgotPasswordMessage, Timer1)

        If (Not userLogin) Then
            admin.login(passwordtxt.Text, emailtxt.Text, forgotPasswordMessage, Timer1)
        End If
    End Sub

    Private Sub passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged

    End Sub

    Private Sub forgotPasswordBtn_Click(sender As Object, e As EventArgs) Handles forgotPasswordBtn.Click
        Dim admin_email As String = ""
        Dim admin_phone_number As String = ""

        connect_db(server, username, password, database)
        Try
            sqlConn.Open()
            'check user info
            sqlQuery = "select admin_phone_number, admin_email from cems.cems_admin where title_id = '3'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            If (sqlReader.Read()) Then
                admin_email = sqlReader.Item("admin_email")
                admin_phone_number = sqlReader.Item("admin_phone_number")
            End If

            sqlConn.Close()

            forgotPasswordMessage.Text = "Veuillez contacter l'administrateur à travers ces contacts " & admin_email & " et " & admin_phone_number & " "

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

        sqlQuery = "CREATE TABLE `cems_admin` (
=======
            If checkTables > 0 Then
                connexionStringPanel.Visible = False
                userAddPanel.Visible = False

            ElseIf checkTables = 0 Then
                'create all tables

                Try
                    sqlConn.Open()

                    sqlQuery = "CREATE TABLE `cems_admin` (
>>>>>>> 6cc17e01643d1c6e2ba74af3c4e2fd5118745a7b
                                  `admin_id` int(11) NOT NULL,
                                  `admin_name` varchar(100) NOT NULL,
                                  `admin_phone_number` varchar(9) NOT NULL,
                                  `admin_password` varchar(12) NOT NULL,
                                  `title_id` int(11) NOT NULL,
                                  `admin_email` varchar(50) NOT NULL
                                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

                            --
                            -- Dumping data for table `cems_admin`
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

                            -- --------------------------------------------------------

                            --
                            -- Table structure for table `cems_halls`
                            --

                            CREATE TABLE `cems_halls` (
                              `hall_id` int(11) NOT NULL,
                              `hall_name` varchar(100) NOT NULL
                            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
                            (2, 'user'),
                            (3, 'super Admin');

                            -- --------------------------------------------------------

                            --
                            -- Table structure for table `cems_users`
                            --

                            CREATE TABLE `cems_users` (
                              `user_id` int(11) NOT NULL,
                              `user_name` varchar(100) NOT NULL,
                              `user_phone_number` varchar(9) NOT NULL,
                              `user_email` varchar(50) NOT NULL,
                              `user_password` varchar(12) NOT NULL,
                              `title_id` int(11) NOT NULL
                            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

                            --
                            -- Dumping data for table `cems_users`
                            --
                            --
                            -- Indexes for dumped tables
                            --

                            --
                            -- Indexes for table `cems_admin`
                            --
                            ALTER TABLE `cems_admin`
                              ADD PRIMARY KEY (`admin_id`),
                              ADD KEY `admin_title` (`title_id`);

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
                            -- AUTO_INCREMENT for table `cems_admin`
                            --
                            ALTER TABLE `cems_admin`
                              MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
                            -- Constraints for table `cems_admin`
                            --
                            ALTER TABLE `cems_admin`
                              ADD CONSTRAINT `cems_admin_ibfk_1` FOREIGN KEY (`title_id`) REFERENCES `cems_titles` (`title_id`);

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
                            "
<<<<<<< HEAD
    End Sub

=======

                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader

                    sqlConn.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()

                End Try

                'populating the title combobox

                userUserAddTitleInput.Items.Clear()


                Try
                    sqlConn.Open()

                    sqlQuery = "select * from  cems.cems_titles"


                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                        userUserAddTitleInput.Items.Add(sqlReader.Item("title_name"))

                    End While
                    sqlConn.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()

                End Try

                userAddPanel.Visible = True
            End If

            connexionStringPanel.Visible = False

        End If



    End Sub


    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password=" + password + ";" + "database =" + database
    End Sub


    Private Sub userAddValidateBtn_Click(sender As Object, e As EventArgs) Handles userAddvalidationBtn.Click 'validate add

        connect_db()

        If userUserAddNameInput.Text = "" Or userUserAddEmailInput.Text = "" Or userUserAddPhoneInput.Text = "" Or userUserAddConfirmPwdInput.Text = "" Or userUserAddTitleInput.Text = "" Then
            addUserErrorMsg.Text = "please fill all the fields !"
            addUserErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else

            Dim title_id As Integer
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select title_id from  cems.cems_titles where title_name = '" & userUserAddTitleInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    title_id = sqlReader.Item("title_id")
                End While

                sqlConn.Close()
                MessageBox.Show(title_id)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try


            If userUserAddPwdInput.Text <> userUserAddConfirmPwdInput.Text Then
                addUserErrorMsg.Visible = True
                addUserErrorMsg.Text = "The password does not correspond"
                Timer2.Interval = 3000
                Timer2.Start()
            Else

                Try
                    sqlConn.Open()
                    sqlQuery = "insert into cems.cems_admin(admin_name, admin_email, admin_phone_number, admin_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & userUserAddConfirmPwdInput.Text & "','" & title_id & "')"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this changes the content of confirmMsg
                    forgotPasswordMessage.ForeColor = Color.Green

                    forgotPasswordMessage.Text = "login with the admin account information ✔"


                    'this makes the confirm message appear for 3secs
                    forgotPasswordMessage.Visible = True
                    Timer2.Interval = 5000
                    Timer2.Start()


                    'this makes the add panel to disappear
                    userAddPanel.Visible = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            End If

        End If
    End Sub


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick 'this stops the timer and make the messages disappear

        addUserErrorMsg.Visible = False
        connexionErrorMsg.Visible = False
        Timer2.Stop()
    End Sub

    'password placeholder
    Private Sub passwordtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.GotFocus
        If passwordtxt.Text = "password" Then
            passwordtxt.Text = ""
        End If
    End Sub
    Private Sub passwordtxt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.LostFocus
        If passwordtxt.Text = "" Then
            passwordtxt.Text = "password"
        End If
    End Sub

    'password placeholder
    Private Sub emailtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtxt.GotFocus
        If emailtxt.Text = "email" Then
            emailtxt.Text = ""
        End If
    End Sub
    Private Sub emailtxt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtxt.LostFocus
        If emailtxt.Text = "" Then
            emailtxt.Text = "email"
        End If
    End Sub


    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click


        Dim userLogin As Boolean

        userLogin = User.login(passwordtxt.Text, emailtxt.Text, forgotPasswordMessage, Timer1)

        If (Not userLogin) Then
            admin.login(passwordtxt.Text, emailtxt.Text, forgotPasswordMessage, Timer1)
        End If
    End Sub

    Private Sub passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged

    End Sub

    Private Sub forgotPasswordBtn_Click(sender As Object, e As EventArgs) Handles forgotPasswordBtn.Click
        Dim admin_email As String
        Dim admin_phone_number As String

        connect_db()
        Try
            sqlConn.Open()
            'check user info
            sqlQuery = "select admin_phone_number, admin_email from cems.cems_admin where title_id = '3'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                admin_email = sqlReader.Item("admin_email")
                admin_phone_number = sqlReader.Item("admin_phone_number")
                forgotPasswordMessage.Text = "Veuillez contacter l'administrateur à travers ces contacts " & admin_email & " et " & admin_phone_number & " "
                Timer1.Interval = 3000
                Timer1.Start()
            End If
            sqlConn.Close()
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


>>>>>>> 6cc17e01643d1c6e2ba74af3c4e2fd5118745a7b
End Class