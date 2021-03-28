<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientos_Detalle_EntregarUno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Detalle_EntregarUno))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvHistorial = New Guna.UI.WinForms.GunaDataGridView()
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
        Me.clmCodTipoEle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCadaUno = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmEntregarTodo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmCantidadPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.lblDeConsumo = New System.Windows.Forms.Label()
        Me.pnlConsumo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConsumo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1176, 5)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 589)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1176, 5)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 584)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1171, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 584)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCircleButton1)
        Me.Panel5.Controls.Add(Me.lblTitulo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1166, 33)
        Me.Panel5.TabIndex = 5
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(1133, 2)
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
        Me.lblTitulo.Size = New System.Drawing.Size(1166, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Recibir elementos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodPrestamo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.clFechaPres, Me.clmFechaDev, Me.clmObserva, Me.clmestado, Me.clmConsecutivo, Me.clmCantiEntrega, Me.clmCodTipoEle, Me.clmCadaUno, Me.clmEntregarTodo, Me.clmCantidadPrestamo, Me.clmCheck})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHistorial.EnableHeadersVisualStyles = False
        Me.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistorial.Location = New System.Drawing.Point(11, 89)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(1153, 438)
        Me.dgvHistorial.TabIndex = 6
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
        Me.clmFechaDev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'clmCodTipoEle
        '
        Me.clmCodTipoEle.HeaderText = "TipoElemnto"
        Me.clmCodTipoEle.Name = "clmCodTipoEle"
        Me.clmCodTipoEle.ReadOnly = True
        Me.clmCodTipoEle.Visible = False
        '
        'clmCadaUno
        '
        Me.clmCadaUno.FillWeight = 50.0!
        Me.clmCadaUno.HeaderText = "Entregar"
        Me.clmCadaUno.Image = Global.Appsena.My.Resources.Resources.icons8_handcart_64
        Me.clmCadaUno.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmCadaUno.Name = "clmCadaUno"
        Me.clmCadaUno.ReadOnly = True
        Me.clmCadaUno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmCadaUno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAceptar.BorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Global.Appsena.My.Resources.Resources.icons8_ok_64
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(528, 551)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(106, 31)
        Me.btnAceptar.TabIndex = 28
        Me.btnAceptar.Text = "Aceptar"
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
        'pnlConsumo
        '
        Me.pnlConsumo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConsumo.Controls.Add(Me.Label2)
        Me.pnlConsumo.Controls.Add(Me.Label1)
        Me.pnlConsumo.Controls.Add(Me.lblDeConsumo)
        Me.pnlConsumo.Location = New System.Drawing.Point(11, 41)
        Me.pnlConsumo.Name = "pnlConsumo"
        Me.pnlConsumo.Size = New System.Drawing.Size(1153, 42)
        Me.pnlConsumo.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(331, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 31)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "fueron consumidos en su totalidad."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(308, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 49
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMovimientos_Detalle_EntregarUno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 594)
        Me.Controls.Add(Me.pnlConsumo)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_Detalle_EntregarUno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_Detalle_EntregarUno"
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConsumo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvHistorial As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblDeConsumo As Label
    Friend WithEvents pnlConsumo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents clmCodTipoEle As DataGridViewTextBoxColumn
    Friend WithEvents clmCadaUno As DataGridViewImageColumn
    Friend WithEvents clmEntregarTodo As DataGridViewImageColumn
    Friend WithEvents clmCantidadPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmCheck As DataGridViewCheckBoxColumn
End Class
