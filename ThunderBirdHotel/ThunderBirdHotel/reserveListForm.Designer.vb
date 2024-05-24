<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserveListForm
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
        Me.dgvReserveList = New System.Windows.Forms.DataGridView()
        CType(Me.dgvReserveList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReserveList
        '
        Me.dgvReserveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserveList.Location = New System.Drawing.Point(1, 68)
        Me.dgvReserveList.Name = "dgvReserveList"
        Me.dgvReserveList.Size = New System.Drawing.Size(799, 381)
        Me.dgvReserveList.TabIndex = 0
        '
        'reserveListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvReserveList)
        Me.Name = "reserveListForm"
        Me.Text = "reserveListForm"
        CType(Me.dgvReserveList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReserveList As DataGridView
End Class
