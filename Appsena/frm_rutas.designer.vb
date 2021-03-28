<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rutas
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
        Me.btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.linkpdf = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpdf = New Guna.UI.WinForms.GunaTextBox()
        Me.linkadministradores = New System.Windows.Forms.LinkLabel()
        Me.linkpermisos = New System.Windows.Forms.LinkLabel()
        Me.linkclientes = New System.Windows.Forms.LinkLabel()
        Me.linkelementos = New System.Windows.Forms.LinkLabel()
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
        Me.link_salidas = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_seguros = New Guna.UI.WinForms.GunaTextBox()
        Me.link_seguros = New System.Windows.Forms.LinkLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_salidas = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.btnguardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = Nothing
        Me.btnguardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnguardar.Location = New System.Drawing.Point(331, 505)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnguardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnguardar.OnHoverImage = Nothing
        Me.btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnguardar.Radius = 10
        Me.btnguardar.Size = New System.Drawing.Size(278, 35)
        Me.btnguardar.TabIndex = 114
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaGroupBox1.Controls.Add(Me.btnguardar)
        Me.GunaGroupBox1.Controls.Add(Me.linkpdf)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.txtpdf)
        Me.GunaGroupBox1.Controls.Add(Me.linkadministradores)
        Me.GunaGroupBox1.Controls.Add(Me.linkpermisos)
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
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(908, 557)
        Me.GunaGroupBox1.TabIndex = 113
        Me.GunaGroupBox1.Text = "Configuración de las rutas donde se guardarán las imágenes del sistema"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'linkpdf
        '
        Me.linkpdf.AutoSize = True
        Me.linkpdf.Location = New System.Drawing.Point(359, 362)
        Me.linkpdf.Name = "linkpdf"
        Me.linkpdf.Size = New System.Drawing.Size(79, 19)
        Me.linkpdf.TabIndex = 140
        Me.linkpdf.TabStop = True
        Me.linkpdf.Text = "Modificar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 19)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Carpeta  de archivos PDF de la mora (URL)"
        '
        'txtpdf
        '
        Me.txtpdf.BackColor = System.Drawing.Color.Transparent
        Me.txtpdf.BaseColor = System.Drawing.Color.White
        Me.txtpdf.BorderColor = System.Drawing.Color.Silver
        Me.txtpdf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpdf.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpdf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtpdf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpdf.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdf.Location = New System.Drawing.Point(33, 384)
        Me.txtpdf.Name = "txtpdf"
        Me.txtpdf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpdf.Radius = 10
        Me.txtpdf.Size = New System.Drawing.Size(380, 30)
        Me.txtpdf.TabIndex = 138
        Me.txtpdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'linkadministradores
        '
        Me.linkadministradores.AutoSize = True
        Me.linkadministradores.Location = New System.Drawing.Point(284, 269)
        Me.linkadministradores.Name = "linkadministradores"
        Me.linkadministradores.Size = New System.Drawing.Size(79, 19)
        Me.linkadministradores.TabIndex = 137
        Me.linkadministradores.TabStop = True
        Me.linkadministradores.Text = "Modificar"
        '
        'linkpermisos
        '
        Me.linkpermisos.AutoSize = True
        Me.linkpermisos.Location = New System.Drawing.Point(668, 269)
        Me.linkpermisos.Name = "linkpermisos"
        Me.linkpermisos.Size = New System.Drawing.Size(79, 19)
        Me.linkpermisos.TabIndex = 136
        Me.linkpermisos.TabStop = True
        Me.linkpermisos.Text = "Modificar"
        '
        'linkclientes
        '
        Me.linkclientes.AutoSize = True
        Me.linkclientes.Location = New System.Drawing.Point(657, 178)
        Me.linkclientes.Name = "linkclientes"
        Me.linkclientes.Size = New System.Drawing.Size(79, 19)
        Me.linkclientes.TabIndex = 135
        Me.linkclientes.TabStop = True
        Me.linkclientes.Text = "Modificar"
        '
        'linkelementos
        '
        Me.linkelementos.AutoSize = True
        Me.linkelementos.Location = New System.Drawing.Point(242, 178)
        Me.linkelementos.Name = "linkelementos"
        Me.linkelementos.Size = New System.Drawing.Size(79, 19)
        Me.linkelementos.TabIndex = 126
        Me.linkelementos.TabStop = True
        Me.linkelementos.Text = "Modificar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(477, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 19)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "Carpeta Permisos (URL)"
        '
        'txtpermisos
        '
        Me.txtpermisos.BackColor = System.Drawing.Color.Transparent
        Me.txtpermisos.BaseColor = System.Drawing.Color.White
        Me.txtpermisos.BorderColor = System.Drawing.Color.Silver
        Me.txtpermisos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpermisos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpermisos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtpermisos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpermisos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpermisos.Location = New System.Drawing.Point(467, 291)
        Me.txtpermisos.Name = "txtpermisos"
        Me.txtpermisos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpermisos.Radius = 10
        Me.txtpermisos.Size = New System.Drawing.Size(380, 30)
        Me.txtpermisos.TabIndex = 133
        Me.txtpermisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 19)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Carpeta  Administradores(URL)"
        '
        'txtadministradores
        '
        Me.txtadministradores.BackColor = System.Drawing.Color.Transparent
        Me.txtadministradores.BaseColor = System.Drawing.Color.White
        Me.txtadministradores.BorderColor = System.Drawing.Color.Silver
        Me.txtadministradores.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtadministradores.FocusedBaseColor = System.Drawing.Color.White
        Me.txtadministradores.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtadministradores.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtadministradores.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadministradores.Location = New System.Drawing.Point(30, 291)
        Me.txtadministradores.Name = "txtadministradores"
        Me.txtadministradores.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtadministradores.Radius = 10
        Me.txtadministradores.Size = New System.Drawing.Size(380, 30)
        Me.txtadministradores.TabIndex = 131
        Me.txtadministradores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(477, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 19)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "Carpeta Clientes (URL)"
        '
        'txtclientes
        '
        Me.txtclientes.BackColor = System.Drawing.Color.Transparent
        Me.txtclientes.BaseColor = System.Drawing.Color.White
        Me.txtclientes.BorderColor = System.Drawing.Color.Silver
        Me.txtclientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclientes.FocusedBaseColor = System.Drawing.Color.White
        Me.txtclientes.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtclientes.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtclientes.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclientes.Location = New System.Drawing.Point(467, 200)
        Me.txtclientes.Name = "txtclientes"
        Me.txtclientes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtclientes.Radius = 10
        Me.txtclientes.Size = New System.Drawing.Size(380, 30)
        Me.txtclientes.TabIndex = 129
        Me.txtclientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 19)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Carpeta elementos (URL)"
        '
        'txtelementos
        '
        Me.txtelementos.BackColor = System.Drawing.Color.Transparent
        Me.txtelementos.BaseColor = System.Drawing.Color.White
        Me.txtelementos.BorderColor = System.Drawing.Color.Silver
        Me.txtelementos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtelementos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtelementos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtelementos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtelementos.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelementos.Location = New System.Drawing.Point(33, 200)
        Me.txtelementos.Name = "txtelementos"
        Me.txtelementos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtelementos.Radius = 10
        Me.txtelementos.Size = New System.Drawing.Size(380, 30)
        Me.txtelementos.TabIndex = 127
        Me.txtelementos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(583, 76)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "2. Ingrese a cada una de las carpetas y copie la dirección URL de estas en cada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    uno de los campos correspondientes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(587, 57)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "1. Cree las siguientes carpetas dentro de la carpeta de imágenes de su equipo: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "     Elementos, clientes, administradores y permisos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'link_salidas
        '
        Me.link_salidas.AutoSize = True
        Me.link_salidas.Location = New System.Drawing.Point(307, 434)
        Me.link_salidas.Name = "link_salidas"
        Me.link_salidas.Size = New System.Drawing.Size(79, 19)
        Me.link_salidas.TabIndex = 176
        Me.link_salidas.TabStop = True
        Me.link_salidas.Text = "Modificar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(477, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 19)
        Me.Label12.TabIndex = 175
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
        Me.txt_seguros.Location = New System.Drawing.Point(467, 384)
        Me.txt_seguros.Name = "txt_seguros"
        Me.txt_seguros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_seguros.Radius = 10
        Me.txt_seguros.Size = New System.Drawing.Size(380, 30)
        Me.txt_seguros.TabIndex = 174
        Me.txt_seguros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'link_seguros
        '
        Me.link_seguros.AutoSize = True
        Me.link_seguros.Location = New System.Drawing.Point(684, 362)
        Me.link_seguros.Name = "link_seguros"
        Me.link_seguros.Size = New System.Drawing.Size(79, 19)
        Me.link_seguros.TabIndex = 173
        Me.link_seguros.TabStop = True
        Me.link_seguros.Text = "Modificar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(43, 434)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(255, 19)
        Me.Label13.TabIndex = 172
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
        Me.txt_salidas.Location = New System.Drawing.Point(33, 456)
        Me.txt_salidas.Name = "txt_salidas"
        Me.txt_salidas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_salidas.Radius = 10
        Me.txt_salidas.Size = New System.Drawing.Size(380, 30)
        Me.txt_salidas.TabIndex = 171
        Me.txt_salidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_rutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(932, 634)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_rutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_rutas"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents linkpdf As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpdf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents linkadministradores As LinkLabel
    Friend WithEvents linkpermisos As LinkLabel
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
    Friend WithEvents link_salidas As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_seguros As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents link_seguros As LinkLabel
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_salidas As Guna.UI.WinForms.GunaTextBox
End Class
