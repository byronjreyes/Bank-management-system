Imports System.Data.OleDb

Public Class clientloging

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        connection()
        Dim username As String = txtacct.Text
        Dim password As String = txtpin.Text

        Try
            If Not cn.State = ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT AccountID, AcctNo, PIN, LoginAttempts, AcctStatus FROM qryAccounts WHERE AcctNo = @acctno;"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@acctno", username)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim userid = dr("AccountID")
                Dim dbUsername As String = dr("AcctNo")
                Dim dbPassword As String = dr("PIN")
                Dim loginAttempts As Integer = dr("LoginAttempts")
                Dim acctStatus As String = dr("AcctStatus")

                If acctStatus = "Disabled" Then
                    MessageBox.Show("Account Number is disabled. Please contact the admin to enable your account.")
                ElseIf password = dbPassword Then
                    vbmsgbox.setAlert("Login Success", vbmsgbox.AlertType.Success)

                    ClientDashboard.lblnumber.Text = txtacct.Text
                    ClientDashboard.lblname.Text = lblaccount.Text
                    ClientDashboard.Show()
                    Me.Hide()
                    'Add the login activity log
                    sql = "INSERT INTO ActivityLogs (ID, Username, ActivityType, ActivityDate) VALUES (@id, @username, 'Login', Now());"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", userid)
                    cmd.Parameters.AddWithValue("@username", dbUsername)
                    cmd.ExecuteNonQuery()

                    txtacct.Select()
                    txtpin.Clear()

                    Dim updateSql As String = "UPDATE tblAccounts SET LoginAttempts = 0 WHERE AccountID = @accountid;"
                    cmd = New OleDbCommand(updateSql, cn)
                    cmd.Parameters.AddWithValue("@accountid", userid)
                    cmd.ExecuteNonQuery()
                Else

                    loginAttempts += 1
                    MessageBox.Show("Incorrect password. You have " & (3 - loginAttempts) & " attempts left.")
                    txtacct.Select()
                    txtpin.Clear()

                    sql = "INSERT INTO ActivityLogs (ID, Username, ActivityType, ActivityDate) VALUES (@id, @username, 'Attempting password', Now());"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", userid)
                    cmd.Parameters.AddWithValue("@username", dbUsername)
                    cmd.ExecuteNonQuery()

                    Dim updateSql As String = "UPDATE tblAccounts SET LoginAttempts = @loginAttempts WHERE AccountID = @accountid;"
                    cmd = New OleDbCommand(updateSql, cn)
                    cmd.Parameters.AddWithValue("@loginAttempts", loginAttempts)
                    cmd.Parameters.AddWithValue("@accountid", userid)
                    cmd.ExecuteNonQuery()

                    If loginAttempts >= 3 Then
                        MessageBox.Show("Account is locked. Please contact the admin to unlock your account.")
                        txtacct.Select()
                        txtpin.Clear()
                        Dim lockSql As String = "UPDATE tblAccounts SET AcctStatus = 'Disabled' WHERE AccountID = @accountid;"
                        cmd = New OleDbCommand(lockSql, cn)
                        cmd.Parameters.AddWithValue("@accountid", userid)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Else
                vbmsgbox.setAlert("Account not found", vbmsgbox.AlertType.Error)
                txtacct.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
        End Try
    End Sub







    'load to
    Private Sub clientloging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         txtacct.Text = "Enter your Account Number"
        txtacct.ForeColor = Color.FromArgb(128, Color.Gray)

        txtpin.Text = "Enter your Pin"
        txtpin.ForeColor = Color.FromArgb(128, Color.Gray)

    End Sub

    Private Sub txtacct_GotFocus(sender As Object, e As EventArgs) Handles txtacct.GotFocus
        If txtacct.Text = "Enter your Account Number" Then
            txtacct.Text = ""
            txtacct.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtacct_LostFocus(sender As Object, e As EventArgs) Handles txtacct.LostFocus
        If String.IsNullOrWhiteSpace(txtacct.Text) Then
            txtacct.Text = "Enter your Account Number"
            txtacct.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtpin_GotFocus(sender As Object, e As EventArgs) Handles txtpin.GotFocus
        If txtpin.Text = "Enter your Pin" Then
            txtpin.Text = ""
            txtpin.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtpin_LostFocus(sender As Object, e As EventArgs) Handles txtpin.LostFocus
        If String.IsNullOrWhiteSpace(txtpin.Text) Then
            txtpin.Text = "Enter your Pin"
            txtpin.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        MsgBox("thank u")
        Me.Hide()
    End Sub

    Private Sub txtacct_TextChanged(sender As Object, e As EventArgs) Handles txtacct.TextChanged
        connection()
        sql = "Select Firstname,Mid,Lastname from qryAccounts where AcctNo='" & txtacct.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblaccount.Text = dr(0).ToString & " " & dr(1).ToString & " " & dr(2).ToString
        End If
    End Sub

    Private Sub signupnow_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signupnow.LinkClicked
        ClientCreatAccount.Show()
        Me.Hide()
    End Sub

    Private currentform As Form = Nothing
    Private Sub openchildform(childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        mainform.Controls.Add(childform)
        mainform.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub hidesubmenu()
        Panelsidemenu.Visible = False

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

        openchildform(New Loginform())

    End Sub









End Class