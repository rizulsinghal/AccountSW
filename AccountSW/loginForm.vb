Imports System.Data.OleDb
Public Class loginForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\AccountSW\AccountSW\Resources\company.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from company where compId = '" & comId & "'"
        da = New OleDbDataAdapter(sql, conn)
        cmd = New OleDbCommand
        dt = New DataTable
        da.Fill(dt)
        comName = dt.Rows(0).Item(1).ToString
        comAd = dt.Rows(0).Item(2).ToString
        comStt = dt.Rows(0).Item(3).ToString
        comCntry = dt.Rows(0).Item(4).ToString
        comTel = dt.Rows(0).Item(5).ToString
        comEmail = dt.Rows(0).Item(6).ToString
        dt.Clear()
        conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AccountSW\Data\" & comId & "\" & comId & ".mdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub cancelBt_Click(sender As Object, e As EventArgs) Handles cancelBt.Click
        Me.Close()
    End Sub

    Private Sub loginBt_Click(sender As Object, e As EventArgs) Handles loginBt.Click
        If Len(userNameTb.Text) = 0 Or Len(userPswrdTb.Text) = 0 Then
            MsgBox("Feild can't be empty")
            userNameTb.Focus()
        End If
        Dim sql As String = "select * from Admins"
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        t = dt.Rows.Count
        i = 0
        While i < t
            If userNameTb.Text = dt.Rows(i).Item(0).ToString Then
                If userPswrdTb.Text = dt.Rows(i).Item(1) Then
                    userName = userNameTb.Text
                    mainForm.Show()
                    homePageForm.Hide()
                    Me.Close()
                    Exit While
                Else
                    MsgBox("Password is wrong!")
                    userPswrdTb.Text = ""
                    userPswrdTb.Focus()
                    Exit While
                End If
            End If
            i += 1
        End While
        If i = t Then
            MsgBox("Username is not registered!")
            userNameTb.Text = ""
            userPswrdTb.Text = ""
            userNameTb.Focus()
        End If
        dt.Clear()
    End Sub
End Class