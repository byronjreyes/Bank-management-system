<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientDashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panelsidemenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnacc = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMediasubmenu2 = New System.Windows.Forms.Panel()
        Me.btntransfer = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnMe = New System.Windows.Forms.Button()
        Me.PanelMediasubmenu1 = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnMes = New System.Windows.Forms.Button()
        Me.Panellogo = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblnumber = New System.Windows.Forms.Label()
        Me.lblname = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mainform = New System.Windows.Forms.Panel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.datenow = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.lblcurrentbal = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LatestTransactionsTableAdapter = New IPT_31A3_REYES.MyDatabaseDataSet1TableAdapters.LatestTransactionsTableAdapter()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panelsidemenu.SuspendLayout()
        Me.PanelMediasubmenu2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.mainform.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelsidemenu
        '
        Me.Panelsidemenu.AutoScroll = True
        Me.Panelsidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panelsidemenu.Controls.Add(Me.Button1)
        Me.Panelsidemenu.Controls.Add(Me.Panel4)
        Me.Panelsidemenu.Controls.Add(Me.btnacc)
        Me.Panelsidemenu.Controls.Add(Me.Panel2)
        Me.Panelsidemenu.Controls.Add(Me.PanelMediasubmenu2)
        Me.Panelsidemenu.Controls.Add(Me.btnMe)
        Me.Panelsidemenu.Controls.Add(Me.PanelMediasubmenu1)
        Me.Panelsidemenu.Controls.Add(Me.btnlogout)
        Me.Panelsidemenu.Controls.Add(Me.btnMes)
        Me.Panelsidemenu.Controls.Add(Me.Panellogo)
        Me.Panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelsidemenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelsidemenu.Name = "Panelsidemenu"
        Me.Panelsidemenu.Size = New System.Drawing.Size(250, 589)
        Me.Panelsidemenu.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(0, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(250, 47)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Settings"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 419)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 10)
        Me.Panel4.TabIndex = 14
        '
        'btnacc
        '
        Me.btnacc.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnacc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnacc.FlatAppearance.BorderSize = 0
        Me.btnacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnacc.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnacc.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnacc.Location = New System.Drawing.Point(0, 372)
        Me.btnacc.Name = "btnacc"
        Me.btnacc.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnacc.Size = New System.Drawing.Size(250, 47)
        Me.btnacc.TabIndex = 13
        Me.btnacc.Text = "Account"
        Me.btnacc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnacc.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 362)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 10)
        Me.Panel2.TabIndex = 12
        '
        'PanelMediasubmenu2
        '
        Me.PanelMediasubmenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMediasubmenu2.Controls.Add(Me.btntransfer)
        Me.PanelMediasubmenu2.Controls.Add(Me.Button4)
        Me.PanelMediasubmenu2.Controls.Add(Me.Button5)
        Me.PanelMediasubmenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediasubmenu2.Location = New System.Drawing.Point(0, 205)
        Me.PanelMediasubmenu2.Name = "PanelMediasubmenu2"
        Me.PanelMediasubmenu2.Size = New System.Drawing.Size(250, 157)
        Me.PanelMediasubmenu2.TabIndex = 9
        '
        'btntransfer
        '
        Me.btntransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btntransfer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btntransfer.FlatAppearance.BorderSize = 0
        Me.btntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransfer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransfer.ForeColor = System.Drawing.Color.Gainsboro
        Me.btntransfer.Location = New System.Drawing.Point(0, 94)
        Me.btntransfer.Name = "btntransfer"
        Me.btntransfer.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btntransfer.Size = New System.Drawing.Size(250, 47)
        Me.btntransfer.TabIndex = 4
        Me.btntransfer.Text = "Transfer"
        Me.btntransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntransfer.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(0, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(250, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Withdraw"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(250, 47)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Deposit"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnMe
        '
        Me.btnMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMe.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMe.FlatAppearance.BorderSize = 0
        Me.btnMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMe.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMe.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMe.Location = New System.Drawing.Point(0, 158)
        Me.btnMe.Name = "btnMe"
        Me.btnMe.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMe.Size = New System.Drawing.Size(250, 47)
        Me.btnMe.TabIndex = 8
        Me.btnMe.Text = "Transactions"
        Me.btnMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMe.UseVisualStyleBackColor = False
        '
        'PanelMediasubmenu1
        '
        Me.PanelMediasubmenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMediasubmenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediasubmenu1.Location = New System.Drawing.Point(0, 148)
        Me.PanelMediasubmenu1.Name = "PanelMediasubmenu1"
        Me.PanelMediasubmenu1.Size = New System.Drawing.Size(250, 10)
        Me.PanelMediasubmenu1.TabIndex = 7
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnlogout.Location = New System.Drawing.Point(0, 530)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnlogout.Size = New System.Drawing.Size(250, 59)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnMes
        '
        Me.btnMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMes.FlatAppearance.BorderSize = 0
        Me.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMes.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMes.Location = New System.Drawing.Point(0, 101)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMes.Size = New System.Drawing.Size(250, 47)
        Me.btnMes.TabIndex = 1
        Me.btnMes.Text = "Dashboard"
        Me.btnMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMes.UseVisualStyleBackColor = False
        '
        'Panellogo
        '
        Me.Panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panellogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panellogo.Location = New System.Drawing.Point(0, 0)
        Me.Panellogo.Name = "Panellogo"
        Me.Panellogo.Size = New System.Drawing.Size(250, 101)
        Me.Panellogo.TabIndex = 0
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 21
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 9
        Me.GunaElipse2.TargetControl = Me.Panel3
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.lblnumber)
        Me.Panel3.Controls.Add(Me.lblname)
        Me.Panel3.Controls.Add(Me.GunaLabel2)
        Me.Panel3.Location = New System.Drawing.Point(35, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 142)
        Me.Panel3.TabIndex = 40
        '
        'lblnumber
        '
        Me.lblnumber.AutoSize = True
        Me.lblnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblnumber.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblnumber.Location = New System.Drawing.Point(15, 67)
        Me.lblnumber.Name = "lblnumber"
        Me.lblnumber.Size = New System.Drawing.Size(93, 26)
        Me.lblnumber.TabIndex = 33
        Me.lblnumber.Text = "7655673cc"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblname.Location = New System.Drawing.Point(15, 94)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(64, 26)
        Me.lblname.TabIndex = 16
        Me.lblname.Text = "Byron f"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel2.Location = New System.Drawing.Point(108, 67)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(67, 37)
        Me.GunaLabel2.TabIndex = 17
        Me.GunaLabel2.Text = "*****"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 554)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 35)
        Me.Panel1.TabIndex = 0
        '
        'mainform
        '
        Me.mainform.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.mainform.Controls.Add(Me.Guna2ShadowPanel1)
        Me.mainform.Controls.Add(Me.Panel3)
        Me.mainform.Controls.Add(Me.datenow)
        Me.mainform.Controls.Add(Me.GunaLabel3)
        Me.mainform.Controls.Add(Me.GunaLabel6)
        Me.mainform.Controls.Add(Me.GunaLabel4)
        Me.mainform.Controls.Add(Me.GunaLabel5)
        Me.mainform.Controls.Add(Me.lblcurrentbal)
        Me.mainform.Controls.Add(Me.GunaLabel1)
        Me.mainform.Controls.Add(Me.Panel1)
        Me.mainform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainform.Location = New System.Drawing.Point(250, 0)
        Me.mainform.Name = "mainform"
        Me.mainform.Size = New System.Drawing.Size(827, 589)
        Me.mainform.TabIndex = 4
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.DataGridView1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(35, 316)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(761, 226)
        Me.Guna2ShadowPanel1.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(20, 15)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(723, 194)
        Me.DataGridView1.TabIndex = 4
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'datenow
        '
        Me.datenow.AutoSize = True
        Me.datenow.BackColor = System.Drawing.Color.Transparent
        Me.datenow.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datenow.ForeColor = System.Drawing.Color.Gainsboro
        Me.datenow.Location = New System.Drawing.Point(137, 238)
        Me.datenow.Name = "datenow"
        Me.datenow.Size = New System.Drawing.Size(73, 26)
        Me.datenow.TabIndex = 33
        Me.datenow.Text = "Monday"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel3.Location = New System.Drawing.Point(38, 238)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(93, 26)
        Me.GunaLabel3.TabIndex = 34
        Me.GunaLabel3.Text = "Date/Time:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel6.Location = New System.Drawing.Point(28, 276)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(220, 37)
        Me.GunaLabel6.TabIndex = 38
        Me.GunaLabel6.Text = "Latest Transactions"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel4.Location = New System.Drawing.Point(26, 9)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(187, 51)
        Me.GunaLabel4.TabIndex = 39
        Me.GunaLabel4.Text = "Dashboard"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel5.Location = New System.Drawing.Point(321, 108)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(30, 34)
        Me.GunaLabel5.TabIndex = 35
        Me.GunaLabel5.Text = "₱"
        '
        'lblcurrentbal
        '
        Me.lblcurrentbal.AutoSize = True
        Me.lblcurrentbal.BackColor = System.Drawing.Color.Transparent
        Me.lblcurrentbal.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentbal.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblcurrentbal.Location = New System.Drawing.Point(350, 108)
        Me.lblcurrentbal.Name = "lblcurrentbal"
        Me.lblcurrentbal.Size = New System.Drawing.Size(27, 34)
        Me.lblcurrentbal.TabIndex = 36
        Me.lblcurrentbal.Text = "0"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel1.Location = New System.Drawing.Point(321, 77)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(138, 26)
        Me.GunaLabel1.TabIndex = 37
        Me.GunaLabel1.Text = "Current Balance:"
        '
        'LatestTransactionsTableAdapter
        '
        Me.LatestTransactionsTableAdapter.ClearBeforeFill = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 11
        Me.Guna2Elipse1.TargetControl = Me.DataGridView1
        '
        'ClientDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 589)
        Me.Controls.Add(Me.mainform)
        Me.Controls.Add(Me.Panelsidemenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientDashboard"
        Me.Panelsidemenu.ResumeLayout(False)
        Me.PanelMediasubmenu2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.mainform.ResumeLayout(False)
        Me.mainform.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelsidemenu As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnMes As Button
    Friend WithEvents Panellogo As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelMediasubmenu2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnMe As Button
    Friend WithEvents PanelMediasubmenu1 As Panel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse

    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcctNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranstypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btntransfer As Button
    Friend WithEvents btnacc As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents mainform As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblnumber As Label
    Friend WithEvents lblname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents datenow As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcurrentbal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents LatestTransactionsTableAdapter As MyDatabaseDataSet1TableAdapters.LatestTransactionsTableAdapter
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
