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
Public Class adminhomePage
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
    Dim adminHomePagePanelUserControl2 As New adminHomePagePanelUserControl
    Dim adminProfilePanelUserControl As New adminProfilePanelUserControl
    Dim adminRolePanelUserControl As New adminRolePanelUserControl
    Dim adminUserPanelUserControl As New adminUserPanelUserControl
    Dim hallUpdatePanelUserControl As New hallUpdatePanelUserControl
    Dim roleAddPanelUserControl As New roleAddPanelUserControl
    Dim hallAddPanelUserControl As New hallAddPanelUserControl
    Dim roleUpdatePanelUserControl As New roleUpdatePanelUserControl
    Dim userAddPanelUserControl As New userAddPanelUserControl
    Dim userUpdatePanelUserControl As New userUpdatePanelUserControl
    Dim adminPostPanelUserControl As New adminPostPanelUserControl
    Dim profileupdatepanelusercontrol As New profileupdatepanelusercontrol

    Dim bitmap As Bitmap

    Dim iscollapsed As Boolean = True
    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
               + "password=" + password + ";" + "database =" + database
    End Sub

    Public Sub showUserName()
        connect_db()
        Try
            sqlConn.Open()
            'username appear
            sqlQuery = "select * from cems.cems_admin where admin_email = '" & Form1.emailtxt.Text & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                aName.Text = sqlReader.Item("admin_name")

            End If

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub adminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()

        showUserName()

        dropdown.Size = dropdown.MinimumSize

        AdminEquipmentPanelUserControl1.Visible = False
        AdminPostPanelUserControl1.Visible = False
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        AdminHomePagePanelUserControl1.Visible = True

        User.activeCount(AdminHomePagePanelUserControl1.activeCPUNumber, "equipments", "equipment", "good", "CPU")
        User.activeCount(AdminHomePagePanelUserControl1.activeIPNumber, "equipments", "equipment", "good", "IP_phone")
        User.activeCount(AdminHomePagePanelUserControl1.activeMonitorNumber, "equipments", "equipment", "good", "monitor")


        User.activeCount(AdminHomePagePanelUserControl1.nonActiveCPUNumber, "equipments", "equipment", "bad", "CPU")
        User.activeCount(AdminHomePagePanelUserControl1.nonActiveIPNumber, "equipments", "equipment", "bad", "IP_phone")
        User.activeCount(AdminHomePagePanelUserControl1.nonActiveMonitorNumber, "equipments", "equipment", "bad", "monitor")
        admin.activeCount(AdminHomePagePanelUserControl1.userNumber, "users")

    End Sub

    Private Sub adminHomePage_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form1.Close()

    End Sub

    'dropdown code 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If iscollapsed Then
            equipmentsBtn.Image = My.Resources.drop_down_arrow
            dropdown.Height += 10
            If dropdown.Size = dropdown.MaximumSize Then
                Timer1.Stop()
                iscollapsed = False
            End If
        Else
            equipmentsBtn.Image = My.Resources.drop_left_arrow1
            dropdown.Height -= 10
            If dropdown.Size = dropdown.MinimumSize Then
                Timer1.Stop()
                iscollapsed = True
            End If
        End If
    End Sub


    Public Sub fillHalls(search As ComboBox)

        search.Items.Clear()

        Try
            sqlConn.Open()

            sqlQuery = "select * from  cems.cems_halls"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                search.Items.Add(sqlReader.Item("hall_name"))

            End While
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try
    End Sub

    Public Sub fillcombo(search As ComboBox, table As String, fillvalue As String)

        search.Items.Clear()

        Try
            sqlConn.Open()

            sqlQuery = "select * from  cems.cems_" & table & ""


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                search.Items.Add(sqlReader.Item("" & fillvalue & ""))

            End While
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try
    End Sub

    Private Sub fillcomboState(search As ComboBox, table As String, fillvalue As String)

        search.Items.Clear()


        search.Items.Add("Good")
        search.Items.Add("Bad")
        search.Items.Add("In reparation")

    End Sub


    'tab buttons section
    Private Sub postsBtn_Click(sender As Object, e As EventArgs) Handles postsBtn.Click


        AdminEquipmentPanelUserControl1.Visible = False
        AdminPostPanelUserControl1.Visible = True
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        User.displayTableP("posts", adminPostPanelUserControl.DataGridView2, sqlDataTableP)  'this is a useless comment

        fillHalls(adminPostPanelUserControl.hallSearchBoxP)
        fillcomboState(adminPostPanelUserControl.stateSearchBoxP, "posts", "post_state")

    End Sub
    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        AdminEquipmentPanelUserControl1.Visible = False
        AdminPostPanelUserControl1.Visible = False
        AdminProfilePanelUserControl1.Visible = True
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        If profileupdatepanelusercontrol.Visible = True Then
            profileupdatepanelusercontrol.profileSubPanel2.Visible = False
        End If

        connect_db()
        User.updateUserInformation("admin", "admin", Form1.emailtxt, adminProfilePanelUserControl.adminNameProfile, adminProfilePanelUserControl.adminEmailProfile, adminProfilePanelUserControl.adminPhoneNumberProfile, adminProfilePanelUserControl.adminTitleProfile)
    End Sub



    Private Sub equipmentsBtn_Click(sender As Object, e As EventArgs) Handles equipmentsBtn.Click
        Timer1.Start()


        AdminEquipmentPanelUserControl1.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "Equipments")
        User.displayTableE("equipments", adminEquipmentPanelUserControl.DataGridView1, sqlDataTableE)

        fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)
        fillcomboState(adminEquipmentPanelUserControl.userSearchBoxE, "equipments", "equipment_state")

    End Sub


    Private Sub hallsBtn_Click(sender As Object, e As EventArgs) Handles hallsBtn.Click
        AdminEquipmentPanelUserControl1.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = True
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        User.displayTable("halls", adminHallsPanelUserControl.DataGridView3, sqlDataTableH)


        adminHallsPanelUserControl.HallUpdateBtn.Visible = False
        adminHallsPanelUserControl.HallDeleteBtn.Visible = False
        hallUpdatePanelUserControl.hallUpdatePanel.Visible = False

        fillHalls(adminHallsPanelUserControl.hallSearchBoxH)
    End Sub

    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles userBtn.Click
        AdminEquipmentPanelUserControl1.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = True
        AdminRolePanelUserControl1.Visible = False

        User.displayTableU("users", adminuserPanelUserControl.DataGridView4, sqlDataTableU)


        userUpdatePanelUserControl.userUpdatePanel.Visible = False
        adminUserPanelUserControl.userUpdateBtn.Visible = False
        adminUserPanelUserControl.userDeleteBtn.Visible = False


    End Sub


    Private Sub rolesBtn_Click(sender As Object, e As EventArgs) Handles rolesBtn.Click
        AdminEquipmentPanelUserControl1.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = True
        AdminRolePanelUserControl1.Visible = False

        adminRolePanelUserControl.roleUpdateBtn.Visible = False

        User.displayTable("titles", adminRolePanelUserControl.DataGridView5, sqlDataTableR)


    End Sub



    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click
        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", adminEquipmentPanelUserControl.DataGridView1)

        AdminEquipmentPanelUserControl1.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)

    End Sub

    Private Sub IPsBtn_Click(sender As Object, e As EventArgs) Handles IPsBtn.Click
        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", adminEquipmentPanelUserControl.DataGridView1)

        AdminEquipmentPanelUserControl1.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)

    End Sub

    Private Sub monitorsBtn2_Click(sender As Object, e As EventArgs)
        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", adminEquipmentPanelUserControl.DataGridView1)

        AdminEquipmentPanelUserControl1.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)

    End Sub


    Private Sub monitorsBtn_Click(sender As Object, e As EventArgs) Handles monitorsBtn.Click
        User.display(adminEquipmentPanelUserControl.adminEquipmentPanel, adminEquipmentPanelUserControl.EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", adminEquipmentPanelUserControl.DataGridView1)

        AdminEquipmentPanelUserControl1.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

        fillHalls(adminEquipmentPanelUserControl.hallSearchBoxE)

    End Sub



    Private Sub adminLogout_Click(sender As Object, e As EventArgs) Handles adminLogout.Click
        Form1.Show()
        Me.Visible = False
        Form1.emailtxt.Text = ""
        Form1.passwordtxt.Text = ""

        AdminEquipmentPanelUserControl1.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        AdminPostPanelUserControl1.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        AdminProfilePanelUserControl1.Visible = False
        AdminHallsPanelUserControl1.Visible = False
        AdminUserPanelUserControl1.Visible = False
        AdminRolePanelUserControl1.Visible = False

    End Sub



    'this is the second timer function which is used to make the timer stop

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick 'this stops the timer and make the messages disappear
        adminPostPanelUserControl.confirmMsgP.Visible = False
        adminEquipmentPanelUserControl.confirmMsgE.Visible = False
        adminHallsPanelUserControl.confirmMsgH.Visible = False
        adminUserPanelUserControl.confirmMsgU.Visible = False
        adminRolePanelUserControl.confirmMsgR.Visible = False
        userAddPanelUserControl.addUserErrorMsg.Visible = False
        addEquipmentPanelUserControl.addEquipmentErrorMsg.Visible = False
        roleAddPanelUserControl.addRoleErrorMsg.Visible = False
        hallAddPanelUserControl.addHallErrorMsg.Visible = False
        addPostPanelUserControl.addPostErrorMsg.Visible = False
        userAddPanelUserControl.addUserErrorMsg.Visible = False
        profileupdatepanelusercontrol.updateProfileErrorMsg.Visible = False

        Timer2.Stop()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If adminPostPanelUserControl.DataGridView2.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub

    Private Sub AdminProfilePanelUserControl1_Load(sender As Object, e As EventArgs)

    End Sub
End Class
