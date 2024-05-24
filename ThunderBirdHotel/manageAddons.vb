Imports System.Data.SqlClient

Public Class manageAddons

    Public id As String
    Public Sub loadAddon()
        Try
            Dim query As String = "SELECT * FROM tbl_addon"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvAddon.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub manageAddons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAddon()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtAddOn.TextLength = 0 Then
                MessageBox.Show("Addon shouldn't be empty")
            ElseIf txtPrice.TextLength = 0 Then
                MessageBox.Show("Price shouldn't be empty")
            Else
                Dim adding As String = txtAddOn.Text
                Dim presyo As String = txtPrice.Text

                If adding = "" Or presyo = "" Then
                    MsgBox("Required field shouldn't be empty")
                Else
                    Dim query As String = "INSERT INTO tbl_addon (Name, Price) VALUES (@Name, @Price)"

                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Name", adding)
                        cmd.Parameters.AddWithValue("@Price", presyo)

                        con.Open()
                        cmd.ExecuteNonQuery()

                    End Using
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

            id = ""
            txtAddOn.Clear()
            txtPrice.Clear()

            MsgBox("Insert Success")

            loadAddon()
        End Try
    End Sub

    Private Sub dgvAddon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddon.CellClick
        Try
            If e.RowIndex >= 0 Then
                id = dgvAddon.Rows(e.RowIndex).Cells(0).Value.ToString
                txtAddOn.Text = dgvAddon.Rows(e.RowIndex).Cells(1).Value.ToString
                txtPrice.Text = dgvAddon.Rows(e.RowIndex).Cells(2).Value.ToString
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim search As String = txtSearch.Text

            Dim query As String = "SELECT * FROM tbl_addon WHERE Name LIKE @name OR Price LIKE @price"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", "%" & search & "%")
                cmd.Parameters.AddWithValue("@price", "%" & search & "%")
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvAddon.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim addOn As String = txtAddOn.Text
            Dim price As String = txtPrice.Text

            If id = "" Then
                MsgBox("Select an Item first")
            Else
                If addOn = "" Or price = "" Then
                    MsgBox("Required should not be empty")
                Else
                    Dim query As String = "UPDATE tbl_addon SET Name = @name, Price = @price WHERE Id = @Id"

                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Id", id)
                        cmd.Parameters.AddWithValue("@name", addOn)
                        cmd.Parameters.AddWithValue("@price", price)

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        id = ""
                        txtAddOn.Clear()
                        txtPrice.Clear()

                        loadAddon()
                        MsgBox("Update Success")
                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

            id = ""
            txtAddOn.Clear()
            txtPrice.Clear()

            loadAddon()
            MsgBox("Update Success")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If id = "" Then
                MsgBox("Select an item to delete")
            Else
                Dim query As String = "DELETE FROM tbl_addon WHERE Id = @id"

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

            id = ""
            txtAddOn.Clear()
            txtPrice.Clear()

            loadAddon()
            MsgBox("Delete Success")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        id = ""
        txtAddOn.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub txtAddOn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddOn.KeyPress
        Try
            If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
            End If

            If txtAddOn.TextLength >= 24 Then
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

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                If Not e.KeyChar = ControlChars.Back Then
                    e.Handled = True
                End If
            End If

            If txtPrice.TextLength >= 5 Then
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

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtAddOn_TextChanged(sender As Object, e As EventArgs) Handles txtAddOn.TextChanged

    End Sub
End Class