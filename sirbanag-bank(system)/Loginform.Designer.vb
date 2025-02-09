<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginform))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnlogin = New Guna.UI.WinForms.GunaButton()
        Me.loginlabel = New System.Windows.Forms.Label()
        Me.txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.signupnow = New Guna.UI.WinForms.GunaLinkLabel()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.mainform = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblrole = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panelsidemenu = New System.Windows.Forms.Panel()
        Me.mainform.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 21
        Me.GunaElipse1.TargetControl = Me
        '
        'btnlogin
        '
        Me.btnlogin.AnimationHoverSpeed = 0.07!
        Me.btnlogin.AnimationSpeed = 0.03!
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnlogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnlogin.BorderSize = 1
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnlogin.FocusedColor = System.Drawing.Color.Transparent
        Me.btnlogin.Font = New System.Drawing.Font("Chakra Petch", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogin.Image = Nothing
        Me.btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogin.Location = New System.Drawing.Point(108, 288)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnlogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnlogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnlogin.OnHoverImage = Nothing
        Me.btnlogin.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogin.OnPressedDepth = 25
        Me.btnlogin.Radius = 21
        Me.btnlogin.Size = New System.Drawing.Size(220, 44)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Sign In"
        Me.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginlabel
        '
        Me.loginlabel.AutoSize = True
        Me.loginlabel.Font = New System.Drawing.Font("Chakra Petch", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlabel.ForeColor = System.Drawing.Color.White
        Me.loginlabel.Location = New System.Drawing.Point(51, 12)
        Me.loginlabel.Name = "loginlabel"
        Me.loginlabel.Size = New System.Drawing.Size(305, 87)
        Me.loginlabel.TabIndex = 3
        Me.loginlabel.Text = "Admin Login"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtpassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtpassword.BorderSize = 1
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtpassword.FocusedBorderColor = System.Drawing.Color.White
        Me.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtpassword.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtpassword.Location = New System.Drawing.Point(108, 206)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.Radius = 10
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(220, 31)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.Text = "Password"
        '
        'signupnow
        '
        Me.signupnow.AutoSize = True
        Me.signupnow.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupnow.LinkColor = System.Drawing.Color.Silver
        Me.signupnow.Location = New System.Drawing.Point(244, 353)
        Me.signupnow.Name = "signupnow"
        Me.signupnow.Size = New System.Drawing.Size(76, 17)
        Me.signupnow.TabIndex = 1
        Me.signupnow.TabStop = True
        Me.signupnow.Text = "Signup now"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtusername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtusername.BorderSize = 1
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtusername.FocusedBorderColor = System.Drawing.Color.White
        Me.txtusername.FocusedForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtusername.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtusername.Location = New System.Drawing.Point(108, 137)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Radius = 10
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(220, 31)
        Me.txtusername.TabIndex = 2
        Me.txtusername.Text = "Username"
        '
        'mainform
        '
        Me.mainform.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.mainform.Controls.Add(Me.Guna2ControlBox1)
        Me.mainform.Controls.Add(Me.lblrole)
        Me.mainform.Controls.Add(Me.GunaLabel2)
        Me.mainform.Controls.Add(Me.GunaLabel3)
        Me.mainform.Controls.Add(Me.GunaLabel1)
        Me.mainform.Controls.Add(Me.txtusername)
        Me.mainform.Controls.Add(Me.signupnow)
        Me.mainform.Controls.Add(Me.txtpassword)
        Me.mainform.Controls.Add(Me.loginlabel)
        Me.mainform.Controls.Add(Me.btnlogin)
        Me.mainform.Controls.Add(Me.PictureBox1)
        Me.mainform.Controls.Add(Me.PictureBox2)
        Me.mainform.Dock = System.Windows.Forms.DockStyle.Right
        Me.mainform.Location = New System.Drawing.Point(320, 0)
        Me.mainform.Name = "mainform"
        Me.mainform.Size = New System.Drawing.Size(387, 431)
        Me.mainform.TabIndex = 14
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(351, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.DarkGray
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 31)
        Me.Guna2ControlBox1.TabIndex = 16
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.BackColor = System.Drawing.Color.Transparent
        Me.lblrole.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrole.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblrole.Location = New System.Drawing.Point(188, 255)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(42, 21)
        Me.lblrole.TabIndex = 15
        Me.lblrole.Text = "User"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel2.Location = New System.Drawing.Point(63, 259)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(58, 17)
        Me.GunaLabel2.TabIndex = 15
        Me.GunaLabel2.Text = "Position"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel3.Location = New System.Drawing.Point(129, 387)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(146, 17)
        Me.GunaLabel3.TabIndex = 15
        Me.GunaLabel3.Text = "Back to Client Login?"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel1.Location = New System.Drawing.Point(101, 353)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(147, 17)
        Me.GunaLabel1.TabIndex = 15
        Me.GunaLabel1.Text = "Don't have Account?"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Panelsidemenu
        '
        Me.Panelsidemenu.AutoScroll = True
        Me.Panelsidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panelsidemenu.BackgroundImage = CType(resources.GetObject("Panelsidemenu.BackgroundImage"), System.Drawing.Image)
        Me.Panelsidemenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelsidemenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelsidemenu.Name = "Panelsidemenu"
        Me.Panelsidemenu.Size = New System.Drawing.Size(320, 431)
        Me.Panelsidemenu.TabIndex = 15
        '
        'Loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 431)
        Me.Controls.Add(Me.Panelsidemenu)
        Me.Controls.Add(Me.mainform)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mainform.ResumeLayout(False)
        Me.mainform.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents mainform As Panel
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents signupnow As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents loginlabel As Label
    Friend WithEvents btnlogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblrole As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panelsidemenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
