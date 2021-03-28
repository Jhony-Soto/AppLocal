Imports System.ComponentModel

Public Class frm_progresbar
    Dim fila, arreglo, coddocumento, marcas, filas, array As Object
    Dim fecha_Actual As DateTime = DateTime.Today
    Public clientes As Boolean

    Private Sub frm_progresbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If clientes = True Then
            Background_subir.RunWorkerAsync()
        Else
            Background_elementos.RunWorkerAsync()
        End If

    End Sub

    Private Sub Background_elementos_DoWork(sender As Object, e As DoWorkEventArgs) Handles Background_elementos.DoWork
        frmDashBoard.timer_validar_reserva.Stop() 'Detenemos este timer para que no arroge error de conexion 
        frmDashBoard.Timer1.Stop()
        frmDashBoard.Timer_conexion_internet.Stop()

        If dgimportar.Columns.Count = 14 Then
            'Obtenemos en numero de registros que tiene el data grid donde se subio la informacion
            filas = dgimportar.Rows.Count

            ''Validamos que si halla informacion
            If filas <> 0 Then
                ReDim arreglo(15)

                'Recorremos el dgimportar para validar la infdormacion y guardarla
                For i = 0 To filas - 1

                    'CODIGO
                    If dgimportar.Rows(i).Cells(0).Value Is DBNull.Value Then
                        arreglo(0) = DBNull.Value
                    Else
                        arreglo(0) = dgimportar.Rows(i).Cells(0).Value
                    End If


                    'Centro
                    datos = CargarDatos("sp_tbl_centroActual_select")
                    tabla = New DataTable
                    tabla = datos.tables("datos")
                    arreglo(1) = tabla(0)(0)

                    'Placa
                    If dgimportar.Rows(i).Cells(1).Value Is DBNull.Value Then
                        arreglo(2) = DBNull.Value
                    Else
                        arreglo(2) = dgimportar.Rows(i).Cells(1).Value
                    End If

                    'Serial
                    If dgimportar.Rows(i).Cells(2).Value Is DBNull.Value Then
                        arreglo(3) = DBNull.Value
                    Else
                        arreglo(3) = dgimportar.Rows(i).Cells(2).Value
                    End If

                    'Nombre
                    If dgimportar.Rows(i).Cells(3).Value Is DBNull.Value Then
                        arreglo(4) = DBNull.Value
                    Else
                        arreglo(4) = dgimportar.Rows(i).Cells(3).Value
                    End If

                    'Marca
                    If dgimportar.Rows(i).Cells(4).Value Is DBNull.Value Then
                        dgimportar.Rows(i).Cells(4).Value = "N/A"
                    End If

                    'Modelo
                    If dgimportar.Rows(i).Cells(5).Value Is DBNull.Value Then
                        dgimportar.Rows(i).Cells(5).Value = "N/A"
                    End If

                    Try
                        datos = Select_1ParametroInt("sp_tbl_marca_nombre", dgimportar.Rows(i).Cells(4).Value)
                        tabla = New DataTable
                        tabla = datos.tables("datos")
                    Catch ex As Exception
                        Return
                    End Try


                    If tabla.Rows.Count > 0 Then
                        marcas = tabla(0)(0)
                        'Si el modelo de la marca existe en la BD
                        datos = modelo_selectFK(marcas, "sp_tbl_modelo_selectFK")
                        tabla = New DataTable
                        tabla = datos.tables("datos")

                        If tabla.Rows.Count > 0 Then
                            arreglo(5) = tabla(0)(0)
                        Else
                            'si no existe el modelo lo creamos
                            Array = {dgimportar.Rows(i).Cells(5).Value, marcas}
                            insert_tbl_modelo(Array, "sp_tbl_modelo_insert")

                            datos = modelo_selectFK(marcas, "sp_tbl_modelo_selectFK")
                            tabla = New DataTable
                            tabla = datos.tables("datos")
                            arreglo(5) = tabla(0)(0)
                        End If
                    Else
                        'Si la marca no existe la creamos 
                        insert_tbl_marca(dgimportar.Rows(i).Cells(4).Value, "sp_tbl_marca_insert")

                        Try
                            datos = Select_1ParametroInt("sp_tbl_marca_nombre", dgimportar.Rows(i).Cells(4).Value)
                            tabla = New DataTable
                            tabla = datos.tables("datos")
                        Catch ex As Exception
                            Return
                        End Try


                        marcas = tabla(0)(0)

                        'Si el modelo de la marca existe en la BD
                        datos = modelo_selectFK(marcas, "sp_tbl_modelo_selectFK")
                        tabla = New DataTable
                        tabla = datos.tables("datos")
                        If tabla.Rows.Count > 0 Then
                            arreglo(5) = tabla(0)(0)
                        Else
                            'si no existe el modelo lo creamos
                            ReDim Array(1)
                            Array = {dgimportar.Rows(i).Cells(5).Value, marcas}
                            insert_tbl_modelo(Array, "sp_tbl_modelo_insert")

                            datos = modelo_selectFK(marcas, "sp_tbl_modelo_selectFK")
                            tabla = New DataTable
                            tabla = datos.tables("datos")
                            arreglo(5) = tabla(0)(0)
                        End If
                    End If

                    'Tipo de elemento
                    datos = Select_1ParametroInt("sp_tbl_tipo_elemento_nombre", dgimportar.Rows(i).Cells(6).Value)
                    tabla = New DataTable
                    tabla = datos.tables("datos")
                    If tabla.Rows.Count > 0 Then
                        arreglo(6) = tabla(0)(0)
                    Else
                        arreglo(6) = DBNull.Value
                    End If

                    'Categoria
                    datos = Select_1ParametroInt("sp_tbl_categoria_variable", dgimportar.Rows(i).Cells(7).Value)
                    tabla = New DataTable
                    tabla = datos.tables("datos")
                    If tabla.Rows.Count > 0 Then
                        arreglo(7) = tabla(0)(0)
                    Else
                        arreglo(7) = DBNull.Value
                    End If


                    'Ubicacion
                    If dgimportar.Rows(i).Cells(8).Value Is DBNull.Value Then
                        arreglo(8) = DBNull.Value
                    Else
                        arreglo(8) = dgimportar.Rows(i).Cells(8).Value
                    End If


                    'Foto
                    arreglo(9) = DBNull.Value


                    'Observaciones
                    If dgimportar.Rows(i).Cells(9).Value Is DBNull.Value Then
                        arreglo(10) = DBNull.Value
                    Else
                        arreglo(10) = dgimportar.Rows(i).Cells(9).Value
                    End If

                    'Fecha de adquisicion
                    If dgimportar.Rows(i).Cells(10).Value Is DBNull.Value Then
                        arreglo(11) = DBNull.Value
                    Else

                        arreglo(11) = dgimportar.Rows(i).Cells(10).Value
                    End If


                    'Valor
                    If dgimportar.Rows(i).Cells(11).Value Is DBNull.Value Then
                        arreglo(12) = DBNull.Value
                    Else
                        arreglo(12) = dgimportar.Rows(i).Cells(11).Value
                    End If

                    'Estado
                    arreglo(13) = "1"

                    'Cantidad
                    If dgimportar.Rows(i).Cells(12).Value Is DBNull.Value Then
                        arreglo(14) = DBNull.Value
                    Else
                        arreglo(14) = dgimportar.Rows(i).Cells(12).Value
                    End If

                    'Disponibles
                    If dgimportar.Rows(i).Cells(13).Value Is DBNull.Value Then
                        arreglo(15) = DBNull.Value
                    Else
                        'validamos  que disponible no sea mayor a cantidad
                        If dgimportar.Rows(i).Cells(12).Value IsNot DBNull.Value And dgimportar.Rows(i).Cells(13).Value IsNot DBNull.Value Then
                            If dgimportar.Rows(i).Cells(13).Value > dgimportar.Rows(i).Cells(12).Value Then
                                arreglo(15) = dgimportar.Rows(i).Cells(12).Value
                            Else
                                arreglo(15) = dgimportar.Rows(i).Cells(13).Value
                            End If
                        End If

                    End If

                    'validamos  que disponible no sea mayor a cantidad
                    If dgimportar.Rows(i).Cells(12).Value IsNot DBNull.Value And dgimportar.Rows(i).Cells(13).Value IsNot DBNull.Value Then

                    End If

                    datos = insert_update_elemento(arreglo, "sp_tbl_elemento_insert")
                Next


                'Validacion de respuesta de la funcion
                If datos = 0 Then
                    MsgBox("Se guardo correctamente el elemento", vbInformation)

                    'Actualizamos la tabla 
                    With frm_elementos
                        .Reload(.anterior, .siguiente)
                    End With

                Else
                    With frm_elementos
                        .Reload(.anterior, .siguiente)
                    End With

                End If
            Else
                'Si no hay registros ,le informamos al usuario
                MsgBox("El archivo no tiene informacion ,por favor verifique de nuevo.", vbCritical)

            End If

        Else
            MsgBox("El archivo que está intentando subir no contiene información correspondiente a elementos." & vbLf & " Por favor descargue la plantilla y llene la información como corresponde.", vbCritical)
        End If


    End Sub

    Private Sub Background_subir_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Background_subir.DoWork
        frmDashBoard.timer_validar_reserva.Stop() 'Detenemos este timer para que no arroge error de conexion 
        frmDashBoard.Timer1.Stop()
        frmDashBoard.Timer_conexion_internet.Stop()

        If dgimportar.Columns.Count = 8 Then


            Dim filas_datagrid = dgimportar.Rows.Count 'guardamos en esta variable en numero de registros que teien el archivo importado


            If filas_datagrid > 1 Then
                For j = 0 To filas_datagrid - 1
                    'Validamos que la ficha y el programa exista en la base de datos
                    Try
                        datos = buscar_ficha(dgimportar.Rows(j).Cells(5).Value, "sp_tbl_ficha_select")
                        fila = datos.tables("datos").rows.count
                    Catch ex As Exception
                        Return
                    End Try



                    'si no hay un existe la ficha , entonces creamos el registro de ella
                    If fila = 0 Then

                        arreglo = {dgimportar.Rows(j).Cells(5).Value, dgimportar.Rows(j).Cells(6).Value, DBNull.Value}
                        insert_update_tbl_ficha(arreglo, "sp_tbl_ficha_insert", "creo una ficha que no existia")

                        'validamos que tipo de documento tiene
                        If dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "CC" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "cc" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "Cc" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "cC" Then
                            coddocumento = 1
                        Else
                            If dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "TI" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "ti" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "Ti" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "tI" Then
                                coddocumento = 3
                            Else
                                If dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "CE" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "ce" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "Ce" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "cE" Then
                                    coddocumento = 2
                                Else
                                    coddocumento = DBNull.Value
                                End If
                            End If
                        End If

                        'Insertamos los datos 
                        arreglo = {dgimportar.Rows(j).Cells(0).Value, dgimportar.Rows(j).Cells(1).Value, dgimportar.Rows(j).Cells(2).Value, dgimportar.Rows(j).Cells(5).Value,
                                dgimportar.Rows(j).Cells(4).Value, dgimportar.Rows(j).Cells(3).Value, fecha_Actual, "1", DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, "0", coddocumento, "1"}
                        datos = Insert_Update_tbl_cliente(arreglo, "sp_tbl_cliente_insert")

                        If datos = 1 Then
                            'recargamos el formulario de clientes para mostrar los cambios
                            With frm_clientes
                                .Reload(.anterior, .siguiente)
                            End With
                        End If

                        ReDim arreglo(0)
                    Else

                        'validamos que tipo de documento tiene
                        If dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "CC" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "cc" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "Cc" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "cC" Then
                            coddocumento = 1
                        Else
                            If dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "TI" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "ti" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "Ti" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "tI" Then
                                coddocumento = 3
                            Else
                                If dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "CE" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "ce" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "Ce" Or dgimportar.Rows(j).Cells(7).Value.ToString.Trim = "cE" Then
                                    coddocumento = 2
                                Else

                                    coddocumento = DBNull.Value
                                End If
                            End If
                        End If
                    End If 'segundo if 

                    'Insertamos los datos
                    arreglo = {dgimportar.Rows(j).Cells(0).Value, dgimportar.Rows(j).Cells(1).Value, dgimportar.Rows(j).Cells(2).Value, dgimportar.Rows(j).Cells(5).Value,
                            dgimportar.Rows(j).Cells(4).Value, dgimportar.Rows(j).Cells(3).Value, fecha_Actual, "1", DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, "0", coddocumento, "1"}
                    datos = Insert_Update_tbl_cliente(arreglo, "sp_tbl_cliente_insert")

                    If datos = 1 Then
                        'recargamos el formulario de clientes para mostrar los cambios
                        With frm_clientes
                            .Reload(.anterior, .siguiente)
                        End With
                    End If

                    ReDim arreglo(0)

                Next

            Else
                MsgBox("El achivo que intenta importar no tiene los suficientes registros", vbCritical)
            End If
        Else
            MsgBox("El archivo que está intentando subir no contiene información correspondiente a clientes." & vbLf & " Por favor descargue la plantilla y llene la información como corresponde.", vbCritical)

        End If
    End Sub

    Private Sub Background_subir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_subir.RunWorkerCompleted
        With frm_clientes
            .Reload(.anterior, .siguiente)
        End With

        dgimportar.DataSource = Nothing

        frmDashBoard.timer_validar_reserva.Start() 'Detenemos este timer para que no arroge error de conexion 
        frmDashBoard.Timer1.Start()
        frmDashBoard.Timer_conexion_internet.Start()
        Me.Close()

    End Sub

    Private Sub Background_elementos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_elementos.RunWorkerCompleted
        With frm_elementos
            .Reload(.anterior, .siguiente)
        End With

        frmDashBoard.timer_validar_reserva.Start() 'Detenemos este timer para que no arroge error de conexion 
        frmDashBoard.Timer1.Start()
        frmDashBoard.Timer_conexion_internet.Start()
        dgimportar.DataSource = Nothing

        Me.Close()
    End Sub
End Class