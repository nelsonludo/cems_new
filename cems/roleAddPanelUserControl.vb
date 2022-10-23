
Imports MySql.Data.MySqlClient

Imports cems.users
Imports cems.adminRolePanelUserControl
Imports cems.roleUpdatePanelUserControl




Public Class roleAddPanelUserControl
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTableR As New DataTable
    Dim sqlQuery As String

    Public server As String = Form1.server
    Public username As String = Form1.username
    Public password As String = Form1.password
    Public database As String = Form1.database

    Dim User As New users

    Dim adminRolePanelUserControl As New adminRolePanelUserControl
    Dim roleUpdatePanelUserControl As New roleUpdatePanelUserControl



    Private Sub roleAddValidationBtn_Click(sender As Object, e As EventArgs) Handles roleAddValidationBtn.Click 'validate add

        adminhomePage.connect_db()

        If titleAddNameInput.Text = "" Then
            addRoleErrorMsg.Text = "please fill the field"
            addRoleErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()
        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_titles(title_name) values ('" & titleAddNameInput.Text & "')"
                'Read through the response'
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader
                sqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                sqlConn.Dispose()
            End Try

            'this updates the datagridview
            User.displayTable("titles", adminRolePanelUserControl.DataGridView5, sqlDataTableR)

            'this changes the content of confirmMsg
            adminRolePanelUserControl.confirmMsgR.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            adminRolePanelUserControl.confirmMsgR.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()


            'this makes the add panel to disappear
            roleUpdatePanelUserControl.roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            roleAddPanel.Visible = False

        End If
    End Sub

    Private Sub roleAddCancelBtn_Click(sender As Object, e As EventArgs) Handles roleAddCancelBtn.Click 'cancel add
        roleUpdatePanelUserControl.roleUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        roleAddPanel.Visible = False
    End Sub


End Class
