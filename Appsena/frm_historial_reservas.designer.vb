<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_historial_reservas
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnldatos = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnbuscar = New Guna.UI.WinForms.GunaButton()
        Me.mora = New System.Windows.Forms.Label()
        Me.check_delete_usuario = New Guna.UI.WinForms.GunaCheckBox()
        Me.prestados = New System.Windows.Forms.Label()
        Me.check_prestados = New Guna.UI.WinForms.GunaCheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.check_delete_sistema = New Guna.UI.WinForms.GunaCheckBox()
        Me.btn_reporte_excel = New Guna.UI.WinForms.GunaButton()
        Me.picker_dia_final = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picker_dia_inicial = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgexportar = New System.Windows.Forms.DataGridView()
        Me.group_reservas = New Guna.UI.WinForms.GunaGroupBox()
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_reservas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'pnldatos
        '
        Me.pnldatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnldatos.AutoScroll = True
        Me.pnldatos.BackColor = System.Drawing.SystemColors.Control
        Me.pnldatos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnldatos.Location = New System.Drawing.Point(36, 140)
        Me.pnldatos.Margin = New System.Windows.Forms.Padding(5)
        Me.pnldatos.Name = "pnldatos"
        Me.pnldatos.Size = New System.Drawing.Size(1025, 621)
        Me.pnldatos.TabIndex = 0
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
        Me.btnbuscar.Location = New System.Drawing.Point(951, 83)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuscar.OnHoverImage = Nothing
        Me.btnbuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuscar.Radius = 10
        Me.btnbuscar.Size = New System.Drawing.Size(100, 28)
        Me.btnbuscar.TabIndex = 141
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'mora
        '
        Me.mora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mora.AutoSize = True
        Me.mora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mora.Location = New System.Drawing.Point(154, 42)
        Me.mora.Name = "mora"
        Me.mora.Size = New System.Drawing.Size(243, 19)
        Me.mora.TabIndex = 63
        Me.mora.Text = "Eliminadas por el administrador"
        Me.ToolTip1.SetToolTip(Me.mora, "Reservas eliminadas por el administrador")
        '
        'check_delete_usuario
        '
        Me.check_delete_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_delete_usuario.BaseColor = System.Drawing.Color.White
        Me.check_delete_usuario.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_delete_usuario.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.check_delete_usuario.FillColor = System.Drawing.Color.White
        Me.check_delete_usuario.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_delete_usuario.Location = New System.Drawing.Point(257, 64)
        Me.check_delete_usuario.Name = "check_delete_usuario"
        Me.check_delete_usuario.Size = New System.Drawing.Size(20, 20)
        Me.check_delete_usuario.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.check_delete_usuario, "Reservas eliminadas por el administrador")
        '
        'prestados
        '
        Me.prestados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prestados.AutoSize = True
        Me.prestados.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prestados.Location = New System.Drawing.Point(34, 42)
        Me.prestados.Name = "prestados"
        Me.prestados.Size = New System.Drawing.Size(97, 19)
        Me.prestados.TabIndex = 61
        Me.prestados.Text = "Reclamadas"
        Me.ToolTip1.SetToolTip(Me.prestados, "Reservas reclamadas por el cliente")
        '
        'check_prestados
        '
        Me.check_prestados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_prestados.BaseColor = System.Drawing.Color.White
        Me.check_prestados.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_prestados.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.check_prestados.FillColor = System.Drawing.Color.White
        Me.check_prestados.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_prestados.Location = New System.Drawing.Point(67, 64)
        Me.check_prestados.Name = "check_prestados"
        Me.check_prestados.Size = New System.Drawing.Size(20, 20)
        Me.check_prestados.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.check_prestados, "Reservas reclamadas por el cliente")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Eliminadas por el sistema"
        Me.ToolTip1.SetToolTip(Me.Label3, "Reservas eliminadas por el administrador")
        '
        'check_delete_sistema
        '
        Me.check_delete_sistema.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_delete_sistema.BaseColor = System.Drawing.Color.White
        Me.check_delete_sistema.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_delete_sistema.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.check_delete_sistema.FillColor = System.Drawing.Color.White
        Me.check_delete_sistema.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_delete_sistema.Location = New System.Drawing.Point(512, 64)
        Me.check_delete_sistema.Name = "check_delete_sistema"
        Me.check_delete_sistema.Size = New System.Drawing.Size(20, 20)
        Me.check_delete_sistema.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.check_delete_sistema, "Reservas eliminadas por el administrador")
        '
        'btn_reporte_excel
        '
        Me.btn_reporte_excel.AnimationHoverSpeed = 0.07!
        Me.btn_reporte_excel.AnimationSpeed = 0.03!
        Me.btn_reporte_excel.BackColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btn_reporte_excel.BorderColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reporte_excel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_reporte_excel.FocusedColor = System.Drawing.Color.Empty
        Me.btn_reporte_excel.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte_excel.ForeColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.Image = Global.Appsena.My.Resources.Resources.icons8_download_64
        Me.btn_reporte_excel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_reporte_excel.Location = New System.Drawing.Point(36, 93)
        Me.btn_reporte_excel.Name = "btn_reporte_excel"
        Me.btn_reporte_excel.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btn_reporte_excel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_reporte_excel.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.OnHoverImage = Nothing
        Me.btn_reporte_excel.OnPressedColor = System.Drawing.Color.Black
        Me.btn_reporte_excel.Radius = 10
        Me.btn_reporte_excel.Size = New System.Drawing.Size(218, 43)
        Me.btn_reporte_excel.TabIndex = 153
        Me.btn_reporte_excel.Text = "Descargar reporte"
        Me.ToolTip1.SetToolTip(Me.btn_reporte_excel, "Descargar reporte")
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
        Me.picker_dia_final.Location = New System.Drawing.Point(721, 83)
        Me.picker_dia_final.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_final.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_final.Name = "picker_dia_final"
        Me.picker_dia_final.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_final.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_final.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_final.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_final.Radius = 10
        Me.picker_dia_final.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_final.TabIndex = 40
        Me.picker_dia_final.Text = "3/12/2019"
        Me.picker_dia_final.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(758, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Fecha Final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.picker_dia_inicial.Location = New System.Drawing.Point(470, 83)
        Me.picker_dia_inicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.picker_dia_inicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.picker_dia_inicial.Name = "picker_dia_inicial"
        Me.picker_dia_inicial.OnHoverBaseColor = System.Drawing.Color.White
        Me.picker_dia_inicial.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.picker_dia_inicial.OnHoverForeColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.OnPressedColor = System.Drawing.Color.Black
        Me.picker_dia_inicial.Radius = 10
        Me.picker_dia_inicial.Size = New System.Drawing.Size(211, 28)
        Me.picker_dia_inicial.TabIndex = 42
        Me.picker_dia_inicial.Text = "3/12/2019"
        Me.picker_dia_inicial.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(492, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Fecha Inicial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(721, 19)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Seleccione dos rangos de fechas para observar las reservas hechas en el transcurs" &
    "o de esos días."
        '
        'dgexportar
        '
        Me.dgexportar.AllowUserToAddRows = False
        Me.dgexportar.AllowUserToDeleteRows = False
        Me.dgexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexportar.Location = New System.Drawing.Point(1034, 3)
        Me.dgexportar.Name = "dgexportar"
        Me.dgexportar.ReadOnly = True
        Me.dgexportar.Size = New System.Drawing.Size(39, 20)
        Me.dgexportar.TabIndex = 143
        Me.dgexportar.Visible = False
        '
        'group_reservas
        '
        Me.group_reservas.BackColor = System.Drawing.Color.Transparent
        Me.group_reservas.BaseColor = System.Drawing.Color.White
        Me.group_reservas.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_reservas.Controls.Add(Me.Label3)
        Me.group_reservas.Controls.Add(Me.check_delete_sistema)
        Me.group_reservas.Controls.Add(Me.mora)
        Me.group_reservas.Controls.Add(Me.check_delete_usuario)
        Me.group_reservas.Controls.Add(Me.prestados)
        Me.group_reservas.Controls.Add(Me.check_prestados)
        Me.group_reservas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_reservas.LineColor = System.Drawing.Color.Gainsboro
        Me.group_reservas.Location = New System.Drawing.Point(12, 3)
        Me.group_reservas.Name = "group_reservas"
        Me.group_reservas.Size = New System.Drawing.Size(669, 87)
        Me.group_reservas.TabIndex = 144
        Me.group_reservas.Text = "Seleccione que reservas desea ver."
        Me.group_reservas.TextLocation = New System.Drawing.Point(10, 8)
        '
        'frm_historial_reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1095, 788)
        Me.Controls.Add(Me.btn_reporte_excel)
        Me.Controls.Add(Me.group_reservas)
        Me.Controls.Add(Me.dgexportar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.picker_dia_inicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picker_dia_final)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnldatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_historial_reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de reservas"
        CType(Me.dgexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_reservas.ResumeLayout(False)
        Me.group_reservas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnldatos As FlowLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents picker_dia_inicial As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents picker_dia_final As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btnbuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
    Friend WithEvents dgexportar As DataGridView
    Friend WithEvents group_reservas As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents check_delete_sistema As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents mora As Label
    Friend WithEvents check_delete_usuario As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents prestados As Label
    Friend WithEvents check_prestados As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btn_reporte_excel As Guna.UI.WinForms.GunaButton
End Class
