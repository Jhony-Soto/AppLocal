<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrestamoExterno
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxCliente = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnCerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblCorreoNom = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTelefonoNom = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.ptbFotoCliente = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.lblNumFicha = New System.Windows.Forms.Label()
        Me.lblDocidNom = New System.Windows.Forms.Label()
        Me.lblNombresNom = New System.Windows.Forms.Label()
        Me.lblDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocidNom = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvElementosPrestados = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxCliente.SuspendLayout()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvElementosPrestados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCliente
        '
        Me.gbxCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCliente.BackColor = System.Drawing.Color.Transparent
        Me.gbxCliente.BaseColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxCliente.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gbxCliente.BorderSize = 2
        Me.gbxCliente.Controls.Add(Me.btnCerrar)
        Me.gbxCliente.Controls.Add(Me.lblCorreoNom)
        Me.gbxCliente.Controls.Add(Me.lblCorreo)
        Me.gbxCliente.Controls.Add(Me.lblTelefonoNom)
        Me.gbxCliente.Controls.Add(Me.lblTelefono)
        Me.gbxCliente.Controls.Add(Me.ptbFotoCliente)
        Me.gbxCliente.Controls.Add(Me.lblNombres)
        Me.gbxCliente.Controls.Add(Me.lblFicha)
        Me.gbxCliente.Controls.Add(Me.lblNumFicha)
        Me.gbxCliente.Controls.Add(Me.lblDocidNom)
        Me.gbxCliente.Controls.Add(Me.lblNombresNom)
        Me.gbxCliente.Controls.Add(Me.lblDocid)
        Me.gbxCliente.Controls.Add(Me.lblTipoDocid)
        Me.gbxCliente.Controls.Add(Me.lblTipoDocidNom)
        Me.gbxCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCliente.ForeColor = System.Drawing.Color.White
        Me.gbxCliente.LineBottom = 2
        Me.gbxCliente.LineColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gbxCliente.LineLeft = 2
        Me.gbxCliente.LineRight = 2
        Me.gbxCliente.LineTop = 35
        Me.gbxCliente.Location = New System.Drawing.Point(2, 2)
        Me.gbxCliente.Name = "gbxCliente"
        Me.gbxCliente.Size = New System.Drawing.Size(1323, 193)
        Me.gbxCliente.TabIndex = 10
        Me.gbxCliente.Text = "Información del cliente"
        Me.gbxCliente.TextLocation = New System.Drawing.Point(10, 8)
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
        Me.btnCerrar.Image = Global.AppSena.My.Resources.Resources.icons8_cancel_64
        Me.btnCerrar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnCerrar.Location = New System.Drawing.Point(1292, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCerrar.OnHoverImage = Nothing
        Me.btnCerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btnCerrar.Size = New System.Drawing.Size(28, 28)
        Me.btnCerrar.TabIndex = 48
        '
        'lblCorreoNom
        '
        Me.lblCorreoNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCorreoNom.AutoSize = True
        Me.lblCorreoNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoNom.ForeColor = System.Drawing.Color.Black
        Me.lblCorreoNom.Location = New System.Drawing.Point(192, 141)
        Me.lblCorreoNom.Name = "lblCorreoNom"
        Me.lblCorreoNom.Size = New System.Drawing.Size(443, 19)
        Me.lblCorreoNom.TabIndex = 21
        Me.lblCorreoNom.Text = "1673552 - Analisis y Desarrollo de Sistemas de Informacion"
        Me.lblCorreoNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorreo
        '
        Me.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.Black
        Me.lblCorreo.Location = New System.Drawing.Point(10, 141)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(176, 19)
        Me.lblCorreo.TabIndex = 20
        Me.lblCorreo.Text = "Correo electrónico:"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefonoNom
        '
        Me.lblTelefonoNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTelefonoNom.AutoSize = True
        Me.lblTelefonoNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoNom.ForeColor = System.Drawing.Color.Black
        Me.lblTelefonoNom.Location = New System.Drawing.Point(107, 164)
        Me.lblTelefonoNom.Name = "lblTelefonoNom"
        Me.lblTelefonoNom.Size = New System.Drawing.Size(99, 19)
        Me.lblTelefonoNom.TabIndex = 19
        Me.lblTelefonoNom.Text = "3136449779"
        Me.lblTelefonoNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.Black
        Me.lblTelefono.Location = New System.Drawing.Point(10, 164)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(91, 19)
        Me.lblTelefono.TabIndex = 18
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbFotoCliente
        '
        Me.ptbFotoCliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbFotoCliente.BackColor = System.Drawing.Color.Transparent
        Me.ptbFotoCliente.BaseColor = System.Drawing.Color.LightGray
        Me.ptbFotoCliente.Location = New System.Drawing.Point(1115, 43)
        Me.ptbFotoCliente.Name = "ptbFotoCliente"
        Me.ptbFotoCliente.Size = New System.Drawing.Size(140, 140)
        Me.ptbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotoCliente.TabIndex = 17
        Me.ptbFotoCliente.TabStop = False
        Me.ptbFotoCliente.UseTransfarantBackground = False
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.Black
        Me.lblNombres.Location = New System.Drawing.Point(10, 43)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(93, 19)
        Me.lblNombres.TabIndex = 9
        Me.lblNombres.Text = "Nombres:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFicha
        '
        Me.lblFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFicha.AutoSize = True
        Me.lblFicha.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.Black
        Me.lblFicha.Location = New System.Drawing.Point(10, 114)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(62, 19)
        Me.lblFicha.TabIndex = 13
        Me.lblFicha.Text = "Ficha:"
        Me.lblFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumFicha
        '
        Me.lblNumFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNumFicha.AutoSize = True
        Me.lblNumFicha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFicha.ForeColor = System.Drawing.Color.Black
        Me.lblNumFicha.Location = New System.Drawing.Point(78, 114)
        Me.lblNumFicha.Name = "lblNumFicha"
        Me.lblNumFicha.Size = New System.Drawing.Size(443, 19)
        Me.lblNumFicha.TabIndex = 14
        Me.lblNumFicha.Text = "1673552 - Analisis y Desarrollo de Sistemas de Informacion"
        Me.lblNumFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocidNom
        '
        Me.lblDocidNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocidNom.AutoSize = True
        Me.lblDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblDocidNom.Location = New System.Drawing.Point(132, 65)
        Me.lblDocidNom.Name = "lblDocidNom"
        Me.lblDocidNom.Size = New System.Drawing.Size(108, 19)
        Me.lblDocidNom.TabIndex = 8
        Me.lblDocidNom.Text = "10004512343"
        Me.lblDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombresNom
        '
        Me.lblNombresNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombresNom.AutoSize = True
        Me.lblNombresNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresNom.ForeColor = System.Drawing.Color.Black
        Me.lblNombresNom.Location = New System.Drawing.Point(109, 43)
        Me.lblNombresNom.Name = "lblNombresNom"
        Me.lblNombresNom.Size = New System.Drawing.Size(247, 19)
        Me.lblNombresNom.TabIndex = 7
        Me.lblNombresNom.Text = "Emilio Cordoba Cuadrado Perea"
        Me.lblNombresNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocid
        '
        Me.lblDocid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocid.AutoSize = True
        Me.lblDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocid.ForeColor = System.Drawing.Color.Black
        Me.lblDocid.Location = New System.Drawing.Point(10, 65)
        Me.lblDocid.Name = "lblDocid"
        Me.lblDocid.Size = New System.Drawing.Size(116, 19)
        Me.lblDocid.TabIndex = 10
        Me.lblDocid.Text = "Documento:"
        Me.lblDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocid
        '
        Me.lblTipoDocid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoDocid.AutoSize = True
        Me.lblTipoDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocid.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocid.Location = New System.Drawing.Point(10, 89)
        Me.lblTipoDocid.Name = "lblTipoDocid"
        Me.lblTipoDocid.Size = New System.Drawing.Size(158, 19)
        Me.lblTipoDocid.TabIndex = 11
        Me.lblTipoDocid.Text = "Tipo Documento:"
        Me.lblTipoDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocidNom
        '
        Me.lblTipoDocidNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoDocidNom.AutoSize = True
        Me.lblTipoDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocidNom.Location = New System.Drawing.Point(174, 89)
        Me.lblTipoDocidNom.Name = "lblTipoDocidNom"
        Me.lblTipoDocidNom.Size = New System.Drawing.Size(168, 19)
        Me.lblTipoDocidNom.TabIndex = 12
        Me.lblTipoDocidNom.Text = "Cédula de Ciudadanía"
        Me.lblTipoDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvElementosPrestados)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1328, 414)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elementos prestados"
        '
        'dgvElementosPrestados
        '
        Me.dgvElementosPrestados.AllowUserToAddRows = False
        Me.dgvElementosPrestados.AllowUserToDeleteRows = False
        Me.dgvElementosPrestados.AllowUserToResizeColumns = False
        Me.dgvElementosPrestados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvElementosPrestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElementosPrestados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvElementosPrestados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvElementosPrestados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementosPrestados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvElementosPrestados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvElementosPrestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementosPrestados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElementosPrestados.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvElementosPrestados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElementosPrestados.EnableHeadersVisualStyles = False
        Me.dgvElementosPrestados.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementosPrestados.Location = New System.Drawing.Point(3, 23)
        Me.dgvElementosPrestados.Name = "dgvElementosPrestados"
        Me.dgvElementosPrestados.RowHeadersVisible = False
        Me.dgvElementosPrestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElementosPrestados.Size = New System.Drawing.Size(1322, 388)
        Me.dgvElementosPrestados.TabIndex = 1
        Me.dgvElementosPrestados.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvElementosPrestados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvElementosPrestados.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvElementosPrestados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementosPrestados.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvElementosPrestados.ThemeStyle.ReadOnly = False
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.Height = 22
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementosPrestados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha prestamo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "FechaDevolucion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'frmPrestamoExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 630)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrestamoExterno"
        Me.Text = "frmPrestamoExterno"
        Me.gbxCliente.ResumeLayout(False)
        Me.gbxCliente.PerformLayout()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvElementosPrestados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCliente As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents ptbFotoCliente As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblFicha As Label
    Friend WithEvents lblNumFicha As Label
    Friend WithEvents lblDocidNom As Label
    Friend WithEvents lblNombresNom As Label
    Friend WithEvents lblDocid As Label
    Friend WithEvents lblTipoDocid As Label
    Friend WithEvents lblTipoDocidNom As Label
    Friend WithEvents lblCorreoNom As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblTelefonoNom As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvElementosPrestados As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaCircleButton
End Class
