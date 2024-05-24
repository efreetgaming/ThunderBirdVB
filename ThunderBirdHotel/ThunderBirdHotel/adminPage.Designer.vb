<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAcccess = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnManageAddons = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDailyReports = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnManageRooms = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnManageUser = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAcccess)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnManageAddons)
        Me.Panel1.Controls.Add(Me.btnDailyReports)
        Me.Panel1.Controls.Add(Me.btnManageRooms)
        Me.Panel1.Controls.Add(Me.btnManageUser)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 760)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(135, 629)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "POSITION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(146, 599)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(144, 570)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 629)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Position : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 599)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Date : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 570)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name : "
        '
        'btnAcccess
        '
        Me.btnAcccess.ActiveBorderThickness = 1
        Me.btnAcccess.ActiveCornerRadius = 20
        Me.btnAcccess.ActiveFillColor = System.Drawing.Color.White
        Me.btnAcccess.ActiveForecolor = System.Drawing.Color.Black
        Me.btnAcccess.ActiveLineColor = System.Drawing.Color.White
        Me.btnAcccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAcccess.BackgroundImage = CType(resources.GetObject("btnAcccess.BackgroundImage"), System.Drawing.Image)
        Me.btnAcccess.ButtonText = "Access Frontdesk"
        Me.btnAcccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcccess.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAcccess.ForeColor = System.Drawing.Color.Black
        Me.btnAcccess.IdleBorderThickness = 1
        Me.btnAcccess.IdleCornerRadius = 20
        Me.btnAcccess.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnAcccess.IdleForecolor = System.Drawing.Color.White
        Me.btnAcccess.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnAcccess.Location = New System.Drawing.Point(4, 401)
        Me.btnAcccess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAcccess.Name = "btnAcccess"
        Me.btnAcccess.Size = New System.Drawing.Size(287, 37)
        Me.btnAcccess.TabIndex = 25
        Me.btnAcccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.ActiveBorderThickness = 1
        Me.btnLogout.ActiveCornerRadius = 20
        Me.btnLogout.ActiveFillColor = System.Drawing.Color.White
        Me.btnLogout.ActiveForecolor = System.Drawing.Color.Black
        Me.btnLogout.ActiveLineColor = System.Drawing.Color.White
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.ButtonText = "Logout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.IdleBorderThickness = 1
        Me.btnLogout.IdleCornerRadius = 20
        Me.btnLogout.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnLogout.IdleForecolor = System.Drawing.Color.White
        Me.btnLogout.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnLogout.Location = New System.Drawing.Point(4, 709)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(287, 37)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnManageAddons
        '
        Me.btnManageAddons.ActiveBorderThickness = 1
        Me.btnManageAddons.ActiveCornerRadius = 20
        Me.btnManageAddons.ActiveFillColor = System.Drawing.Color.White
        Me.btnManageAddons.ActiveForecolor = System.Drawing.Color.Black
        Me.btnManageAddons.ActiveLineColor = System.Drawing.Color.White
        Me.btnManageAddons.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnManageAddons.BackgroundImage = CType(resources.GetObject("btnManageAddons.BackgroundImage"), System.Drawing.Image)
        Me.btnManageAddons.ButtonText = "Manage Add-on"
        Me.btnManageAddons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageAddons.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageAddons.ForeColor = System.Drawing.Color.Black
        Me.btnManageAddons.IdleBorderThickness = 1
        Me.btnManageAddons.IdleCornerRadius = 20
        Me.btnManageAddons.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnManageAddons.IdleForecolor = System.Drawing.Color.White
        Me.btnManageAddons.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnManageAddons.Location = New System.Drawing.Point(4, 307)
        Me.btnManageAddons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManageAddons.Name = "btnManageAddons"
        Me.btnManageAddons.Size = New System.Drawing.Size(287, 37)
        Me.btnManageAddons.TabIndex = 23
        Me.btnManageAddons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDailyReports
        '
        Me.btnDailyReports.ActiveBorderThickness = 1
        Me.btnDailyReports.ActiveCornerRadius = 20
        Me.btnDailyReports.ActiveFillColor = System.Drawing.Color.White
        Me.btnDailyReports.ActiveForecolor = System.Drawing.Color.Black
        Me.btnDailyReports.ActiveLineColor = System.Drawing.Color.White
        Me.btnDailyReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDailyReports.BackgroundImage = CType(resources.GetObject("btnDailyReports.BackgroundImage"), System.Drawing.Image)
        Me.btnDailyReports.ButtonText = "Daily Reports"
        Me.btnDailyReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDailyReports.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDailyReports.ForeColor = System.Drawing.Color.Black
        Me.btnDailyReports.IdleBorderThickness = 1
        Me.btnDailyReports.IdleCornerRadius = 20
        Me.btnDailyReports.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnDailyReports.IdleForecolor = System.Drawing.Color.White
        Me.btnDailyReports.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnDailyReports.Location = New System.Drawing.Point(4, 354)
        Me.btnDailyReports.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDailyReports.Name = "btnDailyReports"
        Me.btnDailyReports.Size = New System.Drawing.Size(287, 37)
        Me.btnDailyReports.TabIndex = 20
        Me.btnDailyReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnManageRooms
        '
        Me.btnManageRooms.ActiveBorderThickness = 1
        Me.btnManageRooms.ActiveCornerRadius = 20
        Me.btnManageRooms.ActiveFillColor = System.Drawing.Color.White
        Me.btnManageRooms.ActiveForecolor = System.Drawing.Color.Black
        Me.btnManageRooms.ActiveLineColor = System.Drawing.Color.White
        Me.btnManageRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnManageRooms.BackgroundImage = CType(resources.GetObject("btnManageRooms.BackgroundImage"), System.Drawing.Image)
        Me.btnManageRooms.ButtonText = "Manage Rooms"
        Me.btnManageRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageRooms.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageRooms.ForeColor = System.Drawing.Color.Black
        Me.btnManageRooms.IdleBorderThickness = 1
        Me.btnManageRooms.IdleCornerRadius = 20
        Me.btnManageRooms.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnManageRooms.IdleForecolor = System.Drawing.Color.White
        Me.btnManageRooms.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnManageRooms.Location = New System.Drawing.Point(4, 260)
        Me.btnManageRooms.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManageRooms.Name = "btnManageRooms"
        Me.btnManageRooms.Size = New System.Drawing.Size(287, 37)
        Me.btnManageRooms.TabIndex = 19
        Me.btnManageRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnManageUser
        '
        Me.btnManageUser.ActiveBorderThickness = 1
        Me.btnManageUser.ActiveCornerRadius = 20
        Me.btnManageUser.ActiveFillColor = System.Drawing.Color.White
        Me.btnManageUser.ActiveForecolor = System.Drawing.Color.Black
        Me.btnManageUser.ActiveLineColor = System.Drawing.Color.White
        Me.btnManageUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnManageUser.BackgroundImage = CType(resources.GetObject("btnManageUser.BackgroundImage"), System.Drawing.Image)
        Me.btnManageUser.ButtonText = "Manage User"
        Me.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageUser.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageUser.ForeColor = System.Drawing.Color.Black
        Me.btnManageUser.IdleBorderThickness = 1
        Me.btnManageUser.IdleCornerRadius = 20
        Me.btnManageUser.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnManageUser.IdleForecolor = System.Drawing.Color.White
        Me.btnManageUser.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnManageUser.Location = New System.Drawing.Point(4, 213)
        Me.btnManageUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(287, 37)
        Me.btnManageUser.TabIndex = 18
        Me.btnManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 103)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = Global.ThunderBirdHotel.My.Resources.Resources.thunderfuckers
        Me.PictureBox1.Location = New System.Drawing.Point(78, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'pnlChildForm
        '
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildForm.Location = New System.Drawing.Point(295, 0)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(1214, 760)
        Me.pnlChildForm.TabIndex = 1
        '
        'adminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 760)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Name = "adminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnManageAddons As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDailyReports As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnManageRooms As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnManageUser As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents btnAcccess As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
