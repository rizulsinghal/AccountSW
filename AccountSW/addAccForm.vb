Imports System.ComponentModel
Imports System.Data.OleDb
Public Class addAccountForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub addAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        da = New OleDbDataAdapter
        cmd = New OleDbCommand
        dt = New DataTable
    End Sub

    Private Sub addbt_Click(sender As Object, e As EventArgs) Handles addbt.Click
        Dim sql As String = "select * from Accounts"
        dt.Clear()
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
            End If
            i += 1
        End While
        dt.Clear()
        If i = t Then
            Dim sql2 As String = "select Acc_Id from Accounts"
            Dim max As Integer = 0
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To (dt.Rows.Count - 1)
                    If max < CInt(dt.Rows(i).Item(0).ToString.Substring(4)) Then
                        max = CInt(dt.Rows(i).Item(0).ToString.Substring(4))
                    End If
                Next
            End If
            dt.Clear()
            sql = "insert into Accounts values ('Acc_" & max + 1 & "','" & nameTb.Text & "','" & adrsTb.Text & "','" & sttTb.Text & "','" & cntryTb.Text & "'," & telTb.Text & ", 0, 0)"
            cmd = New OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            MsgBox("Account Added Successfully")
            nameTb.Text = ""
            adrsTb.Text = ""
            sttTb.Text = ""
            cntryTb.Text = ""
            telTb.Text = ""
            nameTb.Focus()
        End If
    End Sub

    Private Sub cnclBt_Click(sender As Object, e As EventArgs) Handles cnclBt.Click
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub addAccountForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub addAccountForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dt.Clear()
        conn.Close()
    End Sub

    Private Sub telTb_TextChanged(sender As Object, e As EventArgs) Handles telTb.TextChanged
        If Len(telTb.Text) <> 0 Then
            If Not IsNumeric(telTb.Text) Then
                telTb.Text = telTb.Text.Substring(0, Len(telTb.Text) - 1)
            End If
        End If
    End Sub
End Class