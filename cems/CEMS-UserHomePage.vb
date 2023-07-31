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



    Private Sub UserHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        User.showUserName(Form1.emailtxt, uName)

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

        userPostPanel.Visible = True
        userEquipmentPanel.Visible = False
        userProfilePanel.Visible = False
        profileSubPanel2.Visible = False

        equipmentSearchBox.Text = ""
        postSearchBox.Text = ""
        hallSearchBoxP.Text = ""
        hallSearchBoxE.Text = ""
        userSearchBoxE.Text = ""
        stateSearchBoxP.Text = ""
        fillcomboState(stateSearchBoxP, "posts", "post_state")

        User.displayTableP("posts", postDataGridView, sqlDataTableP)

        fillHalls(hallSearchBoxP)

    End Sub
    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click

        userProfilePanel.Visible = True
        userEquipmentPanel.Visible = False
        userPostPanel.Visible = False
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
        User.displayTableE("equipments", equipmentDataGridView, sqlDataTableE)


        fillcomboState(userSearchBoxE, "equipments", "equipment_state")


        fillHalls(hallSearchBoxE)
    End Sub

    'equipment subbuttons

    Private Sub CPUsBtn_Click(sender As Object, e As EventArgs) Handles CPUsBtn.Click
        User.display(userEquipmentPanel, EquipmentTitle, "CPUs")
        User.displayEquipmentTable("equipments", "CPU", equipmentDataGridView)

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
        User.displayEquipmentTable("equipments", "CPU", equipmentDataGridView)

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
        User.displayEquipmentTable("equipments", "IP_Phone", equipmentDataGridView)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

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
        User.displayEquipmentTable("equipments", "IP_Phone", equipmentDataGridView)

        userEquipmentPanel.Visible = True

        userPostPanel.Visible = False

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
        User.displayEquipmentTable("equipments", "Monitor", equipmentDataGridView)

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
        User.displayEquipmentTable("equipments", "Monitor", equipmentDataGridView)

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

        User.showUserName(Form1.emailtxt, uName)
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


        User.export(postDataGridView, "posts")
        sqlConn.Dispose()

        confirmMsgP.Visible = True
        Timer2.Interval = 3000
        Timer2.Start()

    End Sub

    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click


        User.export(equipmentDataGridView, "equipments")
        sqlConn.Dispose()

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


End Class
