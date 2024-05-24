Imports System.Data.SqlClient

Public Class reservation

    Public id As String
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadreservation()
    End Sub

    Sub childform(ByVal panel As Form)
        mainPage.pnlChildForm.Controls.Clear()
        panel.TopLevel = False
        mainPage.pnlChildForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub loadreservation()
        Dim query As String = "Select ID, First_Name, Contact_Email, Phone, Checkin_Date, Checkout_date, Room_Type, No_Of_Adult, No_Of_Children, Reference_Number, Arrival_Time, Downpayment, Room_No from tbl_reservation"
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
        If txtID.Text = "" Then
            MsgBox("Select an Item you want to cancel")
        Else
            Dim name As String = txtName.Text
            Dim checkin As String = dtpCheckIn.Value.Year & "-" & dtpCheckIn.Value.Month & "-" & dtpCheckIn.Value.Day
            Dim checkout As String = dtpCheckOut.Value.Year & "-" & dtpCheckOut.Value.Month & "-" & dtpCheckOut.Value.Day
            Dim dateT As String = dtpDate.Value.Year & "-" & dtpDate.Value.Month & "-" & dtpDate.Value.Day

            ' Query for inserting the report to the reports shit
            Dim updateReportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date)"
            Try
                Using cmd As SqlCommand = New SqlCommand(updateReportQuery, con)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Checked_In", checkin)
                    cmd.Parameters.AddWithValue("@Checked_Out", checkout)
                    cmd.Parameters.AddWithValue("@Total_Price", txtTotalPrice.Text)
                    cmd.Parameters.AddWithValue("@Status", "Cancelled")
                    cmd.Parameters.AddWithValue("@Date", dateT)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            ' Query for deleting the name on the reservation on a table room
            Dim deleteRoomReserveQuery As String = "DELETE FROM [" & txtRoomNo.Text & "] WHERE Guest_Name = @Guest_Name AND Checkin_Date = @CheckIn AND Checkout_Date = @CheckOut"
            Try
                Using cmd As SqlCommand = New SqlCommand(deleteRoomReserveQuery, con)
                    cmd.Parameters.AddWithValue("@Guest_Name", name)
                    cmd.Parameters.AddWithValue("@CheckIn", checkin)
                    cmd.Parameters.AddWithValue("@CheckOut", checkout)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            Catch ex As Exception
                MessageBox.Show("deleteRoomReserveQuery: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            ' Query for deleting the reserved to the reserve list
            Dim query As String = "DELETE FROM tbl_reservation WHERE ID = @id"
            Try
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
                loadreservation()
            End Try

            txtID.Clear()
            txtName.Clear()
            id = ""
        End If
    End Sub

    Private Sub tmrUpdateDB_Tick(sender As Object, e As EventArgs) Handles tmrUpdateDB.Tick
        loadreservation()
    End Sub

    Private Sub btnReserveRoom_Click(sender As Object, e As EventArgs) Handles btnReserveRoom.Click
        childform(reserve)
    End Sub

    Private Sub dgvReservation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservation.CellClick
        Try
            If e.RowIndex >= 0 Then
                txtID.Text = dgvReservation.Rows(e.RowIndex).Cells(0).Value.ToString
                txtName.Text = dgvReservation.Rows(e.RowIndex).Cells(1).Value.ToString
                dtpCheckIn.Value = dgvReservation.Rows(e.RowIndex).Cells(4).Value
                dtpCheckOut.Value = dgvReservation.Rows(e.RowIndex).Cells(5).Value
                txtRoomNo.Text = dgvReservation.Rows(e.RowIndex).Cells(12).Value.ToString
                id = txtID.Text
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class