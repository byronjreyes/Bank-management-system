Public Class ChooseMain
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Loginform.Show()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        clientloging.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("Thank u")
        Application.Exit()
    End Sub
End Class