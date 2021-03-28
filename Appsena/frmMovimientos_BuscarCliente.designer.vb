<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_BuscarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_BuscarCliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvClientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmDocid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodFicha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrograma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.txtBuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 5)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 472)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 5)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 467)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(808, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 467)
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
        Me.Panel5.Size = New System.Drawing.Size(803, 33)
        Me.Panel5.TabIndex = 4
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(770, 3)
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
        Me.lblTitulo.Size = New System.Drawing.Size(803, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Seleccionar un cliente"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDocid, Me.clmCliente, Me.clmTipoCliente, Me.clmCodFicha, Me.clmPrograma})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClientes.Location = New System.Drawing.Point(9, 156)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(796, 250)
        Me.dgvClientes.TabIndex = 61
        Me.dgvClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClientes.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvClientes.ThemeStyle.ReadOnly = True
        Me.dgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvClientes.ThemeStyle.RowsStyle.Height = 22
        Me.dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clmDocid
        '
        Me.clmDocid.FillWeight = 60.0!
        Me.clmDocid.HeaderText = "Documento"
        Me.clmDocid.Name = "clmDocid"
        Me.clmDocid.ReadOnly = True
        '
        'clmCliente
        '
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        '
        'clmTipoCliente
        '
        Me.clmTipoCliente.FillWeight = 80.0!
        Me.clmTipoCliente.HeaderText = "Tipo cliente"
        Me.clmTipoCliente.Name = "clmTipoCliente"
        Me.clmTipoCliente.ReadOnly = True
        '
        'clmCodFicha
        '
        Me.clmCodFicha.HeaderText = "CodFicha"
        Me.clmCodFicha.Name = "clmCodFicha"
        Me.clmCodFicha.ReadOnly = True
        Me.clmCodFicha.Visible = False
        '
        'clmPrograma
        '
        Me.clmPrograma.HeaderText = "Programa"
        Me.clmPrograma.Name = "clmPrograma"
        Me.clmPrograma.ReadOnly = True
        Me.clmPrograma.Visible = False
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBuscarCliente.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarCliente.Location = New System.Drawing.Point(247, 67)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(327, 28)
        Me.lblBuscarCliente.TabIndex = 64
        Me.lblBuscarCliente.Text = "Buscar un cliente"
        Me.lblBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtBuscador.BaseColor = System.Drawing.Color.White
        Me.txtBuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBuscador.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtBuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(247, 98)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscador.Radius = 10
        Me.txtBuscador.Size = New System.Drawing.Size(327, 30)
        Me.txtBuscador.TabIndex = 63
        Me.txtBuscador.Tag = "1"
        Me.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnAceptar.Location = New System.Drawing.Point(355, 424)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(110, 31)
        Me.btnAceptar.TabIndex = 62
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmMovimientos_BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 477)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_BuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_BuscarCliente"
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvClientes As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents txtBuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents clmDocid As DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents clmCodFicha As DataGridViewTextBoxColumn
    Friend WithEvents clmPrograma As DataGridViewTextBoxColumn
End Class
