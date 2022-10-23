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

Public Class roleUpdatePanelUserControl
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
    Dim userAddPanelUserControl As New userAddPanelUserControl
    Dim userUpdatePanelUserControl As New userUpdatePanelUserControl
    Dim adminPostPanelUserControl As New adminPostPanelUserControl


    Dim bitmap As Bitmap

    Private Sub roleUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateValidationBtn.Click 'validate update 

        Dim role_id As String = adminRolePanelUserControl.DataGridView5.SelectedRows(0).Cells(0).Value.ToString

        adminhomePage.connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        'this changes the role name

        With sqlCmd

            .CommandText = "Update cems.cems_titles Set title_name ='" & titleNameInput.Text & "' where title_id = '" & role_id & "' "

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        'this updates the datagridview
        User.displayTable("titles", adminRolePanelUserControl.DataGridView5, sqlDataTableR)

        'this changes the content of confirmMsg
        adminRolePanelUserControl.confirmMsgR.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        adminRolePanelUserControl.confirmMsgR.Visible = True
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()


        'this makes the update panel to disappear
        roleUpdatePanel.Visible = False
        adminRolePanelUserControl.roleUpdateBtn.Visible = False
    End Sub

    Private Sub roleUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateCancelBtn.Click 'cancel
        roleUpdatePanel.Visible = False
        adminRolePanelUserControl.roleUpdateBtn.Visible = False
    End Sub



End Class
