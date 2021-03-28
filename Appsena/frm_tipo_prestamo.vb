Public Class frm_tipo_prestamo
    Public datos As Object
    Public codtipo_prestamo, array, fila As Object

    Private Function guardar()
        'validamos si el campo esta vacio
        If txttipoprestamo.Text = "" Then
            MsgBox("¡Campo vacío !", vbInformation)
            txttipoprestamo.Focus()
        Else
            array = {txttipoprestamo.Text, "1"}
            'llammos al funcion que hace el insert y le mandamos dos parametros (el nombre de nuevo registro y la consulta)
            Insert_tipos(array, "sp_tipo_prestamo_insert", "el Tipo de Prestamo")

            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            frm_tipo_prestamo_Load(Nothing, Nothing)

            txttipoprestamo.Text = ""

        End If
    End Function
    Private Sub btntipoprestamo_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        guardar()
    End Sub

    Private Sub frm_tipo_prestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttipoprestamo.Focus()
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_tipo_prestamos_select")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Ocultamos la columna del codigo
        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(2).Visible = False

    End Sub

    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'Con doble clck en el datagrid abilitamos la opcion de actualizar el registro
        btnguardar.Visible = False 'ocultmos el boton de guardar
        btnactualiazar.Visible = True 'mostrsms el boton de actualizar
        fila = dgdatos.CurrentRow.Index ' indexamos la fila donde se hizo el dobleclick
        codtipo_prestamo = dgdatos.Rows(fila).Cells(0).Value 'ingresamos en la variable el codigo del registro
        txttipoprestamo.Text = dgdatos.Rows(fila).Cells(1).Value 'ingresamos en la variable el codigo del registro
    End Sub

    Private Function actualizar()
        'validamos si el campo esta vacio
        If txttipoprestamo.Text = "" Then
            MsgBox("¡Campo vacío !", vbInformation)
            txttipoprestamo.Focus()
        Else
            'Creamos el arreglo con los datos que pide la funcion
            datos = {codtipo_prestamo, txttipoprestamo.Text}
            'Llamamos la funcion que nos actualizara el registro y le pasamos los datos
            Update_tipos(datos, "sp_tipo_prestamo_update", "el tipo de prestamo")

            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            frm_tipo_prestamo_Load(Nothing, Nothing)
            btnguardar.Visible = True 'ocultmos el boton de guardar
            btnactualiazar.Visible = False
        End If
    End Function
    Private Sub btnactualiazar_Click(sender As Object, e As EventArgs) Handles btnactualiazar.Click
        actualizar()
    End Sub

    Private Sub txttipoprestamo_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoprestamo.KeyDown
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