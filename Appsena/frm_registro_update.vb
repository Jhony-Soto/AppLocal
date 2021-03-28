Imports System.IO

Public Class frm_registro_update
    Public sql, datos, arreglo, ruta, codficha, tipo_cliente, VCmb(4), ficha, SWEdit, sincronizado As Object
    Public swift As Byte
    Dim fecha_actual As DateTime = DateTime.Today

    Private Sub cmbtipo_documento_GotFocus(sender As Object, e As EventArgs) Handles cmbtipo_documento.GotFocus
        'Combobox el cual tiene los tipos de documentos utlizando la funcion cargardatos que nos devuelve los datos de la consulta
        sql = "sp_tbl_tipo_documento_select"
        datos = CargarDatos(sql)

        'creamos una tabla y la llenamos con los datos del dataset
        tabla = New DataTable
        tabla = datos.tables("datos")

        'llenamos el combobox
        cmbtipo_documento.DataSource = tabla
        cmbtipo_documento.DisplayMember = "nombre"
        cmbtipo_documento.ValueMember = "codigo"
    End Sub

    Private Sub btnimagen_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        swift = 1

        MainForm.ShowDialog() 'este formulario me abre la camara del dispositivo

    End Sub

    Private Sub frm_registro_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formu = 3 'indica que formulario se mostrara la foto
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'Guardar la imagen en una ruta establecida
        If ptbFotocliente.Image Is Nothing Then
            ruta = DBNull.Value
        Else
            Dim RutaFoto As Object 'Variable que trae la ruta de la carpeta donde se guarda la imagen
            Dim RutaF As String 'Variable que guarda la imagen en el equipo
            RutaFoto = RutaFotos()
            RutaF = RutaFotos.rows(0)(3) & txtdocumento.Text & "_Foto_Cliente" & ".jpg"
            ruta = RutaF
            'Se elimina la imagen anterior
            If File.Exists(RutaF) Then
                My.Computer.FileSystem.DeleteFile(RutaF)
            End If
            Dim SaveImage As New Bitmap(ptbFotocliente.Image)
            SaveImage.Save(ruta, Imaging.ImageFormat.Jpeg)
            SaveImage.Dispose()
        End If



        ReDim arreglo(16)

        'validamos que los campos este llenos

        'CC
        If txtdocumento.Text = "" Then
            arreglo(0) = DBNull.Value
        Else
            arreglo(0) = txtdocumento.Text
        End If

        'Nombres
        If txtnombres.Text = "" Then
            arreglo(1) = DBNull.Value
        Else
            arreglo(1) = txtnombres.Text
        End If

        'Apellidos
        If txtapellidos.Text = "" Then
            arreglo(2) = DBNull.Value
        Else
            arreglo(2) = txtapellidos.Text
        End If

        'ficha
        If cmbficha.SelectedValue Is Nothing Then
            arreglo(3) = codficha
        Else
            arreglo(3) = cmbficha.SelectedValue
        End If


        'Email
        If txtemail.Text = "" Then
            arreglo(4) = DBNull.Value
        Else
            arreglo(4) = txtemail.Text
        End If


        'telefono
        If txtmovil.Text = "" Then
            arreglo(5) = DBNull.Value
        Else
            arreglo(5) = txtmovil.Text
        End If


        'fecha
        arreglo(6) = fecha_actual

        'tipo de cliente
        If cmbtipocliente.SelectedValue Is Nothing Then
            arreglo(7) = DBNull.Value
        Else
            arreglo(7) = cmbtipocliente.SelectedValue
        End If



        'foto
        arreglo(8) = ruta

        'huellas
        arreglo(9) = DBNull.Value
        arreglo(10) = DBNull.Value
        arreglo(11) = DBNull.Value

        'sincronizacion
        arreglo(12) = "0"



        'tipo documento
        If cmbtipo_documento.SelectedValue Is Nothing Then
            arreglo(13) = DBNull.Value
        Else
            arreglo(13) = cmbtipo_documento.SelectedValue
        End If

        'estado
        arreglo(14) = "1"

        'Insertamos la informacion en la tabla_cliente

        datos = Insert_Update_tbl_cliente(arreglo, "sp_tbl_cliente_insert")
        If datos = 1 Then
            MsgBox("Se guardo correctamente el registro !", vbInformation)
            limpiarcampos()
            'recargamos el formulario de clientes para mostrar los cambios
            With frm_clientes
                .Reload(.anterior, .siguiente)
            End With

            Me.Close()
        End If

        If datos = 2627 Then


            datos = inactivos_activar_cliente(txtdocumento.Text, "sp_tbl_cliente_inactivos", 0)
            tabla = New DataTable
            tabla = datos.tables("datos")

            Dim filas = tabla.Rows.Count
            If filas > 0 Then
                If MessageBox.Show("Ya existe un cliente con este número de documento el cual fue eliminado." & vbLf & " Desea volver a habilitarlo?", "El cliente ya existe.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    inactivos_activar_cliente(txtdocumento.Text, "sp_tbl_cliente_activar", 1)
                    limpiarcampos()
                    Me.Close()
                    With frm_clientes
                        .Reload(.anterior, .siguiente)
                    End With
                End If
            Else
                MsgBox("Ya existe un cliente con este número de documento", vbCritical)
            End If



        Else
            If datos = 515 Then
                MsgBox("Por favor llene todos los campos obligatorios!", vbCritical)
            Else
                If datos = 814 Then
                    MsgBox("Los tipos de datos no corresponden , por favor revizar", vbCritical)
                End If
            End If
        End If

        ReDim arreglo(0)



    End Sub

    Function limpiarcampos()
        cmbtipocliente.Text = ""
        codficha = DBNull.Value
        txtnombres.Text = ""
        txtapellidos.Text = ""
        txtemail.Text = ""
        txtmovil.Text = ""
        cmbtipo_documento.Text = ""
        txtdocumento.Text = ""
        txtbuscador.Text = ""
        ptbFotocliente.Image = Nothing
        lblheader.Text = "Registro de un nuevo cliente."
        btnguardar.Visible = True
        btnactualizar.Visible = False
        txtdocumento.Enabled = True 'inabilitamos el texbox del documento
        cmbficha.Text = ""
        txtbuscador.Enabled = True
        cmbficha.Enabled = True
        cmbficha.DataSource = Nothing
        txttipo_cliente.Visible = False
        txttipo_cliente.Text = ""
        cmbtipocliente.Enabled = True
        linktipo_cliente.Visible = False
    End Function

    Private Sub cmbtipocliente_GotFocus(sender As Object, e As EventArgs) Handles cmbtipocliente.GotFocus
        'Combobox el cual tiene los tipos de documentos utlizando la funcion cargardatos que nos devuelve los datos de la consulta
        sql = "sp_tbl_tipo_cliente_select"
        datos = CargarDatos(sql)

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbtipocliente.DataSource = tabla
        cmbtipocliente.DisplayMember = "nombre"
        cmbtipocliente.ValueMember = "codigo"

    End Sub


    Private Sub btnregrsar_Click(sender As Object, e As EventArgs) Handles btnregrsar.Click
        Me.Close()
        btnimagen.Enabled = True
        limpiarcampos()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        'Guardar la imagen en una ruta establecida
        If ptbFotocliente.Image Is Nothing Then
            Ruta = DBNull.Value
        Else
            Dim RutaFoto As Object 'Variable que trae la ruta de la carpeta donde se guarda la imagen
            Dim RutaF As String 'Variable que guarda la imagen en el equipo
            RutaFoto = RutaFotos()
            RutaF = RutaFotos.rows(0)(2) & txtdocumento.Text & "_Foto_Cliente" & ".jpg"
            ruta = RutaF
            'Se elimina la imagen anterior
            If File.Exists(RutaF) Then
                My.Computer.FileSystem.DeleteFile(RutaF)
            End If
            Dim SaveImage As New Bitmap(ptbFotocliente.Image)
            SaveImage.Save(Ruta, Imaging.ImageFormat.Jpeg)
            SaveImage.Dispose()
        End If



        swift = 0

        ReDim arreglo(16)

        'validamos que los campos este llenos

        'CC
        If txtdocumento.Text = "" Then
            arreglo(0) = DBNull.Value
        Else
            arreglo(0) = txtdocumento.Text
        End If

        'Nombres
        If txtnombres.Text = "" Then
            arreglo(1) = DBNull.Value
        Else
            arreglo(1) = txtnombres.Text
        End If

        'Apellidos
        If txtapellidos.Text = "" Then
            arreglo(2) = DBNull.Value
        Else
            arreglo(2) = txtapellidos.Text
        End If

        'ficha
        If cmbficha.SelectedValue Is Nothing Then
            arreglo(3) = codficha
        Else
            arreglo(3) = cmbficha.SelectedValue
        End If



        'Email
        If txtemail.Text = "" Then
            arreglo(4) = DBNull.Value
        Else
            arreglo(4) = txtemail.Text
        End If


        'telefono
        If txtmovil.Text = "" Then
            arreglo(5) = DBNull.Value
        Else
            arreglo(5) = txtmovil.Text
        End If


        'fecha
        arreglo(6) = fecha_actual

        'tipo de cliente
        If cmbtipocliente.SelectedValue Is Nothing Then
            arreglo(7) = tipo_cliente
        Else
            arreglo(7) = cmbtipocliente.SelectedValue
        End If



        'foto
        arreglo(8) = Ruta

        'Guellas
        arreglo(9) = DBNull.Value
        arreglo(10) = DBNull.Value
        arreglo(11) = DBNull.Value

        'sincronizacion
        arreglo(12) = sincronizado



        'tipo documento
        If cmbtipo_documento.SelectedValue Is Nothing Then
            arreglo(13) = DBNull.Value
        Else
            arreglo(13) = cmbtipo_documento.SelectedValue
        End If

        'estado
        arreglo(14) = "1"



        datos = Insert_Update_tbl_cliente(arreglo, "sp_tbl_cliente_update")
        If datos = 1 Then
            MsgBox("Se actualizó correctamente el registro", vbInformation)
            limpiarcampos()
            If SWEdit = 1 Then
                With frmMovimientos_documento
                    formu = 0
                    .txtDocumento.Text = arreglo(0)
                    .BuscarClientePrest()
                End With
            Else
                With frm_clientes
                    .Reload(.anterior, .siguiente)
                End With
            End If
            Me.Close()
        Else
            If datos = 515 Then
                MsgBox("Por favor llene todos los campos obligatorios", vbCritical)
            Else
                If datos = 8114 Then
                    MsgBox("Los tipos de datos no corresponden , por favor revizar", vbCritical)
                End If

            End If

        End If
        'recargamos el formulario de clientes para mostrar los cambios

        ReDim arreglo(0)
    End Sub

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        'Buscador Automatico
        If txtbuscador.Text <> "" Then
            datos = Buscador_keyUp(txtbuscador.Text, "sp_tbl_ficha_keyup") ' esta funcion nos busca automaticamente por codigo o nombre del elemento

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

    Private Sub txtdocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdocumento.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Function pnlficha()
        'esta funcion la usuamos para ocultar o mostrar el panel para insertar la ficha
        If pnlinsert_ficha.Visible = True Then
            pnlinsert_ficha.Visible = False
        Else
            pnlinsert_ficha.Visible = True
        End If
    End Function

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

    Private Sub btnficha_Click(sender As Object, e As EventArgs) Handles btnficha.Click
        pnlficha()
        txtficha.Focus()
    End Sub

    Private Sub btnguardarficha_Click(sender As Object, e As EventArgs) Handles btnguardarficha.Click
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
        End If
    End Sub

    Private Sub linktipo_cliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linktipo_cliente.LinkClicked
        cmbtipocliente.Enabled = True
        txttipo_cliente.Visible = False
        cmbtipocliente.Select()
        cmbtipocliente.SelectedValue = tipo_cliente
    End Sub

    Private Sub txtmovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmovil.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        'Validamos que el texbox si tenga un correor valido
        If txtemail.Text <> "" Then
            If validar_Mail(LCase(txtemail.Text)) = False Then
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
                txtemail.SelectAll()
                txtemail.Focus()
            End If
        End If
    End Sub

    Function validarcliente()
        'esta funcion inabilita el combobox de la ficha cuando no es aprendiz
        If cmbtipocliente.SelectedValue <> 1 Then
            txtbuscador.Enabled = False
            cmbficha.Enabled = False
            txtbuscador.Text = ""
            cmbficha.Text = ""
            codficha = 0
        Else
            txtbuscador.Enabled = True
            cmbficha.Enabled = True
        End If
    End Function

    Private Sub frm_registro_update_Click(sender As Object, e As EventArgs) Handles Me.Click

        'si esta visible el panel al hacer click lo oculta
        If pnlinsert_ficha.Visible = True Then
            pnlinsert_ficha.Visible = False
        End If
    End Sub

    Private Sub cmbtipocliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbtipocliente.SelectionChangeCommitted
        validarcliente()
    End Sub
End Class