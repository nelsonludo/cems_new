Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports cems.addEquipmentPanelUserControl
Imports cems.addPostPanelUserControl
Imports cems.adminEquipmentPanelUserControl
Imports cems.adminHallsPanelUserControl
Imports cems.adminHomePagePanelUserControl
Imports cems.adminProfilePanelUserControl
Imports cems.adminRolePanelUserControl
Imports cems.adminUserPanelUserControl
Imports cems.hallAddPanelUserControl
Imports cems.hallUpdatePanelUserControl
Imports cems.roleAddPanelUserControl
Imports cems.roleUpdatePanelUserControl
Imports cems.userAddPanelUserControl
Imports cems.userUpdatePanelUserControl




Public Class adminPostPanelUserControl
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

    Dim addEquipmentPanelUserControl As New addEquipmentPanelUserControl
    Dim addPostPanelUserControl As New addPostPanelUserControl
    Dim adminEquipmentPanelUserControl As New adminEquipmentPanelUserControl
    Dim adminHallsPanelUserControl As New adminHallsPanelUserControl
    Dim adminHomePagePanelUserControl As New adminHomePagePanelUserControl
    Dim adminProfilePanelUserControl As New adminProfilePanelUserControl
    Dim adminRolePanelUserControl As New adminRolePanelUserControl
    Dim adminUserPanelUserControl As New adminUserPanelUserControl
    Dim hallAddPanelUserControl As New hallAddPanelUserControl
    Dim hallUpdatePanelUserControl As New hallUpdatePanelUserControl
    Dim roleAddPanelUserControl As New roleAddPanelUserControl
    Dim roleUpdatePanelUserControl As New roleUpdatePanelUserControl
    Dim userAddPanelUserControl As New userAddPanelUserControl
    Dim userUpdatePanelUserControl As New userUpdatePanelUserControl


    Dim bitmap As Bitmap



    Private Sub printBtnP_Click(sender As Object, e As EventArgs) Handles printBtnP.Click

        Try
            Dim height As Integer = DataGridView2.Height
            DataGridView2.Height = DataGridView2.RowCount * DataGridView2.RowTemplate.Height
            bitmap = New Bitmap(DataGridView2.Width, DataGridView2.Height)
            DataGridView2.DrawToBitmap(bitmap, New Rectangle(0, 0, DataGridView2.Width, DataGridView2.Height))
            adminhomePage.PrintPreviewDialog1.Document = adminhomePage.PrintDocument1
            adminhomePage.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            adminhomePage.PrintPreviewDialog1.ShowDialog()

            DataGridView2.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'POST add section
    Private Sub addPosttBtn_Click(sender As Object, e As EventArgs) Handles addPostBtn.Click
        addPostPanelUserControl.addPostPanel.Visible = True
        adminhomePage.fillHalls(addPostPanelUserControl.postHallInput)
    End Sub


    'POST SECTION
    Private Sub DataGridView2_CellClick() Handles DataGridView2.CellClick

        Try
            postChangeStateInput.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString

            postChangeStatePanel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub postChangeBtn_Click(sender As Object, e As EventArgs) Handles postChangeBtn.Click
        Dim post_id As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
        adminhomePage.connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_posts Set post_state ='" & postChangeStateInput.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_equipments Set equipment_state ='" & postChangeStateInput.Text & "' where post_id = '" & post_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


        postChangeStatePanel.Visible = False

        User.displayTableP("posts", DataGridView2, sqlDataTableP)
    End Sub

    Private Sub postdeleteBtn_Click(sender As Object, e As EventArgs) Handles postDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this post ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deletePost(DataGridView2, "posts", "post")
        End If

        postChangeStatePanel.Visible = True

        User.displayTableP("posts", DataGridView2, sqlDataTableP)

    End Sub

    'export buttons 
    Private Sub exportBtnP_Click(sender As Object, e As EventArgs) Handles exportBtnP.Click  'post 

        Try

            User.export(DataGridView2, "posts")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        confirmMsgP.Visible = True
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()

    End Sub

    'post searches

    Private Sub postSearchBox_textChanged(sender As Object, e As EventArgs) Handles postSearchBox.TextChanged

        User.searchP("posts", DataGridView2, "post_id", postSearchBox.Text, searchErrorP, sqlDataTableP)

    End Sub

    'post search by state
    Private Sub stateSearchBoxP_textChanged(sender As Object, e As EventArgs) Handles stateSearchBoxP.TextChanged

        Dim hall_id As Integer
        'SQL Connection'
        adminhomePage.connect_db()

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


    'post hall search
    Private Sub hallSearchBoxP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxP.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        adminhomePage.connect_db()

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

End Class
