<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_administradores
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_administradores))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.pnladmin = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btnconsultar = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lbltipo_documento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblnombres = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldocumento = New System.Windows.Forms.Label()
        Me.pnlfoto = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnbuscar = New Guna.UI.WinForms.GunaButton()
        Me.btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.btnregistros = New Guna.UI.WinForms.GunaCircleButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeAdministradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picker_dia_inicial = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lbliniciaol = New System.Windows.Forms.Label()
        Me.picker_dia_final = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblfinal = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.lblheader = New System.Windows.Forms.Label()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnladmin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pnlfoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        Me.dgdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdatos.BackgroundColor = System.Drawing.Color.White
        Me.dgdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgdatos.ColumnHeadersHeight = 40
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmeliminar})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdatos.Location = New System.Drawing.Point(25, 176)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(1267, 382)
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
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.NullValue = CType(resources.GetObject("DataGridViewCellStyle19.NullValue"), Object)
        Me.clmeliminar.DefaultCellStyle = DataGridViewCellStyle19
        Me.clmeliminar.HeaderText = "Eliminar"
        Me.clmeliminar.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.clmeliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmeliminar.Name = "clmeliminar"
        Me.clmeliminar.ReadOnly = True
        Me.clmeliminar.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Buscar Administrador"
        Me.ToolTip1.SetToolTip(Me.Label1, "Puedes buscar por documento , nombres y apellidos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
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
        Me.txtbuscador.Location = New System.Drawing.Point(33, 122)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(406, 30)
        Me.txtbuscador.TabIndex = 35
        Me.txtbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnladmin
        '
        Me.pnladmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnladmin.BackColor = System.Drawing.Color.Transparent
        Me.pnladmin.BaseColor = System.Drawing.Color.White
        Me.pnladmin.Controls.Add(Me.btnconsultar)
        Me.pnladmin.Controls.Add(Me.Panel1)
        Me.pnladmin.Controls.Add(Me.lbltipo_documento)
        Me.pnladmin.Controls.Add(Me.Label10)
        Me.pnladmin.Controls.Add(Me.lbltelefono)
        Me.pnladmin.Controls.Add(Me.Label8)
        Me.pnladmin.Controls.Add(Me.lblcorreo)
        Me.pnladmin.Controls.Add(Me.Label6)
        Me.pnladmin.Controls.Add(Me.lblnombres)
        Me.pnladmin.Controls.Add(Me.Label4)
        Me.pnladmin.Controls.Add(Me.lbldocumento)
        Me.pnladmin.Controls.Add(Me.pnlfoto)
        Me.pnladmin.Controls.Add(Me.Label2)
        Me.pnladmin.Location = New System.Drawing.Point(821, 89)
        Me.pnladmin.Name = "pnladmin"
        Me.pnladmin.ShadowColor = System.Drawing.Color.Black
        Me.pnladmin.ShadowShift = 10
        Me.pnladmin.Size = New System.Drawing.Size(486, 517)
        Me.pnladmin.TabIndex = 37
        Me.pnladmin.Visible = False
        '
        'btnconsultar
        '
        Me.btnconsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconsultar.AnimationHoverSpeed = 0.07!
        Me.btnconsultar.AnimationSpeed = 0.03!
        Me.btnconsultar.BackColor = System.Drawing.Color.Transparent
        Me.btnconsultar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnconsultar.BorderColor = System.Drawing.Color.Transparent
        Me.btnconsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconsultar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnconsultar.FocusedColor = System.Drawing.Color.Empty
        Me.btnconsultar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultar.ForeColor = System.Drawing.Color.White
        Me.btnconsultar.Image = Global.Appsena.My.Resources.Resources.icons8_update_32
        Me.btnconsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnconsultar.Location = New System.Drawing.Point(365, 48)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnconsultar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnconsultar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnconsultar.OnHoverImage = Nothing
        Me.btnconsultar.OnPressedColor = System.Drawing.Color.Black
        Me.btnconsultar.Radius = 10
        Me.btnconsultar.Size = New System.Drawing.Size(107, 31)
        Me.btnconsultar.TabIndex = 51
        Me.btnconsultar.Text = "Cambiar"
        Me.btnconsultar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnconsultar, "Cambiar de administrador principal")
        Me.btnconsultar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.lblestado)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 42)
        Me.Panel1.TabIndex = 50
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(444, 5)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.Size = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.GunaCircleButton1, "Cerrar")
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.Transparent
        Me.lblestado.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.White
        Me.lblestado.Location = New System.Drawing.Point(149, 11)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(212, 19)
        Me.lblestado.TabIndex = 48
        Me.lblestado.Text = "Administrador principal"
        Me.lblestado.Visible = False
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
        '
        'lbltipo_documento
        '
        Me.lbltipo_documento.AutoSize = True
        Me.lbltipo_documento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo_documento.Location = New System.Drawing.Point(235, 471)
        Me.lbltipo_documento.Name = "lbltipo_documento"
        Me.lbltipo_documento.Size = New System.Drawing.Size(35, 19)
        Me.lbltipo_documento.TabIndex = 47
        Me.lbltipo_documento.Text = "asd"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 471)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(182, 19)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Tipo de documento:"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(144, 421)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(33, 19)
        Me.lbltelefono.TabIndex = 45
        Me.lbltelefono.Text = "ass"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Telefono:"
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(127, 371)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(35, 19)
        Me.lblcorreo.TabIndex = 43
        Me.lblcorreo.Text = "asd"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Correo:"
        '
        'lblnombres
        '
        Me.lblnombres.AutoSize = True
        Me.lblnombres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombres.Location = New System.Drawing.Point(146, 321)
        Me.lblnombres.Name = "lblnombres"
        Me.lblnombres.Size = New System.Drawing.Size(35, 19)
        Me.lblnombres.TabIndex = 41
        Me.lblnombres.Text = "asd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nombres:"
        '
        'lbldocumento
        '
        Me.lbldocumento.AutoSize = True
        Me.lbldocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocumento.Location = New System.Drawing.Point(169, 271)
        Me.lbldocumento.Name = "lbldocumento"
        Me.lbldocumento.Size = New System.Drawing.Size(35, 19)
        Me.lbldocumento.TabIndex = 39
        Me.lbldocumento.Text = "asd"
        '
        'pnlfoto
        '
        Me.pnlfoto.BaseColor = System.Drawing.Color.Silver
        Me.pnlfoto.Location = New System.Drawing.Point(159, 58)
        Me.pnlfoto.Name = "pnlfoto"
        Me.pnlfoto.Size = New System.Drawing.Size(200, 200)
        Me.pnlfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pnlfoto.TabIndex = 0
        Me.pnlfoto.TabStop = False
        Me.pnlfoto.UseTransfarantBackground = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Documento:"
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
        Me.btnbuscar.Location = New System.Drawing.Point(1192, 124)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuscar.OnHoverImage = Nothing
        Me.btnbuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuscar.Radius = 10
        Me.btnbuscar.Size = New System.Drawing.Size(100, 28)
        Me.btnbuscar.TabIndex = 142
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
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
        Me.btnagregar.Location = New System.Drawing.Point(465, 122)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnagregar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagregar.OnHoverImage = Nothing
        Me.btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnagregar.Radius = 10
        Me.btnagregar.Size = New System.Drawing.Size(138, 30)
        Me.btnagregar.TabIndex = 38
        Me.btnagregar.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.btnagregar, "Agregar un nuevo cliente")
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
        Me.btnregistros.Location = New System.Drawing.Point(12, 12)
        Me.btnregistros.Name = "btnregistros"
        Me.btnregistros.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistros.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregistros.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregistros.OnHoverImage = Nothing
        Me.btnregistros.OnPressedColor = System.Drawing.Color.Black
        Me.btnregistros.Size = New System.Drawing.Size(60, 60)
        Me.btnregistros.TabIndex = 145
        Me.ToolTip1.SetToolTip(Me.btnregistros, "Nuemero de elementos")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIONESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1319, 27)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialDeAdministradoresToolStripMenuItem, Me.AdministradoresToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_bulleted_list_32
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(118, 23)
        Me.OPCIONESToolStripMenuItem.Text = "OPCIONES"
        '
        'HistorialDeAdministradoresToolStripMenuItem
        '
        Me.HistorialDeAdministradoresToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_document_64
        Me.HistorialDeAdministradoresToolStripMenuItem.Name = "HistorialDeAdministradoresToolStripMenuItem"
        Me.HistorialDeAdministradoresToolStripMenuItem.Size = New System.Drawing.Size(411, 24)
        Me.HistorialDeAdministradoresToolStripMenuItem.Text = "Historial  de sesiones  de los administradores"
        '
        'AdministradoresToolStripMenuItem
        '
        Me.AdministradoresToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_user_folder_64
        Me.AdministradoresToolStripMenuItem.Name = "AdministradoresToolStripMenuItem"
        Me.AdministradoresToolStripMenuItem.Size = New System.Drawing.Size(411, 24)
        Me.AdministradoresToolStripMenuItem.Text = "Administradores"
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
        Me.picker_dia_inicial.Location = New System.Drawing.Point(705, 122)
        Me.picker_dia_inicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_inicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_inicial.Name = "picker_dia_inicial"
        Me.picker_dia_inicial.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_inicial.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_inicial.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.Radius = 10
        Me.picker_dia_inicial.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_inicial.TabIndex = 46
        Me.picker_dia_inicial.Text = "3/12/2019"
        Me.picker_dia_inicial.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'lbliniciaol
        '
        Me.lbliniciaol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbliniciaol.AutoSize = True
        Me.lbliniciaol.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliniciaol.Location = New System.Drawing.Point(752, 100)
        Me.lbliniciaol.Name = "lbliniciaol"
        Me.lbliniciaol.Size = New System.Drawing.Size(97, 19)
        Me.lbliniciaol.TabIndex = 45
        Me.lbliniciaol.Text = "Fecha Inicial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.picker_dia_final.Location = New System.Drawing.Point(948, 124)
        Me.picker_dia_final.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_final.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_final.Name = "picker_dia_final"
        Me.picker_dia_final.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_final.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_final.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_final.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_final.Radius = 10
        Me.picker_dia_final.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_final.TabIndex = 44
        Me.picker_dia_final.Text = "3/12/2019"
        Me.picker_dia_final.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'lblfinal
        '
        Me.lblfinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfinal.AutoSize = True
        Me.lblfinal.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinal.Location = New System.Drawing.Point(985, 101)
        Me.lblfinal.Name = "lblfinal"
        Me.lblfinal.Size = New System.Drawing.Size(90, 19)
        Me.lblfinal.TabIndex = 43
        Me.lblfinal.Text = "Fecha Final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'pnlheader
        '
        Me.pnlheader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnlheader.Location = New System.Drawing.Point(435, 78)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(500, 5)
        Me.pnlheader.TabIndex = 144
        '
        'lblheader
        '
        Me.lblheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.Black
        Me.lblheader.Location = New System.Drawing.Point(438, 49)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(218, 50)
        Me.lblheader.TabIndex = 143
        Me.lblheader.Text = "Historial de sesiones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frm_administradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 580)
        Me.Controls.Add(Me.btnregistros)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.lblheader)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.picker_dia_inicial)
        Me.Controls.Add(Me.lbliniciaol)
        Me.Controls.Add(Me.picker_dia_final)
        Me.Controls.Add(Me.lblfinal)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.pnladmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_administradores"
        Me.Text = "Administradores"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnladmin.ResumeLayout(False)
        Me.pnladmin.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pnlfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnladmin As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbltipo_documento As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblcorreo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblnombres As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbldocumento As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblestado As Label
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnconsultar As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlfoto As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnagregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeAdministradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picker_dia_inicial As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lbliniciaol As Label
    Friend WithEvents picker_dia_final As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblfinal As Label
    Friend WithEvents btnbuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents AdministradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlheader As Panel
    Friend WithEvents lblheader As Label
    Friend WithEvents btnregistros As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents clmeliminar As DataGridViewImageColumn
End Class
