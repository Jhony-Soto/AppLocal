Public Class frm_rutas
    Dim datos, arreglo, ruta As Object
    Private Sub frm_rutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()

    End Sub

    Function reload()
        'Obtenemos los datos del las rutas
        datos = CargarDatos("sp_tbl_configuracion_select")

        'los datos que recivimos de la funcion los convetimos a una tabla
        tabla = New DataTable
        tabla = datos.tables("datos")

        txtpermisos.Text = tabla(0)(1)
        txtelementos.Text = tabla(0)(2)
        txtclientes.Text = tabla(0)(3)
        txtadministradores.Text = tabla(0)(4)
        txtpdf.Text = tabla(0)(5)
        txt_salidas.Text = tabla(0)(11)
        txt_seguros.Text = tabla(0)(12)

        txtpermisos.Enabled = False
        txtelementos.Enabled = False
        txtclientes.Enabled = False
        txtadministradores.Enabled = False
        txtpdf.Enabled = False
        txt_salidas.Enabled = False
        txt_seguros.Enabled = False
    End Function

    Function abilitar(control)
        'Conn esta duncion habilitamos el control que nos envien
        control.Enabled = True
    End Function

    Function filedialog(texbox)
        Dim carpeta As New FolderBrowserDialog

        If carpeta.ShowDialog = DialogResult.OK Then
            ruta = carpeta.SelectedPath ''Guardamos la ruta de la foto en la variable ruta
            texbox.text = ruta & "\"
        End If
    End Function

    Private Sub linkclientes_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkclientes.LinkClicked
        'Obtenemos la ruta de la carpeta
        filedialog(txtclientes)
    End Sub

    Private Sub linkadministradores_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkadministradores.LinkClicked
        filedialog(txtadministradores)
    End Sub

    Private Sub linkpermisos_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkpermisos.LinkClicked
        filedialog(txtpermisos)
    End Sub

    Private Sub linkpdf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkpdf.LinkClicked
        filedialog(txtpdf)
    End Sub

    Private Sub link_seguros_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_seguros.LinkClicked
        filedialog(txt_seguros)
    End Sub

    Private Sub link_salidas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_salidas.LinkClicked
        filedialog(txt_salidas)
    End Sub

    Private Sub linkelementos_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkelementos.LinkClicked
        filedialog(txtelementos)
    End Sub

    Private Sub btnguardar_Click_1(sender As Object, e As EventArgs) Handles btnguardar.Click
        'Validamos que ninguno de los campos esten vacios
        If txtpermisos.Text = "" Or txtelementos.Text = "" Or txtclientes.Text = "" Or txtadministradores.Text = "" Or txtpdf.Text = "" Then
            MsgBox("Algunos campos están vacíos. Por favor asegúrese de llenar cada uno de ellos.", vbCritical)
        Else
            arreglo = {txtpermisos.Text, txtelementos.Text, txtclientes.Text, txtadministradores.Text, txtpdf.Text, txt_salidas.Text, txt_seguros.Text}
            Update_tbl_configuracion_rutas(arreglo, "sp_tbl_configuracion_update")
            reload()
        End If
    End Sub

End Class