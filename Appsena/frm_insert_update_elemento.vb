Imports System.Data
Public Class frm_insert_update_elemento
    Public datos, ruta, arreglo, codcentro, categoria, tipo_elemento, codmodelo,cantidad As Object

    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        'solo admite numeros
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub cmbtipoelemento_GotFocus(sender As Object, e As EventArgs) Handles cmbtipoelemento.GotFocus
        'Combobox el cual tiene los tipos de elementos
        datos = CargarDatos("sp_tbl_tipo_elemento_select")

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbtipoelemento.DataSource = tabla
        cmbtipoelemento.DisplayMember = "Nombre"
        cmbtipoelemento.ValueMember = "codigo"
    End Sub

    Private Sub cmbcategoria_GotFocus(sender As Object, e As EventArgs) Handles cmbcategoria.GotFocus
        'Combobox el cual tiene las categorias
        datos = CargarDatos("sp_tbl_categoria_select")

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbcategoria.DataSource = tabla
        cmbcategoria.DisplayMember = "Nombre"
        cmbcategoria.ValueMember = "codigo"
    End Sub

    Private Sub cmbmarca_GotFocus(sender As Object, e As EventArgs) Handles cmbmarca.GotFocus
        'Combobox el cual tiene las categorias
        datos = CargarDatos("sp_tbl_marca_select")

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbmarca.DataSource = tabla
        cmbmarca.DisplayMember = "nombre"
        cmbmarca.ValueMember = "codigo"
    End Sub

    Private Sub cmbmodelo_GotFocus(sender As Object, e As EventArgs) Handles cmbmodelo.GotFocus
        'mostramos en el combobox solo los modelos de la marca que se elija
        If cmbmarca.SelectedValue Is Nothing Then
            cmbmarca.Focus()
        Else
            datos = modelo_selectFK(cmbmarca.SelectedValue, "sp_tbl_modelo_selectFK")
            tabla = New DataTable
            tabla = datos.tables("datos")

            Dim filas = tabla.Rows.Count
            If filas > 0 Then
                cmbmodelo.DataSource = tabla
                cmbmodelo.DisplayMember = "nombre"
                cmbmodelo.ValueMember = "codigo"
            Else
                cmbmodelo.DataSource = Nothing
            End If
        End If
    End Sub

    Private Sub btnimagen_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        'MainForm.ShowDialog() 'Abrimos el formulario que enciende la camara

        'creamos una varible e instanciamos un nuevo open dialog

        Dim Ofdseleccionarimagen As New OpenFileDialog

        If Ofdseleccionarimagen.ShowDialog = DialogResult.OK Then
            ptbFotoelemento.Image = Image.FromFile(Ofdseleccionarimagen.FileName)
            ptbFotoelemento.SizeMode = PictureBoxSizeMode.StretchImage
            ruta = Ofdseleccionarimagen.FileName ''Guardamos la ruta de la foto en la variable ruta
        End If

    End Sub

    Function restaurar()
        lblheader.Text = "Registrar un nuevo elemento"
        'Centro
        cmbcentros.Visible = False
        txtcentro.Visible = False
        txtcentro.Text = ""
        'Codigo
        pnlcentro.Visible = False
        txtcodigo.Enabled = True
        txtcodigo.Text = ""

        'placa ,serial,nombre y ubicacion
        txtplaca.Text = ""
        txtserial.Text = ""
        txtnombre.Text = ""
        txtubicacion.Text = ""

        'Tipo elemento
        cmbtipoelemento.Visible = True
        txttipo_elemento.Text = ""
        txttipo_elemento.Visible = False
        linktipo_elemento.Visible = False

        'Categoria
        cmbcategoria.Visible = True
        txtcategoria.Text = ""
        txtcategoria.Visible = False
        linkcategoria.Visible = False

        'Marca y Modelo
        cmbmarca.Enabled = True
        btnmarca.Enabled = True
        cmbmodelo.Enabled = True
        btnmodelo.Enabled = True
        txtmarcas.Visible = False
        txtmarcas.Text = ""
        txtmodelos.Visible = False
        txtmodelos.Text = ""

        'Cantidad y disponible
        ncantidad.Value = 1
        ndisponible.Value = 1
        'Valor
        txtvalor.Text = ""
        'Observaciones
        txtobservaciones.Text = ""

        'Picturbox 
        ptbFotoelemento.Image = Nothing


        btnactualizar.Visible = False
        btnguardar.Visible = True
    End Function

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        CerrarPestañas()
        BajarNivel(frm_elementos)
        restaurar()
    End Sub



    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GunaPanel1.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GunaPanel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GunaPanel1.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================



    Private Sub btnmarca_Click(sender As Object, e As EventArgs) Handles btnmarca.Click
        'Ocultamos o hacemos vsible el panel
        If pnlinsert_marca.Visible = False Then
            pnlinsert_marca.Visible = True
            txtmarca.Focus()
        Else
            pnlinsert_marca.Visible = False
        End If
    End Sub

    Private Sub btnmodelo_Click(sender As Object, e As EventArgs) Handles btnmodelo.Click
        'Ocultamos o hacemos vsible el panel
        If pnlinsert_modelo.Visible = False Then
            pnlinsert_modelo.Visible = True
            txtmodelo.Focus()
        Else
            pnlinsert_modelo.Visible = False
        End If
    End Sub

    Private Sub frm_insert_update_elemento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcodigo.Focus()


        formu = 4 'indica en que formulario mostrar la foto

        'cargamos la informacion del centro actual
        datos = CargarDatos("sp_tbl_centroActual_select")
        tabla = New DataTable
        tabla = datos.tables("datos")
        codcentro = tabla(0)(0)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If ncantidad.Value < ndisponible.Value Then
            validacion_cantidades()
        Else
            'Guardar la imagen en una ruta establecida
            Try
                'Variable que guarda la ruta de la imagen

                'Valida si hay una imagen
                If ptbFotoelemento.Image Is Nothing Then
                    'El valor de la ruta es nulo cuando no hay imagen
                    ruta = DBNull.Value
                End If
            Catch ex As Exception
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ReDim arreglo(16)

            'Codigo
            If txtcodigo.Text = "" Then
                arreglo(0) = DBNull.Value
            Else
                arreglo(0) = txtcodigo.Text
            End If

            'Centro
            arreglo(1) = codcentro


            'PLaca
            If txtplaca.Text = "" Then
                arreglo(2) = DBNull.Value
            Else
                arreglo(2) = txtplaca.Text
            End If

            'Serial
            If txtserial.Text = "" Then
                arreglo(3) = DBNull.Value
            Else
                arreglo(3) = txtserial.Text
            End If

            'Nombre
            If txtnombre.Text = "" Then
                arreglo(4) = DBNull.Value
            Else
                arreglo(4) = txtnombre.Text
            End If

            'Codmodelo
            If cmbmodelo.SelectedValue Is Nothing Then
                arreglo(5) = DBNull.Value
            Else
                arreglo(5) = cmbmodelo.SelectedValue
            End If

            'Tipo_elemento
            If cmbtipoelemento.SelectedValue Is Nothing Then
                arreglo(6) = DBNull.Value
            Else
                arreglo(6) = cmbtipoelemento.SelectedValue
            End If

            'codcategoria
            If cmbcategoria.SelectedValue Is Nothing Then
                arreglo(7) = DBNull.Value
            Else
                arreglo(7) = cmbcategoria.SelectedValue
            End If

            'Ubicacion
            If txtubicacion.Text = "" Then
                arreglo(8) = DBNull.Value
            Else
                arreglo(8) = txtubicacion.Text
            End If

            'Foto
            arreglo(9) = ruta

            'observaciones
            If txtobservaciones.Text = "" Then
                arreglo(10) = DBNull.Value
            Else
                arreglo(10) = txtobservaciones.Text
            End If

            'fecha abquisicion
            If pickerfecha.Value.ToString Is Nothing Then
                arreglo(11) = DBNull.Value
            Else
                arreglo(11) = pickerfecha.Value.ToString
            End If

            'valor
            If txtvalor.Text = "" Then
                arreglo(12) = DBNull.Value
            Else
                arreglo(12) = txtvalor.Text
            End If

            'estado
            arreglo(13) = "1"

            'Cantidad
            If ncantidad.Value = 0 Then
                arreglo(14) = DBNull.Value
            Else
                arreglo(14) = ncantidad.Value
            End If

            'Disponible
            If ndisponible.Value = 0 Then
                arreglo(15) = DBNull.Value
            Else
                arreglo(15) = ndisponible.Value
            End If

            datos = insert_update_elemento(arreglo, "sp_tbl_elemento_insert")

            If datos = 0 Then
                MsgBox("Se guardo correctamente el elemento", vbInformation)
                'Actualizamos la tabla 
                With frm_elementos
                    .Reload(.anterior, .siguiente)
                End With
                restaurar()

                'Cerramos este formulario y abrimos el de elementos
                Me.Close()
                BajarNivel(frm_elementos)

            ElseIf datos = 1 Then
                MsgBox("El código del elemento ya existe, verifique de nuevo la información.", vbCritical)
            ElseIf datos = 2 Then
                MsgBox("Campos vacíos, por favor llene todos los campos obligatorios.", vbCritical)
            End If

        End If



    End Sub

    Private Sub frm_insert_update_elemento_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Ocualtamos los paneles 
        pnlinsert_modelo.Visible = False
        pnlinsert_marca.Visible = False
    End Sub

    Function guardar_marca()
        'enviamos los datos a la funcion para crear una nueva marca
        If txtmarca.Text = "" Then
            MsgBox("Por favor digite un nombre para marca que desea crear.", vbCritical)
        Else
            datos = insert_tbl_marca(txtmarca.Text, "sp_tbl_marca_insert")
            If datos = 1 Then
                MsgBox("Se guardó correctamente el registro.", vbInformation)
                pnlinsert_marca.Visible = False
            End If

        End If
    End Function

    Private Sub btnguardarmarca_Click(sender As Object, e As EventArgs) Handles btnguardarmarca.Click
        guardar_marca()
    End Sub

    Function guardar_modelo()
        'validamos y enviamos los datos a la funcion para crear un nuevo modelo
        If cmbmarca_panel.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una marca", vbCritical)
        Else
            arreglo = {txtmodelo.Text, cmbmarca_panel.SelectedValue}
            datos = insert_tbl_modelo(arreglo, "sp_tbl_modelo_insert")
            If datos = 1 Then
                MsgBox("Se guardó correctamente el registro.", vbInformation)
                pnlinsert_modelo.Visible = False
            End If

        End If
    End Function

    Private Sub btnguardarmodelo_Click(sender As Object, e As EventArgs) Handles btnguardarmodelo.Click
        guardar_modelo()
    End Sub


    Private Sub cmbmarca_panel_GotFocus(sender As Object, e As EventArgs) Handles cmbmarca_panel.GotFocus
        'Combobox el cual tiene las categorias
        datos = CargarDatos("sp_tbl_marca_select")

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbmarca_panel.DataSource = tabla
        cmbmarca_panel.DisplayMember = "nombre"
        cmbmarca_panel.ValueMember = "codigo"
    End Sub



    Private Sub txtmarca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmarca.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardar_marca()
        End Select

    End Sub


    Private Sub cmbmarca_panel_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbmarca_panel.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardar_modelo()
        End Select
    End Sub

    Private Sub txtmodelo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmodelo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardar_modelo()
        End Select
    End Sub

    Function validacion_cantidades()
        'Se Iguala en valor de cantidad y disponibles
        If ncantidad.Value < cantidad Then
            ncantidad.Value = cantidad
        Else
            ndisponible.Value = ncantidad.Value
        End If


    End Function

    Function combobox(cmb, txt)
        'Copn esta funcion ocultamos y hacemos  los controles
        cmb.Visible = True
        txt.Visible = False
    End Function


    Private Sub linkcategoria_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkcategoria.LinkClicked
        'llamamos la funcion para que nos mueste el combox
        combobox(cmbcategoria, txtcategoria)
        cmbcategoria.Focus()
        cmbcategoria.SelectedValue = categoria
    End Sub


    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        If ncantidad.Value < ndisponible.Value Then
            validacion_cantidades()
        Else
            'Guardar la imagen en una ruta establecida
            Try
                'Variable que guarda la ruta de la imagen

                'Valida si hay una imagen
                If ptbFotoelemento.Image Is Nothing Then
                    'El valor de la ruta es nulo cuando no hay imagen
                    ruta = DBNull.Value
                End If
            Catch ex As Exception
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ReDim arreglo(16)

            'Codigo
            If txtcodigo.Text = "" Then
                arreglo(0) = DBNull.Value
            Else
                arreglo(0) = txtcodigo.Text
            End If

            'Centro
            If cmbcentros.SelectedValue <> Nothing Then
                arreglo(1) = cmbcentros.SelectedValue
            Else
                arreglo(1) = codcentro
            End If

            'PLaca
            If txtplaca.Text = "" Then
                arreglo(2) = DBNull.Value
            Else
                arreglo(2) = txtplaca.Text
            End If

            'Serial
            If txtserial.Text = "" Then
                arreglo(3) = DBNull.Value
            Else
                arreglo(3) = txtserial.Text
            End If

            'Nombre
            If txtnombre.Text = "" Then
                arreglo(4) = DBNull.Value
            Else
                arreglo(4) = txtnombre.Text
            End If

            'Codmodelo
            arreglo(5) = codmodelo

            'Tipo_elemento
            If cmbtipoelemento.SelectedValue <> Nothing Then
                arreglo(6) = cmbtipoelemento.SelectedValue
            Else
                arreglo(6) = tipo_elemento
            End If

            'codcategoria
            If cmbcategoria.SelectedValue <> Nothing Then
                arreglo(7) = cmbcategoria.SelectedValue
            Else
                arreglo(7) = categoria
            End If

            'Ubicacion
            If txtubicacion.Text = "" Then
                arreglo(8) = DBNull.Value
            Else
                arreglo(8) = txtubicacion.Text
            End If

            'Foto
            arreglo(9) = ruta

            'observaciones
            If txtobservaciones.Text = "" Then
                arreglo(10) = DBNull.Value
            Else
                arreglo(10) = txtobservaciones.Text
            End If

            'fecha abquisicion
            If pickerfecha.Value.ToString Is Nothing Then
                arreglo(11) = DBNull.Value
            Else
                arreglo(11) = pickerfecha.Value.ToString
            End If

            'valor
            If txtvalor.Text = "" Then
                arreglo(12) = DBNull.Value
            Else
                arreglo(12) = txtvalor.Text
            End If

            'estado
            arreglo(13) = "1"

            'Cantidad
            If ncantidad.Value = 0 Then
                arreglo(14) = DBNull.Value
            Else
                arreglo(14) = ncantidad.Value
            End If

            'Disponible
            If ndisponible.Value = 0 Then
                arreglo(15) = DBNull.Value
            Else
                arreglo(15) = ndisponible.Value
            End If

            datos = insert_update_elemento(arreglo, "sp_tbl_elemento_update")


            If datos = 0 Then
                MsgBox("Se actualizo correctamente el elemento", vbInformation)
                'Actualizamos la tabla 
                With frm_elementos
                    .Reload(.anterior, .siguiente)
                End With
                restaurar()

                'Cerramos este formulario y abrimos el de elementos
                Me.Close()
                BajarNivel(frm_elementos)

            ElseIf datos = 1 Then
                MsgBox("El código del elemento ya existe, verifique de nuevo la información.", vbCritical)
            ElseIf datos = 2 Then
                MsgBox("Campos vacíos, por favor llene todos los campos obligatorios.", vbCritical)
            End If
        End If

    End Sub

    Private Sub linkcentro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkcentro.LinkClicked
        'llamamos la funcion para que nos mueste el combox
        combobox(cmbcentros, txtcentro)
        cmbcentros.Focus()
        cmbcentros.SelectedValue = codcentro

    End Sub

    Private Sub linktipo_elemento_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linktipo_elemento.LinkClicked
        'llamamos la funcion para que nos mueste el combox
        combobox(cmbtipoelemento, txttipo_elemento)
        cmbtipoelemento.Focus()
        cmbtipoelemento.SelectedValue = tipo_elemento
    End Sub

    Private Sub cmbcentros_GotFocus(sender As Object, e As EventArgs) Handles cmbcentros.GotFocus
        'Combobox el cual tiene los centros del sena
        datos = CargarDatos("sp_tbl_centro_select")

        tabla = New DataTable
        tabla = datos.tables("datos")


        cmbcentros.DataSource = tabla
        cmbcentros.DisplayMember = "nombre"
        cmbcentros.ValueMember = "codigo"
    End Sub

    Private Sub cmbtipoelemento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbtipoelemento.SelectionChangeCommitted
        If cmbtipoelemento.SelectedValue = 8 Then
            txtplaca.Text = ""
            txtserial.Text = ""
            txtplaca.Enabled = False
            txtserial.Enabled = False
        Else
            txtplaca.Enabled = True
            txtserial.Enabled = True
        End If
    End Sub


    Private Sub ncantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles ncantidad.KeyUp
        validacion_cantidades()
    End Sub

    Private Sub ncantidad_Click(sender As Object, e As EventArgs) Handles ncantidad.Click
        validacion_cantidades()
    End Sub
End Class