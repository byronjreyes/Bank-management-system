<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreateAccount
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.backbtn = New Guna.UI.WinForms.GunaButton()
        Me.btnsave = New Guna.UI.WinForms.GunaButton()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txtConfirmedpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txtrole = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.citytown = New Guna.UI.WinForms.GunaTextBox()
        Me.address = New Guna.UI.WinForms.GunaTextBox()
        Me.email = New Guna.UI.WinForms.GunaTextBox()
        Me.fullname = New Guna.UI.WinForms.GunaTextBox()
        Me.country = New Guna.UI.WinForms.GunaComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Chakra Petch", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(45, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 67)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CREATE ACCOUNT"
        '
        'backbtn
        '
        Me.backbtn.AnimationHoverSpeed = 0.07!
        Me.backbtn.AnimationSpeed = 0.03!
        Me.backbtn.BackColor = System.Drawing.Color.Transparent
        Me.backbtn.BaseColor = System.Drawing.SystemColors.Window
        Me.backbtn.BorderColor = System.Drawing.Color.Black
        Me.backbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.backbtn.FocusedColor = System.Drawing.Color.Empty
        Me.backbtn.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.backbtn.Image = Nothing
        Me.backbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.backbtn.Location = New System.Drawing.Point(67, 617)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.backbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.backbtn.OnHoverForeColor = System.Drawing.Color.Black
        Me.backbtn.OnHoverImage = Nothing
        Me.backbtn.OnPressedColor = System.Drawing.Color.Black
        Me.backbtn.Radius = 1
        Me.backbtn.Size = New System.Drawing.Size(74, 36)
        Me.backbtn.TabIndex = 1
        Me.backbtn.Text = "Back"
        Me.backbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsave
        '
        Me.btnsave.AnimationHoverSpeed = 0.07!
        Me.btnsave.AnimationSpeed = 0.03!
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BaseColor = System.Drawing.SystemColors.Window
        Me.btnsave.BorderColor = System.Drawing.Color.Black
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsave.FocusedColor = System.Drawing.Color.Empty
        Me.btnsave.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsave.Location = New System.Drawing.Point(271, 617)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Radius = 1
        Me.btnsave.Size = New System.Drawing.Size(74, 36)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Submit"
        Me.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BaseColor = System.Drawing.Color.White
        Me.txtusername.BorderColor = System.Drawing.Color.Silver
        Me.txtusername.BorderSize = 0
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusername.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtusername.Location = New System.Drawing.Point(67, 409)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Radius = 8
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(288, 33)
        Me.txtusername.TabIndex = 7
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BaseColor = System.Drawing.Color.White
        Me.txtpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtpassword.BorderSize = 0
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpassword.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtpassword.Location = New System.Drawing.Point(67, 458)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.Radius = 8
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(288, 33)
        Me.txtpassword.TabIndex = 8
        '
        'txtConfirmedpassword
        '
        Me.txtConfirmedpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmedpassword.BaseColor = System.Drawing.Color.White
        Me.txtConfirmedpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtConfirmedpassword.BorderSize = 0
        Me.txtConfirmedpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmedpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtConfirmedpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmedpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtConfirmedpassword.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmedpassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtConfirmedpassword.Location = New System.Drawing.Point(67, 505)
        Me.txtConfirmedpassword.Name = "txtConfirmedpassword"
        Me.txtConfirmedpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmedpassword.Radius = 8
        Me.txtConfirmedpassword.SelectedText = ""
        Me.txtConfirmedpassword.Size = New System.Drawing.Size(288, 33)
        Me.txtConfirmedpassword.TabIndex = 9
        '
        'txtrole
        '
        Me.txtrole.BackColor = System.Drawing.Color.Transparent
        Me.txtrole.BaseColor = System.Drawing.Color.White
        Me.txtrole.BorderColor = System.Drawing.Color.Transparent
        Me.txtrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtrole.FocusedColor = System.Drawing.Color.Empty
        Me.txtrole.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrole.ForeColor = System.Drawing.Color.Black
        Me.txtrole.FormattingEnabled = True
        Me.txtrole.Items.AddRange(New Object() {"Admin", "SuperAdmin", "Moderator", "Developer"})
        Me.txtrole.Location = New System.Drawing.Point(67, 553)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrole.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtrole.Radius = 10
        Me.txtrole.Size = New System.Drawing.Size(288, 31)
        Me.txtrole.TabIndex = 10
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaElipsePanel2)
        Me.GunaElipsePanel1.Controls.Add(Me.citytown)
        Me.GunaElipsePanel1.Controls.Add(Me.address)
        Me.GunaElipsePanel1.Controls.Add(Me.email)
        Me.GunaElipsePanel1.Controls.Add(Me.fullname)
        Me.GunaElipsePanel1.Controls.Add(Me.txtusername)
        Me.GunaElipsePanel1.Controls.Add(Me.country)
        Me.GunaElipsePanel1.Controls.Add(Me.txtrole)
        Me.GunaElipsePanel1.Controls.Add(Me.Label7)
        Me.GunaElipsePanel1.Controls.Add(Me.Label6)
        Me.GunaElipsePanel1.Controls.Add(Me.btnsave)
        Me.GunaElipsePanel1.Controls.Add(Me.backbtn)
        Me.GunaElipsePanel1.Controls.Add(Me.txtConfirmedpassword)
        Me.GunaElipsePanel1.Controls.Add(Me.txtpassword)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 25
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(426, 742)
        Me.GunaElipsePanel1.TabIndex = 9
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.Label5)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 2
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(580, 84)
        Me.GunaElipsePanel2.TabIndex = 11
        '
        'citytown
        '
        Me.citytown.BackColor = System.Drawing.Color.Transparent
        Me.citytown.BaseColor = System.Drawing.Color.White
        Me.citytown.BorderColor = System.Drawing.Color.Silver
        Me.citytown.BorderSize = 0
        Me.citytown.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.citytown.FocusedBaseColor = System.Drawing.Color.White
        Me.citytown.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.citytown.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.citytown.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citytown.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.citytown.Location = New System.Drawing.Point(67, 277)
        Me.citytown.Name = "citytown"
        Me.citytown.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.citytown.Radius = 8
        Me.citytown.SelectedText = ""
        Me.citytown.Size = New System.Drawing.Size(288, 33)
        Me.citytown.TabIndex = 5
        '
        'address
        '
        Me.address.BackColor = System.Drawing.Color.Transparent
        Me.address.BaseColor = System.Drawing.Color.White
        Me.address.BorderColor = System.Drawing.Color.Silver
        Me.address.BorderSize = 0
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.FocusedBaseColor = System.Drawing.Color.White
        Me.address.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.address.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.address.Location = New System.Drawing.Point(67, 232)
        Me.address.Name = "address"
        Me.address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address.Radius = 8
        Me.address.SelectedText = ""
        Me.address.Size = New System.Drawing.Size(288, 33)
        Me.address.TabIndex = 4
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.Transparent
        Me.email.BaseColor = System.Drawing.Color.White
        Me.email.BorderColor = System.Drawing.Color.Silver
        Me.email.BorderSize = 0
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.FocusedBaseColor = System.Drawing.Color.White
        Me.email.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.email.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.email.Location = New System.Drawing.Point(67, 185)
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.Radius = 8
        Me.email.SelectedText = ""
        Me.email.Size = New System.Drawing.Size(288, 33)
        Me.email.TabIndex = 3
        '
        'fullname
        '
        Me.fullname.BackColor = System.Drawing.Color.Transparent
        Me.fullname.BaseColor = System.Drawing.Color.White
        Me.fullname.BorderColor = System.Drawing.Color.Silver
        Me.fullname.BorderSize = 0
        Me.fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname.FocusedBaseColor = System.Drawing.Color.White
        Me.fullname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.fullname.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.fullname.Location = New System.Drawing.Point(67, 136)
        Me.fullname.Name = "fullname"
        Me.fullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname.Radius = 8
        Me.fullname.SelectedText = ""
        Me.fullname.Size = New System.Drawing.Size(288, 33)
        Me.fullname.TabIndex = 2
        '
        'country
        '
        Me.country.BackColor = System.Drawing.Color.Transparent
        Me.country.BaseColor = System.Drawing.Color.White
        Me.country.BorderColor = System.Drawing.Color.Transparent
        Me.country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.country.FocusedColor = System.Drawing.Color.Empty
        Me.country.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.country.ForeColor = System.Drawing.Color.Black
        Me.country.FormattingEnabled = True
        Me.country.Items.AddRange(New Object() {"Afghanistan", "Bangladesh", "Barbados", "Belarus", "Belgium", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Congo (Congo-Brazzaville)", "Dominica", "Dominican Republic", "Eswatini (fmr. ""Swaziland"")", "Ethiopia", "Fiji", "Gambia", "Georgia", "Grenada", "Guatemala", "Honduras", "Hungary", "Iran", "Iraq", "Jamaica", "Japan", "Jordan", "Laos", "Liberia", "Libya", "Madagascar", "Mauritania", "Nauru", "Nepal", "Netherlands", "New Zealand", "Niger", "Nigeria", "Pakistan", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Rwanda", "Saint Kitts and Nevis", "San Marino", "Seychelles", "Sierra Leone", "Somalia", "Sri Lanka", "Switzerland", "Syria", "United Kingdom", "United States of America", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.country.Location = New System.Drawing.Point(67, 324)
        Me.country.Name = "country"
        Me.country.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.country.OnHoverItemForeColor = System.Drawing.Color.White
        Me.country.Radius = 10
        Me.country.Size = New System.Drawing.Size(288, 31)
        Me.country.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(63, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Enter your Account Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(63, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Enter your personal details"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 25
        Me.GunaElipse1.TargetControl = Me
        '
        'FrmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 738)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCreateAccount"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaButton
    Friend WithEvents backbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtConfirmedpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtrole As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label6 As Label
    Friend WithEvents fullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents citytown As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents address As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents email As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents country As Guna.UI.WinForms.GunaComboBox
End Class
