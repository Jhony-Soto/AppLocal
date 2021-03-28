<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_bajas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_bajas))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.items_bajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasActualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasDefinitivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.items_historial = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElementosConsumidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.group_tipos = New Guna.UI.WinForms.GunaGroupBox()
        Me.mora = New System.Windows.Forms.Label()
        Me.check_definitivas = New Guna.UI.WinForms.GunaCheckBox()
        Me.activos = New System.Windows.Forms.Label()
        Me.check_reintegros = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnbuscar = New Guna.UI.WinForms.GunaButton()
        Me.pnl_fechas = New System.Windows.Forms.Panel()
        Me.picker_dia_inicial = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.picker_dia_final = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lbliniciaol = New System.Windows.Forms.Label()
        Me.lblfinal = New System.Windows.Forms.Label()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.group_tipos.SuspendLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_fechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdatos.BackgroundColor = System.Drawing.Color.White
        Me.dgdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdatos.ColumnHeadersHeight = 40
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmeliminar, Me.Column1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdatos.Location = New System.Drawing.Point(12, 179)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(1354, 402)
        Me.dgdatos.TabIndex = 34
        Me.dgdatos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgdatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgdatos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.ThemeStyle.HeaderStyle.Height = 40
        Me.dgdatos.ThemeStyle.ReadOnly = True
        Me.dgdatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgdatos.ThemeStyle.RowsStyle.Height = 22
        Me.dgdatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgdatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lblbuscar
        '
        Me.lblbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbuscar.Location = New System.Drawing.Point(1092, 97)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(140, 19)
        Me.lblbuscar.TabIndex = 44
        Me.lblbuscar.Text = "Buscar elementos"
        '
        'txtbuscador
        '
        Me.txtbuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtbuscador.BaseColor = System.Drawing.Color.White
        Me.txtbuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbuscador.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbuscador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscador.ForeColor = System.Drawing.Color.Black
        Me.txtbuscador.Location = New System.Drawing.Point(933, 122)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(406, 30)
        Me.txtbuscador.TabIndex = 43
        Me.txtbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblestado
        '
        Me.lblestado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.Black
        Me.lblestado.Location = New System.Drawing.Point(311, 113)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(326, 50)
        Me.lblestado.TabIndex = 67
        Me.lblestado.Text = "Elementos actualmente en bajas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIONESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1378, 27)
        Me.MenuStrip1.TabIndex = 68
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.items_bajas, Me.items_historial, Me.ElementosConsumidosToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCIONESToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_bulleted_list_32
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(118, 23)
        Me.OPCIONESToolStripMenuItem.Text = "OPCIONES"
        '
        'items_bajas
        '
        Me.items_bajas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialToolStripMenuItem, Me.BajasActualesToolStripMenuItem, Me.BajasDefinitivasToolStripMenuItem})
        Me.items_bajas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items_bajas.Image = Global.Appsena.My.Resources.Resources.icons8_unavailable_64
        Me.items_bajas.Name = "items_bajas"
        Me.items_bajas.Size = New System.Drawing.Size(379, 24)
        Me.items_bajas.Text = "Elementos dados de baja"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_order_history_64
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'BajasActualesToolStripMenuItem
        '
        Me.BajasActualesToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_download_resume_64
        Me.BajasActualesToolStripMenuItem.Name = "BajasActualesToolStripMenuItem"
        Me.BajasActualesToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.BajasActualesToolStripMenuItem.Text = "Bajas temporales"
        '
        'BajasDefinitivasToolStripMenuItem
        '
        Me.BajasDefinitivasToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_download_resume_64
        Me.BajasDefinitivasToolStripMenuItem.Name = "BajasDefinitivasToolStripMenuItem"
        Me.BajasDefinitivasToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.BajasDefinitivasToolStripMenuItem.Text = "Bajas definitivas"
        '
        'items_historial
        '
        Me.items_historial.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items_historial.Image = Global.Appsena.My.Resources.Resources.icons8_search_more_64
        Me.items_historial.Name = "items_historial"
        Me.items_historial.Size = New System.Drawing.Size(379, 24)
        Me.items_historial.Text = "Historial de prestamos de cada elemento"
        '
        'ElementosConsumidosToolStripMenuItem
        '
        Me.ElementosConsumidosToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_waiter_64
        Me.ElementosConsumidosToolStripMenuItem.Name = "ElementosConsumidosToolStripMenuItem"
        Me.ElementosConsumidosToolStripMenuItem.Size = New System.Drawing.Size(379, 24)
        Me.ElementosConsumidosToolStripMenuItem.Text = "Elementos consumidos"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(267, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 5)
        Me.Panel2.TabIndex = 115
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 70
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.HeaderText = "PDF"
        Me.DataGridViewImageColumn2.Image = Global.Appsena.My.Resources.Resources.icons8_pdf_32
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 50
        '
        'group_tipos
        '
        Me.group_tipos.BackColor = System.Drawing.Color.Transparent
        Me.group_tipos.BaseColor = System.Drawing.Color.White
        Me.group_tipos.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_tipos.Controls.Add(Me.mora)
        Me.group_tipos.Controls.Add(Me.check_definitivas)
        Me.group_tipos.Controls.Add(Me.activos)
        Me.group_tipos.Controls.Add(Me.check_reintegros)
        Me.group_tipos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_tipos.LineColor = System.Drawing.Color.Gainsboro
        Me.group_tipos.Location = New System.Drawing.Point(12, 12)
        Me.group_tipos.Name = "group_tipos"
        Me.group_tipos.Size = New System.Drawing.Size(409, 77)
        Me.group_tipos.TabIndex = 116
        Me.group_tipos.Text = "Seleccione que elementos desea ver."
        Me.group_tipos.TextLocation = New System.Drawing.Point(10, 8)
        Me.group_tipos.Visible = False
        '
        'mora
        '
        Me.mora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mora.AutoSize = True
        Me.mora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mora.Location = New System.Drawing.Point(243, 42)
        Me.mora.Name = "mora"
        Me.mora.Size = New System.Drawing.Size(126, 19)
        Me.mora.TabIndex = 63
        Me.mora.Text = "Bajas definitivas"
        Me.ToolTip1.SetToolTip(Me.mora, "Mostrar elementos en baja definitiva")
        '
        'check_definitivas
        '
        Me.check_definitivas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_definitivas.BaseColor = System.Drawing.Color.White
        Me.check_definitivas.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_definitivas.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.check_definitivas.FillColor = System.Drawing.Color.White
        Me.check_definitivas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_definitivas.Location = New System.Drawing.Point(217, 42)
        Me.check_definitivas.Name = "check_definitivas"
        Me.check_definitivas.Size = New System.Drawing.Size(20, 20)
        Me.check_definitivas.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.check_definitivas, "Mostrar elementos en baja definitiva")
        '
        'activos
        '
        Me.activos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.activos.AutoSize = True
        Me.activos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activos.Location = New System.Drawing.Point(47, 41)
        Me.activos.Name = "activos"
        Me.activos.Size = New System.Drawing.Size(106, 19)
        Me.activos.TabIndex = 61
        Me.activos.Text = "Reintegrados"
        Me.ToolTip1.SetToolTip(Me.activos, "Mostrar elementos reintegrados")
        '
        'check_reintegros
        '
        Me.check_reintegros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_reintegros.BaseColor = System.Drawing.Color.White
        Me.check_reintegros.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_reintegros.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.check_reintegros.FillColor = System.Drawing.Color.White
        Me.check_reintegros.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_reintegros.Location = New System.Drawing.Point(21, 41)
        Me.check_reintegros.Name = "check_reintegros"
        Me.check_reintegros.Size = New System.Drawing.Size(20, 20)
        Me.check_reintegros.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.check_reintegros, "Mostrar elementos reintegrados")
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
        Me.btnexportar.Location = New System.Drawing.Point(12, 120)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Radius = 10
        Me.btnexportar.Size = New System.Drawing.Size(218, 43)
        Me.btnexportar.TabIndex = 151
        Me.btnexportar.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte")
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(439, 12)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(210, 34)
        Me.dgexportar.TabIndex = 152
        Me.dgexportar.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscar.AnimationHoverSpeed = 0.07!
        Me.btnbuscar.AnimationSpeed = 0.03!
        Me.btnbuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnbuscar.BorderColor = System.Drawing.Color.Black
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbuscar.FocusedColor = System.Drawing.Color.Empty
        Me.btnbuscar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.White
        Me.btnbuscar.Image = Nothing
        Me.btnbuscar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbuscar.Location = New System.Drawing.Point(500, 27)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuscar.OnHoverImage = Nothing
        Me.btnbuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuscar.Radius = 10
        Me.btnbuscar.Size = New System.Drawing.Size(100, 28)
        Me.btnbuscar.TabIndex = 162
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'pnl_fechas
        '
        Me.pnl_fechas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_fechas.Controls.Add(Me.btnbuscar)
        Me.pnl_fechas.Controls.Add(Me.picker_dia_inicial)
        Me.pnl_fechas.Controls.Add(Me.picker_dia_final)
        Me.pnl_fechas.Controls.Add(Me.lbliniciaol)
        Me.pnl_fechas.Controls.Add(Me.lblfinal)
        Me.pnl_fechas.Location = New System.Drawing.Point(726, 31)
        Me.pnl_fechas.Name = "pnl_fechas"
        Me.pnl_fechas.Size = New System.Drawing.Size(652, 58)
        Me.pnl_fechas.TabIndex = 153
        Me.pnl_fechas.Visible = False
        '
        'picker_dia_inicial
        '
        Me.picker_dia_inicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picker_dia_inicial.BackColor = System.Drawing.Color.Transparent
        Me.picker_dia_inicial.BaseColor = System.Drawing.Color.White
        Me.picker_dia_inicial.BorderColor = System.Drawing.Color.Silver
        Me.picker_dia_inicial.CustomFormat = "dd-MM-yyyy"
        Me.picker_dia_inicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.picker_dia_inicial.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_inicial.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_dia_inicial.ForeColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_dia_inicial.Location = New System.Drawing.Point(20, 27)
        Me.picker_dia_inicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_inicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_inicial.Name = "picker_dia_inicial"
        Me.picker_dia_inicial.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_inicial.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_inicial.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.Radius = 10
        Me.picker_dia_inicial.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_inicial.TabIndex = 161
        Me.picker_dia_inicial.Text = "3/12/2019"
        Me.picker_dia_inicial.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'picker_dia_final
        '
        Me.picker_dia_final.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picker_dia_final.BackColor = System.Drawing.Color.Transparent
        Me.picker_dia_final.BaseColor = System.Drawing.Color.White
        Me.picker_dia_final.BorderColor = System.Drawing.Color.Silver
        Me.picker_dia_final.CustomFormat = "dd-MM-yyyy"
        Me.picker_dia_final.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.picker_dia_final.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_final.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_dia_final.ForeColor = System.Drawing.Color.Black
        Me.picker_dia_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_dia_final.Location = New System.Drawing.Point(265, 27)
        Me.picker_dia_final.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_final.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_final.Name = "picker_dia_final"
        Me.picker_dia_final.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_final.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_final.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_final.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_final.Radius = 10
        Me.picker_dia_final.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_final.TabIndex = 159
        Me.picker_dia_final.Text = "3/12/2019"
        Me.picker_dia_final.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'lbliniciaol
        '
        Me.lbliniciaol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbliniciaol.AutoSize = True
        Me.lbliniciaol.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliniciaol.Location = New System.Drawing.Point(67, 5)
        Me.lbliniciaol.Name = "lbliniciaol"
        Me.lbliniciaol.Size = New System.Drawing.Size(97, 19)
        Me.lbliniciaol.TabIndex = 160
        Me.lbliniciaol.Text = "Fecha Inicial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblfinal
        '
        Me.lblfinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfinal.AutoSize = True
        Me.lblfinal.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinal.Location = New System.Drawing.Point(302, 4)
        Me.lblfinal.Name = "lblfinal"
        Me.lblfinal.Size = New System.Drawing.Size(90, 19)
        Me.lblfinal.TabIndex = 158
        Me.lblfinal.Text = "Fecha Final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'clmeliminar
        '
        Me.clmeliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        Me.clmeliminar.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmeliminar.HeaderText = "Eliminar"
        Me.clmeliminar.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.clmeliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmeliminar.Name = "clmeliminar"
        Me.clmeliminar.ReadOnly = True
        Me.clmeliminar.Width = 70
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "PDF"
        Me.Column1.Image = Global.Appsena.My.Resources.Resources.icons8_pdf_32
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 50
        '
        'frm_bajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 593)
        Me.Controls.Add(Me.pnl_fechas)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.group_tipos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.lblbuscar)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.dgdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_bajas"
        Me.Text = " "
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.group_tipos.ResumeLayout(False)
        Me.group_tipos.PerformLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_fechas.ResumeLayout(False)
        Me.pnl_fechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents lblbuscar As Label
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblestado As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents items_bajas As ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajasActualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents items_historial As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BajasDefinitivasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents group_tipos As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents mora As Label
    Friend WithEvents check_definitivas As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents activos As Label
    Friend WithEvents check_reintegros As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ElementosConsumidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnl_fechas As Panel
    Friend WithEvents btnbuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents picker_dia_inicial As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents picker_dia_final As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lbliniciaol As Label
    Friend WithEvents lblfinal As Label
    Friend WithEvents clmeliminar As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
End Class
