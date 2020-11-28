Imports System.Data.OleDb
Public Class addPaymentForm
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim dtFromAcc, dtToAcc As DataTable

    Private Sub addPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            toCb.Items.Add(dtAcc.Rows(i).Item(0))
        Next
        dtAcc.Clear()
        sql = "select COBAcc_Name from CashOrBankAccounts"
        da = New OleDbDataAdapter(sql, conn)
        Dim dtAcc2 As New DataTable
        da.Fill(dtAcc2)
        For i = 0 To (dtAcc2.Rows.Count - 1)
            fromCb.Items.Add(dtAcc2.Rows(i).Item(0))
        Next
        dtAcc2.Clear()
        dateTb.Text = Date.Today.ToShortDateString
        pymntNoTb.Text = paymentNo()
        pymntNoTb.Enabled = False
    End Sub

    Function paymentNo() As String
        Dim sql As String = "select Count(Pymnt_No), Max(Pymnt_No) from PaymentReg"
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

    Private Sub fromCb_Enter(sender As Object, e As EventArgs) Handles fromCb.Enter
        i = 0
        t = toCb.Items.Count
        While i < t
            If toCb.Text = toCb.Items.Item(i) Then
                Dim sql As String = "select Acc_Id, Acc_PayBal, Acc_Bal from Accounts where Acc_Name = '" & toCb.Text & "'"
                da = New OleDbDataAdapter(sql, conn)
                dtToAcc = New DataTable
                da.Fill(dtToAcc)
                balanceLb.Text = "( Cur. Bal. : Rs. " & dtToAcc.Rows(0).Item(1) & " )"
                balanceLb.Visible = True
                Exit While
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Invalid Account Name")
            toCb.Text = ""
            toCb.Focus()
        End If
    End Sub

    Private Sub amountTb_Enter(sender As Object, e As EventArgs) Handles amountTb.Enter
        i = 0
        t = fromCb.Items.Count
        While i < t
            If fromCb.Text = fromCb.Items.Item(i) Then
                Dim sql As String = "select COBAcc_Id, COBAcc_Bal from CashOrBankAccounts where COBAcc_Name = '" & fromCb.Items.Item(i) & "'"
                da = New OleDbDataAdapter(sql, conn)
                dtFromAcc = New DataTable
                da.Fill(dtFromAcc)
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


    Private Sub savePaymentBt_Click(sender As Object, e As EventArgs) Handles savePaymentBt.Click
        Dim flag As Integer = 0
        If dtFromAcc.Rows(0).Item(1) - CInt(amountTb.Text) < 0 Then
            If MsgBox(fromCb.Text & "is going negetive! Do you want to continue?", vbOKCancel + vbQuestion) = vbCancel Then
                amountTb.Text = ""
                amountTb.Focus()
                flag = 1
            End If
        End If
        If flag = 0 Then
            Dim sql As String = "insert into PaymentReg values ('" & dateTb.Text & "','" & dtFromAcc.Rows(0).Item(0) & "','" & dtToAcc.Rows(0).Item(0) & "'," & amountTb.Text & "," & pymntNoTb.Text & ")"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            sql = "update CashOrBankAccounts set COBAcc_Bal = " & CInt(dtFromAcc.Rows(0).Item(1)) - CInt(amountTb.Text) & " where COBAcc_Id = '" & dtFromAcc.Rows(0).Item(0) & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            If CInt(dtToAcc.Rows(0).Item(1)) < CInt(amountTb.Text) Then
                sql = "update Accounts set Acc_PayBal = 0, Acc_Bal = " & CInt(dtToAcc.Rows(0).Item(2)) + (CInt(amountTb.Text) - CInt(dtToAcc.Rows(0).Item(1))) & " where Acc_Id = '" & dtToAcc.Rows(0).Item(0) & "'"
            Else
                sql = "update Accounts set Acc_PayBal = " & CInt(dtToAcc.Rows(0).Item(1)) - CInt(amountTb.Text) & " where Acc_Id = '" & dtToAcc.Rows(0).Item(0) & "'"
            End If
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Payment Done Successfully!")
            fromCb.Text = ""
            toCb.Text = ""
            amountTb.Text = ""
            balanceLb.Text = "( Cur. Bal. : Rs. "
            balanceLb.Visible = False
            pymntNoTb.Text = paymentNo()
            toCb.Focus()
        End If
    End Sub

    Private Sub addPaymentForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub quitBt_Click(sender As Object, e As EventArgs) Handles quitBt.Click
        Me.Close()
    End Sub

End Class