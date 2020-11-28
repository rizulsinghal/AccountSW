Imports ADOX
Imports System.IO
Imports System.Data.OleDb
Public Class homePageForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim i, t As Integer
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\AccountSW\AccountSW\Resources\company.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        da = New OleDbDataAdapter
        cmd = New OleDbCommand
        dt = New DataTable
    End Sub

    Private Sub createBt_Click(sender As Object, e As EventArgs) Handles createComBt.Click
        createPanel.Show()
        nameTb.Focus()
        cmpnyViewPanel.Hide()
    End Sub

    Private Sub saveBt_Click(sender As Object, e As EventArgs) Handles saveBt.Click
        dt.Clear()
        Dim sql As String = "select * from company"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        i = 0
        t = dt.Rows.Count
        Dim flag As Integer = 0
        While i < t
            If Len(nameTb.Text) = 0 Or Len(adrsTb.Text) = 0 Or Len(emailTb.Text) = 0 Or Len(telTb.Text) = 0 Or Len(sttTb.Text) = 0 Or Len(cntryTb.Text) = 0 Then
                MsgBox("Feild can't be empty")
                nameTb.Focus()
                flag = 1
                Exit While
            ElseIf nameTb.Text = dt.Rows(i).Item(1) Then
                MsgBox("Company Name is already registered")
                flag = 1
                Exit While
            End If
            i += 1
        End While
        If flag = 0 Then
            Dim sql2 As String = "select compId from company"
            Dim max As Integer = 0
            dt.Clear()
            da = New OleDbDataAdapter(sql2, conn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To (dt.Rows.Count - 1)
                    If max < CInt(dt.Rows(i).Item(0).ToString.Substring(4)) Then
                        max = CInt(dt.Rows(i).Item(0).ToString.Substring(4))
                    End If
                Next
            End If
            dt.Clear()
            comId = "COMP" & max + 1
            sql = "insert into company (compId, compName, compAd, compStt, CompCon, compTel, compEmail) values ('" & comId & "','" & nameTb.Text & "','" & adrsTb.Text & "','" & sttTb.Text & "','" & cntryTb.Text & "','" & telTb.Text & "','" & emailTb.Text & "')"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New OleDb.OleDbCommand(sql, conn)
            t = cmd.ExecuteNonQuery()
            Dim dbPath As String = "D:\AccountSW\Data\" & comId
            If Not Directory.Exists(dbPath) Then
                Directory.CreateDirectory(dbPath)
            End If
            Dim cat As Catalog = New Catalog()
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath & "\" & comId & ".mdb;Jet OLEDB:Engine Type=5")
            Dim conn2 As New OleDbConnection
            conn2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & "\" & comId & ".mdb"
            If conn2.State = ConnectionState.Closed Then
                conn2.Open()
            End If
            sql = "Create Table Admins(
                userName Varchar(255),
                userPswrd Varchar(255)
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create Table Accounts(
                Acc_Id Varchar(255) Primary Key Not Null,
                Acc_Name Varchar(255),
                Acc_Add Varchar(255),
                Acc_State Varchar(255),
                Acc_Cntry Varchar (255),
                Acc_Phn Number,
                Acc_Bal Number,
                Acc_PayBal Number
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create Table CashOrBankAccounts(
                COBAcc_Id Varchar(255) Primary Key,
                COBAcc_Name Varchar(255),
                COBAcc_Bal Number
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "insert into CashOrBankAccounts values ('COBAcc_1','Cash',0)"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create table Purchase(
                PurcVch_No Varchar(255),
                Acc_Id Varchar(255),
                Purc_Date Date,
                Product Varchar(255),
                Qty Number,
                Amount Number,
                Constraint FK_APurc Foreign Key (Acc_Id) References Accounts(Acc_Id)
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create Table Sales(
                Vch_No Varchar(255),
                Acc_Id Varchar(255),
                Sale_Date Date,
                Product Varchar(255),
                Qty Number,
                Amount Number,
                Constraint FK_ASale Foreign Key (Acc_Id) References Accounts(Acc_Id)
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create Table ItemStock(
                Item_Name Varchar(255),
                Item_PurchasePrice Number,
                Item_SalesPrice Number,
                Item_Qty Number,
                Item_Unit Varchar(255),
                Item_Id AutoIncrement 
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create Table RecipetReg(                
                Entry_Date Date,
                PayingAcc_Id Varchar(255),
                ReceivingAcc_Id Varchar(255),
                Amount Number,
                Rcpt_No Number,
                Constraint FK_PayingAcc Foreign Key (PayingAcc_Id) References Accounts(Acc_Id),
                Constraint FK_ReceivingAcc Foreign Key (ReceivingAcc_Id) References CashOrBankAccounts(COBAcc_Id)
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            sql = "Create Table PaymentReg(
                Entry_Date Date,
                PayingAcc_Id Varchar(255),
                ReceivingAcc_Id Varchar(255),
                Amount Number,
                Pymnt_No Number,
                Constraint FK_PayingPaymentAcc Foreign Key (PayingAcc_Id) References CashOrBankAccounts(COBAcc_Id),
                Constraint FK_ReceivingPaymentAcc Foreign Key (ReceivingAcc_Id) References Accounts(Acc_Id)
                )"
            cmd = New OleDbCommand(sql, conn2)
            t = cmd.ExecuteNonQuery()
            MsgBox("Company Created Succcessfully")
            cat = Nothing
            dt.Clear()
            nameTb.Text = ""
            emailTb.Text = ""
            adrsTb.Text = ""
            telTb.Text = ""
            sttTb.Text = ""
            cntryTb.Text = ""
            createPanel.Hide()
            sprUsrPanel.Show()
            sUNameTb.Focus()
        End If
    End Sub

    Private Sub saveUserBt_Click(sender As Object, e As EventArgs) Handles saveUserBt.Click
        Dim dbPath As String = "D:\AccountSW\Data\" & comId
        Dim conn3 As New OleDbConnection
        conn3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & "\" & comId & ".mdb"
        If conn3.State = ConnectionState.Closed Then
            conn3.Open()
        End If
        If Len(sUNameTb.Text) = 0 Or Len(sUPswrdTb.Text) = 0 Or Len(rePswrdTb.Text) = 0 Then
            MsgBox("Feild can't be empty")
            nameTb.Focus()
        End If
        If sUPswrdTb.Text = rePswrdTb.Text Then
            Dim sql As String = "insert into Admins values ('" & sUNameTb.Text & "','" & sUPswrdTb.Text & "')"
            cmd = New OleDbCommand(sql, conn3)
            t = cmd.ExecuteNonQuery()
            MsgBox("SuperUser Added")
            sprUsrPanel.Hide()
            cmpnyViewPanel.Hide()
            sUNameTb.Text = ""
            sUPswrdTb.Text = ""
            rePswrdTb.Text = ""
        Else
            MsgBox("Password doesn't Match")
            rePswrdTb.Text = ""
            rePswrdTb.Focus()
        End If
    End Sub

    Private Sub cmpnyView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles cmpnyView.CellDoubleClick
        comId = cmpnyView.CurrentRow.Cells(0).Value
        loginForm.Show()
    End Sub

    Private Sub quitBt_Click(sender As Object, e As EventArgs) Handles quitBt.Click
        createPanel.Hide()
    End Sub


    Private Sub openComBt_Click(sender As Object, e As EventArgs) Handles openComBt.Click
        cmpnyView.Rows.Clear()
        cmpnyViewPanel.Show()
        createPanel.Hide()
        sprUsrPanel.Hide()
        i = 0
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from company"
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        t = dt.Rows.Count
        While i < t
            cmpnyView.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1))
            i += 1
        End While
        dt.Clear()
    End Sub

End Class
