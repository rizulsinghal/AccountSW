Imports System.Data.OleDb
Public Class modifyItemForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub modifyItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from ItemStock"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            searchView.Rows.Add(dt.Rows(i).Item(0))
            i += 1
        End While
        dt.Clear()
    End Sub

    Private Sub searchTb_TextChanged(sender As Object, e As EventArgs) Handles searchTb.TextChanged
        searchView.Rows.Clear()
        Dim sql As String = "select * from ItemStock where Item_Name like '%" & searchTb.Text & "%'"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            searchView.Rows.Add(dt.Rows(i).Item(0))
            i += 1
        End While
        dt.Clear()
    End Sub
    Dim modifyItemId As Integer = Nothing
    Private Sub selectItemBt_Click(sender As Object, e As EventArgs) Handles selectItemBt.Click
        dt.Clear()
        Dim modifyItemName As String = searchView.CurrentRow.Cells(0).Value
        Dim sql As String = "select * from ItemStock where Item_Name = '" & modifyItemName & "'"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        modifyItemId = dt.Rows(0).Item(5)
        itemNameTb.Text = dt.Rows(0).Item(0).ToString
        itemPPTb.Text = dt.Rows(0).Item(1).ToString
        itemSPTb.Text = dt.Rows(0).Item(2).ToString
        itemQtyTb.Text = dt.Rows(0).Item(3).ToString
        itemUnitCb.Text = dt.Rows(0).Item(4).ToString
        modifyItemPanel.Enabled = True
        itemNameTb.Focus()
    End Sub

    Private Sub itemQtyTb_TextChanged(sender As Object, e As EventArgs) Handles itemQtyTb.TextChanged
        If Len(itemQtyTb.Text) <> 0 Then
            If Not IsNumeric(itemQtyTb.Text) Then
                itemQtyTb.Text = itemQtyTb.Text.Substring(0, Len(itemQtyTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub itemPPTb_TextChanged(sender As Object, e As EventArgs) Handles itemPPTb.TextChanged
        If Len(itemPPTb.Text) <> 0 Then
            If Not IsNumeric(itemPPTb.Text) Then
                itemPPTb.Text = itemPPTb.Text.Substring(0, Len(itemPPTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub itemSPTb_TextChanged(sender As Object, e As EventArgs) Handles itemSPTb.TextChanged
        If Len(itemSPTb.Text) <> 0 Then
            If Not IsNumeric(itemSPTb.Text) Then
                itemSPTb.Text = itemSPTb.Text.Substring(0, Len(itemSPTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub itemUnitCb_Leave(sender As Object, e As EventArgs) Handles itemUnitCb.Leave
        Dim j As Integer = 0
        While j < 7
            If itemUnitCb.Text.ToUpper = itemUnitCb.Items.Item(j) Then
                Label3.Text = "Quantity (in " & itemUnitCb.Text.ToUpper & ")"
                Label4.Text = "Purc. Price (in " & itemUnitCb.Text.ToUpper & ")"
                Label5.Text = "Sales Price (in " & itemUnitCb.Text.ToUpper & ")"
                Exit While
            End If
            j += 1
        End While
        If j = 7 Then
            MsgBox("Choose from the given units!")
            itemUnitCb.Text = ""
            itemUnitCb.Focus()
        End If
    End Sub

    Private Sub cancelItemBt_Click(sender As Object, e As EventArgs) Handles cancelItemBt.Click
        itemNameTb.Text = ""
        itemUnitCb.Text = ""
        itemQtyTb.Text = ""
        itemPPTb.Text = ""
        itemSPTb.Text = ""
        modifyItemPanel.Enabled = False
    End Sub

    Private Sub cancelModifyBt_Click(sender As Object, e As EventArgs) Handles cancelModifyBt.Click
        Me.Close()
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub modifyItemForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub deleteItemBt_Click(sender As Object, e As EventArgs) Handles deleteItemBt.Click
        Dim sql As String = "delete from ItemStock where Item_Id = " & modifyItemId
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            cmd = New OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            MsgBox("Item Deleted")
            itemNameTb.Text = ""
            itemUnitCb.Text = ""
            itemQtyTb.Text = ""
            itemPPTb.Text = ""
            itemSPTb.Text = ""
            modifyItemPanel.Enabled = False
            dt.Clear()
            searchView.Rows.Clear()
            sql = "select * from ItemStock"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            t = dt.Rows.Count
            i = 0
            While i < t
                searchView.Rows.Add(dt.Rows(i).Item(0))
                i += 1
            End While
            dt.Clear()
        End If
    End Sub

    Private Sub modifyItemBt_Click(sender As Object, e As EventArgs) Handles modifyItemBt.Click
        dt.Clear()
        Dim sql As String = "select Item_Name from ItemStock"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            If itemNameTb.Text = dt.Rows(i).Item(0) Then
                MsgBox("Item with this name is already added!")
                itemNameTb.Text = ""
                itemNameTb.Focus()
                Exit While
            ElseIf Len(itemNameTb.Text) = 0 Then
                MsgBox("No field can be empty!")
                itemNameTb.Focus()
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            sql = "update ItemStock set Item_Name = '" & itemNameTb.Text & "', Item_Unit = '" & itemUnitCb.Text & "', Item_SalesPrice = " & itemSPTb.Text & ", Item_PurchasePrice = " & itemPPTb.Text & ", Item_Qty = " & itemQtyTb.Text & " where Item_Id = " & modifyItemId
            cmd = New OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            MsgBox("Item Updated Successfully")
            itemNameTb.Text = ""
            itemUnitCb.Text = ""
            itemQtyTb.Text = ""
            itemPPTb.Text = ""
            itemSPTb.Text = ""
            modifyItemPanel.Enabled = False
            dt.Clear()
            searchView.Rows.Clear()
            sql = "select * from ItemStock"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            t = dt.Rows.Count
            i = 0
            While i < t
                searchView.Rows.Add(dt.Rows(i).Item(0))
                i += 1
            End While
            dt.Clear()
        End If
    End Sub

End Class