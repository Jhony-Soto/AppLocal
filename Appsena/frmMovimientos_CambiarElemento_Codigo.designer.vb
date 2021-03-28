<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_CambiarElemento_Codigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_CambiarElemento_Codigo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.txtCodElemento = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 33)
        Me.Panel1.TabIndex = 0
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(427, 3)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.Size = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cambiar elemento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Codigo del elemento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAceptar.BorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Global.Appsena.My.Resources.Resources.icons8_maintenance_64
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(182, 146)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(110, 31)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtCodElemento
        '
        Me.txtCodElemento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodElemento.BackColor = System.Drawing.Color.Transparent
        Me.txtCodElemento.BaseColor = System.Drawing.Color.White
        Me.txtCodElemento.BorderColor = System.Drawing.Color.Silver
        Me.txtCodElemento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodElemento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCodElemento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtCodElemento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCodElemento.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodElemento.Location = New System.Drawing.Point(72, 91)
        Me.txtCodElemento.Name = "txtCodElemento"
        Me.txtCodElemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodElemento.Radius = 10
        Me.txtCodElemento.Size = New System.Drawing.Size(327, 30)
        Me.txtCodElemento.TabIndex = 7
        Me.txtCodElemento.Tag = "1"
        Me.txtCodElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Controls.Add(Me.Label2)
        Me.GunaShadowPanel1.Controls.Add(Me.btnAceptar)
        Me.GunaShadowPanel1.Controls.Add(Me.txtCodElemento)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(471, 189)
        Me.GunaShadowPanel1.TabIndex = 3
        '
        'frmMovimientos_CambiarElemento_Codigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 189)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_CambiarElemento_Codigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_CambiarElemento_Codigo"
        Me.Panel1.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtCodElemento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
End Class
