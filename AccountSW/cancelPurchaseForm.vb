Imports System.Data.OleDb
Public Class cancelPurchaseForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub cancelPurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select PurcVch_No from Purchase Group by PurcVch_No"
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        For i = 0 To (dt.Rows.Count - 1)
            selectVchNoCb.Items.Add(dt.Rows(i).Item(0))
        Next
        dt.Clear()
    End Sub

    Private Sub cancelVchBt_Click(sender As Object, e As EventArgs) Handles cancelVchBt.Click
        t = selectVchNoCb.Items.Count
        i = 0
        While i < t
            If selectVchNoCb.Text = selectVchNoCb.Items.Item(i) Then
                If MessageBox.Show("Do you really want to Cancel this Voucher?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Dim sql As String = "select Product, Qty from Purchase where PurcVch_No = '" & selectVchNoCb.Text & "'"
                    da = New OleDbDataAdapter(sql, conn)
                    Dim dtTemp As DataTable
                    dtTemp = New DataTable
                    da.Fill(dtTemp)
                    Dim x As Integer = dtTemp.Rows.Count
                    Dim j As Integer
                    Dim dtTemp2 As DataTable
                    dtTemp2 = New DataTable
                    For j = 0 To (dtTemp.Rows.Count - 1)
                        sql = "select Item_Qty from ItemStock where Item_Name = '" & dtTemp.Rows(j).Item(0) & "'"
                        da = New OleDbDataAdapter(sql, conn)
                        da.Fill(dtTemp2)
                        sql = "update ItemStock set Item_Qty = " & (dtTemp2.Rows(0).Item(0) - dtTemp.Rows(j).Item(1)) & " where Item_Name = '" & dtTemp.Rows(j).Item(0) & "'"
                        cmd = New OleDbCommand(sql, conn)
                        cmd.ExecuteNonQuery()
                        dtTemp2.Clear()
                    Next
                    sql = "select sum(Amount), Acc_Id from Purchase where PurcVch_No = '" & selectVchNoCb.Text & "' Group by PurcVch_No, Acc_Id"
                    da = New OleDbDataAdapter(sql, conn)
                    Dim dtTemp3 As New DataTable
                    da.Fill(dtTemp3)
                    sql = "select Acc_PayBal from Accounts where Acc_Id = '" & dtTemp3.Rows(0).Item(1) & "'"
                    da = New OleDbDataAdapter(sql, conn)
                    Dim dtTemp4 As New DataTable
                    da.Fill(dtTemp4)
                    sql = "update Accounts set Acc_PayBal = " & dtTemp4.Rows(0).Item(0) - dtTemp3.Rows(0).Item(0) & " where Acc_Id = '" & dtTemp3.Rows(0).Item(1) & "'"
                    cmd = New OleDbCommand(sql, conn)
                    t = cmd.ExecuteNonQuery()
                    sql = "delete from Purchase where PurcVch_No = '" & selectVchNoCb.Text & "'"
                    cmd = New OleDbCommand(sql, conn)
                    t = cmd.ExecuteNonQuery()
                    MsgBox("Purchase Voucher Canceled!")
                    selectVchNoCb.Text = ""
                    dt.Clear()
                End If
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Enter valid Voucher No.")
            selectVchNoCb.Text = ""
            selectVchNoCb.Focus()
        End If
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub close2Bt_Click(sender As Object, e As EventArgs) Handles close2Bt.Click
        Me.Close()
    End Sub

    Private Sub cancelPurchaseForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub

End Class