Imports System.ComponentModel

Public Class frmMovimientos_Detalle_EntregarUno
    Public Datos, ElementoPres(7), Codigos(3) As Object
    Dim CodPrestamo As Integer
    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'DetallePrestamo = TraerDetallePrestamo(CodPrestamo, 1)

        Me.Close()
    End Sub

    'Private Sub btnEntregarTodo_Click(sender As Object, e As EventArgs)
    '    If dgvHistorial.Rows.Count > 0 Then
    '        Dim Suma As Integer
    '        CodPrestamo = dgvHistorial.Rows(0).Cells(0).Value
    '        For Each dgvfila As DataGridViewRow In dgvHistorial.Rows
    '            Select Case dgvfila.Cells(3).Value
    '                Case > 1
    '                    'SSE VALIDA SI EL ELEMENTO ES DE CONSUMO O DEVOLUTIVO
    '                    If dgvfila.Cells(15).Value = "2" Then
    '                        ''CUANDO ES CONSUMO
    '                        Datos = SelectElementoPrestamo(CodPrestamo, dgvfila.Cells(1).Value, dgvfila.Cells(4).Value, 1)
    '                        tablapres = New DataTable
    '                        tablapres = Datos.tables("datos")
    '                        With frmMovimientos_EConsumo
    '                            ReDim .ElementoCons(tablapres.Rows.Count - 1, 7)
    '                            For i As Integer = 0 To tablapres.Rows.Count - 1
    '                                If tablapres.Rows(i)(9) = 0 Then
    '                                    .ElementoCons(i, 0) = tablapres.Rows(i)(0)
    '                                    .ElementoCons(i, 1) = tablapres.Rows(i)(1)
    '                                    .ElementoCons(i, 2) = 1
    '                                    .ElementoCons(i, 3) = tablapres.Rows(i)(4)
    '                                    .ElementoCons(i, 4) = Today & " " & Now.ToString("hh:mm")
    '                                    If tablapres.Rows(i)(6) Is DBNull.Value Then
    '                                        .ElementoCons(i, 5) = DBNull.Value
    '                                    Else
    '                                        .ElementoCons(i, 5) = tablapres.Rows(i)(6)
    '                                    End If

    '                                    .ElementoCons(i, 6) = "1" 'Estado de consumo
    '                                    .ElementoCons(i, 7) = tablapres.Rows(i)(8)
    '                                End If
    '                            Next
    '                            .CantElementos = tablapres.Rows.Count
    '                            .Filas = tablapres.Rows.Count - 1
    '                            .swCant = 1
    '                            .NomElem = dgvfila.Cells(2).Value 'Nombre del elemento
    '                            .swEntUn = 1
    '                            .ShowDialog()
    '                        End With
    '                    Else
    '                        'CUANDO ES DEVOLUTIVO
    '                        Datos = SelectElementoPrestamo(CodPrestamo, dgvfila.Cells(1).Value, dgvfila.Cells(4).Value, 1)
    '                        tablapres = New DataTable
    '                        tablapres = Datos.tables("datos")

    '                        For i As Integer = 0 To tablapres.Rows.Count - 1
    '                            If tablapres.Rows(i)(9) = 0 Then
    '                                ElementoPres(0) = tablapres.Rows(i)(0)
    '                                ElementoPres(1) = tablapres.Rows(i)(1)
    '                                ElementoPres(2) = 1
    '                                ElementoPres(3) = tablapres.Rows(i)(4)
    '                                ElementoPres(4) = Today & " " & Now.ToString("hh:mm")
    '                                If tablapres.Rows(i)(6) Is DBNull.Value Then
    '                                    ElementoPres(5) = DBNull.Value
    '                                Else
    '                                    ElementoPres(5) = tablapres.Rows(i)(6)
    '                                End If

    '                                ElementoPres(6) = "0"
    '                                ElementoPres(7) = tablapres.Rows(i)(8)
    '                                'VALIDAR SI EL ELEMENTO A ENTREGAR ES DE CONSUMO
    '                                EntregarElementos(ElementoPres)
    '                                Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
    '                                Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
    '                                UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
    '                                Suma = 0 'Se reinicia la 
    '                            End If
    '                        Next
    '                    End If

    '                Case 1
    '                    'CUANDO ES DE CONSUMO
    '                    If dgvfila.Cells(11).Value = "2" Then
    '                        With frmMovimientos_EConsumo
    '                            ReDim .ElementoCons(0, 7)
    '                            .ElementoCons(0, 0) = dgvfila.Cells(0).Value
    '                            .ElementoCons(0, 1) = dgvfila.Cells(1).Value
    '                            .ElementoCons(0, 2) = 1
    '                            .ElementoCons(0, 3) = dgvfila.Cells(4).Value
    '                            .ElementoCons(0, 4) = Today & " " & Now.ToString("hh:mm")
    '                            If dgvfila.Cells(6) Is DBNull.Value Then
    '                                .ElementoCons(0, 5) = DBNull.Value
    '                            Else
    '                                .ElementoCons(0, 5) = dgvfila.Cells(6).Value
    '                            End If
    '                            .ElementoCons(0, 6) = "1" 'Estado de consumo
    '                            .ElementoCons(0, 7) = dgvfila.Cells(8).Value
    '                            .CantElementos = 1
    '                            .swCant = 0
    '                            .swEntUn = 1
    '                            .NomElem = dgvfila.Cells(2).Value 'Nombre del elemento
    '                            .ShowDialog()
    '                        End With
    '                    Else
    '                        'CUANDO ES DEVOLUTIVO
    '                        ElementoPres(0) = dgvfila.Cells(0).Value
    '                        ElementoPres(1) = dgvfila.Cells(1).Value
    '                        ElementoPres(2) = 1
    '                        ElementoPres(3) = dgvfila.Cells(4).Value
    '                        ElementoPres(4) = Today & " " & Now.ToString("hh:mm")
    '                        If dgvfila.Cells(6).Value = "" Then
    '                            ElementoPres(5) = DBNull.Value
    '                        Else
    '                            ElementoPres(5) = dgvfila.Cells(6).Value
    '                        End If
    '                        'VALIDAR SI EL ELEMENTO A ENTREGAR ES DE CONSUMO
    '                        If dgvfila.Cells(15).Value = "2" Then
    '                            'frmMovimientos_EConsumo.CargarFormulario(dgvfila.Cells(3).Value)
    '                        End If
    '                        ElementoPres(6) = "0"
    '                        ElementoPres(7) = dgvfila.Cells(8).Value
    '                        EntregarElementos(ElementoPres) 'Se actualiza el prestamo del elemento
    '                        Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
    '                        Suma = ElementoPres(2) + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
    '                        UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
    '                        Suma = 0 'Se reinicia la 
    '                    End If

    '            End Select
    '        Next
    '        DetallePrestamo = TraerDetallePrestamo(CodPrestamo, 1)
    '        frmMovimientos_detalle.ActualizarHistorial()
    '        If frmMovimientos_detalle.dgvHistorial.RowCount = 0 Then
    '            Dim EstadoPrestamo As Object
    '            EstadoPrestamo = {CodPrestamo, "0", Today & " " & Now.ToString("hh:mm")}
    '            InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
    '            With frmMovimientos_detalle
    '                .btnEntregarTodo.Visible = False
    '                .btnEntregar.Visible = False
    '                .dgvHistorial.Columns(10).Visible = False
    '                .dgvHistorial.Columns(11).Visible = False
    '            End With
    '        End If
    '    End If
    'End Sub

    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================


    Public Function CargarFormulario(codprestamo, codelento, fechapres, tipo, docid, frm)
        dgvHistorial.Rows.Clear()
        Datos = SelectElementoPrestamo(codprestamo, codelento, fechapres, frm)
        tabla = New DataTable
        tabla = Datos.tables("datos")
        Dim Conta As Integer = 0
        For i = 0 To tabla.Rows.Count - 1
            dgvHistorial.Rows.Add()
            dgvHistorial.Rows(Conta).Cells(0).Value = tabla.Rows(i)(0) 'Codigo prestamo
            dgvHistorial.Rows(Conta).Cells(1).Value = tabla.Rows(i)(1) 'Codigo elemento
            dgvHistorial.Rows(Conta).Cells(2).Value = tabla.Rows(i)(2) 'Descripcion
            dgvHistorial.Rows(Conta).Cells(3).Value = tabla.Rows(i)(3) 'Cantidad
            dgvHistorial.Rows(Conta).Cells(4).Value = tabla.Rows(i)(4) 'Fecha Prestamo

            If tabla.Rows(i)(5) Is DBNull.Value Then 'Fecha devolucion
                dgvHistorial.Rows(Conta).Cells(5).Value = ""
            Else
                dgvHistorial.Rows(Conta).Cells(5).Value = tabla.Rows(i)(5)
            End If

            If tabla.Rows(i)(6) Is DBNull.Value Then 'Observaciones
                dgvHistorial.Rows(Conta).Cells(6).Value = ""
            Else
                dgvHistorial.Rows(Conta).Cells(6).Value = tabla.Rows(i)(6)
            End If
            dgvHistorial.Rows(Conta).Cells(7).Value = tabla.Rows(i)(7) 'Estado del elemento entregado
            If tabla.Rows(i)(7) = "2" Then
                dgvHistorial.Rows(Conta).DefaultCellStyle.BackColor = Color.FromArgb(252, 115, 35)
            End If

            dgvHistorial.Rows(Conta).Cells(8).Value = tabla.Rows(i)(8) 'Consecutivo
            dgvHistorial.Rows(Conta).Cells(9).Value = tabla.Rows(i)(9) 'Cantidad entrega
            dgvHistorial.Rows(Conta).Cells(10).Value = tabla.Rows(i)(10) 'TipoElemento
            dgvHistorial.Rows(Conta).Cells(13).Value = tabla.Rows(i)(3) 'Cantidad de Prestamo para validaciones
            Conta = Conta + 1
        Next
        Codigos(0) = codprestamo
        Codigos(1) = codelento
        Codigos(2) = fechapres
        If tipo = 1 Then
            lblTitulo.Text = "Recibir elementos"
            Codigos(3) = docid
            dgvHistorial.Columns(11).Visible = True
            pnlConsumo.Visible = False
            Me.ShowDialog()
        Else
            If tipo = 2 Then
                lblTitulo.Text = "Elementos entregados"
                btnAceptar.Visible = False
                dgvHistorial.Columns(10).Visible = False
                dgvHistorial.Columns(11).Visible = False
                pnlConsumo.Visible = True
                Me.ShowDialog()

            End If
        End If


    End Function

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        frmMovimientos_detalle.tabmovimiento_Click(Nothing, Nothing)
        Me.Close()
    End Sub

    Private Sub frmMovimientos_Detalle_EntregarUno_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgvHistorial.Rows.Clear()
    End Sub

    '============================================================================================================================================

    Private Sub dgvHistorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellContentClick
        If dgvHistorial.RowCount > 0 Then

            Dim CColumna, Fila, Suma As Integer

            CColumna = dgvHistorial.CurrentCell.ColumnIndex

            Select Case CColumna
                Case 11 'Entregar un solo elemento
                    'cuando es devolutivo
                    If dgvHistorial.Rows(Fila).Cells(10).Value = "1" Then
                        'Si la cantidad es mayor a uno (1) se abre un formulario con los elementos y sus respectivas observaciones
                        Fila = dgvHistorial.CurrentRow.Index
                        'Llenar el arreglo  del elemento a descontar
                        ElementoPres(0) = dgvHistorial.Rows(Fila).Cells(0).Value 'Codigo del prestamo
                        ElementoPres(1) = dgvHistorial.Rows(Fila).Cells(1).Value 'Codigo del elemento
                        ElementoPres(2) = dgvHistorial.Rows(Fila).Cells(3).Value 'Cantidad de entrega
                        ElementoPres(3) = dgvHistorial.Rows(Fila).Cells(4).Value 'Fecha de prestamo


                        ElementoPres(4) = Today & " " & Now.ToString("hh:mm") 'Fecha de devolucion

                        'Observaciones
                        If dgvHistorial.Rows(Fila).Cells(6).Value = "" Then
                            ElementoPres(5) = DBNull.Value
                        Else
                            ElementoPres(5) = dgvHistorial.Rows(Fila).Cells(6).Value
                        End If

                        ElementoPres(6) = dgvHistorial.Rows(Fila).Cells(7).Value 'Estado del prestamo_elemento
                        ElementoPres(7) = dgvHistorial.Rows(Fila).Cells(8).Value 'Consecutivo del prestamo_elemento
                        '-------------------------------------------------------------'


                        ElementoPres(2) = dgvHistorial.Rows(Fila).Cells(9).Value + 1 'La cantidad a entregar va a ser igual a uno

                        'Validar si la cantidad a entregar es igual a la cantidad prestada
                        If ElementoPres(2) = dgvHistorial.Rows(Fila).Cells(13).Value Then
                            ElementoPres(6) = "0" 'El elemento prestado es eliminado
                            EntregarElementos(ElementoPres) 'Se actualiza el prestamo del elemento
                            Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                            Suma = 1 + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                            UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                            Suma = 0 'Se reinicia la variable


                        Else
                            If ElementoPres(2) < dgvHistorial.Rows(Fila).Cells(13).Value Then
                                ElementoPres(6) = "1"
                                EntregarElementos(ElementoPres)

                                Datos = SelectElemento(ElementoPres(1), 1) 'Se consulta el elemento actualizado
                                Suma = 1 + Datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                                UpdateDispoElemento(ElementoPres(1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                                Suma = 0 'Se reinicia la variable
                            End If
                        End If
                        'Se carga detalle prestamo nuevamente
                        DetallePrestamo = TraerDetallePrestamo(ElementoPres(0), 1)
                        'Se actualiza el datagrid
                        CargarFormulario(Codigos(0), Codigos(1), Codigos(2), 0, Nothing, 1)
                        frmMovimientos_detalle.ActualizarHistorial()
                        If frmMovimientos_detalle.dgvHistorial.RowCount = 0 Then
                            Dim EstadoPrestamo As Object
                            EstadoPrestamo = {ElementoPres(0), "0", (Today.Date & " " & Now.ToString("hh:mm"))}
                            InsertUpdatePrestamo(EstadoPrestamo, "SP_tblPrestamo_UpdateEstado")
                            frmMovimientos_detalle.btnEntregar.Visible = False
                            frmMovimientos_detalle.btnEntregarTodo.Visible = False
                            frmMovimientos_detalle.dgvHistorial.Columns(10).Visible = False
                            frmMovimientos_detalle.dgvHistorial.Columns(11).Visible = False

                        End If
                    Else
                        Fila = dgvHistorial.CurrentRow.Index
                        ''CUANDO ES CONSUMO
                        With frmMovimientos_EConsumo
                            ReDim .ElementoCons(0, 7)
                            .ElementoCons(0, 0) = dgvHistorial.Rows(Fila).Cells(0).Value
                            .ElementoCons(0, 1) = dgvHistorial.Rows(Fila).Cells(1).Value
                            .ElementoCons(0, 2) = 1
                            .ElementoCons(0, 3) = dgvHistorial.Rows(Fila).Cells(4).Value
                            .ElementoCons(0, 4) = Today & " " & Now.ToString("hh:mm")
                            If dgvHistorial.Rows(Fila).Cells(6).Value = "" Then
                                .ElementoCons(0, 5) = DBNull.Value
                            Else
                                .ElementoCons(0, 5) = dgvHistorial.Rows(Fila).Cells(6).Value
                            End If
                            .ElementoCons(0, 6) = "1" 'Estado de consumo
                            .ElementoCons(0, 7) = dgvHistorial.Rows(Fila).Cells(8).Value 'Consecutivo
                            .CantElementos = 1
                            .swCant = 0
                            .NomElem = dgvHistorial.Rows(Fila).Cells(2).Value 'Nombre del elemento
                            .ShowDialog()
                        End With
                        DetallePrestamo = TraerDetallePrestamo(dgvHistorial.Rows(Fila).Cells(0).Value, 1)
                        CargarFormulario(Codigos(0), Codigos(1), Codigos(2), 0, Nothing, 1)
                        frmMovimientos_detalle.ActualizarHistorial()
                        'Me.Close()
                    End If
            End Select
        End If
    End Sub

    Private Sub dgvHistorial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellClick
        If dgvHistorial.Rows.Count > 0 Then
            If e.RowIndex <> -1 Then
                If dgvHistorial.Rows(e.RowIndex).Cells(7).Value = "2" Then
                    dgvHistorial.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 84, 2)
                End If
            End If
        End If
    End Sub

    Private Sub frmMovimientos_Detalle_EntregarUno_Load(sender As Object, e As EventArgs) Handles Me.Load
        If dgvHistorial.Rows.Count > 0 Then
            If dgvHistorial.Rows(0).Cells(7).Value = "2" Then
                dgvHistorial.Rows(0).DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 84, 2)
            End If
        End If
    End Sub
End Class