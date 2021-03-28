Imports System.ComponentModel

Public Class frmMovimientos_BuscarCliente
    Public Datos As Object
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub


    Public Function ValidarCliente()
        'Validar si hay filas en el datagrid
        If dgvClientes.Rows.Count > 0 Then
            Dim Fila As Integer
            Fila = dgvClientes.CurrentRow.Index

            frmMovimientos_Historial.dtpFechaInicial.Value = Date.Now.Date.AddDays(-7)
            frmMovimientos_Historial.dtpFechaFinal.Value = Date.Now.Date
            'Se ejecuta la funcion que permite la busqueda de un historial por cliente
            frmMovimientos_Historial.ActualizarDGVfrmHistorial(1, dgvClientes.Rows(Fila).Cells(0).Value)
            With frmMovimientos_Historial
                .lblNombresNom.Text = dgvClientes.Rows(Fila).Cells(1).Value
                .lblTipoClienteNom.Text = dgvClientes.Rows(Fila).Cells(2).Value
                .lblDocid.Text = dgvClientes.Rows(Fila).Cells(0).Value
                .lblNombres.Visible = True
                .lblNombresNom.Visible = True
                .lblTipoCliente.Visible = True
                .lblTipoClienteNom.Visible = True
                .lnkCambiarCliente.Visible = True
                .lnkDetalleCliente.Visible = True
                .lblDocid.Visible = False
                .swHistorial = 1

            End With
            Me.Close()
        Else
            If txtBuscador.Text = "" Then
                MessageBox.Show("El campo del documento está vacío", "Seleccionar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBuscador.Focus()
            Else
                MessageBox.Show("El cliente no existe", "Seleccionar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBuscador.Focus()
            End If

        End If
    End Function

    Private Sub txtBuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscador.KeyUp
        dgvClientes.Rows.Clear()
        Datos = Buscador_keyUp(txtBuscador.Text, "sp_tbl_Cliente_Buscador2")
        tabla = New DataTable
        tabla = Datos.tables("datos")

        For i As Integer = 0 To tabla.Rows.Count - 1
            dgvClientes.Rows.Add()
            For j As Integer = 0 To 4
                dgvClientes.Rows(i).Cells(j).Value = tabla.Rows(i)(j)

            Next
        Next
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ValidarCliente()
    End Sub

    Private Sub frmMovimientos_BuscarCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgvClientes.Rows.Clear() 'Se actualiza el dgv
        txtBuscador.Text = "" ' Se limpia el txt
    End Sub

    Private Sub txtBuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscador.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ValidarCliente()
        End Select

    End Sub

    Private Sub frmMovimientos_BuscarCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtBuscador.Focus()
    End Sub

    Private Sub dgvClientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvClientes.MouseDoubleClick
        If dgvClientes.Rows.Count > 0 Then
            If e.Button = MouseButtons.Left Then
                ValidarCliente()
            End If
        End If

    End Sub
End Class