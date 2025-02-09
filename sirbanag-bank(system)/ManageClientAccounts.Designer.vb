<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageClientAccounts
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
        Me.ddate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.btnsave = New Guna.UI.WinForms.GunaButton()
        Me.txtage = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtmi = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtaddress = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtLastname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtcontactno = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtemail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtfirstname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsex = New Guna.UI.WinForms.GunaComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtacc = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPIN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cbostatus = New Guna.UI.WinForms.GunaComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnupdate = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.txtretypepin = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ddate
        '
        Me.ddate.BackColor = System.Drawing.Color.Transparent
        Me.ddate.BaseColor = System.Drawing.Color.White
        Me.ddate.BorderColor = System.Drawing.Color.Silver
        Me.ddate.BorderSize = 1
        Me.ddate.CustomFormat = Nothing
        Me.ddate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.ddate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ddate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddate.ForeColor = System.Drawing.Color.Black
        Me.ddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ddate.Location = New System.Drawing.Point(120, 298)
        Me.ddate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ddate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ddate.Name = "ddate"
        Me.ddate.OnHoverBaseColor = System.Drawing.Color.White
        Me.ddate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ddate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ddate.OnPressedColor = System.Drawing.Color.Black
        Me.ddate.Radius = 10
        Me.ddate.Size = New System.Drawing.Size(117, 28)
        Me.ddate.TabIndex = 24
        Me.ddate.Text = "10/1/2023"
        Me.ddate.Value = New Date(2023, 10, 1, 14, 6, 24, 260)
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.SystemColors.Window
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(25, 498)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 1
        Me.GunaButton1.Size = New System.Drawing.Size(74, 36)
        Me.GunaButton1.TabIndex = 15
        Me.GunaButton1.Text = "New"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnsave.Location = New System.Drawing.Point(105, 498)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Radius = 1
        Me.btnsave.Size = New System.Drawing.Size(74, 36)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtage.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtage.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtage.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtage.LineSize = 2
        Me.txtage.Location = New System.Drawing.Point(287, 295)
        Me.txtage.Name = "txtage"
        Me.txtage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtage.SelectedText = ""
        Me.txtage.Size = New System.Drawing.Size(40, 30)
        Me.txtage.TabIndex = 34
        Me.txtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmi
        '
        Me.txtmi.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtmi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmi.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtmi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmi.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtmi.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtmi.LineSize = 2
        Me.txtmi.Location = New System.Drawing.Point(419, 79)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmi.SelectedText = ""
        Me.txtmi.Size = New System.Drawing.Size(107, 30)
        Me.txtmi.TabIndex = 34
        Me.txtmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtaddress.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtaddress.LineSize = 2
        Me.txtaddress.Location = New System.Drawing.Point(123, 145)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(401, 30)
        Me.txtaddress.TabIndex = 34
        Me.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastname.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtLastname.LineSize = 2
        Me.txtLastname.Location = New System.Drawing.Point(277, 79)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.Size = New System.Drawing.Size(117, 30)
        Me.txtLastname.TabIndex = 34
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcontactno
        '
        Me.txtcontactno.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtcontactno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontactno.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtcontactno.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtcontactno.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtcontactno.LineSize = 2
        Me.txtcontactno.Location = New System.Drawing.Point(378, 219)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontactno.SelectedText = ""
        Me.txtcontactno.Size = New System.Drawing.Size(151, 30)
        Me.txtcontactno.TabIndex = 34
        Me.txtcontactno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtemail.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtemail.LineSize = 2
        Me.txtemail.Location = New System.Drawing.Point(123, 219)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(144, 30)
        Me.txtemail.TabIndex = 34
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtfirstname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtfirstname.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.LineSize = 2
        Me.txtfirstname.Location = New System.Drawing.Point(123, 79)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.Size = New System.Drawing.Size(128, 30)
        Me.txtfirstname.TabIndex = 34
        Me.txtfirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(283, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 23)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Contact No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Snow
        Me.Label10.Location = New System.Drawing.Point(26, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 23)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Birthdate:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Snow
        Me.Label9.Location = New System.Drawing.Point(337, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(26, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(24, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(20, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Client's name"
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.Transparent
        Me.txtsex.BaseColor = System.Drawing.Color.White
        Me.txtsex.BorderColor = System.Drawing.Color.Transparent
        Me.txtsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtsex.FocusedColor = System.Drawing.Color.Empty
        Me.txtsex.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.ForeColor = System.Drawing.Color.Black
        Me.txtsex.FormattingEnabled = True
        Me.txtsex.Items.AddRange(New Object() {"*-Select your Gender-*", "Male", "Female", "Other"})
        Me.txtsex.Location = New System.Drawing.Point(378, 298)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsex.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtsex.Radius = 10
        Me.txtsex.Size = New System.Drawing.Size(151, 28)
        Me.txtsex.TabIndex = 23
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(24, 360)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(782, 120)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account Number"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Client's Name"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Contact Number"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Age"
        Me.ColumnHeader6.Width = 40
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Birth Date"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sex"
        Me.ColumnHeader8.Width = 50
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Pin"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Account Status"
        Me.ColumnHeader10.Width = 135
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
        Me.txtacc.Location = New System.Drawing.Point(556, 78)
        Me.txtacc.Name = "txtacc"
        Me.txtacc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtacc.SelectedText = ""
        Me.txtacc.Size = New System.Drawing.Size(246, 30)
        Me.txtacc.TabIndex = 34
        Me.txtacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 42)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Client's / Account Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(243, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Age:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Snow
        Me.Label11.Location = New System.Drawing.Point(552, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 23)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Pin:"
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtPIN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPIN.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtPIN.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtPIN.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtPIN.LineSize = 2
        Me.txtPIN.Location = New System.Drawing.Point(556, 144)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPIN.SelectedText = ""
        Me.txtPIN.Size = New System.Drawing.Size(246, 30)
        Me.txtPIN.TabIndex = 34
        Me.txtPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbostatus
        '
        Me.cbostatus.BackColor = System.Drawing.Color.Transparent
        Me.cbostatus.BaseColor = System.Drawing.Color.White
        Me.cbostatus.BorderColor = System.Drawing.Color.Transparent
        Me.cbostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FocusedColor = System.Drawing.Color.Empty
        Me.cbostatus.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.ForeColor = System.Drawing.Color.Black
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Active", "Disabled"})
        Me.cbostatus.Location = New System.Drawing.Point(552, 298)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbostatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbostatus.Radius = 10
        Me.cbostatus.Size = New System.Drawing.Size(250, 28)
        Me.cbostatus.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Snow
        Me.Label13.Location = New System.Drawing.Point(552, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 23)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Account Status:"
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
        Me.btnupdate.Location = New System.Drawing.Point(184, 498)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverImage = Nothing
        Me.btnupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdate.Radius = 1
        Me.btnupdate.Size = New System.Drawing.Size(74, 36)
        Me.btnupdate.TabIndex = 16
        Me.btnupdate.Text = "Update"
        Me.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(552, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Account Number:"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.SystemColors.Window
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(264, 498)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 1
        Me.GunaButton2.Size = New System.Drawing.Size(74, 36)
        Me.GunaButton2.TabIndex = 16
        Me.GunaButton2.Text = "Delete"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtretypepin
        '
        Me.txtretypepin.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtretypepin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtretypepin.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtretypepin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtretypepin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtretypepin.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtretypepin.LineSize = 2
        Me.txtretypepin.Location = New System.Drawing.Point(560, 219)
        Me.txtretypepin.Name = "txtretypepin"
        Me.txtretypepin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtretypepin.SelectedText = ""
        Me.txtretypepin.Size = New System.Drawing.Size(246, 30)
        Me.txtretypepin.TabIndex = 34
        Me.txtretypepin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(556, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 23)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Retype-Pin:"
        '
        'ManageClientAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 545)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txtretypepin)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.txtacc)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.txtsex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ddate)
        Me.Controls.Add(Me.Label5)
        Me.Name = "ManageClientAccounts"
        Me.Text = "ManageClientAccounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ddate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfirstname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtmi As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtLastname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtaddress As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtcontactno As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtemail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtage As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsex As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtacc As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPIN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cbostatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnupdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtretypepin As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label7 As Label
End Class
