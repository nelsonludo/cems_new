Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports System.IO
Imports System.Data.SqlClient

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
            sqlQuery = "select * from cems.cems_users where user_email = '" & Form1.emailtxt.Text & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                uName.Text = sqlReader.Item("user_name")

            End If

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub UserHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        showUserName()

        dropdown.Size = dropdown.MinimumSize

        User.activeCount(activeCPUNumber, "equipments", "equipment", "good", "CPU")
        User.activeCount(activeIPNumber, "equipments", "equipment", "good", "IP_phone")
        User.activeCount(activeMonitorNumber, "equipments", "equipment", "good", "monitor")


        User.activeCount(nonActiveCPUNumber, "equipments", "equipment", "bad", "CPU")
        User.activeCount(nonActiveIPNumber, "equipments", "equipment", "bad", "IP_phone")
        User.activeCount(nonActiveMonitorNumber, "equipments", "equipment", "bad", "monitor")




    End Sub

    Private Sub UserHomePage_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form1.Close()

    End Sub

    'to load the new user information in the profile panel


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


    Private Sub fillcomboState(search As ComboBox, table As String, fillvalue As String)

        search.Items.Clear()


        search.Items.Add("Good")
        search.Items.Add("Bad")
        search.Items.Add("In reparation")

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

    'tab buttons section


    Private Sub postsBtn_Click(sender As Object, e As EventArgs) Handles postsBtn.Click

        userEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        userPostPanel.Visible = True
        userProfilePanel.Visible = False
        profileSubPanel2.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""
        fillcomboState(stateSearchBoxP, "posts", "post_state")

        User.displayTableP("posts", DataGridView2, sqlDataTableP)

        fillHalls(hallSearchBoxP)

    End Sub
    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        userEquipmentPanel.Visible = False 'this is set to true because somehow the postpanel is inside the equipmentpanel
        userPostPanel.Visible = False 'this is set to true because somehow the profilepanel is inside the postpanel
        userProfilePanel.Visible = True
        profileSubPanel2.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        connect_db()
        User.updateUserInformation("users", "user", Form1.emailtxt, userNameProfile, userEmailProfile, userPhoneNumberProfile, userTitleProfile)

    End Sub


    Private Sub equipmentsBtn_Click(sender As Object, e As EventArgs) Handles equipmentsBtn.Click
        Timer1.Start()


        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False

        exportBtnE.Visible = True

        profileSubPanel2.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        User.display(userEquipmentPanel, EquipmentTitle, "Equipments")
        User.displayTableE("equipments", DataGridView1, sqlDataTableE)


        fillcomboState(userSearchBoxE, "equipments", "equipment_state")


        fillHalls(hallSearchBoxE)
    End Sub

    'equipment subbuttons

    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click
        User.display(userEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        profileSubPanel2.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub
    Private Sub CPUsBtn2_Click(sender As Object, e As EventArgs) Handles CPUsBtn2.Click
        User.display(userEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        profileSubPanel2.Visible = False

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub IPsBtn_Click(sender As Object, e As EventArgs) Handles IPsBtn.Click
        User.display(userEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_Phone", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        User.display(userEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "Monitor", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub IPsBtn2_Click(sender As Object, e As EventArgs) Handles IPsBtn2.Click
        User.display(userEquipmentPanel, EquipmentTitle, "IP Phones")
        User.displayEquipmentTable("equipments", "IP_Phone", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        User.display(userEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "Monitor", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub monitorsBtn_Click(sender As Object, e As EventArgs) Handles monitorsBtn.Click
        User.display(userEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "Monitor", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False


        profileSubPanel2.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub monitorsBtn2_Click(sender As Object, e As EventArgs) Handles monitorsBtn2.Click
        User.display(userEquipmentPanel, EquipmentTitle, "Monitors")
        User.displayEquipmentTable("equipments", "Monitor", DataGridView1)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

        userProfilePanel.Visible = False


        profileSubPanel2.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        fillHalls(hallSearchBoxE)

    End Sub

    Private Sub userLogout_Click(sender As Object, e As EventArgs) Handles userLogout.Click
        Form1.Show()
        Me.Visible = False

        Form1.emailtxt.Text = ""
        Form1.passwordtxt.Text = ""

        userEquipmentPanel.Visible = False

        userPostPanel.Visible = False

        userProfilePanel.Visible = False
        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""

        exportBtnE.Visible = False

    End Sub

    'update buttons 
    Private Sub updateProfileShowBtn_Click(sender As Object, e As EventArgs) Handles updateProfileShowBtn.Click
        profileSubPanel2.Visible = True

        userNameProfileInput.Text = userNameProfile.Text
        userPhoneNumberProfileInput.Text = userPhoneNumberProfile.Text
        userEmailProfileInput.Text = userEmailProfile.Text
    End Sub

    Private Sub updateProfileCancelBtn_Click(sender As Object, e As EventArgs) Handles updateProfileCancelBtn.Click
        profileSubPanel2.Visible = False
        updateProfileErrorMsg.Visible = False
    End Sub

    Private Sub updateProfileValidateBtn_Click(sender As Object, e As EventArgs) Handles updateProfileValidateBtn.Click

        User.updateUser("users", "user", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, userPwdProfileInput.Text, userConfirmPwdProfileInput.Text, Form1.emailtxt.Text, updateProfileErrorMsg, profileSubPanel2, Timer2)
        User.updateUserInformation("users", "user", Form1.emailtxt, userNameProfile, userEmailProfile, userPhoneNumberProfile, userTitleProfile)

        'confirm message
        confirmMsgPr.Visible = True

        'timer interval 
        Timer2.Interval = 3000
        Timer2.Start()

        showUserName()
    End Sub

    'searches section
    Private Sub equipmentSearchBox_textChanged(sender As Object, e As EventArgs) Handles equipmentSearchBox.TextChanged

        User.search("equipments", DataGridView1, "post_id", equipmentSearchBox.Text, searchErrorE, sqlDataTableE)

    End Sub

    Private Sub postSearchBox_textChanged(sender As Object, e As EventArgs) Handles postSearchBox.TextChanged

        User.searchP("posts", DataGridView2, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)
    End Sub

    'search by halls in posts 
    Private Sub hallSearchBoxP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxP.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password=" + password + ";" + "database =" + database


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

    'search by halls in equipment
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

    'equipment search by state
    Private Sub usersearchboxe_textChanged(sender As Object, e As EventArgs) Handles userSearchBoxE.TextChanged

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

        User.searchHallAndState("equipments", DataGridView1, "hall_id", hall_id, "equipment_state", userSearchBoxE.Text, searchErrorE, sqlDataTableCBHE)
    End Sub

    'post search by state
    Private Sub stateSearchBoxP_textChanged(sender As Object, e As EventArgs) Handles stateSearchBoxP.TextChanged

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


        User.searchHallAndStateP("posts", DataGridView2, "hall_id", hall_id, "post_state", stateSearchBoxP.Text, searchErrorP, sqlDataTableP)


    End Sub

    'export buttons 
    Private Sub exportBtnP_Click(sender As Object, e As EventArgs) Handles exportBtnP.Click

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

    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click

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


    'this is the second timer function which is used to make the timer stop
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        confirmMsgP.Visible = False
        confirmMsgE.Visible = False
        updateProfileErrorMsg.Visible = False
        confirmMsgPr.Visible = False
        Timer2.Stop()
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


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If Me.DataGridView2.Height = recp.Height > 0 Then e.HasMorePages = True

    End Sub


End Class
