
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




Public Class roleAddPanelUserControl
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
    Private Sub roleAddValidationBtn_Click(sender As Object, e As EventArgs) Handles roleAddValidationBtn.Click 'validate add

        connect_db()

        If roleAddPanelUserControl.titleAddNameInput.Text = "" Then
            roleAddPanelUserControl.addRoleErrorMsg.Text = "please fill the field"
            roleAddPanelUserControl.addRoleErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()
        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_titles(title_name) values ('" & roleAddPanelUserControl.titleAddNameInput.Text & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try

            'this updates the datagridview
            User.displayTable("titles", adminRolePanelUserControl.DataGridView5, sqlDataTableR)

            'this changes the content of confirmMsg
            adminRolePanelUserControl.confirmMsgR.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            adminRolePanelUserControl.confirmMsgR.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()


            'this makes the add panel to disappear
            roleUpdatePanelUserControl.roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            roleAddPanelUserControl.roleAddPanel.Visible = False

        End If
    End Sub

    Private Sub roleAddCancelBtn_Click(sender As Object, e As EventArgs) Handles roleAddCancelBtn.Click 'cancel add
        roleUpdatePanelUserControl.roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        roleAddPanelUserControl.roleAddPanel.Visible = False
    End Sub


End Class
