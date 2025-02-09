Imports System.Data.OleDb
Imports System.Timers

Public Class atmlogin
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpin.Text = txtpin.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpin.Text = txtpin.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpin.Text = txtpin.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtpin.Text = txtpin.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtpin.Text = txtpin.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtpin.Text = txtpin.Text & "6"
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        txtpin.Text = txtpin.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpin.Text = txtpin.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpin.Text = txtpin.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpin.Text = txtpin.Text & "0"
    End Sub




    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtpin.Clear()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub atmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class




