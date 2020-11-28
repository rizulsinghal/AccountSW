<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homePageForm
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
        Me.openComBt = New System.Windows.Forms.Button()
        Me.createComBt = New System.Windows.Forms.Button()
        Me.createPanel = New System.Windows.Forms.Panel()
        Me.emailTb = New System.Windows.Forms.TextBox()
        Me.telTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quitBt = New System.Windows.Forms.Button()
        Me.saveBt = New System.Windows.Forms.Button()
        Me.cntryTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sttTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adrsTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sprUsrPanel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.saveUserBt = New System.Windows.Forms.Button()
        Me.rePswrdTb = New System.Windows.Forms.TextBox()
        Me.sUPswrdTb = New System.Windows.Forms.TextBox()
        Me.sUNameTb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmpnyViewPanel = New System.Windows.Forms.Panel()
        Me.cmpnyView = New System.Windows.Forms.DataGridView()
        Me.compId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createPanel.SuspendLayout()
        Me.sprUsrPanel.SuspendLayout()
        Me.cmpnyViewPanel.SuspendLayout()
        CType(Me.cmpnyView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openComBt
        '
        Me.openComBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.openComBt.Location = New System.Drawing.Point(12, 12)
        Me.openComBt.Name = "openComBt"
        Me.openComBt.Size = New System.Drawing.Size(137, 23)
        Me.openComBt.TabIndex = 0
        Me.openComBt.Text = "Open Company"
        Me.openComBt.UseVisualStyleBackColor = False
        '
        'createComBt
        '
        Me.createComBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.createComBt.Location = New System.Drawing.Point(198, 12)
        Me.createComBt.Name = "createComBt"
        Me.createComBt.Size = New System.Drawing.Size(137, 23)
        Me.createComBt.TabIndex = 1
        Me.createComBt.Text = "Create Company"
        Me.createComBt.UseVisualStyleBackColor = False
        '
        'createPanel
        '
        Me.createPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.createPanel.Controls.Add(Me.emailTb)
        Me.createPanel.Controls.Add(Me.telTb)
        Me.createPanel.Controls.Add(Me.Label6)
        Me.createPanel.Controls.Add(Me.Label5)
        Me.createPanel.Controls.Add(Me.quitBt)
        Me.createPanel.Controls.Add(Me.saveBt)
        Me.createPanel.Controls.Add(Me.cntryTb)
        Me.createPanel.Controls.Add(Me.Label4)
        Me.createPanel.Controls.Add(Me.sttTb)
        Me.createPanel.Controls.Add(Me.Label3)
        Me.createPanel.Controls.Add(Me.adrsTb)
        Me.createPanel.Controls.Add(Me.Label2)
        Me.createPanel.Controls.Add(Me.nameTb)
        Me.createPanel.Controls.Add(Me.Label1)
        Me.createPanel.Location = New System.Drawing.Point(12, 66)
        Me.createPanel.Name = "createPanel"
        Me.createPanel.Size = New System.Drawing.Size(488, 372)
        Me.createPanel.TabIndex = 2
        Me.createPanel.Visible = False
        '
        'emailTb
        '
        Me.emailTb.Location = New System.Drawing.Point(168, 254)
        Me.emailTb.Name = "emailTb"
        Me.emailTb.Size = New System.Drawing.Size(212, 20)
        Me.emailTb.TabIndex = 11
        '
        'telTb
        '
        Me.telTb.Location = New System.Drawing.Point(168, 217)
        Me.telTb.Name = "telTb"
        Me.telTb.Size = New System.Drawing.Size(212, 20)
        Me.telTb.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tel No."
        '
        'quitBt
        '
        Me.quitBt.Location = New System.Drawing.Point(282, 293)
        Me.quitBt.Name = "quitBt"
        Me.quitBt.Size = New System.Drawing.Size(98, 23)
        Me.quitBt.TabIndex = 13
        Me.quitBt.Text = "Quit"
        Me.quitBt.UseVisualStyleBackColor = True
        '
        'saveBt
        '
        Me.saveBt.Location = New System.Drawing.Point(168, 293)
        Me.saveBt.Name = "saveBt"
        Me.saveBt.Size = New System.Drawing.Size(98, 23)
        Me.saveBt.TabIndex = 12
        Me.saveBt.Text = "Save"
        Me.saveBt.UseVisualStyleBackColor = True
        '
        'cntryTb
        '
        Me.cntryTb.Location = New System.Drawing.Point(168, 178)
        Me.cntryTb.Name = "cntryTb"
        Me.cntryTb.Size = New System.Drawing.Size(212, 20)
        Me.cntryTb.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Country"
        '
        'sttTb
        '
        Me.sttTb.Location = New System.Drawing.Point(168, 146)
        Me.sttTb.Name = "sttTb"
        Me.sttTb.Size = New System.Drawing.Size(212, 20)
        Me.sttTb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "State"
        '
        'adrsTb
        '
        Me.adrsTb.Location = New System.Drawing.Point(168, 81)
        Me.adrsTb.Multiline = True
        Me.adrsTb.Name = "adrsTb"
        Me.adrsTb.Size = New System.Drawing.Size(212, 53)
        Me.adrsTb.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'nameTb
        '
        Me.nameTb.Location = New System.Drawing.Point(168, 44)
        Me.nameTb.Name = "nameTb"
        Me.nameTb.Size = New System.Drawing.Size(212, 20)
        Me.nameTb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'sprUsrPanel
        '
        Me.sprUsrPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sprUsrPanel.Controls.Add(Me.Label9)
        Me.sprUsrPanel.Controls.Add(Me.Label8)
        Me.sprUsrPanel.Controls.Add(Me.saveUserBt)
        Me.sprUsrPanel.Controls.Add(Me.rePswrdTb)
        Me.sprUsrPanel.Controls.Add(Me.sUPswrdTb)
        Me.sprUsrPanel.Controls.Add(Me.sUNameTb)
        Me.sprUsrPanel.Controls.Add(Me.Label7)
        Me.sprUsrPanel.Location = New System.Drawing.Point(12, 66)
        Me.sprUsrPanel.Name = "sprUsrPanel"
        Me.sprUsrPanel.Size = New System.Drawing.Size(282, 198)
        Me.sprUsrPanel.TabIndex = 14
        Me.sprUsrPanel.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Retype Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Password"
        '
        'saveUserBt
        '
        Me.saveUserBt.Location = New System.Drawing.Point(136, 153)
        Me.saveUserBt.Name = "saveUserBt"
        Me.saveUserBt.Size = New System.Drawing.Size(75, 23)
        Me.saveUserBt.TabIndex = 4
        Me.saveUserBt.Text = "Save"
        Me.saveUserBt.UseVisualStyleBackColor = True
        '
        'rePswrdTb
        '
        Me.rePswrdTb.Location = New System.Drawing.Point(136, 114)
        Me.rePswrdTb.Name = "rePswrdTb"
        Me.rePswrdTb.Size = New System.Drawing.Size(100, 20)
        Me.rePswrdTb.TabIndex = 3
        '
        'sUPswrdTb
        '
        Me.sUPswrdTb.Location = New System.Drawing.Point(136, 78)
        Me.sUPswrdTb.Name = "sUPswrdTb"
        Me.sUPswrdTb.Size = New System.Drawing.Size(100, 20)
        Me.sUPswrdTb.TabIndex = 2
        '
        'sUNameTb
        '
        Me.sUNameTb.Location = New System.Drawing.Point(136, 41)
        Me.sUNameTb.Name = "sUNameTb"
        Me.sUNameTb.Size = New System.Drawing.Size(100, 20)
        Me.sUNameTb.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SuperUser Name"
        '
        'cmpnyViewPanel
        '
        Me.cmpnyViewPanel.Controls.Add(Me.cmpnyView)
        Me.cmpnyViewPanel.Location = New System.Drawing.Point(12, 66)
        Me.cmpnyViewPanel.Name = "cmpnyViewPanel"
        Me.cmpnyViewPanel.Size = New System.Drawing.Size(488, 372)
        Me.cmpnyViewPanel.TabIndex = 14
        Me.cmpnyViewPanel.Visible = False
        '
        'cmpnyView
        '
        Me.cmpnyView.AllowUserToAddRows = False
        Me.cmpnyView.AllowUserToDeleteRows = False
        Me.cmpnyView.AllowUserToResizeColumns = False
        Me.cmpnyView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cmpnyView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.cmpnyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cmpnyView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.compId, Me.compName})
        Me.cmpnyView.Location = New System.Drawing.Point(0, 0)
        Me.cmpnyView.Name = "cmpnyView"
        Me.cmpnyView.ReadOnly = True
        Me.cmpnyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cmpnyView.Size = New System.Drawing.Size(488, 372)
        Me.cmpnyView.TabIndex = 0
        '
        'compId
        '
        Me.compId.HeaderText = "Company ID"
        Me.compId.Name = "compId"
        Me.compId.ReadOnly = True
        Me.compId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'compName
        '
        Me.compName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.compName.HeaderText = "Company Name"
        Me.compName.Name = "compName"
        Me.compName.ReadOnly = True
        Me.compName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'homePageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.createPanel)
        Me.Controls.Add(Me.cmpnyViewPanel)
        Me.Controls.Add(Me.createComBt)
        Me.Controls.Add(Me.openComBt)
        Me.Controls.Add(Me.sprUsrPanel)
        Me.Name = "homePageForm"
        Me.Text = "AccountSW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.createPanel.ResumeLayout(False)
        Me.createPanel.PerformLayout()
        Me.sprUsrPanel.ResumeLayout(False)
        Me.sprUsrPanel.PerformLayout()
        Me.cmpnyViewPanel.ResumeLayout(False)
        CType(Me.cmpnyView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openComBt As Button
    Friend WithEvents createComBt As Button
    Friend WithEvents createPanel As Panel
    Friend WithEvents nameTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents emailTb As TextBox
    Friend WithEvents telTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents quitBt As Button
    Friend WithEvents saveBt As Button
    Friend WithEvents cntryTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sttTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents adrsTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sprUsrPanel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents saveUserBt As Button
    Friend WithEvents rePswrdTb As TextBox
    Friend WithEvents sUPswrdTb As TextBox
    Friend WithEvents sUNameTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmpnyViewPanel As Panel
    Friend WithEvents cmpnyView As DataGridView
    Friend WithEvents compId As DataGridViewTextBoxColumn
    Friend WithEvents compName As DataGridViewTextBoxColumn
End Class
