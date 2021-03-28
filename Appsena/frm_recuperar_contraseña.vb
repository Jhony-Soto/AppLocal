Public Class frm_recuperar_contraseña
    Dim datos, arreglo, contrasenia As Object
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdocumento.KeyPress
        SoloNumeros(e) 'funcion que solo acepta numeros
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        'Validamos que los campos no esten vacios
        If txtdocumento.Text = "" Then
            MsgBox("Por favor llene todos los campos.", vbCritical)
            txtdocumento.Focus()
        Else
            'Validamso el documento y la fecha de expedicion para recuperar la contraseña
            arreglo = {txtdocumento.Text, fechaDevolucion.Value}
            datos = tbl_admin_recuperar_contraseña(arreglo, "sp_tbl_admin_contrasenia")
            tabla = New DataTable
            tabla = datos.tables("datos")
            'Si se encontraron datos llevamos el usuario y la contrseña al login para iniciar sesion
            If tabla.Rows.Count > 0 Then
                MsgBox("Se recupero la contraseña exitosamente.", vbInformation)
                contrasenia = Desencriptar(tabla(0)(0))
                With frm_login
                    .txtusuario.Text = txtdocumento.Text
                    .txtpassword.Text = contrasenia
                    .Show()
                    Me.Close()
                End With

            Else
                MsgBox("No se encontró ningún administrador con los  datos suministrados.", vbCritical)
                txtdocumento.Focus()
            End If
        End If

    End Sub


    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer

    Private Sub frm_recuperar_contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdocumento.Focus()
        fechaDevolucion.Value = Date.Now.Date
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