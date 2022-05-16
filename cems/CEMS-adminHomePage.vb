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

    Private Sub showUserName()
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


    Private Sub fillHalls(search As ComboBox)

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

    Private Sub fillcombo(search As ComboBox, table As String, fillvalue As String)

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


    'tab buttons section
    Private Sub postsBtn_Click(sender As Object, e As EventArgs) Handles postsBtn.Click

        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel

        adminPostPanel.Visible = True

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        postChangeStatePanel.Visible = False

        User.displayTableP("posts", DataGridView2, sqlDataTableP)

        fillHalls(hallSearchBoxP)

    End Sub
    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        adminEquipmentPanel.Visible = True 'this is set to true because somehow the postpanel is inside the equipmentpanel

        adminPostPanel.Visible = True  'this is set to true because somehow the profilepanel is inside the postpanel

        adminProfilePanel.Visible = True

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        If profileSubPanel2.Visible = True Then
            profileSubPanel2.Visible = False
        End If

        connect_db()
        User.updateUserInformation("admin", "admin", Form1.emailtxt, adminNameProfile, adminEmailProfile, adminPhoneNumberProfile, adminTitleProfile)
    End Sub



    Private Sub equipmentsBtn_Click(sender As Object, e As EventArgs) Handles equipmentsBtn.Click
        Timer1.Start()


        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        User.display(adminEquipmentPanel, EquipmentTitle, "Equipments")
        User.displayTableE("equipments", DataGridView1, sqlDataTableE)

        fillHalls(hallSearchBoxE)

    End Sub


    Private Sub hallsBtn_Click(sender As Object, e As EventArgs) Handles hallsBtn.Click
        adminEquipmentPanel.Visible = True 'this is set to true because somehow the hallpanel is inside the equipmentpanel

        adminHallsPanel.Visible = True

        adminPostPanel.Visible = True

        adminProfilePanel.Visible = True

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        User.displayTable("halls", DataGridView3, sqlDataTableH)

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False
        hallUpdatePanel.Visible = False

        fillHalls(hallSearchBoxH)
    End Sub

    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles userBtn.Click
        adminEquipmentPanel.Visible = True 'this is set to true because somehow the hallpanel is inside the equipmentpanel

        adminHallsPanel.Visible = True

        adminPostPanel.Visible = True

        adminProfilePanel.Visible = True

        adminUsersPanel.Visible = True

        adminRolePanel.Visible = False

        statePanel.Visible = False

        User.displayTableU("users", DataGridView4, sqlDataTableU)

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False


    End Sub

    Private Sub rolesBtn_Click(sender As Object, e As EventArgs) Handles rolesBtn.Click
        adminEquipmentPanel.Visible = True 'this is set to true because somehow the hallpanel is inside the equipmentpanel

        adminHallsPanel.Visible = True

        adminPostPanel.Visible = True

        adminProfilePanel.Visible = True

        adminUsersPanel.Visible = True

        adminRolePanel.Visible = True

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        roleUpdateBtn.Visible = False

        User.displayTable("titles", DataGridView5, sqlDataTableR)


    End Sub


    'equipments secondary buttons clicks

    Private Sub CPUsBtn2_Click(sender As Object, e As EventArgs) Handles CPUsBtn2.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", DataGridView1)

        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", DataGridView1)

        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminRolePanel.Visible = False

        adminUsersPanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub IPsBtn2_Click(sender As Object, e As EventArgs) Handles IPsBtn2.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", DataGridView1)

        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub
    Private Sub IPsBtn_Click(sender As Object, e As EventArgs) Handles IPsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", DataGridView1)

        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub monitorsBtn2_Click(sender As Object, e As EventArgs) Handles monitorsBtn2.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", DataGridView1)

        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub


    Private Sub monitorsBtn_Click(sender As Object, e As EventArgs) Handles monitorsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", DataGridView1)

        adminEquipmentPanel.Visible = True

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub adminLogout_Click(sender As Object, e As EventArgs) Handles adminLogout.Click
        Form1.Show()
        Me.Visible = False
        Form1.emailtxt.Text = ""
        Form1.passwordtxt.Text = ""

        adminEquipmentPanel.Visible = False

        adminPostPanel.Visible = False

        adminProfilePanel.Visible = False

        adminHallsPanel.Visible = False

        adminUsersPanel.Visible = False

        adminRolePanel.Visible = False

        statePanel.Visible = False

        addPostPanel.Visible = False

        addEquipmentPanel.Visible = False

    End Sub

    'update buttons 
    'profile updates
    Private Sub updateProfileShowBtn_Click(sender As Object, e As EventArgs) Handles updateProfileShowBtn.Click
        profileSubPanel2.Visible = True

        userNameProfileInput.Text = adminNameProfile.Text
        userPhoneNumberProfileInput.Text = adminPhoneNumberProfile.Text
        userEmailProfileInput.Text = adminEmailProfile.Text


        userPwdProfileInput.Text = ""
        userConfirmPwdProfileInput.Text = ""


    End Sub

    Private Sub updateProfileCancelBtn_Click(sender As Object, e As EventArgs) Handles updateProfileCancelBtn.Click
        profileSubPanel2.Visible = False
        updateProfileErrorMsg.Visible = False
    End Sub

    Private Sub updateProfileValidateBtn_Click(sender As Object, e As EventArgs) Handles updateProfileValidateBtn.Click

        User.updateUser("admin", "admin", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, userPwdProfileInput.Text, userConfirmPwdProfileInput.Text, Form1.emailtxt.Text, updateProfileErrorMsg, profileSubPanel2, Timer2)
        User.updateUserInformation("admin", "admin", Form1.emailtxt, adminNameProfile, adminEmailProfile, adminPhoneNumberProfile, adminTitleProfile)

        showUserName()
    End Sub

    'searches section

    'equipment searches
    Private Sub equipmentSearchBox_textChanged(sender As Object, e As EventArgs) Handles equipmentSearchBox.TextChanged

        User.search("equipments", DataGridView1, "post_id", equipmentSearchBox.Text, searchErrorE, sqlDataTableE)

    End Sub

    Private Sub hallSearchBoxE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxE.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        connect_db()

        Try
            sqlConn.Open()

            sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & hallSearchBoxE.Text & "'"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            While (sqlReader.Read())
                hall_id = sqlReader.Item("hall_id")
            End While

            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try

        User.searchHall("equipments", DataGridView1, "hall_id", hall_id, searchErrorE, sqlDataTableCBHE)
    End Sub

    'post searches

    Private Sub postSearchBox_textChanged(sender As Object, e As EventArgs) Handles postSearchBox.TextChanged

        User.searchP("posts", DataGridView2, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)

    End Sub

    'post hall search
    Private Sub hallSearchBoxP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxP.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        connect_db()

        Try
            sqlConn.Open()

            sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & hallSearchBoxP.Text & "'"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            While (sqlReader.Read())
                hall_id = sqlReader.Item("hall_id")
            End While

            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try

        User.searchHallP("posts", DataGridView2, "hall_id", hall_id, searchErrorP, sqlDataTableCBHP)
    End Sub

    'halls search

    Private Sub hallSearchH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxH.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        connect_db()

        Try
            sqlConn.Open()

            sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & hallSearchBoxH.Text & "'"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            While (sqlReader.Read())
                hall_id = sqlReader.Item("hall_id")
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try


        admin.generalSearchH("halls", DataGridView3, "hall_id", hall_id, searchErrorH, sqlDataTableCBH)
    End Sub

    'user searches
    Private Sub userSearchBox_textChanged(sender As Object, e As EventArgs) Handles userSearchBox.TextChanged

        User.searchU("users", DataGridView4, "user_name", userSearchBox.Text, searchErrorU, sqlDataTableU)

    End Sub

    'export buttons 
    Private Sub exportBtnP_Click(sender As Object, e As EventArgs) Handles exportBtnP.Click 'post 

        Try

            User.export(DataGridView2, "posts")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        confirmMsgP.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()

    End Sub

    Private Sub exportBtnH_Click(sender As Object, e As EventArgs) Handles exportBtnH.Click 'hall

        Try

            User.export(DataGridView3, "halls")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        'this will make the message appear for three seconds
        confirmMsgH.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()
    End Sub

    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click 'equipment 

        Try

            User.export(DataGridView1, "equipments")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        'this will make the message appear for three seconds
        confirmMsgE.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()
    End Sub

    Private Sub exportBtnu_Click(sender As Object, e As EventArgs) Handles exportBtnU.Click 'user 

        Try

            User.export(DataGridView4, "users")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        'this will make the message appear for three seconds
        confirmMsgU.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()
    End Sub

    Private Sub exportBtnR_Click(sender As Object, e As EventArgs) Handles exportBtnR.Click 'Role 

        Try

            User.export(DataGridView5, "Roles")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        confirmMsgR.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()

    End Sub


    'UPDATES
    'USER SECTION 
    Private Sub userUpdateBtn_Click(sender As Object, e As EventArgs) Handles userUpdateBtn.Click 'update
        userUpdatePanel.Visible = True

        userUserTitleInput.Items.Clear()

        Try
            sqlConn.Open()

            sqlQuery = "select * from  cems.cems_titles"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                userUserTitleInput.Items.Add(sqlReader.Item("title_name"))

            End While
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try

    End Sub

    Private Sub userdeleteBtn_Click(sender As Object, e As EventArgs) Handles userDeleteBtn.Click 'delete

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this user ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then
            admin.deleteRecord(DataGridView4, "users", "user")
        End If

        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False

        User.displayTableU("users", DataGridView4, sqlDataTableU)

    End Sub

    Private Sub userupdatevalidationBtn_Click(sender As Object, e As EventArgs) Handles userUpdateValidationBtn.Click 'validate update 
        connect_db()

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
            MessageBox.Show(title_id)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try

        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        'this changes the hall name

        With sqlCmd

            .CommandText = "Update cems.cems_users set user_name ='" & userUserNameInput.Text & "', user_email = '" & userUserEmailInput.Text & "', user_phone_number = '" & userUserPhoneInput.Text & "', title_id = '" & title_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        'this updates the datagridview
        User.displayTableU("users", DataGridView4, sqlDataTableU)

        'this changes the content of confirmMsg
        confirmMsgU.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        confirmMsgU.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()


        'this makes the update panel to disappear
        userUpdatePanel.Visible = False

        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
    End Sub

    Private Sub userUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles userCancelBtn.Click 'cancel
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False

    End Sub

    'this is the second timer function which is used to make the timer stop


    Private Sub DataGridView4_CellClick() Handles DataGridView4.CellClick 'the cellclicked event

        Try
            userUserNameInput.Text = DataGridView4.SelectedRows(0).Cells(1).Value.ToString
            userUserEmailInput.Text = DataGridView4.SelectedRows(0).Cells(2).Value.ToString
            userUserPhoneInput.Text = DataGridView4.SelectedRows(0).Cells(3).Value.ToString
            userUserTitleInput.Text = DataGridView4.SelectedRows(0).Cells(4).Value.ToString

            userUpdateBtn.Visible = True
            userDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    'EQUIPMENT SECTION
    Private Sub DataGridView1_CellClick() Handles DataGridView1.CellClick

        Try
            equipmentState.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString

            statePanel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub stateChangeBtn_Click(sender As Object, e As EventArgs) Handles stateChangeBtn.Click
        Dim equipment_id As Integer = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_equipments Set equipment_state ='" & equipmentState.Text & "' where equipment_id = '" & equipment_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()



        statePanel.Visible = False

        User.displayTableE("equipments", DataGridView1, sqlDataTableE)
    End Sub

    Private Sub equipmentdeleteBtn_Click(sender As Object, e As EventArgs) Handles equipmentDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this equipment ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(DataGridView1, "equipments", "equipment")
        End If

        statePanel.Visible = False

        User.displayTableE("equipments", DataGridView1, sqlDataTableE)

    End Sub

    'POST SECTION
    Private Sub DataGridView2_CellClick() Handles DataGridView2.CellClick

        Try
            postChangeStateInput.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString

            postChangeStatePanel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub postChangeBtn_Click(sender As Object, e As EventArgs) Handles postChangeBtn.Click
        Dim post_id As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_posts Set post_state ='" & postChangeStateInput.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_equipments Set equipment_state ='" & postChangeStateInput.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


        postChangeStatePanel.Visible = False

        User.displayTableP("posts", DataGridView2, sqlDataTableP)
    End Sub

    Private Sub postdeleteBtn_Click(sender As Object, e As EventArgs) Handles postDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this post ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deletePost(DataGridView2, "posts", "post")
        End If

        postChangeStatePanel.Visible = True

        User.displayTableP("posts", DataGridView2, sqlDataTableP)

    End Sub

    'ROLES SECTION 
    Private Sub RoleUpdateBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateBtn.Click 'update
        roleUpdatePanel.Visible = True
    End Sub

    Private Sub roledeleteBtn_Click(sender As Object, e As EventArgs)  'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this role ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(DataGridView5, "titles", "title")

        End If

        roleUpdateBtn.Visible = False
        User.displayTable("titles", DataGridView5, sqlDataTableR)

    End Sub

    Private Sub roleUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateValidationBtn.Click 'validate update 
        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        'this changes the role name

        With sqlCmd

            .CommandText = "Update cems.cems_titles Set title_name ='" & titleNameInput.Text & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        'this updates the datagridview
        User.displayTable("titles", DataGridView5, sqlDataTableR)

        'this changes the content of confirmMsg
        confirmMsgR.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        confirmMsgR.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()


        'this makes the update panel to disappear
        roleUpdatePanel.Visible = False

        roleUpdateBtn.Visible = False
    End Sub

    Private Sub roleUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateCancelBtn.Click 'cancel
        roleUpdatePanel.Visible = False
        roleUpdateBtn.Visible = False
    End Sub


    Private Sub DataGridView5_CellClick() Handles DataGridView5.CellClick 'the cellclicked event

        Try
            titleNameInput.Text = DataGridView5.SelectedRows(0).Cells(1).Value.ToString
            roleUpdateBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'HALL SECTION 
    Private Sub HallUpdateBtn_Click(sender As Object, e As EventArgs) Handles HallUpdateBtn.Click 'update
        hallUpdatePanel.Visible = True
    End Sub

    Private Sub HalldeleteBtn_Click(sender As Object, e As EventArgs) Handles HallDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this hall ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(DataGridView3, "halls", "hall")

        End If

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False

        User.displayTable("halls", DataGridView3, sqlDataTableH)

    End Sub

    Private Sub hallUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateValidateBtn.Click 'validate update 
        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        'this changes the hall name

        With sqlCmd

            .CommandText = "Update cems.cems_halls Set hall_name ='" & adminUpdateHallNameInput.Text & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        'this updates the datagridview
        User.displayTable("halls", DataGridView3, sqlDataTableH)

        'this changes the content of confirmMsg
        confirmMsgH.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        confirmMsgH.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()


        'this makes the update panel to disappear
        hallUpdatePanel.Visible = False

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False
    End Sub

    Private Sub hallUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateCancelBtn.Click 'cancel
        hallUpdatePanel.Visible = False

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False
    End Sub

    'this is the second timer function which is used to make the timer stop


    Private Sub DataGridView3_CellClick() Handles DataGridView3.CellClick 'the cellclicked event

        Try
            adminUpdateHallNameInput.Text = DataGridView3.SelectedRows(0).Cells(1).Value.ToString
            HallUpdateBtn.Visible = True
            HallDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    'add 
    'HALL add Section
    Private Sub hallAddBtn_Click(sender As Object, e As EventArgs) Handles hallAddBtn.Click 'add 
        hallUpdatePanel.Visible = True 'add panel is on update panel so updatepanel has to be visible 
        hallAddpanel.Visible = True
    End Sub

    Private Sub HallAddCancelBtn_Click(sender As Object, e As EventArgs) Handles HallAddCancelBtn.Click 'cancel add
        hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        hallAddpanel.Visible = False
    End Sub


    Private Sub HallAddValidateBtn_Click(sender As Object, e As EventArgs) Handles HallAddValidateBtn.Click 'validate add

        connect_db()

        If adminAddHallNameInput.Text = "" Then
            addHallErrorMsg.Text = "please fill the field !"
            addHallErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_halls(hall_name) values ('" & adminAddHallNameInput.Text & "')"
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
            User.displayTable("halls", DataGridView3, sqlDataTableH)

            'this changes the content of confirmMsg
            confirmMsgH.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            confirmMsgH.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()


            'this makes the add panel to disappear
            hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            hallAddpanel.Visible = False
        End If
    End Sub

    'Equipment add section
    Private Sub addEquipmentBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentBtn.Click
        addEquipmentPanel.Visible = True
        fillcombo(postIdInput, "posts", "post_id")
        fillHalls(hallInput)
    End Sub

    Private Sub addEquipmentCancelBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentCancelBtn.Click
        addEquipmentPanel.Visible = False

        statePanel.Visible = False
    End Sub

    Private Sub addEquipmentValidationBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentValidationBtn.Click
        connect_db()

        If equipmentTypeInput.Text = "" Or equipmentStateInput.Text = "" Or hallInput.Text = "" Then
            addEquipmentErrorMsg.Text = "please fill all the fields !"
            addEquipmentErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        Else
            Dim hall_id As Integer
            Dim post_id As String = postIdInput.Text
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & hallInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    hall_id = sqlReader.Item("hall_id")
                End While

                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try

            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

                'this updates the datagridview
                User.displayTableE("equipments", DataGridView1, sqlDataTableE)

                'this changes the content of confirmMsg
                confirmMsgE.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                confirmMsgE.Visible = True
                Timer2.Interval = 3000
                Timer2.Start()


                'this makes the add panel to disappear
                statePanel.Visible = False  'play it safe and make both panels visible false 
                addEquipmentPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try
        End If

    End Sub

    'POST add section
    Private Sub addPosttBtn_Click(sender As Object, e As EventArgs) Handles addPostBtn.Click
        addPostPanel.Visible = True
        fillHalls(postHallInput)
    End Sub

    Private Sub addPostCancelBtn_Click(sender As Object, e As EventArgs) Handles addPostCancelBtn.Click
        addPostPanel.Visible = False

        postChangeStatePanel.Visible = False
    End Sub

    Private Sub addPostValidationBtn_Click(sender As Object, e As EventArgs) Handles addPostValidationBtn.Click
        connect_db()

        If postStateInput.Text = "" Or postHallInput.Text = "" Then
            addPostErrorMsg.Text = "please fill all the fields !"
            addPostErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        Else
            Dim hall_id As Integer
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & postHallInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    hall_id = sqlReader.Item("hall_id")
                End While

                sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try

            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_posts(post_id,hall_id, post_state) values ('" & postPostIdInput.Text & "','" & hall_id & "','" & postStateInput.Text & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

                Dim post_id As String = postPostIdInput.Text

                sqlConn.Open()
                sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('IP_Phone','" & postStateInput.Text & "','" & post_id & "','" & hall_id & "');insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('CPU','" & postStateInput.Text & "','" & post_id & "','" & hall_id & "');insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('Monitor','" & postStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()


                'this updates the datagridview
                User.displayTableP("posts", DataGridView2, sqlDataTableP)

                'this changes the content of confirmMsg
                confirmMsgP.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                confirmMsgP.Visible = True
                Timer2.Interval = 3000
                Timer2.Start()


                'this makes the add panel to disappear
                postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                addPostPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try




        End If

    End Sub


    'ROLE add Section
    Private Sub roleAddBtn_Click(sender As Object, e As EventArgs) Handles roleAddBtn.Click 'add 
        roleUpdatePanel.Visible = True 'add panel is on update panel so updatepanel has to be visible 
        roleAddPanel.Visible = True
    End Sub

    Private Sub roleAddCancelBtn_Click(sender As Object, e As EventArgs) Handles roleAddCancelBtn.Click 'cancel add
        roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        roleAddPanel.Visible = False
    End Sub


    Private Sub roleAddValidateBtn_Click(sender As Object, e As EventArgs) Handles roleAddValidationBtn.Click 'validate add

        connect_db()

        If titleAddNameInput.Text = "" Then
            addRoleErrorMsg.Text = "please fill the field"
            addRoleErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_titles(title_name) values ('" & titleAddNameInput.Text & "')"
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
            User.displayTable("titles", DataGridView5, sqlDataTableR)

            'this changes the content of confirmMsg
            confirmMsgR.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            confirmMsgR.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()


            'this makes the add panel to disappear
            roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            roleAddPanel.Visible = False

        End If
    End Sub


    'user add Section
    Private Sub userAddBtn_Click(sender As Object, e As EventArgs) Handles userAddBtn.Click 'add 
        userUpdatePanel.Visible = True 'add panel is on update panel so updatepanel has to be visible 
        userAddPanel.Visible = True

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
    End Sub

    Private Sub userAddCancelBtn_Click(sender As Object, e As EventArgs) Handles userAddCancelBtn.Click 'cancel add
        userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        userAddPanel.Visible = False
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

                If title_id = 1 Or title_id = 3 Then
                    Try
                        sqlConn.Open()
                        sqlQuery = "insert into cems.cems_admin(admin_name, admin_email, admin_phone_number, admin_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & userUserAddConfirmPwdInput.Text & "','" & title_id & "')"
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
                        sqlQuery = "insert into cems.cems_users(user_name, user_email, user_phone_number, user_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & userUserAddConfirmPwdInput.Text & "','" & title_id & "')"
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
                User.displayTableU("users", DataGridView4, sqlDataTableU)

                'this changes the content of confirmMsg
                confirmMsgU.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                confirmMsgU.Visible = True
                Timer2.Interval = 3000
                Timer2.Start()


                'this makes the add panel to disappear
                userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
                userAddPanel.Visible = False

            End If

        End If
    End Sub


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

    Private Sub printBtnP_Click(sender As Object, e As EventArgs) Handles printBtnP.Click

        Try
            Dim height As Integer = DataGridView2.Height
            DataGridView2.Height = DataGridView2.RowCount * DataGridView2.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView2.Width, Me.DataGridView2.Height)
            DataGridView2.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView2.Width, Me.DataGridView2.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            DataGridView2.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub printBtnE_Click(sender As Object, e As EventArgs) Handles printBtnE.Click

        Try
            Dim height As Integer = DataGridView1.Height
            DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
            DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            DataGridView1.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub
    Private Sub printBtnh_Click(sender As Object, e As EventArgs) Handles PrintBtnH.Click

        Try
            Dim height As Integer = DataGridView3.Height
            DataGridView3.Height = DataGridView3.RowCount * DataGridView3.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView3.Width, Me.DataGridView3.Height)
            DataGridView3.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView3.Width, Me.DataGridView3.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            DataGridView3.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub printBtnu_Click(sender As Object, e As EventArgs) Handles PrintBtnU.Click

        Try
            Dim height As Integer = DataGridView4.Height
            DataGridView4.Height = DataGridView4.RowCount * DataGridView4.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView4.Width, Me.DataGridView4.Height)
            DataGridView4.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView4.Width, Me.DataGridView4.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            DataGridView4.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub printBtnr_Click(sender As Object, e As EventArgs) Handles PrintBtnR.Click

        Try
            Dim height As Integer = DataGridView5.Height
            DataGridView5.Height = DataGridView5.RowCount * DataGridView5.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView5.Width, Me.DataGridView5.Height)
            DataGridView5.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView5.Width, Me.DataGridView5.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            DataGridView5.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If Me.DataGridView2.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
End Class
