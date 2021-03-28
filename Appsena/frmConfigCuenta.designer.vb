<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfigCuenta
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtDocid = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNombres = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidos = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelMovil = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpExpedicion = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRepetirContra = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chbVerContraseña = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.btnagregarfoto = New Guna.UI.WinForms.GunaButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ptbFotoAdmin = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.ptbFotoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(67, 145)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(187, 19)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Número de Documento "
        '
        'txtDocid
        '
        Me.txtDocid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDocid.BackColor = System.Drawing.Color.Transparent
        Me.txtDocid.BaseColor = System.Drawing.Color.White
        Me.txtDocid.BorderColor = System.Drawing.Color.Silver
        Me.txtDocid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDocid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDocid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDocid.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocid.Location = New System.Drawing.Point(71, 167)
        Me.txtDocid.Name = "txtDocid"
        Me.txtDocid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocid.Radius = 10
        Me.txtDocid.Size = New System.Drawing.Size(234, 31)
        Me.txtDocid.TabIndex = 2
        Me.txtDocid.Tag = "3"
        Me.ToolTip1.SetToolTip(Me.txtDocid, "Número de documento")
        '
        'txtNombres
        '
        Me.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombres.BackColor = System.Drawing.Color.Transparent
        Me.txtNombres.BaseColor = System.Drawing.Color.White
        Me.txtNombres.BorderColor = System.Drawing.Color.Silver
        Me.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombres.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNombres.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtNombres.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNombres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(373, 93)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombres.Radius = 10
        Me.txtNombres.Size = New System.Drawing.Size(234, 31)
        Me.txtNombres.TabIndex = 4
        Me.txtNombres.Tag = "2"
        Me.ToolTip1.SetToolTip(Me.txtNombres, "Nnombres")
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'txtApellidos
        '
        Me.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtApellidos.BackColor = System.Drawing.Color.Transparent
        Me.txtApellidos.BaseColor = System.Drawing.Color.White
        Me.txtApellidos.BorderColor = System.Drawing.Color.Silver
        Me.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtApellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtApellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtApellidos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(373, 167)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidos.Radius = 10
        Me.txtApellidos.Size = New System.Drawing.Size(234, 31)
        Me.txtApellidos.TabIndex = 5
        Me.txtApellidos.Tag = "4"
        Me.ToolTip1.SetToolTip(Me.txtApellidos, "Apellidos")
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(369, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BaseColor = System.Drawing.Color.White
        Me.txtEmail.BorderColor = System.Drawing.Color.Silver
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmail.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(373, 248)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.Radius = 10
        Me.txtEmail.Size = New System.Drawing.Size(234, 31)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Tag = "6"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(369, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Correo Electrónico"
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTelMovil.BackColor = System.Drawing.Color.Transparent
        Me.txtTelMovil.BaseColor = System.Drawing.Color.White
        Me.txtTelMovil.BorderColor = System.Drawing.Color.Silver
        Me.txtTelMovil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelMovil.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTelMovil.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtTelMovil.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTelMovil.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelMovil.Location = New System.Drawing.Point(373, 320)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelMovil.Radius = 10
        Me.txtTelMovil.Size = New System.Drawing.Size(234, 31)
        Me.txtTelMovil.TabIndex = 7
        Me.txtTelMovil.Tag = "8"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(369, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teléfono Móvil"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbTipoDocumento.BackColor = System.Drawing.Color.Transparent
        Me.cmbTipoDocumento.BaseColor = System.Drawing.Color.White
        Me.cmbTipoDocumento.BorderColor = System.Drawing.Color.Silver
        Me.cmbTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(71, 94)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cmbTipoDocumento.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbTipoDocumento.Radius = 10
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(234, 28)
        Me.cmbTipoDocumento.TabIndex = 1
        Me.cmbTipoDocumento.Tag = "1"
        Me.cmbTipoDocumento.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.ToolTip1.SetToolTip(Me.cmbTipoDocumento, "Tipo de documento")
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de Documento "
        '
        'dtpExpedicion
        '
        Me.dtpExpedicion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpExpedicion.BackColor = System.Drawing.Color.Transparent
        Me.dtpExpedicion.BaseColor = System.Drawing.Color.White
        Me.dtpExpedicion.BorderColor = System.Drawing.Color.Silver
        Me.dtpExpedicion.CustomFormat = "d MMMM yyyy"
        Me.dtpExpedicion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpExpedicion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpExpedicion.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpedicion.ForeColor = System.Drawing.Color.Black
        Me.dtpExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpedicion.Location = New System.Drawing.Point(71, 248)
        Me.dtpExpedicion.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpExpedicion.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpExpedicion.Name = "dtpExpedicion"
        Me.dtpExpedicion.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpExpedicion.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpExpedicion.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpExpedicion.OnPressedColor = System.Drawing.Color.Black
        Me.dtpExpedicion.Radius = 10
        Me.dtpExpedicion.Size = New System.Drawing.Size(234, 30)
        Me.dtpExpedicion.TabIndex = 3
        Me.dtpExpedicion.Tag = "5"
        Me.dtpExpedicion.Text = "25 noviembre 2019"
        Me.ToolTip1.SetToolTip(Me.dtpExpedicion, "Fecha de expedición del documento")
        Me.dtpExpedicion.Value = New Date(2019, 11, 25, 12, 48, 49, 763)
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha de Expedición"
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContraseña.BackColor = System.Drawing.Color.Transparent
        Me.txtContraseña.BaseColor = System.Drawing.Color.White
        Me.txtContraseña.BorderColor = System.Drawing.Color.Silver
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.txtContraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtContraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtContraseña.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(71, 320)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseña.Radius = 10
        Me.txtContraseña.Size = New System.Drawing.Size(234, 31)
        Me.txtContraseña.TabIndex = 8
        Me.txtContraseña.Tag = "7"
        Me.ToolTip1.SetToolTip(Me.txtContraseña, "Contraseña")
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contraseña"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(678, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Foto del Administrador"
        '
        'txtRepetirContra
        '
        Me.txtRepetirContra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRepetirContra.BackColor = System.Drawing.Color.Transparent
        Me.txtRepetirContra.BaseColor = System.Drawing.Color.White
        Me.txtRepetirContra.BorderColor = System.Drawing.Color.Silver
        Me.txtRepetirContra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRepetirContra.FocusedBaseColor = System.Drawing.Color.White
        Me.txtRepetirContra.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtRepetirContra.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtRepetirContra.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepetirContra.Location = New System.Drawing.Point(71, 392)
        Me.txtRepetirContra.Name = "txtRepetirContra"
        Me.txtRepetirContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtRepetirContra.Radius = 10
        Me.txtRepetirContra.Size = New System.Drawing.Size(234, 31)
        Me.txtRepetirContra.TabIndex = 9
        Me.txtRepetirContra.Tag = "9"
        Me.ToolTip1.SetToolTip(Me.txtRepetirContra, "Confirmar contraseña")
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Confirmar Contraseña"
        '
        'chbVerContraseña
        '
        Me.chbVerContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbVerContraseña.Appearance = System.Windows.Forms.Appearance.Button
        Me.chbVerContraseña.AutoSize = True
        Me.chbVerContraseña.BackColor = System.Drawing.Color.Transparent
        Me.chbVerContraseña.FlatAppearance.BorderSize = 0
        Me.chbVerContraseña.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.chbVerContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.chbVerContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.chbVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVerContraseña.Image = Global.Appsena.My.Resources.Resources.icons8_eye_32
        Me.chbVerContraseña.Location = New System.Drawing.Point(306, 316)
        Me.chbVerContraseña.Name = "chbVerContraseña"
        Me.chbVerContraseña.Size = New System.Drawing.Size(38, 38)
        Me.chbVerContraseña.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.chbVerContraseña, "Ver Contraseña")
        Me.chbVerContraseña.UseVisualStyleBackColor = False
        Me.chbVerContraseña.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Transparent
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(398, 388)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 10
        Me.btnGuardar.Size = New System.Drawing.Size(180, 35)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar Cambios")
        '
        'btnagregarfoto
        '
        Me.btnagregarfoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnagregarfoto.AnimationHoverSpeed = 0.07!
        Me.btnagregarfoto.AnimationSpeed = 0.03!
        Me.btnagregarfoto.BackColor = System.Drawing.Color.Transparent
        Me.btnagregarfoto.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnagregarfoto.BorderColor = System.Drawing.Color.Transparent
        Me.btnagregarfoto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnagregarfoto.FocusedColor = System.Drawing.Color.Empty
        Me.btnagregarfoto.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarfoto.ForeColor = System.Drawing.Color.White
        Me.btnagregarfoto.Image = Global.Appsena.My.Resources.Resources.icons8_camera_blanco_64
        Me.btnagregarfoto.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnagregarfoto.Location = New System.Drawing.Point(677, 298)
        Me.btnagregarfoto.Name = "btnagregarfoto"
        Me.btnagregarfoto.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregarfoto.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnagregarfoto.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregarfoto.OnHoverImage = Nothing
        Me.btnagregarfoto.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregarfoto.Radius = 10
        Me.btnagregarfoto.Size = New System.Drawing.Size(180, 29)
        Me.btnagregarfoto.TabIndex = 10
        Me.btnagregarfoto.Text = "Agregar imagen"
        Me.ToolTip1.SetToolTip(Me.btnagregarfoto, "Tomar una Foto")
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(220, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(246, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(223, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(155, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(232, 373)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "*"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(443, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 17)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "*"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(446, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 17)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "*"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(513, 230)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 17)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "*"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(485, 300)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "*"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbFotoAdmin
        '
        Me.ptbFotoAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbFotoAdmin.BackColor = System.Drawing.Color.Transparent
        Me.ptbFotoAdmin.BaseColor = System.Drawing.Color.LightGray
        Me.ptbFotoAdmin.Location = New System.Drawing.Point(677, 109)
        Me.ptbFotoAdmin.Name = "ptbFotoAdmin"
        Me.ptbFotoAdmin.Size = New System.Drawing.Size(180, 180)
        Me.ptbFotoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotoAdmin.TabIndex = 16
        Me.ptbFotoAdmin.TabStop = False
        Me.ptbFotoAdmin.UseTransfarantBackground = False
        '
        'frmConfigCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(964, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chbVerContraseña)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtRepetirContra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnagregarfoto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ptbFotoAdmin)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpExpedicion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTipoDocumento)
        Me.Controls.Add(Me.txtTelMovil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDocid)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmConfigCuenta"
        Me.Text = "Configuración de la cuenta"
        CType(Me.ptbFotoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtDocid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNombres As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellidos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelMovil As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoDocumento As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpExpedicion As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ptbFotoAdmin As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnagregarfoto As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtRepetirContra As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents chbVerContraseña As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
