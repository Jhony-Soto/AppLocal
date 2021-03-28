Public Class frm_reservas
    Dim fechaActual As DateTime = DateTime.Today
    Dim datos, arreglo(), codelemento, observaciones, matriz(,), swift, vportatil, tope As Object
    Dim i = 0

    Private Sub frm_reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        observaciones = "" 'esta variable contendra la informacion de las observacuiones
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

    Private Sub cmbcliente_GotFocus(sender As Object, e As EventArgs) Handles cmbcliente.GotFocus
        datos = CargarDatos("sp_cliente_reserva_select") 'esta fucnion nos carga todos los registros de los clientes
        tabla = New DataTable
        tabla = datos.tables("datos")

        'mostramos los datos en el combo box
        cmbcliente.DataSource = tabla
        cmbcliente.DisplayMember = "nombres"
        cmbcliente.ValueMember = "documento"

    End Sub

    Private Sub cmbtipoPrestamo_GotFocus(sender As Object, e As EventArgs) Handles cmbtipoPrestamo.GotFocus

        datos = CargarDatos("sp_tbl_tipo_prestamos_select") 'esta fucnion nos carga todos los registros de los clientes
        tabla = New DataTable
        tabla = datos.tables("datos")

        'mostramos los datos en el combo box
        cmbtipoPrestamo.DataSource = tabla
        cmbtipoPrestamo.DisplayMember = "nombre"
        cmbtipoPrestamo.ValueMember = "codigo"
    End Sub

    Private Sub dgdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick
        'Identificamos donde se hizo el click
        Dim fila = dgdatos.CurrentRow.Index
        Select Case e.ColumnIndex
            Case 0
                If MsgBox("¿Seguro que desea eliminar este registro?", vbYesNo) = vbYes Then
                    'Eliminamos la todo el registro
                    dgdatos.Rows.RemoveAt(fila) 'elimina la fila del datagid donde se dio el click
                    i = i - 1 'resta 1 
                    observaciones = "" 'limpia la vriable de observaciones
                End If
            Case 1
                'editamos la reserva llevando los datos a los textbox para que los edite
                txtbuscador.Text = dgdatos.Rows(fila).Cells(2).Value
                nmCantidad.Value = dgdatos.Rows(fila).Cells(3).Value
                observaciones = dgdatos.Rows(fila).Cells(4).Value
                ' eliminamos del datagrid la fila a editar
                dgdatos.Rows.RemoveAt(fila)
                i = i - 1
        End Select
    End Sub

    Private Function agregar()
        If txtbuscador.Text = "" Or nmCantidad.Value = 0 Then
            MsgBox("Campos vacíos , por favor llene todos los campos ", vbInformation)
        Else

            If tope = 0 Then
                tope = 999
            End If

            If nmCantidad.Value > tope Then
                MsgBox("El tope para el prestamo de este elemento es " & tope, vbCritical)
            Else
                dgdatos.Rows.Add()

                dgdatos.Rows(i).Cells(2).Value = txtbuscador.Text
                dgdatos.Rows(i).Cells(3).Value = nmCantidad.Value
                dgdatos.Rows(i).Cells(4).Value = observaciones

                i = i + 1
                observaciones = ""
                txtbuscador.Text = ""
                nmCantidad.Value = 1
            End If
        End If

    End Function

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        agregar()
    End Sub

    Private Sub btnficha_Click(sender As Object, e As EventArgs) Handles btnficha.Click
        pnlficha()
        txtficha.Focus()
    End Sub

    Function guardarficha()
        'Creamos una nueva ficha
        If txtficha.Text = "" And txtprograma.Text = "" Then
            MsgBox("Campos vacíos, por favor llene todos los campos obligatorios.", vbCritical)
        Else
            arreglo = {txtficha.Text, txtprograma.Text, DBNull.Value}
            datos = insert_update_tbl_ficha(arreglo, "sp_tbl_ficha_insert", "guardo")
            If datos = 0 Then
                MsgBox("La ficha ya existe, por favor verificar de nuevo la informacion", vbCritical)
            End If
            pnlficha() 'ocultamos el panel
            txtficha.Text = ""
            txtprograma.Text = ""
        End If
    End Function

    Private Sub btnguardarficha_Click(sender As Object, e As EventArgs) Handles btnguardarficha.Click
        guardarficha()
    End Sub


    Private Sub nmCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles nmCantidad.KeyDown
        'este codigo es para que funcione el enter
        Select Case e.KeyCode
            Case Keys.Enter
                agregar()
        End Select
    End Sub

    Private Sub txtbuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyDown
        'este codigo es para que funcione el enter
        Select Case e.KeyCode
            Case Keys.Enter
                agregar()
        End Select
    End Sub

    Private Sub btnguardar_Click_1(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim filas = dgdatos.RowCount
        If filas <> 0 And cmbcliente.SelectedValue <> Nothing And cmbtipoPrestamo.SelectedValue <> Nothing And cmbcategoria.SelectedValue <> Nothing Then
            'llenamos en arreglo con la informcion que enviaremos ala funcion para crear la reserva
            Dim fecha_prestamo = pickerfecha_reserva.Value.Date & " " & picker_hora.Value.Hour & ":" & picker_hora.Value.Minute
            Dim fecha_devolucion = pickerfecha_reserva.Value.Date & " " & picker_hora_devolucion.Value.Hour & ":" & picker_hora_devolucion.Value.Minute

            arreglo = {cmbcliente.SelectedValue, cmbtipoPrestamo.SelectedValue, "1", fechaActual, fecha_prestamo, fecha_devolucion, cmbficha.SelectedValue, cmbcategoria.SelectedValue}


            'llamamos la funcions
            datos = Insert_tblReservas(arreglo, "sp_tbl_reserva_insert")
            If datos = 1 Then
                'traemos el codigo de la reserva
                datos = selectTop1_tbl_reserva("sp_tbl_reserva_select_top1")

                tabla = New DataTable
                tabla = datos.tables("datos")

            End If

            'insertamos los elementos que hay en el datagrid a la tabla reserva elemento
            Dim fila = dgdatos.Rows.Count
            For i = 0 To fila - 1
                arreglo = {tabla(0)(0), dgdatos.Rows(i).Cells(2).Value, dgdatos.Rows(i).Cells(3).Value, dgdatos.Rows(i).Cells(4).Value}
                datos = Insert_tbl_reserva_elemento(arreglo, "sp_tbl_reserva_elemento_insert")
            Next

            'Si los datos se insertaron correctamenrte me muestra este mensaje
            If datos = 1 Then
                MsgBox("Se creo correctamente la reserva", vbInformation)
                limpiarcampos()
                CerrarPestañas()
                BajarNivel(frm_calendario)
                validar_reserva_hoy()
            End If
        Else
            MsgBox("Campos vacíos , por favor llene todos los campos ", vbInformation)
        End If
    End Sub

    Private Sub bntcancelar_Click_1(sender As Object, e As EventArgs) Handles bntcancelar.Click
        CerrarPestañas() 'cerramos la ventana
        limpiarcampos() 'limpiamos los campos del formulario
        BajarNivel(frm_calendario)
    End Sub


    Function limpiarcampos()
        'lipiamos todos los campos
        dgdatos.Rows.Clear()
        txtbuscador.Text = ""
        nmCantidad.Value = 1
        cmbficha.DataSource = Nothing
        cmbcategoria.DataSource = Nothing
        txtbuscadorficha.Text = ""
        i = 0
    End Function

    Private Sub cmbcategoria_GotFocus(sender As Object, e As EventArgs) Handles cmbcategoria.GotFocus
        'esta fucnion nos carga todos los registros de los clientes
        datos = CargarDatos("sp_tbl_categoria_reservas_select")
        tabla = New DataTable
        tabla = datos.tables("datos")

        'mostramos los datos en el combo box
        cmbcategoria.DataSource = tabla
        cmbcategoria.DisplayMember = "nombre"
        cmbcategoria.ValueMember = "codigo"


    End Sub

    Function pnlficha()
        'esta funcion la usuamos para ocultar o mostrar el panel para insertar la ficha
        If pnlinsert_ficha.Visible = True Then
            pnlinsert_ficha.Visible = False
        Else
            pnlinsert_ficha.Visible = True
            txtficha.Focus()
        End If
    End Function

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
                cmbficha.BorderColor = color.red
                cmbficha.Text = "Elemento no encontrado"

            End If
        Else

            cmbficha.Text = ""
            cmbficha.BorderColor = Color.Gray
            cmbficha.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtficha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtficha.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardarficha()
        End Select
    End Sub

    Private Sub txtprograma_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprograma.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardarficha()
        End Select
    End Sub

    Public Sub cmbcategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcategoria.SelectionChangeCommitted
        datos = delete_tbl_categoria_reserva(cmbcategoria.SelectedValue, "sp_tbl_categoria_reservas_selectPK", 1)
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Cambiamos el color del boton dependiendo el item selecionado del combobox
        btncolor.BaseColor = Color.FromArgb(tabla(0)(2))

        tope = tabla(0)(4)
    End Sub
End Class