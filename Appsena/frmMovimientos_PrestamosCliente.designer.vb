<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_PrestamosCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_PrestamosCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvPrestamos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaPres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAdmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTpPresta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscar = New Guna.UI.WinForms.GunaButton()
        Me.lblNombreCLiente = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1188, 33)
        Me.Panel1.TabIndex = 53
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
        Me.lblTitulo.Text = "Prestamos de cliente"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.AllowUserToAddRows = False
        Me.dgvPrestamos.AllowUserToDeleteRows = False
        Me.dgvPrestamos.AllowUserToResizeColumns = False
        Me.dgvPrestamos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPrestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrestamos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(115, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrestamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrestamos.ColumnHeadersHeight = 28
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmPrestamo, Me.clmTipoPrestamo, Me.clmFechaPres, Me.clmEstado, Me.clmAdmin, Me.clmTpPresta})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrestamos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPrestamos.EnableHeadersVisualStyles = False
        Me.dgvPrestamos.GridColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.Location = New System.Drawing.Point(12, 147)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.ReadOnly = True
        Me.dgvPrestamos.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvPrestamos.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPrestamos.Size = New System.Drawing.Size(1174, 418)
        Me.dgvPrestamos.TabIndex = 48
        Me.dgvPrestamos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPrestamos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.GridColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrestamos.ThemeStyle.HeaderStyle.Height = 28
        Me.dgvPrestamos.ThemeStyle.ReadOnly = True
        Me.dgvPrestamos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrestamos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPrestamos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvPrestamos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrestamos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvPrestamos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvPrestamos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clmPrestamo
        '
        Me.clmPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmPrestamo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmPrestamo.FillWeight = 80.0!
        Me.clmPrestamo.HeaderText = "Movimiento"
        Me.clmPrestamo.Name = "clmPrestamo"
        Me.clmPrestamo.ReadOnly = True
        Me.clmPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmPrestamo.Width = 121
        '
        'clmTipoPrestamo
        '
        Me.clmTipoPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmTipoPrestamo.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmTipoPrestamo.HeaderText = "Tipo movimiento"
        Me.clmTipoPrestamo.Name = "clmTipoPrestamo"
        Me.clmTipoPrestamo.ReadOnly = True
        Me.clmTipoPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTipoPrestamo.Width = 157
        '
        'clmFechaPres
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmFechaPres.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmFechaPres.HeaderText = "Fecha prestamo"
        Me.clmFechaPres.Name = "clmFechaPres"
        Me.clmFechaPres.ReadOnly = True
        Me.clmFechaPres.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmEstado
        '
        Me.clmEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmEstado.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmEstado.FillWeight = 50.0!
        Me.clmEstado.HeaderText = "Estado"
        Me.clmEstado.Name = "clmEstado"
        Me.clmEstado.ReadOnly = True
        Me.clmEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmEstado.Width = 81
        '
        'clmAdmin
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmAdmin.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmAdmin.FillWeight = 120.0!
        Me.clmAdmin.HeaderText = "Administrador"
        Me.clmAdmin.Name = "clmAdmin"
        Me.clmAdmin.ReadOnly = True
        Me.clmAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTpPresta
        '
        Me.clmTpPresta.HeaderText = "CodTipoPrestamo"
        Me.clmTpPresta.Name = "clmTpPresta"
        Me.clmTpPresta.ReadOnly = True
        Me.clmTpPresta.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1178, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "*El cliente tiene más de un (1) prestamo activo. Seleccione un prestamo para ver " &
    "el detalle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1174, 19)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Prestamos activos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.AnimationHoverSpeed = 0.07!
        Me.btnBuscar.AnimationSpeed = 0.03!
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBuscar.BorderColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscar.FocusedColor = System.Drawing.Color.Empty
        Me.btnBuscar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.Appsena.My.Resources.Resources.icons8_ok_64
        Me.btnBuscar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBuscar.Location = New System.Drawing.Point(529, 573)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnBuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBuscar.OnHoverImage = Nothing
        Me.btnBuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnBuscar.Radius = 10
        Me.btnBuscar.Size = New System.Drawing.Size(140, 31)
        Me.btnBuscar.TabIndex = 62
        Me.btnBuscar.Text = "Seleccionar"
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Duplicar un prestamo")
        '
        'lblNombreCLiente
        '
        Me.lblNombreCLiente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreCLiente.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCLiente.Location = New System.Drawing.Point(12, 80)
        Me.lblNombreCLiente.Name = "lblNombreCLiente"
        Me.lblNombreCLiente.Size = New System.Drawing.Size(1174, 19)
        Me.lblNombreCLiente.TabIndex = 57
        Me.lblNombreCLiente.Text = "Nombre del cliente"
        Me.lblNombreCLiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1198, 5)
        Me.Panel2.TabIndex = 63
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1193, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 611)
        Me.Panel3.TabIndex = 64
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 611)
        Me.Panel4.TabIndex = 65
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 611)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1188, 5)
        Me.Panel5.TabIndex = 66
        '
        'frmMovimientos_PrestamosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 616)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblNombreCLiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPrestamos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_PrestamosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_PrestamosCliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPrestamos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblNombreCLiente As Label
    Friend WithEvents btnBuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents clmPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmTipoPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPres As DataGridViewTextBoxColumn
    Friend WithEvents clmEstado As DataGridViewTextBoxColumn
    Friend WithEvents clmAdmin As DataGridViewTextBoxColumn
    Friend WithEvents clmTpPresta As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
