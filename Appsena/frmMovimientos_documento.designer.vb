<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientos_documento
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_documento))
        Me.txtDocumento = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxTodosPresAct = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnCambiarCliente = New Guna.UI.WinForms.GunaButton()
        Me.btnDuplicarPrestamo = New Guna.UI.WinForms.GunaButton()
        Me.btnBuscar = New Guna.UI.WinForms.GunaButton()
        Me.cbxTodos = New Guna.UI.WinForms.GunaCheckBox()
        Me.txtBuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbTipoCliente = New Guna.UI.WinForms.GunaComboBox()
        Me.PrestamosMenu = New System.Windows.Forms.MenuStrip()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBuscar = New System.Windows.Forms.Panel()
        Me.lblBuscador = New System.Windows.Forms.Label()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrestamosMenu.SuspendLayout()
        Me.pnlBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDocumento
        '
        Me.txtDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDocumento.BackColor = System.Drawing.Color.Transparent
        Me.txtDocumento.BaseColor = System.Drawing.Color.White
        Me.txtDocumento.BorderColor = System.Drawing.Color.Silver
        Me.txtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocumento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(519, 38)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocumento.Radius = 10
        Me.txtDocumento.Size = New System.Drawing.Size(327, 30)
        Me.txtDocumento.TabIndex = 5
        Me.txtDocumento.Tag = "1"
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtDocumento, "Hacer un nuevo movimiento")
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número del Documento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgvPrestamos.Location = New System.Drawing.Point(12, 187)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.ReadOnly = True
        Me.dgvPrestamos.RowHeadersVisible = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvPrestamos.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPrestamos.Size = New System.Drawing.Size(1342, 569)
        Me.dgvPrestamos.TabIndex = 7
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
        Me.clmPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmPrestamo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmPrestamo.FillWeight = 80.0!
        Me.clmPrestamo.HeaderText = "Movimiento"
        Me.clmPrestamo.Name = "clmPrestamo"
        Me.clmPrestamo.ReadOnly = True
        Me.clmPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmPrestamo.Width = 121
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
        Me.clmTipoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clmTipoCliente.FillWeight = 90.0!
        Me.clmTipoCliente.HeaderText = "Tipo cliente"
        Me.clmTipoCliente.Name = "clmTipoCliente"
        Me.clmTipoCliente.ReadOnly = True
        Me.clmTipoCliente.Width = 118
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
        Me.clmTipoPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmTipoPrestamo.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmTipoPrestamo.HeaderText = "Tipo movimiento"
        Me.clmTipoPrestamo.Name = "clmTipoPrestamo"
        Me.clmTipoPrestamo.ReadOnly = True
        Me.clmTipoPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTipoPrestamo.Width = 157
        '
        'clmEstado
        '
        Me.clmEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmEstado.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmEstado.FillWeight = 50.0!
        Me.clmEstado.HeaderText = "Estado"
        Me.clmEstado.Name = "clmEstado"
        Me.clmEstado.ReadOnly = True
        Me.clmEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmEstado.Width = 81
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
        'cbxTodosPresAct
        '
        Me.cbxTodosPresAct.BaseColor = System.Drawing.Color.White
        Me.cbxTodosPresAct.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbxTodosPresAct.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxTodosPresAct.FillColor = System.Drawing.Color.White
        Me.cbxTodosPresAct.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTodosPresAct.Location = New System.Drawing.Point(12, 4)
        Me.cbxTodosPresAct.Name = "cbxTodosPresAct"
        Me.cbxTodosPresAct.Size = New System.Drawing.Size(249, 23)
        Me.cbxTodosPresAct.TabIndex = 57
        Me.cbxTodosPresAct.Text = "Todos los prestamos activos"
        Me.ToolTip1.SetToolTip(Me.cbxTodosPresAct, "Muestra todos los prestamos que hay activos hasta la fecha")
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
        Me.btnCambiarCliente.Location = New System.Drawing.Point(1166, 113)
        Me.btnCambiarCliente.Name = "btnCambiarCliente"
        Me.btnCambiarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCambiarCliente.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCambiarCliente.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCambiarCliente.OnHoverImage = Nothing
        Me.btnCambiarCliente.OnPressedColor = System.Drawing.Color.Black
        Me.btnCambiarCliente.Radius = 10
        Me.btnCambiarCliente.Size = New System.Drawing.Size(188, 31)
        Me.btnCambiarCliente.TabIndex = 55
        Me.btnCambiarCliente.Text = "Cambiar de cliente"
        Me.ToolTip1.SetToolTip(Me.btnCambiarCliente, "Duplicar un prestamo")
        Me.btnCambiarCliente.Visible = False
        '
        'btnDuplicarPrestamo
        '
        Me.btnDuplicarPrestamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDuplicarPrestamo.AnimationHoverSpeed = 0.07!
        Me.btnDuplicarPrestamo.AnimationSpeed = 0.03!
        Me.btnDuplicarPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDuplicarPrestamo.BorderColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDuplicarPrestamo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDuplicarPrestamo.FocusedColor = System.Drawing.Color.Empty
        Me.btnDuplicarPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicarPrestamo.ForeColor = System.Drawing.Color.White
        Me.btnDuplicarPrestamo.Image = Global.Appsena.My.Resources.Resources.icons8_duplicate_64
        Me.btnDuplicarPrestamo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDuplicarPrestamo.Location = New System.Drawing.Point(1151, 150)
        Me.btnDuplicarPrestamo.Name = "btnDuplicarPrestamo"
        Me.btnDuplicarPrestamo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnDuplicarPrestamo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDuplicarPrestamo.OnHoverImage = Nothing
        Me.btnDuplicarPrestamo.OnPressedColor = System.Drawing.Color.Black
        Me.btnDuplicarPrestamo.Radius = 10
        Me.btnDuplicarPrestamo.Size = New System.Drawing.Size(203, 31)
        Me.btnDuplicarPrestamo.TabIndex = 24
        Me.btnDuplicarPrestamo.Text = "Duplicar movimiento"
        Me.ToolTip1.SetToolTip(Me.btnDuplicarPrestamo, "Duplicar un prestamo")
        '
        'btnBuscar
        '
        Me.btnBuscar.AnimationHoverSpeed = 0.07!
        Me.btnBuscar.AnimationSpeed = 0.03!
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBuscar.BorderColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscar.FocusedColor = System.Drawing.Color.Empty
        Me.btnBuscar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.Appsena.My.Resources.Resources.icons8_search_64
        Me.btnBuscar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBuscar.Location = New System.Drawing.Point(12, 150)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnBuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBuscar.OnHoverImage = Nothing
        Me.btnBuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnBuscar.Radius = 10
        Me.btnBuscar.Size = New System.Drawing.Size(103, 31)
        Me.btnBuscar.TabIndex = 61
        Me.btnBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Duplicar un prestamo")
        '
        'cbxTodos
        '
        Me.cbxTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxTodos.BaseColor = System.Drawing.Color.White
        Me.cbxTodos.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbxTodos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxTodos.FillColor = System.Drawing.Color.White
        Me.cbxTodos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTodos.Location = New System.Drawing.Point(158, 11)
        Me.cbxTodos.Name = "cbxTodos"
        Me.cbxTodos.Size = New System.Drawing.Size(79, 23)
        Me.cbxTodos.TabIndex = 61
        Me.cbxTodos.Text = "Todos"
        Me.ToolTip1.SetToolTip(Me.cbxTodos, "Mostrar todos los prestamos de hoy")
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtBuscador.BaseColor = System.Drawing.Color.White
        Me.txtBuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBuscador.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtBuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBuscador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(255, 33)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscador.Radius = 10
        Me.txtBuscador.Size = New System.Drawing.Size(327, 30)
        Me.txtBuscador.TabIndex = 59
        Me.txtBuscador.Tag = "1"
        Me.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtBuscador, "Buscar movimiento por cliente")
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbTipoCliente.BaseColor = System.Drawing.Color.White
        Me.cmbTipoCliente.BorderColor = System.Drawing.Color.Silver
        Me.cmbTipoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTipoCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoCliente.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cmbTipoCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCliente.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoCliente.FormattingEnabled = True
        Me.cmbTipoCliente.Location = New System.Drawing.Point(3, 36)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbTipoCliente.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbTipoCliente.Radius = 10
        Me.cmbTipoCliente.Size = New System.Drawing.Size(234, 28)
        Me.cmbTipoCliente.TabIndex = 58
        Me.cmbTipoCliente.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.ToolTip1.SetToolTip(Me.cmbTipoCliente, "Filtrar por tipo de cliente")
        '
        'PrestamosMenu
        '
        Me.PrestamosMenu.BackColor = System.Drawing.SystemColors.Control
        Me.PrestamosMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialToolStripMenuItem})
        Me.PrestamosMenu.Location = New System.Drawing.Point(0, 0)
        Me.PrestamosMenu.Name = "PrestamosMenu"
        Me.PrestamosMenu.Size = New System.Drawing.Size(1366, 27)
        Me.PrestamosMenu.TabIndex = 60
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
        '
        'HistorialGeneralToolStripMenuItem
        '
        Me.HistorialGeneralToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_order_history_64
        Me.HistorialGeneralToolStripMenuItem.Name = "HistorialGeneralToolStripMenuItem"
        Me.HistorialGeneralToolStripMenuItem.Size = New System.Drawing.Size(334, 24)
        Me.HistorialGeneralToolStripMenuItem.Text = "Historial general"
        '
        'HistorialPorToolStripMenuItem
        '
        Me.HistorialPorToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_user_folder_64
        Me.HistorialPorToolStripMenuItem.Name = "HistorialPorToolStripMenuItem"
        Me.HistorialPorToolStripMenuItem.Size = New System.Drawing.Size(334, 24)
        Me.HistorialPorToolStripMenuItem.Text = "Historial de prestamos por cliente  "
        '
        'pnlBuscar
        '
        Me.pnlBuscar.Controls.Add(Me.cbxTodos)
        Me.pnlBuscar.Controls.Add(Me.lblBuscador)
        Me.pnlBuscar.Controls.Add(Me.txtBuscador)
        Me.pnlBuscar.Controls.Add(Me.cmbTipoCliente)
        Me.pnlBuscar.Controls.Add(Me.lblFiltrar)
        Me.pnlBuscar.Location = New System.Drawing.Point(12, 114)
        Me.pnlBuscar.Name = "pnlBuscar"
        Me.pnlBuscar.Size = New System.Drawing.Size(588, 67)
        Me.pnlBuscar.TabIndex = 62
        Me.pnlBuscar.Visible = False
        '
        'lblBuscador
        '
        Me.lblBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBuscador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscador.Location = New System.Drawing.Point(255, 11)
        Me.lblBuscador.Name = "lblBuscador"
        Me.lblBuscador.Size = New System.Drawing.Size(327, 19)
        Me.lblBuscador.TabIndex = 60
        Me.lblBuscador.Text = "Buscador"
        Me.lblBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFiltrar
        '
        Me.lblFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFiltrar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrar.Location = New System.Drawing.Point(3, 14)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(234, 19)
        Me.lblFiltrar.TabIndex = 57
        Me.lblFiltrar.Text = "Filtrar"
        Me.lblFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMovimientos_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbxTodosPresAct)
        Me.Controls.Add(Me.btnCambiarCliente)
        Me.Controls.Add(Me.btnDuplicarPrestamo)
        Me.Controls.Add(Me.dgvPrestamos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.PrestamosMenu)
        Me.Controls.Add(Me.pnlBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_documento"
        Me.Text = "Movimientos"
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrestamosMenu.ResumeLayout(False)
        Me.PrestamosMenu.PerformLayout()
        Me.pnlBuscar.ResumeLayout(False)
        Me.pnlBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDocumento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPrestamos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnDuplicarPrestamo As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnCambiarCliente As Guna.UI.WinForms.GunaButton
    Friend WithEvents cbxTodosPresAct As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents PrestamosMenu As MenuStrip
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialPorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents clmPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmDocidCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmAdmin As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmEstado As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPres As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaDEV As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlBuscar As Panel
    Friend WithEvents cbxTodos As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents lblBuscador As Label
    Friend WithEvents txtBuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmbTipoCliente As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblFiltrar As Label
End Class
