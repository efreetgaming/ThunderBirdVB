﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class roomAvailability
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomAvailability))
        Me.dgvAvailableRoom = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tmrUpdateShitty = New System.Windows.Forms.Timer(Me.components)
        Me.btnConfirmRoom = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dgvAvailableRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAvailableRoom
        '
        Me.dgvAvailableRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailableRoom.Location = New System.Drawing.Point(12, 64)
        Me.dgvAvailableRoom.Name = "dgvAvailableRoom"
        Me.dgvAvailableRoom.Size = New System.Drawing.Size(776, 364)
        Me.dgvAvailableRoom.TabIndex = 0
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 25)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(206, 36)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Available Room"
        '
        'tmrUpdateShitty
        '
        Me.tmrUpdateShitty.Enabled = True
        Me.tmrUpdateShitty.Interval = 3000
        '
        'btnConfirmRoom
        '
        Me.btnConfirmRoom.ActiveBorderThickness = 1
        Me.btnConfirmRoom.ActiveCornerRadius = 20
        Me.btnConfirmRoom.ActiveFillColor = System.Drawing.Color.Silver
        Me.btnConfirmRoom.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnConfirmRoom.ActiveLineColor = System.Drawing.Color.Silver
        Me.btnConfirmRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfirmRoom.BackgroundImage = CType(resources.GetObject("btnConfirmRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnConfirmRoom.ButtonText = "Confirm Room"
        Me.btnConfirmRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmRoom.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnConfirmRoom.IdleBorderThickness = 1
        Me.btnConfirmRoom.IdleCornerRadius = 20
        Me.btnConfirmRoom.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnConfirmRoom.IdleForecolor = System.Drawing.Color.White
        Me.btnConfirmRoom.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnConfirmRoom.Location = New System.Drawing.Point(605, 14)
        Me.btnConfirmRoom.Margin = New System.Windows.Forms.Padding(5)
        Me.btnConfirmRoom.Name = "btnConfirmRoom"
        Me.btnConfirmRoom.Size = New System.Drawing.Size(181, 41)
        Me.btnConfirmRoom.TabIndex = 64
        Me.btnConfirmRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'roomAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConfirmRoom)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgvAvailableRoom)
        Me.Name = "roomAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "roomAvailability"
        CType(Me.dgvAvailableRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAvailableRoom As DataGridView
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tmrUpdateShitty As Timer
    Friend WithEvents btnConfirmRoom As Bunifu.Framework.UI.BunifuThinButton2
End Class
