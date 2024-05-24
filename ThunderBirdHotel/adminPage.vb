Public Class adminPage

    Private Sub adminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected")
        con.Close()
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

    Private manageUser As New manageUser()
    Private manageRooms As New manageRooms()
    Private manageAddons As New manageAddons()
    Private mainPage As New mainPage()
    Private loginForm As New loginForm()

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        childform(manageUser)
    End Sub

    Private Sub btnManageRooms_Click_1(sender As Object, e As EventArgs) Handles btnManageRooms.Click
        childform(manageRooms)
    End Sub

    Private Sub btnManageAddOns_Click(sender As Object, e As EventArgs) Handles btnManageAddons.Click
        childform(manageAddons)
    End Sub

    Private Sub btnDailyReports_Click(sender As Object, e As EventArgs) Handles btnDailyReports.Click
        childform(reportsNaten)
    End Sub

    Private Sub btnAcccess_Click(sender As Object, e As EventArgs) Handles btnAcccess.Click
        mainPage.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loginForm.Show()
        Me.Hide()
    End Sub
End Class