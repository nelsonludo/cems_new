Imports MySql.Data.MySqlClient
Public Class admin
    Inherits users

    Public Overloads Sub login(user_password, user_email, errorMsg, timer)
        connect_db()
        Dim email As String = user_email
        Dim password As String = user_password
        Try
            sqlConn.Open()
            sqlQuery = "select * from cems.cems_admin where admin_email = '" & email & "' and admin_password = '" & password & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                adminhomePage.Show()
                Form1.Visible = False

            Else
                errorMsg.Text = "email or password invalid"
                timer.Interval = 3000
                timer.Start()
            End If
            sqlConn.Close()
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

            .CommandText = "delete from cems.cems_" & table & "  where " & column & "_id = '" & id & "'"

            .CommandType = CommandType.Text

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()


    End Sub

    Public Sub deletePost(grid As DataGridView, table As String, column As String)
        Dim id As String = grid.SelectedRows(0).Cells(0).Value.ToString

        connect_db()

        Try

            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd

                .CommandText = "delete from cems.cems_" & table & "  where " & column & "_id = '" & id & "'"

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

                .CommandText = "delete from cems.cems_equipments  where post_id = '" & id & "'"

                .CommandType = CommandType.Text

            End With
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub


End Class
