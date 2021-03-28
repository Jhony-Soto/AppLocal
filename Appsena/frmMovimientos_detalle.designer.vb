<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientos_detalle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_detalle))
        Me.lblNombresNom = New System.Windows.Forms.Label()
        Me.lblDocidNom = New System.Windows.Forms.Label()
        Me.gbxCliente = New Guna.UI.WinForms.GunaGroupBox()
        Me.pnlPrestamoInfo = New System.Windows.Forms.Panel()
        Me.lblTraspaso = New System.Windows.Forms.LinkLabel()
        Me.lblFechaLimit = New System.Windows.Forms.Label()
        Me.lblCodPres = New System.Windows.Forms.Label()
        Me.Separadorgbx = New System.Windows.Forms.Panel()
        Me.lblSeguro = New System.Windows.Forms.LinkLabel()
        Me.lblTipoprestamo = New System.Windows.Forms.Label()
        Me.lblFormatoSalida = New System.Windows.Forms.LinkLabel()
        Me.dtpFechaLimite = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblTpr = New System.Windows.Forms.Label()
        Me.btnAlertaMora = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCambiarCliente = New Guna.UI.WinForms.GunaButton()
        Me.btnEditarPerfil = New Guna.UI.WinForms.GunaButton()
        Me.ptbFotoCliente = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.lblNumFicha = New System.Windows.Forms.Label()
        Me.lblDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocidNom = New System.Windows.Forms.Label()
        Me.dgvHistorial = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmCodPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clFechaPres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaPresta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmObserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmestado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConsecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantiEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoelemt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCadaUno = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmEntregarTodo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmCantidadPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.codtipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaImageReplaceColor1 = New Guna.UI.WinForms.GunaImageReplaceColor(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblReservas = New System.Windows.Forms.Label()
        Me.txtCantidad = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbTipoPrestamo = New Guna.UI.WinForms.GunaComboBox()
        Me.txtElemento = New Guna.UI.WinForms.GunaTextBox()
        Me.dtpFechaLimit = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cbxFechalimite = New Guna.UI.WinForms.GunaCheckBox()
        Me.dtpFechaLimitHora = New System.Windows.Forms.DateTimePicker()
        Me.btnEnviarAMora = New Guna.UI.WinForms.GunaButton()
        Me.btnAgregar = New Guna.UI.WinForms.GunaButton()
        Me.tabMovimiento = New System.Windows.Forms.TabControl()
        Me.tpHistorial = New System.Windows.Forms.TabPage()
        Me.tpPrestamo = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvElementosDispo = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmElemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoElemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmcodtipoele = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvElementosPrestados = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CodTipoElem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpHistorialPrestamo = New System.Windows.Forms.TabPage()
        Me.dgvEPrestados = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDuplicar = New System.Windows.Forms.DataGridView()
        Me.clmCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmcanti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmobser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmfechapres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmfechadevo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerMora = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSeguro = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnEntregarTodo = New Guna.UI.WinForms.GunaButton()
        Me.btnEnviarCorreo = New Guna.UI.WinForms.GunaButton()
        Me.btnEntregar = New Guna.UI.WinForms.GunaButton()
        Me.btnDuplicarPrestamo = New Guna.UI.WinForms.GunaButton()
        Me.btnPrestarElementos = New Guna.UI.WinForms.GunaButton()
        Me.TimerFechaLimite = New System.Windows.Forms.Timer(Me.components)
        Me.gbxCliente.SuspendLayout()
        Me.pnlPrestamoInfo.SuspendLayout()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMovimiento.SuspendLayout()
        Me.tpHistorial.SuspendLayout()
        Me.tpPrestamo.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvElementosDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvElementosPrestados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHistorialPrestamo.SuspendLayout()
        CType(Me.dgvEPrestados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDuplicar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombresNom
        '
        Me.lblNombresNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombresNom.AutoSize = True
        Me.lblNombresNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresNom.ForeColor = System.Drawing.Color.Black
        Me.lblNombresNom.Location = New System.Drawing.Point(108, 36)
        Me.lblNombresNom.Name = "lblNombresNom"
        Me.lblNombresNom.Size = New System.Drawing.Size(247, 19)
        Me.lblNombresNom.TabIndex = 7
        Me.lblNombresNom.Text = "Emilio Cordoba Cuadrado Perea"
        Me.lblNombresNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocidNom
        '
        Me.lblDocidNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocidNom.AutoSize = True
        Me.lblDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblDocidNom.Location = New System.Drawing.Point(131, 59)
        Me.lblDocidNom.Name = "lblDocidNom"
        Me.lblDocidNom.Size = New System.Drawing.Size(108, 19)
        Me.lblDocidNom.TabIndex = 8
        Me.lblDocidNom.Text = "10004512343"
        Me.lblDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxCliente
        '
        Me.gbxCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCliente.BackColor = System.Drawing.Color.Transparent
        Me.gbxCliente.BaseColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxCliente.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.gbxCliente.BorderSize = 2
        Me.gbxCliente.Controls.Add(Me.pnlPrestamoInfo)
        Me.gbxCliente.Controls.Add(Me.btnAlertaMora)
        Me.gbxCliente.Controls.Add(Me.btnCambiarCliente)
        Me.gbxCliente.Controls.Add(Me.btnEditarPerfil)
        Me.gbxCliente.Controls.Add(Me.ptbFotoCliente)
        Me.gbxCliente.Controls.Add(Me.lblNombres)
        Me.gbxCliente.Controls.Add(Me.lblFicha)
        Me.gbxCliente.Controls.Add(Me.lblNumFicha)
        Me.gbxCliente.Controls.Add(Me.lblDocidNom)
        Me.gbxCliente.Controls.Add(Me.lblNombresNom)
        Me.gbxCliente.Controls.Add(Me.lblDocid)
        Me.gbxCliente.Controls.Add(Me.lblTipoDocid)
        Me.gbxCliente.Controls.Add(Me.lblTipoDocidNom)
        Me.gbxCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCliente.ForeColor = System.Drawing.Color.White
        Me.gbxCliente.LineBottom = 2
        Me.gbxCliente.LineColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.gbxCliente.LineLeft = 2
        Me.gbxCliente.LineRight = 2
        Me.gbxCliente.LineTop = 35
        Me.gbxCliente.Location = New System.Drawing.Point(12, 12)
        Me.gbxCliente.Name = "gbxCliente"
        Me.gbxCliente.Size = New System.Drawing.Size(1342, 141)
        Me.gbxCliente.TabIndex = 9
        Me.gbxCliente.Text = "Información del cliente"
        Me.gbxCliente.TextLocation = New System.Drawing.Point(10, 8)
        '
        'pnlPrestamoInfo
        '
        Me.pnlPrestamoInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnlPrestamoInfo.Controls.Add(Me.lblTraspaso)
        Me.pnlPrestamoInfo.Controls.Add(Me.lblFechaLimit)
        Me.pnlPrestamoInfo.Controls.Add(Me.lblCodPres)
        Me.pnlPrestamoInfo.Controls.Add(Me.Separadorgbx)
        Me.pnlPrestamoInfo.Controls.Add(Me.lblSeguro)
        Me.pnlPrestamoInfo.Controls.Add(Me.lblTipoprestamo)
        Me.pnlPrestamoInfo.Controls.Add(Me.lblFormatoSalida)
        Me.pnlPrestamoInfo.Controls.Add(Me.dtpFechaLimite)
        Me.pnlPrestamoInfo.Controls.Add(Me.lblTpr)
        Me.pnlPrestamoInfo.Location = New System.Drawing.Point(956, 34)
        Me.pnlPrestamoInfo.Name = "pnlPrestamoInfo"
        Me.pnlPrestamoInfo.Size = New System.Drawing.Size(383, 107)
        Me.pnlPrestamoInfo.TabIndex = 73
        Me.pnlPrestamoInfo.Visible = False
        '
        'lblTraspaso
        '
        Me.lblTraspaso.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblTraspaso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTraspaso.AutoSize = True
        Me.lblTraspaso.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTraspaso.Location = New System.Drawing.Point(262, 67)
        Me.lblTraspaso.Name = "lblTraspaso"
        Me.lblTraspaso.Size = New System.Drawing.Size(77, 19)
        Me.lblTraspaso.TabIndex = 73
        Me.lblTraspaso.TabStop = True
        Me.lblTraspaso.Text = "Traspaso"
        Me.lblTraspaso.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'lblFechaLimit
        '
        Me.lblFechaLimit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFechaLimit.AutoSize = True
        Me.lblFechaLimit.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaLimit.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaLimit.ForeColor = System.Drawing.Color.Black
        Me.lblFechaLimit.Location = New System.Drawing.Point(13, 37)
        Me.lblFechaLimit.Name = "lblFechaLimit"
        Me.lblFechaLimit.Size = New System.Drawing.Size(120, 19)
        Me.lblFechaLimit.TabIndex = 69
        Me.lblFechaLimit.Text = "Fecha límite:"
        Me.lblFechaLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodPres
        '
        Me.lblCodPres.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCodPres.AutoSize = True
        Me.lblCodPres.BackColor = System.Drawing.Color.Transparent
        Me.lblCodPres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPres.ForeColor = System.Drawing.Color.Black
        Me.lblCodPres.Location = New System.Drawing.Point(330, 5)
        Me.lblCodPres.Name = "lblCodPres"
        Me.lblCodPres.Size = New System.Drawing.Size(37, 19)
        Me.lblCodPres.TabIndex = 59
        Me.lblCodPres.Text = "cod"
        Me.lblCodPres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Separadorgbx
        '
        Me.Separadorgbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Separadorgbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Separadorgbx.Location = New System.Drawing.Point(-2, -19)
        Me.Separadorgbx.Name = "Separadorgbx"
        Me.Separadorgbx.Size = New System.Drawing.Size(5, 141)
        Me.Separadorgbx.TabIndex = 67
        '
        'lblSeguro
        '
        Me.lblSeguro.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblSeguro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSeguro.AutoSize = True
        Me.lblSeguro.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSeguro.Location = New System.Drawing.Point(176, 67)
        Me.lblSeguro.Name = "lblSeguro"
        Me.lblSeguro.Size = New System.Drawing.Size(62, 19)
        Me.lblSeguro.TabIndex = 72
        Me.lblSeguro.TabStop = True
        Me.lblSeguro.Text = "Seguro"
        Me.lblSeguro.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'lblTipoprestamo
        '
        Me.lblTipoprestamo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoprestamo.AutoSize = True
        Me.lblTipoprestamo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoprestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoprestamo.ForeColor = System.Drawing.Color.Black
        Me.lblTipoprestamo.Location = New System.Drawing.Point(183, 5)
        Me.lblTipoprestamo.Name = "lblTipoprestamo"
        Me.lblTipoprestamo.Size = New System.Drawing.Size(141, 19)
        Me.lblTipoprestamo.TabIndex = 58
        Me.lblTipoprestamo.Text = "Tipo de prestamo"
        Me.lblTipoprestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFormatoSalida
        '
        Me.lblFormatoSalida.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblFormatoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFormatoSalida.AutoSize = True
        Me.lblFormatoSalida.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblFormatoSalida.Location = New System.Drawing.Point(13, 67)
        Me.lblFormatoSalida.Name = "lblFormatoSalida"
        Me.lblFormatoSalida.Size = New System.Drawing.Size(141, 19)
        Me.lblFormatoSalida.TabIndex = 71
        Me.lblFormatoSalida.TabStop = True
        Me.lblFormatoSalida.Text = "Formato de salida"
        Me.lblFormatoSalida.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'dtpFechaLimite
        '
        Me.dtpFechaLimite.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaLimite.BackColor = System.Drawing.Color.Transparent
        Me.dtpFechaLimite.BaseColor = System.Drawing.Color.White
        Me.dtpFechaLimite.BorderColor = System.Drawing.Color.Silver
        Me.dtpFechaLimite.Checked = False
        Me.dtpFechaLimite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaLimite.CustomFormat = "dd 'de' MMMM/yyyy"
        Me.dtpFechaLimite.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaLimite.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFechaLimite.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaLimite.ForeColor = System.Drawing.Color.Black
        Me.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaLimite.Location = New System.Drawing.Point(137, 32)
        Me.dtpFechaLimite.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaLimite.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaLimite.Name = "dtpFechaLimite"
        Me.dtpFechaLimite.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFechaLimite.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpFechaLimite.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpFechaLimite.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFechaLimite.Radius = 10
        Me.dtpFechaLimite.Size = New System.Drawing.Size(208, 30)
        Me.dtpFechaLimite.TabIndex = 66
        Me.dtpFechaLimite.Text = "15 de abril/2020"
        Me.ToolTip1.SetToolTip(Me.dtpFechaLimite, "Buscar por fecha de prestamo")
        Me.dtpFechaLimite.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        '
        'lblTpr
        '
        Me.lblTpr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTpr.AutoSize = True
        Me.lblTpr.BackColor = System.Drawing.Color.Transparent
        Me.lblTpr.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTpr.ForeColor = System.Drawing.Color.Black
        Me.lblTpr.Location = New System.Drawing.Point(12, 3)
        Me.lblTpr.Name = "lblTpr"
        Me.lblTpr.Size = New System.Drawing.Size(165, 19)
        Me.lblTpr.TabIndex = 68
        Me.lblTpr.Text = "Tipo de prestamo:"
        Me.lblTpr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAlertaMora
        '
        Me.btnAlertaMora.AnimationHoverSpeed = 0.07!
        Me.btnAlertaMora.AnimationSpeed = 0.03!
        Me.btnAlertaMora.BaseColor = System.Drawing.Color.White
        Me.btnAlertaMora.BorderColor = System.Drawing.Color.Black
        Me.btnAlertaMora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlertaMora.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAlertaMora.FocusedColor = System.Drawing.Color.Empty
        Me.btnAlertaMora.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAlertaMora.ForeColor = System.Drawing.Color.White
        Me.btnAlertaMora.Image = Global.Appsena.My.Resources.Resources.icons8_box_important_64
        Me.btnAlertaMora.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnAlertaMora.Location = New System.Drawing.Point(186, 3)
        Me.btnAlertaMora.Name = "btnAlertaMora"
        Me.btnAlertaMora.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnAlertaMora.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAlertaMora.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAlertaMora.OnHoverImage = Nothing
        Me.btnAlertaMora.OnPressedColor = System.Drawing.Color.Red
        Me.btnAlertaMora.Size = New System.Drawing.Size(28, 28)
        Me.btnAlertaMora.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.btnAlertaMora, "ATENCIÓN: El cliente se encuentra en mora. CLICK para ver más")
        '
        'btnCambiarCliente
        '
        Me.btnCambiarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarCliente.AnimationHoverSpeed = 0.07!
        Me.btnCambiarCliente.AnimationSpeed = 0.03!
        Me.btnCambiarCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnCambiarCliente.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCambiarCliente.BorderColor = System.Drawing.Color.Transparent
        Me.btnCambiarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarCliente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCambiarCliente.FocusedColor = System.Drawing.Color.Empty
        Me.btnCambiarCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarCliente.ForeColor = System.Drawing.Color.White
        Me.btnCambiarCliente.Image = Global.Appsena.My.Resources.Resources.icons8_meeting_64
        Me.btnCambiarCliente.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCambiarCliente.Location = New System.Drawing.Point(1008, 0)
        Me.btnCambiarCliente.Name = "btnCambiarCliente"
        Me.btnCambiarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCambiarCliente.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCambiarCliente.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCambiarCliente.OnHoverImage = Nothing
        Me.btnCambiarCliente.OnPressedColor = System.Drawing.Color.Black
        Me.btnCambiarCliente.Size = New System.Drawing.Size(189, 35)
        Me.btnCambiarCliente.TabIndex = 55
        Me.btnCambiarCliente.Text = "Cambiar de cliente"
        Me.ToolTip1.SetToolTip(Me.btnCambiarCliente, "asd")
        '
        'btnEditarPerfil
        '
        Me.btnEditarPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarPerfil.AnimationHoverSpeed = 0.07!
        Me.btnEditarPerfil.AnimationSpeed = 0.03!
        Me.btnEditarPerfil.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarPerfil.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnEditarPerfil.BorderColor = System.Drawing.Color.Transparent
        Me.btnEditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarPerfil.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditarPerfil.FocusedColor = System.Drawing.Color.Empty
        Me.btnEditarPerfil.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPerfil.ForeColor = System.Drawing.Color.White
        Me.btnEditarPerfil.Image = Global.Appsena.My.Resources.Resources.icons8_pencil_white_64
        Me.btnEditarPerfil.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEditarPerfil.Location = New System.Drawing.Point(1203, 0)
        Me.btnEditarPerfil.Name = "btnEditarPerfil"
        Me.btnEditarPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEditarPerfil.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEditarPerfil.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditarPerfil.OnHoverImage = Nothing
        Me.btnEditarPerfil.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditarPerfil.Size = New System.Drawing.Size(139, 35)
        Me.btnEditarPerfil.TabIndex = 54
        Me.btnEditarPerfil.Text = "Editar perfil"
        '
        'ptbFotoCliente
        '
        Me.ptbFotoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbFotoCliente.BackColor = System.Drawing.Color.Transparent
        Me.ptbFotoCliente.BaseColor = System.Drawing.Color.LightGray
        Me.ptbFotoCliente.Location = New System.Drawing.Point(850, 36)
        Me.ptbFotoCliente.Name = "ptbFotoCliente"
        Me.ptbFotoCliente.Size = New System.Drawing.Size(100, 100)
        Me.ptbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotoCliente.TabIndex = 17
        Me.ptbFotoCliente.TabStop = False
        Me.ptbFotoCliente.UseTransfarantBackground = False
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.Black
        Me.lblNombres.Location = New System.Drawing.Point(9, 37)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(93, 19)
        Me.lblNombres.TabIndex = 9
        Me.lblNombres.Text = "Nombres:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFicha
        '
        Me.lblFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFicha.AutoSize = True
        Me.lblFicha.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.Black
        Me.lblFicha.Location = New System.Drawing.Point(9, 110)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(62, 19)
        Me.lblFicha.TabIndex = 13
        Me.lblFicha.Text = "Ficha:"
        Me.lblFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumFicha
        '
        Me.lblNumFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNumFicha.AutoSize = True
        Me.lblNumFicha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFicha.ForeColor = System.Drawing.Color.Black
        Me.lblNumFicha.Location = New System.Drawing.Point(77, 110)
        Me.lblNumFicha.Name = "lblNumFicha"
        Me.lblNumFicha.Size = New System.Drawing.Size(443, 19)
        Me.lblNumFicha.TabIndex = 14
        Me.lblNumFicha.Text = "1673552 - Analisis y Desarrollo de Sistemas de Informacion"
        Me.lblNumFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocid
        '
        Me.lblDocid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocid.AutoSize = True
        Me.lblDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocid.ForeColor = System.Drawing.Color.Black
        Me.lblDocid.Location = New System.Drawing.Point(9, 59)
        Me.lblDocid.Name = "lblDocid"
        Me.lblDocid.Size = New System.Drawing.Size(116, 19)
        Me.lblDocid.TabIndex = 10
        Me.lblDocid.Text = "Documento:"
        Me.lblDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocid
        '
        Me.lblTipoDocid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoDocid.AutoSize = True
        Me.lblTipoDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocid.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocid.Location = New System.Drawing.Point(9, 83)
        Me.lblTipoDocid.Name = "lblTipoDocid"
        Me.lblTipoDocid.Size = New System.Drawing.Size(156, 19)
        Me.lblTipoDocid.TabIndex = 11
        Me.lblTipoDocid.Text = "Tipo documento:"
        Me.lblTipoDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocidNom
        '
        Me.lblTipoDocidNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoDocidNom.AutoSize = True
        Me.lblTipoDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocidNom.Location = New System.Drawing.Point(173, 83)
        Me.lblTipoDocidNom.Name = "lblTipoDocidNom"
        Me.lblTipoDocidNom.Size = New System.Drawing.Size(168, 19)
        Me.lblTipoDocidNom.TabIndex = 12
        Me.lblTipoDocidNom.Text = "Cédula de Ciudadanía"
        Me.lblTipoDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.AllowUserToResizeColumns = False
        Me.dgvHistorial.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodPrestamo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.clFechaPres, Me.clmFechaPresta, Me.clmObserva, Me.clmestado, Me.clmConsecutivo, Me.clmCantiEntrega, Me.clmTipoelemt, Me.clmCadaUno, Me.clmEntregarTodo, Me.clmCantidadPrestamo, Me.clmCheck, Me.codtipo})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistorial.EnableHeadersVisualStyles = False
        Me.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistorial.Location = New System.Drawing.Point(3, 3)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(1328, 522)
        Me.dgvHistorial.TabIndex = 1
        Me.dgvHistorial.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistorial.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvHistorial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvHistorial.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvHistorial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistorial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvHistorial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHistorial.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistorial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvHistorial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistorial.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvHistorial.ThemeStyle.ReadOnly = True
        Me.dgvHistorial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistorial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistorial.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistorial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvHistorial.ThemeStyle.RowsStyle.Height = 22
        Me.dgvHistorial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvHistorial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clmCodPrestamo
        '
        Me.clmCodPrestamo.HeaderText = "Prestamo"
        Me.clmCodPrestamo.Name = "clmCodPrestamo"
        Me.clmCodPrestamo.ReadOnly = True
        Me.clmCodPrestamo.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Elemento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 97
        '
        'clFechaPres
        '
        Me.clFechaPres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clFechaPres.FillWeight = 90.0!
        Me.clFechaPres.HeaderText = "Fecha prestamo"
        Me.clFechaPres.Name = "clFechaPres"
        Me.clFechaPres.ReadOnly = True
        Me.clFechaPres.Width = 150
        '
        'clmFechaPresta
        '
        Me.clmFechaPresta.FillWeight = 90.0!
        Me.clmFechaPresta.HeaderText = "Fecha límite"
        Me.clmFechaPresta.Name = "clmFechaPresta"
        Me.clmFechaPresta.ReadOnly = True
        '
        'clmObserva
        '
        Me.clmObserva.HeaderText = "Observaciones"
        Me.clmObserva.Name = "clmObserva"
        Me.clmObserva.ReadOnly = True
        '
        'clmestado
        '
        Me.clmestado.HeaderText = "estado"
        Me.clmestado.Name = "clmestado"
        Me.clmestado.ReadOnly = True
        Me.clmestado.Visible = False
        '
        'clmConsecutivo
        '
        Me.clmConsecutivo.HeaderText = "Consecutivo"
        Me.clmConsecutivo.Name = "clmConsecutivo"
        Me.clmConsecutivo.ReadOnly = True
        Me.clmConsecutivo.Visible = False
        '
        'clmCantiEntrega
        '
        Me.clmCantiEntrega.HeaderText = "CantidadEntrega"
        Me.clmCantiEntrega.Name = "clmCantiEntrega"
        Me.clmCantiEntrega.ReadOnly = True
        Me.clmCantiEntrega.Visible = False
        '
        'clmTipoelemt
        '
        Me.clmTipoelemt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmTipoelemt.HeaderText = "Tipo"
        Me.clmTipoelemt.Name = "clmTipoelemt"
        Me.clmTipoelemt.ReadOnly = True
        Me.clmTipoelemt.Width = 66
        '
        'clmCadaUno
        '
        Me.clmCadaUno.FillWeight = 50.0!
        Me.clmCadaUno.HeaderText = "Entregar uno"
        Me.clmCadaUno.Image = Global.Appsena.My.Resources.Resources.icons8_handcart_64
        Me.clmCadaUno.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmCadaUno.Name = "clmCadaUno"
        Me.clmCadaUno.ReadOnly = True
        Me.clmCadaUno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmCadaUno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmCadaUno.Visible = False
        '
        'clmEntregarTodo
        '
        Me.clmEntregarTodo.FillWeight = 50.0!
        Me.clmEntregarTodo.HeaderText = "Entregar todo"
        Me.clmEntregarTodo.Image = Global.Appsena.My.Resources.Resources.icons8_trolley_64
        Me.clmEntregarTodo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmEntregarTodo.Name = "clmEntregarTodo"
        Me.clmEntregarTodo.ReadOnly = True
        Me.clmEntregarTodo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmEntregarTodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmEntregarTodo.Visible = False
        '
        'clmCantidadPrestamo
        '
        Me.clmCantidadPrestamo.HeaderText = "CantidadPrestamo"
        Me.clmCantidadPrestamo.Name = "clmCantidadPrestamo"
        Me.clmCantidadPrestamo.ReadOnly = True
        Me.clmCantidadPrestamo.Visible = False
        '
        'clmCheck
        '
        Me.clmCheck.FillWeight = 37.0!
        Me.clmCheck.HeaderText = "Seleccionar"
        Me.clmCheck.Name = "clmCheck"
        Me.clmCheck.ReadOnly = True
        Me.clmCheck.ToolTipText = "Seleccionar un elemento para enviar a mora"
        Me.clmCheck.Visible = False
        '
        'codtipo
        '
        Me.codtipo.HeaderText = "codTipoEle"
        Me.codtipo.Name = "codtipo"
        Me.codtipo.ReadOnly = True
        Me.codtipo.Visible = False
        '
        'GunaImageReplaceColor1
        '
        Me.GunaImageReplaceColor1.Image = Nothing
        Me.GunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty
        Me.GunaImageReplaceColor1.OldColor = System.Drawing.Color.White
        '
        'lblReservas
        '
        Me.lblReservas.AutoSize = True
        Me.lblReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReservas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblReservas.Location = New System.Drawing.Point(12, 47)
        Me.lblReservas.Name = "lblReservas"
        Me.lblReservas.Size = New System.Drawing.Size(76, 19)
        Me.lblReservas.TabIndex = 53
        Me.lblReservas.Text = "Reservas"
        Me.lblReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblReservas, "Abrir panel de reservas")
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCantidad.BackColor = System.Drawing.Color.Transparent
        Me.txtCantidad.BaseColor = System.Drawing.Color.White
        Me.txtCantidad.BorderColor = System.Drawing.Color.Silver
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantidad.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCantidad.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtCantidad.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantidad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.Location = New System.Drawing.Point(747, 35)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.Radius = 10
        Me.txtCantidad.Size = New System.Drawing.Size(78, 30)
        Me.txtCantidad.TabIndex = 45
        Me.txtCantidad.Tag = "1"
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "Cantidad a prestar")
        '
        'cmbTipoPrestamo
        '
        Me.cmbTipoPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbTipoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.cmbTipoPrestamo.BaseColor = System.Drawing.Color.White
        Me.cmbTipoPrestamo.BorderColor = System.Drawing.Color.Silver
        Me.cmbTipoPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTipoPrestamo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPrestamo.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTipoPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoPrestamo.FormattingEnabled = True
        Me.cmbTipoPrestamo.Location = New System.Drawing.Point(189, 35)
        Me.cmbTipoPrestamo.Name = "cmbTipoPrestamo"
        Me.cmbTipoPrestamo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.cmbTipoPrestamo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbTipoPrestamo.Radius = 10
        Me.cmbTipoPrestamo.Size = New System.Drawing.Size(234, 28)
        Me.cmbTipoPrestamo.TabIndex = 48
        Me.cmbTipoPrestamo.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.ToolTip1.SetToolTip(Me.cmbTipoPrestamo, "Seleccionar un tipo de prestamo")
        '
        'txtElemento
        '
        Me.txtElemento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtElemento.BackColor = System.Drawing.Color.Transparent
        Me.txtElemento.BaseColor = System.Drawing.Color.White
        Me.txtElemento.BorderColor = System.Drawing.Color.Silver
        Me.txtElemento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtElemento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtElemento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtElemento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtElemento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElemento.ForeColor = System.Drawing.Color.Black
        Me.txtElemento.Location = New System.Drawing.Point(437, 35)
        Me.txtElemento.Name = "txtElemento"
        Me.txtElemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtElemento.Radius = 10
        Me.txtElemento.Size = New System.Drawing.Size(296, 30)
        Me.txtElemento.TabIndex = 44
        Me.txtElemento.Tag = "1"
        Me.txtElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtElemento, "Buscar elemento por código o por nombre")
        '
        'dtpFechaLimit
        '
        Me.dtpFechaLimit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaLimit.BackColor = System.Drawing.Color.Transparent
        Me.dtpFechaLimit.BaseColor = System.Drawing.Color.White
        Me.dtpFechaLimit.BorderColor = System.Drawing.Color.Silver
        Me.dtpFechaLimit.Checked = False
        Me.dtpFechaLimit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaLimit.CustomFormat = "dd 'de' MMMM/yyyy"
        Me.dtpFechaLimit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaLimit.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFechaLimit.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaLimit.ForeColor = System.Drawing.Color.Black
        Me.dtpFechaLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaLimit.Location = New System.Drawing.Point(970, 35)
        Me.dtpFechaLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaLimit.Name = "dtpFechaLimit"
        Me.dtpFechaLimit.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFechaLimit.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpFechaLimit.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpFechaLimit.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFechaLimit.Radius = 10
        Me.dtpFechaLimit.Size = New System.Drawing.Size(208, 30)
        Me.dtpFechaLimit.TabIndex = 61
        Me.dtpFechaLimit.Text = "15 de abril/2020"
        Me.ToolTip1.SetToolTip(Me.dtpFechaLimit, "Buscar por fecha de prestamo")
        Me.dtpFechaLimit.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        Me.dtpFechaLimit.Visible = False
        '
        'cbxFechalimite
        '
        Me.cbxFechalimite.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxFechalimite.BaseColor = System.Drawing.Color.White
        Me.cbxFechalimite.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbxFechalimite.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxFechalimite.FillColor = System.Drawing.Color.White
        Me.cbxFechalimite.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFechalimite.ForeColor = System.Drawing.Color.Black
        Me.cbxFechalimite.Location = New System.Drawing.Point(970, 40)
        Me.cbxFechalimite.Name = "cbxFechalimite"
        Me.cbxFechalimite.Size = New System.Drawing.Size(208, 23)
        Me.cbxFechalimite.TabIndex = 62
        Me.cbxFechalimite.Text = "Fecha límite de entrega"
        Me.ToolTip1.SetToolTip(Me.cbxFechalimite, "Muestra todos los prestamos que hay activos hasta la fecha")
        '
        'dtpFechaLimitHora
        '
        Me.dtpFechaLimitHora.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaLimitHora.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpFechaLimitHora.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.dtpFechaLimitHora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaLimitHora.CustomFormat = "hh:mm tt"
        Me.dtpFechaLimitHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaLimitHora.Location = New System.Drawing.Point(1184, 36)
        Me.dtpFechaLimitHora.Name = "dtpFechaLimitHora"
        Me.dtpFechaLimitHora.ShowUpDown = True
        Me.dtpFechaLimitHora.Size = New System.Drawing.Size(70, 27)
        Me.dtpFechaLimitHora.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.dtpFechaLimitHora, "Hora límite de entrega")
        Me.dtpFechaLimitHora.Visible = False
        '
        'btnEnviarAMora
        '
        Me.btnEnviarAMora.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEnviarAMora.AnimationHoverSpeed = 0.07!
        Me.btnEnviarAMora.AnimationSpeed = 0.03!
        Me.btnEnviarAMora.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarAMora.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEnviarAMora.BorderColor = System.Drawing.Color.Transparent
        Me.btnEnviarAMora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarAMora.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnviarAMora.FocusedColor = System.Drawing.Color.Empty
        Me.btnEnviarAMora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarAMora.ForeColor = System.Drawing.Color.White
        Me.btnEnviarAMora.Image = Global.Appsena.My.Resources.Resources.icons8_error_64
        Me.btnEnviarAMora.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnviarAMora.Location = New System.Drawing.Point(560, 725)
        Me.btnEnviarAMora.Name = "btnEnviarAMora"
        Me.btnEnviarAMora.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarAMora.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEnviarAMora.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnviarAMora.OnHoverImage = Nothing
        Me.btnEnviarAMora.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnviarAMora.Radius = 10
        Me.btnEnviarAMora.Size = New System.Drawing.Size(152, 31)
        Me.btnEnviarAMora.TabIndex = 48
        Me.btnEnviarAMora.Text = "Enviar a mora"
        Me.ToolTip1.SetToolTip(Me.btnEnviarAMora, "Agregar a los elementos prestados el elemento seleccionado")
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregar.AnimationHoverSpeed = 0.07!
        Me.btnAgregar.AnimationSpeed = 0.03!
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAgregar.BorderColor = System.Drawing.Color.Transparent
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAgregar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.Appsena.My.Resources.Resources.icons8_joyent_64
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(841, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAgregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAgregar.OnHoverImage = Nothing
        Me.btnAgregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAgregar.Radius = 10
        Me.btnAgregar.Size = New System.Drawing.Size(118, 30)
        Me.btnAgregar.TabIndex = 47
        Me.btnAgregar.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar a los elementos prestados el elemento seleccionado")
        '
        'tabMovimiento
        '
        Me.tabMovimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMovimiento.Controls.Add(Me.tpHistorial)
        Me.tabMovimiento.Controls.Add(Me.tpPrestamo)
        Me.tabMovimiento.Controls.Add(Me.tpHistorialPrestamo)
        Me.tabMovimiento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMovimiento.Location = New System.Drawing.Point(12, 159)
        Me.tabMovimiento.Multiline = True
        Me.tabMovimiento.Name = "tabMovimiento"
        Me.tabMovimiento.SelectedIndex = 0
        Me.tabMovimiento.ShowToolTips = True
        Me.tabMovimiento.Size = New System.Drawing.Size(1342, 560)
        Me.tabMovimiento.TabIndex = 26
        '
        'tpHistorial
        '
        Me.tpHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpHistorial.Controls.Add(Me.dgvHistorial)
        Me.tpHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpHistorial.Location = New System.Drawing.Point(4, 28)
        Me.tpHistorial.Name = "tpHistorial"
        Me.tpHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHistorial.Size = New System.Drawing.Size(1334, 528)
        Me.tpHistorial.TabIndex = 0
        Me.tpHistorial.Text = "Elementos prestados"
        '
        'tpPrestamo
        '
        Me.tpPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpPrestamo.Controls.Add(Me.dtpFechaLimitHora)
        Me.tpPrestamo.Controls.Add(Me.cbxFechalimite)
        Me.tpPrestamo.Controls.Add(Me.dtpFechaLimit)
        Me.tpPrestamo.Controls.Add(Me.lblReservas)
        Me.tpPrestamo.Controls.Add(Me.SplitContainer1)
        Me.tpPrestamo.Controls.Add(Me.txtCantidad)
        Me.tpPrestamo.Controls.Add(Me.Label5)
        Me.tpPrestamo.Controls.Add(Me.cmbTipoPrestamo)
        Me.tpPrestamo.Controls.Add(Me.Label2)
        Me.tpPrestamo.Controls.Add(Me.Label1)
        Me.tpPrestamo.Controls.Add(Me.txtElemento)
        Me.tpPrestamo.Controls.Add(Me.btnAgregar)
        Me.tpPrestamo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpPrestamo.Location = New System.Drawing.Point(4, 28)
        Me.tpPrestamo.Name = "tpPrestamo"
        Me.tpPrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPrestamo.Size = New System.Drawing.Size(1334, 528)
        Me.tpPrestamo.TabIndex = 1
        Me.tpPrestamo.Text = "Prestar elementos"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 69)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1322, 453)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvElementosDispo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1322, 215)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos disponibles"
        '
        'dgvElementosDispo
        '
        Me.dgvElementosDispo.AllowUserToAddRows = False
        Me.dgvElementosDispo.AllowUserToDeleteRows = False
        Me.dgvElementosDispo.AllowUserToResizeColumns = False
        Me.dgvElementosDispo.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvElementosDispo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvElementosDispo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvElementosDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElementosDispo.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvElementosDispo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvElementosDispo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementosDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvElementosDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvElementosDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementosDispo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmElemento, Me.clmCantidad, Me.clmDisponible, Me.clmUbicacion, Me.clmTipoElemento, Me.clmcodtipoele})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElementosDispo.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvElementosDispo.EnableHeadersVisualStyles = False
        Me.dgvElementosDispo.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementosDispo.Location = New System.Drawing.Point(3, 23)
        Me.dgvElementosDispo.Name = "dgvElementosDispo"
        Me.dgvElementosDispo.ReadOnly = True
        Me.dgvElementosDispo.RowHeadersVisible = False
        Me.dgvElementosDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElementosDispo.Size = New System.Drawing.Size(1316, 189)
        Me.dgvElementosDispo.TabIndex = 0
        Me.dgvElementosDispo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvElementosDispo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementosDispo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvElementosDispo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvElementosDispo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvElementosDispo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvElementosDispo.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvElementosDispo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementosDispo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvElementosDispo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvElementosDispo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementosDispo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvElementosDispo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementosDispo.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvElementosDispo.ThemeStyle.ReadOnly = True
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.Height = 22
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementosDispo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmCodigo.FillWeight = 14.75304!
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmElemento
        '
        Me.clmElemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmElemento.FillWeight = 65.76678!
        Me.clmElemento.HeaderText = "Descripción"
        Me.clmElemento.Name = "clmElemento"
        Me.clmElemento.ReadOnly = True
        Me.clmElemento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmCantidad
        '
        Me.clmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmCantidad.FillWeight = 9.388299!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        Me.clmCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmDisponible
        '
        Me.clmDisponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmDisponible.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmDisponible.FillWeight = 11.12092!
        Me.clmDisponible.HeaderText = "Disponible"
        Me.clmDisponible.Name = "clmDisponible"
        Me.clmDisponible.ReadOnly = True
        Me.clmDisponible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmUbicacion
        '
        Me.clmUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmUbicacion.FillWeight = 43.84453!
        Me.clmUbicacion.HeaderText = "Ubicación"
        Me.clmUbicacion.Name = "clmUbicacion"
        Me.clmUbicacion.ReadOnly = True
        Me.clmUbicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmTipoElemento
        '
        Me.clmTipoElemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmTipoElemento.HeaderText = "Tipo"
        Me.clmTipoElemento.Name = "clmTipoElemento"
        Me.clmTipoElemento.ReadOnly = True
        Me.clmTipoElemento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmTipoElemento.Width = 47
        '
        'clmcodtipoele
        '
        Me.clmcodtipoele.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmcodtipoele.FillWeight = 20.26204!
        Me.clmcodtipoele.HeaderText = "codtipoele"
        Me.clmcodtipoele.Name = "clmcodtipoele"
        Me.clmcodtipoele.ReadOnly = True
        Me.clmcodtipoele.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvElementosPrestados)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1322, 234)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elementos prestados"
        '
        'dgvElementosPrestados
        '
        Me.dgvElementosPrestados.AllowUserToAddRows = False
        Me.dgvElementosPrestados.AllowUserToDeleteRows = False
        Me.dgvElementosPrestados.AllowUserToResizeColumns = False
        Me.dgvElementosPrestados.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvElementosPrestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElementosPrestados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvElementosPrestados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvElementosPrestados.CausesValidation = False
        Me.dgvElementosPrestados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementosPrestados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvElementosPrestados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvElementosPrestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementosPrestados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewImageColumn3, Me.DataGridViewImageColumn4, Me.CodTipoElem})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElementosPrestados.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvElementosPrestados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElementosPrestados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgvElementosPrestados.EnableHeadersVisualStyles = False
        Me.dgvElementosPrestados.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementosPrestados.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.dgvElementosPrestados.Location = New System.Drawing.Point(3, 23)
        Me.dgvElementosPrestados.Name = "dgvElementosPrestados"
        Me.dgvElementosPrestados.RowHeadersVisible = False
        Me.dgvElementosPrestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElementosPrestados.Size = New System.Drawing.Size(1316, 208)
        Me.dgvElementosPrestados.TabIndex = 1
        Me.dgvElementosPrestados.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvElementosPrestados.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvElementosPrestados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvElementosPrestados.ThemeStyle.ReadOnly = False
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.Height = 22
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha prestamo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 131
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha límite"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Width = 101
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.FillWeight = 40.0!
        Me.DataGridViewImageColumn3.HeaderText = "Editar"
        Me.DataGridViewImageColumn3.Image = Global.Appsena.My.Resources.Resources.icons8_edit_64
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.Visible = False
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewImageColumn4.FillWeight = 40.0!
        Me.DataGridViewImageColumn4.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn4.Image = Global.Appsena.My.Resources.Resources.icons8_trash_can_64
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.Width = 73
        '
        'CodTipoElem
        '
        Me.CodTipoElem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodTipoElem.HeaderText = "TipoElemento"
        Me.CodTipoElem.Name = "CodTipoElem"
        Me.CodTipoElem.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(189, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Tipo de movimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(743, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Cantidad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(437, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Buscar elemento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpHistorialPrestamo
        '
        Me.tpHistorialPrestamo.Controls.Add(Me.dgvEPrestados)
        Me.tpHistorialPrestamo.Location = New System.Drawing.Point(4, 28)
        Me.tpHistorialPrestamo.Name = "tpHistorialPrestamo"
        Me.tpHistorialPrestamo.Size = New System.Drawing.Size(1334, 528)
        Me.tpHistorialPrestamo.TabIndex = 2
        Me.tpHistorialPrestamo.Text = "Elementos entregados"
        Me.tpHistorialPrestamo.UseVisualStyleBackColor = True
        '
        'dgvEPrestados
        '
        Me.dgvEPrestados.AllowUserToAddRows = False
        Me.dgvEPrestados.AllowUserToDeleteRows = False
        Me.dgvEPrestados.AllowUserToResizeColumns = False
        Me.dgvEPrestados.AllowUserToResizeRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEPrestados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvEPrestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEPrestados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEPrestados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEPrestados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEPrestados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEPrestados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvEPrestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEPrestados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewImageColumn5, Me.DataGridViewImageColumn6, Me.DataGridViewTextBoxColumn21, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn22})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEPrestados.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvEPrestados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEPrestados.EnableHeadersVisualStyles = False
        Me.dgvEPrestados.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEPrestados.Location = New System.Drawing.Point(0, 0)
        Me.dgvEPrestados.Name = "dgvEPrestados"
        Me.dgvEPrestados.ReadOnly = True
        Me.dgvEPrestados.RowHeadersVisible = False
        Me.dgvEPrestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEPrestados.Size = New System.Drawing.Size(1334, 528)
        Me.dgvEPrestados.TabIndex = 2
        Me.dgvEPrestados.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvEPrestados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEPrestados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvEPrestados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEPrestados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvEPrestados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEPrestados.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvEPrestados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEPrestados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvEPrestados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEPrestados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEPrestados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvEPrestados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEPrestados.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvEPrestados.ThemeStyle.ReadOnly = True
        Me.dgvEPrestados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEPrestados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEPrestados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEPrestados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEPrestados.ThemeStyle.RowsStyle.Height = 22
        Me.dgvEPrestados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvEPrestados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Prestamo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Elemento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn13.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 97
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha prestamo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha devolucion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 161
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Consecutivo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "CantidadEntrega"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 66
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewImageColumn5.FillWeight = 45.0!
        Me.DataGridViewImageColumn5.HeaderText = "Ver más"
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn5.Visible = False
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewImageColumn6.FillWeight = 50.0!
        Me.DataGridViewImageColumn6.HeaderText = "Entregar todo"
        Me.DataGridViewImageColumn6.Image = Global.Appsena.My.Resources.Resources.icons8_more_64
        Me.DataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.ReadOnly = True
        Me.DataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn21.HeaderText = "CantidadPrestamo"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.FillWeight = 37.0!
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Seleccionar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.ToolTipText = "Seleccionar un elemento para enviar a mora"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "codTipoEle"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'dgvDuplicar
        '
        Me.dgvDuplicar.AllowUserToAddRows = False
        Me.dgvDuplicar.AllowUserToDeleteRows = False
        Me.dgvDuplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDuplicar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDuplicar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCod, Me.clmnombre, Me.clmcanti, Me.clmobser, Me.clmfechapres, Me.clmfechadevo})
        Me.dgvDuplicar.Location = New System.Drawing.Point(1257, 143)
        Me.dgvDuplicar.Name = "dgvDuplicar"
        Me.dgvDuplicar.ReadOnly = True
        Me.dgvDuplicar.Size = New System.Drawing.Size(90, 27)
        Me.dgvDuplicar.TabIndex = 28
        Me.dgvDuplicar.Visible = False
        '
        'clmCod
        '
        Me.clmCod.HeaderText = "codigo"
        Me.clmCod.Name = "clmCod"
        Me.clmCod.ReadOnly = True
        '
        'clmnombre
        '
        Me.clmnombre.HeaderText = "nombre"
        Me.clmnombre.Name = "clmnombre"
        Me.clmnombre.ReadOnly = True
        '
        'clmcanti
        '
        Me.clmcanti.HeaderText = "cantidad"
        Me.clmcanti.Name = "clmcanti"
        Me.clmcanti.ReadOnly = True
        '
        'clmobser
        '
        Me.clmobser.HeaderText = "observaciones"
        Me.clmobser.Name = "clmobser"
        Me.clmobser.ReadOnly = True
        '
        'clmfechapres
        '
        Me.clmfechapres.HeaderText = "fechapres"
        Me.clmfechapres.Name = "clmfechapres"
        Me.clmfechapres.ReadOnly = True
        '
        'clmfechadevo
        '
        Me.clmfechadevo.HeaderText = "fechadevo"
        Me.clmfechadevo.Name = "clmfechadevo"
        Me.clmfechadevo.ReadOnly = True
        '
        'TimerMora
        '
        Me.TimerMora.Enabled = True
        Me.TimerMora.Interval = 1000
        '
        'TimerSeguro
        '
        Me.TimerSeguro.Enabled = True
        Me.TimerSeguro.Interval = 1000
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 60.0!
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_edit_64
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 91
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 60.0!
        Me.DataGridViewImageColumn2.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn2.Image = Global.Appsena.My.Resources.Resources.icons8_trash_can_64
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Visible = False
        Me.DataGridViewImageColumn2.Width = 90
        '
        'btnEntregarTodo
        '
        Me.btnEntregarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEntregarTodo.AnimationHoverSpeed = 0.07!
        Me.btnEntregarTodo.AnimationSpeed = 0.03!
        Me.btnEntregarTodo.BackColor = System.Drawing.Color.Transparent
        Me.btnEntregarTodo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEntregarTodo.BorderColor = System.Drawing.Color.Transparent
        Me.btnEntregarTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntregarTodo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEntregarTodo.FocusedColor = System.Drawing.Color.Empty
        Me.btnEntregarTodo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregarTodo.ForeColor = System.Drawing.Color.White
        Me.btnEntregarTodo.Image = Global.Appsena.My.Resources.Resources.icons8_basket_64
        Me.btnEntregarTodo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEntregarTodo.Location = New System.Drawing.Point(394, 725)
        Me.btnEntregarTodo.Name = "btnEntregarTodo"
        Me.btnEntregarTodo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEntregarTodo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEntregarTodo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEntregarTodo.OnHoverImage = Nothing
        Me.btnEntregarTodo.OnPressedColor = System.Drawing.Color.Black
        Me.btnEntregarTodo.Radius = 10
        Me.btnEntregarTodo.Size = New System.Drawing.Size(160, 31)
        Me.btnEntregarTodo.TabIndex = 27
        Me.btnEntregarTodo.Text = "Entregar Todo"
        Me.btnEntregarTodo.Visible = False
        '
        'btnEnviarCorreo
        '
        Me.btnEnviarCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarCorreo.AnimationHoverSpeed = 0.07!
        Me.btnEnviarCorreo.AnimationSpeed = 0.03!
        Me.btnEnviarCorreo.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEnviarCorreo.BorderColor = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarCorreo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnviarCorreo.FocusedColor = System.Drawing.Color.Empty
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnEnviarCorreo.Image = Global.Appsena.My.Resources.Resources.icons8_send_64
        Me.btnEnviarCorreo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(915, 725)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEnviarCorreo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnviarCorreo.OnHoverImage = Nothing
        Me.btnEnviarCorreo.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnviarCorreo.Radius = 10
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(230, 31)
        Me.btnEnviarCorreo.TabIndex = 25
        Me.btnEnviarCorreo.Text = "Enviar permiso de salida"
        Me.btnEnviarCorreo.Visible = False
        '
        'btnEntregar
        '
        Me.btnEntregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEntregar.AnimationHoverSpeed = 0.07!
        Me.btnEntregar.AnimationSpeed = 0.03!
        Me.btnEntregar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntregar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEntregar.BorderColor = System.Drawing.Color.Transparent
        Me.btnEntregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEntregar.FocusedColor = System.Drawing.Color.Empty
        Me.btnEntregar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.ForeColor = System.Drawing.Color.White
        Me.btnEntregar.Image = Global.Appsena.My.Resources.Resources.icons8_logout_rounded_left_64
        Me.btnEntregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEntregar.Location = New System.Drawing.Point(205, 725)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEntregar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEntregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEntregar.OnHoverImage = Nothing
        Me.btnEntregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnEntregar.Radius = 10
        Me.btnEntregar.Size = New System.Drawing.Size(183, 31)
        Me.btnEntregar.TabIndex = 24
        Me.btnEntregar.Text = "Recibir elementos"
        '
        'btnDuplicarPrestamo
        '
        Me.btnDuplicarPrestamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDuplicarPrestamo.AnimationHoverSpeed = 0.07!
        Me.btnDuplicarPrestamo.AnimationSpeed = 0.03!
        Me.btnDuplicarPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnDuplicarPrestamo.BorderColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDuplicarPrestamo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDuplicarPrestamo.FocusedColor = System.Drawing.Color.Empty
        Me.btnDuplicarPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicarPrestamo.ForeColor = System.Drawing.Color.White
        Me.btnDuplicarPrestamo.Image = Global.Appsena.My.Resources.Resources.icons8_duplicate_64
        Me.btnDuplicarPrestamo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDuplicarPrestamo.Location = New System.Drawing.Point(1151, 725)
        Me.btnDuplicarPrestamo.Name = "btnDuplicarPrestamo"
        Me.btnDuplicarPrestamo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDuplicarPrestamo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDuplicarPrestamo.OnHoverImage = Nothing
        Me.btnDuplicarPrestamo.OnPressedColor = System.Drawing.Color.Black
        Me.btnDuplicarPrestamo.Radius = 10
        Me.btnDuplicarPrestamo.Size = New System.Drawing.Size(203, 31)
        Me.btnDuplicarPrestamo.TabIndex = 23
        Me.btnDuplicarPrestamo.Text = "Duplicar movimiento"
        '
        'btnPrestarElementos
        '
        Me.btnPrestarElementos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrestarElementos.AnimationHoverSpeed = 0.07!
        Me.btnPrestarElementos.AnimationSpeed = 0.03!
        Me.btnPrestarElementos.BackColor = System.Drawing.Color.Transparent
        Me.btnPrestarElementos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnPrestarElementos.BorderColor = System.Drawing.Color.Transparent
        Me.btnPrestarElementos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrestarElementos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrestarElementos.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrestarElementos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestarElementos.ForeColor = System.Drawing.Color.White
        Me.btnPrestarElementos.Image = Global.Appsena.My.Resources.Resources.icons8_save_641
        Me.btnPrestarElementos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrestarElementos.Location = New System.Drawing.Point(12, 725)
        Me.btnPrestarElementos.Name = "btnPrestarElementos"
        Me.btnPrestarElementos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnPrestarElementos.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnPrestarElementos.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrestarElementos.OnHoverImage = Nothing
        Me.btnPrestarElementos.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrestarElementos.Radius = 10
        Me.btnPrestarElementos.Size = New System.Drawing.Size(187, 31)
        Me.btnPrestarElementos.TabIndex = 22
        Me.btnPrestarElementos.Text = "Prestar elementos"
        '
        'TimerFechaLimite
        '
        '
        'frmMovimientos_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnEnviarAMora)
        Me.Controls.Add(Me.dgvDuplicar)
        Me.Controls.Add(Me.btnEntregarTodo)
        Me.Controls.Add(Me.tabMovimiento)
        Me.Controls.Add(Me.btnEnviarCorreo)
        Me.Controls.Add(Me.btnEntregar)
        Me.Controls.Add(Me.btnDuplicarPrestamo)
        Me.Controls.Add(Me.btnPrestarElementos)
        Me.Controls.Add(Me.gbxCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo movimiento"
        Me.gbxCliente.ResumeLayout(False)
        Me.gbxCliente.PerformLayout()
        Me.pnlPrestamoInfo.ResumeLayout(False)
        Me.pnlPrestamoInfo.PerformLayout()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMovimiento.ResumeLayout(False)
        Me.tpHistorial.ResumeLayout(False)
        Me.tpPrestamo.ResumeLayout(False)
        Me.tpPrestamo.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvElementosDispo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvElementosPrestados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHistorialPrestamo.ResumeLayout(False)
        CType(Me.dgvEPrestados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDuplicar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombresNom As Label
    Friend WithEvents lblDocidNom As Label
    Friend WithEvents gbxCliente As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblNumFicha As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblDocid As Label
    Friend WithEvents lblFicha As Label
    Friend WithEvents lblTipoDocid As Label
    Friend WithEvents lblTipoDocidNom As Label
    Friend WithEvents btnPrestarElementos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDuplicarPrestamo As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaImageReplaceColor1 As Guna.UI.WinForms.GunaImageReplaceColor
    Friend WithEvents dgvHistorial As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnEntregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnEnviarCorreo As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents tabMovimiento As TabControl
    Friend WithEvents tpHistorial As TabPage
    Friend WithEvents tpPrestamo As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvElementosDispo As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvElementosPrestados As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtCantidad As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoPrestamo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnAgregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtElemento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblReservas As Label
    Friend WithEvents btnEntregarTodo As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvDuplicar As DataGridView
    Friend WithEvents clmCod As DataGridViewTextBoxColumn
    Friend WithEvents clmnombre As DataGridViewTextBoxColumn
    Friend WithEvents clmcanti As DataGridViewTextBoxColumn
    Friend WithEvents clmobser As DataGridViewTextBoxColumn
    Friend WithEvents clmfechapres As DataGridViewTextBoxColumn
    Friend WithEvents clmfechadevo As DataGridViewTextBoxColumn
    Friend WithEvents btnEditarPerfil As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCambiarCliente As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEnviarAMora As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAlertaMora As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents TimerMora As Timer
    Friend WithEvents ptbFotoCliente As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents tpHistorialPrestamo As TabPage
    Friend WithEvents dgvEPrestados As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents dtpFechaLimit As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cbxFechalimite As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents dtpFechaLimitHora As DateTimePicker
    Friend WithEvents TimerSeguro As Timer
    Friend WithEvents clmCodPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents clFechaPres As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPresta As DataGridViewTextBoxColumn
    Friend WithEvents clmObserva As DataGridViewTextBoxColumn
    Friend WithEvents clmestado As DataGridViewTextBoxColumn
    Friend WithEvents clmConsecutivo As DataGridViewTextBoxColumn
    Friend WithEvents clmCantiEntrega As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoelemt As DataGridViewTextBoxColumn
    Friend WithEvents clmCadaUno As DataGridViewImageColumn
    Friend WithEvents clmEntregarTodo As DataGridViewImageColumn
    Friend WithEvents clmCantidadPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmCheck As DataGridViewCheckBoxColumn
    Friend WithEvents codtipo As DataGridViewTextBoxColumn
    Friend WithEvents lblTipoprestamo As Label
    Friend WithEvents lblCodPres As Label
    Friend WithEvents clmCodigo As DataGridViewTextBoxColumn
    Friend WithEvents clmElemento As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmDisponible As DataGridViewTextBoxColumn
    Friend WithEvents clmUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoElemento As DataGridViewTextBoxColumn
    Friend WithEvents clmcodtipoele As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents CodTipoElem As DataGridViewTextBoxColumn
    Friend WithEvents lblFormatoSalida As LinkLabel
    Friend WithEvents lblFechaLimit As Label
    Friend WithEvents lblTpr As Label
    Friend WithEvents Separadorgbx As Panel
    Friend WithEvents dtpFechaLimite As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblSeguro As LinkLabel
    Friend WithEvents pnlPrestamoInfo As Panel
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents TimerFechaLimite As Timer
    Friend WithEvents lblTraspaso As LinkLabel
End Class
