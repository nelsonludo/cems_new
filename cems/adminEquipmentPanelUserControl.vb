Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users
Imports cems.admin
Imports cems.adminPostPanelUserControl
Imports cems.addEquipmentPanelUserControl
Imports cems.addPostPanelUserControl
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


    Dim User As New users
    Dim admin As New admin

    Dim addPostPanelUserControl As New addPostPanelUserControl
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
    Dim adminPostPanelUserControl As New adminPostPanelUserControl




    Dim bitmap As Bitmap
    Private Sub printBtnE_Click(sender As Object, e As EventArgs) Handles printBtnE.Click

        Try
            Dim height As Integer = DataGridView1.Height
            DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
            bitmap = New Bitmap(DataGridView1.Width, DataGridView1.Height)
            DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
            adminhomePage.PrintPreviewDialog1.Document = adminhomePage.PrintDocument1
            adminhomePage.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            adminhomePage.PrintPreviewDialog1.ShowDialog()

            DataGridView1.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    'Equipment add section
    Private Sub addEquipmentBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentBtn.Click
        AddEquipmentPanelUserControl1.Visible = True
        adminhomePage.fillcombo(AddEquipmentPanelUserControl1.postIdInput, "posts", "post_id")
        adminhomePage.fillHalls(AddEquipmentPanelUserControl1.hallInput)
    End Sub

    'EQUIPMENT SECTION
    Private Sub DataGridView1_CellClick() Handles DataGridView1.CellClick

        Try
            equipmentState.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString

            statePanel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub stateChangeBtn_Click(sender As Object, e As EventArgs) Handles stateChangeBtn.Click
        Dim equipment_id As Integer = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

        adminhomePage.connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "Update cems.cems_equipments Set equipment_state ='" & equipmentState.Text & "' where equipment_id = '" & equipment_id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()



        statePanel.Visible = False

        User.displayTableE("equipments", DataGridView1, sqlDataTableE)
    End Sub

    Private Sub equipmentdeleteBtn_Click(sender As Object, e As EventArgs) Handles equipmentDeleteBtn.Click  'delete
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this equipment ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then

            admin.deleteRecord(DataGridView1, "equipments", "equipment")
        End If

        statePanel.Visible = False

        User.displayTableE("equipments", DataGridView1, sqlDataTableE)

    End Sub

    Private Sub exportBtnE_Click(sender As Object, e As EventArgs) Handles exportBtnE.Click  'equipment 

        Try

            User.export(DataGridView1, "equipments")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        'this will make the message appear for three seconds
        confirmMsgE.Visible = True
        adminhomePage.Timer2.Interval = 3000
        adminhomePage.Timer2.Start()
    End Sub

    'search by halls in equipment
    Private Sub hallSearchBoxE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hallSearchBoxE.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        adminhomePage.connect_db()

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

        User.searchHall("equipments", DataGridView1, "hall_id", hall_id, searchErrorE, sqlDataTableCBHE)
    End Sub

    'equipment search by state

    Private Sub userSearchBoxE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userSearchBoxE.SelectedIndexChanged
        Dim hall_id As Integer
        'SQL Connection'
        adminhomePage.connect_db()

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

        User.searchHallAndState("equipments", DataGridView1, "hall_id", hall_id, "equipment_state", userSearchBoxE.Text, searchErrorE, sqlDataTableCBHE)


    End Sub

    'equipment searches
    Private Sub equipmentSearchBox_textChanged(sender As Object, e As EventArgs) Handles equipmentSearchBox.TextChanged

        User.search("equipments", DataGridView1, "post_id", equipmentSearchBox.Text, searchErrorE, sqlDataTableE)

    End Sub


    'this is the danger zone //Public Custom Event VisibleChanged As EventHandler

    Private Sub AddVisibleChangedEventHandler()
        AddHandler AddEquipmentPanelUserControl1.addEquipmentPanel.VisibleChanged, AddressOf Label_VisibleChanged
        AddHandler AddEquipmentPanelUserControl1.addEquipmentErrorMsg.VisibleChanged, AddressOf Label1_VisibleChanged

    End Sub

    Private Sub Label_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Visible change event raised!!!")
        statePanel.Visible = False
    End Sub

    Private Sub Label1_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Visible change event raised!!!")
        'this updates the datagridview
        User.displayTableE("equipments", DataGridView1, sqlDataTableE)

        confirmMsgE.Visible = True

        'this changes the content of confirmMsg
        confirmMsgE.Text = "Item successfully added ✔"


        statePanel.Visible = False  'play it safe and make both panels visible false 


    End Sub

End Class
