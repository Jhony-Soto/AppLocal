<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_registrarme
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrarme))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdocumento = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellidos = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombres = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcontraseña1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmovil = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontraseña2 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.checbox = New Guna.UI.WinForms.GunaImageCheckBox()
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.btnimagen = New Guna.UI.WinForms.GunaButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbtipo_documento = New Guna.UI.WinForms.GunaComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.fecha_expedicion = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.ptbFotoAdmin = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.dialog_selecionar_foto = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.ptbFotoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.Panel4)
        Me.GunaPanel1.Controls.Add(Me.GunaCircleButton1)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(971, 73)
        Me.GunaPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(3, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(965, 5)
        Me.Panel4.TabIndex = 38
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(12, 14)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(40, 40)
        Me.GunaCircleButton1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.GunaCircleButton1, "Volver ")
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Zurich", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(377, 28)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(261, 22)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Registro de administrador"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento"
        '
        'txtdocumento
        '
        Me.txtdocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdocumento.BackColor = System.Drawing.Color.Transparent
        Me.txtdocumento.BaseColor = System.Drawing.Color.White
        Me.txtdocumento.BorderColor = System.Drawing.Color.Silver
        Me.txtdocumento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdocumento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtdocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocumento.Location = New System.Drawing.Point(35, 199)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdocumento.Radius = 10
        Me.txtdocumento.Size = New System.Drawing.Size(230, 31)
        Me.txtdocumento.TabIndex = 2
        Me.txtdocumento.Tag = "3"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(414, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres"
        '
        'txtapellidos
        '
        Me.txtapellidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapellidos.BackColor = System.Drawing.Color.Transparent
        Me.txtapellidos.BaseColor = System.Drawing.Color.White
        Me.txtapellidos.BorderColor = System.Drawing.Color.Silver
        Me.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtapellidos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtapellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtapellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtapellidos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidos.Location = New System.Drawing.Point(332, 199)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtapellidos.Radius = 10
        Me.txtapellidos.Size = New System.Drawing.Size(230, 31)
        Me.txtapellidos.TabIndex = 6
        Me.txtapellidos.Tag = "4"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(428, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "E-mail"
        '
        'txtnombres
        '
        Me.txtnombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnombres.BackColor = System.Drawing.Color.Transparent
        Me.txtnombres.BaseColor = System.Drawing.Color.White
        Me.txtnombres.BorderColor = System.Drawing.Color.Silver
        Me.txtnombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombres.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnombres.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnombres.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnombres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombres.Location = New System.Drawing.Point(332, 120)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombres.Radius = 10
        Me.txtnombres.Size = New System.Drawing.Size(230, 31)
        Me.txtnombres.TabIndex = 8
        Me.txtnombres.Tag = "2"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de expedición" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " del documento"
        '
        'txtemail
        '
        Me.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtemail.BackColor = System.Drawing.Color.Transparent
        Me.txtemail.BaseColor = System.Drawing.Color.White
        Me.txtemail.BorderColor = System.Drawing.Color.Silver
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtemail.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(332, 310)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.Radius = 10
        Me.txtemail.Size = New System.Drawing.Size(230, 31)
        Me.txtemail.TabIndex = 10
        Me.txtemail.Tag = "6"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellidos"
        '
        'txtcontraseña1
        '
        Me.txtcontraseña1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcontraseña1.BackColor = System.Drawing.Color.Transparent
        Me.txtcontraseña1.BaseColor = System.Drawing.Color.White
        Me.txtcontraseña1.BorderColor = System.Drawing.Color.Silver
        Me.txtcontraseña1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontraseña1.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcontraseña1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtcontraseña1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcontraseña1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña1.Location = New System.Drawing.Point(35, 389)
        Me.txtcontraseña1.Name = "txtcontraseña1"
        Me.txtcontraseña1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtcontraseña1.Radius = 10
        Me.txtcontraseña1.Size = New System.Drawing.Size(230, 32)
        Me.txtcontraseña1.TabIndex = 12
        Me.txtcontraseña1.Tag = "7"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Teléfono móvil"
        '
        'txtmovil
        '
        Me.txtmovil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmovil.BackColor = System.Drawing.Color.Transparent
        Me.txtmovil.BaseColor = System.Drawing.Color.White
        Me.txtmovil.BorderColor = System.Drawing.Color.Silver
        Me.txtmovil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmovil.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmovil.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtmovil.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtmovil.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmovil.Location = New System.Drawing.Point(332, 397)
        Me.txtmovil.Name = "txtmovil"
        Me.txtmovil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmovil.Radius = 10
        Me.txtmovil.Size = New System.Drawing.Size(230, 31)
        Me.txtmovil.TabIndex = 14
        Me.txtmovil.Tag = "8"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Contraseña"
        '
        'txtcontraseña2
        '
        Me.txtcontraseña2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcontraseña2.BackColor = System.Drawing.Color.Transparent
        Me.txtcontraseña2.BaseColor = System.Drawing.Color.White
        Me.txtcontraseña2.BorderColor = System.Drawing.Color.Silver
        Me.txtcontraseña2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontraseña2.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcontraseña2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtcontraseña2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcontraseña2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña2.Location = New System.Drawing.Point(35, 475)
        Me.txtcontraseña2.Name = "txtcontraseña2"
        Me.txtcontraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtcontraseña2.Radius = 10
        Me.txtcontraseña2.Size = New System.Drawing.Size(230, 30)
        Me.txtcontraseña2.TabIndex = 16
        Me.txtcontraseña2.Tag = "9"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Repetir contraseña"
        '
        'checbox
        '
        Me.checbox.BackColor = System.Drawing.Color.Transparent
        Me.checbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checbox.ImageCheckedOff = Global.Appsena.My.Resources.Resources.icons8_eye_32
        Me.checbox.ImageCheckedOn = Global.Appsena.My.Resources.Resources.icons8_eye_32
        Me.checbox.ImageSize = New System.Drawing.Size(20, 20)
        Me.checbox.Location = New System.Drawing.Point(271, 477)
        Me.checbox.Name = "checbox"
        Me.checbox.Size = New System.Drawing.Size(28, 28)
        Me.checbox.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.checbox, "Ver contraseña")
        '
        'btnguardar
        '
        Me.btnguardar.AnimationHoverSpeed = 0.07!
        Me.btnguardar.AnimationSpeed = 0.03!
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnguardar.BorderColor = System.Drawing.Color.Black
        Me.btnguardar.CausesValidation = False
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardar.Location = New System.Drawing.Point(637, 397)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnguardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverImage = Nothing
        Me.btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar.Radius = 10
        Me.btnguardar.Size = New System.Drawing.Size(278, 35)
        Me.btnguardar.TabIndex = 22
        Me.btnguardar.Text = "Guardar datos"
        Me.btnguardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnguardar, "Guardar los datos ")
        '
        'btnimagen
        '
        Me.btnimagen.AnimationHoverSpeed = 0.07!
        Me.btnimagen.AnimationSpeed = 0.03!
        Me.btnimagen.BackColor = System.Drawing.Color.Transparent
        Me.btnimagen.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnimagen.BorderColor = System.Drawing.Color.Black
        Me.btnimagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimagen.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnimagen.FocusedColor = System.Drawing.Color.Empty
        Me.btnimagen.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimagen.ForeColor = System.Drawing.Color.White
        Me.btnimagen.Image = Global.Appsena.My.Resources.Resources.icons8_camera_blanco_64
        Me.btnimagen.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnimagen.Location = New System.Drawing.Point(637, 351)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnimagen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnimagen.OnHoverForeColor = System.Drawing.Color.White
        Me.btnimagen.OnHoverImage = Nothing
        Me.btnimagen.OnPressedColor = System.Drawing.Color.Black
        Me.btnimagen.Radius = 10
        Me.btnimagen.Size = New System.Drawing.Size(278, 35)
        Me.btnimagen.TabIndex = 21
        Me.btnimagen.Text = "Agregar imagen"
        Me.btnimagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnimagen, "Agregar imagen")
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tipo de documento"
        '
        'cmbtipo_documento
        '
        Me.cmbtipo_documento.BackColor = System.Drawing.Color.Transparent
        Me.cmbtipo_documento.BaseColor = System.Drawing.Color.White
        Me.cmbtipo_documento.BorderColor = System.Drawing.Color.Silver
        Me.cmbtipo_documento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo_documento.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtipo_documento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo_documento.ForeColor = System.Drawing.Color.Black
        Me.cmbtipo_documento.FormattingEnabled = True
        Me.cmbtipo_documento.Location = New System.Drawing.Point(35, 120)
        Me.cmbtipo_documento.Name = "cmbtipo_documento"
        Me.cmbtipo_documento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbtipo_documento.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtipo_documento.Radius = 10
        Me.cmbtipo_documento.Size = New System.Drawing.Size(230, 28)
        Me.cmbtipo_documento.TabIndex = 25
        Me.cmbtipo_documento.Tag = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(206, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(230, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 24)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(241, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 24)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(497, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 24)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(498, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 24)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(487, 287)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 24)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(502, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(202, 366)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(229, 452)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 24)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "*"
        '
        'fecha_expedicion
        '
        Me.fecha_expedicion.BackColor = System.Drawing.Color.Transparent
        Me.fecha_expedicion.BaseColor = System.Drawing.Color.White
        Me.fecha_expedicion.BorderColor = System.Drawing.Color.Silver
        Me.fecha_expedicion.CustomFormat = Nothing
        Me.fecha_expedicion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fecha_expedicion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fecha_expedicion.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_expedicion.ForeColor = System.Drawing.Color.Black
        Me.fecha_expedicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_expedicion.Location = New System.Drawing.Point(35, 310)
        Me.fecha_expedicion.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fecha_expedicion.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fecha_expedicion.Name = "fecha_expedicion"
        Me.fecha_expedicion.OnHoverBaseColor = System.Drawing.Color.White
        Me.fecha_expedicion.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fecha_expedicion.OnHoverForeColor = System.Drawing.Color.Black
        Me.fecha_expedicion.OnPressedColor = System.Drawing.Color.Black
        Me.fecha_expedicion.Radius = 10
        Me.fecha_expedicion.Size = New System.Drawing.Size(230, 31)
        Me.fecha_expedicion.TabIndex = 35
        Me.fecha_expedicion.Tag = "5"
        Me.fecha_expedicion.Text = "25/11/2019"
        Me.fecha_expedicion.Value = New Date(2019, 11, 25, 15, 34, 2, 508)
        '
        'ptbFotoAdmin
        '
        Me.ptbFotoAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbFotoAdmin.BaseColor = System.Drawing.Color.White
        Me.ptbFotoAdmin.Location = New System.Drawing.Point(664, 124)
        Me.ptbFotoAdmin.Name = "ptbFotoAdmin"
        Me.ptbFotoAdmin.Size = New System.Drawing.Size(224, 224)
        Me.ptbFotoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotoAdmin.TabIndex = 20
        Me.ptbFotoAdmin.TabStop = False
        Me.ptbFotoAdmin.UseTransfarantBackground = False
        '
        'dialog_selecionar_foto
        '
        Me.dialog_selecionar_foto.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(966, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 577)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(3, 578)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(965, 5)
        Me.Panel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 584)
        Me.Panel3.TabIndex = 38
        '
        'frm_registrarme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(971, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.checbox)
        Me.Controls.Add(Me.fecha_expedicion)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbtipo_documento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnimagen)
        Me.Controls.Add(Me.ptbFotoAdmin)
        Me.Controls.Add(Me.txtcontraseña2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmovil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcontraseña1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_registrarme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de administrador"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.ptbFotoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdocumento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtapellidos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombres As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcontraseña1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmovil As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcontraseña2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ptbFotoAdmin As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnimagen As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbtipo_documento As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents fecha_expedicion As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents checbox As Guna.UI.WinForms.GunaImageCheckBox
    Friend WithEvents dialog_selecionar_foto As OpenFileDialog
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
