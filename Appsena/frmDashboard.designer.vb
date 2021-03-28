<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashBoard))
        Me.pnlMenu = New Guna.UI.WinForms.GunaPanel()
        Me.ptbSena = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnSincronizar = New Guna.UI.WinForms.GunaButton()
        Me.btnAdministradores = New Guna.UI.WinForms.GunaButton()
        Me.btnUsuarios = New Guna.UI.WinForms.GunaButton()
        Me.btnElementos = New Guna.UI.WinForms.GunaButton()
        Me.btnMora = New Guna.UI.WinForms.GunaButton()
        Me.btnReservas = New Guna.UI.WinForms.GunaButton()
        Me.btnMovimientos = New Guna.UI.WinForms.GunaButton()
        Me.btnResponsive = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFormu = New System.Windows.Forms.Label()
        Me.lbladmin = New System.Windows.Forms.Label()
        Me.ptbSesion = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConfiguracionGeneral = New Guna.UI.WinForms.GunaButton()
        Me.btnConfigurarCuenta = New Guna.UI.WinForms.GunaButton()
        Me.btnCerrarSesion = New Guna.UI.WinForms.GunaButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_validar_reserva = New System.Windows.Forms.Timer(Me.components)
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.pnlConfiguracion = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.Timer_conexion_internet = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu.SuspendLayout()
        CType(Me.ptbSena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfiguracion.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.ptbSena)
        Me.pnlMenu.Controls.Add(Me.btnSincronizar)
        Me.pnlMenu.Controls.Add(Me.btnAdministradores)
        Me.pnlMenu.Controls.Add(Me.btnUsuarios)
        Me.pnlMenu.Controls.Add(Me.btnElementos)
        Me.pnlMenu.Controls.Add(Me.btnMora)
        Me.pnlMenu.Controls.Add(Me.btnReservas)
        Me.pnlMenu.Controls.Add(Me.btnMovimientos)
        Me.pnlMenu.Controls.Add(Me.btnResponsive)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(222, 725)
        Me.pnlMenu.TabIndex = 0
        '
        'ptbSena
        '
        Me.ptbSena.BackColor = System.Drawing.Color.Transparent
        Me.ptbSena.BaseColor = System.Drawing.Color.White
        Me.ptbSena.Image = Global.Appsena.My.Resources.Resources.logoSenaradial
        Me.ptbSena.InitialImage = Global.Appsena.My.Resources.Resources.logoSenaradial
        Me.ptbSena.Location = New System.Drawing.Point(11, 61)
        Me.ptbSena.Name = "ptbSena"
        Me.ptbSena.Size = New System.Drawing.Size(196, 197)
        Me.ptbSena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbSena.TabIndex = 12
        Me.ptbSena.TabStop = False
        Me.ptbSena.UseTransfarantBackground = False
        '
        'btnSincronizar
        '
        Me.btnSincronizar.AnimationHoverSpeed = 0.07!
        Me.btnSincronizar.AnimationSpeed = 0.03!
        Me.btnSincronizar.BackColor = System.Drawing.Color.Transparent
        Me.btnSincronizar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSincronizar.BorderColor = System.Drawing.Color.Transparent
        Me.btnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSincronizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSincronizar.FocusedColor = System.Drawing.Color.Empty
        Me.btnSincronizar.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizar.ForeColor = System.Drawing.Color.White
        Me.btnSincronizar.Image = Global.Appsena.My.Resources.Resources.icons8_cloud_sync_64
        Me.btnSincronizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSincronizar.Location = New System.Drawing.Point(12, 642)
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnSincronizar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnSincronizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSincronizar.OnHoverImage = Nothing
        Me.btnSincronizar.OnPressedColor = System.Drawing.Color.Black
        Me.btnSincronizar.Radius = 10
        Me.btnSincronizar.Size = New System.Drawing.Size(195, 42)
        Me.btnSincronizar.TabIndex = 11
        Me.btnSincronizar.Text = "Sincronizar"
        Me.ToolTip1.SetToolTip(Me.btnSincronizar, "Sincronizar información")
        '
        'btnAdministradores
        '
        Me.btnAdministradores.AnimationHoverSpeed = 0.07!
        Me.btnAdministradores.AnimationSpeed = 0.03!
        Me.btnAdministradores.BackColor = System.Drawing.Color.Transparent
        Me.btnAdministradores.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAdministradores.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdministradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdministradores.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdministradores.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdministradores.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministradores.ForeColor = System.Drawing.Color.White
        Me.btnAdministradores.Image = Global.Appsena.My.Resources.Resources.icons8_businessman_64
        Me.btnAdministradores.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdministradores.Location = New System.Drawing.Point(12, 579)
        Me.btnAdministradores.Name = "btnAdministradores"
        Me.btnAdministradores.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAdministradores.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAdministradores.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdministradores.OnHoverImage = Nothing
        Me.btnAdministradores.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdministradores.Radius = 10
        Me.btnAdministradores.Size = New System.Drawing.Size(195, 42)
        Me.btnAdministradores.TabIndex = 10
        Me.btnAdministradores.Text = "Administradores"
        Me.ToolTip1.SetToolTip(Me.btnAdministradores, "Administradores")
        '
        'btnUsuarios
        '
        Me.btnUsuarios.AnimationHoverSpeed = 0.07!
        Me.btnUsuarios.AnimationSpeed = 0.03!
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnUsuarios.BorderColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUsuarios.FocusedColor = System.Drawing.Color.Empty
        Me.btnUsuarios.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = Global.Appsena.My.Resources.Resources.icons8_user_account_64
        Me.btnUsuarios.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 516)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnUsuarios.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUsuarios.OnHoverImage = Nothing
        Me.btnUsuarios.OnPressedColor = System.Drawing.Color.Black
        Me.btnUsuarios.Radius = 10
        Me.btnUsuarios.Size = New System.Drawing.Size(195, 42)
        Me.btnUsuarios.TabIndex = 9
        Me.btnUsuarios.Text = "Clientes"
        Me.ToolTip1.SetToolTip(Me.btnUsuarios, "Ir a clientes")
        '
        'btnElementos
        '
        Me.btnElementos.AnimationHoverSpeed = 0.07!
        Me.btnElementos.AnimationSpeed = 0.03!
        Me.btnElementos.BackColor = System.Drawing.Color.Transparent
        Me.btnElementos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnElementos.BorderColor = System.Drawing.Color.Transparent
        Me.btnElementos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElementos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnElementos.FocusedColor = System.Drawing.Color.Empty
        Me.btnElementos.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElementos.ForeColor = System.Drawing.Color.White
        Me.btnElementos.Image = Global.Appsena.My.Resources.Resources.icons8_maintenance_64
        Me.btnElementos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnElementos.Location = New System.Drawing.Point(12, 453)
        Me.btnElementos.Name = "btnElementos"
        Me.btnElementos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnElementos.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnElementos.OnHoverForeColor = System.Drawing.Color.White
        Me.btnElementos.OnHoverImage = Nothing
        Me.btnElementos.OnPressedColor = System.Drawing.Color.Black
        Me.btnElementos.Radius = 10
        Me.btnElementos.Size = New System.Drawing.Size(195, 42)
        Me.btnElementos.TabIndex = 8
        Me.btnElementos.Text = "Elementos"
        Me.ToolTip1.SetToolTip(Me.btnElementos, "Inventario")
        '
        'btnMora
        '
        Me.btnMora.AnimationHoverSpeed = 0.07!
        Me.btnMora.AnimationSpeed = 0.03!
        Me.btnMora.BackColor = System.Drawing.Color.Transparent
        Me.btnMora.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMora.BorderColor = System.Drawing.Color.Transparent
        Me.btnMora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMora.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMora.FocusedColor = System.Drawing.Color.Empty
        Me.btnMora.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMora.ForeColor = System.Drawing.Color.White
        Me.btnMora.Image = Global.Appsena.My.Resources.Resources.icons8_raspberry_64
        Me.btnMora.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMora.Location = New System.Drawing.Point(12, 390)
        Me.btnMora.Name = "btnMora"
        Me.btnMora.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMora.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnMora.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMora.OnHoverImage = Nothing
        Me.btnMora.OnPressedColor = System.Drawing.Color.Black
        Me.btnMora.Radius = 10
        Me.btnMora.Size = New System.Drawing.Size(195, 42)
        Me.btnMora.TabIndex = 7
        Me.btnMora.Text = "Mora"
        Me.ToolTip1.SetToolTip(Me.btnMora, "Clientes en mora")
        '
        'btnReservas
        '
        Me.btnReservas.AnimationHoverSpeed = 0.07!
        Me.btnReservas.AnimationSpeed = 0.03!
        Me.btnReservas.BackColor = System.Drawing.Color.Transparent
        Me.btnReservas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnReservas.BorderColor = System.Drawing.Color.Transparent
        Me.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReservas.FocusedColor = System.Drawing.Color.Empty
        Me.btnReservas.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.Color.White
        Me.btnReservas.Image = Global.Appsena.My.Resources.Resources.icons8_calendar_30_64
        Me.btnReservas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReservas.Location = New System.Drawing.Point(12, 327)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnReservas.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnReservas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReservas.OnHoverImage = Nothing
        Me.btnReservas.OnPressedColor = System.Drawing.Color.Black
        Me.btnReservas.Radius = 10
        Me.btnReservas.Size = New System.Drawing.Size(195, 42)
        Me.btnReservas.TabIndex = 6
        Me.btnReservas.Text = "Reservas"
        Me.ToolTip1.SetToolTip(Me.btnReservas, "Reservas")
        '
        'btnMovimientos
        '
        Me.btnMovimientos.AnimationHoverSpeed = 0.07!
        Me.btnMovimientos.AnimationSpeed = 0.03!
        Me.btnMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.btnMovimientos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMovimientos.BorderColor = System.Drawing.Color.Transparent
        Me.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMovimientos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMovimientos.FocusedColor = System.Drawing.Color.Empty
        Me.btnMovimientos.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimientos.ForeColor = System.Drawing.Color.White
        Me.btnMovimientos.Image = Global.Appsena.My.Resources.Resources.icons8_storage_box_64
        Me.btnMovimientos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMovimientos.Location = New System.Drawing.Point(12, 264)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMovimientos.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnMovimientos.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMovimientos.OnHoverImage = Nothing
        Me.btnMovimientos.OnPressedColor = System.Drawing.Color.Black
        Me.btnMovimientos.Radius = 10
        Me.btnMovimientos.Size = New System.Drawing.Size(195, 42)
        Me.btnMovimientos.TabIndex = 4
        Me.btnMovimientos.Text = "Movimientos"
        Me.ToolTip1.SetToolTip(Me.btnMovimientos, "Realizar un movimiento")
        '
        'btnResponsive
        '
        Me.btnResponsive.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnResponsive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResponsive.FlatAppearance.BorderSize = 0
        Me.btnResponsive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResponsive.ForeColor = System.Drawing.Color.Transparent
        Me.btnResponsive.Image = Global.Appsena.My.Resources.Resources.icons8_list_32
        Me.btnResponsive.Location = New System.Drawing.Point(184, 4)
        Me.btnResponsive.Name = "btnResponsive"
        Me.btnResponsive.Size = New System.Drawing.Size(35, 35)
        Me.btnResponsive.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnResponsive, "Minimizar menú")
        Me.btnResponsive.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblFormu)
        Me.Panel1.Controls.Add(Me.lbladmin)
        Me.Panel1.Controls.Add(Me.ptbSesion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(222, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 45)
        Me.Panel1.TabIndex = 1
        '
        'lblFormu
        '
        Me.lblFormu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFormu.BackColor = System.Drawing.Color.Transparent
        Me.lblFormu.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormu.ForeColor = System.Drawing.Color.White
        Me.lblFormu.Location = New System.Drawing.Point(3, 14)
        Me.lblFormu.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFormu.Name = "lblFormu"
        Me.lblFormu.Size = New System.Drawing.Size(300, 22)
        Me.lblFormu.TabIndex = 5
        Me.lblFormu.Text = "Formulario"
        Me.lblFormu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbladmin
        '
        Me.lbladmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbladmin.BackColor = System.Drawing.Color.Transparent
        Me.lbladmin.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladmin.ForeColor = System.Drawing.Color.White
        Me.lbladmin.Location = New System.Drawing.Point(403, 14)
        Me.lbladmin.Margin = New System.Windows.Forms.Padding(0)
        Me.lbladmin.Name = "lbladmin"
        Me.lbladmin.Size = New System.Drawing.Size(372, 22)
        Me.lbladmin.TabIndex = 4
        Me.lbladmin.Text = "Administrador"
        Me.lbladmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ptbSesion
        '
        Me.ptbSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbSesion.BackColor = System.Drawing.Color.Transparent
        Me.ptbSesion.BaseColor = System.Drawing.Color.White
        Me.ptbSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbSesion.ImageLocation = ""
        Me.ptbSesion.Location = New System.Drawing.Point(781, 4)
        Me.ptbSesion.Name = "ptbSesion"
        Me.ptbSesion.Size = New System.Drawing.Size(40, 40)
        Me.ptbSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbSesion.TabIndex = 3
        Me.ptbSesion.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ptbSesion, "Desplegar Opciones")
        Me.ptbSesion.UseTransfarantBackground = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(222, 683)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 42)
        Me.Panel2.TabIndex = 2
        '
        'btnConfiguracionGeneral
        '
        Me.btnConfiguracionGeneral.AnimationHoverSpeed = 0.07!
        Me.btnConfiguracionGeneral.AnimationSpeed = 0.03!
        Me.btnConfiguracionGeneral.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguracionGeneral.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfiguracionGeneral.BorderColor = System.Drawing.Color.Transparent
        Me.btnConfiguracionGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracionGeneral.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConfiguracionGeneral.FocusedColor = System.Drawing.Color.Empty
        Me.btnConfiguracionGeneral.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracionGeneral.ForeColor = System.Drawing.Color.Black
        Me.btnConfiguracionGeneral.Image = Global.Appsena.My.Resources.Resources.icons8_settings_balck_32
        Me.btnConfiguracionGeneral.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConfiguracionGeneral.Location = New System.Drawing.Point(15, 17)
        Me.btnConfiguracionGeneral.Name = "btnConfiguracionGeneral"
        Me.btnConfiguracionGeneral.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnConfiguracionGeneral.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnConfiguracionGeneral.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnConfiguracionGeneral.OnHoverImage = Nothing
        Me.btnConfiguracionGeneral.OnPressedColor = System.Drawing.Color.Black
        Me.btnConfiguracionGeneral.Radius = 10
        Me.btnConfiguracionGeneral.Size = New System.Drawing.Size(228, 42)
        Me.btnConfiguracionGeneral.TabIndex = 11
        Me.btnConfiguracionGeneral.Text = "Configuración general"
        Me.ToolTip1.SetToolTip(Me.btnConfiguracionGeneral, "Ir a configuración general")
        '
        'btnConfigurarCuenta
        '
        Me.btnConfigurarCuenta.AnimationHoverSpeed = 0.07!
        Me.btnConfigurarCuenta.AnimationSpeed = 0.03!
        Me.btnConfigurarCuenta.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarCuenta.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfigurarCuenta.BorderColor = System.Drawing.Color.Transparent
        Me.btnConfigurarCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigurarCuenta.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConfigurarCuenta.FocusedColor = System.Drawing.Color.Empty
        Me.btnConfigurarCuenta.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigurarCuenta.ForeColor = System.Drawing.Color.Black
        Me.btnConfigurarCuenta.Image = Global.Appsena.My.Resources.Resources.icons8_writer_male_black_32
        Me.btnConfigurarCuenta.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConfigurarCuenta.Location = New System.Drawing.Point(15, 65)
        Me.btnConfigurarCuenta.Name = "btnConfigurarCuenta"
        Me.btnConfigurarCuenta.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnConfigurarCuenta.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnConfigurarCuenta.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnConfigurarCuenta.OnHoverImage = Nothing
        Me.btnConfigurarCuenta.OnPressedColor = System.Drawing.Color.Black
        Me.btnConfigurarCuenta.Radius = 10
        Me.btnConfigurarCuenta.Size = New System.Drawing.Size(228, 42)
        Me.btnConfigurarCuenta.TabIndex = 12
        Me.btnConfigurarCuenta.Text = "Configurar la cuenta"
        Me.ToolTip1.SetToolTip(Me.btnConfigurarCuenta, "Ir a configuración de cuenta")
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.AnimationHoverSpeed = 0.07!
        Me.btnCerrarSesion.AnimationSpeed = 0.03!
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarSesion.BorderColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrarSesion.FocusedColor = System.Drawing.Color.Empty
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.Image = Global.Appsena.My.Resources.Resources.icons8_exit_black_32
        Me.btnCerrarSesion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(15, 113)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnCerrarSesion.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.OnHoverImage = Nothing
        Me.btnCerrarSesion.OnPressedColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.Radius = 10
        Me.btnCerrarSesion.Size = New System.Drawing.Size(228, 42)
        Me.btnCerrarSesion.TabIndex = 13
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.ToolTip1.SetToolTip(Me.btnCerrarSesion, "Cerrar la sesión actual")
        '
        'Timer1
        '
        '
        'timer_validar_reserva
        '
        Me.timer_validar_reserva.Interval = 55000
        '
        'dgexportar
        '
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(0, 0)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.Size = New System.Drawing.Size(108, 27)
        Me.dgexportar.TabIndex = 5
        Me.dgexportar.Visible = False
        '
        'pnlConfiguracion
        '
        Me.pnlConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.pnlConfiguracion.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.pnlConfiguracion.Controls.Add(Me.btnCerrarSesion)
        Me.pnlConfiguracion.Controls.Add(Me.btnConfigurarCuenta)
        Me.pnlConfiguracion.Controls.Add(Me.btnConfiguracionGeneral)
        Me.pnlConfiguracion.Location = New System.Drawing.Point(565, 0)
        Me.pnlConfiguracion.Name = "pnlConfiguracion"
        Me.pnlConfiguracion.ShadowColor = System.Drawing.Color.Black
        Me.pnlConfiguracion.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped
        Me.pnlConfiguracion.Size = New System.Drawing.Size(259, 175)
        Me.pnlConfiguracion.TabIndex = 3
        Me.pnlConfiguracion.Visible = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.White
        Me.pnlPrincipal.Controls.Add(Me.pnlConfiguracion)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(222, 45)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(824, 638)
        Me.pnlPrincipal.TabIndex = 4
        '
        'Timer_conexion_internet
        '
        Me.Timer_conexion_internet.Interval = 2000
        '
        'frmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1046, 725)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashBoard"
        Me.Text = "SENA - MEDIOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.ptbSena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptbSesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfiguracion.ResumeLayout(False)
        Me.pnlPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnResponsive As Button
    Friend WithEvents btnMovimientos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnReservas As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMora As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnElementos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUsuarios As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdministradores As Guna.UI.WinForms.GunaButton
    Friend WithEvents ptbSesion As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbladmin As Label
    Friend WithEvents lblFormu As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timer_validar_reserva As Timer
    Friend WithEvents btnSincronizar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents pnlConfiguracion As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnCerrarSesion As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnConfigurarCuenta As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnConfiguracionGeneral As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents Timer_conexion_internet As Timer
    Friend WithEvents ptbSena As Guna.UI.WinForms.GunaCirclePictureBox
End Class
