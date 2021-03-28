<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_fichas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fichas))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.panel_header = New Guna.UI.WinForms.GunaPanel()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblheader = New Guna.UI.WinForms.GunaLabel()
        Me.panel_registro = New Guna.UI.WinForms.GunaShadowPanel()
        Me.cerrar_panel = New Guna.UI.WinForms.GunaCircleButton()
        Me.txtruta_enlace = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_actualizarficha = New Guna.UI.WinForms.GunaButton()
        Me.btnguardarficha = New Guna.UI.WinForms.GunaButton()
        Me.txtprograma = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnregistros = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cerrar_panel_enlace = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_guardarenlace = New Guna.UI.WinForms.GunaButton()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.pnl_enlace = New Guna.UI.WinForms.GunaShadowPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtenlace = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.URLParaElRegistroEnLaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.URLParaElRegistroEnLaWebToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichasEliminadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichasActualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.lbltitulo_fichas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_header.SuspendLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_registro.SuspendLayout()
        Me.pnl_enlace.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.dgdatos.Location = New System.Drawing.Point(26, 217)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(1205, 445)
        Me.dgdatos.TabIndex = 121
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
        Me.Label1.Location = New System.Drawing.Point(961, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Buscar Cliente "
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
        Me.txtbuscador.Location = New System.Drawing.Point(825, 181)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(406, 30)
        Me.txtbuscador.TabIndex = 122
        Me.txtbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.panel_header.Controls.Add(Me.dgexportar)
        Me.panel_header.Controls.Add(Me.btncerrar)
        Me.panel_header.Controls.Add(Me.lblheader)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1262, 64)
        Me.panel_header.TabIndex = 124
        '
        'dgexportar
        '
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(77, 38)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.Size = New System.Drawing.Size(87, 23)
        Me.dgexportar.TabIndex = 154
        Me.dgexportar.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btncerrar.Location = New System.Drawing.Point(1222, 17)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncerrar.OnHoverImage = Nothing
        Me.btncerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btncerrar.Size = New System.Drawing.Size(28, 28)
        Me.btncerrar.TabIndex = 125
        '
        'lblheader
        '
        Me.lblheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Zurich", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.White
        Me.lblheader.Location = New System.Drawing.Point(555, 23)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(199, 22)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Fichas y Programas"
        '
        'panel_registro
        '
        Me.panel_registro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_registro.BackColor = System.Drawing.Color.Transparent
        Me.panel_registro.BaseColor = System.Drawing.Color.White
        Me.panel_registro.Controls.Add(Me.cerrar_panel)
        Me.panel_registro.Controls.Add(Me.txtruta_enlace)
        Me.panel_registro.Controls.Add(Me.btn_actualizarficha)
        Me.panel_registro.Controls.Add(Me.btnguardarficha)
        Me.panel_registro.Controls.Add(Me.txtprograma)
        Me.panel_registro.Controls.Add(Me.Label3)
        Me.panel_registro.Controls.Add(Me.txtcodigo)
        Me.panel_registro.Controls.Add(Me.Label2)
        Me.panel_registro.Location = New System.Drawing.Point(230, 89)
        Me.panel_registro.Name = "panel_registro"
        Me.panel_registro.ShadowColor = System.Drawing.Color.Black
        Me.panel_registro.Size = New System.Drawing.Size(860, 122)
        Me.panel_registro.TabIndex = 125
        Me.panel_registro.Visible = False
        '
        'cerrar_panel
        '
        Me.cerrar_panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar_panel.AnimationHoverSpeed = 0.07!
        Me.cerrar_panel.AnimationSpeed = 0.03!
        Me.cerrar_panel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cerrar_panel.BorderColor = System.Drawing.Color.Black
        Me.cerrar_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar_panel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cerrar_panel.FocusedColor = System.Drawing.Color.Empty
        Me.cerrar_panel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cerrar_panel.ForeColor = System.Drawing.Color.White
        Me.cerrar_panel.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.cerrar_panel.ImageSize = New System.Drawing.Size(23, 23)
        Me.cerrar_panel.Location = New System.Drawing.Point(828, 8)
        Me.cerrar_panel.Name = "cerrar_panel"
        Me.cerrar_panel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cerrar_panel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.cerrar_panel.OnHoverForeColor = System.Drawing.Color.White
        Me.cerrar_panel.OnHoverImage = Nothing
        Me.cerrar_panel.OnPressedColor = System.Drawing.Color.Red
        Me.cerrar_panel.Size = New System.Drawing.Size(23, 23)
        Me.cerrar_panel.TabIndex = 126
        Me.ToolTip1.SetToolTip(Me.cerrar_panel, "Cerrar")
        '
        'txtruta_enlace
        '
        Me.txtruta_enlace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtruta_enlace.BackColor = System.Drawing.Color.Transparent
        Me.txtruta_enlace.BaseColor = System.Drawing.Color.White
        Me.txtruta_enlace.BorderColor = System.Drawing.Color.Silver
        Me.txtruta_enlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtruta_enlace.Enabled = False
        Me.txtruta_enlace.FocusedBaseColor = System.Drawing.Color.White
        Me.txtruta_enlace.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtruta_enlace.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtruta_enlace.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruta_enlace.Location = New System.Drawing.Point(49, 77)
        Me.txtruta_enlace.Name = "txtruta_enlace"
        Me.txtruta_enlace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtruta_enlace.Radius = 10
        Me.txtruta_enlace.Size = New System.Drawing.Size(528, 31)
        Me.txtruta_enlace.TabIndex = 73
        Me.txtruta_enlace.Tag = "3"
        Me.txtruta_enlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_actualizarficha
        '
        Me.btn_actualizarficha.AnimationHoverSpeed = 0.07!
        Me.btn_actualizarficha.AnimationSpeed = 0.03!
        Me.btn_actualizarficha.BackColor = System.Drawing.Color.Transparent
        Me.btn_actualizarficha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btn_actualizarficha.BorderColor = System.Drawing.Color.Black
        Me.btn_actualizarficha.CausesValidation = False
        Me.btn_actualizarficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizarficha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_actualizarficha.FocusedColor = System.Drawing.Color.Empty
        Me.btn_actualizarficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizarficha.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarficha.Image = Global.Appsena.My.Resources.Resources.icons8_pencil_white_64
        Me.btn_actualizarficha.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_actualizarficha.Location = New System.Drawing.Point(620, 41)
        Me.btn_actualizarficha.Name = "btn_actualizarficha"
        Me.btn_actualizarficha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_actualizarficha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_actualizarficha.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_actualizarficha.OnHoverImage = Nothing
        Me.btn_actualizarficha.OnPressedColor = System.Drawing.Color.Black
        Me.btn_actualizarficha.Radius = 10
        Me.btn_actualizarficha.Size = New System.Drawing.Size(180, 30)
        Me.btn_actualizarficha.TabIndex = 127
        Me.btn_actualizarficha.Text = "Actualizar Datos"
        Me.btn_actualizarficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btn_actualizarficha, "Actualizar")
        Me.btn_actualizarficha.Visible = False
        '
        'btnguardarficha
        '
        Me.btnguardarficha.AnimationHoverSpeed = 0.07!
        Me.btnguardarficha.AnimationSpeed = 0.03!
        Me.btnguardarficha.BackColor = System.Drawing.Color.Transparent
        Me.btnguardarficha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnguardarficha.BorderColor = System.Drawing.Color.Black
        Me.btnguardarficha.CausesValidation = False
        Me.btnguardarficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardarficha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardarficha.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardarficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarficha.ForeColor = System.Drawing.Color.White
        Me.btnguardarficha.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardarficha.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardarficha.Location = New System.Drawing.Point(620, 40)
        Me.btnguardarficha.Name = "btnguardarficha"
        Me.btnguardarficha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnguardarficha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnguardarficha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardarficha.OnHoverImage = Nothing
        Me.btnguardarficha.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardarficha.Radius = 10
        Me.btnguardarficha.Size = New System.Drawing.Size(180, 30)
        Me.btnguardarficha.TabIndex = 126
        Me.btnguardarficha.Text = "Guardar Datos"
        Me.btnguardarficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnguardarficha, "Guardar")
        '
        'txtprograma
        '
        Me.txtprograma.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtprograma.BackColor = System.Drawing.Color.Transparent
        Me.txtprograma.BaseColor = System.Drawing.Color.White
        Me.txtprograma.BorderColor = System.Drawing.Color.Silver
        Me.txtprograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprograma.FocusedBaseColor = System.Drawing.Color.White
        Me.txtprograma.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtprograma.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtprograma.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprograma.Location = New System.Drawing.Point(349, 37)
        Me.txtprograma.Name = "txtprograma"
        Me.txtprograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprograma.Radius = 10
        Me.txtprograma.Size = New System.Drawing.Size(230, 31)
        Me.txtprograma.TabIndex = 75
        Me.txtprograma.Tag = "3"
        Me.txtprograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(427, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Programa"
        '
        'txtcodigo
        '
        Me.txtcodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodigo.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigo.BaseColor = System.Drawing.Color.White
        Me.txtcodigo.BorderColor = System.Drawing.Color.Silver
        Me.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcodigo.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcodigo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtcodigo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcodigo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(49, 37)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcodigo.Radius = 10
        Me.txtcodigo.Size = New System.Drawing.Size(230, 31)
        Me.txtcodigo.TabIndex = 73
        Me.txtcodigo.Tag = "3"
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Ficha"
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
        Me.btnregistros.Location = New System.Drawing.Point(12, 99)
        Me.btnregistros.Name = "btnregistros"
        Me.btnregistros.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistros.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregistros.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregistros.OnHoverImage = Nothing
        Me.btnregistros.OnPressedColor = System.Drawing.Color.Black
        Me.btnregistros.Size = New System.Drawing.Size(60, 60)
        Me.btnregistros.TabIndex = 126
        Me.ToolTip1.SetToolTip(Me.btnregistros, "Numero de registros")
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
        Me.btnagregar.Image = Nothing
        Me.btnagregar.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnagregar.Location = New System.Drawing.Point(26, 175)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregar.OnHoverImage = Nothing
        Me.btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregar.Radius = 10
        Me.btnagregar.Size = New System.Drawing.Size(138, 36)
        Me.btnagregar.TabIndex = 128
        Me.btnagregar.Text = "Nueva ficha"
        Me.btnagregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnagregar, "Agregar una nueva ficha")
        '
        'cerrar_panel_enlace
        '
        Me.cerrar_panel_enlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar_panel_enlace.AnimationHoverSpeed = 0.07!
        Me.cerrar_panel_enlace.AnimationSpeed = 0.03!
        Me.cerrar_panel_enlace.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cerrar_panel_enlace.BorderColor = System.Drawing.Color.Black
        Me.cerrar_panel_enlace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar_panel_enlace.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cerrar_panel_enlace.FocusedColor = System.Drawing.Color.Empty
        Me.cerrar_panel_enlace.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cerrar_panel_enlace.ForeColor = System.Drawing.Color.White
        Me.cerrar_panel_enlace.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.cerrar_panel_enlace.ImageSize = New System.Drawing.Size(23, 23)
        Me.cerrar_panel_enlace.Location = New System.Drawing.Point(604, 8)
        Me.cerrar_panel_enlace.Name = "cerrar_panel_enlace"
        Me.cerrar_panel_enlace.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cerrar_panel_enlace.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.cerrar_panel_enlace.OnHoverForeColor = System.Drawing.Color.White
        Me.cerrar_panel_enlace.OnHoverImage = Nothing
        Me.cerrar_panel_enlace.OnPressedColor = System.Drawing.Color.Red
        Me.cerrar_panel_enlace.Size = New System.Drawing.Size(23, 23)
        Me.cerrar_panel_enlace.TabIndex = 126
        Me.ToolTip1.SetToolTip(Me.cerrar_panel_enlace, "Cerrar")
        '
        'btn_guardarenlace
        '
        Me.btn_guardarenlace.AnimationHoverSpeed = 0.07!
        Me.btn_guardarenlace.AnimationSpeed = 0.03!
        Me.btn_guardarenlace.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarenlace.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btn_guardarenlace.BorderColor = System.Drawing.Color.Black
        Me.btn_guardarenlace.CausesValidation = False
        Me.btn_guardarenlace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardarenlace.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_guardarenlace.FocusedColor = System.Drawing.Color.Empty
        Me.btn_guardarenlace.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardarenlace.ForeColor = System.Drawing.Color.White
        Me.btn_guardarenlace.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btn_guardarenlace.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_guardarenlace.Location = New System.Drawing.Point(238, 132)
        Me.btn_guardarenlace.Name = "btn_guardarenlace"
        Me.btn_guardarenlace.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_guardarenlace.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_guardarenlace.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_guardarenlace.OnHoverImage = Nothing
        Me.btn_guardarenlace.OnPressedColor = System.Drawing.Color.Black
        Me.btn_guardarenlace.Radius = 10
        Me.btn_guardarenlace.Size = New System.Drawing.Size(180, 30)
        Me.btn_guardarenlace.TabIndex = 128
        Me.btn_guardarenlace.Text = "Guardar Datos"
        Me.btn_guardarenlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btn_guardarenlace, "Guardar")
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
        Me.btnexportar.Location = New System.Drawing.Point(176, 175)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Radius = 10
        Me.btnexportar.Size = New System.Drawing.Size(213, 36)
        Me.btnexportar.TabIndex = 153
        Me.btnexportar.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte")
        '
        'pnl_enlace
        '
        Me.pnl_enlace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_enlace.BackColor = System.Drawing.Color.White
        Me.pnl_enlace.BaseColor = System.Drawing.Color.White
        Me.pnl_enlace.Controls.Add(Me.Label4)
        Me.pnl_enlace.Controls.Add(Me.LinkLabel1)
        Me.pnl_enlace.Controls.Add(Me.btn_guardarenlace)
        Me.pnl_enlace.Controls.Add(Me.cerrar_panel_enlace)
        Me.pnl_enlace.Controls.Add(Me.txtenlace)
        Me.pnl_enlace.Controls.Add(Me.Label5)
        Me.pnl_enlace.Location = New System.Drawing.Point(336, 265)
        Me.pnl_enlace.Name = "pnl_enlace"
        Me.pnl_enlace.ShadowColor = System.Drawing.Color.Black
        Me.pnl_enlace.Size = New System.Drawing.Size(636, 174)
        Me.pnl_enlace.TabIndex = 128
        Me.pnl_enlace.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(453, 73)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(79, 19)
        Me.LinkLabel1.TabIndex = 129
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modificar"
        '
        'txtenlace
        '
        Me.txtenlace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtenlace.BackColor = System.Drawing.Color.Transparent
        Me.txtenlace.BaseColor = System.Drawing.Color.White
        Me.txtenlace.BorderColor = System.Drawing.Color.Silver
        Me.txtenlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtenlace.Enabled = False
        Me.txtenlace.FocusedBaseColor = System.Drawing.Color.White
        Me.txtenlace.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtenlace.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtenlace.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenlace.Location = New System.Drawing.Point(73, 95)
        Me.txtenlace.Name = "txtenlace"
        Me.txtenlace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtenlace.Radius = 10
        Me.txtenlace.Size = New System.Drawing.Size(470, 31)
        Me.txtenlace.TabIndex = 73
        Me.txtenlace.Tag = "3"
        Me.txtenlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(565, 19)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Por favor guarde aqui el enlace donde se registran los aprendices en la web." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.URLParaElRegistroEnLaWebToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 64)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(115, 27)
        Me.MenuStrip1.TabIndex = 129
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'URLParaElRegistroEnLaWebToolStripMenuItem
        '
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.URLParaElRegistroEnLaWebToolStripMenuItem1, Me.FichasEliminadasToolStripMenuItem, Me.FichasActualesToolStripMenuItem})
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_bulleted_list_32
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.Name = "URLParaElRegistroEnLaWebToolStripMenuItem"
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.Size = New System.Drawing.Size(107, 23)
        Me.URLParaElRegistroEnLaWebToolStripMenuItem.Text = "Opciones"
        '
        'URLParaElRegistroEnLaWebToolStripMenuItem1
        '
        Me.URLParaElRegistroEnLaWebToolStripMenuItem1.Image = Global.Appsena.My.Resources.Resources.icons8_website_64
        Me.URLParaElRegistroEnLaWebToolStripMenuItem1.Name = "URLParaElRegistroEnLaWebToolStripMenuItem1"
        Me.URLParaElRegistroEnLaWebToolStripMenuItem1.Size = New System.Drawing.Size(297, 24)
        Me.URLParaElRegistroEnLaWebToolStripMenuItem1.Text = "URL para el registro en la web"
        '
        'FichasEliminadasToolStripMenuItem
        '
        Me.FichasEliminadasToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_order_history_64
        Me.FichasEliminadasToolStripMenuItem.Name = "FichasEliminadasToolStripMenuItem"
        Me.FichasEliminadasToolStripMenuItem.Size = New System.Drawing.Size(297, 24)
        Me.FichasEliminadasToolStripMenuItem.Text = "Fichas eliminadas"
        '
        'FichasActualesToolStripMenuItem
        '
        Me.FichasActualesToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_document_64
        Me.FichasActualesToolStripMenuItem.Name = "FichasActualesToolStripMenuItem"
        Me.FichasActualesToolStripMenuItem.Size = New System.Drawing.Size(297, 24)
        Me.FichasActualesToolStripMenuItem.Text = "Fichas actuales"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 701)
        Me.Panel1.TabIndex = 131
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(1257, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 699)
        Me.Panel2.TabIndex = 132
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1256, 5)
        Me.Panel3.TabIndex = 132
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(0, 699)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1262, 5)
        Me.Panel4.TabIndex = 132
        '
        'pnl_header
        '
        Me.pnl_header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnl_header.Location = New System.Drawing.Point(394, 148)
        Me.pnl_header.Name = "pnl_header"
        Me.pnl_header.Size = New System.Drawing.Size(485, 5)
        Me.pnl_header.TabIndex = 134
        Me.pnl_header.Visible = False
        '
        'lbltitulo_fichas
        '
        Me.lbltitulo_fichas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbltitulo_fichas.AutoSize = True
        Me.lbltitulo_fichas.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo_fichas.ForeColor = System.Drawing.Color.Black
        Me.lbltitulo_fichas.Location = New System.Drawing.Point(451, 120)
        Me.lbltitulo_fichas.Name = "lbltitulo_fichas"
        Me.lbltitulo_fichas.Size = New System.Drawing.Size(182, 25)
        Me.lbltitulo_fichas.TabIndex = 133
        Me.lbltitulo_fichas.Text = "Fichas eliminadas"
        Me.lbltitulo_fichas.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 19)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "http://www.Tu pagina .com"
        '
        'frm_fichas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 705)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.pnl_header)
        Me.Controls.Add(Me.lbltitulo_fichas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_enlace)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnregistros)
        Me.Controls.Add(Me.panel_registro)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.dgdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_fichas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichas"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_registro.ResumeLayout(False)
        Me.panel_registro.PerformLayout()
        Me.pnl_enlace.ResumeLayout(False)
        Me.pnl_enlace.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents clmeliminar As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents panel_header As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblheader As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents panel_registro As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents txtprograma As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcodigo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_actualizarficha As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnguardarficha As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnregistros As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnagregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents cerrar_panel As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnl_enlace As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents cerrar_panel_enlace As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txtenlace As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents URLParaElRegistroEnLaWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents URLParaElRegistroEnLaWebToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn_guardarenlace As Guna.UI.WinForms.GunaButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtruta_enlace As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FichasEliminadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnl_header As Panel
    Friend WithEvents lbltitulo_fichas As Label
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents FichasActualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
End Class
