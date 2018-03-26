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
        addUser(txt_firstName.Text.ToString().Trim(), txt_lastName.Text.ToString().Trim())
    End Sub

    Private Sub getButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getButton.Click
        getUserTableData()
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim userIsSure = MessageBox.Show("Are you sure you want to remove the selected from the database?", "caption", MessageBoxButtons.YesNo)
        If userIsSure = DialogResult.Yes Then
            'The program throws a null reference exception here sometimes if the user clicks onto the same name that is selected. Something buggy with the listbox....
            Try
                'Grab the selected user and split the sting into firstname and lastname.
                Dim fullName As String = listBox_users.SelectedItem.ToString()
                Dim name() As String = fullName.Split(" ")
                'pass deleteUser the u_ID.
                deleteUser(name(0))
                'refresh the UI
                getUserTableData()
            Catch ex As Exception
                MsgBox("Oops... Something went wrong. Try Again! " & ex.Message)
            End Try
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
    ''' Sub needs to be re-written to get u_id and then delete user based on id not name.
    ''' </remarks>
    Private Sub deleteUser(ByVal u_ID)
        sql = "DELETE FROM _users WHERE u_ID = '" & u_ID & "' LIMIT 1"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbcomm.ExecuteNonQuery()
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
                listBox_users.Items.Add(dbread("u_ID").ToString() & " " & dbread("u_firstName").ToString() & " " & dbread("u_lastName").ToString())
            End While
        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
        End Try
        dbread.Close()
    End Sub
End Class

