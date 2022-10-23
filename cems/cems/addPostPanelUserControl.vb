Imports MySql.Data.MySqlClient


Public Class addPostPanelUserControl
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


    Dim bitmap As Bitmap

    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
               + "password=" + password + ";" + "database =" + database
    End Sub
    Private Sub addPostValidationBtn_Click(sender As Object, e As EventArgs) Handles addPostValidationBtn.Click
        connect_db()

        If addPostPanelUserControl.postStateInput.Text = "" Or addPostPanelUserControl.postHallInput.Text = "" Then
            addPostPanelUserControl.addPostErrorMsg.Text = "please fill all the fields !"
            addPostPanelUserControl.addPostErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()

        Else
            Dim hall_id As Integer
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & addPostPanelUserControl.postHallInput.Text & "'"


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
                sqlQuery = "insert into cems.cems_posts(post_id,hall_id, post_state) values ('" & addPostPanelUserControl.postPostIdInput.Text & "','" & hall_id & "','" & addPostPanelUserControl.postStateInput.Text & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

                Dim post_id As String = addPostPanelUserControl.postPostIdInput.Text

                sqlConn.Open()
                sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('IP_Phone','" & addPostPanelUserControl.postStateInput.Text & "','" & post_id & "','" & hall_id & "');insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('CPU','" & addPostPanelUserControl.postStateInput.Text & "','" & post_id & "','" & hall_id & "');insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('Monitor','" & addPostPanelUserControl.postStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()


                'this updates the datagridview
                User.displayTableP("posts", adminPostPanelUserControl.DataGridView2, sqlDataTableP)

                'this changes the content of confirmMsg
                adminPostPanelUserControl.confirmMsgP.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                adminPostPanelUserControl.confirmMsgP.Visible = True
                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()


                'this makes the add panel to disappear
                adminPostPanelUserControl.postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                addPostPanelUserControl.addPostPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try

        End If

    End Sub

    Private Sub addPostCancelBtn_Click(sender As Object, e As EventArgs) Handles addPostCancelBtn.Click
        addPostPanelUserControl.addPostPanel.Visible = False

        adminPostPanelUserControl.postChangeStatePanel.Visible = False
    End Sub
End Class
