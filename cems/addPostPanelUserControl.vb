Imports MySql.Data.MySqlClient


Public Class addPostPanelUserControl
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTableP As New DataTable
    Dim sqlQuery As String

    Dim User As New users

    Dim adminPostPanelUserControl As New adminPostPanelUserControl


    Private Sub addPostValidationBtn_Click(sender As Object, e As EventArgs) Handles addPostValidationBtn.Click
        adminhomePage.connect_db()

        If postStateInput.Text = "" Or postHallInput.Text = "" Then
            addPostErrorMsg.Text = "please fill all the fields !"
            addPostErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()

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
                User.displayTableP("posts", adminPostPanelUserControl.DataGridView2, sqlDataTableP)

                'this changes the content of confirmMsg
                adminPostPanelUserControl.confirmMsgP.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                adminPostPanelUserControl.confirmMsgP.Visible = True
                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()


                'this makes the add panel to disappear
                adminPostPanelUserControl.postChangeStatePanel.Visible = False  'play it safe and make both panels visible false 
                addPostPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try

        End If

    End Sub

    Private Sub addPostCancelBtn_Click(sender As Object, e As EventArgs) Handles addPostCancelBtn.Click
        addPostPanel.Visible = False

        adminPostPanelUserControl.postChangeStatePanel.Visible = False
    End Sub
End Class
