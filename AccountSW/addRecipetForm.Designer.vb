<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addRecipetForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rcptNoTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dateTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.toCb = New System.Windows.Forms.ComboBox()
        Me.fromCb = New System.Windows.Forms.ComboBox()
        Me.quitBt = New System.Windows.Forms.Button()
        Me.saveRecipetBt = New System.Windows.Forms.Button()
        Me.balanceLb = New System.Windows.Forms.Label()
        Me.amountTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.TabIndex = 1
        '
        'closeBt
        '
        Me.closeBt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closeBt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.closeBt.Location = New System.Drawing.Point(1166, 2)
        Me.closeBt.Margin = New System.Windows.Forms.Padding(4)
        Me.closeBt.Name = "closeBt"
        Me.closeBt.Size = New System.Drawing.Size(32, 26)
        Me.closeBt.TabIndex = 1
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
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Recipet"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.rcptNoTb)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.dateTb)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.toCb)
        Me.Panel2.Controls.Add(Me.fromCb)
        Me.Panel2.Controls.Add(Me.quitBt)
        Me.Panel2.Controls.Add(Me.saveRecipetBt)
        Me.Panel2.Controls.Add(Me.balanceLb)
        Me.Panel2.Controls.Add(Me.amountTb)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 433)
        Me.Panel2.TabIndex = 0
        '
        'rcptNoTb
        '
        Me.rcptNoTb.Location = New System.Drawing.Point(155, 110)
        Me.rcptNoTb.Name = "rcptNoTb"
        Me.rcptNoTb.Size = New System.Drawing.Size(103, 23)
        Me.rcptNoTb.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Recipet No."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(261, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(19, 23)
        Me.DateTimePicker1.TabIndex = 11
        '
        'dateTb
        '
        Me.dateTb.Location = New System.Drawing.Point(155, 48)
        Me.dateTb.Name = "dateTb"
        Me.dateTb.Size = New System.Drawing.Size(100, 23)
        Me.dateTb.TabIndex = 10
        Me.dateTb.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date"
        '
        'toCb
        '
        Me.toCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.toCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.toCb.FormattingEnabled = True
        Me.toCb.Location = New System.Drawing.Point(155, 227)
        Me.toCb.Name = "toCb"
        Me.toCb.Size = New System.Drawing.Size(232, 24)
        Me.toCb.TabIndex = 2
        '
        'fromCb
        '
        Me.fromCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.fromCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.fromCb.FormattingEnabled = True
        Me.fromCb.Location = New System.Drawing.Point(155, 167)
        Me.fromCb.Name = "fromCb"
        Me.fromCb.Size = New System.Drawing.Size(232, 24)
        Me.fromCb.TabIndex = 1
        '
        'quitBt
        '
        Me.quitBt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.quitBt.FlatAppearance.BorderSize = 0
        Me.quitBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quitBt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.quitBt.Location = New System.Drawing.Point(239, 360)
        Me.quitBt.Margin = New System.Windows.Forms.Padding(0)
        Me.quitBt.Name = "quitBt"
        Me.quitBt.Size = New System.Drawing.Size(125, 29)
        Me.quitBt.TabIndex = 5
        Me.quitBt.Text = "Quit"
        Me.quitBt.UseVisualStyleBackColor = False
        '
        'saveRecipetBt
        '
        Me.saveRecipetBt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.saveRecipetBt.FlatAppearance.BorderSize = 0
        Me.saveRecipetBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveRecipetBt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.saveRecipetBt.Location = New System.Drawing.Point(66, 360)
        Me.saveRecipetBt.Margin = New System.Windows.Forms.Padding(0)
        Me.saveRecipetBt.Name = "saveRecipetBt"
        Me.saveRecipetBt.Size = New System.Drawing.Size(125, 29)
        Me.saveRecipetBt.TabIndex = 4
        Me.saveRecipetBt.Text = "Save"
        Me.saveRecipetBt.UseVisualStyleBackColor = False
        '
        'balanceLb
        '
        Me.balanceLb.AutoSize = True
        Me.balanceLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceLb.ForeColor = System.Drawing.Color.MediumBlue
        Me.balanceLb.Location = New System.Drawing.Point(152, 194)
        Me.balanceLb.Name = "balanceLb"
        Me.balanceLb.Size = New System.Drawing.Size(81, 13)
        Me.balanceLb.TabIndex = 0
        Me.balanceLb.Text = "( Cur. Bal. : Rs. "
        Me.balanceLb.Visible = False
        '
        'amountTb
        '
        Me.amountTb.Location = New System.Drawing.Point(155, 284)
        Me.amountTb.Name = "amountTb"
        Me.amountTb.Size = New System.Drawing.Size(232, 23)
        Me.amountTb.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From"
        '
        'addRecipetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addRecipetForm"
        Me.ShowInTaskbar = False
        Me.Text = "addRecipetForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents balanceLb As Label
    Friend WithEvents amountTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents quitBt As Button
    Friend WithEvents saveRecipetBt As Button
    Friend WithEvents toCb As ComboBox
    Friend WithEvents fromCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dateTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rcptNoTb As TextBox
End Class
