Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateadminaccount()
        UpdateClientCount()
        hidesubmenu()
        Timer1.Start()
    End Sub

    Private Sub hidesubmenu()
        PanelMediasubmenu.Visible = False

    End Sub

    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private currentform As Form = Nothing
    Private Sub openchildform(childForm As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainform.Controls.Add(childForm)
        mainform.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub GoBackToClientDashboard()
        If currentform IsNot Nothing Then
            currentform.Hide()
        End If
        If clientloging.Visible Then
            clientloging.Hide()
        End If
        Me.Show()
    End Sub


    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        showsubmenu(PanelMediasubmenu)
    End Sub



    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MyDatabase.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            Dim selectUserInfoSql As String = "SELECT TOP 1 ID, Username FROM ActivityLogs WHERE ActivityType = 'Login' ORDER BY ActivityDate DESC;"
            Dim selectUserInfoCmd As New OleDbCommand(selectUserInfoSql, conn)
            Dim reader As OleDbDataReader = selectUserInfoCmd.ExecuteReader()

            If reader.Read() Then

                Dim userId As Object = reader("ID")
                Dim username As Object = reader("Username")

                ' Insert a record into ActivityLogs for logout
                Dim insertLogoutLogSql As String = "INSERT INTO ActivityLogs (ID, Username, ActivityType, ActivityDate) VALUES (@id, @username, 'Logout', Now());"
                Dim insertLogoutLogCmd As New OleDbCommand(insertLogoutLogSql, conn)
                insertLogoutLogCmd.Parameters.AddWithValue("@id", userId)
                insertLogoutLogCmd.Parameters.AddWithValue("@username", username)
                insertLogoutLogCmd.ExecuteNonQuery()

                MessageBox.Show("Logout successful!")
                Me.Hide()
            Else
                MessageBox.Show("No active login session found.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        Me.Close()
        Loginform.Show()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datenow.Text = Now.ToString
    End Sub

    Private Sub UpdateClientCount()
        Try
            sql = "SELECT COUNT(*) FROM tblAccounts"
            cmd = New OleDbCommand(sql, cn)
            Dim totalclientaccounts As Integer = CInt(cmd.ExecuteScalar())

            LabelaccCount.Text = totalclientaccounts.ToString()
        Catch ex As Exception
            MsgBox("Error updating Account count: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub updateadminaccount()
        Try
            sql = "SELECT COUNT(*) FROM tblUsers"
            cmd = New OleDbCommand(sql, cn)
            Dim totaladminusersaccounts As Integer = CInt(cmd.ExecuteScalar())

            LabeladminCount.Text = totaladminusersaccounts.ToString()
        Catch ex As Exception
            MsgBox("Error updating Users count: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub mainform_Paint(sender As Object, e As PaintEventArgs) Handles mainform.Paint

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        GoBackToClientDashboard()
    End Sub

    Private Sub btnclient_Click_1(sender As Object, e As EventArgs) Handles btnclient.Click
        openchildform(New ManageClientAccounts())
        hidesubmenu()
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        openchildform(New ManageUserAccounts())
        hidesubmenu()
    End Sub
End Class