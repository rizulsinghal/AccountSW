<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAccountForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nameTb = New System.Windows.Forms.TextBox()
        Me.adrsTb = New System.Windows.Forms.TextBox()
        Me.sttTb = New System.Windows.Forms.TextBox()
        Me.cntryTb = New System.Windows.Forms.TextBox()
        Me.telTb = New System.Windows.Forms.TextBox()
        Me.addbt = New System.Windows.Forms.Button()
        Me.cnclBt = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mobile No."
        '
        'nameTb
        '
        Me.nameTb.Location = New System.Drawing.Point(354, 89)
        Me.nameTb.Name = "nameTb"
        Me.nameTb.Size = New System.Drawing.Size(233, 20)
        Me.nameTb.TabIndex = 5
        '
        'adrsTb
        '
        Me.adrsTb.Location = New System.Drawing.Point(354, 131)
        Me.adrsTb.Multiline = True
        Me.adrsTb.Name = "adrsTb"
        Me.adrsTb.Size = New System.Drawing.Size(233, 60)
        Me.adrsTb.TabIndex = 6
        '
        'sttTb
        '
        Me.sttTb.Location = New System.Drawing.Point(354, 212)
        Me.sttTb.Name = "sttTb"
        Me.sttTb.Size = New System.Drawing.Size(233, 20)
        Me.sttTb.TabIndex = 7
        '
        'cntryTb
        '
        Me.cntryTb.Location = New System.Drawing.Point(354, 253)
        Me.cntryTb.Name = "cntryTb"
        Me.cntryTb.Size = New System.Drawing.Size(233, 20)
        Me.cntryTb.TabIndex = 8
        '
        'telTb
        '
        Me.telTb.Location = New System.Drawing.Point(354, 291)
        Me.telTb.Name = "telTb"
        Me.telTb.Size = New System.Drawing.Size(233, 20)
        Me.telTb.TabIndex = 9
        '
        'addbt
        '
        Me.addbt.Location = New System.Drawing.Point(260, 347)
        Me.addbt.Name = "addbt"
        Me.addbt.Size = New System.Drawing.Size(143, 23)
        Me.addbt.TabIndex = 10
        Me.addbt.Text = "Add"
        Me.addbt.UseVisualStyleBackColor = True
        '
        'cnclBt
        '
        Me.cnclBt.Location = New System.Drawing.Point(444, 347)
        Me.cnclBt.Name = "cnclBt"
        Me.cnclBt.Size = New System.Drawing.Size(143, 23)
        Me.cnclBt.TabIndex = 11
        Me.cnclBt.Text = "Cancel"
        Me.cnclBt.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 15
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
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Account"
        '
        'addAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cnclBt)
        Me.Controls.Add(Me.addbt)
        Me.Controls.Add(Me.telTb)
        Me.Controls.Add(Me.cntryTb)
        Me.Controls.Add(Me.sttTb)
        Me.Controls.Add(Me.adrsTb)
        Me.Controls.Add(Me.nameTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addAccountForm"
        Me.ShowInTaskbar = False
        Me.Text = "Add Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameTb As TextBox
    Friend WithEvents adrsTb As TextBox
    Friend WithEvents sttTb As TextBox
    Friend WithEvents cntryTb As TextBox
    Friend WithEvents telTb As TextBox
    Friend WithEvents addbt As Button
    Friend WithEvents cnclBt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
End Class
