<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkOut))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnCheckOut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.txtCheckOutId = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCheckIn = New System.Windows.Forms.TextBox()
        Me.txtCheckOut = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.btnDebug = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtArrivalTime = New System.Windows.Forms.TextBox()
        Me.txtTransactID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(144, 133)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(331, 36)
        Me.txtSearch.TabIndex = 52
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 133)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel2.TabIndex = 51
        Me.BunifuCustomLabel2.Text = "Search :"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.ActiveBorderThickness = 1
        Me.btnCheckOut.ActiveCornerRadius = 20
        Me.btnCheckOut.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnCheckOut.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnCheckOut.ActiveLineColor = System.Drawing.Color.White
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheckOut.BackgroundImage = CType(resources.GetObject("btnCheckOut.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckOut.ButtonText = "Check Out"
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCheckOut.IdleBorderThickness = 1
        Me.btnCheckOut.IdleCornerRadius = 20
        Me.btnCheckOut.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnCheckOut.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnCheckOut.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnCheckOut.Location = New System.Drawing.Point(1431, 117)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(181, 68)
        Me.btnCheckOut.TabIndex = 54
        Me.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.ActiveBorderThickness = 1
        Me.btnSearch.ActiveCornerRadius = 20
        Me.btnSearch.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnSearch.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnSearch.ActiveLineColor = System.Drawing.Color.White
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.IdleBorderThickness = 1
        Me.btnSearch.IdleCornerRadius = 20
        Me.btnSearch.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnSearch.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnSearch.Location = New System.Drawing.Point(492, 117)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(181, 68)
        Me.btnSearch.TabIndex = 53
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'txtCheckOutId
        '
        Me.txtCheckOutId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOutId.Location = New System.Drawing.Point(399, 311)
        Me.txtCheckOutId.Name = "txtCheckOutId"
        Me.txtCheckOutId.Size = New System.Drawing.Size(331, 36)
        Me.txtCheckOutId.TabIndex = 56
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(399, 353)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(331, 36)
        Me.txtCustomerName.TabIndex = 57
        '
        'txtCheckIn
        '
        Me.txtCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckIn.Location = New System.Drawing.Point(399, 480)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.Size = New System.Drawing.Size(331, 36)
        Me.txtCheckIn.TabIndex = 58
        '
        'txtCheckOut
        '
        Me.txtCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOut.Location = New System.Drawing.Point(399, 522)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.Size = New System.Drawing.Size(331, 36)
        Me.txtCheckOut.TabIndex = 59
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(399, 438)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(331, 36)
        Me.txtStatus.TabIndex = 60
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(399, 395)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(331, 36)
        Me.txtTotalPrice.TabIndex = 61
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.Color.SeaGreen
        Me.DataGridView1.Location = New System.Drawing.Point(11, 205)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(1601, 934)
        Me.DataGridView1.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1624, 103)
        Me.Panel1.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(747, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHECK OUT"
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNo.Location = New System.Drawing.Point(736, 311)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(331, 36)
        Me.txtRoomNo.TabIndex = 64
        '
        'btnDebug
        '
        Me.btnDebug.ActiveBorderThickness = 1
        Me.btnDebug.ActiveCornerRadius = 20
        Me.btnDebug.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnDebug.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnDebug.ActiveLineColor = System.Drawing.Color.White
        Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDebug.BackgroundImage = CType(resources.GetObject("btnDebug.BackgroundImage"), System.Drawing.Image)
        Me.btnDebug.ButtonText = "Debug"
        Me.btnDebug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebug.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDebug.IdleBorderThickness = 1
        Me.btnDebug.IdleCornerRadius = 20
        Me.btnDebug.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnDebug.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnDebug.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnDebug.Location = New System.Drawing.Point(1240, 117)
        Me.btnDebug.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(181, 68)
        Me.btnDebug.TabIndex = 65
        Me.btnDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtArrivalTime
        '
        Me.txtArrivalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArrivalTime.Location = New System.Drawing.Point(736, 353)
        Me.txtArrivalTime.Name = "txtArrivalTime"
        Me.txtArrivalTime.Size = New System.Drawing.Size(331, 36)
        Me.txtArrivalTime.TabIndex = 66
        '
        'txtTransactID
        '
        Me.txtTransactID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactID.Location = New System.Drawing.Point(1073, 311)
        Me.txtTransactID.Name = "txtTransactID"
        Me.txtTransactID.Size = New System.Drawing.Size(331, 36)
        Me.txtTransactID.TabIndex = 67
        '
        'checkOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1624, 1151)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtCheckOut)
        Me.Controls.Add(Me.txtCheckIn)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCheckOutId)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtRoomNo)
        Me.Controls.Add(Me.txtArrivalTime)
        Me.Controls.Add(Me.txtTransactID)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "checkOut"
        Me.Text = "checkOut"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckOut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents txtCheckOutId As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCheckIn As TextBox
    Friend WithEvents txtCheckOut As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRoomNo As TextBox
    Friend WithEvents btnDebug As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtArrivalTime As TextBox
    Friend WithEvents txtTransactID As TextBox
End Class
