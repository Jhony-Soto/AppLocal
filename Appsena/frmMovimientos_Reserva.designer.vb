<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_Reserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Reserva))
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.dgvElementoInst = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtBuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvInstructor = New Guna.UI.WinForms.GunaDataGridView()
        Me.codReserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodFicha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.NTF = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.codReser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmElemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescontar = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvElementoInst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvInstructor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 50.0!
        Me.DataGridViewImageColumn1.HeaderText = "Entregar uno"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_handcart_64
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 50.0!
        Me.DataGridViewImageColumn2.HeaderText = "Entregar todo"
        Me.DataGridViewImageColumn2.Image = Global.Appsena.My.Resources.Resources.icons8_trolley_64
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(505, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(679, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Elementos reservados por el instructor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(143, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Buscar reserva"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAceptar.BorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Global.Appsena.My.Resources.Resources.icons8_ok_64
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(1070, 578)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(114, 31)
        Me.btnAceptar.TabIndex = 66
        Me.btnAceptar.Text = "Aceptar"
        '
        'dgvElementoInst
        '
        Me.dgvElementoInst.AllowUserToAddRows = False
        Me.dgvElementoInst.AllowUserToDeleteRows = False
        Me.dgvElementoInst.AllowUserToResizeColumns = False
        Me.dgvElementoInst.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvElementoInst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvElementoInst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvElementoInst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElementoInst.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvElementoInst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvElementoInst.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementoInst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvElementoInst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvElementoInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementoInst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codReser, Me.clmElemento, Me.clmCantidad, Me.clmCantEntrega, Me.observa, Me.clmDescontar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElementoInst.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvElementoInst.EnableHeadersVisualStyles = False
        Me.dgvElementoInst.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementoInst.Location = New System.Drawing.Point(505, 119)
        Me.dgvElementoInst.Name = "dgvElementoInst"
        Me.dgvElementoInst.ReadOnly = True
        Me.dgvElementoInst.RowHeadersVisible = False
        Me.dgvElementoInst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElementoInst.Size = New System.Drawing.Size(679, 453)
        Me.dgvElementoInst.TabIndex = 65
        Me.dgvElementoInst.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvElementoInst.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementoInst.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvElementoInst.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementoInst.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementoInst.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvElementoInst.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvElementoInst.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvElementoInst.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvElementoInst.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvElementoInst.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementoInst.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvElementoInst.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvElementoInst.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvElementoInst.ThemeStyle.ReadOnly = True
        Me.dgvElementoInst.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvElementoInst.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvElementoInst.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvElementoInst.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvElementoInst.ThemeStyle.RowsStyle.Height = 22
        Me.dgvElementoInst.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvElementoInst.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.txtBuscador.Location = New System.Drawing.Point(143, 83)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscador.Radius = 10
        Me.txtBuscador.Size = New System.Drawing.Size(245, 30)
        Me.txtBuscador.TabIndex = 64
        Me.txtBuscador.Tag = "1"
        Me.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 35)
        Me.Panel1.TabIndex = 63
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
        Me.btnCerrar.Location = New System.Drawing.Point(1164, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCerrar.OnHoverImage = Nothing
        Me.btnCerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btnCerrar.Size = New System.Drawing.Size(28, 28)
        Me.btnCerrar.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1198, 5)
        Me.Panel2.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1198, 30)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Reservas de elementos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvInstructor
        '
        Me.dgvInstructor.AllowUserToAddRows = False
        Me.dgvInstructor.AllowUserToDeleteRows = False
        Me.dgvInstructor.AllowUserToResizeColumns = False
        Me.dgvInstructor.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvInstructor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvInstructor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInstructor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvInstructor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInstructor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInstructor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInstructor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInstructor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codReserva, Me.clmCodPrestamo, Me.clmUsuario, Me.clmCodFicha})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInstructor.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInstructor.EnableHeadersVisualStyles = False
        Me.dgvInstructor.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInstructor.Location = New System.Drawing.Point(12, 119)
        Me.dgvInstructor.Name = "dgvInstructor"
        Me.dgvInstructor.ReadOnly = True
        Me.dgvInstructor.RowHeadersVisible = False
        Me.dgvInstructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstructor.Size = New System.Drawing.Size(475, 453)
        Me.dgvInstructor.TabIndex = 2
        Me.dgvInstructor.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvInstructor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInstructor.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInstructor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvInstructor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvInstructor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvInstructor.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvInstructor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInstructor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvInstructor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInstructor.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInstructor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInstructor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInstructor.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvInstructor.ThemeStyle.ReadOnly = True
        Me.dgvInstructor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInstructor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInstructor.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInstructor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvInstructor.ThemeStyle.RowsStyle.Height = 22
        Me.dgvInstructor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvInstructor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'codReserva
        '
        Me.codReserva.HeaderText = "CodReserva"
        Me.codReserva.Name = "codReserva"
        Me.codReserva.ReadOnly = True
        Me.codReserva.Visible = False
        '
        'clmCodPrestamo
        '
        Me.clmCodPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmCodPrestamo.FillWeight = 30.0!
        Me.clmCodPrestamo.HeaderText = "Hora"
        Me.clmCodPrestamo.Name = "clmCodPrestamo"
        Me.clmCodPrestamo.ReadOnly = True
        '
        'clmUsuario
        '
        Me.clmUsuario.FillWeight = 121.0722!
        Me.clmUsuario.HeaderText = "Instructor"
        Me.clmUsuario.Name = "clmUsuario"
        Me.clmUsuario.ReadOnly = True
        '
        'clmCodFicha
        '
        Me.clmCodFicha.FillWeight = 56.21208!
        Me.clmCodFicha.HeaderText = "Ficha"
        Me.clmCodFicha.Name = "clmCodFicha"
        Me.clmCodFicha.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 620)
        Me.Panel3.TabIndex = 71
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 613)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1198, 5)
        Me.Panel4.TabIndex = 72
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(1193, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 612)
        Me.Panel5.TabIndex = 73
        '
        'NTF
        '
        Me.NTF.Icon = CType(resources.GetObject("NTF.Icon"), System.Drawing.Icon)
        Me.NTF.Text = "NotifyIcon1"
        Me.NTF.Visible = True
        '
        'codReser
        '
        Me.codReser.FillWeight = 55.0!
        Me.codReser.HeaderText = "Reserva"
        Me.codReser.Name = "codReser"
        Me.codReser.ReadOnly = True
        Me.codReser.Visible = False
        '
        'clmElemento
        '
        Me.clmElemento.FillWeight = 150.0!
        Me.clmElemento.HeaderText = "Descripción"
        Me.clmElemento.Name = "clmElemento"
        Me.clmElemento.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCantidad.FillWeight = 60.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        Me.clmCantidad.Width = 97
        '
        'clmCantEntrega
        '
        Me.clmCantEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCantEntrega.HeaderText = "Entregado"
        Me.clmCantEntrega.Name = "clmCantEntrega"
        Me.clmCantEntrega.ReadOnly = True
        Me.clmCantEntrega.Width = 108
        '
        'observa
        '
        Me.observa.HeaderText = "Observaciones"
        Me.observa.Name = "observa"
        Me.observa.ReadOnly = True
        '
        'clmDescontar
        '
        Me.clmDescontar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clmDescontar.HeaderText = "Prestar"
        Me.clmDescontar.Image = Global.Appsena.My.Resources.Resources.icons8_handcart_64
        Me.clmDescontar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmDescontar.Name = "clmDescontar"
        Me.clmDescontar.ReadOnly = True
        Me.clmDescontar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmDescontar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmDescontar.Width = 84
        '
        'frmMovimientos_Reserva
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1198, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvInstructor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvElementoInst)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovimientos_Reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMovimientos_Reserva"
        CType(Me.dgvElementoInst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvInstructor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvElementoInst As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtBuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInstructor As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Public WithEvents Panel5 As Panel
    Friend WithEvents codReserva As DataGridViewTextBoxColumn
    Friend WithEvents clmCodPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmUsuario As DataGridViewTextBoxColumn
    Friend WithEvents clmCodFicha As DataGridViewTextBoxColumn
    Friend WithEvents NTF As NotifyIcon
    Friend WithEvents codReser As DataGridViewTextBoxColumn
    Friend WithEvents clmElemento As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmCantEntrega As DataGridViewTextBoxColumn
    Friend WithEvents observa As DataGridViewTextBoxColumn
    Friend WithEvents clmDescontar As DataGridViewImageColumn
End Class
