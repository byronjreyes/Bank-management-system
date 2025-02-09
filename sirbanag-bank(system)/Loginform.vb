Imports System.Data.OleDb

Public Class Loginform


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MyDatabase.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            Dim selectSql As String = "SELECT ID, Username, Password, LoginAttempts, AcctStatus FROM tblUsers WHERE Username = @username;"
            Dim selectCmd As New OleDbCommand(selectSql, conn)
            selectCmd.Parameters.AddWithValue("@username", username)

            Dim reader As OleDbDataReader = selectCmd.ExecuteReader()

            If reader.Read() Then
                Dim userid = reader("ID")
                Dim dbUsername As String = reader("Username")
                Dim dbPassword As String = reader("Password")
                Dim loginAttempts As Integer = reader("LoginAttempts")
                Dim accstatus As Object = reader("AcctStatus")

                If accstatus IsNot DBNull.Value AndAlso CStr(accstatus) = "Disabled" Then
                    MessageBox.Show("Account is locked. Please contact the admin to unlock your account.")
                ElseIf password = dbPassword Then
                    vbmsgbox.setAlert("Login Success", vbmsgbox.AlertType.Success)
                    txtusername.Select()
                    txtpassword.Clear()
                    AdminDashboard.tkrole.Text = lblrole.Text
                    AdminDashboard.tkusername.Text = txtusername.Text

                    AdminDashboard.Show()
                    Me.Hide()

                    'Add the login activity log
                    Dim insertLoginLogSql As String = "INSERT INTO ActivityLogs (ID, Username, ActivityType, ActivityDate) VALUES (@id, @username, 'Login', Now());"
                    Dim insertLoginLogCmd As New OleDbCommand(insertLoginLogSql, conn)
                    insertLoginLogCmd.Parameters.AddWithValue("@id", userid)
                    insertLoginLogCmd.Parameters.AddWithValue("@id", dbUsername)
                    insertLoginLogCmd.ExecuteNonQuery()

                    'Reset the login attempts counter
                    Dim updateSql As String = "UPDATE tblUsers SET LoginAttempts = 0 WHERE ID = @id;"
                    Dim updateCmd As New OleDbCommand(updateSql, conn)
                    updateCmd.Parameters.AddWithValue("@id", userid)
                    updateCmd.ExecuteNonQuery()
                Else
                    'Increment the login attempts counter
                    loginAttempts += 1
                    MessageBox.Show("Incorrect password. You have " & (3 - loginAttempts) & " attempts left.")
                    txtusername.Select()
                    Dim insertLoginLogSql As String = "INSERT INTO ActivityLogs (ID, Username, ActivityType, ActivityDate) VALUES (@id, @username, 'Attempting password', Now());"
                    Dim insertLoginLogCmd As New OleDbCommand(insertLoginLogSql, conn)
                    insertLoginLogCmd.Parameters.AddWithValue("@id", userid)
                    insertLoginLogCmd.Parameters.AddWithValue("@id", dbUsername)
                    insertLoginLogCmd.ExecuteNonQuery()
                    txtpassword.Clear()

                    'Update the login attempts counter
                    Dim updateSql As String = "UPDATE tblUsers SET LoginAttempts = @loginAttempts WHERE ID = @id;"
                    Dim updateCmd As New OleDbCommand(updateSql, conn)
                    updateCmd.Parameters.AddWithValue("@loginAttempts", loginAttempts)
                    updateCmd.Parameters.AddWithValue("@id", userid)
                    updateCmd.ExecuteNonQuery()

                    'Lock the account if the login attempts exceed 3
                    If loginAttempts >= 3 Then
                        MessageBox.Show("Account is locked. Please contact the admin to unlock your account.")
                        txtusername.Select()
                        txtpassword.Clear()
                        Dim lockSql As String = "UPDATE tblUsers SET AcctStatus = 'Disabled' WHERE ID = @id;"
                        Dim lockCmd As New OleDbCommand(lockSql, conn)
                        lockCmd.Parameters.AddWithValue("@id", userid)
                        lockCmd.ExecuteNonQuery()
                    End If
                End If
            Else
                vbmsgbox.setAlert("Account not found", vbmsgbox.AlertType.Error)
                txtusername.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub




    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub txtusername_GotFocus(sender As Object, e As EventArgs) Handles txtusername.GotFocus
        If txtusername.Text = "Username" Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtusername_LostFocus(sender As Object, e As EventArgs) Handles txtusername.LostFocus
        If String.IsNullOrWhiteSpace(txtusername.Text) Then
            txtusername.Text = "Username"
            txtusername.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtpassword_GotFocus(sender As Object, e As EventArgs) Handles txtpassword.GotFocus
        If txtpassword.Text = "Password" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        If String.IsNullOrWhiteSpace(txtpassword.Text) Then
            txtpassword.Text = "Password"
            txtpassword.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub signupnow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signupnow.LinkClicked
        Me.Hide()
        FrmCreateAccount.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        MsgBox("Thank u next")
        Me.Close()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        connection()
        sql = "Select [Role] from tblUsers where Username='" & txtusername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            lblrole.Text = dr(0).ToString
        End If

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
    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click
        openchildform(New clientloging())
    End Sub

    Private Sub lblrole_Click(sender As Object, e As EventArgs) Handles lblrole.Click

    End Sub
End Class