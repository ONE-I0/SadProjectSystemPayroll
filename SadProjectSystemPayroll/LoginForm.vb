Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim username, passowrd As String
    Dim sql As String

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registrationAdmins As AdminRegisters = New AdminRegisters
        registrationAdmins.Show()
        Me.Hide()

    End Sub


    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        txtUsername.ForeColor = Color.White
        txtUsername.Text = ""
        txtUsername.ForeColor = Color.Black
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        txtPassword.ForeColor = Color.White
        txtPassword.Text = ""
        txtPassword.ForeColor = Color.Black
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        username = txtUsername.Text
        passowrd = txtPassword.Text

        If (username = "" And passowrd = "") Then
            MessageBox.Show("Enter Username and passowrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MY_CONNECTION()
            conn.Open()
            sql = "Select * from AdminLogin where username = '" & username & "' and password = '" & passowrd & "'"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then
                Dim f2 As MainPayrollSystem = New MainPayrollSystem
                f2.Show()
                Me.Hide()

            Else
                MessageBox.Show("Login Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class