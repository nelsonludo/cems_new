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






Public Class addEquipmentPanelUserControl
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

    Private Sub addEquipmentCancelBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentCancelBtn.Click
        addEquipmentPanelUserControl.addEquipmentPanel.Visible = False

        adminEquipmentPanelUserControl.statePanel.Visible = False
    End Sub

    Private Sub addEquipmentValidationBtn_Click(sender As Object, e As EventArgs) Handles addEquipmentValidationBtn.Click
        adminhomePage.connect_db()

        If addEquipmentPanelUserControl.equipmentTypeInput.Text = "" Or addEquipmentPanelUserControl.equipmentStateInput.Text = "" Or addEquipmentPanelUserControl.hallInput.Text = "" Then
            addEquipmentPanelUserControl.addEquipmentErrorMsg.Text = "please fill all the fields !"
            addEquipmentPanelUserControl.addEquipmentErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()

        Else
            Dim hall_id As Integer
            Dim post_id As String = addEquipmentPanelUserControl.postIdInput.Text
            'SQL Connection'

            Try
                sqlConn.Open()

                sqlQuery = "select hall_id from  cems.cems_halls where hall_name = '" & addEquipmentPanelUserControl.hallInput.Text & "'"


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
                sqlQuery = "insert into cems.cems_equipments(equipment_type, equipment_state, post_id, hall_id) values ('" & addEquipmentPanelUserControl.equipmentTypeInput.Text & "','" & addEquipmentPanelUserControl.equipmentStateInput.Text & "','" & post_id & "','" & hall_id & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

                'this updates the datagridview
                User.displayTableE("equipments", adminEquipmentPanelUserControl.DataGridView1, sqlDataTableE)

                'this changes the content of confirmMsg
                adminEquipmentPanelUserControl.confirmMsgE.Text = "Item successfully added ✔"

                'this makes the confirm message appear for 3secs
                adminEquipmentPanelUserControl.confirmMsgE.Visible = True
                adminhomePage.Timer2.Interval = 3000
                adminhomePage.Timer2.Start()


                'this makes the add panel to disappear
                adminEquipmentPanelUserControl.statePanel.Visible = False  'play it safe and make both panels visible false 
                addEquipmentPanelUserControl.addEquipmentPanel.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try
        End If

    End Sub
End Class
