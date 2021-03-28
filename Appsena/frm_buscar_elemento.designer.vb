<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_buscar_elemento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscar_elemento))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlelemento = New Guna.UI.WinForms.GunaShadowPanel()
        Me.txtcantidad = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnconsultar = New Guna.UI.WinForms.GunaButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlelemento.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'pnlelemento
        '
        Me.pnlelemento.BackColor = System.Drawing.Color.Transparent
        Me.pnlelemento.BaseColor = System.Drawing.Color.White
        Me.pnlelemento.Controls.Add(Me.txtcantidad)
        Me.pnlelemento.Controls.Add(Me.Label5)
        Me.pnlelemento.Controls.Add(Me.Panel1)
        Me.pnlelemento.Controls.Add(Me.btnconsultar)
        Me.pnlelemento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlelemento.Location = New System.Drawing.Point(0, 0)
        Me.pnlelemento.Name = "pnlelemento"
        Me.pnlelemento.ShadowColor = System.Drawing.Color.Black
        Me.pnlelemento.ShadowShift = 10
        Me.pnlelemento.Size = New System.Drawing.Size(556, 231)
        Me.pnlelemento.TabIndex = 70
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Transparent
        Me.txtcantidad.BaseColor = System.Drawing.Color.White
        Me.txtcantidad.BorderColor = System.Drawing.Color.Silver
        Me.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcantidad.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcantidad.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtcantidad.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcantidad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.Black
        Me.txtcantidad.Location = New System.Drawing.Point(131, 105)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcantidad.Radius = 10
        Me.txtcantidad.Size = New System.Drawing.Size(319, 30)
        Me.txtcantidad.TabIndex = 114
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(216, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 23)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Codigo del elemento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 42)
        Me.Panel1.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(142, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Consultar el historial de prestamos"
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
        Me.btncerrar.Location = New System.Drawing.Point(513, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncerrar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btncerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncerrar.OnHoverImage = Nothing
        Me.btncerrar.OnPressedColor = System.Drawing.Color.Red
        Me.btncerrar.Size = New System.Drawing.Size(28, 28)
        Me.btncerrar.TabIndex = 47
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
        Me.btnconsultar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultar.ForeColor = System.Drawing.Color.White
        Me.btnconsultar.Image = Nothing
        Me.btnconsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnconsultar.Location = New System.Drawing.Point(220, 161)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnconsultar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnconsultar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnconsultar.OnHoverImage = Nothing
        Me.btnconsultar.OnPressedColor = System.Drawing.Color.Black
        Me.btnconsultar.Radius = 10
        Me.btnconsultar.Size = New System.Drawing.Size(121, 31)
        Me.btnconsultar.TabIndex = 29
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnconsultar, "Consultar ")
        '
        'frm_buscar_elemento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 231)
        Me.Controls.Add(Me.pnlelemento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_buscar_elemento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar elemento"
        Me.pnlelemento.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnlelemento As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents txtcantidad As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnconsultar As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
