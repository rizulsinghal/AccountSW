Public Class mainForm
    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmpnyNameLb.Text = comName
        userNameLb.Text = userName
    End Sub

    Private Sub AddAccToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccToolStripMenuItem.Click
        addAccountForm.Show()
        addAccountForm.MdiParent = Me
    End Sub

    Private Sub CloseCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseCompanyToolStripMenuItem.Click
        Me.Close()
        comId = Nothing
        comName = Nothing
        comAd = Nothing
        comTel = Nothing
        comStt = Nothing
        comCntry = Nothing
        comEmail = Nothing
        userName = Nothing
        homePageForm.Show()
    End Sub

    Private Sub ModifyAccToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyAccToolStripMenuItem.Click
        modifyAccForm.Show()
        modifyAccForm.MdiParent = Me
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        addItemForm.Show()
        addItemForm.MdiParent = Me
    End Sub

    Private Sub ModifyItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyItemToolStripMenuItem.Click
        modifyItemForm.Show()
        modifyItemForm.MdiParent = Me
    End Sub

    Private Sub ListAccToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAccToolStripMenuItem.Click
        ListAccForm.Show()
        ListAccForm.MdiParent = Me
    End Sub

    Private Sub AddPurcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPurcToolStripMenuItem.Click
        addPurchaseForm.Show()
        addPurchaseForm.MdiParent = Me
    End Sub

    Private Sub AddSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSaleToolStripMenuItem.Click
        addSaleForm.Show()
        addSaleForm.MdiParent = Me
    End Sub

    Private Sub AddRecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecToolStripMenuItem.Click
        addRecipetForm.Show()
        addRecipetForm.MdiParent = Me
    End Sub

    Private Sub AddPayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPayToolStripMenuItem.Click
        addPaymentForm.Show()
        addPaymentForm.MdiParent = Me
    End Sub

    Private Sub ListItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListItemToolStripMenuItem.Click
        listItemForm.Show()
        listItemForm.MdiParent = Me
    End Sub

    Private Sub ModifySaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifySaleToolStripMenuItem.Click
        cancelSaleForm.Show()
        cancelSaleForm.MdiParent = Me
    End Sub

    Private Sub ModifyPurcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyPurcToolStripMenuItem.Click
        cancelPurchaseForm.Show()
        cancelPurchaseForm.MdiParent = Me
    End Sub

    Private Sub ListSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListSaleToolStripMenuItem.Click
        listSaleForm.Show()
        listSaleForm.MdiParent = Me
    End Sub

    Private Sub ListPurcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPurcToolStripMenuItem.Click
        listPurchaseForm.Show()
        listPurchaseForm.MdiParent = Me
    End Sub

    Private Sub ListRecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListRecToolStripMenuItem.Click
        listRecipetForm.Show()
        listRecipetForm.MdiParent = Me
    End Sub

    Private Sub ListPayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPayToolStripMenuItem.Click
        listPaymentForm.Show()
        listPaymentForm.MdiParent = Me
    End Sub

    Private Sub EditCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCompanyToolStripMenuItem.Click
        editCompForm.Show()
        editCompForm.MdiParent = Me
    End Sub
End Class