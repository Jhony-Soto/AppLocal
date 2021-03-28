<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sincronizacion
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnl_progres = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.lbl_sinconizado = New System.Windows.Forms.Label()
        Me.pnl_ok = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lbl_termino = New System.Windows.Forms.Label()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.pnl_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'pnl_progres
        '
        Me.pnl_progres.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_progres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_progres.Location = New System.Drawing.Point(335, 43)
        Me.pnl_progres.Name = "pnl_progres"
        Me.pnl_progres.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnl_progres.Size = New System.Drawing.Size(350, 350)
        Me.pnl_progres.TabIndex = 3
        '
        'lbl_sinconizado
        '
        Me.lbl_sinconizado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_sinconizado.AutoSize = True
        Me.lbl_sinconizado.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sinconizado.Location = New System.Drawing.Point(397, 396)
        Me.lbl_sinconizado.Name = "lbl_sinconizado"
        Me.lbl_sinconizado.Size = New System.Drawing.Size(234, 25)
        Me.lbl_sinconizado.TabIndex = 4
        Me.lbl_sinconizado.Text = "Sincronizando datos ..."
        '
        'pnl_ok
        '
        Me.pnl_ok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_ok.BaseColor = System.Drawing.Color.White
        Me.pnl_ok.Image = Global.Appsena.My.Resources.Resources.icons8_ok_green_64
        Me.pnl_ok.Location = New System.Drawing.Point(153, 212)
        Me.pnl_ok.Name = "pnl_ok"
        Me.pnl_ok.Size = New System.Drawing.Size(120, 120)
        Me.pnl_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pnl_ok.TabIndex = 5
        Me.pnl_ok.TabStop = False
        Me.pnl_ok.UseTransfarantBackground = False
        Me.pnl_ok.Visible = False
        '
        'lbl_termino
        '
        Me.lbl_termino.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_termino.AutoSize = True
        Me.lbl_termino.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_termino.Location = New System.Drawing.Point(320, 263)
        Me.lbl_termino.Name = "lbl_termino"
        Me.lbl_termino.Size = New System.Drawing.Size(587, 25)
        Me.lbl_termino.TabIndex = 6
        Me.lbl_termino.Text = "¡Ha terminado la sincronización de los datos exitosamente!"
        Me.lbl_termino.Visible = False
        '
        'BackgroundWorker
        '
        '
        'frm_sincronizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 642)
        Me.Controls.Add(Me.lbl_termino)
        Me.Controls.Add(Me.pnl_ok)
        Me.Controls.Add(Me.lbl_sinconizado)
        Me.Controls.Add(Me.pnl_progres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_sincronizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronización"
        CType(Me.pnl_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnl_progres As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents pnl_ok As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lbl_sinconizado As Label
    Friend WithEvents lbl_termino As Label
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
