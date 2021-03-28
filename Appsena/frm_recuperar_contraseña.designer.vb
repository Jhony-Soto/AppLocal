<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recuperar_contraseña
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recuperar_contraseña))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnconsultar = New Guna.UI.WinForms.GunaButton()
        Me.txtdocumento = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fechaDevolucion = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 51)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(154, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 19)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Recuperar contraseña"
        '
        'btncerrar
        '
        Me.btncerrar.AnimationHoverSpeed = 0.07!
        Me.btncerrar.AnimationSpeed = 0.03!
        Me.btncerrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btncerrar.BorderColor = System.Drawing.Color.Black
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncerrar.FocusedColor = System.Drawing.Color.Empty
        Me.btncerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.btncerrar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btncerrar.Location = New System.Drawing.Point(483, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncerrar.OnHoverImage = Nothing
        Me.btncerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btncerrar.Size = New System.Drawing.Size(28, 28)
        Me.btncerrar.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        '
        'btnconsultar
        '
        Me.btnconsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconsultar.AnimationHoverSpeed = 0.07!
        Me.btnconsultar.AnimationSpeed = 0.03!
        Me.btnconsultar.BackColor = System.Drawing.Color.Transparent
        Me.btnconsultar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnconsultar.BorderColor = System.Drawing.Color.Transparent
        Me.btnconsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconsultar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnconsultar.FocusedColor = System.Drawing.Color.Empty
        Me.btnconsultar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultar.ForeColor = System.Drawing.Color.White
        Me.btnconsultar.Image = Nothing
        Me.btnconsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnconsultar.Location = New System.Drawing.Point(196, 265)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnconsultar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnconsultar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnconsultar.OnHoverImage = Nothing
        Me.btnconsultar.OnPressedColor = System.Drawing.Color.Black
        Me.btnconsultar.Radius = 10
        Me.btnconsultar.Size = New System.Drawing.Size(121, 31)
        Me.btnconsultar.TabIndex = 30
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnconsultar, "Consultar contraseña")
        '
        'txtdocumento
        '
        Me.txtdocumento.BackColor = System.Drawing.Color.Transparent
        Me.txtdocumento.BaseColor = System.Drawing.Color.White
        Me.txtdocumento.BorderColor = System.Drawing.Color.Silver
        Me.txtdocumento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdocumento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtdocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocumento.ForeColor = System.Drawing.Color.Black
        Me.txtdocumento.Location = New System.Drawing.Point(92, 128)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdocumento.Radius = 10
        Me.txtdocumento.Size = New System.Drawing.Size(319, 30)
        Me.txtdocumento.TabIndex = 116
        Me.txtdocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(164, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 23)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Numero de documento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fechaDevolucion
        '
        Me.fechaDevolucion.BackColor = System.Drawing.Color.Transparent
        Me.fechaDevolucion.BaseColor = System.Drawing.Color.White
        Me.fechaDevolucion.BorderColor = System.Drawing.Color.Silver
        Me.fechaDevolucion.CustomFormat = "dd-MM-yyyy"
        Me.fechaDevolucion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fechaDevolucion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.fechaDevolucion.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaDevolucion.ForeColor = System.Drawing.Color.Black
        Me.fechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDevolucion.Location = New System.Drawing.Point(92, 216)
        Me.fechaDevolucion.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fechaDevolucion.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fechaDevolucion.Name = "fechaDevolucion"
        Me.fechaDevolucion.OnHoverBaseColor = System.Drawing.Color.White
        Me.fechaDevolucion.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.fechaDevolucion.OnHoverForeColor = System.Drawing.Color.Black
        Me.fechaDevolucion.OnPressedColor = System.Drawing.Color.Black
        Me.fechaDevolucion.Radius = 10
        Me.fechaDevolucion.Size = New System.Drawing.Size(319, 30)
        Me.fechaDevolucion.TabIndex = 118
        Me.fechaDevolucion.Text = "3/12/2019"
        Me.fechaDevolucion.Value = New Date(2019, 12, 3, 15, 2, 18, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(111, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(277, 19)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Fecha de expedición del documento"
        '
        'frm_recuperar_contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 355)
        Me.Controls.Add(Me.fechaDevolucion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_recuperar_contraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar contraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnconsultar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtdocumento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fechaDevolucion As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
