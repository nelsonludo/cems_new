Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
    Imports Microsoft.Win32
    Imports cems.users
Imports cems.admin
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

        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        adminHomePagePanel.Visible = True

        User.activeCount(activeCPUNumber, "equipments", "equipment", "good", "CPU")
        User.activeCount(activeIPNumber, "equipments", "equipment", "good", "IP_phone")
        User.activeCount(activeMonitorNumber, "equipments", "equipment", "good", "monitor")


        User.activeCount(nonActiveCPUNumber, "equipments", "equipment", "bad", "CPU")
        User.activeCount(nonActiveIPNumber, "equipments", "equipment", "bad", "IP_phone")
        User.activeCount(nonActiveMonitorNumber, "equipments", "equipment", "bad", "monitor")
        admin.activeCount(userNumber, "users")

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


        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = True
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        User.displayTableP("posts", DataGridView2, sqlDataTableP)  'this is a useless comment

        fillHalls(hallSearchBoxP)
        fillcomboState(stateSearchBoxP, "posts", "post_state")

    End Sub
    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = True
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        If profileUpdatepanel.Visible = True Then
            profileSubPanel2.Visible = False
        End If

        connect_db()
        User.updateUserInformation("admin", "admin", Form1.emailtxt, adminNameProfile, adminEmailProfile, adminPhoneNumberProfile, adminTitleProfile)
    End Sub



    Private Sub equipmentsBtn_Click(sender As Object, e As EventArgs) Handles equipmentsBtn.Click
        Timer1.Start()


        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        User.display(adminEquipmentPanel, EquipmentTitle, "Equipments")
        User.displayTableE("equipments", DataGridView1, sqlDataTableE)

        fillHalls(hallSearchBoxE)
        fillcomboState(userSearchBoxE, "equipments", "equipment_state")

    End Sub


    Private Sub hallsBtn_Click(sender As Object, e As EventArgs) Handles hallsBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = True
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        User.displayTable("halls", DataGridView3, sqlDataTableH)


        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False
        hallUpdatePanel.Visible = False

        fillHalls(hallSearchBoxH)
    End Sub

    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles userBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = True
        adminRolePanel.Visible = False

        User.displayTableU("users", DataGridView4, sqlDataTableU)


        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False


    End Sub


    Private Sub rolesBtn_Click(sender As Object, e As EventArgs) Handles rolesBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = True
        adminRolePanel.Visible = False

        roleUpdateBtn.Visible = False

        User.displayTable("titles", DataGridView5, sqlDataTableR)


    End Sub



    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", DataGridView1)

        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub IPsBtn_Click(sender As Object, e As EventArgs) Handles IPsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", DataGridView1)

        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub monitorsBtn2_Click(sender As Object, e As EventArgs)
        User.display(adminEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", DataGridView1)

        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub


    Private Sub monitorsBtn_Click(sender As Object, e As EventArgs) Handles monitorsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", DataGridView1)

        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub



    Private Sub adminLogout_Click(sender As Object, e As EventArgs) Handles adminLogout.Click
        Form1.Show()
        Me.Visible = False
        Form1.emailtxt.Text = ""
        Form1.passwordtxt.Text = ""

        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

    End Sub



    'this is the second timer function which is used to make the timer stop

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick 'this stops the timer and make the messages disappear
        confirmMsgP.Visible = False
        confirmMsgE.Visible = False
        confirmMsgH.Visible = False
        confirmMsgU.Visible = False
        confirmMsgR.Visible = False
        addUserErrorMsg.Visible = False
        addEquipmentErrorMsg.Visible = False
        addRoleErrorMsg.Visible = False
        addHallErrorMsg.Visible = False
        addPostErrorMsg.Visible = False
        addUserErrorMsg.Visible = False
        updateProfileErrorMsg.Visible = False

        Timer2.Stop()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If DataGridView2.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub

End Class
