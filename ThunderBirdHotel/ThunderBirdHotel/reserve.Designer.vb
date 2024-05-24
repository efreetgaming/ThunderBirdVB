<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reserve))
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRCountry = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel26 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRAddress = New System.Windows.Forms.TextBox()
        Me.txtREmail = New System.Windows.Forms.TextBox()
        Me.txtRPostCode = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRName = New System.Windows.Forms.TextBox()
        Me.txtRNumber = New System.Windows.Forms.TextBox()
        Me.txtRState = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel24 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.drpRGender = New System.Windows.Forms.ComboBox()
        Me.dudRChildren = New System.Windows.Forms.NumericUpDown()
        Me.txtRCity = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dudRAdult = New System.Windows.Forms.NumericUpDown()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRRoomNo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRRoomType = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnRCalculate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRAvailRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblRoomRate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpRCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpRCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.btnRReserve = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRClear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.dudRChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dudRAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(553, 9)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(107, 29)
        Me.BunifuCustomLabel14.TabIndex = 39
        Me.BunifuCustomLabel14.Text = "RESERVE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtRCountry)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel26)
        Me.Panel1.Controls.Add(Me.txtRAddress)
        Me.Panel1.Controls.Add(Me.txtREmail)
        Me.Panel1.Controls.Add(Me.txtRPostCode)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel25)
        Me.Panel1.Controls.Add(Me.txtRName)
        Me.Panel1.Controls.Add(Me.txtRNumber)
        Me.Panel1.Controls.Add(Me.txtRState)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel24)
        Me.Panel1.Controls.Add(Me.drpRGender)
        Me.Panel1.Controls.Add(Me.dudRChildren)
        Me.Panel1.Controls.Add(Me.txtRCity)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.dudRAdult)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Location = New System.Drawing.Point(10, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 241)
        Me.Panel1.TabIndex = 40
        '
        'txtRCountry
        '
        Me.txtRCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRCountry.Location = New System.Drawing.Point(839, 163)
        Me.txtRCountry.Name = "txtRCountry"
        Me.txtRCountry.Size = New System.Drawing.Size(331, 26)
        Me.txtRCountry.TabIndex = 47
        '
        'BunifuCustomLabel26
        '
        Me.BunifuCustomLabel26.AutoSize = True
        Me.BunifuCustomLabel26.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel26.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel26.Location = New System.Drawing.Point(555, 159)
        Me.BunifuCustomLabel26.Name = "BunifuCustomLabel26"
        Me.BunifuCustomLabel26.Size = New System.Drawing.Size(106, 29)
        Me.BunifuCustomLabel26.TabIndex = 48
        Me.BunifuCustomLabel26.Text = "Country :"
        '
        'txtRAddress
        '
        Me.txtRAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRAddress.Location = New System.Drawing.Point(201, 199)
        Me.txtRAddress.Name = "txtRAddress"
        Me.txtRAddress.Size = New System.Drawing.Size(969, 26)
        Me.txtRAddress.TabIndex = 38
        '
        'txtREmail
        '
        Me.txtREmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtREmail.Location = New System.Drawing.Point(201, 87)
        Me.txtREmail.Name = "txtREmail"
        Me.txtREmail.Size = New System.Drawing.Size(331, 26)
        Me.txtREmail.TabIndex = 37
        '
        'txtRPostCode
        '
        Me.txtRPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRPostCode.Location = New System.Drawing.Point(839, 125)
        Me.txtRPostCode.Name = "txtRPostCode"
        Me.txtRPostCode.Size = New System.Drawing.Size(331, 26)
        Me.txtRPostCode.TabIndex = 45
        '
        'BunifuCustomLabel25
        '
        Me.BunifuCustomLabel25.AutoSize = True
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(555, 122)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(125, 29)
        Me.BunifuCustomLabel25.TabIndex = 46
        Me.BunifuCustomLabel25.Text = "Post Code :"
        '
        'txtRName
        '
        Me.txtRName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRName.Location = New System.Drawing.Point(201, 13)
        Me.txtRName.Name = "txtRName"
        Me.txtRName.Size = New System.Drawing.Size(331, 26)
        Me.txtRName.TabIndex = 36
        '
        'txtRNumber
        '
        Me.txtRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRNumber.Location = New System.Drawing.Point(201, 49)
        Me.txtRNumber.Name = "txtRNumber"
        Me.txtRNumber.Size = New System.Drawing.Size(331, 26)
        Me.txtRNumber.TabIndex = 35
        '
        'txtRState
        '
        Me.txtRState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRState.Location = New System.Drawing.Point(201, 161)
        Me.txtRState.Name = "txtRState"
        Me.txtRState.Size = New System.Drawing.Size(331, 26)
        Me.txtRState.TabIndex = 43
        '
        'BunifuCustomLabel24
        '
        Me.BunifuCustomLabel24.AutoSize = True
        Me.BunifuCustomLabel24.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel24.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel24.Location = New System.Drawing.Point(18, 158)
        Me.BunifuCustomLabel24.Name = "BunifuCustomLabel24"
        Me.BunifuCustomLabel24.Size = New System.Drawing.Size(79, 29)
        Me.BunifuCustomLabel24.TabIndex = 44
        Me.BunifuCustomLabel24.Text = "State :"
        '
        'drpRGender
        '
        Me.drpRGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpRGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpRGender.FormattingEnabled = True
        Me.drpRGender.Items.AddRange(New Object() {"male", "female"})
        Me.drpRGender.Location = New System.Drawing.Point(839, 87)
        Me.drpRGender.Name = "drpRGender"
        Me.drpRGender.Size = New System.Drawing.Size(331, 26)
        Me.drpRGender.TabIndex = 33
        '
        'dudRChildren
        '
        Me.dudRChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dudRChildren.Location = New System.Drawing.Point(839, 51)
        Me.dudRChildren.Name = "dudRChildren"
        Me.dudRChildren.Size = New System.Drawing.Size(331, 26)
        Me.dudRChildren.TabIndex = 28
        '
        'txtRCity
        '
        Me.txtRCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRCity.Location = New System.Drawing.Point(201, 124)
        Me.txtRCity.Name = "txtRCity"
        Me.txtRCity.Size = New System.Drawing.Size(331, 26)
        Me.txtRCity.TabIndex = 39
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(18, 122)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(64, 29)
        Me.BunifuCustomLabel1.TabIndex = 39
        Me.BunifuCustomLabel1.Text = "City :"
        '
        'dudRAdult
        '
        Me.dudRAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dudRAdult.Location = New System.Drawing.Point(839, 13)
        Me.dudRAdult.Name = "dudRAdult"
        Me.dudRAdult.Size = New System.Drawing.Size(331, 26)
        Me.dudRAdult.TabIndex = 27
        Me.dudRAdult.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(555, 87)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(98, 29)
        Me.BunifuCustomLabel6.TabIndex = 16
        Me.BunifuCustomLabel6.Text = "Gender :"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(555, 48)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(229, 29)
        Me.BunifuCustomLabel7.TabIndex = 15
        Me.BunifuCustomLabel7.Text = "Number of Children : "
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(555, 11)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(200, 29)
        Me.BunifuCustomLabel8.TabIndex = 14
        Me.BunifuCustomLabel8.Text = "Number of Adult : "
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(18, 195)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(106, 29)
        Me.BunifuCustomLabel5.TabIndex = 5
        Me.BunifuCustomLabel5.Text = "Address :"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(18, 85)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(81, 29)
        Me.BunifuCustomLabel4.TabIndex = 4
        Me.BunifuCustomLabel4.Text = "Email :"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(18, 46)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(122, 29)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Phone No :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(18, 10)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(84, 29)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Name :"
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(10, 306)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(252, 29)
        Me.BunifuCustomLabel15.TabIndex = 41
        Me.BunifuCustomLabel15.Text = "ROOM INFORMATION :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblRRoomNo)
        Me.Panel2.Controls.Add(Me.lblRRoomType)
        Me.Panel2.Controls.Add(Me.btnRCalculate)
        Me.Panel2.Controls.Add(Me.btnRAvailRoom)
        Me.Panel2.Controls.Add(Me.lblRoomRate)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel13)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel12)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel2.Controls.Add(Me.dtpRCheckOut)
        Me.Panel2.Controls.Add(Me.dtpRCheckIn)
        Me.Panel2.Location = New System.Drawing.Point(10, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1192, 265)
        Me.Panel2.TabIndex = 42
        '
        'lblRRoomNo
        '
        Me.lblRRoomNo.AutoSize = True
        Me.lblRRoomNo.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRRoomNo.ForeColor = System.Drawing.Color.White
        Me.lblRRoomNo.Location = New System.Drawing.Point(290, 147)
        Me.lblRRoomNo.Name = "lblRRoomNo"
        Me.lblRRoomNo.Size = New System.Drawing.Size(195, 29)
        Me.lblRRoomNo.TabIndex = 65
        Me.lblRRoomNo.Text = "Select A Room No"
        '
        'lblRRoomType
        '
        Me.lblRRoomType.AutoSize = True
        Me.lblRRoomType.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRRoomType.ForeColor = System.Drawing.Color.White
        Me.lblRRoomType.Location = New System.Drawing.Point(289, 103)
        Me.lblRRoomType.Name = "lblRRoomType"
        Me.lblRRoomType.Size = New System.Drawing.Size(215, 29)
        Me.lblRRoomType.TabIndex = 64
        Me.lblRRoomType.Text = "Select A Room Type"
        '
        'btnRCalculate
        '
        Me.btnRCalculate.ActiveBorderThickness = 1
        Me.btnRCalculate.ActiveCornerRadius = 20
        Me.btnRCalculate.ActiveFillColor = System.Drawing.Color.White
        Me.btnRCalculate.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRCalculate.ActiveLineColor = System.Drawing.Color.White
        Me.btnRCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRCalculate.BackgroundImage = CType(resources.GetObject("btnRCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnRCalculate.ButtonText = "Calculate"
        Me.btnRCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCalculate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRCalculate.IdleBorderThickness = 1
        Me.btnRCalculate.IdleCornerRadius = 20
        Me.btnRCalculate.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnRCalculate.IdleForecolor = System.Drawing.Color.White
        Me.btnRCalculate.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRCalculate.Location = New System.Drawing.Point(504, 187)
        Me.btnRCalculate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRCalculate.Name = "btnRCalculate"
        Me.btnRCalculate.Size = New System.Drawing.Size(98, 41)
        Me.btnRCalculate.TabIndex = 57
        Me.btnRCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRAvailRoom
        '
        Me.btnRAvailRoom.ActiveBorderThickness = 1
        Me.btnRAvailRoom.ActiveCornerRadius = 20
        Me.btnRAvailRoom.ActiveFillColor = System.Drawing.Color.White
        Me.btnRAvailRoom.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRAvailRoom.ActiveLineColor = System.Drawing.Color.White
        Me.btnRAvailRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRAvailRoom.BackgroundImage = CType(resources.GetObject("btnRAvailRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnRAvailRoom.ButtonText = "Available Room"
        Me.btnRAvailRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRAvailRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRAvailRoom.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRAvailRoom.IdleBorderThickness = 1
        Me.btnRAvailRoom.IdleCornerRadius = 20
        Me.btnRAvailRoom.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnRAvailRoom.IdleForecolor = System.Drawing.Color.White
        Me.btnRAvailRoom.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRAvailRoom.Location = New System.Drawing.Point(327, 187)
        Me.btnRAvailRoom.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRAvailRoom.Name = "btnRAvailRoom"
        Me.btnRAvailRoom.Size = New System.Drawing.Size(159, 41)
        Me.btnRAvailRoom.TabIndex = 41
        Me.btnRAvailRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblRoomRate.ForeColor = System.Drawing.Color.White
        Me.lblRoomRate.Location = New System.Drawing.Point(289, 187)
        Me.lblRoomRate.Name = "lblRoomRate"
        Me.lblRoomRate.Size = New System.Drawing.Size(30, 36)
        Me.lblRoomRate.TabIndex = 40
        Me.lblRoomRate.Text = "0"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(113, 193)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(136, 29)
        Me.BunifuCustomLabel13.TabIndex = 39
        Me.BunifuCustomLabel13.Text = "Room Rate :"
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(113, 147)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(123, 29)
        Me.BunifuCustomLabel12.TabIndex = 38
        Me.BunifuCustomLabel12.Text = "Room No  :"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(113, 103)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(138, 29)
        Me.BunifuCustomLabel11.TabIndex = 37
        Me.BunifuCustomLabel11.Text = "Room Type :"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(302, 43)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(134, 29)
        Me.BunifuCustomLabel10.TabIndex = 36
        Me.BunifuCustomLabel10.Text = "Check Out  :"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(11, 49)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(110, 29)
        Me.BunifuCustomLabel9.TabIndex = 34
        Me.BunifuCustomLabel9.Text = "Check In :"
        '
        'dtpRCheckOut
        '
        Me.dtpRCheckOut.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckOut.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRCheckOut.Location = New System.Drawing.Point(470, 47)
        Me.dtpRCheckOut.Name = "dtpRCheckOut"
        Me.dtpRCheckOut.Size = New System.Drawing.Size(149, 32)
        Me.dtpRCheckOut.TabIndex = 33
        '
        'dtpRCheckIn
        '
        Me.dtpRCheckIn.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckIn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRCheckIn.Location = New System.Drawing.Point(143, 47)
        Me.dtpRCheckIn.Name = "dtpRCheckIn"
        Me.dtpRCheckIn.Size = New System.Drawing.Size(149, 32)
        Me.dtpRCheckIn.TabIndex = 32
        '
        'btnRReserve
        '
        Me.btnRReserve.ActiveBorderThickness = 1
        Me.btnRReserve.ActiveCornerRadius = 20
        Me.btnRReserve.ActiveFillColor = System.Drawing.Color.White
        Me.btnRReserve.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRReserve.ActiveLineColor = System.Drawing.Color.White
        Me.btnRReserve.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRReserve.BackgroundImage = CType(resources.GetObject("btnRReserve.BackgroundImage"), System.Drawing.Image)
        Me.btnRReserve.ButtonText = "Reserve"
        Me.btnRReserve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRReserve.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRReserve.IdleBorderThickness = 1
        Me.btnRReserve.IdleCornerRadius = 20
        Me.btnRReserve.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnRReserve.IdleForecolor = System.Drawing.Color.White
        Me.btnRReserve.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRReserve.Location = New System.Drawing.Point(1016, 621)
        Me.btnRReserve.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRReserve.Name = "btnRReserve"
        Me.btnRReserve.Size = New System.Drawing.Size(181, 41)
        Me.btnRReserve.TabIndex = 62
        Me.btnRReserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRClear
        '
        Me.btnRClear.ActiveBorderThickness = 1
        Me.btnRClear.ActiveCornerRadius = 20
        Me.btnRClear.ActiveFillColor = System.Drawing.Color.White
        Me.btnRClear.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRClear.ActiveLineColor = System.Drawing.Color.White
        Me.btnRClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRClear.BackgroundImage = CType(resources.GetObject("btnRClear.BackgroundImage"), System.Drawing.Image)
        Me.btnRClear.ButtonText = "Clear"
        Me.btnRClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRClear.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRClear.IdleBorderThickness = 1
        Me.btnRClear.IdleCornerRadius = 20
        Me.btnRClear.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnRClear.IdleForecolor = System.Drawing.Color.White
        Me.btnRClear.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRClear.Location = New System.Drawing.Point(815, 621)
        Me.btnRClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRClear.Name = "btnRClear"
        Me.btnRClear.Size = New System.Drawing.Size(181, 41)
        Me.btnRClear.TabIndex = 39
        Me.btnRClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(825, 631)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(158, 20)
        Me.dtpDate.TabIndex = 66
        '
        'reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1211, 672)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuCustomLabel15)
        Me.Controls.Add(Me.btnRReserve)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRClear)
        Me.Controls.Add(Me.BunifuCustomLabel14)
        Me.Controls.Add(Me.dtpDate)
        Me.Name = "reserve"
        Me.Text = "reserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dudRChildren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dudRAdult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRAddress As TextBox
    Friend WithEvents txtREmail As TextBox
    Friend WithEvents txtRName As TextBox
    Friend WithEvents txtRNumber As TextBox
    Friend WithEvents drpRGender As ComboBox
    Friend WithEvents dudRChildren As NumericUpDown
    Friend WithEvents dudRAdult As NumericUpDown
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRReserve As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRClear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRCalculate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRAvailRoom As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblRoomRate As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpRCheckOut As DateTimePicker
    Friend WithEvents dtpRCheckIn As DateTimePicker
    Friend WithEvents lblRRoomNo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRRoomType As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRCity As TextBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRState As TextBox
    Friend WithEvents BunifuCustomLabel24 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRPostCode As TextBox
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRCountry As TextBox
    Friend WithEvents BunifuCustomLabel26 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpDate As DateTimePicker
End Class
