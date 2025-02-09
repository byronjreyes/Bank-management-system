Imports System.Windows.Forms

Public Class vbmsgbox

    Public Enum AlertType
        Success
        Warning
        [Error]
        Info
    End Enum

    Enum ActionType
        Wait
        Start
        Close
    End Enum

    Dim action As ActionType = ActionType.Start

    Public Sub setAlert(msg As String, type As AlertType)
        Me.Visible = False
        Select Case type
            Case AlertType.Success
                Me.BackColor = Color.FromArgb(82, 152, 114)
            Case AlertType.Warning
                Me.BackColor = Color.FromArgb(255, 164, 91)
            Case AlertType.Error
                Me.BackColor = Color.FromArgb(255, 70, 70)
            Case AlertType.Info
                Me.BackColor = Color.FromArgb(71, 169, 248)
        End Select

        Me.Label1.Text = msg
        Dim workingArea = Screen.PrimaryScreen.WorkingArea
        Me.Location = New Point(workingArea.Right - Me.Width, workingArea.Bottom - Me.Height)

        Timer1.Interval = 1
        Timer1.Start()
        Me.Visible = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case ActionType.Start
                Timer1.Interval = 1
                Me.Opacity += 0.1
                If Me.Opacity = 1 Then
                    action = ActionType.Wait
                End If
            Case ActionType.Wait
                Timer1.Interval = 3000
                action = ActionType.Close
            Case ActionType.Close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Me.Close()
                End If
        End Select
    End Sub

End Class
