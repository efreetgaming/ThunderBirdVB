Imports System.Data.SqlClient

Public Class room
    Private Sub room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRoomList()
    End Sub

    Public Sub loadRoomList()
        Dim query As String = "SELECT * FROM tbl_rooms WHERE Guest_Name IS NOT NULL"

        Using cmd As SqlCommand = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dgvRooms.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub tmrUpdateDB_Tick(sender As Object, e As EventArgs) Handles tmrUpdateDB.Tick
        loadRoomList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = "Select * from tbl_rooms Where Guest_Name Like '%" & txtSearchRooms.Text & "%' "

        Using cmd = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    dgvRooms.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Dim query As String = "UPDATE tbl_rooms SET Guest_Name = NULL, Phone_No = NULL, Status = @avail"

        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@avail", "Available")
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            loadRoomList()
        End Using
    End Sub
End Class