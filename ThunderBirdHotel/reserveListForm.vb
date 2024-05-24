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
        Dim now As Date = Date.Today
        If dgvReserveList.Rows(e.RowIndex).Cells(10).Value <> now Then
            MsgBox("Didnt expect to come early")
        Else
            checkIn.dtpCheckIn.Value = dgvReserveList.Rows(e.RowIndex).Cells(10).Value
            checkIn.txtName.Text = dgvReserveList.Rows(e.RowIndex).Cells(1).Value.ToString
            checkIn.txtNumber.Text = dgvReserveList.Rows(e.RowIndex).Cells(4).Value.ToString
            checkIn.txtEmail.Text = dgvReserveList.Rows(e.RowIndex).Cells(2).Value.ToString
            checkIn.txtAddress.Text = dgvReserveList.Rows(e.RowIndex).Cells(5).Value.ToString
            checkIn.dudAdult.Value = dgvReserveList.Rows(e.RowIndex).Cells(13).Value.ToString
            checkIn.dudChildren.Value = dgvReserveList.Rows(e.RowIndex).Cells(14).Value.ToString
            checkIn.dtpCheckOut.Value = dgvReserveList.Rows(e.RowIndex).Cells(11).Value
            checkIn.redragon = dgvReserveList.Rows(e.RowIndex).Cells(0).Value.ToString
            checkIn.lblRoomRate.Text = dgvReserveList.Rows(e.RowIndex).Cells(18).Value.ToString
            checkIn.lblRoomType.Text = dgvReserveList.Rows(e.RowIndex).Cells(12).Value
            checkIn.txtDownpayment.Text = dgvReserveList.Rows(e.RowIndex).Cells(17).Value.ToString
            checkIn.lblRoomNo.Text = dgvReserveList.Rows(e.RowIndex).Cells(19).Value.ToString

            'checkIn.lblRoomNo.Text = "Select A Room No"

            Try
                Dim inTime As DateTime = Convert.ToDateTime(dgvReserveList.Rows(e.RowIndex).Cells(10).Value)
                Dim outTime As DateTime = Convert.ToDateTime(dgvReserveList.Rows(e.RowIndex).Cells(11).Value)
                Dim subtract As String
                Dim lakshimi As String
                If outTime >= inTime Then
                    subtract = outTime.Subtract(inTime).TotalHours / 24
                    lakshimi = subtract
                    'MsgBox("Lakshimi - " & lakshimi)
                    If checkIn.lblRoomRatingRoom.Text = "0" Then

                    Else
                        Dim normalRoomRate As Double = CDbl(checkIn.lblRoomRatingRoom.Text)
                        'MsgBox("Room Rate : " & normalRoomRate)
                        checkIn.lblRoomRate.Text = normalRoomRate * lakshimi
                        'MsgBox("Spanning : " & lakshimi.ToString)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class