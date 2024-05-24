Imports System.Data.SqlClient
Imports Microsoft.Win32


Module autodeletion

    Private previousSystemTime As DateTime
    Private timeChangedHandlerAdded As Boolean = False
    Sub changedTime()
        previousSystemTime = DateTime.Now
        AddHandler SystemEvents.TimeChanged, AddressOf SystemTimeChanged
        timeChangedHandlerAdded = True
    End Sub

    Private Sub SystemTimeChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Calculate the number of days passed since the last system time change
        Dim currentTime As DateTime = DateTime.Now
        Dim daysPassed As Integer = (currentTime - previousSystemTime).Days

        ' Update previousSystemTime with the current time
        previousSystemTime = currentTime

        ' Storing to a datatable for table for each room numbers
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Dim checkoutlist As New List(Of String)

        ' Storing the datafrom the checkout table
        con.Open()
        Dim queryCheckoutDate As String = "SELECT * FROM tbl_checkout WHERE CAST(@now AS DATE) > CAST(Checked_Out AS DATE)"
        Using cmd As New SqlCommand(queryCheckoutDate, con)
            cmd.Parameters.AddWithValue("@now", currentTime)
            Using reader As SqlDataReader = cmd.ExecuteReader
                While reader.Read()
                    checkoutlist.Add(reader("Customer_Id").ToString())
                    checkoutlist.Add(reader("Customer_Name").ToString())
                    checkoutlist.Add(reader("Checked_In").ToString())
                    checkoutlist.Add(reader("Checked_Out").ToString())
                    checkoutlist.Add(reader("Total_Price").ToString())
                    checkoutlist.Add(reader("Status").ToString())
                    checkoutlist.Add(reader("Date").ToString())
                    checkoutlist.Add(reader("Room_No").ToString())
                    checkoutlist.Add(reader("Arrival_Time").ToString())
                    checkoutlist.Add(reader("Departure_Time").ToString())
                    checkoutlist.Add(reader("Transact_ID").ToString())
                End While
                reader.Close()

                For i As Integer = 0 To checkoutlist.Count - 1 Step 11
                    Dim previousDateIguess As Date = checkoutlist(i + 3)
                    If currentTime.Date > previousDateIguess Then
                        Dim insertReportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Arrival_Time, Departure_Time, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Arrival_Time, @Departure_Time, @Date)"
                        Using cmds As New SqlCommand(insertReportQuery, con)
                            cmds.Parameters.AddWithValue("@Name", checkoutlist(i + 1))
                            cmds.Parameters.AddWithValue("@Checked_In", checkoutlist(i + 2))
                            cmds.Parameters.AddWithValue("@Checked_Out", checkoutlist(i + 3))
                            cmds.Parameters.AddWithValue("@Total_Price", checkoutlist(i + 4))
                            cmds.Parameters.AddWithValue("@Status", "Checked Out")
                            cmds.Parameters.AddWithValue("@Arrival_Time", checkoutlist(i + 8))
                            cmds.Parameters.AddWithValue("@Departure_Time", checkoutlist(i + 9))
                            cmds.Parameters.AddWithValue("@Date", checkoutlist(i + 6))

                            cmds.ExecuteNonQuery()
                        End Using

                        Dim updateRoomQuery As String = "UPDATE tbl_rooms SET Guest_Name = NULL, Phone_No = NULL, Status = @status, Extras = NULL, Arrival_Time = NULL, Departure_Time = NULL, Date = NULL WHERE Room_No = @roomNo"
                        Using cmds As New SqlCommand(updateRoomQuery, con)
                            cmds.Parameters.AddWithValue("@roomNo", checkoutlist(i + 7))
                            cmds.Parameters.AddWithValue("@status", "Available")

                            cmds.ExecuteNonQuery()
                        End Using

                        Dim removeGuestQuery As String = "DELETE FROM tbl_guest WHERE Customer_ID = @Id"
                        Using cmds As New SqlCommand(removeGuestQuery, con)
                            cmds.Parameters.AddWithValue("@Id", checkoutlist(i + 0))

                            cmds.ExecuteNonQuery()
                        End Using

                        Dim delcheckouteQuery As String = "DELETE FROM tbl_checkout WHERE Customer_ID = @id"
                        Using cmds As New SqlCommand(delcheckouteQuery, con)
                            cmds.Parameters.AddWithValue("@id", checkoutlist(i + 0))

                            cmds.ExecuteNonQuery()
                        End Using

                        Dim roomNumberQuery As String = $"DELETE FROM [{checkoutlist(i + 7)}] WHERE Transact_ID = @Transact_ID"
                        Using cmds As New SqlCommand(roomNumberQuery, con)
                            cmds.Parameters.AddWithValue("@Transact_ID", checkoutlist(i + 10))

                            cmds.ExecuteNonQuery()
                        End Using

                    End If
                Next
                checkoutlist.Clear()
            End Using
        End Using

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim reservationDateList As New List(Of String)
        con.Open()

        Dim reservation As String = "SELECT ID, First_Name, Checkin_Date, Checkout_Date, Arrival_Time, Downpayment, Room_No, Transact_ID FROM tbl_reservation WHERE CAST(GETDATE() AS DATE) > CAST(Checkin_Date AS DATE)"
        Using cmd As New SqlCommand(reservation, con)
            'cmd.Parameters.AddWithValue("@now", currentTime)
            Using reader As SqlDataReader = cmd.ExecuteReader
                While reader.Read()
                    reservationDateList.Add(reader("ID").ToString)
                    reservationDateList.Add(reader("First_Name").ToString)
                    reservationDateList.Add(reader("Checkin_Date").ToString)
                    reservationDateList.Add(reader("Checkout_Date").ToString)
                    reservationDateList.Add(reader("Arrival_Time").ToString)
                    reservationDateList.Add(reader("Downpayment").ToString)
                    reservationDateList.Add(reader("Room_No").ToString)
                    reservationDateList.Add(reader("Transact_ID").ToString)
                End While
                reader.Close()


                For i As Integer = 0 To reservationDateList.Count - 1 Step 8
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    Dim checkin As Date = reservationDateList(i + 2)

                    Dim insertReportQuery As String = "INSERT INTO tbl_reports (Name, Checked_In, Checked_Out, Total_Price, Status, Arrival_Time, Date) VALUES (@Name, @Checked_In, @Checked_Out, @Total_Price, @Status, @Arrival_Time, @Date)"
                    Using cmds As SqlCommand = New SqlCommand(insertReportQuery, con)
                        cmds.Parameters.AddWithValue("@Name", reservationDateList(i + 1))
                        cmds.Parameters.AddWithValue("@Checked_In", reservationDateList(i + 2))
                        cmds.Parameters.AddWithValue("@Checked_Out", reservationDateList(i + 3))
                        cmds.Parameters.AddWithValue("@Total_Price", reservationDateList(i + 5))
                        cmds.Parameters.AddWithValue("@Status", "Cancelled")
                        cmds.Parameters.AddWithValue("@Arrival_Time", reservationDateList(i + 4))
                        cmds.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"))

                        cmds.ExecuteNonQuery()
                    End Using

                    Dim updateRoomStatusQuery As String = "UPDATE tbl_rooms SET Status = 'Available' WHERE Room_No = @RoomNo"
                    Using cmds As SqlCommand = New SqlCommand(updateRoomStatusQuery, con)
                        cmds.Parameters.AddWithValue("@RoomNo", reservationDateList(i + 6))

                        cmds.ExecuteNonQuery()
                    End Using

                    Dim deleteReservationQuery As String = "DELETE FROM tbl_reservation WHERE Transact_ID = @Transact_ID"
                    Using cmds As SqlCommand = New SqlCommand(deleteReservationQuery, con)
                        cmds.Parameters.AddWithValue("@Transact_ID", reservationDateList(i + 7))

                        cmds.ExecuteNonQuery()
                    End Using

                    Dim updateRoomQuery As String = "DELETE FROM [" & reservationDateList(i + 6) & "] WHERE Transact_ID = @transactID"
                    Using cmds As SqlCommand = New SqlCommand(updateRoomQuery, con)
                        cmds.Parameters.AddWithValue("@transactID", reservationDateList(i + 7))

                        cmds.ExecuteNonQuery()
                    End Using
                Next
                reservationDateList.Clear()
            End Using
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Using
        ' Remove the event handler after it's been executed once
        timeChangedHandlerAdded = False
    End Sub
End Module