Imports System.Data.SqlClient

Public Class roomAvailability

    Public RoomNo As String
    Public RoomType As String
    Public Guest_Name As String
    Public Phone_No As String
    Public Extras As String
    Public RoomRate As String
    Public Max_Guest As String
    Public Status As String

    Private Sub roomAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAvailableRoom()
    End Sub

    Public Sub loadAvailableRoom()
        Dim query As String = "Select * from tbl_rooms WHERE Status = @Status AND Guest_Name IS NULL"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Status", "Available")
            ' Set up the data adapter and fill the DataTable
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Set the DataGridView's data source
                dgvAvailableRoom.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub dgvAvailableRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailableRoom.CellClick
        checkIn.lblRoomNo.Text = dgvAvailableRoom.Rows(e.RowIndex).Cells(0).Value.ToString
        checkIn.lblRoomType.Text = dgvAvailableRoom.Rows(e.RowIndex).Cells(1).Value.ToString
        Guest_Name = dgvAvailableRoom.Rows(e.RowIndex).Cells(2).Value.ToString
        Phone_No = dgvAvailableRoom.Rows(e.RowIndex).Cells(3).Value.ToString
        Extras = dgvAvailableRoom.Rows(e.RowIndex).Cells(4).Value.ToString
        checkIn.lblRoomRate.Text = dgvAvailableRoom.Rows(e.RowIndex).Cells(5).Value.ToString
        Max_Guest = dgvAvailableRoom.Rows(e.RowIndex).Cells(6).Value.ToString
        Status = dgvAvailableRoom.Rows(e.RowIndex).Cells(7).Value.ToString
        checkIn.lblRoomRatingRoom.Text = dgvAvailableRoom.Rows(e.RowIndex).Cells(5).Value.ToString
        checkIn.updateRoomRate()

        checkIn.updateRoomRate()
    End Sub
End Class