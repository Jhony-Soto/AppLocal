<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_backup
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.radio_semestral = New Guna.UI.WinForms.GunaRadioButton()
        Me.radio_trimestral = New Guna.UI.WinForms.GunaRadioButton()
        Me.radio_mensual = New Guna.UI.WinForms.GunaRadioButton()
        Me.radio_semanal = New Guna.UI.WinForms.GunaRadioButton()
        Me.btn_archivo = New Guna.UI.WinForms.GunaButton()
        Me.txtbackup = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.lbl_inicio = New System.Windows.Forms.Label()
        Me.lblestado2 = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblestado1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_semana = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Viernes = New System.Windows.Forms.Label()
        Me.Jueves = New System.Windows.Forms.Label()
        Me.Miercoles = New System.Windows.Forms.Label()
        Me.Martes = New System.Windows.Forms.Label()
        Me.Lunes = New System.Windows.Forms.Label()
        Me.radio_viernes = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.radio_jueves = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.radio_miercoles = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.radio_martes = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.radio_lunes = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.group_manual = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_generar_copia = New Guna.UI.WinForms.GunaButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.pnl_semana.SuspendLayout()
        Me.group_manual.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaShadowPanel1)
        Me.GunaGroupBox1.Controls.Add(Me.btn_archivo)
        Me.GunaGroupBox1.Controls.Add(Me.txtbackup)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.btnguardar)
        Me.GunaGroupBox1.Controls.Add(Me.lbl_inicio)
        Me.GunaGroupBox1.Controls.Add(Me.lblestado2)
        Me.GunaGroupBox1.Controls.Add(Me.lbl_dia)
        Me.GunaGroupBox1.Controls.Add(Me.lbl_fecha)
        Me.GunaGroupBox1.Controls.Add(Me.Panel1)
        Me.GunaGroupBox1.Controls.Add(Me.lblestado1)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.pnl_semana)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(780, 464)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "Fecha en la cual el  sistema hará la copia de seguridad de la base de datos."
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.radio_semestral)
        Me.GunaShadowPanel1.Controls.Add(Me.radio_trimestral)
        Me.GunaShadowPanel1.Controls.Add(Me.radio_mensual)
        Me.GunaShadowPanel1.Controls.Add(Me.radio_semanal)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(15, 72)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 10
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(750, 73)
        Me.GunaShadowPanel1.TabIndex = 38
        '
        'radio_semestral
        '
        Me.radio_semestral.BaseColor = System.Drawing.SystemColors.Control
        Me.radio_semestral.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_semestral.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.radio_semestral.FillColor = System.Drawing.Color.White
        Me.radio_semestral.Location = New System.Drawing.Point(585, 24)
        Me.radio_semestral.Name = "radio_semestral"
        Me.radio_semestral.Size = New System.Drawing.Size(81, 20)
        Me.radio_semestral.TabIndex = 12
        Me.radio_semestral.Tag = "4"
        Me.radio_semestral.Text = "Semestral"
        '
        'radio_trimestral
        '
        Me.radio_trimestral.BaseColor = System.Drawing.SystemColors.Control
        Me.radio_trimestral.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_trimestral.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.radio_trimestral.FillColor = System.Drawing.Color.White
        Me.radio_trimestral.Location = New System.Drawing.Point(397, 24)
        Me.radio_trimestral.Name = "radio_trimestral"
        Me.radio_trimestral.Size = New System.Drawing.Size(80, 20)
        Me.radio_trimestral.TabIndex = 11
        Me.radio_trimestral.Tag = "3"
        Me.radio_trimestral.Text = "Trimestral"
        '
        'radio_mensual
        '
        Me.radio_mensual.BaseColor = System.Drawing.SystemColors.Control
        Me.radio_mensual.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_mensual.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.radio_mensual.FillColor = System.Drawing.Color.White
        Me.radio_mensual.Location = New System.Drawing.Point(203, 24)
        Me.radio_mensual.Name = "radio_mensual"
        Me.radio_mensual.Size = New System.Drawing.Size(73, 20)
        Me.radio_mensual.TabIndex = 10
        Me.radio_mensual.Tag = "2"
        Me.radio_mensual.Text = "Mensual"
        '
        'radio_semanal
        '
        Me.radio_semanal.BaseColor = System.Drawing.SystemColors.Control
        Me.radio_semanal.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_semanal.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.radio_semanal.FillColor = System.Drawing.Color.White
        Me.radio_semanal.Location = New System.Drawing.Point(44, 27)
        Me.radio_semanal.Name = "radio_semanal"
        Me.radio_semanal.Size = New System.Drawing.Size(74, 20)
        Me.radio_semanal.TabIndex = 9
        Me.radio_semanal.Tag = "1"
        Me.radio_semanal.Text = "Semanal"
        '
        'btn_archivo
        '
        Me.btn_archivo.AnimationHoverSpeed = 0.07!
        Me.btn_archivo.AnimationSpeed = 0.03!
        Me.btn_archivo.BackColor = System.Drawing.Color.Transparent
        Me.btn_archivo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_archivo.BorderColor = System.Drawing.Color.Transparent
        Me.btn_archivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_archivo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_archivo.FocusedColor = System.Drawing.Color.Empty
        Me.btn_archivo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_archivo.ForeColor = System.Drawing.Color.White
        Me.btn_archivo.Image = Global.Appsena.My.Resources.Resources.icons8_upload_32
        Me.btn_archivo.ImageSize = New System.Drawing.Size(15, 15)
        Me.btn_archivo.Location = New System.Drawing.Point(305, 361)
        Me.btn_archivo.Name = "btn_archivo"
        Me.btn_archivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_archivo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_archivo.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_archivo.OnHoverImage = Nothing
        Me.btn_archivo.OnPressedColor = System.Drawing.Color.Black
        Me.btn_archivo.Radius = 10
        Me.btn_archivo.Size = New System.Drawing.Size(60, 30)
        Me.btn_archivo.TabIndex = 151
        Me.btn_archivo.Text = "..."
        '
        'txtbackup
        '
        Me.txtbackup.BackColor = System.Drawing.Color.Transparent
        Me.txtbackup.BaseColor = System.Drawing.Color.White
        Me.txtbackup.BorderColor = System.Drawing.Color.Silver
        Me.txtbackup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbackup.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbackup.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtbackup.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbackup.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbackup.Location = New System.Drawing.Point(371, 361)
        Me.txtbackup.Name = "txtbackup"
        Me.txtbackup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbackup.Radius = 10
        Me.txtbackup.Size = New System.Drawing.Size(380, 30)
        Me.txtbackup.TabIndex = 150
        Me.txtbackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 38)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Carpeta de SQL SERVER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para guardar la copia de seguridad."
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.AnimationHoverSpeed = 0.07!
        Me.btnguardar.AnimationSpeed = 0.03!
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnguardar.BorderColor = System.Drawing.Color.Transparent
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = Nothing
        Me.btnguardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardar.Location = New System.Drawing.Point(306, 417)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnguardar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverImage = Nothing
        Me.btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar.Radius = 10
        Me.btnguardar.Size = New System.Drawing.Size(121, 31)
        Me.btnguardar.TabIndex = 148
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_inicio
        '
        Me.lbl_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_inicio.AutoSize = True
        Me.lbl_inicio.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inicio.ForeColor = System.Drawing.Color.Black
        Me.lbl_inicio.Location = New System.Drawing.Point(299, 281)
        Me.lbl_inicio.Name = "lbl_inicio"
        Me.lbl_inicio.Size = New System.Drawing.Size(208, 19)
        Me.lbl_inicio.TabIndex = 49
        Me.lbl_inicio.Text = "A un no ha elegido la fecha."
        '
        'lblestado2
        '
        Me.lblestado2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblestado2.AutoSize = True
        Me.lblestado2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado2.ForeColor = System.Drawing.Color.Black
        Me.lblestado2.Location = New System.Drawing.Point(479, 281)
        Me.lblestado2.Name = "lblestado2"
        Me.lblestado2.Size = New System.Drawing.Size(69, 19)
        Me.lblestado2.TabIndex = 48
        Me.lblestado2.Text = "los días "
        Me.lblestado2.Visible = False
        '
        'lbl_dia
        '
        Me.lbl_dia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.ForeColor = System.Drawing.Color.Black
        Me.lbl_dia.Location = New System.Drawing.Point(554, 281)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(71, 19)
        Me.lbl_dia.TabIndex = 47
        Me.lbl_dia.Text = "viernes"
        Me.lbl_dia.Visible = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecha.Location = New System.Drawing.Point(379, 281)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(80, 19)
        Me.lbl_fecha.TabIndex = 46
        Me.lbl_fecha.Text = "semanal"
        Me.lbl_fecha.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 5)
        Me.Panel1.TabIndex = 45
        '
        'lblestado1
        '
        Me.lblestado1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblestado1.AutoSize = True
        Me.lblestado1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado1.ForeColor = System.Drawing.Color.Black
        Me.lblestado1.Location = New System.Drawing.Point(141, 281)
        Me.lblestado1.Name = "lblestado1"
        Me.lblestado1.Size = New System.Drawing.Size(232, 19)
        Me.lblestado1.TabIndex = 44
        Me.lblestado1.Text = "La copia de seguridad de hará "
        Me.lblestado1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "2. Elija un dia de la semana."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "1. Elija un tipo de fecha."
        '
        'pnl_semana
        '
        Me.pnl_semana.BackColor = System.Drawing.Color.Transparent
        Me.pnl_semana.BaseColor = System.Drawing.Color.White
        Me.pnl_semana.Controls.Add(Me.Viernes)
        Me.pnl_semana.Controls.Add(Me.Jueves)
        Me.pnl_semana.Controls.Add(Me.Miercoles)
        Me.pnl_semana.Controls.Add(Me.Martes)
        Me.pnl_semana.Controls.Add(Me.Lunes)
        Me.pnl_semana.Controls.Add(Me.radio_viernes)
        Me.pnl_semana.Controls.Add(Me.radio_jueves)
        Me.pnl_semana.Controls.Add(Me.radio_miercoles)
        Me.pnl_semana.Controls.Add(Me.radio_martes)
        Me.pnl_semana.Controls.Add(Me.radio_lunes)
        Me.pnl_semana.Location = New System.Drawing.Point(15, 185)
        Me.pnl_semana.Name = "pnl_semana"
        Me.pnl_semana.Radius = 10
        Me.pnl_semana.ShadowColor = System.Drawing.Color.Black
        Me.pnl_semana.Size = New System.Drawing.Size(750, 73)
        Me.pnl_semana.TabIndex = 9
        '
        'Viernes
        '
        Me.Viernes.AutoSize = True
        Me.Viernes.Location = New System.Drawing.Point(539, 16)
        Me.Viernes.Name = "Viernes"
        Me.Viernes.Size = New System.Drawing.Size(65, 19)
        Me.Viernes.TabIndex = 36
        Me.Viernes.Text = "Viernes"
        '
        'Jueves
        '
        Me.Jueves.AutoSize = True
        Me.Jueves.Location = New System.Drawing.Point(433, 16)
        Me.Jueves.Name = "Jueves"
        Me.Jueves.Size = New System.Drawing.Size(61, 19)
        Me.Jueves.TabIndex = 35
        Me.Jueves.Text = "Jueves"
        '
        'Miercoles
        '
        Me.Miercoles.AutoSize = True
        Me.Miercoles.Location = New System.Drawing.Point(330, 16)
        Me.Miercoles.Name = "Miercoles"
        Me.Miercoles.Size = New System.Drawing.Size(82, 19)
        Me.Miercoles.TabIndex = 34
        Me.Miercoles.Text = "Miércoles"
        '
        'Martes
        '
        Me.Martes.AutoSize = True
        Me.Martes.Location = New System.Drawing.Point(240, 16)
        Me.Martes.Name = "Martes"
        Me.Martes.Size = New System.Drawing.Size(60, 19)
        Me.Martes.TabIndex = 33
        Me.Martes.Text = "Martes"
        '
        'Lunes
        '
        Me.Lunes.AutoSize = True
        Me.Lunes.Location = New System.Drawing.Point(139, 16)
        Me.Lunes.Name = "Lunes"
        Me.Lunes.Size = New System.Drawing.Size(53, 19)
        Me.Lunes.TabIndex = 32
        Me.Lunes.Text = "Lunes"
        '
        'radio_viernes
        '
        Me.radio_viernes.BaseColor = System.Drawing.Color.White
        Me.radio_viernes.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_viernes.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.radio_viernes.FillColor = System.Drawing.Color.White
        Me.radio_viernes.Location = New System.Drawing.Point(555, 38)
        Me.radio_viernes.Name = "radio_viernes"
        Me.radio_viernes.Size = New System.Drawing.Size(20, 20)
        Me.radio_viernes.TabIndex = 6
        Me.radio_viernes.Tag = "6"
        '
        'radio_jueves
        '
        Me.radio_jueves.BaseColor = System.Drawing.Color.White
        Me.radio_jueves.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_jueves.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.radio_jueves.FillColor = System.Drawing.Color.White
        Me.radio_jueves.Location = New System.Drawing.Point(455, 38)
        Me.radio_jueves.Name = "radio_jueves"
        Me.radio_jueves.Size = New System.Drawing.Size(20, 20)
        Me.radio_jueves.TabIndex = 5
        Me.radio_jueves.Tag = "5"
        '
        'radio_miercoles
        '
        Me.radio_miercoles.BaseColor = System.Drawing.Color.White
        Me.radio_miercoles.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_miercoles.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.radio_miercoles.FillColor = System.Drawing.Color.White
        Me.radio_miercoles.Location = New System.Drawing.Point(355, 38)
        Me.radio_miercoles.Name = "radio_miercoles"
        Me.radio_miercoles.Size = New System.Drawing.Size(20, 20)
        Me.radio_miercoles.TabIndex = 3
        Me.radio_miercoles.Tag = "4"
        '
        'radio_martes
        '
        Me.radio_martes.BaseColor = System.Drawing.Color.White
        Me.radio_martes.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_martes.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.radio_martes.FillColor = System.Drawing.Color.White
        Me.radio_martes.Location = New System.Drawing.Point(255, 38)
        Me.radio_martes.Name = "radio_martes"
        Me.radio_martes.Size = New System.Drawing.Size(20, 20)
        Me.radio_martes.TabIndex = 2
        Me.radio_martes.Tag = "3"
        '
        'radio_lunes
        '
        Me.radio_lunes.BaseColor = System.Drawing.Color.White
        Me.radio_lunes.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_lunes.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.radio_lunes.FillColor = System.Drawing.Color.White
        Me.radio_lunes.Location = New System.Drawing.Point(155, 38)
        Me.radio_lunes.Name = "radio_lunes"
        Me.radio_lunes.Size = New System.Drawing.Size(20, 20)
        Me.radio_lunes.TabIndex = 1
        Me.radio_lunes.Tag = "2"
        '
        'group_manual
        '
        Me.group_manual.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.group_manual.BackColor = System.Drawing.Color.Transparent
        Me.group_manual.BaseColor = System.Drawing.Color.White
        Me.group_manual.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_manual.Controls.Add(Me.btn_generar_copia)
        Me.group_manual.Controls.Add(Me.Label4)
        Me.group_manual.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_manual.LineColor = System.Drawing.Color.Gainsboro
        Me.group_manual.Location = New System.Drawing.Point(23, 498)
        Me.group_manual.Name = "group_manual"
        Me.group_manual.Size = New System.Drawing.Size(780, 158)
        Me.group_manual.TabIndex = 49
        Me.group_manual.Text = "Generar copia de seguridad manualmente."
        Me.group_manual.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_generar_copia
        '
        Me.btn_generar_copia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generar_copia.AnimationHoverSpeed = 0.07!
        Me.btn_generar_copia.AnimationSpeed = 0.03!
        Me.btn_generar_copia.BackColor = System.Drawing.Color.Transparent
        Me.btn_generar_copia.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_generar_copia.BorderColor = System.Drawing.Color.Transparent
        Me.btn_generar_copia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_generar_copia.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_generar_copia.FocusedColor = System.Drawing.Color.Empty
        Me.btn_generar_copia.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar_copia.ForeColor = System.Drawing.Color.White
        Me.btn_generar_copia.Image = Global.Appsena.My.Resources.Resources.icons8_database_white_64
        Me.btn_generar_copia.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_generar_copia.Location = New System.Drawing.Point(295, 109)
        Me.btn_generar_copia.Name = "btn_generar_copia"
        Me.btn_generar_copia.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btn_generar_copia.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_generar_copia.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_generar_copia.OnHoverImage = Nothing
        Me.btn_generar_copia.OnPressedColor = System.Drawing.Color.Black
        Me.btn_generar_copia.Radius = 10
        Me.btn_generar_copia.Size = New System.Drawing.Size(166, 31)
        Me.btn_generar_copia.TabIndex = 44
        Me.btn_generar_copia.Text = "Generar BackUp"
        Me.btn_generar_copia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 38)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "De Click en el botón y elija la carpeta o el lugar de destino " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "donde se guardará" &
    " la copia de seguridad de la base de datos."
        '
        'frm_backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 702)
        Me.Controls.Add(Me.group_manual)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_backup"
        Me.Text = "frm_backup"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.pnl_semana.ResumeLayout(False)
        Me.pnl_semana.PerformLayout()
        Me.group_manual.ResumeLayout(False)
        Me.group_manual.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_archivo As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtbackup As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lbl_inicio As Label
    Friend WithEvents lblestado2 As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblestado1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_semana As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Viernes As Label
    Friend WithEvents Jueves As Label
    Friend WithEvents Miercoles As Label
    Friend WithEvents Martes As Label
    Friend WithEvents Lunes As Label
    Friend WithEvents radio_viernes As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents radio_jueves As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents radio_miercoles As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents radio_martes As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents radio_lunes As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents group_manual As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_generar_copia As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents radio_semanal As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents radio_semestral As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents radio_trimestral As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents radio_mensual As Guna.UI.WinForms.GunaRadioButton
End Class
