<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebcamForm
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
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Apagar = New System.Windows.Forms.Button()
        Me.ButtonELIMINAR = New System.Windows.Forms.Button()
        Me.ButtonFINSERIEDIARIA = New System.Windows.Forms.Button()
        Me.ButtonSERIEDIARIA = New System.Windows.Forms.Button()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.PCAPTURA = New System.Windows.Forms.PictureBox()
        Me.FORMATO = New System.Windows.Forms.Button()
        Me.FSERIE = New System.Windows.Forms.Button()
        Me.SERIE = New System.Windows.Forms.Button()
        Me.FGRABAR = New System.Windows.Forms.Button()
        Me.GRABAR = New System.Windows.Forms.Button()
        Me.CAPTURAR = New System.Windows.Forms.Button()
        Me.INICIAR = New System.Windows.Forms.Button()
        Me.VISOR = New System.Windows.Forms.PictureBox()
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Apagar
        '
        Me.Apagar.Location = New System.Drawing.Point(487, 394)
        Me.Apagar.Name = "Apagar"
        Me.Apagar.Size = New System.Drawing.Size(114, 23)
        Me.Apagar.TabIndex = 70
        Me.Apagar.Text = "Apagar"
        Me.Apagar.UseVisualStyleBackColor = True
        '
        'ButtonELIMINAR
        '
        Me.ButtonELIMINAR.Location = New System.Drawing.Point(487, 365)
        Me.ButtonELIMINAR.Name = "ButtonELIMINAR"
        Me.ButtonELIMINAR.Size = New System.Drawing.Size(162, 23)
        Me.ButtonELIMINAR.TabIndex = 69
        Me.ButtonELIMINAR.Text = "Eliminar carpetas"
        Me.ButtonELIMINAR.UseVisualStyleBackColor = True
        '
        'ButtonFINSERIEDIARIA
        '
        Me.ButtonFINSERIEDIARIA.Location = New System.Drawing.Point(346, 394)
        Me.ButtonFINSERIEDIARIA.Name = "ButtonFINSERIEDIARIA"
        Me.ButtonFINSERIEDIARIA.Size = New System.Drawing.Size(114, 23)
        Me.ButtonFINSERIEDIARIA.TabIndex = 68
        Me.ButtonFINSERIEDIARIA.Text = "Fin serie diaria"
        Me.ButtonFINSERIEDIARIA.UseVisualStyleBackColor = True
        '
        'ButtonSERIEDIARIA
        '
        Me.ButtonSERIEDIARIA.Location = New System.Drawing.Point(346, 365)
        Me.ButtonSERIEDIARIA.Name = "ButtonSERIEDIARIA"
        Me.ButtonSERIEDIARIA.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSERIEDIARIA.TabIndex = 67
        Me.ButtonSERIEDIARIA.Text = "Serie diaria"
        Me.ButtonSERIEDIARIA.UseVisualStyleBackColor = True
        '
        'GUARDAR
        '
        Me.GUARDAR.Location = New System.Drawing.Point(254, 394)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.GUARDAR.TabIndex = 66
        Me.GUARDAR.Text = "Guardar"
        Me.GUARDAR.UseVisualStyleBackColor = True
        '
        'PCAPTURA
        '
        Me.PCAPTURA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PCAPTURA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCAPTURA.Location = New System.Drawing.Point(499, 24)
        Me.PCAPTURA.Name = "PCAPTURA"
        Me.PCAPTURA.Size = New System.Drawing.Size(276, 209)
        Me.PCAPTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCAPTURA.TabIndex = 65
        Me.PCAPTURA.TabStop = False
        '
        'FORMATO
        '
        Me.FORMATO.Location = New System.Drawing.Point(173, 394)
        Me.FORMATO.Name = "FORMATO"
        Me.FORMATO.Size = New System.Drawing.Size(75, 23)
        Me.FORMATO.TabIndex = 64
        Me.FORMATO.Text = "Formato"
        Me.FORMATO.UseVisualStyleBackColor = True
        '
        'FSERIE
        '
        Me.FSERIE.Location = New System.Drawing.Point(92, 394)
        Me.FSERIE.Name = "FSERIE"
        Me.FSERIE.Size = New System.Drawing.Size(75, 23)
        Me.FSERIE.TabIndex = 63
        Me.FSERIE.Text = "Fserie"
        Me.FSERIE.UseVisualStyleBackColor = True
        '
        'SERIE
        '
        Me.SERIE.Location = New System.Drawing.Point(11, 394)
        Me.SERIE.Name = "SERIE"
        Me.SERIE.Size = New System.Drawing.Size(75, 23)
        Me.SERIE.TabIndex = 62
        Me.SERIE.Text = "Serie"
        Me.SERIE.UseVisualStyleBackColor = True
        '
        'FGRABAR
        '
        Me.FGRABAR.Location = New System.Drawing.Point(254, 365)
        Me.FGRABAR.Name = "FGRABAR"
        Me.FGRABAR.Size = New System.Drawing.Size(75, 23)
        Me.FGRABAR.TabIndex = 61
        Me.FGRABAR.Text = "Fgrabar"
        Me.FGRABAR.UseVisualStyleBackColor = True
        '
        'GRABAR
        '
        Me.GRABAR.Location = New System.Drawing.Point(173, 365)
        Me.GRABAR.Name = "GRABAR"
        Me.GRABAR.Size = New System.Drawing.Size(75, 23)
        Me.GRABAR.TabIndex = 60
        Me.GRABAR.Text = "Grabar"
        Me.GRABAR.UseVisualStyleBackColor = True
        '
        'CAPTURAR
        '
        Me.CAPTURAR.Location = New System.Drawing.Point(92, 365)
        Me.CAPTURAR.Name = "CAPTURAR"
        Me.CAPTURAR.Size = New System.Drawing.Size(75, 23)
        Me.CAPTURAR.TabIndex = 59
        Me.CAPTURAR.Text = "Capturar"
        Me.CAPTURAR.UseVisualStyleBackColor = True
        '
        'INICIAR
        '
        Me.INICIAR.Location = New System.Drawing.Point(11, 365)
        Me.INICIAR.Name = "INICIAR"
        Me.INICIAR.Size = New System.Drawing.Size(75, 23)
        Me.INICIAR.TabIndex = 58
        Me.INICIAR.Text = "Iniciar"
        Me.INICIAR.UseVisualStyleBackColor = True
        '
        'VISOR
        '
        Me.VISOR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VISOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VISOR.Location = New System.Drawing.Point(32, 24)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(449, 335)
        Me.VISOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VISOR.TabIndex = 57
        Me.VISOR.TabStop = False
        '
        'WebcamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 440)
        Me.Controls.Add(Me.Apagar)
        Me.Controls.Add(Me.ButtonELIMINAR)
        Me.Controls.Add(Me.ButtonFINSERIEDIARIA)
        Me.Controls.Add(Me.ButtonSERIEDIARIA)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.PCAPTURA)
        Me.Controls.Add(Me.FORMATO)
        Me.Controls.Add(Me.FSERIE)
        Me.Controls.Add(Me.SERIE)
        Me.Controls.Add(Me.FGRABAR)
        Me.Controls.Add(Me.GRABAR)
        Me.Controls.Add(Me.CAPTURAR)
        Me.Controls.Add(Me.INICIAR)
        Me.Controls.Add(Me.VISOR)
        Me.Name = "WebcamForm"
        Me.Text = "WebcamForm"
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Reloj As System.Windows.Forms.Timer
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Apagar As System.Windows.Forms.Button
    Friend WithEvents ButtonELIMINAR As System.Windows.Forms.Button
    Friend WithEvents ButtonFINSERIEDIARIA As System.Windows.Forms.Button
    Friend WithEvents ButtonSERIEDIARIA As System.Windows.Forms.Button
    Friend WithEvents GUARDAR As System.Windows.Forms.Button
    Friend WithEvents PCAPTURA As System.Windows.Forms.PictureBox
    Friend WithEvents FORMATO As System.Windows.Forms.Button
    Friend WithEvents FSERIE As System.Windows.Forms.Button
    Friend WithEvents SERIE As System.Windows.Forms.Button
    Friend WithEvents FGRABAR As System.Windows.Forms.Button
    Friend WithEvents GRABAR As System.Windows.Forms.Button
    Friend WithEvents CAPTURAR As System.Windows.Forms.Button
    Friend WithEvents INICIAR As System.Windows.Forms.Button
    Friend WithEvents VISOR As System.Windows.Forms.PictureBox
End Class
