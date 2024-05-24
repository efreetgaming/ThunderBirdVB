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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnCheckOut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCheckIn = New System.Windows.Forms.TextBox()
        Me.txtCheckOut = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(144, 63)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(331, 36)
        Me.txtSearch.TabIndex = 52
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(13, 63)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel2.TabIndex = 51
        Me.BunifuCustomLabel2.Text = "Search :"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.ActiveBorderThickness = 1
        Me.btnCheckOut.ActiveCornerRadius = 20
        Me.btnCheckOut.ActiveFillColor = System.Drawing.Color.White
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
        Me.btnCheckOut.Location = New System.Drawing.Point(1020, 63)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(181, 36)
        Me.btnCheckOut.TabIndex = 54
        Me.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.ActiveBorderThickness = 1
        Me.btnSearch.ActiveCornerRadius = 20
        Me.btnSearch.ActiveFillColor = System.Drawing.Color.White
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
        Me.btnSearch.Location = New System.Drawing.Point(493, 63)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(181, 36)
        Me.btnSearch.TabIndex = 53
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerId.Location = New System.Drawing.Point(35, 158)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(331, 36)
        Me.txtCustomerId.TabIndex = 56
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(35, 215)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(331, 36)
        Me.txtCustomerName.TabIndex = 57
        '
        'txtCheckIn
        '
        Me.txtCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckIn.Location = New System.Drawing.Point(35, 273)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.Size = New System.Drawing.Size(331, 36)
        Me.txtCheckIn.TabIndex = 58
        '
        'txtCheckOut
        '
        Me.txtCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOut.Location = New System.Drawing.Point(35, 330)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.Size = New System.Drawing.Size(331, 36)
        Me.txtCheckOut.TabIndex = 59
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(35, 387)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(331, 36)
        Me.txtStatus.TabIndex = 60
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(35, 457)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(331, 36)
        Me.txtTotalPrice.TabIndex = 61
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1189, 598)
        Me.DataGridView1.TabIndex = 62
        '
        'checkOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtCheckOut)
        Me.Controls.Add(Me.txtCheckIn)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCustomerId)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "checkOut"
        Me.Text = "checkOut"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckOut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCheckIn As TextBox
    Friend WithEvents txtCheckOut As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
