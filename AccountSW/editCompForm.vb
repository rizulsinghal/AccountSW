Imports System.Data.OleDb
Public Class editCompForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub editCompForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\AccountSW\AccountSW\Resources\company.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        da = New OleDbDataAdapter
        cmd = New OleDbCommand
        dt = New DataTable
        nameTb.Text = comName
        adrsTb.Text = comAd
        sttTb.Text = comStt
        cntryTb.Text = comCntry
        telTb.Text = comTel
        emailTb.Text = comEmail
    End Sub

    Private Sub closeBt_Click(sender As Object, e As EventArgs) Handles closeBt.Click
        Me.Close()
    End Sub

    Private Sub saveEditBt_Click(sender As Object, e As EventArgs) Handles saveEditBt.Click
        Dim sql As String = "select * from company"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        i = 0
        t = dt.Rows.Count
        Dim flag As Integer = 0
        If Len(nameTb.Text) = 0 Or Len(adrsTb.Text) = 0 Or Len(emailTb.Text) = 0 Or Len(telTb.Text) = 0 Or Len(sttTb.Text) = 0 Or Len(cntryTb.Text) = 0 Then
            MsgBox("Feild can't be empty")
            nameTb.Focus()
            flag = 1
        End If
        If flag = 0 Then
            sql = "update company set compAd = '" & adrsTb.Text & "', compStt = '" & sttTb.Text & "', compCon = '" & cntryTb.Text & "', compTel = '" & telTb.Text & "', compEmail = '" & emailTb.Text & "' where compId = '" & comId & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            comName = nameTb.Text
            comAd = adrsTb.Text
            comStt = sttTb.Text
            comCntry = cntryTb.Text
            comTel = telTb.Text
            comEmail = emailTb.Text
            MsgBox("Company Updated Successfully!")
        End If
    End Sub

    Private Sub editCompForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Location = New Point()
    End Sub

End Class