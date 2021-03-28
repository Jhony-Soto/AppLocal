<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btncerrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.cmdCapturar = New Guna.UI.WinForms.GunaButton()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.AnimationHoverSpeed = 0.07!
        Me.btncerrar.AnimationSpeed = 0.03!
        Me.btncerrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btncerrar.BorderColor = System.Drawing.Color.Black
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncerrar.FocusedColor = System.Drawing.Color.Empty
        Me.btncerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Image = Global.Appsena.My.Resources.Resources.icons8_delete_64
        Me.btncerrar.ImageSize = New System.Drawing.Size(18, 18)
        Me.btncerrar.Location = New System.Drawing.Point(335, 3)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btncerrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btncerrar.OnHoverImage = Nothing
        Me.btncerrar.OnPressedColor = System.Drawing.Color.Black
        Me.btncerrar.Size = New System.Drawing.Size(20, 20)
        Me.btncerrar.TabIndex = 171
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        '
        'cmdCapturar
        '
        Me.cmdCapturar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCapturar.AnimationHoverSpeed = 0.03!
        Me.cmdCapturar.AnimationSpeed = 0.01!
        Me.cmdCapturar.BackColor = System.Drawing.Color.Transparent
        Me.cmdCapturar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.cmdCapturar.BorderColor = System.Drawing.Color.Transparent
        Me.cmdCapturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCapturar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdCapturar.FocusedColor = System.Drawing.Color.Empty
        Me.cmdCapturar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapturar.ForeColor = System.Drawing.Color.White
        Me.cmdCapturar.Image = Global.Appsena.My.Resources.Resources.icons8_picture_64
        Me.cmdCapturar.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdCapturar.Location = New System.Drawing.Point(104, 364)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cmdCapturar.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.cmdCapturar.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCapturar.OnHoverImage = Nothing
        Me.cmdCapturar.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCapturar.Radius = 10
        Me.cmdCapturar.Size = New System.Drawing.Size(143, 42)
        Me.cmdCapturar.TabIndex = 170
        Me.cmdCapturar.Text = "Tomar Foto"
        Me.ToolTip1.SetToolTip(Me.cmdCapturar, "Hacer foto")
        '
        'PicFoto
        '
        Me.PicFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicFoto.Location = New System.Drawing.Point(12, 26)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(332, 332)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 168
        Me.PicFoto.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 419)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.cmdCapturar)
        Me.Controls.Add(Me.PicFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents cmdCapturar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btncerrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
