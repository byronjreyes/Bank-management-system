<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.labelz = New System.Windows.Forms.Label()
        Me.loginlabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtStudentNumber = New Guna.UI.WinForms.GunaTextBox()
        Me.txtStudentName = New Guna.UI.WinForms.GunaTextBox()
        Me.cretacc = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisplay.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(99, 275)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(182, 32)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(142, 416)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(84, 32)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'labelz
        '
        Me.labelz.AutoSize = True
        Me.labelz.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelz.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.labelz.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelz.ForeColor = System.Drawing.Color.White
        Me.labelz.Location = New System.Drawing.Point(79, 337)
        Me.labelz.Name = "labelz"
        Me.labelz.Size = New System.Drawing.Size(147, 17)
        Me.labelz.TabIndex = 0
        Me.labelz.Text = "Don't have Account?"
        '
        'loginlabel
        '
        Me.loginlabel.AutoSize = True
        Me.loginlabel.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlabel.ForeColor = System.Drawing.Color.White
        Me.loginlabel.Location = New System.Drawing.Point(117, 37)
        Me.loginlabel.Name = "loginlabel"
        Me.loginlabel.Size = New System.Drawing.Size(109, 42)
        Me.loginlabel.TabIndex = 0
        Me.loginlabel.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.txtStudentNumber)
        Me.Panel1.Controls.Add(Me.txtStudentName)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.loginlabel)
        Me.Panel1.Controls.Add(Me.cretacc)
        Me.Panel1.Controls.Add(Me.labelz)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 460)
        Me.Panel1.TabIndex = 5
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentNumber.BaseColor = System.Drawing.Color.White
        Me.txtStudentNumber.BorderColor = System.Drawing.Color.Silver
        Me.txtStudentNumber.BorderSize = 0
        Me.txtStudentNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentNumber.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStudentNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStudentNumber.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumber.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtStudentNumber.Location = New System.Drawing.Point(86, 138)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentNumber.Radius = 10
        Me.txtStudentNumber.SelectedText = ""
        Me.txtStudentNumber.Size = New System.Drawing.Size(220, 31)
        Me.txtStudentNumber.TabIndex = 1
        Me.txtStudentNumber.Text = "Student Number"
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentName.BaseColor = System.Drawing.Color.White
        Me.txtStudentName.BorderColor = System.Drawing.Color.Silver
        Me.txtStudentName.BorderSize = 0
        Me.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStudentName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStudentName.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtStudentName.Location = New System.Drawing.Point(86, 200)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentName.Radius = 10
        Me.txtStudentName.SelectedText = ""
        Me.txtStudentName.Size = New System.Drawing.Size(220, 30)
        Me.txtStudentName.TabIndex = 2
        Me.txtStudentName.Text = "Student Name"
        '
        'cretacc
        '
        Me.cretacc.AutoSize = True
        Me.cretacc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cretacc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cretacc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cretacc.ForeColor = System.Drawing.Color.BurlyWood
        Me.cretacc.Location = New System.Drawing.Point(222, 337)
        Me.cretacc.Name = "cretacc"
        Me.cretacc.Size = New System.Drawing.Size(84, 17)
        Me.cretacc.TabIndex = 0
        Me.cretacc.Text = "Singup now"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.IPT_31A3_REYES.My.Resources.Resources.ekis
        Me.PictureBox3.Location = New System.Drawing.Point(319, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.IPT_31A3_REYES.My.Resources.Resources.idnumber
        Me.PictureBox2.Location = New System.Drawing.Point(34, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.IPT_31A3_REYES.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(34, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(357, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplay As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents labelz As Label
    Friend WithEvents loginlabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cretacc As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtStudentName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtStudentNumber As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
