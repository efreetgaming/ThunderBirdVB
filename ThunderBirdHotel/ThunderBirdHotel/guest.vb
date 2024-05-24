Imports System.Data.SqlClient
Public Class guest
    Private Sub guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGuest()
    End Sub

    Public Sub loadGuest()
        Dim query As String = "Select Customer_Id, Customer_Name, Gender, Email_Address, Address, No_Of_Adults, No_Of_Children, Phone_No, Checked_In from tbl_guest"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dgvGuest.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub tmrUpdateDB_Tick(sender As Object, e As EventArgs) Handles tmrUpdateDB.Tick
        loadGuest()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = "Select Customer_Id, Customer_Name, Gender, Email_Address, Address, No_Of_Adults, No_Of_Children, Phone_No, Checked_In from tbl_guest Where Customer_Name like '%" & txtSearchGuest.Text & "%' "

        Using cmd = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    dgvGuest.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Dim query As String = "Delete from tbl_guest"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class