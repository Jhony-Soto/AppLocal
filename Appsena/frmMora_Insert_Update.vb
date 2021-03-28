Imports System.ComponentModel

Public Class frmMora_Insert_Update
    Public Resultado, ex, ey, Operacion As Integer
    Dim CodigoMora As Integer
    Public Arrastre As Boolean
    Public Datos, Datos2, Conjunto(2), MoraResultado As Object
    Public MoritaMaestro(5), MoraDetalle(9), ElementoPres(7) As Object


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


    Private Function LimpiarCampos()
        txtObservaciones.Text = ""
        ptbFotoCliente.Image = Nothing
        dgvMora.Rows.Clear()

    End Function

    Private Sub frmMora_Insert_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'le damos la fecha actual al datatimepicker
        dtpEntradaMora.Value = Date.Now.Date
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        LimpiarCampos()
        Me.Close()
    End Sub

    Private Sub dgvMora_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMora.CellClick
        Select Case e.ColumnIndex
            Case 6
                If MessageBox.Show("¿Está seguro que desea eliminar el elemento de la mora?", "Eliminar elemento de mora", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    dgvMora.Rows.RemoveAt(e.RowIndex)
                End If
        End Select
    End Sub

    Private Sub btnEnviarAMora_Click(sender As Object, e As EventArgs) Handles btnEnviarAMora.Click
        If MessageBox.Show("Está seguro que desea enviar a mora al cliente: " & vbNewLine & lblNombresNom.Text, "Enviar a mora", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) Then
            'Consultar si el cliente ya tiene una mora activa
            MoraResultado = EstadoMoraCliente(lblDocidNom.Text, 1)

            'Se Valida si el cliente si tiene una mora activa
            If MoraResultado.rows.count > 0 Then
                CodigoMora = MoraResultado.rows(0)(0) 'Se guarda el codigo de la mora
            Else
                'SE INSERTA LA MORA EN LA TABLA tb_Mora que es la tabla maestra
                MoritaMaestro(0) = lblDocidNom.Text 'Docid del cliente
                MoritaMaestro(1) = dtpEntradaMora.Value.ToShortDateString 'Fecha de entrada a la mora
                MoritaMaestro(2) = DBNull.Value 'Fecha de salida nula
                MoritaMaestro(3) = "1" 'Estado de la mora, significa que esta activa
                If txtObservaciones.Text = "" Then 'Observaciones sobre la mora del cliente
                    MoritaMaestro(4) = DBNull.Value 'Si está vacío se lleva un null
                Else
                    MoritaMaestro(4) = txtObservaciones.Text 'Se lleva el valor del textbox si no está vacío
                End If
                MoritaMaestro(5) = "0" 'Estado de sincronizacion
                Mora_Insert(MoritaMaestro, "sp_tbl_mora_insert") 'Se inserta la nueva mora

                'Se guarda la informacion de la mora insertada en una variable para después utilizar la información
                MoraResultado = Mora_SelectPK(MoritaMaestro(0), "sp_tblMora_selectPK", 1)

            End If



            'SE HACE EL INSERT EN LA TABLA tbl_mora_elemento'

            For Each dgvfila As DataGridViewRow In dgvMora.Rows
                MoraDetalle(0) = MoraResultado.rows(0)(0) 'Codigo de la mora que es el resultado de la consulta
                MoraDetalle(1) = dgvfila.Cells(0).Value 'Codigo del elemento
                MoraDetalle(2) = dgvfila.Cells(2).Value 'Cantidad
                'Observaciones, se valida si tiene o no tiene observaciones
                If dgvfila.Cells(3).Value = "" Or dgvfila.Cells(3).Value Is Nothing Then
                    MoraDetalle(3) = DBNull.Value 'Se envía un null cuando no tiene observaciones
                Else
                    MoraDetalle(3) = dgvfila.Cells(3).Value 'Se envia el valor de la celda de observaciones cuando hay
                End If

                MoraDetalle(4) = Today.Date & " " & Now.ToString("hh:mm") 'Fecha y Hora de entreda del elemento a mora
                MoraDetalle(5) = DBNull.Value 'Se envía un valor null en la fecha de salida
                MoraDetalle(6) = "1" 'Estado del elemento en mora
                MoraDetalle(7) = CodCentroActual 'Centro actual
                MoraDetalle(8) = DBNull.Value 'Se lleva un valor null en la ruta del documento de respaldo
                MoraDetalle(9) = "0" 'Estado de sincronizacion
                Dim FechaDev As DateTime = Today.Date.ToShortDateString & " " & Now.ToString("hh:mm")
                '------Se hace el insert---------
                Dim ResultadoMora As Integer
                ResultadoMora = Mora_Elemento_Insert(MoraDetalle, "sp_tbl_Mora_Elemento_Insert")
                If ResultadoMora = 1 Then
                    Resultado = Resultado + 1
                Else
                    Resultado = Resultado - 1
                End If

                ''Se consulta el elemento en la tabla de elementos
                'Datos = SelectElemento(MoraDetalle(1), 1)
                ''Se descuenta de la disponibilidad del elemento, ya que va a estar en mora
                'UpdateDispoElemento(MoraDetalle(1), (Datos.rows(0)(2) - MoraDetalle(2)))

                'Se actualiza el estado del elemento en el prestamo del cliente a estado moroso
                EntregarElementos({lblCodPres.Text, MoraDetalle(1), 1, dgvfila.Cells(7).Value, FechaDev, MoraDetalle(3), "3", dgvfila.Cells(6).Value})
            Next

            If Resultado = dgvMora.Rows.Count Then
                MessageBox.Show("Se agregó el cliente y los elementos a mora correctamente", "Enviar a mora", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With frmMovimientos_detalle
                    DetallePrestamo = TraerDetallePrestamo(lblCodPres.Text, 1)
                    .ActualizarHistorial()
                    If .dgvHistorial.RowCount = 0 Then
                        Dim EstadoPrestamo As Object
                        EstadoPrestamo = {lblCodPres.Text, "0", Today & " " & Now.ToString("hh:mm")}
                        InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
                        .btnEntregarTodo.Visible = False
                        .btnEntregar.Visible = False
                        .dgvHistorial.Columns(10).Visible = False
                        .dgvHistorial.Columns(11).Visible = False
                        CerrarPestañas()
                        .ValidarBotones()
                        BajarNivel(frmMovimientos_documento)
                    Else
                        With frmMovimientos_documento
                            .txtDocumento.Text = lblDocidNom.Text
                            .BuscarClientePrest()
                        End With
                    End If
                End With
            Else
                MessageBox.Show("Hay errores en la validación de los elementos", "Error al enviar a mora", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub frmMora_Insert_Update_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LimpiarCampos()
    End Sub

End Class