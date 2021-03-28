<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_progresbar
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
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.lbl_termino = New System.Windows.Forms.Label()
        Me.dgimportar = New System.Windows.Forms.DataGridView()
        Me.Background_subir = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Background_elementos = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgimportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(192, 115)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(222, 211)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 0
        '
        'lbl_termino
        '
        Me.lbl_termino.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_termino.AutoSize = True
        Me.lbl_termino.Font = New System.Drawing.Font("Zurich BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_termino.Location = New System.Drawing.Point(212, 329)
        Me.lbl_termino.Name = "lbl_termino"
        Me.lbl_termino.Size = New System.Drawing.Size(201, 25)
        Me.lbl_termino.TabIndex = 7
        Me.lbl_termino.Text = "Subiendo archivo..."
        '
        'dgimportar
        '
        Me.dgimportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgimportar.Location = New System.Drawing.Point(26, 12)
        Me.dgimportar.Name = "dgimportar"
        Me.dgimportar.Size = New System.Drawing.Size(554, 107)
        Me.dgimportar.TabIndex = 8
        Me.dgimportar.Visible = False
        '
        'Background_subir
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 5)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 484)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 489)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(606, 5)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(606, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 489)
        Me.Panel4.TabIndex = 10
        '
        'Background_elementos
        '
        '
        'frm_progresbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 494)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgimportar)
        Me.Controls.Add(Me.lbl_termino)
        Me.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_progresbar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subiendo archivo"
        CType(Me.dgimportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents lbl_termino As Label
    Friend WithEvents dgimportar As DataGridView
    Friend WithEvents Background_subir As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Background_elementos As System.ComponentModel.BackgroundWorker
End Class
