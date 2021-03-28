<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_EConsumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_EConsumo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtObservaciones = New Guna.UI.WinForms.GunaTextBox()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnSi = New Guna.UI.WinForms.GunaRadioButton()
        Me.btnNo = New Guna.UI.WinForms.GunaRadioButton()
        Me.lblElemento = New System.Windows.Forms.Label()
        Me.lblSeconsumio = New System.Windows.Forms.Label()
        Me.txtCantidad = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 312)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(530, 5)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(530, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(530, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 302)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCircleButton1)
        Me.Panel5.Controls.Add(Me.lblTitulo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(525, 33)
        Me.Panel5.TabIndex = 6
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(492, 2)
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
        Me.lblTitulo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(525, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Elemento de consumo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.txtObservaciones.BaseColor = System.Drawing.Color.White
        Me.txtObservaciones.BorderColor = System.Drawing.Color.Silver
        Me.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservaciones.FocusedBaseColor = System.Drawing.Color.White
        Me.txtObservaciones.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtObservaciones.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtObservaciones.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.Location = New System.Drawing.Point(24, 193)
        Me.txtObservaciones.MultiLine = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Radius = 10
        Me.txtObservaciones.Size = New System.Drawing.Size(488, 66)
        Me.txtObservaciones.TabIndex = 45
        Me.txtObservaciones.Tag = "1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAceptar.BorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Global.Appsena.My.Resources.Resources.icons8_ok_64
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(208, 270)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Radius = 10
        Me.btnAceptar.Size = New System.Drawing.Size(106, 31)
        Me.btnAceptar.TabIndex = 46
        Me.btnAceptar.Text = "Aceptar"
        '
        'lblPregunta
        '
        Me.lblPregunta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPregunta.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.Black
        Me.lblPregunta.Location = New System.Drawing.Point(5, 77)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(525, 19)
        Me.lblPregunta.TabIndex = 47
        Me.lblPregunta.Text = "¿El elemento se consumió completamente?"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSi
        '
        Me.btnSi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSi.BaseColor = System.Drawing.SystemColors.Control
        Me.btnSi.CheckedOffColor = System.Drawing.Color.Gray
        Me.btnSi.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnSi.FillColor = System.Drawing.Color.White
        Me.btnSi.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.Location = New System.Drawing.Point(208, 99)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(46, 23)
        Me.btnSi.TabIndex = 48
        Me.btnSi.Text = "Si"
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.BaseColor = System.Drawing.SystemColors.Control
        Me.btnNo.CheckedOffColor = System.Drawing.Color.Gray
        Me.btnNo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnNo.FillColor = System.Drawing.Color.White
        Me.btnNo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(279, 99)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(53, 23)
        Me.btnNo.TabIndex = 49
        Me.btnNo.Text = "No"
        '
        'lblElemento
        '
        Me.lblElemento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblElemento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElemento.ForeColor = System.Drawing.Color.Black
        Me.lblElemento.Location = New System.Drawing.Point(5, 41)
        Me.lblElemento.Name = "lblElemento"
        Me.lblElemento.Size = New System.Drawing.Size(525, 19)
        Me.lblElemento.TabIndex = 50
        Me.lblElemento.Text = "Nombre"
        Me.lblElemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeconsumio
        '
        Me.lblSeconsumio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeconsumio.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconsumio.ForeColor = System.Drawing.Color.Black
        Me.lblSeconsumio.Location = New System.Drawing.Point(24, 171)
        Me.lblSeconsumio.Name = "lblSeconsumio"
        Me.lblSeconsumio.Size = New System.Drawing.Size(488, 19)
        Me.lblSeconsumio.TabIndex = 51
        Me.lblSeconsumio.Text = "¿En qué se consumió el elemento?"
        Me.lblSeconsumio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.BackColor = System.Drawing.Color.Transparent
        Me.txtCantidad.BaseColor = System.Drawing.Color.White
        Me.txtCantidad.BorderColor = System.Drawing.Color.Silver
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantidad.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCantidad.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtCantidad.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantidad.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.Location = New System.Drawing.Point(208, 99)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.Radius = 10
        Me.txtCantidad.Size = New System.Drawing.Size(106, 30)
        Me.txtCantidad.TabIndex = 52
        Me.txtCantidad.Tag = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMovimientos_EConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 312)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblSeconsumio)
        Me.Controls.Add(Me.lblElemento)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_EConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_EConsumo"
        Me.Panel5.ResumeLayout(False)
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
    Friend WithEvents txtObservaciones As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblPregunta As Label
    Friend WithEvents btnSi As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents btnNo As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents lblElemento As Label
    Friend WithEvents lblSeconsumio As Label
    Friend WithEvents txtCantidad As Guna.UI.WinForms.GunaTextBox
End Class
