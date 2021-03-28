<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_Historial_Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Historial_Detalle))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvHistorial = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNombresNom = New System.Windows.Forms.Label()
        Me.lblTipoPrestamo = New System.Windows.Forms.Label()
        Me.lblFechaPrestamo = New System.Windows.Forms.Label()
        Me.lblFechaDevolucion = New System.Windows.Forms.Label()
        Me.lblAdministrador = New System.Windows.Forms.Label()
        Me.lblEstadoPrestamo = New System.Windows.Forms.Label()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.clmCodPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clFechaPres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaDev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmObserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmestado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConsecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantiEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCadaUno = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmEntregarTodo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmCantidadPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblTraspaso1 = New System.Windows.Forms.LinkLabel()
        Me.lblSeguro = New System.Windows.Forms.LinkLabel()
        Me.lblFormatoSalida = New System.Windows.Forms.LinkLabel()
        Me.lblTraspaso2 = New System.Windows.Forms.LinkLabel()
        Me.pnlConsumo = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDeConsumo = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConsumo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 592)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 5)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(5, 587)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1204, 5)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1204, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 582)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCircleButton1)
        Me.Panel5.Controls.Add(Me.lblTitulo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1199, 33)
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(1166, 2)
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
        Me.lblTitulo.Size = New System.Drawing.Size(1199, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Detalle del prestamo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.Black
        Me.lblNombres.Location = New System.Drawing.Point(22, 59)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(178, 19)
        Me.lblNombres.TabIndex = 68
        Me.lblNombres.Text = "Nombre del cliente:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 19)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Tipo de prestamo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Fecha de prestamo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 19)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Fecha de devolución:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(798, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 19)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Estado del prestamo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(798, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 19)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Administrador:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.AllowUserToResizeColumns = False
        Me.dgvHistorial.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvHistorial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodPrestamo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.clFechaPres, Me.clmFechaDev, Me.clmObserva, Me.clmestado, Me.clmConsecutivo, Me.clmCantiEntrega, Me.clmCadaUno, Me.clmEntregarTodo, Me.clmCantidadPrestamo, Me.clmCheck})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvHistorial.EnableHeadersVisualStyles = False
        Me.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistorial.Location = New System.Drawing.Point(26, 257)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(1159, 277)
        Me.dgvHistorial.TabIndex = 74
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
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(522, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 19)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Elementos prestados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombresNom
        '
        Me.lblNombresNom.AutoSize = True
        Me.lblNombresNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresNom.ForeColor = System.Drawing.Color.Black
        Me.lblNombresNom.Location = New System.Drawing.Point(204, 59)
        Me.lblNombresNom.Name = "lblNombresNom"
        Me.lblNombresNom.Size = New System.Drawing.Size(76, 19)
        Me.lblNombresNom.TabIndex = 76
        Me.lblNombresNom.Text = "nombres"
        Me.lblNombresNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoPrestamo
        '
        Me.lblTipoPrestamo.AutoSize = True
        Me.lblTipoPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblTipoPrestamo.Location = New System.Drawing.Point(195, 98)
        Me.lblTipoPrestamo.Name = "lblTipoPrestamo"
        Me.lblTipoPrestamo.Size = New System.Drawing.Size(76, 19)
        Me.lblTipoPrestamo.TabIndex = 76
        Me.lblTipoPrestamo.Text = "nombres"
        Me.lblTipoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPrestamo
        '
        Me.lblFechaPrestamo.AutoSize = True
        Me.lblFechaPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblFechaPrestamo.Location = New System.Drawing.Point(204, 141)
        Me.lblFechaPrestamo.Name = "lblFechaPrestamo"
        Me.lblFechaPrestamo.Size = New System.Drawing.Size(76, 19)
        Me.lblFechaPrestamo.TabIndex = 77
        Me.lblFechaPrestamo.Text = "nombres"
        Me.lblFechaPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaDevolucion
        '
        Me.lblFechaDevolucion.AutoSize = True
        Me.lblFechaDevolucion.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDevolucion.ForeColor = System.Drawing.Color.Black
        Me.lblFechaDevolucion.Location = New System.Drawing.Point(215, 181)
        Me.lblFechaDevolucion.Name = "lblFechaDevolucion"
        Me.lblFechaDevolucion.Size = New System.Drawing.Size(76, 19)
        Me.lblFechaDevolucion.TabIndex = 78
        Me.lblFechaDevolucion.Text = "nombres"
        Me.lblFechaDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdministrador
        '
        Me.lblAdministrador.AutoSize = True
        Me.lblAdministrador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdministrador.ForeColor = System.Drawing.Color.Black
        Me.lblAdministrador.Location = New System.Drawing.Point(945, 59)
        Me.lblAdministrador.Name = "lblAdministrador"
        Me.lblAdministrador.Size = New System.Drawing.Size(76, 19)
        Me.lblAdministrador.TabIndex = 79
        Me.lblAdministrador.Text = "nombres"
        Me.lblAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstadoPrestamo
        '
        Me.lblEstadoPrestamo.AutoSize = True
        Me.lblEstadoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadoPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblEstadoPrestamo.Location = New System.Drawing.Point(992, 98)
        Me.lblEstadoPrestamo.Name = "lblEstadoPrestamo"
        Me.lblEstadoPrestamo.Size = New System.Drawing.Size(76, 19)
        Me.lblEstadoPrestamo.TabIndex = 80
        Me.lblEstadoPrestamo.Text = "nombres"
        Me.lblEstadoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnexportar.Location = New System.Drawing.Point(967, 208)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Radius = 10
        Me.btnexportar.Size = New System.Drawing.Size(218, 43)
        Me.btnexportar.TabIndex = 153
        Me.btnexportar.Text = "Descargar reporte"
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(471, 44)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(189, 35)
        Me.dgexportar.TabIndex = 154
        Me.dgexportar.Visible = False
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
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn3.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad prestada"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'clFechaPres
        '
        Me.clFechaPres.FillWeight = 90.0!
        Me.clFechaPres.HeaderText = "Fecha prestamo"
        Me.clFechaPres.Name = "clFechaPres"
        Me.clFechaPres.ReadOnly = True
        '
        'clmFechaDev
        '
        Me.clmFechaDev.FillWeight = 90.0!
        Me.clmFechaDev.HeaderText = "Fecha devolucion"
        Me.clmFechaDev.Name = "clmFechaDev"
        Me.clmFechaDev.ReadOnly = True
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
        'lblTraspaso1
        '
        Me.lblTraspaso1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblTraspaso1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTraspaso1.AutoSize = True
        Me.lblTraspaso1.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTraspaso1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTraspaso1.Location = New System.Drawing.Point(799, 136)
        Me.lblTraspaso1.Name = "lblTraspaso1"
        Me.lblTraspaso1.Size = New System.Drawing.Size(260, 18)
        Me.lblTraspaso1.TabIndex = 157
        Me.lblTraspaso1.TabStop = True
        Me.lblTraspaso1.Text = "Respaldo del retiro de los elementos"
        Me.lblTraspaso1.Visible = False
        Me.lblTraspaso1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'lblSeguro
        '
        Me.lblSeguro.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblSeguro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSeguro.AutoSize = True
        Me.lblSeguro.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguro.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSeguro.Location = New System.Drawing.Point(180, 217)
        Me.lblSeguro.Name = "lblSeguro"
        Me.lblSeguro.Size = New System.Drawing.Size(59, 18)
        Me.lblSeguro.TabIndex = 156
        Me.lblSeguro.TabStop = True
        Me.lblSeguro.Text = "Seguro"
        Me.lblSeguro.Visible = False
        Me.lblSeguro.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'lblFormatoSalida
        '
        Me.lblFormatoSalida.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblFormatoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFormatoSalida.AutoSize = True
        Me.lblFormatoSalida.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormatoSalida.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblFormatoSalida.Location = New System.Drawing.Point(23, 217)
        Me.lblFormatoSalida.Name = "lblFormatoSalida"
        Me.lblFormatoSalida.Size = New System.Drawing.Size(132, 18)
        Me.lblFormatoSalida.TabIndex = 155
        Me.lblFormatoSalida.TabStop = True
        Me.lblFormatoSalida.Text = "Formato de salida"
        Me.lblFormatoSalida.Visible = False
        Me.lblFormatoSalida.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'lblTraspaso2
        '
        Me.lblTraspaso2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblTraspaso2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTraspaso2.AutoSize = True
        Me.lblTraspaso2.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTraspaso2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTraspaso2.Location = New System.Drawing.Point(799, 166)
        Me.lblTraspaso2.Name = "lblTraspaso2"
        Me.lblTraspaso2.Size = New System.Drawing.Size(274, 18)
        Me.lblTraspaso2.TabIndex = 158
        Me.lblTraspaso2.TabStop = True
        Me.lblTraspaso2.Text = "Respaldo del ingreso de los elementos"
        Me.lblTraspaso2.Visible = False
        Me.lblTraspaso2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        '
        'pnlConsumo
        '
        Me.pnlConsumo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConsumo.Controls.Add(Me.Label7)
        Me.pnlConsumo.Controls.Add(Me.Label8)
        Me.pnlConsumo.Controls.Add(Me.lblDeConsumo)
        Me.pnlConsumo.Location = New System.Drawing.Point(26, 540)
        Me.pnlConsumo.Name = "pnlConsumo"
        Me.pnlConsumo.Size = New System.Drawing.Size(1159, 40)
        Me.pnlConsumo.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(329, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 31)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "fueron consumidos en su totalidad."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(308, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeConsumo
        '
        Me.lblDeConsumo.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeConsumo.ForeColor = System.Drawing.Color.Black
        Me.lblDeConsumo.Location = New System.Drawing.Point(5, 5)
        Me.lblDeConsumo.Name = "lblDeConsumo"
        Me.lblDeConsumo.Size = New System.Drawing.Size(308, 31)
        Me.lblDeConsumo.TabIndex = 48
        Me.lblDeConsumo.Text = "*Los elementos subrayados con el color"
        Me.lblDeConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMovimientos_Historial_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 592)
        Me.Controls.Add(Me.pnlConsumo)
        Me.Controls.Add(Me.lblTraspaso2)
        Me.Controls.Add(Me.lblTraspaso1)
        Me.Controls.Add(Me.lblSeguro)
        Me.Controls.Add(Me.lblFormatoSalida)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.lblEstadoPrestamo)
        Me.Controls.Add(Me.lblAdministrador)
        Me.Controls.Add(Me.lblFechaDevolucion)
        Me.Controls.Add(Me.lblFechaPrestamo)
        Me.Controls.Add(Me.lblTipoPrestamo)
        Me.Controls.Add(Me.lblNombresNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_Historial_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_Historial_Detalle"
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConsumo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvHistorial As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNombresNom As Label
    Friend WithEvents lblTipoPrestamo As Label
    Friend WithEvents lblFechaPrestamo As Label
    Friend WithEvents lblFechaDevolucion As Label
    Friend WithEvents lblAdministrador As Label
    Friend WithEvents lblEstadoPrestamo As Label
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents clmCodPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents clFechaPres As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaDev As DataGridViewTextBoxColumn
    Friend WithEvents clmObserva As DataGridViewTextBoxColumn
    Friend WithEvents clmestado As DataGridViewTextBoxColumn
    Friend WithEvents clmConsecutivo As DataGridViewTextBoxColumn
    Friend WithEvents clmCantiEntrega As DataGridViewTextBoxColumn
    Friend WithEvents clmCadaUno As DataGridViewImageColumn
    Friend WithEvents clmEntregarTodo As DataGridViewImageColumn
    Friend WithEvents clmCantidadPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmCheck As DataGridViewCheckBoxColumn
    Friend WithEvents lblTraspaso1 As LinkLabel
    Friend WithEvents lblSeguro As LinkLabel
    Friend WithEvents lblFormatoSalida As LinkLabel
    Friend WithEvents lblTraspaso2 As LinkLabel
    Friend WithEvents pnlConsumo As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDeConsumo As Label
End Class
