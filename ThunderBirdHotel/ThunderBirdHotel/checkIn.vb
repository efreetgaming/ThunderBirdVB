Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class checkIn

    Public selectedRoomType As String
    Private dt As New DataTable()
    Public redragon As String

    Private Sub checkIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkin As Date = dtpCheckIn.Value
        dtpCheckIn.MinDate = Date.Today
        dtpCheckOut.MinDate = Date.Today
        dtpCheckOut.Value = checkin.AddDays(1)

        lakshimi = 1

        txtNumber.Text = "09"

        dt = New DataTable()

        ' Add columns to the DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Quantity", GetType(String))
        dt.Columns.Add("Total", GetType(Double))

        ' Set the DataSource property of the DataGridView control to the DataTable object
        dgvAddon.DataSource = dt

        loadAddonList()
    End Sub

    Public Sub loadAddonList()
        Try
            Dim query As String = "SELECT * FROM tbl_addon"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvAddonList.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public lakshimi As Double
    Public roomRateT As Double

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim emailRegex As New Regex(emailPattern)

        If txtName.TextLength = 0 Then
            MessageBox.Show("Name shouldn't be empty")
        ElseIf txtAddress.TextLength = 0 Then
            MessageBox.Show("Address shouldn't be empty")
        ElseIf txtEmail.TextLength = 0 Or Not emailRegex.IsMatch(txtEmail.Text) Then
            MessageBox.Show("Email shouldn't be empty or it should be valid email")
        ElseIf txtNumber.TextLength <= 10 Then
            MessageBox.Show("Number Shouldn't be empty")
        ElseIf drpGender.SelectedIndex = -1 Then
            MessageBox.Show("Select a gender first")
        ElseIf dudAdult.Value = 0 Then
            MessageBox.Show("Determine how many guest is in")
        ElseIf lblRoomNo.Text = "" Then
            MessageBox.Show("Select a Room No.")
        ElseIf txtPayment.Text = "" Then
            MessageBox.Show("Input a money first")
        Else
            Dim Customer_Name As String = txtName.Text
            Dim Phone_No As String = txtNumber.Text
            Dim Email As String = txtEmail.Text
            Dim Address As String = txtAddress.Text
            Dim No_Of_Adults As String = dudAdult.Text
            Dim No_Of_Children As String = dudChildren.Text
            Dim Gender As String = drpGender.Text
            Dim Check_In As String = dtpCheckIn.Value.Year & "-" & dtpCheckIn.Value.Month & "-" & dtpCheckIn.Value.Day
            Dim Check_Out As String = dtpCheckOut.Value.Year & "-" & dtpCheckOut.Value.Month & "-" & dtpCheckOut.Value.Day
            Dim Room_No As String = lblRoomNo.Text
            Dim payment As Double = txtPayment.Text
            Dim change As Double = txtChange.Text
            Dim totalPrice As Integer = txtTotalPrice.Text


            If payment < totalPrice Then
                MsgBox("Not enough Money")
            Else
                ' Query for Guest
                Dim queryGuest As String = "INSERT INTO tbl_guest (Customer_Name, Gender, Email_Address, Address, No_Of_Adults, No_Of_Children, Phone_No, Checked_In) " & "VALUES (@Customer_Name, @Gender, @Email_Address, @Address, @No_Of_Adults, @No_Of_Children, @Phone_No, @Checked_In)"
                Try

                    Using cmd As SqlCommand = New SqlCommand(queryGuest, con)
                        cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                        cmd.Parameters.AddWithValue("@Gender", Gender)
                        cmd.Parameters.AddWithValue("@Email_Address", Email)
                        cmd.Parameters.AddWithValue("@Address", Address)
                        cmd.Parameters.AddWithValue("@No_Of_Adults", No_Of_Adults)
                        cmd.Parameters.AddWithValue("@No_Of_Children", No_Of_Children)
                        cmd.Parameters.AddWithValue("@Phone_No", Phone_No)
                        cmd.Parameters.AddWithValue("@Checked_In", Check_In)

                        con.Open()
                        cmd.ExecuteNonQuery()

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()

                    txtName.Clear()
                    txtNumber.Clear()
                    txtEmail.Clear()
                    txtAddress.Clear()
                End Try

                ' Query for Room
                Dim fixQueryRoom As String = "Update tbl_rooms Set Guest_Name = @Customer_Name, Phone_No = @Phone_No, Status = @Status Where Room_No = @Room_No"
                Try
                    Using cmd As SqlCommand = New SqlCommand(fixQueryRoom, con)
                        cmd.Parameters.AddWithValue("@Room_No", Room_No)
                        cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                        cmd.Parameters.AddWithValue("@Phone_No", Phone_No)
                        cmd.Parameters.AddWithValue("@Status", "Unavailable")

                        con.Open()
                        cmd.ExecuteNonQuery()

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try


                ' Query for Report
                Dim dateNow As String

                dateNow = dtpDate.Value.Year & "-" & dtpDate.Value.Month & "-" & dtpDate.Value.Day

                Dim reportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date)"

                Try
                    Using cmd As SqlCommand = New SqlCommand(reportQuery, con)
                        cmd.Parameters.AddWithValue("@Name", Customer_Name)
                        cmd.Parameters.AddWithValue("@Checked_In", Check_In)
                        cmd.Parameters.AddWithValue("@Checked_Out", Check_Out)
                        cmd.Parameters.AddWithValue("@Total_Price", totalPrice)
                        cmd.Parameters.AddWithValue("@Status", "Checked-In")
                        cmd.Parameters.AddWithValue("@Date", dateNow)

                        con.Open()
                        cmd.ExecuteNonQuery()


                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try


                ' Query for Check Out

                Dim checkOutQuery As String = "INSERT INTO tbl_checkout (Customer_Name, Checked_In, Checked_Out, Total_Price, Status, Date) VALUES (@Customer_Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date)"
                Try
                    Using cmd As SqlCommand = New SqlCommand(checkOutQuery, con)
                        cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                        cmd.Parameters.AddWithValue("@Total_Price", totalPrice)
                        cmd.Parameters.AddWithValue("@Checked_In", Check_In)
                        cmd.Parameters.AddWithValue("@Checked_Out", Check_Out)
                        cmd.Parameters.AddWithValue("@Status", "Checked-In")
                        cmd.Parameters.AddWithValue("@Date", Check_Out)

                        con.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()

                    lblRoomNo.Text = "Select a Room Type First"
                    lblRoomType.Text = "Select a Room Type First"
                    lblRoomRate.Text = "0"
                    lblAddonItem.Text = "Select a Addon Item first"
                    txtPayment.Clear()
                    txtTotalPriceNoVat.Clear()
                    txtChange.Clear()
                    txtVat.Clear()
                    txtTotalPrice.Clear()
                End Try

                ' Query for checking the customer in the Reserve List
                Dim deleteReserveQuery As String = "DELETE FROM tbl_reservation WHERE ID = @id"
                Using cmd As SqlCommand = New SqlCommand(deleteReserveQuery, con)
                    cmd.Parameters.AddWithValue("@id", redragon)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using


                MsgBox("Succees")
            End If
        End If
    End Sub

    ' Condition to Each Text

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If txtName.TextLength >= 24 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        ' Only allow letters, spaces, and periods as special characters
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " " OrElse e.KeyChar = ".") AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If txtNumber.TextLength >= 11 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Back) AndAlso txtNumber.TextLength <= 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        If txtAddress.TextLength >= 75 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAvailRoom_Click(sender As Object, e As EventArgs) Handles btnAvailRoom.Click
        roomAvailability.Show()
    End Sub




    Public idAddon As String
    Public addonName As String
    Public addonPrice As Double
    Public originalPrice As Integer
    Private Sub dgvAddonList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddonList.CellClick
        Try
            If e.RowIndex >= 0 Then
                idAddon = dgvAddonList.Rows(e.RowIndex).Cells(0).Value
                addonName = dgvAddonList.Rows(e.RowIndex).Cells(1).Value.ToString
                ' Get the addonPrice from the DataGridView instead of using the original list
                addonPrice = CDbl(dgvAddonList.Rows(e.RowIndex).Cells(2).Value)
                lblAddonItem.Text = "Items - " & addonName
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddon_Click(sender As Object, e As EventArgs) Handles btnAddon.Click
        Try
            Dim id As String = idAddon
            Dim name As String = addonName
            Dim addonQuantity As String = nupdQuantity.Value
            Dim total As String = nupdQuantity.Value * addonPrice

            If id = listIDAddon Then
                MsgBox("Already added")
            Else
                Dim newRow As DataRow = dt.NewRow()

                newRow("ID") = id
                newRow("Name") = name
                newRow("Quantity") = addonQuantity
                newRow("Total") = total
                dt.Rows.Add(newRow)
            End If

            listIDAddon = ""
            listNameAddon = ""
            idAddon = ""
            addonName = ""
            addonPrice = 0
            lblAddonItem.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim name As String = listNameAddon
            Dim addonQuantity As Double = CDbl(nupdQuantity.Value)

            Dim total As Double = addonQuantity * addonPrice

            Dim row As DataRow = dt.Select("ID = " & listIDAddon).FirstOrDefault
            row("Name") = name
            row("Quantity") = addonQuantity
            row("total") = total

            listIDAddon = ""
            listNameAddon = ""
            idAddon = ""
            addonName = ""
            addonPrice = 0
            btnAddon.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public listIDAddon As Object
    Public listNameAddon As String
    Private Sub dgvAddon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddon.CellClick
        Try
            If dgvAddon.Rows.Count < 1 Then
                MessageBox.Show("The DataGridView is empty.")
            Else
                If e.RowIndex >= 0 Then
                    listIDAddon = dgvAddon.Rows(e.RowIndex).Cells(0).Value.ToString
                    listNameAddon = dgvAddon.Rows(e.RowIndex).Cells(1).Value.ToString
                    nupdQuantity.Value = dgvAddon.Rows(e.RowIndex).Cells(2).Value.ToString
                    ' Use e.RowIndex to access the value from the DataGridView
                    addonPrice = CDbl(dgvAddon.Rows(e.RowIndex).Cells(3).Value)
                    MsgBox("Cart addon - " & addonPrice)
                    btnAddon.Enabled = False
                Else
                    MessageBox.Show("Please select a row in the DataGridView.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearAddon_Click(sender As Object, e As EventArgs) Handles btnClearAddon.Click
        listIDAddon = ""
        listNameAddon = ""
        idAddon = ""
        addonName = ""
        addonPrice = 0
        MsgBox("Cleared Selection to Add-On List and Add-on Cart")
        btnAddon.Enabled = True
        lblAddonItem.Text = "Select First item first"
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim yourIdAddon As Object = listIDAddon
        Try

            If listIDAddon.ToString = "" Then
                MsgBox("Select an item you want to remove to addons cart")
            Else
                Dim row As DataRow = dt.Select("ID = " & yourIdAddon).FirstOrDefault()

                ' Check if the row exists
                If row IsNot Nothing Then
                    ' Remove the row
                    row.Delete()
                    listIDAddon = ""
                    listNameAddon = ""
                    idAddon = ""
                    addonName = ""
                    addonPrice = 0
                    btnAddon.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nupdQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nupdQuantity.ValueChanged
        nupdQuantity.Maximum = 3
        nupdQuantity.Minimum = 0
    End Sub

    Private Sub dudChildren_ValueChanged(sender As Object, e As EventArgs) Handles dudChildren.ValueChanged
        dudChildren.Maximum = 4
        dudChildren.Minimum = 0
    End Sub

    Private Sub dudAdult_ValueChanged(sender As Object, e As EventArgs) Handles dudAdult.ValueChanged
        dudAdult.Maximum = 4
        dudAdult.Minimum = 1
    End Sub
    Public passedRoomRate As Double = CDbl(roomAvailability.RoomRate)

    Public Sub updateRoomRate()
        Try
            Dim inTime As DateTime = Convert.ToDateTime(dtpCheckIn.Text)
            Dim outTime As DateTime = Convert.ToDateTime(dtpCheckOut.Text)

            If outTime >= inTime Then
                lblSubtractDate.Text = outTime.Subtract(inTime).TotalHours / 24
                lakshimi = lblSubtractDate.Text
                'MsgBox("Lakshimi - " & lakshimi)
                If lblRoomRatingRoom.Text = "0" Then

                Else
                    Dim normalRoomRate As Double = CDbl(lblRoomRatingRoom.Text)
                    'MsgBox("Room Rate : " & normalRoomRate)
                    lblRoomRate.Text = normalRoomRate * lakshimi
                    'MsgBox("Spanning : " & lakshimi.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        updateRoomRate()
    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        Try
            Dim inTime As DateTime = Convert.ToDateTime(dtpCheckIn.Text)
            Dim outtime As DateTime = Convert.ToDateTime(dtpCheckOut.Text)

            If inTime >= outtime Then
                MsgBox("Check in date shouldn't be ahead to check out date")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim roomRate As Decimal = CDec(lblRoomRate.Text)
            Dim vat As Decimal = 0.12D
            Dim addonTotal As Decimal = 0D

            For Each row As DataGridViewRow In dgvAddon.Rows
                If Not row.IsNewRow Then
                    addonTotal += CDec(row.Cells("Total").Value)
                End If
            Next

            Dim totalWithoutVat As Decimal = roomRate + addonTotal
            Dim vatAmount As Decimal = totalWithoutVat * vat
            Dim totalWithVat As Decimal = totalWithoutVat + vatAmount

            txtVat.Text = vatAmount.ToString("N2")
            txtTotalPrice.Text = totalWithVat.ToString("N2")
            txtTotalPriceNoVat.Text = totalWithoutVat.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        Try
            If txtPayment.Text = "" Then

            Else
                If txtTotalPrice.Text = "" Then
                Else
                    Dim payment As Double = txtPayment.Text
                    Dim totalprice As Double = txtTotalPrice.Text

                    txtChange.Text = payment - totalprice
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPayment.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                Exit Sub
            End If

            If txtPayment.TextLength > 9 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtNumber.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtTotalPrice.Clear()
        txtVat.Clear()
        txtTotalPriceNoVat.Clear()
        txtPayment.Clear()
        txtChange.Clear()
    End Sub

    Private Sub btnReserved_Click(sender As Object, e As EventArgs) Handles btnReserved.Click
        reserveListForm.Show()
    End Sub
End Class