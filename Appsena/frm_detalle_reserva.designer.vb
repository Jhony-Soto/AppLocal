<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detalle_reserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_detalle_reserva))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnagregar = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.nmCantidad = New Guna.UI.WinForms.GunaNumeric()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picker_hora = New System.Windows.Forms.DateTimePicker()
        Me.cmbtipoPrestamo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.btnregrsar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fecha_reserva = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.pickerfecha_prestamo = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmobservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bntcancelar = New Guna.UI.WinForms.GunaButton()
        Me.btnactualizar = New Guna.UI.WinForms.GunaButton()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.txtcategoria_reserva = New Guna.UI.WinForms.GunaTextBox()
        Me.txttipo_prestamo = New Guna.UI.WinForms.GunaTextBox()
        Me.picker_hora_devolucion = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmbficha = New Guna.UI.WinForms.GunaComboBox()
        Me.txtbuscadorficha = New Guna.UI.WinForms.GunaTextBox()
        Me.lblrequire = New System.Windows.Forms.Label()
        Me.lblficha = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncolor = New Guna.UI.WinForms.GunaCircleButton()
        Me.cmbcategoria = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.linkcategoria_reserva = New Guna.UI.WinForms.GunaLinkLabel()
        Me.linktio_prestamo = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'btnagregar
        '
        Me.btnagregar.AnimationHoverSpeed = 0.07!
        Me.btnagregar.AnimationSpeed = 0.03!
        Me.btnagregar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnagregar.BorderColor = System.Drawing.Color.Black
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnagregar.FocusedColor = System.Drawing.Color.Empty
        Me.btnagregar.Font = New System.Drawing.Font("Zurich BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.Image = Nothing
        Me.btnagregar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnagregar.Location = New System.Drawing.Point(977, 238)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregar.OnHoverImage = Nothing
        Me.btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregar.Size = New System.Drawing.Size(40, 40)
        Me.btnagregar.TabIndex = 49
        Me.btnagregar.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnagregar, "Agregar elemento")
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(42, 199)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1220, 5)
        Me.GunaLinePanel1.TabIndex = 48
        '
        'nmCantidad
        '
        Me.nmCantidad.BackColor = System.Drawing.Color.Transparent
        Me.nmCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.nmCantidad.BaseColor = System.Drawing.Color.White
        Me.nmCantidad.BorderColor = System.Drawing.Color.Silver
        Me.nmCantidad.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.nmCantidad.ButtonForeColor = System.Drawing.Color.White
        Me.nmCantidad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmCantidad.ForeColor = System.Drawing.Color.Black
        Me.nmCantidad.Location = New System.Drawing.Point(826, 243)
        Me.nmCantidad.Maximum = CType(9999999, Long)
        Me.nmCantidad.Minimum = CType(0, Long)
        Me.nmCantidad.Name = "nmCantidad"
        Me.nmCantidad.Radius = 10
        Me.nmCantidad.Size = New System.Drawing.Size(134, 30)
        Me.nmCantidad.TabIndex = 46
        Me.nmCantidad.Text = "GunaNumeric1"
        Me.nmCantidad.Value = CType(1, Long)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Hora del Prestamo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(747, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Cantidad"
        '
        'picker_hora
        '
        Me.picker_hora.CustomFormat = "H:mm"
        Me.picker_hora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.picker_hora.Location = New System.Drawing.Point(271, 166)
        Me.picker_hora.Name = "picker_hora"
        Me.picker_hora.ShowUpDown = True
        Me.picker_hora.Size = New System.Drawing.Size(141, 27)
        Me.picker_hora.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.picker_hora, "Hora en la que se hara el prestamo")
        '
        'cmbtipoPrestamo
        '
        Me.cmbtipoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.cmbtipoPrestamo.BaseColor = System.Drawing.Color.White
        Me.cmbtipoPrestamo.BorderColor = System.Drawing.Color.Silver
        Me.cmbtipoPrestamo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipoPrestamo.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtipoPrestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.cmbtipoPrestamo.FormattingEnabled = True
        Me.cmbtipoPrestamo.Location = New System.Drawing.Point(393, 95)
        Me.cmbtipoPrestamo.Name = "cmbtipoPrestamo"
        Me.cmbtipoPrestamo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbtipoPrestamo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtipoPrestamo.Radius = 10
        Me.cmbtipoPrestamo.Size = New System.Drawing.Size(230, 28)
        Me.cmbtipoPrestamo.TabIndex = 37
        Me.cmbtipoPrestamo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(414, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tipo de Prestamo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblcliente)
        Me.Panel1.Controls.Add(Me.btnregrsar)
        Me.Panel1.Controls.Add(Me.lblheader)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.fecha_reserva)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1314, 55)
        Me.Panel1.TabIndex = 32
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblcliente.Location = New System.Drawing.Point(494, 17)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(244, 25)
        Me.lblcliente.TabIndex = 20
        Me.lblcliente.Text = "Jose daniel gutierrez"
        '
        'btnregrsar
        '
        Me.btnregrsar.AnimationHoverSpeed = 0.07!
        Me.btnregrsar.AnimationSpeed = 0.03!
        Me.btnregrsar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnregrsar.BorderColor = System.Drawing.Color.Black
        Me.btnregrsar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregrsar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregrsar.FocusedColor = System.Drawing.Color.Empty
        Me.btnregrsar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnregrsar.ForeColor = System.Drawing.Color.White
        Me.btnregrsar.Image = CType(resources.GetObject("btnregrsar.Image"), System.Drawing.Image)
        Me.btnregrsar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnregrsar.Location = New System.Drawing.Point(18, 8)
        Me.btnregrsar.Name = "btnregrsar"
        Me.btnregrsar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregrsar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregrsar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregrsar.OnHoverImage = Nothing
        Me.btnregrsar.OnPressedColor = System.Drawing.Color.Black
        Me.btnregrsar.Size = New System.Drawing.Size(40, 40)
        Me.btnregrsar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnregrsar, "Volver")
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.White
        Me.lblheader.Location = New System.Drawing.Point(199, 17)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(303, 25)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Detalle de la reserva para "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(999, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 19)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "fecha en la que se hizo la reserva"
        Me.Label3.Visible = False
        '
        'fecha_reserva
        '
        Me.fecha_reserva.BackColor = System.Drawing.Color.Transparent
        Me.fecha_reserva.BaseColor = System.Drawing.Color.White
        Me.fecha_reserva.BorderColor = System.Drawing.Color.Silver
        Me.fecha_reserva.CustomFormat = "dd-MM-yyyy"
        Me.fecha_reserva.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fecha_reserva.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fecha_reserva.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_reserva.ForeColor = System.Drawing.Color.Black
        Me.fecha_reserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_reserva.Location = New System.Drawing.Point(987, 31)
        Me.fecha_reserva.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fecha_reserva.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fecha_reserva.Name = "fecha_reserva"
        Me.fecha_reserva.OnHoverBaseColor = System.Drawing.Color.White
        Me.fecha_reserva.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fecha_reserva.OnHoverForeColor = System.Drawing.Color.Black
        Me.fecha_reserva.OnPressedColor = System.Drawing.Color.Black
        Me.fecha_reserva.Radius = 10
        Me.fecha_reserva.Size = New System.Drawing.Size(211, 28)
        Me.fecha_reserva.TabIndex = 53
        Me.fecha_reserva.Text = "3/12/2019"
        Me.fecha_reserva.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        Me.fecha_reserva.Visible = False
        '
        'pickerfecha_prestamo
        '
        Me.pickerfecha_prestamo.BackColor = System.Drawing.Color.Transparent
        Me.pickerfecha_prestamo.BaseColor = System.Drawing.Color.White
        Me.pickerfecha_prestamo.BorderColor = System.Drawing.Color.Silver
        Me.pickerfecha_prestamo.CustomFormat = "d,MMMM,yyyy"
        Me.pickerfecha_prestamo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.pickerfecha_prestamo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.pickerfecha_prestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickerfecha_prestamo.ForeColor = System.Drawing.Color.Black
        Me.pickerfecha_prestamo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pickerfecha_prestamo.Location = New System.Drawing.Point(99, 97)
        Me.pickerfecha_prestamo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.pickerfecha_prestamo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.pickerfecha_prestamo.Name = "pickerfecha_prestamo"
        Me.pickerfecha_prestamo.OnHoverBaseColor = System.Drawing.Color.White
        Me.pickerfecha_prestamo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.pickerfecha_prestamo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pickerfecha_prestamo.OnPressedColor = System.Drawing.Color.Black
        Me.pickerfecha_prestamo.Radius = 10
        Me.pickerfecha_prestamo.Size = New System.Drawing.Size(182, 28)
        Me.pickerfecha_prestamo.TabIndex = 18
        Me.pickerfecha_prestamo.Text = "3/12/2019"
        Me.ToolTip1.SetToolTip(Me.pickerfecha_prestamo, "Fecha en la que se hara el prestamo")
        Me.pickerfecha_prestamo.Value = New Date(2019, 12, 3, 0, 0, 0, 0)
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.HeaderText = "Editar"
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Fecha del Prestamo"
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
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn4, Me.DataGridViewImageColumn5, Me.clm, Me.clmcantidad, Me.clmobservaciones})
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
        Me.dgdatos.Location = New System.Drawing.Point(46, 304)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(1184, 210)
        Me.dgdatos.TabIndex = 55
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
        Me.dgdatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgdatos.ThemeStyle.HeaderStyle.Height = 40
        Me.dgdatos.ThemeStyle.ReadOnly = False
        Me.dgdatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgdatos.ThemeStyle.RowsStyle.Height = 22
        Me.dgdatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgdatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn4.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn4.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Width = 70
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn5.HeaderText = "Editar"
        Me.DataGridViewImageColumn5.Image = Global.Appsena.My.Resources.Resources.icons8_update_16
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Width = 70
        '
        'clm
        '
        Me.clm.HeaderText = "Descripción"
        Me.clm.Name = "clm"
        Me.clm.ReadOnly = True
        '
        'clmcantidad
        '
        Me.clmcantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmcantidad.HeaderText = "Cantidad"
        Me.clmcantidad.Name = "clmcantidad"
        Me.clmcantidad.ReadOnly = True
        Me.clmcantidad.Width = 70
        '
        'clmobservaciones
        '
        Me.clmobservaciones.HeaderText = "Observaciones"
        Me.clmobservaciones.Name = "clmobservaciones"
        Me.clmobservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'bntcancelar
        '
        Me.bntcancelar.AnimationHoverSpeed = 0.07!
        Me.bntcancelar.AnimationSpeed = 0.03!
        Me.bntcancelar.BackColor = System.Drawing.Color.Transparent
        Me.bntcancelar.BaseColor = System.Drawing.Color.Red
        Me.bntcancelar.BorderColor = System.Drawing.Color.Black
        Me.bntcancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntcancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bntcancelar.FocusedColor = System.Drawing.Color.Empty
        Me.bntcancelar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntcancelar.ForeColor = System.Drawing.Color.White
        Me.bntcancelar.Image = Global.Appsena.My.Resources.Resources.icons8_error_64
        Me.bntcancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.bntcancelar.Location = New System.Drawing.Point(657, 546)
        Me.bntcancelar.Name = "bntcancelar"
        Me.bntcancelar.OnHoverBaseColor = System.Drawing.Color.IndianRed
        Me.bntcancelar.OnHoverBorderColor = System.Drawing.Color.White
        Me.bntcancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.bntcancelar.OnHoverImage = Nothing
        Me.bntcancelar.OnPressedColor = System.Drawing.Color.Black
        Me.bntcancelar.Radius = 10
        Me.bntcancelar.Size = New System.Drawing.Size(230, 34)
        Me.bntcancelar.TabIndex = 40
        Me.bntcancelar.Text = "Cancelar la reserva"
        Me.bntcancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.bntcancelar, "Cancelar la reserva")
        '
        'btnactualizar
        '
        Me.btnactualizar.AnimationHoverSpeed = 0.07!
        Me.btnactualizar.AnimationSpeed = 0.03!
        Me.btnactualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnactualizar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnactualizar.BorderColor = System.Drawing.Color.Black
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnactualizar.FocusedColor = System.Drawing.Color.Empty
        Me.btnactualizar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnactualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnactualizar.Location = New System.Drawing.Point(430, 546)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnactualizar.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnactualizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnactualizar.OnHoverImage = Nothing
        Me.btnactualizar.OnPressedColor = System.Drawing.Color.Black
        Me.btnactualizar.Radius = 10
        Me.btnactualizar.Size = New System.Drawing.Size(166, 34)
        Me.btnactualizar.TabIndex = 39
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Guardar datos")
        '
        'txtbuscador
        '
        Me.txtbuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtbuscador.BaseColor = System.Drawing.Color.White
        Me.txtbuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbuscador.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbuscador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscador.ForeColor = System.Drawing.Color.Black
        Me.txtbuscador.Location = New System.Drawing.Point(238, 248)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(425, 30)
        Me.txtbuscador.TabIndex = 124
        Me.ToolTip1.SetToolTip(Me.txtbuscador, "Busca por codigo o nombre del elemento")
        '
        'txtcategoria_reserva
        '
        Me.txtcategoria_reserva.BackColor = System.Drawing.Color.Transparent
        Me.txtcategoria_reserva.BaseColor = System.Drawing.Color.White
        Me.txtcategoria_reserva.BorderColor = System.Drawing.Color.Silver
        Me.txtcategoria_reserva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcategoria_reserva.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcategoria_reserva.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtcategoria_reserva.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcategoria_reserva.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategoria_reserva.ForeColor = System.Drawing.Color.Black
        Me.txtcategoria_reserva.Location = New System.Drawing.Point(995, 114)
        Me.txtcategoria_reserva.Name = "txtcategoria_reserva"
        Me.txtcategoria_reserva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcategoria_reserva.Radius = 10
        Me.txtcategoria_reserva.Size = New System.Drawing.Size(254, 30)
        Me.txtcategoria_reserva.TabIndex = 130
        Me.ToolTip1.SetToolTip(Me.txtcategoria_reserva, "Busca por codigo o nombre del elemento")
        '
        'txttipo_prestamo
        '
        Me.txttipo_prestamo.BackColor = System.Drawing.Color.Transparent
        Me.txttipo_prestamo.BaseColor = System.Drawing.Color.White
        Me.txttipo_prestamo.BorderColor = System.Drawing.Color.Silver
        Me.txttipo_prestamo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttipo_prestamo.FocusedBaseColor = System.Drawing.Color.White
        Me.txttipo_prestamo.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txttipo_prestamo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttipo_prestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo_prestamo.ForeColor = System.Drawing.Color.Black
        Me.txttipo_prestamo.Location = New System.Drawing.Point(393, 97)
        Me.txttipo_prestamo.Name = "txttipo_prestamo"
        Me.txttipo_prestamo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttipo_prestamo.Radius = 10
        Me.txttipo_prestamo.Size = New System.Drawing.Size(230, 30)
        Me.txttipo_prestamo.TabIndex = 132
        Me.ToolTip1.SetToolTip(Me.txttipo_prestamo, "Busca por codigo o nombre del elemento")
        '
        'picker_hora_devolucion
        '
        Me.picker_hora_devolucion.CustomFormat = "H:mm"
        Me.picker_hora_devolucion.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_hora_devolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.picker_hora_devolucion.Location = New System.Drawing.Point(478, 164)
        Me.picker_hora_devolucion.Name = "picker_hora_devolucion"
        Me.picker_hora_devolucion.ShowUpDown = True
        Me.picker_hora_devolucion.Size = New System.Drawing.Size(141, 27)
        Me.picker_hora_devolucion.TabIndex = 134
        Me.ToolTip1.SetToolTip(Me.picker_hora_devolucion, "Hora en la que se hara el prestamo")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 603)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 5)
        Me.Panel2.TabIndex = 56
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 603)
        Me.Panel3.TabIndex = 57
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(1308, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 603)
        Me.Panel4.TabIndex = 58
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1313, 5)
        Me.Panel5.TabIndex = 59
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
        Me.cmbficha.Location = New System.Drawing.Point(702, 140)
        Me.cmbficha.Name = "cmbficha"
        Me.cmbficha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbficha.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbficha.Radius = 10
        Me.cmbficha.Size = New System.Drawing.Size(221, 28)
        Me.cmbficha.TabIndex = 123
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
        Me.txtbuscadorficha.Location = New System.Drawing.Point(702, 107)
        Me.txtbuscadorficha.Name = "txtbuscadorficha"
        Me.txtbuscadorficha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscadorficha.Radius = 10
        Me.txtbuscadorficha.Size = New System.Drawing.Size(221, 30)
        Me.txtbuscadorficha.TabIndex = 122
        '
        'lblrequire
        '
        Me.lblrequire.AutoSize = True
        Me.lblrequire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrequire.ForeColor = System.Drawing.Color.Red
        Me.lblrequire.Location = New System.Drawing.Point(831, 85)
        Me.lblrequire.Name = "lblrequire"
        Me.lblrequire.Size = New System.Drawing.Size(18, 24)
        Me.lblrequire.TabIndex = 121
        Me.lblrequire.Text = "*"
        '
        'lblficha
        '
        Me.lblficha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblficha.AutoSize = True
        Me.lblficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblficha.Location = New System.Drawing.Point(778, 89)
        Me.lblficha.Name = "lblficha"
        Me.lblficha.Size = New System.Drawing.Size(47, 19)
        Me.lblficha.TabIndex = 120
        Me.lblficha.Text = "Ficha"
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
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn3.HeaderText = "Editar"
        Me.DataGridViewImageColumn3.Image = Global.Appsena.My.Resources.Resources.icons8_update_16
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Width = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1004, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 19)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Categoria de reserva"
        '
        'btncolor
        '
        Me.btncolor.AnimationHoverSpeed = 0.07!
        Me.btncolor.AnimationSpeed = 0.03!
        Me.btncolor.BaseColor = System.Drawing.Color.Transparent
        Me.btncolor.BorderColor = System.Drawing.Color.Black
        Me.btncolor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncolor.FocusedColor = System.Drawing.Color.Empty
        Me.btncolor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btncolor.ForeColor = System.Drawing.Color.White
        Me.btncolor.Image = Nothing
        Me.btncolor.ImageSize = New System.Drawing.Size(52, 52)
        Me.btncolor.Location = New System.Drawing.Point(1260, 117)
        Me.btncolor.Name = "btncolor"
        Me.btncolor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncolor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncolor.OnHoverForeColor = System.Drawing.Color.White
        Me.btncolor.OnHoverImage = Nothing
        Me.btncolor.OnPressedColor = System.Drawing.Color.Black
        Me.btncolor.Size = New System.Drawing.Size(20, 20)
        Me.btncolor.TabIndex = 128
        Me.btncolor.Text = " "
        '
        'cmbcategoria
        '
        Me.cmbcategoria.BackColor = System.Drawing.Color.Transparent
        Me.cmbcategoria.BaseColor = System.Drawing.Color.White
        Me.cmbcategoria.BorderColor = System.Drawing.Color.Silver
        Me.cmbcategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategoria.FocusedColor = System.Drawing.Color.Empty
        Me.cmbcategoria.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategoria.ForeColor = System.Drawing.Color.Black
        Me.cmbcategoria.FormattingEnabled = True
        Me.cmbcategoria.Location = New System.Drawing.Point(995, 114)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbcategoria.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbcategoria.Radius = 10
        Me.cmbcategoria.Size = New System.Drawing.Size(254, 28)
        Me.cmbcategoria.TabIndex = 127
        Me.cmbcategoria.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1033, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 19)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(345, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 19)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Descripcion de los elementos."
        '
        'linkcategoria_reserva
        '
        Me.linkcategoria_reserva.AutoSize = True
        Me.linkcategoria_reserva.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkcategoria_reserva.Location = New System.Drawing.Point(1171, 91)
        Me.linkcategoria_reserva.Name = "linkcategoria_reserva"
        Me.linkcategoria_reserva.Size = New System.Drawing.Size(58, 15)
        Me.linkcategoria_reserva.TabIndex = 131
        Me.linkcategoria_reserva.TabStop = True
        Me.linkcategoria_reserva.Text = "Modificar"
        '
        'linktio_prestamo
        '
        Me.linktio_prestamo.AutoSize = True
        Me.linktio_prestamo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linktio_prestamo.Location = New System.Drawing.Point(561, 72)
        Me.linktio_prestamo.Name = "linktio_prestamo"
        Me.linktio_prestamo.Size = New System.Drawing.Size(58, 15)
        Me.linktio_prestamo.TabIndex = 133
        Me.linktio_prestamo.TabStop = True
        Me.linktio_prestamo.Text = "Modificar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(474, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 19)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Hora de devolución"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 19)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "*Formato de 24 horas"
        '
        'frm_detalle_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1314, 608)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.picker_hora_devolucion)
        Me.Controls.Add(Me.linktio_prestamo)
        Me.Controls.Add(Me.txttipo_prestamo)
        Me.Controls.Add(Me.linkcategoria_reserva)
        Me.Controls.Add(Me.txtcategoria_reserva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btncolor)
        Me.Controls.Add(Me.cmbcategoria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.cmbficha)
        Me.Controls.Add(Me.txtbuscadorficha)
        Me.Controls.Add(Me.lblrequire)
        Me.Controls.Add(Me.lblficha)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pickerfecha_prestamo)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.nmCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picker_hora)
        Me.Controls.Add(Me.bntcancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.cmbtipoPrestamo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_detalle_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Detalle de la reserva"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnagregar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents nmCantidad As Guna.UI.WinForms.GunaNumeric
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents picker_hora As DateTimePicker
    Friend WithEvents bntcancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnactualizar As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbtipoPrestamo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pickerfecha_prestamo As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblheader As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents btnregrsar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcliente As Label
    Friend WithEvents fecha_reserva As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cmbficha As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtbuscadorficha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblrequire As Label
    Friend WithEvents lblficha As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btncolor As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents cmbcategoria As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents linkcategoria_reserva As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents txtcategoria_reserva As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txttipo_prestamo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents linktio_prestamo As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents clm As DataGridViewTextBoxColumn
    Friend WithEvents clmcantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmobservaciones As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picker_hora_devolucion As DateTimePicker
End Class
