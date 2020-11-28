<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addSaleForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saleDate = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.partyNameCb = New System.Windows.Forms.ComboBox()
        Me.saleTable = New System.Windows.Forms.TableLayoutPanel()
        Me.saleAmountTb = New System.Windows.Forms.TextBox()
        Me.salePriceTb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saleitemCb = New System.Windows.Forms.ComboBox()
        Me.saleQtyTb = New System.Windows.Forms.TextBox()
        Me.addItemBt = New System.Windows.Forms.Button()
        Me.saleItemGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalQtyLb = New System.Windows.Forms.Label()
        Me.totalAmountLb = New System.Windows.Forms.Label()
        Me.saveVchBt = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.vchNoTb = New System.Windows.Forms.TextBox()
        Me.quitBt = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.saleTable.SuspendLayout()
        CType(Me.saleItemGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.closeBt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 32)
        Me.Panel1.TabIndex = 8
        '
        'closeBt
        '
        Me.closeBt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closeBt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.closeBt.Location = New System.Drawing.Point(1168, 2)
        Me.closeBt.Margin = New System.Windows.Forms.Padding(4)
        Me.closeBt.Name = "closeBt"
        Me.closeBt.Size = New System.Drawing.Size(32, 26)
        Me.closeBt.TabIndex = 0
        Me.closeBt.Text = "X"
        Me.closeBt.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(4, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Sale Vch."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'saleDate
        '
        Me.saleDate.Location = New System.Drawing.Point(127, 62)
        Me.saleDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.saleDate.Name = "saleDate"
        Me.saleDate.Size = New System.Drawing.Size(81, 23)
        Me.saleDate.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(214, 62)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(17, 23)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Party"
        '
        'partyNameCb
        '
        Me.partyNameCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.partyNameCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.partyNameCb.FormattingEnabled = True
        Me.partyNameCb.Location = New System.Drawing.Point(127, 108)
        Me.partyNameCb.Name = "partyNameCb"
        Me.partyNameCb.Size = New System.Drawing.Size(264, 24)
        Me.partyNameCb.TabIndex = 2
        '
        'saleTable
        '
        Me.saleTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saleTable.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.saleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.saleTable.ColumnCount = 4
        Me.saleTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.55367!))
        Me.saleTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44633!))
        Me.saleTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.saleTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213.0!))
        Me.saleTable.Controls.Add(Me.saleAmountTb, 3, 1)
        Me.saleTable.Controls.Add(Me.salePriceTb, 2, 1)
        Me.saleTable.Controls.Add(Me.Label7, 3, 0)
        Me.saleTable.Controls.Add(Me.Label5, 2, 0)
        Me.saleTable.Controls.Add(Me.Label4, 1, 0)
        Me.saleTable.Controls.Add(Me.Label3, 0, 0)
        Me.saleTable.Controls.Add(Me.saleitemCb, 0, 1)
        Me.saleTable.Controls.Add(Me.saleQtyTb, 1, 1)
        Me.saleTable.Location = New System.Drawing.Point(63, 172)
        Me.saleTable.Name = "saleTable"
        Me.saleTable.RowCount = 2
        Me.saleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474!))
        Me.saleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.saleTable.Size = New System.Drawing.Size(816, 58)
        Me.saleTable.TabIndex = 3
        '
        'saleAmountTb
        '
        Me.saleAmountTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.saleAmountTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.saleAmountTb.Location = New System.Drawing.Point(601, 33)
        Me.saleAmountTb.Margin = New System.Windows.Forms.Padding(0)
        Me.saleAmountTb.Multiline = True
        Me.saleAmountTb.Name = "saleAmountTb"
        Me.saleAmountTb.Size = New System.Drawing.Size(214, 24)
        Me.saleAmountTb.TabIndex = 4
        Me.saleAmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'salePriceTb
        '
        Me.salePriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.salePriceTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.salePriceTb.Location = New System.Drawing.Point(460, 33)
        Me.salePriceTb.Margin = New System.Windows.Forms.Padding(0)
        Me.salePriceTb.Multiline = True
        Me.salePriceTb.Name = "salePriceTb"
        Me.salePriceTb.Size = New System.Drawing.Size(140, 24)
        Me.salePriceTb.TabIndex = 3
        Me.salePriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(604, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 31)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Amount (Rs.)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(463, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Price (Rs.)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(355, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Qty."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(4, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Item"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'saleitemCb
        '
        Me.saleitemCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.saleitemCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.saleitemCb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.saleitemCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleitemCb.FormattingEnabled = True
        Me.saleitemCb.Location = New System.Drawing.Point(1, 33)
        Me.saleitemCb.Margin = New System.Windows.Forms.Padding(0)
        Me.saleitemCb.Name = "saleitemCb"
        Me.saleitemCb.Size = New System.Drawing.Size(350, 24)
        Me.saleitemCb.TabIndex = 1
        '
        'saleQtyTb
        '
        Me.saleQtyTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.saleQtyTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.saleQtyTb.Location = New System.Drawing.Point(352, 33)
        Me.saleQtyTb.Margin = New System.Windows.Forms.Padding(0)
        Me.saleQtyTb.Multiline = True
        Me.saleQtyTb.Name = "saleQtyTb"
        Me.saleQtyTb.Size = New System.Drawing.Size(107, 24)
        Me.saleQtyTb.TabIndex = 2
        Me.saleQtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'addItemBt
        '
        Me.addItemBt.Location = New System.Drawing.Point(804, 254)
        Me.addItemBt.Name = "addItemBt"
        Me.addItemBt.Size = New System.Drawing.Size(75, 29)
        Me.addItemBt.TabIndex = 4
        Me.addItemBt.Text = "Add Item"
        Me.addItemBt.UseVisualStyleBackColor = True
        '
        'saleItemGridView
        '
        Me.saleItemGridView.AllowUserToAddRows = False
        Me.saleItemGridView.AllowUserToDeleteRows = False
        Me.saleItemGridView.AllowUserToResizeColumns = False
        Me.saleItemGridView.AllowUserToResizeRows = False
        Me.saleItemGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.saleItemGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.saleItemGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.saleItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.saleItemGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.saleItemGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.saleItemGridView.Location = New System.Drawing.Point(64, 317)
        Me.saleItemGridView.Name = "saleItemGridView"
        Me.saleItemGridView.ReadOnly = True
        Me.saleItemGridView.RowHeadersVisible = False
        Me.saleItemGridView.Size = New System.Drawing.Size(816, 158)
        Me.saleItemGridView.TabIndex = 6
        Me.saleItemGridView.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "S.N."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Item"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'totalQtyLb
        '
        Me.totalQtyLb.AutoSize = True
        Me.totalQtyLb.Location = New System.Drawing.Point(331, 478)
        Me.totalQtyLb.Name = "totalQtyLb"
        Me.totalQtyLb.Size = New System.Drawing.Size(36, 17)
        Me.totalQtyLb.TabIndex = 0
        Me.totalQtyLb.Text = "0.00"
        '
        'totalAmountLb
        '
        Me.totalAmountLb.AutoSize = True
        Me.totalAmountLb.Location = New System.Drawing.Point(660, 478)
        Me.totalAmountLb.Name = "totalAmountLb"
        Me.totalAmountLb.Size = New System.Drawing.Size(36, 17)
        Me.totalAmountLb.TabIndex = 0
        Me.totalAmountLb.Text = "0.00"
        Me.totalAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'saveVchBt
        '
        Me.saveVchBt.Location = New System.Drawing.Point(699, 523)
        Me.saveVchBt.Name = "saveVchBt"
        Me.saveVchBt.Size = New System.Drawing.Size(75, 28)
        Me.saveVchBt.TabIndex = 5
        Me.saveVchBt.Text = "Save"
        Me.saveVchBt.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Vch. No."
        '
        'vchNoTb
        '
        Me.vchNoTb.Location = New System.Drawing.Point(535, 62)
        Me.vchNoTb.Name = "vchNoTb"
        Me.vchNoTb.Size = New System.Drawing.Size(100, 23)
        Me.vchNoTb.TabIndex = 1
        '
        'quitBt
        '
        Me.quitBt.Location = New System.Drawing.Point(805, 523)
        Me.quitBt.Name = "quitBt"
        Me.quitBt.Size = New System.Drawing.Size(75, 28)
        Me.quitBt.TabIndex = 10
        Me.quitBt.Text = "Quit"
        Me.quitBt.UseVisualStyleBackColor = True
        '
        'addSaleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.quitBt)
        Me.Controls.Add(Me.vchNoTb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.saveVchBt)
        Me.Controls.Add(Me.totalAmountLb)
        Me.Controls.Add(Me.totalQtyLb)
        Me.Controls.Add(Me.saleItemGridView)
        Me.Controls.Add(Me.addItemBt)
        Me.Controls.Add(Me.saleTable)
        Me.Controls.Add(Me.partyNameCb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.saleDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addSaleForm"
        Me.ShowInTaskbar = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.saleTable.ResumeLayout(False)
        Me.saleTable.PerformLayout()
        CType(Me.saleItemGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents saleDate As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents partyNameCb As ComboBox
    Friend WithEvents saleTable As TableLayoutPanel
    Friend WithEvents saleAmountTb As TextBox
    Friend WithEvents salePriceTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents saleitemCb As ComboBox
    Friend WithEvents saleQtyTb As TextBox
    Friend WithEvents addItemBt As Button
    Friend WithEvents saleItemGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents totalQtyLb As Label
    Friend WithEvents totalAmountLb As Label
    Friend WithEvents saveVchBt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents vchNoTb As TextBox
    Friend WithEvents quitBt As Button
End Class
