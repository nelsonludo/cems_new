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





Public Class adminEquipmentPanelUserControl
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
    Private Sub printBtnE_Click(sender As Object, e As EventArgs) Handles printBtnE.Click

        Try
            Dim height As Integer = adminEquipmentPanelUserControl.DataGridView1.Height
            adminEquipmentPanelUserControl.DataGridView1.Height = adminEquipmentPanelUserControl.DataGridView1.RowCount * adminEquipmentPanelUserControl.DataGridView1.RowTemplate.Height
            bitmap = New Bitmap(adminEquipmentPanelUserControl.DataGridView1.Width, adminEquipmentPanelUserControl.DataGridView1.Height)
            adminEquipmentPanelUserControl.DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, adminEquipmentPanelUserControl.DataGridView1.Width, adminEquipmentPanelUserControl.DataGridView1.Height))
            adminhomePage.PrintPreviewDialog1.Document = adminhomePage.PrintDocument1
            adminhomePage.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            adminhomePage.PrintPreviewDialog1.ShowDialog()

            adminEquipmentPanelUserControl.DataGridView1.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'Equipment add section
    Private Sub addEquipmentBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentBtn.Click
        addEquipmentPanelUserControl.addEquipmentPanel.Visible = True
        adminhomePage.fillcombo(addEquipmentPanelUserControl.postIdInput, "posts", "post_id")
        adminhomePage.fillHalls(addEquipmentPanelUserControl.hallInput)
    End Sub


End Class
