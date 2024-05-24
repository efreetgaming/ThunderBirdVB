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
        Dim uname As String = txtUname.Text
        Dim pword As String = txtPword.Text

        Dim query As String = "SELECT Id, Type FROM tbl_users WHERE Username = @Username AND Password = @Password"

        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", uname)
            cmd.Parameters.AddWithValue("@Password", pword)

            con.Open()

            ' Execute the query and retrieve the Id and AccountType
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' The user exists, retrieve the Id and AccountType
                    Dim id As Integer = reader.GetInt32(0)
                    Dim accountType As String = reader.GetString(1)
                    con.Close()
                    ' Perform validation or other actions based on the AccountType
                    If accountType = "Front-Desk" Then
                        txtPword.Clear()
                        txtUname.Clear()

                        con.Close()
                        mainPage.Show()
                        Me.Hide()
                    ElseIf accountType = "Administrator" Then
                        txtPword.Clear()
                        txtUname.Clear()

                        con.Close()
                        adminPage.Show()
                        Me.Hide()
                    Else
                        MsgBox("There is an error - Please seek for the help in administrator")
                        txtPword.Clear()
                        txtUname.Clear()

                        con.Close()
                    End If
                Else
                    MsgBox("Username or Password is incorrect. If the issue still persist, Please seek for the administrator for a help")

                    txtPword.Clear()
                    txtUname.Clear()

                    con.Close()
                End If
            End Using
        End Using
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected")
        con.Close()
    End Sub
End Class