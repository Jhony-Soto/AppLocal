Imports System.ComponentModel

Public Class frmMovimientos_DuplicarPrestamo
    Public Datos As Object
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    Function DuplicarPrestamo()
        If txtDocumento.Text <> "" Then
            Dim DupliElemento As Object
            For i As Integer = 0 To FilasDupli
                DupliElemento = SelectElemento(MTElementos(i, 0), 1)
                UpdateDispoElemento(MTElementos(i, 0), (DupliElemento.Rows(0)(2) - MTElementos(i, 2)))
            Next
            frmMovimientos_documento.txtDocumento.Text = txtDocumento.Text
            frmMovimientos_documento.BuscarClientePrest()
            Me.Close()
        Else
            MessageBox.Show("El campo del documento está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDocumento.Focus()
        End If
    End Function

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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DuplicarPrestamo()
    End Sub

    Private Sub txtDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocumento.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                DuplicarPrestamo()
        End Select
    End Sub

End Class