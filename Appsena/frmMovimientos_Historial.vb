Public Class frmMovimientos_Historial
    Public swHistorial As Byte
    Public DocidCliente, Datos, titulo As Object

    Public Function ActualizarDGVfrmHistorial(tipo, codcliente)
        ' Limpiar el dgv para hacerlo dinamico
        dgvPrestamos.Rows.Clear()

        'SE EJECUTA UN COMANDO QUE PERMITE ACTUALIZAR EL DATAGRIDVIEW DE LOS ELEMENTOS DISPONIBLES
        Select Case tipo
            Case 0
                datos = Prestamos_HistorialGeneral({dtpFechaInicial.Value, dtpFechaFinal.Value}, "SP_tblPrestamo_HistorialGeneral")
                tabla = New DataTable
                tabla = Datos.tables("datos")

                'cargamos el datagrid que se exportar en execel
                dgexportar.DataSource = Datos
                dgexportar.DataMember = "datos"
                titulo = "HISTORIAL GENERAL DE PRESTAMOS"

            Case 1
                datos = Prestamos_HistorialPorCliente({dtpFechaInicial.Value, dtpFechaFinal.Value}, codcliente, "SP_tblPrestamo_HistorialPorCliente")
                tabla = New DataTable
                tabla = Datos.tables("datos")

                'cargamos el datagrid que se exportar en execel
                dgexportar.DataSource = Datos
                dgexportar.DataMember = "datos"
                titulo = "HISTORIAL DEL CLIENTE"

        End Select

        Dim Filas = tabla.Rows.Count

        'SE LLENA EL DATAGRIDVIEW CON LA INFORMACION RESULTANTE DE LA FUNCION BUSCADOR_KEYUP
        For i = 0 To Filas - 1
            dgvPrestamos.Rows.Add()
            dgvPrestamos.Rows(i).Cells(0).Value = tabla(i)(0) 'codigo del prestamo
            dgvPrestamos.Rows(i).Cells(1).Value = tabla(i)(1) 'documento del cliente
            dgvPrestamos.Rows(i).Cells(2).Value = tabla(i)(2) 'nombre del cliente
            dgvPrestamos.Rows(i).Cells(3).Value = tabla(i)(3) 'tipo de cliente
            dgvPrestamos.Rows(i).Cells(4).Value = tabla(i)(4) 'administrador
            dgvPrestamos.Rows(i).Cells(5).Value = tabla(i)(5) 'tipo de prestamo
            If tabla(i)(6) = 1 Then 'estado del prestamo
                dgvPrestamos.Rows(i).Cells(6).Value = "ACTIVO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(230, 11, 11)
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dgvPrestamos.Rows(i).Cells(6).Value = "ENTREGADO"
                dgvPrestamos.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(0, 168, 17)
                dgvPrestamos.Rows(i).Cells(6).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvPrestamos.Rows(i).Cells(6).Style.ForeColor = Color.White
            End If

            dgvPrestamos.Rows(i).Cells(7).Value = tabla(i)(7) ' fecha del prestmao
            dgvPrestamos.Rows(i).Cells(8).Value = tabla(i)(8).ToString 'fecha devolucion
        Next


    End Function


    Private Sub HistorialGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialGeneralToolStripMenuItem.Click
        lblNombres.Visible = False
        lblNombresNom.Visible = False
        lblTipoCliente.Visible = False
        lblTipoClienteNom.Visible = False
        lnkCambiarCliente.Visible = False
        lnkDetalleCliente.Visible = False
        lblDocid.Visible = False

        swHistorial = 0
        dtpFechaInicial.Value = Date.Now.Date.AddDays(-7)
        dtpFechaFinal.Value = Date.Now.Date
        lblEncabezado.Text = "Historial general"
        ActualizarDGVfrmHistorial(0, Nothing)
    End Sub

    Private Sub frmMovimientos_Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frmMovimientos_Historial_Click
        Next

        dtpFechaInicial.Value = Date.Now.Date.AddDays(-7)
        dtpFechaFinal.Value = Date.Now.Date
        ActualizarDGVfrmHistorial(0, Nothing)

    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frmMovimientos_Historial_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub

    Private Sub btnBuscarHistorial_Click(sender As Object, e As EventArgs) Handles btnBuscarHistorial.Click
        Select Case swHistorial
            Case 0
                If dtpFechaInicial.Value > dtpFechaFinal.Value Then
                    MessageBox.Show("Intervalo de fechas incorrecto, por favor verificar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ActualizarDGVfrmHistorial(0, Nothing)
                End If

            Case 1
                If dtpFechaInicial.Value > dtpFechaFinal.Value Then
                    MessageBox.Show("Intervalo de fechas incorrecto, por favor verificar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ActualizarDGVfrmHistorial(1, lblDocid.Text)
                End If
        End Select

    End Sub

    Private Sub HistorialPorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialPorToolStripMenuItem.Click
        lblEncabezado.Text = "Historial de prestamos por cliente" 'Se cambia el lbl del formulario de historial
        swHistorial = 1
        frmMovimientos_BuscarCliente.ShowDialog()
    End Sub

    Private Sub lnkCambiarCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCambiarCliente.LinkClicked
        frmMovimientos_BuscarCliente.ShowDialog()
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Cursor = Cursors.WaitCursor
        descargar_plantilla_bajas(dgexportar, titulo)
        Cursor = Cursors.Default
    End Sub

    Private Sub lnkDetalleCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDetalleCliente.LinkClicked
        frmMovimientos_ClienteDetalle.CargarCliente(lblDocid.Text)
    End Sub

    Private Sub dgvPrestamos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPrestamos.MouseDoubleClick
        'Validar si es el boton izquierdo del mouse
        If e.Button = MouseButtons.Left Then
            'Validamos que el datagridview si tenga registros
            If dgvPrestamos.Rows.Count > 0 Then
                Dim Fila As Integer = dgvPrestamos.CurrentRow.Index
                frmMovimientos_Historial_Detalle.CargarDetallePrestamo(dgvPrestamos.Rows(Fila).Cells(0).Value)
            End If
        End If
    End Sub
End Class