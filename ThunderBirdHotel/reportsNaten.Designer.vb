<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsNaten
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportsNaten))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReportGenerate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.newlyReports1 = New ThunderBirdHotel.newlyReports()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(734, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REPORTS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1624, 100)
        Me.Panel1.TabIndex = 63
        '
        'btnReportGenerate
        '
        Me.btnReportGenerate.ActiveBorderThickness = 1
        Me.btnReportGenerate.ActiveCornerRadius = 20
        Me.btnReportGenerate.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnReportGenerate.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnReportGenerate.ActiveLineColor = System.Drawing.Color.White
        Me.btnReportGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReportGenerate.BackgroundImage = CType(resources.GetObject("btnReportGenerate.BackgroundImage"), System.Drawing.Image)
        Me.btnReportGenerate.ButtonText = "Generate Report"
        Me.btnReportGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportGenerate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportGenerate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnReportGenerate.IdleBorderThickness = 1
        Me.btnReportGenerate.IdleCornerRadius = 20
        Me.btnReportGenerate.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnReportGenerate.IdleForecolor = System.Drawing.Color.White
        Me.btnReportGenerate.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnReportGenerate.Location = New System.Drawing.Point(939, 108)
        Me.btnReportGenerate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReportGenerate.Name = "btnReportGenerate"
        Me.btnReportGenerate.Size = New System.Drawing.Size(181, 70)
        Me.btnReportGenerate.TabIndex = 65
        Me.btnReportGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfrom
        '
        Me.dtpfrom.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(420, 123)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(176, 42)
        Me.dtpfrom.TabIndex = 66
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(709, 123)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(176, 42)
        Me.dtpTo.TabIndex = 67
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 206)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.newlyReports1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1624, 943)
        Me.CrystalReportViewer1.TabIndex = 68
        '
        'reportsNaten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1624, 1151)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpfrom)
        Me.Controls.Add(Me.btnReportGenerate)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportsNaten"
        Me.Text = "reportsNaten"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReportGenerate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents newlyReports1 As newlyReports


End Class
