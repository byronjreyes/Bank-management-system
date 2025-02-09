Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Depositform

    Private Sub logsavedeposit()
        Try

            Dim sql As String = "INSERT INTO tbltrans([AcctNo],[TransNo],[Transtype],[Amount],[DateTime]) VALUES(@acctno, @transno, @transtype, @amount, @datetime)"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@acctno", ClientDashboard.lblnumber.Text)
                cmd.Parameters.AddWithValue("@transno", "1")
                cmd.Parameters.AddWithValue("@transtype", "Deposit")
                cmd.Parameters.AddWithValue("@amount", Val(txtamount.Text))
                cmd.Parameters.AddWithValue("@datetime", Now.ToString())
                cmd.ExecuteNonQuery()
            End Using


            sql = "INSERT INTO LatestTransactions([AcctNo],[Transtype],[Amount],[TransactionDate]) VALUES(@acctno,@transtype, @amount, @transactionDate)"
            Using cmdLatest As New OleDbCommand(sql, cn)
                cmdLatest.Parameters.AddWithValue("@acctno", ClientDashboard.lblnumber.Text)
                cmdLatest.Parameters.AddWithValue("@transtype", "Deposit")
                cmdLatest.Parameters.AddWithValue("@amount", Val(txtamount.Text))
                cmdLatest.Parameters.AddWithValue("@transactionDate", Now) ' Add the TransactionDate parameter
                cmdLatest.ExecuteNonQuery()
            End Using

            UpdateBalance()
            ClientDashboard.UpdateBalanceAndLoadHistory()
            PrintReceipt()

            vbmsgbox.setAlert("Transaction Success", vbmsgbox.AlertType.Success)
        Catch ex As Exception
            MsgBox("Error saving deposit: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub PrintReceipt()
        Try

            AddHandler PrintDocument1.PrintPage, AddressOf PrintReceiptPage
            Dim paperWidth As Integer = 2
            Dim paperHeight As Integer = 3
            PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("CustomSize", paperWidth, paperHeight)
            Dim printDialog As New PrintDialog()
            printDialog.Document = PrintDocument1

            If printDialog.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
            RemoveHandler PrintDocument1.PrintPage, AddressOf PrintReceiptPage
        Catch ex As Exception
            MsgBox("Error printing receipt: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub PrintReceiptPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim content As String = $"Transaction Receipt
---------------------------
Account Number: {ClientDashboard.lblnumber.Text}
Account Name:  {ClientDashboard.lblname.Text}
Transaction Type: Deposit
Amount: ₱{Val(txtamount.Text):N2}
Current Balance: ₱{ClientDashboard.lblcurrentbal.Text}
Date and Time: {Now.ToString("yyyy-MM-dd HH:mm:ss")}
---------------------------
Thank you for your transaction!"

        Using font As New Font("Arial", 14)
            Dim rect As New RectangleF(2, 2, e.PageBounds.Width - 5, e.PageBounds.Height - 5)
            e.Graphics.DrawString(content, font, Brushes.Black, rect)
        End Using
    End Sub





    Public Sub UpdateBalance()
        Try
            sql = "SELECT SUM(Amount) FROM tbltrans WHERE AcctNo=@acctno AND Transtype='1'"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@acctno", ClientDashboard.lblnumber.Text)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then

                ClientDashboard.lblcurrentbal.Text = result.ToString()
            End If


        Catch ex As Exception
            MsgBox("Error updating balance: " & ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub Depositform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Val(txtamount.Text) < 100 Then

            MsgBox("The minimum deposit is 100", vbCritical)
        Else
            logsavedeposit()

        End If
    End Sub










    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtamount.Clear()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtamount.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtamount.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtamount.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtamount.Text = txtamount.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtamount.Text = txtamount.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtamount.Text = txtamount.Text & "6"
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        txtamount.Text = txtamount.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtamount.Text = txtamount.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtamount.Text = txtamount.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtamount.Text = txtamount.Text & "0"
    End Sub
End Class