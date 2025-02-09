Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail

Public Class Accountchange


    Private Sub clear()
        txtcurrent.Clear()
        txtnewpin.Clear()
        txtrepin.Clear()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrWhiteSpace(txtcurrent.Text) OrElse
       String.IsNullOrWhiteSpace(txtnewpin.Text) OrElse
       String.IsNullOrWhiteSpace(txtrepin.Text) Then
            MsgBox("Please input all fields.", vbExclamation, "Incomplete Information")
            Return
        End If


        If Not CheckCurrentPIN() Then
            MsgBox("Current PIN is incorrect. Please enter the correct PIN.", vbExclamation, "Incorrect PIN")
            Return
        End If

        If txtnewpin.Text <> txtrepin.Text Then
            MsgBox("New PIN and re-entered PIN do not match.", vbExclamation, "PIN Mismatch")
            Return
        ElseIf txtnewpin.Text.Length < 6 Then
            MsgBox("New PIN must be 6 characters long.", vbExclamation, "PIN Length Error")
            Return
        End If

        UpdatePIN()
        clear()
    End Sub

    Private Function CheckCurrentPIN() As Boolean

        sql = "SELECT COUNT(*) FROM tblPIN WHERE AcctNo=@acctno AND PIN=@pin"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@acctno", txtacc.Text)
            .Parameters.AddWithValue("@pin", txtcurrent.Text)
        End With

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub UpdatePIN()

        sql = "UPDATE tblPIN SET PIN=@pin WHERE AcctNo=@acctno"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@pin", txtnewpin.Text)
            .Parameters.AddWithValue("@acctno", txtacc.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("PIN has been updated successfully.", vbInformation, "Updated Successfully")

    End Sub


    Private _accountNumber As String
    Public Property AccountNumber() As String
        Get
            Return _accountNumber
        End Get
        Set(ByVal value As String)
            _accountNumber = value
        End Set
    End Property

    Private Sub Accountchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtacc.Enabled = False
        txtacc.Text = _accountNumber

        Me.Controls.Add(txtacc)
    End Sub


End Class