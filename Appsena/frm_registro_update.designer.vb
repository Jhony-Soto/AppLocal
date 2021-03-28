<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_registro_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro_update))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnregrsar = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblheader = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnimagen = New Guna.UI.WinForms.GunaButton()
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.btnactualizar = New Guna.UI.WinForms.GunaButton()
        Me.btnficha = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnguardarficha = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdocumento = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellidos = New Guna.UI.WinForms.GunaTextBox()
        Me.txtnombres = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmovil = New Guna.UI.WinForms.GunaTextBox()
        Me.ptbFotocliente = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbtipo_documento = New Guna.UI.WinForms.GunaComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbtipocliente = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblficha = New System.Windows.Forms.Label()
        Me.lblrequire = New System.Windows.Forms.Label()
        Me.txtbuscador = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbficha = New Guna.UI.WinForms.GunaComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtficha = New Guna.UI.WinForms.GunaTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtprograma = New Guna.UI.WinForms.GunaTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pnlinsert_ficha = New Guna.UI.WinForms.GunaShadowPanel()
        Me.txttipo_cliente = New Guna.UI.WinForms.GunaTextBox()
        Me.linktipo_cliente = New System.Windows.Forms.LinkLabel()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.ptbFotocliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlinsert_ficha.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnregrsar)
        Me.GunaPanel1.Controls.Add(Me.lblheader)
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1215, 73)
        Me.GunaPanel1.TabIndex = 37
        '
        'btnregrsar
        '
        Me.btnregrsar.AnimationHoverSpeed = 0.07!
        Me.btnregrsar.AnimationSpeed = 0.03!
        Me.btnregrsar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnregrsar.BorderColor = System.Drawing.Color.Black
        Me.btnregrsar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregrsar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregrsar.FocusedColor = System.Drawing.Color.Empty
        Me.btnregrsar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnregrsar.ForeColor = System.Drawing.Color.White
        Me.btnregrsar.Image = CType(resources.GetObject("btnregrsar.Image"), System.Drawing.Image)
        Me.btnregrsar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnregrsar.Location = New System.Drawing.Point(12, 14)
        Me.btnregrsar.Name = "btnregrsar"
        Me.btnregrsar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregrsar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregrsar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregrsar.OnHoverImage = Nothing
        Me.btnregrsar.OnPressedColor = System.Drawing.Color.Black
        Me.btnregrsar.Size = New System.Drawing.Size(40, 40)
        Me.btnregrsar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnregrsar, "Regresar")
        '
        'lblheader
        '
        Me.lblheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Zurich", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.White
        Me.lblheader.Location = New System.Drawing.Point(442, 25)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(291, 22)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Registro de un nuevo cliente."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1210, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 565)
        Me.Panel1.TabIndex = 108
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1210, 5)
        Me.Panel2.TabIndex = 109
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 560)
        Me.Panel3.TabIndex = 110
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 560)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1205, 5)
        Me.Panel4.TabIndex = 111
        '
        'btnimagen
        '
        Me.btnimagen.AnimationHoverSpeed = 0.07!
        Me.btnimagen.AnimationSpeed = 0.03!
        Me.btnimagen.BackColor = System.Drawing.Color.Transparent
        Me.btnimagen.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnimagen.BorderColor = System.Drawing.Color.Black
        Me.btnimagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimagen.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnimagen.FocusedColor = System.Drawing.Color.Empty
        Me.btnimagen.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimagen.ForeColor = System.Drawing.Color.White
        Me.btnimagen.Image = Global.Appsena.My.Resources.Resources.icons8_camera_blanco_64
        Me.btnimagen.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnimagen.Location = New System.Drawing.Point(867, 371)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnimagen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnimagen.OnHoverForeColor = System.Drawing.Color.White
        Me.btnimagen.OnHoverImage = Nothing
        Me.btnimagen.OnPressedColor = System.Drawing.Color.Black
        Me.btnimagen.Radius = 10
        Me.btnimagen.Size = New System.Drawing.Size(278, 35)
        Me.btnimagen.TabIndex = 83
        Me.btnimagen.Text = "Agregar Imagen"
        Me.btnimagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnimagen, "Agregar una imagen")
        '
        'btnguardar
        '
        Me.btnguardar.AnimationHoverSpeed = 0.07!
        Me.btnguardar.AnimationSpeed = 0.03!
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnguardar.BorderColor = System.Drawing.Color.Black
        Me.btnguardar.CausesValidation = False
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardar.Location = New System.Drawing.Point(867, 412)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnguardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverImage = Nothing
        Me.btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar.Radius = 10
        Me.btnguardar.Size = New System.Drawing.Size(278, 35)
        Me.btnguardar.TabIndex = 84
        Me.btnguardar.Text = "Guardar Datos"
        Me.btnguardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnguardar, "Guardar datos")
        '
        'btnactualizar
        '
        Me.btnactualizar.AnimationHoverSpeed = 0.07!
        Me.btnactualizar.AnimationSpeed = 0.03!
        Me.btnactualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnactualizar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnactualizar.BorderColor = System.Drawing.Color.Black
        Me.btnactualizar.CausesValidation = False
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnactualizar.FocusedColor = System.Drawing.Color.Empty
        Me.btnactualizar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnactualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnactualizar.Location = New System.Drawing.Point(867, 412)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnactualizar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnactualizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnactualizar.OnHoverImage = Nothing
        Me.btnactualizar.OnPressedColor = System.Drawing.Color.Black
        Me.btnactualizar.Radius = 10
        Me.btnactualizar.Size = New System.Drawing.Size(278, 35)
        Me.btnactualizar.TabIndex = 101
        Me.btnactualizar.Text = "Actualizar Datos"
        Me.btnactualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar datos")
        Me.btnactualizar.Visible = False
        '
        'btnficha
        '
        Me.btnficha.AnimationHoverSpeed = 0.07!
        Me.btnficha.AnimationSpeed = 0.03!
        Me.btnficha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnficha.BorderColor = System.Drawing.Color.Black
        Me.btnficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnficha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnficha.FocusedColor = System.Drawing.Color.Empty
        Me.btnficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnficha.ForeColor = System.Drawing.Color.White
        Me.btnficha.Image = Nothing
        Me.btnficha.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnficha.Location = New System.Drawing.Point(723, 144)
        Me.btnficha.Name = "btnficha"
        Me.btnficha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnficha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnficha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnficha.OnHoverImage = Nothing
        Me.btnficha.OnPressedColor = System.Drawing.Color.Black
        Me.btnficha.Size = New System.Drawing.Size(30, 30)
        Me.btnficha.TabIndex = 2
        Me.btnficha.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnficha, "Agregar una ficha")
        '
        'btnguardarficha
        '
        Me.btnguardarficha.AnimationHoverSpeed = 0.07!
        Me.btnguardarficha.AnimationSpeed = 0.03!
        Me.btnguardarficha.BackColor = System.Drawing.Color.Transparent
        Me.btnguardarficha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnguardarficha.BorderColor = System.Drawing.Color.Black
        Me.btnguardarficha.CausesValidation = False
        Me.btnguardarficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardarficha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnguardarficha.FocusedColor = System.Drawing.Color.Empty
        Me.btnguardarficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarficha.ForeColor = System.Drawing.Color.White
        Me.btnguardarficha.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnguardarficha.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardarficha.Location = New System.Drawing.Point(14, 163)
        Me.btnguardarficha.Name = "btnguardarficha"
        Me.btnguardarficha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnguardarficha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnguardarficha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardarficha.OnHoverImage = Nothing
        Me.btnguardarficha.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardarficha.Radius = 10
        Me.btnguardarficha.Size = New System.Drawing.Size(180, 30)
        Me.btnguardarficha.TabIndex = 113
        Me.btnguardarficha.Text = "Guardar Datos"
        Me.btnguardarficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnguardarficha, "Guardar datos")
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Documento"
        '
        'txtdocumento
        '
        Me.txtdocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdocumento.BackColor = System.Drawing.Color.Transparent
        Me.txtdocumento.BaseColor = System.Drawing.Color.White
        Me.txtdocumento.BorderColor = System.Drawing.Color.Silver
        Me.txtdocumento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdocumento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtdocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocumento.Location = New System.Drawing.Point(118, 252)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdocumento.Radius = 10
        Me.txtdocumento.Size = New System.Drawing.Size(230, 31)
        Me.txtdocumento.TabIndex = 7
        Me.txtdocumento.Tag = "3"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "E-mail"
        '
        'txtapellidos
        '
        Me.txtapellidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapellidos.BackColor = System.Drawing.Color.Transparent
        Me.txtapellidos.BaseColor = System.Drawing.Color.White
        Me.txtapellidos.BorderColor = System.Drawing.Color.Silver
        Me.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtapellidos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtapellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtapellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtapellidos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidos.Location = New System.Drawing.Point(487, 333)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtapellidos.Radius = 10
        Me.txtapellidos.Size = New System.Drawing.Size(230, 31)
        Me.txtapellidos.TabIndex = 4
        Me.txtapellidos.Tag = "6"
        '
        'txtnombres
        '
        Me.txtnombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnombres.BackColor = System.Drawing.Color.Transparent
        Me.txtnombres.BaseColor = System.Drawing.Color.White
        Me.txtnombres.BorderColor = System.Drawing.Color.Silver
        Me.txtnombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombres.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnombres.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtnombres.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnombres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombres.Location = New System.Drawing.Point(118, 333)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombres.Radius = 10
        Me.txtnombres.Size = New System.Drawing.Size(230, 31)
        Me.txtnombres.TabIndex = 3
        Me.txtnombres.Tag = "5"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(498, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Apellidos"
        '
        'txtemail
        '
        Me.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtemail.BackColor = System.Drawing.Color.Transparent
        Me.txtemail.BaseColor = System.Drawing.Color.White
        Me.txtemail.BorderColor = System.Drawing.Color.Silver
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtemail.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(118, 422)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.Radius = 10
        Me.txtemail.Size = New System.Drawing.Size(230, 31)
        Me.txtemail.TabIndex = 5
        Me.txtemail.Tag = "7"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(498, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 19)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Teléfono móvil"
        '
        'txtmovil
        '
        Me.txtmovil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmovil.BackColor = System.Drawing.Color.Transparent
        Me.txtmovil.BaseColor = System.Drawing.Color.White
        Me.txtmovil.BorderColor = System.Drawing.Color.Silver
        Me.txtmovil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmovil.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmovil.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtmovil.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtmovil.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmovil.Location = New System.Drawing.Point(487, 422)
        Me.txtmovil.Name = "txtmovil"
        Me.txtmovil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmovil.Radius = 10
        Me.txtmovil.Size = New System.Drawing.Size(230, 31)
        Me.txtmovil.TabIndex = 6
        Me.txtmovil.Tag = "8"
        '
        'ptbFotocliente
        '
        Me.ptbFotocliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbFotocliente.BaseColor = System.Drawing.Color.White
        Me.ptbFotocliente.Location = New System.Drawing.Point(894, 140)
        Me.ptbFotocliente.Name = "ptbFotocliente"
        Me.ptbFotocliente.Size = New System.Drawing.Size(224, 224)
        Me.ptbFotocliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotocliente.TabIndex = 82
        Me.ptbFotocliente.TabStop = False
        Me.ptbFotocliente.UseTransfarantBackground = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(498, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 19)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Tipo de Documento"
        '
        'cmbtipo_documento
        '
        Me.cmbtipo_documento.BackColor = System.Drawing.Color.Transparent
        Me.cmbtipo_documento.BaseColor = System.Drawing.Color.White
        Me.cmbtipo_documento.BorderColor = System.Drawing.Color.Silver
        Me.cmbtipo_documento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo_documento.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtipo_documento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo_documento.ForeColor = System.Drawing.Color.Black
        Me.cmbtipo_documento.FormattingEnabled = True
        Me.cmbtipo_documento.Location = New System.Drawing.Point(487, 259)
        Me.cmbtipo_documento.Name = "cmbtipo_documento"
        Me.cmbtipo_documento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbtipo_documento.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtipo_documento.Radius = 10
        Me.cmbtipo_documento.Size = New System.Drawing.Size(230, 28)
        Me.cmbtipo_documento.TabIndex = 2
        Me.cmbtipo_documento.Tag = "4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(235, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(660, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 24)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(219, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 24)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(583, 308)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 24)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(195, 399)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 24)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(625, 396)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 24)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "*"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(134, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 19)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Tipo de Cliente"
        '
        'cmbtipocliente
        '
        Me.cmbtipocliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbtipocliente.BaseColor = System.Drawing.Color.White
        Me.cmbtipocliente.BorderColor = System.Drawing.Color.Silver
        Me.cmbtipocliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipocliente.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtipocliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipocliente.ForeColor = System.Drawing.Color.Black
        Me.cmbtipocliente.FormattingEnabled = True
        Me.cmbtipocliente.Location = New System.Drawing.Point(118, 176)
        Me.cmbtipocliente.Name = "cmbtipocliente"
        Me.cmbtipocliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbtipocliente.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtipocliente.Radius = 10
        Me.cmbtipocliente.Size = New System.Drawing.Size(230, 28)
        Me.cmbtipocliente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(261, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "*"
        '
        'lblficha
        '
        Me.lblficha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblficha.AutoSize = True
        Me.lblficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblficha.Location = New System.Drawing.Point(572, 124)
        Me.lblficha.Name = "lblficha"
        Me.lblficha.Size = New System.Drawing.Size(47, 19)
        Me.lblficha.TabIndex = 103
        Me.lblficha.Text = "Ficha"
        '
        'lblrequire
        '
        Me.lblrequire.AutoSize = True
        Me.lblrequire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrequire.ForeColor = System.Drawing.Color.Red
        Me.lblrequire.Location = New System.Drawing.Point(625, 124)
        Me.lblrequire.Name = "lblrequire"
        Me.lblrequire.Size = New System.Drawing.Size(18, 24)
        Me.lblrequire.TabIndex = 104
        Me.lblrequire.Text = "*"
        '
        'txtbuscador
        '
        Me.txtbuscador.BackColor = System.Drawing.Color.Transparent
        Me.txtbuscador.BaseColor = System.Drawing.Color.White
        Me.txtbuscador.BorderColor = System.Drawing.Color.Silver
        Me.txtbuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuscador.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbuscador.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtbuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbuscador.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscador.ForeColor = System.Drawing.Color.Black
        Me.txtbuscador.Location = New System.Drawing.Point(496, 146)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuscador.Radius = 10
        Me.txtbuscador.Size = New System.Drawing.Size(221, 30)
        Me.txtbuscador.TabIndex = 105
        Me.txtbuscador.Tag = "2"
        '
        'cmbficha
        '
        Me.cmbficha.BackColor = System.Drawing.Color.Transparent
        Me.cmbficha.BaseColor = System.Drawing.Color.White
        Me.cmbficha.BorderColor = System.Drawing.Color.Silver
        Me.cmbficha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbficha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbficha.FocusedColor = System.Drawing.Color.Empty
        Me.cmbficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbficha.ForeColor = System.Drawing.Color.Black
        Me.cmbficha.FormattingEnabled = True
        Me.cmbficha.Location = New System.Drawing.Point(496, 179)
        Me.cmbficha.Name = "cmbficha"
        Me.cmbficha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmbficha.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbficha.Radius = 10
        Me.cmbficha.Size = New System.Drawing.Size(221, 28)
        Me.cmbficha.TabIndex = 107
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(67, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 19)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Ficha"
        '
        'txtficha
        '
        Me.txtficha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtficha.BackColor = System.Drawing.Color.Transparent
        Me.txtficha.BaseColor = System.Drawing.Color.White
        Me.txtficha.BorderColor = System.Drawing.Color.Silver
        Me.txtficha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtficha.FocusedBaseColor = System.Drawing.Color.White
        Me.txtficha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtficha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtficha.Location = New System.Drawing.Point(14, 54)
        Me.txtficha.Name = "txtficha"
        Me.txtficha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtficha.Radius = 10
        Me.txtficha.Size = New System.Drawing.Size(180, 31)
        Me.txtficha.TabIndex = 88
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(223, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 24)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "*"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(58, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 19)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = "Programa"
        '
        'txtprograma
        '
        Me.txtprograma.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtprograma.BackColor = System.Drawing.Color.Transparent
        Me.txtprograma.BaseColor = System.Drawing.Color.White
        Me.txtprograma.BorderColor = System.Drawing.Color.Silver
        Me.txtprograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprograma.FocusedBaseColor = System.Drawing.Color.White
        Me.txtprograma.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtprograma.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtprograma.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprograma.Location = New System.Drawing.Point(14, 109)
        Me.txtprograma.Name = "txtprograma"
        Me.txtprograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprograma.Radius = 10
        Me.txtprograma.Size = New System.Drawing.Size(180, 31)
        Me.txtprograma.TabIndex = 91
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(218, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 24)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "*"
        '
        'pnlinsert_ficha
        '
        Me.pnlinsert_ficha.BackColor = System.Drawing.Color.Transparent
        Me.pnlinsert_ficha.BaseColor = System.Drawing.Color.White
        Me.pnlinsert_ficha.Controls.Add(Me.btnguardarficha)
        Me.pnlinsert_ficha.Controls.Add(Me.Label20)
        Me.pnlinsert_ficha.Controls.Add(Me.txtprograma)
        Me.pnlinsert_ficha.Controls.Add(Me.Label21)
        Me.pnlinsert_ficha.Controls.Add(Me.Label18)
        Me.pnlinsert_ficha.Controls.Add(Me.txtficha)
        Me.pnlinsert_ficha.Controls.Add(Me.Label19)
        Me.pnlinsert_ficha.Location = New System.Drawing.Point(639, 180)
        Me.pnlinsert_ficha.Name = "pnlinsert_ficha"
        Me.pnlinsert_ficha.ShadowColor = System.Drawing.Color.Black
        Me.pnlinsert_ficha.ShadowShift = 10
        Me.pnlinsert_ficha.Size = New System.Drawing.Size(210, 230)
        Me.pnlinsert_ficha.TabIndex = 112
        Me.pnlinsert_ficha.Visible = False
        '
        'txttipo_cliente
        '
        Me.txttipo_cliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttipo_cliente.BackColor = System.Drawing.Color.Transparent
        Me.txttipo_cliente.BaseColor = System.Drawing.Color.White
        Me.txttipo_cliente.BorderColor = System.Drawing.Color.Silver
        Me.txttipo_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttipo_cliente.Enabled = False
        Me.txttipo_cliente.FocusedBaseColor = System.Drawing.Color.White
        Me.txttipo_cliente.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txttipo_cliente.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttipo_cliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo_cliente.Location = New System.Drawing.Point(118, 176)
        Me.txttipo_cliente.Name = "txttipo_cliente"
        Me.txttipo_cliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttipo_cliente.Radius = 10
        Me.txttipo_cliente.Size = New System.Drawing.Size(230, 31)
        Me.txttipo_cliente.TabIndex = 113
        Me.txttipo_cliente.Tag = "1"
        Me.txttipo_cliente.Visible = False
        '
        'linktipo_cliente
        '
        Me.linktipo_cliente.AutoSize = True
        Me.linktipo_cliente.Location = New System.Drawing.Point(285, 157)
        Me.linktipo_cliente.Name = "linktipo_cliente"
        Me.linktipo_cliente.Size = New System.Drawing.Size(50, 13)
        Me.linktipo_cliente.TabIndex = 2
        Me.linktipo_cliente.TabStop = True
        Me.linktipo_cliente.Text = "Modificar"
        Me.linktipo_cliente.Visible = False
        '
        'frm_registro_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1215, 565)
        Me.Controls.Add(Me.linktipo_cliente)
        Me.Controls.Add(Me.txttipo_cliente)
        Me.Controls.Add(Me.pnlinsert_ficha)
        Me.Controls.Add(Me.btnficha)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbficha)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.lblrequire)
        Me.Controls.Add(Me.lblficha)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbtipocliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbtipo_documento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnimagen)
        Me.Controls.Add(Me.ptbFotocliente)
        Me.Controls.Add(Me.txtmovil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_registro_update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.ptbFotocliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlinsert_ficha.ResumeLayout(False)
        Me.pnlinsert_ficha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnregrsar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblheader As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents linktipo_cliente As LinkLabel
    Friend WithEvents txttipo_cliente As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnlinsert_ficha As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnguardarficha As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label20 As Label
    Friend WithEvents txtprograma As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtficha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnficha As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents cmbficha As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtbuscador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblrequire As Label
    Friend WithEvents lblficha As Label
    Friend WithEvents btnactualizar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbtipocliente As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbtipo_documento As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnimagen As Guna.UI.WinForms.GunaButton
    Friend WithEvents ptbFotocliente As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents txtmovil As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnombres As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtapellidos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdocumento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
End Class
