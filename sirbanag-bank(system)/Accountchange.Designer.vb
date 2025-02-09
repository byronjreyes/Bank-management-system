<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accountchange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrepin = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtcurrent = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtacc = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtnewpin = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnLogin.BorderSize = 2
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Transparent
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(273, 331)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogin.OnPressedDepth = 25
        Me.btnLogin.Radius = 21
        Me.btnLogin.Size = New System.Drawing.Size(226, 46)
        Me.btnLogin.TabIndex = 56
        Me.btnLogin.Text = "Update"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(211, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 23)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Retype-Pin:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Snow
        Me.Label11.Location = New System.Drawing.Point(211, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 23)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Current Pin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(211, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Account Number:"
        '
        'txtrepin
        '
        Me.txtrepin.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtrepin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrepin.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtrepin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtrepin.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtrepin.LineSize = 2
        Me.txtrepin.Location = New System.Drawing.Point(215, 255)
        Me.txtrepin.Name = "txtrepin"
        Me.txtrepin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrepin.SelectedText = ""
        Me.txtrepin.Size = New System.Drawing.Size(344, 30)
        Me.txtrepin.TabIndex = 57
        Me.txtrepin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcurrent
        '
        Me.txtcurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtcurrent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurrent.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtcurrent.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrent.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtcurrent.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtcurrent.LineSize = 2
        Me.txtcurrent.Location = New System.Drawing.Point(215, 119)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcurrent.SelectedText = ""
        Me.txtcurrent.Size = New System.Drawing.Size(344, 30)
        Me.txtcurrent.TabIndex = 58
        Me.txtcurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtacc
        '
        Me.txtacc.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtacc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtacc.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtacc.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacc.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtacc.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtacc.LineSize = 2
        Me.txtacc.Location = New System.Drawing.Point(215, 53)
        Me.txtacc.Name = "txtacc"
        Me.txtacc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtacc.SelectedText = ""
        Me.txtacc.Size = New System.Drawing.Size(344, 30)
        Me.txtacc.TabIndex = 59
        Me.txtacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnewpin
        '
        Me.txtnewpin.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtnewpin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpin.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtnewpin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtnewpin.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtnewpin.LineSize = 2
        Me.txtnewpin.Location = New System.Drawing.Point(215, 183)
        Me.txtnewpin.Name = "txtnewpin"
        Me.txtnewpin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnewpin.SelectedText = ""
        Me.txtnewpin.Size = New System.Drawing.Size(344, 30)
        Me.txtnewpin.TabIndex = 58
        Me.txtnewpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(211, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "New PIN:"
        '
        'Accountchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrepin)
        Me.Controls.Add(Me.txtnewpin)
        Me.Controls.Add(Me.txtcurrent)
        Me.Controls.Add(Me.txtacc)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Accountchange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountchange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrepin As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtcurrent As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtacc As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtnewpin As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
End Class
