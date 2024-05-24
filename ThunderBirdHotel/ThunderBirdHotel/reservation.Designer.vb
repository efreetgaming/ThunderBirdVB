<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservation))
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgvReservation = New System.Windows.Forms.DataGridView()
        Me.btnNull = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tmrUpdateDB = New System.Windows.Forms.Timer(Me.components)
        Me.btnReserveRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnSearch.IdleForecolor = System.Drawing.Color.White
        Me.btnSearch.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnSearch.Location = New System.Drawing.Point(511, 40)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(181, 41)
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(144, 42)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(331, 36)
        Me.txtSearch.TabIndex = 50
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(13, 42)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel2.TabIndex = 49
        Me.BunifuCustomLabel2.Text = "Search :"
        '
        'dgvReservation
        '
        Me.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservation.Location = New System.Drawing.Point(12, 89)
        Me.dgvReservation.Name = "dgvReservation"
        Me.dgvReservation.Size = New System.Drawing.Size(1190, 631)
        Me.dgvReservation.TabIndex = 48
        '
        'btnNull
        '
        Me.btnNull.ActiveBorderThickness = 1
        Me.btnNull.ActiveCornerRadius = 20
        Me.btnNull.ActiveFillColor = System.Drawing.Color.White
        Me.btnNull.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnNull.ActiveLineColor = System.Drawing.Color.White
        Me.btnNull.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNull.BackgroundImage = CType(resources.GetObject("btnNull.BackgroundImage"), System.Drawing.Image)
        Me.btnNull.ButtonText = "Cancel Reservation"
        Me.btnNull.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNull.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNull.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnNull.IdleBorderThickness = 1
        Me.btnNull.IdleCornerRadius = 20
        Me.btnNull.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnNull.IdleForecolor = System.Drawing.Color.White
        Me.btnNull.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnNull.Location = New System.Drawing.Point(1019, 40)
        Me.btnNull.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNull.Name = "btnNull"
        Me.btnNull.Size = New System.Drawing.Size(181, 41)
        Me.btnNull.TabIndex = 52
        Me.btnNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrUpdateDB
        '
        Me.tmrUpdateDB.Enabled = True
        Me.tmrUpdateDB.Interval = 1000
        '
        'btnReserveRoom
        '
        Me.btnReserveRoom.ActiveBorderThickness = 1
        Me.btnReserveRoom.ActiveCornerRadius = 20
        Me.btnReserveRoom.ActiveFillColor = System.Drawing.Color.White
        Me.btnReserveRoom.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnReserveRoom.ActiveLineColor = System.Drawing.Color.White
        Me.btnReserveRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReserveRoom.BackgroundImage = CType(resources.GetObject("btnReserveRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnReserveRoom.ButtonText = "Reserve A Room"
        Me.btnReserveRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReserveRoom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserveRoom.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnReserveRoom.IdleBorderThickness = 1
        Me.btnReserveRoom.IdleCornerRadius = 20
        Me.btnReserveRoom.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnReserveRoom.IdleForecolor = System.Drawing.Color.White
        Me.btnReserveRoom.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnReserveRoom.Location = New System.Drawing.Point(711, 40)
        Me.btnReserveRoom.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReserveRoom.Name = "btnReserveRoom"
        Me.btnReserveRoom.Size = New System.Drawing.Size(181, 41)
        Me.btnReserveRoom.TabIndex = 53
        Me.btnReserveRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(144, 124)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 36)
        Me.txtName.TabIndex = 54
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(144, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(331, 36)
        Me.TextBox2.TabIndex = 55
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(144, 208)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(331, 36)
        Me.TextBox3.TabIndex = 56
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(144, 250)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(331, 36)
        Me.TextBox4.TabIndex = 57
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(144, 304)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(331, 20)
        Me.dtpDate.TabIndex = 58
        '
        'reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnReserveRoom)
        Me.Controls.Add(Me.btnNull)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgvReservation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reservation"
        CType(Me.dgvReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgvReservation As DataGridView
    Friend WithEvents btnNull As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tmrUpdateDB As Timer
    Friend WithEvents btnReserveRoom As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents dtpDate As DateTimePicker
End Class
