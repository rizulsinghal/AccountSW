<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addPurchaseForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.purcVchNoTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.savePurcVchBt = New System.Windows.Forms.Button()
        Me.totalAmountLb = New System.Windows.Forms.Label()
        Me.totalQtyLb = New System.Windows.Forms.Label()
        Me.purcItemGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addItemBt = New System.Windows.Forms.Button()
        Me.purcPartyNameCb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.purcDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.purcTable = New System.Windows.Forms.TableLayoutPanel()
        Me.purcAmountTb = New System.Windows.Forms.TextBox()
        Me.purcPriceTb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.purcItemCb = New System.Windows.Forms.ComboBox()
        Me.purcQtyTb = New System.Windows.Forms.TextBox()
        Me.quitBt = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.purcItemGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.purcTable.SuspendLayout()
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
        Me.Panel1.TabIndex = 11
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
        Me.Label6.Size = New System.Drawing.Size(146, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Add Purchase Vch."
        '
        'purcVchNoTb
        '
        Me.purcVchNoTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purcVchNoTb.Location = New System.Drawing.Point(536, 62)
        Me.purcVchNoTb.Name = "purcVchNoTb"
        Me.purcVchNoTb.Size = New System.Drawing.Size(100, 23)
        Me.purcVchNoTb.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Vch. No."
        '
        'savePurcVchBt
        '
        Me.savePurcVchBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savePurcVchBt.Location = New System.Drawing.Point(699, 514)
        Me.savePurcVchBt.Name = "savePurcVchBt"
        Me.savePurcVchBt.Size = New System.Drawing.Size(75, 28)
        Me.savePurcVchBt.TabIndex = 5
        Me.savePurcVchBt.Text = "Save"
        Me.savePurcVchBt.UseVisualStyleBackColor = True
        '
        'totalAmountLb
        '
        Me.totalAmountLb.AutoSize = True
        Me.totalAmountLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmountLb.Location = New System.Drawing.Point(661, 478)
        Me.totalAmountLb.Name = "totalAmountLb"
        Me.totalAmountLb.Size = New System.Drawing.Size(36, 17)
        Me.totalAmountLb.TabIndex = 10
        Me.totalAmountLb.Text = "0.00"
        Me.totalAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalQtyLb
        '
        Me.totalQtyLb.AutoSize = True
        Me.totalQtyLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalQtyLb.Location = New System.Drawing.Point(332, 478)
        Me.totalQtyLb.Name = "totalQtyLb"
        Me.totalQtyLb.Size = New System.Drawing.Size(36, 17)
        Me.totalQtyLb.TabIndex = 9
        Me.totalQtyLb.Text = "0.00"
        '
        'purcItemGridView
        '
        Me.purcItemGridView.AllowUserToAddRows = False
        Me.purcItemGridView.AllowUserToDeleteRows = False
        Me.purcItemGridView.AllowUserToResizeColumns = False
        Me.purcItemGridView.AllowUserToResizeRows = False
        Me.purcItemGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.purcItemGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.purcItemGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.purcItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purcItemGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.purcItemGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.purcItemGridView.Location = New System.Drawing.Point(65, 317)
        Me.purcItemGridView.Name = "purcItemGridView"
        Me.purcItemGridView.ReadOnly = True
        Me.purcItemGridView.RowHeadersVisible = False
        Me.purcItemGridView.Size = New System.Drawing.Size(816, 158)
        Me.purcItemGridView.TabIndex = 8
        Me.purcItemGridView.TabStop = False
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
        'addItemBt
        '
        Me.addItemBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addItemBt.Location = New System.Drawing.Point(805, 261)
        Me.addItemBt.Name = "addItemBt"
        Me.addItemBt.Size = New System.Drawing.Size(75, 29)
        Me.addItemBt.TabIndex = 4
        Me.addItemBt.Text = "Add Item"
        Me.addItemBt.UseVisualStyleBackColor = True
        '
        'purcPartyNameCb
        '
        Me.purcPartyNameCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.purcPartyNameCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.purcPartyNameCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purcPartyNameCb.FormattingEnabled = True
        Me.purcPartyNameCb.Location = New System.Drawing.Point(128, 108)
        Me.purcPartyNameCb.Name = "purcPartyNameCb"
        Me.purcPartyNameCb.Size = New System.Drawing.Size(264, 24)
        Me.purcPartyNameCb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Party"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(215, 62)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(17, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'purcDate
        '
        Me.purcDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purcDate.Location = New System.Drawing.Point(128, 62)
        Me.purcDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purcDate.Name = "purcDate"
        Me.purcDate.Size = New System.Drawing.Size(81, 23)
        Me.purcDate.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Date"
        '
        'purcTable
        '
        Me.purcTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.purcTable.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.purcTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.purcTable.ColumnCount = 4
        Me.purcTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.55367!))
        Me.purcTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44633!))
        Me.purcTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.purcTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213.0!))
        Me.purcTable.Controls.Add(Me.purcAmountTb, 3, 1)
        Me.purcTable.Controls.Add(Me.purcPriceTb, 2, 1)
        Me.purcTable.Controls.Add(Me.Label7, 3, 0)
        Me.purcTable.Controls.Add(Me.Label5, 2, 0)
        Me.purcTable.Controls.Add(Me.Label4, 1, 0)
        Me.purcTable.Controls.Add(Me.Label3, 0, 0)
        Me.purcTable.Controls.Add(Me.purcItemCb, 0, 1)
        Me.purcTable.Controls.Add(Me.purcQtyTb, 1, 1)
        Me.purcTable.Location = New System.Drawing.Point(64, 174)
        Me.purcTable.Name = "purcTable"
        Me.purcTable.RowCount = 2
        Me.purcTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474!))
        Me.purcTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.purcTable.Size = New System.Drawing.Size(816, 58)
        Me.purcTable.TabIndex = 3
        '
        'purcAmountTb
        '
        Me.purcAmountTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.purcAmountTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purcAmountTb.Location = New System.Drawing.Point(601, 33)
        Me.purcAmountTb.Margin = New System.Windows.Forms.Padding(0)
        Me.purcAmountTb.Multiline = True
        Me.purcAmountTb.Name = "purcAmountTb"
        Me.purcAmountTb.Size = New System.Drawing.Size(214, 24)
        Me.purcAmountTb.TabIndex = 3
        Me.purcAmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'purcPriceTb
        '
        Me.purcPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.purcPriceTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purcPriceTb.Location = New System.Drawing.Point(460, 33)
        Me.purcPriceTb.Margin = New System.Windows.Forms.Padding(0)
        Me.purcPriceTb.Multiline = True
        Me.purcPriceTb.Name = "purcPriceTb"
        Me.purcPriceTb.Size = New System.Drawing.Size(140, 24)
        Me.purcPriceTb.TabIndex = 2
        Me.purcPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'purcItemCb
        '
        Me.purcItemCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.purcItemCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.purcItemCb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purcItemCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purcItemCb.FormattingEnabled = True
        Me.purcItemCb.Location = New System.Drawing.Point(1, 33)
        Me.purcItemCb.Margin = New System.Windows.Forms.Padding(0)
        Me.purcItemCb.Name = "purcItemCb"
        Me.purcItemCb.Size = New System.Drawing.Size(350, 24)
        Me.purcItemCb.TabIndex = 0
        '
        'purcQtyTb
        '
        Me.purcQtyTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.purcQtyTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purcQtyTb.Location = New System.Drawing.Point(352, 33)
        Me.purcQtyTb.Margin = New System.Windows.Forms.Padding(0)
        Me.purcQtyTb.Multiline = True
        Me.purcQtyTb.Name = "purcQtyTb"
        Me.purcQtyTb.Size = New System.Drawing.Size(107, 24)
        Me.purcQtyTb.TabIndex = 1
        Me.purcQtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'quitBt
        '
        Me.quitBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitBt.Location = New System.Drawing.Point(805, 514)
        Me.quitBt.Name = "quitBt"
        Me.quitBt.Size = New System.Drawing.Size(75, 28)
        Me.quitBt.TabIndex = 23
        Me.quitBt.Text = "Quit"
        Me.quitBt.UseVisualStyleBackColor = True
        '
        'addPurchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.quitBt)
        Me.Controls.Add(Me.purcTable)
        Me.Controls.Add(Me.purcVchNoTb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.savePurcVchBt)
        Me.Controls.Add(Me.totalAmountLb)
        Me.Controls.Add(Me.totalQtyLb)
        Me.Controls.Add(Me.purcItemGridView)
        Me.Controls.Add(Me.addItemBt)
        Me.Controls.Add(Me.purcPartyNameCb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.purcDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addPurchaseForm"
        Me.ShowInTaskbar = False
        Me.Text = "purchaseForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.purcItemGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.purcTable.ResumeLayout(False)
        Me.purcTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents purcVchNoTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents savePurcVchBt As Button
    Friend WithEvents totalAmountLb As Label
    Friend WithEvents totalQtyLb As Label
    Friend WithEvents purcItemGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents addItemBt As Button
    Friend WithEvents purcPartyNameCb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents purcDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents purcTable As TableLayoutPanel
    Friend WithEvents purcAmountTb As TextBox
    Friend WithEvents purcPriceTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents purcItemCb As ComboBox
    Friend WithEvents purcQtyTb As TextBox
    Friend WithEvents quitBt As Button
End Class
