Public Class frmMovimientos_DuplicarMovim
    Dim Click, Contador, Resta As Integer
    Dim SwClick As Byte

    Public Datos As Object
    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        dgvUsuarios.Rows.Clear()
        dgvElementoUsuario.Rows.Clear()

        Me.Close()
    End Sub

    Private Sub frmDuplicarMovi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDuplicarPrestamo.Value = Today.Date
        Dim Fecha As Date
        If dtpDuplicarPrestamo.Value = Today.Date Then
            Fecha = Today.Date
        Else
            Fecha = dtpDuplicarPrestamo.Value
        End If
        dgvUsuarios.Rows.Clear()
        txtBuscador.Text = ""
        Datos = BuscadorPrestamo({txtBuscador.Text, Fecha}, "sp_tblPrestamo_Buscador")
        tabla = New DataTable
        tabla = Datos.tables("datos")
        For i = 0 To tabla.Rows.Count - 1
            dgvUsuarios.Rows.Add()
            dgvUsuarios.Rows(i).Cells(0).Value = tabla.Rows(i)(0)
            dgvUsuarios.Rows(i).Cells(1).Value = tabla.Rows(i)(1)
            dgvUsuarios.Rows(i).Cells(2).Value = tabla.Rows(i)(2)
            dgvUsuarios.Rows(i).Cells(3).Value = tabla.Rows(i)(3)
        Next
    End Sub

    Private Sub txtBuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscador.KeyUp
        dgvUsuarios.Rows.Clear()
        Dim Fecha As Date
        If dtpDuplicarPrestamo.Value = Today.Date Then
            Fecha = Today.Date.AddDays(-1)
        Else
            Fecha = dtpDuplicarPrestamo.Value
        End If

        Datos = BuscadorPrestamo({txtBuscador.Text, Fecha}, "sp_tblPrestamo_Buscador")
        tabla = New DataTable
        tabla = Datos.tables("datos")

        For i = 0 To tabla.Rows.Count - 1
            dgvUsuarios.Rows.Add()
            dgvUsuarios.Rows(i).Cells(0).Value = tabla.Rows(i)(0)
            dgvUsuarios.Rows(i).Cells(1).Value = tabla.Rows(i)(1)
            dgvUsuarios.Rows(i).Cells(2).Value = tabla.Rows(i)(2)
            dgvUsuarios.Rows(i).Cells(3).Value = tabla.Rows(i)(3)
        Next
    End Sub

    Public Function ActualizarElementos(validacion)
        Dim Conta As Integer
        'Se crea la condicion para no limpiar el datagrid cuando hay varios prestamos seleccionados
        If validacion = 1 Then
            dgvElementoUsuario.Rows.Clear() 'Se limpia el datagridview
            Conta = 0
        Else
            Conta = dgvElementoUsuario.Rows.Count
        End If
        Dim index As Integer 'Variable para guardar el index de una fila
        Dim swCodigo, swFecha, swCase As Byte

        'Nueva instancia de una datatable
        tabla = New DataTable
        'Valor de la tabla
        tabla = DetallePrestamo.tables("datos")
        'Cantidad de filas de la tabla convertida a posiciones
        Dim Filas = tabla.Rows.Count - 1
        'Recorrer la tabla y agregar a un datagridview las filas de la tabla
        'Se recorre la tabla
        For h = 0 To Filas
            'Validamos si hay filas en el dgvelementousuario
            If dgvElementoUsuario.Rows.Count = 0 Then
                dgvElementoUsuario.Rows.Add()
                dgvElementoUsuario.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo elemento
                dgvElementoUsuario.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Descripcion
                dgvElementoUsuario.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Cantidad
                Conta = Conta + 1
            Else
                'Se activa el swCase para entrar a las validaciones posteriormente
                swCase = 1
                'Se recorre el dgvelementousuario
                For k = 0 To dgvElementoUsuario.Rows.Count - 1
                    'Validamos si el registro en la tabla ya está en el dgvelementousuario por medio del codigo
                    If tabla.Rows(h)(0) = dgvElementoUsuario.Rows(k).Cells(0).Value Then 'Codigo
                        swCodigo = 1 'Se activa el swCodigo
                        index = k
                        Exit For
                    Else
                        swCodigo = 0 'Se desactiva el swCodigo cuando el codigo del elemento en la tabla no existe en el dgvelementousuario
                    End If
                Next
            End If
            'Validar si se recorrio el dgvelementousuario
            If swCase = 1 Then
                Select Case swCodigo
                    Case 1
                        dgvElementoUsuario.Rows(index).Cells(2).Value = dgvElementoUsuario.Rows(index).Cells(2).Value + tabla.Rows(h)(2)
                    Case 0
                        dgvElementoUsuario.Rows.Add()
                        dgvElementoUsuario.Rows(Conta).Cells(0).Value = tabla.Rows(h)(0) 'Codigo elemento
                        dgvElementoUsuario.Rows(Conta).Cells(1).Value = tabla.Rows(h)(1) 'Descripcion
                        dgvElementoUsuario.Rows(Conta).Cells(2).Value = tabla.Rows(h)(2) 'Cantidad
                        Conta = Conta + 1
                End Select
                swCodigo = 0
            End If
        Next
    End Function

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If SwClick = 0 Then
            SwClick = 1
        End If

        Select Case SwClick
            Case 1 'Cuando es el primer click
                If dgvUsuarios.Rows(e.RowIndex).Cells(4).Value = CheckState.Unchecked Then
                    dgvUsuarios.Rows(e.RowIndex).Cells(4).Value = CheckState.Checked
                    DetallePrestamo = Select_1ParametroInt("sp_tblprestamo_detalleDupli", dgvUsuarios.Rows(e.RowIndex).Cells(0).Value)
                    ActualizarElementos(1)
                    SwClick = 2
                End If

            Case 2 'Cuando es el segundo click
                If dgvUsuarios.Rows(e.RowIndex).Cells(4).Value = CheckState.Unchecked Then
                    dgvUsuarios.Rows(e.RowIndex).Cells(4).Value = CheckState.Checked
                    DetallePrestamo = Select_1ParametroInt("sp_tblprestamo_detalleDupli", dgvUsuarios.Rows(e.RowIndex).Cells(0).Value)
                    ActualizarElementos(0)
                Else
                    dgvUsuarios.Rows(e.RowIndex).Cells(4).Value = CheckState.Unchecked
                    Dim Datos As Object
                    Datos = Select_1ParametroInt("sp_tblprestamo_detalleDupli", dgvUsuarios.Rows(e.RowIndex).Cells(0).Value)
                    tabla = New DataTable
                    tabla = Datos.tables("datos")
                    For i As Integer = 0 To tabla.Rows.Count - 1
                        For Each dgvfila As DataGridViewRow In dgvElementoUsuario.Rows
                            If tabla.Rows(i)(0) = dgvfila.Cells(0).Value Then
                                dgvfila.Cells(2).Value = dgvfila.Cells(2).Value - tabla.Rows(i)(2)
                                If dgvfila.Cells(2).Value = "0" Then
                                    dgvElementoUsuario.Rows.RemoveAt(dgvfila.Index)
                                End If
                            End If
                        Next
                    Next
                End If
        End Select

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvElementoUsuario.Rows.Clear()
        dgvUsuarios.Rows.Clear()
        dgvDuplicar.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub btnDuplicarPrestamo_Click(sender As Object, e As EventArgs) Handles btnDuplicarPrestamo.Click
        Contador = 0
        For Each dgvfila As DataGridViewRow In dgvElementoUsuario.Rows
            Datos = SelectElemento(dgvfila.Cells(0).Value, 0)
            tabla = New DataTable
            tabla = Datos.tables("datos")
            'MsgBox(tabla.Rows(0)(2) & " | " & dgvfila.Cells(2).Value)
            If tabla.Rows(0)(2) >= dgvfila.Cells(2).Value Then
                dgvDuplicar.Rows.Add()
                dgvDuplicar.Rows(Contador).Cells(0).Value = dgvfila.Cells(0).Value
                dgvDuplicar.Rows(Contador).Cells(1).Value = dgvfila.Cells(1).Value
                dgvDuplicar.Rows(Contador).Cells(2).Value = dgvfila.Cells(2).Value
                dgvDuplicar.Rows(Contador).Cells(3).Value = ""
                dgvDuplicar.Rows(Contador).Cells(4).Value = Today.Date & " " & Now.ToString("hh:mm")
                dgvDuplicar.Rows(Contador).Cells(5).Value = ""
                dgvDuplicar.Rows(Contador).Cells(6).Value = tabla.Rows(0)(3)
                Contador = Contador + 1
            End If
        Next

        FilasDupli = dgvDuplicar.Rows.Count - 1
        ReDim MTElementos(FilasDupli, 6)
        For i As Integer = 0 To FilasDupli
            For j As Integer = 0 To 5
                MTElementos(i, j) = dgvDuplicar.Rows(i).Cells(j).Value
            Next
        Next

        dgvDuplicar.Rows.Clear()
        SwFrm = 1
        frmMovimientos_DuplicarPrestamo.Label1.Text = "Duplicar prestamo"
        frmMovimientos_DuplicarPrestamo.ShowDialog()
    End Sub

    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    Private Sub btnBorrarTodo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnBorrarTodo.LinkClicked
        dgvElementoUsuario.Rows.Clear()
        For i As Integer = 0 To dgvUsuarios.Rows.Count - 1
            If dgvUsuarios.Rows(i).Cells(4).Value = CheckState.Checked Then
                dgvUsuarios.Rows(i).Cells(4).Value = CheckState.Unchecked
            End If
        Next
        SwClick = 0
    End Sub

    Private Sub dgvElementoUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElementoUsuario.CellContentClick
        Select Case e.ColumnIndex
            Case 3
                dgvElementoUsuario.Rows.RemoveAt(e.RowIndex)
        End Select
    End Sub

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

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class