Imports System.Data.OleDb

Public Class ManageUserAccounts
    Private Sub ManageUserAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        loadaccount()
        txtusername.Enabled = False
    End Sub

    Private Sub loadaccount()
        sql = "Select * From tblUsers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim xox As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            xox = New ListViewItem(dr("Username").ToString)
            xox.SubItems.Add(dr("Password").ToString)
            xox.SubItems.Add(dr("Fulname").ToString)
            xox.SubItems.Add(dr("Email").ToString)
            xox.SubItems.Add(dr("Address").ToString)
            xox.SubItems.Add(dr("City").ToString)
            xox.SubItems.Add(dr("Country").ToString)
            xox.SubItems.Add(dr("Role").ToString)
            xox.SubItems.Add(dr("AcctStatus").ToString)
            ListView1.Items.Add(xox)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtusername.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MyDatabase.accdb")
                cn.Open()

                sql = "Select Password,Fulname,Email,Address,City,Country,Role,AcctStatus from tblUsers where Username= '" & txtusername.Text & "'"

                Using cmd As New OleDbCommand(sql, cn)
                    Using dr As OleDbDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtpassword.Text = dr("Password").ToString
                            fullname.Text = dr("Fulname").ToString
                            email.Text = dr("Email").ToString
                            address.Text = dr("Address").ToString
                            citytown.Text = dr("City").ToString
                            country.Text = dr("Country").ToString
                            txtrole.Text = dr("Role").ToString
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
        If txtpassword.Text.Length < 8 Then
            MsgBox("Password must be 8 characters long", vbExclamation, "Pin Error")
        Else
            Call updatedata()
            If cbostatus.Text = "Disabled" Then
                UpdateLoginAttempts(txtusername.Text, 3)
            End If
        End If
    End Sub


    Private Sub updatedata()
        sql = "Update tblUsers set Fulname=@Fulname,Email=@Email,Address=@Address,City=@City,Country=@Country,Role=@Role,AcctStatus=@AcctStatus WHERE Username=@Username"

        cmd = New OleDbCommand(sql, cn)
        With cmd

            .Parameters.AddWithValue("@Fulname", fullname.Text)
            .Parameters.AddWithValue("@Email", email.Text)
            .Parameters.AddWithValue("@Address", address.Text)
            .Parameters.AddWithValue("@City", citytown.Text)
            .Parameters.AddWithValue("@Country", country.Text)
            .Parameters.AddWithValue("@Role", txtrole.Text)
            .Parameters.AddWithValue("@AcctStatus", cbostatus.Text)
            .Parameters.AddWithValue("@Username", txtusername.Text)
            .ExecuteNonQuery()
            If cbostatus.Text = "Active" Then
                ResetLoginAttempts(txtusername.Text)
            End If
        End With

        updatepin()
        MsgBox("Client Record Successfully Updated", MsgBoxStyle.Information)
        loadaccount()
    End Sub


    Private Sub ResetLoginAttempts(usernames As String)
        sql = "Update tblUsers set LoginAttempts = 0 where Username = @username"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@username", usernames)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub updatepin()
        sql = "UPDATE tblUsers SET [Password]=@password WHERE Username=@username"

        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@password", txtpassword.Text)
            .Parameters.AddWithValue("@username", txtusername.Text)
            .ExecuteNonQuery()
        End With
    End Sub
    Private Sub UpdateLoginAttempts(username As String, attempts As Integer)
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Dim sql As String = "UPDATE tblUsers SET LoginAttempts=@attempts WHERE Username=@username"

            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@attempts", attempts)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating login attempts: " & ex.Message)
        End Try
    End Sub


End Class