Imports System.Data.SqlClient
Imports System.IO
Public Class Employee_Registration

    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub Bind()
        MY_CONNECTION()
    End Sub
    Private Sub Register()
        Try
            Dim ms As New MemoryStream
            PictureBoxPhoto.Image.Save(ms, PictureBoxPhoto.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer
            ms.Close()
            MY_CONNECTION()

            cmd = New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "insert into Employee_Data(ID,firstname,lastname,address,gender,phonenumber,dateofbirth,position,sitelocation,photo,rate)values(@ID,@firstname,@lastname,@address,@gender,@phonenumber,@dateofbirth,@position,@sitelocation,@photo,@rate)"



            cmd.Parameters.Add("@ID", txtID.Text)
            cmd.Parameters.Add("@firstname", txtFirstName.Text)
            cmd.Parameters.Add("@lastname", txtLastName.Text)
            cmd.Parameters.Add("@address", txtAddress.Text)
            cmd.Parameters.Add("@gender", cbGender.Text)
            cmd.Parameters.Add("@phonenumber", txtPhoneNumber.Text)
            cmd.Parameters.Add("@dateofbirth", dtpDateofBirth.Value)
            cmd.Parameters.Add("@position", cbPosition.Text)
            cmd.Parameters.Add("@sitelocation", cbSiteLocation.Text)
            cmd.Parameters.Add("@photo", arrImage)
            cmd.Parameters.Add("@rate", txtRate.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record Added")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EmpID()
        Try
            Dim Sql As String
            Dim EID
            Sql = "select ID from Employee_Data order by ID Desc"
            MY_CONNECTION()
            conn.Open()

            cmd = New SqlCommand(Sql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (dr.Read) Then
                Dim id As Integer
                id = (dr(0) + 1)
                EID = id.ToString("00000")
            ElseIf IsDBNull(dr) Then
                EID = ("00001")
            Else
                EID = ("00001")
            End If
            txtID.Text = EID
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim ob As New MainPayrollSystem
        Register()
        ob.loadTable()


    End Sub

    Private Sub Employee_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpID()
        Bind()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        With OpenFileDialog1
            .InitialDirectory = "c:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With PictureBoxPhoto
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If
    End Sub
End Class