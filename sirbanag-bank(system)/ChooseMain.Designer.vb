<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseMain
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
        Me.btnEnter = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.AnimationHoverSpeed = 0.07!
        Me.btnEnter.AnimationSpeed = 0.03!
        Me.btnEnter.BackColor = System.Drawing.Color.Transparent
        Me.btnEnter.BaseColor = System.Drawing.Color.Transparent
        Me.btnEnter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnEnter.BorderSize = 2
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnter.FocusedColor = System.Drawing.Color.Transparent
        Me.btnEnter.Font = New System.Drawing.Font("Chakra Petch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEnter.Image = Nothing
        Me.btnEnter.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnter.Location = New System.Drawing.Point(76, 55)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnEnter.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnEnter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnter.OnHoverImage = Nothing
        Me.btnEnter.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnEnter.OnPressedDepth = 25
        Me.btnEnter.Radius = 21
        Me.btnEnter.Size = New System.Drawing.Size(302, 347)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "User login"
        Me.btnEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Transparent
        Me.GunaButton1.Font = New System.Drawing.Font("Chakra Petch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(425, 55)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaButton1.OnPressedDepth = 25
        Me.GunaButton1.Radius = 21
        Me.GunaButton1.Size = New System.Drawing.Size(302, 347)
        Me.GunaButton1.TabIndex = 6
        Me.GunaButton1.Text = "Client Login"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 21
        Me.GunaElipse1.TargetControl = Me
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.IPT_31A3_REYES.My.Resources.Resources.ekis
        Me.PictureBox3.Location = New System.Drawing.Point(752, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'ChooseMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 482)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.btnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChooseMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChooseMain"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnter As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PictureBox3 As PictureBox
End Class
