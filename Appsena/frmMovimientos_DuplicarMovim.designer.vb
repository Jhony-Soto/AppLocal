<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientos_DuplicarMovim
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvUsuarios = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmCodPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDocid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodFicha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDuplicarPrestamo = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvDuplicar = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New Guna.UI.WinForms.GunaButton()
        Me.btnDuplicarPrestamo = New Guna.UI.WinForms.GunaButton()
        Me.dgvElementoUsuario = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtBuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnBorrarTodo = New System.Windows.Forms.LinkLabel()
        Me.clmCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmElemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmcanti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmobser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmfechapres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmfechadevo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmtipoelem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDuplicar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvElementoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 5)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 607)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1198, 5)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 602)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1193, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 602)
        Me.Panel3.TabIndex = 3
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToResizeColumns = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodPrestamo, Me.clmDocid, Me.clmUsuario, Me.clmCodFicha, Me.clmSeleccionar})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsuarios.Location = New System.Drawing.Point(12, 119)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(554, 441)
        Me.dgvUsuarios.TabIndex = 73
        Me.dgvUsuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUsuarios.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsuarios.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUsuarios.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvUsuarios.ThemeStyle.ReadOnly = True
        Me.dgvUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsuarios.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvUsuarios.ThemeStyle.RowsStyle.Height = 22
        Me.dgvUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clmCodPrestamo
        '
        Me.clmCodPrestamo.FillWeight = 40.0!
        Me.clmCodPrestamo.HeaderText = "Prestamo"
        Me.clmCodPrestamo.Name = "clmCodPrestamo"
        Me.clmCodPrestamo.ReadOnly = True
        '
        'clmDocid
        '
        Me.clmDocid.HeaderText = "Docid"
        Me.clmDocid.Name = "clmDocid"
        Me.clmDocid.ReadOnly = True
        Me.clmDocid.Visible = False
        '
        'clmUsuario
        '
        Me.clmUsuario.FillWeight = 150.0!
        Me.clmUsuario.HeaderText = "Cliente"
        Me.clmUsuario.Name = "clmUsuario"
        Me.clmUsuario.ReadOnly = True
        '
        'clmCodFicha
        '
        Me.clmCodFicha.FillWeight = 65.0!
        Me.clmCodFicha.HeaderText = "Ficha"
        Me.clmCodFicha.Name = "clmCodFicha"
        Me.clmCodFicha.ReadOnly = True
        '
        'clmSeleccionar
        '
        Me.clmSeleccionar.FillWeight = 20.0!
        Me.clmSeleccionar.HeaderText = ""
        Me.clmSeleccionar.Name = "clmSeleccionar"
        Me.clmSeleccionar.ReadOnly = True
        Me.clmSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(327, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 20)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Fecha de prestamo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDuplicarPrestamo
        '
        Me.dtpDuplicarPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.dtpDuplicarPrestamo.BaseColor = System.Drawing.Color.White
        Me.dtpDuplicarPrestamo.BorderColor = System.Drawing.Color.Silver
        Me.dtpDuplicarPrestamo.Checked = False
        Me.dtpDuplicarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDuplicarPrestamo.CustomFormat = "d 'de' MMMM yyyy"
        Me.dtpDuplicarPrestamo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDuplicarPrestamo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpDuplicarPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDuplicarPrestamo.ForeColor = System.Drawing.Color.Black
        Me.dtpDuplicarPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDuplicarPrestamo.Location = New System.Drawing.Point(327, 83)
        Me.dtpDuplicarPrestamo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDuplicarPrestamo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDuplicarPrestamo.Name = "dtpDuplicarPrestamo"
        Me.dtpDuplicarPrestamo.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpDuplicarPrestamo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpDuplicarPrestamo.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpDuplicarPrestamo.OnPressedColor = System.Drawing.Color.Black
        Me.dtpDuplicarPrestamo.Radius = 10
        Me.dtpDuplicarPrestamo.Size = New System.Drawing.Size(223, 30)
        Me.dtpDuplicarPrestamo.TabIndex = 71
        Me.dtpDuplicarPrestamo.Text = "18 de marzo 2020"
        Me.dtpDuplicarPrestamo.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(572, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(612, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Elementos prestados por el cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Buscar cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDuplicar
        '
        Me.dgvDuplicar.AllowUserToAddRows = False
        Me.dgvDuplicar.AllowUserToDeleteRows = False
        Me.dgvDuplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDuplicar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDuplicar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.clmnombre, Me.clmcanti, Me.clmobser, Me.clmfechapres, Me.clmfechadevo, Me.clmtipoelem})
        Me.dgvDuplicar.Location = New System.Drawing.Point(811, 44)
        Me.dgvDuplicar.Name = "dgvDuplicar"
        Me.dgvDuplicar.ReadOnly = True
        Me.dgvDuplicar.Size = New System.Drawing.Size(358, 40)
        Me.dgvDuplicar.TabIndex = 68
        Me.dgvDuplicar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AnimationHoverSpeed = 0.07!
        Me.btnCancelar.AnimationSpeed = 0.03!
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCancelar.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelar.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.btnCancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancelar.Location = New System.Drawing.Point(449, 569)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancelar.OnHoverImage = Nothing
        Me.btnCancelar.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancelar.Radius = 10
        Me.btnCancelar.Size = New System.Drawing.Size(117, 31)
        Me.btnCancelar.TabIndex = 67
        Me.btnCancelar.Text = "Cancelar"
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
        Me.btnDuplicarPrestamo.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicarPrestamo.ForeColor = System.Drawing.Color.White
        Me.btnDuplicarPrestamo.Image = Global.Appsena.My.Resources.Resources.icons8_duplicate_64
        Me.btnDuplicarPrestamo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDuplicarPrestamo.Location = New System.Drawing.Point(592, 569)
        Me.btnDuplicarPrestamo.Name = "btnDuplicarPrestamo"
        Me.btnDuplicarPrestamo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnDuplicarPrestamo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnDuplicarPrestamo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDuplicarPrestamo.OnHoverImage = Nothing
        Me.btnDuplicarPrestamo.OnPressedColor = System.Drawing.Color.Black
        Me.btnDuplicarPrestamo.Radius = 10
        Me.btnDuplicarPrestamo.Size = New System.Drawing.Size(197, 31)
        Me.btnDuplicarPrestamo.TabIndex = 66
        Me.btnDuplicarPrestamo.Text = "Duplicar movimiento"
        '
        'dgvElementoUsuario
        '
        Me.dgvElementoUsuario.AllowUserToAddRows = False
        Me.dgvElementoUsuario.AllowUserToDeleteRows = False
        Me.dgvElementoUsuario.AllowUserToResizeColumns = False
        Me.dgvElementoUsuario.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvElementoUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvElementoUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvElementoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElementoUsuario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvElementoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvElementoUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementoUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvElementoUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvElementoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementoUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCod, Me.clmElemento, Me.clmCantidad, Me.clmEliminar})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElementoUsuario.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvElementoUsuario.EnableHeadersVisualStyles = False
        Me.dgvElementoUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementoUsuario.Location = New System.Drawing.Point(572, 119)
        Me.dgvElementoUsuario.Name = "dgvElementoUsuario"
        Me.dgvElementoUsuario.RowHeadersVisible = False
        Me.dgvElementoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElementoUsuario.Size = New System.Drawing.Size(612, 441)
        Me.dgvElementoUsuario.TabIndex = 65
        Me.dgvElementoUsuario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvElementoUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementoUsuario.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvElementoUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementoUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementoUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvElementoUsuario.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvElementoUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementoUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvElementoUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvElementoUsuario.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementoUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvElementoUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementoUsuario.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvElementoUsuario.ThemeStyle.ReadOnly = False
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.Height = 22
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementoUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtBuscador.BaseColor = System.Drawing.Color.White
        Me.txtBuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBuscador.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtBuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.ForeColor = System.Drawing.Color.Black
        Me.txtBuscador.Location = New System.Drawing.Point(12, 83)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscador.Radius = 10
        Me.txtBuscador.Size = New System.Drawing.Size(296, 30)
        Me.txtBuscador.TabIndex = 64
        Me.txtBuscador.Tag = "1"
        Me.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnCerrar)
        Me.Panel4.Controls.Add(Me.lblTitulo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1188, 33)
        Me.Panel4.TabIndex = 63
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.AnimationHoverSpeed = 0.07!
        Me.btnCerrar.AnimationSpeed = 0.03!
        Me.btnCerrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCerrar.BorderColor = System.Drawing.Color.Black
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.btnCerrar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnCerrar.Location = New System.Drawing.Point(1157, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCerrar.OnHoverImage = Nothing
        Me.btnCerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btnCerrar.Size = New System.Drawing.Size(28, 28)
        Me.btnCerrar.TabIndex = 47
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1188, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Duplicar prestamo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBorrarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarTodo.AutoSize = True
        Me.btnBorrarTodo.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTodo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBorrarTodo.Location = New System.Drawing.Point(1020, 98)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(61, 18)
        Me.btnBorrarTodo.TabIndex = 74
        Me.btnBorrarTodo.TabStop = True
        Me.btnBorrarTodo.Text = "Limpiar"
        Me.btnBorrarTodo.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        '
        'clmCod
        '
        Me.clmCod.FillWeight = 60.0!
        Me.clmCod.HeaderText = "Codigo"
        Me.clmCod.Name = "clmCod"
        Me.clmCod.ReadOnly = True
        '
        'clmElemento
        '
        Me.clmElemento.FillWeight = 150.0!
        Me.clmElemento.HeaderText = "Elemento"
        Me.clmElemento.Name = "clmElemento"
        Me.clmElemento.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.FillWeight = 120.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmEliminar
        '
        Me.clmEliminar.FillWeight = 50.0!
        Me.clmEliminar.HeaderText = "Eliminar"
        Me.clmEliminar.Image = Global.Appsena.My.Resources.Resources.icons8_trash_can_64
        Me.clmEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmEliminar.Name = "clmEliminar"
        Me.clmEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        'clmtipoelem
        '
        Me.clmtipoelem.HeaderText = "tipoele"
        Me.clmtipoelem.Name = "clmtipoelem"
        Me.clmtipoelem.ReadOnly = True
        '
        'frmMovimientos_DuplicarMovim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 612)
        Me.Controls.Add(Me.dgvDuplicar)
        Me.Controls.Add(Me.btnBorrarTodo)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDuplicarPrestamo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnDuplicarPrestamo)
        Me.Controls.Add(Me.dgvElementoUsuario)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMovimientos_DuplicarMovim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMovimientos_DuplicarMovim"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDuplicar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvElementoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvUsuarios As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDuplicarPrestamo As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvDuplicar As DataGridView
    Friend WithEvents btnCancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDuplicarPrestamo As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvElementoUsuario As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtBuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents clmCodPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmDocid As DataGridViewTextBoxColumn
    Friend WithEvents clmUsuario As DataGridViewTextBoxColumn
    Friend WithEvents clmCodFicha As DataGridViewTextBoxColumn
    Friend WithEvents clmSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents btnBorrarTodo As LinkLabel
    Friend WithEvents clmCod As DataGridViewTextBoxColumn
    Friend WithEvents clmElemento As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmEliminar As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents clmnombre As DataGridViewTextBoxColumn
    Friend WithEvents clmcanti As DataGridViewTextBoxColumn
    Friend WithEvents clmobser As DataGridViewTextBoxColumn
    Friend WithEvents clmfechapres As DataGridViewTextBoxColumn
    Friend WithEvents clmfechadevo As DataGridViewTextBoxColumn
    Friend WithEvents clmtipoelem As DataGridViewTextBoxColumn
End Class
