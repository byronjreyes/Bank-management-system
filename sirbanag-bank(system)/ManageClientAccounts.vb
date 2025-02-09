Imports System.Data.OleDb

Public Class ManageClientAccounts
    Private Sub ManageClientAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        loadaccount()
        txtacc.Enabled = False
        btnupdate.Enabled = False


    End Sub
    Private Sub loadaccount()
        sql = "Select * From qryAccounts"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim xox As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            xox = New ListViewItem(dr("AcctNo").ToString)
            xox.SubItems.Add(dr("Lastname").ToString & " " & dr("Firstname").ToString)
            xox.SubItems.Add(dr("Address").ToString)
            xox.SubItems.Add(dr("ContactNo").ToString)
            xox.SubItems.Add(dr("Email").ToString)
            xox.SubItems.Add(dr("Age").ToString)
            xox.SubItems.Add(dr("Bdate").ToString)
            xox.SubItems.Add(dr("Sex").ToString)
            xox.SubItems.Add(dr("PIN").ToString)
            xox.SubItems.Add(dr("AcctStatus").ToString)
            ListView1.Items.Add(xox)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtacc.Text = ListView1.SelectedItems(0).SubItems(0).Text
            btnupdate.Enabled = True
        End If
    End Sub

    Private Sub txtacc_TextChanged(sender As Object, e As EventArgs) Handles txtacc.TextChanged

        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MyDatabase.accdb")
                cn.Open()

                sql = "Select Lastname,Firstname,MID,Address,ContactNo,Email,Age,Bdate,Sex,Pin,AcctStatus from qryAccounts where AcctNo= '" & txtacc.Text & "'"

                Using cmd As New OleDbCommand(sql, cn)
                    Using dr As OleDbDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtLastname.Text = dr("Lastname").ToString
                            txtfirstname.Text = dr("Firstname").ToString
                            txtmi.Text = dr("MID").ToString
                            txtaddress.Text = dr("Address").ToString
                            txtcontactno.Text = dr("ContactNo").ToString
                            txtemail.Text = dr("Email").ToString
                            txtage.Text = dr("Age").ToString
                            ddate.Value = DateTime.Parse(dr("Bdate").ToString())
                            txtsex.Text = dr("Sex").ToString
                            txtPIN.Text = dr("Pin").ToString
                            cbostatus.Text = dr("AcctStatus").ToString
                        End If
                    End Using
                End Using

            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        If txtPIN.Text.Length < 6 Then
            MsgBox("Pin must be 6 characters long", vbExclamation, "Pin Error")
        Else
            Call updatedata()
        End If


    End Sub
    Private Sub updatedata()
        sql = "Update tblAccounts set Lastname=@lastname,Firstname=@firstname,MID=@mid,Address=@address,ContactNo=@contactno,Email=@email,Age=@age,Bdate=@bdate,Sex=@sex,AcctStatus=@acctstatus where AcctNo=@acctno"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@lastname", txtLastname.Text)
            .Parameters.AddWithValue("@firstname", txtfirstname.Text)
            .Parameters.AddWithValue("@mid", txtmi.Text)
            .Parameters.AddWithValue("@address", txtaddress.Text)
            .Parameters.AddWithValue("@contactno", txtcontactno.Text)
            .Parameters.AddWithValue("@email", txtemail.Text)
            .Parameters.AddWithValue("@age", txtage.Text)
            .Parameters.AddWithValue("@bdate", ddate.Text)
            .Parameters.AddWithValue("@sex", txtsex.Text)
            .Parameters.AddWithValue("@acctstatus", cbostatus.Text)
            .Parameters.AddWithValue("@acctno", txtacc.Text)
            .ExecuteNonQuery()


            If cbostatus.Text = "Active" Then
                ResetLoginAttempts(txtacc.Text)
            End If
        End With

        updatepin()
        MsgBox("Client Record Successfully Updated", MsgBoxStyle.Information)
        loadaccount()
    End Sub

    Private Sub ResetLoginAttempts(accountNo As String)
        ' Reset login attempts to 0
        sql = "Update tblAccounts set LoginAttempts = 0 where AcctNo = @acctno"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acctno", accountNo)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub updatepin()
        sql = "Update tblPIN set PIN=@pin WHERE AcctNo=@acctno"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@pin", txtPIN.Text)
            .Parameters.AddWithValue("@acctno", txtacc.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub ddate_ValueChanged(sender As Object, e As EventArgs) Handles ddate.ValueChanged
        Dim age As Integer = DateTime.Today.Year - ddate.Value.Year
        If DateTime.Today.Month < ddate.Value.Month Then
            age -= 1
        ElseIf DateTime.Today.Month = ddate.Value.Month And DateTime.Today.Day < ddate.Value.Day Then
            age -= 1
        End If
        txtage.Text = age.ToString()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            sql = "DELETE FROM tblAccounts WHERE AcctNo = @acctno"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@acctno", txtacc.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Delete successful", vbInformation)
            loadaccount()
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        txtmi.Clear()
        txtfirstname.Clear()
        txtLastname.Clear()
        txtaddress.Clear()
        txtemail.Clear()
        txtcontactno.Clear()
        txtage.Clear()
        txtsex.SelectedIndex = 0
        cbostatus.Text = Nothing
        txtacc.Clear()
        txtPIN.Clear()
        txtacc.Enabled = False
        Dim acctnum As New Random
        txtacc.Text = acctnum.Next(0, 1000000000)
    End Sub

    Private Sub savedata()
        sql = "Insert into tblAccounts ([AcctNo], [Lastname], [Firstname], [MID], [Address], [ContactNo], [Email], [Age], [Bdate], [Sex], [AcctStatus], [LoginAttempts])values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@0", txtacc.Text)
            .Parameters.AddWithValue("@1", txtLastname.Text)
            .Parameters.AddWithValue("@2", txtfirstname.Text)
            .Parameters.AddWithValue("@3", txtmi.Text)
            .Parameters.AddWithValue("@4", txtaddress.Text)
            .Parameters.AddWithValue("@5", txtcontactno.Text)
            .Parameters.AddWithValue("@6", txtemail.Text)
            .Parameters.AddWithValue("@7", txtage.Text)
            .Parameters.AddWithValue("@8", ddate.Value.Date)
            .Parameters.AddWithValue("@9", txtsex.Text)
            .Parameters.AddWithValue("@10", cbostatus.Text)
            .Parameters.AddWithValue("@11", 0)
            .ExecuteNonQuery()
        End With
        MsgBox("Added succesfuly", vbInformation)
        txtretypepin.Clear()
        loadaccount()
    End Sub
    Private Sub SavePIN()
        If txtPIN.Text.Length < 8 Then
            MsgBox("PIN mus be 6 characters", MsgBoxStyle.Critical, "Re-type PIN")
        Else
            sql = "Insert into tblPIN (AcctNo,PIN) values (@AcctNo,@PIN)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@AcctNo", txtacc.Text)
                .Parameters.AddWithValue("@PIN", txtPIN.Text)
                .ExecuteNonQuery()
            End With
        End If
        savedata()
    End Sub

    Private Sub checkAccount()

        sql = "Select AcctNo from tblAccounts where AcctNo='" & txtacc.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        If dr.Read() = True Then
            MsgBox("Account is already Exist", MsgBoxStyle.Exclamation, "Duplicated Data")
        Else
            sql = "Select * From tblPIN Where PIN =" & txtPIN.Text & ""
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                MsgBox("Pin must be unique", vbExclamation, "Unique Pin")
            Else
                SavePIN()
            End If



        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtmi.Text) OrElse
           String.IsNullOrWhiteSpace(txtcontactno.Text) OrElse
           String.IsNullOrWhiteSpace(txtemail.Text) OrElse
           String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtage.Text) OrElse
           String.IsNullOrWhiteSpace(txtacc.Text) OrElse
           String.IsNullOrWhiteSpace(txtPIN.Text) OrElse
           String.IsNullOrWhiteSpace(txtretypepin.Text) OrElse
           txtsex.SelectedIndex = 0 Then

            MessageBox.Show("Please input all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf txtPIN.Text <> txtretypepin.Text Then
            MsgBox("PINs do not match", vbExclamation, "PIN Mismatch")
            txtPIN.Clear()
            txtretypepin.Clear()
            Return

        ElseIf txtPIN.Text.Length < 8 Then
            MessageBox.Show("PIN must be exactly 8 characters long.", "PIN Length Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPIN.Clear()
            txtretypepin.Clear()
            Return

        ElseIf txtacc.Text.Length < 8 Then
            MessageBox.Show("Account number must be at least 8 characters long.", "Account Number Length Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtacc.Clear()
            txtPIN.Clear()
            txtretypepin.Clear()
            Return

        End If


        txtacc.Enabled = False
        Call checkAccount()
    End Sub

End Class