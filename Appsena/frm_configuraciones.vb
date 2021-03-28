Public Class frm_configuraciones

    Private Function closed()
        'Esta funcion cierra todos los formularios
        frm_tipoCliente.Close()
        frm_tipoDocumento.Close()
        frm_tipoElementos.Close()
        frm_tipo_prestamo.Close()
        frmDashBoard.pnlConfiguracion.Visible = False
        frm_categorias.Close()
        frm_centros.Close()
        frm_categoria_reservas.Close()
        frm_rutas.Close()
        frm_backup.Close()
    End Function

    Function limpiarcolor()
        'Esta funcion le aplica color a todos los botones
        btntipoprestamo.BaseColor = Color.WhiteSmoke
        btntipoelementos.BaseColor = Color.WhiteSmoke
        btntipodocumento.BaseColor = Color.WhiteSmoke
        btntipoclientes.BaseColor = Color.WhiteSmoke
        btncategorias.BaseColor = Color.WhiteSmoke
        btncentros.BaseColor = Color.WhiteSmoke
        btncategoria_reserva.BaseColor = Color.WhiteSmoke
        btnrutas.BaseColor = Color.WhiteSmoke
        btn_backup.BaseColor = Color.WhiteSmoke
    End Function

    Private Sub btntipoprestamo_Click(sender As Object, e As EventArgs) Handles btntipoprestamo.Click
        closed()
        BajarNivelConfig(frm_tipo_prestamo) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        limpiarcolor()
        btntipoprestamo.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub btntipoelementos_Click(sender As Object, e As EventArgs) Handles btntipoelementos.Click
        closed()

        BajarNivelConfig(frm_tipoElementos) 'bajamos de nivel el formulario para mostrarlo dentro del panel 

        limpiarcolor()
        btntipoelementos.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub btntipodocumento_Click(sender As Object, e As EventArgs) Handles btntipodocumento.Click
        closed()

        BajarNivelConfig(frm_tipoDocumento) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        limpiarcolor()
        btntipodocumento.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub btntipoclientes_Click(sender As Object, e As EventArgs) Handles btntipoclientes.Click
        closed()

        BajarNivelConfig(frm_tipoCliente) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        limpiarcolor()
        btntipoclientes.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btncategorias.Click
        closed()
        BajarNivelConfig(frm_categorias)
        limpiarcolor()
        btncategorias.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub bntcentros_Click(sender As Object, e As EventArgs) Handles btncentros.Click
        closed()
        BajarNivelConfig(frm_centros) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        limpiarcolor()
        btncentros.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub btncategoria_reserva_Click(sender As Object, e As EventArgs) Handles btncategoria_reserva.Click
        closed()
        BajarNivelConfig(frm_categoria_reservas) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        With frm_categoria_reservas
            .reload()
        End With
        limpiarcolor()
        btncategoria_reserva.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub btnrutas_Click(sender As Object, e As EventArgs) Handles btnrutas.Click
        closed()
        BajarNivelConfig(frm_rutas) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        limpiarcolor()
        btnrutas.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub

    Private Sub frm_configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Obtenemos los datos del administrador principál
        datos = CargarDatos("sp_tbl_administrador_tipo_admin")
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Si el usuario es el administrador principal
        If SESSION(0) = tabla(0)(0) Then
            btn_backup.Visible = True
        End If
    End Sub

    Public Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        closed()
        BajarNivelConfig(frm_backup) 'bajamos de nivel el formulario para mostrarlo dentro del panel 
        limpiarcolor()
        btn_backup.BaseColor = Color.LightGray 'Cambiamos color al boton cuando se seleccione
    End Sub
End Class