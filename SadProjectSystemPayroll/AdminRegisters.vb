Imports System.Data.SqlClient
Public Class AdminRegisters
    Dim cmd As SqlCommand


    Private Sub Bind()
        MY_CONNECTION()
    End Sub

    'Clear TextFields after register

    Public Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtConfirm.Clear()
    End Sub
    Private Sub Register()
        Try
            MY_CONNECTION()
            cmd = New SqlCommand
            cmd.Connection = conn

            cmd.CommandText = "insert into AdminLogin(ID,username,password,firstname,lastname)values((Select ISNULL(MAX(ID)+1,1)from AdminLogin),@username,@password,@firstname,@lastname)"
            cmd.Parameters.Add("@ID", txtID.Text)
            cmd.Parameters.Add("@firstname", txtFirstname.Text)
            cmd.Parameters.Add("@lastname", txtLastname.Text)
            cmd.Parameters.Add("@username", txtUsername.Text)
            cmd.Parameters.Add("@password", txtPassword.Text)

            conn.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Admin Succefully Added!!")
                conn.Close()
            Else
                MsgBox("Admin Registration Failed")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function usernameExist(ByVal username As String) As Boolean

        Dim connn As New SqlConnection("server =ONEIPC\MYSERVER; database=Payrolldatabase; user id =sa; password=admin123;")
        Dim cmd As New SqlCommand("SELECT username FROM AdminLogin where username = @usn", connn)
        cmd.Parameters.Add("@usn", SqlDbType.VarChar).Value = username
        Dim adapater As New SqlDataAdapter
        adapater.SelectCommand = cmd
        Dim table As New DataTable
        adapater.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If




    End Function
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirm.UseSystemPasswordChar = False
        ElseIf cbshow.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
            txtConfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Inputs checkers

        Dim fname As String = txtFirstname.Text
        Dim lname As String = txtLastname.Text
        Dim user As String = txtUsername.Text
        Dim pass As String = txtPassword.Text


        If fname.Trim() = "" Or lname.Trim() = "" Or user.Trim() = "" Or pass.Trim() = "" Then
            MsgBox("Missing Empty Fields")
        ElseIf Not String.Equals(txtPassword.Text, txtConfirm.Text) Then
            MsgBox("Password Mismatch!!!")
        ElseIf usernameExist(txtUsername.Text) Then
            MsgBox("alreadyTaken")
        Else
            Register()
            clear()
            Dim Loginform As LoginForm = New LoginForm
            Loginform.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Loginform As LoginForm = New LoginForm
        Loginform.Show()
        Me.Close()
    End Sub

    'Private Sub BTNVALIDATE_CLICK(SENDER As Object, E As EventArgs) Handles btnValidate.Click
    '    If usernameExist(txtUsername.Text) Then
    '        MsgBox("USER ALREADY TAKEN")
    '    ElseIf Not usernameExist(txtUsername.Text) Then
    '        txtPassword.Enabled = True
    '        txtConfirm.Enabled = True
    '    End If
    'End Sub
End Class