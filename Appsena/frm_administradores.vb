Imports System.IO
Public Class frm_administradores
    Public datos, arreglo, fila, swich_nuevo_admin, documento, swich_registro, swich_H As Object
    Function limpiar_controles()
        'Ocultamos los controles
        lbliniciaol.Visible = False
        picker_dia_inicial.Visible = False
        lblfinal.Visible = False
        picker_dia_final.Visible = False
        btnbuscar.Visible = False
        lblheader.Visible = False
        pnlheader.Visible = False

        'le damos el valor de la fecha de hoy a los datetimepicker
        picker_dia_inicial.Value = Date.Now.Date
        picker_dia_final.Value = Date.Now.Date
    End Function


    Public Sub frm_administradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbuscador.Focus()

        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frm_administradores_Click
        Next

        limpiar_controles()

        'Cargamos los dtos de los administradores en el datagrid
        datos = CargarDatos("sp_tbl_administradores_select")
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Ocultamos la ruta de la foto y el codigo del tipo de documento
        dgdatos.Columns(5).Visible = False
        dgdatos.Columns(6).Visible = False
        dgdatos.Columns(8).Visible = False

        'Obtenemos los datos del administrador principál
        datos = CargarDatos("sp_tbl_administrador_tipo_admin")
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Si el usuario es el administrador principal
        If SESSION(0) = tabla(0)(0) Then
            dgdatos.Columns(0).Visible = True
            documento = tabla(0)(0)
            btnagregar.Visible = True
        Else
            dgdatos.Columns(0).Visible = False
            btnagregar.Visible = False
        End If


        'fecha actual menos 6 meses atras para elimnar los registros del logeo y refrescar la tabla
        Dim fecha_Actual As Date = DateTime.Now.Date
        reserva_select_fecha_prestamo(fecha_Actual.AddMonths(-6), "sp_tbl_logeo_delete")

        btnregistros.Text = dgdatos.RowCount
    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frm_administradores_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub


    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        pnladmin.Visible = False
    End Sub

    Private Sub AdministradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradoresToolStripMenuItem.Click
        swich_H = 0
        dgdatos.Enabled = True
        dgdatos.Columns(0).Visible = True
        frm_administradores_Load(Nothing, Nothing) 'Cargamos de nuevo el formulario
    End Sub


    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If picker_dia_inicial.Value > picker_dia_final.Value Then
            MsgBox("La fecha inicial no debe ser mayor a la fecha final.", vbCritical)
        Else
            arreglo = {txtbuscador.Text, picker_dia_inicial.Value, picker_dia_final.Value}
            datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_logeo_fechas_reporte")
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"
            dgdatos.Columns(1).Visible = False
            btnregistros.Text = dgdatos.RowCount
        End If

    End Sub

    Private Sub HistorialDeAdministradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeAdministradoresToolStripMenuItem.Click
        swich_H = 1
        'dgdatos.Enabled = False
        dgdatos.Columns(0).Visible = False
        'Mostramos los siguientes controles
        btnagregar.Visible = False
        lbliniciaol.Visible = True
        picker_dia_inicial.Visible = True
        lblfinal.Visible = True
        picker_dia_final.Visible = True
        btnbuscar.Visible = True
        lblheader.Visible = True
        pnlheader.Visible = True

        'Obtenemos los datos del historial de  logeos
        arreglo = {txtbuscador.Text, picker_dia_inicial.Value, picker_dia_final.Value}
        datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_logeo_fechas_reporte")

        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        dgdatos.Columns(1).Visible = False


        btnregistros.Text = dgdatos.RowCount
    End Sub



    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        swich_registro = 1
        frm_registrarme.ShowDialog()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        If MessageBox.Show("¿Desea cambiar de administrador principal? " & vbLf & "Al hacerlo perderá los privilegios que tiene.", "Cambiar administrador principal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            swich_nuevo_admin = 1
            MsgBox("Elija el nuevo administrador principal haciendo doble click en el registro.", vbInformation)
            pnladmin.Visible = False
        End If
    End Sub

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        If swich_H = 1 Then
            arreglo = {txtbuscador.Text, picker_dia_inicial.Value, picker_dia_final.Value}
            datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_logeo_fechas_reporte")

            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"
            dgdatos.Columns(1).Visible = False
        Else
            'Buscador automatico para los administradores
            datos = Select_1ParametroInt("sp_tbl_administradores_selectPK", txtbuscador.Text)
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'Ocultamos la ruta de la foto y el codigo del tipo de documento
            dgdatos.Columns(5).Visible = False
            dgdatos.Columns(6).Visible = False
            dgdatos.Columns(8).Visible = False
        End If


        btnregistros.Text = dgdatos.RowCount
    End Sub

    Private Sub dgdatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellClick
        If swich_H <> 1 Then
            If swich_nuevo_admin <> 1 Then
                If e.RowIndex = -1 Then
                    Return
                Else
                    Select Case e.ColumnIndex
                        Case 0
                            fila = dgdatos.CurrentRow.Index
                            If SESSION(0) = dgdatos.Rows(fila).Cells(1).Value Then
                                MsgBox("No puedes eliminar al administrador principal", vbCritical)
                            Else
                                'Eliminar un administrador
                                If MessageBox.Show("¿Está seguro que desea eliminar el administrador?", "Eliminar administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                                    datos = tbl_cliente_delete(dgdatos.Rows(fila).Cells(1).Value, "sp_tbl_administrador_delete")
                                    If datos = 1 Then
                                        MsgBox("Se eliminó correctamente el registro !", vbInformation)
                                    End If
                                    frm_administradores_Load(Nothing, Nothing) 'recargamos el datagrid
                                End If
                            End If

                    End Select
                End If
            End If
        End If

    End Sub

    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        If swich_H <> 1 Then
            'validamos si se quiere cambiar de administrador principal
            If swich_nuevo_admin = 1 Then
                fila = dgdatos.CurrentRow.Index 'obtenemos dnde se dio el click
                'Cambiamos el tipo_admin del administrador principal
                datos = tbl_tipo_admin(documento, "sp_tbl_administrador_principal_update")
                If datos = 1 Then
                    datos = tbl_tipo_admin(dgdatos.Rows(fila).Cells(1).Value, "sp_tbl_administrador_principal")
                    MsgBox("Se cambio de administrador principal correctamente " & vbLf & "Cerráremos sesión para actualizar los datos", vbInformation)
                    frmDashBoard.btnCerrarSesion_Click(Nothing, Nothing)
                End If

            Else

                'obtenemos la fila donde se dio el click
                fila = dgdatos.CurrentRow.Index

                'limpiamos en pnlfoto
                pnlfoto.Image = Nothing

                documento = dgdatos.Rows(fila).Cells(1).Value
                'mostramos todos los datos del administrador en el panel
                'Docuemnto
                lbldocumento.Text = dgdatos.Rows(fila).Cells(1).Value
                'Nombres
                lblnombres.Text = dgdatos.Rows(fila).Cells(2).Value
                'Correo
                lblcorreo.Text = dgdatos.Rows(fila).Cells(3).Value
                'Telefono
                lbltelefono.Text = dgdatos.Rows(fila).Cells(4).Value
                'Validaos que la ruta de la foto no sea nulla y que exista en el equipo
                CargarImg(pnlfoto, dgdatos.Rows(fila).Cells(5).Value, "del administrador")

                'Tipo docuemnto
                lbltipo_documento.Text = dgdatos.Rows(fila).Cells(7).Value

                'Tipo administrador
                If dgdatos.Rows(fila).Cells(8).Value = 1 Then
                    lblestado.Visible = True
                    If SESSION(0) = dgdatos.Rows(fila).Cells(1).Value Then
                        btnconsultar.Visible = True
                    End If
                Else
                    lblestado.Visible = False
                    btnconsultar.Visible = False
                End If

                pnladmin.Visible = True
            End If

        End If


    End Sub

End Class