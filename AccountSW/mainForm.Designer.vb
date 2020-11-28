<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmpnyNameLb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userNameLb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifySaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyPurcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPurcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecipetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListRecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.cmpnyNameLb, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.userNameLb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel1.Text = "Company :"
        '
        'cmpnyNameLb
        '
        Me.cmpnyNameLb.Name = "cmpnyNameLb"
        Me.cmpnyNameLb.Size = New System.Drawing.Size(106, 17)
        Me.cmpnyNameLb.Text = "<company name>"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel3.Text = "User :"
        '
        'userNameLb
        '
        Me.userNameLb.Name = "userNameLb"
        Me.userNameLb.Size = New System.Drawing.Size(78, 17)
        Me.userNameLb.Text = "<user name>"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(0, 0)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.TransactionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CompanyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditCompanyToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseCompanyToolStripMenuItem, Me.ToolStripSeparator3, Me.DeleteCompanyToolStripMenuItem})
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CompanyToolStripMenuItem.Text = "Company"
        '
        'EditCompanyToolStripMenuItem
        '
        Me.EditCompanyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditCompanyToolStripMenuItem.Name = "EditCompanyToolStripMenuItem"
        Me.EditCompanyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditCompanyToolStripMenuItem.Text = "Edit Company"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'CloseCompanyToolStripMenuItem
        '
        Me.CloseCompanyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseCompanyToolStripMenuItem.Name = "CloseCompanyToolStripMenuItem"
        Me.CloseCompanyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseCompanyToolStripMenuItem.Text = "Close Company"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'DeleteCompanyToolStripMenuItem
        '
        Me.DeleteCompanyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteCompanyToolStripMenuItem.Name = "DeleteCompanyToolStripMenuItem"
        Me.DeleteCompanyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteCompanyToolStripMenuItem.Text = "Delete Company"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.ToolStripSeparator1, Me.ItemToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAccToolStripMenuItem, Me.ModifyAccToolStripMenuItem, Me.ListAccToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'AddAccToolStripMenuItem
        '
        Me.AddAccToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddAccToolStripMenuItem.Name = "AddAccToolStripMenuItem"
        Me.AddAccToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AddAccToolStripMenuItem.Text = "Add"
        '
        'ModifyAccToolStripMenuItem
        '
        Me.ModifyAccToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ModifyAccToolStripMenuItem.Name = "ModifyAccToolStripMenuItem"
        Me.ModifyAccToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ModifyAccToolStripMenuItem.Text = "Modify/Delete"
        '
        'ListAccToolStripMenuItem
        '
        Me.ListAccToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ListAccToolStripMenuItem.Name = "ListAccToolStripMenuItem"
        Me.ListAccToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ListAccToolStripMenuItem.Text = "List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(116, 6)
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.ModifyItemToolStripMenuItem, Me.ListItemToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AddItemToolStripMenuItem.Text = "Add"
        '
        'ModifyItemToolStripMenuItem
        '
        Me.ModifyItemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ModifyItemToolStripMenuItem.Name = "ModifyItemToolStripMenuItem"
        Me.ModifyItemToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ModifyItemToolStripMenuItem.Text = "Modify/Delete"
        '
        'ListItemToolStripMenuItem
        '
        Me.ListItemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ListItemToolStripMenuItem.Name = "ListItemToolStripMenuItem"
        Me.ListItemToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ListItemToolStripMenuItem.Text = "List"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ToolStripSeparator4, Me.PurchaseToolStripMenuItem, Me.ToolStripSeparator6, Me.RecipetToolStripMenuItem, Me.ToolStripSeparator5, Me.PaymentToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSaleToolStripMenuItem, Me.ModifySaleToolStripMenuItem, Me.ListSaleToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SalesToolStripMenuItem.ShowShortcutKeys = False
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'AddSaleToolStripMenuItem
        '
        Me.AddSaleToolStripMenuItem.Name = "AddSaleToolStripMenuItem"
        Me.AddSaleToolStripMenuItem.ShowShortcutKeys = False
        Me.AddSaleToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddSaleToolStripMenuItem.Text = "Add"
        '
        'ModifySaleToolStripMenuItem
        '
        Me.ModifySaleToolStripMenuItem.Name = "ModifySaleToolStripMenuItem"
        Me.ModifySaleToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ModifySaleToolStripMenuItem.Text = "Cancel Vch."
        '
        'ListSaleToolStripMenuItem
        '
        Me.ListSaleToolStripMenuItem.Name = "ListSaleToolStripMenuItem"
        Me.ListSaleToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ListSaleToolStripMenuItem.Text = "List"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(119, 6)
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPurcToolStripMenuItem, Me.ModifyPurcToolStripMenuItem, Me.ListPurcToolStripMenuItem})
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'AddPurcToolStripMenuItem
        '
        Me.AddPurcToolStripMenuItem.Name = "AddPurcToolStripMenuItem"
        Me.AddPurcToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddPurcToolStripMenuItem.Text = "Add"
        '
        'ModifyPurcToolStripMenuItem
        '
        Me.ModifyPurcToolStripMenuItem.Name = "ModifyPurcToolStripMenuItem"
        Me.ModifyPurcToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ModifyPurcToolStripMenuItem.Text = "Cancel Vch."
        '
        'ListPurcToolStripMenuItem
        '
        Me.ListPurcToolStripMenuItem.Name = "ListPurcToolStripMenuItem"
        Me.ListPurcToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ListPurcToolStripMenuItem.Text = "List"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(119, 6)
        '
        'RecipetToolStripMenuItem
        '
        Me.RecipetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecToolStripMenuItem, Me.ListRecToolStripMenuItem})
        Me.RecipetToolStripMenuItem.Name = "RecipetToolStripMenuItem"
        Me.RecipetToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RecipetToolStripMenuItem.Text = "Recipet"
        '
        'AddRecToolStripMenuItem
        '
        Me.AddRecToolStripMenuItem.Name = "AddRecToolStripMenuItem"
        Me.AddRecToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.AddRecToolStripMenuItem.Text = "Add"
        '
        'ListRecToolStripMenuItem
        '
        Me.ListRecToolStripMenuItem.Name = "ListRecToolStripMenuItem"
        Me.ListRecToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.ListRecToolStripMenuItem.Text = "List"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPayToolStripMenuItem, Me.ListPayToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'AddPayToolStripMenuItem
        '
        Me.AddPayToolStripMenuItem.Name = "AddPayToolStripMenuItem"
        Me.AddPayToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.AddPayToolStripMenuItem.Text = "Add"
        '
        'ListPayToolStripMenuItem
        '
        Me.ListPayToolStripMenuItem.Name = "ListPayToolStripMenuItem"
        Me.ListPayToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.ListPayToolStripMenuItem.Text = "List"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainForm"
        Me.Text = "Account SW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents cmpnyNameLb As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents userNameLb As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAccToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyAccToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAccToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPurcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyPurcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPurcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifySaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListSaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecipetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListRecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
