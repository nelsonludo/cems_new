Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports System.IO
Imports System.Data.SqlClient
Imports System.Resources
Imports System.Globalization
Imports System.Threading
Imports System.Text.RegularExpressions

Public Class UserHomePage
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
    Dim sqlDataAdaptor As New MySqlDataAdapter
    Dim sqlQuery As String

    Public server As String = Form1.server
    Public username As String = Form1.username
    Public password As String = Form1.password
    Public database As String = Form1.database

    Dim User As New users
    Dim admin As New admin

    Dim bitmap As Bitmap

    Dim isFrench As Boolean = True

    Dim iscollapsed As Boolean = True
    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password=" + password + ";" + "database =" + database
    End Sub


    'this is the translation section 
    Private resourceManager As New ResourceManager("cems.Resources", GetType(UserHomePage).Assembly)

    Private Sub UserHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HomePagePanel.Visible = True

        TranslateFormControlsFrench(Me)


        User.showUserName(Form1.emailtxt, uName)

        dropdown.Size = dropdown.MinimumSize

        User.activeCount(activeCPUNumber, "equipments", "equipment", "good", "CPU")
        User.activeCount(activeIPNumber, "equipments", "equipment", "good", "IP_phone")
        User.activeCount(activeMonitorNumber, "equipments", "equipment", "good", "monitor")


        User.activeCount(nonActiveCPUNumber, "equipments", "equipment", "bad", "CPU")
        User.activeCount(nonActiveIPNumber, "equipments", "equipment", "bad", "IP_phone")
        User.activeCount(nonActiveMonitorNumber, "equipments", "equipment", "bad", "monitor")

        User.activeCount(repairCPUNumber, "equipments", "equipment", "In reparation", "CPU")
        User.activeCount(repairIPNumber, "equipments", "equipment", "In reparation", "IP_phone")
        User.activeCount(repairMonitorNumber, "equipments", "equipment", "In reparation", "monitor")




    End Sub


    'to load the new user information in the profile panel


    'dropdown code 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        User.dropdownTimer(iscollapsed, dropdown, Timer1)
    End Sub


    Private Sub fillcomboState(search As ComboBox, table As String, fillvalue As String)

        search.Items.Clear()



        search.Items.Add("Good")
        search.Items.Add("Bad")
        search.Items.Add("In reparation")

    End Sub

    Private Sub fillHalls(search As ComboBox)

        search.Items.Clear()

        connect_db()
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

        If PostPanel.Visible = True Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle
        End If

        If EquipmentPanel.Visible = True Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle

        End If

        If ProfilePanel.Visible = True Then

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

        If PostPanel.Visible = True Then

            postTitle.Text = My.Resources.resourcesEnText.postTitle
        End If

        If EquipmentPanel.Visible = True Then

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle

        End If

        If ProfilePanel.Visible = True Then

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle
        End If

        If profileSubPanel2.Visible = True Then

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle_Update
        End If

    End Sub

    'tab buttons section

    'dashboard
    Private Sub dashboard_click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        PostPanel.Visible = False
        EquipmentPanel.Visible = False
        ProfilePanel.Visible = False
        profileSubPanel2.Visible = False
        HomePagePanel.Visible = True

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        User.activeCount(activeCPUNumber, "equipments", "equipment", "good", "CPU")
        User.activeCount(activeIPNumber, "equipments", "equipment", "good", "IP_phone")
        User.activeCount(activeMonitorNumber, "equipments", "equipment", "good", "monitor")


        User.activeCount(nonActiveCPUNumber, "equipments", "equipment", "bad", "CPU")
        User.activeCount(nonActiveIPNumber, "equipments", "equipment", "bad", "IP_phone")
        User.activeCount(nonActiveMonitorNumber, "equipments", "equipment", "bad", "monitor")

        User.activeCount(repairCPUNumber, "equipments", "equipment", "In reparation", "CPU")
        User.activeCount(repairIPNumber, "equipments", "equipment", "In reparation", "IP_phone")
        User.activeCount(repairMonitorNumber, "equipments", "equipment", "In reparation", "monitor")

    End Sub

    'profile buttons
    Private Async Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        ProfilePanel.Visible = True
        EquipmentPanel.Visible = False
        PostPanel.Visible = False
        profileSubPanel2.Visible = False
        profileSubPanel1.Visible = True
        HomePagePanel.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""
        If isFrench Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle
        Else

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle
        End If


        connect_db()
        Await User.updateUserInformation("users", "user", Form1.user_email, userNameProfile, userEmailProfile, userPhoneNumberProfile, userTitleProfile)

    End Sub

    'update buttons 
    Private Sub updateProfileShowBtn_Click(sender As Object, e As EventArgs) Handles updateProfileShowBtn.Click
        profileSubPanel2.Visible = True
        profileSubPanel1.Visible = False

        userNameProfileInput.Text = userNameProfile.Text
        userPhoneNumberProfileInput.Text = userPhoneNumberProfile.Text
        userEmailProfileInput.Text = userEmailProfile.Text

        userPwdProfileInput.Text = ""
        userConfirmPwdProfileInput.Text = ""

        If isFrench Then

            profileTitle.Text = My.Resources.resourcesFrText.profileTitle_Update
        Else

            profileTitle.Text = My.Resources.resourcesEnText.profileTitle_Update
        End If

    End Sub

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

    Private Async Sub updateProfileValidateBtn_Click(sender As Object, e As EventArgs) Handles updateProfileValidationBtn.Click

        'this function is called to update the user information in the database and do all the client side validations
        User.updateUser(isFrench, "users", "user", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, Form1.user_email, updateProfileErrorMsg, profileSubPanel2, Timer2)

        'this variable store the value returned by the updateuser() function 
        Dim userUpdateCall As Boolean = User.updateUser(isFrench, "users", "user", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, Form1.user_email, updateProfileErrorMsg, profileSubPanel2, Timer2)


        Await User.updateUserInformation("users", "user", Form1.user_email, userNameProfile, userEmailProfile, userPhoneNumberProfile, userTitleProfile)


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

            User.showUserName(Form1.emailtxt, uName)

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

            User.showUserName(Form1.emailtxt, uName)

        End If
    End Sub

    'post buttons 
    Private Sub postsBtn_Click(sender As Object, e As EventArgs) Handles postsBtn.Click

        PostPanel.Visible = True
        EquipmentPanel.Visible = False
        ProfilePanel.Visible = False
        profileSubPanel2.Visible = False
        HomePagePanel.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""
        fillcomboState(stateSearchBoxP, "posts", "post_state")

        User.displayTableP("posts", postDataGridView, sqlDataTableP)

        fillHalls(hallSearchBoxP)


        If isFrench Then

            postTitle.Text = My.Resources.resourcesFrText.postTitle
        Else

            postTitle.Text = My.Resources.resourcesEnText.postTitle
        End If

    End Sub

    'refresh post button 
    Private Sub refreshBtnP_click(sender As Object, e As EventArgs) Handles refreshBtnP.Click
        'empty the fields after validation
        postSearchBox.Text = ""


        hallSearchBoxP.SelectedIndex = -1

        stateSearchBoxP.SelectedIndex = -1



        'this updates the datagridview
        User.displayTableP("posts", postDataGridView, sqlDataTableP)  'this is a useless comment //you're the useless comment !

        searchErrorP.Visible = False
        postDataGridView.Visible = True
    End Sub

    Private Sub equipmentsBtn_Click(sender As Object, e As EventArgs) Handles equipmentsBtn.Click
        Timer1.Start()


        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False

        exportBtnE.Visible = True

        profileSubPanel2.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        User.display(EquipmentPanel, EquipmentTitle, "Equipments")
        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)


        fillcomboState(userSearchBoxE, "equipments", "equipment_state")


        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.equipmentTitle
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.equipmentTitle
        End If

    End Sub

    'refresh equipment button 
    Private Sub refreshBtnE_click(sender As Object, e As EventArgs) Handles refreshBtnE.Click

        equipmentSearchBox.Text = ""


        hallSearchBoxE.SelectedIndex = -1

        userSearchBoxE.SelectedIndex = -1

        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)

        searchErrorE.Visible = False
        equipmentDataGridView.Visible = True


    End Sub

    'equipment subbuttons

    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click

        User.display(EquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", equipmentDataGridView)

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        profileSubPanel2.Visible = False

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_CPU
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_CPU
        End If


    End Sub
    Private Sub CPUsBtn2_Click(sender As Object, e As EventArgs) Handles CPUsBtn2.Click
        User.display(EquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", equipmentDataGridView)

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        profileSubPanel2.Visible = False

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_CPU
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_CPU
        End If


    End Sub

    Private Sub IPsBtn_Click(sender As Object, e As EventArgs) Handles IPsBtn.Click
        User.display(EquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_Phone", equipmentDataGridView)

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_IP
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_IP
        End If


    End Sub

    Private Sub IPsBtn2_Click(sender As Object, e As EventArgs) Handles IPsBtn2.Click
        User.display(EquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_Phone", equipmentDataGridView)

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_IP
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_IP
        End If


    End Sub

    Private Sub monitorsBtn_Click(sender As Object, e As EventArgs) Handles monitorsBtn.Click
        User.display(EquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "Monitor", equipmentDataGridView)

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False


        profileSubPanel2.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_Monitor
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_Monitor
        End If


    End Sub

    Private Sub monitorsBtn2_Click(sender As Object, e As EventArgs) Handles monitorsBtn2.Click
        User.display(EquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "Monitor", equipmentDataGridView)

        EquipmentPanel.Visible = True

        PostPanel.Visible = False

        ProfilePanel.Visible = False


        profileSubPanel2.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)


        If isFrench Then

            EquipmentTitle.Text = My.Resources.resourcesFrText.EquipmentTitle_Monitor
        Else

            EquipmentTitle.Text = My.Resources.resourcesEnText.EquipmentTitle_Monitor
        End If


    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Visible = False

        Form1.emailtxt.Text = ""
        Form1.passwordtxt.Text = ""

        EquipmentPanel.Visible = False

        PostPanel.Visible = False

        ProfilePanel.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        exportBtnE.Visible = False

    End Sub


    'searches section
    Private Sub equipmentSearchBox_textChanged(sender As Object, e As EventArgs) Handles equipmentSearchBox.TextChanged

        User.search("equipments", equipmentDataGridView, "post_id", equipmentSearchBox.Text, searchErrorE, sqlDataTableE)

    End Sub

    Private Sub postSearchBox_textChanged(sender As Object, e As EventArgs) Handles postSearchBox.TextChanged

        User.searchP("posts", postDataGridView, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)
    End Sub



    'search by halls in posts 


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

    'export buttons 
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

    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click


        User.export(equipmentDataGridView, "equipments", isFrench)
        sqlConn.Dispose()

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


    'this is the second timer function which is used to make the timer stop
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        confirmMsgP.Visible = False
        confirmMsgE.Visible = False
        updateProfileErrorMsg.Visible = False
        confirmMsgPr.Visible = False
        Timer2.Stop()
    End Sub


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


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If Me.postDataGridView.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub


    'accept only digits for phone number input boxes 
    Private Sub textBoxPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles userPhoneNumberProfileInput.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    'checks for email format 

    Private Sub userEmailProfileInput_TextChanged(sender As Object, e As EventArgs) Handles userEmailProfileInput.TextChanged
        textBoxEmail_Validating(userEmailProfileInput)
    End Sub

    Private Sub textBoxEmail_Validating(textBoxEmail As TextBox)
        Dim email As String = textBoxEmail.Text

        ' Check for email format
        IsValidEmail(email)

        If Not IsValidEmail(email) Then
            errorProviderEmail.SetError(textBoxEmail, "Invalid email format")
        Else
            errorProviderEmail.SetError(textBoxEmail, "") ' Clear the error message
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function


    'close all the servers when the app is closed
    Private Sub userHomePage_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form1.Close()

        Try
            ' stop apache
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "close the server", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'General styles part 


End Class
