Imports System.Data.OleDb

Module balanceupp

    Public Sub UpdateBalance(acctNo As String, lblcurrentbal As Label, cn As OleDbConnection)
        Try
            Dim depositSql As String = "SELECT SUM(Amount) FROM tbltrans WHERE AcctNo=@acctno AND Transtype='Deposit'"
            Dim depositCmd As New OleDbCommand(depositSql, cn)
            depositCmd.Parameters.AddWithValue("@acctno", acctNo)

            Dim depositResult As Object = depositCmd.ExecuteScalar()

            Dim withdrawSql As String = "SELECT SUM(Amount) FROM tbltrans WHERE AcctNo=@acctno AND Transtype='Withdraw'"
            Dim withdrawCmd As New OleDbCommand(withdrawSql, cn)
            withdrawCmd.Parameters.AddWithValue("@acctno", acctNo)

            Dim withdrawResult As Object = withdrawCmd.ExecuteScalar()

            If depositResult IsNot Nothing AndAlso Not DBNull.Value.Equals(depositResult) AndAlso
               withdrawResult IsNot Nothing AndAlso Not DBNull.Value.Equals(withdrawResult) Then

                Dim currentBalance As Decimal = Convert.ToDecimal(depositResult) - Convert.ToDecimal(withdrawResult)
                lblcurrentbal.Text = currentBalance.ToString()
            End If
        Catch ex As Exception
            MsgBox("Error updating balance: " & ex.Message, vbCritical)
        End Try
    End Sub

End Module
