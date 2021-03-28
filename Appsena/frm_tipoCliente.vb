Public Class frm_tipoCliente

    Public datos, codocumento, fila As Object
    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'Con doble clck en el datagrid abilitamos la opcion de actualizar el registro
        btnguardar.Visible = False 'ocultmos el boton de guardar
        btnactualiazar.Visible = True 'mostrsms el boton de actualizar
        Dim fila = dgdatos.CurrentRow.Index ' indexamos la fila donde se hizo el dobleclick
        codocumento = dgdatos.Rows(fila).Cells(0).Value 'ingresamos en la variable el codigo del registro
        txtcliente.Text = dgdatos.Rows(fila).Cells(1).Value 'ingresamos en la variable el codigo del registro
    End Sub


    Private Sub frm_tipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcliente.Focus()
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_tipo_cliente_select")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Ocultamos la columna del codigo
        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(2).Visible = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        guardar() 'llamamos la funcion guardar
    End Sub

    Private Function guardar()
        'validamos si el campo esta vacio
        If txtcliente.Text = "" Then
            MsgBox("¡Campo vacío !", vbInformation)
            txtcliente.Focus()
        Else
            datos = {txtcliente.Text, "1"}
            'llammos al funcion que hace el insert y le mandamos dos parametros (el nombre de nuevo registro y la consulta)
            Insert_tipos(datos, "sp_tbl_tipo_cliente_insert", "el Tipo de cliente")

            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            frm_tipoDocumento_Load(Nothing, Nothing)

            txtcliente.Text = ""

        End If
    End Function

    Private Function actualizar()
        'validamos si el campo esta vacio
        If txtcliente.Text = "" Then
            MsgBox("¡Campo vacío !", vbInformation)
            txtcliente.Focus()
        Else
            'Creamos el arreglo con los datos que pide la funcion
            datos = {codocumento, txtcliente.Text}
            'Llamamos la funcion que nos actualizara el registro y le pasamos los datos
            Update_tipos(datos, "sp_tbl_tipo_cliente_update", "el tipo de documento")

            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            frm_tipoDocumento_Load(Nothing, Nothing)

            btnactualiazar.Visible = False
            btnguardar.Visible = True

            txtcliente.Text = ""

        End If
    End Function

    Private Sub btnactualiazar_Click(sender As Object, e As EventArgs) Handles btnactualiazar.Click
        actualizar() 'llamamos la funcion actualizar
    End Sub

    Private Sub txtcliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente.KeyDown
        'Este codigo es para usar el enter y llama la funcion dependiendo de lo que si quiere hacer
        Select Case e.KeyCode
            Case Keys.Enter
                If btnguardar.Visible = True Then
                    guardar() 'guarda un resgistro
                Else
                    actualizar() 'actualiza el registro
                End If

        End Select
    End Sub
End Class