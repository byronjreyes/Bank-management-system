Imports System.Data.OleDb

Public Class ClientDashboard

    Private WithEvents reloadTimer As New Timer()
    Private Sub ClientDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        hidesubmenu()
        Timer1.Start()
        reloadTimer.Start()

        UpdateBalanceAndLoadHistory()

        reloadTimer.Interval = 1000
        reloadTimer.Start()
    End Sub

    Private Sub ReloadTimer_Tick(sender As Object, e As EventArgs) Handles reloadTimer.Tick
        UpdateBalanceAndLoadHistory()

    End Sub

    Public Sub UpdateBalanceAndLoadHistory()
        Try
            ' Update balance
            Dim balanceSql As String = "SELECT SUM(Amount) FROM tbltrans WHERE AcctNo=@acctno"
            cmd = New OleDbCommand(balanceSql, cn)
            cmd.Parameters.AddWithValue("@acctno", lblnumber.Text)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                lblcurrentbal.Text = result.ToString()
            End If

            ' Load transaction history
            Dim historySql As String = "SELECT AcctNo, Transtype, Amount, TransactionDate FROM LatestTransactions WHERE AcctNo=@acctno ORDER BY TransactionDate DESC"
            cmd = New OleDbCommand(historySql, cn)
            cmd.Parameters.AddWithValue("@acctno", lblnumber.Text)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MsgBox("Error updating balance or loading transaction history: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub hidesubmenu()
        PanelMediasubmenu2.Visible = False

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




    Private Sub btnclient_Click(sender As Object, e As EventArgs)
        openchildform(New ManageClientAccounts())
        hidesubmenu()
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
            Else
                MessageBox.Show("No active login session found.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        Me.Close()
        clientloging.Show()
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs)
        openchildform(New ManageUserAccounts())
    End Sub




    Private Sub btnMe_Click(sender As Object, e As EventArgs) Handles btnMe.Click
        showsubmenu(PanelMediasubmenu2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Depositform.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WithdrawForm.ShowDialog()
    End Sub

    Private Sub btnMes_Click(sender As Object, e As EventArgs) Handles btnMes.Click
        GoBackToClientDashboard()
    End Sub

    Private Sub btnacc_Click(sender As Object, e As EventArgs) Handles btnacc.Click

        Dim accountChangeForm As New Accountchange
        accountChangeForm.AccountNumber = lblnumber.Text

        openchildform(accountChangeForm)
    End Sub

    Private Sub mainform_Paint(sender As Object, e As PaintEventArgs) Handles mainform.Paint

    End Sub
End Class