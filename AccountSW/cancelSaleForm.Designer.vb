<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cancelSaleForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.selectVchNoPanel = New System.Windows.Forms.Panel()
        Me.selectVchNoCb = New System.Windows.Forms.ComboBox()
        Me.close2Bt = New System.Windows.Forms.Button()
        Me.cancelVchBt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.selectVchNoPanel.SuspendLayout()
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
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cancel Sale Vch."
        '
        'selectVchNoPanel
        '
        Me.selectVchNoPanel.BackColor = System.Drawing.Color.LightGray
        Me.selectVchNoPanel.Controls.Add(Me.selectVchNoCb)
        Me.selectVchNoPanel.Controls.Add(Me.close2Bt)
        Me.selectVchNoPanel.Controls.Add(Me.cancelVchBt)
        Me.selectVchNoPanel.Controls.Add(Me.Label1)
        Me.selectVchNoPanel.Location = New System.Drawing.Point(0, 32)
        Me.selectVchNoPanel.Name = "selectVchNoPanel"
        Me.selectVchNoPanel.Size = New System.Drawing.Size(324, 143)
        Me.selectVchNoPanel.TabIndex = 1
        '
        'selectVchNoCb
        '
        Me.selectVchNoCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.selectVchNoCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.selectVchNoCb.FormattingEnabled = True
        Me.selectVchNoCb.Location = New System.Drawing.Point(127, 32)
        Me.selectVchNoCb.Name = "selectVchNoCb"
        Me.selectVchNoCb.Size = New System.Drawing.Size(176, 21)
        Me.selectVchNoCb.TabIndex = 1
        '
        'close2Bt
        '
        Me.close2Bt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.close2Bt.FlatAppearance.BorderSize = 0
        Me.close2Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.close2Bt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.close2Bt.Location = New System.Drawing.Point(194, 80)
        Me.close2Bt.Margin = New System.Windows.Forms.Padding(0)
        Me.close2Bt.Name = "close2Bt"
        Me.close2Bt.Size = New System.Drawing.Size(109, 29)
        Me.close2Bt.TabIndex = 3
        Me.close2Bt.Text = "Close"
        Me.close2Bt.UseVisualStyleBackColor = False
        '
        'cancelVchBt
        '
        Me.cancelVchBt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cancelVchBt.FlatAppearance.BorderSize = 0
        Me.cancelVchBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelVchBt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cancelVchBt.Location = New System.Drawing.Point(24, 80)
        Me.cancelVchBt.Margin = New System.Windows.Forms.Padding(0)
        Me.cancelVchBt.Name = "cancelVchBt"
        Me.cancelVchBt.Size = New System.Drawing.Size(109, 29)
        Me.cancelVchBt.TabIndex = 2
        Me.cancelVchBt.Text = "Cancel"
        Me.cancelVchBt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Vch. No."
        '
        'cancelSaleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.selectVchNoPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cancelSaleForm"
        Me.ShowInTaskbar = False
        Me.Text = "cancelSaleForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.selectVchNoPanel.ResumeLayout(False)
        Me.selectVchNoPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBt As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents selectVchNoPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents close2Bt As Button
    Friend WithEvents cancelVchBt As Button
    Friend WithEvents selectVchNoCb As ComboBox
End Class
