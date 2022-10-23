Imports MySql.Data.MySqlClient

Public Class adminHallsPanelUserControladminEquipmentPanelUserControl
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

    Private Sub printBtnh_Click(sender As Object, e As EventArgs) Handles PrintBtnh.Click

        Try
            Dim height As Integer = adminHallsPanelUserControl.DataGridView3.Height
            adminHallsPanelUserControl.DataGridView3.Height = adminHallsPanelUserControl.DataGridView3.RowCount * adminHallsPanelUserControl.DataGridView3.RowTemplate.Height
            bitmap = New Bitmap(adminHallsPanelUserControl.DataGridView3.Width, adminHallsPanelUserControl.DataGridView3.Height)
            adminHallsPanelUserControl.DataGridView3.DrawToBitmap(bitmap, New Rectangle(0, 0, adminHallsPanelUserControl.DataGridView3.Width, adminHallsPanelUserControl.DataGridView3.Height))
            adminhomePage.PrintPreviewDialog1.Document = adminhomePage.PrintDocument1
            adminhomePage.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            adminhomePage.PrintPreviewDialog1.ShowDialog()

            adminHallsPanelUserControl.DataGridView3.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'add 
    'HALL add Section
    Private Sub hallAddBtn_Click(sender As Object, e As EventArgs) Handles halladdbtn.click 'add 
        hallUpdatePanelUserControl.hallUpdatePanel.Visible = True 'add panel is on update panel so updatepanel has to be visible 
        hallAddPanelUserControl.hallAddpanel.Visible = True
    End Sub

End Class
