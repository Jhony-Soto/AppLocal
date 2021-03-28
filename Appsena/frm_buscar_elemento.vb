Public Class frm_buscar_elemento
    Dim arreglo, elemento As Object
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        txtcantidad.Text = ""
        Me.Close()
    End Sub


    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================


    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        'consultamos si el elemento tiene estado 0
        arreglo = {txtcantidad.Text, Date.Now.Date, Date.Now.Date}
        datos = Select_1ParametroInt("sp_tbl_elemento_prestamo_sin_fechas", txtcantidad.Text)
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla.Rows.Count > 0 Then

            elemento = tabla(0)(1) & " " & tabla(0)(2)
            CerrarPestañas()
            BajarNivel(frm_elementos)



            With frm_elementos

                .pnl_paginador.Visible = False
                .lblestado.Text = elemento 'Nombre del elemento
                'Ocultamos la columna '0
                .dgdatos.Columns(0).Visible = False
                .dgdatos.Columns(1).Visible = False
                .dgdatos.Columns(2).Visible = False
                .dgdatos.Columns(3).Visible = False
                .dgdatos.Columns(4).Visible = False

                .group_activos_mora.Visible = False
                .btnexcel.Visible = False
                .btnagregar.Visible = False
                .pnlexcel.Visible = False
                .pnlcontroles.Visible = False
                .Label1.Visible = False
                .txtbuscador.Visible = False
                .lblestado.Visible = True
                .Panel2.Visible = True


                .btn_reporte_excel.Visible = True 'Hacemos visisble le boton para exportar excel

                .array = txtcantidad.Text 'enviamos el codigo del elemento que estamos conusltando

                'Estos son los datetime picker que usuaremos para obetener los prestamos entre dos fechas
                .btnbuscar.Visible = True
                .picker_dia_final.Visible = True
                .picker_dia_final.Value = Date.Now
                .picker_dia_inicial.Visible = True
                .picker_dia_inicial.Value = Date.Now
                .lblfinal.Visible = True
                .lbliniciaol.Visible = True

                'ejecutamos el metodo para que ejecute la consulta con la fecha actual
                .buscar_prestamos()
            End With

            Me.Close()
        Else

            MsgBox("No se encontraron prestamos con  el elemento", vbCritical)
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnconsultar_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub frm_buscar_elemento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtcantidad.Focus()

    End Sub
End Class