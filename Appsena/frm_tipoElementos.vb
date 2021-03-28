Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frm_tipoElementos
    Public datos, codelemento, fila As Object
    Private Sub frm_tipoElementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtelemento.Focus()
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_tipo_elemento_select")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Ocultamos la columna del codigo
        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(2).Visible = False

    End Sub
    Private Function guardar()
        'validamos si el campo esta vacio
        If txtelemento.Text = "" Then
            MsgBox("¡Campo vacío !", vbInformation)
            txtelemento.Focus()
        Else
            datos = {txtelemento.Text, "1"}
            'llammos al funcion que hace el insert y le mandamos dos parametros (el nombre de nuevo registro y la consulta)
            Insert_tipos(datos, "sp_tbl_tipo_elemento_insert", "el Tipo de elemento")

            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            frm_tipoElementos_Load(Nothing, Nothing)

            txtelemento.Text = ""

        End If
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        guardar() 'llamamos la funcion guardar

    End Sub
    Private Function actualizar()
        'validamos si el campo esta vacio
        If txtelemento.Text = "" Then
            MsgBox("¡Campo vacío !", vbInformation)
            txtelemento.Focus()
        Else
            'Creamos el arreglo con los datos que pide la funcion
            datos = {codelemento, txtelemento.Text}
            'Llamamos la funcion que nos actualizara el registro y le pasamos los datos
            Update_tipos(datos, "sp_tbl_tipo_elemento_update", "el tipo de elemento")

            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            frm_tipoElementos_Load(Nothing, Nothing)

            btnactualiazar.Visible = False
            btnguardar.Visible = True

            txtelemento.Text = ""



        End If
    End Function
    Private Sub btnactualiazar_Click(sender As Object, e As EventArgs) Handles btnactualiazar.Click
        actualizar() 'llamamos la funcion actualizar
    End Sub

    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'Con doble clck en el datagrid abilitamos la opcion de actualizar el registro
        btnguardar.Visible = False 'ocultmos el boton de guardar
        btnactualiazar.Visible = True 'mostrsms el boton de actualizar
        Dim fila = dgdatos.CurrentRow.Index ' indexamos la fila donde se hizo el dobleclick
        codelemento = dgdatos.Rows(fila).Cells(0).Value 'ingresamos en la variable el codigo del registro
        txtelemento.Text = dgdatos.Rows(fila).Cells(1).Value 'ingresamos en la variable el codigo del registro
    End Sub

    Private Sub txtelemento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtelemento.KeyDown
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