Imports System.Data.SqlClient

Public Class manageRooms

    Public Sub loadRooms()
        Try

            Dim query As String = "SELECT * FROM tbl_rooms"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvRooms.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub loadComboBoxRoomType()
        Dim uniqueValues As New List(Of String)

        con.Open()

        ' Retrieve unique values from the Room_Type column
        Dim query As String = "SELECT DISTINCT Room_Type FROM tbl_Rooms"
        Try
            Using cmd As SqlCommand = New SqlCommand(query, con)
                ' Execute the query and retrieve the unique values
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    uniqueValues.Add(reader("Room_Type").ToString())
                End While

                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        ' Bind the List to the ComboBox's DataSource property
        cmbRoomType.DataSource = uniqueValues
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtRoomId.TextLength = 0 Then
                MessageBox.Show("roomid shouldn't be empty")
            ElseIf txtRoomRate.TextLength = 0 Then
                MessageBox.Show("roomrate shouldn't be empty")
            Else
                Dim roomId As String = txtRoomId.Text
                Dim roomType As String = cmbRoomType.Text
                Dim roomRate As String = txtRoomRate.Text
                Dim guest As String = dudGuest.Text

                If roomIdPresent = roomId Then
                    MsgBox("The room is already existed")
                Else
                    If roomId = "" Or roomType = "" Or roomRate = "" Or guest = "" Then
                        MsgBox("Required field shouldn't be empty")
                    Else
                        Dim query As String = "INSERT INTO tbl_rooms (Room_No, Room_Type, Room_Rate, Max_Guest, Status) VALUES (@roomId, @roomType, @roomRate, @guest, @Status)"

                        Using cmd As SqlCommand = New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@roomId", roomId)
                            cmd.Parameters.AddWithValue("@roomType", roomType)
                            cmd.Parameters.AddWithValue("@roomRate", roomRate)
                            cmd.Parameters.AddWithValue("@guest", guest)
                            cmd.Parameters.AddWithValue("@Status", "Available")

                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                            loadRooms()

                            MsgBox("Insert Success")

                            txtRoomId.Clear()
                            txtRoomRate.Clear()
                            dudGuest.Value = 1
                        End Using
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            loadRooms()

            MsgBox("Insert Success")

            txtRoomId.Clear()
            txtRoomRate.Clear()
            dudGuest.Value = 1

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim search As String = txtSearch.Text

            Dim query = "SELECT Room_No, Room_Type, Room_Rate, Max_Guest, Status FROM tbl_rooms WHERE Room_No LIKE @roomNo OR Room_Type LIKE @roomType OR Room_Rate LIKE @roomRate OR Max_Guest LIKE @guest OR Status LIKE @status"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@roomNo", "%" & search & "%")
                cmd.Parameters.AddWithValue("@roomType", "%" & search & "%")
                cmd.Parameters.AddWithValue("@roomRate", "%" & search & "%")
                cmd.Parameters.AddWithValue("@guest", "%" & search & "%")
                cmd.Parameters.AddWithValue("@status", "%" & search & "%")

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvRooms.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRooms.CellClick
        Try
            If e.RowIndex >= 0 Then
                txtRoomId.Text = dgvRooms.Rows(e.RowIndex).Cells(0).Value.ToString
                cmbRoomType.Text = dgvRooms.Rows(e.RowIndex).Cells(1).Value.ToString
                txtRoomRate.Text = dgvRooms.Rows(e.RowIndex).Cells(5).Value.ToString
                dudGuest.Text = dgvRooms.Rows(e.RowIndex).Cells(6).Value.ToString
                roomIdPresent = txtRoomId.Text
                txtRoomId.Enabled = False
            Else
                ' Empty
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public roomIdPresent As String
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim roomId As String = txtRoomId.Text
            Dim roomType As String = cmbRoomType.Text
            Dim roomRate As String = txtRoomRate.Text
            Dim guest As String = dudGuest.Text

            If roomId = "" Or roomType = "" Or roomRate = "" Or guest = "" Then
                MsgBox("Required field shouldn't be empty")
            Else
                Dim query As String = "UPDATE tbl_rooms SET Room_Type = @roomType, Room_Rate = @roomRate, Max_Guest = @guest WHERE Room_No = @roomId"

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@roomId", roomId)
                    cmd.Parameters.AddWithValue("@roomType", roomType)
                    cmd.Parameters.AddWithValue("@roomRate", roomRate)
                    cmd.Parameters.AddWithValue("@guest", guest)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

            loadRooms()
            MsgBox("Update Success")

            txtRoomId.Enabled = True
            txtRoomId.Clear()

            txtRoomRate.Clear()
            dudGuest.Value = 1

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim roomId As String = txtRoomId.Text

            If roomId = "" Then
                MsgBox("Select a room to delete")
            Else
                Dim query As String = "DELETE FROM tbl_rooms WHERE Room_No = @roomId"

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@roomId", roomId)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Deleted Succesful")
                    loadRooms()

                    txtRoomId.Enabled = True
                    txtRoomId.Clear()

                    txtRoomRate.Clear()
                    dudGuest.Value = 1
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            MsgBox("Deleted Succesful")
            loadRooms()

            txtRoomId.Enabled = True
            txtRoomId.Clear()

            txtRoomRate.Clear()
            dudGuest.Value = 1

        End Try
    End Sub

    Private Sub txtRoomId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoomId.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                If Not e.KeyChar = ControlChars.Back Then
                    e.Handled = True
                End If
            End If

            If txtRoomId.TextLength >= 4 Then
                If e.KeyChar = ControlChars.Back Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtRoomRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoomRate.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                If Not e.KeyChar = ControlChars.Back Then
                    e.Handled = True
                End If
            End If

            If txtRoomRate.TextLength >= 5 Then
                If e.KeyChar = ControlChars.Back Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRoomId.Enabled = True
        txtRoomId.Clear()
        txtRoomRate.Clear()
        dudGuest.Value = 1
    End Sub

    Private Sub manageRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRooms()
        loadComboBoxRoomType()
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tmrUpdateDB_Tick(sender As Object, e As EventArgs) Handles tmrUpdateDB.Tick
        loadRooms()
    End Sub
End Class