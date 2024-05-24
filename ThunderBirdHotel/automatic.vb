Imports System.Data.SqlClient

Module automatic
    Public breakMentioned As Boolean
    Public WithEvents Timer1 As New Timer()
    Public WithEvents Timer2 As New Timer()
    Public WithEvents Timer3 As New Timer()

    ' Planned arrival time
    Private roomStatusChange As Boolean = False

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim dt As DateTime = DateTime.Now

        ' Check if time is between 2 PM and 12 AM (inclusive)
        If dt.Hour >= 14 And Not roomStatusChange Then
            ' Call the function to check the room status
            Dim roomStatus As Boolean = CheckRoomStatus()
            If roomStatus Then
                Console.WriteLine("Someone reserved")
                UpdateRoomStatus()
                roomStatusChange = True
            Else
                Console.WriteLine("It should be Available that room")
                UpdateRoomStatus()
                roomStatusChange = True
            End If
        End If
        reserveTriggerOnce = False
    End Sub

    Private checkoutTriggerOnce As Boolean = False

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim dt As DateTime = DateTime.Now
        If dt.Hour >= 12 And dt.Hour <= 14 And Not checkoutTriggerOnce Then
            ' Check if the connection is closed, then open it
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "SELECT * FROM tbl_checkout"

            ' Set the command text and connection

            ' Execute the query and read the results using a SqlDataReader
            Using cmd As New SqlCommand(query, con)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Create a list to store the data
                    Dim dataList As New List(Of String)()

                    ' Read the data from the SqlDataReader and add it to the list
                    While reader.Read()
                        ' Add each data item to the list
                        dataList.Add(reader("Customer_id").ToString())
                        dataList.Add(reader("Customer_Name").ToString())
                        dataList.Add(reader("Checked_In").ToString())
                        dataList.Add(reader("Checked_Out").ToString())
                        dataList.Add(reader("Total_Price").ToString())
                        dataList.Add(reader("Status").ToString())
                        dataList.Add(reader("Date").ToString())
                        dataList.Add(reader("Room_No").ToString())
                        dataList.Add(reader("Arrival_Time").ToString())
                        dataList.Add(reader("Departure_Time").ToString())
                        dataList.Add(reader("Transact_ID").ToString())
                    End While

                    ' Close the reader after reading all data
                    reader.Close()



                    ' Perform operations using dataList
                    For i As Integer = 0 To dataList.Count - 1 Step 11
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        ' Get the checkout date and departure time from the data list
                        Dim checkoutDate As Date = dataList(i + 3)

                        ' Parse the departure time string as a TimeSpan
                        ' Get the current date and time
                        Dim now As DateTime = DateTime.Now

                        ' Check if the checkout date is equal to today's date and the departure time is equal to the current time
                        If checkoutDate <= now.Date Then
                            ' Update the room status
                            Dim updateRoomQuery As String = "UPDATE tbl_rooms SET Guest_Name = NULL, Phone_No = NULL, Status = @status, Extras = NULL, Arrival_Time = @arrival_time, Departure_Time = @departure_time, Date = @date WHERE Room_No = @roomNo"
                            Using cmds As SqlCommand = New SqlCommand(updateRoomQuery, con)
                                cmds.Parameters.AddWithValue("@roomNo", dataList(i + 7))
                                cmds.Parameters.AddWithValue("@status", "Cleaning")
                                cmds.Parameters.AddWithValue("@arrival_time", DBNull.Value)
                                cmds.Parameters.AddWithValue("@departure_time", DBNull.Value)
                                cmds.Parameters.AddWithValue("@date", DBNull.Value)

                                cmds.ExecuteNonQuery()
                            End Using

                            ' Insert report
                            Dim insertReportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Date, Arrival_Time, Departure_Time) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Date, @Arrival_Time, @Departure_Time)"
                            Using cmds As SqlCommand = New SqlCommand(insertReportQuery, con)
                                cmds.Parameters.AddWithValue("@Name", dataList(i + 1))
                                cmds.Parameters.AddWithValue("@Checked_In", dataList(i + 2))
                                cmds.Parameters.AddWithValue("@Checked_Out", dataList(i + 3))
                                cmds.Parameters.AddWithValue("@Total_Price", dataList(i + 4))
                                cmds.Parameters.AddWithValue("@Status", "Checked-Out")
                                cmds.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"))
                                cmds.Parameters.AddWithValue("@Arrival_Time", dataList(i + 8))
                                cmds.Parameters.AddWithValue("@Departure_Time", dataList(i + 9))

                                cmds.ExecuteNonQuery()
                            End Using

                            ' Remove guest from the list
                            Dim removeGuestQuery As String = "DELETE FROM tbl_guest WHERE Customer_ID = @Id"
                            Using cmds As SqlCommand = New SqlCommand(removeGuestQuery, con)
                                cmds.Parameters.AddWithValue("@Id", dataList(i))

                                cmds.ExecuteNonQuery()
                            End Using

                            ' Delete checkout record
                            Dim delQuery As String = "DELETE FROM tbl_checkout WHERE Customer_ID = @id"
                            Using cmds As SqlCommand = New SqlCommand(delQuery, con)
                                cmds.Parameters.AddWithValue("@id", dataList(i))

                                cmds.ExecuteNonQuery()
                            End Using

                            Dim roomNumberQuery As String = $"DELETE FROM [{dataList(i + 7)}] WHERE Transact_ID = @Transact_ID"
                            Using cmds As SqlCommand = New SqlCommand(roomNumberQuery, con)
                                cmds.Parameters.AddWithValue("@Transact_ID", dataList(i + 10))

                                cmds.ExecuteNonQuery()
                            End Using

                            Dim checkinini As String = $"SELECT Checked_Out FROM tbl_checkout WHERE Room_No = {dataList(i + 7)}"
                            Dim command As New SqlCommand(checkinini, con)
                            Dim checkoutDates As Date = Convert.ToDateTime(command.ExecuteScalar())
                            If checkoutDates < Date.Today Then
                                Dim updateRoomQuerys As String = $"UPDATE tbl_rooms SET Status = 'Cleaning' WHERE Room_No = {dataList(i + 7)}"
                                Using cmds As SqlCommand = New SqlCommand(updateRoomQuerys, con)
                                    cmds.ExecuteNonQuery()
                                End Using
                            End If

                            MsgBox("The guest " & dataList(1) & " has been checked out")
                        End If
                    Next

                    ' Clear dataList after processing
                    dataList.Clear()
                End Using
            End Using

            ' Close the connection if it was opened in this block
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            checkoutTriggerOnce = True
        End If
        roomStatusChange = False
    End Sub


    Private reserveTriggerOnce As Boolean = False

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim dt As DateTime = DateTime.Now
        If dt.Hour >= 0 AndAlso dt.Hour < 12 And Not reserveTriggerOnce Then
            ' Check if the connection is closed, then open it
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "Select ID, First_Name, Checkin_Date, Checkout_Date, Arrival_Time, Downpayment, Room_No, Transact_ID FROM tbl_reservation WHERE @now > Checkin_Date"

            ' Set the command text and connection

            ' Execute the query and read the results using a SqlDataReader
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@now", dt)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Create a list to store the data
                    Dim dataList As New List(Of String)()

                    ' Read the data from the SqlDataReader and add it to the list
                    While reader.Read()
                        ' Add each data item to the list
                        dataList.Add(reader("ID").ToString())
                        dataList.Add(reader("First_Name").ToString())
                        dataList.Add(reader("Checkin_Date").ToString())
                        dataList.Add(reader("Checkout_Date").ToString())
                        dataList.Add(reader("Arrival_Time").ToString())
                        dataList.Add(reader("Downpayment").ToString())
                        dataList.Add(reader("Room_No").ToString())
                        dataList.Add(reader("Transact_ID").ToString())
                    End While

                    ' Close the reader after reading all data
                    reader.Close()

                    ' Perform operations using dataList
                    For i As Integer = 0 To dataList.Count - 1 Step 8
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        ' Get the checkout date and departure time from the data list
                        Dim checkinDate As Date = dataList(i + 2)

                        ' Parse the departure time string as a TimeSpan
                        ' Get the current date and time
                        Dim now As DateTime = DateTime.Now

                        ' Check if the checkout date is equal to today's date and the departure time is equal to the current time
                        If now.Date > checkinDate Then
                            ' Update the room status
                            Dim insertReportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Arrival_Time, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Arrival_Time, @Date)"
                            Using cmds As SqlCommand = New SqlCommand(insertReportQuery, con)
                                cmds.Parameters.AddWithValue("@Name", dataList(i + 1))
                                cmds.Parameters.AddWithValue("@Checked_In", dataList(i + 2))
                                cmds.Parameters.AddWithValue("@Checked_Out", dataList(i + 3))
                                cmds.Parameters.AddWithValue("@Total_Price", dataList(i + 5))
                                cmds.Parameters.AddWithValue("@Status", "Cancelled")
                                cmds.Parameters.AddWithValue("@Arrival_Time", dataList(i + 4))
                                cmds.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"))

                                cmds.ExecuteNonQuery()
                            End Using

                            Dim deleteReservationQuery As String = "DELETE FROM tbl_reservation WHERE Transact_ID = @transactID"
                            Using cmds As SqlCommand = New SqlCommand(deleteReservationQuery, con)
                                cmds.Parameters.AddWithValue("@transactID", dataList(i + 7))

                                cmds.ExecuteNonQuery()
                            End Using

                            Dim updateRoomQuery As String = "DELETE FROM [" & dataList(i + 6) & "] WHERE Transact_ID = @transactID"
                            Using cmds As SqlCommand = New SqlCommand(updateRoomQuery, con)
                                cmds.Parameters.AddWithValue("@transactID", dataList(i + 7))

                                cmds.ExecuteNonQuery()
                            End Using

                            MsgBox("The guest " & dataList(1) & " has been cancelled out")
                        End If
                    Next

                    ' Clear dataList after processing
                    dataList.Clear()
                End Using
            End Using

            ' Close the connection if it was opened in this block
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            reserveTriggerOnce = True
        End If
        checkoutTriggerOnce = False
    End Sub


    Function CheckRoomStatus() As Boolean
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim roomNumbers As String() = {"101", "202", "203", "204", "205", "301", "302", "303", "304", "305", "401", "402", "403", "404", "405", "501", "502", "503", "504", "505", "511", "512", "513", "514", "515"}
        Dim hasReservedRoom As Boolean = False
        con.Open()
        ' Loop through each room number and check the Checkin_Date column
        For Each roomNumber In roomNumbers
            Dim tableName As String = roomNumber
            Dim command As New SqlCommand("SELECT COUNT(*) FROM [" & tableName & "] WHERE Checkin_Date = @CheckinDate", con)
            command.Parameters.AddWithValue("@CheckinDate", DateTime.Today)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                hasReservedRoom = True
            Else
                ' If no reservation exists for today's date for this room, update its status to "Available"
                Dim updateQuery As String = "UPDATE tbl_rooms SET Status = 'Available' WHERE Room_No = @RoomNo"
                Using cmd As New SqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@RoomNo", roomNumber)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Next

        con.Close()
        Return hasReservedRoom
    End Function

    Sub UpdateRoomStatus()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim roomNumbers As String() = {"101", "202", "203", "204", "205", "301", "302", "303", "304", "305", "401", "402", "403", "404", "405", "501", "502", "503", "504", "505", "511", "512", "513", "514", "515"}

        con.Open()

        For Each roomNumber In roomNumbers
            Dim isReservedToday As Boolean = IsRoomReservedToday(roomNumber)

            If isReservedToday Then
                UpdateRoomStatusForRoom(roomNumber, "Reserved")
            Else
                Dim checkChecoutDate As String = $"SELECT Checked_Out FROM tbl_checkout WHERE Room_No = {roomNumber}"
                Dim command As New SqlCommand(checkChecoutDate, con)
                Dim room As String = Convert.ToDateTime(command.ExecuteScalar())
                If Date.Today < room Then
                    UpdateRoomStatusForRoom(roomNumber, "Unavailable")
                Else
                    UpdateRoomStatusForRoom(roomNumber, "Available")
                End If

            End If
        Next

        con.Close()
    End Sub

    Function IsRoomReservedToday(ByVal roomNumber As String) As Boolean
        Dim isReserved As Boolean = False

        Dim command As New SqlCommand("SELECT COUNT(*) FROM [" & roomNumber & "] WHERE Checkin_Date = @CheckinDate AND STATUS = 'Reserved'", con)
        command.Parameters.AddWithValue("@CheckinDate", DateTime.Today)
        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

        If count > 0 Then
            isReserved = True

        End If

        Return isReserved
    End Function

    Sub UpdateRoomStatusForRoom(ByVal roomNumber As String, ByVal status As String)
        Dim updateQuery As String = "UPDATE tbl_rooms SET Status = @Status WHERE Room_No = @RoomNo"
        Using cmd As New SqlCommand(updateQuery, con)
            cmd.Parameters.AddWithValue("@Status", status)
            cmd.Parameters.AddWithValue("@RoomNo", roomNumber)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Module