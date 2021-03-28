<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mora
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblsaldado = New System.Windows.Forms.Label()
        Me.btnexportar = New Guna.UI.WinForms.GunaButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblmora = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HisorialDeMorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesEnMoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgdatos.Location = New System.Drawing.Point(10, 127)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdatos.Size = New System.Drawing.Size(1261, 505)
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1008, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Buscar "
        Me.ToolTip1.SetToolTip(Me.Label1, "Busca por documento  y nombre del cliente.")
        '
        'txtbuscador
        '
        Me.txtbuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtbuscador.BaseColor = System.Drawing.Color.White
        Me.txtbuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbuscador.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbuscador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscador.ForeColor = System.Drawing.Color.Black
        Me.txtbuscador.Location = New System.Drawing.Point(823, 82)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(406, 30)
        Me.txtbuscador.TabIndex = 35
        Me.txtbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblsaldado
        '
        Me.lblsaldado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblsaldado.AutoSize = True
        Me.lblsaldado.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldado.ForeColor = System.Drawing.Color.Black
        Me.lblsaldado.Location = New System.Drawing.Point(355, 73)
        Me.lblsaldado.Name = "lblsaldado"
        Me.lblsaldado.Size = New System.Drawing.Size(189, 25)
        Me.lblsaldado.TabIndex = 62
        Me.lblsaldado.Text = "Historial de moras" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.lblsaldado, "Estos elementos ya fueron entregados en buen estado por el cliente.")
        Me.lblsaldado.Visible = False
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
        Me.btnexportar.Location = New System.Drawing.Point(12, 73)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnexportar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnexportar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnexportar.OnHoverImage = Nothing
        Me.btnexportar.OnPressedColor = System.Drawing.Color.Black
        Me.btnexportar.Radius = 10
        Me.btnexportar.Size = New System.Drawing.Size(218, 43)
        Me.btnexportar.TabIndex = 152
        Me.btnexportar.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btnexportar, "Descargar reporte")
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = "Retirar"
        Me.DataGridViewImageColumn1.Image = Global.Appsena.My.Resources.Resources.icons8_delete_bin_321
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "Retirar cliente de la mora."
        Me.DataGridViewImageColumn1.Width = 70
        '
        'lblmora
        '
        Me.lblmora.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblmora.AutoSize = True
        Me.lblmora.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmora.ForeColor = System.Drawing.Color.Black
        Me.lblmora.Location = New System.Drawing.Point(355, 73)
        Me.lblmora.Name = "lblmora"
        Me.lblmora.Size = New System.Drawing.Size(176, 25)
        Me.lblmora.TabIndex = 64
        Me.lblmora.Text = "Clientes en mora"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(298, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 5)
        Me.Panel1.TabIndex = 65
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIONESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1281, 27)
        Me.MenuStrip1.TabIndex = 150
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HisorialDeMorasToolStripMenuItem, Me.ClientesEnMoraToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCIONESToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_bulleted_list_32
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(118, 23)
        Me.OPCIONESToolStripMenuItem.Text = "OPCIONES"
        '
        'HisorialDeMorasToolStripMenuItem
        '
        Me.HisorialDeMorasToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_order_history_64
        Me.HisorialDeMorasToolStripMenuItem.Name = "HisorialDeMorasToolStripMenuItem"
        Me.HisorialDeMorasToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.HisorialDeMorasToolStripMenuItem.Text = "Historial de moras"
        '
        'ClientesEnMoraToolStripMenuItem
        '
        Me.ClientesEnMoraToolStripMenuItem.Image = Global.Appsena.My.Resources.Resources.icons8_download_resume_64
        Me.ClientesEnMoraToolStripMenuItem.Name = "ClientesEnMoraToolStripMenuItem"
        Me.ClientesEnMoraToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.ClientesEnMoraToolStripMenuItem.Text = "Clientes en mora"
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(485, 33)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(351, 14)
        Me.dgexportar.TabIndex = 153
        Me.dgexportar.Visible = False
        '
        'frm_mora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1281, 655)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblmora)
        Me.Controls.Add(Me.lblsaldado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_mora"
        Me.Text = "Mora"
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents lblsaldado As Label
    Friend WithEvents lblmora As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HisorialDeMorasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesEnMoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnexportar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgexportar As DataGridView

End Class
