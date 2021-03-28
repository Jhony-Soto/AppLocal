<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_reservas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.cmbtipoPrestamo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pickerfecha_reserva = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.picker_hora = New System.Windows.Forms.DateTimePicker()
        Me.btnagregar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnficha = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnguardarficha = New Guna.UI.WinForms.GunaButton()
        Me.bntcancelar = New Guna.UI.WinForms.GunaButton()
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nmCantidad = New Guna.UI.WinForms.GunaNumeric()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmeditar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmobservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbcliente = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbcategoria = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlinsert_ficha = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtprograma = New Guna.UI.WinForms.GunaTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtficha = New Guna.UI.WinForms.GunaTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbficha = New Guna.UI.WinForms.GunaComboBox()
        Me.txtbuscadorficha = New Guna.UI.WinForms.GunaTextBox()
        Me.lblrequire = New System.Windows.Forms.Label()
        Me.lblficha = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btncolor = New Guna.UI.WinForms.GunaCircleButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.picker_hora_devolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlinsert_ficha.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'cmbtipoPrestamo
        '
        Me.cmbtipoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.cmbtipoPrestamo.BaseColor = System.Drawing.Color.White
        Me.cmbtipoPrestamo.BorderColor = System.Drawing.Color.Silver
        Me.cmbtipoPrestamo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipoPrestamo.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtipoPrestamo.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.cmbtipoPrestamo.FormattingEnabled = True
        Me.cmbtipoPrestamo.Location = New System.Drawing.Point(426, 86)
        Me.cmbtipoPrestamo.Name = "cmbtipoPrestamo"
        Me.cmbtipoPrestamo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbtipoPrestamo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtipoPrestamo.Radius = 10
        Me.cmbtipoPrestamo.Size = New System.Drawing.Size(230, 28)
        Me.cmbtipoPrestamo.TabIndex = 16
        Me.cmbtipoPrestamo.Tag = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(447, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tipo de prestamo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pickerfecha_reserva)
        Me.Panel1.Controls.Add(Me.lblheader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1314, 55)
        Me.Panel1.TabIndex = 11
        '
        'pickerfecha_reserva
        '
        Me.pickerfecha_reserva.BackColor = System.Drawing.Color.Transparent
        Me.pickerfecha_reserva.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pickerfecha_reserva.BorderColor = System.Drawing.Color.Silver
        Me.pickerfecha_reserva.CustomFormat = "d,MMMM,yyyy"
        Me.pickerfecha_reserva.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.pickerfecha_reserva.Enabled = False
        Me.pickerfecha_reserva.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pickerfecha_reserva.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickerfecha_reserva.ForeColor = System.Drawing.Color.White
        Me.pickerfecha_reserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pickerfecha_reserva.Location = New System.Drawing.Point(567, 15)
        Me.pickerfecha_reserva.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.pickerfecha_reserva.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.pickerfecha_reserva.Name = "pickerfecha_reserva"
        Me.pickerfecha_reserva.OnHoverBaseColor = System.Drawing.Color.White
        Me.pickerfecha_reserva.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pickerfecha_reserva.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pickerfecha_reserva.OnPressedColor = System.Drawing.Color.Black
        Me.pickerfecha_reserva.Radius = 10
        Me.pickerfecha_reserva.Size = New System.Drawing.Size(182, 28)
        Me.pickerfecha_reserva.TabIndex = 18
        Me.pickerfecha_reserva.Text = "29/11/2019"
        Me.ToolTip1.SetToolTip(Me.pickerfecha_reserva, "Fecha del Prestamo")
        Me.pickerfecha_reserva.Value = New Date(2019, 11, 29, 9, 10, 25, 893)
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.White
        Me.lblheader.Location = New System.Drawing.Point(229, 15)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(326, 25)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Realizar una reserva para el "
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
        Me.txtbuscador.Location = New System.Drawing.Point(254, 262)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(425, 30)
        Me.txtbuscador.TabIndex = 22
        Me.txtbuscador.Tag = "7"
        Me.ToolTip1.SetToolTip(Me.txtbuscador, "Busca por codigo o nombre del elemento")
        '
        'picker_hora
        '
        Me.picker_hora.CustomFormat = "H:mm"
        Me.picker_hora.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.picker_hora.Location = New System.Drawing.Point(301, 163)
        Me.picker_hora.Name = "picker_hora"
        Me.picker_hora.ShowUpDown = True
        Me.picker_hora.Size = New System.Drawing.Size(141, 29)
        Me.picker_hora.TabIndex = 20
        Me.picker_hora.Tag = "5"
        Me.ToolTip1.SetToolTip(Me.picker_hora, "Hora del prestamo")
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
        Me.btnagregar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.Image = Nothing
        Me.btnagregar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnagregar.Location = New System.Drawing.Point(952, 260)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregar.OnHoverImage = Nothing
        Me.btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregar.Size = New System.Drawing.Size(40, 40)
        Me.btnagregar.TabIndex = 30
        Me.btnagregar.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnagregar, "Agregar Elemento")
        '
        'btnficha
        '
        Me.btnficha.AnimationHoverSpeed = 0.07!
        Me.btnficha.AnimationSpeed = 0.03!
        Me.btnficha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnficha.BorderColor = System.Drawing.Color.Black
        Me.btnficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnficha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnficha.FocusedColor = System.Drawing.Color.Empty
        Me.btnficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnficha.ForeColor = System.Drawing.Color.White
        Me.btnficha.Image = Nothing
        Me.btnficha.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnficha.Location = New System.Drawing.Point(946, 106)
        Me.btnficha.Name = "btnficha"
        Me.btnficha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnficha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnficha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnficha.OnHoverImage = Nothing
        Me.btnficha.OnPressedColor = System.Drawing.Color.Black
        Me.btnficha.Size = New System.Drawing.Size(30, 30)
        Me.btnficha.TabIndex = 113
        Me.btnficha.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnficha, "Agregar una ficha")
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
        Me.btnguardarficha.Location = New System.Drawing.Point(14, 163)
        Me.btnguardarficha.Name = "btnguardarficha"
        Me.btnguardarficha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnguardarficha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnguardarficha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardarficha.OnHoverImage = Nothing
        Me.btnguardarficha.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardarficha.Radius = 10
        Me.btnguardarficha.Size = New System.Drawing.Size(180, 30)
        Me.btnguardarficha.TabIndex = 113
        Me.btnguardarficha.Text = "Guardar Datos"
        Me.btnguardarficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnguardarficha, "Guardar datos")
        '
        'bntcancelar
        '
        Me.bntcancelar.AnimationHoverSpeed = 0.07!
        Me.bntcancelar.AnimationSpeed = 0.03!
        Me.bntcancelar.BackColor = System.Drawing.Color.Transparent
        Me.bntcancelar.BaseColor = System.Drawing.Color.Gray
        Me.bntcancelar.BorderColor = System.Drawing.Color.Black
        Me.bntcancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntcancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bntcancelar.FocusedColor = System.Drawing.Color.Empty
        Me.bntcancelar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntcancelar.ForeColor = System.Drawing.Color.White
        Me.bntcancelar.Image = Global.Appsena.My.Resources.Resources.icons8_error_64
        Me.bntcancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.bntcancelar.Location = New System.Drawing.Point(645, 579)
        Me.bntcancelar.Name = "bntcancelar"
        Me.bntcancelar.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.bntcancelar.OnHoverBorderColor = System.Drawing.Color.White
        Me.bntcancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.bntcancelar.OnHoverImage = Nothing
        Me.bntcancelar.OnPressedColor = System.Drawing.Color.Black
        Me.bntcancelar.Radius = 10
        Me.bntcancelar.Size = New System.Drawing.Size(125, 34)
        Me.bntcancelar.TabIndex = 41
        Me.bntcancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.bntcancelar, "Cancelar la Reserva")
        '
        'btnguardar
        '
        Me.btnguardar.AnimationHoverSpeed = 0.07!
        Me.btnguardar.AnimationSpeed = 0.03!
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnguardar.BorderColor = System.Drawing.Color.Black
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardar.Location = New System.Drawing.Point(503, 579)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnguardar.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverImage = Nothing
        Me.btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar.Radius = 10
        Me.btnguardar.Size = New System.Drawing.Size(121, 34)
        Me.btnguardar.TabIndex = 40
        Me.btnguardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnguardar, "Guardar Reserva")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Hora del prestamo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(361, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Descripcion de los elementos."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(722, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Cantidad"
        '
        'nmCantidad
        '
        Me.nmCantidad.BackColor = System.Drawing.Color.Transparent
        Me.nmCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.nmCantidad.BaseColor = System.Drawing.Color.White
        Me.nmCantidad.BorderColor = System.Drawing.Color.Silver
        Me.nmCantidad.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.nmCantidad.ButtonForeColor = System.Drawing.Color.White
        Me.nmCantidad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmCantidad.ForeColor = System.Drawing.Color.Black
        Me.nmCantidad.Location = New System.Drawing.Point(801, 265)
        Me.nmCantidad.Maximum = CType(50, Long)
        Me.nmCantidad.Minimum = CType(0, Long)
        Me.nmCantidad.Name = "nmCantidad"
        Me.nmCantidad.Radius = 10
        Me.nmCantidad.Size = New System.Drawing.Size(134, 30)
        Me.nmCantidad.TabIndex = 26
        Me.nmCantidad.Text = "GunaNumeric1"
        Me.nmCantidad.Value = CType(1, Long)
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(41, 209)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1220, 5)
        Me.GunaLinePanel1.TabIndex = 29
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdatos.BackgroundColor = System.Drawing.Color.White
        Me.dgdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgdatos.ColumnHeadersHeight = 40
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmeliminar, Me.clmeditar, Me.clm, Me.clmcantidad, Me.clmobservaciones})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdatos.Location = New System.Drawing.Point(37, 326)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(1231, 221)
        Me.dgdatos.TabIndex = 31
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
        'clmeliminar
        '
        Me.clmeliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmeliminar.HeaderText = "Eliminar"
        Me.clmeliminar.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.clmeliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmeliminar.Name = "clmeliminar"
        Me.clmeliminar.Width = 70
        '
        'clmeditar
        '
        Me.clmeditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmeditar.HeaderText = "Editar"
        Me.clmeditar.Image = Global.Appsena.My.Resources.Resources.icons8_update_16
        Me.clmeditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmeditar.Name = "clmeditar"
        Me.clmeditar.Width = 70
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
        Me.clmcantidad.Width = 75
        '
        'clmobservaciones
        '
        Me.clmobservaciones.HeaderText = "Observaciones"
        Me.clmobservaciones.Name = "clmobservaciones"
        Me.clmobservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmbcliente
        '
        Me.cmbcliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbcliente.BaseColor = System.Drawing.Color.White
        Me.cmbcliente.BorderColor = System.Drawing.Color.Silver
        Me.cmbcliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcliente.FocusedColor = System.Drawing.Color.Empty
        Me.cmbcliente.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcliente.ForeColor = System.Drawing.Color.Black
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(53, 86)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbcliente.Radius = 10
        Me.cmbcliente.Size = New System.Drawing.Size(316, 28)
        Me.cmbcliente.TabIndex = 15
        Me.cmbcliente.Tag = "1"
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
        Me.cmbcategoria.Location = New System.Drawing.Point(1014, 132)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbcategoria.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbcategoria.Radius = 10
        Me.cmbcategoria.Size = New System.Drawing.Size(254, 28)
        Me.cmbcategoria.TabIndex = 33
        Me.cmbcategoria.Tag = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1052, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = " "
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 649)
        Me.Panel2.TabIndex = 34
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 643)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1314, 5)
        Me.FlowLayoutPanel1.TabIndex = 35
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(1309, -6)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(10, 649)
        Me.FlowLayoutPanel2.TabIndex = 36
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1311, 5)
        Me.Panel3.TabIndex = 37
        '
        'pnlinsert_ficha
        '
        Me.pnlinsert_ficha.BackColor = System.Drawing.Color.Transparent
        Me.pnlinsert_ficha.BaseColor = System.Drawing.Color.White
        Me.pnlinsert_ficha.Controls.Add(Me.btnguardarficha)
        Me.pnlinsert_ficha.Controls.Add(Me.Label20)
        Me.pnlinsert_ficha.Controls.Add(Me.txtprograma)
        Me.pnlinsert_ficha.Controls.Add(Me.Label21)
        Me.pnlinsert_ficha.Controls.Add(Me.Label18)
        Me.pnlinsert_ficha.Controls.Add(Me.txtficha)
        Me.pnlinsert_ficha.Controls.Add(Me.Label19)
        Me.pnlinsert_ficha.Location = New System.Drawing.Point(719, 144)
        Me.pnlinsert_ficha.Name = "pnlinsert_ficha"
        Me.pnlinsert_ficha.ShadowColor = System.Drawing.Color.Black
        Me.pnlinsert_ficha.ShadowShift = 10
        Me.pnlinsert_ficha.Size = New System.Drawing.Size(221, 230)
        Me.pnlinsert_ficha.TabIndex = 118
        Me.pnlinsert_ficha.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(218, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 24)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "*"
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
        Me.txtprograma.Location = New System.Drawing.Point(19, 109)
        Me.txtprograma.Name = "txtprograma"
        Me.txtprograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprograma.Radius = 10
        Me.txtprograma.Size = New System.Drawing.Size(180, 31)
        Me.txtprograma.TabIndex = 91
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(63, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 19)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = "Programa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(223, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 24)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "*"
        '
        'txtficha
        '
        Me.txtficha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtficha.BackColor = System.Drawing.Color.Transparent
        Me.txtficha.BaseColor = System.Drawing.Color.White
        Me.txtficha.BorderColor = System.Drawing.Color.Silver
        Me.txtficha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtficha.FocusedBaseColor = System.Drawing.Color.White
        Me.txtficha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtficha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtficha.Location = New System.Drawing.Point(19, 54)
        Me.txtficha.Name = "txtficha"
        Me.txtficha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtficha.Radius = 10
        Me.txtficha.Size = New System.Drawing.Size(180, 31)
        Me.txtficha.TabIndex = 88
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(72, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 19)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Ficha"
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
        Me.cmbficha.Location = New System.Drawing.Point(719, 141)
        Me.cmbficha.Name = "cmbficha"
        Me.cmbficha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbficha.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbficha.Radius = 10
        Me.cmbficha.Size = New System.Drawing.Size(221, 28)
        Me.cmbficha.TabIndex = 117
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
        Me.txtbuscadorficha.Location = New System.Drawing.Point(719, 108)
        Me.txtbuscadorficha.Name = "txtbuscadorficha"
        Me.txtbuscadorficha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscadorficha.Radius = 10
        Me.txtbuscadorficha.Size = New System.Drawing.Size(221, 30)
        Me.txtbuscadorficha.TabIndex = 116
        Me.txtbuscadorficha.Tag = "3"
        '
        'lblrequire
        '
        Me.lblrequire.AutoSize = True
        Me.lblrequire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrequire.ForeColor = System.Drawing.Color.Red
        Me.lblrequire.Location = New System.Drawing.Point(848, 86)
        Me.lblrequire.Name = "lblrequire"
        Me.lblrequire.Size = New System.Drawing.Size(18, 24)
        Me.lblrequire.TabIndex = 115
        Me.lblrequire.Text = "*"
        '
        'lblficha
        '
        Me.lblficha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblficha.AutoSize = True
        Me.lblficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblficha.Location = New System.Drawing.Point(795, 90)
        Me.lblficha.Name = "lblficha"
        Me.lblficha.Size = New System.Drawing.Size(47, 19)
        Me.lblficha.TabIndex = 114
        Me.lblficha.Text = "Ficha"
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
        Me.btncolor.Location = New System.Drawing.Point(1274, 136)
        Me.btncolor.Name = "btncolor"
        Me.btncolor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncolor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncolor.OnHoverForeColor = System.Drawing.Color.White
        Me.btncolor.OnHoverImage = Nothing
        Me.btncolor.OnPressedColor = System.Drawing.Color.Black
        Me.btncolor.Size = New System.Drawing.Size(20, 20)
        Me.btncolor.TabIndex = 119
        Me.btncolor.Text = " "
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_32
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 189
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.HeaderText = "Editar"
        Me.DataGridViewImageColumn2.Image = Global.Appsena.My.Resources.Resources.icons8_update_16
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 189
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1023, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 19)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Categoria de reservas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(519, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 19)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Hora de devolución"
        '
        'picker_hora_devolucion
        '
        Me.picker_hora_devolucion.CustomFormat = "H:mm"
        Me.picker_hora_devolucion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_hora_devolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.picker_hora_devolucion.Location = New System.Drawing.Point(524, 163)
        Me.picker_hora_devolucion.Name = "picker_hora_devolucion"
        Me.picker_hora_devolucion.ShowUpDown = True
        Me.picker_hora_devolucion.Size = New System.Drawing.Size(141, 29)
        Me.picker_hora_devolucion.TabIndex = 121
        Me.picker_hora_devolucion.Tag = "5"
        Me.ToolTip1.SetToolTip(Me.picker_hora_devolucion, "Hora del prestamo")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 19)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "*Formato de 24 Horas"
        '
        'frm_reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1314, 648)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.picker_hora_devolucion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btncolor)
        Me.Controls.Add(Me.pnlinsert_ficha)
        Me.Controls.Add(Me.btnficha)
        Me.Controls.Add(Me.cmbficha)
        Me.Controls.Add(Me.txtbuscadorficha)
        Me.Controls.Add(Me.lblrequire)
        Me.Controls.Add(Me.lblficha)
        Me.Controls.Add(Me.bntcancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbcategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.nmCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picker_hora)
        Me.Controls.Add(Me.cmbtipoPrestamo)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "b"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlinsert_ficha.ResumeLayout(False)
        Me.pnlinsert_ficha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents cmbtipoPrestamo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheader As Label
    Friend WithEvents pickerfecha_reserva As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents picker_hora As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents nmCantidad As Guna.UI.WinForms.GunaNumeric
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnagregar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cmbcliente As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbcategoria As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bntcancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlinsert_ficha As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnguardarficha As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label20 As Label
    Friend WithEvents txtprograma As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtficha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnficha As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents cmbficha As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtbuscadorficha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblrequire As Label
    Friend WithEvents lblficha As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btncolor As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label8 As Label
    Friend WithEvents clmeliminar As DataGridViewImageColumn
    Friend WithEvents clmeditar As DataGridViewImageColumn
    Friend WithEvents clm As DataGridViewTextBoxColumn
    Friend WithEvents clmcantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmobservaciones As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents picker_hora_devolucion As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
