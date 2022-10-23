Imports MySql.Data.MySqlClient

Public Class adminUserPanelUserControl
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

    Private Sub printBtnu_Click(sender As Object, e As EventArgs) Handles PrintBtnU.Click

        Try
            Dim height As Integer = adminUserPanelUserControl.DataGridView4.Height
            adminUserPanelUserControl.DataGridView4.Height = adminUserPanelUserControl.DataGridView4.RowCount * adminUserPanelUserControl.DataGridView4.RowTemplate.Height
            bitmap = New Bitmap(adminUserPanelUserControl.DataGridView4.Width, adminUserPanelUserControl.DataGridView4.Height)
            adminUserPanelUserControl.DataGridView4.DrawToBitmap(bitmap, New Rectangle(0, 0, adminUserPanelUserControl.DataGridView4.Width, adminUserPanelUserControl.DataGridView4.Height))
            adminhomePage.PrintPreviewDialog1.Document = adminhomePage.PrintDocument1
            adminhomePage.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            adminhomePage.PrintPreviewDialog1.ShowDialog()

            adminUserPanelUserControl.DataGridView4.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'user add Section
    Private Sub userAddBtn_Click(sender As Object, e As EventArgs) Handles userAddBtn.Click 'add 
        userUpdatePanelUserControl.userUpdatePanel.Visible = True 'add panel is on update panel so updatepanel has to be visible 
        userAddPanelUserControl.userAddPanel.Visible = True

        userAddPanelUserControl.userUserAddTitleInput.Items.Clear()


        Try
            sqlConn.Open()

            sqlQuery = "select * from  cems.cems_titles"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                userAddPanelUserControl.userUserAddTitleInput.Items.Add(sqlReader.Item("title_name"))

            End While
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()

        End Try
    End Sub

    Private Sub DataGridView4_CellClick() Handles DataGridView4.CellClick 'the cellclicked event

        Try
            userUpdatePanelUserControl.userUserNameInput.Text = DataGridView4.SelectedRows(0).Cells(1).Value.ToString
            userUpdatePanelUserControl.userUserEmailInput.Text = DataGridView4.SelectedRows(0).Cells(2).Value.ToString
            userUpdatePanelUserControl.userUserPhoneInput.Text = DataGridView4.SelectedRows(0).Cells(3).Value.ToString
            userUpdatePanelUserControl.userUserTitleInput.Text = DataGridView4.SelectedRows(0).Cells(4).Value.ToString

            userUpdateBtn.Visible = True
            userDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub userUpdateBtn_Click(sender As Object, e As EventArgs) Handles userUpdateBtn.Click 'update
        userUpdatePanelUserControl.userUpdatePanel.Visible = True

        userUpdatePanelUserControl.userUserTitleInput.Items.Clear()

        Try
            sqlConn.Open()

            sqlQuery = "select * from  cems.cems_titles"


            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                userUpdatePanelUserControl.userUserTitleInput.Items.Add(sqlReader.Item("title_name"))

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
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()
    End Sub


    'user searches
    Private Sub userSearchBox_textChanged(sender As Object, e As EventArgs) Handles userSearchBox.TextChanged

        User.searchU("users", DataGridView4, "user_name", userSearchBox.Text, searchErrorU, sqlDataTableU)

    End Sub

End Class
