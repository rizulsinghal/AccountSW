Imports System.Data.OleDb
Public Class modifyAccForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Friend modifyAccName As String

    Private Sub modifyAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from Accounts"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            searchView.Rows.Add(dt.Rows(i).Item(1))
            i += 1
        End While
        dt.Clear()
        modifyAccName = searchView.Rows(0).Cells(0).Value
    End Sub

    Private Sub searchTb_TextChanged(sender As Object, e As EventArgs) Handles searchTb.TextChanged
        searchView.Rows.Clear()
        Dim sql As String = "select * from Accounts where Acc_Name like '%" & searchTb.Text & "%'"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            searchView.Rows.Add(dt.Rows(i).Item(1))
            i += 1
        End While
        dt.Clear()
    End Sub

    Dim modifyAccId As String = Nothing

    Private Sub searchView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchView.CellClick
        modifyAccName = searchView.CurrentRow.Cells(0).Value
    End Sub

    Private Sub selectAccBt_Click(sender As Object, e As EventArgs) Handles selectAccBt.Click
        dt.Clear()
        Dim sql As String = "select * from Accounts where Acc_Name = '" & modifyAccName & "'"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        modifyAccId = dt.Rows(0).Item(0)
        nameTb.Text = dt.Rows(0).Item(1).ToString
        adrsTb.Text = dt.Rows(0).Item(2).ToString
        sttTb.Text = dt.Rows(0).Item(3).ToString
        cntryTb.Text = dt.Rows(0).Item(4).ToString
        telTb.Text = dt.Rows(0).Item(5).ToString
        modifyAccPanel.Enabled = True
        nameTb.Focus()
        searchPanel.Enabled = False
    End Sub

    Private Sub cancelAccBt_Click(sender As Object, e As EventArgs) Handles cancelAccBt.Click
        Me.Close()
    End Sub

    Private Sub deleteAccModifyBt_Click(sender As Object, e As EventArgs) Handles deleteAccModifyBt.Click
        Dim sql As String = "delete from Accounts where Acc_Id = '" & modifyAccId & "'"
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            cmd = New OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            MsgBox("Account Deleted")
            nameTb.Text = ""
            adrsTb.Text = ""
            sttTb.Text = ""
            cntryTb.Text = ""
            telTb.Text = ""
            modifyAccPanel.Enabled = False
            dt.Clear()
            searchView.Rows.Clear()
            sql = "select * from Accounts"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            t = dt.Rows.Count
            i = 0
            While i < t
                searchView.Rows.Add(dt.Rows(i).Item(1))
                i += 1
            End While
            dt.Clear()
        End If
    End Sub

    Private Sub modifyAccBt_Click(sender As Object, e As EventArgs) Handles modifyAccBt.Click
        dt.Clear()
        Dim sql As String = "select * from Accounts"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            If nameTb.Text = dt.Rows(i).Item(1) Then
                MsgBox("Account Name Already Registered!")
                nameTb.Text = ""
                nameTb.Focus()
                Exit While
            ElseIf Len(nameTb.Text) = 0 Then
                MsgBox("Account Name can not be Empty!")
                nameTb.Focus()
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            sql = "update Accounts set Acc_Name = '" & nameTb.Text & "', Acc_Add = '" & adrsTb.Text & "', Acc_State = '" & sttTb.Text & "', Acc_Cntry = '" & cntryTb.Text & "', Acc_Phn = " & telTb.Text & " where Acc_Id = '" & modifyAccId & "'"
            cmd = New OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            MsgBox("Account Updated Successfully")
            nameTb.Text = ""
            adrsTb.Text = ""
            sttTb.Text = ""
            cntryTb.Text = ""
            telTb.Text = ""
            modifyAccPanel.Enabled = False
            dt.Clear()
            searchView.Rows.Clear()
            sql = "select * from Accounts"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            t = dt.Rows.Count
            i = 0
            While i < t
                searchView.Rows.Add(dt.Rows(i).Item(1))
                i += 1
            End While
            dt.Clear()
        End If
    End Sub

    Private Sub modifyAccForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub telTb_TextChanged(sender As Object, e As EventArgs) Handles telTb.TextChanged
        If Len(telTb.Text) <> 0 Then
            If Not IsNumeric(telTb.Text) Then
                telTb.Text = telTb.Text.Substring(0, Len(telTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub cancelModifyBt_Click(sender As Object, e As EventArgs) Handles cancelModifyBt.Click
        nameTb.Text = ""
        adrsTb.Text = ""
        sttTb.Text = ""
        cntryTb.Text = ""
        telTb.Text = ""
        modifyAccPanel.Enabled = False
        searchPanel.Enabled = True
    End Sub
End Class