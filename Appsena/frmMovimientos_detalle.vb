Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
'Imports Microsoft.Office.Interop.Word


Public Class frmMovimientos_detalle
    Public FilaPrestados, FilaDispo, Resta, Suma, Cantidad, Filas, Contador, CantEPres, Cont, CodigoPrestamo As Integer
    Public Swicht, SwichtBtn, SwichtObserva, SWPrestamo, SwBtn, SwExterno, SWEditar, FilaEPres, SwSeguro, SwCCliente As Byte
    Public Datos, Observaciones, ElementoPres(7), CambioElemento(1), ArregloMora(10), VPrestamo(10), FechLimit(1) As Object
    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl 'Se crea el control que permite la edicion de una celda en un dgv
    Public Datos2 As Object
    Public Disponible, SWRepe As Integer
    Public CmbValue As Object
    Public Elementos(8), CodigoPres As Object

    Public Function ValidarBotones()
        If dgvHistorial.Rows.Count = 0 Then
            btnCambiarCliente.Visible = False

        End If
    End Function

    Private Function AggDatosValidado()
        'Se lleva el indice del elemento buscado a una variable
        FilaDispo = dgvElementosDispo.CurrentRow.Index
        'Se cuenta la cantidad de filas del DataGridView de los elementos prestados
        FilaPrestados = dgvElementosPrestados.RowCount

        Cantidad = txtCantidad.Text

        'Validar si el elemento existe
        If dgvElementosDispo.RowCount > 0 Then
            'Validar si la cantidad es superior a la cantidad disponible del elemento
            If txtCantidad.Text <= dgvElementosDispo.Rows(FilaDispo).Cells(3).Value Then
                'Validar si el datagrid de los elementos prestados está vacío
                'Cuando el datagrid de los elementos tiene filas
                If dgvElementosPrestados.RowCount > 0 Then
                    'Validar si el elemento a prestar ya se encuentra en el datagrid
                    For i = 0 To dgvElementosPrestados.RowCount - 1
                        If dgvElementosDispo.Rows(FilaDispo).Cells(0).Value = dgvElementosPrestados.Rows(i).Cells(0).Value And dgvElementosPrestados.Rows(i).Cells(4).Value = Today & " " & Now.ToString("hh:mm") Then
                            'Validar si la fecha del prestamo del elemento es igual
                            If dgvElementosPrestados.Rows(i).Cells(4).Value = Today & " " & Now.ToString("hh:mm") Then
                                Swicht = 1 'Activar un swicht cuando el elemento ya esta en el datagridview y tiene la misma hora de prestamo
                                FilaPrestados = i
                                Exit For
                            Else
                                Swicht = 2 'Activar un swicht cuando el elemento ya esta en el datagridview y la hora no es la misma
                                Exit For
                            End If
                        Else
                            Swicht = 0
                        End If
                    Next
                    Select Case Swicht
                            'Si el elemento no existe en el datagrid de los elementos prestados o no tiene la misma hora de prestamo
                        Case 0
                            dgvElementosPrestados.Rows.Add() 'Agregar una fila
                            For i = 0 To 1
                                'Llenar las dos primeras columnas del datagrid de los elementos prestados con la informacion del datagrid de los elementos disponibles
                                dgvElementosPrestados.Rows(FilaPrestados).Cells(i).Value = dgvElementosDispo.Rows(FilaDispo).Cells(i).Value
                            Next
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(2).Value = Cantidad 'Cantidad del elemento
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(3).Value = Observaciones 'Observaciones
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(4).Value = Today & " " & Now.ToString("hh:mm") 'Fecha del prestamo
                            If cbxFechalimite.Checked = True Then 'Fecha limite de cada elemento
                                dgvElementosPrestados.Rows(FilaPrestados).Cells(5).Value = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
                            Else
                                dgvElementosPrestados.Rows(FilaPrestados).Cells(5).Value = ""
                            End If

                            'Validar si el elemento a prestar es un devolutivo o consumo
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(8).Value = dgvElementosDispo.Rows(FilaDispo).Cells(6).Value
                            'Se hace una resta de la cantidad solicitada a la disponibilidad del elemento
                            Resta = dgvElementosDispo.Rows(FilaDispo).Cells(3).Value - txtCantidad.Text
                            'se ejecuta la funcion y se le llevan los parametros necesarios
                            UpdateDispoElemento(dgvElementosPrestados.Rows(FilaPrestados).Cells(0).Value, Resta)

                        'Si el elemento existe y la hora del prestamo es igual a la hora exacta
                        Case 1
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(2).Value = dgvElementosPrestados.Rows(FilaPrestados).Cells(2).Value + Cantidad 'Se suma la cantidad a la fila
                            Resta = dgvElementosDispo.Rows(FilaDispo).Cells(3).Value - Cantidad 'Se resta la nueva cantidad
                            UpdateDispoElemento(dgvElementosPrestados.Rows(FilaPrestados).Cells(0).Value, Resta) 'Se llama la funcion y se le lleva los parametros
                            Swicht = 0 'Se reinicia el swich

                        Case 2
                            dgvElementosPrestados.Rows.Add() 'Agregar una fila
                            For i = 0 To 1
                                'Llenar las dos primeras columnas del datagrid de los elementos prestados con la informacion del datagrid de los elementos disponibles
                                dgvElementosPrestados.Rows(FilaPrestados).Cells(i).Value = dgvElementosDispo.Rows(FilaDispo).Cells(i).Value
                            Next
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(2).Value = Cantidad 'Cantidad del elemento
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(3).Value = Observaciones 'Observaciones
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(4).Value = Today & " " & Now.ToString("hh:mm") 'Fecha del prestamo
                            If cbxFechalimite.Checked = True Then 'Fecha limite de cada elemento
                                dgvElementosPrestados.Rows(FilaPrestados).Cells(5).Value = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
                            Else
                                dgvElementosPrestados.Rows(FilaPrestados).Cells(5).Value = ""
                            End If
                            'Se hace una resta de la cantidad solicitada a la disponibilidad del elemento
                            Resta = dgvElementosDispo.Rows(FilaDispo).Cells(3).Value - txtCantidad.Text
                            'se ejecuta la funcion y se le llevan los parametros necesarios
                            UpdateDispoElemento(dgvElementosPrestados.Rows(FilaPrestados).Cells(0).Value, Resta)
                            'Validar si el elemento a prestar es un devolutivo o consumo
                            dgvElementosPrestados.Rows(FilaPrestados).Cells(8).Value = dgvElementosDispo.Rows(FilaDispo).Cells(6).Value
                            Swicht = 0
                    End Select

                    'Cuando el datagrid de los elementos está vacío
                Else
                    dgvElementosPrestados.Rows.Add() 'Agregar una fila
                    For i = 0 To 1
                        'Llenar las dos primeras columnas del datagrid de los elementos prestados con la informacion del datagrid de los elementos disponibles
                        dgvElementosPrestados.Rows(FilaPrestados).Cells(i).Value = dgvElementosDispo.Rows(FilaDispo).Cells(i).Value
                    Next
                    dgvElementosPrestados.Rows(FilaPrestados).Cells(2).Value = Cantidad 'Cantidad del elemento
                    dgvElementosPrestados.Rows(FilaPrestados).Cells(3).Value = Observaciones 'Observaciones
                    dgvElementosPrestados.Rows(FilaPrestados).Cells(4).Value = Today & " " & Now.ToString("hh:mm") 'Fecha del prestamo
                    If cbxFechalimite.Checked = True Then 'Fecha limite de cada elemento
                        dgvElementosPrestados.Rows(FilaPrestados).Cells(5).Value = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
                    Else
                        dgvElementosPrestados.Rows(FilaPrestados).Cells(5).Value = ""
                    End If
                    'Validar si el elemento a prestar es un devolutivo o consumo
                    dgvElementosPrestados.Rows(FilaPrestados).Cells(8).Value = dgvElementosDispo.Rows(FilaDispo).Cells(6).Value
                    'Se hace una resta de la cantidad solicitada a la disponibilidad del elemento
                    Resta = dgvElementosDispo.Rows(FilaDispo).Cells(3).Value - txtCantidad.Text
                    'se ejecuta la funcion y se le llevan los parametros necesarios
                    UpdateDispoElemento(dgvElementosPrestados.Rows(FilaPrestados).Cells(0).Value, Resta)

                End If
                txtElemento.Text = ""
                txtElemento.Focus()
                txtCantidad.Text = "1"
                If cmbTipoPrestamo.SelectedValue <> "1" Then
                    cbxFechalimite.Checked = True
                Else
                    cbxFechalimite.Checked = False
                End If
                ActualizarDGV()

            Else
                MsgBox("La cantidad necesaria es superior a la cantidad disponible", vbCritical)
            End If
        Else
            MsgBox("El elemento buscado no existe", vbCritical)
        End If
    End Function

    Public Function ActualizarDGV()
        'Limpiar el dgv para hacerlo dinamico
        dgvElementosDispo.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Datos = Buscador_keyUp(txtElemento.Text, "sp_tbl_elemento_buscador")
        tabla = New DataTable
        tabla = Datos.tables("datos")

        Filas = tabla.Rows.Count

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Filas - 1
            dgvElementosDispo.Rows.Add()
            dgvElementosDispo.Rows(i).Cells(0).Value = tabla(i)(0) 'Codigo del Elemento
            dgvElementosDispo.Rows(i).Cells(1).Value = tabla(i)(1) 'Descripción del Elemento
            dgvElementosDispo.Rows(i).Cells(2).Value = tabla(i)(2) 'Cantidad
            dgvElementosDispo.Rows(i).Cells(3).Value = tabla(i)(3) 'Disponible
            dgvElementosDispo.Rows(i).Cells(4).Value = tabla(i)(4) 'Ubicación
            dgvElementosDispo.Rows(i).Cells(5).Value = tabla(i)(6) 'Tipo elemento
            dgvElementosDispo.Rows(i).Cells(6).Value = tabla(i)(7)
        Next
    End Function

    'FUNCION QUE GUARDA LOS ELEMENTOS QUE HAY EN EL DATAGRID DE ELEMENTOS PRESTADOS
    Public Function GuardarPrestamo(btn)
        If dgvElementosPrestados.Rows.Count > 0 Then

            'Variables controladoras para realizar el insert de cada elemento en la base de datos
            Dim Cliente As Object

            'Dim tablapres As DataTable
            If btn = 1 Then
                Cliente = lblDocidNom.Text
            Else
                Cliente = btn
            End If
            'Se consulta el tipo de prestamo que tiene el cliente realizado
            CodigoPres = TraerPrestamo(lblDocidNom.Text, cmbTipoPrestamo.SelectedValue)
            'Se valida si la consulta trajo datos
            If CodigoPres IsNot Nothing Then 'Cuando el cliente tiene un prestamo activo
                tabla = New DataTable
                tabla = CodigoPres.tables("datos")
                Select Case tabla.Rows(0)(3)
                    Case 1
                        GuardarPrestamoValidado()
                    Case 2
                        'Se llena el vector VPrestamo con la informacion necesaria para hacer el insert maestro del prestamo
                        VPrestamo(0) = Cliente 'Codigo del cliente
                        VPrestamo(1) = SESSION(0) 'Codigo del Admin
                        VPrestamo(2) = cmbTipoPrestamo.SelectedValue 'Codigo tipo de prestamo
                        VPrestamo(3) = "1" 'Estado del elemento. 1 es activo, 0 es inactivo
                        VPrestamo(4) = Today.Date & " " & Now.ToString("hh:mm") 'la hora exacta del prestamo del elemento
                        VPrestamo(5) = DBNull.Value 'la fecha de devolucion del elemento prestado
                        'Validar que la fecha limite no sea menor a la fecha actual
                        If cbxFechalimite.Checked = True Then
                            If dtpFechaLimit.Value >= Today.Date Then
                                If SwSeguro = 1 Then
                                    If dtpFechaLimit.Value > Today.Date.AddMonths(1) Then
                                        If MessageBox.Show("ATENCION:" & vbNewLine & "el tiempo de prestamo es superior a un mes, por lo tanto se debe hacer un traspaso de elementos." & vbNewLine & "¿Desea hacer el traspaso de elementos?", "¿Realizar un traspaso?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = vbYes Then
                                            'HACER EL TRASPASO
                                            With frmMovimientos_Seguro
                                                .lblFormato1.Text = "Constancia de traspaso:"
                                                .ShowDialog()
                                            End With
                                            VPrestamo(2) = TipoPres_Traspaso

                                        Else
                                            'NO HACER EL TRASPASO
                                            MessageBox.Show("No se puede completar el " & cmbTipoPrestamo.Text & "." & vbNewLine & "Se requiere de un traspaso de elementos", "Error en el prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Function
                                        End If
                                    Else
                                        If dtpFechaLimit.Value >= Today.Date And dtpFechaLimit.Value <= Today.Date.AddMonths(1) Then
                                            If MessageBox.Show("ATENCIÓN:" & vbNewLine & "Los elementos que se prestarán deben ser asegurados." & vbNewLine & "¿Desea realizar el seguro?", "Realizar seguro a los elementos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                                                'HACER EL SEGURO
                                                frmMovimientos_Seguro.ShowDialog()
                                            Else
                                                'NO HACER EL SEGURO
                                                MessageBox.Show("No se puede completar el " & cmbTipoPrestamo.Text & "." & vbNewLine & "Se deben asegurar los elementos", "Error en el prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                Exit Function
                                            End If

                                        End If
                                    End If
                                End If
                                VPrestamo(6) = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimit.Value.ToShortTimeString
                            Else
                                MessageBox.Show("La fecha límite no puede inferior a la fecha actual." & vbNewLine & "Por favor seleccione una fecha correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                dtpFechaLimit.Focus()
                                Exit Function
                            End If
                        Else
                            MessageBox.Show("El " & cmbTipoPrestamo.Text & "no tiene una fecha límite de entrega, Por favor seleccione una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cbxFechalimite.Checked = True
                            dtpFechaLimit.Focus()
                            Exit Function
                        End If
                        'Se valida si todas las operaciones se realizaron
                        If Cerradura = 1 Then
                            Cerradura = 0
                            Exit Function
                        End If
                        'la funcion retorna un byte que permite realizar diferentes funciones
                        Datos = InsertUpdatePrestamo(VPrestamo, "sp_tblprestamo_insert")
                        If Datos = 1 Then
                            GuardarPrestamoValidado()
                        Else
                            MsgBox("No se completó la operación", vbCritical)
                        End If
                    Case 5
                        'Se llena el vector VPrestamo con la informacion necesaria para hacer el insert maestro del prestamo
                        VPrestamo(0) = Cliente 'Codigo del cliente
                        VPrestamo(1) = SESSION(0) 'Codigo del Admin
                        VPrestamo(2) = cmbTipoPrestamo.SelectedValue 'Codigo tipo de prestamo
                        VPrestamo(3) = "1" 'Estado del elemento. 1 es activo, 0 es inactivo
                        VPrestamo(4) = Today.Date & " " & Now.ToString("hh:mm") 'la hora exacta del prestamo del elemento
                        VPrestamo(5) = DBNull.Value 'la fecha de devolucion del elemento prestado
                        'Validar que la fecha limite no sea menor a la fecha actual
                        If cbxFechalimite.Checked = True Then
                            If dtpFechaLimit.Value >= Today.Date Then
                                If SwSeguro = 1 Then
                                    If dtpFechaLimit.Value > Today.Date.AddMonths(1) Then
                                        If MessageBox.Show("ATENCION:" & vbNewLine & "el tiempo de prestamo es superior a un mes, por lo tanto se debe hacer un traspaso de elementos." & vbNewLine & "¿Desea hacer el traspaso de elementos?", "¿Realizar un traspaso?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = vbYes Then
                                            'HACER EL TRASPASO
                                            With frmMovimientos_Seguro
                                                .lblFormato1.Text = "Constancia de traspaso:"
                                                .ShowDialog()
                                            End With
                                            VPrestamo(2) = TipoPres_Traspaso
                                        Else
                                            'NO HACER EL TRASPASO
                                            MessageBox.Show("No se puede completar el " & cmbTipoPrestamo.Text & "." & vbNewLine & "Se requiere de un traspaso de elementos", "Error en el prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Function
                                        End If
                                        Exit Function
                                    Else
                                        If dtpFechaLimit.Value >= Today.Date And dtpFechaLimit.Value <= Today.Date.AddMonths(1) Then
                                            If MessageBox.Show("ATENCIÓN:" & vbNewLine & "Los elementos que se prestarán deben ser asegurados." & vbNewLine & "¿Desea realizar el seguro?", "Realizar seguro a los elementos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                                                'HACER EL SEGURO
                                                frmMovimientos_Seguro.ShowDialog()
                                            Else
                                                'NO HACER EL SEGURO
                                                MessageBox.Show("No se puede completar el " & cmbTipoPrestamo.Text & "." & vbNewLine & "Se deben asegurar los elementos", "Error en el prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                Exit Function
                                            End If
                                        End If
                                    End If
                                End If
                                VPrestamo(6) = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimit.Value.ToShortTimeString
                            Else
                                MessageBox.Show("La fecha límite no puede inferior a la fecha actual." & vbNewLine & "Por favor seleccione una fecha correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                dtpFechaLimit.Focus()
                                Exit Function
                            End If
                        Else
                            MessageBox.Show("El " & cmbTipoPrestamo.Text & "no tiene una fecha límite de entrega, Por favor seleccione una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cbxFechalimite.Checked = True
                            dtpFechaLimit.Focus()
                            Exit Function
                        End If
                        'Se valida si todas las operaciones se realizaron
                        If Cerradura = 1 Then
                            Cerradura = 0
                            Exit Function
                        End If
                        'la funcion retorna un byte que permite realizar diferentes funciones
                        Datos = InsertUpdatePrestamo(VPrestamo, "sp_tblprestamo_insert")

                        If Datos = 1 Then
                            GuardarPrestamoValidado()
                        Else
                            MsgBox("No se completó la operación", vbCritical)
                        End If
                End Select
            Else 'Cuando no tiene un prestamo activo
                'Se llena el vector VPrestamo con la informacion necesaria para hacer el insert maestro del prestamo
                VPrestamo(0) = Cliente 'Codigo del cliente
                VPrestamo(1) = SESSION(0) 'Codigo del Admin
                VPrestamo(2) = cmbTipoPrestamo.SelectedValue 'Codigo tipo de prestamo
                VPrestamo(3) = "1" 'Estado del elemento. 1 es activo, 0 es inactivo
                VPrestamo(4) = Today.Date & " " & Now.ToString("hh:mm") 'la hora exacta del prestamo del elemento
                VPrestamo(5) = DBNull.Value 'la fecha de devolucion del elemento prestado
                'VALIDAR SI ES UN PRESTAMO EXTERNO O PARA PROYECTO
                If cmbTipoPrestamo.SelectedValue = 2 Or cmbTipoPrestamo.SelectedValue = 5 Then
                    If cbxFechalimite.Checked = True Then
                        If dtpFechaLimit.Value >= Today.Date Then
                            If SwSeguro = 1 Then
                                If dtpFechaLimit.Value > Today.Date.AddMonths(1) Then
                                    If MessageBox.Show("ATENCION:" & vbNewLine & "el tiempo de prestamo es superior a un mes, por lo tanto se debe hacer un traspaso de elementos." & vbNewLine & "¿Desea hacer el traspaso de elementos?", "¿Realizar un traspaso?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = vbYes Then
                                        'HACER EL TRASPASO
                                        With frmMovimientos_Seguro
                                            .lblFormato1.Text = "Constancia de traspaso:"
                                            .ShowDialog()
                                        End With
                                        VPrestamo(2) = TipoPres_Traspaso

                                    Else
                                        'NO HACER EL TRASPASO
                                        MessageBox.Show("No se puede completar el " & cmbTipoPrestamo.Text & "." & vbNewLine & "Se requiere de un traspaso de elementos", "Error en el prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Function
                                    End If
                                Else
                                    If dtpFechaLimit.Value >= Today.Date And dtpFechaLimit.Value <= Today.Date.AddMonths(1) Then
                                        If MessageBox.Show("ATENCIÓN:" & vbNewLine & "Los elementos que se prestarán deben ser asegurados." & vbNewLine & "¿Desea realizar el seguro?", "Realizar seguro a los elementos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                                            'HACER EL SEGURO
                                            frmMovimientos_Seguro.ShowDialog()
                                        Else
                                            'NO HACER EL SEGURO
                                            MessageBox.Show("No se puede completar el " & cmbTipoPrestamo.Text & "." & vbNewLine & "Se deben asegurar los elementos", "Error en el prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Function
                                        End If
                                    End If
                                End If
                            End If
                            VPrestamo(6) = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimit.Value.ToShortTimeString
                        Else
                            MessageBox.Show("La fecha límite no puede inferior a la fecha actual." & vbNewLine & "Por favor seleccione una fecha correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            dtpFechaLimit.Focus()
                            Exit Function
                        End If
                    Else
                        MessageBox.Show("El " & cmbTipoPrestamo.Text & "no tiene una fecha límite de entrega, Por favor seleccione una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxFechalimite.Checked = True
                        dtpFechaLimit.Focus()
                        Exit Function
                    End If
                Else
                    If cbxFechalimite.Checked = True Then
                        Select Case dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimit.Value.ToShortTimeString
                            Case < Today.Date.ToShortDateString & " " & Today.Date.ToShortTimeString
                                MessageBox.Show("La fecha límite no puede inferior a la fecha actual." & vbNewLine & "Por favor seleccione una fecha correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                dtpFechaLimit.Focus()
                                Exit Function

                            Case <= Today.Date.AddMonths(1)
                                VPrestamo(6) = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimit.Value.ToShortTimeString
                        End Select
                    Else
                        VPrestamo(6) = DBNull.Value 'SE LLEVA UN VALOR NULO AL VALOR DE LA FECHA LIMITE DEL PRESTAMO
                    End If
                    VPrestamo(7) = DBNull.Value 'Se lleva un valor nulo al campo del seguro ya que es un prestamo interno
                    VPrestamo(8) = DBNull.Value 'Se lleva un valor nulo al campo del seguro ya que es un prestamo interno
                    VPrestamo(9) = DBNull.Value 'Se lleva un valor nulo al campo del seguro ya que es un prestamo interno
                    VPrestamo(10) = DBNull.Value 'RUTA DEL FORMATO DE SALIDA
                End If
                If VPrestamo(2) <> 1 Then
                    'Se valida si todas las operaciones se realizaron
                    If Cerradura = 1 Then
                        'la funcion retorna un byte que permite realizar diferentes funciones
                        Datos = InsertUpdatePrestamo(VPrestamo, "sp_tblprestamo_insert")
                        Cerradura = 0
                    Else
                        MsgBox("No se completó la operación", vbCritical)
                        Exit Function
                    End If
                Else
                    Datos = InsertUpdatePrestamo(VPrestamo, "sp_tblprestamo_insert")

                End If
                If Datos = 1 Then
                    GuardarPrestamoValidado()
                Else
                    MsgBox("No se completó la operación del prestamo", vbCritical)
                End If
            End If

        Else
            MessageBox.Show("No ha seleccionado elementos," & "por favor seleccione los elementos a prestar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    'FUNCION VALIDADA DEL INSERT DE LOS ELEMENTOS (PARA NO REPETIR CODIGO)
    Public Function GuardarPrestamoValidado()
        If IsTraspaso = 1 Then
            'Se consulta el codigo del prestamo, si ya tiene un prestamo se trae el codigo y si no se consulta el nuevo prestamo
            CodigoPres = TraerPrestamo(lblDocidNom.Text, 6)
        Else
            'Se consulta el codigo del prestamo, si ya tiene un prestamo se trae el codigo y si no se consulta el nuevo prestamo
            CodigoPres = TraerPrestamo(lblDocidNom.Text, cmbTipoPrestamo.SelectedValue)
        End If

        tabla = New DataTable
        tabla = CodigoPres.tables("datos")
        CodigoPres = tabla.Rows(0)(0)
        'Cantidad de filas en el datagrid, se convierte a posiciones con un -1
        Dim FilasPrestamo = dgvElementosPrestados.Rows.Count - 1

        'Se recorre el datagrid y por cada fila se hace el insert
        For Each dgvfila As DataGridViewRow In dgvElementosPrestados.Rows
            Dim Observaciones(dgvfila.Cells(2).Value - 1) As String
            Elementos(0) = CodigoPres 'Codigo del prestamo
            Elementos(1) = dgvfila.Cells(0).Value 'Codigo del elemento
            Elementos(2) = dgvfila.Cells(2).Value 'Cantidad
            Elementos(3) = dgvfila.Cells(4).Value 'Fecha prestamo
            Elementos(4) = DBNull.Value 'Fecha devolucion
            'Observaciones
            If dgvfila.Cells(3).Value = "" Or dgvfila.Cells(3).Value Is Nothing Then
                Elementos(5) = DBNull.Value
            Else
                If Elementos(2) > 1 Then
                    Elementos(5) = dgvfila.Cells(3).Value
                    Dim Str As String = Elementos(5)
                    Dim strarr() As String
                    Dim Cont As Integer = 0
                    strarr = Str.Split(",")
                    For Each s As String In strarr
                        Observaciones(Cont) = s
                        Cont = Cont + 1
                    Next
                Else
                    Elementos(5) = dgvfila.Cells(3).Value
                End If
            End If
            Elementos(6) = "1" 'Estado del prestamo
            Elementos(7) = 0 'Cantidad entrega
            If cbxFechalimite.Checked = True Then
                Elementos(8) = dgvfila.Cells(4).Value
            Else
                Elementos(8) = DBNull.Value
            End If
            'Se descuenta la cantidad prestada de la cantidad en inventario del elemento
            If IsTraspaso = 1 Then
                Dim ElementCant As Object
                ElementCant = Select_1ParametroVarchar("sp_tblelemento_Disponible", Elementos(1))
                UpdateCANTElemento(Elementos(1), ElementCant.Rows(0)(0) - Elementos(2))
            End If
            'Validar si la cantidad del elemento prestado es mayor a uno 1
            If Elementos(2) > 1 Then
                Dim Cantidad As Integer = Elementos(2) 'Variable que controla la cantidad de inserts
                Elementos(2) = 1 'la cantidad de cada elemento se actualiza a 1 
                'Se hace un insert por cada una de las cantidades del elemento
                For i = 0 To Cantidad - 1
                    If Observaciones(i) = "" Then
                        Elementos(5) = DBNull.Value
                    Else
                        Elementos(5) = Observaciones(i)
                    End If
                    InsertUpdatePrestamoElemento(Elementos, "sp_tblprestamoelemento_insert")
                Next
            Else
                InsertUpdatePrestamoElemento(Elementos, "sp_tblprestamoelemento_insert")
            End If
        Next
        IsTraspaso = 0 'Se reinicia el suiche de traspaso
        Datos = Nothing
        MessageBox.Show("Se agregó el prestamo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvElementosPrestados.Rows.Clear()
        If SwExterno = 1 Then
            SwExterno = 0
        Else
            CerrarPestañas()
            BajarNivel(frmMovimientos_documento)
        End If
        If btnEntregar.Enabled = False And btnDuplicarPrestamo.Enabled = False And btnEnviarCorreo.Enabled = False Then
            btnDuplicarPrestamo.Enabled = True
            btnEnviarCorreo.Visible = True
            btnEntregar.Enabled = True
        End If

    End Function

    Public Function ActualizarHistorial() 'Funcion para actualizar el historial trayendo la chorrera de registros y juntandola por codigo y por fecha de prestamo
        dgvHistorial.Rows.Clear() 'Se limpia el datagridview
        Dim index As Integer 'Variable para guardar el index de una fila
        Dim swCodigo, swFecha, swCase As Byte

        'Nueva instancia de una datatable
        tabla = New DataTable
        'Valor de la tabla
        tabla = DetallePrestamo.tables("datos")
        'Cantidad de filas de la tabla convertida a posiciones
        Dim Filas = tabla.Rows.Count - 1
        'Recorrer la tabla y agregar a un datagridview las filas de la tabla
        Dim Conta As Integer = 0
        'Se recorre la tabla
        For h = 0 To Filas
            'Validamos si hay filas en el dgvHistorial
            If dgvHistorial.Rows.Count = 0 Then
                dgvHistorial.Rows.Add()
                dgvHistorial.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
                dgvHistorial.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento
                dgvHistorial.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
                dgvHistorial.Rows(Conta).Cells(3).Value = tabla.Rows(h)(3) - tabla.Rows(h)(9) 'Cantidad
                dgvHistorial.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

                If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha limite
                    dgvHistorial.Rows(Conta).Cells(5).Value = ""
                Else
                    dgvHistorial.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
                End If

                If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                    dgvHistorial.Rows(Conta).Cells(6).Value = ""
                Else
                    dgvHistorial.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
                End If
                dgvHistorial.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado
                dgvHistorial.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo
                dgvHistorial.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
                dgvHistorial.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
                dgvHistorial.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                dgvHistorial.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
                Conta = Conta + 1
            Else
                'Se activa el swCase para entrar a las validaciones posteriormente
                swCase = 1
                'Se recorre el dgvHistorial
                For k = 0 To dgvHistorial.Rows.Count - 1
                    'Validamos si el registro en la tabla ya está en el dgvHistorial por medio del codigo
                    If tabla.Rows(h)(1) = dgvHistorial.Rows(k).Cells(1).Value Then 'Codigo
                        swCodigo = 1 'Se activa el swCodigo
                        'Validar si la fecha de prestamo del elemento es igual
                        If tabla.Rows(h)(4) = dgvHistorial.Rows(k).Cells(4).Value Then 'Fecha de prestamo igual
                            swFecha = 1 'Se activa el swFecha ya que las fechas y el codigo coinciden
                            index = k 'Se lleva a una variable el indice de la fila que está duplicada
                        Else
                            swFecha = 0 'Se desactiva el swFecha cuando la fecha de prestamo es diferente
                        End If
                    Else
                        swCodigo = 0 'Se desactiva el swCodigo cuando el codigo del elemento en la tabla no existe en el dgvHistorial
                    End If
                Next
            End If
            'Validar si se recorrio el dgvHistorial
            If swCase = 1 Then
                Select Case swCodigo
                    Case 1
                        Select Case swFecha
                            Case 1
                                dgvHistorial.Rows(index).Cells(3).Value = dgvHistorial.Rows(index).Cells(3).Value + tabla.Rows(h)(3)
                                If tabla.Rows(h)(6) IsNot DBNull.Value Then
                                    dgvHistorial.Rows(index).Cells(6).Value = dgvHistorial.Rows(index).Cells(6).Value & "," & tabla.Rows(h)(6)
                                    dgvHistorial.Rows(index).Cells(9).Value = dgvHistorial.Rows(index).Cells(9).Value + tabla.Rows(h)(9) 'Se suma la Cantidad entrega
                                    dgvHistorial.Rows(index).Cells(13).Value = dgvHistorial.Rows(index).Cells(13).Value + tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                                End If
                            Case 0
                                dgvHistorial.Rows.Add()
                                dgvHistorial.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
                                dgvHistorial.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento
                                dgvHistorial.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
                                dgvHistorial.Rows(Conta).Cells(3).Value = tabla.Rows(h)(3) - tabla.Rows(h)(9) 'Cantidad
                                dgvHistorial.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

                                If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha devolucion
                                    dgvHistorial.Rows(Conta).Cells(5).Value = ""
                                Else
                                    dgvHistorial.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
                                End If

                                If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                                    dgvHistorial.Rows(Conta).Cells(6).Value = ""
                                Else
                                    dgvHistorial.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
                                End If
                                dgvHistorial.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado
                                dgvHistorial.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo
                                dgvHistorial.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
                                dgvHistorial.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
                                dgvHistorial.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                                dgvHistorial.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
                                Conta = Conta + 1
                        End Select
                    Case 0
                        dgvHistorial.Rows.Add()
                        dgvHistorial.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
                        dgvHistorial.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento
                        dgvHistorial.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
                        dgvHistorial.Rows(Conta).Cells(3).Value = tabla.Rows(h)(3) - tabla.Rows(h)(9) 'Cantidad
                        dgvHistorial.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

                        If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha devolucion
                            dgvHistorial.Rows(Conta).Cells(5).Value = ""
                        Else
                            dgvHistorial.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
                        End If

                        If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                            dgvHistorial.Rows(Conta).Cells(6).Value = ""
                        Else
                            dgvHistorial.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
                        End If
                        dgvHistorial.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado
                        dgvHistorial.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo
                        dgvHistorial.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
                        dgvHistorial.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
                        dgvHistorial.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                        dgvHistorial.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
                        Conta = Conta + 1
                End Select
            End If
            If dgvHistorial.RowCount = 0 Then
                Dim EstadoPrestamo As Object
                EstadoPrestamo = {tabla.Rows(h)(0), "0", Today & " " & Now.ToString("hh:mm")}
                InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
                btnEntregarTodo.Visible = False
                btnEntregar.Visible = False
                dgvHistorial.Columns(11).Visible = False
                dgvHistorial.Columns(12).Visible = False
            End If

        Next

        ValidarBotones()
    End Function

    Public Function ActualizarHistorialMora() 'Funcion para actualizar el historial trayendo la chorrera de registros y juntandola por codigo y por fecha de prestamo
        dgvHistorial.Rows.Clear() 'Se limpia el datagridview
        Dim index As Integer 'Variable para guardar el index de una fila
        Dim swCodigo, swFecha, swCase As Byte

        'Nueva instancia de una datatable
        tabla = New DataTable
        'Valor de la tabla
        tabla = DetallePrestamo.tables("datos")
        'Cantidad de filas de la tabla convertida a posiciones
        Dim Filas = tabla.Rows.Count - 1
        'Recorrer la tabla y agregar a un datagridview las filas de la tabla
        Dim Conta As Integer = 0
        'Se recorre la tabla
        For h = 0 To Filas
            'Validamos si hay filas en el dgvHistorial
            dgvHistorial.Rows.Add()
            dgvHistorial.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
            dgvHistorial.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento
            dgvHistorial.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
            dgvHistorial.Rows(Conta).Cells(3).Value = tabla.Rows(h)(3) - tabla.Rows(h)(9) 'Cantidad
            dgvHistorial.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

            If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha limite
                dgvHistorial.Rows(Conta).Cells(5).Value = ""
            Else
                dgvHistorial.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
            End If

            If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                dgvHistorial.Rows(Conta).Cells(6).Value = ""
            Else
                dgvHistorial.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
            End If
            dgvHistorial.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado
            dgvHistorial.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo            
            dgvHistorial.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
            dgvHistorial.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
            dgvHistorial.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
            dgvHistorial.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
            Conta = Conta + 1
        Next
        ValidarBotones()
    End Function

    Public Function ActualizarEPrestados()
        dgvEPrestados.Rows.Clear() 'Se limpia el datagridview
        Dim index As Integer 'Variable para guardar el index de una fila
        Dim swCodigo, swFecha, swCase As Byte

        'Nueva instancia de una datatable
        tabla = New DataTable
        'Valor de la tabla
        tabla = DetallePrestamo.tables("datos")
        'Cantidad de filas de la tabla convertida a posiciones
        Dim Filas = tabla.Rows.Count - 1
        'Recorrer la tabla y agregar a un datagridview las filas de la tabla
        Dim Conta As Integer = 0
        'Se recorre la tabla
        For h = 0 To Filas
            'Validamos si hay filas en el dgvHistorial
            If dgvEPrestados.Rows.Count = 0 Then
                dgvEPrestados.Rows.Add()
                dgvEPrestados.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
                dgvEPrestados.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento

                dgvEPrestados.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
                dgvEPrestados.Rows(Conta).Cells(3).Value = tabla.Rows(h)(9) 'Cantidad Entregada
                dgvEPrestados.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

                If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha devolucion
                    dgvEPrestados.Rows(Conta).Cells(5).Value = ""
                Else
                    dgvEPrestados.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
                End If

                If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                    dgvEPrestados.Rows(Conta).Cells(6).Value = ""
                Else
                    dgvEPrestados.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
                End If
                dgvEPrestados.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado


                dgvEPrestados.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo
                dgvEPrestados.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
                dgvEPrestados.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
                dgvEPrestados.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                dgvEPrestados.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
                Conta = Conta + 1
            Else
                'Se activa el swCase para entrar a las validaciones posteriormente
                swCase = 1
                'Se recorre el dgvHistorial
                For k = 0 To dgvEPrestados.Rows.Count - 1
                    'Validamos si el registro en la tabla ya está en el dgvHistorial por medio del codigo
                    If tabla.Rows(h)(1) = dgvEPrestados.Rows(k).Cells(1).Value Then 'Codigo
                        swCodigo = 1 'Se activa el swCodigo
                        'Validar si la fecha de prestamo del elemento es igual
                        If tabla.Rows(h)(4) = dgvEPrestados.Rows(k).Cells(4).Value Then 'Fecha de prestamo igual
                            swFecha = 1 'Se activa el swFecha ya que las fechas y el codigo coinciden
                            index = k 'Se lleva a una variable el indice de la fila que está duplicada
                        Else
                            swFecha = 0 'Se desactiva el swFecha cuando la fecha de prestamo es diferente
                        End If
                    Else
                        swCodigo = 0 'Se desactiva el swCodigo cuando el codigo del elemento en la tabla no existe en el dgvHistorial
                    End If
                Next
            End If
            'Validar si se recorrio el dgvHistorial
            If swCase = 1 Then
                Select Case swCodigo
                    Case 1
                        Select Case swFecha
                            Case 1
                                dgvEPrestados.Rows(index).Cells(3).Value = dgvEPrestados.Rows(index).Cells(3).Value + tabla.Rows(h)(3)
                                If tabla.Rows(h)(6) IsNot DBNull.Value Then
                                    dgvEPrestados.Rows(index).Cells(6).Value = dgvEPrestados.Rows(index).Cells(6).Value & "," & tabla.Rows(h)(6)
                                    dgvEPrestados.Rows(index).Cells(9).Value = dgvEPrestados.Rows(index).Cells(9).Value + tabla.Rows(h)(9) 'Se suma la Cantidad entrega
                                    dgvEPrestados.Rows(index).Cells(13).Value = dgvEPrestados.Rows(index).Cells(13).Value + tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                                    dgvEPrestados.Rows(index).Cells(5).Value = tabla.Rows(h)(5) 'Ultima fecha de entrega
                                End If
                            Case 0
                                dgvEPrestados.Rows.Add()
                                dgvEPrestados.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
                                dgvEPrestados.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento
                                dgvEPrestados.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
                                dgvEPrestados.Rows(Conta).Cells(3).Value = tabla.Rows(h)(9) 'Cantidad
                                dgvEPrestados.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

                                If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha devolucion
                                    dgvEPrestados.Rows(Conta).Cells(5).Value = ""
                                Else
                                    dgvEPrestados.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
                                End If

                                If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                                    dgvEPrestados.Rows(Conta).Cells(6).Value = ""
                                Else
                                    dgvEPrestados.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
                                End If
                                dgvEPrestados.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado
                                dgvEPrestados.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo
                                dgvEPrestados.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
                                dgvEPrestados.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
                                dgvEPrestados.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                                dgvEPrestados.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
                                Conta = Conta + 1
                        End Select
                    Case 0
                        dgvEPrestados.Rows.Add()
                        dgvEPrestados.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo prestamo
                        dgvEPrestados.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Codigo elemento
                        dgvEPrestados.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Descripcion
                        dgvEPrestados.Rows(Conta).Cells(3).Value = tabla.Rows(h)(9) 'Cantidad
                        dgvEPrestados.Rows(Conta).Cells(4).Value = tabla.Rows(h)(4) 'Fecha Prestamo

                        If tabla.Rows(h)(5) Is DBNull.Value Then 'Fecha devolucion
                            dgvEPrestados.Rows(Conta).Cells(5).Value = ""
                        Else
                            dgvEPrestados.Rows(Conta).Cells(5).Value = tabla.Rows(h)(5)
                        End If

                        If tabla.Rows(h)(6) Is DBNull.Value Then 'Observaciones
                            dgvEPrestados.Rows(Conta).Cells(6).Value = ""
                        Else
                            dgvEPrestados.Rows(Conta).Cells(6).Value = tabla.Rows(h)(6)
                        End If
                        dgvEPrestados.Rows(Conta).Cells(7).Value = tabla.Rows(h)(7) 'Estado
                        dgvEPrestados.Rows(Conta).Cells(8).Value = tabla.Rows(h)(8) 'Consecutivo
                        dgvEPrestados.Rows(Conta).Cells(9).Value = tabla.Rows(h)(9) 'Cantidad entrega
                        dgvEPrestados.Rows(Conta).Cells(10).Value = tabla.Rows(h)(10) 'Tipo de elemento
                        dgvEPrestados.Rows(Conta).Cells(13).Value = tabla.Rows(h)(3) 'Cantidad de Prestamo para validaciones
                        dgvEPrestados.Rows(Conta).Cells(15).Value = tabla.Rows(h)(11) 'codigo Tipo de elemento
                        Conta = Conta + 1
                End Select
            End If
            If dgvEPrestados.RowCount = 0 Then
                Dim EstadoPrestamo As Object
                EstadoPrestamo = {tabla.Rows(h)(0), "0", Today & " " & Now.ToString("hh:mm")}
                InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
                btnEntregarTodo.Visible = False
                btnEntregar.Visible = False
                dgvEPrestados.Columns(11).Visible = False
                dgvEPrestados.Columns(12).Visible = False
            End If

        Next

        For Each dgvfilaconsumo As DataGridViewRow In dgvEPrestados.Rows
            If dgvfilaconsumo.Cells(3).Value = "2" Then
                If dgvfilaconsumo.Cells(3).Value = "1" Then
                    dgvEPrestados.Rows(Conta).DefaultCellStyle.BackColor = Color.FromArgb(252, 115, 35)
                End If
            End If
        Next
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AggDatos() 'Agregamos el elemento buscado al datagrid de los elementos prestados
        ActualizarDGV() 'Se utiliza esta funcion para actualizar el datagridview despúes de una transacción
    End Sub

    Private Sub btnPrestarElementos_Click(sender As Object, e As EventArgs) Handles btnPrestarElementos.Click
        'Validar en cual tab está
        'CUANDO ESTÁ EN EL TAB DE PRESTAMO

        If tabMovimiento.SelectedTab Is tpPrestamo Then

            For i As Integer = 0 To dgvElementosPrestados.Rows.Count - 1
                If dgvElementosPrestados.Rows(i).Cells(3).Value <> "" Then
                    Dim Str As String = dgvElementosPrestados.Rows(i).Cells(3).Value
                    Dim strarr() As String
                    Cont = 0
                    strarr = Str.Split(",")
                    For Each s As String In strarr
                        Cont = Cont + 1
                    Next
                    If dgvElementosPrestados.Rows(i).Cells(2).Value > 1 Then
                        If Cont > dgvElementosPrestados.Rows(i).Cells(2).Value Then
                            MessageBox.Show("La cantidad de observaciones es mayor a la cantidad prestada del elemento." & vbNewLine & "Si desea hacer varias observaciones a un solo elemento, debe separar las observaciones con un guión. ( - ) " & vbNewLine & "Si desea hacer observaciones para cada elemento, debe separar con una coma. ( , )", "Error en las observaciones del elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End If

                End If
            Next

            GuardarPrestamo(1)

        Else
            'CUANDO ESTÁ EN EL TAB DE HISTORIAL
            'Si el historial es igual a cero significa que el prestamo ya se entregó
            If dgvHistorial.RowCount = 0 Then
                btnEntregarTodo.Visible = False
                btnEntregar.Enabled = False
                btnEnviarCorreo.Enabled = False
            End If
            CerrarPestañas()
            BajarNivel(frmMovimientos_documento)
        End If
    End Sub

    Public Sub btnEntregarTodo_Click(sender As Object, e As EventArgs) Handles btnEntregarTodo.Click
        If dgvHistorial.Rows.Count > 0 Then
            Dim CodPrestamo As Integer = dgvHistorial.Rows(0).Cells(0).Value
            For Each dgvfila As DataGridViewRow In dgvHistorial.Rows
                Select Case dgvfila.Cells(3).Value
                    Case > 1
                        'SSE VALIDA SI EL ELEMENTO ES DE CONSUMO O DEVOLUTIVO
                        If dgvfila.Cells(15).Value = "2" Then
                            ''CUANDO ES CONSUMO
                            Datos = SelectElementoPrestamo(CodPrestamo, dgvfila.Cells(1).Value, dgvfila.Cells(4).Value, 1)
                            tablapres = New DataTable
                            tablapres = Datos.tables("datos")
                            With frmMovimientos_EConsumo
                                ReDim .ElementoCons(tablapres.Rows.Count - 1, 7)
                                For i As Integer = 0 To tablapres.Rows.Count - 1
                                        If tablapres.Rows(i)(9) = 0 Then
                                        .ElementoCons(i, 0) = tablapres.Rows(i)(0) 'codprestamo
                                        .ElementoCons(i, 1) = tablapres.Rows(i)(1) 'codelemento
                                        .ElementoCons(i, 2) = 1 'cantidad entrega
                                        .ElementoCons(i, 3) = tablapres.Rows(i)(4) 'Fecha de prestamo
                                        .ElementoCons(i, 4) = Today & " " & Now.ToString("hh:mm")
                                        If tablapres.Rows(i)(6) Is DBNull.Value Then
                                            .ElementoCons(i, 5) = DBNull.Value
                                        Else
                                            .ElementoCons(i, 5) = tablapres.Rows(i)(6) 'observaciones
                                        End If

                                        .ElementoCons(i, 6) = "1" 'Estado de consumo
                                        .ElementoCons(i, 7) = tablapres.Rows(i)(8) 'consecutivo
                                    End If
                                Next
                                .CantElementos = tablapres.Rows.Count
                                .Filas = tablapres.Rows.Count - 1
                                .swCant = 1
                                .NomElem = dgvfila.Cells(2).Value 'Nombre del elemento
                                .ShowDialog()
                            End With
                        Else
                            'CUANDO ES DEVOLUTIVO
                            Datos = SelectElementoPrestamo(CodPrestamo, dgvfila.Cells(1).Value, dgvfila.Cells(4).Value, 1)
                            tablapres = New DataTable
                            tablapres = Datos.tables("datos")

                            For i As Integer = 0 To tablapres.Rows.Count - 1
                                If tablapres.Rows(i)(9) = 0 Then
                                    ElementoPres(0) = tablapres.Rows(i)(0) 'codprestamo
                                    ElementoPres(1) = tablapres.Rows(i)(1) 'codelemento
                                    ElementoPres(2) = 1 'cantidad entrega
                                    ElementoPres(3) = tablapres.Rows(i)(4) 'fechapres
                                    ElementoPres(4) = Today & " " & Now.ToString("hh:mm") 'fecha entrega
                                    If tablapres.Rows(i)(6) Is DBNull.Value Then 'Observaciones
                                        ElementoPres(5) = DBNull.Value
                                    Else
                                        ElementoPres(5) = tablapres.Rows(i)(6)
                                    End If

                                    ElementoPres(6) = "0"
                                    ElementoPres(7) = tablapres.Rows(i)(8)
                                    'VALIDAR SI EL ELEMENTO A ENTREGAR ES DE CONSUMO
                                    EntregarElementos(ElementoPres)
                                    Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                                    Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                                    UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                                    Suma = 0 'Se reinicia la 
                                End If
                            Next
                        End If

                    Case 1
                        'CUANDO ES DE CONSUMO
                        If dgvfila.Cells(15).Value = "2" Then
                            'SSE VALIDA SI EL ELEMENTO ES DE CONSUMO O DEVOLUTIVO
                            'CUANDO ES CONSUMO
                            Datos = SelectElementoPrestamo(CodPrestamo, dgvfila.Cells(1).Value, dgvfila.Cells(4).Value, 1)
                                tablapres = New DataTable
                                tablapres = Datos.tables("datos")
                                With frmMovimientos_EConsumo
                                    ReDim .ElementoCons(tablapres.Rows.Count - 1, 7)
                                    For i As Integer = 0 To tablapres.Rows.Count - 1
                                        If tablapres.Rows(i)(9) = 0 Then
                                            .ElementoCons(i, 0) = tablapres.Rows(i)(0)
                                            .ElementoCons(i, 1) = tablapres.Rows(i)(1)
                                            .ElementoCons(i, 2) = 1
                                            .ElementoCons(i, 3) = tablapres.Rows(i)(4)
                                            .ElementoCons(i, 4) = Today & " " & Now.ToString("hh:mm")
                                            If tablapres.Rows(i)(6) Is DBNull.Value Then
                                                .ElementoCons(i, 5) = DBNull.Value
                                            Else
                                                .ElementoCons(i, 5) = tablapres.Rows(i)(6)
                                            End If

                                            .ElementoCons(i, 6) = "1" 'Estado de consumo
                                            .ElementoCons(i, 7) = tablapres.Rows(i)(8)
                                        End If
                                    Next
                                    .CantElementos = tablapres.Rows.Count
                                    .Filas = tablapres.Rows.Count - 1
                                .swCant = 0
                                .NomElem = dgvfila.Cells(2).Value 'Nombre del elemento
                                    .ShowDialog()
                                End With
                            Else
                            'CUANDO ES DEVOLUTIVO
                            ElementoPres(0) = dgvfila.Cells(0).Value
                            ElementoPres(1) = dgvfila.Cells(1).Value
                            ElementoPres(2) = 1
                            ElementoPres(3) = dgvfila.Cells(4).Value
                            ElementoPres(4) = Today & " " & Now.ToString("hh:mm")
                            If dgvfila.Cells(6).Value = "" Then
                                ElementoPres(5) = DBNull.Value
                            Else
                                ElementoPres(5) = dgvfila.Cells(6).Value
                            End If
                            ElementoPres(6) = "0"
                            ElementoPres(7) = dgvfila.Cells(8).Value
                            EntregarElementos(ElementoPres) 'Se actualiza el prestamo del elemento
                            Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                            Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                            UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                            Suma = 0 'Se reinicia la 
                        End If

                End Select
            Next
            DetallePrestamo = TraerDetallePrestamo(CodPrestamo, 1)
            ActualizarHistorial()
            If dgvHistorial.RowCount = 0 Then
                Dim EstadoPrestamo As Object
                EstadoPrestamo = {CodPrestamo, "0", Today & " " & Now.ToString("hh:mm")}
                InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
                btnEntregarTodo.Visible = False
                btnEntregar.Visible = False
                dgvHistorial.Columns(10).Visible = False
                dgvHistorial.Columns(11).Visible = False
                CerrarPestañas()
                ValidarBotones()
                BajarNivel(frmMovimientos_documento)
            End If
        End If
        ValidarBotones()
    End Sub


    'La funcion AggDatos agrega el elemento buscado al datagridview
    Private Function AggDatos()


        'Validar que los campos no esten vacios
        If txtElemento.Text = "" Or txtCantidad.Text = "" Then
            'Mensaje personalizado cuando el TextBox de la Cantidad del elemento está vacío
            If txtCantidad.Text = "" Then
                MsgBox("Valor para la cantidad no válido", vbCritical)
                txtCantidad.Focus()
            End If
            'Mensaje personalizado cuando el TextBox del elemento está vacío
            If txtElemento.Text = "" Then
                MsgBox("El Campo del elemento está vacío", vbCritical)
                txtElemento.Focus()
            End If

        Else

            If dgvElementosDispo.RowCount = 0 Then
                MsgBox("El elemento no existe", vbCritical)
                txtElemento.Focus()
                txtElemento.Text = ""
            Else
                AggDatosValidado()
            End If

        End If

    End Function

    Private Sub btnEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
        SWEditar = 1
        With frm_registro_update
            .SWEdit = 1
            .txtdocumento.Enabled = False 'inabilitamos el texbox del documento
            .txtdocumento.Text = Cliente(0)
            .txtnombres.Text = Cliente(1)
            .txtapellidos.Text = Cliente(2)
            .txtbuscador.Text = Cliente(4)

            'Tipo Cliente
            .tipo_cliente = Cliente(9)
            .txttipo_cliente.Text = Cliente(8)
            .cmbtipocliente.Enabled = False
            .txttipo_cliente.Visible = True
            .linktipo_cliente.Visible = True

            .cmbtipo_documento.Select()
            .VCmb(2) = Cliente(7)
            .VCmb(1) = Cliente(4)

            .txtemail.Text = Cliente(10)
            .txtmovil.Text = Cliente(11)

            'estado de sincronizacion
            Select Case Cliente(12)
                Case "0"
                    .sincronizado = 0

                Case "1"
                    .sincronizado = 1

            End Select

            .ficha = Cliente(3)
            For Each cnt As Control In frm_registro_update.Controls
                cnt.Focus()

            Next

            If Cliente(3) = "No Aplica" And Cliente(9) <> 1 Then
                .codficha = 0
                .txtbuscador.Enabled = False

                .cmbficha.Enabled = False
            Else
                If Cliente(3) = "Sin Ficha" Then
                    .codficha = 1
                Else
                    .codficha = Cliente(4)
                End If
            End If



            .ptbFotocliente.Image = Nothing
            If File.Exists(Cliente(5).ToString) Then
                Dim FS = New FileStream(Cliente(5), FileMode.Open)
                .ptbFotocliente.Image = Image.FromStream(FS) 'Se muestra la foto en un picturebox si la tiene
                FS.Close()
            Else
                MsgBox("No se encontró la imagen del cliente", vbCritical)
            End If
            .lblheader.Text = "Actualizar Información"

            .btnguardar.Visible = False
            .btnactualizar.Visible = True


            .ShowDialog()
        End With
    End Sub

    Public Sub btnDuplicarPrestamo_Click(sender As Object, e As EventArgs) Handles btnDuplicarPrestamo.Click

        For Each dgvfila As DataGridViewRow In dgvHistorial.Rows
            Dim codigos = {dgvfila.Cells(0).Value, dgvfila.Cells(1).Value}


            Datos = DuplicarElementos(codigos) 'Se trae cada uno de los elementos prestados
            Datos2 = SelectElemento(dgvfila.Cells(1).Value, 1)
            Disponible = Datos2.rows(0)(2)
            'Se recorre la tabla y se suma la cantidad si estan repetidos
            For i = 0 To Datos.rows.count - 1
                Cantidad = Cantidad + Datos.rows(i)(2)
            Next

            'Se duplica el elemento si la cantidad a prestar es menor o igual a la cantidad disponible del elemento
            If Cantidad <= Datos2.rows(0)(2) Then
                For Each dgvfila2 As DataGridViewRow In dgvDuplicar.Rows
                    If dgvfila.Cells(1).Value = dgvfila2.Cells(0).Value Then
                        SWRepe = 1
                        Exit For
                    Else
                        SWRepe = 0
                    End If
                Next
                If SWRepe = 0 Then
                    dgvDuplicar.Rows.Add()
                    dgvDuplicar.Rows(Contador).Cells(0).Value = dgvfila.Cells(1).Value
                    dgvDuplicar.Rows(Contador).Cells(1).Value = dgvfila.Cells(2).Value
                    dgvDuplicar.Rows(Contador).Cells(2).Value = Cantidad
                    dgvDuplicar.Rows(Contador).Cells(3).Value = ""
                    dgvDuplicar.Rows(Contador).Cells(4).Value = Today & " " & Now.ToString("hh:mm")
                    dgvDuplicar.Rows(Contador).Cells(5).Value = ""
                    Contador = Contador + 1
                End If
            End If
            Cantidad = 0
        Next
        FilasDupli = dgvDuplicar.RowCount - 1
        ReDim MTElementos(FilasDupli, 6)
        For i = 0 To FilasDupli
            For j = 0 To 5
                MTElementos(i, j) = dgvDuplicar.Rows(i).Cells(j).Value
                If j = 2 Then

                    Datos2 = SelectElemento(MTElementos(i, 0), 1)
                    Disponible = Datos2.rows(0)(2)
                    Resta = Disponible - MTElementos(i, j)
                    UpdateDispoElemento(MTElementos(i, 0), Resta)
                    Resta = 0
                End If
            Next
        Next
        dgvDuplicar.Rows.Clear()

        frmMovimientos_DuplicarPrestamo.ShowDialog()

    End Sub

    Private Sub btnCambiarCliente_Click(sender As Object, e As EventArgs) Handles btnCambiarCliente.Click
        If dgvHistorial.Columns(14).Visible = False Then
            dgvHistorial.Columns(14).Visible = True
            ActualizarHistorialMora()
            SwCCliente = 1
            FilasDupli = 0
        Else
            For i As Integer = 0 To dgvHistorial.Rows.Count - 1
                If dgvHistorial.Rows(i).Cells(14).Value = CheckState.Checked Then
                    FilasDupli = FilasDupli + 1
                End If
            Next
            If FilasDupli = 0 Then
                MessageBox.Show("No hay elementos seleccionados para cambiar de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            FilasDupli = FilasDupli - 1
                ReDim MTElementos(FilasDupli, 6)
                Dim ContMT As Integer
                ContMT = 0
                For i As Integer = 0 To dgvHistorial.Rows.Count - 1
                    If dgvHistorial.Rows(i).Cells(14).Value = CheckState.Checked Then
                        If dgvHistorial.Rows(i).Cells(5).Value = "" Then
                            MTElementos(ContMT, 0) = dgvHistorial.Rows(i).Cells(1).Value 'Codigo del elemento
                            MTElementos(ContMT, 1) = dgvHistorial.Rows(i).Cells(2).Value 'Descripcion
                            MTElementos(ContMT, 2) = dgvHistorial.Rows(i).Cells(3).Value 'Cantidad
                            If dgvHistorial.Rows(i).Cells(6).Value = "" Then 'Observaciones
                                MTElementos(ContMT, 3) = "" 'Cuando está vacio
                            Else
                                MTElementos(ContMT, 3) = dgvHistorial.Rows(i).Cells(3).Value 'Cuanto tiene una observacion
                            End If

                            MTElementos(ContMT, 4) = Today.Date & " " & Now.ToString("hh:mm") 'Fecha de prestamo

                            If dgvHistorial.Rows(i).Cells(5).Value = "" Then 'Fecha limite de entrega, si la tiene
                                MTElementos(ContMT, 5) = ""
                            Else
                                MTElementos(ContMT, 5) = dgvHistorial.Rows(i).Cells(5).Value
                            End If

                            MTElementos(ContMT, 6) = dgvHistorial.Rows(i).Cells(15).Value
                            ContMT = ContMT + 1
                        Else
                            If dgvHistorial.Rows(i).Cells(5).Value <= Today.Date & " " & Now.ToString("hh:mm") Then
                                MsgBox("No se puede cambiar de cliente el elemento " & dgvHistorial.Rows(i).Cells(2).Value & " ya que la fecha limite de entrega se superó", vbCritical + vbOK, "Error")
                                Contador = Contador + 1
                            Else
                                MTElementos(ContMT, 0) = dgvHistorial.Rows(i).Cells(1).Value 'Codigo del elemento
                                MTElementos(ContMT, 1) = dgvHistorial.Rows(i).Cells(2).Value 'Descripcion
                                MTElementos(ContMT, 2) = dgvHistorial.Rows(i).Cells(3).Value 'Cantidad
                                If dgvHistorial.Rows(i).Cells(3).Value = "" Then 'Observaciones
                                    MTElementos(ContMT, 3) = "" 'Cuando está vacio
                                Else
                                    MTElementos(ContMT, 3) = dgvHistorial.Rows(i).Cells(3).Value 'Cuanto tiene una observacion
                                End If

                                MTElementos(ContMT, 4) = Today.Date & " " & Now.ToString("hh:mm") 'Fecha de prestamo

                                If dgvHistorial.Rows(i).Cells(5).Value = "" Then 'Fecha limite de entrega, si la tiene
                                    MTElementos(ContMT, 5) = ""
                                Else
                                    MTElementos(ContMT, 5) = dgvHistorial.Rows(i).Cells(5).Value
                                End If

                                MTElementos(ContMT, 6) = dgvHistorial.Rows(i).Cells(15).Value
                                ContMT = ContMT + 1
                            End If
                        End If
                    End If
                Next
                If Contador < FilasDupli Then
                    SwFrm = 1
                    frmMovimientos_DuplicarPrestamo.Label1.Text = "Cambiar de cliente"
                    frmMovimientos_DuplicarPrestamo.ShowDialog()
                End If
            End If
    End Sub

    Private Sub btnEnviarCorreo_Click(sender As Object, e As EventArgs) Handles btnEnviarCorreo.Click

        If dgvElementosPrestados.RowCount > 0 Then
            If cmbTipoPrestamo.SelectedValue = 2 Then

                With frmPrestamoExterno
                    For i = 0 To dgvElementosPrestados.RowCount - 1
                        .dgvElementosPrestados.Rows.Add()
                        For j = 0 To 5
                            .dgvElementosPrestados.Rows(i).Cells(j).Value = dgvElementosPrestados.Rows(i).Cells(j).Value
                        Next
                    Next
                    'Informacion del cliente
                    'Nombres
                    .lblNombresNom.Text = Cliente(1) & " " & Cliente(2) & " -  " & Cliente(7) 'Tipo de cliente
                    'Documento
                    .lblDocidNom.Text = Cliente(0)
                    .lblNumFicha.Text = (Cliente(4) & " - " & Cliente(3)) 'Numero de la ficha concatenada al nombre de la ficha
                    'Validar si el cliente tiene una foto en el registro
                    If Cliente(5) <> "" Then
                        .ptbFotoCliente.Image = Image.FromFile(Cliente(5)) 'Se muestra la foto en un picturebox si la tiene
                    End If
                    .lblTipoDocidNom.Text = Cliente(6) 'Tipo de documento
                    .lblCorreoNom.Text = Cliente(10)
                    .lblTelefonoNom.Text = Cliente(11)
                End With
                SwExterno = 1
                GuardarPrestamo(1)
                frmPrestamoExterno.Show()

            Else
                MsgBox("El movimiento a realizar no es un prestamo externo", vbCritical)
            End If
        Else
            MsgBox("No hay elementos prestados", vbCritical)
            txtElemento.Focus()
        End If

    End Sub

    Private Sub TimerMora_Tick(sender As Object, e As EventArgs) Handles TimerMora.Tick
        Select Case btnAlertaMora.Visible
            Case False
                btnAlertaMora.Visible = True
                gbxCliente.BaseColor = Color.FromArgb(255, 226, 226)

            Case True
                btnAlertaMora.Visible = False
                gbxCliente.BaseColor = Color.FromName("ControlLightLight")
        End Select
    End Sub

    Private Sub btnCambiarElemento_Click(sender As Object, e As EventArgs)
        If tabMovimiento.SelectedTab Is tpPrestamo Then
            MessageBox.Show("Seleccione un elemento para cambiar", "Cambiar elemento", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tabMovimiento.SelectedTab = tpHistorial
        Else
            frmMovimientos_CambiarElemento_Codigo.ShowDialog()
        End If
    End Sub

    Private Sub lblReservas_Click(sender As Object, e As EventArgs) Handles lblReservas.Click
        frmMovimientos_Reserva.Show()

    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        If TraspasoDetalle = 1 Then
            If MessageBox.Show("¿Está seguro que el cliente quiere devolver todos los elementos traspasados?" & vbNewLine & "Revisar los elementos antes de entregar", "Devolver elementos traspasados", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                'Se requiere de un archivo que respalde el traspaso nuevamente
                MessageBox.Show("Se requiere de un archivo que respalde el traspaso de elementos nuevamente", "Debe anexar un archivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Se abre un dialogo para cargar un archivo
                Dim result As New OpenFileDialog
                Dim Ruta As String
                result.Title = "Seleccionar el respaldo para el traspaso de elementos"
                ' Test result.
                If result.ShowDialog = DialogResult.OK Then
                    Ruta = result.FileName
                    TraspasoRespaldo(lblCodPres.Text, Ruta)
                Else
                    MessageBox.Show("No se puede completar el traspaso de elementos", "No se completó la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                For Each dgvfila As DataGridViewRow In dgvHistorial.Rows
                    Dim ElementCant As Object
                    ElementCant = Select_1ParametroVarchar("sp_tblelemento_Disponible", dgvfila.Cells(1).Value)
                    UpdateCANTElemento(dgvfila.Cells(1).Value, ElementCant.Rows(0)(0) + dgvfila.Cells(3).Value)
                Next
                btnEntregarTodo_Click(Nothing, Nothing)

            End If
            TraspasoDetalle = 0
        Else
            'Validar si hay elementos prestados y habilitar las opciones para entregar los elementos
            If dgvHistorial.RowCount > 0 Then
                If btnEntregarTodo.Visible = False Then
                    SwBtn = 1
                    btnEntregarTodo.Visible = True
                    dgvHistorial.Columns(11).Visible = True
                    dgvHistorial.Columns(12).Visible = True
                    btnEntregar.Text = "Cancelar"
                Else
                    SwBtn = 1
                    btnEntregar.Text = "Recibir elementos"
                    btnEntregarTodo.Visible = False
                    dgvHistorial.Columns(11).Visible = False
                    dgvHistorial.Columns(12).Visible = False
                End If
            End If
        End If
    End Sub


    Private Sub btnEnviarAMora_Click(sender As Object, e As EventArgs) Handles btnEnviarAMora.Click
        'Dim Contador As Integer 'Variable que llevara la posicion en un dgv
        'Validacion para enviar a mora
        'el primer click sobre el boton será para habilitar la columna para seleccionar los elementos para enviar a mora
        If dgvHistorial.Columns(14).Visible = False Then
            dgvHistorial.Columns(14).Visible = True
            ArregloMora(10) = 1 'Validar si ya dio un click en el boton mora
            ActualizarHistorialMora()
        Else
            'Nuevamente se valida para que sea el segundo click
            If ArregloMora(10) = 1 Then
                Dim Validar As Byte 'Validar si tiene seleccionado algun elemento
                Validar = 0
                For Each dgvfila As DataGridViewRow In dgvHistorial.Rows

                    If dgvfila.Cells(14).Value = CheckState.Checked Then
                        Validar = 1
                    End If
                Next
                If Validar = 1 Then 'SE EJECUTA EL INSERT SI HAY ELEMENTOS SELECCIONADOS
                    With frmMora_Insert_Update
                        'MAESTRO DE LA MORA
                        .dtpEntradaMora.Value = Now.Date.ToShortDateString 'Hora de entrada a la mora
                        .lblNombresNom.Text = lblNombresNom.Text 'Nombres del cliente
                        .lblDocidNom.Text = lblDocidNom.Text 'Documento del cliente
                        .lblTipoDocidNom.Text = lblTipoDocidNom.Text 'Tipo de documento
                        .lblNumFicha.Text = lblNumFicha.Text 'Ficha del cliente
                        .lblTelefonoNom.Text = Cliente(11) 'Telefono del cliente
                        .lblCorreoElectNom.Text = Cliente(10) 'Correo electronico
                        CargarImg(.ptbFotoCliente, Cliente(5), "del cliente") 'Imagen del cliente
                        .lblCodPres.Text = lblCodPres.Text 'Codigo del prestamo
                        '==================

                        'DETALLE DE LA MORA
                        Dim Filamora As Integer
                        For Each dgvfila As DataGridViewRow In dgvHistorial.Rows
                            If dgvfila.Cells(14).Value = CheckState.Checked Then
                                .dgvMora.Rows.Add()
                                .dgvMora.Rows(Filamora).Cells(0).Value = dgvfila.Cells(1).Value 'Codigo del elemento
                                .dgvMora.Rows(Filamora).Cells(1).Value = dgvfila.Cells(2).Value 'Nombre del elemento
                                .dgvMora.Rows(Filamora).Cells(2).Value = dgvfila.Cells(3).Value 'Cantidad a mora
                                .dgvMora.Rows(Filamora).Cells(3).Value = dgvfila.Cells(6).Value 'Observaciones
                                .dgvMora.Rows(Filamora).Cells(4).Value = dgvfila.Cells(10).Value 'TipoElemento
                                .dgvMora.Rows(Filamora).Cells(5).Value = "1" 'Estado de la mora (ACTIVO)
                                .dgvMora.Rows(Filamora).Cells(6).Value = dgvfila.Cells(8).Value 'Consecutivo del elemento
                                .dgvMora.Rows(Filamora).Cells(7).Value = dgvfila.Cells(4).Value 'Fecha de prestamo del elemento
                                Filamora = Filamora + 1
                            End If
                        Next
                        '===================

                        .ShowDialog()
                    End With
                Else
                    MessageBox.Show("Debe seleccionar los elementos que se van a enviar a mora.", "No hay elementos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If


    End Sub

    Private Sub dgvHistorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellContentClick
        If dgvHistorial.RowCount > 0 Then

            Dim CColumna, Fila As Integer

            CColumna = dgvHistorial.CurrentCell.ColumnIndex

            Select Case CColumna
                Case 11 'Entregar un solo elemento
                    'Si la cantidad es mayor a uno (1) se abre un formulario con los elementos y sus respectivas observaciones
                    If dgvHistorial.Rows(e.RowIndex).Cells(3).Value > 1 Then
                        frmMovimientos_Detalle_EntregarUno.CargarFormulario(dgvHistorial.Rows(e.RowIndex).Cells(0).Value, dgvHistorial.Rows(e.RowIndex).Cells(1).Value, dgvHistorial.Rows(e.RowIndex).Cells(4).Value, 1, lblDocidNom.Text, 1)
                        'Si la cantidad es igual a uno (1) se entrega el elemento directamente
                    Else
                        'CUANDO ES DE CONSUMO
                        If dgvHistorial.Rows(e.RowIndex).Cells(15).Value = "2" Then
                            'SSE VALIDA SI EL ELEMENTO ES DE CONSUMO O DEVOLUTIVO
                            'CUANDO ES CONSUMO
                            Datos = SelectElementoPrestamo(lblCodPres.Text, dgvHistorial.Rows(e.RowIndex).Cells(1).Value, dgvHistorial.Rows(e.RowIndex).Cells(4).Value, 1)
                            tablapres = New DataTable
                            tablapres = Datos.tables("datos")
                            With frmMovimientos_EConsumo
                                ReDim .ElementoCons(tablapres.Rows.Count - 1, 7)
                                For i As Integer = 0 To tablapres.Rows.Count - 1
                                    If tablapres.Rows(i)(9) = 0 Then
                                        .ElementoCons(i, 0) = tablapres.Rows(i)(0)
                                        .ElementoCons(i, 1) = tablapres.Rows(i)(1)
                                        .ElementoCons(i, 2) = 1
                                        .ElementoCons(i, 3) = tablapres.Rows(i)(4)
                                        .ElementoCons(i, 4) = Today & " " & Now.ToString("hh:mm")
                                        If tablapres.Rows(i)(6) Is DBNull.Value Then
                                            .ElementoCons(i, 5) = DBNull.Value
                                        Else
                                            .ElementoCons(i, 5) = tablapres.Rows(i)(6)
                                        End If
                                        .ElementoCons(i, 6) = "1" 'Estado de consumo
                                        .ElementoCons(i, 7) = tablapres.Rows(i)(8)
                                    End If
                                Next
                                .CantElementos = tablapres.Rows.Count
                                .Filas = tablapres.Rows.Count - 1
                                .swCant = 0
                                .NomElem = dgvHistorial.Rows(e.RowIndex).Cells(2).Value 'Nombre del elemento
                                .ShowDialog()
                            End With
                        Else
                            'CUANDO ES DEVOLUTIVO
                            ElementoPres(0) = dgvHistorial.Rows(e.RowIndex).Cells(0).Value
                            ElementoPres(1) = dgvHistorial.Rows(e.RowIndex).Cells(1).Value
                            ElementoPres(2) = 1
                            ElementoPres(3) = dgvHistorial.Rows(e.RowIndex).Cells(4).Value
                            ElementoPres(4) = Today & " " & Now.ToString("hh:mm")
                            If dgvHistorial.Rows(e.RowIndex).Cells(6).Value = "" Then
                                ElementoPres(5) = DBNull.Value
                            Else
                                ElementoPres(5) = dgvHistorial.Rows(e.RowIndex).Cells(6).Value
                            End If
                            ElementoPres(6) = "0"
                            ElementoPres(7) = dgvHistorial.Rows(e.RowIndex).Cells(8).Value
                            EntregarElementos(ElementoPres) 'Se actualiza el prestamo del elemento
                            Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                            Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                            UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                            Suma = 0 'Se reinicia la 
                        End If
                    End If
                    ValidarElementosPrestamo()
                Case 12 'Entregar todo
                    Select Case dgvHistorial.Rows(e.RowIndex).Cells(3).Value
                        Case > 1
                            'SSE VALIDA SI EL ELEMENTO ES DE CONSUMO O DEVOLUTIVO
                            If dgvHistorial.Rows(e.RowIndex).Cells(15).Value = "2" Then
                                ''CUANDO ES CONSUMO
                                Datos = SelectElementoPrestamo(lblCodPres.Text, dgvHistorial.Rows(e.RowIndex).Cells(1).Value, dgvHistorial.Rows(e.RowIndex).Cells(4).Value, 1)
                                tablapres = New DataTable
                                tablapres = Datos.tables("datos")
                                With frmMovimientos_EConsumo
                                    ReDim .ElementoCons(tablapres.Rows.Count - 1, 7)
                                    For i As Integer = 0 To tablapres.Rows.Count - 1
                                        If tablapres.Rows(i)(9) = 0 Then
                                            .ElementoCons(i, 0) = tablapres.Rows(i)(0) 'codprestamo
                                            .ElementoCons(i, 1) = tablapres.Rows(i)(1) 'codelemento
                                            .ElementoCons(i, 2) = 1 'cantidad entrega
                                            .ElementoCons(i, 3) = tablapres.Rows(i)(4) 'Fecha de prestamo
                                            .ElementoCons(i, 4) = Today & " " & Now.ToString("hh:mm")
                                            If tablapres.Rows(i)(6) Is DBNull.Value Then
                                                .ElementoCons(i, 5) = DBNull.Value
                                            Else
                                                .ElementoCons(i, 5) = tablapres.Rows(i)(6) 'observaciones
                                            End If

                                            .ElementoCons(i, 6) = "1" 'Estado de consumo
                                            .ElementoCons(i, 7) = tablapres.Rows(i)(8) 'consecutivo
                                        End If
                                    Next
                                    .CantElementos = tablapres.Rows.Count
                                    .Filas = tablapres.Rows.Count - 1
                                    .swCant = 1
                                    .NomElem = dgvHistorial.Rows(e.RowIndex).Cells(2).Value 'Nombre del elemento
                                    .ShowDialog()
                                End With
                            Else
                                'CUANDO ES DEVOLUTIVO
                                Datos = SelectElementoPrestamo(lblCodPres.Text, dgvHistorial.Rows(e.RowIndex).Cells(1).Value, dgvHistorial.Rows(e.RowIndex).Cells(4).Value, 1)
                                tablapres = New DataTable
                                tablapres = Datos.tables("datos")

                                For i As Integer = 0 To tablapres.Rows.Count - 1
                                    If tablapres.Rows(i)(9) = 0 Then
                                        ElementoPres(0) = tablapres.Rows(i)(0) 'codprestamo
                                        ElementoPres(1) = tablapres.Rows(i)(1) 'codelemento
                                        ElementoPres(2) = 1 'cantidad entrega
                                        ElementoPres(3) = tablapres.Rows(i)(4) 'fechapres
                                        ElementoPres(4) = Today & " " & Now.ToString("hh:mm") 'fecha entrega
                                        If tablapres.Rows(i)(6) Is DBNull.Value Then 'Observaciones
                                            ElementoPres(5) = DBNull.Value
                                        Else
                                            ElementoPres(5) = tablapres.Rows(i)(6)
                                        End If

                                        ElementoPres(6) = "0"
                                        ElementoPres(7) = tablapres.Rows(i)(8)
                                        'VALIDAR SI EL ELEMENTO A ENTREGAR ES DE CONSUMO
                                        EntregarElementos(ElementoPres)
                                        Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                                        Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                                        UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                                        Suma = 0 'Se reinicia la 
                                    End If
                                Next
                            End If

                        Case 1
                            'CUANDO ES DE CONSUMO
                            If dgvHistorial.Rows(e.RowIndex).Cells(15).Value = "2" Then
                                'SSE VALIDA SI EL ELEMENTO ES DE CONSUMO O DEVOLUTIVO
                                'CUANDO ES CONSUMO
                                Datos = SelectElementoPrestamo(lblCodPres.Text, dgvHistorial.Rows(e.RowIndex).Cells(1).Value, dgvHistorial.Rows(e.RowIndex).Cells(4).Value, 1)
                                tablapres = New DataTable
                                tablapres = Datos.tables("datos")
                                With frmMovimientos_EConsumo
                                    ReDim .ElementoCons(tablapres.Rows.Count - 1, 7)
                                    For i As Integer = 0 To tablapres.Rows.Count - 1
                                        If tablapres.Rows(i)(9) = 0 Then
                                            .ElementoCons(i, 0) = tablapres.Rows(i)(0)
                                            .ElementoCons(i, 1) = tablapres.Rows(i)(1)
                                            .ElementoCons(i, 2) = 1
                                            .ElementoCons(i, 3) = tablapres.Rows(i)(4)
                                            .ElementoCons(i, 4) = Today & " " & Now.ToString("hh:mm")
                                            If tablapres.Rows(i)(6) Is DBNull.Value Then
                                                .ElementoCons(i, 5) = DBNull.Value
                                            Else
                                                .ElementoCons(i, 5) = tablapres.Rows(i)(6)
                                            End If

                                            .ElementoCons(i, 6) = "1" 'Estado de consumo
                                            .ElementoCons(i, 7) = tablapres.Rows(i)(8)
                                        End If
                                    Next
                                    .CantElementos = tablapres.Rows.Count
                                    .Filas = tablapres.Rows.Count - 1
                                    .swCant = 0
                                    .NomElem = dgvHistorial.Rows(e.RowIndex).Cells(2).Value 'Nombre del elemento
                                    .ShowDialog()
                                End With
                            Else
                                'CUANDO ES DEVOLUTIVO
                                ElementoPres(0) = dgvHistorial.Rows(e.RowIndex).Cells(0).Value
                                ElementoPres(1) = dgvHistorial.Rows(e.RowIndex).Cells(1).Value
                                ElementoPres(2) = 1
                                ElementoPres(3) = dgvHistorial.Rows(e.RowIndex).Cells(4).Value
                                ElementoPres(4) = Today & " " & Now.ToString("hh:mm")
                                If dgvHistorial.Rows(e.RowIndex).Cells(6).Value = "" Then
                                    ElementoPres(5) = DBNull.Value
                                Else
                                    ElementoPres(5) = dgvHistorial.Rows(e.RowIndex).Cells(6).Value
                                End If
                                ElementoPres(6) = "0"
                                ElementoPres(7) = dgvHistorial.Rows(e.RowIndex).Cells(8).Value
                                EntregarElementos(ElementoPres) 'Se actualiza el prestamo del elemento
                                Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                                Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                                UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                                Suma = 0 'Se reinicia la 
                            End If
                    End Select
                    ValidarElementosPrestamo()
                Case 14
                    Fila = dgvHistorial.CurrentRow.Index
                    If dgvHistorial.Rows(Fila).Cells(14).Value = CheckState.Checked Then
                        dgvHistorial.Rows(Fila).Cells(14).Value = CheckState.Unchecked
                    Else
                        dgvHistorial.Rows(Fila).Cells(14).Value = CheckState.Checked
                    End If
            End Select
        End If

    End Sub

    'LA FUNCION ValidarElementosPrestamo PERMITE AHORRAR LINEAS DE CODIGO
    Private Function ValidarElementosPrestamo()
        DetallePrestamo = TraerDetallePrestamo(CodigoPrestamo, 1)
        ActualizarHistorial()
        If dgvHistorial.RowCount = 0 Then
            Dim EstadoPrestamo As Object
            EstadoPrestamo = {lblCodPres.Text, "0", Today & " " & Now.ToString("hh:mm")}
            InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
            btnEntregarTodo.Visible = False
            btnEntregar.Visible = False
            dgvHistorial.Columns(10).Visible = False
            dgvHistorial.Columns(11).Visible = False
            CerrarPestañas()
            ValidarBotones()
            BajarNivel(frmMovimientos_documento)
        End If
        ValidarBotones()
    End Function

    'La funcion ActualizarDGV actualiza el datagrid de los elementos disponibles

    Public Sub frmMovimientos_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frmMovimientos_detalle_Click
        Next
        cbxFechalimite.Enabled = True

        'Si la variable MaestroPrestamo es nothing significa que no tiene prestamo activo
        If MaestroPrestamo IsNot Nothing Then
            Dim TipoPres As Object
            TipoPres = TipoPrestamo(MaestroPrestamo.rows(0)(0))
            TipoPres = TipoPres.tables("datos")
            'Se valida que si el tipo de prestamo es distinto a un interno
            If TipoPres.rows(0)(0) <> 1 Then
                dtpFechaLimite.Value = TipoPres.rows(0)(2)
            End If
            If MaestroPrestamo.rows(0)(3) = 6 Then
                lblSeguro.Visible = False
                tpHistorial.Text = "Elementos traspasados"
                TraspasoDetalle = 1
            End If
        End If

        'Se carga un botón si el cliente está en mora
        If SWMORA = 1 Then
            TimerMora.Start() 'Se inicia un timer que permite el parpadeo de un botón
        Else
            TimerMora.Stop() 'Cuando el cliente no tiene una mora activa se detiene el timer
            btnAlertaMora.Visible = False 'y el botón se oculta
        End If

        'Informacion del cliente
        'Nombres
        lblNombresNom.Text = Cliente(1) & " " & Cliente(2) & "  -  " & Cliente(8) 'Tipo de cliente
        'Documento
        lblDocidNom.Text = Cliente(0)
        lblNumFicha.Text = (Cliente(4) & " - " & Cliente(3)) 'Numero de la ficha concatenada al nombre de la ficha
        'Validar si el cliente tiene una foto en el registro
        ptbFotoCliente.Image = Nothing
        If Cliente(5) Is DBNull.Value Then
            ptbFotoCliente.Image = Nothing
        Else
            If File.Exists(Cliente(5)) Then
                Dim FS = New FileStream(Cliente(5), FileMode.Open)
                ptbFotoCliente.Image = Image.FromStream(FS) 'Se muestra la foto en un picturebox si la tiene
                FS.Close()
            Else
                MsgBox("No se encontró la imagen del cliente", vbCritical)
            End If
        End If

        If SwFrm = 1 Then
            tabMovimiento.SelectedTab = tpPrestamo
            For i = 0 To FilasDupli
                dgvElementosPrestados.Rows.Add()
                For j = 0 To 5
                    dgvElementosPrestados.Rows(i).Cells(j).Value = MTElementos(i, j)
                Next
                dgvElementosPrestados.Rows(i).Cells(8).Value = MTElementos(i, 6)
            Next
            SwFrm = 0
        End If


        lblTipoDocidNom.Text = Cliente(6) 'Tipo de documento
        If tabMovimiento.SelectedTab Is tpPrestamo Then
            TimerFechaLimite.Start()
            btnEnviarAMora.Visible = False
            cmbTipoPrestamo.Select() 'Hacer focus en el combobox de tipo prestamo para cargar los prestamos
            cmbTipoPrestamo.SelectedValue = CmbValue
            ActualizarDGV()
            txtElemento.Focus()

        Else
            ActualizarHistorial()
            If dgvHistorial.Rows.Count = 0 Then
                btnEnviarAMora.Visible = False
            Else
                btnEnviarAMora.Visible = True
            End If
        End If
        If dgvHistorial.Rows.Count > 0 Then
            btnCambiarCliente.Visible = True

        Else
            btnCambiarCliente.Visible = False

        End If
        dtpFechaLimit.Value = Today.Date
        FechLimit(0) = dtpFechaLimit.Value
        FechLimit(1) = dtpFechaLimitHora.Value.ToShortTimeString
    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frmMovimientos_detalle_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub


    Private Sub txtElemento_KeyUp(sender As Object, e As KeyEventArgs) Handles txtElemento.KeyUp
        ActualizarDGV() 'Se utiliza esta funcion para actualizar el datagridview despúes de una transacción
    End Sub

    Private Sub lblFormatoSalida_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFormatoSalida.LinkClicked
        If System.IO.File.Exists(MaestroPrestamo.rows(0)(11)) Then
            Process.Start(MaestroPrestamo.rows(0)(11))
        Else
            MessageBox.Show("El archivo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lblTraspaso_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblTraspaso.LinkClicked
        If System.IO.File.Exists(MaestroPrestamo.rows(0)(8)) Then
            Process.Start(MaestroPrestamo.rows(0)(8))
        Else
            MessageBox.Show("El archivo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lblSeguro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSeguro.LinkClicked
        frmSeguros.ShowDialog()
    End Sub

    Private Sub TimerFechaLimite_Tick(sender As Object, e As EventArgs) Handles TimerFechaLimite.Tick
        If FechLimit(0) <> dtpFechaLimit.Value Then
            If FechLimit(1) <> dtpFechaLimitHora.Value.ToShortTimeString Then
                FechLimit(1) = dtpFechaLimitHora.Value.ToShortTimeString
            End If
            For Each dgvfila As DataGridViewRow In dgvElementosPrestados.Rows
                dgvfila.Cells(5).Value = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
            Next
            FechLimit(0) = dtpFechaLimit.Value
        Else
            If FechLimit(1) <> dtpFechaLimitHora.Value.ToShortTimeString Then
                For Each dgvfila As DataGridViewRow In dgvElementosPrestados.Rows
                    dgvfila.Cells(5).Value = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
                Next
                FechLimit(1) = dtpFechaLimitHora.Value.ToShortTimeString
            End If
        End If
    End Sub

    Private Sub btnAlertaMora_Click(sender As Object, e As EventArgs) Handles btnAlertaMora.Click
        'Se muestra el detalle de la mora, si el cliente posee una
        With frm_detalle_mora
            .cod_mora = ClienteMora(0) 'Codigo de la mora
            .lblcliente.Text = Cliente(1) & " " & Cliente(2) 'Nombre del cliente
            .check_entregados.Checked = False
            'este arreglo nos servira para mostrar los datos del cliente en el reporte de excel del detalle de la mora
            .datos_cliente = {Cliente(0),'Documento
                        Cliente(1) & " " & Cliente(2), 'Nombre
                        Cliente(4), 'ficha
                        Cliente(3)'Porgrama
                        }
            .reload()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnSeguro_Click(sender As Object, e As EventArgs)
        If dgvElementosPrestados.Rows.Count > 0 Then
            frmMovimientos_Seguro.ShowDialog()
        Else
            MessageBox.Show("No hay elementos prestados, elija los elementos que desee prestar", "No hay elementos prestados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbxFechalimite_CheckedChanged(sender As Object, e As EventArgs) Handles cbxFechalimite.CheckedChanged
        Dim Equis As Integer = cbxFechalimite.Location.X
        If cbxFechalimite.Checked = True Then
            cbxFechalimite.Location = New Point(Equis, 9)
            dtpFechaLimit.Visible = True
            dtpFechaLimitHora.Visible = True
        Else
            cbxFechalimite.Location = New Point(Equis, 40)
            dtpFechaLimit.Visible = False
            dtpFechaLimitHora.Visible = False
        End If
    End Sub

    Private Sub txtElemento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtElemento.KeyDown
        'Valida si la tecla presionada es la Tecla Enter
        Select Case e.KeyCode
            Case Keys.Enter
                AggDatos()
                ActualizarDGV() 'Se utiliza esta funcion para actualizar el datagridview despúes de una transacción
        End Select
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        'Valida si la tecla presionada es la Tecla Enter
        Select Case e.KeyCode
            Case Keys.Enter
                AggDatos()
                ActualizarDGV()
        End Select
    End Sub

    'Este metodo cambia el diseño del boton btnprestarelementos para así realizar varios procesos en un mismo boton
    Public Sub tabmovimiento_Click(sender As Object, e As EventArgs) Handles tabMovimiento.Click
        'Condicion según el tab seleccionado en el TabMovimiento
        'Si el tab seleccionado es tpHistorial
        If tabMovimiento.SelectedTab Is tpHistorial Then
            dgvHistorial.Columns(14).Visible = False

            btnEnviarCorreo.Visible = False
            btnPrestarElementos.Text = "Guardar cambios"
            btnPrestarElementos.Image = Global.Appsena.My.Resources.Resources.icons8_save_641
            btnPrestarElementos.Visible = True
            If dgvHistorial.Rows.Count > 0 Then
                btnEntregar.Visible = True
                btnEnviarAMora.Visible = True
                btnDuplicarPrestamo.Visible = True
            Else
                btnEntregar.Visible = False
                btnEnviarAMora.Visible = False
                btnDuplicarPrestamo.Visible = False
            End If
            If lblCodPres.Text <> "cod" Then
                DetallePrestamo = TraerDetallePrestamo(lblCodPres.Text, 1)
                ActualizarHistorial()
            End If
            TimerFechaLimite.Stop()
        Else
            If tabMovimiento.SelectedTab Is tpPrestamo Then
                'Se inicia un timer para controlar el valor de la fecha limite si se cambia
                TimerFechaLimite.Start()

                'Si el tab seleccionado es tpMovimiento
                btnPrestarElementos.Text = "Prestar elementos" 'Se cambia la propiedad de texto al botón
                btnPrestarElementos.Image = Global.Appsena.My.Resources.Resources.icons8_storage_box_64 'Se cambia la imagen del botón
                btnPrestarElementos.Visible = True
                cmbTipoPrestamo.Select()
                btnEntregar.Visible = False
                btnEnviarAMora.Visible = False
                btnDuplicarPrestamo.Visible = False
                If btnEntregar.Text = "Cancelar" Then
                    btnEntregar.Text = "Entregar todo"
                    btnEntregarTodo.Visible = False
                End If
                txtElemento.Focus()
                ActualizarDGV()

            Else
                TimerFechaLimite.Stop()
                'Si estamos el el tab de historial
                btnEntregar.Visible = False
                btnEntregarTodo.Visible = False
                btnPrestarElementos.Visible = False
                btnEnviarAMora.Visible = False
                btnEnviarCorreo.Visible = False
                btnDuplicarPrestamo.Visible = False
                If dgvHistorial.Rows.Count > 0 Then
                    DetallePrestamo = TraerDetallePrestamo(dgvHistorial.Rows(0).Cells(0).Value, 3)
                    ActualizarEPrestados()
                End If
                If btnEntregar.Text = "Cancelar" Then
                    btnEntregar.Text = "Entregar todo"
                    btnEntregarTodo.Visible = False
                End If
            End If
        End If
    End Sub

    'Cargar los tipo de prestamo en un combo box 
    Private Sub cmbTipoPrestamo_GotFocus(sender As Object, e As EventArgs) Handles cmbTipoPrestamo.GotFocus
        'CARGAR LOS TIPOS DE PRESTAMOS EN UN COMBOBOX
        'La funcion retorna un dataset que la variable datos recibe
        Datos = CargarDatos("sp_tbltipoprestamo_select")


        cmbTipoPrestamo.DataSource = Datos.tables("datos") 'Se intancia el datasource del combobox con la tabla que trae el dataset
        cmbTipoPrestamo.ValueMember = "codigo" 'Iguala el valuemember del combo box con la columna codigo de la tabla datos
        cmbTipoPrestamo.DisplayMember = "nombre" 'Iguala el DisplayMember del combo box con la columna nombre de la tabla datos
        'cmbTipoPrestamo.SelectedValue = 4
    End Sub

    Private Sub dgvElementosPrestados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElementosPrestados.CellContentClick
        If dgvElementosPrestados.Rows.Count > 0 Then

            Select Case e.ColumnIndex
                Case 7 'Eliminar registro
                    Dim Click = dgvElementosPrestados.CurrentRow.Index
                    FilaDispo = dgvElementosDispo.CurrentRow.Index
                    Dim DeleteRow As Integer

                    For i = 0 To dgvElementosDispo.Rows.Count - 1
                        'si el elemento a eliminar es igual al elemento seleccionado
                        If dgvElementosDispo.Rows(i).Cells(0).Value = dgvElementosPrestados.Rows(Click).Cells(0).Value And Swicht = 0 Then
                            DeleteRow = i 'Igualamos la variable DeleteRow para utilizarla como index en el eliminar
                            Swicht = 1
                        End If
                    Next
                    Select Case Swicht 'Procedimientos según el resultado de la busqueda en el For 
                        Case 0 'Cuando no tiene filas
                            'La suma va a ser igual a la cantidad del elemento a eliminar
                            Suma = dgvElementosPrestados.Rows(Click).Cells(2).Value
                            UpdateDispoElemento(dgvElementosPrestados.Rows(Click).Cells(0).Value, Suma) 'Se ejecuta la funcion

                            dgvElementosPrestados.Rows.RemoveAt(Click) 'Se elimina la fila

                        Case 1 'Cuando el dgv tiene filas
                            'se recorre el datagridview
                            Suma = dgvElementosDispo.Rows(DeleteRow).Cells(3).Value + dgvElementosPrestados.Rows(Click).Cells(2).Value 'Se suma la cantidad del elemento prestado con la disponibilidad del elemento
                            UpdateDispoElemento(dgvElementosPrestados.Rows(Click).Cells(0).Value, Suma) 'Se llevan las variables y se ejecut la funcion

                            dgvElementosPrestados.Rows.RemoveAt(Click) 'Se elimina la Fila
                            Swicht = 0
                    End Select
                    Suma = 0
                    Observaciones = ""
                    txtCantidad.Text = 1
                    txtElemento.Text = ""
                    txtElemento.Focus()
                    ActualizarDGV() 'Se actualiza el dgv de los elementos disponibles
            End Select
        End If
    End Sub

    Private Sub frmMovimientos_detalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ptbFotoCliente.Image = Nothing
        TimerMora.Stop() 'Se detiene el timer que avisa si el cliente está en mora
        If dgvElementosPrestados.RowCount > 0 Then
            If SwFrm <> 1 Then
                For i = 0 To dgvElementosPrestados.RowCount - 1
                    Datos = Select_1ParametroVarchar("sp_tblelemento_Disponible", dgvElementosPrestados.Rows(i).Cells(0).Value)
                    Suma = dgvElementosPrestados.Rows(i).Cells(2).Value + Datos.rows(0)(1)
                    UpdateDispoElemento(dgvElementosPrestados.Rows(i).Cells(0).Value, Suma)
                    Suma = 0
                Next
            End If
        End If
        'btnSeguro.Image = Appsena.My.Resources.Resources.icons8_warning_shield_641
        SWPrestamo = 0
    End Sub

    Private Sub cmbTipoPrestamo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTipoPrestamo.SelectionChangeCommitted
        'Si el cliente no es un aprendiz
        If Cliente(9) <> 1 Then
            Select Case cmbTipoPrestamo.SelectedValue
                Case 1 'Prestampo interno
                    cbxFechalimite.Checked = False 'Se desmarca la casilla de la fecha limite de entrega del elemento
                    SwSeguro = 0
                    cbxFechalimite.Enabled = True

                Case 2 'Prestamo Externo
                    cbxFechalimite.Checked = True 'Se marca la casilla de la fecha limite de entrega
                    cbxFechalimite.Enabled = False
                    SwSeguro = 1 'Se activa el suiche que muestra el boton para agregar un seguro a los elementos
                    btnEnviarCorreo.Visible = True 'Se habilita el boton para enviar el permiso de salida de los elementos
                    'btnSeguro.Visible = True

                Case 5 'Prestamo para proyectos
                    cbxFechalimite.Checked = True 'Se marca la casilla de la fecha limite de entrega
                    SwSeguro = 1 'Se activa el suiche que muestra el boton para agregar un seguro a los elementos
                    btnEnviarCorreo.Visible = True 'Se habilita el boton para enviar el permiso de salida de los elementos
                    'btnSeguro.Visible = True
                    cbxFechalimite.Enabled = False

            End Select
            txtElemento.Focus() 'Se lleva el foco al buscador de elementos
        Else
            Select Case cmbTipoPrestamo.SelectedValue
                Case 1 'Prestamo Interno
                    cbxFechalimite.Checked = False 'Se desmarca la casilla de la fecha limite de entrega del elemento
                    txtElemento.Focus()

                Case 2 'Prestamo Externo
                    MessageBox.Show("El aprendiz no puede hacer un prestamo externo." & vbNewLine & "Debe solicitar a un superior que realice el prestamo externo", "Prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnEnviarCorreo.Visible = False
                Case 5 'Prestamo para proyectos
                    MessageBox.Show("Los aprendices no pueden realizar prestamos para proyectos", "Prestamo de elementos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnEnviarCorreo.Visible = False
            End Select
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub btnAlertaMora_MouseHover(sender As Object, e As EventArgs) Handles btnAlertaMora.MouseHover
        TimerMora.Stop()
        btnAlertaMora.Visible = True
    End Sub

    Private Sub btnAlertaMora_MouseLeave(sender As Object, e As EventArgs) Handles btnAlertaMora.MouseLeave
        TimerMora.Start()

    End Sub

    'Editar la cantidad del elemento prestado
    Private Sub dgvElementosPrestados_CellEndEdit(sender As Object, e As EventArgs) Handles dgvElementosPrestados.CellEndEdit
        Dim fila As Integer = dgvElementosPrestados.CurrentRow.Index
        Dim columna As Integer = dgvElementosPrestados.CurrentCell.ColumnIndex
        Select Case columna
            'Cuando se edita la columna de cantidad
            Case 2
                'Se establece un valor por defecto cuando el usuario no lo define
                If dgvElementosPrestados.Rows(fila).Cells(2).Value.ToString = "" Or dgvElementosPrestados.Rows(fila).Cells(2).Value.ToString = "0" Then
                    dgvElementosPrestados.Rows(fila).Cells(2).Value = 1
                End If
                'Se consulta el elemento que se va a editar
                Datos = SelectElemento(dgvElementosPrestados.Rows(fila).Cells(0).Value, 0)
                tabla = New DataTable
                tabla = Datos.tables("datos")
                'Segun la cantidad de prestamo se realiza un proceso
                Select Case dgvElementosPrestados.Rows(fila).Cells(2).Value
                    'Si la cantidad a prestar es mayor a la cantidad que habia antes de cambiar la cantidad
                    Case > CantEPres
                        'Se descuenta la cantidad que prestó incialmente a la nueva cantidad
                        Resta = dgvElementosPrestados.Rows(fila).Cells(2).Value - CantEPres
                        'Si la cantidad a prestar es menor o igual a la cantidad disponible se presta el elemento
                        If Resta <= tabla.Rows(0)(2) Then
                            UpdateDispoElemento(dgvElementosPrestados.Rows(fila).Cells(0).Value, (tabla.Rows(0)(2) - Resta))
                            txtElemento.Text = ""
                        Else
                            'Cuando la cantidad a prestar es mayor a la disponible
                            MessageBox.Show("La cantidad a prestar es superior a la cantidad disponible del elemento," & vbNewLine & "por lo tanto no se puede prestar", "Error al prestar elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            dgvElementosPrestados.Rows(fila).Cells(2).Value = CantEPres 'en la celda de cantidad se establece nuevamente la cantidad inicial de prestamo
                            txtElemento.Text = dgvElementosPrestados.Rows(fila).Cells(0).Value 'Slleva al txt del elemento el codigo para saber que cantidad tengo dispo
                        End If
                        'Si la cantidad a prestar es menor a la cantidad que habia antes de cambiar la cantidad
                    Case < CantEPres
                        'Se valida si la cantidad nueva es menor a la cantidad de observaciones
                        Select Case Cont
                            Case > dgvElementosPrestados.Rows(fila).Cells(2).Value
                                MessageBox.Show("La cantidad de observaciones es superior a la cantidad a prestar." & "Por favor cambie las observaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                dgvElementosPrestados.CurrentCell = dgvElementosPrestados.Rows(fila).Cells(3) 'Se da el foco en la columna de observaciones
                                dgvElementosPrestados.BeginEdit(True) 'Se habilita la edicion de la misma
                                Return
                        End Select
                        'Se descuenta la cantidad que presto a la nueva cantidad
                        Resta = CantEPres - dgvElementosPrestados.Rows(fila).Cells(2).Value
                        'Se valida que la cantidad nueva a prestar sea menor o igual a la cantidad disponible del elemento
                        If Resta <= tabla.Rows(0)(2) Then
                            'Se actualiza la disponibilidad del elemento
                            UpdateDispoElemento(dgvElementosPrestados.Rows(fila).Cells(0).Value, (tabla.Rows(0)(2) + Resta))
                            txtElemento.Text = ""
                        Else
                            If tabla.Rows(0)(2) = 0 Then
                                UpdateDispoElemento(dgvElementosPrestados.Rows(fila).Cells(0).Value, (tabla.Rows(0)(2) + Resta))
                                txtElemento.Text = ""
                            Else
                                If CantEPres > tabla.Rows(0)(2) Then
                                    UpdateDispoElemento(dgvElementosPrestados.Rows(fila).Cells(0).Value, (tabla.Rows(0)(2) + Resta))
                                    txtElemento.Text = ""
                                Else
                                    'Cuando la cantidad a prestar es mayor a la disponible
                                    MessageBox.Show("La cantidad a prestar es superior a la cantidad disponible del elemento," & vbNewLine & "por lo tanto no se puede prestar", "Error al prestar elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    dgvElementosPrestados.Rows(fila).Cells(2).Value = CantEPres 'en la celda de cantidad se establece nuevamente la cantidad inicial de prestamo
                                    txtElemento.Text = dgvElementosPrestados.Rows(fila).Cells(0).Value 'Slleva al txt del elemento el codigo para saber que cantidad tengo dispo
                                End If

                            End If

                        End If

                    Case = CantEPres 'Si la cantidad a prestar es igual a la anterior y es inferior a las observaciones
                        Select Case Cont
                            Case > dgvElementosPrestados.Rows(fila).Cells(2).Value
                                MessageBox.Show("La cantidad de observaciones es superior a la cantidad a prestar." & "Por favor cambie las observaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                dgvElementosPrestados.CurrentCell = dgvElementosPrestados.Rows(fila).Cells(3) 'Se da el foco en la columna de observaciones
                                dgvElementosPrestados.BeginEdit(True) 'Se habilita la edicion de la misma
                                Return
                        End Select
                End Select
                ActualizarDGV()
                Resta = 0
                'Editar la columna de observaciones
            Case 3
                If dgvElementosPrestados.Rows(fila).Cells(3).Value <> "" Then
                    Dim Str As String = dgvElementosPrestados.Rows(fila).Cells(3).Value
                    Dim strarr() As String
                    Cont = 0
                    strarr = Str.Split(",")
                    For Each s As String In strarr
                        Cont = Cont + 1
                    Next
                    If dgvElementosPrestados.Rows(fila).Cells(2).Value > 1 Then
                        If Cont > dgvElementosPrestados.Rows(fila).Cells(2).Value Then
                            MessageBox.Show("La cantidad de observaciones es mayor a la cantidad prestada del elemento." & vbNewLine & "Si desea hacer varias observaciones a un solo elemento, debe separar las observaciones con un guión. ( - ) " & vbNewLine & "Si desea hacer observaciones para cada elemento, debe separar con una coma. ( , )", "Error en las observaciones del elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
        End Select
    End Sub


    Private Sub dgvElementosPrestados_CellBeginEdit(sender As Object, e As EventArgs) Handles dgvElementosPrestados.CellBeginEdit
        Dim fila As Integer = dgvElementosPrestados.CurrentRow.Index
        Dim columna As Integer = dgvElementosPrestados.CurrentCell.ColumnIndex
        Select Case columna
            Case 2
                CantEPres = dgvElementosPrestados.Rows(fila).Cells(2).Value
        End Select
    End Sub

    'Evento keypress que valida que solo se escriban numeros
    Private Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cellTextBox.KeyPress
        If FilaEPres = 1 Then
            SoloNumeros(e)
        End If
    End Sub

    'Validar que en la celda de cantidad solo se permitan numeros
    Private Sub dgvElementosPrestados_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvElementosPrestados.EditingControlShowing
        'Se crea una variable que controla el indice de la fila que se va a editar
        Dim col As Integer = dgvElementosPrestados.CurrentCell.ColumnIndex
        Select Case col
            Case 2
                FilaEPres = 1
            Case 3
                FilaEPres = 2
            Case Else
                FilaEPres = 0
        End Select

        ' Referenciamos el control DataGridViewTextBoxEditingControl actual.
        '
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)
    End Sub

    Private Sub dgvEPrestados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEPrestados.CellDoubleClick
        If dgvEPrestados.Rows.Count > 0 Then
            Dim Fila As Integer = dgvEPrestados.CurrentRow.Index
            If e.RowIndex = -1 Then
                Return
            Else
                If dgvEPrestados.Rows(Fila).Cells(3).Value > 1 Then
                    frmMovimientos_Detalle_EntregarUno.CargarFormulario(dgvEPrestados.Rows(Fila).Cells(0).Value, dgvEPrestados.Rows(Fila).Cells(1).Value, dgvEPrestados.Rows(Fila).Cells(4).Value, 2, lblDocidNom.Text, 2)
                End If
            End If
        End If
    End Sub

    'Al hacer doble click el elemento se presta
    Private Sub dgvElementosDispo_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElementosDispo.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        Else
            AggDatosValidado()
        End If
    End Sub

    Private Sub btnSeguro_MouseHover(sender As Object, e As EventArgs)
        If SwSeguro = 1 Or SwSeguro = 0 Then
            'btnSeguro.Visible = True
            TimerSeguro.Stop()
        Else

            'ToolTip1.SetToolTip(btnSeguro, "Los elementos se encuentran asegurados. Click para ver más")
        End If

    End Sub

    Private Sub btnSeguro_MouseLeave(sender As Object, e As EventArgs)
        If SwSeguro = 1 Or SwSeguro = 0 Then
            TimerSeguro.Start()
        End If
    End Sub

    Private Sub dtpFechaLimitHora_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaLimitHora.KeyDown
        'Valida si la tecla presionada es la Tecla Enter
        Select Case e.KeyCode
            Case Keys.Enter
                AggDatos()
                ActualizarDGV()
        End Select
    End Sub

    Private Sub dgvElementosPrestados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvElementosPrestados.KeyDown
        Console.WriteLine(e)
        Console.WriteLine(sender)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgvEPrestados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEPrestados.CellClick
        If dgvHistorial.Rows.Count > 0 Then
            If e.RowIndex <> -1 Then
                If dgvEPrestados.Rows(e.RowIndex).Cells(7).Value = "2" Then
                    If dgvEPrestados.Rows(e.RowIndex).Cells(3).Value = 1 Then
                        dgvEPrestados.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 84, 2)
                    End If
                End If
            End If
        End If
    End Sub
End Class