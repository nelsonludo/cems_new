﻿Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports Org.BouncyCastle.Crypto.Generators
Imports BCrypt.Net.BCrypt
Imports System.Windows.Forms
Imports System.Resources
Imports System.Globalization
Imports System.Threading
Imports System.Text.RegularExpressions





Public Class homePage
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


    Public server As String = Nothing
    Public username As String = Nothing
    Public password As String = Nothing
    Public database As String = Nothing
    Public loggedIn As Boolean = Form1.loggedIn



    Dim User As New users
    Dim admin As New admin

    'this is used in the print function
    Dim bitmap As Bitmap


    'this is for the sidebar dropdown
    Dim iscollapsed As Boolean = False

    Dim isFrench As Boolean = True



    'connection functoin
    Public Sub connect_db()

        server = Form1.server
        username = Form1.username
        password = Form1.password
        database = Form1.database

        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
               + "password=" + password + ";" + "database =" + database
    End Sub


    'FAILED EXPERIMENT TO REDUCE THE NUMBER OF QUERRIES USED BY QUERRYING ONCE AND STORING IT IN VARIABLES
    'Public Sub getEverything(name As String, email As String)
    '    connect_db()
    '    Try
    '        sqlConn.Open()
    '        'username appear
    '        sqlQuery = "select * from " & database & ".cems_admin where admin_email = '" & Form1.emailtxt.Text & "'"
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


    'this is the translation section 
    Private resourceManager As New ResourceManager("cems.Resources", GetType(homePage).Assembly)


    Private Sub adminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        TranslateFormControlsFrench(Me)


        connect_db()

        User.showUserName(Form1.emailtxt, aName)

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

        User.activeCount(repairCPUNumber, "equipments", "equipment", "In reparation", "CPU")
        User.activeCount(repairIPNumber, "equipments", "equipment", "In reparation", "IP_phone")
        User.activeCount(repairMonitorNumber, "equipments", "equipment", "In reparation", "monitor")


    End Sub

    Private Sub adminHomePage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        adminHomePagePanel.Visible = True
    End Sub

    'this is like the media of css for the responsiveness
    Private Sub adminhomepage_resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        ' Perform layout adjustments based on the screen size
        Dim increaseY As Integer = 30
        Dim increaseX As Integer = 90

        'If WindowState = FormWindowState.Maximized Then
        '    userbuttoninactive.Left += increaseX
        '    userbuttoninactive.Top += increaseY
        'Else
        '    userbuttoninactive.Left -= increaseX
        '    userbuttoninactive.Top -= increaseY
        'End If

    End Sub


    'dropdown code 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        User.dropdownTimer(iscollapsed, dropdown, Timer1)
    End Sub


    Public Sub fillHalls(search As ComboBox)

        search.Items.Clear()

        Try
            sqlConn.Open()

            sqlQuery = "select * from  " & database & ".cems_halls"


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

            sqlQuery = "select * from  " & database & ".cems_" & table & ""


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

    Public Sub fillcomboEquipment(search As ComboBox, table As String, fillvalue As String)

        search.Items.Clear()

        Try
            sqlConn.Open()

            sqlQuery = "select equipment_type from  " & database & ".cems_" & table & " group by equipment_type"


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




    'this is a recurcive function that loops through all the controls(mostly labels and buttons) in the form and translates them to english as set in the resourceEnText.resx file
    Private Sub TranslateFormControlsEnglish(ByVal control As Control)
        For Each childControl As Control In control.Controls
            If TypeOf childControl Is Button OrElse TypeOf childControl Is Label OrElse TypeOf childControl Is TextBox Then
                Dim resourceName As String = childControl.Name
                Dim translatedText As String = My.Resources.resourcesEnText.ResourceManager.GetString(resourceName)
                If Not String.IsNullOrEmpty(translatedText) Then
                    childControl.Text = translatedText
                End If
            End If

            ' Recursively translate child controls
            TranslateFormControlsEnglish(childControl)


        Next
        isFrench = False
    End Sub

    'this is a recurcive function that loops through all the controls(mostly labels and buttons) in the form and translates them to french as set in the resourceFrText.resx file
    Private Sub TranslateFormControlsFrench(ByVal control As Control)
        For Each childControl As Control In control.Controls
            If TypeOf childControl Is Button OrElse TypeOf childControl Is Label OrElse TypeOf childControl Is TextBox Then
                Dim resourceName As String = childControl.Name
                Dim translatedText As String = My.Resources.resourcesFrText.ResourceManager.GetString(resourceName)
                If Not String.IsNullOrEmpty(translatedText) Then
                    childControl.Text = translatedText
                End If
            End If

            ' Recursively translate child controls
            TranslateFormControlsFrench(childControl)
        Next
        isFrench = True

    End Sub



    'translation buttons 
    Private Sub FrenchButton_Click(sender As Object, e As EventArgs) Handles frenchBtn.Click
        frenchBtn.Visible = False
        englishBtn.Visible = True

        TranslateFormControlsFrench(Me)

        If adminPostPanel.Visible = True Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle
        End If

        If addPostPanel.Visible = True Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle_Add
        End If

        If adminEquipmentPanel.Visible = True Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle

        End If



        If addEquipmentPanel.Visible = True Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_Add

        End If

        If adminHallsPanel.Visible = True Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle
        End If

        If hallUpdatePanel.Visible = True Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle_Update
        End If

        If hallAddpanel.Visible = True Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle_Add
        End If

        If adminUsersPanel.Visible = True Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle
        End If

        If userUpdatePanel.Visible = True Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle_Update
        End If

        If userAddPanel.Visible = True Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle_Add
        End If

        If adminRolePanel.Visible = True Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle
        End If

        If roleUpdatePanel.Visible = True Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle_Update
        End If

        If roleAddPanel.Visible = True Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle_Add
        End If

        If adminProfilePanel.Visible = True Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle
        End If

        If profileSubPanel2.Visible = True Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle_Update
        End If



    End Sub

    Private Sub EnglishButton_Click(sender As Object, e As EventArgs) Handles englishBtn.Click

        frenchBtn.Visible = True
        englishBtn.Visible = False

        TranslateFormControlsEnglish(Me)

        If adminPostPanel.Visible = True Then

            postTitle.Text = My.Resources.resourcesEnText.postTitle
        End If

        If addPostPanel.Visible = True Then

            postTitle.Text = My.Resources.resourcesEnText.postTitle_Add
        End If

        If adminEquipmentPanel.Visible = True Then

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle

        End If

        If addEquipmentPanel.Visible = True Then

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_Add

        End If

        If adminHallsPanel.Visible = True Then

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle
        End If

        If hallUpdatePanel.Visible = True Then

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle_Update
        End If

        If hallAddpanel.Visible = True Then

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle_Add
        End If

        If adminUsersPanel.Visible = True Then

            userTitle.Text = My.Resources.resourcesEnText.userTitle
        End If

        If userUpdatePanel.Visible = True Then

            userTitle.Text = My.Resources.resourcesEnText.userTitle_Update
        End If

        If userAddPanel.Visible = True Then

            userTitle.Text = My.Resources.resourcesEnText.userTitle_Add
        End If

        If adminRolePanel.Visible = True Then

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle
        End If

        If roleUpdatePanel.Visible = True Then

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle_Update
        End If

        If roleAddPanel.Visible = True Then

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle_Add
        End If

        If adminProfilePanel.Visible = True Then

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle
        End If

        If profileSubPanel2.Visible = True Then

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle_Update
        End If


    End Sub

    'tab buttons section

    'dashboard button
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click

        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = False
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False

        profileSubPanel2.Visible = False
        profileSubPanel3.Visible = False
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
        adminHomePagePanel.Visible = True

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        User.activeCount(activeCPUNumber, "equipments", "equipment", "good", "CPU")
        User.activeCount(activeIPNumber, "equipments", "equipment", "good", "IP_phone")
        User.activeCount(activeMonitorNumber, "equipments", "equipment", "good", "monitor")


        User.activeCount(nonActiveCPUNumber, "equipments", "equipment", "bad", "CPU")
        User.activeCount(nonActiveIPNumber, "equipments", "equipment", "bad", "IP_phone")
        User.activeCount(nonActiveMonitorNumber, "equipments", "equipment", "bad", "monitor")
        admin.activeCount(userNumber, "users")

        User.activeCount(repairCPUNumber, "equipments", "equipment", "In reparation", "CPU")
        User.activeCount(repairIPNumber, "equipments", "equipment", "In reparation", "IP_phone")
        User.activeCount(repairMonitorNumber, "equipments", "equipment", "In reparation", "monitor")

    End Sub


    'POST SECTION
    Private Sub DataGridView2_CellClick() Handles postDataGridView.CellClick

        Try
            'postChangeStateInput.Text = postDataGridView.SelectedRows(0).Cells(1).Value.ToString
            postChangeHallInput.Text = postDataGridView.SelectedRows(0).Cells(2).Value.ToString

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
        adminHomePagePanel.Visible = False

        postChangeStatePanel.Visible = False
        addPostPanel.Visible = False
        addEquipmentPanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        profileSubPanel3.Visible = False
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
        refreshBtnP.Visible = True


        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""

        hallSearchBoxP.SelectedIndex = -1

        stateSearchBoxP.SelectedIndex = -1



        User.displayTableP("posts", postDataGridView, sqlDataTableP)  'this is a useless comment //you're the useless comment !

        searchErrorP.Visible = False
        fillHalls(hallSearchBoxP)

        'this fills the halls in the change post hall combobox
        fillHalls(postChangeHallInput)


        fillcomboState(stateSearchBoxP, "posts", "post_state")

        If isFrench Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle
        Else

            postTitle.Text = My.Resources.resourcesEnText.postTitle
        End If

        postDataGridView.Visible = True
        postSearchBox.Visible = True
        postsearchlabel.Visible = True
        addPostBtn.Visible = True
        exportBtnP.Visible = True
        'printBtnP.Visible = True
    End Sub


    'refresh post button 
    Private Sub refreshBtnP_click(sender As Object, e As EventArgs) Handles refreshBtnP.Click

        'empty the fields after validation
        postSearchBox.Text = ""


        hallSearchBoxP.SelectedIndex = -1

        stateSearchBoxP.SelectedIndex = -1



        'this updates the datagridview
        User.displayTableP("posts", postDataGridView, sqlDataTableP)

        searchErrorP.Visible = False
        postDataGridView.Visible = True

    End Sub


    'POST add section
    Private Sub addPostBtn_Click(sender As Object, e As EventArgs) Handles addPostBtn.Click
        addPostPanel.Visible = True

        fillHalls(postHallInput)

        postDataGridView.Visible = False
        postSearchBox.Visible = False
        postsearchlabel.Visible = False
        addPostBtn.Visible = False
        exportBtnP.Visible = False
        postChangeStatePanel.Visible = False
        searchErrorP.Visible = False
        refreshBtnP.Visible = False


        'printBtnP.Visible = False


        If isFrench Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle_Add
        Else

            postTitle.Text = My.Resources.resourcesEnText.postTitle_Add
        End If
    End Sub


    Private Sub addPostValidationBtn_Click(sender As Object, e As EventArgs) Handles addPostValidationBtn.Click
        connect_db()

        If postStateInput.Text = "" And postHallInput.Text = "" Then

            If isFrench Then
                addPostErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                addPostErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If

            addPostErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()



        Else
            Dim hall_id As Integer
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & postHallInput.Text & "'"


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
                sqlQuery = "select * from cems_posts where post_id = '" & postPostIdInput.Text & "' and hall_id = '" & hall_id & "'"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                If (sqlReader.Read()) Then

                    If isFrench Then
                        addPostErrorMsg.Text = My.Resources.resourcesFrText.postExist
                    Else
                        addPostErrorMsg.Text = My.Resources.resourcesEnText.postExist

                    End If

                    addPostErrorMsg.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()
                    sqlConn.Close()
                Else

                    If postHallInput.Text = "" Then
                        Try
                            sqlConn.Close()
                            sqlConn.Open()
                            sqlQuery = "insert into " & database & ".cems_posts(post_id,hall_id, post_state) values ('" & postPostIdInput.Text & "',1,'" & postStateInput.Text & "')"
                            'Read through the response'
                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            sqlConn.Close()

                            Dim post_id As String = postPostIdInput.Text

                            If post_id <> 1 Then

                                sqlConn.Open()
                                sqlQuery = "insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('IP_Phone','" & postStateInput.Text & "','" & post_id & "',1);insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('CPU','" & postStateInput.Text & "','" & post_id & "',1);insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('Monitor','" & postStateInput.Text & "','" & post_id & "',1)"
                                'Read through the response'
                                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                                sqlReader = sqlCmd.ExecuteReader
                                sqlConn.Close()


                                'this updates the datagridview
                                User.displayTableP("posts", postDataGridView, sqlDataTableP)

                            End If
                            'this changes the content of confirmMsg

                            If isFrench Then
                                confirmMsgP.Text = My.Resources.resourcesFrText.confirmMsgP_add
                            Else
                                confirmMsgP.Text = My.Resources.resourcesEnText.confirmMsgP_add

                            End If


                            'this makes the confirm message appear for 3secs
                            confirmMsgP.Visible = True
                            Timer2.Interval = 3000
                            Timer2.Start()


                            'this makes the add panel to disappear
                            postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                            addPostPanel.Visible = False

                            'empty the fields after validation
                            postStateInput.SelectedIndex = -1
                            postHallInput.SelectedIndex = -1
                            postPostIdInput.Text = ""

                            'empty the search fields after validation
                            postSearchBox.Text = ""


                            hallSearchBoxP.SelectedIndex = -1

                            stateSearchBoxP.SelectedIndex = -1


                            If isFrench Then

                                postTitle.Text = My.Resources.resourcesFrText.postTitle
                            Else

                                postTitle.Text = My.Resources.resourcesEnText.postTitle
                            End If
                            postDataGridView.Visible = True
                            postSearchBox.Visible = True
                            postsearchlabel.Visible = True
                            addPostBtn.Visible = True
                            exportBtnP.Visible = True
                            refreshBtnP.Visible = True
                            'printBtnP.Visible = True
                            searchErrorP.Visible = False


                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "MySql add post ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Finally
                            sqlConn.Dispose()
                        End Try
                    Else
                        Try
                            sqlConn.Close()
                            sqlConn.Open()
                            sqlQuery = "insert into " & database & ".cems_posts(post_id,hall_id, post_state) values ('" & postPostIdInput.Text & "','" & hall_id & "','" & postStateInput.Text & "')"
                            'Read through the response'
                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            sqlConn.Close()

                            Dim post_id As String = postPostIdInput.Text

                            sqlConn.Open()
                            sqlQuery = "insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('IP_Phone','" & postStateInput.Text & "','" & post_id & "','" & hall_id & "');insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('CPU','" & postStateInput.Text & "','" & post_id & "','" & hall_id & "');insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('Monitor','" & postStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                            'Read through the response'
                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            sqlConn.Close()


                            'this updates the datagridview
                            User.displayTableP("posts", postDataGridView, sqlDataTableP)

                            'this changes the content of confirmMsg
                            If isFrench Then
                                confirmMsgP.Text = My.Resources.resourcesFrText.confirmMsgP_add
                            Else
                                confirmMsgP.Text = My.Resources.resourcesEnText.confirmMsgP_add

                            End If
                            'this makes the confirm message appear for 3secs
                            confirmMsgP.Visible = True
                            Timer2.Interval = 3000
                            Timer2.Start()


                            'this makes the add panel to disappear
                            postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                            addPostPanel.Visible = False

                            'empty the fields after validation
                            postStateInput.SelectedIndex = -1
                            postHallInput.SelectedIndex = -1
                            postPostIdInput.Text = ""

                            If isFrench Then

                                postTitle.Text = My.Resources.resourcesFrText.postTitle
                            Else

                                postTitle.Text = My.Resources.resourcesEnText.postTitle
                            End If
                            postDataGridView.Visible = True
                            postSearchBox.Visible = True
                            postsearchlabel.Visible = True
                            addPostBtn.Visible = True
                            exportBtnP.Visible = True
                            refreshBtnP.Visible = True
                            'printBtnP.Visible = True
                            searchErrorP.Visible = False


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

        'empty the search fields after validation
        postSearchBox.Text = ""


        hallSearchBoxP.SelectedIndex = -1

        stateSearchBoxP.SelectedIndex = -1

        'empty the fields after validation
        postStateInput.SelectedIndex = -1
        postHallInput.SelectedIndex = -1
        postPostIdInput.Text = ""

        If isFrench Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle
        Else

            postTitle.Text = My.Resources.resourcesEnText.postTitle
        End If
        postDataGridView.Visible = True
        postSearchBox.Visible = True
        postsearchlabel.Visible = True
        addPostBtn.Visible = True
        exportBtnP.Visible = True
        refreshBtnP.Visible = True


        'this updates the datagridview
        User.displayTableP("posts", postDataGridView, sqlDataTableP)
        searchErrorP.Visible = False
        'printBtnP.Visible = true
    End Sub

    'delete post button
    Private Sub postdeleteBtn_Click(sender As Object, e As EventArgs) Handles postDeleteBtn.Click 'delete


        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this post ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            If admin.checkDefaultRecord(postDataGridView) Then
                MessageBox.Show("It is not possible to delete the default post!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                admin.deleteRecord(postDataGridView, "posts", "post")

            End If
        End If

        postChangeStatePanel.Visible = False

        User.displayTableP("posts", postDataGridView, sqlDataTableP)

    End Sub

    'change post button
    Private Sub postChangeBtn_Click(sender As Object, e As EventArgs) Handles postChangeBtn.Click

        If admin.checkDefaultRecord(postDataGridView) Then
            MessageBox.Show("It is not possible to update the default post!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            postChangeStatePanel.Visible = False
        Else


            Dim post_id As String = postDataGridView.SelectedRows(0).Cells(0).Value.ToString

            Dim hall_id As Integer
            'SQL Connection'
            connect_db()

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & postChangeHallInput.Text & "'"


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
                connect_db()

                sqlConn.Open()

                sqlCmd.Connection = sqlConn

                With sqlCmd
                    'possible problem
                    .CommandText = "Update " & database & ".cems_posts Set hall_id ='" & hall_id & "' where post_id = '" & post_id & "'" 'post_state ='" & postChangeStateInput.Text & "',

                    .CommandType = CommandType.Text

                End With
                sqlCmd.ExecuteNonQuery()
                sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql update post hall and state", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try

            Try
                'update the equipment hall aswell 

                sqlConn.Open()

                sqlCmd.Connection = sqlConn

                With sqlCmd

                    .CommandText = "Update " & database & ".cems_equipments Set hall_id ='" & hall_id & "' where post_id = '" & post_id & "'"

                    .CommandType = CommandType.Text

                End With
                sqlCmd.ExecuteNonQuery()
                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql update equipment hall from post", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try

            postChangeStatePanel.Visible = False



            User.displayTableP("posts", postDataGridView, sqlDataTableP)
        End If
    End Sub



    'profile button
    Private Async Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        adminEquipmentPanel.Visible = False
        adminPostPanel.Visible = False
        adminHallsPanel.Visible = False
        adminUsersPanel.Visible = False
        adminRolePanel.Visible = False
        adminHomePagePanel.Visible = False
        adminProfilePanel.Visible = True

        profileSubPanel2.Visible = False
        profileSubPanel3.Visible = False
        profileSubPanel1.Visible = True
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


        If isFrench Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle
        Else

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle
        End If


        connect_db()
        Await User.updateUserInformation("users", "user", Form1.user_email, adminNameProfile, EmailProfile, adminPhoneNumberProfile, adminTitleProfile)

    End Sub

    'update profile button

    Private Sub updateProfileShowBtn_Click(sender As Object, e As EventArgs) Handles updateProfileShowBtn.Click
        profileSubPanel2.Visible = True
        profileSubPanel1.Visible = False

        userNameProfileInput.Text = adminNameProfile.Text
        userPhoneNumberProfileInput.Text = adminPhoneNumberProfile.Text
        userEmailProfileInput.Text = EmailProfile.Text

        userPwdProfileInput.Text = ""
        userConfirmPwdProfileInput.Text = ""

        If isFrench Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle_Update
        Else

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle_Update
        End If

    End Sub

    'profile cancel
    Private Sub updateProfileCancelBtn_Click(sender As Object, e As EventArgs) Handles updateProfileCancelBtn.Click
        profileSubPanel2.Visible = False
        profileSubPanel1.Visible = True
        updateProfileErrorMsg.Visible = False

        If isFrench Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle
        Else

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle
        End If
    End Sub

    Private Async Sub updateProfileValidateBtn_ClickAsync(sender As Object, e As EventArgs) Handles updateProfileValidationBtn.Click
        'this function is called to update the user information in the database and do all the client side validations
        User.updateUser(isFrench, "users", "user", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, Form1.user_email, updateProfileErrorMsg, profileSubPanel2, Timer2)

        'this variable store the value returned by the updateuser() function 
        Dim userUpdateCall As Boolean = User.updateUser(isFrench, "users", "user", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, Form1.user_email, updateProfileErrorMsg, profileSubPanel2, Timer2)


        Await User.updateUserInformation("users", "user", Form1.user_email, adminNameProfile, EmailProfile, adminPhoneNumberProfile, adminTitleProfile)


        'this checks if  the update was successful before doing anything else concerning the update 
        If userUpdateCall Then
            profileSubPanel2.Visible = False
            profileSubPanel1.Visible = True

            'this changes the content of confirmMsg
            confirmMsgPr.Visible = True

            If isFrench Then
                confirmMsgPr.Text = My.Resources.resourcesFrText.confirmMsgPr
            Else
                confirmMsgPr.Text = My.Resources.resourcesEnText.confirmMsgPr

            End If

            'timer duration
            Timer2.Interval = 3000
            Timer2.Start()

            If isFrench Then

                profileTitle.Text = My.Resources.resourcesFrText.profileTitle
            Else

                profileTitle.Text = My.Resources.resourcesEnText.profileTitle
            End If

            User.showUserName(Form1.emailtxt, aName)

        End If

    End Sub

    Private Sub changePwdBtn_Click(sender As Object, e As EventArgs) Handles changePwdBtn.Click
        profileSubPanel3.Visible = True
        profileSubPanel2.Visible = False
        profileSubPanel1.Visible = False

    End Sub
    Private Sub changePwdCancelBtn_Click(sender As Object, e As EventArgs) Handles changePwdCancelBtn.Click
        profileSubPanel3.Visible = False
        profileSubPanel2.Visible = False
        profileSubPanel1.Visible = True


        If isFrench Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle
        Else

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle
        End If
    End Sub

    Private Sub changePwdValidationBtn_Click(sender As Object, e As EventArgs) Handles changePwdValidationBtn.Click
        User.updateUserPwd(isFrench, "users", "user", userPwdProfileInput.Text, userConfirmPwdProfileInput.Text, Form1.user_email, changePwdErrorMsg, profileSubPanel3, Timer2)

        Dim changePwdCall As Boolean = User.updateUserPwd(isFrench, "users", "user", userPwdProfileInput.Text, userConfirmPwdProfileInput.Text, Form1.user_email, changePwdErrorMsg, profileSubPanel3, Timer2)

        If changePwdCall Then

            profileSubPanel3.Visible = False
            profileSubPanel2.Visible = False
            profileSubPanel1.Visible = True


            'this changes the content of confirmMsg
            confirmMsgPr.Visible = True

            If isFrench Then
                confirmMsgPr.Text = My.Resources.resourcesFrText.PwdChanged
            Else
                confirmMsgPr.Text = My.Resources.resourcesEnText.PwdChanged

            End If

            'timer duration
            Timer2.Interval = 3000
            Timer2.Start()

            If isFrench Then

                profileTitle.Text = My.Resources.resourcesFrText.profileTitle
            Else

                profileTitle.Text = My.Resources.resourcesEnText.profileTitle
            End If

            User.showUserName(Form1.emailtxt, aName)

        End If
    End Sub




    'halls buttons

    'HALL add Section
    Private Sub hallAddBtn_Click(sender As Object, e As EventArgs) Handles hallAddBtn.Click 'add 
        hallUpdatePanel.Visible = False 'add panel is on update panel so updatepanel has to be visible 
        hallAddpanel.Visible = True
        If isFrench Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle_Add
        Else

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle_Add
        End If


        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = False
        exportBtnH.Visible = False
        'PrintBtnH.Visible = False
        hallSearchBoxH.Visible = False
        hallSearchLabelH.Visible = False
        hallDataGridView.Visible = False
        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False
        refreshBtnH.Visible = False
        searchErrorH.Visible = False
        hallCountPanel.Visible = False


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
        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False
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
        refreshBtnH.Visible = True

        hallCountPanel.Visible = True

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""

        'counts
        admin.activeCount(countPostNumber, "posts")
        admin.activeCount(countEquipmentNumber, "equipments")
        fillcomboEquipment(countEquipmentTypeCombo, "equipments", "equipment_type")

        fillHalls(hallSearchBoxH)
        fillHalls(countHallCombo)

        'this is to translate the title of the panel 
        If isFrench Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle
        Else

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle
        End If
        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        hallSearchLabelH.Visible = True
        hallDataGridView.Visible = True
        searchErrorH.Visible = False


    End Sub

    'refresh hall button 
    Private Sub refreshBtnH_click(sender As Object, e As EventArgs) Handles refreshBtnH.Click


        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False


        hallSearchBoxH.SelectedIndex = -1
        countEquipmentTypeCombo.SelectedIndex = -1
        countHallCombo.SelectedIndex = -1

        countEquipmentNumber.Text = "0000"
        countPostNumber.Text = "0000"

        searchErrorH.Visible = False

        User.displayTable("halls", hallDataGridView, sqlDataTableH)
        hallDataGridView.Visible = True
    End Sub

    'hall add buttons
    Private Sub HallAddCancelBtn_Click(sender As Object, e As EventArgs) Handles hallAddCancelBtn.Click 'cancel add
        hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        hallAddpanel.Visible = False
        If isFrench Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle
        Else

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle
        End If

        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        hallSearchLabelH.Visible = True
        hallDataGridView.Visible = True
        refreshBtnH.Visible = True
        searchErrorH.Visible = False


    End Sub


    Private Sub HallAddValidateBtn_Click(sender As Object, e As EventArgs) Handles hallAddValidationBtn.Click 'validate add

        connect_db()

        If adminAddHallNameInput.Text = "" Then

            If isFrench Then
                addHallErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                addHallErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If

            addHallErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into " & database & ".cems_halls(hall_id, hall_name) values ('" & adminAddHallIdInput.Text & "', '" & adminAddHallNameInput.Text & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql add hall", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try

            'this updates the datagridview
            User.displayTable("halls", hallDataGridView, sqlDataTableH)

            'this changes the content of confirmMsg

            If isFrench Then
                confirmMsgH.Text = My.Resources.resourcesFrText.confirmMsgH_add
            Else
                confirmMsgH.Text = My.Resources.resourcesEnText.confirmMsgH_add

            End If


            'this makes the confirm message appear for 3secs
            confirmMsgH.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()


            'this makes the add panel to disappear
            hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            hallAddpanel.Visible = False

            adminAddHallNameInput.Text = ""
            fillHalls(hallSearchBoxH)

            hallUpdateBtn.Visible = False
            hallDeleteBtn.Visible = False

            If isFrench Then

                hallTitle.Text = My.Resources.resourcesFrText.hallTitle
            Else

                hallTitle.Text = My.Resources.resourcesEnText.hallTitle
            End If
            'things that have to disappear (this is annoying)
            hallAddBtn.Visible = True
            exportBtnH.Visible = True
            'PrintBtnH.Visible = True
            hallSearchBoxH.Visible = True
            hallSearchLabelH.Visible = True
            hallDataGridView.Visible = True
            refreshBtnH.Visible = True
            searchErrorH.Visible = False

            hallCountPanel.Visible = True

        End If


    End Sub

    'hall update buttons 

    Private Sub DataGridView3_CellClick() Handles hallDataGridView.CellClick 'the cellclicked event

        Try
            adminUpdateHallNameInput.Text = hallDataGridView.SelectedRows(0).Cells(1).Value.ToString
            hallUpdateBtn.Visible = True
            hallDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub HallUpdateBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateBtn.Click 'update
        hallUpdatePanel.Visible = True

        If isFrench Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle_Update
        Else

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle_Update
        End If

        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = False
        exportBtnH.Visible = False
        'PrintBtnH.Visible = False
        hallSearchBoxH.Visible = False
        hallSearchLabelH.Visible = False
        hallDataGridView.Visible = False
        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False
        refreshBtnH.Visible = False
        searchErrorH.Visible = False

        hallCountPanel.Visible = False


    End Sub

    Private Sub HalldeleteBtn_Click(sender As Object, e As EventArgs) Handles hallDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this hall ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then
            If admin.checkDefaultRecord(hallDataGridView) Then
                MessageBox.Show("It is not possible to delete the default Hall!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                admin.deleteRecord(hallDataGridView, "halls", "hall")
            End If

        End If

        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False

        User.displayTable("halls", hallDataGridView, sqlDataTableH)
        fillHalls(hallSearchBoxH)

    End Sub

    Private Sub hallUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateCancelBtn.Click 'cancel
        hallUpdatePanel.Visible = False

        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False

        If isFrench Then

            hallTitle.Text = My.Resources.resourcesFrText.hallTitle
        Else

            hallTitle.Text = My.Resources.resourcesEnText.hallTitle
        End If
        'things that have to disappear (this is annoying)
        hallAddBtn.Visible = True
        exportBtnH.Visible = True
        'PrintBtnH.Visible = True
        hallSearchBoxH.Visible = True
        hallSearchLabelH.Visible = True
        hallDataGridView.Visible = True
        refreshBtnH.Visible = True
        searchErrorH.Visible = False


    End Sub

    Private Sub hallUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles hallUpdateValidationBtn.Click 'validate update 


        If adminUpdateHallNameInput.Text = "" Then
            'this changes the content of updateHallErrorMsg

            If isFrench Then
                updateHallErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                updateHallErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If


            'this makes the confirm message appear for 3secs
            updateHallErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        Else

            Try
                Dim hall_id As String = hallDataGridView.SelectedRows(0).Cells(0).Value.ToString

                connect_db()

                sqlConn.Open()

                sqlCmd.Connection = sqlConn
                'this changes the hall name

                With sqlCmd

                    .CommandText = "Update " & database & ".cems_halls Set hall_id ='" & adminUpdateHallIdInput.Text & "', hall_name ='" & adminUpdateHallNameInput.Text & "' where hall_id = '" & hall_id & "' " 'Update " & database & ".cems_users set user_name ='" & userUserNameInput.Text & "', user_email = '" & userUserEmailInput.Text & "', user_phone_number = '" & userUserPhoneInput.Text & "', title_id = '" & title_id & "'"

                    .CommandType = CommandType.Text

                End With
                sqlCmd.ExecuteNonQuery()
                sqlConn.Close()

                'this updates the datagridview
                User.displayTable("halls", hallDataGridView, sqlDataTableH)

                'this changes the content of confirmMsg

                If isFrench Then
                    confirmMsgH.Text = My.Resources.resourcesFrText.confirmMsgH_update
                Else
                    confirmMsgH.Text = My.Resources.resourcesEnText.confirmMsgH_update

                End If

                'this makes the confirm message appear for 3secs
                confirmMsgH.Visible = True
                Timer2.Interval = 3000
                Timer2.Start()


                'this makes the update panel to disappear
                hallUpdatePanel.Visible = False

                hallUpdateBtn.Visible = False
                hallDeleteBtn.Visible = False

                adminUpdateHallNameInput.Text = ""
                fillHalls(hallSearchBoxH)


                If isFrench Then

                    hallTitle.Text = My.Resources.resourcesFrText.hallTitle
                Else

                    hallTitle.Text = My.Resources.resourcesEnText.hallTitle
                End If
                'things that have to disappear (this is annoying)
                hallAddBtn.Visible = True
                exportBtnH.Visible = True
                'PrintBtnH.Visible = True
                hallSearchBoxH.Visible = True
                hallSearchLabelH.Visible = True
                hallDataGridView.Visible = True
                refreshBtnH.Visible = True
                searchErrorH.Visible = False

                hallCountPanel.Visible = True


            Catch ex As Exception
                MessageBox.Show(ex.Message, "mysql update role", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If


    End Sub


    'user buttons

    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles usersBtn.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminRolePanel.Visible = False
        adminUsersPanel.Visible = True
        adminHomePagePanel.Visible = False

        User.displayTableU("users", userDataGridView, sqlDataTableU)

        addPostPanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        addEquipmentPanel.Visible = False
        postChangeStatePanel.Visible = False
        statePanel.Visible = False
        profileSubPanel2.Visible = False
        profileSubPanel3.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False
        refreshBtnU.Visible = True

        hallSearchBoxH.Text = ""
        equipmentSearchBox.Text = ""
        hallSearchBoxE.Text = ""
        hallSearchBoxP.Text = ""
        userSearchBoxE.Text = ""
        userSearchBox.Text = ""
        postSearchBox.Text = ""
        stateSearchBoxP.Text = ""


        If isFrench Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle
        Else

            userTitle.Text = My.Resources.resourcesEnText.userTitle
        End If

        userDataGridView.Visible = True
        addPostPanel.Visible = True
        userDeleteBtn.Visible = False
        userUpdateBtn.Visible = False
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        userAddBtn.Visible = True
        searchuserlabel.Visible = True
        searchErrorU.Visible = False


    End Sub

    'refresh user button 
    Private Sub refreshBtnU_click(sender As Object, e As EventArgs) Handles refreshBtnU.Click
        User.displayTableU("users", userDataGridView, sqlDataTableU)

        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False


        userSearchBox.Text = ""
        searchErrorU.Visible = False

    End Sub

    Private Sub usersBtn2_Click(sender As Object, e As EventArgs) Handles usersBtn2.Click
        adminEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        adminPostPanel.Visible = False  'this is set to true because somehow the profilepanel is inside the postpanel
        adminProfilePanel.Visible = False
        adminHallsPanel.Visible = False
        adminRolePanel.Visible = False
        adminHomePagePanel.Visible = False
        adminUsersPanel.Visible = True
        refreshBtnU.Visible = True


        If isFrench Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle
        Else

            userTitle.Text = My.Resources.resourcesEnText.userTitle
        End If


        User.displayTableU("users", userDataGridView, sqlDataTableU)

    End Sub
    'user update section

    Private Sub userupdatevalidationBtn_Click(sender As Object, e As EventArgs) Handles userUpdateValidationBtn.Click  'validate update 
        connect_db()

        Dim title_id As Integer
        'SQL Connection'

        If userUserNameInput.Text = "" Or userUserPhoneInput.Text = "" Or userUserEmailInput.Text = "" Then
            'this changes the content of updateuserErrorMsg

            If isFrench Then
                updateUserErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                updateUserErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If


            'this makes the confirm message appear for 3secs

            updateUserErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        ElseIf userUserTitleInput.Text = "" Then
            Try
                sqlConn.Open()

                sqlQuery = "select title_id from  " & database & ".cems_titles where title_name = '" & userUserTitleInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    title_id = sqlReader.Item("title_id")
                End While


                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql getting titles for update user", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Try
                If Not User.IsValidEmail(userUserEmailInput.Text) Then
                    If isFrench Then
                        updateUserErrorMsg.Text = My.Resources.resourcesEnText.invalidEmail

                    Else
                        updateUserErrorMsg.Text = My.Resources.resourcesFrText.invalidEmail

                    End If
                    updateUserErrorMsg.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()
                Else

                    sqlConn.Open()
                    sqlQuery = "select * from cems_users where user_email = '" & userUserAddEmailInput.Text & "'"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader

                    If (sqlReader.Read()) Then
                        updateUserErrorMsg.Visible = True

                        If isFrench Then
                            updateUserErrorMsg.Text = My.Resources.resourcesFrText.userExist
                        Else
                            updateUserErrorMsg.Text = My.Resources.resourcesEnText.userExist

                        End If

                        Timer2.Interval = 3000
                        Timer2.Start()
                        sqlConn.Close()

                    Else
                        sqlConn.Close()
                        sqlConn.Open()

                        Dim user_id As String = userDataGridView.SelectedRows(0).Cells(0).Value.ToString


                        sqlCmd.Connection = sqlConn
                        'this changes the hall name

                        With sqlCmd

                            .CommandText = "Update " & database & ".cems_users set user_name ='" & userUserNameInput.Text & "', user_email = '" & userUserEmailInput.Text & "', user_phone_number = '" & userUserPhoneInput.Text & "' where user_id = '" & user_id & "'"

                            .CommandType = CommandType.Text

                        End With
                        sqlCmd.ExecuteNonQuery()
                        sqlConn.Close()



                        'this updates the datagridview
                        User.displayTableU("users", userDataGridView, sqlDataTableU)

                        'this changes the content of confirmMsg

                        If isFrench Then
                            confirmMsgU.Text = My.Resources.resourcesFrText.confirmMsgU_update
                        Else
                            confirmMsgU.Text = My.Resources.resourcesEnText.confirmMsgU_update

                        End If


                        'this makes the confirm message appear for 3secs
                        confirmMsgU.Visible = True
                        Timer2.Interval = 3000
                        Timer2.Start()


                        'this makes the update panel to disappear
                        userUpdatePanel.Visible = False

                        userDeleteBtn.Visible = False


                        If isFrench Then

                            userTitle.Text = My.Resources.resourcesFrText.userTitle
                        Else

                            userTitle.Text = My.Resources.resourcesEnText.userTitle
                        End If

                        userDataGridView.Visible = True
                        userUpdateBtn.Visible = True
                        userAddBtn.Visible = True
                        exportBtnU.Visible = True
                        'PrintBtnU.Visible = True
                        searchuserlabel.Visible = True

                        userUpdateBtn.Visible = False
                        userDeleteBtn.Visible = False
                        refreshBtnU.Visible = True
                        searchErrorU.Visible = False

                    End If

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "mysql update user", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try


        Else


            Try
                sqlConn.Open()

                sqlQuery = "select title_id from  " & database & ".cems_titles where title_name = '" & userUserTitleInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    title_id = sqlReader.Item("title_id")
                End While


                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql getting titles for update user", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Try
                If Not User.IsValidEmail(userUserEmailInput.Text) Then
                    If isFrench Then
                        updateUserErrorMsg.Text = My.Resources.resourcesEnText.invalidEmail

                    Else
                        updateUserErrorMsg.Text = My.Resources.resourcesFrText.invalidEmail

                    End If
                    updateUserErrorMsg.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()
                Else
                    sqlConn.Open()

                    Dim user_id As String = userDataGridView.SelectedRows(0).Cells(0).Value.ToString


                    sqlCmd.Connection = sqlConn
                    'this changes the hall name

                    With sqlCmd

                        .CommandText = "Update " & database & ".cems_users set user_name ='" & userUserNameInput.Text & "', user_email = '" & userUserEmailInput.Text & "', user_phone_number = '" & userUserPhoneInput.Text & "', title_id = '" & title_id & "' where user_id = '" & user_id & "'"

                        .CommandType = CommandType.Text

                    End With
                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableU("users", userDataGridView, sqlDataTableU)

                    'this changes the content of confirmMsg

                    If isFrench Then
                        confirmMsgU.Text = My.Resources.resourcesFrText.confirmMsgU_update
                    Else
                        confirmMsgU.Text = My.Resources.resourcesEnText.confirmMsgU_update

                    End If


                    'this makes the confirm message appear for 3secs
                    confirmMsgU.Visible = True
                    Timer2.Interval = 3000
                    Timer2.Start()


                    'this makes the update panel to disappear
                    userUpdatePanel.Visible = False

                    userDeleteBtn.Visible = False


                    If isFrench Then

                        userTitle.Text = My.Resources.resourcesFrText.userTitle
                    Else

                        userTitle.Text = My.Resources.resourcesEnText.userTitle
                    End If

                    userDataGridView.Visible = True
                    userUpdateBtn.Visible = True
                    userAddBtn.Visible = True
                    exportBtnU.Visible = True
                    'PrintBtnU.Visible = True
                    searchuserlabel.Visible = True

                    userUpdateBtn.Visible = False
                    userDeleteBtn.Visible = False
                    refreshBtnU.Visible = True
                    searchErrorU.Visible = False

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "mysql update user", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try

        End If

    End Sub

    Private Sub userCancelBtn_Click(sender As Object, e As EventArgs) Handles userUpdateCancelBtn.Click 'cancel
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False


        If isFrench Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle
        Else

            userTitle.Text = My.Resources.resourcesEnText.userTitle
        End If

        userDataGridView.Visible = True
        userAddBtn.Visible = True
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        searchuserlabel.Visible = True
        refreshBtnU.Visible = True
        searchErrorU.Visible = False


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

            sqlQuery = "select * from  " & database & ".cems_titles"


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


        If isFrench Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle_Update
        Else

            userTitle.Text = My.Resources.resourcesEnText.userTitle_Update
        End If

        userUpdateBtn.Visible = False
        userAddBtn.Visible = False
        userDeleteBtn.Visible = False
        exportBtnU.Visible = False
        'PrintBtnU.Visible = False
        searchuserlabel.Visible = False
        userDataGridView.Visible = False
        refreshBtnU.Visible = False
        searchErrorU.Visible = False


    End Sub

    Private Sub userdeleteBtn_Click(sender As Object, e As EventArgs) Handles userDeleteBtn.Click 'delete user

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this user ?", "Comfirm User Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            If admin.compareSelectedRecordWithLoggedinUser(userDataGridView, Form1.emailtxt.Text) Then
                MessageBox.Show("It is not possible to delete a loggedin user!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                admin.deleteRecord(userDataGridView, "users", "user")

            End If
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

            sqlQuery = "select * from  " & database & ".cems_titles"


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


        If isFrench Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle_Add
        Else

            userTitle.Text = My.Resources.resourcesEnText.userTitle_Add
        End If

        userUpdateBtn.Visible = False
        userDataGridView.Visible = False
        exportBtnU.Visible = False
        'PrintBtnU.Visible = False
        searchuserlabel.Visible = False
        refreshBtnU.Visible = False
        userAddBtn.Visible = False
        userDeleteBtn.Visible = False

    End Sub


    Private Sub userAddValidateBtn_Click(sender As Object, e As EventArgs) Handles userAddValidationBtn.Click 'validate add

        connect_db()

        If userUserAddNameInput.Text = "" Or userUserAddEmailInput.Text = "" Or userUserAddPhoneInput.Text = "" Or userUserAddConfirmPwdInput.Text = "" Or userUserAddTitleInput.Text = "" Then

            If isFrench Then
                addUserErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                addUserErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If


            addUserErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else

            Dim title_id As Integer
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select title_id from  " & database & ".cems_titles where title_name = '" & userUserAddTitleInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    title_id = sqlReader.Item("title_id")
                End While

                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql getting all titles for add user", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try


            If userUserAddPwdInput.Text <> userUserAddConfirmPwdInput.Text Then
                addUserErrorMsg.Visible = True

                If isFrench Then
                    addUserErrorMsg.Text = My.Resources.resourcesFrText.PwdNotMatch
                Else
                    addUserErrorMsg.Text = My.Resources.resourcesEnText.PwdNotMatch

                End If

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

                        If isFrench Then
                            addUserErrorMsg.Text = My.Resources.resourcesFrText.userExist
                        Else
                            addUserErrorMsg.Text = My.Resources.resourcesEnText.userExist

                        End If

                        Timer2.Interval = 3000
                        Timer2.Start()
                        sqlConn.Close()

                    ElseIf Not user.IsValidEmail(userUserAddEmailInput.Text) Then
                        If isFrench Then
                            addUserErrorMsg.Text = My.Resources.resourcesEnText.invalidEmail

                        Else
                            addUserErrorMsg.Text = My.Resources.resourcesFrText.invalidEmail

                        End If
                        addUserErrorMsg.Visible = True
                        Timer2.Interval = 3000
                        Timer2.Start()
                    Else

                        Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(userUserAddConfirmPwdInput.Text)
                        Try
                            sqlConn.Close()
                            sqlConn.Open()
                            sqlQuery = "insert into " & database & ".cems_users(user_name, user_email, user_phone_number, user_password, title_id) values ('" & userUserAddNameInput.Text & "','" & userUserAddEmailInput.Text & "','" & userUserAddPhoneInput.Text & "','" & hashedPassword & "','" & title_id & "')"
                            'Read through the response'
                            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                            sqlReader = sqlCmd.ExecuteReader
                            sqlConn.Close()


                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "MySql inserting a user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Finally
                            sqlConn.Dispose()
                        End Try
                        'this updates the datagridview
                        User.displayTableU("users", userDataGridView, sqlDataTableU)

                        'this changes the content of confirmMsg

                        If isFrench Then
                            confirmMsgU.Text = My.Resources.resourcesFrText.confirmMsgU_add
                        Else
                            confirmMsgU.Text = My.Resources.resourcesEnText.confirmMsgU_add

                        End If

                        'this makes the confirm message appear for 3secs
                        confirmMsgU.Visible = True
                        Timer2.Interval = 3000
                        Timer2.Start()


                        'this makes the add panel to disappear
                        userUpdatePanel.Visible = False  'play it safe and make both panels visible false 
                        userAddPanel.Visible = False

                        If isFrench Then

                            userTitle.Text = My.Resources.resourcesFrText.userTitle
                        Else

                            userTitle.Text = My.Resources.resourcesEnText.userTitle
                        End If

                        userDataGridView.Visible = True
                        userUpdateBtn.Visible = True
                        userAddBtn.Visible = True
                        exportBtnU.Visible = True
                        'PrintBtnU.Visible = True
                        searchuserlabel.Visible = True

                        userUpdateBtn.Visible = False
                        userDeleteBtn.Visible = False
                        refreshBtnU.Visible = True


                        'empty the fields after validation
                        userUserAddNameInput.Text = ""
                        userUserAddEmailInput.Text = ""
                        userUserAddPhoneInput.Text = ""
                        userUserAddPwdInput.Text = ""
                        userUserAddConfirmPwdInput.Text = ""
                        userUserAddTitleInput.Text = ""

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql adding a user", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If isFrench Then

            userTitle.Text = My.Resources.resourcesFrText.userTitle
        Else

            userTitle.Text = My.Resources.resourcesEnText.userTitle
        End If

        userDataGridView.Visible = True
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddBtn.Visible = True
        exportBtnU.Visible = True
        'PrintBtnU.Visible = True
        searchuserlabel.Visible = True
        User.displayTableU("users", userDataGridView, sqlDataTableU)
        searchErrorU.Visible = False
        refreshBtnU.Visible = True



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
        profileSubPanel3.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        refreshBtnR.Visible = True
        searchErrorR.Visible = False


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
        If isFrench Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle
        Else

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle
        End If

        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True
    End Sub

    'refresh roles button 
    Private Sub refreshBtnR_click(sender As Object, e As EventArgs) Handles refreshBtnR.Click
        User.displayTable("titles", roleDataGridView, sqlDataTableR)

        roleUpdateBtn.Visible = True
        searchErrorR.Visible = False



    End Sub

    'role update buttons
    Private Sub roleUpdateValidateBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateValidationBtn.Click 'validate update 

        If titleNameInput.Text = "" Then
            'this changes the content of updateRoleErrorMsg

            If isFrench Then
                updateRoleErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                updateRoleErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If


            'this makes the confirm message appear for 3secs
            updateRoleErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else
            Try

                Dim role_id As String = roleDataGridView.SelectedRows(0).Cells(0).Value.ToString

                connect_db()

                sqlConn.Open()

                sqlCmd.Connection = sqlConn
                'this changes the role name

                With sqlCmd

                    .CommandText = "Update " & database & ".cems_titles Set title_name ='" & titleNameInput.Text & "' where title_id = '" & role_id & "' "

                    .CommandType = CommandType.Text

                End With
                sqlCmd.ExecuteNonQuery()
                sqlConn.Close()

                'this updates the datagridview
                User.displayTable("titles", roleDataGridView, sqlDataTableR)

                'this changes the content of confirmMsg

                If isFrench Then
                    confirmMsgR.Text = My.Resources.resourcesFrText.confirmMsgR_update
                Else
                    confirmMsgR.Text = My.Resources.resourcesEnText.confirmMsgR_update

                End If


                'this makes the confirm message appear for 3secs
                confirmMsgR.Visible = True
                Timer2.Interval = 3000
                Timer2.Start()


                'this makes the update panel to disappear
                roleUpdatePanel.Visible = False
                roleUpdateBtn.Visible = False
                roleAddPanel.Visible = False

                roleDataGridView.Visible = True
                If isFrench Then

                    roleTitle.Text = My.Resources.resourcesFrText.roleTitle
                Else

                    roleTitle.Text = My.Resources.resourcesEnText.roleTitle
                End If

                roleAddBtn.Visible = True
                exportBtnR.Visible = True
                'PrintBtnR.Visible = True
                refreshBtnR.Visible = True
                searchErrorR.Visible = False



            Catch ex As Exception
                MessageBox.Show(ex.Message, "mysql update role", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End If


    End Sub

    Private Sub roleUpdateCancelBtn_Click(sender As Object, e As EventArgs) Handles roleUpdateCancelBtn.Click 'cancel
        roleUpdatePanel.Visible = False
        roleUpdateBtn.Visible = False

        roleDataGridView.Visible = True
        If isFrench Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle
        Else

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle
        End If

        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True
        refreshBtnR.Visible = True
        searchErrorR.Visible = False

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
        If isFrench Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle_Update
        Else

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle_Update
        End If

        roleAddBtn.Visible = False
        exportBtnR.Visible = False
        'PrintBtnR.Visible = False
        refreshBtnR.Visible = False
        searchErrorR.Visible = False

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
        If isFrench Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle_Add
        Else

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle_Add
        End If

        roleAddBtn.Visible = False
        exportBtnR.Visible = False
        'PrintBtnR.Visible = False
        refreshBtnR.Visible = False
        searchErrorR.Visible = False

    End Sub
    Private Sub roleAddValidationBtn_Click(sender As Object, e As EventArgs) Handles roleAddValidationBtn.Click 'validate add

        connect_db()

        If titleAddNameInput.Text = "" Then

            If isFrench Then
                addRoleErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                addRoleErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If

            addRoleErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()
        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into " & database & ".cems_titles(title_name) values ('" & titleAddNameInput.Text & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql role add", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try

            'this updates the datagridview
            User.displayTable("titles", roleDataGridView, sqlDataTableR)

            'this changes the content of confirmMsg


            If isFrench Then
                confirmMsgR.Text = My.Resources.resourcesFrText.confirmMsgR_add
            Else
                confirmMsgR.Text = My.Resources.resourcesEnText.confirmMsgR_add

            End If

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
            If isFrench Then

                roleTitle.Text = My.Resources.resourcesFrText.roleTitle
            Else

                roleTitle.Text = My.Resources.resourcesEnText.roleTitle
            End If

            roleAddBtn.Visible = True
            exportBtnR.Visible = True
            'PrintBtnR.Visible = True
            refreshBtnR.Visible = True
            searchErrorR.Visible = False

        End If
    End Sub

    Private Sub roleAddCancelBtn_Click(sender As Object, e As EventArgs) Handles roleAddCancelBtn.Click 'cancel add
        roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        roleAddPanel.Visible = False

        roleDataGridView.Visible = True
        If isFrench Then

            roleTitle.Text = My.Resources.resourcesFrText.roleTitle
        Else

            roleTitle.Text = My.Resources.resourcesEnText.roleTitle
        End If

        roleAddBtn.Visible = True
        exportBtnR.Visible = True
        'PrintBtnR.Visible = True
        refreshBtnR.Visible = True
        searchErrorR.Visible = False

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
        profileSubPanel3.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False
        refreshBtnE.Visible = True
        searchErrorE.Visible = False


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
        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
        End If

        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        'printBtnE.Visible = true
    End Sub

    'refresh equipment button 
    Private Sub refreshBtnE_click(sender As Object, e As EventArgs) Handles refreshBtnE.Click

        statePanel.Visible = False
        equipmentSearchBox.Text = ""


        hallSearchBoxE.SelectedIndex = -1

        userSearchBoxE.SelectedIndex = -1

        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

        searchErrorE.Visible = False
        equipmentDataGridView.Visible = True


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
        profileSubPanel3.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False
        searchErrorE.Visible = False


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
        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle_CPU
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle_CPU
        End If

        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        refreshBtnE.Visible = True
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
        searchErrorE.Visible = False


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle_CPU
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle_CPU
        End If


        addPostPanel.Visible = False
        refreshBtnE.Visible = True

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
        profileSubPanel3.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False
        searchErrorE.Visible = False



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
        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle_IP
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle_IP
        End If

        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        refreshBtnE.Visible = True
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
        searchErrorE.Visible = False


        addPostPanel.Visible = False
        refreshBtnE.Visible = True


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle_IP
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle_IP
        End If


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
        searchErrorE.Visible = False


        addPostPanel.Visible = False
        refreshBtnE.Visible = True

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle_Monitor
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle_Monitor
        End If


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
        profileSubPanel3.Visible = False
        hallUpdatePanel.Visible = False
        hallAddpanel.Visible = False
        userUpdatePanel.Visible = False
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False
        userAddPanel.Visible = False
        roleUpdateBtn.Visible = False
        roleUpdatePanel.Visible = False
        roleAddPanel.Visible = False
        searchErrorE.Visible = False


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
        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle_Monitor
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle_Monitor
        End If

        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        refreshBtnE.Visible = True
        'printBtnE.Visible = True

    End Sub

    'Equipment add section
    Private Sub addEquipmentBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentBtn.Click
        addEquipmentPanel.Visible = True
        fillcombo(postIdInput, "posts", "post_id")
        fillcomboEquipment(equipmentTypeInput, "equipments", "equipment_type")

        fillHalls(hallInput)

        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_Add
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_Add
        End If
        equipmentDataGridView.Visible = False
        equipmentSearchBox.Visible = False
        equipmentsearchpostidlabel.Visible = False
        addEquipmentBtn.Visible = False
        statePanel.Visible = False
        exportBtnE.Visible = False
        'printBtnE.Visible = False
        refreshBtnE.Visible = False
        searchErrorE.Visible = False

    End Sub

    Private Sub addEquipmentCancelBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentCancelBtn.Click
        addEquipmentPanel.Visible = False

        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
        End If
        equipmentDataGridView.Visible = True
        equipmentSearchBox.Visible = True
        equipmentsearchpostidlabel.Visible = True
        addEquipmentBtn.Visible = True
        exportBtnE.Visible = True
        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)
        searchErrorE.Visible = False
        'printBtnE.Visible = True
        refreshBtnE.Visible = True

    End Sub

    Private Sub addEquipmentValidationBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentValidationBtn.Click
        connect_db()

        If equipmentTypeInput.Text = "" Or equipmentStateInput.Text = "" Then

            If isFrench Then
                addEquipmentErrorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                addEquipmentErrorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If

            addEquipmentErrorMsg.Visible = True
            Timer2.Interval = 3000
            Timer2.Start()

        Else
            Dim hall_id As Integer
            Dim post_id As String = postIdInput.Text
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallInput.Text & "'"


                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    hall_id = sqlReader.Item("hall_id")
                End While

                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql getting the hall id ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()

            End Try



            If hallInput.Text = "" And postIdInput.Text = "" Then
                Try
                    sqlConn.Open()
                    sqlQuery = "insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "',1,1)"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

                    'this changes the content of confirmMsg

                    If isFrench Then
                        confirmMsgE.Text = My.Resources.resourcesFrText.confirmMsgE_add
                    Else
                        confirmMsgE.Text = My.Resources.resourcesEnText.confirmMsgE_add

                    End If


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


                    If isFrench Then

                        EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
                    Else

                        EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
                    End If
                    equipmentDataGridView.Visible = True
                    equipmentSearchBox.Visible = True
                    equipmentsearchpostidlabel.Visible = True
                    addEquipmentBtn.Visible = True
                    exportBtnE.Visible = True
                    refreshBtnE.Visible = True
                    searchErrorE.Visible = False

                    'printBtnE.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql if hall and post are not specified", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            ElseIf hallInput.Text = "" Then
                Try
                    sqlConn.Open()
                    sqlQuery = "insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "','" & post_id & "',0)"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

                    'this changes the content of confirmMsg
                    If isFrench Then
                        confirmMsgE.Text = My.Resources.resourcesFrText.confirmMsgE_add
                    Else
                        confirmMsgE.Text = My.Resources.resourcesEnText.confirmMsgE_add

                    End If
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


                    If isFrench Then

                        EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
                    Else

                        EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
                    End If
                    equipmentDataGridView.Visible = True
                    equipmentSearchBox.Visible = True
                    equipmentsearchpostidlabel.Visible = True
                    addEquipmentBtn.Visible = True
                    exportBtnE.Visible = True
                    refreshBtnE.Visible = True
                    searchErrorE.Visible = False

                    'printBtnE.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql if hall is not specified", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try

            ElseIf postIdInput.Text = "" Then
                Try
                    sqlConn.Open()
                    sqlQuery = "insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "',0,'" & hall_id & "')"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

                    'this changes the content of confirmMsg
                    If isFrench Then
                        confirmMsgE.Text = My.Resources.resourcesFrText.confirmMsgE_add
                    Else
                        confirmMsgE.Text = My.Resources.resourcesEnText.confirmMsgE_add

                    End If
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


                    If isFrench Then

                        EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
                    Else

                        EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
                    End If
                    equipmentDataGridView.Visible = True
                    equipmentSearchBox.Visible = True
                    equipmentsearchpostidlabel.Visible = True
                    addEquipmentBtn.Visible = True
                    exportBtnE.Visible = True
                    refreshBtnE.Visible = True
                    searchErrorE.Visible = False

                    'printBtnE.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql if post is not specified", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    sqlConn.Dispose()
                End Try
            Else
                Try
                    sqlConn.Open()
                    sqlQuery = "insert into " & database & ".cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & equipmentTypeInput.Text & "','" & equipmentStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                    'Read through the response'
                    sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                    sqlReader = sqlCmd.ExecuteReader
                    sqlConn.Close()

                    'this updates the datagridview
                    User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

                    'this changes the content of confirmMsg
                    If isFrench Then
                        confirmMsgE.Text = My.Resources.resourcesFrText.confirmMsgE_add
                    Else
                        confirmMsgE.Text = My.Resources.resourcesEnText.confirmMsgE_add

                    End If
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


                    If isFrench Then

                        EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
                    Else

                        EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
                    End If
                    equipmentDataGridView.Visible = True
                    equipmentSearchBox.Visible = True
                    equipmentsearchpostidlabel.Visible = True
                    addEquipmentBtn.Visible = True
                    exportBtnE.Visible = True
                    refreshBtnE.Visible = True
                    searchErrorE.Visible = False

                    'printBtnE.Visible = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "MySql if all the inputs are specified", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            .CommandText = "Update " & database & ".cems_equipments Set equipment_state ='" & equipmentState.Text & "' where equipment_id = '" & equipment_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd
            'possible problem
            .CommandText = "Update " & database & ".cems_posts Set post_state ='" & equipmentState.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()



        statePanel.Visible = False

        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)
        fillHalls(hallSearchBoxE)
    End Sub

    'delete equipment

    Private Sub equipmentdeleteBtn_Click(sender As Object, e As EventArgs)  'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this equipment ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(equipmentDataGridView, "equipments", "equipment")
        End If

        statePanel.Visible = False

        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

    End Sub


    'logout button
    Private Sub adminLogout_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
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


        User.export(roleDataGridView, "Roles", isFrench)


        sqlConn.Dispose()

        confirmMsgR.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()

    End Sub


    'halls export 

    Private Sub exportBtnH_Click(sender As Object, e As EventArgs) Handles exportBtnH.Click 'hall



        User.export(hallDataGridView, "halls", isFrench)
        sqlConn.Dispose()

        'this will make the message appear for three seconds
        confirmMsgH.Visible = True

        If isFrench Then
            confirmMsgH.Text = My.Resources.resourcesFrText.export
        Else
            confirmMsgH.Text = My.Resources.resourcesEnText.export

        End If

        Timer2.Interval = 3000
        Timer2.Start()
    End Sub


    'user export 

    Private Sub exportBtnu_Click(sender As Object, e As EventArgs) Handles exportBtnU.Click 'user 

        User.export(userDataGridView, "users", isFrench)

        sqlConn.Dispose()

        'this will make the message appear for three seconds
        confirmMsgU.Visible = True

        If isFrench Then
            confirmMsgU.Text = My.Resources.resourcesFrText.export
        Else
            confirmMsgU.Text = My.Resources.resourcesEnText.export

        End If

        Timer2.Interval = 3000
        Timer2.Start()
    End Sub


    'post export
    Private Sub exportBtnP_Click(sender As Object, e As EventArgs) Handles exportBtnP.Click

        User.export(postDataGridView, "posts", isFrench)
        sqlConn.Dispose()

        confirmMsgP.Visible = True

        If isFrench Then
            confirmMsgP.Text = My.Resources.resourcesFrText.export
        Else
            confirmMsgP.Text = My.Resources.resourcesEnText.export

        End If

        Timer2.Interval = 3000
        Timer2.Start()

    End Sub

    'equipment export
    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click

        Try

            User.export(equipmentDataGridView, "equipments", isFrench)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        'this will make the message appear for three seconds
        confirmMsgE.Visible = True

        If isFrench Then
            confirmMsgE.Text = My.Resources.resourcesFrText.export
        Else
            confirmMsgE.Text = My.Resources.resourcesEnText.export

        End If

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

            sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxH.Text & "'"


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

        hallUpdateBtn.Visible = False
        hallDeleteBtn.Visible = False

    End Sub


    'equipment searches
    Private Sub equipmentSearchBox_textChanged(sender As Object, e As EventArgs) Handles equipmentSearchBox.TextChanged

        User.search("equipments", equipmentDataGridView, "post_id", equipmentSearchBox.Text, searchErrorE, sqlDataTableE)


        statePanel.Visible = False

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

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxE.Text & "'"



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

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxE.Text & "'"



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

        statePanel.Visible = False
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

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxE.Text & "'"


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

        statePanel.Visible = False

    End Sub


    'user searches
    Private Sub userSearchBox_textChanged(sender As Object, e As EventArgs) Handles userSearchBox.TextChanged

        User.searchU("users", userDataGridView, "user_name", userSearchBox.Text, searchErrorU, sqlDataTableU)

        'make the modification buttons disappear
        userUpdateBtn.Visible = False
        userDeleteBtn.Visible = False

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

        hallSearchBoxP.SelectedIndex = -1
        If postSearchBox.Text = "" And stateSearchBoxP.Text <> "" Then

            User.displayTableP("posts", postDataGridView, sqlDataTableP)

        ElseIf postSearchBox.Text = "" Then

            User.displayTableP("posts", postDataGridView, sqlDataTableP)

        ElseIf stateSearchBoxP.Text <> "" Then

            User.searchPostAndStateP("posts", postDataGridView, "post_state", stateSearchBoxP.Text, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)

        Else
            User.searchP("posts", postDataGridView, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)

        End If


        postChangeStatePanel.Visible = False

    End Sub

    'post search by state
    Private Sub stateSearchBoxP_textChanged(sender As Object, e As EventArgs) Handles stateSearchBoxP.TextChanged


        Dim hall_id As Integer

        If hallSearchBoxP.Text <> "" Then

            postSearchBox.Text = ""
            'SQL Connection'
            connect_db()

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxP.Text & "'"


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
        ElseIf postSearchBox.Text <> "" Then
            hallSearchBoxP.SelectedIndex = -1

            User.searchPostAndStateP("posts", postDataGridView, "post_state", stateSearchBoxP.Text, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)

        Else

            User.searchHallAndState("posts", postDataGridView, "post_state", stateSearchBoxP.Text, searchErrorP, sqlDataTableP)
        End If


        postChangeStatePanel.Visible = False

    End Sub


    'post hall search
    Private Sub hallSearchBoxP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxP.SelectedIndexChanged
        Dim hall_id As Integer


        If stateSearchBoxP.Text <> "" Then

            'SQL Connection'
            connect_db()

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxP.Text & "'"


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

                sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & hallSearchBoxP.Text & "'"


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


        postChangeStatePanel.Visible = False

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
            MessageBox.Show(ex.Message, "print error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        updateRoleErrorMsg.Visible = False
        updateUserErrorMsg.Visible = False
        updateHallErrorMsg.Visible = False
        changePwdErrorMsg.Visible = False

        Timer2.Stop()
    End Sub


    'print page
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If postDataGridView.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub

    'accept only digits for phone number input boxes 
    Private Sub textBoxPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles userUserPhoneInput.KeyPress, userUserAddPhoneInput.KeyPress, userPhoneNumberProfileInput.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    'checks the format of email 

    Private Sub userUserEmailInput_TextChanged(sender As Object, e As EventArgs) Handles userUserEmailInput.TextChanged
        textBoxEmail_Validating(userUserEmailInput)
    End Sub
    Private Sub userUserAddEmailInput_TextChanged(sender As Object, e As EventArgs) Handles userUserAddEmailInput.TextChanged
        textBoxEmail_Validating(userUserAddEmailInput)
    End Sub

    Private Sub userEmailProfileInput_TextChanged(sender As Object, e As EventArgs) Handles userEmailProfileInput.TextChanged
        textBoxEmail_Validating(userEmailProfileInput)
    End Sub

    Private Sub textBoxEmail_Validating(textBoxEmail As TextBox)
        Dim email As String = textBoxEmail.Text

        ' Check for email format
        If Not User.IsValidEmail(email) Then
            errorProviderEmail.SetError(textBoxEmail, "Invalid email format")
        Else
            errorProviderEmail.SetError(textBoxEmail, "") ' Clear the error message
        End If
    End Sub




    'close all the servers when the app is closed
    Private Sub adminHomePage_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form1.Close()

        ' Stop Apache

        Try

            'Dim apacheProcesses() As Process = Process.GetProcessesByName("httpd")
            'For Each apacheProcess As Process In apacheProcesses
            '    If Not apacheProcess.CloseMainWindow() Then
            '        apacheProcess.Kill()
            '    End If
            'Next
            '
            ' Stop MySQL
            Dim mysqlProcesses() As Process = Process.GetProcessesByName("mysqld")
            For Each mysqlProcess As Process In mysqlProcesses
                If Not mysqlProcess.CloseMainWindow() Then
                    mysqlProcess.Kill()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "close the server", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub countEquipmentTypeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countEquipmentTypeCombo.SelectedIndexChanged

        Dim hall_id As Integer
        'SQL Connection'

        Try
            sqlConn.Open()

            sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & countHallCombo.Text & "'"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            While (sqlReader.Read())
                hall_id = sqlReader.Item("hall_id")
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql getting the hall id ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try

        If countHallCombo.Text = "" Then
            admin.activeCount(countEquipmentNumber, "equipments", countEquipmentTypeCombo.Text)
            admin.activeCount(countEquipmentNumber, "posts")


        Else
            admin.activeCount(countEquipmentNumber, "equipments", countEquipmentTypeCombo.Text, hall_id)

            admin.activeCountHall(countPostNumber, "posts", hall_id)

        End If

    End Sub


    Private Sub countHallCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countHallCombo.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'

        Try
            sqlConn.Open()

            sqlQuery = "select hall_id from  " & database & ".cems_halls where hall_name = '" & countHallCombo.Text & "'"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader

            While (sqlReader.Read())
                hall_id = sqlReader.Item("hall_id")
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql getting the hall id ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try

        If countEquipmentTypeCombo.Text = "" Then
            admin.activeCountHall(countEquipmentNumber, "equipments", hall_id)

            admin.activeCountHall(countPostNumber, "posts", hall_id)

        Else
            admin.activeCount(countEquipmentNumber, "equipments", countEquipmentTypeCombo.Text, hall_id)

            admin.activeCountHall(countPostNumber, "posts", hall_id)

        End If

    End Sub


    Private Sub adminupdateHallinput_TextChanged(sender As Object, e As KeyEventArgs) Handles adminUpdateHallNameInput.KeyDown, adminUpdateHallIdInput.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            hallUpdateValidateBtn_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub

    Private Sub adminAddHallNameInput_TextChanged(sender As Object, e As KeyEventArgs) Handles adminAddHallNameInput.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            HallAddValidateBtn_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub

    Private Sub userUserAddConfirmPwdInput_TextChanged(sender As Object, e As KeyEventArgs) Handles userUserAddConfirmPwdInput.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            userAddValidateBtn_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub

    Private Sub userConfirmPwdProfileInput_TextChanged(sender As Object, e As KeyEventArgs) Handles userConfirmPwdProfileInput.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            changePwdValidationBtn_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub
    Private Sub userPhoneNumberProfileInput_TextChanged(sender As Object, e As KeyEventArgs) Handles userPhoneNumberProfileInput.KeyDown 'the magical enter press trigger an event function (works on a particular inputbox)
        If e.KeyCode = Keys.Enter Then
            updateProfileValidateBtn_ClickAsync(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub


    'styles









    'General styles part 


End Class
