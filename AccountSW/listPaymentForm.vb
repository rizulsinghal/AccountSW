Imports System.Data.OleDb
Public Class listPaymentForm
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim i, t As Integer
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub listPaymentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select Entry_Date, Pymnt_No, PayingAcc_Id, ReceivingAcc_id, Amount from PaymentReg Order By Pymnt_No"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        Dim dtTemp As New DataTable
        Dim dtTemp2 As New DataTable
        While i < t
            sql = "select Acc_Name from Accounts where Acc_Id = '" & dt.Rows(i).Item(3) & "'"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dtTemp)
            sql = "select COBAcc_Name from CashOrBankAccounts where COBAcc_Id = '" & dt.Rows(i).Item(2) & "'"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dtTemp2)
            recipetView.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1), dtTemp.Rows(0).Item(0), dtTemp2.Rows(0).Item(0), dt.Rows(i).Item(4))
            i += 1
            dtTemp.Clear()
        End While
        If i < 27 Then
            recipetView.Rows.Add(27 - i)
        End If
        dt.Clear()
    End Sub

    Private Sub listPaymentForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub
End Class