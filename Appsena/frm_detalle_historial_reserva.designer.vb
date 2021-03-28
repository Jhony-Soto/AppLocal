<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_detalle_historial_reserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_detalle_historial_reserva))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.v = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbldocumento = New System.Windows.Forms.Label()
        Me.lblfecha_prestamo = New System.Windows.Forms.Label()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.lblficha = New System.Windows.Forms.Label()
        Me.lblprograma = New System.Windows.Forms.Label()
        Me.lblfecha_reserva = New System.Windows.Forms.Label()
        Me.lbltipo_prestamo = New System.Windows.Forms.Label()
        Me.lblnombres = New System.Windows.Forms.Label()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlfoto = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.dgdatos = New Guna.UI.WinForms.GunaDataGridView()
        Me.clm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmobservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblestado = New System.Windows.Forms.Label()
        CType(Me.pnlfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 616)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 5)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(5, 611)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(865, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(870, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 611)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de prestamo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de la reserva:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Categoria de la reserva:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(417, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha del prestamo:"
        '
        'v
        '
        Me.v.AutoSize = True
        Me.v.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v.Location = New System.Drawing.Point(417, 320)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(62, 19)
        Me.v.TabIndex = 10
        Me.v.Text = "Ficha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zurich", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Programa:"
        '
        'lbldocumento
        '
        Me.lbldocumento.AutoSize = True
        Me.lbldocumento.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocumento.Location = New System.Drawing.Point(154, 240)
        Me.lbldocumento.Name = "lbldocumento"
        Me.lbldocumento.Size = New System.Drawing.Size(58, 19)
        Me.lbldocumento.TabIndex = 12
        Me.lbldocumento.Text = "Label8"
        '
        'lblfecha_prestamo
        '
        Me.lblfecha_prestamo.AutoSize = True
        Me.lblfecha_prestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha_prestamo.Location = New System.Drawing.Point(607, 240)
        Me.lblfecha_prestamo.Name = "lblfecha_prestamo"
        Me.lblfecha_prestamo.Size = New System.Drawing.Size(67, 19)
        Me.lblfecha_prestamo.TabIndex = 14
        Me.lblfecha_prestamo.Text = "Label10"
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoria.Location = New System.Drawing.Point(636, 280)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(67, 19)
        Me.lblcategoria.TabIndex = 15
        Me.lblcategoria.Text = "Label11"
        '
        'lblficha
        '
        Me.lblficha.AutoSize = True
        Me.lblficha.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblficha.Location = New System.Drawing.Point(485, 320)
        Me.lblficha.Name = "lblficha"
        Me.lblficha.Size = New System.Drawing.Size(67, 19)
        Me.lblficha.TabIndex = 16
        Me.lblficha.Text = "Label12"
        '
        'lblprograma
        '
        Me.lblprograma.AutoSize = True
        Me.lblprograma.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprograma.Location = New System.Drawing.Point(522, 360)
        Me.lblprograma.Name = "lblprograma"
        Me.lblprograma.Size = New System.Drawing.Size(67, 19)
        Me.lblprograma.TabIndex = 17
        Me.lblprograma.Text = "Label13"
        '
        'lblfecha_reserva
        '
        Me.lblfecha_reserva.AutoSize = True
        Me.lblfecha_reserva.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha_reserva.Location = New System.Drawing.Point(219, 360)
        Me.lblfecha_reserva.Name = "lblfecha_reserva"
        Me.lblfecha_reserva.Size = New System.Drawing.Size(67, 19)
        Me.lblfecha_reserva.TabIndex = 18
        Me.lblfecha_reserva.Text = "Label14"
        '
        'lbltipo_prestamo
        '
        Me.lbltipo_prestamo.AutoSize = True
        Me.lbltipo_prestamo.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo_prestamo.Location = New System.Drawing.Point(203, 320)
        Me.lbltipo_prestamo.Name = "lbltipo_prestamo"
        Me.lbltipo_prestamo.Size = New System.Drawing.Size(67, 19)
        Me.lbltipo_prestamo.TabIndex = 19
        Me.lbltipo_prestamo.Text = "Label15"
        '
        'lblnombres
        '
        Me.lblnombres.AutoSize = True
        Me.lblnombres.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombres.Location = New System.Drawing.Point(131, 280)
        Me.lblnombres.Name = "lblnombres"
        Me.lblnombres.Size = New System.Drawing.Size(67, 19)
        Me.lblnombres.TabIndex = 20
        Me.lblnombres.Text = "Label16"
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Global.Appsena.My.Resources.Resources.icons8_cancel_64
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(836, 11)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.Size = New System.Drawing.Size(28, 28)
        Me.GunaCircleButton1.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.GunaCircleButton1, "Cerrar")
        '
        'pnlfoto
        '
        Me.pnlfoto.BackColor = System.Drawing.Color.Transparent
        Me.pnlfoto.BaseColor = System.Drawing.Color.Silver
        Me.pnlfoto.Location = New System.Drawing.Point(352, 11)
        Me.pnlfoto.Name = "pnlfoto"
        Me.pnlfoto.Size = New System.Drawing.Size(200, 200)
        Me.pnlfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pnlfoto.TabIndex = 49
        Me.pnlfoto.TabStop = False
        Me.pnlfoto.UseTransfarantBackground = False
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdatos.BackgroundColor = System.Drawing.Color.White
        Me.dgdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdatos.ColumnHeadersHeight = 40
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm, Me.clmcantidad, Me.clmobservaciones})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdatos.EnableHeadersVisualStyles = False
        Me.dgdatos.GridColor = System.Drawing.Color.White
        Me.dgdatos.Location = New System.Drawing.Point(36, 395)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgdatos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(790, 186)
        Me.dgdatos.TabIndex = 56
        Me.dgdatos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgdatos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.dgdatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgdatos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdatos.ThemeStyle.HeaderStyle.Height = 40
        Me.dgdatos.ThemeStyle.ReadOnly = True
        Me.dgdatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdatos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgdatos.ThemeStyle.RowsStyle.Height = 22
        Me.dgdatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgdatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'clm
        '
        Me.clm.HeaderText = "Descripción"
        Me.clm.Name = "clm"
        Me.clm.ReadOnly = True
        '
        'clmcantidad
        '
        Me.clmcantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmcantidad.HeaderText = "Cantidad"
        Me.clmcantidad.Name = "clmcantidad"
        Me.clmcantidad.ReadOnly = True
        Me.clmcantidad.Width = 80
        '
        'clmobservaciones
        '
        Me.clmobservaciones.HeaderText = "Observaciones"
        Me.clmobservaciones.Name = "clmobservaciones"
        Me.clmobservaciones.ReadOnly = True
        Me.clmobservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.Red
        Me.lblestado.Font = New System.Drawing.Font("Zurich BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.White
        Me.lblestado.Location = New System.Drawing.Point(32, 210)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(58, 19)
        Me.lblestado.TabIndex = 57
        Me.lblestado.Text = "Label8"
        '
        'frm_detalle_historial_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 616)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.dgdatos)
        Me.Controls.Add(Me.pnlfoto)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.lblnombres)
        Me.Controls.Add(Me.lbltipo_prestamo)
        Me.Controls.Add(Me.lblfecha_reserva)
        Me.Controls.Add(Me.lblprograma)
        Me.Controls.Add(Me.lblficha)
        Me.Controls.Add(Me.lblcategoria)
        Me.Controls.Add(Me.lblfecha_prestamo)
        Me.Controls.Add(Me.lbldocumento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_detalle_historial_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de la reserva"
        CType(Me.pnlfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label7 As Label
    Friend WithEvents v As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblnombres As Label
    Friend WithEvents lbltipo_prestamo As Label
    Friend WithEvents lblfecha_reserva As Label
    Friend WithEvents lblprograma As Label
    Friend WithEvents lblficha As Label
    Friend WithEvents lblcategoria As Label
    Friend WithEvents lblfecha_prestamo As Label
    Friend WithEvents lbldocumento As Label
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlfoto As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents dgdatos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents clm As DataGridViewTextBoxColumn
    Friend WithEvents clmcantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmobservaciones As DataGridViewTextBoxColumn
    Friend WithEvents lblestado As Label
End Class
