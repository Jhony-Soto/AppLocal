Imports System.ComponentModel

Public Class frmMovimientos_PrestamosCliente
    Public Datos As Object
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub


    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub



    Public Function CargarFormulario(codcliente)
        Datos = CargarPrestamosCliente(codcliente)
        tabla = New DataTable
        tabla = Datos.tables("datos")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgvPrestamos.Rows.Add()
            For j As Integer = 0 To 4
                If j = 3 Then
                    dgvPrestamos.Rows(i).Cells(3).Value = "ACTIVO"
                    dgvPrestamos.Rows(i).Cells(3).Style.BackColor = Color.FromArgb(230, 11, 11)
                    dgvPrestamos.Rows(i).Cells(3).Style.ForeColor = Color.White
                    dgvPrestamos.Rows(i).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    dgvPrestamos.Rows(i).Cells(j).Value = tabla.Rows(i)(j)
                End If
            Next
        Next

        lblNombreCLiente.Text = tabla.Rows(0)(5)

        Me.ShowDialog()
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dgvPrestamos.Rows.Count > 0 Then
            MaestroPrestamo = ValidarClientePrestamo(dgvPrestamos.Rows(dgvPrestamos.CurrentRow.Index).Cells(0).Value, 2)
            DetallePrestamo = TraerDetallePrestamo(dgvPrestamos.Rows(dgvPrestamos.CurrentRow.Index).Cells(0).Value, 1)
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        With frmMovimientos_documento
            .SwCerrar = 1
            .txtDocumento.SelectAll()
        End With
        Me.Close()

    End Sub

    Private Sub frmMovimientos_PrestamosCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgvPrestamos.Rows.Clear()
    End Sub

    Private Sub dgvPrestamos_DoubleClick(sender As Object, e As EventArgs) Handles dgvPrestamos.DoubleClick
        If dgvPrestamos.Rows.Count > 0 Then
            MaestroPrestamo = ValidarClientePrestamo(dgvPrestamos.Rows(dgvPrestamos.CurrentRow.Index).Cells(0).Value, 2)
            DetallePrestamo = TraerDetallePrestamo(dgvPrestamos.Rows(dgvPrestamos.CurrentRow.Index).Cells(0).Value, 1)
            Me.Close()
        End If
    End Sub
End Class