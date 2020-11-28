Imports System.Data.OleDb
Public Class listItemForm
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim i, t As Integer
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub listItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from ItemStock order by Item_Name"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            itemView.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(3), dt.Rows(i).Item(4), dt.Rows(i).Item(1), dt.Rows(i).Item(2))
            i += 1
        End While
        If i < 27 Then
            itemView.Rows.Add(27 - i)
        End If
        dt.Clear()
    End Sub

    Private Sub listItemForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point(0, 0)
    End Sub
End Class