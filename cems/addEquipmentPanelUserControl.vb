Imports MySql.Data.MySqlClient

Public Class addEquipmentPanelUserControl

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTableE As New DataTable
    Dim sqlQuery As String


    Private Sub addEquipmentCancelBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentCancelBtn.Click
        addEquipmentPanel.Visible = False


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


                'this makes the confirm message appear for 3secs

                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()


                'this makes the add panel to disappear

                addEquipmentPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try
        End If

    End Sub
End Class
