Imports System.Data.OleDb
Public Class ListAccForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub accountView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles accountView.CellDoubleClick
        modifyAccForm.Show()
        modifyAccForm.MdiParent = mainForm
        modifyAccForm.modifyAccName = accountView.CurrentRow.Cells(0).Value
        modifyAccForm.selectAccBt.PerformClick()
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub ListAccForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub ListAccForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from Accounts order by Acc_Name"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            accountView.Rows.Add(dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3), dt.Rows(i).Item(4), dt.Rows(i).Item(5))
            i += 1
        End While
        If i < 27 Then
            accountView.Rows.Add(27 - i)
        End If
        dt.Clear()
    End Sub
End Class