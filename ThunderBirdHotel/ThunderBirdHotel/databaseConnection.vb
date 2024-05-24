Imports System.Data.SqlClient

Module databaseConnection
    Public con As New SqlConnection
    Public cmd As New SqlCommand

    Sub opencon()
        con.ConnectionString = "Data Source=VALIARES;Initial Catalog=DBHotelManagement;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    End Sub
End Module
