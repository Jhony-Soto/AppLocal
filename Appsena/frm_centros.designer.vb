<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_centros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_centros))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcentro = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New Guna.UI.WinForms.GunaTextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnactualiazar = New Guna.UI.WinForms.GunaButton()
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.cmbciudad = New Guna.UI.WinForms.GunaComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbdepartamento = New Guna.UI.WinForms.GunaComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgdatos.Location = New System.Drawing.Point(27, 162)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(849, 346)
        Me.dgdatos.TabIndex = 17
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombre del centro"
        '
        'txtcentro
        '
        Me.txtcentro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcentro.BackColor = System.Drawing.Color.Transparent
        Me.txtcentro.BaseColor = System.Drawing.Color.White
        Me.txtcentro.BorderColor = System.Drawing.Color.Silver
        Me.txtcentro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcentro.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcentro.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtcentro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcentro.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcentro.Location = New System.Drawing.Point(303, 92)
        Me.txtcentro.Name = "txtcentro"
        Me.txtcentro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcentro.Radius = 10
        Me.txtcentro.Size = New System.Drawing.Size(313, 30)
        Me.txtcentro.TabIndex = 21
        Me.txtcentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Codigo del centro"
        '
        'txtcodigo
        '
        Me.txtcodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcodigo.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigo.BaseColor = System.Drawing.Color.White
        Me.txtcodigo.BorderColor = System.Drawing.Color.Silver
        Me.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcodigo.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcodigo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtcodigo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcodigo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(36, 92)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcodigo.Radius = 10
        Me.txtcodigo.Size = New System.Drawing.Size(230, 30)
        Me.txtcodigo.TabIndex = 25
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Eliminar el Registro"
        Me.DataGridViewImageColumn1.Width = 75
        '
        'btnactualiazar
        '
        Me.btnactualiazar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnactualiazar.AnimationHoverSpeed = 0.07!
        Me.btnactualiazar.AnimationSpeed = 0.03!
        Me.btnactualiazar.BackColor = System.Drawing.Color.Transparent
        Me.btnactualiazar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnactualiazar.BorderColor = System.Drawing.Color.Transparent
        Me.btnactualiazar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualiazar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnactualiazar.FocusedColor = System.Drawing.Color.Empty
        Me.btnactualiazar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualiazar.ForeColor = System.Drawing.Color.White
        Me.btnactualiazar.Image = Global.Appsena.My.Resources.Resources.icons8_update_32
        Me.btnactualiazar.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnactualiazar.Location = New System.Drawing.Point(640, 92)
        Me.btnactualiazar.Name = "btnactualiazar"
        Me.btnactualiazar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnactualiazar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnactualiazar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnactualiazar.OnHoverImage = Nothing
        Me.btnactualiazar.OnPressedColor = System.Drawing.Color.Black
        Me.btnactualiazar.Radius = 10
        Me.btnactualiazar.Size = New System.Drawing.Size(115, 30)
        Me.btnactualiazar.TabIndex = 23
        Me.btnactualiazar.Text = "Actualizar"
        Me.ToolTip1.SetToolTip(Me.btnactualiazar, "Actualizar datos")
        Me.btnactualiazar.Visible = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnguardar.AnimationHoverSpeed = 0.07!
        Me.btnguardar.AnimationSpeed = 0.03!
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnguardar.BorderColor = System.Drawing.Color.Transparent
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardar.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnguardar.Location = New System.Drawing.Point(640, 92)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnguardar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverImage = Nothing
        Me.btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar.Radius = 10
        Me.btnguardar.Size = New System.Drawing.Size(115, 30)
        Me.btnguardar.TabIndex = 22
        Me.btnguardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnguardar, "Guardar datos")
        '
        'cmbciudad
        '
        Me.cmbciudad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbciudad.BackColor = System.Drawing.Color.Transparent
        Me.cmbciudad.BaseColor = System.Drawing.Color.White
        Me.cmbciudad.BorderColor = System.Drawing.Color.Silver
        Me.cmbciudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbciudad.FocusedColor = System.Drawing.Color.Empty
        Me.cmbciudad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbciudad.ForeColor = System.Drawing.Color.Black
        Me.cmbciudad.FormattingEnabled = True
        Me.cmbciudad.Location = New System.Drawing.Point(351, 31)
        Me.cmbciudad.Name = "cmbciudad"
        Me.cmbciudad.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbciudad.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbciudad.Radius = 10
        Me.cmbciudad.Size = New System.Drawing.Size(207, 28)
        Me.cmbciudad.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Seleccione una ciudad"
        '
        'cmbdepartamento
        '
        Me.cmbdepartamento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbdepartamento.BackColor = System.Drawing.Color.Transparent
        Me.cmbdepartamento.BaseColor = System.Drawing.Color.White
        Me.cmbdepartamento.BorderColor = System.Drawing.Color.Silver
        Me.cmbdepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdepartamento.FocusedColor = System.Drawing.Color.Empty
        Me.cmbdepartamento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdepartamento.ForeColor = System.Drawing.Color.Black
        Me.cmbdepartamento.FormattingEnabled = True
        Me.cmbdepartamento.Location = New System.Drawing.Point(36, 31)
        Me.cmbdepartamento.Name = "cmbdepartamento"
        Me.cmbdepartamento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbdepartamento.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbdepartamento.Radius = 10
        Me.cmbdepartamento.Size = New System.Drawing.Size(230, 28)
        Me.cmbdepartamento.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 19)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Seleccione departamento"
        '
        'frm_centros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(904, 532)
        Me.Controls.Add(Me.cmbdepartamento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbciudad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnactualiazar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtcentro)
        Me.Controls.Add(Me.dgdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_centros"
        Me.Text = "frm_centros"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnactualiazar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtcentro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents cmbciudad As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbdepartamento As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
