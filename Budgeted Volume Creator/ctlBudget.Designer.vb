<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBudget
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabYear = New System.Windows.Forms.TabControl()
        Me.tabVolume = New System.Windows.Forms.TabPage()
        Me.dgvBudget = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impFCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impMTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expFCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expMTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabYear.SuspendLayout()
        Me.tabVolume.SuspendLayout()
        CType(Me.dgvBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabYear
        '
        Me.tabYear.Controls.Add(Me.tabVolume)
        Me.tabYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tabYear.Location = New System.Drawing.Point(3, 3)
        Me.tabYear.Name = "tabYear"
        Me.tabYear.SelectedIndex = 0
        Me.tabYear.Size = New System.Drawing.Size(1088, 705)
        Me.tabYear.TabIndex = 1
        '
        'tabVolume
        '
        Me.tabVolume.Controls.Add(Me.dgvBudget)
        Me.tabVolume.Location = New System.Drawing.Point(4, 29)
        Me.tabVolume.Name = "tabVolume"
        Me.tabVolume.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVolume.Size = New System.Drawing.Size(1080, 672)
        Me.tabVolume.TabIndex = 0
        Me.tabVolume.Text = "TabPage1"
        Me.tabVolume.UseVisualStyleBackColor = True
        '
        'dgvBudget
        '
        Me.dgvBudget.AllowUserToAddRows = False
        Me.dgvBudget.AllowUserToDeleteRows = False
        Me.dgvBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBudget.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.impFCL, Me.impMTY, Me.expFCL, Me.expMTY, Me.total})
        Me.dgvBudget.Location = New System.Drawing.Point(6, 6)
        Me.dgvBudget.Name = "dgvBudget"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBudget.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBudget.Size = New System.Drawing.Size(1068, 660)
        Me.dgvBudget.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.DataPropertyName = "month"
        Me.Column1.HeaderText = "Month"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 65
        '
        'impFCL
        '
        Me.impFCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.impFCL.DataPropertyName = "ImportFull"
        Me.impFCL.HeaderText = "Import Full"
        Me.impFCL.Name = "impFCL"
        Me.impFCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'impMTY
        '
        Me.impMTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.impMTY.DataPropertyName = "ImportEmpty"
        Me.impMTY.HeaderText = "Import Empty"
        Me.impMTY.Name = "impMTY"
        Me.impMTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'expFCL
        '
        Me.expFCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.expFCL.DataPropertyName = "ExportFull"
        Me.expFCL.HeaderText = "Export Full"
        Me.expFCL.Name = "expFCL"
        Me.expFCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'expMTY
        '
        Me.expMTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.expMTY.DataPropertyName = "ExportEmpty"
        Me.expMTY.HeaderText = "Export Empty"
        Me.expMTY.Name = "expMTY"
        Me.expMTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.total.DataPropertyName = "Total"
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ctlBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabYear)
        Me.Name = "ctlBudget"
        Me.Size = New System.Drawing.Size(1105, 725)
        Me.tabYear.ResumeLayout(False)
        Me.tabVolume.ResumeLayout(False)
        CType(Me.dgvBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabYear As TabControl
    Friend WithEvents tabVolume As TabPage
    Friend WithEvents dgvBudget As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents impFCL As DataGridViewTextBoxColumn
    Friend WithEvents impMTY As DataGridViewTextBoxColumn
    Friend WithEvents expFCL As DataGridViewTextBoxColumn
    Friend WithEvents expMTY As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
