<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modifyItemForm
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
        Me.modifyItemPanel = New System.Windows.Forms.Panel()
        Me.itemUnitCb = New System.Windows.Forms.ComboBox()
        Me.cancelItemBt = New System.Windows.Forms.Button()
        Me.modifyItemBt = New System.Windows.Forms.Button()
        Me.itemSPTb = New System.Windows.Forms.TextBox()
        Me.itemPPTb = New System.Windows.Forms.TextBox()
        Me.itemQtyTb = New System.Windows.Forms.TextBox()
        Me.itemNameTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTb = New System.Windows.Forms.TextBox()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchView = New System.Windows.Forms.DataGridView()
        Me.selectItemBt = New System.Windows.Forms.Button()
        Me.cancelModifyBt = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deleteItemBt = New System.Windows.Forms.Button()
        Me.modifyItemPanel.SuspendLayout()
        CType(Me.searchView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'modifyItemPanel
        '
        Me.modifyItemPanel.Controls.Add(Me.deleteItemBt)
        Me.modifyItemPanel.Controls.Add(Me.itemUnitCb)
        Me.modifyItemPanel.Controls.Add(Me.cancelItemBt)
        Me.modifyItemPanel.Controls.Add(Me.modifyItemBt)
        Me.modifyItemPanel.Controls.Add(Me.itemSPTb)
        Me.modifyItemPanel.Controls.Add(Me.itemPPTb)
        Me.modifyItemPanel.Controls.Add(Me.itemQtyTb)
        Me.modifyItemPanel.Controls.Add(Me.itemNameTb)
        Me.modifyItemPanel.Controls.Add(Me.Label5)
        Me.modifyItemPanel.Controls.Add(Me.Label4)
        Me.modifyItemPanel.Controls.Add(Me.Label3)
        Me.modifyItemPanel.Controls.Add(Me.Label2)
        Me.modifyItemPanel.Controls.Add(Me.Label1)
        Me.modifyItemPanel.Enabled = False
        Me.modifyItemPanel.Location = New System.Drawing.Point(400, 62)
        Me.modifyItemPanel.Name = "modifyItemPanel"
        Me.modifyItemPanel.Size = New System.Drawing.Size(409, 329)
        Me.modifyItemPanel.TabIndex = 8
        '
        'itemUnitCb
        '
        Me.itemUnitCb.AutoCompleteCustomSource.AddRange(New String() {"Kgs.", "Gms.", "Dozens", "Tonne", "Units", "Pcs.", "N.A."})
        Me.itemUnitCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.itemUnitCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.itemUnitCb.BackColor = System.Drawing.SystemColors.Window
        Me.itemUnitCb.FormattingEnabled = True
        Me.itemUnitCb.Items.AddRange(New Object() {"DOZENS", "GMS.", "KGS.", "PCS.", "TONNE", "UNITS", "N.A."})
        Me.itemUnitCb.Location = New System.Drawing.Point(156, 89)
        Me.itemUnitCb.Name = "itemUnitCb"
        Me.itemUnitCb.Size = New System.Drawing.Size(121, 21)
        Me.itemUnitCb.TabIndex = 14
        '
        'cancelItemBt
        '
        Me.cancelItemBt.Location = New System.Drawing.Point(162, 269)
        Me.cancelItemBt.Name = "cancelItemBt"
        Me.cancelItemBt.Size = New System.Drawing.Size(107, 23)
        Me.cancelItemBt.TabIndex = 19
        Me.cancelItemBt.Text = "Cancel"
        Me.cancelItemBt.UseVisualStyleBackColor = True
        '
        'modifyItemBt
        '
        Me.modifyItemBt.Location = New System.Drawing.Point(42, 269)
        Me.modifyItemBt.Name = "modifyItemBt"
        Me.modifyItemBt.Size = New System.Drawing.Size(107, 23)
        Me.modifyItemBt.TabIndex = 18
        Me.modifyItemBt.Text = "Modify"
        Me.modifyItemBt.UseVisualStyleBackColor = True
        '
        'itemSPTb
        '
        Me.itemSPTb.Location = New System.Drawing.Point(156, 215)
        Me.itemSPTb.Name = "itemSPTb"
        Me.itemSPTb.Size = New System.Drawing.Size(121, 20)
        Me.itemSPTb.TabIndex = 17
        '
        'itemPPTb
        '
        Me.itemPPTb.Location = New System.Drawing.Point(156, 173)
        Me.itemPPTb.Name = "itemPPTb"
        Me.itemPPTb.Size = New System.Drawing.Size(121, 20)
        Me.itemPPTb.TabIndex = 16
        '
        'itemQtyTb
        '
        Me.itemQtyTb.Location = New System.Drawing.Point(156, 127)
        Me.itemQtyTb.Name = "itemQtyTb"
        Me.itemQtyTb.Size = New System.Drawing.Size(121, 20)
        Me.itemQtyTb.TabIndex = 15
        '
        'itemNameTb
        '
        Me.itemNameTb.Location = New System.Drawing.Point(156, 44)
        Me.itemNameTb.Name = "itemNameTb"
        Me.itemNameTb.Size = New System.Drawing.Size(233, 20)
        Me.itemNameTb.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sales Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Purc. Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name"
        '
        'searchTb
        '
        Me.searchTb.Location = New System.Drawing.Point(15, 62)
        Me.searchTb.Name = "searchTb"
        Me.searchTb.Size = New System.Drawing.Size(338, 20)
        Me.searchTb.TabIndex = 4
        '
        'itemName
        '
        Me.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemName.HeaderText = "Item Name"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'searchView
        '
        Me.searchView.AllowUserToAddRows = False
        Me.searchView.AllowUserToDeleteRows = False
        Me.searchView.AllowUserToResizeColumns = False
        Me.searchView.AllowUserToResizeRows = False
        Me.searchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemName})
        Me.searchView.Location = New System.Drawing.Point(15, 101)
        Me.searchView.Name = "searchView"
        Me.searchView.ReadOnly = True
        Me.searchView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.searchView.Size = New System.Drawing.Size(338, 248)
        Me.searchView.TabIndex = 5
        '
        'selectItemBt
        '
        Me.selectItemBt.Location = New System.Drawing.Point(15, 368)
        Me.selectItemBt.Name = "selectItemBt"
        Me.selectItemBt.Size = New System.Drawing.Size(147, 23)
        Me.selectItemBt.TabIndex = 6
        Me.selectItemBt.Text = "Select"
        Me.selectItemBt.UseVisualStyleBackColor = True
        '
        'cancelModifyBt
        '
        Me.cancelModifyBt.Location = New System.Drawing.Point(206, 368)
        Me.cancelModifyBt.Name = "cancelModifyBt"
        Me.cancelModifyBt.Size = New System.Drawing.Size(147, 23)
        Me.cancelModifyBt.TabIndex = 7
        Me.cancelModifyBt.Text = "Cancel"
        Me.cancelModifyBt.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 9
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
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Modify Item"
        '
        'deleteItemBt
        '
        Me.deleteItemBt.Location = New System.Drawing.Point(282, 269)
        Me.deleteItemBt.Name = "deleteItemBt"
        Me.deleteItemBt.Size = New System.Drawing.Size(107, 23)
        Me.deleteItemBt.TabIndex = 20
        Me.deleteItemBt.Text = "Delete"
        Me.deleteItemBt.UseVisualStyleBackColor = True
        '
        'modifyItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.modifyItemPanel)
        Me.Controls.Add(Me.cancelModifyBt)
        Me.Controls.Add(Me.selectItemBt)
        Me.Controls.Add(Me.searchView)
        Me.Controls.Add(Me.searchTb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modifyItemForm"
        Me.ShowInTaskbar = False
        Me.Text = "Modify Item"
        Me.modifyItemPanel.ResumeLayout(False)
        Me.modifyItemPanel.PerformLayout()
        CType(Me.searchView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents modifyItemPanel As Panel
    Friend WithEvents itemUnitCb As ComboBox
    Friend WithEvents cancelItemBt As Button
    Friend WithEvents modifyItemBt As Button
    Friend WithEvents itemSPTb As TextBox
    Friend WithEvents itemPPTb As TextBox
    Friend WithEvents itemQtyTb As TextBox
    Friend WithEvents itemNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTb As TextBox
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents searchView As DataGridView
    Friend WithEvents selectItemBt As Button
    Friend WithEvents cancelModifyBt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents deleteItemBt As Button
End Class
