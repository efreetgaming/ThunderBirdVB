Imports System.Data.SqlClient

Public Class reservation

    Public id As String
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadreservation()
    End Sub

    Public Sub loadreservation()
        Dim query As String = "Select * from tbl_reservation"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dgvReservation.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnNull_Click(sender As Object, e As EventArgs) Handles btnNull.Click

        ' Query for inserting the report to the reports shit
        Dim updateReportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date)"
        Using cmd As SqlCommand = New SqlCommand(updateReportQuery, con)
            cmd.Parameters.AddWithValue("@Name")
            cmd.Parameters.AddWithValue("@Checked_In")
            cmd.Parameters.AddWithValue("@Checked_Out")
            cmd.Parameters.AddWithValue("@Total_Price")
            cmd.Parameters.AddWithValue("@Status")
            cmd.Parameters.AddWithValue("@Date")
        End Using

        ' Query for deleting the reserved to the reserve list
        Dim query As String = "DELETE FROM tbl_reservation WHERE ID = @id"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            loadreservation()
        End Using
    End Sub

    Private Sub tmrUpdateDB_Tick(sender As Object, e As EventArgs) Handles tmrUpdateDB.Tick
        loadreservation()
    End Sub

    Private Sub btnReserveRoom_Click(sender As Object, e As EventArgs) Handles btnReserveRoom.Click
        reserve.Show()
    End Sub

    Private Sub dgvReservation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservation.CellClick

    End Sub
End Class