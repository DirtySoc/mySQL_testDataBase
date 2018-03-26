Imports MySql.Data.MySqlClient

Public Class Form1

    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;user id=test;password=test123;port=3306;database=test")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " + ex.Message.ToString)
        End Try
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        addUser(txt_firstName.Text.ToString(), txt_lastName.Text.ToString())
    End Sub

    Private Sub getButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getButton.Click
        getUserTableData()
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim userIsSure = MessageBox.Show("Are you sure you want to remove the selected from the database?", "caption", MessageBoxButtons.YesNo)
        If userIsSure = DialogResult.Yes Then
            'Grab the selected user and split the sting into firstname and lastname.
            Dim fullName As String = listBox_users.SelectedItem.ToString()
            Dim name() As String = fullName.Split(" ")
            'pass deleteUser the first name and last name of person getting deleted.
            deleteUser(name(0), name(1))
            getUserTableData()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub addUser(ByVal firstName, ByVal lastName)
        sql = "INSERT INTO _users(u_id,u_firstName,u_lastName) VALUES(NULL,'" & firstName & "','" & lastName & "')"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
            MsgBox("Data inserted.")
            txt_firstName.Clear()
            txt_lastName.Clear()
        Catch ex As Exception
            MsgBox("Failed to insert data: " & ex.Message.ToString())
        End Try
        dbread.Close()
    End Sub

    ''' <summary>
    ''' DELETE FROM test 
    ''' WHERE u_firstname='Bob'
    ''' AND u_lastname='Burger'
    ''' </summary>
    ''' <remarks>
    ''' NOT WORKING 
    ''' Verified that SQL being sent is correct format. Tested command via cmd line interface to MariaDB...
    ''' </remarks>
    Private Sub deleteUser(ByVal firstName, ByVal lastName)
        sql = "DELETE FROM _users WHERE u_firstname = '" & firstName & "' AND u_lastname = '" & lastName & "' LIMIT 1"
        MsgBox(sql)
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            MsgBox("User deleted!")
        Catch ex As Exception
            MsgBox("Error trying to delete: " & ex.Message)
        End Try
    End Sub

    Private Sub getUserTableData()
        listBox_users.Items.Clear()
        sql = "SELECT * FROM _users"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                listBox_users.Items.Add(dbread("u_firstName").ToString() & " " & dbread("u_lastName").ToString())
            End While
        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
        End Try
        dbread.Close()
    End Sub
End Class

