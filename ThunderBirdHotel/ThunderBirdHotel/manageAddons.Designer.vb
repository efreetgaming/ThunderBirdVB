<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageAddons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageAddons))
        Me.dgvAddon = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAddOn = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dgvAddon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAddon
        '
        Me.dgvAddon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddon.Location = New System.Drawing.Point(18, 195)
        Me.dgvAddon.Name = "dgvAddon"
        Me.dgvAddon.Size = New System.Drawing.Size(1190, 594)
        Me.dgvAddon.TabIndex = 47
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(12, 22)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(301, 36)
        Me.BunifuCustomLabel5.TabIndex = 48
        Me.BunifuCustomLabel5.Text = "Add-ons Management :"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 131)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(90, 36)
        Me.BunifuCustomLabel1.TabIndex = 52
        Me.BunifuCustomLabel1.Text = "Price :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(21, 82)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(117, 36)
        Me.BunifuCustomLabel2.TabIndex = 51
        Me.BunifuCustomLabel2.Text = "Add-on :"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(206, 131)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(331, 36)
        Me.txtPrice.TabIndex = 50
        '
        'txtAddOn
        '
        Me.txtAddOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddOn.Location = New System.Drawing.Point(206, 82)
        Me.txtAddOn.Name = "txtAddOn"
        Me.txtAddOn.Size = New System.Drawing.Size(331, 36)
        Me.txtAddOn.TabIndex = 49
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(579, 82)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(153, 36)
        Me.BunifuCustomLabel6.TabIndex = 56
        Me.BunifuCustomLabel6.Text = "Commands"
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
        Me.btnDelete.Location = New System.Drawing.Point(954, 79)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 41)
        Me.btnDelete.TabIndex = 55
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
        Me.btnUpdate.Location = New System.Drawing.Point(847, 79)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 41)
        Me.btnUpdate.TabIndex = 54
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
        Me.btnSave.Location = New System.Drawing.Point(740, 79)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 41)
        Me.btnSave.TabIndex = 53
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(589, 130)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(112, 36)
        Me.BunifuCustomLabel7.TabIndex = 58
        Me.BunifuCustomLabel7.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(707, 131)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(467, 36)
        Me.txtSearch.TabIndex = 57
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
        Me.btnClear.Location = New System.Drawing.Point(1061, 79)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 41)
        Me.btnClear.TabIndex = 59
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'manageAddons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1214, 760)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtAddOn)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.dgvAddon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageAddons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageAddons"
        CType(Me.dgvAddon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAddon As DataGridView
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAddOn As TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuThinButton2
End Class
