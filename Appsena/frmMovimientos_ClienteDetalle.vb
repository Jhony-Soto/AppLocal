Imports System.ComponentModel

Public Class frmMovimientos_ClienteDetalle
    Public Datos As Object
    Public Function CargarCliente(Docid)
        Datos = BuscarCliente(Docid)
        'Validar si el valor de Datos en la poscicion 0 es un 1, si el cliente existe
        If Datos(0) = "1" Then
            'Llenar los campos con la informacion del cliente
            'Se recorre la tabla con la informacion del cliente y se lleva a un arreglo
            For i = 0 To 11
                'Validar si el campo es nulo
                If Datos(1).Rows(0)(i) Is DBNull.Value Then
                    Cliente(i) = DBNull.Value
                Else
                    Cliente(i) = Datos(1).Rows(0)(i)
                End If
            Next
        End If

        lblNombresNom.Text = Cliente(1) & " " & Cliente(2)
        lblDocidNom.Text = Cliente(0)
        lblTipoDocidNom.Text = Cliente(6)
        lblNumFicha.Text = Cliente(4) & " - " & Cliente(3)
        lblTipoCliente.Text = Cliente(8)
        lblTelefonoNom.Text = Cliente(11)
        lblCorreoElectNom.Text = Cliente(10)
        CargarImg(ptbFotoCliente, Cliente(5), "del cliente")

        Me.ShowDialog()
    End Function


    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub frmMovimientos_ClienteDetalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ptbFotoCliente.Image = Nothing
    End Sub
End Class