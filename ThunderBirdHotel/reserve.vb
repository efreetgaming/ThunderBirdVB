Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class reserve
    Public selectedRoomType As String
    Private dt As New DataTable()
    Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
    Dim emailRegex As New Regex(emailPattern)

    Private Sub reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        Dim checkin As Date = dtpRCheckIn.Value
        dtpRCheckIn.MinDate = Date.Today
        dtpRCheckOut.MinDate = Date.Today
        dtpRCheckOut.Value = checkin.AddDays(1)

        lakshimi = 1

        txtRNumber.Text = "09"
        txtRCountry.Text = "Philippines"
    End Sub


    Public lakshimi As Double
    Public roomRateT As Double

    Private Sub btnRAdd_Click(sender As Object, e As EventArgs) Handles btnRReserve.Click
        If IsValidInput() Then
            Dim customerData As Dictionary(Of String, String) = GetCustomerData()
            SaveReservation(customerData)
        End If
    End Sub

    ' Condition to Each Text

    Private Sub txtRName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRName.KeyPress
        If txtRName.TextLength >= 24 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        ' Only allow letters, spaces, and periods as special characters
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " " OrElse e.KeyChar = ".") AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If txtRNumber.TextLength >= 11 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Back) AndAlso txtRNumber.TextLength <= 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRAddress.KeyPress
        If txtRAddress.TextLength >= 75 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRAvailRoom_Click(sender As Object, e As EventArgs) Handles btnRAvailRoom.Click
        roomReservationAvailabality.Show()
    End Sub

    Private Sub dudChildren_ValueChanged(sender As Object, e As EventArgs) Handles dudRChildren.ValueChanged
        dudRChildren.Maximum = 4
        dudRChildren.Minimum = 0
    End Sub

    Private Sub dudAdult_ValueChanged(sender As Object, e As EventArgs) Handles dudRAdult.ValueChanged
        dudRAdult.Maximum = 4
        dudRAdult.Minimum = 1
    End Sub
    Public passedRoomRate As Double = CDbl(roomAvailability.RoomRate)

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpRCheckIn.ValueChanged
        updateRoomRate()
        lblRRoomType.Text = "Select A Room Type"
        lblRRoomNo.Text = "Select A Room No"
        lblRRoomRate.Text = "0"

        Try
            Dim inTime As DateTime = Convert.ToDateTime(dtpRCheckIn.Text)
            Dim outtime As DateTime = Convert.ToDateTime(dtpRCheckOut.Text)

            If inTime >= outtime Then
                MsgBox("Check in date shouldn't be ahead to check out date")
                dtpRCheckOut.Value = outtime.AddDays(1)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRClear_Click(sender As Object, e As EventArgs) Handles btnRClear.Click
        txtDownpayment.Clear()
        txtPayment.Clear()
        txtReference.Clear()
        txtRName.Clear()
        txtREmail.Clear()
        txtRNumber.Text = "09"
        txtRCity.Clear()
        txtRState.Clear()
        txtRAddress.Clear()
        drpRGender.SelectedIndex = -1
        txtRPostCode.Clear()
        txtRCountry.Text = "Philippines"
        lblRRoomNo.Text = "Select A Room No"
        lblRRoomRate.Text = "0"
        lblRRoomType.Text = "Select A Room Type"
        lblRSubtractDate.Text = ""
    End Sub

    Private Sub txtRPostCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRPostCode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If txtRPostCode.TextLength >= 5 AndAlso Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRCountry.KeyPress
        If txtRCountry.TextLength >= 24 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Public Sub updateRoomRate()
        Try
            Dim inTime As DateTime = Convert.ToDateTime(dtpRCheckIn.Text)
            Dim outTime As DateTime = Convert.ToDateTime(dtpRCheckOut.Text)

            If outTime >= inTime Then
                Dim daysSpanned As Double = outTime.Subtract(inTime).TotalDays ' Calculate the number of days spanned

                lblRSubtractDate.Text = daysSpanned.ToString("N2") ' Display the days spanned in the label

                If lblRRoomRatingRoom.Text <> "0" Then
                    Dim normalRoomRate As Double
                    If Double.TryParse(lblRRoomRatingRoom.Text, normalRoomRate) Then
                        Dim roomRate As Double = normalRoomRate * daysSpanned
                        lblRRoomRate.Text = roomRate.ToString("N2") ' Display the calculated room rate in the label
                    Else
                        lblRRoomRate.Text = "Invalid Room Rate" ' Handle invalid room rate value
                    End If
                Else
                    lblRRoomRate.Text = "0" ' Set room rate to 0 if normal room rate is 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtDownpayment.Text = CDec(lblRRoomRate.Text) * 0.1
    End Sub

    Private Sub dtpRCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpRCheckOut.ValueChanged
        updateRoomRate()
        lblRRoomType.Text = "Select A Room Type"
        lblRRoomNo.Text = "Select A Room No"
        lblRRoomRate.Text = "0"

        Dim inTime As DateTime = Convert.ToDateTime(dtpRCheckIn.Text)
        Dim outtime As DateTime = Convert.ToDateTime(dtpRCheckOut.Text)

        If inTime = outtime Then
            MsgBox("Check in and check out shouldn't be allowed to checkout within the day of check in")
            dtpRCheckOut.Value = inTime.AddDays(1)
        Else
            updateRoomRate()
        End If
    End Sub

    Private Sub reserve_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        con.Close()
    End Sub

    Private Sub txtReference_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReference.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            If txtReference.TextLength >= 13 Then
                e.Handled = True
            End If
        ElseIf e.KeyChar = ChrW(8) Then
            ' Allow backspace
        Else
            e.Handled = True
        End If
    End Sub

    Private Function IsValidInput() As Boolean
        If txtRName.TextLength = 0 Then
            MessageBox.Show("Name shouldn't be empty")
            Return False
        ElseIf txtRAddress.TextLength = 0 Then
            MessageBox.Show("Address shouldn't be empty")
            Return False
        ElseIf txtREmail.TextLength = 0 Or Not emailRegex.IsMatch(txtREmail.Text) Then
            MessageBox.Show("Email shouldn't be empty or it should be valid email")
            Return False
        ElseIf txtRNumber.TextLength <= 10 Then
            MessageBox.Show("Number Shouldn't be empty")
            Return False
        ElseIf drpRGender.SelectedIndex = -1 Then
            MessageBox.Show("Select a gender first")
            Return False
        ElseIf dudRAdult.Value = 0 Then
            MessageBox.Show("Determine how many guest is in")
            Return False
        ElseIf lblRRoomNo.Text = "" Then
            MessageBox.Show("Select a Room No.")
            Return False
        ElseIf lblRRoomNo.Text = "Select A Room No" Then
            MessageBox.Show("Select a Room First")
            Return False
        ElseIf lblRRoomType.Text = "" Then
            MessageBox.Show("Select a Room First")
            Return False
        ElseIf lblRRoomType.Text = "Select A Room Type" Then
            MessageBox.Show("Select a Room First")
            Return False
        ElseIf txtDownpayment.Text = "" Then
            MessageBox.Show("Click the Calculate First")
            Return False
        ElseIf txtReference.Text = "" Then
            MessageBox.Show("type a reference number first")
            Return False
        ElseIf txtDownpayment.Text = "0" Then
            MessageBox.Show("Giggity, Ung Downpayment hehe")
            Return False
        End If
        Return True
    End Function


    Private Function GetCustomerData() As Dictionary(Of String, String)
        Dim customerData As New Dictionary(Of String, String)()
        customerData.Add("Customer_Name", txtRName.Text)
        customerData.Add("Phone_No", txtRNumber.Text)
        customerData.Add("Email", txtREmail.Text)
        customerData.Add("Address", txtRAddress.Text)
        customerData.Add("No_Of_Adults", dudRAdult.Text)
        customerData.Add("No_Of_Children", dudRChildren.Text)
        customerData.Add("Gender", drpRGender.Text)
        customerData.Add("Check_In", dtpRCheckIn.Value.Year & "-" & dtpRCheckIn.Value.Month & "-" & dtpRCheckIn.Value.Day)
        customerData.Add("Check_Out", dtpRCheckOut.Value.Year & "-" & dtpRCheckOut.Value.Month & "-" & dtpRCheckOut.Value.Day)
        customerData.Add("Room_No", lblRRoomNo.Text)
        customerData.Add("Room_Type", lblRRoomType.Text)
        customerData.Add("City", txtRCity.Text)
        customerData.Add("State", txtRState.Text)
        customerData.Add("postcode", txtRPostCode.Text)
        customerData.Add("country", txtRCountry.Text)
        customerData.Add("arrival", dtpArrivalTime.Value.ToString("HH:mm tt"))
        customerData.Add("downpayment", txtDownpayment.Text)
        customerData.Add("payment", txtPayment.Text)
        customerData.Add("roomrate", lblRRoomRate.Text)
        customerData.Add("referenceno", txtReference.Text)
        Return customerData
    End Function

    Private Sub SaveReservation(customerData As Dictionary(Of String, String))
        Dim Phone_No As String = txtRNumber.Text
        Dim Email As String = txtREmail.Text
        Dim Address As String = txtRAddress.Text
        Dim No_Of_Adults As String = dudRAdult.Text
        Dim No_Of_Children As String = dudRChildren.Text
        Dim Gender As String = drpRGender.Text
        Dim Check_In As String = dtpRCheckIn.Value.Year & "-" & dtpRCheckIn.Value.Month & "-" & dtpRCheckIn.Value.Day
        Dim Check_Out As String = dtpRCheckOut.Value.Year & "-" & dtpRCheckOut.Value.Month & "-" & dtpRCheckOut.Value.Day
        Dim Room_No As String = lblRRoomNo.Text
        Dim Room_Type As String = lblRRoomType.Text
        Dim City As String = txtRCity.Text
        Dim State As String = txtRState.Text
        Dim postcode As String = txtRPostCode.Text
        Dim country As String = txtRCountry.Text
        Dim arrival As String
        Dim downpayment As String = txtDownpayment.Text
        Dim payment As String = txtPayment.Text
        Dim roomrate As String = lblRRoomRate.Text
        Dim referenceno As String = txtReference.Text
        Dim random As New Random()
        Dim transactId As String = Convert.ToInt64(random.NextDouble() * (99999999999999 - 10000000000000) + 10000000000000)

        Dim roomNumberQuery As String = "SELECT * FROM tbl_reservation WHERE Room_Type = @Room_Type AND Room_No = @Room_No AND ((@CheckIn < Checkin_Date AND @CheckOut > Checkin_Date) OR (@CheckIn < Checkout_Date AND @CheckOut > Checkout_Date) OR (@CheckIn > Checkin_Date AND @CheckOut < Checkout_Date) OR (@CheckIn < Checkin_Date AND @CheckOut > Checkout_Date)) AND NOT (@CheckIn = Checkout_Date AND @Room_Type = Room_Type)"

        Try
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(roomNumberQuery, con)
                cmd.Parameters.AddWithValue("@Room_No", customerData("Room_No"))
                cmd.Parameters.AddWithValue("@Room_Type", customerData("Room_Type"))
                cmd.Parameters.AddWithValue("@CheckIn", customerData("Check_In"))
                cmd.Parameters.AddWithValue("@CheckOut", customerData("Check_Out"))

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close()
                    con.Close()
                    MessageBox.Show("Error: The date range has been reserved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    reader.Close()

                    ' Query for Guest
                    Dim queryGuest As String = "INSERT INTO tbl_reservation (First_Name, Email, Contact_Email, Phone, Address, City, State, Post_Code, Country, Checkin_Date, Checkout_Date, Room_Type, No_Of_Adult, No_Of_Children, Reference_Number, Arrival_Time, Downpayment, Room_Rate, Room_No, Transact_ID) " & "VALUES (@First_Name, @Email, @Contact_Email, @Phone, @Address, @City, @State, @Post_Code, @Country, @Checkin_Date, @Checkout_Date, @Room_Type, @No_Of_Adult, @No_Of_Children, @Reference_Number, @Arrival_Time, @Downpayment, @Room_Rate, @Room_No, @Transact_ID)"

                    Try
                        Using cmds As SqlCommand = New SqlCommand(queryGuest, con)
                            cmds.Parameters.AddWithValue("@First_Name", customerData("Customer_Name"))
                            cmds.Parameters.AddWithValue("@Email", customerData("Email"))
                            cmds.Parameters.AddWithValue("@Contact_Email", customerData("Email"))
                            cmds.Parameters.AddWithValue("@Phone", customerData("Phone_No"))
                            cmds.Parameters.AddWithValue("@Address", customerData("Address"))
                            cmds.Parameters.AddWithValue("@City", customerData("City"))
                            cmds.Parameters.AddWithValue("@State", customerData("State"))
                            cmds.Parameters.AddWithValue("@Post_Code", customerData("postcode"))
                            cmds.Parameters.AddWithValue("@Country", customerData("country"))
                            cmds.Parameters.AddWithValue("@Checkin_Date", customerData("Check_In"))
                            cmds.Parameters.AddWithValue("@Checkout_Date", customerData("Check_Out"))
                            cmds.Parameters.AddWithValue("@Room_Type", customerData("Room_Type"))
                            cmds.Parameters.AddWithValue("@No_Of_Adult", customerData("No_Of_Adults"))
                            cmds.Parameters.AddWithValue("@No_Of_Children", customerData("No_Of_Children"))
                            cmds.Parameters.AddWithValue("@Reference_Number", customerData("referenceno"))
                            cmds.Parameters.AddWithValue("@Arrival_Time", customerData("arrival"))
                            cmds.Parameters.AddWithValue("@Downpayment", customerData("downpayment"))
                            cmds.Parameters.AddWithValue("@Room_Rate", customerData("roomrate"))
                            cmds.Parameters.AddWithValue("@Room_No", customerData("Room_No"))
                            cmds.Parameters.AddWithValue("@Transact_ID", transactId)

                            cmds.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    ' Query for Report
                    Dim dateNow As String
                    dateNow = dtpDate.Value.Year & "-" & dtpDate.Value.Month & "-" & dtpDate.Value.Day

                    Dim reportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Status, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Status, @Date)"

                    Try
                        Using cmds As SqlCommand = New SqlCommand(reportQuery, con)
                            cmds.Parameters.AddWithValue("@Name", customerData("Customer_Name"))
                            cmds.Parameters.AddWithValue("@Checked_In", customerData("Check_In"))
                            cmds.Parameters.AddWithValue("@Checked_Out", customerData("Check_Out"))
                            cmds.Parameters.AddWithValue("@Status", "Reserved")
                            cmds.Parameters.AddWithValue("@Date", dateNow)

                            cmds.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    Dim roomNumberQueryt As String = "INSERT INTO [" & customerData("Room_No") & "] (Room_No, Room_Type, Checkin_Date, Checkout_Date, Guest_Name, Status, Transact_ID) VALUES (@RoomNo, @RoomType, @CheckIn, @CheckOut, @Guest_Name, @Status, @Transact_ID)"
                    Try
                        Using cmds As SqlCommand = New SqlCommand(roomNumberQueryt, con)
                            cmds.Parameters.AddWithValue("@RoomNo", customerData("Room_No"))
                            cmds.Parameters.AddWithValue("@RoomType", customerData("Room_Type"))
                            cmds.Parameters.AddWithValue("@CheckIn", customerData("Check_In"))
                            cmds.Parameters.AddWithValue("@CheckOut", customerData("Check_Out"))
                            cmds.Parameters.AddWithValue("@Guest_Name", customerData("Customer_Name"))
                            cmds.Parameters.AddWithValue("@Status", "Reserved")
                            cmds.Parameters.AddWithValue("@Transact_ID", transactId)

                            cmds.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Room Number Entering Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                        Me.Hide()
                    End Try
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Something Entering Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        txtDownpayment.Clear()
        txtPayment.Clear()
        txtReference.Clear()
        txtRName.Clear()
        txtREmail.Clear()
        txtRNumber.Clear()
        txtRCity.Clear()
        txtRState.Clear()
        txtRAddress.Clear()
        drpRGender.SelectedIndex = -1
        txtRPostCode.Clear()
        txtRCountry.Clear()
        lblRRoomNo.Text = "Select A Room No"
        lblRRoomRate.Text = "0"
        lblRRoomType.Text = "Select A Room Type"
        lblRSubtractDate.Text = ""
    End Sub

    Private Sub txtPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPayment.KeyPress
        ' Check if the pressed key is a digit or Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' If the pressed key is not a digit or Backspace, ignore it
            e.Handled = True
        End If

        ' Limit the text length to 15 digits
        If txtPayment.Text.Length >= 15 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' If the text length is already 15 digits and the pressed key is not Backspace, ignore it
            e.Handled = True
        End If
    End Sub
End Class