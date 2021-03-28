<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_configuracion_inicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_configuracion_inicial))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btncontinuar = New Guna.UI.WinForms.GunaButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.linkpdf = New System.Windows.Forms.LinkLabel()
        Me.linkpermisos = New System.Windows.Forms.LinkLabel()
        Me.linkadmin = New System.Windows.Forms.LinkLabel()
        Me.linkclientes = New System.Windows.Forms.LinkLabel()
        Me.linkelementos = New System.Windows.Forms.LinkLabel()
        Me.link_salidas = New System.Windows.Forms.LinkLabel()
        Me.link_seguros = New System.Windows.Forms.LinkLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_seguros = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_salidas = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbackup = New Guna.UI.WinForms.GunaTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtpdf = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpermisos = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtadministradores = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtclientes = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtelementos = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.cmbcentro = New Guna.UI.WinForms.GunaComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbciudad = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdepartamento = New Guna.UI.WinForms.GunaComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 51)
        Me.Panel1.TabIndex = 0
        '
        'btncontinuar
        '
        Me.btncontinuar.AnimationHoverSpeed = 0.07!
        Me.btncontinuar.AnimationSpeed = 0.03!
        Me.btncontinuar.BackColor = System.Drawing.Color.Transparent
        Me.btncontinuar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btncontinuar.BorderColor = System.Drawing.Color.Black
        Me.btncontinuar.CausesValidation = False
        Me.btncontinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncontinuar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncontinuar.FocusedColor = System.Drawing.Color.Empty
        Me.btncontinuar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontinuar.ForeColor = System.Drawing.Color.White
        Me.btncontinuar.Image = Nothing
        Me.btncontinuar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncontinuar.Location = New System.Drawing.Point(477, 745)
        Me.btncontinuar.Name = "btncontinuar"
        Me.btncontinuar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btncontinuar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncontinuar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncontinuar.OnHoverImage = Nothing
        Me.btncontinuar.OnPressedColor = System.Drawing.Color.Black
        Me.btncontinuar.Radius = 10
        Me.btncontinuar.Size = New System.Drawing.Size(278, 35)
        Me.btncontinuar.TabIndex = 111
        Me.btncontinuar.Text = "Continuar"
        Me.btncontinuar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btncontinuar, "Continuar")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(777, 319)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 19)
        Me.LinkLabel1.TabIndex = 163
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Abrir explorador de archivo")
        '
        'linkpdf
        '
        Me.linkpdf.AutoSize = True
        Me.linkpdf.Location = New System.Drawing.Point(366, 320)
        Me.linkpdf.Name = "linkpdf"
        Me.linkpdf.Size = New System.Drawing.Size(58, 19)
        Me.linkpdf.TabIndex = 161
        Me.linkpdf.TabStop = True
        Me.linkpdf.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.linkpdf, "Abrir explorador de archivo")
        '
        'linkpermisos
        '
        Me.linkpermisos.AutoSize = True
        Me.linkpermisos.Location = New System.Drawing.Point(656, 245)
        Me.linkpermisos.Name = "linkpermisos"
        Me.linkpermisos.Size = New System.Drawing.Size(58, 19)
        Me.linkpermisos.TabIndex = 158
        Me.linkpermisos.TabStop = True
        Me.linkpermisos.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.linkpermisos, "Abrir explorador de archivo")
        '
        'linkadmin
        '
        Me.linkadmin.AutoSize = True
        Me.linkadmin.Location = New System.Drawing.Point(290, 245)
        Me.linkadmin.Name = "linkadmin"
        Me.linkadmin.Size = New System.Drawing.Size(58, 19)
        Me.linkadmin.TabIndex = 157
        Me.linkadmin.TabStop = True
        Me.linkadmin.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.linkadmin, "Abrir explorador de archivo")
        '
        'linkclientes
        '
        Me.linkclientes.AutoSize = True
        Me.linkclientes.Location = New System.Drawing.Point(645, 165)
        Me.linkclientes.Name = "linkclientes"
        Me.linkclientes.Size = New System.Drawing.Size(58, 19)
        Me.linkclientes.TabIndex = 156
        Me.linkclientes.TabStop = True
        Me.linkclientes.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.linkclientes, "Abrir explorador de archivo")
        '
        'linkelementos
        '
        Me.linkelementos.AutoSize = True
        Me.linkelementos.Location = New System.Drawing.Point(245, 165)
        Me.linkelementos.Name = "linkelementos"
        Me.linkelementos.Size = New System.Drawing.Size(58, 19)
        Me.linkelementos.TabIndex = 155
        Me.linkelementos.TabStop = True
        Me.linkelementos.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.linkelementos, "Abrir explorador de archivo")
        '
        'link_salidas
        '
        Me.link_salidas.AutoSize = True
        Me.link_salidas.Location = New System.Drawing.Point(310, 384)
        Me.link_salidas.Name = "link_salidas"
        Me.link_salidas.Size = New System.Drawing.Size(58, 19)
        Me.link_salidas.TabIndex = 170
        Me.link_salidas.TabStop = True
        Me.link_salidas.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.link_salidas, "Abrir explorador de archivo")
        '
        'link_seguros
        '
        Me.link_seguros.AutoSize = True
        Me.link_seguros.Location = New System.Drawing.Point(672, 384)
        Me.link_seguros.Name = "link_seguros"
        Me.link_seguros.Size = New System.Drawing.Size(58, 19)
        Me.link_seguros.TabIndex = 167
        Me.link_seguros.TabStop = True
        Me.link_seguros.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.link_seguros, "Abrir explorador de archivo")
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.link_salidas)
        Me.GunaGroupBox1.Controls.Add(Me.Label12)
        Me.GunaGroupBox1.Controls.Add(Me.txt_seguros)
        Me.GunaGroupBox1.Controls.Add(Me.link_seguros)
        Me.GunaGroupBox1.Controls.Add(Me.Label13)
        Me.GunaGroupBox1.Controls.Add(Me.txt_salidas)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.txtbackup)
        Me.GunaGroupBox1.Controls.Add(Me.linkpdf)
        Me.GunaGroupBox1.Controls.Add(Me.Label11)
        Me.GunaGroupBox1.Controls.Add(Me.txtpdf)
        Me.GunaGroupBox1.Controls.Add(Me.linkpermisos)
        Me.GunaGroupBox1.Controls.Add(Me.linkadmin)
        Me.GunaGroupBox1.Controls.Add(Me.linkclientes)
        Me.GunaGroupBox1.Controls.Add(Me.linkelementos)
        Me.GunaGroupBox1.Controls.Add(Me.Label10)
        Me.GunaGroupBox1.Controls.Add(Me.txtpermisos)
        Me.GunaGroupBox1.Controls.Add(Me.Label8)
        Me.GunaGroupBox1.Controls.Add(Me.txtadministradores)
        Me.GunaGroupBox1.Controls.Add(Me.Label7)
        Me.GunaGroupBox1.Controls.Add(Me.txtclientes)
        Me.GunaGroupBox1.Controls.Add(Me.Label6)
        Me.GunaGroupBox1.Controls.Add(Me.txtelementos)
        Me.GunaGroupBox1.Controls.Add(Me.Label5)
        Me.GunaGroupBox1.Controls.Add(Me.Label4)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(186, 264)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(861, 462)
        Me.GunaGroupBox1.TabIndex = 119
        Me.GunaGroupBox1.Text = "2. Ruta de carpetas."
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(465, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 19)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Carpeta de  seguros (URL)"
        '
        'txt_seguros
        '
        Me.txt_seguros.BackColor = System.Drawing.Color.Transparent
        Me.txt_seguros.BaseColor = System.Drawing.Color.White
        Me.txt_seguros.BorderColor = System.Drawing.Color.Silver
        Me.txt_seguros.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_seguros.Enabled = False
        Me.txt_seguros.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_seguros.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txt_seguros.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_seguros.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_seguros.Location = New System.Drawing.Point(455, 406)
        Me.txt_seguros.Name = "txt_seguros"
        Me.txt_seguros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_seguros.Radius = 10
        Me.txt_seguros.Size = New System.Drawing.Size(380, 30)
        Me.txt_seguros.TabIndex = 168
        Me.txt_seguros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(255, 19)
        Me.Label13.TabIndex = 166
        Me.Label13.Text = "Carpeta  formatos de salida (URL)"
        '
        'txt_salidas
        '
        Me.txt_salidas.BackColor = System.Drawing.Color.Transparent
        Me.txt_salidas.BaseColor = System.Drawing.Color.White
        Me.txt_salidas.BorderColor = System.Drawing.Color.Silver
        Me.txt_salidas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_salidas.Enabled = False
        Me.txt_salidas.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_salidas.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txt_salidas.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_salidas.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salidas.Location = New System.Drawing.Point(36, 406)
        Me.txt_salidas.Name = "txt_salidas"
        Me.txt_salidas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_salidas.Radius = 10
        Me.txt_salidas.Size = New System.Drawing.Size(380, 30)
        Me.txt_salidas.TabIndex = 165
        Me.txt_salidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 38)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Carpeta de SQL SERVER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para guardar la copia de seguridad (URL)"
        '
        'txtbackup
        '
        Me.txtbackup.BackColor = System.Drawing.Color.Transparent
        Me.txtbackup.BaseColor = System.Drawing.Color.White
        Me.txtbackup.BorderColor = System.Drawing.Color.Silver
        Me.txtbackup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbackup.Enabled = False
        Me.txtbackup.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbackup.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtbackup.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbackup.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbackup.Location = New System.Drawing.Point(455, 342)
        Me.txtbackup.Name = "txtbackup"
        Me.txtbackup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbackup.Radius = 10
        Me.txtbackup.Size = New System.Drawing.Size(380, 30)
        Me.txtbackup.TabIndex = 162
        Me.txtbackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(320, 19)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Carpeta  de archivos PDF de la mora (URL)"
        '
        'txtpdf
        '
        Me.txtpdf.BackColor = System.Drawing.Color.Transparent
        Me.txtpdf.BaseColor = System.Drawing.Color.White
        Me.txtpdf.BorderColor = System.Drawing.Color.Silver
        Me.txtpdf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpdf.Enabled = False
        Me.txtpdf.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpdf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtpdf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpdf.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdf.Location = New System.Drawing.Point(36, 342)
        Me.txtpdf.Name = "txtpdf"
        Me.txtpdf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpdf.Radius = 10
        Me.txtpdf.Size = New System.Drawing.Size(380, 30)
        Me.txtpdf.TabIndex = 159
        Me.txtpdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 19)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Carpeta Permisos (URL)"
        '
        'txtpermisos
        '
        Me.txtpermisos.BackColor = System.Drawing.Color.Transparent
        Me.txtpermisos.BaseColor = System.Drawing.Color.White
        Me.txtpermisos.BorderColor = System.Drawing.Color.Silver
        Me.txtpermisos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpermisos.Enabled = False
        Me.txtpermisos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpermisos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtpermisos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpermisos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpermisos.Location = New System.Drawing.Point(455, 267)
        Me.txtpermisos.Name = "txtpermisos"
        Me.txtpermisos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpermisos.Radius = 10
        Me.txtpermisos.Size = New System.Drawing.Size(380, 30)
        Me.txtpermisos.TabIndex = 153
        Me.txtpermisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 19)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Carpeta  Administradores(URL)"
        '
        'txtadministradores
        '
        Me.txtadministradores.BackColor = System.Drawing.Color.Transparent
        Me.txtadministradores.BaseColor = System.Drawing.Color.White
        Me.txtadministradores.BorderColor = System.Drawing.Color.Silver
        Me.txtadministradores.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtadministradores.Enabled = False
        Me.txtadministradores.FocusedBaseColor = System.Drawing.Color.White
        Me.txtadministradores.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtadministradores.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtadministradores.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadministradores.Location = New System.Drawing.Point(36, 267)
        Me.txtadministradores.Name = "txtadministradores"
        Me.txtadministradores.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtadministradores.Radius = 10
        Me.txtadministradores.Size = New System.Drawing.Size(380, 30)
        Me.txtadministradores.TabIndex = 151
        Me.txtadministradores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 19)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Carpeta Clientes (URL)"
        '
        'txtclientes
        '
        Me.txtclientes.BackColor = System.Drawing.Color.Transparent
        Me.txtclientes.BaseColor = System.Drawing.Color.White
        Me.txtclientes.BorderColor = System.Drawing.Color.Silver
        Me.txtclientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclientes.Enabled = False
        Me.txtclientes.FocusedBaseColor = System.Drawing.Color.White
        Me.txtclientes.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtclientes.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtclientes.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclientes.Location = New System.Drawing.Point(455, 187)
        Me.txtclientes.Name = "txtclientes"
        Me.txtclientes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtclientes.Radius = 10
        Me.txtclientes.Size = New System.Drawing.Size(380, 30)
        Me.txtclientes.TabIndex = 149
        Me.txtclientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 19)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Carpeta elementos (URL)"
        '
        'txtelementos
        '
        Me.txtelementos.BackColor = System.Drawing.Color.Transparent
        Me.txtelementos.BaseColor = System.Drawing.Color.White
        Me.txtelementos.BorderColor = System.Drawing.Color.Silver
        Me.txtelementos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtelementos.Enabled = False
        Me.txtelementos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtelementos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtelementos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtelementos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelementos.Location = New System.Drawing.Point(36, 187)
        Me.txtelementos.Name = "txtelementos"
        Me.txtelementos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtelementos.Radius = 10
        Me.txtelementos.Size = New System.Drawing.Size(380, 30)
        Me.txtelementos.TabIndex = 147
        Me.txtelementos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(583, 76)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "2. Ingrese a cada una de las carpetas y copie la dirección URL de estas en cada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    uno de los campos correspondientes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(614, 57)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "1. Cree las siguientes carpetas dentro de la carpeta de imágenes de su equipo: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "     Elementos, clientes, administradores, permisos y asi con cada uno de los it" &
    "ems." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.cmbcentro)
        Me.GunaGroupBox2.Controls.Add(Me.Label3)
        Me.GunaGroupBox2.Controls.Add(Me.cmbciudad)
        Me.GunaGroupBox2.Controls.Add(Me.Label2)
        Me.GunaGroupBox2.Controls.Add(Me.cmbdepartamento)
        Me.GunaGroupBox2.Controls.Add(Me.Label9)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Location = New System.Drawing.Point(186, 74)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(868, 172)
        Me.GunaGroupBox2.TabIndex = 127
        Me.GunaGroupBox2.Text = "1. Por favor elija el centro de formación en el cual se hizo la instalación de es" &
    "te programa."
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'cmbcentro
        '
        Me.cmbcentro.BackColor = System.Drawing.Color.Transparent
        Me.cmbcentro.BaseColor = System.Drawing.Color.White
        Me.cmbcentro.BorderColor = System.Drawing.Color.Silver
        Me.cmbcentro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcentro.FocusedColor = System.Drawing.Color.Empty
        Me.cmbcentro.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcentro.ForeColor = System.Drawing.Color.Black
        Me.cmbcentro.FormattingEnabled = True
        Me.cmbcentro.Location = New System.Drawing.Point(138, 125)
        Me.cmbcentro.Name = "cmbcentro"
        Me.cmbcentro.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbcentro.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbcentro.Radius = 10
        Me.cmbcentro.Size = New System.Drawing.Size(600, 28)
        Me.cmbcentro.TabIndex = 133
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 19)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Seleccione un centro de formación"
        '
        'cmbciudad
        '
        Me.cmbciudad.BackColor = System.Drawing.Color.Transparent
        Me.cmbciudad.BaseColor = System.Drawing.Color.White
        Me.cmbciudad.BorderColor = System.Drawing.Color.Silver
        Me.cmbciudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbciudad.FocusedColor = System.Drawing.Color.Empty
        Me.cmbciudad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbciudad.ForeColor = System.Drawing.Color.Black
        Me.cmbciudad.FormattingEnabled = True
        Me.cmbciudad.Location = New System.Drawing.Point(508, 61)
        Me.cmbciudad.Name = "cmbciudad"
        Me.cmbciudad.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbciudad.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbciudad.Radius = 10
        Me.cmbciudad.Size = New System.Drawing.Size(230, 28)
        Me.cmbciudad.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 19)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Seleccione una ciudad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbdepartamento
        '
        Me.cmbdepartamento.BackColor = System.Drawing.Color.Transparent
        Me.cmbdepartamento.BaseColor = System.Drawing.Color.White
        Me.cmbdepartamento.BorderColor = System.Drawing.Color.Silver
        Me.cmbdepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdepartamento.FocusedColor = System.Drawing.Color.Empty
        Me.cmbdepartamento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdepartamento.ForeColor = System.Drawing.Color.Black
        Me.cmbdepartamento.FormattingEnabled = True
        Me.cmbdepartamento.Location = New System.Drawing.Point(138, 61)
        Me.cmbdepartamento.Name = "cmbdepartamento"
        Me.cmbdepartamento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbdepartamento.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbdepartamento.Radius = 10
        Me.cmbdepartamento.Size = New System.Drawing.Size(230, 28)
        Me.cmbdepartamento.TabIndex = 128
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 19)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Seleccione departamento"
        '
        'frm_configuracion_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 788)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.btncontinuar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_configuracion_inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion_inicial"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btncontinuar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents cmbcentro As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbciudad As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbdepartamento As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents link_salidas As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_seguros As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents link_seguros As LinkLabel
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_salidas As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtbackup As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents linkpdf As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpdf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents linkpermisos As LinkLabel
    Friend WithEvents linkadmin As LinkLabel
    Friend WithEvents linkclientes As LinkLabel
    Friend WithEvents linkelementos As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpermisos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtadministradores As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtclientes As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtelementos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
