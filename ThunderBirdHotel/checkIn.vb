Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class checkIn

    Public selectedRoomType As String
    Private dt As New DataTable()
    Public redragon As String

    Private Sub checkIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkin As Date = dtpCheckIn.Value
        dtpCheckIn.MinDate = Date.Today
        dtpCheckIn.MaxDate = Date.Today
        dtpCheckOut.MinDate = Date.Today
        dtpCheckOut.Value = checkin.AddDays(1)
        dtpDepartureTime.Value = DateTime.Parse("12:00 PM")

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
        Dim calculationNupd As Integer = dudAdult.Value + dudChildren.Value

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
        ElseIf calculationNupd > 2 Then
            MessageBox.Show("Add Extra Person and Extra Person since the minimum guest is 2")
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

            ' Arrival Time And Departure Time
            Dim Arrival_Time As DateTime = dtpArrivalTime.Value
            Dim realArrival_Time As TimeSpan = New TimeSpan(Arrival_Time.Hour, Arrival_Time.Minute, Arrival_Time.Second)
            Dim vrealArrival_Time As String = realArrival_Time.ToString

            Dim Departure_Time As DateTime = dtpArrivalTime.Value
            Departure_Time = New DateTime(Departure_Time.Year, Departure_Time.Month, Departure_Time.Day, 12, 0, 0)

            Dim realDeparture_Time As TimeSpan = New TimeSpan(Departure_Time.Hour, Departure_Time.Minute, Departure_Time.Second)
            Dim vrealDeparture_time As String = realDeparture_Time.ToString

            Dim Room_Type As String = lblRoomType.Text
            Dim Number_of_Person As String
            Dim plus_guest As String = CInt(dudAdult.Text) + CInt(No_Of_Children)
            Number_of_Person = plus_guest
            Dim Total_Amount As String = txtTotalPrice.Text
            Dim Total_No_Vat As String = txtTotalPriceNoVat.Text
            Dim VAT As String = txtVat.Text

            ' Transaction ID
            Dim random As New Random()
            Dim transactId As String = Convert.ToInt64(random.NextDouble() * (99999999999999 - 10000000000000) + 10000000000000)


            If payment < totalPrice Then
                MsgBox("Not enough Money")
            Else
                If lblRoomNo.Text = "Select A Room No" Or lblRoomNo.Text = "Select a Room Type First" Then
                    MsgBox("Select A Room No First")
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
                        MessageBox.Show("Error In Guest: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()

                        txtName.Clear()
                        txtNumber.Clear()
                        txtEmail.Clear()
                        txtAddress.Clear()
                    End Try

                    ' Addons of user
                    DisplayValuesInMessageBox()

                    ' Query for Room
                    Dim fixQueryRoom As String = "Update tbl_rooms Set Guest_Name = @Customer_Name, Phone_No = @Phone_No, Status = @Status, Extras = @Extras, Arrival_Time = @Arrival_Time, Departure_Time = @Departure_Time, Date = @date Where Room_No = @Room_No"
                    Try
                        Using cmd As SqlCommand = New SqlCommand(fixQueryRoom, con)
                            cmd.Parameters.AddWithValue("@Room_No", Room_No)
                            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                            cmd.Parameters.AddWithValue("@Phone_No", Phone_No)
                            cmd.Parameters.AddWithValue("@Status", "Unavailable")
                            cmd.Parameters.AddWithValue("@Extras", message)
                            cmd.Parameters.AddWithValue("@Arrival_Time", dtpArrivalTime.Value)
                            cmd.Parameters.AddWithValue("@Departure_Time", dtpDepartureTime.Value)
                            cmd.Parameters.AddWithValue("@date", Check_In)

                            con.Open()
                            cmd.ExecuteNonQuery()

                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Room Error : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                    End Try


                    ' Query for Report
                    Dim dateNow As String
                    Dim arrival As String
                    Dim departure As String

                    dateNow = dtpDate.Value.Year & "-" & dtpDate.Value.Month & "-" & dtpDate.Value.Day
                    arrival = dtpArrivalTime.Value.ToString("HH:mm:ss")
                    departure = dtpDepartureTime.Value.ToString("12:00:00")

                    Dim reportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date, Arrival_Time, Departure_Time) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date, @Arrival_Time, @Departure_Time)"

                    Try
                        Using cmd As SqlCommand = New SqlCommand(reportQuery, con)
                            cmd.Parameters.AddWithValue("@Name", Customer_Name)
                            cmd.Parameters.AddWithValue("@Checked_In", Check_In)
                            cmd.Parameters.AddWithValue("@Checked_Out", Check_Out)
                            cmd.Parameters.AddWithValue("@Total_Price", totalPrice)
                            cmd.Parameters.AddWithValue("@Status", "Checked-In")
                            cmd.Parameters.AddWithValue("@Date", dateNow)
                            cmd.Parameters.AddWithValue("@Arrival_Time", arrival)
                            cmd.Parameters.AddWithValue("@Departure_Time", departure)

                            con.Open()
                            cmd.ExecuteNonQuery()

                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Report : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                    End Try


                    ' Query for Check Out

                    Dim checkOutQuery As String = "INSERT INTO tbl_checkout (Customer_Name, Checked_In, Checked_Out, Total_Price, Status, Date, Room_No, Arrival_Time, Departure_Time, Transact_ID) VALUES (@Customer_Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date, @Room_No, @Arrival_Time, @Departure_Time, @Transact_ID)"
                    Try
                        Using cmd As SqlCommand = New SqlCommand(checkOutQuery, con)
                            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                            cmd.Parameters.AddWithValue("@Total_Price", totalPrice)
                            cmd.Parameters.AddWithValue("@Checked_In", Check_In)
                            cmd.Parameters.AddWithValue("@Checked_Out", Check_Out)
                            cmd.Parameters.AddWithValue("@Status", "Checked-In")
                            cmd.Parameters.AddWithValue("@Date", Check_Out)
                            cmd.Parameters.AddWithValue("@Room_No", lblRoomNo.Text)
                            cmd.Parameters.AddWithValue("@Arrival_Time", arrival)
                            cmd.Parameters.AddWithValue("@Departure_Time", departure)
                            cmd.Parameters.AddWithValue("@Transact_ID", transactId)

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
                        txtNumber.Text = "09"
                        lblAddonItem.Text = "Select a Addon Item first"
                        lblMaxGuest.Text = "0"
                        txtDownpayment.Text = ""
                        txtPayment.Clear()
                        txtTotalPriceNoVat.Clear()
                        txtChange.Clear()
                        txtVat.Clear()
                        txtTotalPrice.Clear()
                        dt.Clear()
                    End Try

                    ' Query for checking the customer in the Reserve List
                    If Not redragon = "" Then
                        Dim deleteReserveQuery As String = "DELETE FROM tbl_reservation WHERE ID = @id"
                        Using cmd As SqlCommand = New SqlCommand(deleteReserveQuery, con)
                            cmd.Parameters.AddWithValue("@id", redragon)

                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End If

                    ' Query for unavailable in tbl_roombooked
                    Dim updateRoomBooked As String = "UPDATE tbl_roombooked SET Checked_In = @Checkin, Checked_Out = @Checkout, Status = @Status WHERE Room_No = @Room_No"
                    Try
                        Using cmd As SqlCommand = New SqlCommand(updateRoomBooked, con)
                            cmd.Parameters.AddWithValue("@Checkin", Check_In)
                            cmd.Parameters.AddWithValue("@Checkout", Check_Out)
                            cmd.Parameters.AddWithValue("@Room_No", Room_No)
                            cmd.Parameters.AddWithValue("@Status", "Unavailable")

                            con.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Roombooked Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                    End Try

                    Dim updateRoomTableQuery As String = "INSERT INTO [" & Room_No & "] (Room_No, Room_Type, Checkin_Date, Checkout_Date, Guest_Name, Status, Transact_ID) VALUES (@roomNo, @roomType, @checkinDate, @checkoutDate, @guestName, @status, @transactID)"
                    Try
                        Using cmd As SqlCommand = New SqlCommand(updateRoomTableQuery, con)
                            cmd.Parameters.AddWithValue("@roomNo", Room_No)
                            cmd.Parameters.AddWithValue("@roomType", Room_Type)
                            cmd.Parameters.AddWithValue("@checkinDate", Check_In)
                            cmd.Parameters.AddWithValue("@checkoutDate", Check_Out)
                            cmd.Parameters.AddWithValue("@guestName", Customer_Name)
                            cmd.Parameters.AddWithValue("@status", "Checked In")
                            cmd.Parameters.AddWithValue("@transactID", transactId)

                            con.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Room Table Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                    End Try



                    Dim report1 As New CrystalReport1
                    report1.SetParameterValue("Name", Customer_Name)
                    report1.SetParameterValue("Address", Address)
                    report1.SetParameterValue("Room No", Room_No)
                    report1.SetParameterValue("Room Type", Room_Type)
                    report1.SetParameterValue("Number of Person", Number_of_Person)
                    report1.SetParameterValue("Check In", Check_In)
                    report1.SetParameterValue("Check Out", Check_Out)
                    report1.SetParameterValue("Total Price", totalPrice)
                    report1.SetParameterValue("Balance", change)
                    report1.SetParameterValue("Total Amount", Total_Amount)
                    report1.SetParameterValue("Total", Total_No_Vat)
                    report1.SetParameterValue("VAT", VAT)
                    report1.SetParameterValue("Add-Ons", message)
                    report1.SetParameterValue("Arrival Time", vrealArrival_Time)
                    report1.SetParameterValue("Departure Time", vrealDeparture_time)
                    report1.SetParameterValue("TransactID", transactId)

                    receiptForm.CrystalReportViewer1.ReportSource = report1

                    receiptForm.Show()
                End If
            End If
        End If
    End Sub

    ' Condition to Each Text

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If txtName.TextLength >= 35 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
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

    Private Function GetValuesFromDataGridViewColumn(ByVal dataGridView As DataGridView, ByVal columnIndex As Integer) As List(Of String)
        Dim values As New List(Of String)()

        For Each row As DataGridViewRow In dataGridView.Rows
            If Not row.IsNewRow Then
                values.Add(row.Cells(columnIndex).Value.ToString())
            End If
        Next

        Return values
    End Function

    Public message As String = ""
    Private Sub DisplayValuesInMessageBox()
        message = ""
        Dim values As List(Of String) = GetValuesFromDataGridViewColumn(dgvAddon, 1)

        For Each value As String In values
            message &= value & ", "
        Next

        'MessageBox.Show(message)
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
            DisplayValuesInMessageBox()
            nupdQuantity.Value = 1
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
        nupdQuantity.Minimum = 0
        nupdQuantity.Maximum = If(lblAddonItem.Text = "Items - Plus Person", 2, 3)
        'If lblAddonItem.Text = "Items - Plus Person" Then
        '    nupdQuantity.Maximum = 2
        'ElseIf Not lblAddonItem.Text = "Items - Plus Person" Then
        '    nupdQuantity.Maximum = 3
        'End If
    End Sub


    Private Sub dudChildren_ValueChanged(sender As Object, e As EventArgs) Handles dudChildren.ValueChanged
        Dim selectedValue As Integer = Convert.ToInt32(dudAdult.Value)
        If selectedValue < 0 OrElse selectedValue > 2 Then
            dudAdult.Value = Math.Min(Math.Max(selectedValue, 0), 2)
            MsgBox("If you are planning to add another person you have to add Plus Person at Add-on List")
        End If

        Dim remainingCapacity As Integer = 2 - Convert.ToInt32(dudAdult.Value)
        dudChildren.Maximum = remainingCapacity
    End Sub

    Private Sub dudAdult_ValueChanged(sender As Object, e As EventArgs) Handles dudAdult.ValueChanged
        Dim selectedValue As Integer = Convert.ToInt32(dudAdult.Value)
        If selectedValue < 0 OrElse selectedValue > 2 Then
            dudAdult.Value = Math.Min(Math.Max(selectedValue, 0), 2)
            MsgBox("If you are planning to add another person you have to add Plus Person at Add-on List")
        End If

        Dim remainingCapacity As Integer = 2 - Convert.ToInt32(dudAdult.Value)
        dudChildren.Maximum = remainingCapacity
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
        Dim inTime As DateTime = Convert.ToDateTime(dtpCheckIn.Text)
        Dim outtime As DateTime = Convert.ToDateTime(dtpCheckOut.Text)

        If inTime = outtime Then
            MsgBox("Check in and check out shouldn't be allowed to checkout within the day of check in")
            dtpCheckOut.Value = inTime.AddDays(1)
        Else
            updateRoomRate()
        End If
    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        Try
            Dim inTime As DateTime = Convert.ToDateTime(dtpCheckIn.Text)
            Dim outtime As DateTime = Convert.ToDateTime(dtpCheckOut.Text)

            If inTime > outtime Then
                MsgBox("Check in date shouldn't be ahead to check out date")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim roomRate As Decimal
            If Decimal.TryParse(txtDownpayment.Text, roomRate) Then
                ' If txtDownpayment contains a valid decimal value, subtract it from lblRoomRate.Text
                roomRate = CDec(lblRoomRate.Text) - roomRate
            Else
                ' If txtDownpayment doesn't contain a valid decimal value, use lblRoomRate.Text as is
                roomRate = CDec(lblRoomRate.Text)
            End If

            Dim vat As Decimal = 0.12D
            Dim addonTotal As Decimal = 0D

            For Each row As DataGridViewRow In dgvAddon.Rows
                If Not row.IsNewRow Then
                    addonTotal += CDec(row.Cells("Total").Value)
                End If
            Next

            lblTotalPrice.text = addonTotal

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
            If e.KeyChar = ControlChars.Back Then
                ' Allow backspace key
                Return
            End If

            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            End If

            If txtPayment.TextLength > 11 Then
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

    Private Sub dtpDepartureTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpDepartureTime.ValueChanged
        dtpDepartureTime.Value = New DateTime(dtpDepartureTime.Value.Year, dtpDepartureTime.Value.Month, dtpDepartureTime.Value.Day, 12, 0, 0)
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = ControlChars.Back Then
            ' Allow backspace key
            Return
        End If

        If e.KeyChar = ControlChars.Back Then
            ' Allow backspace key
            Return
        End If

        If txtEmail.TextLength >= 50 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        Else
            If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> "@"c AndAlso e.KeyChar <> "."c Then
                e.Handled = True
            End If
        End If
    End Sub
End Class