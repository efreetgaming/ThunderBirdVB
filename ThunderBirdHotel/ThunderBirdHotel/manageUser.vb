Imports System.Data.SqlClient

Public Class manageUser

    Public Sub loadUser()
        Try

            Dim query As String = "SELECT * FROM tbl_users"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvUsers.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub manageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUser()
        txtName.Clear()
        txtPassword.Clear()
        txtUname.Clear()
        drpRole.SelectedIndex = -1
        id = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtName.TextLength = 0 Then
                MessageBox.Show("Name shouldn't be empty")
            ElseIf txtUname.TextLength = 0 Then
                MessageBox.Show("Username shouldn't be empty")
            ElseIf txtPassword.TextLength = 0 Then
                MessageBox.Show("Password shouldn't be empty")
            Else

                Dim name As String = txtName.Text
                Dim uname As String = txtUname.Text
                Dim pword As String = txtPassword.Text
                Dim type As String = drpRole.Text

                If name = "" Or uname = "" Or pword = "" Or type = "" Then
                    MsgBox("Please fill all the required fields")

                Else
                    Dim query As String = "INSERT INTO tbl_users (Name, Username, Password, Type) VALUES (@Name, @Username, @Password, @Type)"

                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Name", name)
                        cmd.Parameters.AddWithValue("@Username", uname)
                        cmd.Parameters.AddWithValue("@Password", pword)
                        cmd.Parameters.AddWithValue("@Type", type)

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        txtName.Clear()
                        txtPassword.Clear()
                        txtUname.Clear()
                        drpRole.SelectedIndex = -1
                        id = ""

                        MsgBox("Successful")
                        loadUser()
                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            txtName.Clear()
            txtPassword.Clear()
            txtUname.Clear()
            drpRole.SelectedIndex = -1
            id = ""

            MsgBox("Successful")
            loadUser()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim search As String = txtSearch.Text

            Dim query As String = "SELECT * FROM tbl_users WHERE Name Like @Name OR Username Like @Username or Type Like @Type"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", "%" & search & "%")
                cmd.Parameters.AddWithValue("@Username", "%" & search & "%")
                cmd.Parameters.AddWithValue("@Type", "%" & search & "%")
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvUsers.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public id As String
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim name As String = txtName.Text
            Dim uname As String = txtUname.Text
            Dim pword As String = txtPassword.Text
            Dim type As String = drpRole.Text

            If name = "" Or uname = "" Or pword = "" Or type = "" Then
                MsgBox("It shouldn't be empty required fields")
            Else
                Dim query As String = "UPDATE tbl_users set Name = @Name, Username = @Username, Password = @Password, Type = @Type WHERE id = @Id"

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Id", id)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Username", uname)
                    cmd.Parameters.AddWithValue("@Password", pword)
                    cmd.Parameters.AddWithValue("@Type", type)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    loadUser()

                    txtName.Clear()
                    txtPassword.Clear()
                    txtUname.Clear()
                    drpRole.SelectedIndex = -1
                    id = ""
                    btnSave.Enabled = True

                    MsgBox("Update Success")
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            loadUser()

            txtName.Clear()
            txtPassword.Clear()
            txtUname.Clear()
            drpRole.SelectedIndex = -1
            id = ""
            btnSave.Enabled = True

            MsgBox("Update Success")

        End Try

    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        Try
            If e.RowIndex >= 0 Then
                id = dgvUsers.Rows(e.RowIndex).Cells(0).Value.ToString
                txtName.Text = dgvUsers.Rows(e.RowIndex).Cells(1).Value.ToString
                txtUname.Text = dgvUsers.Rows(e.RowIndex).Cells(2).Value.ToString
                txtPassword.Text = dgvUsers.Rows(e.RowIndex).Cells(3).Value.ToString
                drpRole.Text = dgvUsers.Rows(e.RowIndex).Cells(4).Value.ToString
                btnSave.Enabled = False
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim name As String = txtName.Text
            Dim uname As String = txtUname.Text
            Dim pword As String = txtPassword.Text
            Dim type As String = drpRole.Text

            If name = "" Or uname = "" Or pword = "" Or type = "" Then
                MsgBox("It shouldn't be empty required fields")
            Else
                Dim query As String = "DELETE FROM tbl_users WHERE ID = @Id"

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Id", id)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    loadUser()

                    txtName.Clear()
                    txtPassword.Clear()
                    txtUname.Clear()
                    drpRole.SelectedIndex = -1
                    id = ""

                    MsgBox("Deleted Success")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            loadUser()

            txtName.Clear()
            txtPassword.Clear()
            txtUname.Clear()
            drpRole.SelectedIndex = -1
            id = ""

            MsgBox("Deleted Success")

        End Try
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Try
            If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
            End If

            If txtName.TextLength >= 24 Then
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

    Private Sub txtUname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUname.KeyPress
        Try
            If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsNumber(e.KeyChar) Then
                If Not e.KeyChar = ControlChars.Back Then
                    e.Handled = True
                End If
            End If

            If txtUname.TextLength >= 15 Then
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

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        Try
            If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
            End If

            If txtPassword.TextLength >= 24 Then
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
        txtName.Clear()
        txtPassword.Clear()
        txtUname.Clear()
        drpRole.SelectedIndex = -1
        id = ""
        btnSave.Enabled = True
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click

    End Sub
End Class