<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.userNameTb = New System.Windows.Forms.TextBox()
        Me.userPswrdTb = New System.Windows.Forms.TextBox()
        Me.loginBt = New System.Windows.Forms.Button()
        Me.cancelBt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'userNameTb
        '
        Me.userNameTb.Location = New System.Drawing.Point(115, 92)
        Me.userNameTb.Name = "userNameTb"
        Me.userNameTb.Size = New System.Drawing.Size(100, 20)
        Me.userNameTb.TabIndex = 3
        '
        'userPswrdTb
        '
        Me.userPswrdTb.Location = New System.Drawing.Point(115, 146)
        Me.userPswrdTb.Name = "userPswrdTb"
        Me.userPswrdTb.Size = New System.Drawing.Size(100, 20)
        Me.userPswrdTb.TabIndex = 4
        '
        'loginBt
        '
        Me.loginBt.Location = New System.Drawing.Point(32, 201)
        Me.loginBt.Name = "loginBt"
        Me.loginBt.Size = New System.Drawing.Size(75, 23)
        Me.loginBt.TabIndex = 5
        Me.loginBt.Text = "Login"
        Me.loginBt.UseVisualStyleBackColor = True
        '
        'cancelBt
        '
        Me.cancelBt.Location = New System.Drawing.Point(140, 201)
        Me.cancelBt.Name = "cancelBt"
        Me.cancelBt.Size = New System.Drawing.Size(75, 23)
        Me.cancelBt.TabIndex = 6
        Me.cancelBt.Text = "Cancel"
        Me.cancelBt.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 250)
        Me.Controls.Add(Me.cancelBt)
        Me.Controls.Add(Me.loginBt)
        Me.Controls.Add(Me.userPswrdTb)
        Me.Controls.Add(Me.userNameTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginForm"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents userNameTb As TextBox
    Friend WithEvents userPswrdTb As TextBox
    Friend WithEvents loginBt As Button
    Friend WithEvents cancelBt As Button
End Class
