Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient 'libreria de sql
Imports System.Data
Imports System.Text.RegularExpressions 'libreria para validar correos
Imports System.Text
Imports System.IO


Module Funciones
    Public formu As Byte
    Public VDatos, Cliente(12), ClienteMora(5), codreserva, codcliente, tipo_prestamo, DetallePrestamo, MaestroPrestamo, MTElementos, AAdmin(10), CodCentro As Object
    Public imagenBytes(), SwPrestamo, Sw, SwFrm, SWMORA, Cerradura, IsTraspaso, TraspasoDetalle As Byte
    Public imagenmemoria As MemoryStream
    Public Docid, CodCentroActual As String
    Public ToolTip1 As New ToolTip()
    Public FechaHoy As Date = Today & " " & Now.ToString("hh:mm")
    Public FilasDupli, TipoPres_Traspaso As Integer

    Public Function SoloNumeros(e)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.handled = True

        End If
    End Function

    Public Function CargarImg(ptb, rutaimg, msg)
        If IO.File.Exists(rutaimg.ToString) Then
            Dim FS = New FileStream(rutaimg, FileMode.Open)
            ptb.Image = Image.FromStream(FS)
            FS.Close()
        Else
            If rutaimg Is DBNull.Value Then
                ptb.image = Nothing
            Else
                MsgBox("ATENCIÓN: No se encontró la imagen " & msg & " en la ruta especificada", vbExclamation)
                ptb.image = Nothing
            End If
        End If
    End Function

    Public Function CerrarConfiguraciones(e As MouseEventArgs)
        If e.Button = MouseButtons.Left And frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Function

    Public Function Select_1ParametroInt(sql, parametro)
        'Esta funcion carga un datagrid con un historial de movimientos que se hicieron hoy
        Try

            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim parametroSql As New SqlParameter("@variable", SqlDbType.VarChar)
            parametroSql.Value = parametro
            comandos.Parameters.Add(parametroSql)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")



            conexionSQL.Close()

            Return dataset 'retornamos los datos obtenidos.

        Catch err As SqlException
            If err.Number = 201 Then
                conexionSQL.Close()
                Return 0
            Else
                conexionSQL.Close()
                MsgBox(err.ToString) 'imprimimos el error que nos genere
            End If

        End Try
    End Function

    Public Function Select_1ParametroVarchar(sql, parametro)
        'Esta funcion carga un datagrid con un historial de movimientos que se hicieron hoy
        Try

            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim parametroSql As New SqlParameter("@variable", SqlDbType.VarChar)
            parametroSql.Value = parametro
            comandos.Parameters.Add(parametroSql)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            tabla = New DataTable
            tabla = dataset.Tables("datos")

            conexionSQL.Close()

            Return tabla 'retornamos los datos obtenidos.

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString) 'imprimimos el error que nos genere
        End Try
    End Function

    Public Function Select_1Parametro(sql, parametro)
        'Esta funcion carga un datagrid con un historial de movimientos que se hicieron hoy
        Try

            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim parametroSql As New SqlParameter("@fechaactual", SqlDbType.DateTime)
            parametroSql.Value = parametro
            comandos.Parameters.Add(parametroSql)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")


            conexionSQL.Close()

            Return dataset 'retornamos los datos obtenidos.

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString) 'imprimimos el error que nos genere
        End Try
    End Function

    Public Function CerrarPestañas()
        frmConfigCuenta.Close()
        frm_configuraciones.Close()
        frmMovimientos_detalle.Close()
        frmMovimientos_documento.Close()
        frm_reservas.Close()
        frm_detalle_reserva.Close()
        frm_calendario.Close()
        frm_insert_update_elemento.Close()
        frmDashBoard.pnlConfiguracion.Visible = False
        frm_clientes.Close()
        frmMovimientos_DuplicarPrestamo.Close()
        frm_elementos.Close()
        frmMovimientos_DuplicarMovim.Close()
        frm_mora.Close()
        frm_historial_reservas.Close()
        frmMora_Insert_Update.Close()
        frmMovimientos_Historial.Close()
        frm_bajas.Close()
        frm_administradores.Close()
        frmMovimientos_PrestamosCliente.Close()
        frm_sincronizacion.Close()

    End Function



    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            Bin.Dispose()
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                Bin.Dispose()
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function CerrarConfig()
        'Ocultamos el panel de Usuario
        frmDashBoard.pnlConfiguracion.Visible = False

    End Function

    Public Function BajarNivel(formulario)

        'Funcion para bajar de nivel los form y abrirlos dentro de un panel
        formulario.TopLevel = False
        formulario.Dock = DockStyle.Fill
        frmDashBoard.pnlPrincipal.Controls.Add(formulario)
        formulario.show()
        frmDashBoard.lblFormu.Text = formulario.text
    End Function
    Public Function BajarNivelConfig(formulario)

        'Funcion para bajar de nivel los form y abrirlos dentro de un panel
        formulario.TopLevel = False
        formulario.Dock = DockStyle.Fill
        frm_configuraciones.panelconfiguraciones.Controls.Add(formulario)
        formulario.show()
    End Function

    Public Function CargarDatos(sql)
        'Esta funcion me cargara la informacion para los datagrid y los combobox
        Try

            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return dataset 'retornamos los datos obtenidos.

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString) 'imprimimos el error que nos genere
        End Try
    End Function

    'Funcion que retorna un valor dependiendo de la necesidad de simbolos
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
               "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Public Function ValidarAdmin(sql)
        'validamos si ya hay un administrador regustrado ,esto se hace para ocultar el boton de registro en el login
        conexionSQL.Open()
        comandos = New SqlCommand(sql, conexionSQL)
        comandos.CommandType = CommandType.StoredProcedure

        lectura = comandos.ExecuteReader
        If lectura.HasRows Then
            frm_login.btnregistrarme.Visible = False 'Si ya se encuentran registros en la tabla administradores se oculta el boton registrar
        End If

        conexionSQL.Close()
    End Function




    Public Function Insert_tipos(dato, sql, info)
        'Esta funcion la utilizaremos para insertar o para actualizar un registro de la tabla tipos de prestamos
        Try
            conexionSQL.Close() 'cerramos la conexion

            'si existe el administrador,obtenemos todos los datos y los guardamos en la varible global de SESSION
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramnomnbre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)

            paramnomnbre.Value = dato(0)
            paramestado.Value = dato(1)

            comandos.Parameters.Add(paramnomnbre)
            comandos.Parameters.Add(paramestado)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return MsgBox("¡Se creó correctamente " & info & "!", vbInformation)
        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try


    End Function

    Public Function Update_tipos(dato, sql, info)
        'Esta funcion la utilizaremos  para actualizar un registro de la tablas de tipos ya que su estructura es la misma 
        Try
            conexionSQL.Close() 'cerramos la conexion

            'si existe el administrador,obtenemos todos los datos y los guardamos en la varible global de SESSION
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.Int)
            Dim paramnomnbre As New SqlParameter("@nombre", SqlDbType.VarChar)

            paramcodigo.Value = dato(0)
            paramnomnbre.Value = dato(1)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramnomnbre)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()
            Return MsgBox("¡Se Actualizo correctamente  " & info & "!", vbInformation) 'Retornnamos el mensaje 
        Catch ex As SqlException

            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Eliminar_tipos(dato, sql, info)
        'Esta funcion la utilizaremos el estado a 0 esto significa que esta eliminado
        Try

            'si existe el administrador,obtenemos todos los datos y los guardamos en la varible global de SESSION
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.Int)

            paramcodigo.Value = dato

            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return MsgBox("¡Se Elimino  " & info & "!", vbInformation)
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Insert_tblReservas(array, sql)
        'Esta funcion nos sirve para insertar y actualizar alguna reserva
        Try
            conexionSQL.Open() 'abre conexcion
            comandos = New SqlCommand(sql, conexionSQL) 'pasamos a la varible la consulta con la conexion
            comandos.CommandType = CommandType.StoredProcedure 'definimos que es un procedimiento almacendo

            'creamos los parametros que pide el procedimiento almacenado
            Dim paramcliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
            Dim paramprestamo As New SqlParameter("@tipo_prestamo", SqlDbType.Int)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim paramfreserva As New SqlParameter("@fecha_reserva", SqlDbType.DateTime)
            Dim paramfprestamo As New SqlParameter("@fecha_prestamo", SqlDbType.DateTime)
            Dim paramfdevolucion As New SqlParameter("@fecha_devolucion", SqlDbType.DateTime)
            Dim paramficha As New SqlParameter("@ficha", SqlDbType.VarChar)
            Dim paramcategoria As New SqlParameter("@categoria", SqlDbType.Int)


            'llenamos los parametros con los datos que nos mandaron
            paramcliente.Value = array(0)
            paramprestamo.Value = array(1)
            paramestado.Value = array(2)
            paramfreserva.Value = array(3)
            paramfprestamo.Value = array(4)
            paramfdevolucion.Value = array(5)
            paramficha.Value = array(6)
            paramcategoria.Value = array(7)


            'Agregamos los parametros al comando que tiene la consulta
            comandos.Parameters.Add(paramcliente)
            comandos.Parameters.Add(paramprestamo)
            comandos.Parameters.Add(paramestado)
            comandos.Parameters.Add(paramfreserva)
            comandos.Parameters.Add(paramfprestamo)
            comandos.Parameters.Add(paramfdevolucion)
            comandos.Parameters.Add(paramficha)
            comandos.Parameters.Add(paramcategoria)

            'creamos el adaptdos
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            'creamos el dataset
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return 1 'retornamos un 1 para informaar que se creo o actualizo la reserva

        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return MsgBox("Error al realizar la reserva !", vbCritical)
            End If
        End Try

    End Function

    Public Function Buscador_keyUp_elementos(dato, sql)
        'Esta funcion se usa para buscadores automaticos  y recibe 2 parametros 
        Try
            conexionSQL.Close()

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)
            Dim paramcategoria As New SqlParameter("@categoria", SqlDbType.Int)


            paramvariable.Value = dato(0)
            paramcategoria.Value = dato(1)

            comandos.Parameters.Add(paramvariable)
            comandos.Parameters.Add(paramcategoria)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Buscador_keyUp(dato, sql)
        'Esta funcion se usa para buscadores automaticos  y recibe 2 parametros 
        Try
            conexionSQL.Close()

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)



            paramvariable.Value = dato


            comandos.Parameters.Add(paramvariable)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function
    Public Function selectTop1_tbl_reserva(sql)
        'Esta funcion me trae la informacion dela utlima reserva 
        Try
            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return dataset 'retornamos los datos obtenidos.

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString) 'imprimimos el error que nos genere
        End Try
    End Function

    Public Function Insert_tbl_reserva_elemento(dato, sql)
        'Esta funcion la utilizaremos para insertar los elemtos de la reserva
        Try
            conexionSQL.Close() 'cerramos la conexion

            'si existe el administrador,obtenemos todos los datos y los guardamos en la varible global de SESSION
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramreserva As New SqlParameter("@codreserva", SqlDbType.Int)
            Dim paramcodelemento As New SqlParameter("@descripcion", SqlDbType.VarChar)
            Dim paramcantidad As New SqlParameter("@cantidad", SqlDbType.Int)
            Dim paramobservaciones As New SqlParameter("@observaciones", SqlDbType.VarChar)


            paramreserva.Value = dato(0)
            paramcodelemento.Value = dato(1)
            paramcantidad.Value = dato(2)
            paramobservaciones.Value = dato(3)


            comandos.Parameters.Add(paramreserva)
            comandos.Parameters.Add(paramcodelemento)
            comandos.Parameters.Add(paramcantidad)
            comandos.Parameters.Add(paramobservaciones)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return 1
        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function



    Public Function dia_reservas(dia_inicial, dia_final, sql)
        Try
            'con esta funcion obtenemos las resrvas que hay entre dos fechas
            conexionSQL.Close() 'cerramos la conexion

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramfecha_inicial As New SqlParameter("@fecha_inicial", SqlDbType.Date)
            Dim paramfecha_final As New SqlParameter("@fecha_final", SqlDbType.Date)

            paramfecha_inicial.Value = dia_inicial
            paramfecha_final.Value = dia_final

            comandos.Parameters.Add(paramfecha_inicial)
            comandos.Parameters.Add(paramfecha_final)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()
            Return dataset
        Catch ex As SqlException

            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Reserva_selectPK(dato, sql)
        'Esta funcion se usa para buscar la reserva en la cual se dio click en el calendario y tambien para consultar los elementos de una reserva.
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codreserva", SqlDbType.Int)

            paramcodigo.Value = dato

            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset 'devolvemos el dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Reserva_elemento_PK(dato, sql)
        'Esta funcion se usa para buscar la reserva en la cual se dio click en el calendario y tambien para consultar los elementos de una reserva.
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codreserva", SqlDbType.Int)

            paramcodigo.Value = dato

            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset 'devolvemos el dataset

        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function



    Public Function UpdateDispoElemento(Codigo, Operacion)
        Try
            conexionSQL.Open() 'Abrir la conexion
            comandos = New SqlCommand("sp_tbl_elemento_DescontarDispo", conexionSQL) ' Se crea el comando
            comandos.CommandType = CommandType.StoredProcedure 'Se selecciona el tipo de comando

            'Se crean los parametros del procedimiento
            Dim ParamCod As New SqlParameter("@codigo", SqlDbType.VarChar)
            Dim ParamDispo As New SqlParameter("@disponibile", SqlDbType.Int)

            'Se le da un valor a cada uno de los parametros
            ParamCod.Value = Codigo
            ParamDispo.Value = Operacion

            'Se agregan los parametros al comando
            comandos.Parameters.Add(ParamCod)
            comandos.Parameters.Add(ParamDispo)

            'Se crea una nueva instancia del adaptador
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos 'Se le instancia el comando al adaptador
            adaptador.SelectCommand.Connection = conexionSQL 'Se instancia la conexion para el comando
            dataset = New DataSet 'Se crea una nueva instancia del dataset
            adaptador.Fill(dataset, "datos") 'Se llena el dataset por medio del adaptador
            conexionSQL.Close() 'Se cierra la conexion

            Return dataset 'Retornamos el dataset para poder utilizar la informacion

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)

        End Try


    End Function


    Public Function InsertUpdatePrestamo(prestamo, sql)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Select Case sql
                Case "sp_tblprestamo_insert"
                    Dim ParamCodCliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
                    Dim ParamAdmin As New SqlParameter("@codadministrador", SqlDbType.VarChar)
                    Dim ParamTipoPrestamo As New SqlParameter("@tipo_prestamo", SqlDbType.Int)
                    Dim ParamCodEstado As New SqlParameter("@codestado", SqlDbType.VarChar)
                    Dim ParamFechaPres As New SqlParameter("@fecha_prestamo", SqlDbType.DateTime)
                    Dim ParamFechaDev As New SqlParameter("@fecha_devolucion", SqlDbType.DateTime)
                    Dim ParamFechaLimit As New SqlParameter("@fecha_limite", SqlDbType.DateTime)
                    Dim ParamSeguro1 As New SqlParameter("@seguro1", SqlDbType.VarChar)
                    Dim ParamSeguro2 As New SqlParameter("@seguro2", SqlDbType.VarChar)
                    Dim ParamSeguro3 As New SqlParameter("@seguro3", SqlDbType.VarChar)
                    Dim ParamFSalida As New SqlParameter("@fsalida", SqlDbType.VarChar)

                    ParamCodCliente.Value = prestamo(0)
                    ParamAdmin.Value = prestamo(1)
                    ParamTipoPrestamo.Value = prestamo(2)
                    ParamCodEstado.Value = prestamo(3)
                    ParamFechaPres.Value = prestamo(4)
                    ParamFechaDev.Value = prestamo(5)
                    ParamFechaLimit.Value = prestamo(6)
                    ParamSeguro1.Value = prestamo(7)
                    ParamSeguro2.Value = prestamo(8)
                    ParamSeguro3.Value = prestamo(9)
                    ParamFSalida.Value = prestamo(10)

                    comandos.Parameters.Add(ParamCodCliente)
                    comandos.Parameters.Add(ParamAdmin)
                    comandos.Parameters.Add(ParamTipoPrestamo)
                    comandos.Parameters.Add(ParamCodEstado)
                    comandos.Parameters.Add(ParamFechaPres)
                    comandos.Parameters.Add(ParamFechaDev)
                    comandos.Parameters.Add(ParamFechaLimit)
                    comandos.Parameters.Add(ParamSeguro1)
                    comandos.Parameters.Add(ParamSeguro2)
                    comandos.Parameters.Add(ParamSeguro3)
                    comandos.Parameters.Add(ParamFSalida)

                Case "SP_tblPrestamo_UpdateEstado"
                    Dim ParamCodigo As New SqlParameter("@codigo", SqlDbType.Int)
                    Dim ParamCodEstado As New SqlParameter("@codestado", SqlDbType.VarChar)
                    Dim ParamFechaDevolucion As New SqlParameter("@fecha_devolucion", SqlDbType.DateTime)

                    ParamCodigo.Value = prestamo(0)
                    ParamCodEstado.Value = prestamo(1)
                    ParamFechaDevolucion.Value = prestamo(2)

                    comandos.Parameters.Add(ParamCodigo)
                    comandos.Parameters.Add(ParamCodEstado)
                    comandos.Parameters.Add(ParamFechaDevolucion)

                Case "sp_tbl_prestamo_updateseguro"
                    Dim ParamCodPres As New SqlParameter("@codigo", SqlDbType.Int)
                    Dim ParamFechaLimit As New SqlParameter("@fechanueva", SqlDbType.DateTime)
                    Dim ParamRutaSeg As New SqlParameter("@rutaseguro", SqlDbType.VarChar)
                    Dim ParamCampo As New SqlParameter("@campo", SqlDbType.VarChar)

                    ParamCodPres.Value = prestamo(0)
                    ParamFechaLimit.Value = prestamo(1)
                    ParamRutaSeg.Value = prestamo(2)
                    ParamCampo.Value = prestamo(3)

                    comandos.Parameters.Add(ParamCodPres)
                    comandos.Parameters.Add(ParamFechaLimit)
                    comandos.Parameters.Add(ParamRutaSeg)
                    comandos.Parameters.Add(ParamCampo)

            End Select

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()
            Return 1

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try


    End Function

    Public Function InsertUpdatePrestamoElemento(Elemento, sql)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodPrestamo As New SqlParameter("@codprestamo", SqlDbType.Int)
            Dim ParamCodElemento As New SqlParameter("codelemento", SqlDbType.VarChar)
            Dim ParamCantidad As New SqlParameter("@cantidad", SqlDbType.Int)
            Dim ParamFechaPrestamo As New SqlParameter("@fecha_prestamo", SqlDbType.DateTime)
            Dim ParamFechaDev As New SqlParameter("@fecha_devolucion", SqlDbType.DateTime)
            Dim ParamObserva As New SqlParameter("@observaciones", SqlDbType.VarChar)
            Dim ParamEstado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim ParamCantidadEntrega As New SqlParameter("@cantidadentrega", SqlDbType.Int)
            Dim ParamFechaLimit As New SqlParameter("@fechalimit", SqlDbType.DateTime)

            ParamCodPrestamo.Value = Elemento(0)
            ParamCodElemento.Value = Elemento(1)
            ParamCantidad.Value = Elemento(2)
            ParamFechaPrestamo.Value = Elemento(3)
            ParamFechaDev.Value = Elemento(4)
            ParamObserva.Value = Elemento(5)
            ParamEstado.Value = Elemento(6)
            ParamCantidadEntrega.Value = Elemento(7)
            ParamFechaLimit.Value = Elemento(8)

            comandos.Parameters.Add(ParamCodPrestamo)
            comandos.Parameters.Add(ParamCodElemento)
            comandos.Parameters.Add(ParamCantidad)
            comandos.Parameters.Add(ParamFechaPrestamo)
            comandos.Parameters.Add(ParamFechaDev)
            comandos.Parameters.Add(ParamObserva)
            comandos.Parameters.Add(ParamEstado)
            comandos.Parameters.Add(ParamCantidadEntrega)
            comandos.Parameters.Add(ParamFechaLimit)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function TraerPrestamo(codcliente, tipopres)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("sp_tblprestamo_consecutivo", conexionSQL)

            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodCliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
            Dim ParamTipoPres As New SqlParameter("@tipoprestamo", SqlDbType.Int)

            ParamCodCliente.Value = codcliente
            ParamTipoPres.Value = tipopres

            comandos.Parameters.Add(ParamCodCliente)
            comandos.Parameters.Add(ParamTipoPres)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet

            adaptador.Fill(dataset, "datos")

            lectura = comandos.ExecuteReader
            If lectura.HasRows Then
                conexionSQL.Close()
                Return dataset
            Else
                conexionSQL.Close()
                Return Nothing
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function ValidarClientePrestamo(variable, validacion)
        Try
            conexionSQL.Open()
            Select Case validacion
                Case 1
                    comandos = New SqlCommand("sp_tblprestamo_Maestro", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure
                    Dim ParamCodCliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
                    ParamCodCliente.Value = variable
                    comandos.Parameters.Add(ParamCodCliente)

                Case 2
                    comandos = New SqlCommand("sp_tblprestamo_MaestroCod", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure
                    Dim ParamCodigo As New SqlParameter("@codigo", SqlDbType.Int)
                    ParamCodigo.Value = variable
                    comandos.Parameters.Add(ParamCodigo)
            End Select


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            lectura = comandos.ExecuteReader
            If lectura.HasRows Then
                conexionSQL.Close()
                tabla = New DataTable
                tabla = dataset.Tables("datos")
                Return tabla
            Else
                conexionSQL.Close()
                Return Nothing
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try

    End Function

    Public Function TraerDetallePrestamo(codprestamo, frm)
        Try

            conexionSQL.Open()
            Select Case frm
                Case 1
                    comandos = New SqlCommand("sp_tblprestamo_detalle", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

                Case 2
                    comandos = New SqlCommand("sp_tblprestamo_detalle_Historial", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

                    'Elementos entregados
                Case 3
                    comandos = New SqlCommand("sp_tblprestamo_detalle_ElementosEntregados", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

            End Select


            Dim ParamCodPrestamo As New SqlParameter("@codprestamo", SqlDbType.Int)
            ParamCodPrestamo.Value = codprestamo
            comandos.Parameters.Add(ParamCodPrestamo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet

            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()


            Return dataset

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function BuscarCliente(docid)
        Dim Arreglo
        conexionSQL.Open()
        comandos = New SqlCommand("sp_tblcliente_seleckPK", conexionSQL)
        comandos.CommandType = CommandType.StoredProcedure

        Dim ParamDocid As New SqlParameter("@docid", SqlDbType.VarChar)
        ParamDocid.Value = docid
        comandos.Parameters.Add(ParamDocid)

        adaptador = New SqlDataAdapter
        adaptador.SelectCommand = comandos
        adaptador.SelectCommand.Connection = conexionSQL

        dataset = New DataSet
        adaptador.Fill(dataset, "Datos")

        tabla = New DataTable
        tabla = dataset.Tables("Datos")


        lectura = comandos.ExecuteReader

        If lectura.HasRows Then
            conexionSQL.Close()
            Arreglo = {1, tabla}
            Return Arreglo
        Else
            conexionSQL.Close()
            Arreglo = {0}
            Return Arreglo
        End If
    End Function

    Public Function UpdateElemenentoRepetido(arreglo, procedure, consecutivo)
        Try
            Dim resultado As Object
            conexionSQL.Open()
            comandos = New SqlCommand("SP_tblprestamoelemento_buscarrepetido", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodProcedure As New SqlParameter("@codprocedure", SqlDbType.VarChar)
            Dim ParamCodPres As New SqlParameter("@codprestamo", SqlDbType.Int)
            Dim ParamCodElement As New SqlParameter("@codelemento", SqlDbType.Int)
            Dim ParamFechaPres As New SqlParameter("@fechaprestamo", SqlDbType.DateTime)
            Dim ParamCantidad As New SqlParameter("@cantidad", SqlDbType.Int)
            Dim ParamConsecutivo As New SqlParameter("@consecutivo", SqlDbType.Int)


            ParamCodProcedure.Value = procedure
            ParamCodPres.Value = arreglo(0)
            ParamCodElement.Value = arreglo(1)
            ParamFechaPres.Value = arreglo(3)
            ParamCantidad.Value = arreglo(2)
            ParamConsecutivo.Value = consecutivo


            comandos.Parameters.Add(ParamCodProcedure)
            comandos.Parameters.Add(ParamCodPres)
            comandos.Parameters.Add(ParamCodElement)
            comandos.Parameters.Add(ParamFechaPres)
            comandos.Parameters.Add(ParamCantidad)
            comandos.Parameters.Add(ParamConsecutivo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            tabla = New DataTable
            tabla = dataset.Tables("datos")

            lectura = comandos.ExecuteReader
            If lectura.HasRows Then
                conexionSQL.Close()
                If procedure = "1" Then
                    resultado = {1, 1, tabla}
                    Return resultado
                Else
                    resultado = {1, 2}
                End If
            Else
                conexionSQL.Close()
                If procedure = "1" Then
                    resultado = {0, 1}
                    Return resultado
                Else
                    resultado = {0, 2}
                    Return resultado
                End If
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try

    End Function

    Public Function Update_tblReservas(array, sql)
        'Esta funcion nos sirve para insertar y actualizar alguna reserva
        Try
            conexionSQL.Open() 'abre conexcion
            comandos = New SqlCommand(sql, conexionSQL) 'pasamos a la varible la consulta con la conexion
            comandos.CommandType = CommandType.StoredProcedure 'definimos que es un procedimiento almacendo

            'creamos los parametros que pide el procedimiento almacenado
            Dim paramcodreserva As New SqlParameter("@codreserva", SqlDbType.Int)
            Dim paramcliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
            Dim paramprestamo As New SqlParameter("@tipo_prestamo", SqlDbType.Int)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim paramfreserva As New SqlParameter("@fecha_reserva", SqlDbType.DateTime)
            Dim paramfprestamo As New SqlParameter("@fecha_prestamo", SqlDbType.DateTime)
            Dim paramfdevolucion As New SqlParameter("@fecha_devolucion", SqlDbType.DateTime)
            Dim paramficha As New SqlParameter("@codficha", SqlDbType.VarChar)
            Dim paramcategoria As New SqlParameter("@categoria", SqlDbType.Int)
            Dim Paramadmin As New SqlParameter("delete_admin", SqlDbType.VarChar)


            'llenamos los parametros con los datos que nos mandaron
            paramcodreserva.Value = array(0)
            paramcliente.Value = array(1)
            paramprestamo.Value = array(2)
            paramestado.Value = array(3)
            paramfreserva.Value = array(4)
            paramfprestamo.Value = array(5)
            paramfdevolucion.Value = array(6)
            paramficha.Value = array(7)
            paramcategoria.Value = array(8)
            Paramadmin.Value = array(9)

            'Agregamos los parametros al comando que tiene la consulta
            comandos.Parameters.Add(paramcodreserva)
            comandos.Parameters.Add(paramcliente)
            comandos.Parameters.Add(paramprestamo)
            comandos.Parameters.Add(paramestado)
            comandos.Parameters.Add(paramfreserva)
            comandos.Parameters.Add(paramfprestamo)
            comandos.Parameters.Add(paramfdevolucion)
            comandos.Parameters.Add(paramficha)
            comandos.Parameters.Add(paramcategoria)
            comandos.Parameters.Add(Paramadmin)

            'creamos el adaptdos
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            'creamos el dataset
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return 1 'retornamos un 1 para informaar que se creo o actualizo la reserva

        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return MsgBox("Error al realizar la reserva !", vbCritical)
            End If
        End Try

    End Function

    Public Function reserva_elemento_delete(datos, sql)
        'Esta funcion se usa para eliminar los elementos de una reserva 
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure
            Dim paramcodigo As New SqlParameter("@codreserva", SqlDbType.Int)
            paramcodigo.Value = datos
            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return 1 ' Devolvemos un 1 para indicar que si se completo 

        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function reserva_select_fecha_prestamo(dato, sql)
        'Esta funcion se usa para  valiodar si hay reservas para fecha actual
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@fecha_actual", SqlDbType.Date)

            paramvariable.Value = dato

            comandos.Parameters.Add(paramvariable)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function



    Function validar_reserva_hoy()
        '*************Validamos que no hallan reservas activas del dia anterior***********
        Dim fecha_anterior As Date = Date.Now.AddDays(-1)
        Dim datos = reserva_select_fecha_prestamo(fecha_anterior, "sp_reserva_select_fecha_prestamo")
        tabla = New DataTable
        tabla = datos.tables("datos")
        If tabla.Rows.Count > 0 Then
            For i = 0 To datos.tables("datos").rows.count - 1
                tbl_reserva_delete(tabla(i)(0))
            Next
            MsgBox("Se borraron todas las reservas de ayer", vbCritical)
        End If
        '*********************************************************




        '*******************consultamos si existe alguna reserva para la fecha actual
        Dim fecha_actual As Date = Today & " " & Now.ToString("H:mm")

        datos = reserva_select_fecha_prestamo(fecha_actual, "sp_reserva_select_fecha_prestamo") 'eniamos a la funcion el preocedimiento para que nos devuelva los resultados de esta

        Dim filas = datos.tables("datos").rows.count
        'validamos si hay reservas
        If filas > 0 Then

            tabla = New DataTable
            tabla = datos.tables("datos")


            For i = 0 To filas - 1
                Dim fecha_prestamo As New DateTime
                fecha_prestamo = tabla(i)(5).AddHours(1) 'fecha del prestamo


                If fecha_actual.Hour >= fecha_prestamo.Hour And fecha_actual.Minute >= fecha_prestamo.Minute Then
                    'And fecha_actual.Minute >= fecha_prestamo.Minute

                    'se eliminara la reserva por que ya  ha sobrepasado la hora del entrega
                    tbl_reserva_delete(tabla(i)(0))
                    MsgBox("Se eliminó la reserva del instructor " & tabla(i)(1) & "  ya que supero la hora estimada para reclamar los elementos reservados ", vbInformation)


                    'Actualizamos  el formulario del calendario
                    frm_calendario.Close()
                    BajarNivel(frm_calendario)

                    Exit For

                Else
                    If fecha_actual.Minute.ToString = fecha_prestamo.AddMinutes(-10).Minute Then
                        'Notificamos la usuario quue en 10 minutos se eliminara la reserva 
                        MsgBox("ATENCION la reserva del instructor " & tabla(i)(1) & " se borrara en 10 minutos , por favor notificarle que reclame sus elementos reservados.", vbExclamation)

                    End If
                End If


            Next

            frmDashBoard.btnReservas.Image = My.Resources.icons8_alarms_64 'si hay una reserva cambiamos el icono a una alarma
            ToolTip1.SetToolTip(frmDashBoard.btnReservas, "")
            ToolTip1.SetToolTip(frmDashBoard.btnReservas, "¡Hay reservas para el día de hoy, por favor revisar!")

        Else
            frmDashBoard.btnReservas.Image = My.Resources.icons8_calendar_30_64 'si hay una reserva cambiamos el icono a una alarma

            ToolTip1.SetToolTip(frmDashBoard.btnReservas, "")
            ToolTip1.SetToolTip(frmDashBoard.btnReservas, "Abrir reservas")
        End If
        frmDashBoard.timer_validar_reserva.Start()
    End Function

    Public Function Insert_Update_tbl_cliente(array, sql)
        Try
            conexionSQL.Open() 'abre conexcion
            comandos = New SqlCommand(sql, conexionSQL) 'pasamos a la varible la consulta con la conexion
            comandos.CommandType = CommandType.StoredProcedure 'definimos que es un procedimiento almacendo

            'creamos los parametros que pide el procedimiento almacenado
            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)
            Dim paramnombres As New SqlParameter("@nombres", SqlDbType.VarChar)
            Dim paramapellidos As New SqlParameter("@apellidos", SqlDbType.VarChar)
            Dim paramficha As New SqlParameter("@codficha", SqlDbType.VarChar)
            Dim paramemail As New SqlParameter("@email", SqlDbType.VarChar)
            Dim paramtelmovil As New SqlParameter("@telefono", SqlDbType.VarChar)
            Dim paramfecha As New SqlParameter("@fecha", SqlDbType.Date)
            Dim paramtipo_cliente As New SqlParameter("@tipo_cliente", SqlDbType.Int)
            Dim paramfoto As New SqlParameter("@foto", SqlDbType.VarChar)
            Dim paramhuella1 As New SqlParameter("@huella1", SqlDbType.VarChar)
            Dim paramhuella2 As New SqlParameter("@huella2", SqlDbType.VarChar)
            Dim paramhuella3 As New SqlParameter("@huella3", SqlDbType.VarChar)
            Dim paramsincronizacion As New SqlParameter("@sincronizacion", SqlDbType.VarChar)
            Dim paramtipo_documento As New SqlParameter("@tipo_documento", SqlDbType.Int)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)


            'llenamos los parametros con los datos que nos mandaron
            paramdocumento.Value = array(0)
            paramnombres.Value = array(1)
            paramapellidos.Value = array(2)
            paramficha.Value = array(3)
            paramemail.Value = array(4)
            paramtelmovil.Value = array(5)
            paramfecha.Value = array(6)
            paramtipo_cliente.Value = array(7)
            paramfoto.Value = array(8)
            paramhuella1.Value = array(9)
            paramhuella2.Value = array(10)
            paramhuella3.Value = array(11)
            paramsincronizacion.Value = array(12)
            paramtipo_documento.Value = array(13)
            paramestado.Value = array(14)

            'Agregamos los parametros al comando que tiene la consulta
            comandos.Parameters.Add(paramdocumento)
            comandos.Parameters.Add(paramnombres)
            comandos.Parameters.Add(paramapellidos)
            comandos.Parameters.Add(paramficha)
            comandos.Parameters.Add(paramemail)
            comandos.Parameters.Add(paramtelmovil)
            comandos.Parameters.Add(paramfecha)
            comandos.Parameters.Add(paramtipo_cliente)
            comandos.Parameters.Add(paramfoto)
            comandos.Parameters.Add(paramhuella1)
            comandos.Parameters.Add(paramhuella2)
            comandos.Parameters.Add(paramhuella3)
            comandos.Parameters.Add(paramsincronizacion)
            comandos.Parameters.Add(paramtipo_documento)
            comandos.Parameters.Add(paramestado)

            'creamos el adaptdos
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            'creamos el dataset
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return 1

        Catch ex As SqlException
            'Si el documento ya existe
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return 2627
                frm_clientes.Cursor = Cursors.Default
            Else

                'campos obligatorios
                If ex.Number = 515 Then
                    conexionSQL.Close()
                    Return 515
                    frm_clientes.Cursor = Cursors.Default
                Else
                    If ex.Number = 8114 Then
                        conexionSQL.Close()
                        Return 8114
                    Else
                        If ex.Number = 547 Then
                            conexionSQL.Close()
                            Return 547
                        Else

                        End If
                        conexionSQL.Close()
                        MsgBox(ex.ToString)
                        frm_clientes.Cursor = Cursors.Default
                    End If

                End If
            End If
            conexionSQL.Close()
        End Try
    End Function


    Public Function buscar_ficha(dato, sql)
        'Esta funcion se usa para buscar si exsite algunma ficha
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@variable", SqlDbType.VarChar)

            paramcodigo.Value = dato

            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            If ex.Number = 201 Then
                conexionSQL.Close() 'Cerramos la conexion
                Return 0
            Else
                conexionSQL.Close() 'Cerramos la conexion
                MsgBox(ex.ToString)
            End If

        End Try
    End Function

    Public Function insert_update_tbl_ficha(dato, sql, info)
        'Esta funcion se usa para insertar y actualizar un registro 
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.VarChar)
            Dim paramprograma As New SqlParameter("@programa", SqlDbType.VarChar)
            Dim paramenlace As New SqlParameter("@enlace", SqlDbType.VarChar)

            paramcodigo.Value = dato(0)
            paramprograma.Value = dato(1)
            paramenlace.Value = dato(2)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramprograma)
            comandos.Parameters.Add(paramenlace)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexioN

            Return MsgBox("Se " & info & " correctamente el registro", vbInformation)

        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close() 'Cerramos la conexion
                Return 0
            Else
                conexionSQL.Close()
                Return 0
            End If
        End Try
    End Function

    Public Function tbl_cliente_selectPK(dato, sql)
        'Esta funcion se usa para buscar si exsite algunma ficha
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)

            paramdocumento.Value = dato

            comandos.Parameters.Add(paramdocumento)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function tbl_cliente_delete(dato, sql)
        'Esta funcion se usa para actualizar el estado del cliente a 0 ,de esta manera ya no sera visible en el sistema
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)

            paramdocumento.Value = dato

            comandos.Parameters.Add(paramdocumento)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return 1
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function tbl_reserva_delete(dato)
        'Esta funcion se usa para actualizar el estado del cliente a 0 ,de esta manera ya no sera visible en el sistema
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("sp_tbl_reserva_delete", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramdocumento As New SqlParameter("@codreserva", SqlDbType.Int)

            paramdocumento.Value = dato

            comandos.Parameters.Add(paramdocumento)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexion

        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function EntregarElementos(arreglo)
        Try

            conexionSQL.Open()
            comandos = New SqlCommand("SP_tblprestamoelemento_Actualizar", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCoPrestamo As New SqlParameter("@codprestamo", SqlDbType.Int)
            Dim ParamCodElemento As New SqlParameter("@codelemento", SqlDbType.VarChar)
            Dim ParamFechaPres As New SqlParameter("@fecha_prestamo", SqlDbType.DateTime)
            Dim ParamFechaDev As New SqlParameter("@fecha_devolucion", SqlDbType.DateTime)
            Dim ParamObserva As New SqlParameter("@observaciones", SqlDbType.VarChar)
            Dim ParamEstado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim ParamConse As New SqlParameter("@consecutivo", SqlDbType.Int)
            Dim ParamCantidadEntrega As New SqlParameter("@cantidadentrega", SqlDbType.Int)

            ParamCoPrestamo.Value = arreglo(0)
            ParamCodElemento.Value = arreglo(1)
            ParamFechaPres.Value = arreglo(3)
            ParamFechaDev.Value = arreglo(4)
            ParamObserva.Value = arreglo(5)
            ParamEstado.Value = arreglo(6)
            ParamConse.Value = arreglo(7)
            ParamCantidadEntrega.Value = arreglo(2)

            comandos.Parameters.Add(ParamCoPrestamo)
            comandos.Parameters.Add(ParamCodElemento)
            comandos.Parameters.Add(ParamFechaPres)
            comandos.Parameters.Add(ParamFechaDev)
            comandos.Parameters.Add(ParamObserva)
            comandos.Parameters.Add(ParamEstado)
            comandos.Parameters.Add(ParamConse)
            comandos.Parameters.Add(ParamCantidadEntrega)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try

    End Function

    Function tbl_configuracion_backup(datos, sql)
        Try


            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramtipo_copia As New SqlParameter("@tipo_copia", SqlDbType.VarChar)
            Dim paramfecha_copia As New SqlParameter("@fecha_copia", SqlDbType.Date)
            Dim paramruta As New SqlParameter("@ruta_backup", SqlDbType.VarChar)


            paramtipo_copia.Value = datos(0)
            paramfecha_copia.Value = datos(1)
            paramruta.Value = datos(2)


            comandos.Parameters.Add(paramtipo_copia)
            comandos.Parameters.Add(paramfecha_copia)
            comandos.Parameters.Add(paramruta)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return MsgBox("Se guardaron exitosamente los datos.", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function SelectElemento(codigo, devolver)
        Try

            conexionSQL.Open()
            comandos = New SqlCommand("sp_tbl_elemento_selectPK", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCod As New SqlParameter("@codigo", SqlDbType.VarChar)
            ParamCod.Value = codigo
            comandos.Parameters.Add(ParamCod)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            If devolver = 1 Then
                tabla = New DataTable
                tabla = dataset.Tables("datos")
                Return tabla
            Else
                Return dataset
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try

    End Function


    Public Function DuplicarMovimiento(sql, parametro)
        'Esta funcion carga un datagrid con un historial de movimientos que se hicieron hoy
        Try

            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim parametroSql As New SqlParameter("@variable", SqlDbType.VarChar)
            parametroSql.Value = parametro
            comandos.Parameters.Add(parametroSql)

            Dim parametroSql2 As New SqlParameter("@fecha", SqlDbType.Date)
            parametroSql2.Value = Today.Date
            comandos.Parameters.Add(parametroSql2)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            tabla = New DataTable
            tabla = dataset.Tables("datos")

            conexionSQL.Close()

            Return tabla 'retornamos los datos obtenidos.

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString) 'imprimimos el error que nos genere
        End Try
    End Function

    Public Function DuplicarElementos(codigos)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("SP_tblPrestamoElemento_Duplicar", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodPrestamo As New SqlParameter("@codprestamo", SqlDbType.Int)
            Dim ParamCodElemento As New SqlParameter("@codelemento", SqlDbType.VarChar)

            ParamCodPrestamo.Value = codigos(0)
            ParamCodElemento.Value = codigos(1)

            comandos.Parameters.Add(ParamCodPrestamo)
            comandos.Parameters.Add(ParamCodElemento)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            tabla = New DataTable
            tabla = dataset.Tables("datos")
            conexionSQL.Close()

            Return tabla

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try


    End Function

    Public Function BuscadorPrestamo(dato, sql)
        'Esta funcion se usa para buscadores automaticos  y recibe 2 parametros 
        Try
            conexionSQL.Close()

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)
            paramvariable.Value = dato(0)
            comandos.Parameters.Add(paramvariable)

            Dim paramvariable2 As New SqlParameter("@fecha", SqlDbType.Date)
            paramvariable2.Value = dato(1)
            comandos.Parameters.Add(paramvariable2)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function modelo_selectFK(dato, sql)
        'Esta funcion se usa para buscar los modelos corresponientes a cada marca
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodmarca As New SqlParameter("@codmarca", SqlDbType.Int)

            paramcodmarca.Value = dato

            comandos.Parameters.Add(paramcodmarca)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function insert_update_elemento(array, sql)
        Try
            conexionSQL.Open() 'abre conexcion
            comandos = New SqlCommand(sql, conexionSQL) 'pasamos a la varible la consulta con la conexion
            comandos.CommandType = CommandType.StoredProcedure 'definimos que es un procedimiento almacendo

            'creamos los parametros que pide el procedimiento almacenado
            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.VarChar)
            Dim paramcentro As New SqlParameter("@codcentro", SqlDbType.VarChar)
            Dim paramplaca As New SqlParameter("@placa", SqlDbType.VarChar)
            Dim paramserial As New SqlParameter("@serial", SqlDbType.VarChar)
            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim parammodelo As New SqlParameter("@codmodelo", SqlDbType.Int)
            Dim paramtipo_elemento As New SqlParameter("@tipo_elemento", SqlDbType.Int)
            Dim paramcategoria As New SqlParameter("@codcategoria", SqlDbType.Int)
            Dim paramubicacion As New SqlParameter("@ubicacion", SqlDbType.VarChar)
            Dim paramfoto As New SqlParameter("@foto", SqlDbType.VarChar)
            Dim paramobservaciones As New SqlParameter("@observaciones", SqlDbType.VarChar)
            Dim paramfecha As New SqlParameter("@fecha_abquisicion", SqlDbType.Date)
            Dim paramvalor As New SqlParameter("@valor", SqlDbType.Int)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim paramcantidad As New SqlParameter("@cantidad", SqlDbType.Int)
            Dim paramdisponibles As New SqlParameter("@disponible", SqlDbType.Int)


            'llenamos los parametros con los datos que nos mandaron
            paramcodigo.Value = array(0)
            paramcentro.Value = array(1)
            paramplaca.Value = array(2)
            paramserial.Value = array(3)
            paramnombre.Value = array(4)
            parammodelo.Value = array(5)
            paramtipo_elemento.Value = array(6)
            paramcategoria.Value = array(7)
            paramubicacion.Value = array(8)
            paramfoto.Value = array(9)
            paramobservaciones.Value = array(10)
            paramfecha.Value = array(11)
            paramvalor.Value = array(12)
            paramestado.Value = array(13)
            paramcantidad.Value = array(14)
            paramdisponibles.Value = array(15)


            'Agregamos los parametros al comando que tiene la consulta
            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramcentro)
            comandos.Parameters.Add(paramplaca)
            comandos.Parameters.Add(paramserial)
            comandos.Parameters.Add(paramnombre)
            comandos.Parameters.Add(parammodelo)
            comandos.Parameters.Add(paramtipo_elemento)
            comandos.Parameters.Add(paramcategoria)
            comandos.Parameters.Add(paramubicacion)
            comandos.Parameters.Add(paramfoto)
            comandos.Parameters.Add(paramobservaciones)
            comandos.Parameters.Add(paramfecha)
            comandos.Parameters.Add(paramvalor)
            comandos.Parameters.Add(paramestado)
            comandos.Parameters.Add(paramcantidad)
            comandos.Parameters.Add(paramdisponibles)



            'creamos el adaptdos
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            'creamos el dataset
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return 0

        Catch ex As SqlException
            'Si el documento ya existe
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return 1
            Else

                'campos obligatorios
                If ex.Number = 515 Then
                    conexionSQL.Close()
                    Return 2
                Else
                    conexionSQL.Close()
                    Return MsgBox(ex.ToString)
                End If
            End If
        End Try
    End Function


    Public Function insert_categorias(datos, sql, info)
        'Esta funcion se usa para insertar y actualizar las categorias
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)


            paramnombre.Value = datos(0)
            paramestado.Value = datos(1)

            comandos.Parameters.Add(paramnombre)
            comandos.Parameters.Add(paramestado)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return MsgBox("Se " & info & " correctamente la categoria", vbInformation)
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function update_categoria(datos, sql, info)
        'Esta funcion se usa para insertar y actualizar las categorias
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramcategoria As New SqlParameter("@codcategoria", SqlDbType.Int)
            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)

            paramcategoria.Value = datos(0)
            paramnombre.Value = datos(1)
            paramestado.Value = datos(2)


            comandos.Parameters.Add(paramcategoria)
            comandos.Parameters.Add(paramnombre)
            comandos.Parameters.Add(paramestado)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return MsgBox("Se " & info & " correctamente la categoria", vbInformation)
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function RutaFotos()
        Try
            conexionSQL.Open() 'Se abre la conexion
            comandos = New SqlCommand("sp_tblConfiguraicones_Select", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            tabla = New DataTable
            tabla = dataset.Tables("datos")
            Return tabla
        Catch err As SqlException
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function PrestamosFiltro_Keyup(parametros)
        Try

            Select Case parametros(4)
                Case 0
                    conexionSQL.Open()
                    comandos = New SqlCommand("SP_tblPrestamo_PrestamosHoy_FiltroAll", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

                    Dim ParamFechaactual As New SqlParameter("@fechaactual", SqlDbType.DateTime)
                    Dim ParamBuscador As New SqlParameter("@buscador", SqlDbType.VarChar)

                    ParamFechaactual.Value = parametros(0)
                    ParamBuscador.Value = parametros(2)

                    comandos.Parameters.Add(ParamFechaactual)
                    comandos.Parameters.Add(ParamBuscador)

                Case 1
                    conexionSQL.Open()
                    comandos = New SqlCommand("SP_tblPrestamo_PrestamosHoy_Filtro", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

                    Dim ParamFechaactual As New SqlParameter("@fechaactual", SqlDbType.DateTime)
                    Dim ParamEstado As New SqlParameter("@codestado", SqlDbType.VarChar)
                    Dim ParamBuscador As New SqlParameter("@buscador", SqlDbType.VarChar)

                    ParamFechaactual.Value = parametros(0)
                    ParamEstado.Value = parametros(1)
                    ParamBuscador.Value = parametros(2)

                    comandos.Parameters.Add(ParamFechaactual)
                    comandos.Parameters.Add(ParamEstado)
                    comandos.Parameters.Add(ParamBuscador)

                Case 2
                    conexionSQL.Open()
                    comandos = New SqlCommand("SP_tblPrestamo_PrestamosHoy_FiltroCMB", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

                    Dim ParamFechaactual As New SqlParameter("@fechaactual", SqlDbType.DateTime)
                    Dim ParamEstado As New SqlParameter("@codestado", SqlDbType.VarChar)
                    Dim ParamBuscador As New SqlParameter("@buscador", SqlDbType.VarChar)
                    Dim ParamCMB As New SqlParameter("@cmbfiltro", SqlDbType.Int)

                    ParamFechaactual.Value = parametros(0)
                    ParamEstado.Value = parametros(1)
                    ParamBuscador.Value = parametros(2)
                    ParamCMB.Value = parametros(3)

                    comandos.Parameters.Add(ParamFechaactual)
                    comandos.Parameters.Add(ParamEstado)
                    comandos.Parameters.Add(ParamBuscador)
                    comandos.Parameters.Add(ParamCMB)

                Case 3
                    conexionSQL.Open()
                    comandos = New SqlCommand("SP_tblPrestamo_PrestamosHoy_FiltroAllCMB", conexionSQL)
                    comandos.CommandType = CommandType.StoredProcedure

                    Dim ParamFechaactual As New SqlParameter("@fechaactual", SqlDbType.DateTime)
                    Dim ParamBuscador As New SqlParameter("@buscador", SqlDbType.VarChar)
                    Dim ParamCMB As New SqlParameter("@cmbfiltro", SqlDbType.Int)

                    ParamFechaactual.Value = parametros(0)
                    ParamBuscador.Value = parametros(2)
                    ParamCMB.Value = parametros(3)

                    comandos.Parameters.Add(ParamFechaactual)
                    comandos.Parameters.Add(ParamBuscador)
                    comandos.Parameters.Add(ParamCMB)

            End Select

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            tabla = New DataTable
            tabla = dataset.Tables("datos")
            conexionSQL.Close()

            Return tabla
        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function Buscador_keyUp_clientes(dato, sql)
        'Esta funcion se usa para buscadores automaticos  y recibe 2 parametros 
        Try
            conexionSQL.Close()

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)
            Dim paramcliente As New SqlParameter("@tipo_cliente", SqlDbType.Int)


            paramvariable.Value = dato(0)
            paramcliente.Value = dato(1)

            comandos.Parameters.Add(paramvariable)
            comandos.Parameters.Add(paramcliente)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function insert_tbl_marca(dato, sql)
        'Esta funcion se usa para insertar nuevos datos en la tabla Marca
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim parammarca As New SqlParameter("@nombre", SqlDbType.VarChar)

            parammarca.Value = dato

            comandos.Parameters.Add(parammarca)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexion

            Return 1
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function insert_tbl_modelo(datos, sql)
        'Esta funcion se usa para insertar nuevos datos en la tabla Marca
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim parammodelo As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim parammarca As New SqlParameter("@codmarca", SqlDbType.Int)

            parammodelo.Value = datos(0)
            parammarca.Value = datos(1)

            comandos.Parameters.Add(parammodelo)
            comandos.Parameters.Add(parammarca)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return 1
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function cargar_ciudad(datos, sql)
        'Esta funcion se usa para buscar las ciudades que correspondan a un departamento
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcoddepartamento As New SqlParameter("@coddepartamento", SqlDbType.VarChar)

            paramcoddepartamento.Value = datos


            comandos.Parameters.Add(paramcoddepartamento)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset

        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function cargar_centros(datos, sql)
        'Esta funcion se usa para buscar las ciudades que correspondan a un departamento
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodciudad As New SqlParameter("@codciudad", SqlDbType.VarChar)

            paramcodciudad.Value = datos


            comandos.Parameters.Add(paramcodciudad)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset

        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function insert_tbl_centroActual(datos, sql)
        'Esta funcion se usa para insertar nuevos datos en la tabla centros
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.VarChar)
            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)

            paramcodigo.Value = datos(0)
            paramnombre.Value = datos(1)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramnombre)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return MsgBox("Se guardó correctamente los datos.", vbInformation)
        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return MsgBox("El código del elemento ya existe, verifique de nuevo la información.", vbCritical)
            Else
                If ex.Number = 547 Then
                    conexionSQL.Close()
                    Return MsgBox("No se puede eliminar este registro ya que guarda relación con otros datos.", vbCritical)
                End If
                conexionSQL.Close() 'Cerramos la conexion
                Return MsgBox(ex.ToString)
            End If

        End Try
    End Function

    Public Function inactivos_activar_cliente(dato, sql, operacion)
        'Esta funcion se usa para buscar las ciudades que correspondan a un departamento
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodciudad As New SqlParameter("@documento", SqlDbType.VarChar)

            paramcodciudad.Value = dato


            comandos.Parameters.Add(paramcodciudad)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio
            If operacion = 1 Then
                Return MsgBox("¡Se volvió a activar el cliente exitosamente!", vbInformation)
            Else
                Return dataset
            End If



        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function insert_tbl_categoria_reservas(datos, sql)
        'Esta funcion se usa para guardar registros en la tabla categoria reserva
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim paramcolor As New SqlParameter("@color", SqlDbType.VarChar)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim paramtope As New SqlParameter("@tope", SqlDbType.Int)

            paramnombre.Value = datos(0)
            paramcolor.Value = datos(1)
            paramestado.Value = "1"
            paramtope.Value = datos(2)

            comandos.Parameters.Add(paramnombre)
            comandos.Parameters.Add(paramcolor)
            comandos.Parameters.Add(paramestado)
            comandos.Parameters.Add(paramtope)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return MsgBox("Se guardó el registro exitosamente.", vbInformation)

        Catch ex As SqlException
            If ex.Number = 201 Then
                conexionSQL.Close()
                Return MsgBox("Debe seleccionar un color")
            Else
                conexionSQL.Close()
                Return MsgBox(ex.ToString)
            End If

        End Try
    End Function

    Function update_tbl_categoria_reserva(datos, sql)
        'Esta funcion se usa paraactualizar registros en la tabla categoria reserva
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.Int)
            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim paramcolor As New SqlParameter("@color", SqlDbType.VarChar)
            Dim paramtope As New SqlParameter("@tope", SqlDbType.Int)

            paramcodigo.Value = datos(0)
            paramnombre.Value = datos(1)
            paramcolor.Value = datos(2)
            paramtope.Value = datos(3)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramnombre)
            comandos.Parameters.Add(paramcolor)
            comandos.Parameters.Add(paramtope)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return MsgBox("Se actualizó el registro exitosamente.", vbInformation)

        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function delete_tbl_categoria_reserva(datos, sql, opcion)
        'Esta funcion se usa paraactualizar registros en la tabla categoria reserva
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.Int)

            paramcodigo.Value = datos
            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            If opcion = 0 Then
                Return MsgBox("Se elimino el registro exitosamente.", vbInformation)
            Else
                Return dataset
            End If
        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function tbl_elementos_delete(dato, sql, info)
        'Esta funcion se usa para insertar y actualizar un registro 
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.VarChar)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)

            paramcodigo.Value = dato(0)
            paramestado.Value = dato(1)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramestado)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexioN

            Return MsgBox("Se " & info & " correctamente el registro", vbInformation)

        Catch ex As SqlException
            If ex.Number = 547 Then
                conexionSQL.Close() 'Cerramos la conexion
                MsgBox("No se puede eliminar este elemento ya que tiene relacion con otros registros", vbCritical)
            End If

        End Try
    End Function

    Public Function Mora_Insert(Arreglo, SQL)
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(SQL, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodCliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
            Dim ParamFechaEntrada As New SqlParameter("@fecha_entrada", SqlDbType.Date)
            Dim ParamFechaSalid As New SqlParameter("@fecha_salida", SqlDbType.Date)
            Dim Paramcodestado As New SqlParameter("@codestado", SqlDbType.VarChar)
            Dim ParamObserva As New SqlParameter("@observaciones", SqlDbType.VarChar)
            Dim ParamSincro As New SqlParameter("@sincronizado", SqlDbType.VarChar)

            ParamCodCliente.Value = Arreglo(0)
            ParamFechaEntrada.Value = Arreglo(1)
            ParamFechaSalid.Value = Arreglo(2)
            Paramcodestado.Value = Arreglo(3)
            ParamObserva.Value = Arreglo(4)
            ParamSincro.Value = Arreglo(5)

            comandos.Parameters.Add(ParamCodCliente)
            comandos.Parameters.Add(ParamFechaEntrada)
            comandos.Parameters.Add(ParamFechaSalid)
            comandos.Parameters.Add(Paramcodestado)
            comandos.Parameters.Add(ParamObserva)
            comandos.Parameters.Add(ParamSincro)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return 1

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try

    End Function

    Public Function tbl_mora_update(datos, sql)
        'Esta funcion se usa para insertar y actualizar un registro 
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codmora", SqlDbType.Int)
            Dim paramrespaldo As New SqlParameter("@codrespaldo", SqlDbType.VarChar)

            paramcodigo.Value = datos(0)
            paramrespaldo.Value = datos(1)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramrespaldo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexioN

            Return MsgBox("Se guardó  correctamente el registro", vbInformation)

        Catch ex As SqlException
            If ex.Number = 547 Then
                conexionSQL.Close() 'Cerramos la conexion
                MsgBox(ex.Message)
            End If

        End Try
    End Function

    Public Function tbl_mora_delete(datos, sql)
        'Esta funcion se usa para eliminar los elementos de una reserva 
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure
            Dim paramcodigo As New SqlParameter("@codmora", SqlDbType.Int)
            Dim paramfecha As New SqlParameter("@fecha_salida", SqlDbType.DateTime)

            paramcodigo.Value = datos(0)
            paramfecha.Value = datos(1)
            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramfecha)
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return 1 ' Devolvemos un 1 para indicar que si se completo 

        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function eliminar_aprendicesXficha(sql, parametro)
        'Esta funcion carga un datagrid con un historial de movimientos que se hicieron hoy
        Try

            conexionSQL.Open()

            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim parametroSql As New SqlParameter("@ficha", SqlDbType.VarChar)
            parametroSql.Value = parametro
            comandos.Parameters.Add(parametroSql)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return MsgBox("Se eliminaron todos los aprendices pertenecientes a la ficha " & parametro, vbInformation)

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString) 'imprimimos el error que nos genere
        End Try
    End Function

    Public Function Mora_SelectPK(Dato, SQL, Devolver)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(SQL, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodCliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
            ParamCodCliente.Value = Dato
            comandos.Parameters.Add(ParamCodCliente)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            If Devolver = 1 Then
                tabla = New DataTable
                tabla = dataset.Tables("datos")
                Return tabla
            Else
                Return dataset
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try

    End Function

    Public Function Mora_Elemento_Insert(Arreglo, SQL)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(SQL, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodMora As New SqlParameter("@cod_mora", SqlDbType.Int)
            Dim ParamCodElemento As New SqlParameter("@cod_elemento", SqlDbType.VarChar)
            Dim ParamCantidad As New SqlParameter("@cantidad", SqlDbType.Int)
            Dim ParamObserva As New SqlParameter("@observaciones", SqlDbType.VarChar)
            Dim ParamFechaEntrada As New SqlParameter("@fecha_entrada", SqlDbType.DateTime)
            Dim ParamFechaSalida As New SqlParameter("@fecha_salida", SqlDbType.DateTime)
            Dim ParamCodEstado As New SqlParameter("@cod_estado", SqlDbType.VarChar)
            Dim ParamCodCentro As New SqlParameter("@cod_centro", SqlDbType.VarChar)
            Dim ParamDocRespa As New SqlParameter("@docrespaldo", SqlDbType.VarChar)

            ParamCodMora.Value = Arreglo(0)
            ParamCodElemento.Value = Arreglo(1)
            ParamCantidad.Value = Arreglo(2)
            ParamObserva.Value = Arreglo(3)
            ParamFechaEntrada.Value = Arreglo(4)
            ParamFechaSalida.Value = Arreglo(5)
            ParamCodEstado.Value = Arreglo(6)
            ParamCodCentro.Value = Arreglo(7)
            ParamDocRespa.Value = Arreglo(8)

            comandos.Parameters.Add(ParamCodMora)
            comandos.Parameters.Add(ParamCodElemento)
            comandos.Parameters.Add(ParamCantidad)
            comandos.Parameters.Add(ParamObserva)
            comandos.Parameters.Add(ParamFechaEntrada)
            comandos.Parameters.Add(ParamFechaSalida)
            comandos.Parameters.Add(ParamCodEstado)
            comandos.Parameters.Add(ParamCodCentro)
            comandos.Parameters.Add(ParamDocRespa)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            Return 1

        Catch err As SqlException
            conexionSQL.Close()
            Return 0
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function EstadoMoraCliente(codcliente, devolver)
        Try

            conexionSQL.Open()
            comandos = New SqlCommand("sp_tbl_mora_ClienteSelect", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodCliente As New SqlParameter("@codcliente", SqlDbType.VarChar)
            ParamCodCliente.Value = codcliente
            comandos.Parameters.Add(ParamCodCliente)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            If devolver = 1 Then
                tabla = New DataTable
                tabla = dataset.Tables("datos")
                Return tabla
            Else
                Return dataset
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function ValidarPrestamosFecha(fecha, sql, devolver)
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamFecha As New SqlParameter("@fechahoy", SqlDbType.Date)
            ParamFecha.Value = fecha
            comandos.Parameters.Add(ParamFecha)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            If devolver = 1 Then
                tabla = New DataTable
                tabla = dataset.Tables("datos")
                Return tabla
            Else
                Return dataset
            End If

        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function Prestamos_HistorialGeneral(fechas, sql)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamFechaInicial As New SqlParameter("@fechainicial", SqlDbType.Date)
            Dim ParamFechaFinal As New SqlParameter("@fechafinal", SqlDbType.Date)

            ParamFechaInicial.Value = fechas(0)
            ParamFechaFinal.Value = fechas(1)

            comandos.Parameters.Add(ParamFechaInicial)
            comandos.Parameters.Add(ParamFechaFinal)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return dataset


        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function

    Public Function Prestamos_HistorialPorCliente(fechas, cliente, sql)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamFechaInicial As New SqlParameter("@fechainicial", SqlDbType.Date)
            Dim ParamFechaFinal As New SqlParameter("@fechafinal", SqlDbType.Date)
            Dim ParamCliente As New SqlParameter("@Cliente", SqlDbType.VarChar)

            ParamFechaInicial.Value = fechas(0)
            ParamFechaFinal.Value = fechas(1)
            ParamCliente.Value = cliente

            comandos.Parameters.Add(ParamFechaInicial)
            comandos.Parameters.Add(ParamFechaFinal)
            comandos.Parameters.Add(ParamCliente)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return dataset


        Catch err As SqlException
            conexionSQL.Close()
            MsgBox(err.ToString)
        End Try
    End Function



    Public Function tbl_bajas_update(datos, sql)
        'Esta funcion se usa para actualizar los datos de la tabla de bajas
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.Int)
            Dim paramfecha As New SqlParameter("@fechareintegro", SqlDbType.DateTime)

            paramcodigo.Value = datos(0)
            paramfecha.Value = datos(1)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramfecha)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexioN

            Return MsgBox("Se reintegro el elemento  correctamente.", vbInformation)

        Catch ex As SqlException
            If ex.Number = 547 Then
                conexionSQL.Close() 'Cerramos la conexion
                MsgBox(ex.Message)
            End If

        End Try
    End Function

    Public Function tbl_mora_elemento(datos, sql)
        'Esta funcion se usa para eliminar los elementos de una reserva 
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure
            Dim paramcodigo As New SqlParameter("@cod_mora", SqlDbType.Int)
            paramcodigo.Value = datos
            comandos.Parameters.Add(paramcodigo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function tbl_mora_elemento_delete(datos, sql)
        'Esta funcion se usa para eliminar los elementos de una reserva 
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramconsecutivo As New SqlParameter("@consecutivo", SqlDbType.Int)
            Dim paramfecha_salida As New SqlParameter("@fecha_salida", SqlDbType.DateTime)

            paramconsecutivo.Value = datos(0)
            paramfecha_salida.Value = datos(1)


            comandos.Parameters.Add(paramconsecutivo)
            comandos.Parameters.Add(paramfecha_salida)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return 1 ' Devolvemos un 1 para indicar que si se completo 

        Catch ex As SqlException
            conexionSQL.Close() 'cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function PrestamoMaestroHistorial(codprestamo, devolver)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("sp_tblprestamo_Maestro_Historial", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodPrestamo As New SqlParameter("@codprestamo", SqlDbType.Int)
            ParamCodPrestamo.Value = codprestamo
            comandos.Parameters.Add(ParamCodPrestamo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            If devolver = 1 Then
                tabla = New DataTable
                tabla = dataset.Tables("datos")
                Return tabla
            Else
                Return dataset
            End If

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function SelectElementoPrestamo(codprestamo, codelemento, fechapres, procedimiento)
        Try
            conexionSQL.Open()
            Select Case procedimiento
                'Cuando se va a entregar un elemento si la cantidad prestada es mayor a uno
                Case 1
                    comandos = New SqlCommand("sp_tblprestamoelemento_selecthistorial", conexionSQL)
                    'Cuando se va a visualizar la cantidad de elementos entregados
                Case 2
                    comandos = New SqlCommand("sp_tblprestamoelemento_DetalleEntregados", conexionSQL)
            End Select

            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodPrestamo As New SqlParameter("@codprestamo", SqlDbType.Int)
            Dim ParamCodElemento As New SqlParameter("@codelemento", SqlDbType.VarChar)
            Dim ParamFechaPres As New SqlParameter("@fechaprestamo", SqlDbType.DateTime)

            ParamCodPrestamo.Value = codprestamo
            ParamCodElemento.Value = codelemento
            ParamFechaPres.Value = fechapres

            comandos.Parameters.Add(ParamCodPrestamo)
            comandos.Parameters.Add(ParamCodElemento)
            comandos.Parameters.Add(ParamFechaPres)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            Return dataset

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function CargarPrestamosCliente(codcliente)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("SP_tblPrestamo_PrestamosCliente", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodCliente As New SqlParameter("@cliente", SqlDbType.VarChar)
            ParamCodCliente.Value = codcliente
            comandos.Parameters.Add(ParamCodCliente)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()
            Return dataset

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function tbl_tipo_admin(dato, sql)
        'Esta funcion se usa para actualizar el estado del cliente a 0 ,de esta manera ya no sera visible en el sistema
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)

            paramdocumento.Value = dato

            comandos.Parameters.Add(paramdocumento)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return 1
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function ValidarLogin(array, sql)
        Try
            'validamos si  el usuario y la contraseña existen en la tabla administradores

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)
            Dim paramcontraseña As New SqlParameter("@contrasenia", SqlDbType.VarChar)

            paramdocumento.Value = array(0)
            paramcontraseña.Value = array(1)

            comandos.Parameters.Add(paramdocumento)
            comandos.Parameters.Add(paramcontraseña)

            lectura = comandos.ExecuteReader
            'Si se encuntra algun registro, guradmos los datos del administrador en un arreglo llamado Session
            If lectura.HasRows Then
                conexionSQL.Close() 'cerramos la conexion

                frm_login.Timer1.Start() 'Detenemos el timer del progresbar

                'si existe el administrador,obtenemos todos los datos y los guardamos en la varible global de SESSION
                conexionSQL.Open()
                comandos = New SqlCommand(sql, conexionSQL)
                comandos.CommandType = CommandType.StoredProcedure

                Dim paramdocumento1 As New SqlParameter("@documento", SqlDbType.VarChar)
                Dim paramcontraseña1 As New SqlParameter("@contrasenia", SqlDbType.VarChar)

                paramdocumento1.Value = array(0)
                paramcontraseña1.Value = array(1)

                comandos.Parameters.Add(paramdocumento1)
                comandos.Parameters.Add(paramcontraseña1)
                adaptador = New SqlDataAdapter
                adaptador.SelectCommand = comandos
                adaptador.SelectCommand.Connection = conexionSQL

                dataset = New DataSet
                adaptador.Fill(dataset, "datos")

                tabla = New DataTable
                tabla = dataset.Tables("datos")

                For i = 0 To 10
                    SESSION(i) = tabla(0)(i)
                Next

                'Guardamos la hora de inicio de sesion del administrador que ingreso al sistema en la tabla de logeo

                comandos = New SqlCommand("sp_tbl_logeo_insert", conexionSQL)
                comandos.CommandType = CommandType.StoredProcedure

                Dim paramadmin As New SqlParameter("@administrador", SqlDbType.VarChar)
                Dim paramhora_inicio As New SqlParameter("@hora_inicio", SqlDbType.DateTime)

                paramadmin.Value = array(0)
                paramhora_inicio.Value = Date.Now

                comandos.Parameters.Add(paramadmin)
                comandos.Parameters.Add(paramhora_inicio)
                adaptador = New SqlDataAdapter
                adaptador.SelectCommand = comandos
                adaptador.SelectCommand.Connection = conexionSQL

                dataset = New DataSet
                adaptador.Fill(dataset, "datos")

                conexionSQL.Close()

            Else
                conexionSQL.Close()
                Return MsgBox("Datos incorrectos, por favor verifique la información !", vbCritical)
            End If
        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function


    Function tbl_logeo_update(datos)
        conexionSQL.Open()
        comandos = New SqlCommand("sp_tbl_logeo_update", conexionSQL)
        comandos.CommandType = CommandType.StoredProcedure

        Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.Int)
        Dim paramhora_final As New SqlParameter("@hora_final", SqlDbType.DateTime)


        paramcodigo.Value = datos
        paramhora_final.Value = Date.Now

        comandos.Parameters.Add(paramcodigo)
        comandos.Parameters.Add(paramhora_final)

        adaptador = New SqlDataAdapter
        adaptador.SelectCommand = comandos
        adaptador.SelectCommand.Connection = conexionSQL

        dataset = New DataSet
        adaptador.Fill(dataset, "datos")

        conexionSQL.Close()
    End Function


    Function tbl_logeo_select_fechas(datos, sql)
        conexionSQL.Open()
        comandos = New SqlCommand(sql, conexionSQL)
        comandos.CommandType = CommandType.StoredProcedure

        Dim paramadmin As New SqlParameter("@variable", SqlDbType.VarChar)
        Dim paramfecha_inicial As New SqlParameter("@fecha_inicial", SqlDbType.Date)
        Dim paramfecha_final As New SqlParameter("@fecha_final", SqlDbType.Date)

        paramadmin.Value = datos(0)
        paramfecha_inicial.Value = datos(1)
        paramfecha_final.Value = datos(2)

        comandos.Parameters.Add(paramadmin)
        comandos.Parameters.Add(paramfecha_inicial)
        comandos.Parameters.Add(paramfecha_final)

        adaptador = New SqlDataAdapter
        adaptador.SelectCommand = comandos
        adaptador.SelectCommand.Connection = conexionSQL

        dataset = New DataSet
        adaptador.Fill(dataset, "datos")

        conexionSQL.Close()

        Return dataset
    End Function

    Public Function Insert_Update_Admin(array, sql) 'Esta funcion nos sirve para hacer un insert o para actualizar datos de los administradores
        Try
            conexionSQL.Open() 'abre conexcion
            comandos = New SqlCommand(sql, conexionSQL) 'pasamos a la varible la consulta con la conexion
            comandos.CommandType = CommandType.StoredProcedure 'definimos que es un procedimiento almacendo

            'creamos los parametros que pide el procedimiento almacenado
            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)
            Dim paramnombres As New SqlParameter("@nombres", SqlDbType.VarChar)
            Dim paramapellidos As New SqlParameter("@apellidos", SqlDbType.VarChar)
            Dim paramemail As New SqlParameter("@email", SqlDbType.VarChar)
            Dim paramtelmovil As New SqlParameter("@telefonomovil", SqlDbType.VarChar)
            Dim paramcontraseña As New SqlParameter("@contrasenia", SqlDbType.VarChar)
            Dim paramfecha_expedicion As New SqlParameter("@fecha_expedicion", SqlDbType.Date)
            Dim paramfoto As New SqlParameter("@foto", SqlDbType.VarChar)
            Dim paramtipodocumento As New SqlParameter("@tipo_documento", SqlDbType.Int)
            Dim paramestado As New SqlParameter("@estado", SqlDbType.VarChar)
            Dim paramtipo_admin As New SqlParameter("@tipo_admin", SqlDbType.VarChar)

            'llenamos los parametros con los datos que nos mandaron
            paramdocumento.Value = array(0)
            paramnombres.Value = array(1)
            paramapellidos.Value = array(2)
            paramemail.Value = array(3)
            paramtelmovil.Value = array(4)
            paramcontraseña.Value = array(5)
            paramfecha_expedicion.Value = array(6)
            paramfoto.Value = array(7)
            paramtipodocumento.Value = array(8)
            paramestado.Value = array(9)
            paramtipo_admin.Value = array(10)

            'Agregamos los parametros al comando que tiene la consulta
            comandos.Parameters.Add(paramdocumento)
            comandos.Parameters.Add(paramnombres)
            comandos.Parameters.Add(paramapellidos)
            comandos.Parameters.Add(paramemail)
            comandos.Parameters.Add(paramtelmovil)
            comandos.Parameters.Add(paramcontraseña)
            comandos.Parameters.Add(paramfecha_expedicion)
            comandos.Parameters.Add(paramfoto)
            comandos.Parameters.Add(paramtipodocumento)
            comandos.Parameters.Add(paramestado)
            comandos.Parameters.Add(paramtipo_admin)

            'creamos el adaptdos
            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            'creamos el dataset
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return MsgBox("Operacion realizada con exito !", vbInformation)

        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                MsgBox("Ya existe un administrador con este numero de documento !", vbCritical)

                If MsgBox("Ya existe un administrador con este número de documento el cual fue eliminado Desea volver a habilitarlo?", vbYesNo) = vbYes Then
                    inactivos_activar_cliente(array(0), "sp_tbl_administradores_activar", 2)
                    With frm_registrarme
                        .limpiarcampos()
                        .Close()
                    End With
                End If

            End If
        End Try

    End Function


    Public Function insert_tbl_bajas(datos, sql)
        'Esta funcion se usa paraactualizar registros en la tabla categoria reserva
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramcodelemento As New SqlParameter("@codelemento", SqlDbType.VarChar)
            Dim paramdescripcion As New SqlParameter("@descripcion", SqlDbType.VarChar)
            Dim paramfecha_baja As New SqlParameter("@fecha_baja", SqlDbType.DateTime)
            Dim paramfecha_reintegro As New SqlParameter("@fecha_reintegro", SqlDbType.DateTime)
            Dim paramcantidad As New SqlParameter("@cantidad", SqlDbType.Int)
            Dim paramadmin As New SqlParameter("@administrador", SqlDbType.VarChar)
            Dim paramtipo_baja As New SqlParameter("@tipo_baja", SqlDbType.VarChar)
            Dim parampdf As New SqlParameter("@pdf", SqlDbType.VarChar)

            paramcodelemento.Value = datos(0)
            paramdescripcion.Value = datos(1)
            paramfecha_baja.Value = datos(2)
            paramfecha_reintegro.Value = datos(3)
            paramcantidad.Value = datos(4)
            paramadmin.Value = datos(5)
            paramtipo_baja.Value = datos(6)
            parampdf.Value = datos(7)

            comandos.Parameters.Add(paramcodelemento)
            comandos.Parameters.Add(paramdescripcion)
            comandos.Parameters.Add(paramfecha_baja)
            comandos.Parameters.Add(paramfecha_reintegro)
            comandos.Parameters.Add(paramcantidad)
            comandos.Parameters.Add(paramadmin)
            comandos.Parameters.Add(paramtipo_baja)
            comandos.Parameters.Add(parampdf)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Buscador_keyUp_clientes_paginado(dato, sql)
        'Esta funcion se usa para buscadores automaticos  y recibe 2 parametros
        Try
            conexionSQL.Close()

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)
            Dim paramcliente As New SqlParameter("@tipo_cliente", SqlDbType.Int)
            Dim paramanterior As New SqlParameter("@anterior", SqlDbType.Int)
            Dim paramnext As New SqlParameter("@siguiente", SqlDbType.Int)


            paramvariable.Value = dato(0)
            paramcliente.Value = dato(1)
            paramanterior.Value = dato(2)
            paramnext.Value = dato(3)


            comandos.Parameters.Add(paramvariable)
            comandos.Parameters.Add(paramcliente)
            comandos.Parameters.Add(paramanterior)
            comandos.Parameters.Add(paramnext)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Function tbl_clientes_paginado(datos, sql)
        Try


            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)
            Dim paramanterior As New SqlParameter("@anterior", SqlDbType.Int)
            Dim paramsiguiente As New SqlParameter("@siguiente", SqlDbType.Int)

            paramvariable.Value = datos(0)
            paramanterior.Value = datos(1)
            paramsiguiente.Value = datos(2)

            comandos.Parameters.Add(paramvariable)
            comandos.Parameters.Add(paramanterior)
            comandos.Parameters.Add(paramsiguiente)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return dataset
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Function


    Function tbl_admin_recuperar_contraseña(datos, sql)
        Try


            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim paramdocumento As New SqlParameter("@documento", SqlDbType.VarChar)
            Dim paramfecha_expedicion As New SqlParameter("@fecha", SqlDbType.Date)


            paramdocumento.Value = datos(0)
            paramfecha_expedicion.Value = datos(1)


            comandos.Parameters.Add(paramdocumento)
            comandos.Parameters.Add(paramfecha_expedicion)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")

            conexionSQL.Close()

            Return dataset

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function insert_update_delete_tbl_centros(datos, sql, info)
        'Esta funcion se usa para insertar nuevos datos en la tabla centros
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramcodigo As New SqlParameter("@codigo", SqlDbType.VarChar)
            Dim paramnombre As New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim paramciudad As New SqlParameter("@ciudad", SqlDbType.VarChar)

            paramcodigo.Value = datos(0)
            paramnombre.Value = datos(1)
            paramciudad.Value = datos(2)

            comandos.Parameters.Add(paramcodigo)
            comandos.Parameters.Add(paramnombre)
            comandos.Parameters.Add(paramciudad)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return MsgBox("Se " & info & " correctamente el registro.", vbInformation)
        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return MsgBox("El código del elemento ya existe, verifique de nuevo la información.", vbCritical)
            Else
                If ex.Number = 547 Then
                    conexionSQL.Close()
                    Return MsgBox("No se puede eliminar este registro ya que guarda relación con otros datos.", vbCritical)
                End If
                conexionSQL.Close() 'Cerramos la conexion
                Return MsgBox(ex.ToString)
            End If

        End Try
    End Function

    Public Function tbl_configuracion_backup_sistema(dato, sql)
        'Esta funcion se usa para buscar la reserva en la cual se dio click en el calendario y tambien para consultar los elementos de una reserva.
        Try

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramfecha As New SqlParameter("@fecha_copia", SqlDbType.Date)
            Dim paramestado As New SqlParameter("@estado_copia", SqlDbType.VarChar)

            paramfecha.Value = dato(0)
            paramestado.Value = dato(1)

            comandos.Parameters.Add(paramfecha)
            comandos.Parameters.Add(paramestado)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset 'devolvemos el dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function


    Public Function insert_tbl_configuracion_rutas(datos, sql)
        'Esta funcion se usa para insertar las rutas de las carpetas en la tabla configuracion
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim parampermisos As New SqlParameter("@permisos", SqlDbType.VarChar)
            Dim paramelementos As New SqlParameter("@elementos", SqlDbType.VarChar)
            Dim paramclientes As New SqlParameter("@clientes", SqlDbType.VarChar)
            Dim paramadministradores As New SqlParameter("@administradores", SqlDbType.VarChar)
            Dim parampdf As New SqlParameter("@pdf", SqlDbType.VarChar)
            Dim parambackup As New SqlParameter("@ruta_backup", SqlDbType.VarChar)
            Dim paramsalida As New SqlParameter("@salidas", SqlDbType.VarChar)
            Dim paramseguros As New SqlParameter("@seguros", SqlDbType.VarChar)

            parampermisos.Value = datos(0)
            paramelementos.Value = datos(1)
            paramclientes.Value = datos(2)
            paramadministradores.Value = datos(3)
            parampdf.Value = datos(4)
            parambackup.Value = datos(5)
            paramsalida.Value = datos(6)
            paramseguros.Value = datos(7)

            comandos.Parameters.Add(parampermisos)
            comandos.Parameters.Add(paramelementos)
            comandos.Parameters.Add(paramclientes)
            comandos.Parameters.Add(paramadministradores)
            comandos.Parameters.Add(parampdf)
            comandos.Parameters.Add(parambackup)
            comandos.Parameters.Add(paramsalida)
            comandos.Parameters.Add(paramseguros)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio
            Return MsgBox("Se guardaron los datos correctamente", vbInformation)

        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return MsgBox("El código del elemento ya existe, verifique de nuevo la información.", vbCritical)
            Else
                conexionSQL.Close() 'Cerramos la conexion
                Return MsgBox(ex.ToString)
            End If

        End Try
    End Function

    Public Function Buscador_keyUp_elementos_paginado(dato, sql)
        'Esta funcion se usa para buscadores automaticos  y recibe 2 parametros
        Try
            conexionSQL.Close()

            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim paramvariable As New SqlParameter("@variable", SqlDbType.VarChar)
            Dim paramcategoria As New SqlParameter("@categoria", SqlDbType.Int)
            Dim paramanterior As New SqlParameter("@anterior", SqlDbType.Int)
            Dim paramnext As New SqlParameter("@siguiente", SqlDbType.Int)


            paramvariable.Value = dato(0)
            paramcategoria.Value = dato(1)
            paramanterior.Value = dato(2)
            paramnext.Value = dato(3)


            comandos.Parameters.Add(paramvariable)
            comandos.Parameters.Add(paramcategoria)
            comandos.Parameters.Add(paramanterior)
            comandos.Parameters.Add(paramnext)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio

            Return dataset
        Catch ex As SqlException
            conexionSQL.Close() 'Cerramos la conexion
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function TipoPrestamo(codprestamo)
        Try
            'ESTÁ FUNCION PERMITE TRAER EL TIPO DE PRESTAMO
            conexionSQL.Open()
            comandos = New SqlCommand("sp_tblPrestamo_TipoPrestamo", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodPrestamo As New SqlParameter("@codigo", SqlDbType.Int)
            ParamCodPrestamo.Value = codprestamo
            comandos.Parameters.Add(ParamCodPrestamo)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

            Return dataset

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function ActualizarReserva(arreglo)
        'Esta funcion descuenta a la cantidad del elemento reservado
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("sp_reserva_updatecantidad", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamReserv As New SqlParameter("@codreservelem", SqlDbType.Int)
            Dim ParamCodReserva As New SqlParameter("@codreserva", SqlDbType.Int)
            Dim ParamCant As New SqlParameter("@cantidad", SqlDbType.Int)

            ParamReserv.Value = arreglo(0)
            ParamCodReserva.Value = arreglo(1)
            ParamCant.Value = arreglo(2)

            comandos.Parameters.Add(ParamReserv)
            comandos.Parameters.Add(ParamCodReserva)
            comandos.Parameters.Add(ParamCant)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL
            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function


    Function UpdateEstadoReserva(arreglo)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("sp_tbl_reserva_updateEstado", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodReserva As New SqlParameter("@codreserva", SqlDbType.Int)
            Dim ParamEstado As New SqlParameter("@estado", SqlDbType.VarChar)

            ParamCodReserva.Value = arreglo(0)
            ParamEstado.Value = arreglo(1)

            comandos.Parameters.Add(ParamCodReserva)
            comandos.Parameters.Add(ParamEstado)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function AbrirArchivos(ruta)
        If File.Exists(ruta) Then
            Process.Start(ruta)
        Else
            MessageBox.Show("El archivo está dañado o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Public Function Update_tbl_configuracion_rutas(datos, sql)
        'Esta funcion se usa para insertar las rutas de las carpetas en la tabla configuracion
        Try
            conexionSQL.Open()
            comandos = New SqlCommand(sql, conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure


            Dim parampermisos As New SqlParameter("@permisos", SqlDbType.VarChar)
            Dim paramelementos As New SqlParameter("@elementos", SqlDbType.VarChar)
            Dim paramclientes As New SqlParameter("@clientes", SqlDbType.VarChar)
            Dim paramadministradores As New SqlParameter("@administradores", SqlDbType.VarChar)
            Dim parampdf As New SqlParameter("@pdf", SqlDbType.VarChar)
            Dim paramsalida As New SqlParameter("@salidas", SqlDbType.VarChar)
            Dim paramseguros As New SqlParameter("@seguros", SqlDbType.VarChar)

            parampermisos.Value = datos(0)
            paramelementos.Value = datos(1)
            paramclientes.Value = datos(2)
            paramadministradores.Value = datos(3)
            parampdf.Value = datos(4)
            paramsalida.Value = datos(5)
            paramseguros.Value = datos(6)

            comandos.Parameters.Add(parampermisos)
            comandos.Parameters.Add(paramelementos)
            comandos.Parameters.Add(paramclientes)
            comandos.Parameters.Add(paramadministradores)
            comandos.Parameters.Add(parampdf)
            comandos.Parameters.Add(paramsalida)
            comandos.Parameters.Add(paramseguros)


            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close() 'cerramos la conexio
            Return MsgBox("Se guardaron los datos correctamente", vbInformation)

        Catch ex As SqlException
            If ex.Number = 2627 Then
                conexionSQL.Close()
                Return MsgBox("El código del elemento ya existe, verifique de nuevo la información.", vbCritical)
            Else
                conexionSQL.Close() 'Cerramos la conexion
                Return MsgBox(ex.ToString)
            End If

        End Try
    End Function

    'Esta funcion descuenta de cantidad los elementos que se traspasaron y tambien los vuelve a sumar
    Public Function UpdateCANTElemento(cod, cant)
        Try
            conexionSQL.Open()
            comandos = New SqlCommand("sp_tblElemento_UpdateCant", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodElem As New SqlParameter("@codElemento", SqlDbType.VarChar)
            Dim ParamCantidad As New SqlParameter("@Cantidad", SqlDbType.Int)

            ParamCodElem.Value = cod
            ParamCantidad.Value = cant

            comandos.Parameters.Add(ParamCodElem)
            comandos.Parameters.Add(ParamCantidad)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function TraspasoRespaldo(prestamo, archivo)
        Try

            conexionSQL.Open()
            comandos = New SqlCommand("sp_tbl_prestamo_devolvertraspaso", conexionSQL)
            comandos.CommandType = CommandType.StoredProcedure

            Dim ParamCodPres As New SqlParameter("@codpres", SqlDbType.Int)
            Dim ParamFormat As New SqlParameter("@formato", SqlDbType.VarChar)

            ParamCodPres.Value = prestamo
            ParamFormat.Value = archivo

            comandos.Parameters.Add(ParamCodPres)
            comandos.Parameters.Add(ParamFormat)

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = comandos
            adaptador.SelectCommand.Connection = conexionSQL

            dataset = New DataSet
            adaptador.Fill(dataset, "datos")
            conexionSQL.Close()

        Catch ex As SqlException
            conexionSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Function
End Module