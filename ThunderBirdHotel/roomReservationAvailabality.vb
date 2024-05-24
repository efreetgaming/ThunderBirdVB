Imports System.ComponentModel

Public Class roomReservationAvailabality
    Private Sub roomReservationAvailabality_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAvailableRoom()
    End Sub

    Public Sub loadAvailableRoom()
        'Dim query As String = "Select * from tbl_rooms WHERE Status = @Status AND Guest_Name IS NULL"
        'Using cmd As New SqlCommand(query, con)
        '    cmd.Parameters.AddWithValue("@Status", "Available")
        '    ' Set up the data adapter and fill the DataTable
        '    Using da As New SqlDataAdapter(cmd)
        '        Dim dt As New DataTable()
        '        da.Fill(dt)

        '        ' Set the DataGridView's data source
        '        dgvRRoomAvailable.DataSource = dt
        '    End Using
        'End Using
        Dim checkInDate As Date = reserve.dtpRCheckIn.Value
        Dim checkOutDate As Date = reserve.dtpRCheckOut.Value

        dgvRRoomAvailable.DataSource = CheckRoomAvailability(checkInDate, checkOutDate)
    End Sub

    Private Sub dgvRRoomAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRRoomAvailable.CellClick
        If e.RowIndex >= 0 Then
            reserve.lblRRoomNo.Text = dgvRRoomAvailable.Rows(e.RowIndex).Cells(0).Value.ToString
            reserve.lblRRoomType.Text = dgvRRoomAvailable.Rows(e.RowIndex).Cells(1).Value.ToString
            reserve.lblRRoomRate.Text = dgvRRoomAvailable.Rows(e.RowIndex).Cells(2).Value.ToString
            reserve.lblRRoomRatingRoom.Text = dgvRRoomAvailable.Rows(e.RowIndex).Cells(2).Value.ToString
            reserve.updateRoomRate()
        Else
        End If
    End Sub

    Private Sub roomReservationAvailabality_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        con.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub
End Class