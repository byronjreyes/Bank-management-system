Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCreateAccount

    Private Sub FrmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connection()

        txtusername.Text = "Username"
        txtusername.ForeColor = Color.FromArgb(128, Color.Gray)

        txtpassword.Text = "Password"
        txtpassword.ForeColor = Color.FromArgb(128, Color.Gray)

        txtConfirmedpassword.Text = "Re-type Your Password"
        txtConfirmedpassword.ForeColor = Color.FromArgb(128, Color.Gray)


        email.Text = "Email"
        email.ForeColor = Color.FromArgb(128, Color.Gray)

        address.Text = "Address"
        address.ForeColor = Color.FromArgb(128, Color.Gray)

        citytown.Text = "City/Town"
        citytown.ForeColor = Color.FromArgb(128, Color.Gray)

        fullname.Text = "Full Name"
        fullname.ForeColor = Color.FromArgb(128, Color.Gray)

        txtrole.Items.Insert(0, "Select Role")
        country.Items.Insert(0, "Select Country")
        txtrole.SelectedIndex = 0
        country.SelectedIndex = 0

    End Sub


    Private Sub clear()
        txtusername.Clear()
        txtConfirmedpassword.Clear()
        txtpassword.Clear()
        txtrole.Text = Nothing
        email.Clear()
        fullname.Clear()
        address.Clear()
        citytown.Clear()
        country.Text = Nothing

    End Sub




    Private Sub checkifExist()
        sql = "Select username from tblUsers where Username= @Username"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", txtusername.Text)

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                MsgBox("Username is already exist", MsgBoxStyle.Exclamation, "Duplicate data")
                clear()
            Else
                Call SaveData()
            End If
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub SaveData()
        sql = "Insert into tblUsers ([Username],[Password],[Role],[Fulname],[Email],[Address],[City],[Country]) VALUES (@Username, @Password, @Role, @Fulname, @Email, @Address, @City, @Country)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Username", txtusername.Text)
            .Parameters.AddWithValue("@Password", txtpassword.Text)
            .Parameters.AddWithValue("@Role", txtrole.Text)
            .Parameters.AddWithValue("@Fulname", fullname.Text)
            .Parameters.AddWithValue("@Email", email.Text)
            .Parameters.AddWithValue("@Address", address.Text)
            .Parameters.AddWithValue("@City", citytown.Text)
            .Parameters.AddWithValue("@Country", country.Text)
        End With

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cmd.ExecuteNonQuery()

            MsgBox("New user successfully added to the Database", MsgBoxStyle.Information, "Create Account")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click

        If String.IsNullOrWhiteSpace(txtusername.Text) OrElse
       String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
       String.IsNullOrWhiteSpace(txtConfirmedpassword.Text) OrElse
       String.IsNullOrWhiteSpace(fullname.Text) OrElse
       String.IsNullOrWhiteSpace(email.Text) OrElse
       String.IsNullOrWhiteSpace(address.Text) OrElse
       String.IsNullOrWhiteSpace(citytown.Text) OrElse
       String.IsNullOrWhiteSpace(country.Text) OrElse
       txtrole.SelectedIndex = 0 Then

            MessageBox.Show("Please input all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtpassword.Text <> txtConfirmedpassword.Text Then
            MessageBox.Show("Password and confirmed password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Select()
            txtConfirmedpassword.Clear()
            Return
        End If

        If txtpassword.Text.Length < 8 Then
            MessageBox.Show("Password must be exactly 8 characters long.", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clear()
            txtpassword.Select()

            Return
        End If


        checkifExist()
    End Sub



    Private Sub clearbtn_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        MsgBox("Thank you comeback again", MsgBoxStyle.Information, "Good Bye")
        Me.Hide()
        Loginform.Show()
    End Sub

    Private Sub txtusername_GotFocus(sender As Object, e As EventArgs) Handles txtusername.GotFocus
        If txtusername.Text = "Username" Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
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
            txtpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        If String.IsNullOrWhiteSpace(txtpassword.Text) Then
            txtpassword.Text = "Password"
            txtpassword.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtConfirmedpassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmedpassword.GotFocus
        If txtConfirmedpassword.Text = "Re-type Your Password" Then
            txtConfirmedpassword.Text = ""
            txtConfirmedpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtConfirmedpassword_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmedpassword.LostFocus
        If String.IsNullOrWhiteSpace(txtConfirmedpassword.Text) Then
            txtConfirmedpassword.Text = "Re-type Your Password"
            txtConfirmedpassword.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub txtrole_GotFocus(sender As Object, e As EventArgs) Handles txtrole.GotFocus
        If txtrole.Text = "Select Role" Then
            txtrole.Text = ""
            txtrole.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtrole_LostFocus(sender As Object, e As EventArgs) Handles txtrole.LostFocus
        If String.IsNullOrWhiteSpace(txtrole.Text) Then
            txtrole.Text = "Select Role"
            txtrole.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub email_GotFocus(sender As Object, e As EventArgs) Handles email.GotFocus
        If email.Text = "Email" Then
            email.Text = ""
            email.ForeColor = Color.Black
        End If
    End Sub

    Private Sub email_LostFocus(sender As Object, e As EventArgs) Handles email.LostFocus
        If String.IsNullOrWhiteSpace(email.Text) Then
            email.Text = "Email"
            email.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub address_GotFocus(sender As Object, e As EventArgs) Handles address.GotFocus
        If address.Text = "Address" Then
            address.Text = ""
            address.ForeColor = Color.Black
        End If
    End Sub

    Private Sub address_LostFocus(sender As Object, e As EventArgs) Handles address.LostFocus
        If String.IsNullOrWhiteSpace(address.Text) Then
            address.Text = "Address"
            address.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub citytown_GotFocus(sender As Object, e As EventArgs) Handles citytown.GotFocus
        If citytown.Text = "City/Town" Then
            citytown.Text = ""
            citytown.ForeColor = Color.Black
        End If
    End Sub

    Private Sub citytown_LostFocus(sender As Object, e As EventArgs) Handles citytown.LostFocus
        If String.IsNullOrWhiteSpace(citytown.Text) Then
            citytown.Text = "City/Town"
            citytown.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub country_GotFocus(sender As Object, e As EventArgs) Handles country.GotFocus
        If country.Text = "Select Country" Then
            country.Text = ""
            country.ForeColor = Color.Black
        End If
    End Sub

    Private Sub country_LostFocus(sender As Object, e As EventArgs) Handles country.LostFocus
        If String.IsNullOrWhiteSpace(country.Text) Then
            country.Text = "Select Country"
            country.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub fullname_GotFocus(sender As Object, e As EventArgs) Handles fullname.GotFocus
        If fullname.Text = "Full Name" Then
            fullname.Text = ""
            fullname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub fullname_LostFocus(sender As Object, e As EventArgs) Handles fullname.LostFocus
        If String.IsNullOrWhiteSpace(fullname.Text) Then
            fullname.Text = "Full Name"
            fullname.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub GunaElipsePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaElipsePanel1.Paint

    End Sub
End Class