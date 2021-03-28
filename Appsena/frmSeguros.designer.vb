<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguros))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnagg1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btnagg2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.btnagg3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.lblSeguro1 = New System.Windows.Forms.Label()
        Me.lblSeguro2 = New System.Windows.Forms.Label()
        Me.lblSeguro3 = New System.Windows.Forms.Label()
        Me.TimerFile = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaLimitHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaLimit = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.gbxFechaLimite = New System.Windows.Forms.GroupBox()
        Me.Panel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.gbxFechaLimite.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 5)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 415)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 5)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(651, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 410)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 410)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCircleButton1)
        Me.Panel5.Controls.Add(Me.lblTitulo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(646, 33)
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(613, 3)
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
        Me.lblTitulo.Size = New System.Drawing.Size(646, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Formato de seguro"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GunaPanel1.Controls.Add(Me.btnagg1)
        Me.GunaPanel1.Location = New System.Drawing.Point(35, 72)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(163, 176)
        Me.GunaPanel1.TabIndex = 7
        '
        'btnagg1
        '
        Me.btnagg1.AnimationHoverSpeed = 0.07!
        Me.btnagg1.AnimationSpeed = 0.03!
        Me.btnagg1.BaseColor = System.Drawing.Color.White
        Me.btnagg1.BorderColor = System.Drawing.Color.Black
        Me.btnagg1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagg1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnagg1.FocusedColor = System.Drawing.Color.Empty
        Me.btnagg1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnagg1.ForeColor = System.Drawing.Color.White
        Me.btnagg1.Image = Global.Appsena.My.Resources.Resources.icons8_add_file_64
        Me.btnagg1.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnagg1.Location = New System.Drawing.Point(50, 62)
        Me.btnagg1.Name = "btnagg1"
        Me.btnagg1.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.btnagg1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnagg1.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagg1.OnHoverImage = Nothing
        Me.btnagg1.OnPressedColor = System.Drawing.Color.Black
        Me.btnagg1.Size = New System.Drawing.Size(60, 60)
        Me.btnagg1.TabIndex = 2
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GunaPanel2.Controls.Add(Me.btnagg2)
        Me.GunaPanel2.Location = New System.Drawing.Point(247, 72)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(163, 176)
        Me.GunaPanel2.TabIndex = 8
        '
        'btnagg2
        '
        Me.btnagg2.AnimationHoverSpeed = 0.07!
        Me.btnagg2.AnimationSpeed = 0.03!
        Me.btnagg2.BaseColor = System.Drawing.Color.White
        Me.btnagg2.BorderColor = System.Drawing.Color.Black
        Me.btnagg2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagg2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnagg2.FocusedColor = System.Drawing.Color.Empty
        Me.btnagg2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnagg2.ForeColor = System.Drawing.Color.White
        Me.btnagg2.Image = Global.Appsena.My.Resources.Resources.icons8_add_file_64
        Me.btnagg2.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnagg2.Location = New System.Drawing.Point(52, 62)
        Me.btnagg2.Name = "btnagg2"
        Me.btnagg2.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.btnagg2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnagg2.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagg2.OnHoverImage = Nothing
        Me.btnagg2.OnPressedColor = System.Drawing.Color.Black
        Me.btnagg2.Size = New System.Drawing.Size(60, 60)
        Me.btnagg2.TabIndex = 0
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.GunaPanel3.Controls.Add(Me.btnagg3)
        Me.GunaPanel3.Location = New System.Drawing.Point(461, 72)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(163, 176)
        Me.GunaPanel3.TabIndex = 9
        '
        'btnagg3
        '
        Me.btnagg3.AnimationHoverSpeed = 0.07!
        Me.btnagg3.AnimationSpeed = 0.03!
        Me.btnagg3.BaseColor = System.Drawing.Color.White
        Me.btnagg3.BorderColor = System.Drawing.Color.Black
        Me.btnagg3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagg3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnagg3.FocusedColor = System.Drawing.Color.Empty
        Me.btnagg3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnagg3.ForeColor = System.Drawing.Color.White
        Me.btnagg3.Image = Global.Appsena.My.Resources.Resources.icons8_add_file_64
        Me.btnagg3.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnagg3.Location = New System.Drawing.Point(50, 62)
        Me.btnagg3.Name = "btnagg3"
        Me.btnagg3.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.btnagg3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnagg3.OnHoverForeColor = System.Drawing.Color.White
        Me.btnagg3.OnHoverImage = Nothing
        Me.btnagg3.OnPressedColor = System.Drawing.Color.Black
        Me.btnagg3.Size = New System.Drawing.Size(60, 60)
        Me.btnagg3.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Transparent
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Appsena.My.Resources.Resources.icons8_save_64
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(268, 377)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 10
        Me.btnGuardar.Size = New System.Drawing.Size(114, 31)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "Guardar"
        '
        'lblSeguro1
        '
        Me.lblSeguro1.AutoSize = True
        Me.lblSeguro1.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguro1.Location = New System.Drawing.Point(66, 51)
        Me.lblSeguro1.Name = "lblSeguro1"
        Me.lblSeguro1.Size = New System.Drawing.Size(99, 18)
        Me.lblSeguro1.TabIndex = 1
        Me.lblSeguro1.Text = "Seguro No. 1"
        '
        'lblSeguro2
        '
        Me.lblSeguro2.AutoSize = True
        Me.lblSeguro2.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguro2.Location = New System.Drawing.Point(279, 51)
        Me.lblSeguro2.Name = "lblSeguro2"
        Me.lblSeguro2.Size = New System.Drawing.Size(99, 18)
        Me.lblSeguro2.TabIndex = 61
        Me.lblSeguro2.Text = "Seguro No. 2"
        '
        'lblSeguro3
        '
        Me.lblSeguro3.AutoSize = True
        Me.lblSeguro3.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguro3.Location = New System.Drawing.Point(492, 51)
        Me.lblSeguro3.Name = "lblSeguro3"
        Me.lblSeguro3.Size = New System.Drawing.Size(99, 18)
        Me.lblSeguro3.TabIndex = 62
        Me.lblSeguro3.Text = "Seguro No. 3"
        '
        'TimerFile
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 18)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "* El seguro de los elementos puede ser renovado máximo dos veces"
        '
        'dtpFechaLimitHora
        '
        Me.dtpFechaLimitHora.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpFechaLimitHora.CalendarFont = New System.Drawing.Font("Zurich BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaLimitHora.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpFechaLimitHora.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.dtpFechaLimitHora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaLimitHora.CustomFormat = "hh:mm tt"
        Me.dtpFechaLimitHora.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaLimitHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaLimitHora.Location = New System.Drawing.Point(220, 26)
        Me.dtpFechaLimitHora.Name = "dtpFechaLimitHora"
        Me.dtpFechaLimitHora.ShowUpDown = True
        Me.dtpFechaLimitHora.Size = New System.Drawing.Size(69, 27)
        Me.dtpFechaLimitHora.TabIndex = 66
        '
        'dtpFechaLimit
        '
        Me.dtpFechaLimit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpFechaLimit.BackColor = System.Drawing.Color.Transparent
        Me.dtpFechaLimit.BaseColor = System.Drawing.Color.White
        Me.dtpFechaLimit.BorderColor = System.Drawing.Color.Silver
        Me.dtpFechaLimit.Checked = False
        Me.dtpFechaLimit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaLimit.CustomFormat = "dd 'de' MMMM/yyyy"
        Me.dtpFechaLimit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaLimit.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFechaLimit.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaLimit.ForeColor = System.Drawing.Color.Black
        Me.dtpFechaLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaLimit.Location = New System.Drawing.Point(6, 23)
        Me.dtpFechaLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaLimit.Name = "dtpFechaLimit"
        Me.dtpFechaLimit.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFechaLimit.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dtpFechaLimit.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpFechaLimit.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFechaLimit.Radius = 10
        Me.dtpFechaLimit.Size = New System.Drawing.Size(208, 30)
        Me.dtpFechaLimit.TabIndex = 65
        Me.dtpFechaLimit.Text = "13 de marzo/2020"
        Me.dtpFechaLimit.Value = New Date(2020, 1, 17, 16, 8, 22, 916)
        '
        'gbxFechaLimite
        '
        Me.gbxFechaLimite.Controls.Add(Me.dtpFechaLimit)
        Me.gbxFechaLimite.Controls.Add(Me.dtpFechaLimitHora)
        Me.gbxFechaLimite.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFechaLimite.Location = New System.Drawing.Point(176, 295)
        Me.gbxFechaLimite.Name = "gbxFechaLimite"
        Me.gbxFechaLimite.Size = New System.Drawing.Size(298, 63)
        Me.gbxFechaLimite.TabIndex = 67
        Me.gbxFechaLimite.TabStop = False
        Me.gbxFechaLimite.Text = "Nueva fecha limite de entrega"
        Me.gbxFechaLimite.Visible = False
        '
        'frmSeguros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 420)
        Me.Controls.Add(Me.gbxFechaLimite)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeguro3)
        Me.Controls.Add(Me.lblSeguro2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblSeguro1)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeguros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeguros"
        Me.Panel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.gbxFechaLimite.ResumeLayout(False)
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
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnagg2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnagg1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnagg3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblSeguro1 As Label
    Friend WithEvents lblSeguro2 As Label
    Friend WithEvents lblSeguro3 As Label
    Friend WithEvents TimerFile As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaLimitHora As DateTimePicker
    Friend WithEvents dtpFechaLimit As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents gbxFechaLimite As GroupBox
End Class
