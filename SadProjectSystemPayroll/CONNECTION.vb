Imports System.Data.SqlClient

Module CONNECTION
    Public conn As SqlConnection
    Public Sub MY_CONNECTION()
        Try
            conn = New SqlConnection("server =ONEIPC\MYSERVER; database=Payrolldatabase; user id =sa; password=admin123;")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
