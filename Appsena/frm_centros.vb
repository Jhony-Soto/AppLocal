Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frm_centros
    Dim datos, arreglo, fila As Object

    Function reload()
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_centro_select")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        dgdatos.Columns(2).Visible = False
    End Function
    Private Sub frm_centros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
        txtcentro.Focus()

    End Sub

    Function insertar()
        'validamos que los campos esten llenos
        If txtcodigo.Text = "" Or txtcentro.Text = "" Or cmbciudad.SelectedValue Is Nothing Then
            MsgBox("Debes llenar todos los campos", vbCritical)
        Else
            'mandamos los datos y el procedimiento a la funcion para crear un nuevo centro
            arreglo = {txtcodigo.Text, txtcentro.Text, cmbciudad.SelectedValue}
            insert_update_delete_tbl_centros(arreglo, "sp_tbl_centros_insert", "Guardo")
            limpiarcampos()
            reload()
        End If
    End Function

    Function actualizar()
        'validamos que los campos esten llenos
        If txtcodigo.Text = "" Or txtcentro.Text = "" Or cmbciudad.SelectedValue Is Nothing Then
            MsgBox("Debes llenar todos los campos", vbCritical)
        Else
            'mandamos los datos y el procedimiento a la funcion para crear un nuevo centro
            arreglo = {txtcodigo.Text, txtcentro.Text, cmbciudad.SelectedValue}
            insert_update_delete_tbl_centros(arreglo, "sp_tbl_centros_update", "Actualizo")
            limpiarcampos()
            btnactualiazar.Visible = False
            btnguardar.Visible = True
            reload()
        End If
    End Function

    Function limpiarcampos()
        txtcentro.Text = ""
        txtcodigo.Text = ""
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        insertar()
    End Sub

    Private Sub txtcentro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcentro.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If btnactualiazar.Visible = False Then
                    insertar()
                Else
                    actualizar()
                End If

        End Select
    End Sub

    Private Sub btnactualiazar_Click(sender As Object, e As EventArgs) Handles btnactualiazar.Click
        actualizar()
    End Sub



    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        fila = dgdatos.CurrentRow.Index
        'llevamos los valores de donde se dio el doble click al los campos de texto
        txtcodigo.Text = dgdatos.Rows(fila).Cells(0).Value
        txtcentro.Text = dgdatos.Rows(fila).Cells(1).Value

        btnactualiazar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub cmbciudad_GotFocus(sender As Object, e As EventArgs) Handles cmbciudad.GotFocus
        If cmbdepartamento.SelectedValue Is Nothing Then
            cmbdepartamento.Select()
        Else
            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            datos = cargar_ciudad(cmbdepartamento.SelectedValue, "sp_tbl_ciudad_select")
            'los datos que recivimos de la funcion los mostramos en el datagrid
            tabla = New DataTable
            tabla = datos.tables("datos")

            cmbciudad.DataSource = tabla
            cmbciudad.DisplayMember = "nombre"
            cmbciudad.ValueMember = "codigo"
        End If
    End Sub

    Private Sub cmbdepartamento_GotFocus(sender As Object, e As EventArgs) Handles cmbdepartamento.GotFocus
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_departamento_selct")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbdepartamento.DataSource = tabla
        cmbdepartamento.DisplayMember = "nombre"
        cmbdepartamento.ValueMember = "codigo"
    End Sub
End Class