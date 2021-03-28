'Imports System.Data.SqlClient 'libreria de sql
'Imports System.Data


Public Class frmMovimientos_documento
    Public Datos, DatosMora, ParametrosFiltrar(4) As Object

    Public estadopres, SwCmb, SwDgv, SwCerrar As Byte

    Public Function BuscarClientePrest()
        'Buscar si el cliente existe (DEVUELVE UN ARREGLO)

        Datos = BuscarCliente(txtDocumento.Text)
        'Validar si el valor de Datos en la poscicion 0 es un 1, si el cliente existe
        If Datos(0) = "1" Then
            'Llenar los campos con la informacion del cliente
            'Se recorre la tabla con la informacion del cliente y se lleva a un arreglo
            For i = 0 To 12
                'Validar si el campo es nulo
                If Datos(1).Rows(0)(i) Is DBNull.Value Then
                    Cliente(i) = DBNull.Value
                Else
                    Cliente(i) = Datos(1).Rows(0)(i)
                End If
            Next

            'SE VALIDA SI EL CLIENTE TIENE UNA MORA ACTIVA
            DatosMora = EstadoMoraCliente(txtDocumento.Text, 1) 'Consultar si el cliente está en mora
            If DatosMora.rows.count = 0 Then
                SWMORA = 0
            Else
                SWMORA = 1
                For i = 0 To 5
                    ClienteMora(i) = DatosMora.rows(0)(i)
                Next
            End If

            'Validar si el dia de hoy el cliente tiene un prestamo activo
            MaestroPrestamo = ValidarClientePrestamo(txtDocumento.Text, 1)
            'Validar si el resultado de la validacion es verdadera o falsa
            'Si no tiene un prestamo
            If MaestroPrestamo Is Nothing Then
                CerrarPestañas() 'Cerrar los formularios
                'Se ejecutan funciones con el formulario Movimientos_detalle
                With frmMovimientos_detalle
                    'Se selecciona el tab de prestamo
                    .tabMovimiento.SelectedTab = .tpPrestamo
                    'Se bloquean botones para evitar funciones indevidas
                    .btnDuplicarPrestamo.Visible = False
                    .btnEnviarCorreo.Visible = False
                    .btnEntregar.Visible = False

                    .btnPrestarElementos.Text = "Prestar elementos" 'Se cambia la propiedad de texto al botón
                    .btnPrestarElementos.Image = Global.Appsena.My.Resources.Resources.icons8_storage_box_64 'Se cambia la imagen del botón
                    .CmbValue = 1
                    .txtElemento.Focus()

                End With
            Else
                'Se validad desde que control esta accediendo al detalle del prestamo
                If SwDgv = 1 Then 'Cuando accede desde el dgv con un doble click
                    Dim Fila As Integer = dgvPrestamos.CurrentRow.Index
                    'Se valida cuantos prestamos activos tiene el cliente
                    Select Case MaestroPrestamo.rows.count
                        Case 1 'Cuando tiene un solo prestamo
                            DetallePrestamo = TraerDetallePrestamo(MaestroPrestamo.rows(0)(0), 1)
                        Case > 1 'Cuando tiene mas de 1 prestamo
                            'Se consulta el prestamo que el usuario quiere ver
                            MaestroPrestamo = ValidarClientePrestamo(dgvPrestamos.Rows(Fila).Cells(0).Value, 2)
                            'Se trae el detalle del prestamo
                            DetallePrestamo = TraerDetallePrestamo(MaestroPrestamo.rows(0)(0), 1)
                    End Select
                Else
                    Select Case MaestroPrestamo.rows.count
                        Case 1 'Cuando tiene un solo prestamo
                            DetallePrestamo = TraerDetallePrestamo(MaestroPrestamo.rows(0)(0), 1)

                        Case > 1 'Cuando tiene mas de 1 prestamo
                            If frmMovimientos_detalle.SWEditar = 1 Then
                                'Y ya abrió un prestamo
                                DetallePrestamo = TraerDetallePrestamo(frmMovimientos_detalle.lblCodPres.Text, 1)
                            Else
                                'Cuando da enter en el buscador
                                frmMovimientos_PrestamosCliente.CargarFormulario(txtDocumento.Text)
                                If SwCerrar = 1 Then
                                    Exit Function
                                End If
                            End If
                    End Select
                End If
                CerrarPestañas() 'Cerrar los formularios
                'Ejecutar procesos con el formulario Movimientos_detalle
                With frmMovimientos_detalle
                    .tabMovimiento.SelectedTab = .tpHistorial
                    Dim TipoPres As Object

                    'Nueva instancia de una datatable
                    tabla = New DataTable
                    'Valor de la tabla
                    tabla = DetallePrestamo.tables("datos")
                    'Se consulta el tipo de prestamo a cargar
                    TipoPres = TipoPrestamo(MaestroPrestamo.rows(0)(0))
                    TipoPres = TipoPres.tables("datos")
                    .lblTipoprestamo.Text = TipoPres.rows(0)(1)
                    'Se valida que si el tipo de prestamo es distinto a un interno
                    If TipoPres.rows(0)(0) <> 1 Then
                        .pnlPrestamoInfo.Visible = True
                        '.lblTipoprestamo.Text = TipoPres.rows(0)(1) 'Prestamo
                        .dtpFechaLimite.Enabled = False

                        If TipoPres.rows(0)(3) Is DBNull.Value Then
                            .lblFormatoSalida.Visible = False
                        Else
                            .lblFormatoSalida.Visible = True
                        End If

                        If TipoPres.rows(0)(6) Is DBNull.Value Then
                            .lblSeguro.Visible = False
                        Else
                            .lblSeguro.Visible = True
                        End If
                    Else
                        .pnlPrestamoInfo.Visible = True
                        .lblSeguro.Visible = False
                        .dtpFechaLimite.Enabled = False
                        .dtpFechaLimite.Visible = False
                        .lblFechaLimit.Visible = False
                        .lblFormatoSalida.Visible = False
                    End If
                    .lblCodPres.Text = tabla.Rows(0)(0) 'Codigo del prestamo
                    .CodigoPrestamo = tabla.Rows(0)(0) 'Codigo del prestamo
                    .lblTipoprestamo.Visible = True
                    .btnPrestarElementos.Text = "Guardar cambios"
                    .btnPrestarElementos.Image = Global.Appsena.My.Resources.Resources.icons8_save_641
                End With
            End If
            BajarNivel(frmMovimientos_detalle) 'Abrir el formulario de movimiento detalle
        Else
            If txtDocumento.Text = "" Then
                'Cuando el campo del documento está vacío
                MsgBox("El campo de texto del documento está vacío.", vbCritical)

            Else
                'Cuando el documento digitado no existe
                MsgBox("El usuario no existe", vbCritical)
                txtDocumento.Text = ""
            End If
            txtDocumento.Focus()
        End If
    End Function
    Private Function ActualizarHistorial(tipo)
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        If tipo = 1 Then
            Datos = Select_1Parametro("SP_tblPrestamo_PrestamosHoy", Today)
            tabla = New DataTable
            tabla = Datos.tables("datos")
        Else
            Datos = CargarDatos("SP_tblPrestamo_PrestamosActivos")
            tabla = New DataTable
            tabla = Datos.tables("datos")
        End If

        Dim Filas = tabla.Rows.Count

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Filas - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo
            If tabla(i)(6) = 1 Then 'estado del prestamo
                dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
            End If

            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next
    End Function


    Private Sub frmMovimientos_documento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frmMovimientos_documento_Click
        Next

        txtDocumento.Focus()

        'SE EJECUTA LA FUNCION QUE PERMITE ACTUALIZAR EL DGV DE HISTORIAL
        ActualizarHistorial(1)
    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frmMovimientos_documento_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub


    Private Sub txtDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocumento.KeyDown
        Select Case e.KeyCode 'Se captura el codigo de la tecla presionada
            Case Keys.Enter 'Cuando la tecla presioanada sea la tecla ENTER
                SwDgv = 0
                BuscarClientePrest() 'Se ejecuta la funcion

        End Select
    End Sub

    Private Sub btnDuplicarPrestamo_Click(sender As Object, e As EventArgs) Handles btnDuplicarPrestamo.Click
        frmMovimientos_DuplicarMovim.ShowDialog() 'Se abre un formulario para duplicar el prestamo
    End Sub

    Private Sub dgvPrestamos_DoubleClick(sender As Object, e As EventArgs) Handles dgvPrestamos.DoubleClick
        'Se captura el doble click y se realiza una funcion
        If dgvPrestamos.Rows.Count > 0 Then 'Solo se ejecuta si el datagrid tiene filas
            txtDocumento.Text = dgvPrestamos.Rows(dgvPrestamos.CurrentRow.Index).Cells(1).Value
            SwDgv = 1
            BuscarClientePrest()

        End If
    End Sub

    Private Sub rbtnentregado_CheckedChanged(sender As Object, e As EventArgs)
        ParametrosFiltrar(0) = Today.Date
        ParametrosFiltrar(1) = "0"
        ParametrosFiltrar(2) = txtBuscador.Text

        ParametrosFiltrar(4) = "1"
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Datos = PrestamosFiltro_Keyup(ParametrosFiltrar)

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Datos.rows.count - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo

            dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO" 'Estado
            dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
            dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter


            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next
    End Sub

    Private Sub rbtnTodos_CheckedChanged(sender As Object, e As EventArgs)
        ParametrosFiltrar(0) = Today.Date
        ParametrosFiltrar(1) = "1"
        ParametrosFiltrar(2) = txtBuscador.Text

        ParametrosFiltrar(4) = "0"
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Datos = PrestamosFiltro_Keyup(ParametrosFiltrar)

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Datos.rows.count - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo
            If tabla(i)(6) = 1 Then 'estado del prestamo
                dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
            End If

            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next
    End Sub


    Private Sub rbtnActivo_CheckedChanged(sender As Object, e As EventArgs)


        ParametrosFiltrar(0) = Today.Date
        ParametrosFiltrar(1) = "1"
        ParametrosFiltrar(2) = txtBuscador.Text

        ParametrosFiltrar(4) = "1"
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Datos = PrestamosFiltro_Keyup(ParametrosFiltrar)

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Datos.rows.count - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo

            dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO" 'Estado
            dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
            dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
            dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter


            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next
    End Sub

    Private Sub txtBuscador_KeyUp(sender As Object, e As KeyEventArgs)
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        ParametrosFiltrar(0) = Today.Date

        If cbxTodos.Checked = True Then
            ParametrosFiltrar(4) = "0"
        End If

        ParametrosFiltrar(2) = txtBuscador.Text


        ParametrosFiltrar(2) = txtBuscador.Text
        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Datos = PrestamosFiltro_Keyup(ParametrosFiltrar)

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Datos.rows.count - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo
            If tabla(i)(6) = 1 Then 'estado del prestamo
                dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
            End If

            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next
    End Sub


    Private Sub cbxTodos_CheckedChanged(sender As Object, e As EventArgs)

        If cbxTodos.Checked = True Then
            If cbxTodosPresAct.Checked = True Then
                cbxTodosPresAct.Checked = False
            End If
            cmbTipoCliente.Enabled = False

            ParametrosFiltrar(0) = Today.Date
            ParametrosFiltrar(1) = "1"
            ParametrosFiltrar(2) = txtBuscador.Text

            ParametrosFiltrar(4) = "0"
            ' Limpiar el dgv para hacerlo dinamico
            dgvPrestamos.Rows.Clear()

            'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
            Datos = PrestamosFiltro_Keyup(ParametrosFiltrar)

            'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
            For i = 0 To Datos.rows.count - 1
                dgvPrestamos.Rows.Add()
                dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
                dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
                dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
                dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
                dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
                dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo
                If tabla(i)(6) = 1 Then 'estado del prestamo
                    dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO"
                    dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
                    dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                    dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO"
                    dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
                    dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If

                dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
                dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
            Next
        Else
            ActualizarHistorial(1)
            cmbTipoCliente.Enabled = True
        End If
    End Sub

    Private Sub cbxTodosPresAct_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTodosPresAct.CheckedChanged
        Select Case cbxTodosPresAct.Checked
            Case True
                cbxTodos.Checked = False
                'SI EL CLIENTE SELECCIONA EL CHECKBOX DE TODOS LOS PRESTAMOS ACTIVOS
                ActualizarHistorial(0)

            Case False
                'SI EL DESSELECCIONA EL CHECKBOX
                ActualizarHistorial(1)
        End Select

    End Sub

    Private Sub HistorialGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialGeneralToolStripMenuItem.Click
        CerrarPestañas() 'Se cierran las pestañas
        BajarNivel(frmMovimientos_Historial) 'Se abre el formulario
        frmMovimientos_Historial.ActualizarDGVfrmHistorial(0, Nothing) 'Se ejecuta la funcion de actualizar el historial
        frmDashBoard.lblFormu.Text = "Historial de movimientos" 'Se cambia el lbl del dashboard
        frmMovimientos_Historial.lblEncabezado.Text = "Historial general" 'Se cambia el lbl del formulario de historial
        With frmMovimientos_Historial
            .lblNombres.Visible = False
            .lblNombresNom.Visible = False
            .lblTipoCliente.Visible = False
            .lblTipoClienteNom.Visible = False
            .lnkCambiarCliente.Visible = False
            .lnkDetalleCliente.Visible = False
            .lblDocid.Visible = False
        End With
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'cmbTipoCliente.Visible = True
        'lblFiltrar.Visible = True
        'lblFiltrar.Visible = True
        'txtBuscador.Visible = True
        'cbxTodos.Visible = True
        pnlBuscar.Visible = True
        btnBuscar.Visible = False
    End Sub

    Private Sub HistorialPorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialPorToolStripMenuItem.Click
        CerrarPestañas()
        BajarNivel(frmMovimientos_Historial) 'Se abre el formulario
        frmDashBoard.lblFormu.Text = "Historial de movimientos" 'Se cambia el lbl del dashboard
        frmMovimientos_Historial.lblEncabezado.Text = "Historial de prestamos por cliente" 'Se cambia el lbl del formulario de historial
        With frmMovimientos_Historial
            .lblNombres.Visible = False
            .lblNombresNom.Visible = False
            .lblTipoCliente.Visible = False
            .lblTipoClienteNom.Visible = False
            .lnkCambiarCliente.Visible = False
            .lnkDetalleCliente.Visible = False
            .lblDocid.Visible = False
        End With
        frmMovimientos_BuscarCliente.ShowDialog()
    End Sub

    Private Sub cmbTipoCliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTipoCliente.SelectionChangeCommitted
        ParametrosFiltrar(0) = Today.Date
        ParametrosFiltrar(1) = "1"
        ParametrosFiltrar(2) = txtBuscador.Text
        ParametrosFiltrar(3) = cmbTipoCliente.SelectedValue
        ParametrosFiltrar(4) = "3"
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Datos = PrestamosFiltro_Keyup(ParametrosFiltrar)

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Datos.rows.count - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo
            If tabla(i)(6) = 1 Then 'estado del prestamo
                dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
            End If

            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next
    End Sub
    'SE VALIDA QUE SOLO SE ADMITAN NUMEROS
    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub pnlBuscar_LostFocus(sender As Object, e As EventArgs) Handles pnlBuscar.LostFocus
        pnlBuscar.Visible = False
    End Sub

    Private Sub cmbTipoCliente_GotFocus(sender As Object, e As EventArgs) Handles cmbTipoCliente.GotFocus
        'Combobox el cual tiene los tipos de documentos utlizando la funcion cargardatos que nos devuelve los datos de la consulta

        Datos = CargarDatos("sp_tbl_tipo_cliente_select")
        tabla = New DataTable
        tabla = Datos.tables("datos")

        cmbTipoCliente.DataSource = tabla
        cmbTipoCliente.ValueMember = "codigo"
        cmbTipoCliente.DisplayMember = "Nombre"
        SwCmb = 1
    End Sub
End Class