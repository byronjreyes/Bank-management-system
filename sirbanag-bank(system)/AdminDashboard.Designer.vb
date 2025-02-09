<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panellogo = New System.Windows.Forms.Panel()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panelsidemenu = New System.Windows.Forms.Panel()
        Me.PanelMediasubmenu = New System.Windows.Forms.Panel()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnclient = New System.Windows.Forms.Button()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datenow = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.tkrole = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.tkusername = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.mainform = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2ShadowPanel5 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.LabelaccCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonStartElection = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.LabeladminCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Panelsidemenu.SuspendLayout()
        Me.PanelMediasubmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mainform.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2ShadowPanel5.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 21
        Me.GunaElipse1.TargetControl = Me
        '
        'Timer1
        '
        '
        'Panellogo
        '
        Me.Panellogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panellogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panellogo.Location = New System.Drawing.Point(0, 0)
        Me.Panellogo.Name = "Panellogo"
        Me.Panellogo.Size = New System.Drawing.Size(250, 131)
        Me.Panellogo.TabIndex = 0
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnhome.Location = New System.Drawing.Point(0, 131)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnhome.Size = New System.Drawing.Size(250, 59)
        Me.btnhome.TabIndex = 1
        Me.btnhome.Text = "Home"
        Me.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
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
        'Panelsidemenu
        '
        Me.Panelsidemenu.AutoScroll = True
        Me.Panelsidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panelsidemenu.Controls.Add(Me.PanelMediasubmenu)
        Me.Panelsidemenu.Controls.Add(Me.btnMedia)
        Me.Panelsidemenu.Controls.Add(Me.btnlogout)
        Me.Panelsidemenu.Controls.Add(Me.btnhome)
        Me.Panelsidemenu.Controls.Add(Me.Panellogo)
        Me.Panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelsidemenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelsidemenu.Name = "Panelsidemenu"
        Me.Panelsidemenu.Size = New System.Drawing.Size(250, 589)
        Me.Panelsidemenu.TabIndex = 1
        '
        'PanelMediasubmenu
        '
        Me.PanelMediasubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMediasubmenu.Controls.Add(Me.btnuser)
        Me.PanelMediasubmenu.Controls.Add(Me.btnclient)
        Me.PanelMediasubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediasubmenu.Location = New System.Drawing.Point(0, 249)
        Me.PanelMediasubmenu.Name = "PanelMediasubmenu"
        Me.PanelMediasubmenu.Size = New System.Drawing.Size(250, 104)
        Me.PanelMediasubmenu.TabIndex = 5
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnuser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnuser.FlatAppearance.BorderSize = 0
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnuser.Location = New System.Drawing.Point(0, 46)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnuser.Size = New System.Drawing.Size(250, 47)
        Me.btnuser.TabIndex = 1
        Me.btnuser.Text = "Admin Accounts"
        Me.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnclient
        '
        Me.btnclient.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnclient.FlatAppearance.BorderSize = 0
        Me.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclient.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclient.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnclient.Location = New System.Drawing.Point(0, 0)
        Me.btnclient.Name = "btnclient"
        Me.btnclient.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnclient.Size = New System.Drawing.Size(250, 46)
        Me.btnclient.TabIndex = 0
        Me.btnclient.Text = "Client Accounts"
        Me.btnclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclient.UseVisualStyleBackColor = False
        '
        'btnMedia
        '
        Me.btnMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedia.FlatAppearance.BorderSize = 0
        Me.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedia.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedia.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMedia.Location = New System.Drawing.Point(0, 190)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMedia.Size = New System.Drawing.Size(250, 59)
        Me.btnMedia.TabIndex = 4
        Me.btnMedia.Text = "Manage Accounts"
        Me.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datenow)
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.tkrole)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.tkusername)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 554)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 35)
        Me.Panel1.TabIndex = 0
        '
        'datenow
        '
        Me.datenow.AutoSize = True
        Me.datenow.BackColor = System.Drawing.Color.Transparent
        Me.datenow.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datenow.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.datenow.Location = New System.Drawing.Point(370, 9)
        Me.datenow.Name = "datenow"
        Me.datenow.Size = New System.Drawing.Size(60, 17)
        Me.datenow.TabIndex = 16
        Me.datenow.Text = "Monday"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel3.Location = New System.Drawing.Point(289, 9)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(75, 17)
        Me.GunaLabel3.TabIndex = 16
        Me.GunaLabel3.Text = "Date/Time"
        '
        'tkrole
        '
        Me.tkrole.AutoSize = True
        Me.tkrole.BackColor = System.Drawing.Color.Transparent
        Me.tkrole.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkrole.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tkrole.Location = New System.Drawing.Point(723, 9)
        Me.tkrole.Name = "tkrole"
        Me.tkrole.Size = New System.Drawing.Size(50, 17)
        Me.tkrole.TabIndex = 16
        Me.tkrole.Text = "Admin"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel2.Location = New System.Drawing.Point(618, 9)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(99, 17)
        Me.GunaLabel2.TabIndex = 16
        Me.GunaLabel2.Text = "Account Type:"
        '
        'tkusername
        '
        Me.tkusername.AutoSize = True
        Me.tkusername.BackColor = System.Drawing.Color.Transparent
        Me.tkusername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkusername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tkusername.Location = New System.Drawing.Point(105, 9)
        Me.tkusername.Name = "tkusername"
        Me.tkusername.Size = New System.Drawing.Size(70, 17)
        Me.tkusername.TabIndex = 16
        Me.tkusername.Text = "John Doe"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(75, 17)
        Me.GunaLabel1.TabIndex = 16
        Me.GunaLabel1.Text = "Username:"
        '
        'mainform
        '
        Me.mainform.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.mainform.Controls.Add(Me.FlowLayoutPanel1)
        Me.mainform.Controls.Add(Me.GunaLabel4)
        Me.mainform.Controls.Add(Me.Panel1)
        Me.mainform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainform.Location = New System.Drawing.Point(250, 0)
        Me.mainform.Name = "mainform"
        Me.mainform.Size = New System.Drawing.Size(843, 589)
        Me.mainform.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2ShadowPanel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(43, 172)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(753, 134)
        Me.FlowLayoutPanel1.TabIndex = 41
        '
        'Guna2ShadowPanel5
        '
        Me.Guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel5.Controls.Add(Me.Guna2GradientPanel1)
        Me.Guna2ShadowPanel5.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel5.Location = New System.Drawing.Point(3, 3)
        Me.Guna2ShadowPanel5.Name = "Guna2ShadowPanel5"
        Me.Guna2ShadowPanel5.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel5.Size = New System.Drawing.Size(279, 127)
        Me.Guna2ShadowPanel5.TabIndex = 9
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.LabelaccCount)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.ButtonStartElection)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(5, 5)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(269, 119)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'LabelaccCount
        '
        Me.LabelaccCount.AutoSize = True
        Me.LabelaccCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelaccCount.ForeColor = System.Drawing.Color.White
        Me.LabelaccCount.Location = New System.Drawing.Point(20, 7)
        Me.LabelaccCount.Name = "LabelaccCount"
        Me.LabelaccCount.Size = New System.Drawing.Size(28, 32)
        Me.LabelaccCount.TabIndex = 3
        Me.LabelaccCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total No. of Client"
        '
        'ButtonStartElection
        '
        Me.ButtonStartElection.Animated = True
        Me.ButtonStartElection.CheckedState.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.CustomImages.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonStartElection.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonStartElection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonStartElection.ForeColor = System.Drawing.Color.White
        Me.ButtonStartElection.HoverState.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.Location = New System.Drawing.Point(0, 87)
        Me.ButtonStartElection.Name = "ButtonStartElection"
        Me.ButtonStartElection.ShadowDecoration.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.Size = New System.Drawing.Size(269, 32)
        Me.ButtonStartElection.TabIndex = 1
        Me.ButtonStartElection.Text = "More Info"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(288, 3)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(279, 127)
        Me.Guna2ShadowPanel1.TabIndex = 10
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.LabeladminCount)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(5, 5)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(269, 119)
        Me.Guna2GradientPanel2.TabIndex = 0
        '
        'LabeladminCount
        '
        Me.LabeladminCount.AutoSize = True
        Me.LabeladminCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabeladminCount.ForeColor = System.Drawing.Color.White
        Me.LabeladminCount.Location = New System.Drawing.Point(20, 7)
        Me.LabeladminCount.Name = "LabeladminCount"
        Me.LabeladminCount.Size = New System.Drawing.Size(28, 32)
        Me.LabeladminCount.TabIndex = 3
        Me.LabeladminCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total No. of Admin"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(0, 87)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(269, 32)
        Me.Guna2GradientButton1.TabIndex = 1
        Me.Guna2GradientButton1.Text = "More Info"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel4.Location = New System.Drawing.Point(37, 36)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(187, 51)
        Me.GunaLabel4.TabIndex = 40
        Me.GunaLabel4.Text = "Dashboard"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1093, 589)
        Me.Controls.Add(Me.mainform)
        Me.Controls.Add(Me.Panelsidemenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "c"
        Me.Panelsidemenu.ResumeLayout(False)
        Me.PanelMediasubmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mainform.ResumeLayout(False)
        Me.mainform.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel5.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panelsidemenu As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Panellogo As Panel
    Friend WithEvents mainform As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datenow As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tkrole As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tkusername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2ShadowPanel5 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents LabelaccCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonStartElection As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents LabeladminCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PanelMediasubmenu As Panel
    Friend WithEvents btnuser As Button
    Friend WithEvents btnclient As Button
    Friend WithEvents btnMedia As Button
End Class
