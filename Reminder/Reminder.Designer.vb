<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreminder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.dgrid = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reminder About"
        '
        'txtrem
        '
        Me.txtrem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtrem.Location = New System.Drawing.Point(23, 23)
        Me.txtrem.Multiline = True
        Me.txtrem.Name = "txtrem"
        Me.txtrem.Size = New System.Drawing.Size(249, 53)
        Me.txtrem.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(23, 104)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(249, 20)
        Me.dtpdate.TabIndex = 3
        '
        'btncreate
        '
        Me.btncreate.BackColor = System.Drawing.Color.LightGray
        Me.btncreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncreate.Location = New System.Drawing.Point(283, 53)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(98, 28)
        Me.btncreate.TabIndex = 4
        Me.btncreate.Text = "CREATE"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'dgrid
        '
        Me.dgrid.AllowUserToAddRows = False
        Me.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        Me.dgrid.Location = New System.Drawing.Point(3, 132)
        Me.dgrid.Name = "dgrid"
        Me.dgrid.Size = New System.Drawing.Size(388, 190)
        Me.dgrid.TabIndex = 9
        '
        'Column3
        '
        Me.Column3.HeaderText = "Rid"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Reminder"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        '
        'frmreminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 326)
        Me.Controls.Add(Me.dgrid)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtrem)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmreminder"
        Me.Text = "REMINDER"
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtrem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents btncreate As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents dgrid As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
