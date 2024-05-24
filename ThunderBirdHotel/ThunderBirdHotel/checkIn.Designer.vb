<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkIn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkIn))
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.drpGender = New System.Windows.Forms.ComboBox()
        Me.dudChildren = New System.Windows.Forms.NumericUpDown()
        Me.dudAdult = New System.Windows.Forms.NumericUpDown()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRoomNo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRoomType = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel23 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAvailRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblAddonItem = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTotalPriceNoVat = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel21 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel20 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.dgvAddonList = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnClearAddon = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAddon = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nupdQuantity = New System.Windows.Forms.NumericUpDown()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgvAddon = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRoomRate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSubtractDate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRoomRatingRoom = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tmrCheckIn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRoomNo = New System.Windows.Forms.Timer(Me.components)
        Me.btnAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnClear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnReserved = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.dudChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dudAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvAddonList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupdQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAddon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 68)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(296, 29)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "PERSONAL INFORMATION :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtNumber)
        Me.Panel1.Controls.Add(Me.drpGender)
        Me.Panel1.Controls.Add(Me.dudChildren)
        Me.Panel1.Controls.Add(Me.dudAdult)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Location = New System.Drawing.Point(10, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 171)
        Me.Panel1.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAddress.Location = New System.Drawing.Point(201, 130)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(969, 26)
        Me.txtAddress.TabIndex = 38
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(201, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(331, 26)
        Me.txtEmail.TabIndex = 37
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(201, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 26)
        Me.txtName.TabIndex = 36
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNumber.Location = New System.Drawing.Point(201, 49)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(331, 26)
        Me.txtNumber.TabIndex = 35
        '
        'drpGender
        '
        Me.drpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpGender.FormattingEnabled = True
        Me.drpGender.Items.AddRange(New Object() {"male", "female"})
        Me.drpGender.Location = New System.Drawing.Point(839, 87)
        Me.drpGender.Name = "drpGender"
        Me.drpGender.Size = New System.Drawing.Size(331, 26)
        Me.drpGender.TabIndex = 33
        '
        'dudChildren
        '
        Me.dudChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dudChildren.Location = New System.Drawing.Point(839, 51)
        Me.dudChildren.Name = "dudChildren"
        Me.dudChildren.Size = New System.Drawing.Size(331, 26)
        Me.dudChildren.TabIndex = 28
        '
        'dudAdult
        '
        Me.dudAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dudAdult.Location = New System.Drawing.Point(839, 13)
        Me.dudAdult.Name = "dudAdult"
        Me.dudAdult.Size = New System.Drawing.Size(331, 26)
        Me.dudAdult.TabIndex = 27
        Me.dudAdult.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(18, 127)
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
        'dtpCheckOut
        '
        Me.dtpCheckOut.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckOut.Location = New System.Drawing.Point(476, 19)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(149, 32)
        Me.dtpCheckOut.TabIndex = 33
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CalendarFont = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckIn.Location = New System.Drawing.Point(149, 19)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(149, 32)
        Me.dtpCheckIn.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblRoomNo)
        Me.Panel2.Controls.Add(Me.lblRoomType)
        Me.Panel2.Controls.Add(Me.txtChange)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel23)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel22)
        Me.Panel2.Controls.Add(Me.txtPayment)
        Me.Panel2.Controls.Add(Me.btnCalculate)
        Me.Panel2.Controls.Add(Me.btnAvailRoom)
        Me.Panel2.Controls.Add(Me.lblAddonItem)
        Me.Panel2.Controls.Add(Me.txtTotalPriceNoVat)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel21)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel20)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel19)
        Me.Panel2.Controls.Add(Me.txtVat)
        Me.Panel2.Controls.Add(Me.txtTotalPrice)
        Me.Panel2.Controls.Add(Me.dgvAddonList)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnClearAddon)
        Me.Panel2.Controls.Add(Me.btnAddon)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.nupdQuantity)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel18)
        Me.Panel2.Controls.Add(Me.dgvAddon)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel17)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel16)
        Me.Panel2.Controls.Add(Me.lblRoomRate)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel13)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel12)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel2.Controls.Add(Me.dtpCheckOut)
        Me.Panel2.Controls.Add(Me.dtpCheckIn)
        Me.Panel2.Controls.Add(Me.lblSubtractDate)
        Me.Panel2.Controls.Add(Me.lblRoomRatingRoom)
        Me.Panel2.Controls.Add(Me.dtpDate)
        Me.Panel2.Location = New System.Drawing.Point(10, 326)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1192, 367)
        Me.Panel2.TabIndex = 36
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoomNo.ForeColor = System.Drawing.Color.White
        Me.lblRoomNo.Location = New System.Drawing.Point(858, 59)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(195, 29)
        Me.lblRoomNo.TabIndex = 63
        Me.lblRoomNo.Text = "Select A Room No"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoomType.ForeColor = System.Drawing.Color.White
        Me.lblRoomType.Location = New System.Drawing.Point(857, 15)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(215, 29)
        Me.lblRoomType.TabIndex = 62
        Me.lblRoomType.Text = "Select A Room Type"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtChange.Location = New System.Drawing.Point(862, 309)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(307, 26)
        Me.txtChange.TabIndex = 61
        '
        'BunifuCustomLabel23
        '
        Me.BunifuCustomLabel23.AutoSize = True
        Me.BunifuCustomLabel23.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel23.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel23.Location = New System.Drawing.Point(682, 305)
        Me.BunifuCustomLabel23.Name = "BunifuCustomLabel23"
        Me.BunifuCustomLabel23.Size = New System.Drawing.Size(89, 29)
        Me.BunifuCustomLabel23.TabIndex = 60
        Me.BunifuCustomLabel23.Text = "Change"
        '
        'BunifuCustomLabel22
        '
        Me.BunifuCustomLabel22.AutoSize = True
        Me.BunifuCustomLabel22.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel22.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel22.Location = New System.Drawing.Point(682, 268)
        Me.BunifuCustomLabel22.Name = "BunifuCustomLabel22"
        Me.BunifuCustomLabel22.Size = New System.Drawing.Size(104, 29)
        Me.BunifuCustomLabel22.TabIndex = 59
        Me.BunifuCustomLabel22.Text = "Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPayment.Location = New System.Drawing.Point(862, 271)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(307, 26)
        Me.txtPayment.TabIndex = 58
        '
        'btnCalculate
        '
        Me.btnCalculate.ActiveBorderThickness = 1
        Me.btnCalculate.ActiveCornerRadius = 20
        Me.btnCalculate.ActiveFillColor = System.Drawing.Color.White
        Me.btnCalculate.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnCalculate.ActiveLineColor = System.Drawing.Color.White
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.btnCalculate.Location = New System.Drawing.Point(1063, 99)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 41)
        Me.btnCalculate.TabIndex = 57
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvailRoom
        '
        Me.btnAvailRoom.ActiveBorderThickness = 1
        Me.btnAvailRoom.ActiveCornerRadius = 20
        Me.btnAvailRoom.ActiveFillColor = System.Drawing.Color.White
        Me.btnAvailRoom.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnAvailRoom.ActiveLineColor = System.Drawing.Color.White
        Me.btnAvailRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAvailRoom.BackgroundImage = CType(resources.GetObject("btnAvailRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnAvailRoom.ButtonText = "Available Room"
        Me.btnAvailRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvailRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailRoom.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAvailRoom.IdleBorderThickness = 1
        Me.btnAvailRoom.IdleCornerRadius = 20
        Me.btnAvailRoom.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnAvailRoom.IdleForecolor = System.Drawing.Color.White
        Me.btnAvailRoom.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnAvailRoom.Location = New System.Drawing.Point(918, 99)
        Me.btnAvailRoom.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAvailRoom.Name = "btnAvailRoom"
        Me.btnAvailRoom.Size = New System.Drawing.Size(135, 41)
        Me.btnAvailRoom.TabIndex = 41
        Me.btnAvailRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddonItem
        '
        Me.lblAddonItem.AutoSize = True
        Me.lblAddonItem.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddonItem.ForeColor = System.Drawing.Color.White
        Me.lblAddonItem.Location = New System.Drawing.Point(385, 131)
        Me.lblAddonItem.Name = "lblAddonItem"
        Me.lblAddonItem.Size = New System.Drawing.Size(178, 29)
        Me.lblAddonItem.TabIndex = 56
        Me.lblAddonItem.Text = "Select an Addon"
        '
        'txtTotalPriceNoVat
        '
        Me.txtTotalPriceNoVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTotalPriceNoVat.Location = New System.Drawing.Point(862, 233)
        Me.txtTotalPriceNoVat.Name = "txtTotalPriceNoVat"
        Me.txtTotalPriceNoVat.ReadOnly = True
        Me.txtTotalPriceNoVat.Size = New System.Drawing.Size(307, 26)
        Me.txtTotalPriceNoVat.TabIndex = 55
        '
        'BunifuCustomLabel21
        '
        Me.BunifuCustomLabel21.AutoSize = True
        Me.BunifuCustomLabel21.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel21.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel21.Location = New System.Drawing.Point(634, 231)
        Me.BunifuCustomLabel21.Name = "BunifuCustomLabel21"
        Me.BunifuCustomLabel21.Size = New System.Drawing.Size(223, 29)
        Me.BunifuCustomLabel21.TabIndex = 54
        Me.BunifuCustomLabel21.Text = "Total Price (No VAT):"
        '
        'BunifuCustomLabel20
        '
        Me.BunifuCustomLabel20.AutoSize = True
        Me.BunifuCustomLabel20.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel20.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel20.Location = New System.Drawing.Point(682, 194)
        Me.BunifuCustomLabel20.Name = "BunifuCustomLabel20"
        Me.BunifuCustomLabel20.Size = New System.Drawing.Size(102, 29)
        Me.BunifuCustomLabel20.TabIndex = 53
        Me.BunifuCustomLabel20.Text = "VAT 12% :"
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(682, 156)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(127, 29)
        Me.BunifuCustomLabel19.TabIndex = 52
        Me.BunifuCustomLabel19.Text = "Total Price:"
        '
        'txtVat
        '
        Me.txtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtVat.Location = New System.Drawing.Point(863, 194)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(307, 26)
        Me.txtVat.TabIndex = 51
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTotalPrice.Location = New System.Drawing.Point(863, 156)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(307, 26)
        Me.txtTotalPrice.TabIndex = 39
        '
        'dgvAddonList
        '
        Me.dgvAddonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddonList.Location = New System.Drawing.Point(23, 93)
        Me.dgvAddonList.Name = "dgvAddonList"
        Me.dgvAddonList.Size = New System.Drawing.Size(326, 109)
        Me.dgvAddonList.TabIndex = 50
        '
        'btnUpdate
        '
        Me.btnUpdate.ActiveBorderThickness = 1
        Me.btnUpdate.ActiveCornerRadius = 20
        Me.btnUpdate.ActiveFillColor = System.Drawing.Color.White
        Me.btnUpdate.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnUpdate.ActiveLineColor = System.Drawing.Color.White
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.ButtonText = "Update"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.IdleBorderThickness = 1
        Me.btnUpdate.IdleCornerRadius = 20
        Me.btnUpdate.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnUpdate.IdleForecolor = System.Drawing.Color.White
        Me.btnUpdate.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnUpdate.Location = New System.Drawing.Point(476, 256)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 41)
        Me.btnUpdate.TabIndex = 49
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearAddon
        '
        Me.btnClearAddon.ActiveBorderThickness = 1
        Me.btnClearAddon.ActiveCornerRadius = 20
        Me.btnClearAddon.ActiveFillColor = System.Drawing.Color.White
        Me.btnClearAddon.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnClearAddon.ActiveLineColor = System.Drawing.Color.White
        Me.btnClearAddon.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearAddon.BackgroundImage = CType(resources.GetObject("btnClearAddon.BackgroundImage"), System.Drawing.Image)
        Me.btnClearAddon.ButtonText = "Clear"
        Me.btnClearAddon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearAddon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAddon.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnClearAddon.IdleBorderThickness = 1
        Me.btnClearAddon.IdleCornerRadius = 20
        Me.btnClearAddon.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnClearAddon.IdleForecolor = System.Drawing.Color.White
        Me.btnClearAddon.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnClearAddon.Location = New System.Drawing.Point(368, 297)
        Me.btnClearAddon.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClearAddon.Name = "btnClearAddon"
        Me.btnClearAddon.Size = New System.Drawing.Size(98, 41)
        Me.btnClearAddon.TabIndex = 48
        Me.btnClearAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddon
        '
        Me.btnAddon.ActiveBorderThickness = 1
        Me.btnAddon.ActiveCornerRadius = 20
        Me.btnAddon.ActiveFillColor = System.Drawing.Color.White
        Me.btnAddon.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnAddon.ActiveLineColor = System.Drawing.Color.White
        Me.btnAddon.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddon.BackgroundImage = CType(resources.GetObject("btnAddon.BackgroundImage"), System.Drawing.Image)
        Me.btnAddon.ButtonText = "Add"
        Me.btnAddon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddon.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAddon.IdleBorderThickness = 1
        Me.btnAddon.IdleCornerRadius = 20
        Me.btnAddon.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnAddon.IdleForecolor = System.Drawing.Color.White
        Me.btnAddon.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnAddon.Location = New System.Drawing.Point(368, 256)
        Me.btnAddon.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddon.Name = "btnAddon"
        Me.btnAddon.Size = New System.Drawing.Size(98, 41)
        Me.btnAddon.TabIndex = 47
        Me.btnAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.ActiveBorderThickness = 1
        Me.btnRemove.ActiveCornerRadius = 20
        Me.btnRemove.ActiveFillColor = System.Drawing.Color.White
        Me.btnRemove.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnRemove.ActiveLineColor = System.Drawing.Color.White
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.ButtonText = "Remove"
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRemove.IdleBorderThickness = 1
        Me.btnRemove.IdleCornerRadius = 20
        Me.btnRemove.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnRemove.IdleForecolor = System.Drawing.Color.White
        Me.btnRemove.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRemove.Location = New System.Drawing.Point(476, 297)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(98, 41)
        Me.btnRemove.TabIndex = 41
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nupdQuantity
        '
        Me.nupdQuantity.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupdQuantity.Location = New System.Drawing.Point(406, 195)
        Me.nupdQuantity.Name = "nupdQuantity"
        Me.nupdQuantity.Size = New System.Drawing.Size(122, 38)
        Me.nupdQuantity.TabIndex = 39
        Me.nupdQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(423, 166)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(90, 26)
        Me.BunifuCustomLabel18.TabIndex = 46
        Me.BunifuCustomLabel18.Text = "Quantity"
        '
        'dgvAddon
        '
        Me.dgvAddon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddon.Location = New System.Drawing.Point(23, 233)
        Me.dgvAddon.Name = "dgvAddon"
        Me.dgvAddon.Size = New System.Drawing.Size(326, 109)
        Me.dgvAddon.TabIndex = 42
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(118, 211)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(132, 26)
        Me.BunifuCustomLabel17.TabIndex = 45
        Me.BunifuCustomLabel17.Text = "Your Add ons"
        Me.BunifuCustomLabel17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(128, 64)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(114, 26)
        Me.BunifuCustomLabel16.TabIndex = 44
        Me.BunifuCustomLabel16.Text = "Add-on List"
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblRoomRate.ForeColor = System.Drawing.Color.White
        Me.lblRoomRate.Location = New System.Drawing.Point(857, 99)
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
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(681, 105)
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
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(681, 59)
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
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(681, 15)
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
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(308, 15)
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
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(18, 16)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(110, 29)
        Me.BunifuCustomLabel9.TabIndex = 34
        Me.BunifuCustomLabel9.Text = "Check In :"
        '
        'lblSubtractDate
        '
        Me.lblSubtractDate.AutoSize = True
        Me.lblSubtractDate.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubtractDate.ForeColor = System.Drawing.Color.White
        Me.lblSubtractDate.Location = New System.Drawing.Point(95, 256)
        Me.lblSubtractDate.Name = "lblSubtractDate"
        Me.lblSubtractDate.Size = New System.Drawing.Size(178, 29)
        Me.lblSubtractDate.TabIndex = 64
        Me.lblSubtractDate.Text = "Select an Addon"
        '
        'lblRoomRatingRoom
        '
        Me.lblRoomRatingRoom.AutoSize = True
        Me.lblRoomRatingRoom.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoomRatingRoom.ForeColor = System.Drawing.Color.White
        Me.lblRoomRatingRoom.Location = New System.Drawing.Point(166, 297)
        Me.lblRoomRatingRoom.Name = "lblRoomRatingRoom"
        Me.lblRoomRatingRoom.Size = New System.Drawing.Size(26, 29)
        Me.lblRoomRatingRoom.TabIndex = 65
        Me.lblRoomRatingRoom.Text = "0"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(73, 277)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 66
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(439, 9)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(270, 29)
        Me.BunifuCustomLabel14.TabIndex = 37
        Me.BunifuCustomLabel14.Text = "CHECK-IN INFORMATION"
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(12, 283)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(252, 29)
        Me.BunifuCustomLabel15.TabIndex = 38
        Me.BunifuCustomLabel15.Text = "ROOM INFORMATION :"
        '
        'tmrCheckIn
        '
        Me.tmrCheckIn.Enabled = True
        Me.tmrCheckIn.Interval = 1000
        '
        'tmrRoomNo
        '
        Me.tmrRoomNo.Enabled = True
        Me.tmrRoomNo.Interval = 1000
        '
        'btnAdd
        '
        Me.btnAdd.ActiveBorderThickness = 1
        Me.btnAdd.ActiveCornerRadius = 20
        Me.btnAdd.ActiveFillColor = System.Drawing.Color.White
        Me.btnAdd.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnAdd.ActiveLineColor = System.Drawing.Color.White
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.ButtonText = "Check-In"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.IdleBorderThickness = 1
        Me.btnAdd.IdleCornerRadius = 20
        Me.btnAdd.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnAdd.IdleForecolor = System.Drawing.Color.White
        Me.btnAdd.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnAdd.Location = New System.Drawing.Point(1001, 705)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(181, 41)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.ActiveBorderThickness = 1
        Me.btnClear.ActiveCornerRadius = 20
        Me.btnClear.ActiveFillColor = System.Drawing.Color.White
        Me.btnClear.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnClear.ActiveLineColor = System.Drawing.Color.White
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.ButtonText = "Clear"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnClear.IdleBorderThickness = 1
        Me.btnClear.IdleCornerRadius = 20
        Me.btnClear.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnClear.IdleForecolor = System.Drawing.Color.White
        Me.btnClear.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(797, 705)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(181, 41)
        Me.btnClear.TabIndex = 39
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReserved
        '
        Me.btnReserved.ActiveBorderThickness = 1
        Me.btnReserved.ActiveCornerRadius = 20
        Me.btnReserved.ActiveFillColor = System.Drawing.Color.White
        Me.btnReserved.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnReserved.ActiveLineColor = System.Drawing.Color.White
        Me.btnReserved.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReserved.BackgroundImage = CType(resources.GetObject("btnReserved.BackgroundImage"), System.Drawing.Image)
        Me.btnReserved.ButtonText = "Already Reserved?"
        Me.btnReserved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserved.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnReserved.IdleBorderThickness = 1
        Me.btnReserved.IdleCornerRadius = 20
        Me.btnReserved.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnReserved.IdleForecolor = System.Drawing.Color.White
        Me.btnReserved.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnReserved.Location = New System.Drawing.Point(1042, 51)
        Me.btnReserved.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReserved.Name = "btnReserved"
        Me.btnReserved.Size = New System.Drawing.Size(158, 41)
        Me.btnReserved.TabIndex = 67
        Me.btnReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'checkIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.btnReserved)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BunifuCustomLabel15)
        Me.Controls.Add(Me.BunifuCustomLabel14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "checkIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "checkIn"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dudChildren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dudAdult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvAddonList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupdQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAddon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dudChildren As NumericUpDown
    Friend WithEvents dudAdult As NumericUpDown
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents drpGender As ComboBox
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRoomRate As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents tmrCheckIn As Timer
    Friend WithEvents tmrRoomNo As Timer
    Friend WithEvents btnAvailRoom As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dgvAddon As DataGridView
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAddon As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nupdQuantity As NumericUpDown
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClearAddon As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dgvAddonList As DataGridView
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel21 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel20 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTotalPriceNoVat As TextBox
    Friend WithEvents lblAddonItem As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnCalculate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents BunifuCustomLabel22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtChange As TextBox
    Friend WithEvents BunifuCustomLabel23 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRoomNo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblSubtractDate As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRoomRatingRoom As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblRoomType As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnReserved As Bunifu.Framework.UI.BunifuThinButton2
End Class
