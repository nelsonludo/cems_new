Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports cems.adminPostPanelUserControl
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


Public Class adminHallsPanelUserControl

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
    Private Sub printBtnh_Click(sender As Object, e As EventArgs) Handles PrintBtnH.Click

        Try
            Dim height As Integer = DataGridView3.Height
            DataGridView3.Height = DataGridView3.RowCount * DataGridView3.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView3.Width, Me.DataGridView3.Height)
            DataGridView3.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView3.Width, Me.DataGridView3.Height))
            adminhomePage.PrintPreviewDialog1.Document = adminhomePage.PrintDocument1
            adminhomePage.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            adminhomePage.PrintPreviewDialog1.ShowDialog()

            DataGridView3.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'add 
    'HALL add Section
    Private Sub hallAddBtn_Click(sender As Object, e As EventArgs) Handles hallAddBtn.Click 'add 
        hallUpdatePanelUserControl.hallUpdatePanel.Visible = True 'add panel is on update panel so updatepanel has to be visible 
        hallAddPanelUserControl.hallAddpanel.Visible = True
    End Sub

    Private Sub DataGridView3_CellClick() Handles DataGridView3.CellClick 'the cellclicked event

        Try
            hallUpdatePanelUserControl.adminUpdateHallNameInput.Text = DataGridView3.SelectedRows(0).Cells(1).Value.ToString
            HallUpdateBtn.Visible = True
            HallDeleteBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'HALL SECTION 
    Private Sub HallUpdateBtn_Click(sender As Object, e As EventArgs) Handles HallUpdateBtn.Click 'update
        hallUpdatePanelUserControl.hallUpdatePanel.Visible = True
    End Sub

    Private Sub HalldeleteBtn_Click(sender As Object, e As EventArgs) Handles HallDeleteBtn.Click 'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this hall ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(DataGridView3, "halls", "hall")

        End If

        HallUpdateBtn.Visible = False
        HallDeleteBtn.Visible = False

        User.displayTable("halls", DataGridView3, sqlDataTableH)

    End Sub

    Private Sub exportBtnH_Click(sender As Object, e As EventArgs) Handles exportBtnH.Click  'hall

        Try

            User.export(DataGridView3, "halls")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        'this will make the message appear for three seconds
        confirmMsgH.Visible = True
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()
    End Sub

    'halls search

    Private Sub hallSearchboxH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxH.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        adminhomePage.connect_db()

        Try
            sqlConn.Open()

            sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & hallSearchBoxH.Text & "'"


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


        admin.generalSearchH("halls", DataGridView3, "hall_id", hall_id, searchErrorH, sqlDataTableCBH)
    End Sub

End Class
