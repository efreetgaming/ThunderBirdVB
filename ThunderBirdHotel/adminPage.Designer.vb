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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnManageUser = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnAcccess = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnManageAddons = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDailyReports = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnManageRooms = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChildForm.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnManageUser)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnAcccess)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnManageAddons)
        Me.Panel1.Controls.Add(Me.btnDailyReports)
        Me.Panel1.Controls.Add(Me.btnManageRooms)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 1151)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.PictureBox1)
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
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(108, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'btnManageUser
        '
        Me.btnManageUser.ActiveBorderThickness = 1
        Me.btnManageUser.ActiveCornerRadius = 20
        Me.btnManageUser.ActiveFillColor = System.Drawing.Color.White
        Me.btnManageUser.ActiveForecolor = System.Drawing.Color.Black
        Me.btnManageUser.ActiveLineColor = System.Drawing.Color.White
        Me.btnManageUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnManageUser.BackgroundImage = CType(resources.GetObject("btnManageUser.BackgroundImage"), System.Drawing.Image)
        Me.btnManageUser.ButtonText = "Manage User"
        Me.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageUser.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUser.ForeColor = System.Drawing.Color.Black
        Me.btnManageUser.IdleBorderThickness = 1
        Me.btnManageUser.IdleCornerRadius = 20
        Me.btnManageUser.IdleFillColor = System.Drawing.Color.White
        Me.btnManageUser.IdleForecolor = System.Drawing.Color.Black
        Me.btnManageUser.IdleLineColor = System.Drawing.Color.White
        Me.btnManageUser.Location = New System.Drawing.Point(13, 256)
        Me.btnManageUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(268, 64)
        Me.btnManageUser.TabIndex = 37
        Me.btnManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(108, 824)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(108, 654)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(108, 330)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(108, 492)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'btnAcccess
        '
        Me.btnAcccess.ActiveBorderThickness = 1
        Me.btnAcccess.ActiveCornerRadius = 20
        Me.btnAcccess.ActiveFillColor = System.Drawing.Color.White
        Me.btnAcccess.ActiveForecolor = System.Drawing.Color.Black
        Me.btnAcccess.ActiveLineColor = System.Drawing.Color.White
        Me.btnAcccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnAcccess.BackgroundImage = CType(resources.GetObject("btnAcccess.BackgroundImage"), System.Drawing.Image)
        Me.btnAcccess.ButtonText = "Access Frontdesk"
        Me.btnAcccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcccess.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcccess.ForeColor = System.Drawing.Color.Black
        Me.btnAcccess.IdleBorderThickness = 1
        Me.btnAcccess.IdleCornerRadius = 20
        Me.btnAcccess.IdleFillColor = System.Drawing.Color.White
        Me.btnAcccess.IdleForecolor = System.Drawing.Color.Black
        Me.btnAcccess.IdleLineColor = System.Drawing.Color.White
        Me.btnAcccess.Location = New System.Drawing.Point(15, 914)
        Me.btnAcccess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAcccess.Name = "btnAcccess"
        Me.btnAcccess.Size = New System.Drawing.Size(268, 71)
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
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.ButtonText = "Logout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.IdleBorderThickness = 1
        Me.btnLogout.IdleCornerRadius = 20
        Me.btnLogout.IdleFillColor = System.Drawing.Color.White
        Me.btnLogout.IdleForecolor = System.Drawing.Color.Black
        Me.btnLogout.IdleLineColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(15, 1079)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(266, 62)
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
        Me.btnManageAddons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnManageAddons.BackgroundImage = CType(resources.GetObject("btnManageAddons.BackgroundImage"), System.Drawing.Image)
        Me.btnManageAddons.ButtonText = "Manage Add-on"
        Me.btnManageAddons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageAddons.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAddons.ForeColor = System.Drawing.Color.Black
        Me.btnManageAddons.IdleBorderThickness = 1
        Me.btnManageAddons.IdleCornerRadius = 20
        Me.btnManageAddons.IdleFillColor = System.Drawing.Color.White
        Me.btnManageAddons.IdleForecolor = System.Drawing.Color.Black
        Me.btnManageAddons.IdleLineColor = System.Drawing.Color.White
        Me.btnManageAddons.Location = New System.Drawing.Point(13, 582)
        Me.btnManageAddons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManageAddons.Name = "btnManageAddons"
        Me.btnManageAddons.Size = New System.Drawing.Size(268, 64)
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
        Me.btnDailyReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDailyReports.BackgroundImage = CType(resources.GetObject("btnDailyReports.BackgroundImage"), System.Drawing.Image)
        Me.btnDailyReports.ButtonText = "Daily Reports"
        Me.btnDailyReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDailyReports.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyReports.ForeColor = System.Drawing.Color.Black
        Me.btnDailyReports.IdleBorderThickness = 1
        Me.btnDailyReports.IdleCornerRadius = 20
        Me.btnDailyReports.IdleFillColor = System.Drawing.Color.White
        Me.btnDailyReports.IdleForecolor = System.Drawing.Color.Black
        Me.btnDailyReports.IdleLineColor = System.Drawing.Color.White
        Me.btnDailyReports.Location = New System.Drawing.Point(13, 744)
        Me.btnDailyReports.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDailyReports.Name = "btnDailyReports"
        Me.btnDailyReports.Size = New System.Drawing.Size(268, 72)
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
        Me.btnManageRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnManageRooms.BackgroundImage = CType(resources.GetObject("btnManageRooms.BackgroundImage"), System.Drawing.Image)
        Me.btnManageRooms.ButtonText = "Manage Rooms"
        Me.btnManageRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageRooms.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageRooms.ForeColor = System.Drawing.Color.Black
        Me.btnManageRooms.IdleBorderThickness = 1
        Me.btnManageRooms.IdleCornerRadius = 20
        Me.btnManageRooms.IdleFillColor = System.Drawing.Color.White
        Me.btnManageRooms.IdleForecolor = System.Drawing.Color.Black
        Me.btnManageRooms.IdleLineColor = System.Drawing.Color.Black
        Me.btnManageRooms.Location = New System.Drawing.Point(13, 420)
        Me.btnManageRooms.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManageRooms.Name = "btnManageRooms"
        Me.btnManageRooms.Size = New System.Drawing.Size(268, 64)
        Me.btnManageRooms.TabIndex = 19
        Me.btnManageRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlChildForm
        '
        Me.pnlChildForm.BackgroundImage = CType(resources.GetObject("pnlChildForm.BackgroundImage"), System.Drawing.Image)
        Me.pnlChildForm.Controls.Add(Me.Panel3)
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildForm.Location = New System.Drawing.Point(295, 0)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(1624, 1151)
        Me.pnlChildForm.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1624, 103)
        Me.Panel3.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(724, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 45)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ADMIN PANEL"
        '
        'adminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1919, 1151)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Name = "adminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChildForm.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnManageAddons As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDailyReports As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnManageRooms As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents btnAcccess As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnManageUser As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
End Class
