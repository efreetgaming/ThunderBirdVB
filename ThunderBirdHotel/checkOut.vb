Imports System.Data.SqlClient

Public Class checkOut

    Private Sub checkOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCheckOut()
    End Sub

    Public Sub loadCheckOut()
        Try
            Dim query As String = "Select * from tbl_checkout"
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If txtCheckOutId.Text = "" Then
            MsgBox("Click an item to the list first")
        Else
            Try
                Dim checkOutId As String = txtCheckOutId.Text
                Dim roomNo As String = txtRoomNo.Text
                Dim custName As String = txtCustomerName.Text
                Dim checkIn As String = txtCheckIn.Text
                Dim checkOut As String = txtCheckOut.Text
                Dim totalPrice As String = txtTotalPrice.Text
                Dim dateOne As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim arrival As String = txtArrivalTime.Text
                Dim departure As String = DateTime.Now.ToString("HH:mm:ss")
                Dim transactId As String = txtTransactID.Text

                ' Query for Changing the Available of room
                Try
                    Dim updateRoomQuery As String = "UPDATE tbl_rooms SET Guest_Name = NULL, Phone_No = NULL, Status = @avail, Extras = NULL, Arrival_Time = @arrival_time, Departure_Time = @departure_time WHERE Room_No = @roomNo"

                    Using cmd As SqlCommand = New SqlCommand(updateRoomQuery, con)
                        cmd.Parameters.AddWithValue("@Extras", DBNull.Value)
                        cmd.Parameters.AddWithValue("@avail", "Cleaning")
                        cmd.Parameters.AddWithValue("@roomNo", roomNo)
                        cmd.Parameters.AddWithValue("@arrival_time", DBNull.Value)
                        cmd.Parameters.AddWithValue("@departure_time", DBNull.Value)

                        con.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                    MsgBox("Update Room success")
                End Try


                ' Query for reports
                Dim query As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date, Arrival_Time, Departure_Time) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date, @Arrival_Time, @Departure_Time)"
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Name", custName)
                    cmd.Parameters.AddWithValue("@Checked_In", checkIn)
                    cmd.Parameters.AddWithValue("@Checked_Out", checkOut)
                    cmd.Parameters.AddWithValue("@Total_Price", totalPrice)
                    cmd.Parameters.AddWithValue("@Status", "Checked-Out")
                    cmd.Parameters.AddWithValue("@Date", dateOne)
                    cmd.Parameters.AddWithValue("@Arrival_Time", arrival)
                    cmd.Parameters.AddWithValue("@Departure_Time", departure)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Insert report success")
                End Using

                ' Query for Removing from the guest list
                Dim removeGuestQuery As String = "DELETE FROM tbl_guest WHERE Customer_ID = @Id"
                Using cmd As SqlCommand = New SqlCommand(removeGuestQuery, con)
                    cmd.Parameters.AddWithValue("@Id", checkOutId)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using


                ' Query for removing to checkout
                Dim delQuery As String = "DELETE FROM tbl_checkout WHERE Customer_ID = @id"
                Using cmd As SqlCommand = New SqlCommand(delQuery, con)
                    cmd.Parameters.AddWithValue("@id", checkOutId)
                    con.Open()
                    cmd.ExecuteNonQuery()

                    con.Close()
                    MsgBox("Delete Checkout success")

                End Using

                Dim roomNumberQuery As String = $"DELETE FROM [{roomNo}] WHERE Transact_ID = @Transact_ID"
                Using cmd As SqlCommand = New SqlCommand(roomNumberQuery, con)
                    cmd.Parameters.AddWithValue("@Transact_ID", transactId)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Updated Room Number")
                End Using

            Catch ex As Exception
                ' Handle the exception here
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clean up resources here
                con.Close()
                loadCheckOut()
                txtCheckOutId.Clear()
                txtCustomerName.Clear()
                txtCheckIn.Clear()
                txtCheckOut.Clear()
                txtStatus.Clear()
                txtTotalPrice.Clear()
                txtSearch.Clear()
            End Try
        End If

    End Sub

    Private Sub dgvCheckOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            txtCheckOutId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            txtCustomerName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            txtCheckIn.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            txtCheckOut.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            txtTotalPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            txtStatus.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            txtRoomNo.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            txtArrivalTime.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
        Else

        End If
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        loadCheckOut()
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Dim truncatedelete As String = "DELETE FROM tbl_checkout; Truncate table tbl_checkout"

        Using cmd As SqlCommand = New SqlCommand(truncatedelete, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim search As String = txtSearch.Text

            Dim query As String = "SELECT * FROM tbl_checkout WHERE Customer_Id LIKE @CustID OR Customer_Name LIKE @CustName OR Checked_In LIKE @checkedIn OR Checked_Out LIKE @checkedOut OR Room_No LIKE @roomNo OR Transact_ID"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@custID", "%" & search & "%")
                cmd.Parameters.AddWithValue("@CustName", "%" & search & "%")
                cmd.Parameters.AddWithValue("@checkedIn", "%" & search & "%")
                cmd.Parameters.AddWithValue("@checkedOut", "%" & search & "%")
                cmd.Parameters.AddWithValue("@roomNo", "%" & search & "%")

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Search Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class