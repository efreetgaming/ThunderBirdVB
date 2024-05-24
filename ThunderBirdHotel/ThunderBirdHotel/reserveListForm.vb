Imports System.Data.SqlClient

Public Class reserveListForm
    Private Sub reserveListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReserveList()
    End Sub

    Public Sub loadReserveList()
        Dim query As String = "Select * from tbl_reservation"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dgvReserveList.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub dgvReserveList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserveList.CellClick
        checkIn.txtName.Text = dgvReserveList.Rows(e.RowIndex).Cells(1).Value.ToString
        checkIn.txtNumber.Text = dgvReserveList.Rows(e.RowIndex).Cells(4).Value.ToString
        checkIn.txtEmail.Text = dgvReserveList.Rows(e.RowIndex).Cells(2).Value.ToString
        checkIn.txtAddress.Text = dgvReserveList.Rows(e.RowIndex).Cells(5).Value.ToString
        checkIn.dudAdult.Value = dgvReserveList.Rows(e.RowIndex).Cells(13).Value.ToString
        checkIn.dudChildren.Value = dgvReserveList.Rows(e.RowIndex).Cells(14).Value.ToString
        checkIn.dtpCheckIn.Value = dgvReserveList.Rows(e.RowIndex).Cells(10).Value
        checkIn.dtpCheckOut.Value = dgvReserveList.Rows(e.RowIndex).Cells(11).Value
        checkIn.redragon = dgvReserveList.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub
End Class