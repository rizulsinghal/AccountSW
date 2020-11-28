Imports System.Data.OleDb
Public Class addPurchaseForm
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dt, dtItem, dtAllItem As DataTable
    Dim purcAccId As String
    Dim prevPayBal, i, t As Integer
    Dim itemCount As Integer = 0

    Private Sub addPurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDbCommand
        Dim sql As String = "select Acc_Name from Accounts"
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        dtItem = New DataTable
        dtAllItem = New DataTable
        da.Fill(dt)
        For i = 0 To (dt.Rows.Count - 1)
            purcPartyNameCb.Items.Add(dt.Rows(i).Item(0))
        Next
        dt.Clear()
        sql = "select Item_Name from ItemStock"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dtItem)
        For i = 0 To (dtItem.Rows.Count - 1)
            purcItemCb.Items.Add(dtItem.Rows(i).Item(0))
        Next
        dtItem.Clear()
        sql = "select * from ItemStock"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dtAllItem)
        purcDate.Text = Date.Today.ToShortDateString
        purcItemGridView.Rows.Add(6)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        purcDate.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub purcDate_KeyUp(sender As Object, e As KeyEventArgs) Handles purcDate.KeyUp
        purcDate.Text = ""
    End Sub

    Private Sub purcVchNoTb_Enter(sender As Object, e As EventArgs) Handles purcVchNoTb.Enter
        purcVchNoTb.Text = voucherNo()
    End Sub

    Private Sub purcVchNoTb_TextChanged(sender As Object, e As EventArgs) Handles purcVchNoTb.TextChanged
        If Not purcVchNoTb.Text = voucherNo() Then
            purcVchNoTb.Text = voucherNo()
            MsgBox("Voucher Number is generated automatically and can't be changed!")
        End If
    End Sub

    Function voucherNo() As String
        Dim sql As String = "select PurcVch_No from Purchase"
        Dim max As Integer = 0
        da = New OleDbDataAdapter(sql, conn)
        Dim dtVch As New DataTable
        da.Fill(dtVch)
        If dtVch.Rows.Count > 0 Then
            For j = 0 To (dtVch.Rows.Count - 1)
                If CInt(dtVch.Rows(j).Item(0).Substring(dtVch.Rows(j).Item(0).LastIndexOf("/") + 1)) > max Then
                    max = CInt(dtVch.Rows(j).Item(0).Substring(dtVch.Rows(j).Item(0).LastIndexOf("/") + 1))
                End If
            Next
        End If
        dtVch.Clear()
        Return "P/" & userName & "/" & Date.Today.Month & "/" & Date.Today.Year & "/" & max + 1
    End Function

    Private Sub purcItemCb_Enter(sender As Object, e As EventArgs) Handles purcItemCb.Enter
        i = 0
        t = purcPartyNameCb.Items.Count
        While i < t
            If purcPartyNameCb.Text = purcPartyNameCb.Items.Item(i) Then
                Dim sql As String = "select Acc_Id, Acc_PayBal from Accounts where Acc_Name = '" & purcPartyNameCb.Text & "'"
                da = New OleDbDataAdapter(sql, conn)
                Dim dtAcc As New DataTable
                da.Fill(dtAcc)
                purcAccId = dtAcc.Rows(0).Item(0)
                prevPayBal = dtAcc.Rows(0).Item(1)
                dtAcc.Clear()
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Enter Valid Party Name")
            purcPartyNameCb.Text = ""
            purcPartyNameCb.Focus()
        End If
    End Sub

    Private Sub purcQtyTb_Enter(sender As Object, e As EventArgs) Handles purcQtyTb.Enter
        t = purcItemCb.Items.Count
        i = 0
        While i < t
            If purcItemCb.Text = purcItemCb.Items.Item(i) Then
                dtItem.Clear()
                Dim sql As String = "select * from ItemStock where Item_Name = '" & purcItemCb.Text & "'"
                da = New OleDbDataAdapter(sql, conn)
                da.Fill(dtItem)
                purcPriceTb.Text = dtItem.Rows(0).Item(1)
                Exit While
            End If
            i += 1
        End While
        If i = t Or Len(purcItemCb.Text) = 0 Then
            MsgBox("Enter Valid Item!")
            purcItemCb.Text = ""
            purcItemCb.Focus()
        End If
    End Sub

    Private Sub purcQtyTb_TextChanged(sender As Object, e As EventArgs) Handles purcQtyTb.TextChanged
        If Len(purcQtyTb.Text) <> 0 Then
            If Not IsNumeric(purcQtyTb.Text) Then
                purcQtyTb.Text = purcQtyTb.Text.Substring(0, Len(purcQtyTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub purcQtyTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles purcQtyTb.KeyPress
        If e.KeyChar = Chr(13) Then
            purcPriceTb.Focus()
        End If
    End Sub

    Private Sub purcQtyTb_Leave(sender As Object, e As EventArgs) Handles purcQtyTb.Leave
        If Not Len(purcQtyTb.Text) = 0 Then
            purcAmountTb.Text = CStr(CInt(purcQtyTb.Text) * CInt(purcPriceTb.Text))
        Else
            purcQtyTb.Text = "0"
            purcAmountTb.Text = "0"
        End If
    End Sub

    Private Sub purcPriceTb_TextChanged(sender As Object, e As EventArgs) Handles purcPriceTb.TextChanged
        purcAmountTb.Text = ""
        If Len(purcPriceTb.Text) <> 0 Then
            If Not IsNumeric(purcPriceTb.Text) Then
                purcPriceTb.Text = purcPriceTb.Text.Substring(0, Len(purcPriceTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub purcPriceTb_Leave(sender As Object, e As EventArgs) Handles purcPriceTb.Leave
        If Len(purcPriceTb.Text) = 0 Then
            purcPriceTb.Text = dtItem.Rows(0).Item(2)
        End If
        purcAmountTb.Text = CStr(CInt(purcQtyTb.Text) * CInt(purcPriceTb.Text))
    End Sub

    Private Sub purcAmountTb_TextChanged(sender As Object, e As EventArgs) Handles purcAmountTb.TextChanged
        If Len(purcAmountTb.Text) <> 0 Then
            If Not purcAmountTb.Text = CStr(CInt(purcQtyTb.Text) * CInt(purcPriceTb.Text)) Then
                MsgBox("Amount can not be changed!")
                purcAmountTb.Text = CStr(CInt(purcQtyTb.Text) * CInt(purcPriceTb.Text))
            End If
        End If
    End Sub

    Private Sub addItemBt_Click(sender As Object, e As EventArgs) Handles addItemBt.Click
        Dim j, k As Integer
        j = dtAllItem.Rows.Count
        k = 0
        While k < j
            If purcItemCb.Text = dtAllItem.Rows(k).Item(0) Then
                Exit While
            End If
            k += 1
        End While
        If purcQtyTb.Text = "0" Then
            MsgBox("Enter Quantity of Item!")
            purcQtyTb.Focus()
        Else
            dtAllItem.Rows(k).Item(3) += CInt(purcQtyTb.Text)
            itemCount += 1
            If itemCount < 7 Then
                purcItemGridView.Rows(itemCount - 1).SetValues(itemCount, purcItemCb.Text, purcQtyTb.Text, purcPriceTb.Text, purcAmountTb.Text)
            Else
                purcItemGridView.Rows.Add(itemCount, purcItemCb.Text, purcQtyTb.Text, purcPriceTb.Text, purcAmountTb.Text)
            End If
            totalQtyLb.Text = CInt(totalQtyLb.Text) + CInt(purcQtyTb.Text)
            totalAmountLb.Text = CInt(totalAmountLb.Text) + CInt(purcAmountTb.Text)
            purcItemCb.Text = ""
            purcQtyTb.Text = ""
            purcPriceTb.Text = ""
            purcAmountTb.Text = ""
            purcItemCb.Focus()
        End If
    End Sub

    Private Sub savePurcVchBt_Click(sender As Object, e As EventArgs) Handles savePurcVchBt.Click
        If Len(purcPartyNameCb.Text) = 0 Then
            MsgBox("Enter Party Name")
            purcPartyNameCb.Focus()
        Else
            If itemCount = 0 Then
                MsgBox("Enter Items")
            Else
                Dim j As Integer = 0
                While j < itemCount
                    Dim sql As String = "insert into Purchase values ('" & purcVchNoTb.Text & "','" & purcAccId & "','" & purcDate.Text & "','" & purcItemGridView.Rows(j).Cells(1).Value & "'," & CInt(purcItemGridView.Rows(j).Cells(2).Value) & "," & CInt(purcItemGridView.Rows(j).Cells(4).Value) & ")"
                    cmd = New OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    Dim k As Integer = 0
                    While k < dtAllItem.Rows.Count
                        If purcItemGridView.Rows(j).Cells(1).Value = dtAllItem.Rows(k).Item(0) Then
                            sql = "update ItemStock set Item_Qty = " & dtAllItem.Rows(k).Item(3) & " where Item_Name = '" & purcItemGridView.Rows(j).Cells(1).Value & "'"
                            cmd = New OleDbCommand(sql, conn)
                            cmd.ExecuteNonQuery()
                            Exit While
                        End If
                        k += 1
                    End While
                    sql = "update Accounts set Acc_PayBal = " & CInt(totalAmountLb.Text) + prevPayBal & " where Acc_Name = '" & purcPartyNameCb.Text & "'"
                    cmd = New OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    j += 1
                End While
                MsgBox("Voucher Added!")
                purcPartyNameCb.Text = ""
                purcItemCb.Text = ""
                purcQtyTb.Text = ""
                purcPriceTb.Text = ""
                purcAmountTb.Text = ""
                totalQtyLb.Text = "0"
                totalAmountLb.Text = "0.00"
                purcItemGridView.Rows.Clear()
                purcItemGridView.Rows.Add(6)
                itemCount = 0
                purcVchNoTb.Focus()
            End If
        End If
    End Sub

    Private Sub addPurchaseForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub quitBt_Click(sender As Object, e As EventArgs) Handles quitBt.Click
        Me.Close()
    End Sub
End Class