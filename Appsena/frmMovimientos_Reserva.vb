Imports System.ComponentModel

Public Class frmMovimientos_Reserva
    Public ElementosReserva(0, 0) As Object
    Public Datos As Object
    Public Filas As Integer
    Private Function ActualizarINST()
        Datos = reserva_select_fecha_prestamo(Today.Date, "sp_reserva_select_fecha_prestamo")
        tabla = New DataTable
        tabla = Datos.tables("datos")

        For i As Integer = 0 To tabla.Rows.Count - 1
            dgvInstructor.Rows.Add() 'Se agrega una nueva fila
            dgvInstructor.Rows(i).Cells(0).Value = tabla(i)(0) 'Codigo de la reserva
            dgvInstructor.Rows(i).Cells(1).Value = Format(tabla(i)(5), "HH:mm") 'Se saca la hora del prestamo
            dgvInstructor.Rows(i).Cells(2).Value = tabla(i)(1) 'Nombre del instructor que hizo la reserva
            If tabla(i)(7) = 0 Then
                dgvInstructor.Rows(i).Cells(3).Value = "No aplica"
            Else
                dgvInstructor.Rows(i).Cells(3).Value = tabla(i)(7) 'Ficha a la que se hizo la reserva
            End If

        Next
    End Function

    Private Function ActualizarRese()
        dgvElementoInst.Rows.Clear() 'Se limpia el datagrid de los elementos

        If dgvInstructor.RowCount > 0 Then 'Se valida que el data grid tenga registros
            Dim Array(1) As Object 'Se crea un arreglo para guardar los datos
            Array(0) = dgvInstructor.CurrentRow.Index 'Click
            Array(1) = dgvInstructor.Rows(Array(0)).Cells(0).Value 'Codigo de la reserva
            Datos = Reserva_elemento_PK(Array(1), "sp_reserva_elemento_selectPK") 'Consultamos los alementos de la reserva
            tabla = New DataTable 'Nueva instancia de una tabla
            tabla = Datos.tables("datos") 'Se iguala la tabla
            ReDim ElementosReserva((tabla.Rows.Count - 1), 1)
            Filas = tabla.Rows.Count - 1
            'Se llena la tabla con la informacion de la base de datos
            For i As Integer = 0 To tabla.Rows.Count - 1
                dgvElementoInst.Rows.Add() 'Se agrega una fila
                dgvElementoInst.Rows(i).Cells(0).Value = tabla(i)(5) 'Codigo de la reserva
                dgvElementoInst.Rows(i).Cells(1).Value = tabla(i)(1) 'Elemento a prestar
                dgvElementoInst.Rows(i).Cells(2).Value = tabla(i)(2) - tabla(i)(4) 'Cantidad a prestar
                dgvElementoInst.Rows(i).Cells(4).Value = tabla(i)(3) 'Observaciones
                dgvElementoInst.Rows(i).Cells(3).Value = tabla(i)(4) 'Cantidad entrega
                If tabla(i)(2) = 0 Then
                    dgvElementoInst.Rows.RemoveAt(i)
                End If
            Next
        End If
    End Function

    Private Sub frmMovimientos_Reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarINST()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close() 'Se cierra el formulario
    End Sub

    'Se acutaliza los campos cuando el formulario se este cerrando
    Private Sub frmMovimientos_Reserva_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgvElementoInst.Rows.Clear()
        dgvInstructor.Rows.Clear()
    End Sub

    'Se trael el detalle de la reserva despues de seleccionar un instructor o elemnto del datagridview
    Private Sub dgvInstructor_Click(sender As Object, e As EventArgs) Handles dgvInstructor.CellClick
        ActualizarRese()
    End Sub

    Private Sub dgvElementoInst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElementoInst.CellContentClick
        If e.RowIndex = -1 Then
            Return
        Else
            If dgvElementoInst.Rows(e.RowIndex).Cells(2).Value > 0 Then
                Dim CColumna As Integer
                CColumna = dgvElementoInst.CurrentCell.ColumnIndex
                Select Case CColumna
                    Case 5
                        Dim Fila As Integer
                        Fila = dgvInstructor.CurrentRow.Index
                        ActualizarReserva({dgvElementoInst.Rows(e.RowIndex).Cells(0).Value, dgvInstructor.Rows(Fila).Cells(0).Value, (dgvElementoInst.Rows(e.RowIndex).Cells(3).Value + 1)})
                        ActualizarRese()
                End Select
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If dgvElementoInst.Rows.Count > 0 Then
            'SE RECORRE EL DATAGRID DE LOS ELEMENTOS RESERVADOS Y SI LA CANTIDAD RESERVADA ES IGUAL A CERO, SE ELIMINA LA RESERVA
            Dim ContaValidar As Integer
            For Each dgvfila As DataGridViewRow In dgvElementoInst.Rows
                If dgvfila.Cells(2).Value = 0 Then
                    ContaValidar = ContaValidar + 1
                End If
            Next

            'Se valida si la cantidad de elementos reservados que estan en cero es igual a la cantidad de los elementos reservados
            If ContaValidar = dgvElementoInst.Rows.Count Then
                'Se actualiza el estado de la reserva a entregado
                UpdateEstadoReserva({dgvInstructor.Rows(dgvInstructor.CurrentRow.Index).Cells(0).Value, "3"})
            End If
            Me.Close()
        End If
    End Sub
End Class