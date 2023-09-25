Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography.X509Certificates

Module modDataAccessLayer
    Public con As New MySqlConnection("server=localhost;database=vbnet_login&register;uid=root;pwd='';")

    Public Sub Connect()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        Else
            con.Open()
        End If
    End Sub

    Public Function frmlogin(username As String, password As String)
        Connect()
        Dim cmd As New MySqlCommand("select * from users where username = @1 and password = @2", con)
        cmd.Parameters.AddWithValue("@1", username)
        cmd.Parameters.AddWithValue("@2", password)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt
    End Function

    Public Function frmregister(username As String, password As String, email As String)
        Connect()
        Dim cmd As New MySqlCommand("insert into users(username,password,email)values(@1,@2,@3)", con)
        'Dim cmd1 As New MySqlCommand("SELECT * FROM users WHERE username=@username", con)
        'Dim reader As MySqlDataReader

        With cmd
            .Parameters.AddWithValue("@1", username)
            .Parameters.AddWithValue("@2", password)
            .Parameters.AddWithValue("@3", email)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

End Module
