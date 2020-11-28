Imports System.Data.OleDb
Public Class addSaleForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t, prevBal As Integer
    Dim da As OleDbDataAdapter
    Dim dt, dtItem, dtAllItem As DataTable
    Dim itemCount As Integer = 0
    Dim saleAccId As String
    Private Sub addSaleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        da = New OleDbDataAdapter
        cmd = New OleDbCommand
        dt = New DataTable
        dtItem = New DataTable
        dtAllItem = New DataTable
        Dim sql As String = "select Acc_Name from Accounts"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            partyNameCb.Items.Add(dt.Rows(i).Item(0))
            i += 1
        End While
        Dim sql2 As String = "select Item_Name from ItemStock"
        da = New OleDbDataAdapter(sql2, conn)
        da.Fill(dtItem)
        t = dtItem.Rows.Count
        i = 0
        While i < t
            saleitemCb.Items.Add(dtItem.Rows(i).Item(0))
            i += 1
        End While
        dt.Clear()
        dtItem.Clear()
        sql = "select * from ItemStock"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dtAllItem)
        saleDate.Text = Date.Today.ToShortDateString
        saleItemGridView.Rows.Add(6)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        saleDate.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub saleDate_KeyUp(sender As Object, e As KeyEventArgs) Handles saleDate.KeyUp
        saleDate.Text = ""
    End Sub

    Private Sub vchNoTb_Enter(sender As Object, e As EventArgs) Handles vchNoTb.Enter
        vchNoTb.Text = voucherNo()
    End Sub

    Private Sub vchNoTb_TextChanged(sender As Object, e As EventArgs) Handles vchNoTb.TextChanged
        If Not vchNoTb.Text = voucherNo() Then
            vchNoTb.Text = voucherNo()
            MsgBox("Voucher Number is generated automatically and can't be changed!")
        End If
    End Sub

    Private Sub saleitemCb_Enter(sender As Object, e As EventArgs) Handles saleitemCb.Enter
        t = partyNameCb.Items.Count
        i = 0
        While i < t
            If partyNameCb.Text = partyNameCb.Items.Item(i) Then
                Dim sql As String = "select Acc_Id, Acc_Bal from Accounts where Acc_Name = '" & partyNameCb.Text & "'"
                da = New OleDbDataAdapter(sql, conn)
                Dim dtAcc As New DataTable
                da.Fill(dtAcc)
                saleAccId = dtAcc.Rows(0).Item(0)
                prevBal = dtAcc.Rows(0).Item(1)
                dtAcc.Clear()
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Entered Valid Party Name")
            partyNameCb.Text = ""
            partyNameCb.Focus()
        End If
    End Sub

    Private Sub saleQtyTb_Enter(sender As Object, e As EventArgs) Handles saleQtyTb.Enter
        t = saleitemCb.Items.Count
        i = 0
        While i < t
            If saleitemCb.Text = saleitemCb.Items.Item(i) Then
                dtItem.Clear()
                Dim sql As String = "select * from ItemStock where Item_Name = '" & saleitemCb.Text & "'"
                da = New OleDbDataAdapter(sql, conn)
                da.Fill(dtItem)
                salePriceTb.Text = dtItem.Rows(0).Item(2)
                Exit While
            End If
            i += 1
        End While
        If i = t Or Len(saleitemCb.Text) = 0 Then
            MsgBox("Enter valid Item")
            saleitemCb.Text = ""
            saleitemCb.Focus()
        End If
    End Sub

    Private Sub saleQtyTb_TextChanged(sender As Object, e As EventArgs) Handles saleQtyTb.TextChanged
        If Len(saleQtyTb.Text) <> 0 Then
            If Not IsNumeric(saleQtyTb.Text) Then
                saleQtyTb.Text = saleQtyTb.Text.Substring(0, Len(saleQtyTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub saleQtyTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles saleQtyTb.KeyPress
        If e.KeyChar = Chr(13) Then
            salePriceTb.Focus()
        End If
    End Sub

    Private Sub saleQtyTb_Leave(sender As Object, e As EventArgs) Handles saleQtyTb.Leave
        If Not Len(saleQtyTb.Text) = 0 Then
            saleAmountTb.Text = CStr(CInt(saleQtyTb.Text) * CInt(salePriceTb.Text))
        Else
            saleQtyTb.Text = "0"
            saleAmountTb.Text = "0"
        End If
    End Sub

    Private Sub addItemBt_Click(sender As Object, e As EventArgs) Handles addItemBt.Click
        Dim j, k As Integer
        j = dtAllItem.Rows.Count
        k = 0
        While k < j
            If saleitemCb.Text = dtAllItem.Rows(k).Item(0) Then
                Exit While
            End If
            k += 1
        End While
        Dim flag As Integer = 0
        If Not saleQtyTb.Text = "0" Then
            If CInt(saleQtyTb.Text) > dtAllItem.Rows(k).Item(3) Then
                If MsgBox("Stock of Item is going negetive. Would you like to continue?", vbYesNo, "Item Stock Negetive!") = vbNo Then
                    saleQtyTb.Text = ""
                    saleQtyTb.Focus()
                    flag = 1
                End If
            End If
        Else
            MsgBox("Enter Quantity of Item!")
            saleQtyTb.Focus()
            flag = 1
        End If
        If flag = 0 Then
            dtAllItem.Rows(k).Item(3) -= CInt(saleQtyTb.Text)
            itemCount += 1
            If itemCount < 7 Then
                saleItemGridView.Rows(itemCount - 1).SetValues(itemCount, saleitemCb.Text, saleQtyTb.Text, salePriceTb.Text, saleAmountTb.Text)
            Else
                saleItemGridView.Rows.Add(itemCount, saleitemCb.Text, saleQtyTb.Text, salePriceTb.Text, saleAmountTb.Text)
            End If
            totalQtyLb.Text = CInt(totalQtyLb.Text) + CInt(saleQtyTb.Text)
            totalAmountLb.Text = CInt(totalAmountLb.Text) + CInt(saleAmountTb.Text)
            saleitemCb.Text = ""
            saleQtyTb.Text = ""
            salePriceTb.Text = ""
            saleAmountTb.Text = ""
            saleitemCb.Focus()
        End If
    End Sub

    Private Sub salePriceTb_TextChanged(sender As Object, e As EventArgs) Handles salePriceTb.TextChanged
        saleAmountTb.Text = ""
        If Len(salePriceTb.Text) <> 0 Then
            If Not IsNumeric(salePriceTb.Text) Then
                salePriceTb.Text = salePriceTb.Text.Substring(0, Len(salePriceTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub salePriceTb_Leave(sender As Object, e As EventArgs) Handles salePriceTb.Leave
        If Len(salePriceTb.Text) = 0 Then
            salePriceTb.Text = dtItem.Rows(0).Item(2)
        End If
        saleAmountTb.Text = CStr(CInt(saleQtyTb.Text) * CInt(salePriceTb.Text))
    End Sub

    Private Sub saleAmountTb_TextChanged(sender As Object, e As EventArgs) Handles saleAmountTb.TextChanged
        If Len(saleAmountTb.Text) <> 0 Then
            If Not saleAmountTb.Text = CInt(saleQtyTb.Text) * CInt(salePriceTb.Text) Then
                MsgBox("Amount can not be changed!")
                saleAmountTb.Text = CStr(CInt(saleQtyTb.Text) * CInt(salePriceTb.Text))
            End If
        End If
    End Sub

    Function voucherNo() As String
        Dim sql As String = "select Vch_No from Sales"
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
        Return userName & "/" & Date.Today.Month & "/" & Date.Today.Year & "/" & max + 1
    End Function

    Private Sub saveVchBt_Click(sender As Object, e As EventArgs) Handles saveVchBt.Click
        If Len(partyNameCb.Text) = 0 Then
            MsgBox("Enter Party Name")
            partyNameCb.Focus()
        Else
            If itemCount = 0 Then
                MsgBox("Enter Items")
            Else
                Dim j As Integer = 0
                While j < itemCount
                    Dim sql As String = "insert into Sales values ('" & vchNoTb.Text & "','" & saleAccId & "','" & saleDate.Text & "','" & saleItemGridView.Rows(j).Cells(1).Value & "'," & CInt(saleItemGridView.Rows(j).Cells(2).Value) & "," & CInt(saleItemGridView.Rows(j).Cells(4).Value) & ")"
                    cmd = New OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    Dim k As Integer = 0
                    While k < dtAllItem.Rows.Count
                        If saleItemGridView.Rows(j).Cells(1).Value = dtAllItem.Rows(k).Item(0) Then
                            sql = "update ItemStock set Item_Qty = " & dtAllItem.Rows(k).Item(3) & " where Item_Name = '" & saleItemGridView.Rows(j).Cells(1).Value & "'"
                            cmd = New OleDbCommand(sql, conn)
                            cmd.ExecuteNonQuery()
                            Exit While
                        End If
                        k += 1
                    End While
                    sql = "update Accounts set Acc_Bal = " & CInt(totalAmountLb.Text) + prevBal & " where Acc_Name = '" & partyNameCb.Text & "'"
                    cmd = New OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    j += 1
                End While
                MsgBox("Voucher Added!")
                partyNameCb.Text = ""
                saleitemCb.Text = ""
                saleQtyTb.Text = ""
                salePriceTb.Text = ""
                saleAmountTb.Text = ""
                saleItemGridView.Rows.Clear()
                saleItemGridView.Rows.Add(6)
                totalAmountLb.Text = "0.00"
                totalQtyLb.Text = "0"
                itemCount = 0
                vchNoTb.Focus()
            End If
        End If
    End Sub

    Private Sub addSaleForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub quitBt_Click(sender As Object, e As EventArgs) Handles quitBt.Click
        Me.Close()
    End Sub

End Class