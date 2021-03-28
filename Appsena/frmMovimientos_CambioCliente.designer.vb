<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos_CambioCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_CambioCliente))
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.txtDocumento = New Guna.UI.WinForms.GunaTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel5)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel4)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel3)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel2)
        Me.GunaShadowPanel1.Controls.Add(Me.lblInicial)
        Me.GunaShadowPanel1.Controls.Add(Me.txtDocumento)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(993, 506)
        Me.GunaShadowPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 33)
        Me.Panel1.TabIndex = 13
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(950, 3)
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
        Me.lblTitulo.Size = New System.Drawing.Size(983, 33)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Información del cliente"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 501)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(983, 5)
        Me.Panel5.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(988, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 501)
        Me.Panel4.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 501)
        Me.Panel3.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(993, 5)
        Me.Panel2.TabIndex = 9
        '
        'lblInicial
        '
        Me.lblInicial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInicial.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.Location = New System.Drawing.Point(321, 52)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(327, 28)
        Me.lblInicial.TabIndex = 8
        Me.lblInicial.Text = "Documento del cliente final"
        Me.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumento
        '
        Me.txtDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDocumento.BackColor = System.Drawing.Color.Transparent
        Me.txtDocumento.BaseColor = System.Drawing.Color.White
        Me.txtDocumento.BorderColor = System.Drawing.Color.Silver
        Me.txtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocumento.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtDocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDocumento.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(321, 83)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocumento.Radius = 10
        Me.txtDocumento.Size = New System.Drawing.Size(327, 30)
        Me.txtDocumento.TabIndex = 1
        Me.txtDocumento.Tag = "1"
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtDocumento, "Digitar el número de documento")
        '
        'frmMovimientos_CambioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 506)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientos_CambioCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMovimientos_CambioCliente"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents lblInicial As Label
    Friend WithEvents txtDocumento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitulo As Label
End Class
