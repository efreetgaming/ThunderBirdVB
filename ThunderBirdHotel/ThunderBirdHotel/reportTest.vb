Imports System.Data.SqlClient

Public Class reportTest
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        opencon()
        Dim dateOne As String
        Dim dateTwo As String

        dateOne = dtpFrom.Value.Month & "-" & dtpFrom.Value.Day & "-" & dtpFrom.Value.Year
        dateTwo = dtpTo.Value.Month & "-" & dtpTo.Value.Day & "-" & dtpTo.Value.Year

        con.Open()

        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from tbl_reports where Date between @dateOne and @dateTwo", con)
        cmd.Parameters.AddWithValue("@dateOne", dateOne)
        cmd.Parameters.AddWithValue("@dateTwo", dateTwo)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        Dim cr As New reports()
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr

        con.Close()

    End Sub
End Class