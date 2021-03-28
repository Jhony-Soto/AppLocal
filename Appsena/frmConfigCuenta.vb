Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConfigCuenta

    'Variable que guarda la ruta de la imagen
    Public ruta As Object

    Private Sub btnConfiguracionGeneral_Click(sender As Object, e As EventArgs) Handles btnagregarfoto.Click


        'Define en que formulario se mostrará la imagen
        formu = 1
        'Abrir el formulario para tomar la foto del admin
        MainForm.Show()
    End Sub

    Private Sub txtDocid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocid.KeyPress
        'Permite solo valores numericos cada vez que se presiona una tecla
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        'Validar si en el textbox del email hay valores
        If txtEmail.Text <> "" Then
            'Validar si el valor del txtemail contiene el simbolo "@" y el "." despues del dominio.
            If validar_Mail(LCase(txtEmail.Text)) = False Then
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
                txtEmail.SelectAll()
                txtEmail.Focus()
            End If
        End If

    End Sub

    Private Sub txtTelMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelMovil.KeyPress
        'Permite solo valores numericos cada vez que se presiona una tecla
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        'Habilita el hawkeye o el ver contrasela cuando se digite mas de 1 caracteres
        If txtContraseña.Text.Length >= 1 Then
            chbVerContraseña.Visible = True

        End If
    End Sub

    Private Sub chbVerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chbVerContraseña.CheckedChanged
        'Cambiar el passwordchar cuando el hawkeye este habilitado o deshabilitado
        If chbVerContraseña.Checked = True Then
            txtContraseña.PasswordChar = ""
            txtRepetirContra.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "•"
            txtRepetirContra.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        'El hawkeye se oculta cuando el campo de la contraseña esta vacío
        If txtContraseña.Text = "" And txtRepetirContra.Text = "" Then
            chbVerContraseña.Visible = False
            chbVerContraseña.Checked = False
        End If
    End Sub

    Private Sub cmbTipoDocumento_GotFocus(sender As Object, e As EventArgs) Handles cmbTipoDocumento.GotFocus
        'Cargar los tipo de documentos al combobox

        Dim datos As Object
        datos = CargarDatos("sp_tbltipodocumento_combobox")
        tabla = New DataTable
        tabla = datos.tables("datos")
        cmbTipoDocumento.DataSource = tabla
        cmbTipoDocumento.ValueMember = "codigo"
        cmbTipoDocumento.DisplayMember = "nombre"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim RutaFoto As Object 'Variable que trae la ruta de la carpeta donde se guarda la imagen
        Dim Ruta As String 'Variable que guarda la imagen en el equipo
        RutaFoto = RutaFotos()
        Ruta = RutaFotos.rows(0)(3) & txtDocid.Text & "_Foto_Admin" & ".jpg"

        '-----------------VALIDAR CAMPOS-------------------------
        AAdmin(0) = txtDocid.Text

        If txtNombres.Text = "" Then
            AAdmin(1) = DBNull.Value
        Else
            AAdmin(1) = txtNombres.Text
        End If

        If txtApellidos.Text = "" Then
            AAdmin(2) = DBNull.Value
        Else
            AAdmin(2) = txtApellidos.Text
        End If

        If txtEmail.Text = "" Then
            AAdmin(3) = DBNull.Value
        Else
            AAdmin(3) = txtEmail.Text
        End If

        If txtTelMovil.Text = "" Then
            AAdmin(4) = DBNull.Value
        Else
            AAdmin(4) = txtTelMovil.Text
        End If

        'Contraseña
        AAdmin(5) = Encriptar(txtRepetirContra.Text)

        If dtpExpedicion.Value.ToShortDateString = Today.Date Or dtpExpedicion.Value.ToShortDateString > Today.Date Then
            MsgBox("La fecha de expedicion no es la correcta")
            Exit Sub
        Else
            AAdmin(6) = dtpExpedicion.Value.ToShortDateString
        End If

        If ptbFotoAdmin Is Nothing Then
            AAdmin(7) = DBNull.Value
        Else
            AAdmin(7) = Ruta
        End If

        'Tipo documento
        AAdmin(8) = cmbTipoDocumento.SelectedValue

        'Estado admin
        AAdmin(9) = "1"

        'tipó de administrador
        AAdmin(10) = SESSION(10)

        If ptbFotoAdmin.Image IsNot Nothing Then

            Dim SaveImage As New Bitmap(ptbFotoAdmin.Image)
            SaveImage.Save(Ruta, Imaging.ImageFormat.Jpeg)
            SaveImage.Dispose()
        End If


        Insert_Update_Admin(AAdmin, "sp_tbl_administrador_update")
        'Guardamos la hora en la cual se cerro la sesion
        datos = CargarDatos("sp_tbl_logeo_order_by")
        tabla = New DataTable
        tabla = datos.tables("datos")
        tbl_logeo_update(tabla(0)(0))

        CerrarPestañas()
        frmDashBoard.Close()
        frm_login.Show()





    End Sub

    Private Sub frmConfigCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SE LLEVAN LOS DATOS DEL ADMIN A LOS CONTROLES EN EL FORMULARIO
        txtDocid.Text = SESSION(0)
        txtNombres.Text = SESSION(1)
        txtApellidos.Text = SESSION(2)
        txtEmail.Text = SESSION(3)
        txtTelMovil.Text = SESSION(4)
        txtContraseña.Text = Desencriptar(SESSION(5))
        txtRepetirContra.Text = Desencriptar(SESSION(5))
        dtpExpedicion.Text = SESSION(6)


        CargarImg(ptbFotoAdmin, SESSION(7), "del administrador")





        'se hace un focus al combobox para cargar el valor de la base de datos ya que el framework utilizado para el diseño tiene un bug
        cmbTipoDocumento.Focus()
        cmbTipoDocumento.SelectedValue = SESSION(8)
        ruta = SESSION(7)

        txtDocid.Enabled = False


    End Sub


End Class