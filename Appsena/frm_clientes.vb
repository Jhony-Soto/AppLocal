Imports System.ComponentModel
Imports System.IO

Public Class frm_clientes

    Public datos, fila, swdocumento, swcliente, coddocumento, Arreglo, array, swich_eliminados, swich_tipos, swich_moroso As Object
    Dim fecha_Actual As DateTime = DateTime.Today

    'Atributos que nesecitamos para crear la pagimnacion del datagrid
    Dim total_datos As Integer = 0 'guardamos el total de los registros
    Dim pagina As Integer = 1  'Guardaremos la pagina en la cual estamos
    Dim maximo_paginas As Integer = 0 'Guardaremos el nmumero de paginas que se generan 
    Dim numero_registros As Integer = 50 'el numero de regsitros que mostraremos por cada pagina
    Public anterior As Integer = 0
    Public siguiente As Integer = numero_registros




    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbxtodos.Checked = True
        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frm_clientes_Click
        Next
        Reload(anterior, siguiente) 'cargamos los datos de los clientes
        dgexportar.Rows.Add(6)
        dgexportar.Rows(0).Cells(7).Value = "CC"
        dgexportar.Rows(1).Cells(7).Value = "TI"
        dgexportar.Rows(2).Cells(7).Value = "CE"
        dgexportar.Rows(0).Cells(8).Value = "Para cedulas de ciudadania"
        dgexportar.Rows(1).Cells(8).Value = "Para Tarjetas de identidad"
        dgexportar.Rows(2).Cells(8).Value = "Para Cedulas extrajeras"
        cmbtipo_cliente.Select()
        Cursor = Cursors.Default
        txtbuscador.Focus()
    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frm_clientes_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub


    Function Reload(anterior, siguiente)

        'cargamos el datagrid que se exporta a excel
        datos = Select_1ParametroInt("sp_tbl_cliente_select", "")
        dgreportes.DataSource = datos
        dgreportes.DataMember = "datos"


        'Contamos los datos que nos regresa la consulta
        tabla = New DataTable
        tabla = datos.tables("datos")
        total_datos = tabla.Rows.Count
        lblpagina.Text = pagina
        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
        lbl_total_paginas.Text = "/ " & maximo_paginas





        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        Arreglo = {txtbuscador.Text, anterior, siguiente}
        datos = tbl_clientes_paginado(Arreglo, "sp_tbl_cliente_paginado")



        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        ''Ocultamos la columna del codigo
        dgdatos.Columns(9).Visible = False
        dgdatos.Columns(11).Visible = False
        dgdatos.Columns(12).Visible = False
        dgdatos.Columns(13).Visible = False
        dgdatos.Columns(14).Visible = False
        dgdatos.Columns(16).Visible = False
        dgdatos.Columns(18).Visible = False
        dgdatos.Columns(19).Visible = False

        fila = datos.tables("datos").Rows.Count

        'Cambiamos el nombre de la sincronizacion 
        For i = 0 To fila - 1
            If dgdatos.Rows(i).Cells(15).Value = 0 Then
                dgdatos.Rows(i).Cells(15).Value = "NO"
                dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Red
            Else
                dgdatos.Rows(i).Cells(15).Value = "SI"
                dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Green
            End If
        Next

        'Consultamos el nuemero de registros de clientes
        datos = CargarDatos("sp_contador_clientes")
        tabla = New DataTable
        tabla = datos.tables("datos")
        btnregistros.Text = tabla(0)(0)
    End Function

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        With frm_registro_update
            .ShowDialog()
        End With
    End Sub

    Private Sub btnexcel_Click(sender As Object, e As EventArgs) Handles btnexcel.Click
        'Mostramos o ocultamos el panel con las opciones de excel
        If pnlexcel.Visible = True Then
            pnlexcel.Visible = False
        Else
            pnlexcel.Visible = True
        End If
    End Sub

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        buscador()

    End Sub

    Private Sub btnexcel_Leave(sender As Object, e As EventArgs) Handles btnexcel.Leave
        pnlexcel.Visible = False
    End Sub

    Private Sub dgdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick
        If e.RowIndex = -1 Then
            Return
        Else
            Select Case e.ColumnIndex
                Case 0
                    'Validamos si esta seguro de realizar la operacion
                    If MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                        Dim row = dgdatos.CurrentRow.Index

                        'Validamos que el aprendiz no este ne mora
                        datos = Select_1ParametroInt("sp_tbl_mora_select_PK2", dgdatos.Rows(row).Cells(1).Value)
                        tabla = New DataTable
                        tabla = datos.tables("datos")
                        'Si no esta en mora lo eliminamos
                        If tabla.Rows.Count = 0 Then
                            datos = tbl_cliente_delete(dgdatos.Rows(row).Cells(1).Value, "sp_tbl_cliente_delete")
                            If datos = 1 Then
                                MsgBox("Se eliminó correctamente el registro !", vbInformation)
                            End If
                            Reload(anterior, siguiente) 'recargamos el datagrid
                        Else
                            MsgBox("El aprendiz aun tiene elementos en mora,no puede ser eliminado.", vbCritical)
                        End If
                    End If

            End Select
        End If


    End Sub


    Private Sub btntipoprestamo_Click(sender As Object, e As EventArgs) Handles btntipoprestamo.Click
        Cursor = Cursors.WaitCursor
        descargar_plantilla(dgexportar) 'esta funcion imprime la plantilla de excel 
    End Sub

    Private Sub eliminar_fichas_Click(sender As Object, e As EventArgs) Handles eliminar_fichas.Click
        With pnlficha
            txtbuscadorficha.Text = ""
            pnlficha.Visible = True
            txtbuscadorficha.Focus()
        End With
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        pnlficha.Visible = False
        txtbuscador.Text = ""
        cmbficha.DataSource = Nothing
    End Sub

    Private Sub cbxtodos_CheckedChanged(sender As Object, e As EventArgs) Handles cbxtodos.CheckedChanged
        If cbxtodos.Checked = True Then
            cmbtipo_cliente.Enabled = False
            Reload(anterior, siguiente)
            swich_tipos = 0
        Else
            cmbtipo_cliente.Enabled = True
            cmbtipo_cliente.Select()
            swich_tipos = 1
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cmbficha.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar un ficha", vbCritical)
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar la ficha?", "Eliminar Ficha.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                'validamos que ningunos de los aprenidces esten en mora
                datos = Select_1ParametroInt("sp_tbl_clientesXficha", cmbficha.SelectedValue)
                tabla = New DataTable
                tabla = datos.tables("datos")

                If tabla.Rows.Count > 0 Then

                    For i = 0 To tabla.Rows.Count - 1
                        'Validamos que el aprendiz no este ne mora
                        datos = Select_1ParametroInt("sp_tbl_mora_select_PK2", tabla(i)(0))
                        If datos.tables("datos").rows.count = 0 Then
                            tbl_cliente_delete(tabla(i)(0), "sp_tbl_cliente_delete")
                        Else
                            'Si hay algun moroso activam,os el swich
                            swich_moroso = 1
                        End If
                    Next
                    'Si no hay ningun moroso en la ficha ,eliminamos la ficha
                    If swich_moroso <> 1 Then
                        eliminar_aprendicesXficha("sp_tbl_ficha_delete", cmbficha.SelectedValue)
                    Else
                        MsgBox("Se eliminaron los aprendices de la ficha " & cmbficha.SelectedValue & " los cuales no estan reportados en mora", vbInformation)
                    End If
                End If

                txtbuscador.Text = ""
                cmbficha.DataSource = Nothing
                pnlficha.Visible = False
                If swich_eliminados = 1 Then
                    clientes_eliminados(anterior, siguiente)
                Else
                    Reload(anterior, siguiente)
                End If

            End If
        End If
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        'crear reporte de excel 
        Cursor = Cursors.WaitCursor
        If cmbtipo_cliente.SelectedValue Is Nothing Then
            descargar_plantilla_bajas(dgreportes, "REPORTE DE CLIENTES ACTIVOS")
        Else
            descargar_plantilla_bajas(dgreportes, "REPORTE DE CLIENTES DE TIPO (" & cmbtipo_cliente.Text & ")")
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub btn_reporte_excel_Click(sender As Object, e As EventArgs) Handles btn_reporte_excel.Click
        'crear reporte de excel 
        Cursor = Cursors.WaitCursor

        descargar_plantilla_bajas(dgreportes, "REPORTE DE CLIENTES ELIMINADOS")

        Cursor = Cursors.Default
    End Sub

    Private Sub btn_primera_pagina_Click(sender As Object, e As EventArgs) Handles btn_primera_pagina.Click
        If swich_tipos <> 1 Then
            'vista de cliente eliminados
            If swich_eliminados = 1 Then
                pagina = pagina - pagina + 1
                lblpagina.Text = pagina
                siguiente = numero_registros
                anterior = 0
                clientes_eliminados(anterior, siguiente)
            Else
                'vista principal de clientes
                If txtbuscador.Text <> "" Then
                    pagina = pagina - pagina + 1
                    lblpagina.Text = pagina
                    siguiente = numero_registros
                    anterior = 0
                    buscador()
                Else
                    pagina = pagina - pagina + 1
                    lblpagina.Text = pagina
                    siguiente = numero_registros
                    anterior = 0
                    Reload(anterior, siguiente)
                End If

            End If

        Else

            pagina = pagina - pagina + 1
            lblpagina.Text = pagina
            siguiente = numero_registros
            anterior = 0
            cmbtipo_cliente_SelectionChangeCommitted(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_ultima_pagina_Click(sender As Object, e As EventArgs) Handles btn_ultima_pagina.Click
        'Vamos hasta los ultimos registros
        If swich_tipos <> 1 Then
            'Vista de clientes eliminados
            If swich_eliminados = 1 Then
                pagina = maximo_paginas
                lblpagina.Text = pagina
                siguiente = numero_registros * maximo_paginas
                anterior = siguiente - numero_registros

                clientes_eliminados(anterior, siguiente)
            Else
                'vista princopal de clientes
                If txtbuscador.Text <> "" Then
                    pagina = maximo_paginas
                    lblpagina.Text = pagina
                    siguiente = numero_registros * maximo_paginas
                    anterior = siguiente - numero_registros
                    buscador()
                Else
                    pagina = maximo_paginas
                    lblpagina.Text = pagina
                    siguiente = numero_registros * maximo_paginas
                    anterior = siguiente - numero_registros

                    Reload(anterior, siguiente)
                End If

            End If

        Else
            pagina = maximo_paginas
            lblpagina.Text = pagina
            siguiente = numero_registros * maximo_paginas
            anterior = siguiente - numero_registros
            cmbtipo_cliente_SelectionChangeCommitted(Nothing, Nothing)
        End If

    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        'Pagina siguiente
        If swich_tipos <> 1 Then
            'vista de clientes eliminados
            If swich_eliminados = 1 Then
                If lblpagina.Text > 1 Then
                    pagina = pagina - 1
                    lblpagina.Text = pagina
                    siguiente = siguiente - numero_registros - 1
                    anterior = anterior - numero_registros - 1

                    clientes_eliminados(anterior, siguiente)
                End If
            Else
                'Vista principal de clientes
                If lblpagina.Text > 1 Then
                    pagina = pagina - 1
                    lblpagina.Text = pagina
                    siguiente = siguiente - numero_registros - 1
                    anterior = anterior - numero_registros - 1

                    Reload(anterior, siguiente)
                End If
            End If

        Else


            If lblpagina.Text > 1 Then
                pagina = pagina - 1
                lblpagina.Text = pagina
                siguiente = siguiente - numero_registros - 1
                anterior = anterior - numero_registros - 1
                cmbtipo_cliente_SelectionChangeCommitted(Nothing, Nothing)
            End If
        End If


    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        'Pagina siguiente
        If swich_tipos <> 1 Then
            'Si esta en la vista de clientes eliminados
            If swich_eliminados = 1 Then
                If lblpagina.Text <> maximo_paginas Then
                    pagina = pagina + 1
                    lblpagina.Text = pagina
                    siguiente = siguiente + numero_registros + 1
                    anterior = anterior + numero_registros + 1

                    clientes_eliminados(anterior, siguiente)
                End If
            Else
                'Vista principál de clientes
                If lblpagina.Text <> maximo_paginas Then
                    pagina = pagina + 1
                    lblpagina.Text = pagina
                    siguiente = siguiente + numero_registros + 1
                    anterior = anterior + numero_registros + 1

                    Reload(anterior, siguiente)
                End If
            End If

        Else

            If lblpagina.Text <> maximo_paginas Then
                pagina = pagina + 1
                lblpagina.Text = pagina
                siguiente = siguiente + numero_registros + 1
                anterior = anterior + numero_registros + 1
                cmbtipo_cliente_SelectionChangeCommitted(Nothing, Nothing)
            End If
        End If


    End Sub


    Function clientes_eliminados(anterior, siguiente)

        'Mostramos todos los clientes que han digo eliminados
        swich_eliminados = 1
        lblestado.Visible = True
        Panel2.Visible = True
        btnexcel.Visible = False
        btnagregar.Visible = False
        pnl_filtros.Visible = False


        btn_reporte_excel.Visible = True

        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = Select_1ParametroInt("sp_tbl_clientes_eliminados", "")

        'cargamos el datagrid que se exporta a excel
        dgreportes.DataSource = datos
        dgreportes.DataMember = "datos"

        'Contamos los datos que nos regresa la consulta
        tabla = New DataTable
        tabla = datos.tables("datos")

        total_datos = tabla.Rows.Count
        lblpagina.Text = pagina
        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
        lbl_total_paginas.Text = "/ " & maximo_paginas

        'los datos que recivimos de la funcion los mostramos en el datagrid
        Arreglo = {txtbuscador.Text, anterior, siguiente}
        datos = tbl_clientes_paginado(Arreglo, "sp_tbl_clientes_eliminados_paginados")
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"




        ''Ocultamos la columna del codigo
        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(9).Visible = False
        dgdatos.Columns(11).Visible = False
        dgdatos.Columns(12).Visible = False
        dgdatos.Columns(13).Visible = False
        dgdatos.Columns(14).Visible = False
        dgdatos.Columns(16).Visible = False
        dgdatos.Columns(18).Visible = False

        fila = dgdatos.Rows.Count

        'Cambiamos el nombre de la sincronizacion 
        For i = 0 To fila - 1
            Select Case dgdatos.Rows(i).Cells(15).Value
                Case 0
                    dgdatos.Rows(i).Cells(15).Value = "No"
                    dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Red
                Case 1
                    dgdatos.Rows(i).Cells(15).Value = "Si"
                    dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Green
            End Select
        Next


        'Cambiamos el nombre cuando noy hay ficha
        For i = 0 To fila - 1
            Select Case dgdatos.Rows(i).Cells(4).Value
                Case 0
                    dgdatos.Rows(i).Cells(4).Value = "No Aplica"

                Case 1
                    dgdatos.Rows(i).Cells(4).Value = "Sin Ficha"
            End Select
        Next

        btnregistros.Text = dgdatos.Rows.Count
    End Function

    Private Sub cmbtipo_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipo_cliente.SelectedIndexChanged
        btn_primera_pagina_Click(Nothing, Nothing)
    End Sub


    Private Sub FichasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichasToolStripMenuItem.Click
        With frm_fichas
            .ShowDialog()
        End With
    End Sub

    Private Sub ClientesEliminadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesEliminadosToolStripMenuItem.Click
        'Llamamos la funcion que carga los datos
        clientes_eliminados(anterior, siguiente)

    End Sub

    Private Sub btnsubir_Click(sender As Object, e As EventArgs) Handles btnsubir.Click

        Cursor = Cursors.WaitCursor


        importarExcel(frm_progresbar.dgimportar) 'este funcion nos trae un archivo excel y lo encapsula en el datagrid que le enviamos como parametro

        With frm_progresbar
            .clientes = True
            .ShowDialog()
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        fila = dgdatos.CurrentRow.Index
        Try
            If swich_eliminados <> 1 Then
                'Enviamos los la informacion al formulario y luego lo abrimos
                With frm_registro_update
                    .txtdocumento.Enabled = False 'inabilitamos el texbox del documento
                    .txtdocumento.Text = dgdatos.Rows(fila).Cells(1).Value
                    .txtnombres.Text = dgdatos.Rows(fila).Cells(2).Value
                    .txtapellidos.Text = dgdatos.Rows(fila).Cells(3).Value
                    .txtbuscador.Text = dgdatos.Rows(fila).Cells(5).Value


                    .codficha = dgdatos.Rows(fila).Cells(4).Value
                    'estado de sincronizacion
                    Select Case dgdatos.Rows(fila).Cells(15).Value
                        Case "NO"
                            .sincronizado = 0

                        Case "SI"
                            .sincronizado = 1

                    End Select


                    .txtemail.Text = dgdatos.Rows(fila).Cells(6).Value
                    .txtmovil.Text = dgdatos.Rows(fila).Cells(7).Value

                    .tipo_cliente = dgdatos.Rows(fila).Cells(9).Value
                    .txttipo_cliente.Text = dgdatos.Rows(fila).Cells(10).Value
                    .cmbtipocliente.Enabled = False
                    .txttipo_cliente.Visible = True
                    .linktipo_cliente.Visible = True

                    .ptbFotocliente.Image = Nothing
                    If String.IsNullOrEmpty(dgdatos.Rows(fila).Cells(11).Value.ToString) Then
                        .ptbFotocliente.Image = Nothing
                    Else

                        .ruta = dgdatos.Rows(fila).Cells(11).Value

                        If File.Exists(dgdatos.Rows(fila).Cells(11).Value) Then
                            Dim FS = New FileStream(.ruta, FileMode.Open)
                            .ptbFotocliente.Image = Image.FromStream(FS)
                            FS.Close()
                        Else
                            MsgBox("No se encontró la imagen del cliente", vbCritical)
                        End If




                    End If
                    .lblheader.Text = "Actualiar Informacion"
                    .cmbtipo_documento.Select()
                    .cmbtipo_documento.SelectedValue = dgdatos.Rows(fila).Cells(18).Value
                    .btnguardar.Visible = False
                    .btnactualizar.Visible = True

                    .ShowDialog()
                End With
            End If

        Catch ex As IO.IOException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbtipo_cliente_GotFocus(sender As Object, e As EventArgs) Handles cmbtipo_cliente.GotFocus
        'Combobox el cual tiene los tipos de documentos utlizando la funcion cargardatos que nos devuelve los datos de la consulta
        datos = CargarDatos("sp_tbl_tipo_cliente_select")

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbtipo_cliente.DataSource = tabla
        cmbtipo_cliente.DisplayMember = "nombre"
        cmbtipo_cliente.ValueMember = "codigo"
    End Sub

    Function buscador()
        If txtbuscador.Text <> "" Then
            ''Buscador automatico, Busca por Documentos , Nombres, Apellidos, Fichas  y Tipos de Clientes

            If swich_eliminados = 1 Then
                'Buscador de clientes eliminados
                Arreglo = {txtbuscador.Text, anterior, siguiente}
                datos = tbl_clientes_paginado(Arreglo, "sp_tbl_clientes_eliminados_paginados")
            Else
                If cbxtodos.Checked = True Then

                    datos = Select_1ParametroInt("sp_tbl_cliente_select", txtbuscador.Text)
                    'Contamos los datos que nos regresa la consulta
                    tabla = New DataTable
                    tabla = datos.tables("datos")
                    total_datos = tabla.Rows.Count
                    lblpagina.Text = pagina
                    maximo_paginas = Math.Ceiling(total_datos / numero_registros)
                    lbl_total_paginas.Text = "/ " & maximo_paginas


                    'Buscador de clientes activos
                    Arreglo = {txtbuscador.Text, anterior, siguiente}
                    datos = tbl_clientes_paginado(Arreglo, "sp_tbl_cliente_paginado")
                Else
                    'Buscador por tipo_clientes
                    Arreglo = {txtbuscador.Text, cmbtipo_cliente.SelectedValue}
                    datos = Buscador_keyUp_clientes(Arreglo, "sp_tbl_clientes_select_keyUp")

                    tabla = New DataTable
                    tabla = datos.tables("datos")
                    total_datos = tabla.Rows.Count
                    lblpagina.Text = pagina
                    maximo_paginas = Math.Ceiling(total_datos / numero_registros)
                    lbl_total_paginas.Text = "/ " & maximo_paginas

                    'Paginado
                    Arreglo = {txtbuscador.Text, cmbtipo_cliente.SelectedValue, anterior, siguiente}
                    datos = Buscador_keyUp_clientes_paginado(Arreglo, "sp_tbl_clientes_select_keyUp_paginado")

                End If
            End If


            'los datos que recivimos de la funcion los mostramos en el datagrid
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"




            ''Ocultamos la columna del codigo
            dgdatos.Columns(9).Visible = False
            dgdatos.Columns(11).Visible = False
            dgdatos.Columns(12).Visible = False
            dgdatos.Columns(13).Visible = False
            dgdatos.Columns(14).Visible = False
            dgdatos.Columns(16).Visible = False
            dgdatos.Columns(18).Visible = False
            dgdatos.Columns(19).Visible = False

            fila = dgdatos.Rows.Count

            'Cambiamos el nombre de la sincronizacion 
            For i = 0 To fila - 1
                Select Case dgdatos.Rows(i).Cells(15).Value
                    Case 0
                        dgdatos.Rows(i).Cells(15).Value = "NO"
                        dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Red
                    Case 1
                        dgdatos.Rows(i).Cells(15).Value = "SI"
                        dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Green
                End Select
            Next

            'Contador de regsitros
            btnregistros.Text = dgdatos.Rows.Count
        Else
            If swich_tipos = 1 Then
                cmbtipo_cliente_SelectionChangeCommitted(Nothing, Nothing)
            Else
                If swich_eliminados = 1 Then
                    clientes_eliminados(anterior, siguiente)
                Else
                    Reload(anterior, siguiente)
                End If
            End If

        End If

    End Function

    Private Sub cmbtipo_cliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbtipo_cliente.SelectionChangeCommitted
        Arreglo = {txtbuscador.Text, cmbtipo_cliente.SelectedValue}
        datos = Buscador_keyUp_clientes(Arreglo, "sp_tbl_clientes_select_keyUp")

        'cargamos el datagrid que se exporta a excel
        dgreportes.DataSource = datos
        dgreportes.DataMember = "datos"

        'Contamos los datos que nos regresa la consulta
        tabla = New DataTable
        tabla = datos.tables("datos")
        total_datos = tabla.Rows.Count
        lblpagina.Text = pagina
        maximo_paginas = Math.Ceiling(total_datos / numero_registros)
        lbl_total_paginas.Text = "/ " & maximo_paginas

        'datos paginados
        Arreglo = {txtbuscador.Text, cmbtipo_cliente.SelectedValue, anterior, siguiente}
        datos = Buscador_keyUp_clientes_paginado(Arreglo, "sp_tbl_clientes_select_keyUp_paginado")

        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Cambiamos el nombre de la sincronizacion 
        For i = 0 To datos.tables("datos").rows.count - 1
            Select Case dgdatos.Rows(i).Cells(15).Value
                Case 0
                    dgdatos.Rows(i).Cells(15).Value = "No"
                    dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Red
                Case 1
                    dgdatos.Rows(i).Cells(15).Value = "Si"
                    dgdatos.Rows(i).Cells(15).Style.ForeColor = Color.Green
            End Select
        Next


        btnregistros.Text = total_datos


    End Sub

    Private Sub txtbuscadorficha_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscadorficha.KeyUp
        'Buscador Automatico
        If txtbuscadorficha.Text <> "" Then
            datos = Buscador_keyUp(txtbuscadorficha.Text, "sp_tbl_ficha_keyup") ' esta funcion nos busca automaticamente por codigo o nombre del elemento

            tabla = New DataTable
            tabla = datos.tables("datos")


            Dim fila = tabla.Rows.Count

            'validamos si la consulta NOS REGRESO ALGUNOS REGISTROS
            If fila <> 0 Then
                cmbficha.DataSource = tabla
                cmbficha.DisplayMember = "programa"
                cmbficha.ValueMember = "codigo"

                cmbficha.BorderColor = Color.Green

            Else
                cmbficha.BorderColor = Color.Red
                cmbficha.Text = "Elemento no encontrado"
                cmbficha.DataSource = Nothing
            End If
        Else

            cmbficha.Text = ""
            cmbficha.BorderColor = Color.Gray
            cmbficha.ForeColor = Color.Black
            cmbficha.DataSource = Nothing
        End If
    End Sub

    Private Sub txtbuscador_GotFocus(sender As Object, e As EventArgs) Handles txtbuscador.GotFocus
        btn_primera_pagina_Click(Nothing, Nothing)
    End Sub
End Class