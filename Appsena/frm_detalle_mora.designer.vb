<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_detalle_mora
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_detalle_mora))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnregrsar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.check_entregados = New Guna.UI.WinForms.GunaCheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.activos = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnregrsar)
        Me.Panel1.Controls.Add(Me.lblcliente)
        Me.Panel1.Controls.Add(Me.lblheader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 55)
        Me.Panel1.TabIndex = 33
        '
        'btnregrsar
        '
        Me.btnregrsar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnregrsar.AnimationHoverSpeed = 0.07!
        Me.btnregrsar.AnimationSpeed = 0.03!
        Me.btnregrsar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnregrsar.BorderColor = System.Drawing.Color.Black
        Me.btnregrsar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregrsar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregrsar.FocusedColor = System.Drawing.Color.Empty
        Me.btnregrsar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnregrsar.ForeColor = System.Drawing.Color.White
        Me.btnregrsar.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.btnregrsar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnregrsar.Location = New System.Drawing.Point(986, 13)
        Me.btnregrsar.Name = "btnregrsar"
        Me.btnregrsar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregrsar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnregrsar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregrsar.OnHoverImage = Nothing
        Me.btnregrsar.OnPressedColor = System.Drawing.Color.Red
        Me.btnregrsar.Size = New System.Drawing.Size(28, 28)
        Me.btnregrsar.TabIndex = 146
        Me.ToolTip1.SetToolTip(Me.btnregrsar, "Cerrar")
        '
        'lblcliente
        '
        Me.lblcliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblcliente.Location = New System.Drawing.Point(440, 13)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(244, 25)
        Me.lblcliente.TabIndex = 20
        Me.lblcliente.Text = "Jose daniel gutierrez"
        '
        'lblheader
        '
        Me.lblheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.White
        Me.lblheader.Location = New System.Drawing.Point(65, 16)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(369, 25)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Detalle  de mora  para el cliente"
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
        Me.btnexportar.Location = New System.Drawing.Point(29, 61)
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
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte")
        '
        'check_entregados
        '
        Me.check_entregados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_entregados.BaseColor = System.Drawing.Color.White
        Me.check_entregados.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_entregados.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.check_entregados.FillColor = System.Drawing.Color.White
        Me.check_entregados.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_entregados.Location = New System.Drawing.Point(802, 73)
        Me.check_entregados.Name = "check_entregados"
        Me.check_entregados.Size = New System.Drawing.Size(20, 20)
        Me.check_entregados.TabIndex = 148
        Me.ToolTip1.SetToolTip(Me.check_entregados, "Ver elementos entregados")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1400, 5)
        Me.Panel2.TabIndex = 142
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 310)
        Me.Panel3.TabIndex = 143
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 309)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1029, 5)
        Me.Panel4.TabIndex = 144
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
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
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
        Me.dgdatos.Location = New System.Drawing.Point(29, 109)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(974, 187)
        Me.dgdatos.TabIndex = 147
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
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Sacar"
        Me.Column1.Image = Global.Appsena.My.Resources.Resources.return_32
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Respaldo"
        Me.Column2.Image = Global.Appsena.My.Resources.Resources.icons8_pdf_32
        Me.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 80
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = "Sacar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.return_32
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Respaldo"
        Me.DataGridViewImageColumn2.Image = Global.Appsena.My.Resources.Resources.icons8_pdf_32
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 924
        '
        'activos
        '
        Me.activos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.activos.AutoSize = True
        Me.activos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activos.Location = New System.Drawing.Point(828, 74)
        Me.activos.Name = "activos"
        Me.activos.Size = New System.Drawing.Size(175, 19)
        Me.activos.TabIndex = 149
        Me.activos.Text = "Elementos entregados"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Location = New System.Drawing.Point(1023, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 307)
        Me.Panel5.TabIndex = 0
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(279, 68)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(240, 35)
        Me.dgexportar.TabIndex = 154
        Me.dgexportar.Visible = False
        '
        'frm_detalle_mora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 314)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.activos)
        Me.Controls.Add(Me.check_entregados)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_detalle_mora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de mora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblcliente As Label
    Friend WithEvents lblheader As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnregrsar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents activos As Label
    Friend WithEvents check_entregados As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
End Class
