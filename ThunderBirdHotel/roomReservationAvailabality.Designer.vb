<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomReservationAvailabality
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomReservationAvailabality))
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgvRRoomAvailable = New System.Windows.Forms.DataGridView()
        Me.btnConfirm = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dgvRRoomAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 22)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(206, 36)
        Me.BunifuCustomLabel2.TabIndex = 5
        Me.BunifuCustomLabel2.Text = "Available Room"
        '
        'dgvRRoomAvailable
        '
        Me.dgvRRoomAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRRoomAvailable.Location = New System.Drawing.Point(12, 61)
        Me.dgvRRoomAvailable.Name = "dgvRRoomAvailable"
        Me.dgvRRoomAvailable.Size = New System.Drawing.Size(802, 410)
        Me.dgvRRoomAvailable.TabIndex = 6
        '
        'btnConfirm
        '
        Me.btnConfirm.ActiveBorderThickness = 1
        Me.btnConfirm.ActiveCornerRadius = 20
        Me.btnConfirm.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnConfirm.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnConfirm.ActiveLineColor = System.Drawing.Color.Silver
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfirm.BackgroundImage = CType(resources.GetObject("btnConfirm.BackgroundImage"), System.Drawing.Image)
        Me.btnConfirm.ButtonText = "Confirm Room"
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.IdleBorderThickness = 1
        Me.btnConfirm.IdleCornerRadius = 20
        Me.btnConfirm.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnConfirm.IdleForecolor = System.Drawing.Color.White
        Me.btnConfirm.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnConfirm.Location = New System.Drawing.Point(633, 17)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(5)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(181, 41)
        Me.btnConfirm.TabIndex = 63
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'roomReservationAvailabality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(826, 483)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.dgvRRoomAvailable)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "roomReservationAvailabality"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "roomReservationAvailabality"
        CType(Me.dgvRRoomAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgvRRoomAvailable As DataGridView
    Friend WithEvents btnConfirm As Bunifu.Framework.UI.BunifuThinButton2
End Class
