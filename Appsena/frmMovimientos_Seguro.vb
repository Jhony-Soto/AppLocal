Imports System.ComponentModel

Public Class frmMovimientos_Seguro
    Dim CFDev, CFCon, ContadorValidar(1) As Integer

    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        TipoPres_Traspaso = frmMovimientos_detalle.cmbTipoPrestamo.SelectedValue
        Me.Close()
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub

    '==================================================================================================
    'Funcion para generar un libro de excel con los elementos para una mejor manipulacion
    Private Function GenerarDGVElementos(btn)
        'Se carga unos datagrids que contienen los elementos que se van a retirar
        With frmMovimientos_detalle
            'Se llena dos datagrids ocultos que permiten controlar los elementos en un libro de excel
            For Each dgvfila As DataGridViewRow In .dgvElementosPrestados.Rows
                Select Case dgvfila.Cells(8).Value
                    Case 1 'Es devolutivo
                        dgvEDevolutivos.Rows.Add()
                        For i = 0 To 2
                            dgvEDevolutivos.Rows(CFDev).Cells(i).Value = dgvfila.Cells(i).Value
                        Next
                        CFDev = CFDev + 1
                    Case 2 'Es de consumo
                        dgvEConsumos.Rows.Add()
                        For i = 0 To 2
                            dgvEConsumos.Rows(CFCon).Cells(i).Value = dgvfila.Cells(i).Value
                        Next
                        CFCon = CFCon + 1
                End Select
            Next
        End With
        'Se ejecuta la funcion que permite exportar los elementos
        plantilla_elementos_prestamo_externo(dgvEDevolutivos, dgvEConsumos)

        tabla = New DataTable
        tabla = RutaFotos() 'Se consulta la ruta de los elementos
        'Se valida el boton en foco
        If btn Is btnGenerarSa Then
            'Abre el formato de salida establecido
            If System.IO.File.Exists(tabla.Rows(0)(11)) Then
                Process.Start(tabla.Rows(0)(11))
            Else
                MessageBox.Show("El archivo no existe o la ruta establecida no es la correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'Abre el formato de salida establecido
            If System.IO.File.Exists(tabla.Rows(0)(12)) Then
                Process.Start(tabla.Rows(0)(12))
            Else
                MessageBox.Show("El archivo no existe o la ruta establecida no es la correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        dgvEConsumos.Rows.Clear()
        dgvEDevolutivos.Rows.Clear()
        CFDev = 0
        CFCon = 0
    End Function

    Private Function SubirFormato(btn)
        Dim result As New OpenFileDialog
        Dim Ruta As String
        ' Test result.
        If result.ShowDialog = DialogResult.OK Then
            Ruta = result.FileName
        End If
        With frmMovimientos_detalle
            If btn Is btnSubirSa Then

                .VPrestamo(10) = Ruta
                ContadorValidar(0) = 1
            Else
                If lblFormato1.Text = "Constancia de traspaso:" Then
                    TipoPres_Traspaso = 6
                End If
                .VPrestamo(7) = Ruta
                .VPrestamo(8) = DBNull.Value
                .VPrestamo(9) = DBNull.Value
                'HAY QUE VALIDAR: SI ES LA PRIMERA VEZ QUE HACE EL PRESTAMO EXTERNO LOS SEGURO2 Y SEGURO3 SON NULOS
                'SI SE VA A RENOVAR VALIDAR SI LOS SEGUROS ANTERIORES TIENEN DATOS Y EL QUE NO TENGA SE INSERTA
                ContadorValidar(1) = 1
            End If
        End With
    End Function


    Private Sub btnSubirSeg_Click(sender As Object, e As EventArgs) Handles btnSubirSeg.Click
        SubirFormato(btnSubirSeg)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ContadorValidar(0) = 1 And ContadorValidar(1) = 1 Then 'Se valida si los dos formatos requieridos para el prestamo externo se subieron
            Cerradura = 1 'Si se subieron se activa un swiche que continua con el prestamo
            With frmMovimientos_detalle
                If .VPrestamo(7) <> Nothing And .VPrestamo(10) <> Nothing Then
                    '.btnSeguro.Image = My.Resources.icons8_protect_64
                    .SwSeguro = 0
                End If
            End With
            If lblFormato1.Text = "Constancia de traspaso:" Then
                IsTraspaso = 1
            Else
                IsTraspaso = 0
            End If
        Else
            Cerradura = 0 'Se desactiva el suiche que continua con el prestamo
        End If
        Me.Close()
    End Sub

    Private Sub btnGenerarSeg_Click(sender As Object, e As EventArgs) Handles btnGenerarSeg.Click
        GenerarDGVElementos(btnGenerarSeg)
    End Sub

    Private Sub btnSubirSa_Click(sender As Object, e As EventArgs) Handles btnSubirSa.Click
        SubirFormato(btnSubirSa)
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub btnGenerarSa_Click(sender As Object, e As EventArgs) Handles btnGenerarSa.Click
        'Se ejecuta la funcion que carga un libro de excel con los elementos y abre el respectivo formato
        GenerarDGVElementos(btnGenerarSa)
    End Sub

    Private Sub frmMovimientos_Seguro_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        lblFormato1.Text = "Formato de seguro:"
        dgvEConsumos.Rows.Clear()
        dgvEDevolutivos.Rows.Clear()
        CFDev = 0
        CFCon = 0
    End Sub
End Class