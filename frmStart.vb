Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System.IO

Public Class frmStart
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin
        txtLogUsername.Focus()
        If My.Settings.rememberMe = True Then
            tglswtchRememberMe.Enabled = False
            lblRememberMe.Enabled = False
            tglswtchRememberMe.Checked = True
            txtLogUsername.Text = My.Settings.username
            txtLogPassword.Text = My.Settings.password
            lblinkForgetMe.Enabled = True
        Else
            lblinkForgetMe.Enabled = False
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If tglswtchRememberMe.Checked = True Then
                If txtLogUsername.Text <> Nothing Or txtLogPassword.Text <> Nothing Then
                    My.Settings.username = txtLogUsername.Text
                    My.Settings.password = txtLogPassword.Text
                    My.Settings.rememberMe = True
                    My.Settings.Save()
                    My.Settings.Reload()
                    MessageBox.Show("You have successfully login. Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtLogUsername.Text = ""
                    txtLogPassword.Text = ""
                Else
                    MessageBox.Show("Username and Password are required", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtLogUsername.Focus()
                End If
            Else
                If txtLogUsername.Text <> Nothing Or txtLogPassword.Text <> Nothing Then
                    MessageBox.Show("You have successfully login. Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtLogUsername.Text = ""
                    txtLogPassword.Text = ""
                Else
                    MessageBox.Show("Username and Password are required", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtLogUsername.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("incorrect setting. Please check your definition again", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lblinkForgetMe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblinkForgetMe.LinkClicked
        Try
            Dim ask As String = MessageBox.Show("Are you sure to remove this session?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = MsgBoxResult.Yes Then
                My.Settings.Reset()
                tglswtchRememberMe.Enabled = True
                lblinkForgetMe.Enabled = True
                txtLogUsername.Text = ""
                txtLogPassword.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("incorrect setting. Please check your definition again", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnLogCreateAccount_Click(sender As Object, e As EventArgs) Handles btnLogCreateAccount.Click
        pnRegister.Visible = True
        pnLogin.Visible = False
        Guna2Transition1.ShowSync(pnRegister)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If txtRegEmail.Text = "" Or txtRegUsername.Text = "" Or txtRegPassword.Text = "" Then
            MessageBox.Show("All fields are required", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmregister(txtRegEmail.Text, txtRegUsername.Text, txtRegPassword.Text)
            MessageBox.Show("User successfully registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBackLogin_Click(sender As Object, e As EventArgs) Handles btnBackLogin.Click
        pnLogin.Visible = True
        Guna2Transition1.ShowSync(pnLogin)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLogUsername.TextChanged

    End Sub
End Class
