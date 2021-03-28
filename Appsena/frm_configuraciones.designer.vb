<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_configuraciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelconfiguraciones = New System.Windows.Forms.Panel()
        Me.color_categoria = New System.Windows.Forms.ColorDialog()
        Me.btn_backup = New Guna.UI.WinForms.GunaButton()
        Me.btnrutas = New Guna.UI.WinForms.GunaButton()
        Me.btncategoria_reserva = New Guna.UI.WinForms.GunaButton()
        Me.btncentros = New Guna.UI.WinForms.GunaButton()
        Me.btncategorias = New Guna.UI.WinForms.GunaButton()
        Me.btntipoclientes = New Guna.UI.WinForms.GunaButton()
        Me.btntipodocumento = New Guna.UI.WinForms.GunaButton()
        Me.btntipoelementos = New Guna.UI.WinForms.GunaButton()
        Me.btntipoprestamo = New Guna.UI.WinForms.GunaButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'panelconfiguraciones
        '
        Me.panelconfiguraciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelconfiguraciones.BackColor = System.Drawing.SystemColors.Control
        Me.panelconfiguraciones.Location = New System.Drawing.Point(324, 12)
        Me.panelconfiguraciones.Name = "panelconfiguraciones"
        Me.panelconfiguraciones.Size = New System.Drawing.Size(650, 588)
        Me.panelconfiguraciones.TabIndex = 20
        '
        'btn_backup
        '
        Me.btn_backup.AnimationHoverSpeed = 0.07!
        Me.btn_backup.AnimationSpeed = 0.03!
        Me.btn_backup.BackColor = System.Drawing.Color.Transparent
        Me.btn_backup.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backup.BorderColor = System.Drawing.Color.Transparent
        Me.btn_backup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_backup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_backup.FocusedColor = System.Drawing.Color.Empty
        Me.btn_backup.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.ForeColor = System.Drawing.Color.Black
        Me.btn_backup.Image = Global.Appsena.My.Resources.Resources.icons8_database_view_64
        Me.btn_backup.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_backup.Location = New System.Drawing.Point(48, 529)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btn_backup.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_backup.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_backup.OnHoverImage = Nothing
        Me.btn_backup.OnPressedColor = System.Drawing.Color.Black
        Me.btn_backup.Radius = 10
        Me.btn_backup.Size = New System.Drawing.Size(237, 42)
        Me.btn_backup.TabIndex = 23
        Me.btn_backup.Text = "Copia de seguridad"
        Me.ToolTip1.SetToolTip(Me.btn_backup, "Configurar y generar copia de seguridad")
        Me.btn_backup.Visible = False
        '
        'btnrutas
        '
        Me.btnrutas.AnimationHoverSpeed = 0.07!
        Me.btnrutas.AnimationSpeed = 0.03!
        Me.btnrutas.BackColor = System.Drawing.Color.Transparent
        Me.btnrutas.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btnrutas.BorderColor = System.Drawing.Color.Transparent
        Me.btnrutas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrutas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnrutas.FocusedColor = System.Drawing.Color.Empty
        Me.btnrutas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrutas.ForeColor = System.Drawing.Color.Black
        Me.btnrutas.Image = Global.Appsena.My.Resources.Resources.icons8_download_resume_64
        Me.btnrutas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnrutas.Location = New System.Drawing.Point(48, 460)
        Me.btnrutas.Name = "btnrutas"
        Me.btnrutas.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btnrutas.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnrutas.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnrutas.OnHoverImage = Nothing
        Me.btnrutas.OnPressedColor = System.Drawing.Color.Black
        Me.btnrutas.Radius = 10
        Me.btnrutas.Size = New System.Drawing.Size(237, 42)
        Me.btnrutas.TabIndex = 22
        Me.btnrutas.Text = "Rutas"
        Me.ToolTip1.SetToolTip(Me.btnrutas, "Rutas de carpetas")
        '
        'btncategoria_reserva
        '
        Me.btncategoria_reserva.AnimationHoverSpeed = 0.07!
        Me.btncategoria_reserva.AnimationSpeed = 0.03!
        Me.btncategoria_reserva.BackColor = System.Drawing.Color.Transparent
        Me.btncategoria_reserva.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btncategoria_reserva.BorderColor = System.Drawing.Color.Transparent
        Me.btncategoria_reserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncategoria_reserva.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncategoria_reserva.FocusedColor = System.Drawing.Color.Empty
        Me.btncategoria_reserva.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoria_reserva.ForeColor = System.Drawing.Color.Black
        Me.btncategoria_reserva.Image = Global.Appsena.My.Resources.Resources.icons8_booking_641
        Me.btncategoria_reserva.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncategoria_reserva.Location = New System.Drawing.Point(48, 400)
        Me.btncategoria_reserva.Name = "btncategoria_reserva"
        Me.btncategoria_reserva.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btncategoria_reserva.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncategoria_reserva.OnHoverForeColor = System.Drawing.Color.Black
        Me.btncategoria_reserva.OnHoverImage = Nothing
        Me.btncategoria_reserva.OnPressedColor = System.Drawing.Color.Black
        Me.btncategoria_reserva.Radius = 10
        Me.btncategoria_reserva.Size = New System.Drawing.Size(237, 42)
        Me.btncategoria_reserva.TabIndex = 21
        Me.btncategoria_reserva.Text = "Categoria de reservas"
        Me.ToolTip1.SetToolTip(Me.btncategoria_reserva, "Categoria de reservas")
        '
        'btncentros
        '
        Me.btncentros.AnimationHoverSpeed = 0.07!
        Me.btncentros.AnimationSpeed = 0.03!
        Me.btncentros.BackColor = System.Drawing.Color.Transparent
        Me.btncentros.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btncentros.BorderColor = System.Drawing.Color.Transparent
        Me.btncentros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncentros.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncentros.FocusedColor = System.Drawing.Color.Empty
        Me.btncentros.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncentros.ForeColor = System.Drawing.Color.Black
        Me.btncentros.Image = Global.Appsena.My.Resources.Resources.icons8_museum_64
        Me.btncentros.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncentros.Location = New System.Drawing.Point(48, 340)
        Me.btncentros.Name = "btncentros"
        Me.btncentros.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btncentros.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncentros.OnHoverForeColor = System.Drawing.Color.Black
        Me.btncentros.OnHoverImage = Nothing
        Me.btncentros.OnPressedColor = System.Drawing.Color.Black
        Me.btncentros.Radius = 10
        Me.btncentros.Size = New System.Drawing.Size(237, 42)
        Me.btncentros.TabIndex = 19
        Me.btncentros.Text = "Centros de formación "
        Me.ToolTip1.SetToolTip(Me.btncentros, "Centros de formación")
        '
        'btncategorias
        '
        Me.btncategorias.AnimationHoverSpeed = 0.07!
        Me.btncategorias.AnimationSpeed = 0.03!
        Me.btncategorias.BackColor = System.Drawing.Color.Transparent
        Me.btncategorias.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btncategorias.BorderColor = System.Drawing.Color.Transparent
        Me.btncategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncategorias.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncategorias.FocusedColor = System.Drawing.Color.Empty
        Me.btncategorias.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategorias.ForeColor = System.Drawing.Color.Black
        Me.btncategorias.Image = Global.Appsena.My.Resources.Resources.icons8_maintenance_642
        Me.btncategorias.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncategorias.Location = New System.Drawing.Point(48, 280)
        Me.btncategorias.Name = "btncategorias"
        Me.btncategorias.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btncategorias.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncategorias.OnHoverForeColor = System.Drawing.Color.Black
        Me.btncategorias.OnHoverImage = Nothing
        Me.btncategorias.OnPressedColor = System.Drawing.Color.Black
        Me.btncategorias.Radius = 10
        Me.btncategorias.Size = New System.Drawing.Size(237, 42)
        Me.btncategorias.TabIndex = 18
        Me.btncategorias.Text = "Categorias de elementos"
        Me.ToolTip1.SetToolTip(Me.btncategorias, "Categoria de elementos")
        '
        'btntipoclientes
        '
        Me.btntipoclientes.AnimationHoverSpeed = 0.07!
        Me.btntipoclientes.AnimationSpeed = 0.03!
        Me.btntipoclientes.BackColor = System.Drawing.Color.Transparent
        Me.btntipoclientes.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btntipoclientes.BorderColor = System.Drawing.Color.Transparent
        Me.btntipoclientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntipoclientes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btntipoclientes.FocusedColor = System.Drawing.Color.Empty
        Me.btntipoclientes.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipoclientes.ForeColor = System.Drawing.Color.Black
        Me.btntipoclientes.Image = Global.Appsena.My.Resources.Resources.icons8_user_folder_64
        Me.btntipoclientes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btntipoclientes.Location = New System.Drawing.Point(48, 220)
        Me.btntipoclientes.Name = "btntipoclientes"
        Me.btntipoclientes.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btntipoclientes.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btntipoclientes.OnHoverForeColor = System.Drawing.Color.Black
        Me.btntipoclientes.OnHoverImage = Nothing
        Me.btntipoclientes.OnPressedColor = System.Drawing.Color.Black
        Me.btntipoclientes.Radius = 10
        Me.btntipoclientes.Size = New System.Drawing.Size(237, 42)
        Me.btntipoclientes.TabIndex = 16
        Me.btntipoclientes.Text = "Tipo de clientes"
        Me.ToolTip1.SetToolTip(Me.btntipoclientes, "Tipo de clientes")
        '
        'btntipodocumento
        '
        Me.btntipodocumento.AnimationHoverSpeed = 0.07!
        Me.btntipodocumento.AnimationSpeed = 0.03!
        Me.btntipodocumento.BackColor = System.Drawing.Color.Transparent
        Me.btntipodocumento.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btntipodocumento.BorderColor = System.Drawing.Color.Transparent
        Me.btntipodocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntipodocumento.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btntipodocumento.FocusedColor = System.Drawing.Color.Empty
        Me.btntipodocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipodocumento.ForeColor = System.Drawing.Color.Black
        Me.btntipodocumento.Image = Global.Appsena.My.Resources.Resources.icons8_document_64
        Me.btntipodocumento.ImageSize = New System.Drawing.Size(20, 20)
        Me.btntipodocumento.Location = New System.Drawing.Point(48, 160)
        Me.btntipodocumento.Name = "btntipodocumento"
        Me.btntipodocumento.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btntipodocumento.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btntipodocumento.OnHoverForeColor = System.Drawing.Color.Black
        Me.btntipodocumento.OnHoverImage = Nothing
        Me.btntipodocumento.OnPressedColor = System.Drawing.Color.Black
        Me.btntipodocumento.Radius = 10
        Me.btntipodocumento.Size = New System.Drawing.Size(237, 42)
        Me.btntipodocumento.TabIndex = 15
        Me.btntipodocumento.Text = "Tipo de documentos"
        Me.ToolTip1.SetToolTip(Me.btntipodocumento, "Tipos de documentos")
        '
        'btntipoelementos
        '
        Me.btntipoelementos.AnimationHoverSpeed = 0.07!
        Me.btntipoelementos.AnimationSpeed = 0.03!
        Me.btntipoelementos.BackColor = System.Drawing.Color.Transparent
        Me.btntipoelementos.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btntipoelementos.BorderColor = System.Drawing.Color.Transparent
        Me.btntipoelementos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntipoelementos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btntipoelementos.FocusedColor = System.Drawing.Color.Empty
        Me.btntipoelementos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipoelementos.ForeColor = System.Drawing.Color.Black
        Me.btntipoelementos.Image = Global.Appsena.My.Resources.Resources.icons8_maintenance_642
        Me.btntipoelementos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btntipoelementos.Location = New System.Drawing.Point(48, 100)
        Me.btntipoelementos.Name = "btntipoelementos"
        Me.btntipoelementos.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btntipoelementos.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btntipoelementos.OnHoverForeColor = System.Drawing.Color.Black
        Me.btntipoelementos.OnHoverImage = Nothing
        Me.btntipoelementos.OnPressedColor = System.Drawing.Color.Black
        Me.btntipoelementos.Radius = 10
        Me.btntipoelementos.Size = New System.Drawing.Size(237, 42)
        Me.btntipoelementos.TabIndex = 14
        Me.btntipoelementos.Text = "Tipos de elementos"
        Me.ToolTip1.SetToolTip(Me.btntipoelementos, "Tipos de elementos")
        '
        'btntipoprestamo
        '
        Me.btntipoprestamo.AnimationHoverSpeed = 0.07!
        Me.btntipoprestamo.AnimationSpeed = 0.03!
        Me.btntipoprestamo.BackColor = System.Drawing.Color.Transparent
        Me.btntipoprestamo.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btntipoprestamo.BorderColor = System.Drawing.Color.Transparent
        Me.btntipoprestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntipoprestamo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btntipoprestamo.FocusedColor = System.Drawing.Color.Empty
        Me.btntipoprestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipoprestamo.ForeColor = System.Drawing.Color.Black
        Me.btntipoprestamo.Image = Global.Appsena.My.Resources.Resources.icons8_data_transfer_64
        Me.btntipoprestamo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btntipoprestamo.Location = New System.Drawing.Point(48, 40)
        Me.btntipoprestamo.Name = "btntipoprestamo"
        Me.btntipoprestamo.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btntipoprestamo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btntipoprestamo.OnHoverForeColor = System.Drawing.Color.Black
        Me.btntipoprestamo.OnHoverImage = Nothing
        Me.btntipoprestamo.OnPressedColor = System.Drawing.Color.Black
        Me.btntipoprestamo.Radius = 10
        Me.btntipoprestamo.Size = New System.Drawing.Size(237, 42)
        Me.btntipoprestamo.TabIndex = 12
        Me.btntipoprestamo.Text = "Tipo de prestamo"
        Me.ToolTip1.SetToolTip(Me.btntipoprestamo, "Tipos de prestamos que hace el sistemas")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(986, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'frm_configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(986, 612)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.btnrutas)
        Me.Controls.Add(Me.btncategoria_reserva)
        Me.Controls.Add(Me.panelconfiguraciones)
        Me.Controls.Add(Me.btncentros)
        Me.Controls.Add(Me.btncategorias)
        Me.Controls.Add(Me.btntipoclientes)
        Me.Controls.Add(Me.btntipodocumento)
        Me.Controls.Add(Me.btntipoelementos)
        Me.Controls.Add(Me.btntipoprestamo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_configuraciones"
        Me.Text = "Configuración general"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btntipoprestamo As Guna.UI.WinForms.GunaButton
    Friend WithEvents btntipoclientes As Guna.UI.WinForms.GunaButton
    Friend WithEvents btntipodocumento As Guna.UI.WinForms.GunaButton
    Friend WithEvents btntipoelementos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btncategorias As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btncentros As Guna.UI.WinForms.GunaButton
    Friend WithEvents panelconfiguraciones As Panel
    Friend WithEvents btncategoria_reserva As Guna.UI.WinForms.GunaButton
    Friend WithEvents color_categoria As ColorDialog
    Friend WithEvents btnrutas As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_backup As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
