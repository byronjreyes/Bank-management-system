Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Net


Public Class ClientCreatAccount
    Private Sub ClientCreatAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        Dim acctnum As New Random
        txtacc.Text = acctnum.Next(0, 1000000000)
        txtfirstname.Text = "First Name"
        txtfirstname.ForeColor = Color.FromArgb(128, Color.Gray)

        txtLastname.Text = "Last Name"
        txtLastname.ForeColor = Color.FromArgb(128, Color.Gray)

        txtmi.Text = "Middle Initial"
        txtmi.ForeColor = Color.FromArgb(128, Color.Gray)


        txtemail.Text = "Email"
        txtemail.ForeColor = Color.FromArgb(128, Color.Gray)

        txtaddress.Text = "Address"
        txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)


        txtcontactno.Text = "Contact Number"
        txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)



        txtsex.Text = "Select your Gender"
        txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)


        txtage.Text = "Age"
        txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)


        txtsex.Items.Insert(0, "--Select your Gender--")
        txtsex.SelectedIndex = 0
        txtsex.ForeColor = Color.FromArgb(128, Color.DimGray)


        txtPIN.Text = "Enter your Pin"
        txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)

        txtRePin.Text = "Re-type your Pin"
        txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)

        txtage.Enabled = False
        txtacc.Enabled = False
    End Sub

    Private Sub clearall()
        txtacc.Clear()
        txtLastname.Clear()
        txtfirstname.Clear()
        txtmi.Clear()
        txtaddress.Clear()
        txtcontactno.Clear()
        txtemail.Clear()
        txtage.Clear()
        ddate.Text = Nothing
        txtsex.Text = Nothing
        txtage.Clear()
        txtPIN.Clear()
        txtRePin.Clear()
    End Sub
    Private Sub SaveData()
        Dim contactNo As Double
        If Double.TryParse(txtcontactno.Text, contactNo) Then
            sql = "INSERT INTO tblAccounts ([AcctNo], [Lastname], [Firstname], [MID], [Address], [ContactNo], [Email], [Age], [Bdate], [Sex], [AcctStatus], [LoginAttempts]) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@0", txtacc.Text)
                .Parameters.AddWithValue("@1", txtLastname.Text)
                .Parameters.AddWithValue("@2", txtfirstname.Text)
                .Parameters.AddWithValue("@3", txtmi.Text)
                .Parameters.AddWithValue("@4", txtaddress.Text)
                .Parameters.AddWithValue("@5", contactNo)
                .Parameters.AddWithValue("@6", txtemail.Text)
                .Parameters.AddWithValue("@7", txtage.Text)
                .Parameters.AddWithValue("@8", ddate.Value.Date)
                .Parameters.AddWithValue("@9", txtsex.Text)
                .Parameters.AddWithValue("@10", "Active")
                .Parameters.AddWithValue("@11", 0)
                .ExecuteNonQuery()
            End With

            MsgBox("New user successfully added to the Database", MsgBoxStyle.Information, "Create Account")
            clearall()
        Else
            MsgBox("Invalid Contact Number. Please enter a valid numeric value.", MsgBoxStyle.Exclamation, "Validation Error")
        End If
    End Sub



    Private Sub SavePIN()
        If txtPIN.Text <> txtRePin.Text Then
            MsgBox("PIN IS MISMACTH", MsgBoxStyle.Critical, "Re-type PIN")
        Else
            sql = "Insert into tblPIN (AcctNo,PIN) values (@AcctNo,@PIN)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@AcctNo", txtacc.Text)
                .Parameters.AddWithValue("@PIN", txtPIN.Text)
                .ExecuteNonQuery()
            End With
        End If
        SaveData()
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
       String.IsNullOrWhiteSpace(txtRePin.Text) OrElse
       txtsex.SelectedIndex = 0 Then

            MessageBox.Show("Please input all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf txtPIN.Text.Length < 8 Then
            MessageBox.Show("PIN must be exactly 8 characters long.", "PIN Length Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtacc.Select()
            txtPIN.Clear()
            txtRePin.Clear()
            Return
        ElseIf txtacc.Text.Length < 8 Then
            MessageBox.Show("Account number must be at least 8 characters long.", "Account Number Length Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtacc.Clear()
            txtPIN.Clear()
            txtRePin.Clear()
            Return
        ElseIf txtPIN.Text <> txtRePin.Text Then
            MessageBox.Show("PIN does not match.", "PIN Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtacc.Select()
            txtPIN.Clear()
            txtRePin.Clear()
            Return
        End If




        Call checkAccount()
    End Sub

    Private Sub txtfirstname_GotFocus(sender As Object, e As EventArgs) Handles txtfirstname.GotFocus
        If txtfirstname.Text = "First Name" Then
            txtfirstname.Text = ""
            txtfirstname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtfirstname_LostFocus(sender As Object, e As EventArgs) Handles txtfirstname.LostFocus
        If String.IsNullOrWhiteSpace(txtfirstname.Text) Then
            txtfirstname.Text = "First Name"
            txtfirstname.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtlastname_GotFocus(sender As Object, e As EventArgs) Handles txtLastname.GotFocus
        If txtLastname.Text = "Last Name" Then
            txtLastname.Text = ""
            txtLastname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtlastname_LostFocus(sender As Object, e As EventArgs) Handles txtLastname.LostFocus
        If String.IsNullOrWhiteSpace(txtLastname.Text) Then
            txtLastname.Text = "Last Name"
            txtLastname.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtmi_GotFocus(sender As Object, e As EventArgs) Handles txtmi.GotFocus
        If txtmi.Text = "Middle Initial" Then
            txtmi.Text = ""
            txtmi.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtmi_LostFocus(sender As Object, e As EventArgs) Handles txtmi.LostFocus
        If String.IsNullOrWhiteSpace(txtmi.Text) Then
            txtmi.Text = "Middle Initial"
            txtmi.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtaddress_GotFocus(sender As Object, e As EventArgs) Handles txtaddress.GotFocus
        If txtaddress.Text = "Address" Then
            txtaddress.Text = ""
            txtaddress.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtaddress_LostFocus(sender As Object, e As EventArgs) Handles txtaddress.LostFocus
        If String.IsNullOrWhiteSpace(txtaddress.Text) Then
            txtaddress.Text = "Address"
            txtaddress.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtcontactno_GotFocus(sender As Object, e As EventArgs) Handles txtcontactno.GotFocus
        If txtcontactno.Text = "Contact Number" Then
            txtcontactno.Text = ""
            txtcontactno.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtcontactno_LostFocus(sender As Object, e As EventArgs) Handles txtcontactno.LostFocus
        If String.IsNullOrWhiteSpace(txtcontactno.Text) Then
            txtcontactno.Text = "Contact Number"
            txtcontactno.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub
    Private Sub txtemail_GotFocus(sender As Object, e As EventArgs) Handles txtemail.GotFocus
        If txtemail.Text = "Email" Then
            txtemail.Text = ""
            txtemail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtemail_LostFocus(sender As Object, e As EventArgs) Handles txtemail.LostFocus
        If String.IsNullOrWhiteSpace(txtemail.Text) Then
            txtemail.Text = "Email"
            txtemail.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtsex_GotFocus(sender As Object, e As EventArgs) Handles txtsex.GotFocus
        If txtsex.Text = "--Select your Gender--" Then
            txtsex.Text = ""
            txtsex.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtsex_LostFocus(sender As Object, e As EventArgs) Handles txtsex.LostFocus
        If String.IsNullOrWhiteSpace(txtsex.Text) Then
            txtsex.Text = "--Select your Gender--"
            txtsex.ForeColor = Color.FromArgb(128, Color.Gray)
        End If

    End Sub
    Private Sub txtage_GotFocus(sender As Object, e As EventArgs) Handles txtage.GotFocus
        If txtage.Text = "Age" Then
            txtage.Text = ""
            txtage.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtage_LostFocus(sender As Object, e As EventArgs) Handles txtage.LostFocus
        If String.IsNullOrWhiteSpace(txtage.Text) Then
            txtage.Text = "Age"
            txtage.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub


    Private Sub txtPIN_GotFocus(sender As Object, e As EventArgs) Handles txtPIN.GotFocus
        If txtPIN.Text = "Enter your Pin" Then
            txtPIN.Text = ""
            txtPIN.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPIN_LostFocus(sender As Object, e As EventArgs) Handles txtPIN.LostFocus
        If String.IsNullOrWhiteSpace(txtPIN.Text) Then
            txtPIN.Text = "Enter your Pin"
            txtPIN.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtRePin_GotFocus(sender As Object, e As EventArgs) Handles txtRePin.GotFocus
        If txtRePin.Text = "Re-type your Pin" Then
            txtRePin.Text = ""
            txtRePin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRePin_LostFocus(sender As Object, e As EventArgs) Handles txtRePin.LostFocus
        If String.IsNullOrWhiteSpace(txtRePin.Text) Then
            txtRePin.Text = "Re-type your Pin"
            txtRePin.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
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

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        clientloging.Show()
        Me.Hide()
    End Sub


End Class