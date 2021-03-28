Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frm_sincronizacion

    Dim arreglo(,) As Object

    'Atributos que nesecitamos para crear la pagimnacion del datagrid
    Dim total_datos As Integer = 0 'guardamos el total de los registros
    Dim pagina As Integer = 1  'Guardaremos la pagina en la cual estamos
    Dim maximo_paginas As Integer = 0 'Guardaremos el nmumero de paginas que se generan 
    Dim numero_registros As Integer = 100 'el numero de regsitros que mostraremos por cada pagina
    Public anterior As Integer = 0
    Public siguiente As Integer = numero_registros

    '******** CON ESTE METODO CONSULTAMOS EL CENTRO DONDE SE ESTA EJECUTANDO LA APLICACION************
    Function CentroActual()
        datos = CargarDatos("sp_tbl_centroActual_select")
        tabla = New DataTable
        tabla = datos.tables("datos")

        CodCentroActual = tabla(0)(0)

        'Guardamos el centro actual en  MYSQL
        Try
            conexionMS.Open() 'abrimos laconexion de mysql
            comandoMS = New MySqlCommand("INSERT INTO tbl_centro VALUES('" & tabla(0)(0) & "','" & tabla(0)(1) & "')", conexionMS)
            comandoMS.CommandType = CommandType.Text
            comandoMS.ExecuteNonQuery()
            conexionMS.Close()

        Catch ex As MySqlException
            conexionMS.Close()
            Exit Try
        End Try

    End Function
    '*************************************************************


    Private Sub frm_sincronizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDashBoard.timer_validar_reserva.Stop() 'Detenemos este timer para que no arroge error de conexion 


        CentroActual() 'Metodo para obtener y guardar el centroa actual

        BackgroundWorker.RunWorkerAsync() 'Inicializa el trabajo en segundo plano
    End Sub

    '********* CON ESTE METODO VALIDAMOS QUE TODOS LOS REGISTROS ESTEN SINCRONIZADOS*****
    Public Function validacion_de_sincronizacion()

        datos = Registros_sin_sincronizar("select * from tbl_cliente where sincronizacion='0' and codficha='1'")
        If datos.rows.count > 0 Then
            frmDashBoard.btnSincronizar.BorderColor = Color.Red
            frmDashBoard.btnSincronizar.BorderSize = 2

        Else
            datos = Registros_sin_sincronizar("select * from tbl_ficha where sincronizado='0' and estado='1'")
            If datos.rows.count > 0 Then
                frmDashBoard.btnSincronizar.BorderColor = Color.Red
                frmDashBoard.btnSincronizar.BorderSize = 2
            Else
                datos = Registros_sin_sincronizar("select * from tbl_mora where sincronizado='0' and cod_estado='1'")
                If datos.rows.count > 0 Then
                    frmDashBoard.btnSincronizar.BorderColor = Color.Red
                    frmDashBoard.btnSincronizar.BorderSize = 2

                Else
                    frmDashBoard.btnSincronizar.BorderColor = Color.Transparent
                    frmDashBoard.btnSincronizar.BorderSize = 0
                End If
            End If

        End If
    End Function
    '*********************************************************************


    '**************** METODO PARA CONSULTAR SI HAY REGISTROS SIN SINCRONIZAR AUN*********
    Function Registros_sin_sincronizar(sql)
        Try
            conexionSQL.Close()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.Text

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            tabla = New DataTable
            tabla = dataset.Tables("datos")

            Return tabla
            conexionSQL.Close()
        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.Message)
        End Try
    End Function
    '********************************************************************************



    '********** METODO QUE SE EJECUTA Y TRABAJA EN SEGUNDO PLANO ****************
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        'Validamos que si halla conexion a internet

        frmDashBoard.btnSincronizar.BaseColor = Color.FromArgb(26, 92, 81)

        fichas() 'Sincroniza las fichas

        clientes() 'Sincroniza los aprendice

        Mora() 'Sincroniza las moras

        limpiar_clientes() 'Coneste mentodo se elimina los aprendizes que fueron eliminados de mysql en otras sedes

    End Sub
    '*************************************************************************

    '********** METODO EN EL CUAL ELIMINAMOS DE SQL LOS REGISTROS QUE FUERON BORRADOS EN MYSQL **********
    Private Sub limpiar_clientes()
        Try

            conexionSQL.Open()
            comandos = New SqlCommand("select * from tbl_cliente where tipo_cliente='1'  and estado='1' and sincronizacion='1'", conexionSQL)
            comandos.CommandType = CommandType.Text

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            tabla = New DataTable
            tabla = dataset.Tables("datos")
            conexionSQL.Close()

            If tabla.Rows.Count > 0 Then
                For i = 0 To tabla.Rows.Count - 1
                    'Consultamos si el registro de SQL existe en MYSQL 

                    conexionMS.Open()
                    comandoMS = New MySqlCommand("SELECT * FROM `tbl_clientes` where documento='" & tabla(i)(0) & "'", conexionMS)
                    comandoMS.CommandType = CommandType.Text

                    LectorMS = comandoMS.ExecuteReader
                    If Not LectorMS.HasRows Then
                        'si no existe el registro en MYSQL se elimina de SQL
                        Try
                            conexionSQL.Open()
                            comandos = New SqlCommand("delete from tbl_cliente where documento='" & tabla(i)(0) & "'", conexionSQL)
                            comandos.CommandType = CommandType.Text

                            comandos.ExecuteNonQuery()
                            conexionSQL.Close()
                        Catch ex As SqlException
                            conexionSQL.Close()
                            MsgBox(ex.Message)
                        End Try
                    End If

                    conexionMS.Close()

                Next
            End If

            conexionSQL.Close()

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    '*******************************************************************************************



    '********* METODO QUE SE EJECUTA AL TERMINAR DEL TRABAJO EN SEGUNDO PLANO *****************
    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        lbl_termino.Visible = True
        lbl_sinconizado.Visible = False

        pnl_ok.Visible = True
        pnl_progres.Visible = False

        frmDashBoard.pnlMenu.Enabled = True

        validacion_de_sincronizacion()
        frmDashBoard.pnlMenu.Enabled = True
        frmDashBoard.timer_validar_reserva.Start()
    End Sub
    '***********************************************************

    '***************************** SINCRONIZACION DE MORAS *********************
    Function Mora()

        Guardar_mora_MYSQL() 'Metodo para guardar las moras activas en MYSQL

        Mora_saldadas() 'Se eliminan las moras saldadas de MYSQL

    End Function
    '************************************************************************************

    ''************* ESTE METODO GUARDAR LAS MORAS ACTIVAS DE SQL SERVER EN MYSQL************
    Function Guardar_mora_MYSQL()
        'Cargamos las moras activas
        datos = CargarDatos("sp_tbl_mora_select")
        tabla = New DataTable
        tabla = datos.tables("datos")

        ReDim arreglo(tabla.Rows.Count - 1, 4)

        For i = 0 To tabla.Rows.Count - 1
            arreglo(i, 0) = tabla(i)(0)
            arreglo(i, 1) = tabla(i)(1)
            arreglo(i, 2) = tabla(i)(3)
            arreglo(i, 3) = Format(tabla(i)(5), "yyyy/MM/dd")
            arreglo(i, 4) = tabla(i)(7)
        Next

        If tabla.Rows.Count > 0 Then

            For i = 0 To tabla.Rows.Count - 1
                'Guardarmos el registro en la base de datos de MYSQl
                Try
                    conexionMS.Open() 'abrimos laconexion de mysql
                    comandoMS = New MySqlCommand("INSERT into tbl_mora VALUES('" & arreglo(i, 0) & "',
                                                                              '" & arreglo(i, 1) & "',
                                                                              '" & arreglo(i, 2) & "',
                                                                              '" & arreglo(i, 3) & "',
                                                                              '" & arreglo(i, 4) & "',
                                                                              '" & CodCentroActual & "')", conexionMS)
                    comandoMS.CommandType = CommandType.Text
                    comandoMS.ExecuteNonQuery()
                    conexionMS.Close() 'cerramos conexion mysql

                    Cambio_sincronizado_mora_SQL(arreglo(i, 0)) 'Cambia el estado de sincronizado de sql

                    Guardar_mora_elemento_MYSQL(arreglo(i, 0)) 'Insertamos los elementos en mora del cliente

                    Eliminar_elementos_entregados(arreglo(i, 0)) 'Eliminamos los elementos entregados de MYSQL

                Catch ex As MySqlException
                    conexionMS.Close() 'cerramos conexion mysql

                    Cambio_sincronizado_mora_SQL(arreglo(i, 0)) 'Cambia el estado de sincronizado de sql

                    Guardar_mora_elemento_MYSQL(arreglo(i, 0)) 'Insertamos los elementos en mora del cliente

                    Eliminar_elementos_entregados(arreglo(i, 0)) 'Eliminamos los elementos entregados de MYSQL

                    Exit Try
                End Try

            Next

        End If




    End Function
    '****************************


    '******** METODO PARA CAMBIAR EL ESTADO SINCRONIZADO DE LA MORA SQL*************
    Function Cambio_sincronizado_mora_SQL(mora)
        'Actualizamos el estado de sincronizacion de la MORA    
        Try
            conexionSQL.Open() 'conexion sql

            comandos = New SqlCommand("Update tbl_mora set sincronizado='1' where codigo_mora='" & mora & "'", conexionSQL)
            comandos.CommandType = CommandType.Text
            comandos.ExecuteNonQuery()

            conexionSQL.Close() 'conexion sql
        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.Message)
        End Try

    End Function
    '*************************************************************

    '*********** CON ESTE METODO ELIMINAMOS LA MORA DEL CLIENTE QUE YA A DEVUELTO TODO LO QUE DEBIA *********
    Function Mora_saldadas()

        datos = CargarDatos("sp_tbl_mora_saldados")
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla.Rows.Count > 0 Then
            For i = 0 To tabla.Rows.Count - 1

                Try
                    conexionMS.Open()
                    comandoMS = New MySqlCommand("delete from tbl_mora_elemento where cod_mora='" & tabla(i)(0) & "'", conexionMS)
                    comandoMS.CommandType = CommandType.Text
                    comandoMS.ExecuteNonQuery()

                    conexionMS.Close()
                Catch ex As MySqlException
                    conexionMS.Close()
                    MsgBox(ex.Message)
                End Try


                Try
                    conexionMS.Open()
                    comandoMS = New MySqlCommand("DELETE FROM tbl_mora WHERE codigo_mora='" & tabla(i)(0) & "'", conexionMS)
                    comandoMS.CommandType = CommandType.Text
                    comandoMS.ExecuteNonQuery()
                    conexionMS.Close()
                Catch ex As MySqlException
                    conexionMS.Close()
                    MsgBox(ex.Message)
                    Exit Try
                End Try
            Next
        End If
    End Function
    '*******************************************************


    '******************** METODO PARA GUARDAR LOS ELEMENTOS EN MORA DE UN CLIENTE EN MYSQL **************
    Function Guardar_mora_elemento_MYSQL(cod_mora)
        ''Consultamos los elementos en mora del cliente y los guardamos en mysql
        datos = tbl_mora_elemento(cod_mora, "sp_tbl_mora_elemento")
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla.Rows.Count > 0 Then
            For j = 0 To tabla.Rows.Count - 1

                Try
                    conexionMS.Open()
                    comandoMS = New MySqlCommand("INSERT into tbl_mora_elemento values ('" & tabla(j)(9) & "',
                                                                            '" & tabla(j)(0) & "',
                                                                            '" & tabla(j)(1) & "',
                                                                            '" & tabla(j)(2) & "',
                                                                            '" & tabla(j)(3) & "',
                                                                            '" & Format(tabla(j)(5).date, "yyyy/MM/dd") & "',
                                                                            '" & tabla(j)(4) & "')", conexionMS)
                    comandoMS.CommandType = CommandType.Text
                    comandoMS.ExecuteNonQuery()
                    conexionMS.Close()
                Catch ex As MySqlException
                    conexionMS.Close()
                    Exit Try
                End Try
            Next
        End If
        '*******************************************
    End Function
    '****************************************************************************************


    '*************** METODO PARA ELIMINAR LOS ELEMENTOS ENTREGADOS POR EL CLIENTE DE MYSQL**********
    Function Eliminar_elementos_entregados(codmora)
        'Consultamos los elementos saldados del cliente
        datos = tbl_mora_elemento(codmora, "sp_tbl_mora_elemento_entregados")
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla.Rows.Count > 0 Then
            For i = 0 To tabla.Rows.Count - 1
                Try
                    conexionMS.Open()
                    comandoMS = New MySqlCommand("delete from tbl_mora_elemento where consecutivo='" & tabla(i)(10) & "'", conexionMS)
                    comandoMS.CommandType = CommandType.Text
                    comandoMS.ExecuteNonQuery()

                    conexionMS.Close()
                Catch ex As MySqlException
                    conexionMS.Close()
                    MsgBox(ex.Message)
                End Try
            Next
        End If

    End Function
    '*********************************************************************************************




    '******* CAMBIO DE ESTADO EN LA SINCRONIZACION  DE LAS FICHAS SQL SERVER **********
    Function cambio_estado_ficha_SQL(CODIGO)
        'Actualizamos el estado de sincronizacion de la ficha
        Try
            conexionSQL.Open() 'conexion sql

            comandos = New SqlCommand("Update tbl_ficha set sincronizado='1' where codigo='" & CODIGO & "'", conexionSQL)
            comandos.CommandType = CommandType.Text
            comandos.ExecuteNonQuery()

            conexionSQL.Close() 'conexion sql
        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.Message)
        End Try
    End Function
    '************************************************************************************

    '************ METODO PARA GUARDAR EN SQL SERVER LAS FICHAS SINCRONIZADAS DESDE OTROS CENTROS DE FORMACION  ***********************
    Function Consultar_fichas_de_MYSQL()
        Try
            conexionMS.Open()

            comandoMS = New MySqlCommand("SELECT * FROM tbl_ficha ", conexionMS)
            comandoMS.CommandType = CommandType.Text

            AdaptadorMS = New MySqlDataAdapter
            AdaptadorMS.SelectCommand = comandoMS
            AdaptadorMS.SelectCommand.Connection = conexionMS

            dataset = New DataSet
            AdaptadorMS.Fill(dataset, "datos")

            conexionMS.Close()

            tabla = New DataTable
            tabla = dataset.Tables("datos")



            'Guardamos las fichas en sql server
            For i = 0 To tabla.Rows.Count - 1
                Try
                    conexionSQL.Open()
                    comandos = New SqlCommand("INSERT INTO tbl_ficha VALUES ('" & tabla(i)(0) & "','" & tabla(i)(1) & "','1','" & tabla(i)(2) & "','1')", conexionSQL)
                    comandos.CommandType = CommandType.Text
                    comandos.ExecuteNonQuery()

                    conexionSQL.Close()
                Catch ex As SqlException
                    conexionSQL.Close()
                    Exit Try
                End Try
            Next

        Catch ex As MySqlException
            conexionMS.Close()
            MsgBox(ex.Message)
        End Try
    End Function

    '***************************************************************************************************************

    '*******************  SINCRONIZAMOS LA TABLA FICHAS ***********************************************************************
    Function fichas()
        '***************FICHAS ACTIVAS*********************
        datos = Select_1ParametroInt("sp_tbl_ficha_select", "") 'Obtenemos todas las fichas activas en  SQL SERVER
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla.Rows.Count > 0 Then
            'recorremos los registros con un para  determinar cuales tiene el estado 0 en sincronizacion

            For i = 0 To tabla.Rows.Count - 1
                If tabla(i)(3) = 0 Then

                    'Guardarmos el registro en la base de datos de MYSQl
                    Try
                        conexionMS.Open() 'abrimos laconexion de mysql

                        comandoMS = New MySqlCommand("INSERT INTO tbl_ficha VALUES ('" & tabla(i)(0) & "','" & tabla(i)(1) & "','" & tabla(i)(2) & "')", conexionMS)
                        comandoMS.CommandType = CommandType.Text
                        comandoMS.ExecuteNonQuery()

                        conexionMS.Close() 'cerramos conexion mysql

                        'Con esta funcion cambiamos el estado de sincronizado en la tabla ficha de SQL SERVER
                        cambio_estado_ficha_SQL(tabla(i)(0))

                    Catch ex As MySqlException
                        conexionMS.Close() 'cerramos conexion mysql

                        'Con esta funcion cambiamos el estado de sincronizado en la tabla ficha de SQL SERVER
                        cambio_estado_ficha_SQL(tabla(i)(0))
                        Exit Try
                    End Try
                End If
            Next

        End If


        '******************FICHAS ELIMINADAS*******************************************
        eliminar_fichas_MYSQL() 'Eliminar las fichas de MYSQl las cuales en SQL tienen un estado 0

        '*************** Guardamos las fichas de mysql que no esten en sql **********
        Consultar_fichas_de_MYSQL()
    End Function
    '********************************************************************************

    '********************METODOS PARA ELIMINAR LAS FICHAS CON ESTADO 0 DE SQL EN MYSQL**************
    Function eliminar_fichas_MYSQL()
        'Obtenemos las fichas inactivas (con estado 0) de la base de datos de SQLSERVER 
        datos = Select_1ParametroInt("sp_tbl_fichas_eliminadas", "")
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla.Rows.Count > 0 Then

            For i = 0 To tabla.Rows.Count - 1
                Try
                    conexionMS.Open() 'abrimos laconexion de mysql

                    'Eliminadmos el registro en la base de datos de MYSQl
                    comandoMS = New MySqlCommand("DELETE FROM tbl_ficha WHERE codigo='" & tabla(i)(0) & "'", conexionMS)
                    comandoMS.CommandType = CommandType.Text
                    comandoMS.ExecuteNonQuery()

                    conexionMS.Close() 'cerramos conexion mysql
                Catch ex As MySqlException
                    conexionMS.Close() 'cerramos conexion mysql
                    Exit Try
                End Try

            Next

        End If
    End Function
    '*******************************************************************************************


    '********************************  SINCRONIZAMOS LA TABLA CLIENTES ****************************************************
    Function clientes()
        datos = Select_1ParametroInt("sp_tbl_cliente_select_sincronizados", "1") 'Obtenemos todas las fichas activas en  SQL SERVER
        tabla = New DataTable
        tabla = datos.tables("datos")


        If tabla.Rows.Count > 0 Then

            total_datos = tabla.Rows.Count
            maximo_paginas = Math.Ceiling(total_datos / numero_registros)


            For i = 0 To maximo_paginas - 1
                datos = tbl_clientes_paginado({"1", anterior, siguiente}, "sp_tbl_cliente_sincronizado_paginado")
                tabla = New DataTable
                tabla = datos.tables("datos")

                'recorremos los registros con un para  determinar cuales tiene el estado 0 en sincronizacion
                For j = 0 To tabla.Rows.Count - 1
                    Try
                        Select Case tabla(j)(14)
                            Case 0

                                Try
                                    conexionMS.Open() 'abrimos laconexion de mysql

                                    comandoMS = New MySqlCommand("INSERT INTO tbl_clientes VALUES ('" & tabla(j)(0) & "', 
                                                                                                      '" & tabla(j)(1) & "',
                                                                                                      '" & tabla(j)(2) & "',
                                                                                                       '" & tabla(j)(3) & "',
                                                                                                       '" & tabla(j)(5) & "',
                                                                                                       '" & tabla(j)(6) & "',
                                                                                                      '" & tabla(j)(8) & "',
                                                                                                      '" & tabla(j)(15) & "')", conexionMS)

                                    comandoMS.CommandType = CommandType.Text
                                    comandoMS.ExecuteNonQuery()

                                    conexionMS.Close() 'abrimos laconexion de mysql

                                    cambio_estado_sincronizado_clientes_SQL(tabla(j)(0)) 'esta funcion cambia el estado de sincronizacion del cliente

                                Catch ex As MySqlException
                                    conexionMS.Close() 'abrimos laconexion de mysql
                                    cambio_estado_sincronizado_clientes_SQL(tabla(j)(0)) 'esta funcion cambia el estado de sincronizacion del cliente
                                    Exit Try
                                End Try
                        End Select

                    Catch ex As Exception
                        Exit Try

                    End Try
                Next

                anterior = siguiente + 1
                siguiente = siguiente + numero_registros
            Next

        End If

        '*****************************************************************************************************************************************
        anterior = 0
        siguiente = numero_registros

        eliminar_clientes_MYSQL() 'Metodo para eliminar de MYSQL los clientes con estado 0 en sql server

        Consultar_clientes_MYSQL() 'Guardamos los aprendizes sincronizados en otros centros en nuestra BD SQL
    End Function
    ''*************************************************************************************************************************


    '************** METODO PARA GUARDAR LOS CLIENTES DE MYSQL EN SQL SERVES ***************
    Function Consultar_clientes_MYSQL()
        Try
            conexionMS.Open()

            comandoMS = New MySqlCommand("SELECT * FROM tbl_clientes ", conexionMS)
            comandoMS.CommandType = CommandType.Text

            AdaptadorMS = New MySqlDataAdapter
            AdaptadorMS.SelectCommand = comandoMS
            AdaptadorMS.SelectCommand.Connection = conexionMS

            dataset = New DataSet
            AdaptadorMS.Fill(dataset, "datos")

            conexionMS.Close()

            tabla = New DataTable
            tabla = dataset.Tables("datos")


            'Guardamos las fichas en sql server
            For i = 0 To tabla.Rows.Count - 1
                Try
                    conexionSQL.Open()
                    comandos = New SqlCommand("INSERT INTO tbl_cliente VALUES ('" & tabla(i)(0) & "', 
                                                                             '" & tabla(i)(1) & "',
                                                                             '" & tabla(i)(2) & "',
                                                                             '" & tabla(i)(3) & "',
                                                                             '" & tabla(i)(4) & "',
                                                                             '" & tabla(i)(5) & "',
                                                                             '" & Date.Now.Date & "',
                                                                             '" & tabla(i)(6) & "',
                                                                             '" & DBNull.Value & "',
                                                                             '" & DBNull.Value & "',
                                                                             '" & DBNull.Value & "',
                                                                             '" & DBNull.Value & "',
                                                                             '1',
                                                                             '" & tabla(i)(7) & "',
                                                                             '1')", conexionSQL)
                    comandos.CommandType = CommandType.Text
                    comandos.ExecuteNonQuery()

                    conexionSQL.Close()
                Catch ex As SqlException
                    conexionSQL.Close()
                    Exit Try
                End Try
            Next

        Catch ex As MySqlException
            conexionMS.Close()
            MsgBox(ex.Message)
        End Try
    End Function
    '*******************************************************************************


    '**************** CONSULTAMOS CLIENTES ELIMIANDOS PARA ELIMINARLOS DE LA BD DE MYSQL********************
    Function eliminar_clientes_MYSQL()
        datos = Select_1ParametroInt("sp_tbl_clientes_eliminados ", "aprendiz")
        tabla = New DataTable
        tabla = datos.tables("datos")

        For i = 0 To tabla.Rows.Count - 1
            Try
                conexionMS.Open()
                comandoMS = New MySqlCommand("delete FROM `tbl_clientes` WHERE documento='" & tabla(i)(0) & "'", conexionMS)
                comandoMS.CommandType = CommandType.Text

                comandoMS.ExecuteNonQuery()
                conexionMS.Close()
            Catch ex As MySqlException
                conexionMS.Close()
                MsgBox(ex.Message)
            End Try

        Next
    End Function
    '**************************************************************************


    ''**************** CAMBIO DE ESTADO EN LA SINCRONIZACION  DE LOS CLIENTES SQL SERVER*********************
    Function cambio_estado_sincronizado_clientes_SQL(codigo)

        'Actualizamos el estado de sincronizacion del cliente
        Try
            conexionSQL.Open() 'conexion sql

            comandos = New SqlCommand("Update tbl_cliente set sincronizacion='1' where documento='" & codigo & "'", conexionSQL)
            comandos.CommandType = CommandType.Text
            comandos.ExecuteNonQuery()

            conexionSQL.Close() 'conexion sql
        Catch ex As SqlException
            conexionSQL.Close() 'conexion sql
            MsgBox(ex.Message)
        End Try

    End Function
    '*******************************************************************************************
End Class