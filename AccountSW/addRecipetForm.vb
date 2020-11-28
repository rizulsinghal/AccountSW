Imports System.Data.OleDb
Public Class addRecipetForm
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim dtFromAcc, dtToAcc As DataTable

    Private Sub addRecipetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select Acc_Name from Accounts"
        da = New OleDbDataAdapter(sql, conn)
        Dim dtAcc As New DataTable
        dtAcc = New DataTable
        da.Fill(dtAcc)
        For i = 0 To (dtAcc.Rows.Count - 1)
            fromCb.Items.Add(dtAcc.Rows(i).Item(0))
        Next
        dtAcc.Clear()
        sql = "select COBAcc_Name from CashOrBankAccounts"
        da = New OleDbDataAdapter(sql, conn)
        Dim dtAcc2 As New DataTable
        da.Fill(dtAcc2)
        For i = 0 To (dtAcc2.Rows.Count - 1)
            toCb.Items.Add(dtAcc2.Rows(i).Item(0))
        Next
        dateTb.Text = Date.Today.ToShortDateString
        rcptNoTb.Text = recipetNo()
        rcptNoTb.Enabled = False
    End Sub

    Function recipetNo() As String
        Dim sql As String = "select Count(Rcpt_No), Max(Rcpt_No) from RecipetReg"
        da = New OleDbDataAdapter(sql, conn)
        Dim dtTemp As New DataTable
        da.Fill(dtTemp)
        If dtTemp.Rows(0).Item(0) > 0 Then
            Return CStr(dtTemp.Rows(0).Item(1) + 1)
        Else
            Return "1"
        End If
        dtTemp.Clear()
    End Function

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dateTb.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub dateTb_KeyUp(sender As Object, e As KeyEventArgs) Handles dateTb.KeyUp
        dateTb.Text = ""
    End Sub

    Private Sub toCb_Enter(sender As Object, e As EventArgs) Handles toCb.Enter
        i = 0
        t = fromCb.Items.Count
        While i < t
            If fromCb.Text = fromCb.Items.Item(i) Then
                Dim sql As String = "select Acc_Id, Acc_Bal, Acc_PayBal from Accounts where Acc_Name = '" & fromCb.Text & "'"
                da = New OleDbDataAdapter(sql, conn)
                dtFromAcc = New DataTable
                da.Fill(dtFromAcc)
                balanceLb.Text = "( Cur. Bal. : Rs. " & dtFromAcc.Rows(0).Item(1) & " )"
                balanceLb.Visible = True
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Invalid Account Name")
            fromCb.Text = ""
            fromCb.Focus()
        End If
    End Sub

    Private Sub amountTb_Enter(sender As Object, e As EventArgs) Handles amountTb.Enter
        i = 0
        t = toCb.Items.Count
        While i < t
            If toCb.Text = toCb.Items.Item(i) Then
                Dim sql As String = "select COBAcc_Id, COBAcc_Bal from CashOrBankAccounts where COBAcc_Name = '" & toCb.Items.Item(i) & "'"
                da = New OleDbDataAdapter(sql, conn)
                dtToAcc = New DataTable
                da.Fill(dtToAcc)
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Invalid Account Name")
        End If
    End Sub

    Private Sub amountTb_TextChanged(sender As Object, e As EventArgs) Handles amountTb.TextChanged
        If Len(amountTb.Text) <> 0 Then
            If Not IsNumeric(amountTb.Text) Then
                amountTb.Text = amountTb.Text.Substring(0, Len(amountTb.Text) - 1)
            End If
        End If
    End Sub

    Private Sub saveRecipetBt_Click(sender As Object, e As EventArgs) Handles saveRecipetBt.Click
        Dim sql As String = "insert into RecipetReg values ('" & dateTb.Text & "','" & dtFromAcc.Rows(0).Item(0) & "','" & dtToAcc.Rows(0).Item(0) & "'," & amountTb.Text & "," & rcptNoTb.Text & ")"
        cmd = New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        If CInt(dtFromAcc.Rows(0).Item(1)) < CInt(amountTb.Text) Then
            sql = "update Accounts set Acc_Bal = 0, Acc_PayBal = " & CInt(dtFromAcc.Rows(0).Item(2)) + (CInt(amountTb.Text) - CInt(dtFromAcc.Rows(0).Item(1))) & " where Acc_Id = '" & dtFromAcc.Rows(0).Item(0) & "'"
        Else
            sql = "update Accounts set Acc_Bal = " & CInt(dtFromAcc.Rows(0).Item(1)) - CInt(amountTb.Text) & " where Acc_Id = '" & dtFromAcc.Rows(0).Item(0) & "'"
        End If
        cmd = New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        sql = "update CashOrBankAccounts set COBAcc_Bal = " & CInt(dtToAcc.Rows(0).Item(1)) + CInt(amountTb.Text) & " where COBAcc_Id = '" & dtToAcc.Rows(0).Item(0) & "'"
        cmd = New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Recipet Added Successfully!")
        fromCb.Text = ""
        toCb.Text = ""
        amountTb.Text = ""
        balanceLb.Text = "( Cur. Bal. : Rs. "
        balanceLb.Visible = False
        rcptNoTb.Text = recipetNo()
        fromCb.Focus()
    End Sub

    Private Sub addRecipetForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub quitBt_Click(sender As Object, e As EventArgs) Handles quitBt.Click
        Me.Close()
    End Sub
End Class