Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        clear()
    End Sub

    Private Sub clear()
        txtStudentNumber.Clear()
        txtStudentName.Clear()
    End Sub


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        MsgBox("Student Number: " & txtStudentNumber.Text & vbNewLine & "Student Name: " & txtStudentName.Text, vbInformation, "Displayed")
        clear()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ggg As New PrivateFontCollection
        ggg.AddFontFile("C:\Users\Admin\Documents\fonts\Chakra_Petch\ChakraPetch-Regular.ttf")
        loginlabel.Font = New Font(ggg.Families(0), 32, FontStyle.Bold)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles cretacc.Click
        FrmCreateAccount.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtStudentName_Click(sender As Object, e As EventArgs) Handles txtStudentName.Click, txtStudentNumber.Leave
        If txtStudentName.Text = "Student Name" Then
            txtStudentName.Text = ""
            txtStudentName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtStudentName_Leave(sender As Object, e As EventArgs) Handles txtStudentName.Leave
        If String.IsNullOrWhiteSpace(txtStudentName.Text) Then
            txtStudentName.Text = "Student Name"
            txtStudentName.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub


    Private Sub txtStudentNumber_Click(sender As Object, e As EventArgs) Handles txtStudentNumber.Click, txtStudentName.Leave
        If txtStudentNumber.Text = "Student Number" Then
            txtStudentNumber.Text = ""
            txtStudentNumber.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtStudentNumber_Leave(sender As Object, e As EventArgs) Handles txtStudentNumber.Leave
        If String.IsNullOrWhiteSpace(txtStudentNumber.Text) Then
            txtStudentNumber.Text = "Student Number"
            txtStudentNumber.ForeColor = Color.FromArgb(128, Color.Gray)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtStudentNumber_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNumber.TextChanged

    End Sub
End Class
