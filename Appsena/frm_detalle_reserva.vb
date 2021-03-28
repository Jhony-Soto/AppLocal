Public Class frm_detalle_reserva
    Public datos, arreglo, observaciones, fila, swift, tope, codficha, categoria As Object
    Public fecha_devolucion As Date
    Public fecha_hoy As DateTime = DateTime.Today
    Dim i = 0

    Private Sub bntcancelar_Click(sender As Object, e As EventArgs) Handles bntcancelar.Click

        If MsgBox("¿Está seguro que desea cancelar esta reserva?", vbInformation + vbYesNo) = vbYes Then
            'Si la respuesta es si se llama la funcion que cambiara el estado de la reserva a 0.
            Dim fecha_prestamo As Date = pickerfecha_prestamo.Value.Date & " " & picker_hora.Value.Hour & ":" & picker_hora.Value.Minute
            fecha_devolucion = pickerfecha_prestamo.Value.Date & " " & picker_hora_devolucion.Value.Hour & ":" & picker_hora_devolucion.Value.Minute

            arreglo = {codreserva, codcliente, tipo_prestamo, "2", fecha_reserva.Value, fecha_prestamo, fecha_devolucion, codficha, categoria, SESSION(0)} 'creamos el arreglo que enviaremos ala funcion

            datos = Update_tblReservas(arreglo, "sp_tbl_reserva_update")
            'si la funcion me devuelve un 1 significa que si se cambio el estado
            If datos = 1 Then
                MsgBox("Se canceló la reserva", vbInformation)
                CerrarPestañas() 'cerramos la ventana
                limpiarcampos() 'limpiamos los campos del formulario
                BajarNivel(frm_calendario)

                validar_reserva_hoy()
            End If
        End If

    End Sub

    Function limpiarcampos()
        'lipiamos todos los campos
        dgdatos.Rows.Clear()
        txtbuscador.Text = ""
        nmCantidad.Value = 1
        cmbficha.DataSource = Nothing
        cmbcategoria.DataSource = Nothing
        txtbuscadorficha.Text = ""

        cmbcategoria.Visible = False
        txtcategoria_reserva.Visible = True

        cmbtipoPrestamo.Visible = False
        txttipo_prestamo.Visible = True
        i = 0
    End Function


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



    Private Sub frm_detalle_reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcategoria_comitted()


        datos = Reserva_elemento_PK(codreserva, "sp_reserva_elemento_selectPK") 'Consultamos los alementos de la reserva
        tabla = New DataTable
        tabla = datos.tables("datos")

        fila = tabla.Rows.Count

        'Llebamos el datagrid con los elemetntos de la reserva
        For i = 0 To fila - 1
            dgdatos.Rows.Add()
            dgdatos.Rows(i).Cells(2).Value = tabla(i)(1)
            dgdatos.Rows(i).Cells(3).Value = tabla(i)(2)
            dgdatos.Rows(i).Cells(4).Value = tabla(i)(3)
        Next
    End Sub

    Private Sub btnregrsar_Click(sender As Object, e As EventArgs) Handles btnregrsar.Click
        CerrarPestañas() 'cerramos la ventana
        limpiarcampos() 'limpiamos los campos del formulario
        BajarNivel(frm_calendario)
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Dim filas = dgdatos.RowCount

        If cmbtipoPrestamo.SelectedValue <> Nothing Then
            tipo_prestamo = cmbtipoPrestamo.SelectedValue
        End If

        If cmbficha.SelectedValue <> Nothing Then
            codficha = cmbficha.SelectedValue
        End If

        If cmbcategoria.SelectedValue <> Nothing Then
            categoria = cmbcategoria.SelectedValue
        End If


        If filas <> 0 And tipo_prestamo <> Nothing Then
            'llenamos en arreglo con la informcion que enviaremos ala funcion para crear la reserva
            Dim fecha_prestamo As Date = pickerfecha_prestamo.Value.Date & " " & picker_hora.Value.Hour & ":" & picker_hora.Value.Minute
            fecha_devolucion = pickerfecha_prestamo.Value.Date & " " & picker_hora_devolucion.Value.Hour & ":" & picker_hora_devolucion.Value.Minute

            arreglo = {codreserva, codcliente, tipo_prestamo, "1", fecha_reserva.Value, fecha_prestamo, fecha_Devolucion, codficha, categoria, SESSION(0)}

            'llamamos la funcion que actualiza la reserva
            datos = Update_tblReservas(arreglo, "sp_tbl_reserva_update")
                If datos = 1 Then

                    'eliminamos esos registros de la bd
                    For j = 0 To filas - 1
                        datos = reserva_elemento_delete(codreserva, "sp_reserva_elemento_delete")
                    Next



                    'insertamos los elementos que hay en el datagrid a la tabla reserva elemento
                    Dim fila = dgdatos.Rows.Count
                    For i = 0 To fila - 1
                        If dgdatos.Rows(i).Cells(4).Value Is Nothing Then
                            dgdatos.Rows(i).Cells(4).Value = DBNull.Value
                        End If
                        arreglo = {codreserva, dgdatos.Rows(i).Cells(2).Value, dgdatos.Rows(i).Cells(3).Value, dgdatos.Rows(i).Cells(4).Value}
                        datos = Insert_tbl_reserva_elemento(arreglo, "sp_tbl_reserva_elemento_insert")
                    Next

                    'Si los datos se insertaron correctamenrte me muestra este mensaje
                    If datos = 1 Then
                        limpiarcampos()
                        CerrarPestañas()
                        BajarNivel(frm_calendario)
                        validar_reserva_hoy()
                    End If


                End If

        Else
            MsgBox("Algunos campos aun estan vacios", vbCritical)
        End If
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

    Private Sub dgdatos_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick
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


    Private Sub cmbtipoPrestamo_GotFocus(sender As Object, e As EventArgs) Handles cmbtipoPrestamo.GotFocus

        datos = CargarDatos("sp_tbl_tipo_prestamos_select") 'esta fucnion nos carga todos los registros de los clientes
        tabla = New DataTable
        tabla = datos.tables("datos")

        'mostramos los datos en el combo box
        cmbtipoPrestamo.DataSource = tabla
        cmbtipoPrestamo.DisplayMember = "nombre"
        cmbtipoPrestamo.ValueMember = "codigo"
    End Sub

    Private Sub linkcategoria_reserva_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkcategoria_reserva.LinkClicked
        cmbcategoria.Visible = True
        txtcategoria_reserva.Visible = False
        cmbcategoria.Select()
        cmbcategoria.SelectedValue = categoria

    End Sub

    Private Sub linktio_prestamo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linktio_prestamo.LinkClicked

        cmbtipoPrestamo.Visible = True
        txttipo_prestamo.Visible = False
        cmbtipoPrestamo.Select()
        cmbtipoPrestamo.SelectedValue = tipo_prestamo

    End Sub

    Private Sub txtbuscador_KeyDown(sender As Object, e As KeyEventArgs)
        'este codigo es para que funcione el enter
        Select Case e.KeyCode
            Case Keys.Enter
                agregar()
        End Select
    End Sub

    Private Sub nmCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles nmCantidad.KeyDown
        'este codigo es para que funcione el enter
        Select Case e.KeyCode
            Case Keys.Enter
                agregar()
        End Select
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

            End If
        Else

            cmbficha.Text = ""
            cmbficha.BorderColor = Color.Gray
            cmbficha.ForeColor = Color.Black
        End If
    End Sub

    Public Sub cmbcategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcategoria.SelectionChangeCommitted
        categoria = cmbcategoria.SelectedValue
    End Sub

    Function cmbcategoria_comitted()

        datos = delete_tbl_categoria_reserva(categoria, "sp_tbl_categoria_reservas_selectPK", 1)
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Cambiamos el color del boton dependiendo el item selecionado del combobox
        btncolor.BaseColor = Color.FromArgb(tabla(0)(2))

        tope = tabla(0)(4)
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
End Class