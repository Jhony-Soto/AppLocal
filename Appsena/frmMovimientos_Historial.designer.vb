<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_Historial
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Historial))
        Me.PrestamosMenu = New System.Windows.Forms.MenuStrip()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPrestamos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDocidCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAdmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaPres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaDEV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaInicial = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblEncabezado = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresNom = New System.Windows.Forms.Label()
        Me.lblTipoClienteNom = New System.Windows.Forms.Label()
        Me.lnkCambiarCliente = New Guna.UI.WinForms.GunaLinkLabel()
        Me.lblTipoCliente = New System.Windows.Forms.Label()
        Me.lnkDetalleCliente = New Guna.UI.WinForms.GunaLinkLabel()
        Me.lblDocid = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscarHistorial = New Guna.UI.WinForms.GunaButton()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.PrestamosMenu.SuspendLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrestamosMenu
        '
        Me.PrestamosMenu.BackColor = System.Drawing.SystemColors.Control
        Me.PrestamosMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialToolStripMenuItem})
        Me.PrestamosMenu.Location = New System.Drawing.Point(0, 0)
        Me.PrestamosMenu.Name = "PrestamosMenu"
        Me.PrestamosMenu.Size = New System.Drawing.Size(1366, 27)
        Me.PrestamosMenu.TabIndex = 59
        Me.PrestamosMenu.Text = "MenuStrip1"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HistorialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialGeneralToolStripMenuItem, Me.HistorialPorToolStripMenuItem})
        Me.HistorialToolStripMenuItem.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_activity_history_64
        Me.HistorialToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(97, 23)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        Me.HistorialToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.HistorialToolStripMenuItem.ToolTipText = "Cargar historiales de prestamos"
        '
        'HistorialGeneralToolStripMenuItem
        '
        Me.HistorialGeneralToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_order_history_64
        Me.HistorialGeneralToolStripMenuItem.Name = "HistorialGeneralToolStripMenuItem"
        Me.HistorialGeneralToolStripMenuItem.Size = New System.Drawing.Size(334, 24)
        Me.HistorialGeneralToolStripMenuItem.Text = "Historial general"
        Me.HistorialGeneralToolStripMenuItem.ToolTipText = "Mostrar todos los prestamos entre dos fechas"
        '
        'HistorialPorToolStripMenuItem
        '
        Me.HistorialPorToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_user_folder_64
        Me.HistorialPorToolStripMenuItem.Name = "HistorialPorToolStripMenuItem"
        Me.HistorialPorToolStripMenuItem.Size = New System.Drawing.Size(334, 24)
        Me.HistorialPorToolStripMenuItem.Text = "Historial de prestamos por cliente  "
        Me.HistorialPorToolStripMenuItem.ToolTipText = "Mostrar los prestamos de un cliente específico entre dos fechas"
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.AllowUserToAddRows = False
        Me.dgvPrestamos.AllowUserToDeleteRows = False
        Me.dgvPrestamos.AllowUserToResizeColumns = False
        Me.dgvPrestamos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPrestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrestamos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(115, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrestamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrestamos.ColumnHeadersHeight = 28
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmPrestamo, Me.clmDocidCliente, Me.clmCliente, Me.clmTipoCliente, Me.clmAdmin, Me.clmTipoPrestamo, Me.clmEstado, Me.clmFechaPres, Me.clmFechaDEV})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrestamos.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPrestamos.EnableHeadersVisualStyles = False
        Me.dgvPrestamos.GridColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.Location = New System.Drawing.Point(12, 146)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrestamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPrestamos.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvPrestamos.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPrestamos.Size = New System.Drawing.Size(1342, 610)
        Me.dgvPrestamos.TabIndex = 60
        Me.dgvPrestamos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPrestamos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.GridColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.Height = 28
        Me.dgvPrestamos.ThemeStyle.ReadOnly = True
        Me.dgvPrestamos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPrestamos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvPrestamos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvPrestamos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clmPrestamo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmPrestamo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmPrestamo.FillWeight = 80.0!
        Me.clmPrestamo.HeaderText = "Movimiento"
        Me.clmPrestamo.Name = "clmPrestamo"
        Me.clmPrestamo.ReadOnly = True
        Me.clmPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmDocidCliente
        '
        Me.clmDocidCliente.HeaderText = "Documento"
        Me.clmDocidCliente.Name = "clmDocidCliente"
        Me.clmDocidCliente.ReadOnly = True
        '
        'clmCliente
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmCliente.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmCliente.FillWeight = 150.0!
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTipoCliente
        '
        Me.clmTipoCliente.FillWeight = 90.0!
        Me.clmTipoCliente.HeaderText = "Tipo cliente"
        Me.clmTipoCliente.Name = "clmTipoCliente"
        Me.clmTipoCliente.ReadOnly = True
        '
        'clmAdmin
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmAdmin.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmAdmin.FillWeight = 120.0!
        Me.clmAdmin.HeaderText = "Administrador"
        Me.clmAdmin.Name = "clmAdmin"
        Me.clmAdmin.ReadOnly = True
        Me.clmAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTipoPrestamo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmTipoPrestamo.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmTipoPrestamo.HeaderText = "Tipo movimiento"
        Me.clmTipoPrestamo.Name = "clmTipoPrestamo"
        Me.clmTipoPrestamo.ReadOnly = True
        Me.clmTipoPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmEstado
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmEstado.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmEstado.FillWeight = 50.0!
        Me.clmEstado.HeaderText = "Estado"
        Me.clmEstado.Name = "clmEstado"
        Me.clmEstado.ReadOnly = True
        Me.clmEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmFechaPres
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmFechaPres.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmFechaPres.HeaderText = "Fecha prestamo"
        Me.clmFechaPres.Name = "clmFechaPres"
        Me.clmFechaPres.ReadOnly = True
        Me.clmFechaPres.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmFechaDEV
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmFechaDEV.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmFechaDEV.HeaderText = "Fecha devolución"
        Me.clmFechaDEV.Name = "clmFechaDEV"
        Me.clmFechaDEV.ReadOnly = True
        Me.clmFechaDEV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaInicial.BackColor = System.Drawing.Color.Transparent
        Me.dtpFechaInicial.BaseColor = System.Drawing.Color.White
        Me.dtpFechaInicial.BorderColor = System.Drawing.Color.Silver
        Me.dtpFechaInicial.Checked = False
        Me.dtpFechaInicial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaInicial.CustomFormat = "d 'de' MMMM yyyy"
        Me.dtpFechaInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaInicial.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFechaInicial.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicial.ForeColor = System.Drawing.Color.Black
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicial.Location = New System.Drawing.Point(413, 89)
        Me.dtpFechaInicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFechaInicial.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpFechaInicial.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpFechaInicial.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFechaInicial.Radius = 10
        Me.dtpFechaInicial.Size = New System.Drawing.Size(223, 30)
        Me.dtpFechaInicial.TabIndex = 61
        Me.dtpFechaInicial.Text = "15 de abril 2020"
        Me.ToolTip1.SetToolTip(Me.dtpFechaInicial, "Fecha inicial para la busqueda de prestamos")
        Me.dtpFechaInicial.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFechaInicial.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicial.ForeColor = System.Drawing.Color.Black
        Me.lblFechaInicial.Location = New System.Drawing.Point(413, 67)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(223, 19)
        Me.lblFechaInicial.TabIndex = 62
        Me.lblFechaInicial.Text = "Fecha inicial"
        Me.lblFechaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFechaFinal.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinal.ForeColor = System.Drawing.Color.Black
        Me.lblFechaFinal.Location = New System.Drawing.Point(642, 67)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(223, 19)
        Me.lblFechaFinal.TabIndex = 64
        Me.lblFechaFinal.Text = "Fecha final"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaFinal.BackColor = System.Drawing.Color.Transparent
        Me.dtpFechaFinal.BaseColor = System.Drawing.Color.White
        Me.dtpFechaFinal.BorderColor = System.Drawing.Color.Silver
        Me.dtpFechaFinal.Checked = False
        Me.dtpFechaFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaFinal.CustomFormat = "d 'de' MMMM yyyy"
        Me.dtpFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaFinal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.ForeColor = System.Drawing.Color.Black
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFinal.Location = New System.Drawing.Point(642, 89)
        Me.dtpFechaFinal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaFinal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFechaFinal.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpFechaFinal.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpFechaFinal.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFechaFinal.Radius = 10
        Me.dtpFechaFinal.Size = New System.Drawing.Size(223, 30)
        Me.dtpFechaFinal.TabIndex = 63
        Me.dtpFechaFinal.Text = "15 de abril 2020"
        Me.ToolTip1.SetToolTip(Me.dtpFechaFinal, "Fecha final para la busqueda de prestamos")
        Me.dtpFechaFinal.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        '
        'lblEncabezado
        '
        Me.lblEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncabezado.BackColor = System.Drawing.Color.Transparent
        Me.lblEncabezado.Font = New System.Drawing.Font("Zurich BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.Black
        Me.lblEncabezado.Location = New System.Drawing.Point(12, 27)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(1342, 33)
        Me.lblEncabezado.TabIndex = 65
        Me.lblEncabezado.Text = "Texto"
        Me.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.Black
        Me.lblNombres.Location = New System.Drawing.Point(12, 60)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(85, 19)
        Me.lblNombres.TabIndex = 67
        Me.lblNombres.Text = "Nombres:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombresNom
        '
        Me.lblNombresNom.AutoSize = True
        Me.lblNombresNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresNom.ForeColor = System.Drawing.Color.Black
        Me.lblNombresNom.Location = New System.Drawing.Point(103, 60)
        Me.lblNombresNom.Name = "lblNombresNom"
        Me.lblNombresNom.Size = New System.Drawing.Size(189, 19)
        Me.lblNombresNom.TabIndex = 69
        Me.lblNombresNom.Text = "ALFREDO ALIRIO PEREZ"
        Me.lblNombresNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoClienteNom
        '
        Me.lblTipoClienteNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoClienteNom.AutoSize = True
        Me.lblTipoClienteNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoClienteNom.ForeColor = System.Drawing.Color.Black
        Me.lblTipoClienteNom.Location = New System.Drawing.Point(139, 89)
        Me.lblTipoClienteNom.Name = "lblTipoClienteNom"
        Me.lblTipoClienteNom.Size = New System.Drawing.Size(75, 19)
        Me.lblTipoClienteNom.TabIndex = 70
        Me.lblTipoClienteNom.Text = "Aprendiz"
        Me.lblTipoClienteNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkCambiarCliente
        '
        Me.lnkCambiarCliente.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lnkCambiarCliente.AutoSize = True
        Me.lnkCambiarCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCambiarCliente.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lnkCambiarCliente.Location = New System.Drawing.Point(10, 114)
        Me.lnkCambiarCliente.Name = "lnkCambiarCliente"
        Me.lnkCambiarCliente.Size = New System.Drawing.Size(145, 19)
        Me.lnkCambiarCliente.TabIndex = 71
        Me.lnkCambiarCliente.TabStop = True
        Me.lnkCambiarCliente.Text = "Buscar otro cliente"
        Me.lnkCambiarCliente.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        Me.ToolTip1.SetToolTip(Me.lnkCambiarCliente, "Buscar el historial de otro cliente")
        Me.lnkCambiarCliente.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        '
        'lblTipoCliente
        '
        Me.lblTipoCliente.AutoSize = True
        Me.lblTipoCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCliente.ForeColor = System.Drawing.Color.Black
        Me.lblTipoCliente.Location = New System.Drawing.Point(12, 89)
        Me.lblTipoCliente.Name = "lblTipoCliente"
        Me.lblTipoCliente.Size = New System.Drawing.Size(127, 19)
        Me.lblTipoCliente.TabIndex = 72
        Me.lblTipoCliente.Text = "Tipo de Cliente:"
        Me.lblTipoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkDetalleCliente
        '
        Me.lnkDetalleCliente.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lnkDetalleCliente.AutoSize = True
        Me.lnkDetalleCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkDetalleCliente.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lnkDetalleCliente.Location = New System.Drawing.Point(233, 89)
        Me.lnkDetalleCliente.Name = "lnkDetalleCliente"
        Me.lnkDetalleCliente.Size = New System.Drawing.Size(59, 19)
        Me.lnkDetalleCliente.TabIndex = 73
        Me.lnkDetalleCliente.TabStop = True
        Me.lnkDetalleCliente.Text = "Detalle"
        Me.lnkDetalleCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDetalleCliente.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        Me.ToolTip1.SetToolTip(Me.lnkDetalleCliente, "Ver más información del cliente")
        Me.lnkDetalleCliente.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        '
        'lblDocid
        '
        Me.lblDocid.AutoSize = True
        Me.lblDocid.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocid.ForeColor = System.Drawing.Color.Black
        Me.lblDocid.Location = New System.Drawing.Point(161, 114)
        Me.lblDocid.Name = "lblDocid"
        Me.lblDocid.Size = New System.Drawing.Size(99, 19)
        Me.lblDocid.TabIndex = 74
        Me.lblDocid.Text = "1000415537"
        Me.lblDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDocid.Visible = False
        '
        'btnBuscarHistorial
        '
        Me.btnBuscarHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscarHistorial.AnimationHoverSpeed = 0.07!
        Me.btnBuscarHistorial.AnimationSpeed = 0.03!
        Me.btnBuscarHistorial.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarHistorial.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBuscarHistorial.BorderColor = System.Drawing.Color.Transparent
        Me.btnBuscarHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarHistorial.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscarHistorial.FocusedColor = System.Drawing.Color.Empty
        Me.btnBuscarHistorial.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarHistorial.ForeColor = System.Drawing.Color.White
        Me.btnBuscarHistorial.Image = Global.Appsena.My.Resources.Resources.icons8_search_64
        Me.btnBuscarHistorial.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBuscarHistorial.Location = New System.Drawing.Point(871, 88)
        Me.btnBuscarHistorial.Name = "btnBuscarHistorial"
        Me.btnBuscarHistorial.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBuscarHistorial.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnBuscarHistorial.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBuscarHistorial.OnHoverImage = Nothing
        Me.btnBuscarHistorial.OnPressedColor = System.Drawing.Color.Black
        Me.btnBuscarHistorial.Radius = 10
        Me.btnBuscarHistorial.Size = New System.Drawing.Size(165, 31)
        Me.btnBuscarHistorial.TabIndex = 66
        Me.btnBuscarHistorial.Text = "Buscar historial"
        Me.ToolTip1.SetToolTip(Me.btnBuscarHistorial, "Mostrar los prestamos")
        '
        'btnexportar
        '
        Me.btnexportar.AnimationHoverSpeed = 0.07!
        Me.btnexportar.AnimationSpeed = 0.03!
        Me.btnexportar.BackColor = System.Drawing.Color.Transparent
        Me.btnexportar.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnexportar.BorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexportar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexportar.FocusedColor = System.Drawing.Color.Empty
        Me.btnexportar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexportar.ForeColor = System.Drawing.Color.Black
        Me.btnexportar.Image = Global.Appsena.My.Resources.Resources.icons8_download_64
        Me.btnexportar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnexportar.Location = New System.Drawing.Point(16, 14)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Radius = 10
        Me.btnexportar.Size = New System.Drawing.Size(218, 43)
        Me.btnexportar.TabIndex = 152
        Me.btnexportar.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte")
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(1279, 119)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(75, 21)
        Me.dgexportar.TabIndex = 153
        Me.dgexportar.Visible = False
        '
        'frmMovimientos_Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.lblDocid)
        Me.Controls.Add(Me.lnkDetalleCliente)
        Me.Controls.Add(Me.lblTipoCliente)
        Me.Controls.Add(Me.lnkCambiarCliente)
        Me.Controls.Add(Me.lblTipoClienteNom)
        Me.Controls.Add(Me.lblNombresNom)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblEncabezado)
        Me.Controls.Add(Me.btnBuscarHistorial)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.lblFechaInicial)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.dgvPrestamos)
        Me.Controls.Add(Me.PrestamosMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_Historial"
        Me.Text = "frmMovimientos_Historial"
        Me.PrestamosMenu.ResumeLayout(False)
        Me.PrestamosMenu.PerformLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrestamosMenu As MenuStrip
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialPorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvPrestamos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents clmPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmDocidCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmAdmin As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmEstado As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPres As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaDEV As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaInicial As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblFechaInicial As Label
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents dtpFechaFinal As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblEncabezado As Label
    Friend WithEvents btnBuscarHistorial As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresNom As Label
    Friend WithEvents lblTipoClienteNom As Label
    Friend WithEvents lnkCambiarCliente As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lblTipoCliente As Label
    Friend WithEvents lnkDetalleCliente As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lblDocid As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgexportar As DataGridView
End Class
