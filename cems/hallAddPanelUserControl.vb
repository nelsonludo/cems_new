Imports MySql.Data.MySqlClient


Public Class hallAddPanelUserControl
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlDataTableH As New DataTable
    Dim sqlQuery As String

    Public server As String = Form1.server
    Public username As String = Form1.username
    Public password As String = Form1.password
    Public database As String = Form1.database

    Dim User As New users

    Dim adminHallsPanelUserControl As adminHallsPanelUserControl
    Dim hallUpdatePanelUserControl As hallUpdatePanelUserControl

    Private Sub HallAddCancelBtn_Click(sender As Object, e As EventArgs) Handles HallAddCancelBtn.Click 'cancel add
        hallUpdatePanelUserControl.hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
        hallAddpanel.Visible = False
    End Sub


    Private Sub HallAddValidateBtn_Click(sender As Object, e As EventArgs) Handles HallAddValidateBtn.Click 'validate add

        adminhomePage.connect_db()

        If adminAddHallNameInput.Text = "" Then
            addHallErrorMsg.Text = "please fill the field !"
            addHallErrorMsg.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()

        Else
            Try
                sqlConn.Open()
                sqlQuery = "insert into cems.cems_halls(hall_name) values ('" & adminAddHallNameInput.Text & "')"
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
            User.displayTable("halls", adminHallsPanelUserControl.DataGridView3, sqlDataTableH)

            'this changes the content of confirmMsg
            adminHallsPanelUserControl.confirmMsgH.Text = "Item successfully added ✔"

            'this makes the confirm message appear for 3secs
            adminHallsPanelUserControl.confirmMsgH.Visible = True
            adminhomePage.Timer2.Interval = 3000
            adminhomePage.Timer2.Start()


            'this makes the add panel to disappear
            hallUpdatePanelUserControl.hallUpdatePanel.Visible = False  'play it safe and make both panels visible false 
            hallAddpanel.Visible = False
        End If
    End Sub

End Class
