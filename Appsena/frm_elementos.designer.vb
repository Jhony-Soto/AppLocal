<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_elementos
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlexcel = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btnplantilla = New Guna.UI.WinForms.GunaButton()
        Me.btnsubir = New Guna.UI.WinForms.GunaButton()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbcategoria = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxtodos = New Guna.UI.WinForms.GunaCheckBox()
        Me.dgexportar2 = New Guna.UI.WinForms.GunaDataGridView()
        Me.group_activos_mora = New Guna.UI.WinForms.GunaGroupBox()
        Me.mora = New System.Windows.Forms.Label()
        Me.checkmora = New Guna.UI.WinForms.GunaCheckBox()
        Me.activos = New System.Windows.Forms.Label()
        Me.checkactivos = New Guna.UI.WinForms.GunaCheckBox()
        Me.pnlcontroles = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnregistros = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_reporte_excel = New Guna.UI.WinForms.GunaButton()
        Me.btn_archivo = New Guna.UI.WinForms.GunaButton()
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnbuscar = New Guna.UI.WinForms.GunaButton()
        Me.btn_ultima_pagina = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_siguiente = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_anterior = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_primera_pagina = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btnguardar_baja = New Guna.UI.WinForms.GunaButton()
        Me.dgplantilla = New Guna.UI.WinForms.GunaDataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLACA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ELEMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ADQUISICION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISPONIBLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgimportar = New Guna.UI.WinForms.GunaDataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.items_bajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasActualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasDefinitivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.items_historial = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElementosConsumidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlbaja = New Guna.UI.WinForms.GunaShadowPanel()
        Me.lblruta = New System.Windows.Forms.Label()
        Me.radio_definitiva = New Guna.UI.WinForms.GunaRadioButton()
        Me.radio_temporal = New Guna.UI.WinForms.GunaRadioButton()
        Me.txtcantidad = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblelemento = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtobservaciones = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnexcel = New Guna.UI.WinForms.GunaButton()
        Me.btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.picker_dia_inicial = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lbliniciaol = New System.Windows.Forms.Label()
        Me.picker_dia_final = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblfinal = New System.Windows.Forms.Label()
        Me.lbl_total_paginas = New System.Windows.Forms.Label()
        Me.lblpagina = New System.Windows.Forms.Label()
        Me.pnl_paginador = New System.Windows.Forms.Panel()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlexcel.SuspendLayout()
        CType(Me.dgexportar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_activos_mora.SuspendLayout()
        Me.pnlcontroles.SuspendLayout()
        CType(Me.dgplantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgimportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlbaja.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_paginador.SuspendLayout()
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
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdatos.BackgroundColor = System.Drawing.Color.White
        Me.dgdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgdatos.ColumnHeadersHeight = 40
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmeliminar})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.NullValue = Nothing
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdatos.Location = New System.Drawing.Point(15, 172)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(1484, 495)
        Me.dgdatos.TabIndex = 33
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
        'clmeliminar
        '
        Me.clmeliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmeliminar.HeaderText = "Eliminar"
        Me.clmeliminar.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.clmeliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmeliminar.Name = "clmeliminar"
        Me.clmeliminar.ReadOnly = True
        Me.clmeliminar.Width = 70
        '
        'pnlexcel
        '
        Me.pnlexcel.BackColor = System.Drawing.Color.Transparent
        Me.pnlexcel.BaseColor = System.Drawing.Color.White
        Me.pnlexcel.Controls.Add(Me.btnplantilla)
        Me.pnlexcel.Controls.Add(Me.btnsubir)
        Me.pnlexcel.Controls.Add(Me.btnexportar)
        Me.pnlexcel.Location = New System.Drawing.Point(16, 172)
        Me.pnlexcel.Name = "pnlexcel"
        Me.pnlexcel.ShadowColor = System.Drawing.Color.Black
        Me.pnlexcel.Size = New System.Drawing.Size(237, 166)
        Me.pnlexcel.TabIndex = 45
        Me.pnlexcel.Visible = False
        '
        'btnplantilla
        '
        Me.btnplantilla.AnimationHoverSpeed = 0.07!
        Me.btnplantilla.AnimationSpeed = 0.03!
        Me.btnplantilla.BackColor = System.Drawing.Color.Transparent
        Me.btnplantilla.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnplantilla.BorderColor = System.Drawing.Color.Transparent
        Me.btnplantilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplantilla.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnplantilla.FocusedColor = System.Drawing.Color.Empty
        Me.btnplantilla.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplantilla.ForeColor = System.Drawing.Color.Black
        Me.btnplantilla.Image = Global.Appsena.My.Resources.Resources.icons8_download_64
        Me.btnplantilla.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnplantilla.Location = New System.Drawing.Point(9, 114)
        Me.btnplantilla.Name = "btnplantilla"
        Me.btnplantilla.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnplantilla.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnplantilla.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnplantilla.OnHoverImage = Nothing
        Me.btnplantilla.OnPressedColor = System.Drawing.Color.Black
        Me.btnplantilla.Size = New System.Drawing.Size(218, 43)
        Me.btnplantilla.TabIndex = 41
        Me.btnplantilla.Text = "Descargar plantilla"
        Me.ToolTip1.SetToolTip(Me.btnplantilla, "Descargar plantilla.")
        '
        'btnsubir
        '
        Me.btnsubir.AnimationHoverSpeed = 0.07!
        Me.btnsubir.AnimationSpeed = 0.03!
        Me.btnsubir.BackColor = System.Drawing.Color.Transparent
        Me.btnsubir.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnsubir.BorderColor = System.Drawing.Color.Transparent
        Me.btnsubir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubir.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsubir.FocusedColor = System.Drawing.Color.Empty
        Me.btnsubir.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubir.ForeColor = System.Drawing.Color.Black
        Me.btnsubir.Image = Global.Appsena.My.Resources.Resources.icons8_microsoft_excel_641
        Me.btnsubir.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsubir.Location = New System.Drawing.Point(9, 65)
        Me.btnsubir.Name = "btnsubir"
        Me.btnsubir.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnsubir.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnsubir.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnsubir.OnHoverImage = Nothing
        Me.btnsubir.OnPressedColor = System.Drawing.Color.Black
        Me.btnsubir.Size = New System.Drawing.Size(218, 43)
        Me.btnsubir.TabIndex = 40
        Me.btnsubir.Text = "Subir archivo"
        Me.ToolTip1.SetToolTip(Me.btnsubir, "Subir archivo de elementos.")
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
        Me.btnexportar.Location = New System.Drawing.Point(9, 16)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Size = New System.Drawing.Size(218, 43)
        Me.btnexportar.TabIndex = 38
        Me.btnexportar.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte del inventario de los elementos")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1217, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Buscar elementos"
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
        Me.txtbuscador.Location = New System.Drawing.Point(1058, 133)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(406, 30)
        Me.txtbuscador.TabIndex = 41
        Me.txtbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbcategoria
        '
        Me.cmbcategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbcategoria.BackColor = System.Drawing.Color.Transparent
        Me.cmbcategoria.BaseColor = System.Drawing.Color.White
        Me.cmbcategoria.BorderColor = System.Drawing.Color.Silver
        Me.cmbcategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategoria.FocusedColor = System.Drawing.Color.Empty
        Me.cmbcategoria.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategoria.ForeColor = System.Drawing.Color.Black
        Me.cmbcategoria.FormattingEnabled = True
        Me.cmbcategoria.Location = New System.Drawing.Point(138, 41)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cmbcategoria.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbcategoria.Radius = 10
        Me.cmbcategoria.Size = New System.Drawing.Size(296, 28)
        Me.cmbcategoria.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Seleccione una categoria"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Mostrar todos"
        '
        'cbxtodos
        '
        Me.cbxtodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxtodos.BaseColor = System.Drawing.Color.White
        Me.cbxtodos.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbxtodos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cbxtodos.FillColor = System.Drawing.Color.White
        Me.cbxtodos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxtodos.Location = New System.Drawing.Point(57, 41)
        Me.cbxtodos.Name = "cbxtodos"
        Me.cbxtodos.Size = New System.Drawing.Size(20, 20)
        Me.cbxtodos.TabIndex = 55
        '
        'dgexportar2
        '
        Me.dgexportar2.AllowUserToAddRows = False
        Me.dgexportar2.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgexportar2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgexportar2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgexportar2.BackgroundColor = System.Drawing.Color.Gray
        Me.dgexportar2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgexportar2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgexportar2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgexportar2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgexportar2.ColumnHeadersHeight = 40
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgexportar2.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgexportar2.EnableHeadersVisualStyles = False
        Me.dgexportar2.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgexportar2.Location = New System.Drawing.Point(944, 0)
        Me.dgexportar2.Name = "dgexportar2"
        Me.dgexportar2.ReadOnly = True
        Me.dgexportar2.RowHeadersVisible = False
        Me.dgexportar2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgexportar2.Size = New System.Drawing.Size(212, 33)
        Me.dgexportar2.TabIndex = 58
        Me.dgexportar2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgexportar2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgexportar2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgexportar2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgexportar2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgexportar2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgexportar2.ThemeStyle.BackColor = System.Drawing.Color.Gray
        Me.dgexportar2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgexportar2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgexportar2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgexportar2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgexportar2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgexportar2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgexportar2.ThemeStyle.HeaderStyle.Height = 40
        Me.dgexportar2.ThemeStyle.ReadOnly = True
        Me.dgexportar2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgexportar2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgexportar2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgexportar2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgexportar2.ThemeStyle.RowsStyle.Height = 22
        Me.dgexportar2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgexportar2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgexportar2.Visible = False
        '
        'group_activos_mora
        '
        Me.group_activos_mora.BackColor = System.Drawing.Color.Transparent
        Me.group_activos_mora.BaseColor = System.Drawing.Color.White
        Me.group_activos_mora.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_activos_mora.Controls.Add(Me.mora)
        Me.group_activos_mora.Controls.Add(Me.checkmora)
        Me.group_activos_mora.Controls.Add(Me.activos)
        Me.group_activos_mora.Controls.Add(Me.checkactivos)
        Me.group_activos_mora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_activos_mora.LineColor = System.Drawing.Color.Gainsboro
        Me.group_activos_mora.Location = New System.Drawing.Point(97, 12)
        Me.group_activos_mora.Name = "group_activos_mora"
        Me.group_activos_mora.Size = New System.Drawing.Size(409, 77)
        Me.group_activos_mora.TabIndex = 59
        Me.group_activos_mora.Text = "Seleccione que elementos desea ver."
        Me.group_activos_mora.TextLocation = New System.Drawing.Point(10, 8)
        '
        'mora
        '
        Me.mora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mora.AutoSize = True
        Me.mora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mora.Location = New System.Drawing.Point(243, 42)
        Me.mora.Name = "mora"
        Me.mora.Size = New System.Drawing.Size(153, 19)
        Me.mora.TabIndex = 63
        Me.mora.Text = "Elementos en mora"
        Me.ToolTip1.SetToolTip(Me.mora, "Mostrar elementos en mora")
        '
        'checkmora
        '
        Me.checkmora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkmora.BaseColor = System.Drawing.Color.White
        Me.checkmora.CheckedOffColor = System.Drawing.Color.Gray
        Me.checkmora.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.checkmora.FillColor = System.Drawing.Color.White
        Me.checkmora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkmora.Location = New System.Drawing.Point(217, 42)
        Me.checkmora.Name = "checkmora"
        Me.checkmora.Size = New System.Drawing.Size(20, 20)
        Me.checkmora.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.checkmora, "Mostrar elementos en mora")
        '
        'activos
        '
        Me.activos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.activos.AutoSize = True
        Me.activos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activos.Location = New System.Drawing.Point(47, 41)
        Me.activos.Name = "activos"
        Me.activos.Size = New System.Drawing.Size(139, 19)
        Me.activos.TabIndex = 61
        Me.activos.Text = "Prestados activos"
        Me.ToolTip1.SetToolTip(Me.activos, "Mostrar elementos prestados")
        '
        'checkactivos
        '
        Me.checkactivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkactivos.BaseColor = System.Drawing.Color.White
        Me.checkactivos.CheckedOffColor = System.Drawing.Color.Gray
        Me.checkactivos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.checkactivos.FillColor = System.Drawing.Color.White
        Me.checkactivos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkactivos.Location = New System.Drawing.Point(21, 41)
        Me.checkactivos.Name = "checkactivos"
        Me.checkactivos.Size = New System.Drawing.Size(20, 20)
        Me.checkactivos.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.checkactivos, "Mostrar elementos prestados")
        '
        'pnlcontroles
        '
        Me.pnlcontroles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcontroles.Controls.Add(Me.Label3)
        Me.pnlcontroles.Controls.Add(Me.cbxtodos)
        Me.pnlcontroles.Controls.Add(Me.cmbcategoria)
        Me.pnlcontroles.Controls.Add(Me.Label2)
        Me.pnlcontroles.Location = New System.Drawing.Point(610, 93)
        Me.pnlcontroles.Name = "pnlcontroles"
        Me.pnlcontroles.Size = New System.Drawing.Size(444, 73)
        Me.pnlcontroles.TabIndex = 60
        '
        'btnregistros
        '
        Me.btnregistros.AnimationHoverSpeed = 0.07!
        Me.btnregistros.AnimationSpeed = 0.03!
        Me.btnregistros.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnregistros.BorderColor = System.Drawing.Color.Black
        Me.btnregistros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistros.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregistros.FocusedColor = System.Drawing.Color.Empty
        Me.btnregistros.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistros.ForeColor = System.Drawing.Color.White
        Me.btnregistros.Image = Nothing
        Me.btnregistros.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnregistros.Location = New System.Drawing.Point(25, 14)
        Me.btnregistros.Name = "btnregistros"
        Me.btnregistros.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistros.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregistros.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregistros.OnHoverImage = Nothing
        Me.btnregistros.OnPressedColor = System.Drawing.Color.Black
        Me.btnregistros.Size = New System.Drawing.Size(60, 60)
        Me.btnregistros.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.btnregistros, "Nuemero de elementos")
        '
        'btn_reporte_excel
        '
        Me.btn_reporte_excel.AnimationHoverSpeed = 0.07!
        Me.btn_reporte_excel.AnimationSpeed = 0.03!
        Me.btn_reporte_excel.BackColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btn_reporte_excel.BorderColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reporte_excel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_reporte_excel.FocusedColor = System.Drawing.Color.Empty
        Me.btn_reporte_excel.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte_excel.ForeColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.Image = Global.Appsena.My.Resources.Resources.icons8_download_64
        Me.btn_reporte_excel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_reporte_excel.Location = New System.Drawing.Point(16, 123)
        Me.btn_reporte_excel.Name = "btn_reporte_excel"
        Me.btn_reporte_excel.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btn_reporte_excel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.OnHoverImage = Nothing
        Me.btn_reporte_excel.OnPressedColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.Radius = 10
        Me.btn_reporte_excel.Size = New System.Drawing.Size(218, 43)
        Me.btn_reporte_excel.TabIndex = 152
        Me.btn_reporte_excel.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btn_reporte_excel, "Descargar reporte")
        Me.btn_reporte_excel.Visible = False
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
        Me.btn_archivo.Location = New System.Drawing.Point(259, 143)
        Me.btn_archivo.Name = "btn_archivo"
        Me.btn_archivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_archivo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_archivo.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_archivo.OnHoverImage = Nothing
        Me.btn_archivo.OnPressedColor = System.Drawing.Color.Black
        Me.btn_archivo.Radius = 10
        Me.btn_archivo.Size = New System.Drawing.Size(60, 30)
        Me.btn_archivo.TabIndex = 118
        Me.btn_archivo.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btn_archivo, "Subir archivo")
        Me.btn_archivo.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.AnimationHoverSpeed = 0.07!
        Me.btncerrar.AnimationSpeed = 0.03!
        Me.btncerrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btncerrar.BorderColor = System.Drawing.Color.Black
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncerrar.FocusedColor = System.Drawing.Color.Empty
        Me.btncerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.btncerrar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btncerrar.Location = New System.Drawing.Point(513, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncerrar.OnHoverImage = Nothing
        Me.btncerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btncerrar.Size = New System.Drawing.Size(28, 28)
        Me.btncerrar.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
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
        Me.btnbuscar.Location = New System.Drawing.Point(1359, 61)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuscar.OnHoverImage = Nothing
        Me.btnbuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuscar.Radius = 10
        Me.btnbuscar.Size = New System.Drawing.Size(100, 28)
        Me.btnbuscar.TabIndex = 157
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnbuscar.Visible = False
        '
        'btn_ultima_pagina
        '
        Me.btn_ultima_pagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_ultima_pagina.AnimationHoverSpeed = 0.07!
        Me.btn_ultima_pagina.AnimationSpeed = 0.03!
        Me.btn_ultima_pagina.BaseColor1 = System.Drawing.Color.Lime
        Me.btn_ultima_pagina.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ultima_pagina.BorderColor = System.Drawing.Color.Black
        Me.btn_ultima_pagina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ultima_pagina.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_ultima_pagina.FocusedColor = System.Drawing.Color.Empty
        Me.btn_ultima_pagina.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ultima_pagina.ForeColor = System.Drawing.Color.White
        Me.btn_ultima_pagina.Image = Nothing
        Me.btn_ultima_pagina.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_ultima_pagina.Location = New System.Drawing.Point(599, 13)
        Me.btn_ultima_pagina.Name = "btn_ultima_pagina"
        Me.btn_ultima_pagina.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_ultima_pagina.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_ultima_pagina.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_ultima_pagina.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_ultima_pagina.OnHoverImage = Nothing
        Me.btn_ultima_pagina.OnPressedColor = System.Drawing.Color.Black
        Me.btn_ultima_pagina.Size = New System.Drawing.Size(30, 30)
        Me.btn_ultima_pagina.TabIndex = 165
        Me.btn_ultima_pagina.Text = ">|"
        Me.ToolTip1.SetToolTip(Me.btn_ultima_pagina, "Ultima pagina")
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_siguiente.AnimationHoverSpeed = 0.07!
        Me.btn_siguiente.AnimationSpeed = 0.03!
        Me.btn_siguiente.BaseColor1 = System.Drawing.Color.Lime
        Me.btn_siguiente.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_siguiente.BorderColor = System.Drawing.Color.Black
        Me.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_siguiente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_siguiente.FocusedColor = System.Drawing.Color.Empty
        Me.btn_siguiente.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siguiente.ForeColor = System.Drawing.Color.White
        Me.btn_siguiente.Image = Nothing
        Me.btn_siguiente.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_siguiente.Location = New System.Drawing.Point(542, 13)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_siguiente.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_siguiente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_siguiente.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_siguiente.OnHoverImage = Nothing
        Me.btn_siguiente.OnPressedColor = System.Drawing.Color.Black
        Me.btn_siguiente.Size = New System.Drawing.Size(30, 30)
        Me.btn_siguiente.TabIndex = 164
        Me.btn_siguiente.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btn_siguiente, "Siguiente")
        '
        'btn_anterior
        '
        Me.btn_anterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_anterior.AnimationHoverSpeed = 0.07!
        Me.btn_anterior.AnimationSpeed = 0.03!
        Me.btn_anterior.BaseColor1 = System.Drawing.Color.Lime
        Me.btn_anterior.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_anterior.BorderColor = System.Drawing.Color.Black
        Me.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_anterior.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_anterior.FocusedColor = System.Drawing.Color.Empty
        Me.btn_anterior.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anterior.ForeColor = System.Drawing.Color.White
        Me.btn_anterior.Image = Nothing
        Me.btn_anterior.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_anterior.Location = New System.Drawing.Point(163, 13)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_anterior.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_anterior.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_anterior.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_anterior.OnHoverImage = Nothing
        Me.btn_anterior.OnPressedColor = System.Drawing.Color.Black
        Me.btn_anterior.Size = New System.Drawing.Size(30, 30)
        Me.btn_anterior.TabIndex = 163
        Me.btn_anterior.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btn_anterior, "Anterior")
        '
        'btn_primera_pagina
        '
        Me.btn_primera_pagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_primera_pagina.AnimationHoverSpeed = 0.07!
        Me.btn_primera_pagina.AnimationSpeed = 0.03!
        Me.btn_primera_pagina.BaseColor1 = System.Drawing.Color.Lime
        Me.btn_primera_pagina.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_primera_pagina.BorderColor = System.Drawing.Color.Black
        Me.btn_primera_pagina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_primera_pagina.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_primera_pagina.FocusedColor = System.Drawing.Color.Empty
        Me.btn_primera_pagina.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_primera_pagina.ForeColor = System.Drawing.Color.White
        Me.btn_primera_pagina.Image = Nothing
        Me.btn_primera_pagina.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_primera_pagina.Location = New System.Drawing.Point(111, 13)
        Me.btn_primera_pagina.Name = "btn_primera_pagina"
        Me.btn_primera_pagina.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_primera_pagina.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_primera_pagina.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_primera_pagina.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_primera_pagina.OnHoverImage = Nothing
        Me.btn_primera_pagina.OnPressedColor = System.Drawing.Color.Black
        Me.btn_primera_pagina.Size = New System.Drawing.Size(30, 30)
        Me.btn_primera_pagina.TabIndex = 162
        Me.btn_primera_pagina.Text = "|<"
        Me.ToolTip1.SetToolTip(Me.btn_primera_pagina, "Volver al inicio")
        '
        'btnguardar_baja
        '
        Me.btnguardar_baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar_baja.AnimationHoverSpeed = 0.07!
        Me.btnguardar_baja.AnimationSpeed = 0.03!
        Me.btnguardar_baja.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar_baja.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnguardar_baja.BorderColor = System.Drawing.Color.Transparent
        Me.btnguardar_baja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar_baja.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardar_baja.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardar_baja.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar_baja.ForeColor = System.Drawing.Color.White
        Me.btnguardar_baja.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardar_baja.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardar_baja.Location = New System.Drawing.Point(220, 291)
        Me.btnguardar_baja.Name = "btnguardar_baja"
        Me.btnguardar_baja.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnguardar_baja.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnguardar_baja.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar_baja.OnHoverImage = Nothing
        Me.btnguardar_baja.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar_baja.Radius = 10
        Me.btnguardar_baja.Size = New System.Drawing.Size(121, 31)
        Me.btnguardar_baja.TabIndex = 29
        Me.btnguardar_baja.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnguardar_baja, "Guardar")
        '
        'dgplantilla
        '
        Me.dgplantilla.AllowUserToAddRows = False
        Me.dgplantilla.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgplantilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgplantilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgplantilla.BackgroundColor = System.Drawing.Color.Gray
        Me.dgplantilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgplantilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgplantilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgplantilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgplantilla.ColumnHeadersHeight = 40
        Me.dgplantilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.PLACA, Me.SERIAL, Me.NOMBRE, Me.MARCA, Me.MODELO, Me.TIPO_ELEMENTO, Me.CATEGORIA, Me.UBICACION, Me.OBSERVACIONES, Me.FECHA_ADQUISICION, Me.VALOR, Me.CANTIDAD, Me.DISPONIBLES})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgplantilla.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgplantilla.EnableHeadersVisualStyles = False
        Me.dgplantilla.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgplantilla.Location = New System.Drawing.Point(962, 12)
        Me.dgplantilla.Name = "dgplantilla"
        Me.dgplantilla.ReadOnly = True
        Me.dgplantilla.RowHeadersVisible = False
        Me.dgplantilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgplantilla.Size = New System.Drawing.Size(227, 33)
        Me.dgplantilla.TabIndex = 61
        Me.dgplantilla.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgplantilla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgplantilla.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgplantilla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgplantilla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgplantilla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgplantilla.ThemeStyle.BackColor = System.Drawing.Color.Gray
        Me.dgplantilla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgplantilla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgplantilla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgplantilla.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgplantilla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgplantilla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgplantilla.ThemeStyle.HeaderStyle.Height = 40
        Me.dgplantilla.ThemeStyle.ReadOnly = True
        Me.dgplantilla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgplantilla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgplantilla.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgplantilla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgplantilla.ThemeStyle.RowsStyle.Height = 22
        Me.dgplantilla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgplantilla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgplantilla.Visible = False
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'PLACA
        '
        Me.PLACA.HeaderText = "PLACA"
        Me.PLACA.Name = "PLACA"
        Me.PLACA.ReadOnly = True
        '
        'SERIAL
        '
        Me.SERIAL.HeaderText = "SERIAL"
        Me.SERIAL.Name = "SERIAL"
        Me.SERIAL.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        '
        'MODELO
        '
        Me.MODELO.HeaderText = "MODELO"
        Me.MODELO.Name = "MODELO"
        Me.MODELO.ReadOnly = True
        '
        'TIPO_ELEMENTO
        '
        Me.TIPO_ELEMENTO.HeaderText = "TIPO_ELEMENTO"
        Me.TIPO_ELEMENTO.Name = "TIPO_ELEMENTO"
        Me.TIPO_ELEMENTO.ReadOnly = True
        '
        'CATEGORIA
        '
        Me.CATEGORIA.HeaderText = "CATEGORIA"
        Me.CATEGORIA.Name = "CATEGORIA"
        Me.CATEGORIA.ReadOnly = True
        '
        'UBICACION
        '
        Me.UBICACION.HeaderText = "UBICACION"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.ReadOnly = True
        '
        'FECHA_ADQUISICION
        '
        Me.FECHA_ADQUISICION.HeaderText = "FECHA_ADQUISICION"
        Me.FECHA_ADQUISICION.Name = "FECHA_ADQUISICION"
        Me.FECHA_ADQUISICION.ReadOnly = True
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "VALOR"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'DISPONIBLES
        '
        Me.DISPONIBLES.HeaderText = "DISPONIBLES"
        Me.DISPONIBLES.Name = "DISPONIBLES"
        Me.DISPONIBLES.ReadOnly = True
        '
        'dgimportar
        '
        Me.dgimportar.AllowUserToAddRows = False
        Me.dgimportar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgimportar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgimportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgimportar.BackgroundColor = System.Drawing.Color.Gray
        Me.dgimportar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgimportar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgimportar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgimportar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgimportar.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgimportar.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgimportar.EnableHeadersVisualStyles = False
        Me.dgimportar.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgimportar.Location = New System.Drawing.Point(748, 12)
        Me.dgimportar.Name = "dgimportar"
        Me.dgimportar.ReadOnly = True
        Me.dgimportar.RowHeadersVisible = False
        Me.dgimportar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgimportar.Size = New System.Drawing.Size(99, 31)
        Me.dgimportar.TabIndex = 62
        Me.dgimportar.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgimportar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgimportar.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgimportar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgimportar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgimportar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgimportar.ThemeStyle.BackColor = System.Drawing.Color.Gray
        Me.dgimportar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgimportar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgimportar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgimportar.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgimportar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgimportar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgimportar.ThemeStyle.HeaderStyle.Height = 40
        Me.dgimportar.ThemeStyle.ReadOnly = True
        Me.dgimportar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgimportar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgimportar.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgimportar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgimportar.ThemeStyle.RowsStyle.Height = 22
        Me.dgimportar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgimportar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgimportar.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIONESToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 27)
        Me.MenuStrip1.TabIndex = 63
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
        Me.items_bajas.Size = New System.Drawing.Size(345, 24)
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
        Me.items_historial.Size = New System.Drawing.Size(345, 24)
        Me.items_historial.Text = "Consultar historial de cada elemento"
        '
        'ElementosConsumidosToolStripMenuItem
        '
        Me.ElementosConsumidosToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_waiter_64
        Me.ElementosConsumidosToolStripMenuItem.Name = "ElementosConsumidosToolStripMenuItem"
        Me.ElementosConsumidosToolStripMenuItem.Size = New System.Drawing.Size(345, 24)
        Me.ElementosConsumidosToolStripMenuItem.Text = "Elementos consumidos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 23)
        Me.ToolStripMenuItem1.Text = " "
        '
        'pnlbaja
        '
        Me.pnlbaja.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlbaja.BackColor = System.Drawing.Color.Transparent
        Me.pnlbaja.BaseColor = System.Drawing.Color.White
        Me.pnlbaja.Controls.Add(Me.lblruta)
        Me.pnlbaja.Controls.Add(Me.btn_archivo)
        Me.pnlbaja.Controls.Add(Me.radio_definitiva)
        Me.pnlbaja.Controls.Add(Me.radio_temporal)
        Me.pnlbaja.Controls.Add(Me.txtcantidad)
        Me.pnlbaja.Controls.Add(Me.Label7)
        Me.pnlbaja.Controls.Add(Me.Label6)
        Me.pnlbaja.Controls.Add(Me.Label5)
        Me.pnlbaja.Controls.Add(Me.lblelemento)
        Me.pnlbaja.Controls.Add(Me.Panel1)
        Me.pnlbaja.Controls.Add(Me.txtobservaciones)
        Me.pnlbaja.Controls.Add(Me.btnguardar_baja)
        Me.pnlbaja.Location = New System.Drawing.Point(454, 210)
        Me.pnlbaja.Name = "pnlbaja"
        Me.pnlbaja.ShadowColor = System.Drawing.Color.Black
        Me.pnlbaja.ShadowShift = 10
        Me.pnlbaja.Size = New System.Drawing.Size(554, 345)
        Me.pnlbaja.TabIndex = 65
        Me.pnlbaja.Visible = False
        '
        'lblruta
        '
        Me.lblruta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblruta.AutoSize = True
        Me.lblruta.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblruta.Location = New System.Drawing.Point(325, 150)
        Me.lblruta.Name = "lblruta"
        Me.lblruta.Size = New System.Drawing.Size(130, 19)
        Me.lblruta.TabIndex = 112
        Me.lblruta.Text = "ruta_del_archivo"
        Me.lblruta.Visible = False
        '
        'radio_definitiva
        '
        Me.radio_definitiva.BaseColor = System.Drawing.SystemColors.Control
        Me.radio_definitiva.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_definitiva.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.radio_definitiva.FillColor = System.Drawing.Color.White
        Me.radio_definitiva.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_definitiva.Location = New System.Drawing.Point(321, 65)
        Me.radio_definitiva.Name = "radio_definitiva"
        Me.radio_definitiva.Size = New System.Drawing.Size(137, 23)
        Me.radio_definitiva.TabIndex = 119
        Me.radio_definitiva.Text = "Baja definitiva"
        '
        'radio_temporal
        '
        Me.radio_temporal.BaseColor = System.Drawing.SystemColors.Control
        Me.radio_temporal.CheckedOffColor = System.Drawing.Color.Gray
        Me.radio_temporal.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.radio_temporal.FillColor = System.Drawing.Color.White
        Me.radio_temporal.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_temporal.Location = New System.Drawing.Point(137, 65)
        Me.radio_temporal.Name = "radio_temporal"
        Me.radio_temporal.Size = New System.Drawing.Size(136, 23)
        Me.radio_temporal.TabIndex = 118
        Me.radio_temporal.Text = "Baja temporal"
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Transparent
        Me.txtcantidad.BaseColor = System.Drawing.Color.White
        Me.txtcantidad.BorderColor = System.Drawing.Color.Silver
        Me.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcantidad.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcantidad.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtcantidad.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcantidad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.Black
        Me.txtcantidad.Location = New System.Drawing.Point(173, 143)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcantidad.Radius = 10
        Me.txtcantidad.Size = New System.Drawing.Size(74, 30)
        Me.txtcantidad.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(27, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 23)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Cantidad : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Observaciones  : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Elemento : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblelemento
        '
        Me.lblelemento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblelemento.BackColor = System.Drawing.Color.White
        Me.lblelemento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblelemento.ForeColor = System.Drawing.Color.Black
        Me.lblelemento.Location = New System.Drawing.Point(169, 109)
        Me.lblelemento.Name = "lblelemento"
        Me.lblelemento.Size = New System.Drawing.Size(372, 23)
        Me.lblelemento.TabIndex = 46
        Me.lblelemento.Text = "Eliminar aprendices"
        Me.lblelemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Controls.Add(Me.lblcodigo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 42)
        Me.Panel1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(143, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(315, 23)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Dar de baja el elemento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcodigo
        '
        Me.lblcodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(30, 12)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(107, 19)
        Me.lblcodigo.TabIndex = 110
        Me.lblcodigo.Text = "codelemento"
        Me.lblcodigo.Visible = False
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.Color.Transparent
        Me.txtobservaciones.BaseColor = System.Drawing.Color.White
        Me.txtobservaciones.BorderColor = System.Drawing.Color.Silver
        Me.txtobservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtobservaciones.FocusedBaseColor = System.Drawing.Color.White
        Me.txtobservaciones.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtobservaciones.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtobservaciones.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.ForeColor = System.Drawing.Color.Black
        Me.txtobservaciones.Location = New System.Drawing.Point(173, 195)
        Me.txtobservaciones.MultiLine = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtobservaciones.Radius = 10
        Me.txtobservaciones.Size = New System.Drawing.Size(293, 80)
        Me.txtobservaciones.TabIndex = 109
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(299, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 5)
        Me.Panel2.TabIndex = 117
        Me.Panel2.Visible = False
        '
        'lblestado
        '
        Me.lblestado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.Black
        Me.lblestado.Location = New System.Drawing.Point(368, 116)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(362, 50)
        Me.lblestado.TabIndex = 116
        Me.lblestado.Text = "historial de prestamos del elemento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblestado.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 70
        '
        'btnexcel
        '
        Me.btnexcel.AnimationHoverSpeed = 0.07!
        Me.btnexcel.AnimationSpeed = 0.03!
        Me.btnexcel.BackColor = System.Drawing.Color.Transparent
        Me.btnexcel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnexcel.BorderColor = System.Drawing.Color.Transparent
        Me.btnexcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexcel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexcel.FocusedColor = System.Drawing.Color.Empty
        Me.btnexcel.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcel.ForeColor = System.Drawing.Color.White
        Me.btnexcel.Image = Global.Appsena.My.Resources.Resources.icons8_microsoft_excel_64
        Me.btnexcel.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnexcel.Location = New System.Drawing.Point(16, 130)
        Me.btnexcel.Name = "btnexcel"
        Me.btnexcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnexcel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexcel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexcel.OnHoverImage = Nothing
        Me.btnexcel.OnPressedColor = System.Drawing.Color.Black
        Me.btnexcel.Radius = 10
        Me.btnexcel.Size = New System.Drawing.Size(98, 36)
        Me.btnexcel.TabIndex = 44
        Me.btnexcel.Text = "Excel"
        '
        'btnagregar
        '
        Me.btnagregar.AnimationHoverSpeed = 0.07!
        Me.btnagregar.AnimationSpeed = 0.03!
        Me.btnagregar.BackColor = System.Drawing.Color.Transparent
        Me.btnagregar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnagregar.BorderColor = System.Drawing.Color.Transparent
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnagregar.FocusedColor = System.Drawing.Color.Empty
        Me.btnagregar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.Image = Global.Appsena.My.Resources.Resources.icons8_add_user_group_man_man_64
        Me.btnagregar.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnagregar.Location = New System.Drawing.Point(133, 130)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregar.OnHoverImage = Nothing
        Me.btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregar.Radius = 10
        Me.btnagregar.Size = New System.Drawing.Size(138, 36)
        Me.btnagregar.TabIndex = 43
        Me.btnagregar.Text = "Agregar"
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
        Me.picker_dia_inicial.Location = New System.Drawing.Point(882, 61)
        Me.picker_dia_inicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_inicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_inicial.Name = "picker_dia_inicial"
        Me.picker_dia_inicial.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_inicial.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_inicial.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.Radius = 10
        Me.picker_dia_inicial.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_inicial.TabIndex = 156
        Me.picker_dia_inicial.Text = "3/12/2019"
        Me.picker_dia_inicial.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        Me.picker_dia_inicial.Visible = False
        '
        'lbliniciaol
        '
        Me.lbliniciaol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbliniciaol.AutoSize = True
        Me.lbliniciaol.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliniciaol.Location = New System.Drawing.Point(929, 39)
        Me.lbliniciaol.Name = "lbliniciaol"
        Me.lbliniciaol.Size = New System.Drawing.Size(97, 19)
        Me.lbliniciaol.TabIndex = 155
        Me.lbliniciaol.Text = "Fecha Inicial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbliniciaol.Visible = False
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
        Me.picker_dia_final.Location = New System.Drawing.Point(1127, 61)
        Me.picker_dia_final.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_final.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_final.Name = "picker_dia_final"
        Me.picker_dia_final.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_final.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_final.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_final.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_final.Radius = 10
        Me.picker_dia_final.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_final.TabIndex = 154
        Me.picker_dia_final.Text = "3/12/2019"
        Me.picker_dia_final.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        Me.picker_dia_final.Visible = False
        '
        'lblfinal
        '
        Me.lblfinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfinal.AutoSize = True
        Me.lblfinal.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinal.Location = New System.Drawing.Point(1164, 38)
        Me.lblfinal.Name = "lblfinal"
        Me.lblfinal.Size = New System.Drawing.Size(90, 19)
        Me.lblfinal.TabIndex = 153
        Me.lblfinal.Text = "Fecha Final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblfinal.Visible = False
        '
        'lbl_total_paginas
        '
        Me.lbl_total_paginas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_total_paginas.AutoSize = True
        Me.lbl_total_paginas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_paginas.Location = New System.Drawing.Point(356, 13)
        Me.lbl_total_paginas.Name = "lbl_total_paginas"
        Me.lbl_total_paginas.Size = New System.Drawing.Size(27, 19)
        Me.lbl_total_paginas.TabIndex = 166
        Me.lbl_total_paginas.Text = "/ 6"
        '
        'lblpagina
        '
        Me.lblpagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblpagina.AutoSize = True
        Me.lblpagina.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagina.Location = New System.Drawing.Point(322, 13)
        Me.lblpagina.Name = "lblpagina"
        Me.lblpagina.Size = New System.Drawing.Size(18, 19)
        Me.lblpagina.TabIndex = 161
        Me.lblpagina.Text = "1"
        '
        'pnl_paginador
        '
        Me.pnl_paginador.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pnl_paginador.Controls.Add(Me.lbl_total_paginas)
        Me.pnl_paginador.Controls.Add(Me.lblpagina)
        Me.pnl_paginador.Controls.Add(Me.btn_ultima_pagina)
        Me.pnl_paginador.Controls.Add(Me.btn_primera_pagina)
        Me.pnl_paginador.Controls.Add(Me.btn_siguiente)
        Me.pnl_paginador.Controls.Add(Me.btn_anterior)
        Me.pnl_paginador.Location = New System.Drawing.Point(400, 688)
        Me.pnl_paginador.Name = "pnl_paginador"
        Me.pnl_paginador.Size = New System.Drawing.Size(676, 49)
        Me.pnl_paginador.TabIndex = 167
        '
        'frm_elementos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.pnl_paginador)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.picker_dia_inicial)
        Me.Controls.Add(Me.picker_dia_final)
        Me.Controls.Add(Me.lbliniciaol)
        Me.Controls.Add(Me.lblfinal)
        Me.Controls.Add(Me.btn_reporte_excel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.btnregistros)
        Me.Controls.Add(Me.pnlbaja)
        Me.Controls.Add(Me.dgimportar)
        Me.Controls.Add(Me.dgplantilla)
        Me.Controls.Add(Me.pnlcontroles)
        Me.Controls.Add(Me.group_activos_mora)
        Me.Controls.Add(Me.dgexportar2)
        Me.Controls.Add(Me.pnlexcel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.btnexcel)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Zurich BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_elementos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Elementos"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlexcel.ResumeLayout(False)
        CType(Me.dgexportar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_activos_mora.ResumeLayout(False)
        Me.group_activos_mora.PerformLayout()
        Me.pnlcontroles.ResumeLayout(False)
        Me.pnlcontroles.PerformLayout()
        CType(Me.dgplantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgimportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlbaja.ResumeLayout(False)
        Me.pnlbaja.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_paginador.ResumeLayout(False)
        Me.pnl_paginador.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents clmeliminar As DataGridViewImageColumn
    Friend WithEvents pnlexcel As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnexcel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnagregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents cmbcategoria As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxtodos As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents dgexportar2 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents group_activos_mora As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents mora As Label
    Friend WithEvents checkmora As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents activos As Label
    Friend WithEvents checkactivos As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents pnlcontroles As Panel
    Friend WithEvents btnsubir As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnplantilla As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dgplantilla As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents PLACA As DataGridViewTextBoxColumn
    Friend WithEvents SERIAL As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents MARCA As DataGridViewTextBoxColumn
    Friend WithEvents MODELO As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ELEMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORIA As DataGridViewTextBoxColumn
    Friend WithEvents UBICACION As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONES As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ADQUISICION As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents DISPONIBLES As DataGridViewTextBoxColumn
    Friend WithEvents dgimportar As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents items_bajas As ToolStripMenuItem
    Friend WithEvents items_historial As ToolStripMenuItem
    Friend WithEvents pnlbaja As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblelemento As Label
    Friend WithEvents txtobservaciones As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnguardar_baja As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblcodigo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajasActualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtcantidad As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnregistros As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblestado As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblruta As Label
    Friend WithEvents btn_archivo As Guna.UI.WinForms.GunaButton
    Friend WithEvents radio_definitiva As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents radio_temporal As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents BajasDefinitivasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_reporte_excel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnbuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents picker_dia_inicial As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lbliniciaol As Label
    Friend WithEvents picker_dia_final As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblfinal As Label
    Friend WithEvents lbl_total_paginas As Label
    Friend WithEvents btn_ultima_pagina As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btn_siguiente As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btn_anterior As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btn_primera_pagina As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents lblpagina As Label
    Friend WithEvents pnl_paginador As Panel
    Friend WithEvents ElementosConsumidosToolStripMenuItem As ToolStripMenuItem
End Class
