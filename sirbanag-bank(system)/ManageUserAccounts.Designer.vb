<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageUserAccounts
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
        Me.fullname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.country = New Guna.UI.WinForms.GunaComboBox()
        Me.txtrole = New Guna.UI.WinForms.GunaComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email = New Guna.UI.WinForms.GunaLineTextBox()
        Me.address = New Guna.UI.WinForms.GunaLineTextBox()
        Me.citytown = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtusername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbostatus = New Guna.UI.WinForms.GunaComboBox()
        Me.btnupdate = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'fullname
        '
        Me.fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.fullname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.fullname.LineColor = System.Drawing.Color.WhiteSmoke
        Me.fullname.LineSize = 2
        Me.fullname.Location = New System.Drawing.Point(110, 82)
        Me.fullname.Name = "fullname"
        Me.fullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname.SelectedText = ""
        Me.fullname.Size = New System.Drawing.Size(269, 30)
        Me.fullname.TabIndex = 35
        Me.fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 42)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Admin's / Account Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(15, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Full name"
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
        Me.country.Location = New System.Drawing.Point(110, 342)
        Me.country.Name = "country"
        Me.country.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.country.OnHoverItemForeColor = System.Drawing.Color.White
        Me.country.Radius = 10
        Me.country.Size = New System.Drawing.Size(269, 31)
        Me.country.TabIndex = 44
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
        Me.txtrole.Location = New System.Drawing.Point(557, 209)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrole.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtrole.Radius = 10
        Me.txtrole.Size = New System.Drawing.Size(221, 31)
        Me.txtrole.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(589, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 23)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Admin's Account Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(168, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 23)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Admin's Personal Details"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.email.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.email.LineColor = System.Drawing.Color.WhiteSmoke
        Me.email.LineSize = 2
        Me.email.Location = New System.Drawing.Point(110, 146)
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.SelectedText = ""
        Me.email.Size = New System.Drawing.Size(269, 30)
        Me.email.TabIndex = 35
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'address
        '
        Me.address.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.address.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.address.LineColor = System.Drawing.Color.WhiteSmoke
        Me.address.LineSize = 2
        Me.address.Location = New System.Drawing.Point(110, 210)
        Me.address.Name = "address"
        Me.address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address.SelectedText = ""
        Me.address.Size = New System.Drawing.Size(269, 30)
        Me.address.TabIndex = 35
        Me.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'citytown
        '
        Me.citytown.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.citytown.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.citytown.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.citytown.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citytown.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.citytown.LineColor = System.Drawing.Color.WhiteSmoke
        Me.citytown.LineSize = 2
        Me.citytown.Location = New System.Drawing.Point(110, 282)
        Me.citytown.Name = "citytown"
        Me.citytown.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.citytown.SelectedText = ""
        Me.citytown.Size = New System.Drawing.Size(269, 30)
        Me.citytown.TabIndex = 35
        Me.citytown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(15, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(15, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(15, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "City/Town"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(15, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 23)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Country"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtusername.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.LineSize = 2
        Me.txtusername.Location = New System.Drawing.Point(557, 82)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(221, 30)
        Me.txtusername.TabIndex = 35
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtpassword.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtpassword.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.LineSize = 2
        Me.txtpassword.Location = New System.Drawing.Point(557, 146)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(221, 30)
        Me.txtpassword.TabIndex = 35
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Snow
        Me.Label9.Location = New System.Drawing.Point(433, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Username:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Snow
        Me.Label10.Location = New System.Drawing.Point(433, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 23)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Snow
        Me.Label11.Location = New System.Drawing.Point(433, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 23)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Role:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 399)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(782, 173)
        Me.ListView1.TabIndex = 49
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fullname"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Email"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "City"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Country"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Role"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 70
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "AcctStatus"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Snow
        Me.Label12.Location = New System.Drawing.Point(433, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 23)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Account Status:"
        '
        'cbostatus
        '
        Me.cbostatus.BackColor = System.Drawing.Color.Transparent
        Me.cbostatus.BaseColor = System.Drawing.Color.White
        Me.cbostatus.BorderColor = System.Drawing.Color.Transparent
        Me.cbostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FocusedColor = System.Drawing.Color.Empty
        Me.cbostatus.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.ForeColor = System.Drawing.Color.Black
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Active", "Disabled"})
        Me.cbostatus.Location = New System.Drawing.Point(557, 284)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbostatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbostatus.Radius = 10
        Me.cbostatus.Size = New System.Drawing.Size(221, 31)
        Me.cbostatus.TabIndex = 48
        '
        'btnupdate
        '
        Me.btnupdate.AnimationHoverSpeed = 0.07!
        Me.btnupdate.AnimationSpeed = 0.03!
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BaseColor = System.Drawing.SystemColors.Window
        Me.btnupdate.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdate.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnupdate.Image = Nothing
        Me.btnupdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnupdate.Location = New System.Drawing.Point(704, 342)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverImage = Nothing
        Me.btnupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdate.Radius = 1
        Me.btnupdate.Size = New System.Drawing.Size(74, 36)
        Me.btnupdate.TabIndex = 50
        Me.btnupdate.Text = "Update"
        Me.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ManageUserAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 584)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.citytown)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.fullname)
        Me.Name = "ManageUserAccounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fullname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents country As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtrole As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents email As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents address As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents citytown As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label12 As Label
    Friend WithEvents cbostatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents btnupdate As Guna.UI.WinForms.GunaButton
End Class
