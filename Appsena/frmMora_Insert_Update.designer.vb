<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMora_Insert_Update
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMora_Insert_Update))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlVentana = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvMora = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtObservaciones = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpEntradaMora = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.lblNumFicha = New System.Windows.Forms.Label()
        Me.lblDocidNom = New System.Windows.Forms.Label()
        Me.lblNombresNom = New System.Windows.Forms.Label()
        Me.lblDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocidNom = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTelefonoNom = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCorreoElectNom = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ptbFotoCliente = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnEnviarAMora = New Guna.UI.WinForms.GunaButton()
        Me.lblCodPres = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidadMora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmObserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipElem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmestado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConseElement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaPres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlVentana.SuspendLayout()
        CType(Me.dgvMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 5)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 657)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1281, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 657)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 657)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1276, 5)
        Me.Panel4.TabIndex = 3
        '
        'pnlVentana
        '
        Me.pnlVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.pnlVentana.Controls.Add(Me.btnCerrar)
        Me.pnlVentana.Controls.Add(Me.lblTitulo)
        Me.pnlVentana.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVentana.Location = New System.Drawing.Point(5, 5)
        Me.pnlVentana.Name = "pnlVentana"
        Me.pnlVentana.Size = New System.Drawing.Size(1276, 33)
        Me.pnlVentana.TabIndex = 53
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
        Me.btnCerrar.Location = New System.Drawing.Point(1245, 2)
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
        Me.lblTitulo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1276, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Enviar a mora"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMora
        '
        Me.dgvMora.AllowUserToAddRows = False
        Me.dgvMora.AllowUserToDeleteRows = False
        Me.dgvMora.AllowUserToResizeColumns = False
        Me.dgvMora.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMora.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMora.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMora.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.clmCantidadMora, Me.clmObserva, Me.clmTipElem, Me.clmestado, Me.clmConseElement, Me.clmFechaPres, Me.clmEliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMora.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMora.EnableHeadersVisualStyles = False
        Me.dgvMora.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMora.Location = New System.Drawing.Point(50, 347)
        Me.dgvMora.Name = "dgvMora"
        Me.dgvMora.ReadOnly = True
        Me.dgvMora.RowHeadersVisible = False
        Me.dgvMora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMora.Size = New System.Drawing.Size(1199, 238)
        Me.dgvMora.TabIndex = 56
        Me.dgvMora.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvMora.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvMora.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvMora.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvMora.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvMora.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMora.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvMora.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMora.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvMora.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMora.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMora.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvMora.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMora.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvMora.ThemeStyle.ReadOnly = True
        Me.dgvMora.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvMora.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMora.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMora.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvMora.ThemeStyle.RowsStyle.Height = 22
        Me.dgvMora.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvMora.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.txtObservaciones.BaseColor = System.Drawing.Color.White
        Me.txtObservaciones.BorderColor = System.Drawing.Color.Silver
        Me.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservaciones.FocusedBaseColor = System.Drawing.Color.White
        Me.txtObservaciones.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtObservaciones.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtObservaciones.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.Location = New System.Drawing.Point(46, 261)
        Me.txtObservaciones.MultiLine = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Radius = 10
        Me.txtObservaciones.Size = New System.Drawing.Size(1187, 61)
        Me.txtObservaciones.TabIndex = 57
        Me.txtObservaciones.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Fecha de entrada:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEntradaMora
        '
        Me.dtpEntradaMora.BackColor = System.Drawing.Color.Transparent
        Me.dtpEntradaMora.BaseColor = System.Drawing.Color.White
        Me.dtpEntradaMora.BorderColor = System.Drawing.Color.Silver
        Me.dtpEntradaMora.Checked = False
        Me.dtpEntradaMora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEntradaMora.CustomFormat = "d 'de' MMMM yyyy"
        Me.dtpEntradaMora.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpEntradaMora.Enabled = False
        Me.dtpEntradaMora.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpEntradaMora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntradaMora.ForeColor = System.Drawing.Color.Black
        Me.dtpEntradaMora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntradaMora.Location = New System.Drawing.Point(212, 48)
        Me.dtpEntradaMora.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEntradaMora.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEntradaMora.Name = "dtpEntradaMora"
        Me.dtpEntradaMora.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpEntradaMora.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpEntradaMora.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpEntradaMora.OnPressedColor = System.Drawing.Color.Black
        Me.dtpEntradaMora.Radius = 10
        Me.dtpEntradaMora.Size = New System.Drawing.Size(223, 30)
        Me.dtpEntradaMora.TabIndex = 61
        Me.dtpEntradaMora.Text = "11 de marzo 2020"
        Me.dtpEntradaMora.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 64
        Me.Label4.Tag = "Observaciones"
        Me.Label4.Text = "Observaciones:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.Black
        Me.lblNombres.Location = New System.Drawing.Point(40, 84)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(93, 19)
        Me.lblNombres.TabIndex = 67
        Me.lblNombres.Text = "Nombres:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFicha
        '
        Me.lblFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFicha.AutoSize = True
        Me.lblFicha.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.Black
        Me.lblFicha.Location = New System.Drawing.Point(41, 157)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(62, 19)
        Me.lblFicha.TabIndex = 71
        Me.lblFicha.Text = "Ficha:"
        Me.lblFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumFicha
        '
        Me.lblNumFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNumFicha.AutoSize = True
        Me.lblNumFicha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFicha.ForeColor = System.Drawing.Color.Black
        Me.lblNumFicha.Location = New System.Drawing.Point(109, 157)
        Me.lblNumFicha.Name = "lblNumFicha"
        Me.lblNumFicha.Size = New System.Drawing.Size(443, 19)
        Me.lblNumFicha.TabIndex = 72
        Me.lblNumFicha.Text = "1673552 - Analisis y Desarrollo de Sistemas de Informacion"
        Me.lblNumFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocidNom
        '
        Me.lblDocidNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocidNom.AutoSize = True
        Me.lblDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblDocidNom.Location = New System.Drawing.Point(162, 106)
        Me.lblDocidNom.Name = "lblDocidNom"
        Me.lblDocidNom.Size = New System.Drawing.Size(108, 19)
        Me.lblDocidNom.TabIndex = 66
        Me.lblDocidNom.Text = "10004512343"
        Me.lblDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombresNom
        '
        Me.lblNombresNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombresNom.AutoSize = True
        Me.lblNombresNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresNom.ForeColor = System.Drawing.Color.Black
        Me.lblNombresNom.Location = New System.Drawing.Point(139, 83)
        Me.lblNombresNom.Name = "lblNombresNom"
        Me.lblNombresNom.Size = New System.Drawing.Size(247, 19)
        Me.lblNombresNom.TabIndex = 65
        Me.lblNombresNom.Text = "Emilio Cordoba Cuadrado Perea"
        Me.lblNombresNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocid
        '
        Me.lblDocid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocid.AutoSize = True
        Me.lblDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocid.ForeColor = System.Drawing.Color.Black
        Me.lblDocid.Location = New System.Drawing.Point(40, 106)
        Me.lblDocid.Name = "lblDocid"
        Me.lblDocid.Size = New System.Drawing.Size(116, 19)
        Me.lblDocid.TabIndex = 68
        Me.lblDocid.Text = "Documento:"
        Me.lblDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocid
        '
        Me.lblTipoDocid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoDocid.AutoSize = True
        Me.lblTipoDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocid.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocid.Location = New System.Drawing.Point(41, 130)
        Me.lblTipoDocid.Name = "lblTipoDocid"
        Me.lblTipoDocid.Size = New System.Drawing.Size(156, 19)
        Me.lblTipoDocid.TabIndex = 69
        Me.lblTipoDocid.Text = "Tipo documento:"
        Me.lblTipoDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocidNom
        '
        Me.lblTipoDocidNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoDocidNom.AutoSize = True
        Me.lblTipoDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocidNom.Location = New System.Drawing.Point(205, 130)
        Me.lblTipoDocidNom.Name = "lblTipoDocidNom"
        Me.lblTipoDocidNom.Size = New System.Drawing.Size(168, 19)
        Me.lblTipoDocidNom.TabIndex = 70
        Me.lblTipoDocidNom.Text = "Cédula de Ciudadanía"
        Me.lblTipoDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1075, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Foto del cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(50, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1199, 19)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Lista de elementos para enviar a mora"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Teléfono:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefonoNom
        '
        Me.lblTelefonoNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTelefonoNom.AutoSize = True
        Me.lblTelefonoNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoNom.ForeColor = System.Drawing.Color.Black
        Me.lblTelefonoNom.Location = New System.Drawing.Point(138, 183)
        Me.lblTelefonoNom.Name = "lblTelefonoNom"
        Me.lblTelefonoNom.Size = New System.Drawing.Size(99, 19)
        Me.lblTelefonoNom.TabIndex = 77
        Me.lblTelefonoNom.Text = "3137494630"
        Me.lblTelefonoNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(42, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 19)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Correo Electrónico:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorreoElectNom
        '
        Me.lblCorreoElectNom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCorreoElectNom.AutoSize = True
        Me.lblCorreoElectNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoElectNom.ForeColor = System.Drawing.Color.Black
        Me.lblCorreoElectNom.Location = New System.Drawing.Point(225, 208)
        Me.lblCorreoElectNom.Name = "lblCorreoElectNom"
        Me.lblCorreoElectNom.Size = New System.Drawing.Size(133, 19)
        Me.lblCorreoElectNom.TabIndex = 79
        Me.lblCorreoElectNom.Text = "hola@gmail.com"
        Me.lblCorreoElectNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(46, 588)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(519, 19)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "*El documento de respaldo deberá ingresarlo en el apartado de mora"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 16.0!
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_trash_can_64
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.ToolTipText = "Eliminar elemento de la lista"
        Me.DataGridViewImageColumn1.Width = 70
        '
        'ptbFotoCliente
        '
        Me.ptbFotoCliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbFotoCliente.BackColor = System.Drawing.Color.Transparent
        Me.ptbFotoCliente.BaseColor = System.Drawing.Color.LightGray
        Me.ptbFotoCliente.Location = New System.Drawing.Point(1077, 93)
        Me.ptbFotoCliente.Name = "ptbFotoCliente"
        Me.ptbFotoCliente.Size = New System.Drawing.Size(120, 120)
        Me.ptbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotoCliente.TabIndex = 73
        Me.ptbFotoCliente.TabStop = False
        Me.ptbFotoCliente.UseTransfarantBackground = False
        '
        'btnEnviarAMora
        '
        Me.btnEnviarAMora.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEnviarAMora.AnimationHoverSpeed = 0.07!
        Me.btnEnviarAMora.AnimationSpeed = 0.03!
        Me.btnEnviarAMora.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarAMora.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEnviarAMora.BorderColor = System.Drawing.Color.Transparent
        Me.btnEnviarAMora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarAMora.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnviarAMora.FocusedColor = System.Drawing.Color.Empty
        Me.btnEnviarAMora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarAMora.ForeColor = System.Drawing.Color.White
        Me.btnEnviarAMora.Image = Global.Appsena.My.Resources.Resources.icons8_error_64
        Me.btnEnviarAMora.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnviarAMora.Location = New System.Drawing.Point(564, 619)
        Me.btnEnviarAMora.Name = "btnEnviarAMora"
        Me.btnEnviarAMora.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarAMora.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEnviarAMora.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnviarAMora.OnHoverImage = Nothing
        Me.btnEnviarAMora.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnviarAMora.Radius = 10
        Me.btnEnviarAMora.Size = New System.Drawing.Size(152, 31)
        Me.btnEnviarAMora.TabIndex = 81
        Me.btnEnviarAMora.Text = "Enviar a mora"
        '
        'lblCodPres
        '
        Me.lblCodPres.AutoSize = True
        Me.lblCodPres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPres.ForeColor = System.Drawing.Color.Black
        Me.lblCodPres.Location = New System.Drawing.Point(441, 52)
        Me.lblCodPres.Name = "lblCodPres"
        Me.lblCodPres.Size = New System.Drawing.Size(37, 19)
        Me.lblCodPres.TabIndex = 82
        Me.lblCodPres.Text = "cod"
        Me.lblCodPres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 86
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Elemento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'clmCantidadMora
        '
        Me.clmCantidadMora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCantidadMora.FillWeight = 50.0!
        Me.clmCantidadMora.HeaderText = "Cantidad a mora"
        Me.clmCantidadMora.Name = "clmCantidadMora"
        Me.clmCantidadMora.ReadOnly = True
        Me.clmCantidadMora.Width = 152
        '
        'clmObserva
        '
        Me.clmObserva.HeaderText = "Observaciones"
        Me.clmObserva.Name = "clmObserva"
        Me.clmObserva.ReadOnly = True
        '
        'clmTipElem
        '
        Me.clmTipElem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmTipElem.HeaderText = "Tipo"
        Me.clmTipElem.Name = "clmTipElem"
        Me.clmTipElem.ReadOnly = True
        Me.clmTipElem.Width = 66
        '
        'clmestado
        '
        Me.clmestado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmestado.HeaderText = "estado"
        Me.clmestado.Name = "clmestado"
        Me.clmestado.ReadOnly = True
        Me.clmestado.Visible = False
        '
        'clmConseElement
        '
        Me.clmConseElement.HeaderText = "ConsecutivoElemen"
        Me.clmConseElement.Name = "clmConseElement"
        Me.clmConseElement.ReadOnly = True
        '
        'clmFechaPres
        '
        Me.clmFechaPres.HeaderText = "FechaPrestamo"
        Me.clmFechaPres.Name = "clmFechaPres"
        Me.clmFechaPres.ReadOnly = True
        Me.clmFechaPres.Visible = False
        '
        'clmEliminar
        '
        Me.clmEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmEliminar.FillWeight = 25.0!
        Me.clmEliminar.HeaderText = "Eliminar"
        Me.clmEliminar.Image = Global.Appsena.My.Resources.Resources.icons8_trash_can_64
        Me.clmEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmEliminar.Name = "clmEliminar"
        Me.clmEliminar.ReadOnly = True
        Me.clmEliminar.ToolTipText = "Eliminar elemento de la lista"
        '
        'frmMora_Insert_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 662)
        Me.Controls.Add(Me.lblCodPres)
        Me.Controls.Add(Me.btnEnviarAMora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCorreoElectNom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTelefonoNom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ptbFotoCliente)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblFicha)
        Me.Controls.Add(Me.lblNumFicha)
        Me.Controls.Add(Me.lblDocidNom)
        Me.Controls.Add(Me.lblNombresNom)
        Me.Controls.Add(Me.lblDocid)
        Me.Controls.Add(Me.lblTipoDocid)
        Me.Controls.Add(Me.lblTipoDocidNom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpEntradaMora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.dgvMora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlVentana)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMora_Insert_Update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMora_Insert_Update"
        Me.pnlVentana.ResumeLayout(False)
        CType(Me.dgvMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlVentana As Panel
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMora As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtObservaciones As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpEntradaMora As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ptbFotoCliente As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblFicha As Label
    Friend WithEvents lblNumFicha As Label
    Friend WithEvents lblDocidNom As Label
    Friend WithEvents lblNombresNom As Label
    Friend WithEvents lblDocid As Label
    Friend WithEvents lblTipoDocid As Label
    Friend WithEvents lblTipoDocidNom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTelefonoNom As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCorreoElectNom As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnEnviarAMora As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCodPres As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadMora As DataGridViewTextBoxColumn
    Friend WithEvents clmObserva As DataGridViewTextBoxColumn
    Friend WithEvents clmTipElem As DataGridViewTextBoxColumn
    Friend WithEvents clmestado As DataGridViewTextBoxColumn
    Friend WithEvents clmConseElement As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPres As DataGridViewTextBoxColumn
    Friend WithEvents clmEliminar As DataGridViewImageColumn
End Class
