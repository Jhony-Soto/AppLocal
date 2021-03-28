<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_ClienteDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_ClienteDetalle))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCorreoElectNom = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTelefonoNom = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ptbFotoCliente = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.lblNumFicha = New System.Windows.Forms.Label()
        Me.lblDocidNom = New System.Windows.Forms.Label()
        Me.lblNombresNom = New System.Windows.Forms.Label()
        Me.lblDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocid = New System.Windows.Forms.Label()
        Me.lblTipoDocidNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipoCliente = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 5)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 316)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1013, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 316)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 316)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1008, 5)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCircleButton1)
        Me.Panel5.Controls.Add(Me.lblTitulo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1008, 33)
        Me.Panel5.TabIndex = 5
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(975, 3)
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
        Me.lblTitulo.Size = New System.Drawing.Size(1008, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Información del cliente"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorreoElectNom
        '
        Me.lblCorreoElectNom.AutoSize = True
        Me.lblCorreoElectNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoElectNom.ForeColor = System.Drawing.Color.Black
        Me.lblCorreoElectNom.Location = New System.Drawing.Point(197, 280)
        Me.lblCorreoElectNom.Name = "lblCorreoElectNom"
        Me.lblCorreoElectNom.Size = New System.Drawing.Size(133, 19)
        Me.lblCorreoElectNom.TabIndex = 93
        Me.lblCorreoElectNom.Text = "hola@gmail.com"
        Me.lblCorreoElectNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 19)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Correo Electrónico:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefonoNom
        '
        Me.lblTelefonoNom.AutoSize = True
        Me.lblTelefonoNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoNom.ForeColor = System.Drawing.Color.Black
        Me.lblTelefonoNom.Location = New System.Drawing.Point(112, 246)
        Me.lblTelefonoNom.Name = "lblTelefonoNom"
        Me.lblTelefonoNom.Size = New System.Drawing.Size(99, 19)
        Me.lblTelefonoNom.TabIndex = 91
        Me.lblTelefonoNom.Text = "3137494630"
        Me.lblTelefonoNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Teléfono:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(767, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Foto del cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbFotoCliente
        '
        Me.ptbFotoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbFotoCliente.BackColor = System.Drawing.Color.Transparent
        Me.ptbFotoCliente.BaseColor = System.Drawing.Color.LightGray
        Me.ptbFotoCliente.Location = New System.Drawing.Point(741, 105)
        Me.ptbFotoCliente.Name = "ptbFotoCliente"
        Me.ptbFotoCliente.Size = New System.Drawing.Size(180, 180)
        Me.ptbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFotoCliente.TabIndex = 88
        Me.ptbFotoCliente.TabStop = False
        Me.ptbFotoCliente.UseTransfarantBackground = False
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.Black
        Me.lblNombres.Location = New System.Drawing.Point(15, 72)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(93, 19)
        Me.lblNombres.TabIndex = 82
        Me.lblNombres.Text = "Nombres:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFicha
        '
        Me.lblFicha.AutoSize = True
        Me.lblFicha.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.Black
        Me.lblFicha.Location = New System.Drawing.Point(15, 213)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(62, 19)
        Me.lblFicha.TabIndex = 86
        Me.lblFicha.Text = "Ficha:"
        Me.lblFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumFicha
        '
        Me.lblNumFicha.AutoSize = True
        Me.lblNumFicha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFicha.ForeColor = System.Drawing.Color.Black
        Me.lblNumFicha.Location = New System.Drawing.Point(83, 213)
        Me.lblNumFicha.Name = "lblNumFicha"
        Me.lblNumFicha.Size = New System.Drawing.Size(443, 19)
        Me.lblNumFicha.TabIndex = 87
        Me.lblNumFicha.Text = "1673552 - Analisis y Desarrollo de Sistemas de Informacion"
        Me.lblNumFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocidNom
        '
        Me.lblDocidNom.AutoSize = True
        Me.lblDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblDocidNom.Location = New System.Drawing.Point(137, 105)
        Me.lblDocidNom.Name = "lblDocidNom"
        Me.lblDocidNom.Size = New System.Drawing.Size(108, 19)
        Me.lblDocidNom.TabIndex = 81
        Me.lblDocidNom.Text = "10004512343"
        Me.lblDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombresNom
        '
        Me.lblNombresNom.AutoSize = True
        Me.lblNombresNom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblNombresNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresNom.ForeColor = System.Drawing.Color.Black
        Me.lblNombresNom.Location = New System.Drawing.Point(114, 72)
        Me.lblNombresNom.Name = "lblNombresNom"
        Me.lblNombresNom.Size = New System.Drawing.Size(247, 19)
        Me.lblNombresNom.TabIndex = 80
        Me.lblNombresNom.Text = "Emilio Cordoba Cuadrado Perea"
        Me.lblNombresNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocid
        '
        Me.lblDocid.AutoSize = True
        Me.lblDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocid.ForeColor = System.Drawing.Color.Black
        Me.lblDocid.Location = New System.Drawing.Point(15, 105)
        Me.lblDocid.Name = "lblDocid"
        Me.lblDocid.Size = New System.Drawing.Size(116, 19)
        Me.lblDocid.TabIndex = 83
        Me.lblDocid.Text = "Documento:"
        Me.lblDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocid
        '
        Me.lblTipoDocid.AutoSize = True
        Me.lblTipoDocid.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocid.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocid.Location = New System.Drawing.Point(15, 140)
        Me.lblTipoDocid.Name = "lblTipoDocid"
        Me.lblTipoDocid.Size = New System.Drawing.Size(156, 19)
        Me.lblTipoDocid.TabIndex = 84
        Me.lblTipoDocid.Text = "Tipo documento:"
        Me.lblTipoDocid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDocidNom
        '
        Me.lblTipoDocidNom.AutoSize = True
        Me.lblTipoDocidNom.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocidNom.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocidNom.Location = New System.Drawing.Point(177, 140)
        Me.lblTipoDocidNom.Name = "lblTipoDocidNom"
        Me.lblTipoDocidNom.Size = New System.Drawing.Size(168, 19)
        Me.lblTipoDocidNom.TabIndex = 85
        Me.lblTipoDocidNom.Text = "Cédula de Ciudadanía"
        Me.lblTipoDocidNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Tipo de cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoCliente
        '
        Me.lblTipoCliente.AutoSize = True
        Me.lblTipoCliente.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCliente.ForeColor = System.Drawing.Color.Black
        Me.lblTipoCliente.Location = New System.Drawing.Point(163, 175)
        Me.lblTipoCliente.Name = "lblTipoCliente"
        Me.lblTipoCliente.Size = New System.Drawing.Size(75, 19)
        Me.lblTipoCliente.TabIndex = 95
        Me.lblTipoCliente.Text = "Aprendiz"
        Me.lblTipoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMovimientos_ClienteDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 321)
        Me.Controls.Add(Me.lblTipoCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCorreoElectNom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTelefonoNom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ptbFotoCliente)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblFicha)
        Me.Controls.Add(Me.lblNumFicha)
        Me.Controls.Add(Me.lblDocidNom)
        Me.Controls.Add(Me.lblNombresNom)
        Me.Controls.Add(Me.lblDocid)
        Me.Controls.Add(Me.lblTipoDocid)
        Me.Controls.Add(Me.lblTipoDocidNom)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_ClienteDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_ClienteDetalle"
        Me.Panel5.ResumeLayout(False)
        CType(Me.ptbFotoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCorreoElectNom As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTelefonoNom As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ptbFotoCliente As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblFicha As Label
    Friend WithEvents lblNumFicha As Label
    Friend WithEvents lblDocidNom As Label
    Friend WithEvents lblNombresNom As Label
    Friend WithEvents lblDocid As Label
    Friend WithEvents lblTipoDocid As Label
    Friend WithEvents lblTipoDocidNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTipoCliente As Label
End Class
