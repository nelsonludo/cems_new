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


Public Class adminHomePagePanelUserControl
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
    Dim profileupdatepanelusercontrol As profileupdatepanelusercontrol

    Dim bitmap As Bitmap

    Private Sub IPsBtn2_Click(sender As Object, e As EventArgs) Handles IPsBtn2.Click
        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", adminEquipmentPanelUserControl.DataGridView1)

        adminEquipmentPanelUserControl.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanelUserControl.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanelUserControl.Visible = False
        adminHallsPanelUserControl.Visible = False
        adminUserPanelUserControl.Visible = False
        adminRolePanelUserControl.Visible = False

        adminhomePage.fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)

    End Sub

    'equipments secondary buttons clicks

    Private Sub CPUsBtn2_Click(sender As Object, e As EventArgs) Handles CPUsBtn2.Click
        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", adminEquipmentPanelUserControl.DataGridView1)

        adminEquipmentPanelUserControl.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanelUserControl.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanelUserControl.Visible = False
        adminHallsPanelUserControl.Visible = False
        adminUserPanelUserControl.Visible = False
        adminRolePanelUserControl.Visible = False

        adminhomePage.fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)
    End Sub

    Private Sub usersBtn2_Click(sender As Object, e As EventArgs) Handles usersBtn2.Click
        adminEquipmentPanelUserControl.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanelUserControl.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanelUserControl.Visible = False
        adminHallsPanelUserControl.Visible = False
        adminUserPanelUserControl.Visible = True
        adminRolePanelUserControl.Visible = False

        User.displayTableU("users", adminUserPanelUserControl.DataGridView4, sqlDataTableU)


        userUpdatePanelUserControl.userUpdatePanel.Visible = False
        adminUserPanelUserControl.userUpdateBtn.Visible = False
        adminUserPanelUserControl.userDeleteBtn.Visible = False


    End Sub
End Class
