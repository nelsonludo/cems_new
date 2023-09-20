Imports MySql.Data.MySqlClient
Public Class admin
    Inherits users

    Public Overloads Sub activeCount(countLabel As Label, table As String)

        Dim count As Integer

        connect_db()


        Try
            sqlConn.Open()
            'count the number of good
            sqlQuery = "select count(*) from cems_" & table & " " 'Form1.emailtxt.Text'
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                count = sqlReader.Item("count(*)")

            End If

            sqlConn.Close()

            If count < 10 Then
                countLabel.Text = "000" & count & ""

            ElseIf count < 100 Then

                countLabel.Text = "00" & count & ""
            ElseIf count < 1000 Then

                countLabel.Text = "0" & count & ""
            Else
                countLabel.Text = count
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub


    Public Sub generalSearchH(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select * from cems_halls where hall_id = '" & searchValue & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            sqlReader = sqlCmd.ExecuteReader
            datatable.Load(sqlReader)

            grid.DataSource = datatable

            If datatable.Rows.Count < 1 And searchValue <> "" Then
                grid.Visible = False 'datagridview disappear
                searchErrorLabel.Visible = True 'error message appear
            Else
                grid.Visible = True
                searchErrorLabel.Visible = False 'error message disappear

            End If


            sqlReader.Close()
            sqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Public Sub deleteRecord(grid As DataGridView, table As String, column As String)
        Dim id As String = grid.SelectedRows(0).Cells(0).Value.ToString

        connect_db()

        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "delete from " & database & ".cems_" & table & "  where " & column & "_id = '" & id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


    End Sub

    Public Function compareSelectedRecordWithLoggedinUser(grid As DataGridView, loggedInUserEmail As String)
        Dim selectedEmail As String = grid.SelectedRows(0).Cells(2).Value.ToString


        If selectedEmail = loggedInUserEmail Then
            'if it is true the admin is trying to delete himself
            Return True
        Else
            'if not he is trying to delete another user and that's okay
            Return False
        End If

    End Function

    Public Function checkDefaultRecord(grid As DataGridView)
        Dim selectedId As String = grid.SelectedRows(0).Cells(0).Value.ToString


        If selectedId = "1" Then
            'if it is true the admin is trying to delete himself
            Return True
        Else
            'if not he is trying to delete another user and that's okay
            Return False
        End If

    End Function

    Public Sub deletePost(grid As DataGridView, table As String, column As String)
        Dim id As String = grid.SelectedRows(0).Cells(0).Value.ToString

        connect_db()

        Try

            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd

                .CommandText = "delete from " & database & ".cems_" & table & "  where " & column & "_id = '" & id & "'"

                .CommandType = CommandType.Text

            End With
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

        Try

            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd

                .CommandText = "delete from " & database & ".cems_equipments  where post_id = '" & id & "'"

                .CommandType = CommandType.Text

            End With
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub







End Class
