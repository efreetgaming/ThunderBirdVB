Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class loginForm
    Private Sub chkBoxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxPassword.CheckedChanged
        If chkBoxPassword.Checked Then
            txtPword.PasswordChar = ""
        Else
            txtPword.PasswordChar = "•"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Open()
        cmd = New SqlCommand("tbl_users2", con)
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@user", txtUname.Text)
            .Parameters.AddWithValue("@pass", txtPword.Text)
            .Parameters.Add("@role", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
            .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output
            .ExecuteScalar()
            Dim role As String = .Parameters("@role").Value.ToString()
            Dim result As Integer = CInt(.Parameters("@result").Value)

            Select Case result
                Case 3
                    MsgBox("Administrator login successful", vbInformation)
                    txtPword.Clear()
                    txtUname.Clear()
                    con.Close()
                    adminPage.Show()
                    Me.Hide()
                Case 2
                    MsgBox("Frontdesk login successful", vbInformation)
                    txtPword.Clear()
                    txtUname.Clear()
                    con.Close()
                    mainPage.Show()
                    Me.Hide()
                Case Else
                    MsgBox("Invalid username or password", vbCritical)
            End Select
        End With
        con.Close()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        con.Close()
    End Sub

    Private Sub loginForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If adminPage IsNot Nothing Then adminPage.Close()
        If mainPage IsNot Nothing Then mainPage.Close()
    End Sub
End Class