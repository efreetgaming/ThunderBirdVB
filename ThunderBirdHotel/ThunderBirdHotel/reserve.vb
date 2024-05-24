Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class reserve
    Public selectedRoomType As String
    Private dt As New DataTable()

    Private Sub reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkin As Date = dtpRCheckIn.Value
        dtpRCheckIn.MinDate = Date.Today
        dtpRCheckOut.MinDate = Date.Today
        dtpRCheckOut.Value = checkin.AddDays(1)

        lakshimi = 1

        txtRNumber.Text = "09"
    End Sub


    Public lakshimi As Double
    Public roomRateT As Double

    Private Sub btnRAdd_Click(sender As Object, e As EventArgs) Handles btnRReserve.Click
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim emailRegex As New Regex(emailPattern)

        If txtRName.TextLength = 0 Then
            MessageBox.Show("Name shouldn't be empty")
        ElseIf txtRAddress.TextLength = 0 Then
            MessageBox.Show("Address shouldn't be empty")
        ElseIf txtREmail.TextLength = 0 Or Not emailRegex.IsMatch(txtREmail.Text) Then
            MessageBox.Show("Email shouldn't be empty or it should be valid email")
        ElseIf txtRNumber.TextLength <= 10 Then
            MessageBox.Show("Number Shouldn't be empty")
        ElseIf drpRGender.SelectedIndex = -1 Then
            MessageBox.Show("Select a gender first")
        ElseIf dudRAdult.Value = 0 Then
            MessageBox.Show("Determine how many guest is in")
        ElseIf lblRRoomNo.Text = "" Then
            MessageBox.Show("Select a Room No.")
        Else
            Dim Customer_Name As String = txtRName.Text
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

            ' Query for Guest
            Dim queryGuest As String = "INSERT INTO tbl_reservation (First_Name, Email, Contact_Email, Phone, Address, City, State, Post_Code, Country, Checkin_Date, Checkout_Date, Room_Type, No_Of_Adult, No_Of_Children) " & "VALUES (@First_Name, @Email, @Contact_Email, @Phone, @Address, @City, @State, @Post_Code, @Country, @Checkin_Date, @Checkout_Date, @Room_Type, @No_Of_Adult, @No_Of_Children)"

            Using cmd As SqlCommand = New SqlCommand(queryGuest, con)
                cmd.Parameters.AddWithValue("@First_Name", Customer_Name)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@Contact_Email", Email)
                cmd.Parameters.AddWithValue("@Phone", Phone_No)
                cmd.Parameters.AddWithValue("@Address", Address)
                cmd.Parameters.AddWithValue("@City", City)
                cmd.Parameters.AddWithValue("@State", State)
                cmd.Parameters.AddWithValue("@Post_Code", postcode)
                cmd.Parameters.AddWithValue("@Country", country)
                cmd.Parameters.AddWithValue("@Checkin_Date", Check_In)
                cmd.Parameters.AddWithValue("@Checkout_Date", Check_Out)
                cmd.Parameters.AddWithValue("@Room_Type", Room_Type)
                cmd.Parameters.AddWithValue("@No_Of_Adult", No_Of_Adults)
                cmd.Parameters.AddWithValue("@No_Of_Children", No_Of_Children)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                txtRName.Clear()
                txtRNumber.Clear()
                txtREmail.Clear()
                txtRAddress.Clear()
            End Using


            ' Query for Report
            Dim dateNow As String
                dateNow = dtpDate.Value.Year & "-" & dtpDate.Value.Month & "-" & dtpDate.Value.Day

            Dim reportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Status, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Status, @Date)"

            Using cmd As SqlCommand = New SqlCommand(reportQuery, con)
                cmd.Parameters.AddWithValue("@Name", Customer_Name)
                cmd.Parameters.AddWithValue("@Checked_In", Check_In)
                cmd.Parameters.AddWithValue("@Checked_Out", Check_Out)
                cmd.Parameters.AddWithValue("@Status", "Reserved")
                cmd.Parameters.AddWithValue("@Date", dateNow)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            End Using
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
        roomAvailability.Show()
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
        Dim inTime As DateTime = Convert.ToDateTime(dtpRCheckIn.Text)
        Dim outtime As DateTime = Convert.ToDateTime(dtpRCheckOut.Text)

        If inTime >= outtime Then
            MsgBox("Check in date shouldn't be ahead to check out date")
        End If
    End Sub

    Private Sub btnRClear_Click(sender As Object, e As EventArgs) Handles btnRClear.Click
        txtRName.Clear()
        txtRNumber.Clear()
        txtREmail.Clear()
        txtRAddress.Clear()
    End Sub
End Class