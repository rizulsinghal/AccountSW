﻿Imports System.Data.OleDb
Public Class listSaleForm
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim i, t As Integer
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub listSaleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select Sale_Date, Vch_No, Acc_Id, Sum(Amount) from Sales Group By Vch_No, Acc_Id, Sale_Date Order By Vch_No"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        Dim dtTemp As New DataTable
        While i < t
            sql = "select Acc_Name from Accounts where Acc_Id = '" & dt.Rows(i).Item(2) & "'"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dtTemp)
            saleView.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1), dtTemp.Rows(0).Item(0), dt.Rows(i).Item(3))
            i += 1
            dtTemp.Clear()
        End While
        If i < 27 Then
            saleView.Rows.Add(27 - i)
        End If
        dt.Clear()
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub listSaleForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub

End Class