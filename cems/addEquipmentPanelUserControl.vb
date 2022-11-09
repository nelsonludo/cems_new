Imports MySql.Data.MySqlClient
Imports cems.adminEquipmentPanelUserControl

Public Class addEquipmentPanelUserControl

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTableE As New DataTable
    Dim sqlQuery As String
    'Dim User As New users

    'Dim adminEquipmentPanelUserControl2 As New adminEquipmentPanelUserControl

    Private Sub addEquipmentCancelBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentCancelBtn.Click
        addEquipmentPanel.Visible = False

        'adminEquipmentPanelUserControl2.statePanel.Visible = False
    End Sub

    Private Sub addEquipmentValidationBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentValidationBtn.Click
        adminhomePage.connect_db()

        If equipmentTypeInput.Text = "" Or equipmentStateInput.Text = "" Or hallInput.Text = "" Then
            addEquipmentErrorMsg.Text = "please fill all the fields !"
            addEquipmentErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()

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
                'User.displayTableE("equipments", adminEquipmentPanelUserControl2.DataGridView1, sqlDataTableE)

                'this changes the content of confirmMsg
                'adminEquipmentPanelUserControl2.confirmMsgE.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                'adminEquipmentPanelUserControl2.confirmMsgE.Visible = True
                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()


                'this makes the add panel to disappear
                'adminEquipmentPanelUserControl2.statePanel.Visible = False  'play it safe and make both panels visible false 
                addEquipmentPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try
        End If

    End Sub
End Class
