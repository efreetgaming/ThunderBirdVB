<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(room))
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSearchRooms = New System.Windows.Forms.TextBox()
        Me.tmrUpdateDB = New System.Windows.Forms.Timer(Me.components)
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.btnDebug = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 42)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Search :"
        '
        'txtSearchRooms
        '
        Me.txtSearchRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchRooms.Location = New System.Drawing.Point(143, 42)
        Me.txtSearchRooms.Name = "txtSearchRooms"
        Me.txtSearchRooms.Size = New System.Drawing.Size(331, 36)
        Me.txtSearchRooms.TabIndex = 37
        '
        'tmrUpdateDB
        '
        Me.tmrUpdateDB.Enabled = True
        Me.tmrUpdateDB.Interval = 5000
        '
        'dgvRooms
        '
        Me.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(11, 105)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.Size = New System.Drawing.Size(1194, 631)
        Me.dgvRooms.TabIndex = 43
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
        Me.btnDebug.Location = New System.Drawing.Point(1019, 40)
        Me.btnDebug.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(181, 41)
        Me.btnDebug.TabIndex = 42
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
        Me.btnSearch.Location = New System.Drawing.Point(510, 40)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(181, 41)
        Me.btnSearch.TabIndex = 41
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchRooms)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "room"
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSearchRooms As TextBox
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tmrUpdateDB As Timer
    Friend WithEvents btnDebug As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dgvRooms As DataGridView
End Class
