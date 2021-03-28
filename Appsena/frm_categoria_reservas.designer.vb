<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_categoria_reservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_categoria_reservas))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clmeliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcategoria = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btncolor = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ntope = New Guna.UI.WinForms.GunaNumeric()
        Me.btnactualiazar = New Guna.UI.WinForms.GunaButton()
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.color_categoria = New System.Windows.Forms.ColorDialog()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmeliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.White
        Me.dgdatos.Location = New System.Drawing.Point(30, 200)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(720, 307)
        Me.dgdatos.TabIndex = 17
        Me.dgdatos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.GridColor = System.Drawing.Color.White
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
        Me.clmeliminar.HeaderText = "Eliminar"
        Me.clmeliminar.Image = CType(resources.GetObject("clmeliminar.Image"), System.Drawing.Image)
        Me.clmeliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmeliminar.Name = "clmeliminar"
        Me.clmeliminar.ReadOnly = True
        Me.clmeliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmeliminar.ToolTipText = "Eliminar el Registro"
        Me.clmeliminar.Width = 75
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombre de la categoria"
        '
        'txtcategoria
        '
        Me.txtcategoria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcategoria.BackColor = System.Drawing.Color.Transparent
        Me.txtcategoria.BaseColor = System.Drawing.Color.White
        Me.txtcategoria.BorderColor = System.Drawing.Color.Silver
        Me.txtcategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcategoria.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcategoria.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtcategoria.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcategoria.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategoria.Location = New System.Drawing.Point(52, 116)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcategoria.Radius = 10
        Me.txtcategoria.Size = New System.Drawing.Size(270, 30)
        Me.txtcategoria.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Elejir un color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btncolor
        '
        Me.btncolor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btncolor.AnimationHoverSpeed = 0.07!
        Me.btncolor.AnimationSpeed = 0.03!
        Me.btncolor.BackColor = System.Drawing.Color.Transparent
        Me.btncolor.BaseColor = System.Drawing.Color.Silver
        Me.btncolor.BorderColor = System.Drawing.Color.DimGray
        Me.btncolor.BorderSize = 3
        Me.btncolor.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncolor.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncolor.CheckedForeColor = System.Drawing.Color.White
        Me.btncolor.CheckedImage = CType(resources.GetObject("btncolor.CheckedImage"), System.Drawing.Image)
        Me.btncolor.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncolor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncolor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncolor.FocusedColor = System.Drawing.Color.Empty
        Me.btncolor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btncolor.ForeColor = System.Drawing.Color.White
        Me.btncolor.Image = Nothing
        Me.btncolor.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncolor.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncolor.Location = New System.Drawing.Point(360, 116)
        Me.btncolor.Name = "btncolor"
        Me.btncolor.OnHoverBaseColor = System.Drawing.Color.Empty
        Me.btncolor.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.btncolor.OnHoverForeColor = System.Drawing.Color.White
        Me.btncolor.OnHoverImage = Nothing
        Me.btncolor.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncolor.OnPressedColor = System.Drawing.Color.Black
        Me.btncolor.Radius = 10
        Me.btncolor.Size = New System.Drawing.Size(85, 30)
        Me.btncolor.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btncolor, "Elije el color el cual identificara la categoria")
        '
        'ntope
        '
        Me.ntope.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ntope.BackColor = System.Drawing.Color.Transparent
        Me.ntope.BaseColor = System.Drawing.Color.White
        Me.ntope.BorderColor = System.Drawing.Color.Silver
        Me.ntope.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ntope.ButtonForeColor = System.Drawing.Color.White
        Me.ntope.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ntope.ForeColor = System.Drawing.Color.Black
        Me.ntope.Location = New System.Drawing.Point(490, 116)
        Me.ntope.Maximum = CType(9999999, Long)
        Me.ntope.Minimum = CType(0, Long)
        Me.ntope.Name = "ntope"
        Me.ntope.Radius = 10
        Me.ntope.Size = New System.Drawing.Size(114, 30)
        Me.ntope.TabIndex = 33
        Me.ntope.Text = "GunaNumeric1"
        Me.ToolTip1.SetToolTip(Me.ntope, "Indica el tope maximo para la cantidad de elementos que se puden reservar y prest" &
        "ar para esta categoria.")
        Me.ntope.Value = CType(0, Long)
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
        Me.btnactualiazar.Location = New System.Drawing.Point(635, 116)
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
        Me.btnguardar.Location = New System.Drawing.Point(635, 116)
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
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tope "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_categoria_reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 532)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ntope)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncolor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnactualiazar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtcategoria)
        Me.Controls.Add(Me.dgdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_categoria_reservas"
        Me.Text = "frm_categoria_reservas"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents clmeliminar As DataGridViewImageColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btncolor As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnactualiazar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtcategoria As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents color_categoria As ColorDialog
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents ntope As Guna.UI.WinForms.GunaNumeric
End Class
