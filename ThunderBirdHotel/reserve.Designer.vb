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
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpArrivalTime = New System.Windows.Forms.DateTimePicker()
        Me.btnCalculate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDownpayment = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.lblRRoomNo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRRoomType = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnRAvailRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblRRoomRate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpRCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpRCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.lblRSubtractDate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRRoomRatingRoom = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnRReserve = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRClear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dudRChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dudRAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(462, 31)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(242, 35)
        Me.BunifuCustomLabel14.TabIndex = 39
        Me.BunifuCustomLabel14.Text = "RESERVATION FORM"
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
        Me.Panel1.Location = New System.Drawing.Point(10, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 241)
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
        Me.BunifuCustomLabel26.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel26.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel26.Location = New System.Drawing.Point(555, 159)
        Me.BunifuCustomLabel26.Name = "BunifuCustomLabel26"
        Me.BunifuCustomLabel26.Size = New System.Drawing.Size(108, 33)
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
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(555, 122)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(128, 33)
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
        Me.BunifuCustomLabel24.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel24.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel24.Location = New System.Drawing.Point(18, 158)
        Me.BunifuCustomLabel24.Name = "BunifuCustomLabel24"
        Me.BunifuCustomLabel24.Size = New System.Drawing.Size(82, 33)
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
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(18, 122)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(66, 33)
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
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(555, 87)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(103, 33)
        Me.BunifuCustomLabel6.TabIndex = 16
        Me.BunifuCustomLabel6.Text = "Gender :"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(555, 48)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(237, 33)
        Me.BunifuCustomLabel7.TabIndex = 15
        Me.BunifuCustomLabel7.Text = "Number of Children : "
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(555, 11)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(204, 33)
        Me.BunifuCustomLabel8.TabIndex = 14
        Me.BunifuCustomLabel8.Text = "Number of Adult : "
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(18, 195)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(112, 33)
        Me.BunifuCustomLabel5.TabIndex = 5
        Me.BunifuCustomLabel5.Text = "Address :"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(18, 85)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(85, 33)
        Me.BunifuCustomLabel4.TabIndex = 4
        Me.BunifuCustomLabel4.Text = "Email :"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(18, 46)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(124, 33)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Phone No :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(18, 10)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(87, 33)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Name :"
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(18, 19)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(214, 29)
        Me.BunifuCustomLabel15.TabIndex = 41
        Me.BunifuCustomLabel15.Text = "ROOM INFORMATION :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel19)
        Me.Panel2.Controls.Add(Me.txtPayment)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel18)
        Me.Panel2.Controls.Add(Me.dtpArrivalTime)
        Me.Panel2.Controls.Add(Me.btnCalculate)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel17)
        Me.Panel2.Controls.Add(Me.txtDownpayment)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel16)
        Me.Panel2.Controls.Add(Me.txtReference)
        Me.Panel2.Controls.Add(Me.lblRRoomNo)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel15)
        Me.Panel2.Controls.Add(Me.lblRRoomType)
        Me.Panel2.Controls.Add(Me.btnRAvailRoom)
        Me.Panel2.Controls.Add(Me.lblRRoomRate)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel13)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel12)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel2.Controls.Add(Me.dtpRCheckOut)
        Me.Panel2.Controls.Add(Me.dtpRCheckIn)
        Me.Panel2.Controls.Add(Me.lblRSubtractDate)
        Me.Panel2.Controls.Add(Me.lblRRoomRatingRoom)
        Me.Panel2.Location = New System.Drawing.Point(12, 371)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1181, 189)
        Me.Panel2.TabIndex = 42
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(947, 108)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(94, 29)
        Me.BunifuCustomLabel19.TabIndex = 76
        Me.BunifuCustomLabel19.Text = "Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPayment.Location = New System.Drawing.Point(952, 148)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(192, 26)
        Me.txtPayment.TabIndex = 75
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(18, 146)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(226, 29)
        Me.BunifuCustomLabel18.TabIndex = 74
        Me.BunifuCustomLabel18.Text = "Planned Arrival Time  :"
        '
        'dtpArrivalTime
        '
        Me.dtpArrivalTime.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpArrivalTime.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpArrivalTime.Location = New System.Drawing.Point(250, 148)
        Me.dtpArrivalTime.Name = "dtpArrivalTime"
        Me.dtpArrivalTime.Size = New System.Drawing.Size(149, 32)
        Me.dtpArrivalTime.TabIndex = 73
        '
        'btnCalculate
        '
        Me.btnCalculate.ActiveBorderThickness = 1
        Me.btnCalculate.ActiveCornerRadius = 20
        Me.btnCalculate.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnCalculate.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnCalculate.ActiveLineColor = System.Drawing.Color.White
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.ButtonText = "Calculate"
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCalculate.IdleBorderThickness = 1
        Me.btnCalculate.IdleCornerRadius = 20
        Me.btnCalculate.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnCalculate.IdleForecolor = System.Drawing.Color.White
        Me.btnCalculate.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnCalculate.Location = New System.Drawing.Point(963, 57)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(181, 41)
        Me.btnCalculate.TabIndex = 72
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(726, 108)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(145, 29)
        Me.BunifuCustomLabel17.TabIndex = 69
        Me.BunifuCustomLabel17.Text = "Downpayment"
        '
        'txtDownpayment
        '
        Me.txtDownpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDownpayment.Location = New System.Drawing.Point(731, 148)
        Me.txtDownpayment.Name = "txtDownpayment"
        Me.txtDownpayment.ReadOnly = True
        Me.txtDownpayment.Size = New System.Drawing.Size(192, 26)
        Me.txtDownpayment.TabIndex = 68
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(726, 25)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(156, 29)
        Me.BunifuCustomLabel16.TabIndex = 67
        Me.BunifuCustomLabel16.Text = "Reference No. :"
        '
        'txtReference
        '
        Me.txtReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtReference.Location = New System.Drawing.Point(731, 65)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(192, 26)
        Me.txtReference.TabIndex = 49
        '
        'lblRRoomNo
        '
        Me.lblRRoomNo.AutoSize = True
        Me.lblRRoomNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRRoomNo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRoomNo.ForeColor = System.Drawing.Color.Black
        Me.lblRRoomNo.Location = New System.Drawing.Point(466, 69)
        Me.lblRRoomNo.Name = "lblRRoomNo"
        Me.lblRRoomNo.Size = New System.Drawing.Size(181, 29)
        Me.lblRRoomNo.TabIndex = 65
        Me.lblRRoomNo.Text = "Select A Room No"
        '
        'lblRRoomType
        '
        Me.lblRRoomType.AutoSize = True
        Me.lblRRoomType.BackColor = System.Drawing.Color.Transparent
        Me.lblRRoomType.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRoomType.ForeColor = System.Drawing.Color.Black
        Me.lblRRoomType.Location = New System.Drawing.Point(465, 25)
        Me.lblRRoomType.Name = "lblRRoomType"
        Me.lblRRoomType.Size = New System.Drawing.Size(197, 29)
        Me.lblRRoomType.TabIndex = 64
        Me.lblRRoomType.Text = "Select A Room Type"
        '
        'btnRAvailRoom
        '
        Me.btnRAvailRoom.ActiveBorderThickness = 1
        Me.btnRAvailRoom.ActiveCornerRadius = 20
        Me.btnRAvailRoom.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnRAvailRoom.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRAvailRoom.ActiveLineColor = System.Drawing.Color.White
        Me.btnRAvailRoom.BackColor = System.Drawing.Color.White
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
        Me.btnRAvailRoom.Location = New System.Drawing.Point(441, 143)
        Me.btnRAvailRoom.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRAvailRoom.Name = "btnRAvailRoom"
        Me.btnRAvailRoom.Size = New System.Drawing.Size(181, 41)
        Me.btnRAvailRoom.TabIndex = 41
        Me.btnRAvailRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRRoomRate
        '
        Me.lblRRoomRate.AutoSize = True
        Me.lblRRoomRate.BackColor = System.Drawing.Color.Transparent
        Me.lblRRoomRate.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRoomRate.ForeColor = System.Drawing.Color.Black
        Me.lblRRoomRate.Location = New System.Drawing.Point(465, 109)
        Me.lblRRoomRate.Name = "lblRRoomRate"
        Me.lblRRoomRate.Size = New System.Drawing.Size(25, 29)
        Me.lblRRoomRate.TabIndex = 40
        Me.lblRRoomRate.Text = "0"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(334, 115)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(125, 29)
        Me.BunifuCustomLabel13.TabIndex = 39
        Me.BunifuCustomLabel13.Text = "Room Rate :"
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(334, 69)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(114, 29)
        Me.BunifuCustomLabel12.TabIndex = 38
        Me.BunifuCustomLabel12.Text = "Room No  :"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(334, 25)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(124, 29)
        Me.BunifuCustomLabel11.TabIndex = 37
        Me.BunifuCustomLabel11.Text = "Room Type :"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(18, 102)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(125, 29)
        Me.BunifuCustomLabel10.TabIndex = 36
        Me.BunifuCustomLabel10.Text = "Check Out  :"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(18, 57)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(105, 29)
        Me.BunifuCustomLabel9.TabIndex = 34
        Me.BunifuCustomLabel9.Text = "Check In :"
        '
        'dtpRCheckOut
        '
        Me.dtpRCheckOut.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckOut.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRCheckOut.Location = New System.Drawing.Point(158, 102)
        Me.dtpRCheckOut.Name = "dtpRCheckOut"
        Me.dtpRCheckOut.Size = New System.Drawing.Size(149, 32)
        Me.dtpRCheckOut.TabIndex = 33
        '
        'dtpRCheckIn
        '
        Me.dtpRCheckIn.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckIn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRCheckIn.Location = New System.Drawing.Point(158, 57)
        Me.dtpRCheckIn.Name = "dtpRCheckIn"
        Me.dtpRCheckIn.Size = New System.Drawing.Size(149, 32)
        Me.dtpRCheckIn.TabIndex = 32
        '
        'lblRSubtractDate
        '
        Me.lblRSubtractDate.AutoSize = True
        Me.lblRSubtractDate.BackColor = System.Drawing.Color.Transparent
        Me.lblRSubtractDate.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSubtractDate.ForeColor = System.Drawing.Color.Black
        Me.lblRSubtractDate.Location = New System.Drawing.Point(832, 148)
        Me.lblRSubtractDate.Name = "lblRSubtractDate"
        Me.lblRSubtractDate.Size = New System.Drawing.Size(25, 29)
        Me.lblRSubtractDate.TabIndex = 71
        Me.lblRSubtractDate.Text = "0"
        '
        'lblRRoomRatingRoom
        '
        Me.lblRRoomRatingRoom.AutoSize = True
        Me.lblRRoomRatingRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblRRoomRatingRoom.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRoomRatingRoom.ForeColor = System.Drawing.Color.Black
        Me.lblRRoomRatingRoom.Location = New System.Drawing.Point(765, 148)
        Me.lblRRoomRatingRoom.Name = "lblRRoomRatingRoom"
        Me.lblRRoomRatingRoom.Size = New System.Drawing.Size(25, 29)
        Me.lblRRoomRatingRoom.TabIndex = 70
        Me.lblRRoomRatingRoom.Text = "0"
        '
        'btnRReserve
        '
        Me.btnRReserve.ActiveBorderThickness = 1
        Me.btnRReserve.ActiveCornerRadius = 20
        Me.btnRReserve.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnRReserve.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRReserve.ActiveLineColor = System.Drawing.Color.White
        Me.btnRReserve.BackColor = System.Drawing.Color.White
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
        Me.btnRReserve.Location = New System.Drawing.Point(1012, 568)
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
        Me.btnRClear.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnRClear.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRClear.ActiveLineColor = System.Drawing.Color.White
        Me.btnRClear.BackColor = System.Drawing.Color.White
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
        Me.btnRClear.Location = New System.Drawing.Point(821, 568)
        Me.btnRClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRClear.Name = "btnRClear"
        Me.btnRClear.Size = New System.Drawing.Size(181, 41)
        Me.btnRClear.TabIndex = 39
        Me.btnRClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(834, 577)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(158, 20)
        Me.dtpDate.TabIndex = 66
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1624, 100)
        Me.Panel3.TabIndex = 43
        '
        'reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1624, 1151)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRReserve)
        Me.Controls.Add(Me.btnRClear)
        Me.Controls.Add(Me.dtpDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dudRChildren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dudRAdult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnRAvailRoom As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblRRoomRate As Bunifu.Framework.UI.BunifuCustomLabel
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtReference As TextBox
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDownpayment As TextBox
    Friend WithEvents lblRRoomRatingRoom As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRSubtractDate As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnCalculate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpArrivalTime As DateTimePicker
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPayment As TextBox
End Class
