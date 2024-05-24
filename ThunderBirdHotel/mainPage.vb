Public Class mainPage
    'Public breakMentioned As Boolean
    'Private WithEvents Timer1 As New Timer()
    'Private WithEvents Timer2 As New Timer()

    Private Sub mainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected")
        con.Close()
        timedateLoad()
        changedTime()
        Timer1.Interval = 1000 ' Check every second
        Timer1.Start()
        Timer2.Interval = 1000
        Timer2.Start()
        Timer3.Interval = 1000
        Timer3.Start()
    End Sub

    Sub childform(ByVal panel As Form)
        pnlChildForm.Controls.Clear()
        panel.TopLevel = False
        pnlChildForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub timedateLoad()
        lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd")
        lblTime.Text = DateTime.Now.ToString("h:mm:ss")
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs)
        timedateLoad()
    End Sub
End Class