<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BudgetForm
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
        Me.tabYear = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tabYear
        '
        Me.tabYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tabYear.Location = New System.Drawing.Point(12, 12)
        Me.tabYear.Name = "tabYear"
        Me.tabYear.SelectedIndex = 0
        Me.tabYear.Size = New System.Drawing.Size(1088, 705)
        Me.tabYear.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1106, 639)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(94, 78)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'BudgetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 732)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.tabYear)
        Me.Name = "BudgetForm"
        Me.Text = "frmBudget"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabYear As TabControl
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cmdSave As Button
End Class
