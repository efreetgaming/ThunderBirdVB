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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainPage))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCheckOut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuest = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCheckIn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnReservation = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.Label6)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.Label5)
        Me.pnlSidebar.Controls.Add(Me.Label4)
        Me.pnlSidebar.Controls.Add(Me.btnCheckOut)
        Me.pnlSidebar.Controls.Add(Me.Label3)
        Me.pnlSidebar.Controls.Add(Me.btnGuest)
        Me.pnlSidebar.Controls.Add(Me.Label2)
        Me.pnlSidebar.Controls.Add(Me.btnRoom)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Controls.Add(Me.btnCheckIn)
        Me.pnlSidebar.Controls.Add(Me.btnReservation)
        Me.pnlSidebar.Controls.Add(Me.pnlImage)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.ForeColor = System.Drawing.Color.Gray
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(295, 760)
        Me.pnlSidebar.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(135, 628)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "POSITION"
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
        Me.btnLogout.Location = New System.Drawing.Point(5, 711)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(287, 37)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(146, 598)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(144, 569)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "NAME"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.ActiveBorderThickness = 1
        Me.btnCheckOut.ActiveCornerRadius = 20
        Me.btnCheckOut.ActiveFillColor = System.Drawing.Color.White
        Me.btnCheckOut.ActiveForecolor = System.Drawing.Color.Black
        Me.btnCheckOut.ActiveLineColor = System.Drawing.Color.White
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheckOut.BackgroundImage = CType(resources.GetObject("btnCheckOut.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckOut.ButtonText = "Check Out"
        Me.btnCheckOut.CausesValidation = False
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckOut.ForeColor = System.Drawing.Color.Black
        Me.btnCheckOut.IdleBorderThickness = 1
        Me.btnCheckOut.IdleCornerRadius = 20
        Me.btnCheckOut.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.IdleForecolor = System.Drawing.Color.White
        Me.btnCheckOut.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.Location = New System.Drawing.Point(5, 434)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(287, 37)
        Me.btnCheckOut.TabIndex = 6
        Me.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 628)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Position : "
        '
        'btnGuest
        '
        Me.btnGuest.ActiveBorderThickness = 1
        Me.btnGuest.ActiveCornerRadius = 20
        Me.btnGuest.ActiveFillColor = System.Drawing.Color.White
        Me.btnGuest.ActiveForecolor = System.Drawing.Color.Black
        Me.btnGuest.ActiveLineColor = System.Drawing.Color.White
        Me.btnGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuest.BackgroundImage = CType(resources.GetObject("btnGuest.BackgroundImage"), System.Drawing.Image)
        Me.btnGuest.ButtonText = "Guest"
        Me.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuest.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuest.ForeColor = System.Drawing.Color.Black
        Me.btnGuest.IdleBorderThickness = 1
        Me.btnGuest.IdleCornerRadius = 20
        Me.btnGuest.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnGuest.IdleForecolor = System.Drawing.Color.White
        Me.btnGuest.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnGuest.Location = New System.Drawing.Point(5, 387)
        Me.btnGuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(287, 37)
        Me.btnGuest.TabIndex = 5
        Me.btnGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 598)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Date : "
        '
        'btnRoom
        '
        Me.btnRoom.ActiveBorderThickness = 1
        Me.btnRoom.ActiveCornerRadius = 20
        Me.btnRoom.ActiveFillColor = System.Drawing.Color.White
        Me.btnRoom.ActiveForecolor = System.Drawing.Color.Black
        Me.btnRoom.ActiveLineColor = System.Drawing.Color.White
        Me.btnRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRoom.BackgroundImage = CType(resources.GetObject("btnRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnRoom.ButtonText = "Room Booked"
        Me.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoom.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRoom.ForeColor = System.Drawing.Color.Black
        Me.btnRoom.IdleBorderThickness = 1
        Me.btnRoom.IdleCornerRadius = 20
        Me.btnRoom.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnRoom.IdleForecolor = System.Drawing.Color.White
        Me.btnRoom.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnRoom.Location = New System.Drawing.Point(5, 340)
        Me.btnRoom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(287, 37)
        Me.btnRoom.TabIndex = 4
        Me.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 569)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Name : "
        '
        'btnCheckIn
        '
        Me.btnCheckIn.ActiveBorderThickness = 1
        Me.btnCheckIn.ActiveCornerRadius = 20
        Me.btnCheckIn.ActiveFillColor = System.Drawing.Color.White
        Me.btnCheckIn.ActiveForecolor = System.Drawing.Color.Black
        Me.btnCheckIn.ActiveLineColor = System.Drawing.Color.White
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheckIn.BackgroundImage = CType(resources.GetObject("btnCheckIn.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckIn.ButtonText = "Check In"
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIn.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckIn.ForeColor = System.Drawing.Color.Black
        Me.btnCheckIn.IdleBorderThickness = 1
        Me.btnCheckIn.IdleCornerRadius = 20
        Me.btnCheckIn.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.IdleForecolor = System.Drawing.Color.White
        Me.btnCheckIn.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.Location = New System.Drawing.Point(5, 293)
        Me.btnCheckIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(287, 37)
        Me.btnCheckIn.TabIndex = 3
        Me.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReservation
        '
        Me.btnReservation.ActiveBorderThickness = 1
        Me.btnReservation.ActiveCornerRadius = 20
        Me.btnReservation.ActiveFillColor = System.Drawing.Color.White
        Me.btnReservation.ActiveForecolor = System.Drawing.Color.Black
        Me.btnReservation.ActiveLineColor = System.Drawing.Color.White
        Me.btnReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReservation.BackgroundImage = CType(resources.GetObject("btnReservation.BackgroundImage"), System.Drawing.Image)
        Me.btnReservation.ButtonText = "Reservation"
        Me.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservation.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReservation.ForeColor = System.Drawing.Color.Black
        Me.btnReservation.IdleBorderThickness = 1
        Me.btnReservation.IdleCornerRadius = 20
        Me.btnReservation.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnReservation.IdleForecolor = System.Drawing.Color.White
        Me.btnReservation.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnReservation.Location = New System.Drawing.Point(5, 246)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(287, 37)
        Me.btnReservation.TabIndex = 2
        Me.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildForm.Location = New System.Drawing.Point(295, 0)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(1214, 760)
        Me.pnlChildForm.TabIndex = 1
        '
        'mainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 760)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home | Thunderbird Hotel"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlImage.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
