<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_clientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxtodos = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnregistros = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_primera_pagina = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_anterior = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_siguiente = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_ultima_pagina = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btn_reporte_excel = New Guna.UI.WinForms.GunaButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.btnsubir = New Guna.UI.WinForms.GunaButton()
        Me.btntipoprestamo = New Guna.UI.WinForms.GunaButton()
        Me.btnexcel = New Guna.UI.WinForms.GunaButton()
        Me.btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.pnlexcel = New Guna.UI.WinForms.GunaShadowPanel()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_Movil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codficha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borrar_esta_columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgimportar = New System.Windows.Forms.DataGridView()
        Me.cmbtipo_cliente = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminar_fichas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesEliminadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlficha = New Guna.UI.WinForms.GunaShadowPanel()
        Me.cmbficha = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbuscadorficha = New Guna.UI.WinForms.GunaTextBox()
        Me.lblficha = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.dgreportes = New System.Windows.Forms.DataGridView()
        Me.pnl_filtros = New System.Windows.Forms.Panel()
        Me.lblpagina = New System.Windows.Forms.Label()
        Me.lbl_total_paginas = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlexcel.SuspendLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgimportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlficha.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgreportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.txtbuscador.Location = New System.Drawing.Point(844, 115)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(406, 30)
        Me.txtbuscador.TabIndex = 23
        Me.txtbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtbuscador, "Busca por Documentos , Nombres , Apellidos , Fichas  y Tipos de Clientes")
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
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdatos.ColumnHeadersHeight = 40
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmeliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdatos.Location = New System.Drawing.Point(12, 165)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(1238, 516)
        Me.dgdatos.TabIndex = 32
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(980, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Buscar Cliente "
        Me.ToolTip1.SetToolTip(Me.Label1, "Busca por Documentos , Nombres , Apellidos , Fichas  y Tipos de Clientes")
        '
        'cbxtodos
        '
        Me.cbxtodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxtodos.BaseColor = System.Drawing.Color.White
        Me.cbxtodos.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbxtodos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cbxtodos.FillColor = System.Drawing.Color.White
        Me.cbxtodos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxtodos.Location = New System.Drawing.Point(57, 35)
        Me.cbxtodos.Name = "cbxtodos"
        Me.cbxtodos.Size = New System.Drawing.Size(20, 20)
        Me.cbxtodos.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.cbxtodos, "Seleccione para mostrar todos los clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
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
        Me.btnregistros.Location = New System.Drawing.Point(20, 12)
        Me.btnregistros.Name = "btnregistros"
        Me.btnregistros.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistros.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregistros.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregistros.OnHoverImage = Nothing
        Me.btnregistros.OnPressedColor = System.Drawing.Color.Black
        Me.btnregistros.Size = New System.Drawing.Size(60, 60)
        Me.btnregistros.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.btnregistros, "Nuemero de clientes")
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
        Me.btn_primera_pagina.Location = New System.Drawing.Point(395, 705)
        Me.btn_primera_pagina.Name = "btn_primera_pagina"
        Me.btn_primera_pagina.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_primera_pagina.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_primera_pagina.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_primera_pagina.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_primera_pagina.OnHoverImage = Nothing
        Me.btn_primera_pagina.OnPressedColor = System.Drawing.Color.Black
        Me.btn_primera_pagina.Size = New System.Drawing.Size(30, 30)
        Me.btn_primera_pagina.TabIndex = 156
        Me.btn_primera_pagina.Text = "|<"
        Me.ToolTip1.SetToolTip(Me.btn_primera_pagina, "Volver al inicio")
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
        Me.btn_anterior.Location = New System.Drawing.Point(447, 705)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_anterior.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_anterior.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_anterior.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_anterior.OnHoverImage = Nothing
        Me.btn_anterior.OnPressedColor = System.Drawing.Color.Black
        Me.btn_anterior.Size = New System.Drawing.Size(30, 30)
        Me.btn_anterior.TabIndex = 157
        Me.btn_anterior.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btn_anterior, "Anterior")
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
        Me.btn_siguiente.Location = New System.Drawing.Point(826, 705)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_siguiente.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_siguiente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_siguiente.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_siguiente.OnHoverImage = Nothing
        Me.btn_siguiente.OnPressedColor = System.Drawing.Color.Black
        Me.btn_siguiente.Size = New System.Drawing.Size(30, 30)
        Me.btn_siguiente.TabIndex = 158
        Me.btn_siguiente.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btn_siguiente, "Siguiente")
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
        Me.btn_ultima_pagina.Location = New System.Drawing.Point(883, 705)
        Me.btn_ultima_pagina.Name = "btn_ultima_pagina"
        Me.btn_ultima_pagina.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_ultima_pagina.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_ultima_pagina.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_ultima_pagina.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_ultima_pagina.OnHoverImage = Nothing
        Me.btn_ultima_pagina.OnPressedColor = System.Drawing.Color.Black
        Me.btn_ultima_pagina.Size = New System.Drawing.Size(30, 30)
        Me.btn_ultima_pagina.TabIndex = 159
        Me.btn_ultima_pagina.Text = ">|"
        Me.ToolTip1.SetToolTip(Me.btn_ultima_pagina, "Ultima pagina")
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
        Me.btn_reporte_excel.Location = New System.Drawing.Point(12, 113)
        Me.btn_reporte_excel.Name = "btn_reporte_excel"
        Me.btn_reporte_excel.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btn_reporte_excel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.OnHoverImage = Nothing
        Me.btn_reporte_excel.OnPressedColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.Radius = 10
        Me.btn_reporte_excel.Size = New System.Drawing.Size(218, 43)
        Me.btn_reporte_excel.TabIndex = 153
        Me.btn_reporte_excel.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btn_reporte_excel, "Descargar reporte")
        Me.btn_reporte_excel.Visible = False
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
        Me.GunaCircleButton1.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(389, 2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.Size = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.GunaCircleButton1, "Cerrar")
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
        Me.btnexportar.Location = New System.Drawing.Point(9, 102)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Size = New System.Drawing.Size(186, 43)
        Me.btnexportar.TabIndex = 40
        Me.btnexportar.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte del inventario de los elementos")
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
        Me.btnsubir.Location = New System.Drawing.Point(8, 59)
        Me.btnsubir.Name = "btnsubir"
        Me.btnsubir.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnsubir.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnsubir.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnsubir.OnHoverImage = Nothing
        Me.btnsubir.OnPressedColor = System.Drawing.Color.Black
        Me.btnsubir.Size = New System.Drawing.Size(186, 37)
        Me.btnsubir.TabIndex = 39
        Me.btnsubir.Text = "Subir archivo"
        Me.ToolTip1.SetToolTip(Me.btnsubir, "Importar archivo Excel")
        '
        'btntipoprestamo
        '
        Me.btntipoprestamo.AnimationHoverSpeed = 0.07!
        Me.btntipoprestamo.AnimationSpeed = 0.03!
        Me.btntipoprestamo.BackColor = System.Drawing.Color.Transparent
        Me.btntipoprestamo.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btntipoprestamo.BorderColor = System.Drawing.Color.Transparent
        Me.btntipoprestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntipoprestamo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btntipoprestamo.FocusedColor = System.Drawing.Color.Empty
        Me.btntipoprestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipoprestamo.ForeColor = System.Drawing.Color.Black
        Me.btntipoprestamo.Image = Global.Appsena.My.Resources.Resources.icons8_download_64
        Me.btntipoprestamo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btntipoprestamo.Location = New System.Drawing.Point(8, 16)
        Me.btntipoprestamo.Name = "btntipoprestamo"
        Me.btntipoprestamo.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btntipoprestamo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btntipoprestamo.OnHoverForeColor = System.Drawing.Color.Black
        Me.btntipoprestamo.OnHoverImage = Nothing
        Me.btntipoprestamo.OnPressedColor = System.Drawing.Color.Black
        Me.btntipoprestamo.Size = New System.Drawing.Size(187, 37)
        Me.btntipoprestamo.TabIndex = 38
        Me.btntipoprestamo.Text = "Descargar plantilla"
        Me.ToolTip1.SetToolTip(Me.btntipoprestamo, "Descargar")
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
        Me.btnexcel.Location = New System.Drawing.Point(12, 113)
        Me.btnexcel.Name = "btnexcel"
        Me.btnexcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnexcel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexcel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexcel.OnHoverImage = Nothing
        Me.btnexcel.OnPressedColor = System.Drawing.Color.Black
        Me.btnexcel.Radius = 10
        Me.btnexcel.Size = New System.Drawing.Size(138, 36)
        Me.btnexcel.TabIndex = 36
        Me.btnexcel.Text = "Excel"
        Me.ToolTip1.SetToolTip(Me.btnexcel, "Puedes descargar la plantilla para Excel o subir registros.")
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
        Me.btnagregar.Location = New System.Drawing.Point(165, 113)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregar.OnHoverImage = Nothing
        Me.btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregar.Radius = 10
        Me.btnagregar.Size = New System.Drawing.Size(138, 36)
        Me.btnagregar.TabIndex = 35
        Me.btnagregar.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.btnagregar, "Agregar un nuevo cliente")
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAceptar.BorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_32
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(158, 222)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(110, 31)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Acepta eliminar la ficha")
        '
        'pnlexcel
        '
        Me.pnlexcel.BackColor = System.Drawing.Color.Transparent
        Me.pnlexcel.BaseColor = System.Drawing.Color.White
        Me.pnlexcel.Controls.Add(Me.btnexportar)
        Me.pnlexcel.Controls.Add(Me.btnsubir)
        Me.pnlexcel.Controls.Add(Me.btntipoprestamo)
        Me.pnlexcel.Location = New System.Drawing.Point(12, 165)
        Me.pnlexcel.Name = "pnlexcel"
        Me.pnlexcel.ShadowColor = System.Drawing.Color.Black
        Me.pnlexcel.Size = New System.Drawing.Size(203, 153)
        Me.pnlexcel.TabIndex = 37
        Me.pnlexcel.Visible = False
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Documento, Me.Nombres, Me.Apellidos, Me.Telefono_Movil, Me.E_mail, Me.codficha, Me.programa, Me.tipo_documento, Me.Borrar_esta_columna})
        Me.dgexportar.Location = New System.Drawing.Point(1164, 30)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(86, 37)
        Me.dgexportar.TabIndex = 38
        Me.dgexportar.Visible = False
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        '
        'Telefono_Movil
        '
        Me.Telefono_Movil.HeaderText = "Telefono Movil"
        Me.Telefono_Movil.Name = "Telefono_Movil"
        Me.Telefono_Movil.ReadOnly = True
        '
        'E_mail
        '
        Me.E_mail.HeaderText = "E-mail"
        Me.E_mail.Name = "E_mail"
        Me.E_mail.ReadOnly = True
        '
        'codficha
        '
        Me.codficha.HeaderText = "Ficha"
        Me.codficha.Name = "codficha"
        Me.codficha.ReadOnly = True
        '
        'programa
        '
        Me.programa.HeaderText = "Programa"
        Me.programa.Name = "programa"
        Me.programa.ReadOnly = True
        '
        'tipo_documento
        '
        Me.tipo_documento.HeaderText = "Tipo_documento"
        Me.tipo_documento.Name = "tipo_documento"
        Me.tipo_documento.ReadOnly = True
        '
        'Borrar_esta_columna
        '
        Me.Borrar_esta_columna.HeaderText = ""
        Me.Borrar_esta_columna.Name = "Borrar_esta_columna"
        Me.Borrar_esta_columna.ReadOnly = True
        '
        'dgimportar
        '
        Me.dgimportar.AllowUserToAddRows = False
        Me.dgimportar.AllowUserToDeleteRows = False
        Me.dgimportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgimportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgimportar.Location = New System.Drawing.Point(749, 11)
        Me.dgimportar.Name = "dgimportar"
        Me.dgimportar.ReadOnly = True
        Me.dgimportar.Size = New System.Drawing.Size(80, 36)
        Me.dgimportar.TabIndex = 40
        Me.dgimportar.Visible = False
        '
        'cmbtipo_cliente
        '
        Me.cmbtipo_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbtipo_cliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbtipo_cliente.BaseColor = System.Drawing.Color.White
        Me.cmbtipo_cliente.BorderColor = System.Drawing.Color.Silver
        Me.cmbtipo_cliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo_cliente.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtipo_cliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo_cliente.ForeColor = System.Drawing.Color.Black
        Me.cmbtipo_cliente.FormattingEnabled = True
        Me.cmbtipo_cliente.Location = New System.Drawing.Point(120, 35)
        Me.cmbtipo_cliente.Name = "cmbtipo_cliente"
        Me.cmbtipo_cliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbtipo_cliente.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtipo_cliente.Radius = 10
        Me.cmbtipo_cliente.Size = New System.Drawing.Size(254, 28)
        Me.cmbtipo_cliente.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Seleccione un tipo de cliente"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Mostrar Todos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 27)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu
        '
        Me.menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.eliminar_fichas, Me.ClientesEliminadosToolStripMenuItem, Me.FichasToolStripMenuItem})
        Me.menu.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Image = Global.Appsena.My.Resources.Resources.icons8_bulleted_list_32
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(118, 23)
        Me.menu.Text = "OPCIONES"
        '
        'eliminar_fichas
        '
        Me.eliminar_fichas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar_fichas.Image = Global.Appsena.My.Resources.Resources.icons8_order_history_64
        Me.eliminar_fichas.Name = "eliminar_fichas"
        Me.eliminar_fichas.Size = New System.Drawing.Size(222, 24)
        Me.eliminar_fichas.Text = "Eliminar fichas"
        '
        'ClientesEliminadosToolStripMenuItem
        '
        Me.ClientesEliminadosToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_delete_user_male_64
        Me.ClientesEliminadosToolStripMenuItem.Name = "ClientesEliminadosToolStripMenuItem"
        Me.ClientesEliminadosToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ClientesEliminadosToolStripMenuItem.Text = "Clientes eliminados"
        '
        'FichasToolStripMenuItem
        '
        Me.FichasToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_activity_history_64
        Me.FichasToolStripMenuItem.Name = "FichasToolStripMenuItem"
        Me.FichasToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.FichasToolStripMenuItem.Text = "Fichas"
        '
        'pnlficha
        '
        Me.pnlficha.BackColor = System.Drawing.Color.Transparent
        Me.pnlficha.BaseColor = System.Drawing.Color.White
        Me.pnlficha.Controls.Add(Me.cmbficha)
        Me.pnlficha.Controls.Add(Me.Label6)
        Me.pnlficha.Controls.Add(Me.Panel1)
        Me.pnlficha.Controls.Add(Me.txtbuscadorficha)
        Me.pnlficha.Controls.Add(Me.btnAceptar)
        Me.pnlficha.Controls.Add(Me.lblficha)
        Me.pnlficha.Location = New System.Drawing.Point(519, 188)
        Me.pnlficha.Name = "pnlficha"
        Me.pnlficha.ShadowColor = System.Drawing.Color.Black
        Me.pnlficha.Size = New System.Drawing.Size(420, 273)
        Me.pnlficha.TabIndex = 58
        Me.pnlficha.Visible = False
        '
        'cmbficha
        '
        Me.cmbficha.BackColor = System.Drawing.Color.Transparent
        Me.cmbficha.BaseColor = System.Drawing.Color.White
        Me.cmbficha.BorderColor = System.Drawing.Color.Silver
        Me.cmbficha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbficha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbficha.FocusedColor = System.Drawing.Color.Empty
        Me.cmbficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbficha.ForeColor = System.Drawing.Color.Black
        Me.cmbficha.FormattingEnabled = True
        Me.cmbficha.Location = New System.Drawing.Point(32, 188)
        Me.cmbficha.Name = "cmbficha"
        Me.cmbficha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbficha.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbficha.Radius = 10
        Me.cmbficha.Size = New System.Drawing.Size(362, 28)
        Me.cmbficha.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(383, 63)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Elimine todos los aprendices pertenecientes a la ficha elegida."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 33)
        Me.Panel1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(47, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Eliminar aprendices"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbuscadorficha
        '
        Me.txtbuscadorficha.BackColor = System.Drawing.Color.Transparent
        Me.txtbuscadorficha.BaseColor = System.Drawing.Color.White
        Me.txtbuscadorficha.BorderColor = System.Drawing.Color.Silver
        Me.txtbuscadorficha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuscadorficha.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbuscadorficha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtbuscadorficha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbuscadorficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscadorficha.ForeColor = System.Drawing.Color.Black
        Me.txtbuscadorficha.Location = New System.Drawing.Point(35, 146)
        Me.txtbuscadorficha.Name = "txtbuscadorficha"
        Me.txtbuscadorficha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscadorficha.Radius = 10
        Me.txtbuscadorficha.Size = New System.Drawing.Size(362, 30)
        Me.txtbuscadorficha.TabIndex = 109
        '
        'lblficha
        '
        Me.lblficha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblficha.AutoSize = True
        Me.lblficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblficha.Location = New System.Drawing.Point(154, 124)
        Me.lblficha.Name = "lblficha"
        Me.lblficha.Size = New System.Drawing.Size(140, 19)
        Me.lblficha.TabIndex = 108
        Me.lblficha.Text = "Codigo de la ficha"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(287, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 5)
        Me.Panel2.TabIndex = 117
        Me.Panel2.Visible = False
        '
        'lblestado
        '
        Me.lblestado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.Location = New System.Drawing.Point(358, 27)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(200, 25)
        Me.lblestado.TabIndex = 118
        Me.lblestado.Text = "Clientes eliminados"
        Me.lblestado.Visible = False
        '
        'dgreportes
        '
        Me.dgreportes.AllowUserToAddRows = False
        Me.dgreportes.AllowUserToDeleteRows = False
        Me.dgreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgreportes.Location = New System.Drawing.Point(850, 12)
        Me.dgreportes.Name = "dgreportes"
        Me.dgreportes.ReadOnly = True
        Me.dgreportes.Size = New System.Drawing.Size(86, 35)
        Me.dgreportes.TabIndex = 154
        Me.dgreportes.Visible = False
        '
        'pnl_filtros
        '
        Me.pnl_filtros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_filtros.Controls.Add(Me.Label2)
        Me.pnl_filtros.Controls.Add(Me.cmbtipo_cliente)
        Me.pnl_filtros.Controls.Add(Me.cbxtodos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Location = New System.Drawing.Point(455, 81)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(383, 68)
        Me.pnl_filtros.TabIndex = 155
        '
        'lblpagina
        '
        Me.lblpagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblpagina.AutoSize = True
        Me.lblpagina.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagina.Location = New System.Drawing.Point(589, 705)
        Me.lblpagina.Name = "lblpagina"
        Me.lblpagina.Size = New System.Drawing.Size(18, 19)
        Me.lblpagina.TabIndex = 111
        Me.lblpagina.Text = "1"
        '
        'lbl_total_paginas
        '
        Me.lbl_total_paginas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_total_paginas.AutoSize = True
        Me.lbl_total_paginas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_paginas.Location = New System.Drawing.Point(640, 705)
        Me.lbl_total_paginas.Name = "lbl_total_paginas"
        Me.lbl_total_paginas.Size = New System.Drawing.Size(27, 19)
        Me.lbl_total_paginas.TabIndex = 160
        Me.lbl_total_paginas.Text = "/ 6"
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
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.HeaderText = "Editar"
        Me.DataGridViewImageColumn2.Image = Global.Appsena.My.Resources.Resources.icons8_edit_64
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 70
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1262, 757)
        Me.Controls.Add(Me.lbl_total_paginas)
        Me.Controls.Add(Me.btn_ultima_pagina)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.btn_primera_pagina)
        Me.Controls.Add(Me.lblpagina)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Controls.Add(Me.dgreportes)
        Me.Controls.Add(Me.btn_reporte_excel)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnregistros)
        Me.Controls.Add(Me.pnlficha)
        Me.Controls.Add(Me.dgimportar)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.pnlexcel)
        Me.Controls.Add(Me.btnexcel)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlexcel.ResumeLayout(False)
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgimportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlficha.ResumeLayout(False)
        Me.pnlficha.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgreportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnagregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnexcel As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlexcel As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnsubir As Guna.UI.WinForms.GunaButton
    Friend WithEvents btntipoprestamo As Guna.UI.WinForms.GunaButton
    Friend WithEvents clmeliminar As DataGridViewImageColumn
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents dgimportar As DataGridView
    Friend WithEvents cmbtipo_cliente As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxtodos As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu As ToolStripMenuItem
    Friend WithEvents eliminar_fichas As ToolStripMenuItem
    Friend WithEvents pnlficha As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbficha As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtbuscadorficha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblficha As Label
    Friend WithEvents btnregistros As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ClientesEliminadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblestado As Label
    Friend WithEvents btn_reporte_excel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgreportes As DataGridView
    Friend WithEvents pnl_filtros As Panel
    Friend WithEvents lblpagina As Label
    Friend WithEvents btn_ultima_pagina As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btn_siguiente As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btn_anterior As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btn_primera_pagina As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents lbl_total_paginas As Label
    Friend WithEvents FichasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_Movil As DataGridViewTextBoxColumn
    Friend WithEvents E_mail As DataGridViewTextBoxColumn
    Friend WithEvents codficha As DataGridViewTextBoxColumn
    Friend WithEvents programa As DataGridViewTextBoxColumn
    Friend WithEvents tipo_documento As DataGridViewTextBoxColumn
    Friend WithEvents Borrar_esta_columna As DataGridViewTextBoxColumn
End Class
