Imports System.IO
Public Class frm_registrarme
    Dim contrasenia As Object

    'Definimos las varibles que nesecitaremos en este modulo
    Public sql, datos, array, ruta, tipo_admin As Object


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



    Private Sub GunaCircleButton1_Click_1(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        With frm_administradores
            If .swich_registro = 1 Then
                Me.Close()
            Else
                Me.Close() 'cerramos este formulario
                frm_login.Show() 'abrimos el formulario de login
            End If
        End With

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'validamos que todos los campos esten llenos
        If txtdocumento.Text = "" Or cmbtipo_documento.ValueMember = "" Or txtnombres.Text = "" Or txtapellidos.Text = "" Or txtemail.Text = "" Or txtcontraseña1.Text = "" Or txtcontraseña2.Text = "" Or txtmovil.Text = "" Or fecha_expedicion.Value = Nothing Then
            MsgBox("Campos requeridos sin completar, por favor vuelva a verificar.", vbCritical)
        Else

            'Incriptamos la contraseña
            contrasenia = Encriptar(txtcontraseña2.Text)
            '*********************************************************************************************
            'Guardar la imagen en una ruta establecida
            Try
                'Variable que guarda la ruta de la imagen
                Dim ruta As Object
                'Valida si hay una imagen
                'Guardar la imagen en una ruta establecida
                If ptbFotoAdmin.Image Is Nothing Then
                    ruta = DBNull.Value
                Else
                    Dim RutaFoto As Object 'Variable que trae la ruta de la carpeta donde se guarda la imagen
                    Dim RutaF As String 'Variable que guarda la imagen en el equipo
                    RutaFoto = RutaFotos()
                    RutaF = RutaFotos.rows(0)(4) & txtdocumento.Text & "_Foto_Admin" & ".jpg"
                    ruta = RutaF
                    'Se elimina la imagen anterior
                    If File.Exists(RutaF) Then
                        My.Computer.FileSystem.DeleteFile(RutaF)
                    End If
                    Dim SaveImage As New Bitmap(ptbFotoAdmin.Image)
                    SaveImage.Save(ruta, Imaging.ImageFormat.Jpeg)
                    SaveImage.Dispose()
                End If


                If tipo_admin <> 1 Then
                    tipo_admin = 0
                End If


                'Si todos los campos estan llenos creamos el arreglo para hacer el insert en la funcion 
                array = {txtdocumento.Text, txtnombres.Text, txtapellidos.Text, txtemail.Text, txtmovil.Text, contrasenia, fecha_expedicion.Value, ruta, cmbtipo_documento.SelectedValue, "1", tipo_admin}
                Insert_Update_Admin(array, "sp_tbl_admin_insert")

                'Validamos si el registro se esta haciendo desde el formulario de administradores
                With frm_administradores
                    If .swich_registro = 1 Then
                        Me.Close()
                        .frm_administradores_Load(Nothing, Nothing)
                    Else
                        Me.Close() 'cerramos este formulario
                        frm_login.Show() 'abrimos el formulario de login
                    End If
                End With

                limpiarcampos() 'Limpiar los campos de todo el formulario

                frm_login.btnregistrarme.Visible = False



            Catch ex As Exception
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            '****************************************************************************************************

        End If
    End Sub

    Function limpiarcampos()
        'Limpia todos los campos del formulario
        txtdocumento.Text = ""
        cmbtipo_documento.ValueMember = ""
        txtnombres.Text = ""
        txtapellidos.Text = ""
        txtemail.Text = ""
        txtcontraseña1.Text = ""
        txtcontraseña2.Text = ""
        txtmovil.Text = ""
        fecha_expedicion.Text = ""
        ptbFotoAdmin.Image = Nothing
    End Function

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdocumento.KeyPress
        'Solo permite Numeros en el texbox
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmbtipo_documento_GotFocus(sender As Object, e As EventArgs) Handles cmbtipo_documento.GotFocus
        'Combobox el cual tiene los tipos de documentos utlizando la funcion cargardatos que nos devuelve los datos de la consulta
        sql = "sp_tbl_tipo_documento_select"
        datos = CargarDatos(sql)

        tabla = New DataTable
        tabla = datos.tables("datos")

        cmbtipo_documento.DataSource = tabla
        cmbtipo_documento.DisplayMember = "nombre"
        cmbtipo_documento.ValueMember = "codigo"

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

    Private Sub txtcontraseña2_LostFocus(sender As Object, e As EventArgs) Handles txtcontraseña2.LostFocus
        'Validamos que las contraseñas que se pidan sean iguales
        If txtcontraseña2.Text <> "" Then
            If Not txtcontraseña1.Text = txtcontraseña2.Text Then
                MsgBox("Las contraseñas no coinciden ,por favor verifique los datos!", vbInformation)
                txtcontraseña2.Focus()
            End If
        End If

    End Sub

    Private Sub frm_registrarme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        fecha_expedicion.Value = Date.Now.Date
    End Sub

    Private Sub txtmovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmovil.KeyPress
        'Solo permite Numeros en el texbox
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnimagen_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        formu = 2
        MainForm.Show()
    End Sub

    Private Sub GunaImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checbox.CheckedChanged
        'Este codigo es para mostrar la contraseña en texto o volverla a ocultar
        If checbox.Checked = False Then
            txtcontraseña1.PasswordChar = "●"
            txtcontraseña2.PasswordChar = "●"
        Else
            txtcontraseña1.PasswordChar = ""
            txtcontraseña2.PasswordChar = ""

        End If
    End Sub
End Class