Public Class mainPage
    Private Sub mainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected")
        con.Close()
    End Sub

    Sub childform(ByVal panel As Form)
        pnlChildForm.Controls.Clear()
        panel.TopLevel = False
        pnlChildForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        childform(checkIn)
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        childform(room)
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        childform(guest)
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        childform(checkOut)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        childform(reservation)
    End Sub

    Private Sub btnHotelStatus_Click(sender As Object, e As EventArgs) 
    End Sub
End Class
