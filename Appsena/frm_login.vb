Public Class frm_login
    Dim datos, array, password As Object

    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click

        'Validamos que no hallan reservas activas aun el dia de hoy
        Dim fecha_actual As Date = Date.Now.Date

        Dim datos = reserva_select_fecha_prestamo(fecha_actual, "sp_reserva_select_fecha_prestamo")
        tabla = New DataTable
        tabla = datos.tables("datos")
        If tabla.Rows.Count > 0 Then
            If MessageBox.Show("Queremos informarte que a un hay reservas pendientes." & vbLf & " ¿Quieres revisar el módulo de reservas antes de salir de la aplicación?", "Reservas Pendientes.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then
                Dim PrestamosFechas As Object
                PrestamosFechas = ValidarPrestamosFecha(Today.Date, "sp_tbl_prestamo_PrestamosActivos", 1)
                If PrestamosFechas.rows.count > 0 Then
                    If MessageBox.Show("Hay prestamos activos en este momento," & vbNewLine & "¿Está seguro que desea salir?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        Me.Close()
                    Else
                        txtusuario.Focus()
                    End If
                Else
                    Me.Close()
                End If
            Else
                txtusuario.Focus()
            End If
        Else
            Dim PrestamosFechas As Object
            PrestamosFechas = ValidarPrestamosFecha(Today.Date, "sp_tbl_prestamo_PrestamosActivos", 1)
            If PrestamosFechas.rows.count > 0 Then
                If MessageBox.Show("Hay prestamos activos en este momento," & vbNewLine & "¿Está seguro que desea salir?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    Me.Close()
                Else
                    txtusuario.Focus()
                End If
            Else
                Me.Close()
            End If
        End If


    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnregistrarme.Click
        frm_registrarme.tipo_admin = 1
        frm_registrarme.Show() 'abre el formulario de registro
        Me.Hide()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Focus()
        txtusuario.Select()
        ValidarAdmin("sp_tbl_administradores_select") 'Validamos si ya hay algun registro en la tabla de administradoress

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progresbar.Value += 10 'Valor en que se incrementa el progress
        'Cuando el progres llegue a 100  se nos abrira el dashboard
        If progresbar.Value = 100 Then
            Timer1.Stop()
            progresbar.Value = 0

            datos = CargarDatos("sp_tbl_centroActual_select")
            tabla = New DataTable
            tabla = datos.tables("datos")
            CodCentroActual = tabla(0)(0)
            frmDashBoard.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "" Then
            checbox.Visible = False
        End If
    End Sub

    Private Sub lblolvidocontraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblolvidocontraseña.LinkClicked
        Me.Hide()
        frm_recuperar_contraseña.Show()
    End Sub

    Private Sub checbox_CheckedChanged(sender As Object, e As EventArgs) Handles checbox.CheckedChanged
        'Ver la contraseña
        If checbox.Checked = False Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        'Validamos que los campos no esten vacios
        If txtusuario.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Campos requeridos sin completar, por favor vuelva a verificar.", vbCritical)
        Else
            'Guardamos la contraseña en una variables
            password = txtpassword.Text
            'Incriptamos la contraseña
            array = {txtusuario.Text, Encriptar(txtpassword.Text)} 'creamos el arreglo con los datos 
            ValidarLogin(array, "sp_usuario_selectPK") 'enviamos los parametros a la funcion de validacion
            txtpassword.Text = password
        End If
        txtusuario.Text = ""
        txtpassword.Text = ""
        txtusuario.Focus()
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If txtpassword.Text.Length >= 1 Then
            checbox.Visible = True
        End If
    End Sub

    Private Sub frm_login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Validamos que ya se halla registrado el centro
        datos = CargarDatos("sp_tbl_centroActual_select")
        tabla = New DataTable
        tabla = datos.tables("datos")
        Dim Fila = tabla.Rows.Count
        'Si no hay ningun registro en la tabla abrimos el formulario para que elija el centro de formacion
        If Fila = 0 Then
            frm_configuracion_inicial.Show()
            Me.Hide()

        End If
    End Sub
End Class