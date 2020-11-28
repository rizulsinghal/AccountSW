Imports System.Data.OleDb
Public Class addItemForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub addItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        da = New OleDbDataAdapter
        cmd = New OleDbCommand
        dt = New DataTable
    End Sub

    Private Sub itemUnitCb_Leave(sender As Object, e As EventArgs) Handles itemUnitCb.Leave
        Dim j As Integer = 0
        While j < 7
            If itemUnitCb.Text.ToUpper = itemUnitCb.Items.Item(j) Then
                Label3.Text = "Quantity (in " & itemUnitCb.Text.ToUpper & ")"
                Label4.Text = "Purc. Price (Per " & itemUnitCb.Text.ToUpper & ")"
                Label5.Text = "Sales Price (Per " & itemUnitCb.Text.ToUpper & ")"
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

    Private Sub itemNameTb_Leave(sender As Object, e As EventArgs) Handles itemNameTb.Leave
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
            End If
            i += 1
        End While
        dt.Clear()
    End Sub

    Private Sub addItemBt_Click(sender As Object, e As EventArgs) Handles addItemBt.Click
        If Len(itemNameTb.Text) = 0 Or Len(itemQtyTb.Text) = 0 Or Len(itemUnitCb.Text) = 0 Or Len(itemSPTb.Text) = 0 Or Len(itemPPTb.Text) = 0 Then
            MsgBox("No field can be empty")
            itemNameTb.Focus()
        Else
            Dim sql As String = "insert into ItemStock (Item_Name, Item_PurchasePrice, Item_SalesPrice, Item_Qty, Item_Unit)values ('" & itemNameTb.Text & "'," & itemPPTb.Text & "," & itemSPTb.Text & "," & itemQtyTb.Text & ",'" & itemUnitCb.Text & "')"
            cmd = New OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            MsgBox("Item Added Successfully")
            itemNameTb.Text = ""
            itemUnitCb.Text = ""
            itemQtyTb.Text = ""
            itemPPTb.Text = ""
            itemSPTb.Text = ""
            itemNameTb.Focus()
        End If
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub addItemForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(0, 0)
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

    Private Sub cancelItemBt_Click(sender As Object, e As EventArgs) Handles cancelItemBt.Click
        conn.Close()
        Me.Close()
    End Sub

End Class