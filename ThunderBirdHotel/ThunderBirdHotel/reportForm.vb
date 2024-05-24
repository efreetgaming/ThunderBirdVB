Imports System.Data.SqlClient

Public Class reportForm
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    'Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
    '    Dim dateOne As String
    '    Dim dateTwo As String

    '    dateOne = dtpFrom.Value.ToString("yyyy-MM-dd")

    '    dateTwo = dtpTo.Value.ToString("yyyy-MM-dd")

    '    Dim query As String = "Select * from tbl_reports where Date between @dateOne and @dateTwo"
    '    Using cmd As SqlCommand = New SqlCommand(query, con)
    '        cmd.Parameters.AddWithValue("@dateOne", dateOne)
    '        cmd.Parameters.AddWithValue("@dateTwo", dateTwo)
    '        Using da As New SqlDataAdapter
    '            da.SelectCommand = cmd
    '            Using dt As New DataTable()
    '                da.Fill(dt)
    '                If CrystalReportViewer1 IsNot Nothing Then
    '                    Dim cr As New CrystalReport1()
    '                    cr.SetDataSource(dt)
    '                    CrystalReportViewer1.ReportSource = dt
    '                End If
    '            End Using
    '        End Using
    '    End Using
    'End Sub

End Class