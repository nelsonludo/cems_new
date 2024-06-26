﻿
Imports MySql.Data.MySqlClient
Imports cems.homePage
Imports cems.admin
Imports cems.UserHomePage
Imports System.IO
Imports Microsoft.Office.Interop
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Xml.XPath
Imports System.Xml
Imports ClosedXML.Excel
Imports Org.BouncyCastle.Crypto.Generators
Imports BCrypt.Net.BCrypt
Imports System.Text.RegularExpressions
Public Class users
    Protected sqlConn As New MySqlConnection
    Protected sqlCmd As New MySqlCommand
    Protected sqlReader As MySqlDataReader
    Protected sqlDataTable As New DataTable
    Protected sqlDataAdapter As New MySqlDataAdapter
    Protected sqlQuery As String

    Public user_name As String
    Public user_email As String
    Public permanentEmail As String
    Protected errorMsg As Control
    Protected timer As Timer

    Public username As String = Nothing
    Public server As String = Nothing
    Public database As String = Nothing
    Public password As String = Nothing

    Public Sub connect_db()

        username = Form1.username
        server = Form1.server
        database = Form1.database
        password = Form1.password

        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password=" + password + ";" + "database =" + database
    End Sub

    'the login function
    Public Function login(user_password As String, user_email As String, errorMsg As Label, timer As Timer)
        connect_db()

        Try
            sqlConn.Open()
            'check user info
            sqlQuery = "select * from " & database & ".cems_users where user_email = '" & user_email & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader



            'now compare the row's password with the user input 


            If (sqlReader.Read()) Then
                'then store the password in that row into the hashedPassword variable
                Dim hashedPassword = sqlReader.GetString(4)

                If BCrypt.Net.BCrypt.Verify(user_password, hashedPassword) Then
                    ' Passwords match, login is successful
                    If sqlReader.GetInt32(5) = 2 Then

                        UserHomePage.Show()
                        UserHomePage.HomePagePanel.Visible = True

                    Else
                        homePage.Show()
                        homePage.adminHomePagePanel.Visible = True

                    End If
                    permanentEmail = user_email 'this is the email that is going to be used throughout the application 
                    Form1.Visible = False


                Else
                    errorMsg.Text = "email or password invalid"

                    errorMsg.Visible = True
                    timer.Interval = 3000
                    timer.Start()

                End If



            Else
                errorMsg.Text = "email or password invalid!"

                errorMsg.Visible = True
                timer.Interval = 3000
                timer.Start()

            End If
            sqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
        Return True
    End Function

    'this is to display the user's name 
    Public Sub showUserName(email As Control, name As Control)

        connect_db()
        Try
            sqlConn.Open()
            'username appear
            sqlQuery = "select * from " & database & ".cems_users where user_email = '" & email.Text & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            If (sqlReader.Read()) Then
                name.Text = sqlReader.Item("user_name")

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

    Public Sub displayEquipmentTable(table As String, type As String, grid As DataGridView) 'changes tabs on the window
        connect_db()
        Try

            sqlConn.Open()
            sqlDataTable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select cems_" & table & " .equipment_id, cems_" & table & " .equipment_type, cems_" & table & " .equipment_state,cems_" & table & " .post_id,cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_equipments.hall_id = cems_halls.hall_id where equipment_type = '" & type & "' "

            sqlReader = sqlCmd.ExecuteReader
            sqlDataTable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = sqlDataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql display equipment table", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub


    'this is the base function used to display tables 
    Public Sub displayTable(table As String, grid As DataGridView, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "select * from " & database & ".cems_" & table & " "

            sqlReader = sqlCmd.ExecuteReader
            datatable.Load(sqlReader)
            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = datatable



        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql general display table", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            MessageBox.Show(ex.Message, "MySql equipment display table", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            sqlCmd.CommandText = "select cems_" & table & ".post_id, cems_" & table & ".post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_posts.hall_id = cems_halls.hall_id"
            'i had to add a new method for displaying the post table . i use the join in this qeurry to display the hall name instead of the hall id .this is only for the user view'

            sqlReader = sqlCmd.ExecuteReader
            'datatable.Load(sqlReader)

            'i had to create a new datatable and load the content of the sqlreader in it so as to avoid the unique constraint on post_id field which form some odd reason was in the datatable

            Dim newDataTable As New DataTable()

            For i As Integer = 0 To sqlReader.FieldCount - 1
                newDataTable.Columns.Add(sqlReader.GetName(i), sqlReader.GetFieldType(i))
            Next
            While sqlReader.Read()

                Dim row As DataRow = newDataTable.NewRow()

                For i As Integer = 0 To sqlReader.FieldCount - 1
                    row(i) = sqlReader(i)
                Next

                newDataTable.Rows.Add(row)
            End While

            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = newDataTable


        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql post display table", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    'equipment hall and state search function
    Public Sub searchHallAndState(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchColumn2 As String, searchValue2 As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .equipment_id, cems_" & table & " .equipment_type, cems_" & table & " .equipment_state,cems_" & table & " .post_id,cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_equipments.hall_id = cems_halls.hall_id where cems_halls." & searchColumn & " like '" & searchValue & "' and  cems_" & table & "." & searchColumn2 & " like '" & searchValue2 & "'"
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

    'search state without hall 

    Public Sub searchHallAndStateNohall(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .equipment_id, cems_" & table & " .equipment_type, cems_" & table & " .equipment_state,cems_" & table & " .post_id,cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_equipments.hall_id = cems_halls.hall_id where cems_equipments." & searchColumn & " like '" & searchValue & "'"
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
    Public Sub searchHallP(table As String, grid As DataGridView, searchColumn2 As String, searchValue2 As String, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_" & table & ".hall_id = cems_halls.hall_id where cems_halls." & searchColumn & " like '" & searchValue & "' and cems_" & table & "." & searchColumn2 & " like '" & searchValue2 & "'"
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

    'search without the state 
    Public Sub searchHallPNoState(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 

        'MsgBox(searchValue)


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

    'post hall and state search function
    Public Sub searchHallAndStateP(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchColumn2 As String, searchValue2 As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_" & table & ".hall_id = cems_halls.hall_id where cems_" & table & "." & searchColumn2 & " like '" & searchValue2 & "' and cems_halls." & searchColumn & " like '" & searchValue & "'"
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
    Public Sub searchPostAndStateP(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchColumn2 As String, searchValue2 As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_" & table & ".hall_id = cems_halls.hall_id where cems_" & table & "." & searchColumn2 & " like '" & searchValue2 & "' and cems_" & table & "." & searchColumn & " like '" & searchValue & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            sqlReader = sqlCmd.ExecuteReader

            Dim newDataTable As New DataTable()

            For i As Integer = 0 To sqlReader.FieldCount - 1
                newDataTable.Columns.Add(sqlReader.GetName(i), sqlReader.GetFieldType(i))
            Next
            While sqlReader.Read()

                Dim row As DataRow = newDataTable.NewRow()

                For i As Integer = 0 To sqlReader.FieldCount - 1
                    row(i) = sqlReader(i)
                Next

                newDataTable.Rows.Add(row)
            End While

            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = newDataTable


            If newDataTable.Rows.Count < 1 And searchValue <> "" Then
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
    Public Sub searchHallAndPost(table As String, grid As DataGridView, searchColumn As String, searchValue As String, searchColumn2 As String, searchValue2 As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_" & table & ".hall_id = cems_halls.hall_id where cems_" & table & "." & searchColumn2 & " like '" & searchValue2 & "' and cems_halls." & searchColumn & " like '" & searchValue & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            sqlReader = sqlCmd.ExecuteReader

            Dim newDataTable As New DataTable()

            For i As Integer = 0 To sqlReader.FieldCount - 1
                newDataTable.Columns.Add(sqlReader.GetName(i), sqlReader.GetFieldType(i))
            Next
            While sqlReader.Read()

                Dim row As DataRow = newDataTable.NewRow()

                For i As Integer = 0 To sqlReader.FieldCount - 1
                    row(i) = sqlReader(i)
                Next

                newDataTable.Rows.Add(row)
            End While

            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = newDataTable

            MessageBox.Show(newDataTable.Rows.Count)

            If newDataTable.Rows.Count < 1 And searchValue2 <> "" Then
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

    'search for post state regardless of the hall 
    Public Sub searchHallAndState(table As String, grid As DataGridView, searchColumn2 As String, searchValue2 As String, searchErrorLabel As Control, datatable As DataTable) 'displays the correct table ... grid here is the datagridview and table is obviously the table 
        connect_db()
        Try

            sqlConn.Open()
            datatable.Rows.Clear()

            sqlQuery = "select cems_" & table & " .post_id, cems_" & table & " .post_state, cems_halls.hall_name from cems_" & table & "  inner join cems_halls on cems_" & table & ".hall_id = cems_halls.hall_id where cems_" & table & "." & searchColumn2 & " like '" & searchValue2 & "' "
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            sqlReader = sqlCmd.ExecuteReader

            datatable.Load(sqlReader)

            grid.DataSource = datatable



            If datatable.Rows.Count < 1 Then
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

            Dim newDataTable As New DataTable()

            For i As Integer = 0 To sqlReader.FieldCount - 1
                newDataTable.Columns.Add(sqlReader.GetName(i), sqlReader.GetFieldType(i))
            Next
            While sqlReader.Read()

                Dim row As DataRow = newDataTable.NewRow()

                For i As Integer = 0 To sqlReader.FieldCount - 1
                    row(i) = sqlReader(i)
                Next

                newDataTable.Rows.Add(row)
            End While

            sqlReader.Close()
            sqlConn.Close()

            grid.DataSource = newDataTable

            If newDataTable.Rows.Count < 2 And searchValue <> "" Then
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

    'user search function
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

    'function to check the email format 
    Public Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function

    'this is to change the password 
    Public Function updateUserPwd(isfrench As Boolean, table As String, column As String, pwd As String, confirmPwd As String, previousEmail As String, errorMsg As Control, panel As Control, timer As Timer)

        Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(confirmPwd)

        Dim updatesuccess As Boolean = False

        If pwd = "" Or confirmPwd = "" Then
            errorMsg.Visible = True
            If isfrench Then
                errorMsg.Text = My.Resources.resourcesFrText.EmptyField
            Else
                errorMsg.Text = My.Resources.resourcesEnText.EmptyField

            End If

            timer.Interval = 3000
            timer.Start()
        ElseIf pwd <> confirmPwd Then
            errorMsg.Visible = True
            If isfrench Then
                errorMsg.Text = My.Resources.resourcesFrText.PwdNotMatch
            Else
                errorMsg.Text = My.Resources.resourcesEnText.PwdNotMatch

            End If

            timer.Interval = 3000
            timer.Start()

        Else

            sqlConn.Open()

            sqlCmd.Connection = sqlConn


            With sqlCmd

                .CommandText = "Update " & database & ".cems_" & table & " Set  " & column & "_password = '" & hashedPassword & "' where " & column & "_email = '" & previousEmail & "'"

                .CommandType = CommandType.Text

            End With

            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

            panel.Visible = False
            updatesuccess = True
        End If

        Return updatesuccess
    End Function

    'this is to update the profile 
    Public Function updateUser(isfrench As Boolean, table As String, column As String, name As String, phone As String, email As String, previousEmail As String, errorMsg As Control, panel As Control, timer As Timer)

        Dim updateSuccess As Boolean = False
        connect_db()

        Try

            If name = "" Or email = "" Or phone = "" Then
                errorMsg.Visible = True
                If isfrench Then
                    errorMsg.Text = My.Resources.resourcesFrText.EmptyField
                Else
                    errorMsg.Text = My.Resources.resourcesEnText.EmptyField

                End If

                timer.Interval = 3000
                timer.Start()
            ElseIf Not IsValidEmail(email) Then
                errorMsg.Visible = True
                If isfrench Then
                    errorMsg.Text = My.Resources.resourcesFrText.invalidEmail
                Else
                    errorMsg.Text = My.Resources.resourcesEnText.invalidEmail

                End If

                timer.Interval = 3000
                timer.Start()
            Else
                sqlConn.Open()
                ' sqlQuery = "select * from cems_users where user_email = '" & email & "'"
                ' 'Read through the response'
                ' sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                ' sqlReader = sqlCmd.ExecuteReader
                '
                ' If (sqlReader.Read()) Then
                '     errorMsg.Visible = True
                '
                '     If isFrench Then
                '         errorMsg.Text = My.Resources.resourcesFrText.userExist
                '     Else
                '         errorMsg.Text = My.Resources.resourcesEnText.userExist
                '
                '     End If
                '
                '     timer.Interval = 3000
                '     timer.Start()
                '     sqlConn.Close()
                ' Else

                sqlCmd.Connection = sqlConn

                    With sqlCmd

                    .CommandText = "Update " & database & ".cems_" & table & " Set " & column & "_name = '" & name & "', " & column & "_phone_number = '" & phone & "', " & column & "_email = '" & email & "'  where " & column & "_email = '" & previousEmail & "'"

                    .CommandType = CommandType.Text

                    End With

                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()

                    panel.Visible = False
                    updateSuccess = True


                    Form1.user_email = email
                '  End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

        Return updateSuccess

    End Function

    'this is used to update one's personal information
    Public Async Function updateUserInformation(table As String, column As String, searchValue As String, name As Control, email As Control, phone As Control, title As Control) As Task

        connect_db()



        Try
            sqlConn.Open()
            'username appear
            sqlQuery = "select cems_" & table & "." & column & "_id, cems_" & table & "." & column & "_name, cems_" & table & "." & column & "_phone_number, cems_" & table & "." & column & "_email, cems_titles.title_name from cems_" & table & "  inner join cems_titles on cems_" & table & ".title_id = cems_titles.title_id where " & column & "_email = '" & searchValue & "'" 'Form1.emailtxt.Text'
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = Await sqlCmd.ExecuteReaderAsync
            If (sqlReader.Read()) Then
                name.Text = sqlReader.Item("" & column & "_name")


                email.Text = sqlReader.Item("" & column & "_email")
                phone.Text = sqlReader.Item("" & column & "_phone_number")
                title.Text = sqlReader.Item("title_name")


            End If

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql update user information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Function


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub export(grid As DataGridView, columnName As String, isFrench As Boolean)

        ' Get your data table


        Try
            Dim xlApp As Excel.Application = Nothing
            Dim xlWorkBook As Excel.Workbook = Nothing
            Dim xlWorkSheet As Excel.Worksheet = Nothing
            Dim misValue As Object = System.Reflection.Missing.Value


            xlApp = New Excel.Application

            xlWorkBook = xlApp.Workbooks.Add()
            xlWorkSheet = xlWorkBook.Sheets(1)


            If grid.Rows.Count > 0 AndAlso grid.Columns.Count > 0 Then

                ' Loop through the rows and columns of the data table
                For i As Integer = 0 To grid.Rows.Count - 1
                    For j As Integer = 0 To grid.Columns.Count - 1
                        For k As Integer = 1 To grid.Columns.Count
                            'test that i and j are greater than the number of rows and columns 
                            If i >= 0 AndAlso i < grid.Rows.Count AndAlso j >= 0 AndAlso j < grid.Columns.Count Then


                                xlWorkSheet.Cells(1, k) = grid.Columns(k - 1).HeaderText
                                xlWorkSheet.Cells(i + 2, j + 1) = grid.Rows(i).Cells(j).Value.ToString()

                            End If
                        Next
                    Next
                Next

            End If


            ' Save the Excel workbook to a file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"

            ' Set the default filename

            If Not isFrench Then
                Select Case columnName
                    Case "posts"
                        saveFileDialog.FileName = My.Resources.resourcesEnText.PostExport
                    Case "users"
                        saveFileDialog.FileName = My.Resources.resourcesEnText.UserExport
                    Case "halls"
                        saveFileDialog.FileName = My.Resources.resourcesEnText.HallExport
                    Case "equipments"
                        saveFileDialog.FileName = My.Resources.resourcesEnText.EquipmentExport
                    Case Else
                        saveFileDialog.FileName = My.Resources.resourcesEnText.OtherExport
                End Select

            Else

                Select Case columnName
                    Case "posts"
                        saveFileDialog.FileName = My.Resources.resourcesFrText.PostExport
                    Case "users"
                        saveFileDialog.FileName = My.Resources.resourcesFrText.UserExport
                    Case "halls"
                        saveFileDialog.FileName = My.Resources.resourcesFrText.HallExport
                    Case "equipments"
                        saveFileDialog.FileName = My.Resources.resourcesFrText.EquipmentExport
                    Case Else
                        saveFileDialog.FileName = My.Resources.resourcesFrText.OtherExport
                End Select

            End If


            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                xlWorkSheet.SaveAs(saveFileDialog.FileName)
            End If

            ' Release Excel objects from memory
            xlWorkBook.Close(False)
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'perform garbage collection 
            GC.Collect()
            GC.WaitForPendingFinalizers()

        End Try



    End Sub

    'this shows the number of functioning and malfunctioning equipments in the system 
    Public Sub activeCount(countLabel As Label, table As String, column As String, state As String, Cname As String)
        Dim count As Integer
        connect_db()
        Try
            sqlConn.Open()
            'count the number of good
            sqlQuery = "select count(*) from cems_" & table & " where " & column & "_state = '" & state & "' and " & column & "_type = '" & Cname & "'" 'Form1.emailtxt.Text'
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

    'dropdown timer function
    Public Sub dropdownTimer(iscollapsed As Boolean, dropdown As Panel, timer1 As Timer)
        'If iscollapsed Then
        '    dropdown.Size = dropdown.MaximumSize
        '    If dropdown.Size = dropdown.MaximumSize Then
        '        timer1.Stop()
        '        iscollapsed = False
        '    End If
        'Else
        '    dropdown.Size = dropdown.MinimumSize
        '    If dropdown.Size = dropdown.MinimumSize Then
        '        timer1.Stop()
        '        iscollapsed = True
        '    End If
        'End If

        If dropdown.Size = dropdown.MaximumSize Then
            dropdown.Size = dropdown.MinimumSize
            timer1.Stop()
        Else
            dropdown.Size = dropdown.MaximumSize
            timer1.Stop()
        End If

    End Sub


End Class

'                    .CommandText = "Update " & database & ".cems_'" & table & "' Set user_name = '" & name & "', user_phone_number = '" & phone & "', user_email = '" & email & "'  where user_email = '" & Form1.emailtxt.Text & "'"
