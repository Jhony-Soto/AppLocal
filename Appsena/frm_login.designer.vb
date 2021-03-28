<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.progresbar = New Guna.UI.WinForms.GunaProgressBar()
        Me.checbox = New Guna.UI.WinForms.GunaImageCheckBox()
        Me.btnregistrarme = New Guna.UI.WinForms.GunaButton()
        Me.lblolvidocontraseña = New System.Windows.Forms.LinkLabel()
        Me.btningresar = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusuario = New Guna.UI.WinForms.GunaLineTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaShadowPanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'btncerrar
        '
        Me.btncerrar.AnimationHoverSpeed = 0.07!
        Me.btncerrar.AnimationSpeed = 0.03!
        Me.btncerrar.BackColor = System.Drawing.Color.Transparent
        Me.btncerrar.BaseColor = System.Drawing.Color.DarkOrange
        Me.btncerrar.BorderColor = System.Drawing.Color.Black
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncerrar.FocusedColor = System.Drawing.Color.Empty
        Me.btncerrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Image = Nothing
        Me.btncerrar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btncerrar.Location = New System.Drawing.Point(408, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncerrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncerrar.OnHoverImage = Nothing
        Me.btncerrar.OnPressedColor = System.Drawing.Color.Black
        Me.btncerrar.Size = New System.Drawing.Size(30, 30)
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.progresbar)
        Me.GunaShadowPanel1.Controls.Add(Me.checbox)
        Me.GunaShadowPanel1.Controls.Add(Me.btnregistrarme)
        Me.GunaShadowPanel1.Controls.Add(Me.lblolvidocontraseña)
        Me.GunaShadowPanel1.Controls.Add(Me.btningresar)
        Me.GunaShadowPanel1.Controls.Add(Me.Label2)
        Me.GunaShadowPanel1.Controls.Add(Me.txtpassword)
        Me.GunaShadowPanel1.Controls.Add(Me.Label1)
        Me.GunaShadowPanel1.Controls.Add(Me.txtusuario)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(68, 260)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowShift = 10
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(316, 405)
        Me.GunaShadowPanel1.TabIndex = 1
        '
        'progresbar
        '
        Me.progresbar.BorderColor = System.Drawing.Color.Black
        Me.progresbar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.progresbar.IdleColor = System.Drawing.Color.Gainsboro
        Me.progresbar.Location = New System.Drawing.Point(13, 390)
        Me.progresbar.Name = "progresbar"
        Me.progresbar.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progresbar.ProgressMinColor = System.Drawing.Color.Lime
        Me.progresbar.Size = New System.Drawing.Size(290, 5)
        Me.progresbar.TabIndex = 38
        '
        'checbox
        '
        Me.checbox.BackColor = System.Drawing.Color.Transparent
        Me.checbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checbox.ImageCheckedOff = Global.Appsena.My.Resources.Resources.icons8_eye_32
        Me.checbox.ImageCheckedOn = Global.Appsena.My.Resources.Resources.icons8_eye_32
        Me.checbox.ImageSize = New System.Drawing.Size(20, 20)
        Me.checbox.Location = New System.Drawing.Point(255, 169)
        Me.checbox.Name = "checbox"
        Me.checbox.Size = New System.Drawing.Size(28, 28)
        Me.checbox.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.checbox, "Ver contraseña")
        Me.checbox.Visible = False
        '
        'btnregistrarme
        '
        Me.btnregistrarme.AnimationHoverSpeed = 0.07!
        Me.btnregistrarme.AnimationSpeed = 0.03!
        Me.btnregistrarme.BackColor = System.Drawing.Color.Transparent
        Me.btnregistrarme.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnregistrarme.BorderColor = System.Drawing.Color.Black
        Me.btnregistrarme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistrarme.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregistrarme.FocusedColor = System.Drawing.Color.Empty
        Me.btnregistrarme.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrarme.ForeColor = System.Drawing.Color.White
        Me.btnregistrarme.Image = Nothing
        Me.btnregistrarme.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnregistrarme.Location = New System.Drawing.Point(94, 335)
        Me.btnregistrarme.Name = "btnregistrarme"
        Me.btnregistrarme.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistrarme.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregistrarme.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregistrarme.OnHoverImage = Nothing
        Me.btnregistrarme.OnPressedColor = System.Drawing.Color.Black
        Me.btnregistrarme.Radius = 15
        Me.btnregistrarme.Size = New System.Drawing.Size(116, 35)
        Me.btnregistrarme.TabIndex = 6
        Me.btnregistrarme.Text = "Registrarme"
        Me.btnregistrarme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnregistrarme, "Registrarme")
        '
        'lblolvidocontraseña
        '
        Me.lblolvidocontraseña.AutoSize = True
        Me.lblolvidocontraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblolvidocontraseña.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblolvidocontraseña.Location = New System.Drawing.Point(71, 295)
        Me.lblolvidocontraseña.Name = "lblolvidocontraseña"
        Me.lblolvidocontraseña.Size = New System.Drawing.Size(169, 18)
        Me.lblolvidocontraseña.TabIndex = 5
        Me.lblolvidocontraseña.TabStop = True
        Me.lblolvidocontraseña.Text = "¿Olvidó su contraseña?"
        Me.ToolTip1.SetToolTip(Me.lblolvidocontraseña, "Recuperar contraseña")
        '
        'btningresar
        '
        Me.btningresar.AnimationHoverSpeed = 0.07!
        Me.btningresar.AnimationSpeed = 0.03!
        Me.btningresar.BackColor = System.Drawing.Color.Transparent
        Me.btningresar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btningresar.BorderColor = System.Drawing.Color.Black
        Me.btningresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btningresar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btningresar.FocusedColor = System.Drawing.Color.Empty
        Me.btningresar.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.ForeColor = System.Drawing.Color.White
        Me.btningresar.Image = Nothing
        Me.btningresar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btningresar.Location = New System.Drawing.Point(43, 235)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btningresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btningresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btningresar.OnHoverImage = Nothing
        Me.btningresar.OnPressedColor = System.Drawing.Color.Black
        Me.btningresar.Radius = 20
        Me.btningresar.Size = New System.Drawing.Size(226, 42)
        Me.btningresar.TabIndex = 4
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btningresar, "Ingresar al sistema")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtpassword.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.LineColor = System.Drawing.Color.Gainsboro
        Me.txtpassword.Location = New System.Drawing.Point(43, 171)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Size = New System.Drawing.Size(227, 30)
        Me.txtpassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento"
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.Color.White
        Me.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtusuario.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.LineColor = System.Drawing.Color.Gainsboro
        Me.txtusuario.Location = New System.Drawing.Point(42, 88)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusuario.Size = New System.Drawing.Size(227, 30)
        Me.txtusuario.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.Appsena.My.Resources.Resources.logoSenaradial
        Me.GunaCirclePictureBox1.InitialImage = Global.Appsena.My.Resources.Resources.logoSenaradial
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(149, 113)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(155, 155)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 2
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'frm_login
        '
        Me.AcceptButton = Me.btningresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Appsena.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(450, 688)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.btncerrar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btningresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusuario As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnregistrarme As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblolvidocontraseña As LinkLabel
    Friend WithEvents checbox As Guna.UI.WinForms.GunaImageCheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents progresbar As Guna.UI.WinForms.GunaProgressBar
End Class
