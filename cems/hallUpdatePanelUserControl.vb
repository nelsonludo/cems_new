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
Imports cems.hallUpdatePanelUserControl
Imports cems.roleAddPanelUserControl
Imports cems.roleUpdatePanelUserControl
Imports cems.userAddPanelUserControl
Imports cems.userUpdatePanelUserControl

Public Class hallUpdatePanelUserControl
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
    Dim roleAddPanelUserControl As New roleAddPanelUserControl
    Dim roleUpdatePanelUserControl As New roleUpdatePanelUserControl
    Dim userAddPanelUserControl As New userAddPanelUserControl
    Dim userUpdatePanelUserControl As New userUpdatePanelUserControl
    Dim adminPostPanelUserControl As New adminPostPanelUserControl


    Dim bitmap As Bitmap
    Private Sub hallUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateCancelBtn.Click 'cancel
        hallUpdatePanel.Visible = False

        adminHallsPanelUserControl.HallUpdateBtn.Visible = False
        adminHallsPanelUserControl.HallDeleteBtn.Visible = False
    End Sub

    Private Sub hallUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateValidateBtn.Click 'validate update 

        Dim hall_id As String = adminHallsPanelUserControl.DataGridView3.SelectedRows(0).Cells(0).Value.ToString

        adminhomePage.connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        'this changes the hall name

        With sqlCmd

            .CommandText = "Update cems.cems_halls Set hall_name ='" & adminUpdateHallNameInput.Text & "' where hall_id = '" & hall_id & "' " 'Update cems.cems_users set user_name ='" & userUserNameInput.Text & "', user_email = '" & userUserEmailInput.Text & "', user_phone_number = '" & userUserPhoneInput.Text & "', title_id = '" & title_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        'this updates the datagridview
        User.displayTable("halls", adminHallsPanelUserControl.DataGridView3, sqlDataTableH)

        'this changes the content of confirmMsg
        adminHallsPanelUserControl.confirmMsgH.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        adminHallsPanelUserControl.confirmMsgH.Visible = True
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()


        'this makes the update panel to disappear
        hallUpdatePanel.Visible = False

        adminHallsPanelUserControl.HallUpdateBtn.Visible = False
        adminHallsPanelUserControl.HallDeleteBtn.Visible = False
    End Sub

End Class
