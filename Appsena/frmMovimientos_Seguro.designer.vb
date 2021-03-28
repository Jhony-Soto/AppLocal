<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientos_Seguro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Seguro))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFormato2 = New System.Windows.Forms.Label()
        Me.btnGenerarSa = New Guna.UI.WinForms.GunaButton()
        Me.lblFormato1 = New System.Windows.Forms.Label()
        Me.dgvEDevolutivos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrpción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEConsumos = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenerarSeg = New Guna.UI.WinForms.GunaButton()
        Me.btnSubirSa = New Guna.UI.WinForms.GunaButton()
        Me.btnSubirSeg = New Guna.UI.WinForms.GunaButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvEDevolutivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEConsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 5)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(409, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(5, 293)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 293)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 5)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 288)
        Me.Panel3.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCircleButton1)
        Me.Panel5.Controls.Add(Me.lblTitulo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(404, 33)
        Me.Panel5.TabIndex = 6
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(371, 2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.Size = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.TabIndex = 47
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(404, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Generar formatos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFormato2
        '
        Me.lblFormato2.AutoSize = True
        Me.lblFormato2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato2.ForeColor = System.Drawing.Color.Black
        Me.lblFormato2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormato2.Location = New System.Drawing.Point(24, 159)
        Me.lblFormato2.Name = "lblFormato2"
        Me.lblFormato2.Size = New System.Drawing.Size(143, 20)
        Me.lblFormato2.TabIndex = 48
        Me.lblFormato2.Text = "Formato de salida:"
        Me.lblFormato2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarSa
        '
        Me.btnGenerarSa.AnimationHoverSpeed = 0.07!
        Me.btnGenerarSa.AnimationSpeed = 0.03!
        Me.btnGenerarSa.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerarSa.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnGenerarSa.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenerarSa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarSa.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerarSa.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerarSa.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarSa.ForeColor = System.Drawing.Color.White
        Me.btnGenerarSa.Image = Global.Appsena.My.Resources.Resources.icons8_microsoft_excel_64
        Me.btnGenerarSa.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerarSa.Location = New System.Drawing.Point(27, 182)
        Me.btnGenerarSa.Name = "btnGenerarSa"
        Me.btnGenerarSa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGenerarSa.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnGenerarSa.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerarSa.OnHoverImage = Nothing
        Me.btnGenerarSa.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerarSa.Radius = 10
        Me.btnGenerarSa.Size = New System.Drawing.Size(190, 31)
        Me.btnGenerarSa.TabIndex = 49
        Me.btnGenerarSa.Text = "Generar elementos"
        '
        'lblFormato1
        '
        Me.lblFormato1.AutoSize = True
        Me.lblFormato1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato1.ForeColor = System.Drawing.Color.Black
        Me.lblFormato1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormato1.Location = New System.Drawing.Point(22, 58)
        Me.lblFormato1.Name = "lblFormato1"
        Me.lblFormato1.Size = New System.Drawing.Size(153, 20)
        Me.lblFormato1.TabIndex = 51
        Me.lblFormato1.Text = "Formato de seguro:"
        Me.lblFormato1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvEDevolutivos
        '
        Me.dgvEDevolutivos.AllowUserToAddRows = False
        Me.dgvEDevolutivos.AllowUserToDeleteRows = False
        Me.dgvEDevolutivos.AllowUserToResizeColumns = False
        Me.dgvEDevolutivos.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.dgvEDevolutivos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvEDevolutivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEDevolutivos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEDevolutivos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEDevolutivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEDevolutivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEDevolutivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvEDevolutivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEDevolutivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descrpción, Me.Cantidad})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEDevolutivos.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvEDevolutivos.EnableHeadersVisualStyles = False
        Me.dgvEDevolutivos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEDevolutivos.Location = New System.Drawing.Point(27, 118)
        Me.dgvEDevolutivos.Name = "dgvEDevolutivos"
        Me.dgvEDevolutivos.RowHeadersVisible = False
        Me.dgvEDevolutivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEDevolutivos.Size = New System.Drawing.Size(91, 17)
        Me.dgvEDevolutivos.TabIndex = 52
        Me.dgvEDevolutivos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvEDevolutivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEDevolutivos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvEDevolutivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvEDevolutivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvEDevolutivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvEDevolutivos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvEDevolutivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEDevolutivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvEDevolutivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEDevolutivos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEDevolutivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvEDevolutivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEDevolutivos.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvEDevolutivos.ThemeStyle.ReadOnly = False
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvEDevolutivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEDevolutivos.Visible = False
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codigo.FillWeight = 30.0!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Descrpción
        '
        Me.Descrpción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descrpción.HeaderText = "Descripción"
        Me.Descrpción.Name = "Descrpción"
        Me.Descrpción.ReadOnly = True
        Me.Descrpción.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle11
        Me.Cantidad.FillWeight = 30.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cantidad.Width = 78
        '
        'dgvEConsumos
        '
        Me.dgvEConsumos.AllowUserToAddRows = False
        Me.dgvEConsumos.AllowUserToDeleteRows = False
        Me.dgvEConsumos.AllowUserToResizeColumns = False
        Me.dgvEConsumos.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvEConsumos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvEConsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEConsumos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEConsumos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEConsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEConsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEConsumos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvEConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEConsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEConsumos.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvEConsumos.EnableHeadersVisualStyles = False
        Me.dgvEConsumos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEConsumos.Location = New System.Drawing.Point(124, 118)
        Me.dgvEConsumos.Name = "dgvEConsumos"
        Me.dgvEConsumos.RowHeadersVisible = False
        Me.dgvEConsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEConsumos.Size = New System.Drawing.Size(104, 17)
        Me.dgvEConsumos.TabIndex = 53
        Me.dgvEConsumos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvEConsumos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEConsumos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvEConsumos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvEConsumos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvEConsumos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvEConsumos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvEConsumos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEConsumos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvEConsumos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEConsumos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEConsumos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvEConsumos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEConsumos.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvEConsumos.ThemeStyle.ReadOnly = False
        Me.dgvEConsumos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEConsumos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEConsumos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEConsumos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEConsumos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvEConsumos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvEConsumos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEConsumos.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn3.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 78
        '
        'btnGenerarSeg
        '
        Me.btnGenerarSeg.AnimationHoverSpeed = 0.07!
        Me.btnGenerarSeg.AnimationSpeed = 0.03!
        Me.btnGenerarSeg.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerarSeg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnGenerarSeg.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenerarSeg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarSeg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerarSeg.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerarSeg.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarSeg.ForeColor = System.Drawing.Color.White
        Me.btnGenerarSeg.Image = Global.Appsena.My.Resources.Resources.icons8_microsoft_excel_64
        Me.btnGenerarSeg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerarSeg.Location = New System.Drawing.Point(26, 81)
        Me.btnGenerarSeg.Name = "btnGenerarSeg"
        Me.btnGenerarSeg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGenerarSeg.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnGenerarSeg.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerarSeg.OnHoverImage = Nothing
        Me.btnGenerarSeg.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerarSeg.Radius = 10
        Me.btnGenerarSeg.Size = New System.Drawing.Size(190, 31)
        Me.btnGenerarSeg.TabIndex = 54
        Me.btnGenerarSeg.Text = "Generar elementos"
        '
        'btnSubirSa
        '
        Me.btnSubirSa.AnimationHoverSpeed = 0.07!
        Me.btnSubirSa.AnimationSpeed = 0.03!
        Me.btnSubirSa.BackColor = System.Drawing.Color.Transparent
        Me.btnSubirSa.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnSubirSa.BorderColor = System.Drawing.Color.Transparent
        Me.btnSubirSa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubirSa.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSubirSa.FocusedColor = System.Drawing.Color.Empty
        Me.btnSubirSa.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirSa.ForeColor = System.Drawing.Color.White
        Me.btnSubirSa.Image = Global.Appsena.My.Resources.Resources.icons8_upload_32
        Me.btnSubirSa.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSubirSa.Location = New System.Drawing.Point(223, 182)
        Me.btnSubirSa.Name = "btnSubirSa"
        Me.btnSubirSa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSubirSa.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnSubirSa.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSubirSa.OnHoverImage = Nothing
        Me.btnSubirSa.OnPressedColor = System.Drawing.Color.Black
        Me.btnSubirSa.Radius = 10
        Me.btnSubirSa.Size = New System.Drawing.Size(160, 31)
        Me.btnSubirSa.TabIndex = 56
        Me.btnSubirSa.Text = "Subir formato"
        '
        'btnSubirSeg
        '
        Me.btnSubirSeg.AnimationHoverSpeed = 0.07!
        Me.btnSubirSeg.AnimationSpeed = 0.03!
        Me.btnSubirSeg.BackColor = System.Drawing.Color.Transparent
        Me.btnSubirSeg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnSubirSeg.BorderColor = System.Drawing.Color.Transparent
        Me.btnSubirSeg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubirSeg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSubirSeg.FocusedColor = System.Drawing.Color.Empty
        Me.btnSubirSeg.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirSeg.ForeColor = System.Drawing.Color.White
        Me.btnSubirSeg.Image = Global.Appsena.My.Resources.Resources.icons8_upload_32
        Me.btnSubirSeg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSubirSeg.Location = New System.Drawing.Point(222, 81)
        Me.btnSubirSeg.Name = "btnSubirSeg"
        Me.btnSubirSeg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSubirSeg.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnSubirSeg.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSubirSeg.OnHoverImage = Nothing
        Me.btnSubirSeg.OnPressedColor = System.Drawing.Color.Black
        Me.btnSubirSeg.Radius = 10
        Me.btnSubirSeg.Size = New System.Drawing.Size(160, 31)
        Me.btnSubirSeg.TabIndex = 57
        Me.btnSubirSeg.Text = "Subir formato"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Transparent
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(144, 243)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 10
        Me.btnGuardar.Size = New System.Drawing.Size(114, 31)
        Me.btnGuardar.TabIndex = 59
        Me.btnGuardar.Text = "Guardar"
        '
        'frmMovimientos_Seguro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 298)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSubirSeg)
        Me.Controls.Add(Me.btnSubirSa)
        Me.Controls.Add(Me.btnGenerarSeg)
        Me.Controls.Add(Me.dgvEConsumos)
        Me.Controls.Add(Me.dgvEDevolutivos)
        Me.Controls.Add(Me.lblFormato1)
        Me.Controls.Add(Me.btnGenerarSa)
        Me.Controls.Add(Me.lblFormato2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_Seguro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMovimientos_Seguro"
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvEDevolutivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEConsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblFormato2 As Label
    Friend WithEvents btnGenerarSa As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblFormato1 As Label
    Friend WithEvents dgvEDevolutivos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents dgvEConsumos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descrpción As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents btnGenerarSeg As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSubirSa As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSubirSeg As Guna.UI.WinForms.GunaButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
End Class
