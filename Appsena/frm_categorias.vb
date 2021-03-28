Public Class frm_categorias
    Dim datos, arreglo, codcategoria As Object

    Function reload()
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_categoria_select")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(2).Visible = False
    End Function
    Private Sub frm_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
        txtcategoria.Focus()
    End Sub

    Function insert()
        If txtcategoria.Text <> "" Then
            arreglo = {txtcategoria.Text, "1"}
            insert_categorias(arreglo, "sp_tbl_categoria_insert", "guardo")
            limpiar()
            reload() 'recargamos el formulario
        Else
            MsgBox("Algunos campos están vacíos ,por favor complete la información", vbCritical)
        End If
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        insert()
    End Sub

    Function limpiar()
        txtcategoria.Text = ""
    End Function

    Function update()
        If txtcategoria.Text <> "" Then
            arreglo = {codcategoria, txtcategoria.Text, "1"}
            update_categoria(arreglo, "sp_tbl_categoria_update", "actualizo")
            btnactualiazar.Visible = False
            btnguardar.Visible = True
            limpiar()
            reload() 'recargamos el formulario
        Else
            MsgBox("Algunos campos están vacíos ,por favor complete la información", vbCritical)
        End If
    End Function
    Private Sub btnactualiazar_Click(sender As Object, e As EventArgs) Handles btnactualiazar.Click
        update()
    End Sub

    Private Sub txtcategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcategoria.KeyDown
        'Este codigo es para usar el enter y llama la funcion dependiendo de lo que si quiere hacer
        Select Case e.KeyCode
            Case Keys.Enter
                If btnguardar.Visible = True Then
                    insert() 'guarda un resgistro
                Else
                    update() 'actualiza el registro
                End If
        End Select
    End Sub

    Private Sub ntope_KeyDown(sender As Object, e As KeyEventArgs)
        'Este codigo es para usar el enter y llama la funcion dependiendo de lo que si quiere hacer
        Select Case e.KeyCode
            Case Keys.Enter
                If btnguardar.Visible = True Then
                    insert() 'guarda un resgistro
                Else
                    update() 'actualiza el registro
                End If
        End Select
    End Sub


    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'Con doble clck en el datagrid abilitamos la opcion de actualizar el registro
        btnguardar.Visible = False 'ocultmos el boton de guardar
        btnactualiazar.Visible = True 'mostrsms el boton de actualizar
        Dim fila = dgdatos.CurrentRow.Index ' indexamos la fila donde se hizo el dobleclick
        codcategoria = dgdatos.Rows(fila).Cells(0).Value 'ingresamos en la variable el codigo del registro
        txtcategoria.Text = dgdatos.Rows(fila).Cells(1).Value 'ingresamos en la variable el codigo del registro
    End Sub
End Class