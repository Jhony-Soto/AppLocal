
Imports System.ComponentModel

Public Class frm_elementos
    Public datos, arreglo, filas_datagrid, filas, array, marcas, dispo, ruta, tipo_baja, swich_ruta, titulo, swich_categoria As Object


    'Atributos que nesecitamos para crear la pagimnacion del datagrid
    Dim total_datos As Integer = 0 'guardamos el total de los registros
    Dim pagina As Integer = 1  'Guardaremos la pagina en la cual estamos
    Dim maximo_paginas As Integer = 0 'Guardaremos el nmumero de paginas que se generan 
    Dim numero_registros As Integer = 50 'el numero de regsitros que mostraremos por cada pagina
    Public anterior As Integer = 0
    Public siguiente As Integer = numero_registros

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frm_clientes_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub

    Private Sub frm_elementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frm_clientes_Click
        Next


        'Activamos el checkbox
        cbxtodos.Checked = True
        checkactivos.Checked = False
        checkmora.Checked = False

        'Cargamos la tabala con informacion
        Reload(anterior, siguiente)
        Cursor = Cursors.Default
    End Sub

    Function Reload(anterior, siguiente)

        ''Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = Select_1ParametroInt("sp_tbl_elementos_select2", "")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgexportar2.DataSource = datos
        dgexportar2.DataMember = "datos"

        'Contamos los datos que nos regresa la consulta
        tabla = New DataTable
        tabla = datos.tables("datos")
        total_datos = tabla.Rows.Count
        lblpagina.Text = pagina
        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
        lbl_total_paginas.Text = "/ " & maximo_paginas


        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        arreglo = {txtbuscador.Text, anterior, siguiente}
        datos = tbl_clientes_paginado(arreglo, "sp_tbl_elementos_select2_paginador")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"


        'Ocultamos algunas  columnas de codigos
        dgdatos.Columns(8).Visible = False
        dgdatos.Columns(10).Visible = False
        dgdatos.Columns(12).Visible = False
        dgdatos.Columns(16).Visible = False
        dgdatos.Columns(18).Visible = False
        dgdatos.Columns(19).Visible = False
        dgdatos.Columns(20).Visible = False
        dgdatos.Columns(21).Visible = False
        dgdatos.Columns(22).Visible = False

        dgdatos.Columns(0).Width = 50
        dgdatos.Columns(5).Width = 55
        dgdatos.Columns(6).Width = 55

        'Damos formato de moneda 
        dgdatos.Columns(15).DefaultCellStyle.Format = "c"

        'obtenemos el numero de registros totales de elementos
        datos = CargarDatos("sp_contador_elementos")
        tabla = New DataTable
        tabla = datos.tables("datos")
        btnregistros.Text = tabla(0)(0)

    End Function

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        'Buscador automatico, Busca por codigo y nombre
        If txtbuscador.Text <> "" Then
            'Si esta activo el checkbox de los elementos que tienen prestamo activo
            If checkactivos.Checked = True Then
                datos = Select_1ParametroInt("sp_tbl_elementos_prestamo_activoPK", txtbuscador.Text)
                dgdatos.DataSource = datos
                dgdatos.DataMember = "datos"

                'cargamos los datos en el datgrid que se usara para exportatr excel
                dgexportar2.DataSource = datos
                dgexportar2.DataMember = "datos"
                titulo = "ELEMENTOS CON EL PRESTAMO ACTIVO."

            Else
                'Buscamos elementos en mora
                If checkmora.Checked = True Then
                    datos = Select_1ParametroInt("sp_tbl_mora_selectPK", txtbuscador.Text)
                    dgdatos.DataSource = datos
                    dgdatos.DataMember = "datos"


                    'cargamos los datos en el datgrid que se usara para exportatr excel
                    dgexportar2.DataSource = datos
                    dgexportar2.DataMember = "datos"
                    titulo = "ELEMENTOS EN MORA ACTUALMENTE."

                Else


                    'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
                    If cbxtodos.Checked = True Then
                        ''Cargamos los datos desde la funcion a la cual enviamos el procedimiento
                        datos = Select_1ParametroInt("sp_tbl_elementos_select2", txtbuscador.Text)
                        'los datos que recivimos de la funcion los mostramos en el datagrid
                        dgexportar2.DataSource = datos
                        dgexportar2.DataMember = "datos"

                        'Contamos los datos que nos regresa la consulta
                        tabla = New DataTable
                        tabla = datos.tables("datos")
                        total_datos = tabla.Rows.Count
                        lblpagina.Text = pagina
                        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
                        lbl_total_paginas.Text = "/ " & maximo_paginas


                        arreglo = {txtbuscador.Text, anterior, siguiente}
                        datos = tbl_clientes_paginado(arreglo, "sp_tbl_elementos_select2_paginador")
                        'los datos que recibimos de la funcion los mostramos en el datagrid
                        dgdatos.DataSource = datos
                        dgdatos.DataMember = "datos"

                    Else

                        arreglo = {txtbuscador.Text, cmbcategoria.SelectedValue}
                        datos = Buscador_keyUp_elementos(arreglo, "sp_tbl_elemento_select_keyUp")
                        'los datos que recivimos de la funcion los mostramos en el datagrid


                        tabla = New DataTable
                        tabla = datos.tables("datos")
                        total_datos = tabla.Rows.Count
                        lblpagina.Text = pagina
                        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
                        lbl_total_paginas.Text = "/ " & maximo_paginas


                        'Paginado
                        arreglo = {txtbuscador.Text, cmbcategoria.SelectedValue, anterior, siguiente}
                        datos = Buscador_keyUp_elementos_paginado(arreglo, "sp_tbl_elemento_select_keyUp2")
                        dgdatos.DataSource = datos
                        dgdatos.DataMember = "datos"
                    End If

                    'Ocultamos algunas  columnas de codigos
                    dgdatos.Columns(8).Visible = False
                    dgdatos.Columns(10).Visible = False
                    dgdatos.Columns(12).Visible = False
                    dgdatos.Columns(16).Visible = False


                    dgdatos.Columns(0).Width = 50
                    dgdatos.Columns(5).Width = 55
                    dgdatos.Columns(6).Width = 55
                End If
            End If

        Else
            If swich_categoria = 1 Then
                cmbcategoria_SelectionChangeCommitted(Nothing, Nothing)
            Else
                If checkactivos.Checked = True Then
                    checkactivos_CheckedChanged(Nothing, Nothing)
                Else
                    If checkmora.Checked = True Then
                        checkmora_CheckedChanged(Nothing, Nothing)
                    Else
                        Reload(anterior, siguiente)
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'Abrimos el formulario 
        With frm_insert_update_elemento
            .ShowDialog()
        End With
    End Sub

    Private Sub cmbcategoria_GotFocus(sender As Object, e As EventArgs) Handles cmbcategoria.GotFocus
        'esta fucnion nos carga todos los registros de los clientes
        datos = CargarDatos("sp_tbl_categoria_select")
        tabla = New DataTable
        tabla = datos.tables("datos")

        'mostramos los datos en el combo box
        cmbcategoria.DataSource = tabla
        cmbcategoria.DisplayMember = "nombre"
        cmbcategoria.ValueMember = "codigo"
    End Sub

    Private Sub btnexcel_Click(sender As Object, e As EventArgs) Handles btnexcel.Click
        'Ocultamos o mostramos el panel
        If pnlexcel.Visible = False Then
            pnlexcel.Visible = True
        Else
            pnlexcel.Visible = False
        End If
    End Sub

    Private Sub cmbcategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcategoria.SelectionChangeCommitted
        'Buscador automatico, Busca por codigo y nombre
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        arreglo = {txtbuscador.Text, cmbcategoria.SelectedValue}
        datos = Buscador_keyUp_elementos(arreglo, "sp_tbl_elemento_select_keyUp")


        'cargamos el datagrid que se exporta a excel
        dgexportar2.DataSource = datos
        dgexportar2.DataMember = "datos"

        'Contamos los datos que nos regresa la consulta
        tabla = New DataTable
        tabla = datos.tables("datos")
        total_datos = tabla.Rows.Count
        lblpagina.Text = pagina
        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
        lbl_total_paginas.Text = "/ " & maximo_paginas
        'Paginado
        arreglo = {txtbuscador.Text, cmbcategoria.SelectedValue, anterior, siguiente}
        datos = Buscador_keyUp_elementos_paginado(arreglo, "sp_tbl_elemento_select_keyUp2")

        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        dgdatos.Columns(13).Visible = False
        dgdatos.Columns(0).Width = 50
        dgdatos.Columns(5).Width = 55
        dgdatos.Columns(6).Width = 55

        btnregistros.Text = dgdatos.Rows.Count
    End Sub

    Private Sub frm_elementos_Click(sender As Object, e As EventArgs) Handles Me.Click
        pnlexcel.Visible = False
    End Sub

    Private Sub cbxtodos_CheckedChanged(sender As Object, e As EventArgs) Handles cbxtodos.CheckedChanged
        'Validamos el estado en el que esta el checkbox
        If cbxtodos.Checked = True Then

            checkactivos.Checked = False
            checkmora.Checked = False
            dgdatos.DataSource = Nothing
            txtbuscador.Visible = True
            cmbcategoria.Enabled = False
            Reload(anterior, siguiente)
            swich_categoria = 0
        Else
            checkactivos.Checked = False
            checkmora.Checked = False
            cmbcategoria.Enabled = True
            cmbcategoria.Select()
            swich_categoria = 1
        End If
    End Sub

    Private Sub dgdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick

        If e.RowIndex = -1 Then
            Return
        Else
            Select Case e.ColumnIndex
                Case 0
                    Dim row = dgdatos.CurrentRow.Index

                    If dgdatos.Rows(row).Cells(6).Value > 1 Then
                        'Para dar de baja elementos con mayor disponiblidad
                        'Validamos si esta seguro de realizar la operacion
                        If MessageBox.Show("¿Esta seguro que desea dar de baja al elemento ?", "Dar de baja elemento.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                            'mostramos los datos en el panel de bajas
                            lblelemento.Text = dgdatos.Rows(row).Cells(2).Value 'Nombre del elemento
                            lblcodigo.Text = dgdatos.Rows(row).Cells(1).Value 'codigo del elemento 
                            txtcantidad.Text = "1"
                            pnlbaja.Visible = True

                            dispo = dgdatos.Rows(row).Cells(6).Value
                        End If
                    Else
                        'Validamos si esta seguro de realizar la oper/acion
                        If MessageBox.Show("¿Esta seguro que desea dar de baja al elemento ?", "Dar de baja elemento.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then

                            'mostramos los datos en el panel de bajas
                            lblelemento.Text = dgdatos.Rows(row).Cells(2).Value 'Nombre del elemento
                            lblcodigo.Text = dgdatos.Rows(row).Cells(1).Value 'codigo del elemento
                            txtcantidad.Enabled = False
                            txtcantidad.Text = "1"
                            pnlbaja.Visible = True
                            dispo = dgdatos.Rows(row).Cells(6).Value
                        End If
                    End If

            End Select
        End If


    End Sub

    Private Sub checkactivos_CheckedChanged(sender As Object, e As EventArgs) Handles checkactivos.CheckedChanged
        If checkactivos.Checked = True Then
            'Quitamos el checked dela mora
            checkmora.Checked = False
            btnagregar.Visible = False
            btnexcel.Visible = False
            pnlcontroles.Visible = False
            pnl_paginador.Visible = False

            btn_reporte_excel.Visible = True

            datos = CargarDatos("sp_tbl_elementos_prestamo_activo")

            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            dgdatos.Columns(0).Visible = False

            'cargamos los datos en el datgrid que se usara para exportatr excel
            dgexportar2.DataSource = datos
            dgexportar2.DataMember = "datos"
            titulo = "ELEMENTOS CON EL PRESTAMO ACTIVO."

            contador(dgdatos) 'contamos l numero de registros

        Else
            'mostramos de nuevo los controles
            btnagregar.Visible = True
            btnexcel.Visible = True
            pnlcontroles.Visible = True
            dgdatos.Enabled = True
            pnl_paginador.Visible = True
            btn_reporte_excel.Visible = False


            dgdatos.Columns(0).Visible = True

            Reload(anterior, siguiente)
        End If
    End Sub

    Private Sub checkmora_CheckedChanged(sender As Object, e As EventArgs) Handles checkmora.CheckedChanged
        If checkmora.Checked = True Then
            'Quitamos el checked dela mora
            checkactivos.Checked = False
            btnagregar.Visible = False
            btnexcel.Visible = False
            pnlcontroles.Visible = False
            pnl_paginador.Visible = False
            btn_reporte_excel.Visible = True

            datos = CargarDatos("sp_tbl_elementos_mora")

            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'cargamos los datos en el datgrid que se usara para exportatr excel
            dgexportar2.DataSource = datos
            dgexportar2.DataMember = "datos"
            titulo = "ELEMENTOS EN MORA ACTUALMENTE."

            contador(dgdatos) 'contamos l numero de registros

            dgdatos.Columns(0).Visible = False
        Else
            'mostramos de nuevo los controles
            btnagregar.Visible = True
            btnexcel.Visible = True
            pnlcontroles.Visible = True
            dgdatos.Enabled = True
            dgdatos.Columns(0).Visible = True
            pnl_paginador.Visible = True
            btn_reporte_excel.Visible = False

            Reload(anterior, siguiente)
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        txtobservaciones.Text = ""
        pnlbaja.Visible = False
        txtcantidad.Enabled = True
    End Sub

    Private Sub btnguardar_baja_Click(sender As Object, e As EventArgs) Handles btnguardar_baja.Click
        If radio_definitiva.Checked = False And radio_temporal.Checked = False Then
            MsgBox("Por favor elija un tipo de baja para el elemento.", vbCritical)
        Else
            If dispo < txtcantidad.Text Then
                MsgBox("La cantidad ingresada es mayor a la disponibilidad", vbCritical)
            Else
                'Guardamos elementos con cantidad y disponibilidad de 1
                If txtcantidad.Enabled = False Then
                    If txtobservaciones.Text = "" Or btn_archivo.Visible = True And swich_ruta = 0 Then
                        MsgBox("Por favor diligencie todos los campos y adjunte el archivo PDF", vbCritical)
                        txtobservaciones.Focus()
                    Else
                        'Para baja temporal el codigo es 1 si es definitiva es 0
                        If radio_temporal.Checked = True Then
                            tipo_baja = 1

                        Else
                            tipo_baja = 0
                        End If

                        'Insertamos los datos en la tabla de bajas
                        arreglo = {lblcodigo.Text, txtobservaciones.Text, Date.Now, DBNull.Value, txtcantidad.Text, SESSION(0), tipo_baja, ruta}
                        insert_tbl_bajas(arreglo, "sp_tbl_baja_insert")

                        'cambiamos el estado del elemento a 0 
                        arreglo = {lblcodigo.Text, "0"}
                        tbl_elementos_delete(arreglo, "sp_tbl_elemento_delete", "dio de baja")

                        UpdateDispoElemento(lblcodigo.Text, dispo - txtcantidad.Text)
                        Reload(anterior, siguiente) 'recargamos el datagrid

                        txtcantidad.Enabled = True
                        txtcantidad.Text = ""
                        pnlbaja.Visible = False
                        txtobservaciones.Text = ""
                        btn_archivo.Visible = False
                        lblruta.Visible = False
                        lblruta.Text = ""
                        radio_temporal.Checked = False
                        radio_definitiva.Checked = False
                    End If
                Else
                    'Guardamos elementos con cantidad y disponibilidad mayores a 1
                    If txtobservaciones.Text = "" Or txtcantidad.Text = "" Or btn_archivo.Visible = True And swich_ruta = 0 Then
                        MsgBox("Por favor diligencie todos los campos y adjunte el archivo PDF.", vbCritical)
                        txtcantidad.Focus()
                    Else
                        'Para baja temporal el codigo es 1 si es definitiva es 0
                        If radio_temporal.Checked = True Then
                            tipo_baja = 1

                        Else
                            tipo_baja = 0
                        End If
                        'Insertamos los datos en la tabla de bajas
                        arreglo = {lblcodigo.Text, txtobservaciones.Text, Date.Now, DBNull.Value, txtcantidad.Text, SESSION(0), tipo_baja, ruta}
                        insert_tbl_bajas(arreglo, "sp_tbl_baja_insert")

                        'cambiamos la disponibilida del elemento
                        UpdateDispoElemento(lblcodigo.Text, dispo - txtcantidad.Text)
                        Reload(anterior, siguiente)
                        txtcantidad.Enabled = True
                        pnlbaja.Visible = False
                        btn_archivo.Visible = False
                        lblruta.Visible = False
                        lblruta.Text = ""
                        txtobservaciones.Text = ""
                        radio_temporal.Checked = False
                        radio_definitiva.Checked = False
                        MsgBox("Se dio de baja el elemento exitosamente", vbInformation)
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        'abrimos el formulario de bajs
        CerrarPestañas()
        BajarNivel(frm_bajas)
        With frm_bajas
            'ejcutamos el metodo 
            .HistorialToolStripMenuItem_Click(Nothing, Nothing)
        End With
    End Sub

    Private Sub BajasActualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasActualesToolStripMenuItem.Click
        'abrimos el formulario de bajs
        CerrarPestañas()
        BajarNivel(frm_bajas)
        With frm_bajas
            'ejcutamos el metodo 
            .BajasActualesToolStripMenuItem_Click(Nothing, Nothing)
        End With
    End Sub

    Private Sub items_historial_Click(sender As Object, e As EventArgs) Handles items_historial.Click
        'cargamo el formulario
        With frm_buscar_elemento
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_reporte_excel_Click(sender As Object, e As EventArgs) Handles btn_reporte_excel.Click
        'Descaragamos el reporte que hay en el datagrid
        Cursor = Cursors.WaitCursor
        descargar_plantilla_bajas(dgexportar2, titulo)
        Cursor = Cursors.Default
    End Sub

    Function contador(datagrid)
        btnregistros.Text = datagrid.rows.count()
    End Function

    Public Function buscar_prestamos()

        'Cargamos los prestamos de un elemento entre dos fechas
        arreglo = {array, picker_dia_inicial.Value.Date, picker_dia_final.Value.Date}
        datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_elemeentos_prestamos_hechos")
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Ocultamos la columna '0
        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(1).Visible = False
        dgdatos.Columns(2).Visible = False
        dgdatos.Columns(3).Visible = False
        dgdatos.Columns(4).Visible = False

        For i = 0 To dgdatos.Rows.Count - 1
            If dgdatos.Rows(i).Cells(4).Value = 2 Then
                dgdatos.Rows(i).DefaultCellStyle.ForeColor = Color.FromArgb(253, 110, 37)
            End If
        Next


        'cargamos los datos en el datgrid que se usara para exportatr excel
        dgexportar2.DataSource = datos
        dgexportar2.DataMember = "datos"
        titulo = "PRESTAMOS DEL ELEMENTO."

        contador(dgdatos) 'contamos l numero de registros

    End Function

    Public Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If picker_dia_inicial.Value > picker_dia_final.Value Then
            MsgBox("La fecha inicial no debe ser mayor a la fecha final.", vbCritical)
        Else
            buscar_prestamos()
        End If
    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        If lblpagina.Text > 1 Then
            'Cuandos se esta mostrando elementos por cada categoria
            If swich_categoria = 1 Then
                pagina = pagina - 1
                lblpagina.Text = pagina
                siguiente = siguiente - numero_registros - 1
                anterior = anterior - numero_registros - 1
                cmbcategoria_SelectionChangeCommitted(Nothing, Nothing)

            Else
                'Pagina principal
                pagina = pagina - 1
                lblpagina.Text = pagina
                siguiente = siguiente - numero_registros - 1
                anterior = anterior - numero_registros - 1

                Reload(anterior, siguiente)
            End If

        End If
    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        'Mostramos la pagina siguiente del dategird
        If lblpagina.Text <> maximo_paginas Then
            If swich_categoria = 1 Then
                pagina = pagina + 1
                lblpagina.Text = pagina
                siguiente = siguiente + numero_registros + 1
                anterior = anterior + numero_registros + 1
                cmbcategoria_SelectionChangeCommitted(Nothing, Nothing)
            Else
                pagina = pagina + 1
                lblpagina.Text = pagina
                siguiente = siguiente + numero_registros + 1
                anterior = anterior + numero_registros + 1

                Reload(anterior, siguiente)
            End If

        End If
    End Sub

    Private Sub btn_ultima_pagina_Click(sender As Object, e As EventArgs) Handles btn_ultima_pagina.Click
        'Mostramos la pagina anteriopr del dategird
        If swich_categoria = 1 Then
            pagina = maximo_paginas
            lblpagina.Text = pagina
            siguiente = numero_registros * maximo_paginas
            anterior = siguiente - numero_registros

            cmbcategoria_SelectionChangeCommitted(Nothing, Nothing)
        Else
            pagina = maximo_paginas
            lblpagina.Text = pagina
            siguiente = numero_registros * maximo_paginas
            anterior = siguiente - numero_registros

            Reload(anterior, siguiente)
        End If

    End Sub

    Private Sub btn_primera_pagina_Click(sender As Object, e As EventArgs) Handles btn_primera_pagina.Click
        'primera pagina del datagrid
        If swich_categoria = 1 Then
            pagina = pagina - pagina + 1
            lblpagina.Text = pagina
            siguiente = numero_registros
            anterior = 0
            cmbcategoria_SelectionChangeCommitted(Nothing, Nothing)
        Else
            pagina = pagina - pagina + 1
            lblpagina.Text = pagina
            siguiente = numero_registros
            anterior = 0
            Reload(anterior, siguiente)
        End If

    End Sub


    Private Sub BajasDefinitivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasDefinitivasToolStripMenuItem.Click
        'abrimos el formulario de bajs
        CerrarPestañas()
        BajarNivel(frm_bajas)
        With frm_bajas
            'ejcutamos el metodo 
            .BajasDefinitivasToolStripMenuItem_Click(Nothing, Nothing)
        End With
    End Sub

    Private Sub cmbcategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategoria.SelectedIndexChanged
        btn_primera_pagina_Click(Nothing, Nothing)
    End Sub

    Private Sub ElementosConsumidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementosConsumidosToolStripMenuItem.Click
        'Mostramos loe elementos consumidos
        CerrarPestañas()
        BajarNivel(frm_bajas)
        With frm_bajas
            .ElementosConsumidosToolStripMenuItem_Click(Nothing, Nothing)
        End With
    End Sub


    Private Sub radio_definitiva_CheckedChanged(sender As Object, e As EventArgs) Handles radio_definitiva.CheckedChanged
        'validamos si esta chekeado el radio buton
        If radio_definitiva.Checked = True Then
            'validamos que timpo de elementos es,de consumo o devolutivo
            datos = SelectElemento(lblcodigo.Text, 1)
            If datos.rows(0)(3) = 1 Then
                btn_archivo.Visible = True
                lblruta.Visible = True
            End If
        End If
    End Sub

    Private Sub btn_archivo_Click(sender As Object, e As EventArgs) Handles btn_archivo.Click
        Dim archivo As New OpenFileDialog

        If archivo.ShowDialog = DialogResult.OK Then
            ruta = archivo.FileName
            lblruta.Text = ruta
            lblruta.Visible = True
            swich_ruta = 1
        Else
            ruta = DBNull.Value
            swich_ruta = 0
        End If
    End Sub

    Private Sub radio_temporal_CheckedChanged(sender As Object, e As EventArgs) Handles radio_temporal.CheckedChanged
        'validamos si esta chekeado el radio buton
        If radio_temporal.Checked = True Then
            btn_archivo.Visible = False
            lblruta.Visible = False
            ruta = DBNull.Value
        End If
    End Sub


    '********************** METODO PARA SUBIR ARCHIVOS MASIVAMENTE *********************************
    Private Sub btnsubir_Click(sender As Object, e As EventArgs) Handles btnsubir.Click



        'Enviamos el datagrid en el cual se subiran los datos
        importarExcel(frm_progresbar.dgimportar)


        With frm_progresbar
            .clientes = False
            .ShowDialog()
        End With

        Cursor = Cursors.Default


    End Sub

    Private Sub btnplantilla_Click(sender As Object, e As EventArgs) Handles btnplantilla.Click
        Cursor = Cursors.WaitCursor

        'Obtenemos los tipos de elementos que hay en la BD para mostrarlos en la plantilla
        datos = CargarDatos("sp_tbl_tipo_elemento_select")
        tabla = New DataTable
        tabla = datos.tables("datos")
        For i = 0 To tabla.Rows.Count - 1
            dgplantilla.Rows.Add()
            dgplantilla.Rows(i).Cells(6).Value = tabla(i)(1)
        Next

        'Obtenemos las categorias de elemento en  la BD para mostrarlos en la plantilla
        datos = CargarDatos("sp_tbl_categoria_select")
        tabla = New DataTable
        tabla = datos.tables("datos")
        For i = 0 To tabla.Rows.Count - 1
            dgplantilla.Rows.Add()
            dgplantilla.Rows(i).Cells(7).Value = tabla(i)(1)
        Next

        'Deswcargamos la plantilla
        descargar_plantilla(dgplantilla)

        Cursor = Cursors.Default
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Cursor = Cursors.WaitCursor

        'Obtenemos los datos del base de datos
        datos = CargarDatos("sp_tbl_elementos_ReportePDF")
        'Mostramos los datos en el data grid
        dgexportar2.DataSource = datos
        dgexportar2.DataMember = "datos"
        'Descargamos la plantilla con los datos 
        descargar_plantilla_elementos(dgexportar2)
        Cursor = Cursors.Default
    End Sub

    Private Sub btnexcel_Leave(sender As Object, e As EventArgs) Handles btnexcel.Leave
        'se oculta el panel
        pnlexcel.Visible = False
    End Sub


    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'Obtenemos la fila donde se dio el doble click
        If checkactivos.Checked <> True Then
            If checkmora.Checked <> True Then
                If btnbuscar.Visible = False Then
                    Dim fila = dgdatos.CurrentRow.Index
                    'enviamos la informacion al formualario para que se edite
                    With frm_insert_update_elemento
                        'titulo del formulario
                        .lblheader.Text = "Editar elemento."

                        .txtcodigo.Enabled = False
                        .txtcodigo.Text = dgdatos.Rows(fila).Cells(1).Value

                        'Centros
                        .pnlcentro.Visible = True
                        .txtcentro.Text = dgdatos.Rows(fila).Cells(13).Value
                        .txtcentro.Visible = True
                        .codcentro = dgdatos.Rows(fila).Cells(12).Value

                        'validamos si es un campo nulo
                        If dgdatos.Rows(fila).Cells(3).Value Is DBNull.Value Then
                            .txtplaca.Text = ""
                        Else
                            .txtplaca.Text = dgdatos.Rows(fila).Cells(3).Value
                        End If

                        'validamos si es un campo nulo
                        If dgdatos.Rows(fila).Cells(4).Value Is DBNull.Value Then
                            .txtserial.Text = ""
                        Else
                            .txtserial.Text = dgdatos.Rows(fila).Cells(4).Value
                        End If

                        'categoria
                        .txtcategoria.Text = dgdatos.Rows(fila).Cells(11).Value
                        .categoria = dgdatos.Rows(fila).Cells(10).Value
                        .txtcategoria.Visible = True
                        .cmbcategoria.Visible = False
                        .linkcategoria.Visible = True

                        'Nombre 
                        .txtnombre.Text = dgdatos.Rows(fila).Cells(21).Value

                        'tipo elemento
                        .txttipo_elemento.Text = dgdatos.Rows(fila).Cells(9).Value
                        .tipo_elemento = dgdatos.Rows(fila).Cells(8).Value
                        .txttipo_elemento.Visible = True
                        .linktipo_elemento.Visible = True
                        .cmbtipoelemento.Visible = False

                        'Ubicacion
                        .txtubicacion.Text = dgdatos.Rows(fila).Cells(7).Value

                        .cmbmarca.Enabled = False
                        .cmbmodelo.Enabled = False
                        .btnmarca.Enabled = False
                        .btnmodelo.Enabled = False

                        'fecha
                        .pickerfecha.Value = dgdatos.Rows(fila).Cells(14).Value
                        'cantidad
                        .ncantidad.Value = dgdatos.Rows(fila).Cells(5).Value
                        .cantidad = dgdatos.Rows(fila).Cells(5).Value
                        'disponibles
                        .ndisponible.Value = dgdatos.Rows(fila).Cells(6).Value
                        'valor
                        .txtvalor.Text = dgdatos.Rows(fila).Cells(15).Value

                        'Observaciones
                        'validamos si es un campo nulo
                        If dgdatos.Rows(fila).Cells(17).Value Is DBNull.Value Then
                            .txtobservaciones.Text = ""
                        Else
                            .txtobservaciones.Text = dgdatos.Rows(fila).Cells(17).Value
                        End If

                        'Foto del elemento
                        If dgdatos.Rows(fila).Cells(16).Value IsNot DBNull.Value Then
                            .ptbFotoelemento.Image = Image.FromFile(dgdatos.Rows(fila).Cells(16).Value)
                            .ptbFotoelemento.SizeMode = PictureBoxSizeMode.StretchImage
                            .ruta = dgdatos.Rows(fila).Cells(16).Value
                        End If


                        'Modelo
                        .codmodelo = dgdatos.Rows(fila).Cells(18).Value
                        .txtmodelos.Text = dgdatos.Rows(fila).Cells(19).Value
                        .txtmodelos.Visible = True

                        'marca
                        .txtmarcas.Text = dgdatos.Rows(fila).Cells(20).Value
                        .txtmarcas.Visible = True
                        'volvemos los botnes a su estado inicial
                        .btnactualizar.Visible = True
                        .btnguardar.Visible = False
                        .ShowDialog()
                    End With
                End If
            End If
        End If




    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        SoloNumeros(e) 'Admite solo numeros
    End Sub

    Private Sub txtbuscador_GotFocus(sender As Object, e As EventArgs) Handles txtbuscador.GotFocus
        If checkactivos.Checked <> True Then
            If checkmora.Checked <> True Then
                btn_primera_pagina_Click(Nothing, Nothing)
            End If

        End If

    End Sub


End Class




