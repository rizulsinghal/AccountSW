<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifyAccForm
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
        Me.modifyAccPanel = New System.Windows.Forms.Panel()
        Me.cancelModifyBt = New System.Windows.Forms.Button()
        Me.modifyAccBt = New System.Windows.Forms.Button()
        Me.telTb = New System.Windows.Forms.TextBox()
        Me.cntryTb = New System.Windows.Forms.TextBox()
        Me.sttTb = New System.Windows.Forms.TextBox()
        Me.adrsTb = New System.Windows.Forms.TextBox()
        Me.nameTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchPanel = New System.Windows.Forms.Panel()
        Me.cancelAccBt = New System.Windows.Forms.Button()
        Me.selectAccBt = New System.Windows.Forms.Button()
        Me.searchView = New System.Windows.Forms.DataGridView()
        Me.cmpnyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchTb = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deleteAccModifyBt = New System.Windows.Forms.Button()
        Me.modifyAccPanel.SuspendLayout()
        Me.searchPanel.SuspendLayout()
        CType(Me.searchView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'modifyAccPanel
        '
        Me.modifyAccPanel.Controls.Add(Me.deleteAccModifyBt)
        Me.modifyAccPanel.Controls.Add(Me.cancelModifyBt)
        Me.modifyAccPanel.Controls.Add(Me.modifyAccBt)
        Me.modifyAccPanel.Controls.Add(Me.telTb)
        Me.modifyAccPanel.Controls.Add(Me.cntryTb)
        Me.modifyAccPanel.Controls.Add(Me.sttTb)
        Me.modifyAccPanel.Controls.Add(Me.adrsTb)
        Me.modifyAccPanel.Controls.Add(Me.nameTb)
        Me.modifyAccPanel.Controls.Add(Me.Label5)
        Me.modifyAccPanel.Controls.Add(Me.Label4)
        Me.modifyAccPanel.Controls.Add(Me.Label3)
        Me.modifyAccPanel.Controls.Add(Me.Label2)
        Me.modifyAccPanel.Controls.Add(Me.Label1)
        Me.modifyAccPanel.Enabled = False
        Me.modifyAccPanel.Location = New System.Drawing.Point(425, 90)
        Me.modifyAccPanel.Name = "modifyAccPanel"
        Me.modifyAccPanel.Size = New System.Drawing.Size(366, 291)
        Me.modifyAccPanel.TabIndex = 4
        '
        'cancelModifyBt
        '
        Me.cancelModifyBt.Location = New System.Drawing.Point(149, 265)
        Me.cancelModifyBt.Name = "cancelModifyBt"
        Me.cancelModifyBt.Size = New System.Drawing.Size(74, 23)
        Me.cancelModifyBt.TabIndex = 35
        Me.cancelModifyBt.Text = "Cancel"
        Me.cancelModifyBt.UseVisualStyleBackColor = True
        '
        'modifyAccBt
        '
        Me.modifyAccBt.Location = New System.Drawing.Point(38, 265)
        Me.modifyAccBt.Name = "modifyAccBt"
        Me.modifyAccBt.Size = New System.Drawing.Size(73, 23)
        Me.modifyAccBt.TabIndex = 34
        Me.modifyAccBt.Text = "Modify"
        Me.modifyAccBt.UseVisualStyleBackColor = True
        '
        'telTb
        '
        Me.telTb.Location = New System.Drawing.Point(98, 204)
        Me.telTb.Name = "telTb"
        Me.telTb.Size = New System.Drawing.Size(233, 20)
        Me.telTb.TabIndex = 33
        '
        'cntryTb
        '
        Me.cntryTb.Location = New System.Drawing.Point(98, 166)
        Me.cntryTb.Name = "cntryTb"
        Me.cntryTb.Size = New System.Drawing.Size(233, 20)
        Me.cntryTb.TabIndex = 32
        '
        'sttTb
        '
        Me.sttTb.Location = New System.Drawing.Point(99, 125)
        Me.sttTb.Name = "sttTb"
        Me.sttTb.Size = New System.Drawing.Size(233, 20)
        Me.sttTb.TabIndex = 31
        '
        'adrsTb
        '
        Me.adrsTb.Location = New System.Drawing.Point(99, 44)
        Me.adrsTb.Multiline = True
        Me.adrsTb.Name = "adrsTb"
        Me.adrsTb.Size = New System.Drawing.Size(233, 60)
        Me.adrsTb.TabIndex = 30
        '
        'nameTb
        '
        Me.nameTb.Location = New System.Drawing.Point(99, 2)
        Me.nameTb.Name = "nameTb"
        Me.nameTb.Size = New System.Drawing.Size(233, 20)
        Me.nameTb.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Mobile No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "State"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name"
        '
        'searchPanel
        '
        Me.searchPanel.Controls.Add(Me.cancelAccBt)
        Me.searchPanel.Controls.Add(Me.selectAccBt)
        Me.searchPanel.Controls.Add(Me.searchView)
        Me.searchPanel.Controls.Add(Me.searchTb)
        Me.searchPanel.Location = New System.Drawing.Point(12, 52)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(372, 329)
        Me.searchPanel.TabIndex = 5
        '
        'cancelAccBt
        '
        Me.cancelAccBt.Location = New System.Drawing.Point(208, 306)
        Me.cancelAccBt.Name = "cancelAccBt"
        Me.cancelAccBt.Size = New System.Drawing.Size(147, 23)
        Me.cancelAccBt.TabIndex = 7
        Me.cancelAccBt.Text = "Cancel"
        Me.cancelAccBt.UseVisualStyleBackColor = True
        '
        'selectAccBt
        '
        Me.selectAccBt.Location = New System.Drawing.Point(17, 306)
        Me.selectAccBt.Name = "selectAccBt"
        Me.selectAccBt.Size = New System.Drawing.Size(147, 23)
        Me.selectAccBt.TabIndex = 6
        Me.selectAccBt.Text = "Select"
        Me.selectAccBt.UseVisualStyleBackColor = True
        '
        'searchView
        '
        Me.searchView.AllowUserToAddRows = False
        Me.searchView.AllowUserToDeleteRows = False
        Me.searchView.AllowUserToResizeColumns = False
        Me.searchView.AllowUserToResizeRows = False
        Me.searchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmpnyName})
        Me.searchView.Location = New System.Drawing.Point(17, 38)
        Me.searchView.Name = "searchView"
        Me.searchView.ReadOnly = True
        Me.searchView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.searchView.Size = New System.Drawing.Size(338, 248)
        Me.searchView.TabIndex = 5
        '
        'cmpnyName
        '
        Me.cmpnyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cmpnyName.HeaderText = "Company Name"
        Me.cmpnyName.Name = "cmpnyName"
        Me.cmpnyName.ReadOnly = True
        Me.cmpnyName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'searchTb
        '
        Me.searchTb.Location = New System.Drawing.Point(17, 0)
        Me.searchTb.Name = "searchTb"
        Me.searchTb.Size = New System.Drawing.Size(338, 20)
        Me.searchTb.TabIndex = 4
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
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Modify Account"
        '
        'deleteAccModifyBt
        '
        Me.deleteAccModifyBt.Location = New System.Drawing.Point(259, 265)
        Me.deleteAccModifyBt.Name = "deleteAccModifyBt"
        Me.deleteAccModifyBt.Size = New System.Drawing.Size(73, 23)
        Me.deleteAccModifyBt.TabIndex = 36
        Me.deleteAccModifyBt.Text = "Delete"
        Me.deleteAccModifyBt.UseVisualStyleBackColor = True
        '
        'modifyAccForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.searchPanel)
        Me.Controls.Add(Me.modifyAccPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 27)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modifyAccForm"
        Me.ShowInTaskbar = False
        Me.Text = "Modify Account"
        Me.modifyAccPanel.ResumeLayout(False)
        Me.modifyAccPanel.PerformLayout()
        Me.searchPanel.ResumeLayout(False)
        Me.searchPanel.PerformLayout()
        CType(Me.searchView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents modifyAccPanel As Panel
    Friend WithEvents cancelModifyBt As Button
    Friend WithEvents modifyAccBt As Button
    Friend WithEvents telTb As TextBox
    Friend WithEvents cntryTb As TextBox
    Friend WithEvents sttTb As TextBox
    Friend WithEvents adrsTb As TextBox
    Friend WithEvents nameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents searchPanel As Panel
    Friend WithEvents cancelAccBt As Button
    Friend WithEvents selectAccBt As Button
    Friend WithEvents searchView As DataGridView
    Friend WithEvents cmpnyName As DataGridViewTextBoxColumn
    Friend WithEvents searchTb As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents deleteAccModifyBt As Button
End Class
