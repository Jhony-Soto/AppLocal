Imports System.ComponentModel

Public Class frmMovimientos_Historial_Detalle
    Public arreglo, datos, titulo As Object
    Public Function CargarDetallePrestamo(codpres)
        '==================MAESTRO========================
        MaestroPrestamo = PrestamoMaestroHistorial(codpres, 1)
        lblNombresNom.Text = MaestroPrestamo.rows(0)(1) 'Nombres del cliente
        lblAdministrador.Text = MaestroPrestamo.rows(0)(2) 'Nombres del administrador
        lblTipoPrestamo.Text = MaestroPrestamo.rows(0)(3) 'Tipo de prestamo

        'Cargamos el datagrid donde se exportara a excel
        arreglo = {MaestroPrestamo.rows(0)(7), MaestroPrestamo.rows(0)(1), MaestroPrestamo.rows(0)(8), MaestroPrestamo.rows(0)(9)}


        'Estado del prestamo
        If MaestroPrestamo.rows(0)(4) = "1" Then
            lblEstadoPrestamo.Text = "ACTIVO"
            lblEstadoPrestamo.ForeColor = Color.White
            lblEstadoPrestamo.BackColor = Color.FromArgb(230, 11, 11)
        Else
            lblEstadoPrestamo.Text = "ENTREGADO"
            lblEstadoPrestamo.ForeColor = Color.White
            lblEstadoPrestamo.BackColor = Color.FromArgb(0, 168, 17)
        End If

        lblFechaPrestamo.Text = MaestroPrestamo.rows(0)(5).ToShortDateString 'Fecha de prestamo
        If MaestroPrestamo.rows(0)(6) IsNot DBNull.Value Then
            lblFechaDevolucion.Text = MaestroPrestamo.rows(0)(6).ToShortDateString 'Fecha de devolucion
        Else
            lblFechaDevolucion.Text = ""
        End If

        Select Case MaestroPrestamo.rows(0)(10)
            Case 2 'Prestamo externo
                lblFormatoSalida.Visible = True
                lblSeguro.Visible = True
            Case 5 'Prestamo para proyecto
                lblFormatoSalida.Visible = True
                lblSeguro.Visible = True
            Case 6 'Traspaso de elementos
                lblFormatoSalida.Visible = True
                If MaestroPrestamo.rows(0)(13) Is DBNull.Value Then
                    lblTraspaso1.Visible = True
                Else
                    lblTraspaso1.Visible = True
                    lblTraspaso2.Visible = True
                End If
        End Select


        '=======================DETALLE=====================
        dgvHistorial.Rows.Clear()
        'Se consulta el detalle del prestamo
        DetallePrestamo = TraerDetallePrestamo(codpres, 2)

        'Cargamos los detalles del prestamo en el datatgrid que se exportara
        dgexportar.DataSource = DetallePrestamo
        dgexportar.DataMember = "datos"

        'Nueva instancia de una datatable
        tabla = New DataTable
        'Valor de la tabla
        tabla = DetallePrestamo.tables("datos")
        'Cantidad de filas de la tabla convertida a posiciones
        Dim Filas = tabla.Rows.Count - 1
        'Recorrer la tabla y agregar a un datagridview las filas de la tabla
        For i = 0 To Filas
            dgvHistorial.Rows.Add()
            dgvHistorial.Rows(i).Cells(0).Value = tabla.Rows(i)(0) 'Codigo del Prestamo
            dgvHistorial.Rows(i).Cells(1).Value = tabla.Rows(i)(1) 'Codigo del Elemento
            dgvHistorial.Rows(i).Cells(2).Value = tabla.Rows(i)(2) 'Descripcion
            dgvHistorial.Rows(i).Cells(3).Value = tabla.Rows(i)(3) 'Cantidad
            dgvHistorial.Rows(i).Cells(4).Value = tabla.Rows(i)(4) 'Fecha del prestamo

            'Validar campos nulos
            If tabla.Rows(i)(5) Is DBNull.Value Then 'Fecha devolucion
                dgvHistorial.Rows(i).Cells(5).Value = ""
            Else
                dgvHistorial.Rows(i).Cells(5).Value = tabla.Rows(i)(5)
            End If

            If tabla.Rows(i)(6) Is DBNull.Value Then 'Observaciones
                dgvHistorial.Rows(i).Cells(6).Value = ""
            Else
                dgvHistorial.Rows(i).Cells(6).Value = tabla.Rows(i)(6)
            End If

            dgvHistorial.Rows(i).Cells(7).Value = tabla.Rows(i)(7) 'Estado
            If dgvHistorial.Rows(i).Cells(7).Value = 2 Then
                dgvHistorial.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(252, 115, 35)
            End If
            dgvHistorial.Rows(i).Cells(8).Value = tabla.Rows(i)(8) 'consecutivo
            dgvHistorial.Rows(i).Cells(9).Value = tabla.Rows(i)(9) 'Cantida Entrega
            dgvHistorial.Rows(i).Cells(12).Value = tabla.Rows(i)(3) 'Cantidad de Prestamo para validaciones
        Next

        Me.ShowDialog()
    End Function

    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        'IMPRIMIR REPORTE DE EXCEL
        Cursor = Cursors.WaitCursor
        descargar_plantilla_detalle_mora(dgexportar, titulo, arreglo)
        Cursor = Cursors.Default
    End Sub

    Private Sub dgvHistorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellContentClick
        If dgvHistorial.Rows.Count > 0 Then
            If e.RowIndex <> -1 Then
                If dgvHistorial.Rows(e.RowIndex).Cells(7).Value = "2" Then
                    dgvHistorial.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 84, 2)
                End If
            End If
        End If
    End Sub

    Private Sub frmMovimientos_Historial_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dgvHistorial.Rows.Count > 0 Then
            If dgvHistorial.Rows(0).Cells(7).Value = "2" Then
                dgvHistorial.Rows(0).DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 84, 2)
            End If
        End If
    End Sub

    Private Sub lblFormatoSalida_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFormatoSalida.LinkClicked
        AbrirArchivos(MaestroPrestamo.rows(0)(11))
    End Sub

    Private Sub lblSeguro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSeguro.LinkClicked
        frmSeguros.ShowDialog()
    End Sub

    Private Sub lblTraspaso1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblTraspaso1.LinkClicked
        AbrirArchivos(MaestroPrestamo.rows(0)(12))
    End Sub

    Private Sub lblTraspaso2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblTraspaso2.LinkClicked
        AbrirArchivos(MaestroPrestamo.rows(0)(13))
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub frmMovimientos_Historial_Detalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        lblFormatoSalida.Visible = False
        lblSeguro.Visible = False
        lblTraspaso1.Visible = False
        lblTraspaso2.Visible = False
        dgvHistorial.Rows.Clear()
    End Sub
End Class