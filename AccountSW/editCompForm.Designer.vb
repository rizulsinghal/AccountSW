<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editCompForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.createPanel = New System.Windows.Forms.Panel()
        Me.emailTb = New System.Windows.Forms.TextBox()
        Me.telTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quitBt = New System.Windows.Forms.Button()
        Me.saveEditBt = New System.Windows.Forms.Button()
        Me.cntryTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sttTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adrsTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.createPanel.SuspendLayout()
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
        Me.Panel1.TabIndex = 10
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
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Edit Company"
        '
        'createPanel
        '
        Me.createPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.createPanel.Controls.Add(Me.emailTb)
        Me.createPanel.Controls.Add(Me.telTb)
        Me.createPanel.Controls.Add(Me.Label1)
        Me.createPanel.Controls.Add(Me.Label5)
        Me.createPanel.Controls.Add(Me.quitBt)
        Me.createPanel.Controls.Add(Me.saveEditBt)
        Me.createPanel.Controls.Add(Me.cntryTb)
        Me.createPanel.Controls.Add(Me.Label4)
        Me.createPanel.Controls.Add(Me.sttTb)
        Me.createPanel.Controls.Add(Me.Label3)
        Me.createPanel.Controls.Add(Me.adrsTb)
        Me.createPanel.Controls.Add(Me.Label2)
        Me.createPanel.Controls.Add(Me.nameTb)
        Me.createPanel.Controls.Add(Me.Label7)
        Me.createPanel.Location = New System.Drawing.Point(0, 32)
        Me.createPanel.Name = "createPanel"
        Me.createPanel.Size = New System.Drawing.Size(488, 372)
        Me.createPanel.TabIndex = 3
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Email"
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
        'saveEditBt
        '
        Me.saveEditBt.Location = New System.Drawing.Point(168, 293)
        Me.saveEditBt.Name = "saveEditBt"
        Me.saveEditBt.Size = New System.Drawing.Size(98, 23)
        Me.saveEditBt.TabIndex = 12
        Me.saveEditBt.Text = "Save"
        Me.saveEditBt.UseVisualStyleBackColor = True
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
        Me.nameTb.Enabled = False
        Me.nameTb.Location = New System.Drawing.Point(168, 44)
        Me.nameTb.Name = "nameTb"
        Me.nameTb.Size = New System.Drawing.Size(212, 20)
        Me.nameTb.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(95, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name"
        '
        'editCompForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.createPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editCompForm"
        Me.ShowInTaskbar = False
        Me.Text = "editCompForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.createPanel.ResumeLayout(False)
        Me.createPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents createPanel As Panel
    Friend WithEvents emailTb As TextBox
    Friend WithEvents telTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents quitBt As Button
    Friend WithEvents saveEditBt As Button
    Friend WithEvents cntryTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sttTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents adrsTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nameTb As TextBox
    Friend WithEvents Label7 As Label
End Class
