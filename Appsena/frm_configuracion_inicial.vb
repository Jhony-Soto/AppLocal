Public Class frm_configuracion_inicial
    Dim datos, arreglo, ruta As Object
    Private Sub frm_configuracion_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.Show()
    End Sub
    Function limpiardatos()
        cmbciudad.DataSource = Nothing
        cmbcentro.DataSource = Nothing
    End Function

    Private Sub cmbcentro_GotFocus(sender As Object, e As EventArgs) Handles cmbcentro.Click
        If cmbciudad.SelectedValue Is Nothing Then
            cmbciudad.Select()
        Else
            'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
            datos = cargar_centros(cmbciudad.SelectedValue, "sp_tbl_centro_selectFK")
            'los datos que recivimos de la funcion los mostramos en el datagrid
            tabla = New DataTable
            tabla = datos.tables("datos")

            cmbcentro.DataSource = tabla
            cmbcentro.DisplayMember = "nombre"
            cmbcentro.ValueMember = "codigo"
        End If
    End Sub

    Private Sub cmbciudad_GotFocus(sender As Object, e As EventArgs) Handles cmbciudad.Click
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


    Function filedialog(txt)
        Dim carpeta As New FolderBrowserDialog

        If carpeta.ShowDialog = DialogResult.OK Then
            ruta = carpeta.SelectedPath
            txt.text = ruta & "\"
        End If

    End Function

    Private Sub linkclientes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkclientes.LinkClicked
        filedialog(txtclientes)
    End Sub

    Private Sub linkadmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkadmin.LinkClicked
        filedialog(txtadministradores)
    End Sub

    Private Sub linkpermisos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkpermisos.LinkClicked
        filedialog(txtpermisos)
    End Sub

    Private Sub linkpdf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkpdf.LinkClicked
        filedialog(txtpdf)
    End Sub

    Private Sub btncontinuar_Click(sender As Object, e As EventArgs) Handles btncontinuar.Click
        'validamos que los campos no esten vacios
        If cmbcentro.SelectedValue Is Nothing Or txtelementos.Text = "" Or txtclientes.Text = "" Or txtadministradores.Text = "" Or txtpermisos.Text = "" Or txtpdf.Text = "" Or txt_salidas.Text = "" Or txt_seguros.Text = "" Then
            MsgBox("Se encontraron campos vacíos, debe llenar todos los campos de esta ventana.", vbCritical)
        Else
            'caundo se cumpla la condicion guardamos la informacion
            'Guardamos los datos del centro
            arreglo = {cmbcentro.SelectedValue, cmbcentro.Text}
            insert_tbl_centroActual(arreglo, "sp_tbl_centroActual_insert")
            CodCentro = cmbcentro.SelectedValue

            'guardarmps las rutas
            arreglo = {txtpermisos.Text, txtelementos.Text, txtclientes.Text, txtadministradores.Text, txtpdf.Text, txtbackup.Text, txt_salidas.Text, txt_seguros.Text}
            insert_tbl_configuracion_rutas(arreglo, "sp_tbl_configuracion_insert")
            frm_login.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        filedialog(txtbackup)
    End Sub

    Private Sub linkelementos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkelementos.LinkClicked
        filedialog(txtelementos)
    End Sub


    Private Sub cmbdepartamento_GotFocus(sender As Object, e As EventArgs) Handles cmbdepartamento.Click
        ''limpiardatos()
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_departamento_selct")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbdepartamento.DataSource = tabla
        cmbdepartamento.DisplayMember = "nombre"
        cmbdepartamento.ValueMember = "codigo"
    End Sub

    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer

    Private Sub link_salidas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_salidas.LinkClicked
        filedialog(txt_salidas)
    End Sub

    Private Sub link_seguros_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_seguros.LinkClicked
        filedialog(txt_seguros)
    End Sub

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
End Class