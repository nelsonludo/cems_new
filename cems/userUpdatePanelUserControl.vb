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





Public Class userUpdatePanelUserControl
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

    Dim addEquipmentPanelUserControl As New addEquipmentPanelUserControl
    Dim addPostPanelUserControl As New addPostPanelUserControl
    Dim adminEquipmentPanelUserControl As New adminEquipmentPanelUserControl
    Dim adminHallsPanelUserControl As New adminHallsPanelUserControl
    Dim adminHomePagePanelUserControl As New adminHomePagePanelUserControl
    Dim adminProfilePanelUserControl As New adminProfilePanelUserControl
    Dim adminRolePanelUserControl As New adminRolePanelUserControl
    Dim adminUserPanelUserControl As New adminUserPanelUserControl
    Dim hallAddPanelUserControl As New hallAddPanelUserControl
    Dim hallUpdatePanelUserControl As New hallUpdatePanelUserControl
    Dim roleAddPanelUserControl As New roleAddPanelUserControl
    Dim roleUpdatePanelUserControl As New roleUpdatePanelUserControl
    Dim userAddPanelUserControl As New userAddPanelUserControl
    Dim adminPostPanelUserControl As New adminPostPanelUserControl


    Dim bitmap As Bitmap


    'UPDATES
    'USER SECTION 


    Private Sub userupdatevalidationBtn_Click(sender As Object, e As EventArgs) Handles userUpdateValidationBtn.Click  'validate update 
        adminhomePage.connect_db()

        Dim title_id As Integer
        'SQL Connection'

        Try
            sqlConn.Open()

            sqlQuery = "select title_id from  cems.cems_titles where title_name = '" & userUserTitleInput.Text & "'"


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


        Dim user_id As String = adminUserPanelUserControl.DataGridView4.SelectedRows(0).Cells(0).Value.ToString


        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        'this changes the hall name

        With sqlCmd

            .CommandText = "Update cems.cems_users set user_name ='" & userUserNameInput.Text & "', user_email = '" & userUserEmailInput.Text & "', user_phone_number = '" & userUserPhoneInput.Text & "', title_id = '" & title_id & "' where user_id = '" & user_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        'this updates the datagridview
        User.displayTableU("users", adminUserPanelUserControl.DataGridView4, sqlDataTableU)

        'this changes the content of confirmMsg
        adminUserPanelUserControl.confirmMsgU.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        adminUserPanelUserControl.confirmMsgU.Visible = True
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()


        'this makes the update panel to disappear
        userUpdatePanel.Visible = False

        adminUserPanelUserControl.userUpdateBtn.Visible = False
        adminUserPanelUserControl.userDeleteBtn.Visible = False
    End Sub

    Private Sub userCancelBtn_Click(sender As Object, e As EventArgs) Handles userCancelBtn.Click 'cancel
        userUpdatePanel.Visible = False
        adminUserPanelUserControl.userUpdateBtn.Visible = False
        adminUserPanelUserControl.userDeleteBtn.Visible = False

    End Sub
End Class
