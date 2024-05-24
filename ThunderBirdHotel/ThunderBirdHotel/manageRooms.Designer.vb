<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageRooms))
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRoomId = New System.Windows.Forms.TextBox()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dudGuest = New System.Windows.Forms.NumericUpDown()
        Me.btnClear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cmbRoomType = New System.Windows.Forms.ComboBox()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dudGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(93, 169)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(164, 36)
        Me.BunifuCustomLabel1.TabIndex = 56
        Me.BunifuCustomLabel1.Text = "Room Rate :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(93, 120)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(166, 36)
        Me.BunifuCustomLabel2.TabIndex = 55
        Me.BunifuCustomLabel2.Text = "Room Type :"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(278, 169)
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.Size = New System.Drawing.Size(331, 36)
        Me.txtRoomRate.TabIndex = 54
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(12, 9)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(273, 36)
        Me.BunifuCustomLabel5.TabIndex = 57
        Me.BunifuCustomLabel5.Text = "Room Management :"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(646, 71)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(100, 36)
        Me.BunifuCustomLabel3.TabIndex = 61
        Me.BunifuCustomLabel3.Text = "Guest :"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(93, 71)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(142, 36)
        Me.BunifuCustomLabel6.TabIndex = 63
        Me.BunifuCustomLabel6.Text = "Room No :"
        '
        'txtRoomId
        '
        Me.txtRoomId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomId.Location = New System.Drawing.Point(278, 71)
        Me.txtRoomId.Name = "txtRoomId"
        Me.txtRoomId.Size = New System.Drawing.Size(331, 36)
        Me.txtRoomId.TabIndex = 62
        '
        'btnDelete
        '
        Me.btnDelete.ActiveBorderThickness = 1
        Me.btnDelete.ActiveCornerRadius = 20
        Me.btnDelete.ActiveFillColor = System.Drawing.Color.White
        Me.btnDelete.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnDelete.ActiveLineColor = System.Drawing.Color.White
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.ButtonText = "Delete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.IdleBorderThickness = 1
        Me.btnDelete.IdleCornerRadius = 20
        Me.btnDelete.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnDelete.IdleForecolor = System.Drawing.Color.White
        Me.btnDelete.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(923, 227)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 41)
        Me.btnDelete.TabIndex = 66
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnUpdate.Location = New System.Drawing.Point(775, 227)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(131, 41)
        Me.btnUpdate.TabIndex = 65
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 1
        Me.btnSave.ActiveCornerRadius = 20
        Me.btnSave.ActiveFillColor = System.Drawing.Color.White
        Me.btnSave.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnSave.ActiveLineColor = System.Drawing.Color.White
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSave.IdleBorderThickness = 1
        Me.btnSave.IdleCornerRadius = 20
        Me.btnSave.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnSave.IdleForecolor = System.Drawing.Color.White
        Me.btnSave.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnSave.Location = New System.Drawing.Point(627, 227)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 41)
        Me.btnSave.TabIndex = 64
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(12, 232)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel7.TabIndex = 68
        Me.BunifuCustomLabel7.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(130, 233)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(479, 36)
        Me.txtSearch.TabIndex = 67
        '
        'dgvRooms
        '
        Me.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(12, 281)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.Size = New System.Drawing.Size(1190, 467)
        Me.dgvRooms.TabIndex = 69
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(833, 176)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(153, 36)
        Me.BunifuCustomLabel8.TabIndex = 70
        Me.BunifuCustomLabel8.Text = "Commands"
        '
        'dudGuest
        '
        Me.dudGuest.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudGuest.Location = New System.Drawing.Point(764, 69)
        Me.dudGuest.Name = "dudGuest"
        Me.dudGuest.Size = New System.Drawing.Size(331, 38)
        Me.dudGuest.TabIndex = 71
        Me.dudGuest.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.btnClear.Location = New System.Drawing.Point(1071, 227)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 41)
        Me.btnClear.TabIndex = 72
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbRoomType
        '
        Me.cmbRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomType.FormattingEnabled = True
        Me.cmbRoomType.Items.AddRange(New Object() {"Presidential Suite Room", "Superior Room", "Family Suite Room", "Junior Suite Room(Bay View)", "Premier Suite Room", "Juinio Suite Room", "Satin Black Suite Room"})
        Me.cmbRoomType.Location = New System.Drawing.Point(278, 120)
        Me.cmbRoomType.Name = "cmbRoomType"
        Me.cmbRoomType.Size = New System.Drawing.Size(331, 28)
        Me.cmbRoomType.TabIndex = 73
        '
        'manageRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.cmbRoomType)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dudGuest)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.txtRoomId)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtRoomRate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageRooms"
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dudGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRoomRate As TextBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRoomId As TextBox
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dudGuest As NumericUpDown
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cmbRoomType As ComboBox
End Class
