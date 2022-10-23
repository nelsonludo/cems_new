
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports cems.adminPostPanelUserControl
Imports cems.addEquipmentPanelUserControl
Imports cems.addPostPanelUserControl
Imports cems.adminEquipmentPanelUserControl
Imports cems.adminHallsPanelUserControl
Imports cems.adminHomePagePanelUserControl
Imports cems.adminProfilePanelUserControl
Imports cems.adminRolePanelUserControl
Imports cems.adminUserPanelUserControl
Imports cems.hallAddPanelUserControl
Imports cems.hallUpdatePanelUserControl
Imports cems.roleAddPanelUserControl
Imports cems.roleUpdatePanelUserControl
Imports cems.userAddPanelUserControl
Imports cems.userUpdatePanelUserControl




Public Class userAddPanelUserControl
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTableE As New DataTable
    Dim sqlDataTableP As New DataTable
    Dim sqlDataTableH As New DataTable
    Dim sqlDataTableU As New DataTable
    Dim sqlDataTableR As New DataTable
    Dim sqlDataTableCBHP As New DataTable 'hall search combobox
    Dim sqlDataTableCBHE As New DataTable 'hall search combobox
    Dim sqlDataTableCBH As New DataTable 'hall search combobox
    Dim sqlDataAdaptor As New MySqlDataAdapter
    Dim sqlQuery As String

    Public server As String = Form1.server
    Public username As String = Form1.username
    Public password As String = Form1.password
    Public database As String = Form1.database

    Dim User As New users
    Dim admin As New admin

    Dim addEquipmentPanelUserControl As addEquipmentPanelUserControl
    Dim addPostPanelUserControl As addPostPanelUserControl
    Dim adminEquipmentPanelUserControl As adminEquipmentPanelUserControl
    Dim adminHallsPanelUserControl As adminHallsPanelUserControl
    Dim adminHomePagePanelUserControl As adminHomePagePanelUserControl
    Dim adminProfilePanelUserControl As adminProfilePanelUserControl
    Dim adminRolePanelUserControl As adminRolePanelUserControl
    Dim adminUserPanelUserControl As adminUserPanelUserControl
    Dim hallAddPanelUserControl As hallAddPanelUserControl
    Dim hallUpdatePanelUserControl As hallUpdatePanelUserControl
    Dim roleAddPanelUserControl As roleAddPanelUserControl
    Dim roleUpdatePanelUserControl As roleUpdatePanelUserControl
    Dim userAddPanelUserControl As userAddPanelUserControl
    Dim userUpdatePanelUserControl As userUpdatePanelUserControl
    Dim adminPostPanelUserControl As adminPostPanelUserControl


    Dim bitmap As Bitmap

    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
               + "password=" + password + ";" + "database =" + database
    End Sub

    'user add Section

    Private Sub userAddValidateBtn_Click(sender As Object, e As EventArgs) Handles userAddvalidationBtn.Click 'validate add

        connect_db()

        If userAddPanelUserControl.userUserAddNameInput.Text = "" Or userAddPanelUserControl.userUserAddEmailInput.Text = "" Or userAddPanelUserControl.userUserAddPhoneInput.Text = "" Or userAddPanelUserControl.userUserAddConfirmPwdInput.Text = "" Or userAddPanelUserControl.userUserAddTitleInput.Text = "" Then
            userAddPanelUserControl.addUserErrorMsg.Text = "please fill all the fields !"
            userAddPanelUserControl.addUserErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()
        Else

            Dim title_id As Integer
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select title_id from  cems.cems_titles where title_name = '" & userAddPanelUserControl.userUserAddTitleInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    title_id = sqlReader.Item("title_id")
                End While

                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try


            If userAddPanelUserControl.userUserAddPwdInput.Text <> userAddPanelUserControl.userUserAddConfirmPwdInput.Text Then
                userAddPanelUserControl.addUserErrorMsg.Visible = True
                userAddPanelUserControl.addUserErrorMsg.Text = "The password does not correspond"
                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()
            Else

                If title_id = 1 Or title_id = 2 Then
                    Try
                        sqlConn.Open()
                        sqlQuery = "insert into cems.cems_admin(admin_name, admin_email, admin_phone_number, admin_password, title_id) values ('" & userAddPanelUserControl.userUserAddNameInput.Text & "','" & userAddPanelUserControl.userUserAddEmailInput.Text & "','" & userAddPanelUserControl.userUserAddPhoneInput.Text & "','" & userAddPanelUserControl.userUserAddConfirmPwdInput.Text & "','" & title_id & "')"
                        'Read through the response'
                        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                        sqlReader = sqlCmd.ExecuteReader
                        sqlConn.Close()



                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        sqlConn.Dispose()
                    End Try

                Else
                    Try
                        sqlConn.Open()
                        'Read through the response'
                        sqlQuery = "insert into cems.cems_users(user_name, user_email, user_phone_number, user_password, title_id) values ('" & userAddPanelUserControl.userUserAddNameInput.Text & "','" & userAddPanelUserControl.userUserAddEmailInput.Text & "','" & userAddPanelUserControl.userUserAddPhoneInput.Text & "','" & userAddPanelUserControl.userUserAddConfirmPwdInput.Text & "','" & title_id & "')"
                        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                        sqlReader = sqlCmd.ExecuteReader
                        sqlConn.Close()



                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        sqlConn.Dispose()
                    End Try
                End If
                'this updates the datagridview
                User.displayTableU("users", adminUserPanelUserControl.DataGridView4, sqlDataTableU)

                'this changes the content of confirmMsg
                adminUserPanelUserControl.confirmMsgU.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                adminUserPanelUserControl.confirmMsgU.Visible = True
                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()


                'this makes the add panel to disappear
                userUpdatePanelUserControl.userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
                userAddPanelUserControl.userAddPanel.Visible = False

            End If

        End If
    End Sub

    Private Sub userAddCancelBtn_Click(sender As Object, e As EventArgs) Handles userAddCancelBtn.Click 'cancel add
        userUpdatePanelUserControl.userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        userAddPanelUserControl.userAddPanel.Visible = False
    End Sub


End Class
