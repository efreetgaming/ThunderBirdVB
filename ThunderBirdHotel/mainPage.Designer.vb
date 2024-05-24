<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainPage
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
        Me.components = New System.ComponentModel.Container()
        Dim tmrDateTime As System.Windows.Forms.Timer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainPage))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnReservation = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCheckOut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuest = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCheckIn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChildForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrDateTime
        '
        tmrDateTime.Enabled = True
        tmrDateTime.Interval = 1000
        AddHandler tmrDateTime.Tick, AddressOf Me.tmrDateTime_Tick
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblTime)
        Me.pnlSidebar.Controls.Add(Me.lblDate)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Controls.Add(Me.Label2)
        Me.pnlSidebar.Controls.Add(Me.PictureBox6)
        Me.pnlSidebar.Controls.Add(Me.PictureBox5)
        Me.pnlSidebar.Controls.Add(Me.PictureBox4)
        Me.pnlSidebar.Controls.Add(Me.PictureBox3)
        Me.pnlSidebar.Controls.Add(Me.PictureBox2)
        Me.pnlSidebar.Controls.Add(Me.btnReservation)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnCheckOut)
        Me.pnlSidebar.Controls.Add(Me.btnGuest)
        Me.pnlSidebar.Controls.Add(Me.btnRoom)
        Me.pnlSidebar.Controls.Add(Me.btnCheckIn)
        Me.pnlSidebar.Controls.Add(Me.pnlImage)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.ForeColor = System.Drawing.Color.Gray
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(295, 1151)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.CausesValidation = False
        Me.lblTime.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(90, 1015)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(97, 25)
        Me.lblTime.TabIndex = 47
        Me.lblTime.Text = "Time Here"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.CausesValidation = False
        Me.lblDate.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(90, 979)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(94, 25)
        Me.lblDate.TabIndex = 46
        Me.lblDate.Text = "Date Here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 1015)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 979)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Date "
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(105, 623)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 42
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(105, 779)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 41
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(105, 461)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 40
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(105, 292)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(105, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'btnReservation
        '
        Me.btnReservation.ActiveBorderThickness = 1
        Me.btnReservation.ActiveCornerRadius = 20
        Me.btnReservation.ActiveFillColor = System.Drawing.SystemColors.Menu
        Me.btnReservation.ActiveForecolor = System.Drawing.Color.Black
        Me.btnReservation.ActiveLineColor = System.Drawing.Color.White
        Me.btnReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnReservation.BackgroundImage = CType(resources.GetObject("btnReservation.BackgroundImage"), System.Drawing.Image)
        Me.btnReservation.ButtonText = "Reservation"
        Me.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservation.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.ForeColor = System.Drawing.Color.Black
        Me.btnReservation.IdleBorderThickness = 1
        Me.btnReservation.IdleCornerRadius = 20
        Me.btnReservation.IdleFillColor = System.Drawing.Color.White
        Me.btnReservation.IdleForecolor = System.Drawing.Color.Black
        Me.btnReservation.IdleLineColor = System.Drawing.Color.White
        Me.btnReservation.Location = New System.Drawing.Point(9, 213)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(275, 65)
        Me.btnReservation.TabIndex = 2
        Me.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnLogout.Location = New System.Drawing.Point(4, 1103)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(287, 37)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckOut
        '
        Me.btnCheckOut.ActiveBorderThickness = 1
        Me.btnCheckOut.ActiveCornerRadius = 20
        Me.btnCheckOut.ActiveFillColor = System.Drawing.Color.White
        Me.btnCheckOut.ActiveForecolor = System.Drawing.Color.Black
        Me.btnCheckOut.ActiveLineColor = System.Drawing.Color.White
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCheckOut.BackgroundImage = CType(resources.GetObject("btnCheckOut.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckOut.ButtonText = "Check Out"
        Me.btnCheckOut.CausesValidation = False
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.Black
        Me.btnCheckOut.IdleBorderThickness = 1
        Me.btnCheckOut.IdleCornerRadius = 20
        Me.btnCheckOut.IdleFillColor = System.Drawing.Color.White
        Me.btnCheckOut.IdleForecolor = System.Drawing.Color.Black
        Me.btnCheckOut.IdleLineColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(9, 869)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(275, 60)
        Me.btnCheckOut.TabIndex = 6
        Me.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuest
        '
        Me.btnGuest.ActiveBorderThickness = 1
        Me.btnGuest.ActiveCornerRadius = 20
        Me.btnGuest.ActiveFillColor = System.Drawing.Color.White
        Me.btnGuest.ActiveForecolor = System.Drawing.Color.Black
        Me.btnGuest.ActiveLineColor = System.Drawing.Color.White
        Me.btnGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGuest.BackgroundImage = CType(resources.GetObject("btnGuest.BackgroundImage"), System.Drawing.Image)
        Me.btnGuest.ButtonText = "Guest"
        Me.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuest.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.Black
        Me.btnGuest.IdleBorderThickness = 1
        Me.btnGuest.IdleCornerRadius = 20
        Me.btnGuest.IdleFillColor = System.Drawing.Color.White
        Me.btnGuest.IdleForecolor = System.Drawing.Color.Black
        Me.btnGuest.IdleLineColor = System.Drawing.Color.White
        Me.btnGuest.Location = New System.Drawing.Point(9, 709)
        Me.btnGuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(275, 64)
        Me.btnGuest.TabIndex = 5
        Me.btnGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRoom
        '
        Me.btnRoom.ActiveBorderThickness = 1
        Me.btnRoom.ActiveCornerRadius = 20
        Me.btnRoom.ActiveFillColor = System.Drawing.Color.White
        Me.btnRoom.ActiveForecolor = System.Drawing.Color.Black
        Me.btnRoom.ActiveLineColor = System.Drawing.Color.White
        Me.btnRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnRoom.BackgroundImage = CType(resources.GetObject("btnRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnRoom.ButtonText = "Room Booked"
        Me.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoom.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoom.ForeColor = System.Drawing.Color.Black
        Me.btnRoom.IdleBorderThickness = 1
        Me.btnRoom.IdleCornerRadius = 20
        Me.btnRoom.IdleFillColor = System.Drawing.Color.White
        Me.btnRoom.IdleForecolor = System.Drawing.Color.Black
        Me.btnRoom.IdleLineColor = System.Drawing.Color.White
        Me.btnRoom.Location = New System.Drawing.Point(9, 550)
        Me.btnRoom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(275, 65)
        Me.btnRoom.TabIndex = 4
        Me.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckIn
        '
        Me.btnCheckIn.ActiveBorderThickness = 1
        Me.btnCheckIn.ActiveCornerRadius = 20
        Me.btnCheckIn.ActiveFillColor = System.Drawing.Color.White
        Me.btnCheckIn.ActiveForecolor = System.Drawing.Color.Black
        Me.btnCheckIn.ActiveLineColor = System.Drawing.Color.White
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCheckIn.BackgroundImage = CType(resources.GetObject("btnCheckIn.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckIn.ButtonText = "Check In"
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.Color.Black
        Me.btnCheckIn.IdleBorderThickness = 1
        Me.btnCheckIn.IdleCornerRadius = 20
        Me.btnCheckIn.IdleFillColor = System.Drawing.Color.White
        Me.btnCheckIn.IdleForecolor = System.Drawing.Color.Black
        Me.btnCheckIn.IdleLineColor = System.Drawing.Color.White
        Me.btnCheckIn.Location = New System.Drawing.Point(9, 382)
        Me.btnCheckIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(275, 65)
        Me.btnCheckIn.TabIndex = 3
        Me.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.Maroon
        Me.pnlImage.Controls.Add(Me.PictureBox1)
        Me.pnlImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlImage.Location = New System.Drawing.Point(0, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(295, 103)
        Me.pnlImage.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = Global.ThunderBirdHotel.My.Resources.Resources.thunderfuckers
        Me.PictureBox1.Location = New System.Drawing.Point(79, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlChildForm
        '
        Me.pnlChildForm.BackgroundImage = CType(resources.GetObject("pnlChildForm.BackgroundImage"), System.Drawing.Image)
        Me.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlChildForm.Controls.Add(Me.Panel1)
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildForm.Location = New System.Drawing.Point(295, 0)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(1624, 1151)
        Me.pnlChildForm.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1624, 103)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(732, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 45)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "FRONT DESK"
        '
        'mainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1919, 1151)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainPage"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home | Thunderbird Hotel"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImage.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChildForm.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlImage As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCheckOut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuest As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRoom As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCheckIn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnReservation As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
End Class
