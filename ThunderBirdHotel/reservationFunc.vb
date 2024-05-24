Imports System.Data.SqlClient

Module reservationFunc
    Public Function CheckRoomAvailability(checkinDate As Date, checkoutDate As Date)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        ' Get a list of all room tables in the database
        Dim roomTables As New List(Of String)(New String() {"[101]", "[202]", "[203]", "[204]", "[205]", "[301]", "[302]", "[303]", "[304]", "[305]", "[401]", "[402]", "[403]", "[404]", "[405]", "[501]", "[502]", "[503]", "[504]", "[505]", "[511]", "[512]", "[513]", "[514]", "[515]"})
        Dim availableRooms As New List(Of String)()
        Dim availableRoomsData As New DataTable()
        availableRoomsData.Columns.Add("Room No", GetType(String))
        availableRoomsData.Columns.Add("Room Type", GetType(String))
        availableRoomsData.Columns.Add("Room Rate", GetType(String))

        ' Open a connection to the database

        con.Open()

        For Each roomTable As String In roomTables
            ' Create a query to check for conflicts in each room table
            Dim query As String = $"SELECT COUNT(*) FROM {roomTable} WHERE Status IN (@Status1, @Status2) AND (Checkin_Date <= @checkoutDate AND Checkout_Date >= @checkinDate) OR (Checkin_Date >= @checkinDate AND Checkout_Date <= @checkoutDate)"

            ' Check if the connection is already open and close it if necessary

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@Status1", "Reserved")
                command.Parameters.AddWithValue("@Status2", "Checked In")
                command.Parameters.AddWithValue("@checkinDate", checkinDate)
                command.Parameters.AddWithValue("@checkoutDate", checkoutDate)

                Dim conflictCount As Integer = CInt(command.ExecuteScalar())

                If conflictCount = 0 Then
                    ' No conflicts found, print the room table name
                    Dim roomNumber As String = roomTable.Replace("[", "").Replace("]", "")
                    Dim roomType As String
                    Dim roomRate As String

                    Select Case roomNumber.Substring(0, 2)
                        Case "10"
                            roomType = "Presidential Suite Room"
                            roomRate = "4200"
                        Case "20"
                            roomType = "Superior Suite Room"
                            roomRate = "2500"
                        Case "30"
                            roomType = "Premier Suite Room"
                            roomRate = "3200"
                        Case "40"
                            roomType = "Family Suite Room"
                            roomRate = "3700"
                        Case "50"
                            roomType = "Junior Suite Room"
                            roomRate = "2200"
                        Case "51"
                            roomType = "Junior Suite Room (BayView)"
                            roomRate = "2700"
                        Case Else
                            roomType = "Unknown"
                    End Select

                    Dim row As DataRow = availableRoomsData.NewRow()
                    row("Room No") = roomNumber
                    row("Room Type") = roomType
                    row("Room Rate") = roomRate
                    availableRoomsData.Rows.Add(row)

                End If
            End Using
        Next
        Return availableRoomsData
    End Function
End Module
