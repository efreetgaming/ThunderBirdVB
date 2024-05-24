Imports System.Data.SqlClient
Imports System.Reflection

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
        If txtCustomerId.Text = "" Then
            MsgBox("Click an item to the list first")
        Else
            Try
                Dim custId As String = txtCustomerId.Text
                Dim custName As String = txtCustomerName.Text
                Dim checkIn As String = txtCheckIn.Text
                Dim checkOut As String = txtCheckOut.Text
                Dim totalPrice As String = txtTotalPrice.Text
                Dim dateOne As String = DateTime.Now.ToString("yyyy-MM-dd")

                ' Query for removing to checkout
                Dim delQuery As String = "DELETE FROM tbl_checkout WHERE Customer_Name = @Cust_Name"
                Using cmd As SqlCommand = New SqlCommand(delQuery, con)
                    cmd.Parameters.AddWithValue("@Cust_Name", custName)
                    con.Open()
                    cmd.ExecuteNonQuery()

                    con.Close()
                    MsgBox("Delete Checkout success")
                    loadCheckOut()
                End Using

                ' Query for reports
                Dim query As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date)"
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Name", custName)
                    cmd.Parameters.AddWithValue("@Checked_In", checkIn)
                    cmd.Parameters.AddWithValue("@Checked_Out", checkOut)
                    cmd.Parameters.AddWithValue("@Total_Price", totalPrice)
                    cmd.Parameters.AddWithValue("@Status", "Checked-Out")
                    cmd.Parameters.AddWithValue("@Date", dateOne)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Insert report success")
                End Using

                ' Query for Changing the Available of room
                Dim updateQuery As String = "UPDATE tbl_rooms SET Guest_Name = NULL, Phone_No = NULL, Status = @avail WHERE Room_No = @roomNo"

                Using cmd As SqlCommand = New SqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@avail", "Available")
                    cmd.Parameters.AddWithValue("@roomNo", custId)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Update Room success")

                    txtCustomerId.Clear()
                    txtCustomerName.Clear()
                    txtCheckIn.Clear()
                    txtCheckOut.Clear()
                    txtStatus.Clear()
                    txtTotalPrice.Clear()
                    txtSearch.Clear()
                End Using
            Catch ex As Exception
                ' Handle the exception here
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clean up resources here
                con.Close()
            End Try
        End If


    End Sub

    Private Sub dgvCheckOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Get the values from the selected row
            txtCustomerId.Text = row.Cells(0).Value.ToString()
            txtCustomerName.Text = row.Cells(1).Value.ToString()
            txtCheckIn.Text = row.Cells(2).Value.ToString()

            txtCheckOut.Text = row.Cells(3).Value.ToString()
            txtTotalPrice.Text = row.Cells(4).Value.ToString()
        Else

        End If
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        loadCheckOut()
    End Sub
End Class