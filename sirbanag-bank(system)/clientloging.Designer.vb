<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientloging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientloging))
        Me.txtacct = New Guna.UI.WinForms.GunaTextBox()
        Me.txtpin = New Guna.UI.WinForms.GunaTextBox()
        Me.btnlogin = New Guna.UI.WinForms.GunaButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mainform = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.signupnow = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblaccount = New Guna.UI.WinForms.GunaLabel()
        Me.Panelsidemenu = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainform.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.Transparent
        Me.txtacct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtacct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtacct.BorderSize = 1
        Me.txtacct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtacct.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtacct.FocusedBorderColor = System.Drawing.Color.White
        Me.txtacct.FocusedForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtacct.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtacct.Location = New System.Drawing.Point(108, 137)
        Me.txtacct.Name = "txtacct"
        Me.txtacct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtacct.Radius = 10
        Me.txtacct.SelectedText = ""
        Me.txtacct.Size = New System.Drawing.Size(220, 31)
        Me.txtacct.TabIndex = 2
        Me.txtacct.Text = "Enter your Account Number"
        Me.txtacct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpin
        '
        Me.txtpin.BackColor = System.Drawing.Color.Transparent
        Me.txtpin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtpin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtpin.BorderSize = 1
        Me.txtpin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpin.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtpin.FocusedBorderColor = System.Drawing.Color.White
        Me.txtpin.FocusedForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtpin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtpin.Location = New System.Drawing.Point(108, 206)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpin.Radius = 10
        Me.txtpin.SelectedText = ""
        Me.txtpin.Size = New System.Drawing.Size(220, 31)
        Me.txtpin.TabIndex = 3
        Me.txtpin.Text = "Enter Your Pin"
        Me.txtpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnlogin
        '
        Me.btnlogin.AnimationHoverSpeed = 0.07!
        Me.btnlogin.AnimationSpeed = 0.03!
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BaseColor = System.Drawing.Color.Transparent
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
        Me.btnlogin.TabIndex = 1
        Me.btnlogin.Text = "Sign In"
        Me.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Chakra Petch", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(51, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 87)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Client Login"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 21
        Me.GunaElipse1.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(675, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 32)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.IPT_31A3_REYES.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(66, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.IPT_31A3_REYES.My.Resources.Resources.password_logo
        Me.PictureBox2.Location = New System.Drawing.Point(66, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'mainform
        '
        Me.mainform.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.mainform.Controls.Add(Me.Guna2ControlBox2)
        Me.mainform.Controls.Add(Me.signupnow)
        Me.mainform.Controls.Add(Me.GunaLabel2)
        Me.mainform.Controls.Add(Me.GunaLabel1)
        Me.mainform.Controls.Add(Me.lblaccount)
        Me.mainform.Controls.Add(Me.Label5)
        Me.mainform.Controls.Add(Me.PictureBox1)
        Me.mainform.Controls.Add(Me.txtacct)
        Me.mainform.Controls.Add(Me.PictureBox2)
        Me.mainform.Controls.Add(Me.txtpin)
        Me.mainform.Controls.Add(Me.btnlogin)
        Me.mainform.Dock = System.Windows.Forms.DockStyle.Right
        Me.mainform.Location = New System.Drawing.Point(320, 0)
        Me.mainform.Name = "mainform"
        Me.mainform.Size = New System.Drawing.Size(387, 431)
        Me.mainform.TabIndex = 21
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(351, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.PressedColor = System.Drawing.Color.DarkGray
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(33, 31)
        Me.Guna2ControlBox2.TabIndex = 24
        '
        'signupnow
        '
        Me.signupnow.AutoSize = True
        Me.signupnow.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupnow.LinkColor = System.Drawing.Color.Silver
        Me.signupnow.Location = New System.Drawing.Point(244, 353)
        Me.signupnow.Name = "signupnow"
        Me.signupnow.Size = New System.Drawing.Size(76, 17)
        Me.signupnow.TabIndex = 23
        Me.signupnow.TabStop = True
        Me.signupnow.Text = "Signup now"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel2.Location = New System.Drawing.Point(129, 388)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(150, 17)
        Me.GunaLabel2.TabIndex = 22
        Me.GunaLabel2.Text = "Back to Admin Login?"
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
        Me.GunaLabel1.TabIndex = 22
        Me.GunaLabel1.Text = "Don't have Account?"
        '
        'lblaccount
        '
        Me.lblaccount.AutoSize = True
        Me.lblaccount.BackColor = System.Drawing.Color.Transparent
        Me.lblaccount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblaccount.Location = New System.Drawing.Point(162, 254)
        Me.lblaccount.Name = "lblaccount"
        Me.lblaccount.Size = New System.Drawing.Size(42, 21)
        Me.lblaccount.TabIndex = 21
        Me.lblaccount.Text = "User"
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
        Me.Panelsidemenu.TabIndex = 22
        '
        'clientloging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 431)
        Me.Controls.Add(Me.Panelsidemenu)
        Me.Controls.Add(Me.mainform)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clientloging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "clientloging"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainform.ResumeLayout(False)
        Me.mainform.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtacct As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtpin As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnlogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents mainform As Panel
    Friend WithEvents lblaccount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents signupnow As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panelsidemenu As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
End Class
