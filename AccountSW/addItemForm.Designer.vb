<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addItemForm
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
        Me.cancelItemBt = New System.Windows.Forms.Button()
        Me.addItemBt = New System.Windows.Forms.Button()
        Me.itemSPTb = New System.Windows.Forms.TextBox()
        Me.itemPPTb = New System.Windows.Forms.TextBox()
        Me.itemQtyTb = New System.Windows.Forms.TextBox()
        Me.itemNameTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemUnitCb = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelItemBt
        '
        Me.cancelItemBt.Location = New System.Drawing.Point(382, 311)
        Me.cancelItemBt.Name = "cancelItemBt"
        Me.cancelItemBt.Size = New System.Drawing.Size(107, 23)
        Me.cancelItemBt.TabIndex = 7
        Me.cancelItemBt.Text = "Cancel"
        Me.cancelItemBt.UseVisualStyleBackColor = True
        '
        'addItemBt
        '
        Me.addItemBt.Location = New System.Drawing.Point(254, 311)
        Me.addItemBt.Name = "addItemBt"
        Me.addItemBt.Size = New System.Drawing.Size(107, 23)
        Me.addItemBt.TabIndex = 6
        Me.addItemBt.Text = "Add"
        Me.addItemBt.UseVisualStyleBackColor = True
        '
        'itemSPTb
        '
        Me.itemSPTb.Location = New System.Drawing.Point(368, 257)
        Me.itemSPTb.Name = "itemSPTb"
        Me.itemSPTb.Size = New System.Drawing.Size(121, 20)
        Me.itemSPTb.TabIndex = 5
        '
        'itemPPTb
        '
        Me.itemPPTb.Location = New System.Drawing.Point(368, 215)
        Me.itemPPTb.Name = "itemPPTb"
        Me.itemPPTb.Size = New System.Drawing.Size(121, 20)
        Me.itemPPTb.TabIndex = 4
        '
        'itemQtyTb
        '
        Me.itemQtyTb.Location = New System.Drawing.Point(368, 169)
        Me.itemQtyTb.Name = "itemQtyTb"
        Me.itemQtyTb.Size = New System.Drawing.Size(121, 20)
        Me.itemQtyTb.TabIndex = 3
        '
        'itemNameTb
        '
        Me.itemNameTb.Location = New System.Drawing.Point(368, 86)
        Me.itemNameTb.Name = "itemNameTb"
        Me.itemNameTb.Size = New System.Drawing.Size(233, 20)
        Me.itemNameTb.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sales Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Purc. Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'itemUnitCb
        '
        Me.itemUnitCb.AutoCompleteCustomSource.AddRange(New String() {"Kgs.", "Gms.", "Dozens", "Tonne", "Units", "Pcs.", "N.A."})
        Me.itemUnitCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.itemUnitCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.itemUnitCb.BackColor = System.Drawing.SystemColors.Window
        Me.itemUnitCb.FormattingEnabled = True
        Me.itemUnitCb.Items.AddRange(New Object() {"DOZENS", "GMS.", "KGS.", "PCS.", "TONNE", "UNITS", "N.A."})
        Me.itemUnitCb.Location = New System.Drawing.Point(368, 131)
        Me.itemUnitCb.Name = "itemUnitCb"
        Me.itemUnitCb.Size = New System.Drawing.Size(121, 21)
        Me.itemUnitCb.TabIndex = 2
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
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Item"
        '
        'addItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.itemUnitCb)
        Me.Controls.Add(Me.cancelItemBt)
        Me.Controls.Add(Me.addItemBt)
        Me.Controls.Add(Me.itemSPTb)
        Me.Controls.Add(Me.itemPPTb)
        Me.Controls.Add(Me.itemQtyTb)
        Me.Controls.Add(Me.itemNameTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addItemForm"
        Me.ShowInTaskbar = False
        Me.Text = "Add Item"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelItemBt As Button
    Friend WithEvents addItemBt As Button
    Friend WithEvents itemSPTb As TextBox
    Friend WithEvents itemPPTb As TextBox
    Friend WithEvents itemQtyTb As TextBox
    Friend WithEvents itemNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents itemUnitCb As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
End Class
