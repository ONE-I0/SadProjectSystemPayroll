Imports System.Data.SqlClient
Public Class MainPayrollSystem
    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim adapter As New SqlDataAdapter

    Public Sub loadTable()
        Try
            MY_CONNECTION()
            cmd = New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select * from Employee_Data"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim empRegistration As Employee_Registration = New Employee_Registration
        empRegistration.Show()

    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Dim empEmployeeData As Employee_Edit = New Employee_Edit
        empEmployeeData.Show()

    End Sub

    Private Sub MainPayrollSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()

    End Sub

    Private Sub ComputationofPayment()
        Dim Payment As Integer
        Payment = txtRate.Text * txtWeeklyHours.Text
        txtPayment.Text = Payment

    End Sub
    Private Sub PayslipDisplay()
        lblID.Text = txtID.Text
        lblName.Text = txtfirstname.Text & " " & txtlastname.Text
        lblAddress.Text = txtAddress.Text
        lblGender.Text = txtGender.Text
        lblPhonenumber.Text = txtPhonenumber.Text
        lblPosition.Text = txtPosition.Text
        lblWeeklyHours.Text = txtWeeklyHours.Text
        lblRate.Text = txtRate.Text
        lblPayment.Text = txtPayment.Text
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'Display Employee Information
        txtID.Text = DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value
        txtfirstname.Text = DataGridView1("firstname", DataGridView1.CurrentRow.Index).Value
        txtlastname.Text = DataGridView1("lastname", DataGridView1.CurrentRow.Index).Value
        txtGender.Text = DataGridView1("gender", DataGridView1.CurrentRow.Index).Value
        txtPhonenumber.Text = DataGridView1("phonenumber", DataGridView1.CurrentRow.Index).Value
        txtAddress.Text = DataGridView1("address", DataGridView1.CurrentRow.Index).Value
        txtDateofBirth.Text = DataGridView1("dateofbirth", DataGridView1.CurrentRow.Index).Value

        'Display Computation Data
        txtRate.Text = DataGridView1("rate", DataGridView1.CurrentRow.Index).Value
        txtPosition.Text = DataGridView1("position", DataGridView1.CurrentRow.Index).Value


    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Try
            Dim cancel As String
            cancel = MessageBox.Show("are your inputs correct?", "Payroll", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If String.IsNullOrEmpty(txtWeeklyHours.Text) Then
                MessageBox.Show("No Input!.", "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            ElseIf cancel = MsgBoxResult.No Then
                txtRate.Clear()
                txtWeeklyHours.Clear()
                Exit Sub
            ElseIf cancel = MsgBoxResult.Yes Then
                ComputationofPayment()
                PayslipDisplay()
            Else
                MsgBox("Invalid Input.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtWeeklyHours_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
            MessageBox.Show("Numbers Only!", "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtWeeklyHours.Clear()
        txtRate.Clear()
        txtPayment.Clear()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim Admins As LoginForm = New LoginForm
        Me.Close()
        Admins.Show()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        loadTable()
    End Sub


End Class