Imports System.IO
Public Class frm_historial_reservas
    Dim datos, titulo As Object

    Function paneles(dia_inicial, dia_final, sql)
        pnldatos.Controls.Clear() 'flowpanel es el panel que me contiene los paneles de cada uno de los dias


        datos = dia_reservas(dia_inicial, dia_final, sql) 'Llamamos la funcion y le enviamos las fechas como parametros
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Cargamos los datos en el datagrid que se usara para descargar el reporte
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"


        For Each row As DataRow In tabla.Rows
            '******** creamos el panel *************************
            Dim pnldetalle As New Guna.UI.WinForms.GunaShadowPanel 'Creamos una nueva instancia de panel

            If check_delete_usuario.Checked = True Then
                pnldetalle.Size = New Size(300, 460) 'definimos el tamanño de cada panel
            Else
                pnldetalle.Size = New Size(300, 410) 'definimos el tamanño de cada panel
            End If

            pnldetalle.BackColor = Color.White 'definimos el color de fondo
            pnldetalle.ShadowShift = 10

            '************** foto ************************
            Dim foto As New Guna.UI.WinForms.GunaCirclePictureBox
            foto.BaseColor = Color.Silver
            foto.Size = New Size(150, 150)
            foto.Left = 80
            foto.Top = 10
            If row("foto") IsNot DBNull.Value Then
                If File.Exists(row("foto")) Then
                    foto.Image = Image.FromFile(row("foto"))
                End If

            End If
            pnldetalle.Controls.Add(foto)

            '****************** labels con el tipo de cliente
            Dim lbltipo_cliente As New System.Windows.Forms.Label
            lbltipo_cliente.Text = "Tipo de cliente:"
            lbltipo_cliente.Size = New Size(140, 22)
            lbltipo_cliente.ForeColor = Color.Black
            lbltipo_cliente.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            lbltipo_cliente.Top = 170
            lbltipo_cliente.Left = 11
            pnldetalle.Controls.Add(lbltipo_cliente)


            Dim lbltipo_cliente1 As New System.Windows.Forms.Label
            lbltipo_cliente1.Text = row("tipo_cliente")
            lbltipo_cliente1.Size = New Size(100, 22)
            ToolTip1.SetToolTip(lbltipo_cliente1, row("tipo_cliente"))
            lbltipo_cliente1.ForeColor = Color.Black
            lbltipo_cliente1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            lbltipo_cliente1.Top = 170
            lbltipo_cliente1.Left = 150

            pnldetalle.Controls.Add(lbltipo_cliente1)

            '****************** labels con el documento del cliente
            Dim lbldocumento As New System.Windows.Forms.Label
            lbldocumento.Text = "Documento:"
            lbldocumento.Size = New Size(110, 22)
            lbldocumento.ForeColor = Color.Black
            lbldocumento.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            lbldocumento.Top = 200
            lbldocumento.Left = 11
            pnldetalle.Controls.Add(lbldocumento)

            Dim lbldocumento1 As New System.Windows.Forms.Label
            lbldocumento1.Text = row("documento")
            ToolTip1.SetToolTip(lbldocumento1, row("documento"))
            lbldocumento1.Size = New Size(165, 22)
            lbldocumento1.ForeColor = Color.Black
            lbldocumento1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            lbldocumento1.Top = 200
            lbldocumento1.Left = 120
            pnldetalle.Controls.Add(lbldocumento1)

            '****************** labels con el nombre de cliente
            Dim lblnombres As New System.Windows.Forms.Label
            lblnombres.Text = "Nombres:"
            lblnombres.Size = New Size(85, 22)
            lblnombres.ForeColor = Color.Black
            lblnombres.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            lblnombres.Top = 230
            lblnombres.Left = 11
            pnldetalle.Controls.Add(lblnombres)

            Dim lblnombres1 As New System.Windows.Forms.Label
            lblnombres1.Text = row("nombre")
            ToolTip1.SetToolTip(lblnombres1, row("nombre"))
            lblnombres1.Size = New Size(185, 22)
            lblnombres1.ForeColor = Color.Black
            lblnombres1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            lblnombres1.Top = 230
            lblnombres1.Left = 95
            pnldetalle.Controls.Add(lblnombres1)


            '****************** labels con la ficha
            Dim lblficha As New System.Windows.Forms.Label
            lblficha.Text = "Ficha:"
            lblficha.Size = New Size(60, 22)
            lblficha.ForeColor = Color.Black
            lblficha.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            lblficha.Top = 260
            lblficha.Left = 11
            pnldetalle.Controls.Add(lblficha)

            Dim lblficha1 As New System.Windows.Forms.Label
            lblficha1.Text = row("ficha")
            ToolTip1.SetToolTip(lblficha1, row("ficha"))
            lblficha1.Size = New Size(200, 22)
            lblficha1.ForeColor = Color.Black
            lblficha1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            lblficha1.Top = 260
            lblficha1.Left = 70
            pnldetalle.Controls.Add(lblficha1)

            '****************** labels con el programa
            Dim lblprograma As New System.Windows.Forms.Label
            lblprograma.Text = "Porgrama:"
            lblprograma.Size = New Size(95, 22)
            lblprograma.ForeColor = Color.Black
            lblprograma.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            lblprograma.Top = 290
            lblprograma.Left = 11

            pnldetalle.Controls.Add(lblprograma)

            Dim lblprograma1 As New System.Windows.Forms.Label
            lblprograma1.Text = row("programa")
            ToolTip1.SetToolTip(lblprograma1, row("programa"))
            lblprograma1.Size = New Size(180, 22)
            lblprograma1.ForeColor = Color.Black
            lblprograma1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            lblprograma1.Top = 290
            lblprograma1.Left = 105
            pnldetalle.Controls.Add(lblprograma1)

            '****************** labels con la fecha del prestam0
            Dim lblfecha As New System.Windows.Forms.Label
            lblfecha.Size = New Size(65, 22)
            lblfecha.Text = "Fecha:"
            lblfecha.ForeColor = Color.Black
            lblfecha.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            lblfecha.Top = 320
            lblfecha.Left = 11
            pnldetalle.Controls.Add(lblfecha)

            Dim lblfecha1 As New System.Windows.Forms.Label
            lblfecha1.Size = New Size(210, 22)
            lblfecha1.Text = row("fecha")
            ToolTip1.SetToolTip(lblfecha1, row("fecha"))
            lblfecha1.ForeColor = Color.Black
            lblfecha1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            lblfecha1.Top = 320
            lblfecha1.Left = 75
            pnldetalle.Controls.Add(lblfecha1)

            'label con el administrador que elimino la rserva
            If check_delete_usuario.Checked = True And check_delete_sistema.Checked = False And check_prestados.Checked = False Then

                If row("Administrador") IsNot DBNull.Value Then

                    Dim lbladmin As New System.Windows.Forms.Label
                    lbladmin.Size = New Size(125, 22)
                    lbladmin.Text = "Administrador:"
                    lbladmin.ForeColor = Color.Black
                    lbladmin.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
                    lbladmin.Top = 350
                    lbladmin.Left = 11
                    pnldetalle.Controls.Add(lbladmin)

                    Dim lbladmin1 As New System.Windows.Forms.Label
                    lbladmin1.Size = New Size(130, 22)
                    lbladmin1.Text = row("Administrador")
                    ToolTip1.SetToolTip(lbladmin1, row("Administrador"))
                    lbladmin1.ForeColor = Color.Black
                    lbladmin1.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
                    lbladmin1.Top = 350
                    lbladmin1.Left = 135
                    pnldetalle.Controls.Add(lbladmin1)

                End If
            End If


            ' ********** botones de ver mas *********
            Dim btn As New Guna.UI.WinForms.GunaButton
            btn.BaseColor = Color.FromArgb(37, 136, 120)
            btn.Tag = row("codigo")
            btn.Image = Nothing
            ToolTip1.SetToolTip(btn, "Ver detalle de la reserva")
            btn.Font = New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)
            btn.ForeColor = Color.White
            btn.OnHoverBaseColor = Color.FromArgb(21, 82, 72)
            btn.Size = New Size(100, 35)
            btn.TextAlign = HorizontalAlignment.Center
            btn.Cursor = Cursors.Hand
            btn.Text = "Ver más"
            btn.Radius = 10

            If check_delete_usuario.Checked = True Then
                btn.Top = 410
            Else
                btn.Top = 350
            End If


            btn.Left = 100
            AddHandler btn.Click, AddressOf ver_mas
            pnldetalle.Controls.Add(btn)
            pnldatos.Controls.Add(pnldetalle)


        Next
    End Function

    Private Sub frm_historial_reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frm_historial_reservas_Click
        Next

        picker_dia_final.Value = Date.Now
        picker_dia_inicial.Value = Date.Now

        paneles(picker_dia_inicial.Value.Date, picker_dia_final.Value.Date, "sp_tbl_historial_reservas_fechas")
        titulo = "HISTORIAL GENERAL DE RESERVAS"

    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frm_historial_reservas_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub

    Private Sub ver_mas(sender As Object, e As EventArgs)
        Dim codreserva = CType(sender, Guna.UI.WinForms.GunaButton).Tag
        datos = Reserva_selectPK(codreserva, "sp_tbl_reserva_selecPK") 'enviamos a la funcion los porametros y gurdamnos en una variable lo que nos devuelve
        'guardamos en una tabla los datos para asi manipularlos de una mejor manera
        tabla = New DataTable
        tabla = datos.tables("datos")

        Dim registros = tabla.Rows.Count 'contamos el nmero de filas que tiene la tabla
        If registros <> 0 Then

            With frm_detalle_historial_reserva
                'Documento
                .lbldocumento.Text = tabla(0)(1)
                'Nombres
                .lblnombres.Text = tabla(0)(2)
                'tipo_prestami
                .lbltipo_prestamo.Text = tabla(0)(4)
                'fecha reserva
                .lblfecha_reserva.Text = tabla(0)(6)
                'fecha prestamo
                .lblfecha_prestamo.Text = tabla(0)(7)
                'catehoria de la reserva
                .lblcategoria.Text = tabla(0)(10)
                'ficha
                .lblficha.Text = tabla(0)(11)
                'programa
                .lblprograma.Text = tabla(0)(12)
                'foto
                If tabla(0)(13) IsNot DBNull.Value Then
                    If File.Exists(tabla(0)(13)) Then
                        .pnlfoto.Image = Image.FromFile(tabla(0)(13))
                    End If
                End If
                .codreserva = codreserva

                'Mostramos el estado de la reserva dependiendo el codigo del estado
                Select Case tabla(0)(5)
                    Case 0
                        .lblestado.Text = "Eliminada por el sistema."
                        .lblestado.BackColor = Color.Red
                    Case 2
                        .lblestado.Text = "Eliminada por el administrador."
                        .lblestado.BackColor = Color.Red
                    Case 3
                        .lblestado.Text = "Reclamada por el cliente."
                        .lblestado.BackColor = Color.Green
                End Select

                .ShowDialog()
            End With
        End If


    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If picker_dia_inicial.Value.Date > picker_dia_final.Value.Date Then
            MsgBox("La fecha inicial debe ser menor  a la fecha final", vbCritical)
        Else
            'Si esta checkeado para mostrar las reservas reclamadas
            If check_prestados.Checked = True Then
                paneles(picker_dia_inicial.Value.Date, picker_dia_final.Value.Date, "sp_tbl_historial_reservas_reclamadas")
                titulo = "RESERVAS RECLAMADAS POR EL CLIENTE"
            Else
                'Si esta checkeado para mostrar las reservas eliminadas por el administrador
                If check_delete_usuario.Checked = True Then
                    paneles(picker_dia_inicial.Value.Date, picker_dia_final.Value.Date, "sp_tbl_historial_reservas_delete_admin")
                    titulo = "RESERVAS ELIMINADAS POR EL ADMINISTRADOR"
                Else
                    'Si esta checkeado para mostrar las reservas eliminadas por el sistema
                    If check_delete_sistema.Checked = True Then
                        paneles(picker_dia_inicial.Value.Date, picker_dia_final.Value.Date, "sp_tbl_historial_reservas_delete_sistema")
                        titulo = "RESERVAS ELIMINADAS POR EL SISTEMA"
                    Else
                        paneles(picker_dia_inicial.Value.Date, picker_dia_final.Value.Date, "sp_tbl_historial_reservas_fechas")
                        titulo = "HISTORIAL GENERAL DE RESERVAS"
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub check_prestados_CheckedChanged(sender As Object, e As EventArgs) Handles check_prestados.CheckedChanged
        Cursor = Cursors.WaitCursor
        If check_prestados.Checked = True Then
            check_delete_usuario.Checked = False 'Eliminamos el check 
            check_delete_sistema.Checked = False 'Eliminamos el check 

            btnbuscar_Click(Nothing, Nothing)
        Else
            btnbuscar_Click(Nothing, Nothing)
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub check_delete_usuario_CheckedChanged(sender As Object, e As EventArgs) Handles check_delete_usuario.CheckedChanged
        Cursor = Cursors.WaitCursor
        If check_delete_usuario.Checked = True Then
            check_delete_sistema.Checked = False 'Eliminamos el check 
            check_prestados.Checked = False 'Eliminamos el check 
            btnbuscar_Click(Nothing, Nothing)
        Else
            btnbuscar_Click(Nothing, Nothing)
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub btn_reporte_excel_Click(sender As Object, e As EventArgs) Handles btn_reporte_excel.Click
        'funccion para imprimir el reporte en excel de las reservas
        Cursor = Cursors.WaitCursor
        descargar_plantilla_bajas(dgexportar, titulo)
        Cursor = Cursors.Default
    End Sub

    Private Sub check_delete_sistema_CheckedChanged(sender As Object, e As EventArgs) Handles check_delete_sistema.CheckedChanged
        Cursor = Cursors.WaitCursor
        If check_delete_sistema.Checked = True Then
            check_delete_usuario.Checked = False 'Eliminamos el check 
            check_prestados.Checked = False 'Eliminamos el check 
            btnbuscar_Click(Nothing, Nothing)
        Else
            btnbuscar_Click(Nothing, Nothing)
        End If
        Cursor = Cursors.Default
    End Sub
End Class