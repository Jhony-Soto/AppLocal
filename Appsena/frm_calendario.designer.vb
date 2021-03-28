<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_calendario
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
        Me.header = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhistorial = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblheaderfecha = New System.Windows.Forms.Label()
        Me.btnsiguiente = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnanterior = New Guna.UI.WinForms.GunaCircleButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.flowpaneldias = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlheaderdias = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSabado = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblJueves = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblViernes = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMartes = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMiercoles = New System.Windows.Forms.Label()
        Me.pnlDomingo = New System.Windows.Forms.Panel()
        Me.lnlLunes = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        Me.pnlheaderdias.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlDomingo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Controls.Add(Me.Label1)
        Me.header.Controls.Add(Me.btnhistorial)
        Me.header.Controls.Add(Me.lblheaderfecha)
        Me.header.Controls.Add(Me.btnsiguiente)
        Me.header.Controls.Add(Me.btnanterior)
        Me.header.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.header.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1450, 78)
        Me.header.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1180, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Historial de reservas"
        '
        'btnhistorial
        '
        Me.btnhistorial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnhistorial.AnimationHoverSpeed = 0.07!
        Me.btnhistorial.AnimationSpeed = 0.03!
        Me.btnhistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhistorial.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnhistorial.BorderColor = System.Drawing.Color.Black
        Me.btnhistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhistorial.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnhistorial.FocusedColor = System.Drawing.Color.Empty
        Me.btnhistorial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnhistorial.ForeColor = System.Drawing.Color.White
        Me.btnhistorial.Image = Global.Appsena.My.Resources.Resources.icons8_bookmark_64
        Me.btnhistorial.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnhistorial.Location = New System.Drawing.Point(1372, 12)
        Me.btnhistorial.Name = "btnhistorial"
        Me.btnhistorial.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnhistorial.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnhistorial.OnHoverForeColor = System.Drawing.Color.White
        Me.btnhistorial.OnHoverImage = Nothing
        Me.btnhistorial.OnPressedColor = System.Drawing.Color.Black
        Me.btnhistorial.Size = New System.Drawing.Size(48, 46)
        Me.btnhistorial.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnhistorial, "Abrir el historial de las reservas")
        '
        'lblheaderfecha
        '
        Me.lblheaderfecha.AutoSize = True
        Me.lblheaderfecha.Font = New System.Drawing.Font("Zurich", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheaderfecha.ForeColor = System.Drawing.Color.White
        Me.lblheaderfecha.Location = New System.Drawing.Point(28, 29)
        Me.lblheaderfecha.Name = "lblheaderfecha"
        Me.lblheaderfecha.Size = New System.Drawing.Size(282, 39)
        Me.lblheaderfecha.TabIndex = 1
        Me.lblheaderfecha.Text = "Diciembre,2019"
        Me.ToolTip1.SetToolTip(Me.lblheaderfecha, "Fecha")
        '
        'btnsiguiente
        '
        Me.btnsiguiente.AnimationHoverSpeed = 0.07!
        Me.btnsiguiente.AnimationSpeed = 0.03!
        Me.btnsiguiente.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnsiguiente.BorderColor = System.Drawing.Color.Black
        Me.btnsiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsiguiente.FocusedColor = System.Drawing.Color.Empty
        Me.btnsiguiente.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiguiente.ForeColor = System.Drawing.Color.White
        Me.btnsiguiente.Image = Nothing
        Me.btnsiguiente.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnsiguiente.Location = New System.Drawing.Point(462, 29)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsiguiente.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnsiguiente.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsiguiente.OnHoverImage = Nothing
        Me.btnsiguiente.OnPressedColor = System.Drawing.Color.Black
        Me.btnsiguiente.Size = New System.Drawing.Size(40, 40)
        Me.btnsiguiente.TabIndex = 1
        Me.btnsiguiente.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnsiguiente, "Mes Siguiente")
        '
        'btnanterior
        '
        Me.btnanterior.AnimationHoverSpeed = 0.07!
        Me.btnanterior.AnimationSpeed = 0.03!
        Me.btnanterior.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnanterior.BorderColor = System.Drawing.Color.Black
        Me.btnanterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanterior.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnanterior.FocusedColor = System.Drawing.Color.Empty
        Me.btnanterior.Font = New System.Drawing.Font("Zurich", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnanterior.ForeColor = System.Drawing.Color.White
        Me.btnanterior.Image = Nothing
        Me.btnanterior.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnanterior.Location = New System.Drawing.Point(416, 29)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnanterior.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnanterior.OnHoverForeColor = System.Drawing.Color.White
        Me.btnanterior.OnHoverImage = Nothing
        Me.btnanterior.OnPressedColor = System.Drawing.Color.Black
        Me.btnanterior.Size = New System.Drawing.Size(40, 40)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btnanterior, "Mes Anterior")
        '
        'flowpaneldias
        '
        Me.flowpaneldias.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.flowpaneldias.Location = New System.Drawing.Point(3, 114)
        Me.flowpaneldias.Name = "flowpaneldias"
        Me.flowpaneldias.Size = New System.Drawing.Size(1447, 885)
        Me.flowpaneldias.TabIndex = 1
        '
        'pnlheaderdias
        '
        Me.pnlheaderdias.Controls.Add(Me.Panel6)
        Me.pnlheaderdias.Controls.Add(Me.Panel4)
        Me.pnlheaderdias.Controls.Add(Me.Panel2)
        Me.pnlheaderdias.Controls.Add(Me.Panel5)
        Me.pnlheaderdias.Controls.Add(Me.Panel1)
        Me.pnlheaderdias.Controls.Add(Me.Panel3)
        Me.pnlheaderdias.Controls.Add(Me.pnlDomingo)
        Me.pnlheaderdias.Location = New System.Drawing.Point(0, 75)
        Me.pnlheaderdias.Name = "pnlheaderdias"
        Me.pnlheaderdias.Size = New System.Drawing.Size(1483, 34)
        Me.pnlheaderdias.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(3, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 33)
        Me.Panel6.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Domingo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.lblSabado)
        Me.Panel4.Location = New System.Drawing.Point(1239, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 33)
        Me.Panel4.TabIndex = 3
        '
        'lblSabado
        '
        Me.lblSabado.AutoSize = True
        Me.lblSabado.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSabado.ForeColor = System.Drawing.Color.Black
        Me.lblSabado.Location = New System.Drawing.Point(30, 7)
        Me.lblSabado.Name = "lblSabado"
        Me.lblSabado.Size = New System.Drawing.Size(65, 19)
        Me.lblSabado.TabIndex = 0
        Me.lblSabado.Text = "Sabado"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lblJueves)
        Me.Panel2.Location = New System.Drawing.Point(827, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 33)
        Me.Panel2.TabIndex = 3
        '
        'lblJueves
        '
        Me.lblJueves.AutoSize = True
        Me.lblJueves.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJueves.ForeColor = System.Drawing.Color.Black
        Me.lblJueves.Location = New System.Drawing.Point(30, 7)
        Me.lblJueves.Name = "lblJueves"
        Me.lblJueves.Size = New System.Drawing.Size(61, 19)
        Me.lblJueves.TabIndex = 0
        Me.lblJueves.Text = "Jueves"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.lblViernes)
        Me.Panel5.Location = New System.Drawing.Point(1033, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 33)
        Me.Panel5.TabIndex = 2
        '
        'lblViernes
        '
        Me.lblViernes.AutoSize = True
        Me.lblViernes.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViernes.ForeColor = System.Drawing.Color.Black
        Me.lblViernes.Location = New System.Drawing.Point(30, 7)
        Me.lblViernes.Name = "lblViernes"
        Me.lblViernes.Size = New System.Drawing.Size(65, 19)
        Me.lblViernes.TabIndex = 0
        Me.lblViernes.Text = "Viernes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblMartes)
        Me.Panel1.Location = New System.Drawing.Point(415, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 33)
        Me.Panel1.TabIndex = 1
        '
        'lblMartes
        '
        Me.lblMartes.AutoSize = True
        Me.lblMartes.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMartes.ForeColor = System.Drawing.Color.Black
        Me.lblMartes.Location = New System.Drawing.Point(30, 7)
        Me.lblMartes.Name = "lblMartes"
        Me.lblMartes.Size = New System.Drawing.Size(60, 19)
        Me.lblMartes.TabIndex = 0
        Me.lblMartes.Text = "Martes"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.lblMiercoles)
        Me.Panel3.Location = New System.Drawing.Point(621, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 33)
        Me.Panel3.TabIndex = 2
        '
        'lblMiercoles
        '
        Me.lblMiercoles.AutoSize = True
        Me.lblMiercoles.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiercoles.ForeColor = System.Drawing.Color.Black
        Me.lblMiercoles.Location = New System.Drawing.Point(30, 7)
        Me.lblMiercoles.Name = "lblMiercoles"
        Me.lblMiercoles.Size = New System.Drawing.Size(82, 19)
        Me.lblMiercoles.TabIndex = 0
        Me.lblMiercoles.Text = "Miercoles"
        '
        'pnlDomingo
        '
        Me.pnlDomingo.BackColor = System.Drawing.Color.Silver
        Me.pnlDomingo.Controls.Add(Me.lnlLunes)
        Me.pnlDomingo.Location = New System.Drawing.Point(209, 0)
        Me.pnlDomingo.Name = "pnlDomingo"
        Me.pnlDomingo.Size = New System.Drawing.Size(200, 33)
        Me.pnlDomingo.TabIndex = 0
        '
        'lnlLunes
        '
        Me.lnlLunes.AutoSize = True
        Me.lnlLunes.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlLunes.ForeColor = System.Drawing.Color.Black
        Me.lnlLunes.Location = New System.Drawing.Point(44, 9)
        Me.lnlLunes.Name = "lnlLunes"
        Me.lnlLunes.Size = New System.Drawing.Size(53, 19)
        Me.lnlLunes.TabIndex = 0
        Me.lnlLunes.Text = "Lunes"
        '
        'frm_calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.pnlheaderdias)
        Me.Controls.Add(Me.flowpaneldias)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_calendario"
        Me.Text = "Reservas"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.pnlheaderdias.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlDomingo.ResumeLayout(False)
        Me.pnlDomingo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents header As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents btnsiguiente As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnanterior As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblheaderfecha As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlheaderdias As Panel
    Friend WithEvents flowpaneldias As FlowLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSabado As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblJueves As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblViernes As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblMiercoles As Label
    Friend WithEvents pnlDomingo As Panel
    Friend WithEvents lnlLunes As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMartes As Label
    Friend WithEvents btnhistorial As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
End Class
