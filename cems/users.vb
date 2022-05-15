
Imports MySql.Data.MySqlClient
Imports cems.adminhomePage
Imports cems.admin
Imports cems.UserHomePage
Imports System.IO

Public Class users
    Protected sqlConn As New MySqlConnection
    Protected sqlCmd As New MySqlCommand
    Protected sqlReader As MySqlDataReader
    Protected sqlDataTable As New DataTable
    Protected sqlDataAdapter As New MySqlDataAdapter
    Protected sqlQuery As String

    Protected user_name As String
    Protected user_phone_number As String
    Protected user_password As String
    Protected user_email As String
    Protected errorMsg As Control
    Protected timer As Timer

    Public Sub connect_db()
        sqlConn.ConnectionString = "server =" + adminhomePage.server + ";" + "user id =" + adminhomePage.username + ";" _
           + "password=" + adminhomePage.password + ";" + "database =" + adminhomePage.database
    End Sub

    Public Function login(user_password, user_email, errorMsg, timer)
        connect_db()
        Dim email As String = user_email
        Dim password As String = user_password
        Try
            sqlConn.Open()
            'check user info
            sqlQuery = "select * from cems.cems_users where user_email = '" & email & "' and user_password = '" & password & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                UserHomePage.Show()
                Form1.Visible = False

                Return True

            End If
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
        Return 0
    End Function

    'this is to display the user's name 
    Public Sub showUserName(email As Control, table As String, column As String, name As Control)

        connect_db()
        Try
            sqlConn.Open()
            'username appear
            sqlQuery = "select * from cems.cems_" & table & " where " & column & "_email = '" & email.Text & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                email.Text = sqlReader.Item("" & column & "_name")

            End If

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Public Sub display(panel As Control, tableLabel As Control, tableName As String) 'changes tabs on the window
        panel.BringToFront()

        tableLabel.Text = tableName
    End Sub

    Public Sub displayEquipmentTable(table As String, grid As DataGridView) 'changes tabs on the window
        connect_db()
        Try

            sqlConn.Open()
            sqlDataTable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select * from cems.cems_equipments where equipment_type = '" & table & "' "

            sqlReader = sqlCmd.ExecuteReader
            sqlDataTable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = sqlDataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub


    Public Sub displayTable(table As String, grid As DataGridView, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select * from cems.cems_" & table & " "

            sqlReader = sqlCmd.ExecuteReader
            datatable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = datatable



        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Public Sub displayTableE(table As String, grid As DataGridView, datatable As DataTable) 'displays the equipment table ...the only difference with displayTable() is the querry 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select cems_" & table & " .equipment_id, cems_" & table & " .equipment_type, cems_" & table & " .equipment_state,cems_" & table & " .post_id,cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_equipments.hall_id = cems_halls.hall_id"
            'i had to add a new method for displaying the equipment table . i use the join in this qeurry to display the hall name instead of the hall id '

            sqlReader = sqlCmd.ExecuteReader
            datatable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = datatable



        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Public Sub displayTableP(table As String, grid As DataGridView, datatable As DataTable) 'displays the post table ...the only difference with displayTable() is the querry 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_posts.hall_id = cems_halls.hall_id"
            'i had to add a new method for displaying the post table . i use the join in this qeurry to display the hall name instead of the hall id .this is only for the user view'

            sqlReader = sqlCmd.ExecuteReader
            datatable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = datatable



        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Public Sub displayTableU(table As String, grid As DataGridView, datatable As DataTable) 'displays the equipment table ...the only difference with displayTable() is the querry 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select cems_" & table & ".user_id, cems_" & table & ".user_name, cems_" & table & ".user_email,cems_" & table & ".user_phone_number, cems_titles.title_name from cems_" & table & "  inner join cems_titles on cems_" & table & ".title_id = cems_titles.title_id"
            'i had to add a new method for displaying the equipment table . i use the join in this qeurry to display the hall name instead of the hall id '

            sqlReader = sqlCmd.ExecuteReader
            datatable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = datatable



        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub


    'searches
    'equipment search function
    Public Sub search(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .equipment_id, cems_" & table & " .equipment_type, cems_" & table & " .equipment_state,cems_" & table & " .post_id,cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_equipments.hall_id = cems_halls.hall_id where " & searchColumn & " like '" & searchValue & "%'"
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

    'equipment hall search function
    Public Sub searchHall(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .equipment_id, cems_" & table & " .equipment_type, cems_" & table & " .equipment_state,cems_" & table & " .post_id,cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_equipments.hall_id = cems_halls.hall_id where cems_halls." & searchColumn & " like '" & searchValue & "'"
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

    'post hall search function
    Public Sub searchHallP(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_" & table & ".hall_id = cems_halls.hall_id where cems_halls." & searchColumn & " like '" & searchValue & "'"
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

    'post search function
    Public Sub searchP(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_posts.post_id, cems_posts.post_state, cems_halls.hall_name from cems_posts inner join cems_halls on cems_posts.hall_id = cems_halls.hall_id where cems_posts.post_id like '" & searchValue & "%'"
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

    'post search function
    Public Sub searchU(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & ".user_id, cems_" & table & ".user_name, cems_" & table & ".user_email,cems_" & table & ".user_phone_number, cems_titles.title_name from cems_" & table & "  inner join cems_titles on cems_" & table & ".title_id = cems_titles.title_id where cems_users.user_name Like '" & searchValue & "%'"
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


    Public Sub updateUser(table As String, column As String, name As String, phone As String, email As String, pwd As String, confirmPwd As String, previousEmail As String, errorMsg As Control, panel As Control)

        connect_db()

        Try


            If name = "" And email = "" And phone = "" And pwd = "" Then
                errorMsg.Visible = True
                errorMsg.Text = "Please fill the fields"
            Else
                If pwd <> confirmPwd Then
                    errorMsg.Visible = True
                    errorMsg.Text = "The password does not correspond"

                ElseIf name = "" And phone = "" And pwd = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_email = '" & email & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf name = "" And email = "" And pwd = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_phone_number = '" & phone & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf email = "" And phone = "" And pwd = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf email = "" And phone = "" And name = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False


                ElseIf name = "" And phone = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_email = '" & email & "', " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf name = "" And email = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_phone_number = '" & phone & "', " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf email = "" And phone = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf name = "" And pwd = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_email = '" & email & "', " & column & "_phone_number = '" & phone & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf pwd = "" And email = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_phone_number = '" & phone & "', " & column & "_name = '" & name & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf pwd = "" And phone = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_phone_number = '" & phone & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False


                ElseIf name = "" Then

                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_phone_number = '" & phone & "', " & column & "_email = '" & email & "', " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf phone = "" Then



                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_email = '" & email & "', " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf email = "" Then


                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_phone_number = '" & phone & "', " & column & "_password = '" & pwd & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                ElseIf pwd = "" Then


                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_phone_number = '" & phone & "', " & column & "_email = '" & email & "'  where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                Else
                    sqlConn.Open()

                    sqlCmd.Connection = sqlConn

                    With sqlCmd

                        .CommandText = "Update cems.cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_phone_number = '" & phone & "', " & column & "_password = '" & pwd & "', " & column & "_email = '" & email & "'   where " & column & "_email = '" & previousEmail & "'"

                        .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False

                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try


    End Sub

    Public Sub updateUserInformation(table As String, column As String, searchValue As Control, name As Control, email As Control, phone As Control, title As Control)

        connect_db()

        Try
            sqlConn.Open()
            'username appear
            sqlQuery = "select cems_" & table & "." & column & "_id, cems_" & table & "." & column & "_name, cems_" & table & "." & column & "_phone_number, cems_" & table & "." & column & "_email, cems_titles.title_name from cems_" & table & "  inner join cems_titles on cems_" & table & ".title_id = cems_titles.title_id where " & column & "_email = '" & searchValue.Text & "'" 'Form1.emailtxt.Text'
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                name.Text = sqlReader.Item("" & column & "_name")
                email.Text = sqlReader.Item("" & column & "_email")
                phone.Text = sqlReader.Item("" & column & "_phone_number")
                title.Text = sqlReader.Item("title_name")


            End If

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Public Sub export(grid As DataGridView, columnName As String)
        Dim DGVOriginalHeight As Integer = grid.Height
        grid.Height = (grid.RowCount * grid.RowTemplate.Height) + grid.ColumnHeadersHeight

        Using bitmap As Bitmap = New Bitmap(grid.Width, grid.Height)
            grid.DrawToBitmap(bitmap, New Rectangle(Point.Empty, grid.Size))
            Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            bitmap.Save(Path.Combine(DesktopFolder, "" & columnName & ".png"), Imaging.ImageFormat.Png)
        End Using

        grid.Height = DGVOriginalHeight
    End Sub

    Public Sub activeCount(countLabel As Label, table As String, column As String, state As String)

        Dim count As Integer

        connect_db()


        Try
            sqlConn.Open()
            'count the number of good
            sqlQuery = "select count(*) from cems_" & table & " where " & column & "_state = '" & state & "'" 'Form1.emailtxt.Text'
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




End Class

'                    .CommandText = "Update cems.cems_'" & table & "' Set user_name = '" & name & "', user_phone_number = '" & phone & "', user_email = '" & email & "'  where user_email = '" & Form1.emailtxt.Text & "'"
