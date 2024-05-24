Imports System.Data.SqlClient

Public Class reportsNaten
    Dim connection As New SqlConnection("Data Source=VALIARES;Initial Catalog=DBHotelManagement;Integrated Security=true")

    Private Sub btnReportGenerate_Click(sender As Object, e As EventArgs) Handles btnReportGenerate.Click
        ComputeTotalValue()
    End Sub

    Private Sub ComputeTotalValue()
        If dtpfrom.Value > dtpTo.Value Then
            MessageBox.Show("Invalid date range. From date cannot be greater than To date.")
            Return
        End If

        Dim dateOne As String = dtpfrom.Value.Month & "-" & dtpfrom.Value.Day & "-" & dtpfrom.Value.Year
        Dim dateTwo As String = dtpTo.Value.Month & "-" & dtpTo.Value.Day & "-" & dtpTo.Value.Year

        connection.Open()

        Dim totalValue As Integer
        Dim cmd As New SqlCommand("SELECT ISNULL(SUM(TRY_CONVERT(int, Total_Price)), 0) FROM tbl_reports WHERE Date BETWEEN @dateOne AND @dateTwo AND Total_Price IS NOT NULL AND Total_Price <> ''", connection)
        cmd.Parameters.AddWithValue("@dateOne", dateOne)
        cmd.Parameters.AddWithValue("@dateTwo", dateTwo)
        totalValue = 0
        totalValue = CInt(cmd.ExecuteScalar())

        Dim dt As New DataTable()
        Dim cmd2 As New SqlCommand("SELECT * FROM tbl_reports WHERE Date BETWEEN @dateOne AND @dateTwo", connection)
        cmd2.Parameters.AddWithValue("@dateOne", dateOne)
        cmd2.Parameters.AddWithValue("@dateTwo", dateTwo)
        Dim da As New SqlDataAdapter(cmd2)
        da.Fill(dt)

        Dim cr As New newlyReports()
        cr.SetDataSource(dt)
        cr.SetParameterValue("TotalValue", totalValue)
        CrystalReportViewer1.ReportSource = cr

        connection.Close()

        Dim reportDataSet As New reportsDataSet()
        reportDataSet.EnforceConstraints = False
    End Sub

End Class