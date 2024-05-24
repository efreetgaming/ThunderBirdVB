<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guest))
        Me.dgvGuest = New System.Windows.Forms.DataGridView()
        Me.btnDebug = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtSearchGuest = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tmrUpdateDB = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGuest
        '
        Me.dgvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuest.Location = New System.Drawing.Point(12, 117)
        Me.dgvGuest.Name = "dgvGuest"
        Me.dgvGuest.Size = New System.Drawing.Size(1190, 631)
        Me.dgvGuest.TabIndex = 44
        '
        'btnDebug
        '
        Me.btnDebug.ActiveBorderThickness = 1
        Me.btnDebug.ActiveCornerRadius = 20
        Me.btnDebug.ActiveFillColor = System.Drawing.Color.White
        Me.btnDebug.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnDebug.ActiveLineColor = System.Drawing.Color.White
        Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDebug.BackgroundImage = CType(resources.GetObject("btnDebug.BackgroundImage"), System.Drawing.Image)
        Me.btnDebug.ButtonText = "Clear Table"
        Me.btnDebug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebug.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDebug.IdleBorderThickness = 1
        Me.btnDebug.IdleCornerRadius = 20
        Me.btnDebug.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnDebug.IdleForecolor = System.Drawing.Color.White
        Me.btnDebug.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnDebug.Location = New System.Drawing.Point(1020, 68)
        Me.btnDebug.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(181, 41)
        Me.btnDebug.TabIndex = 48
        Me.btnDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSearch.Location = New System.Drawing.Point(511, 68)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(181, 41)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearchGuest
        '
        Me.txtSearchGuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchGuest.Location = New System.Drawing.Point(144, 70)
        Me.txtSearchGuest.Name = "txtSearchGuest"
        Me.txtSearchGuest.Size = New System.Drawing.Size(331, 36)
        Me.txtSearchGuest.TabIndex = 46
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(13, 70)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel2.TabIndex = 45
        Me.BunifuCustomLabel2.Text = "Search :"
        '
        'tmrUpdateDB
        '
        Me.tmrUpdateDB.Enabled = True
        Me.tmrUpdateDB.Interval = 5000
        '
        'guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchGuest)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgvGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "guest"
        CType(Me.dgvGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGuest As DataGridView
    Friend WithEvents btnDebug As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtSearchGuest As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tmrUpdateDB As Timer
End Class
