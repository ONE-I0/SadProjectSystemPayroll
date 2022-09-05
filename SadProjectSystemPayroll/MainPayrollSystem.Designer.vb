<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPayrollSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtDateofBirth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhonenumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtWeeklyHours = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblWeeklyHours = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPhonenumber = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.refresh = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayrollToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.SettingToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateEmployeeToolStripMenuItem, Me.RegisterEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee"
        '
        'RegisterEmployeeToolStripMenuItem
        '
        Me.RegisterEmployeeToolStripMenuItem.Name = "RegisterEmployeeToolStripMenuItem"
        Me.RegisterEmployeeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RegisterEmployeeToolStripMenuItem.Text = "Register Employee"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfirstname)
        Me.GroupBox1.Controls.Add(Me.txtDateofBirth)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPhonenumber)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 390)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Location = New System.Drawing.Point(51, 60)
        Me.txtfirstname.Multiline = True
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(121, 26)
        Me.txtfirstname.TabIndex = 12
        '
        'txtDateofBirth
        '
        Me.txtDateofBirth.Enabled = False
        Me.txtDateofBirth.Location = New System.Drawing.Point(73, 216)
        Me.txtDateofBirth.Multiline = True
        Me.txtDateofBirth.Name = "txtDateofBirth"
        Me.txtDateofBirth.Size = New System.Drawing.Size(230, 26)
        Me.txtDateofBirth.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Birth:"
        '
        'txtPhonenumber
        '
        Me.txtPhonenumber.Enabled = False
        Me.txtPhonenumber.Location = New System.Drawing.Point(51, 124)
        Me.txtPhonenumber.Multiline = True
        Me.txtPhonenumber.Name = "txtPhonenumber"
        Me.txtPhonenumber.Size = New System.Drawing.Size(252, 26)
        Me.txtPhonenumber.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No:"
        '
        'txtGender
        '
        Me.txtGender.Enabled = False
        Me.txtGender.Location = New System.Drawing.Point(51, 92)
        Me.txtGender.Multiline = True
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(252, 26)
        Me.txtGender.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender:"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(51, 156)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(252, 54)
        Me.txtAddress.TabIndex = 5
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(6, 159)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(48, 13)
        Me.Address.TabIndex = 4
        Me.Address.Text = "Address:"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Location = New System.Drawing.Point(182, 60)
        Me.txtlastname.Multiline = True
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(121, 26)
        Me.txtlastname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(51, 28)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(252, 26)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'txtPosition
        '
        Me.txtPosition.Enabled = False
        Me.txtPosition.Location = New System.Drawing.Point(90, 19)
        Me.txtPosition.Multiline = True
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(123, 26)
        Me.txtPosition.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Position:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPayment)
        Me.GroupBox3.Controls.Add(Me.txtWeeklyHours)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnCompute)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(399, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 244)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'txtPayment
        '
        Me.txtPayment.Enabled = False
        Me.txtPayment.Location = New System.Drawing.Point(98, 52)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(115, 24)
        Me.txtPayment.TabIndex = 26
        '
        'txtWeeklyHours
        '
        Me.txtWeeklyHours.Enabled = False
        Me.txtWeeklyHours.Location = New System.Drawing.Point(98, 19)
        Me.txtWeeklyHours.Multiline = True
        Me.txtWeeklyHours.Name = "txtWeeklyHours"
        Me.txtWeeklyHours.Size = New System.Drawing.Size(115, 24)
        Me.txtWeeklyHours.TabIndex = 26
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(98, 151)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(115, 24)
        Me.TextBox4.TabIndex = 25
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(98, 118)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(115, 24)
        Me.TextBox3.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(98, 184)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 24)
        Me.TextBox2.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 178)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Net-Salary"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "           PhilHealth"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "           SSS"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(98, 85)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 24)
        Me.TextBox1.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tax:    Pag-Ibig"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(156, 215)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(57, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(98, 215)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(57, 23)
        Me.btnCompute.TabIndex = 16
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "GrossSalary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "WeeklyHour"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lblPosition)
        Me.GroupBox2.Controls.Add(Me.lblRate)
        Me.GroupBox2.Controls.Add(Me.lblWeeklyHours)
        Me.GroupBox2.Controls.Add(Me.lblPayment)
        Me.GroupBox2.Controls.Add(Me.lblPhonenumber)
        Me.GroupBox2.Controls.Add(Me.lblGender)
        Me.GroupBox2.Controls.Add(Me.lblAddress)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(634, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 390)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pay Slip"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(104, 150)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(85, 13)
        Me.lblPosition.TabIndex = 17
        Me.lblPosition.Text = ".........................."
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(104, 198)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(85, 13)
        Me.lblRate.TabIndex = 16
        Me.lblRate.Text = ".........................."
        '
        'lblWeeklyHours
        '
        Me.lblWeeklyHours.AutoSize = True
        Me.lblWeeklyHours.Location = New System.Drawing.Point(104, 174)
        Me.lblWeeklyHours.Name = "lblWeeklyHours"
        Me.lblWeeklyHours.Size = New System.Drawing.Size(85, 13)
        Me.lblWeeklyHours.TabIndex = 15
        Me.lblWeeklyHours.Text = ".........................."
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(104, 242)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(85, 13)
        Me.lblPayment.TabIndex = 14
        Me.lblPayment.Text = ".........................."
        '
        'lblPhonenumber
        '
        Me.lblPhonenumber.AutoSize = True
        Me.lblPhonenumber.Location = New System.Drawing.Point(104, 127)
        Me.lblPhonenumber.Name = "lblPhonenumber"
        Me.lblPhonenumber.Size = New System.Drawing.Size(85, 13)
        Me.lblPhonenumber.TabIndex = 13
        Me.lblPhonenumber.Text = ".........................."
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(104, 102)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(85, 13)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = ".........................."
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(104, 78)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(85, 13)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = ".........................."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(104, 54)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(85, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = ".........................."
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(104, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(85, 13)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = ".........................."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 242)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Net-Salary"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Rate:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Weekly Hours:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Position"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "No:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Gender:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Address:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ID:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPosition)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtRate)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(399, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 128)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'txtRate
        '
        Me.txtRate.Enabled = False
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(90, 60)
        Me.txtRate.Multiline = True
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(123, 26)
        Me.txtRate.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Rate:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 464)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(808, 191)
        Me.DataGridView1.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(204, 25)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "PAYROLL SYSTEM"
        '
        'refresh
        '
        Me.refresh.BackgroundImage = Global.SadProjectSystemPayroll.My.Resources.Resources.refress_icon
        Me.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refresh.Location = New System.Drawing.Point(826, 464)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(42, 38)
        Me.refresh.TabIndex = 22
        Me.refresh.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(104, 219)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = ".........................."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 219)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Total Tax"
        '
        'MainPayrollSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 667)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPayrollSystem"
        Me.Text = "MainPayrollSystem"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDateofBirth As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhonenumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblWeeklyHours As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblPhonenumber As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents refresh As Button
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtWeeklyHours As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
End Class
