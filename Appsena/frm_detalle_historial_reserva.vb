Public Class frm_detalle_historial_reserva
    Public codreserva, fila As Object

    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub

    Private Sub dgdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================



    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        pnlfoto.Image = Nothing
        dgdatos.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub frm_detalle_historial_reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datos = Reserva_elemento_PK(codreserva, "sp_reserva_elemento_selectPK") 'Consultamos los alementos de la reserva
        tabla = New DataTable
        tabla = datos.tables("datos")

        fila = tabla.Rows.Count

        'Llebamos el datagrid con los elemetntos de la reserva
        For i = 0 To fila - 1
            dgdatos.Rows.Add()
            dgdatos.Rows(i).Cells(0).Value = tabla(i)(1)
            dgdatos.Rows(i).Cells(1).Value = tabla(i)(2)
            dgdatos.Rows(i).Cells(2).Value = tabla(i)(3)
        Next
    End Sub
End Class