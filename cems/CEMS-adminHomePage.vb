Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports Org.BouncyCastle.Crypto.Generators
Imports BCrypt.Net.BCrypt

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

    'this is used in the print function
    Dim bitmap As Bitmap


    'this is for the sidebar dropdown
    Dim iscollapsed As Boolean = True

    'connection functoin
    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
               + "password=" + password + ";" + "database =" + database
    End Sub


    'FAILED EXPERIMENT TO REDUCE THE NUMBER OF QUERRIES USED BY QUERRYING ONCE AND STORING IT IN VARIABLES
    'Public Sub getEverything(name As String, email As String)
    '    connect_db()
    '    Try
    '        sqlConn.Open()
    '        'username appear
    '        sqlQuery = "select * from cems.cems_admin where admin_email = '" & Form1.emailtxt.Text & "'"
    '        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
    '        sqlReader = sqlCmd.ExecuteReader
    '        If (sqlReader.Read()) Then
    '            name = sqlReader.Item("admin_name")
    '            email = sqlReader.Item("admin_email")
    '
    '        End If
    '
    '        sqlConn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Finally
    '        sqlConn.Dispose()
    '    End Try
    'End Sub

    Private Sub adminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()

        User.showUserName(Form1.emailtxt, aName)

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

    'POST SECTION
    Private Sub DataGridView2_CellClick() Handles postDataGridView.CellClick

        Try
            postChangeStateInput.Text = postDataGridView.SelectedRows(0).Cells(1).Value.ToString

            postChangeStatePanel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'post buttons
    Private Sub postsBtn_Click(sender As Object, e As EventArgs) Handles postsBtn.Click


        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = True
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        postChangeStatePanel.Visible = False
        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userUpdatePanel.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""



        User.displayTableP("posts", postDataGridView, sqlDataTableP)  'this is a useless comment //you're the useless comment !

        fillHalls(hallSearchBoxP)
        fillcomboState(stateSearchBoxP, "posts", "post_state")

        postTitle.Text = "Posts"
        postDataGridView.Visible = True
        postSearchBox.Visible = True
        postsearchlabel.Visible = True
        addPostBtn.Visible = True
        exportBtnP.Visible = True
        'printBtnP.Visible = True
    End Sub


    'POST add section
    Private Sub addPostBtn_Click(sender As Object, e As EventArgs) Handles addPostBtn.Click
        addPostPanel.Visible = True

        fillHalls(postHallInput)

        postTitle.Text = "Add posts"
        postDataGridView.Visible = False
        postSearchBox.Visible = False
        postsearchlabel.Visible = False
        addPostBtn.Visible = False
        exportBtnP.Visible = False
        postChangeStatePanel.Visible = False
        searchErrorP.Visible = False

        'printBtnP.Visible = False
    End Sub


    Private Sub addPostValidationBtn_Click(sender As Object, e As EventArgs) Handles addPostValidationBtn.Click
        connect_db()

        If postStateInput.Text = "" And postHallInput.Text = "" Then
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
                MessageBox.Show(ex.Message, "MySql get all halls ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try


            Try
                sqlConn.Open()
                sqlQuery = "select * from cems_posts where post_id = '" & postPostIdInput.Text & "'"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                If (sqlReader.Read()) Then
                    addPostErrorMsg.Text = "post already exist try another one"
                    addPostErrorMsg.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()
                    sqlConn.Close()
                Else

                    If postHallInput.Text = "" Then
                        Try
                            sqlConn.Close()
                            sqlConn.Open()
                            sqlQuery = "insert into cems.cems_posts(post_id,hall_id, post_state) values ('" & postPostIdInput.Text & "',1,'" & postStateInput.Text & "')"
                            'Read through the response'
                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            sqlConn.Close()

                            Dim post_id As String = postPostIdInput.Text

                            sqlConn.Open()
                            sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('IP_Phone','" & postStateInput.Text & "','" & post_id & "',1);insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('CPU','" & postStateInput.Text & "','" & post_id & "',1);insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('Monitor','" & postStateInput.Text & "','" & post_id & "',1)"
                            'Read through the response'
                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            sqlConn.Close()


                            'this updates the datagridview
                            User.displayTableP("posts", postDataGridView, sqlDataTableP)

                            'this changes the content of confirmMsg
                            confirmMsgP.Text = "Item successfully added ✔"

                            'this makes the confirm message appear for 3secs
                            confirmMsgP.Visible = True
                            Timer2.Interval = 3000
                            Timer2.Start()


                            'this makes the add panel to disappear
                            postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                            addPostPanel.Visible = False

                            'empty the fields after validation
                            postStateInput.Text = ""
                            postHallInput.Text = ""

                            postTitle.Text = "Posts"
                            postDataGridView.Visible = True
                            postSearchBox.Visible = True
                            postsearchlabel.Visible = True
                            addPostBtn.Visible = True
                            exportBtnP.Visible = True
                            'printBtnP.Visible = True


                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "MySql add post ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Finally
                            sqlConn.Dispose()
                        End Try
                    Else
                        Try
                            sqlConn.Close()
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
                            User.displayTableP("posts", postDataGridView, sqlDataTableP)

                            'this changes the content of confirmMsg
                            confirmMsgP.Text = "Item successfully added ✔"

                            'this makes the confirm message appear for 3secs
                            confirmMsgP.Visible = True
                            Timer2.Interval = 3000
                            Timer2.Start()


                            'this makes the add panel to disappear
                            postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                            addPostPanel.Visible = False

                            'empty the fields after validation
                            postStateInput.Text = ""
                            postHallInput.Text = ""

                            postTitle.Text = "Posts"
                            postDataGridView.Visible = True
                            postSearchBox.Visible = True
                            postsearchlabel.Visible = True
                            addPostBtn.Visible = True
                            exportBtnP.Visible = True
                            'printBtnP.Visible = True


                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "MySql add post ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Finally
                            sqlConn.Dispose()
                        End Try

                    End If

                End If
                    sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql get post and test it", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Finally
                sqlConn.Dispose()
            End Try


        End If

    End Sub

    Private Sub addPostCancelBtn_Click(sender As Object, e As EventArgs) Handles addPostCancelBtn.Click
        addPostPanel.Visible = False

        postChangeStatePanel.Visible = False

        'empty the fields after validation
        postStateInput.Text = ""
        postHallInput.Text = ""

        postTitle.Text = "Posts"
        postDataGridView.Visible = True
        postSearchBox.Visible = True
        postsearchlabel.Visible = True
        addPostBtn.Visible = True
        exportBtnP.Visible = True


        'this updates the datagridview
        User.displayTableP("posts", postDataGridView, sqlDataTableP)
        searchErrorP.Visible = False
        'printBtnP.Visible = true
    End Sub

    'delete post button
    Private Sub postdeleteBtn_Click(sender As Object, e As EventArgs) Handles postDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this post ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deletePost(postDataGridView, "posts", "post")
        End If

        postChangeStatePanel.Visible = True

        User.displayTableP("posts", postDataGridView, sqlDataTableP)

    End Sub

    'change post button
    Private Sub postChangeBtn_Click(sender As Object, e As EventArgs) Handles postChangeBtn.Click
        Dim post_id As String = postDataGridView.SelectedRows(0).Cells(0).Value.ToString
        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd
            'possible problem
            .CommandText = "Update cems.cems_posts Set post_state ='" & postChangeStateInput.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


        'this was to update the equipment state when the post state was changed. It was removed because we are changing the order of update state so that equipment state change changes post state
        'sqlConn.Open()
        '
        'sqlCmd.Connection = sqlConn
        '
        'With sqlCmd
        '
        '    .CommandText = "Update cems.cems_equipments Set equipment_state ='" & postChangeStateInput.Text & "' where post_id = '" & post_id & "'"
        '
        '    .CommandType = CommandType.Text
        '
        'End With
        'sqlCmd.ExecuteNonQuery()
        'sqlConn.Close()


        postChangeStatePanel.Visible = False



        User.displayTableP("posts", postDataGridView, sqlDataTableP)
    End Sub

    'profile button
    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = True
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        profileSubPanel2.Visible = False
        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        connect_db()
        User.updateUserInformation("users", "user", Form1.emailtxt, adminNameProfile, adminEmailProfile, adminPhoneNumberProfile, adminTitleProfile)
    End Sub

    'update profile button

    Private Sub updateProfileShowBtn_Click(sender As Object, e As EventArgs) Handles updateProfileShowBtn.Click
        profileSubPanel2.Visible = True

        userNameProfileInput.Text = adminNameProfile.Text
        userPhoneNumberProfileInput.Text = adminPhoneNumberProfile.Text
        userEmailProfileInput.Text = adminEmailProfile.Text

        userPwdProfileInput.Text = ""
        userConfirmPwdProfileInput.Text = ""


    End Sub

    'profile cancel
    Private Sub updateProfileCancelBtn_Click(sender As Object, e As EventArgs) Handles updateProfileCancelBtn.Click
        profileSubPanel2.Visible = False
        updateProfileErrorMsg.Visible = False
    End Sub

    Private Sub updateProfileValidateBtn_Click(sender As Object, e As EventArgs) Handles updateProfileValidateBtn.Click

        User.updateUser("users", "user", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, userPwdProfileInput.Text, userConfirmPwdProfileInput.Text, Form1.emailtxt.Text, updateProfileErrorMsg, profileSubPanel2, Timer2)
        User.updateUserInformation("users", "user", Form1.emailtxt, adminNameProfile, adminEmailProfile, adminPhoneNumberProfile, adminTitleProfile)

        profileSubPanel2.Visible = False


        'this changes the content of confirmMsg
        confirmMsgPr.Visible = True

        'timer duration
        Timer2.Interval = 3000
        Timer2.Start()

        User.showUserName(Form1.emailtxt, aName)
    End Sub


    'halls buttons

    'HALL add Section
    Private Sub hallAddBtn_Click(sender As Object, e As EventArgs) Handles hallAddBtn.Click 'add 
        hallUpdatePanel.Visible = False 'add panel is on update panel so updatepanel has to be visible 
        hallAddpanel.Visible = True
        Label21.Text = "Add halls"


        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = False
        exportBtnH.Visible = False
        'PrintBtnH.Visible = False
        hallSearchBoxH.Visible = False
        Label4.Visible = False
        hallDataGridView.Visible = False
        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False

    End Sub

    Private Sub hallsBtn_Click(sender As Object, e As EventArgs) Handles hallsBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = True
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False


        User.displayTable("halls", hallDataGridView, sqlDataTableH)


        addPostPanel.Visible = False
        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False
        hallUpdatePanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxH)


        Label21.Text = "Halls"

        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        Label4.Visible = True
        hallDataGridView.Visible = True

    End Sub

    'hall add buttons
    Private Sub HallAddCancelBtn_Click(sender As Object, e As EventArgs) Handles HallAddCancelBtn.Click 'cancel add
        hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        hallAddpanel.Visible = False
        Label21.Text = "Halls"

        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        Label4.Visible = True
        hallDataGridView.Visible = True

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
            User.displayTable("halls", hallDataGridView, sqlDataTableH)

            'this changes the content of confirmMsg
            confirmMsgH.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            confirmMsgH.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()


            'this makes the add panel to disappear
            hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            hallAddpanel.Visible = False

            adminAddHallNameInput.Text = ""
            fillHalls(hallSearchBoxH)

            HallUpdateBtn.Visible = False
            HallDeleteBtn.Visible = False

            Label21.Text = "Halls"

            'things that have to disappear (this is annoying)
            hallAddBtn.Visible = True
            exportBtnH.Visible = True
            'PrintBtnH.Visible = True
            hallSearchBoxH.Visible = True
            Label4.Visible = True
            hallDataGridView.Visible = True
        End If


    End Sub

    'hall update buttons 

    Private Sub DataGridView3_CellClick() Handles hallDataGridView.CellClick 'the cellclicked event

        Try
            adminUpdateHallNameInput.Text = hallDataGridView.SelectedRows(0).Cells(1).Value.ToString
            HallUpdateBtn.Visible = True
            HallDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub HallUpdateBtn_Click(sender As Object, e As EventArgs) Handles HallUpdateBtn.Click 'update
        hallUpdatePanel.Visible = True

        Label21.Text = "Update halls"


        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = False
        exportBtnH.Visible = False
        'PrintBtnH.Visible = False
        hallSearchBoxH.Visible = False
        Label4.Visible = False
        hallDataGridView.Visible = False
        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False

    End Sub

    Private Sub HalldeleteBtn_Click(sender As Object, e As EventArgs) Handles HallDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this hall ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(hallDataGridView, "halls", "hall")

        End If

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False

        User.displayTable("halls", hallDataGridView, sqlDataTableH)
        fillHalls(hallSearchBoxH)

    End Sub

    Private Sub hallUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateCancelBtn.Click 'cancel
        hallUpdatePanel.Visible = False

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False

        Label21.Text = "Halls"

        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        Label4.Visible = True
        hallDataGridView.Visible = True

    End Sub

    Private Sub hallUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateValidateBtn.Click 'validate update 

        Dim hall_id As String = hallDataGridView.SelectedRows(0).Cells(0).Value.ToString

        connect_db()

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
        User.displayTable("halls", hallDataGridView, sqlDataTableH)

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

        adminUpdateHallNameInput.Text = ""
        fillHalls(hallSearchBoxH)


        Label21.Text = "Halls"

        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        Label4.Visible = True
        hallDataGridView.Visible = True

    End Sub


    'user buttons

    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles userBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminRolePanel.Visible = False
        adminUsersPanel.Visible = True

        User.displayTableU("users", userDataGridView, sqlDataTableU)

        addPostPanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""


        Label10.Text = "users"


        userDataGridView.Visible = True
        addPostPanel.Visible = True
        userDeleteBtn.Visible = False
        userUpdateBtn.Visible = False
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        userAddBtn.Visible = True
        searchuserlabel.Visible = True

    End Sub


    Private Sub usersBtn2_Click(sender As Object, e As EventArgs) Handles usersBtn2.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminRolePanel.Visible = False
        adminUsersPanel.Visible = True

        User.displayTableU("users", userDataGridView, sqlDataTableU)

    End Sub
    'user update section

    Private Sub userupdatevalidationBtn_Click(sender As Object, e As EventArgs) Handles userUpdateValidationBtn.Click  'validate update 
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try


        Dim user_id As String = userDataGridView.SelectedRows(0).Cells(0).Value.ToString


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
        User.displayTableU("users", userDataGridView, sqlDataTableU)

        'this changes the content of confirmMsg
        confirmMsgU.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        confirmMsgU.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()


        'this makes the update panel to disappear
        userUpdatePanel.Visible = False

        userDeleteBtn.Visible = False


        Label10.Text = "Users"

        userDataGridView.Visible = True
        userUpdateBtn.Visible = True
        userAddBtn.Visible = True
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        searchuserlabel.Visible = True

        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False

    End Sub

    Private Sub userCancelBtn_Click(sender As Object, e As EventArgs) Handles userCancelBtn.Click 'cancel
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False


        Label10.Text = "Users"

        userDataGridView.Visible = True
        userAddBtn.Visible = True
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        searchuserlabel.Visible = True

    End Sub

    Private Sub DataGridView4_CellClick() Handles userDataGridView.CellClick 'the cellclicked event

        Try
            userUserNameInput.Text = userDataGridView.SelectedRows(0).Cells(1).Value.ToString
            userUserEmailInput.Text = userDataGridView.SelectedRows(0).Cells(2).Value.ToString
            userUserPhoneInput.Text = userDataGridView.SelectedRows(0).Cells(3).Value.ToString
            userUserTitleInput.Text = userDataGridView.SelectedRows(0).Cells(4).Value.ToString

            userUpdateBtn.Visible = True
            userDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

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


        Label10.Text = "Update user"

        userUpdateBtn.Visible = False
        userAddBtn.Visible = False
        exportBtnU.Visible = False
        'PrintBtnU.Visible = False
        searchuserlabel.Visible = False
        userDataGridView.Visible = False

    End Sub

    Private Sub userdeleteBtn_Click(sender As Object, e As EventArgs) Handles userDeleteBtn.Click 'delete

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this user ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then
            admin.deleteRecord(userDataGridView, "users", "user")
        End If

        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False

        User.displayTableU("users", userDataGridView, sqlDataTableU)



    End Sub


    'user add Section
    Private Sub userAddBtn_Click(sender As Object, e As EventArgs) Handles userAddBtn.Click 'add 
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


        Label10.Text = "Add user"

        userUpdateBtn.Visible = False
        userDataGridView.Visible = False
        exportBtnU.Visible = False
        'PrintBtnU.Visible = False
        searchuserlabel.Visible = False

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

                Try
                    sqlConn.Open()
                    sqlQuery = "select * from cems_users where user_email = '" & userUserAddEmailInput.Text & "'"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader

                    If (sqlReader.Read()) Then
                        addUserErrorMsg.Visible = True
                        addUserErrorMsg.Text = "This user already exists !"
                        Timer2.Interval = 3000
                        Timer2.Start()
                        sqlConn.Close()
                    Else

                        Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(userUserAddConfirmPwdInput.Text)
                        Try
                            sqlConn.Close()
                            sqlConn.Open()
                            sqlQuery = "insert into cems.cems_users(user_name, user_email, user_phone_number, user_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & hashedPassword & "','" & title_id & "')"
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
                        User.displayTableU("users", userDataGridView, sqlDataTableU)

                        'this changes the content of confirmMsg
                        confirmMsgU.Text = "Item successfully added ✔"

                        'this makes the confirm message appear for 3secs
                        confirmMsgU.Visible = True
                        Timer2.Interval = 3000
                        Timer2.Start()


                        'this makes the add panel to disappear
                        userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
                        userAddPanel.Visible = False

                        Label10.Text = "Users"

                        userDataGridView.Visible = True
                        userUpdateBtn.Visible = True
                        userAddBtn.Visible = True
                        exportBtnU.Visible = True
                        'PrintBtnU.Visible = True
                        searchuserlabel.Visible = True

                        userUpdateBtn.Visible = False
                        userDeleteBtn.Visible = False


                        'empty the fields after validation
                        userUserAddNameInput.Text = ""
                        userUserAddEmailInput.Text = ""
                        userUserAddPhoneInput.Text = ""
                        userUserAddPwdInput.Text = ""
                        userUserAddConfirmPwdInput.Text = ""
                        userUserAddTitleInput.Text = ""

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try




            End If

        End If



    End Sub

    Private Sub userAddCancelBtn_Click(sender As Object, e As EventArgs) Handles userAddCancelBtn.Click 'cancel add
        userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        userAddPanel.Visible = False

        'empty the fields after cancel
        userUserAddNameInput.Text = ""
        userUserAddEmailInput.Text = ""
        userUserAddPhoneInput.Text = ""
        userUserAddPwdInput.Text = ""
        userUserAddConfirmPwdInput.Text = ""
        userUserAddTitleInput.Text = ""

        Label10.Text = "Users"

        userDataGridView.Visible = True
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddBtn.Visible = True
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        searchuserlabel.Visible = True
        User.displayTableU("users", userDataGridView, sqlDataTableU)
        searchErrorU.Visible = False



    End Sub

    'role buttons 
    Private Sub rolesBtn_Click(sender As Object, e As EventArgs) Handles rolesBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = True

        addPostPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        roleAddPanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        User.displayTable("titles", roleDataGridView, sqlDataTableR)

        roleUpdateBtn.Visible = False
        roleDataGridView.Visible = True
        Roles.Text = "Roles"
        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True
    End Sub

    'role update buttons
    Private Sub roleUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateValidationBtn.Click 'validate update 

        If titleNameInput.Text = "" Then

        End If

        Dim role_id As String = roleDataGridView.SelectedRows(0).Cells(0).Value.ToString

        connect_db()

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
        User.displayTable("titles", roleDataGridView, sqlDataTableR)

        'this changes the content of confirmMsg
        confirmMsgR.Text = "update successfull ✔"

        'this makes the confirm message appear for 3secs
        confirmMsgR.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()


        'this makes the update panel to disappear
        roleUpdatePanel.Visible = False
        roleUpdateBtn.Visible = False
        roleAddPanel.Visible = False

        roleDataGridView.Visible = True
        Roles.Text = "Roles"
        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True

    End Sub

    Private Sub roleUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateCancelBtn.Click 'cancel
        roleUpdatePanel.Visible = False
        roleUpdateBtn.Visible = False

        roleDataGridView.Visible = True
        Roles.Text = "Roles"
        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True
    End Sub

    Private Sub DataGridView5_CellClick() Handles roleDataGridView.CellClick 'the cellclicked event

        Try
            titleNameInput.Text = roleDataGridView.SelectedRows(0).Cells(1).Value.ToString
            roleUpdateBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub


    Private Sub RoleUpdateBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateBtn.Click 'update
        roleUpdatePanel.Visible = True

        roleUpdateBtn.Visible = False
        roleDataGridView.Visible = False
        Roles.Text = "Update roles"
        roleAddBtn.Visible = False
        exportBtnR.Visible = False
        'PrintBtnR.Visible = False
    End Sub

    Private Sub roleDeleteBtn_Click_1(sender As Object, e As EventArgs) Handles roleDeleteBtn.Click  'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this role ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(roleDataGridView, "titles", "title")

        End If

        roleUpdateBtn.Visible = False
        User.displayTable("titles", roleDataGridView, sqlDataTableR)
    End Sub


    'role add buttons

    Private Sub roleAddBtn_Click(sender As Object, e As EventArgs) Handles roleAddBtn.Click 'add 
        roleUpdatePanel.Visible = False 'add panel is on update panel so updatepanel has to be visible 
        roleAddPanel.Visible = True

        roleUpdateBtn.Visible = False
        roleDataGridView.Visible = False
        Roles.Text = "Add roles"
        roleAddBtn.Visible = False
        exportBtnR.Visible = False
        'PrintBtnR.Visible = False
    End Sub
    Private Sub roleAddValidationBtn_Click(sender As Object, e As EventArgs) Handles roleAddValidationBtn.Click 'validate add

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
            User.displayTable("titles", roleDataGridView, sqlDataTableR)

            'this changes the content of confirmMsg
            confirmMsgR.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            confirmMsgR.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()


            'this makes the add panel to disappear
            roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            roleAddPanel.Visible = False

            'empty aftwr validation
            titleAddNameInput.Text = ""

            roleDataGridView.Visible = True
            Roles.Text = "Roles"
            roleAddBtn.Visible = True
            exportBtnR.Visible = True
            'PrintBtnR.Visible = True
        End If
    End Sub

    Private Sub roleAddCancelBtn_Click(sender As Object, e As EventArgs) Handles roleAddCancelBtn.Click 'cancel add
        roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        roleAddPanel.Visible = False

        roleDataGridView.Visible = True
        Roles.Text = "Roles"
        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True
    End Sub

    'equipment SECTION

    Private Sub equipmentsBtn_Click(sender As Object, e As EventArgs) Handles equipmentsBtn.Click
        Timer1.Start()


        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        User.display(adminEquipmentPanel, EquipmentTitle, "Equipments")
        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

        fillHalls(hallSearchBoxE)
        fillcomboState(userSearchBoxE, "equipments", "equipment_state")


        equipmentDataGridView.Visible = True
        equipmentSearchBox.Visible = True
        equipmentsearchpostidlabel.Visible = True
        EquipmentTitle.Text = "Equipment"
        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        'printBtnE.Visible = true
    End Sub


    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", equipmentDataGridView)

        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False


        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible =
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

        equipmentDataGridView.Visible = True
        equipmentSearchBox.Visible = True
        equipmentsearchpostidlabel.Visible = True
        EquipmentTitle.Text = "CPUs"
        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        'printBtnE.Visible = True

    End Sub

    Private Sub CPUsBtn2_Click(sender As Object, e As EventArgs) Handles CPUsBtn2.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", equipmentDataGridView)

        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False


        addPostPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub IPsBtn_Click(sender As Object, e As EventArgs) Handles IPsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", equipmentDataGridView)

        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False


        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

        equipmentDataGridView.Visible = True
        equipmentSearchBox.Visible = True
        equipmentsearchpostidlabel.Visible = True
        EquipmentTitle.Text = "IP Phones"
        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        'printBtnE.Visible = True
    End Sub

    Private Sub IPsBtn2_Click(sender As Object, e As EventArgs) Handles IPsBtn2.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_phone", equipmentDataGridView)

        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        addPostPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub monitorsBtn2_Click(sender As Object, e As EventArgs) Handles monitorsBtn2.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", equipmentDataGridView)

        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        addPostPanel.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub


    Private Sub monitorsBtn_Click(sender As Object, e As EventArgs) Handles monitorsBtn.Click
        User.display(adminEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "monitor", equipmentDataGridView)

        adminEquipmentPanel.Visible = True
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

        equipmentDataGridView.Visible = True
        equipmentSearchBox.Visible = True
        equipmentsearchpostidlabel.Visible = True
        EquipmentTitle.Text = "Monitors"
        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        'printBtnE.Visible = True

    End Sub

    'Equipment add section
    Private Sub addEquipmentBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentBtn.Click
        addEquipmentPanel.Visible = True
        fillcombo(postIdInput, "posts", "post_id")
        fillHalls(hallInput)

        EquipmentTitle.Text = "Add equipment"
        equipmentDataGridView.Visible = False
        equipmentSearchBox.Visible = False
        equipmentsearchpostidlabel.Visible = False
        addEquipmentBtn.Visible = False
        exportBtnE.Visible = False
        'printBtnE.Visible = False
    End Sub

    Private Sub addEquipmentCancelBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentCancelBtn.Click
        addEquipmentPanel.Visible = False

        EquipmentTitle.Text = "Equipment"
        equipmentDataGridView.Visible = True
        equipmentSearchBox.Visible = True
        equipmentsearchpostidlabel.Visible = True
        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)
        searchErrorE.Visible = False
        'printBtnE.Visible = True

    End Sub

    Private Sub addEquipmentValidationBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentValidationBtn.Click
        connect_db()

        If equipmentTypeInput.Text = "" Or equipmentStateInput.Text = "" And hallInput.Text = "" Then
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

            If hallInput.Text = "" Then
                Try
                    sqlConn.Open()
                    sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "','" & post_id & "',1)"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

                    'this changes the content of confirmMsg
                    confirmMsgE.Text = "Item successfully added ✔"

                    'this makes the confirm message appear for 3secs
                    confirmMsgE.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()


                    'this makes the add panel to disappear
                    statePanel.Visible = False  'play it safe and make both panels visible false 
                    addEquipmentPanel.Visible = False

                    equipmentTypeInput.Text = ""
                    equipmentStateInput.Text = ""
                    hallInput.Text = ""

                    fillHalls(hallSearchBoxE)


                    EquipmentTitle.Text = "Equipment"
                    equipmentDataGridView.Visible = True
                    equipmentSearchBox.Visible = True
                    equipmentsearchpostidlabel.Visible = True
                    addEquipmentBtn.Visible = True
                    exportBtnE.Visible = True
                    'printBtnE.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            Else
                Try
                    sqlConn.Open()
                    sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

                    'this changes the content of confirmMsg
                    confirmMsgE.Text = "Item successfully added ✔"

                    'this makes the confirm message appear for 3secs
                    confirmMsgE.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()


                    'this makes the add panel to disappear
                    statePanel.Visible = False  'play it safe and make both panels visible false 
                    addEquipmentPanel.Visible = False

                    equipmentTypeInput.Text = ""
                    equipmentStateInput.Text = ""
                    hallInput.Text = ""

                    fillHalls(hallSearchBoxE)


                    EquipmentTitle.Text = "Equipment"
                    equipmentDataGridView.Visible = True
                    equipmentSearchBox.Visible = True
                    equipmentsearchpostidlabel.Visible = True
                    addEquipmentBtn.Visible = True
                    exportBtnE.Visible = True
                    'printBtnE.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            End If


        End If
    End Sub

    'update equipment



    'EQUIPMENT SECTION
    Private Sub DataGridView1_CellClick() Handles equipmentDataGridView.CellClick

        Try
            equipmentState.Text = equipmentDataGridView.SelectedRows(0).Cells(2).Value.ToString

            statePanel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    'update equipment state
    Private Sub stateChangeBtn_Click(sender As Object, e As EventArgs) Handles stateChangeBtn.Click
        Dim equipment_id As Integer = equipmentDataGridView.SelectedRows(0).Cells(0).Value.ToString
        Dim post_id As Integer = equipmentDataGridView.SelectedRows(0).Cells(3).Value.ToString

        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_equipments Set equipment_state ='" & equipmentState.Text & "' where equipment_id = '" & equipment_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd
            'possible problem
            .CommandText = "Update cems.cems_posts Set post_state ='" & equipmentState.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()



        statePanel.Visible = False

        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)
        fillHalls(hallSearchBoxE)
    End Sub

    'delete equipment

    Private Sub equipmentdeleteBtn_Click(sender As Object, e As EventArgs) Handles equipmentDeleteBtn.Click  'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this equipment ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(equipmentDataGridView, "equipments", "equipment")
        End If

        statePanel.Visible = False

        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

    End Sub


    'logout button
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

        addPostPanel.Visible = False

    End Sub



    'export buttons 

    'role export
    Private Sub exportBtnR_Click(sender As Object, e As EventArgs) Handles exportBtnR.Click 'Role 


        User.export(roleDataGridView, "Roles")


        sqlConn.Dispose()

        confirmMsgR.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()

    End Sub


    'halls export 

    Private Sub exportBtnH_Click(sender As Object, e As EventArgs) Handles exportBtnH.Click  'hall



        User.export(hallDataGridView, "halls")
        sqlConn.Dispose()

        'this will make the message appear for three seconds
        confirmMsgH.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()
    End Sub


    'user export 

    Private Sub exportBtnu_Click(sender As Object, e As EventArgs) Handles exportBtnU.Click 'user 

        User.export(userDataGridView, "users")

        sqlConn.Dispose()

        'this will make the message appear for three seconds
        confirmMsgU.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()
    End Sub


    'post export
    Private Sub exportBtnP_Click(sender As Object, e As EventArgs) Handles exportBtnP.Click

        User.export(postDataGridView, "posts")
        sqlConn.Dispose()

        confirmMsgP.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()

    End Sub

    'equipment export
    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click

        Try

            User.export(equipmentDataGridView, "equipments")


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

    'searches button section

    'halls search

    Private Sub hallSearchboxH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxH.SelectedIndexChanged
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


        admin.generalSearchH("halls", hallDataGridView, "hall_id", hall_id, searchErrorH, sqlDataTableCBH)
    End Sub


    'equipment searches
    Private Sub equipmentSearchBox_textChanged(sender As Object, e As EventArgs) Handles equipmentSearchBox.TextChanged

        User.search("equipments", equipmentDataGridView, "post_id", equipmentSearchBox.Text, searchErrorE, sqlDataTableE)

    End Sub


    'search by halls in equipment
    Private Sub hallSearchBoxE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxE.SelectedIndexChanged
        Dim hall_id As Integer

        equipmentSearchBox.Text = ""

        If userSearchBoxE.Text = "" Then
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

            User.searchHall("equipments", equipmentDataGridView, "hall_id", hall_id, searchErrorE, sqlDataTableCBHE)
        Else
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

            User.searchHallAndState("equipments", equipmentDataGridView, "hall_id", hall_id, "equipment_state", userSearchBoxE.Text, searchErrorE, sqlDataTableCBHE)

        End If


    End Sub

    'equipment search by state

    Private Sub userSearchBoxE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userSearchBoxE.SelectedIndexChanged
        Dim hall_id As Integer

        equipmentSearchBox.Text = ""

        If hallSearchBoxE.Text <> "" Then
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

            User.searchHallAndState("equipments", equipmentDataGridView, "hall_id", hall_id, "equipment_state", userSearchBoxE.Text, searchErrorE, sqlDataTableCBHE)

        Else
            User.searchHallAndStateNohall("equipments", equipmentDataGridView, "equipment_state", userSearchBoxE.Text, searchErrorE, sqlDataTableCBHE)
        End If



    End Sub


    'user searches
    Private Sub userSearchBox_textChanged(sender As Object, e As EventArgs) Handles userSearchBox.TextChanged

        User.searchU("users", userDataGridView, "user_name", userSearchBox.Text, searchErrorU, sqlDataTableU)

    End Sub


    'this is the danger zone //Public Custom Event VisibleChanged As EventHandler

    Private Sub AddVisibleChangedEventHandler()
        AddHandler addEquipmentPanel.VisibleChanged, AddressOf Label_VisibleChanged
        AddHandler addEquipmentErrorMsg.VisibleChanged, AddressOf Label1_VisibleChanged

    End Sub

    Private Sub Label_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        'MessageBox.Show("Visible change event raised!!!")
        statePanel.Visible = False
    End Sub

    Private Sub Label1_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        'MessageBox.Show("Visible change event raised!!!")
        'this updates the datagridview
        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

        confirmMsgE.Visible = True

        'this changes the content of confirmMsg
        confirmMsgE.Text = "Item successfully added ✔"


        statePanel.Visible = False  'play it safe and make both panels visible false 


    End Sub


    'post searches

    Private Sub postSearchBox_textChanged(sender As Object, e As EventArgs) Handles postSearchBox.TextChanged

        User.searchP("posts", postDataGridView, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)

    End Sub

    'post search by state
    Private Sub stateSearchBoxP_textChanged(sender As Object, e As EventArgs) Handles stateSearchBoxP.TextChanged

        postSearchBox.Text = ""


        Dim hall_id As Integer

        If hallSearchBoxP.Text <> "" Then
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

            User.searchHallAndStateP("posts", postDataGridView, "hall_id", hall_id, "post_state", stateSearchBoxP.Text, searchErrorP, sqlDataTableP)
        Else

            User.searchHallAndState("posts", postDataGridView, "post_state", stateSearchBoxP.Text, searchErrorP, sqlDataTableP)
        End If



    End Sub


    'post hall search
    Private Sub hallSearchBoxP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxP.SelectedIndexChanged
        Dim hall_id As Integer

        postSearchBox.Text = ""

        If stateSearchBoxP.Text <> "" Then

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

            User.searchHallP("posts", postDataGridView, "post_state", stateSearchBoxP.Text, "hall_id", hall_id, searchErrorP, sqlDataTableCBHP)
        Else
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

            User.searchHallPNoState("posts", postDataGridView, "hall_id", hall_id, searchErrorP, sqlDataTableCBHP)
        End If

    End Sub


    'print buttons

    'halls print

    Private Sub printBtnh_Click(sender As Object, e As EventArgs)

        Try
            Dim height As Integer = hallDataGridView.Height
            hallDataGridView.Height = hallDataGridView.RowCount * hallDataGridView.RowTemplate.Height
            bitmap = New Bitmap(Me.hallDataGridView.Width, Me.hallDataGridView.Height)
            hallDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.hallDataGridView.Width, Me.hallDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            hallDataGridView.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub


    'roles print

    Private Sub printBtnr_Click(sender As Object, e As EventArgs)

        Try
            Dim height As Integer = roleDataGridView.Height
            roleDataGridView.Height = roleDataGridView.RowCount * roleDataGridView.RowTemplate.Height
            bitmap = New Bitmap(roleDataGridView.Width, roleDataGridView.Height)
            roleDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, roleDataGridView.Width, roleDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            roleDataGridView.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub


    'user print 

    Private Sub printBtnu_Click(sender As Object, e As EventArgs)

        Try
            Dim height As Integer = userDataGridView.Height
            userDataGridView.Height = userDataGridView.RowCount * userDataGridView.RowTemplate.Height
            bitmap = New Bitmap(userDataGridView.Width, userDataGridView.Height)
            userDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, userDataGridView.Width, userDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            userDataGridView.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub



    'post print
    Private Sub printBtnP_Click(sender As Object, e As EventArgs)

        Try
            Dim height As Integer = postDataGridView.Height
            postDataGridView.Height = postDataGridView.RowCount * postDataGridView.RowTemplate.Height
            bitmap = New Bitmap(Me.postDataGridView.Width, Me.postDataGridView.Height)
            postDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.postDataGridView.Width, Me.postDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            postDataGridView.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'equipment print
    Private Sub printBtnE_Click(sender As Object, e As EventArgs)

        Try
            Dim height As Integer = equipmentDataGridView.Height
            equipmentDataGridView.Height = equipmentDataGridView.RowCount * equipmentDataGridView.RowTemplate.Height
            bitmap = New Bitmap(Me.equipmentDataGridView.Width, Me.equipmentDataGridView.Height)
            equipmentDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.equipmentDataGridView.Width, Me.equipmentDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()

            equipmentDataGridView.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub



    'this is the second timer function which is used to make the timer stop

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick 'this stops the timer and make the messages disappear
        confirmMsgP.Visible = False
        confirmMsgE.Visible = False
        confirmMsgH.Visible = False
        confirmMsgU.Visible = False
        confirmMsgR.Visible = False
        confirmMsgPr.Visible = False
        addUserErrorMsg.Visible = False
        addEquipmentErrorMsg.Visible = False
        addRoleErrorMsg.Visible = False
        addHallErrorMsg.Visible = False
        addPostErrorMsg.Visible = False
        addUserErrorMsg.Visible = False
        updateProfileErrorMsg.Visible = False

        Timer2.Stop()
    End Sub


    'print page
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If postDataGridView.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub




    'styles

    'close all the servers when the app is closed
    Private Sub adminHomePage_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Stop Apache
        Dim apacheProcesses() As Process = Process.GetProcessesByName("httpd")
        For Each apacheProcess As Process In apacheProcesses
            If Not apacheProcess.CloseMainWindow() Then
                apacheProcess.Kill()
            End If
        Next

        ' Stop MySQL
        Dim mysqlProcesses() As Process = Process.GetProcessesByName("mysqld")
        For Each mysqlProcess As Process In mysqlProcesses
            If Not mysqlProcess.CloseMainWindow() Then
                mysqlProcess.Kill()
            End If
        Next

    End Sub
End Class
