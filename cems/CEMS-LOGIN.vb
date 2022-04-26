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

    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click

        Dim wrapper As New Simple3Des("")

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


        FileOpen(1, FILE_PATH, OpenMode.Append) 'localPath, OpenMode.Append)

        PrintLine(1, serverEncr)
        PrintLine(1, userNameEncr)
        PrintLine(1, pwdEncr)
        PrintLine(1, databaseEncr)

        FileClose(1)

        FileOpen(1, FILE_PATH, OpenMode.Input) 'localPath, OpenMode.Input)

        While Not EOF(1)
            server = wrapper.DecryptData(LineInput(1))
            username = wrapper.DecryptData(LineInput(1))
            password = wrapper.DecryptData(LineInput(1))
            database = wrapper.DecryptData(LineInput(1))
        End While

        FileClose(1)

        connexionStringPanel.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FILE_PATH As String = "C:\Users\ludon\OneDrive\Documents\connectionString.txt"

        Dim FILE_NAME As String = "connectionString.txt"

        Dim appDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

        Dim connexionStringDirectory As String = appDir & "\" & FILE_NAME

        Dim uriPath As String = connexionStringDirectory
        Dim localPath As String = New Uri(uriPath).LocalPath

        Dim wrapper As New Simple3Des("")

        If System.IO.File.Exists(FILE_PATH) = True Then 'localPath) = True Then

            FileOpen(1, FILE_PATH, OpenMode.Input) 'localPath, OpenMode.Input)

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
            System.IO.File.Create(FILE_PATH)
            System.IO.File.SetAttributes(FILE_PATH, System.IO.FileAttributes.Hidden) 'localPath, System.IO.FileAttributes.Hidden)
        End If
    End Sub

    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password=" + password + ";" + "database =" + database
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


End Class