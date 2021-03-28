Imports System.IO
Public Class frm_detalle_mora
    Public datos_cliente, fila, cod_mora, swich_entregados, titulo, ruta_archivo, arreglo2 As Object

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Cursor = Cursors.WaitCursor

        ''Descargamos la plantilla con los datos 
        descargar_plantilla_detalle_mora(dgexportar, titulo, datos_cliente)
        Cursor = Cursors.Default
    End Sub

    Private Sub btnregrsar_Click_1(sender As Object, e As EventArgs) Handles btnregrsar.Click
        activos.Visible = True
        check_entregados.Visible = True
        check_entregados.Checked = False
        Me.Close()
    End Sub

    Public Sub check_entregados_CheckedChanged(sender As Object, e As EventArgs) Handles check_entregados.CheckedChanged
        If check_entregados.Checked = True Then
            swich_entregados = 1
            'muestra los elementos que ya entrego el cliente
            datos = tbl_mora_elemento(cod_mora, "sp_tbl_mora_elemento_entregados")
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'Cargamos el datagrid que se expoprta con la misma informacion
            dgexportar.DataSource = datos
            dgexportar.DataMember = "datos"
            titulo = "ELEMENTOS ENTREGADOS POR EL CLIENTE"
            '****************************************************

            dgdatos.Columns(0).Visible = False
            dgdatos.Columns(2).Visible = False
            dgdatos.Columns(3).Visible = False
            dgdatos.Columns(9).Visible = False
            dgdatos.Columns(11).Visible = False
            dgdatos.Columns(12).Visible = False

        Else
            'mostramos los elementos que tiene en mora
            reload()
            swich_entregados = 0
        End If
    End Sub


    Function reload()
        'muestra los elementos que tiene en mora el cliente
        datos = tbl_mora_elemento(cod_mora, "sp_tbl_mora_elemento")
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Cargamos el datagrid que se expoprta con la misma informacion
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"
        titulo = "ELEMENTOS QUE AUN DEBE EL CLIENTE."
        '*********************************

        dgdatos.Columns(0).Visible = True
        dgdatos.Columns(2).Visible = False
        dgdatos.Columns(3).Visible = False
        dgdatos.Columns(8).Visible = False
        dgdatos.Columns(10).Visible = False
        dgdatos.Columns(11).Visible = False



    End Function


    Private Sub frm_detalle_mora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        swich_entregados = 0
    End Sub



    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer


    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================

    Function archivos(fila)

        'Si es 1 quiere decir que estamos en el detalle del historial
        'Validamos que tenga una ruta de PDF
        If dgdatos.Rows(fila).Cells(10 + swich_entregados).Value IsNot DBNull.Value Then
            'Validamos que el archivo exista en la ruta especificada
            If File.Exists(dgdatos.Rows(fila).Cells(10 + swich_entregados).Value) Then
                'Abrimos el archivo PDf
                Process.Start(dgdatos.Rows(fila).Cells(10 + swich_entregados).Value)
            Else
                'Si no se encuentra el archivo en la ruta se informa que debe volver a cargarlo
                MsgBox("El archivo no se encontró en la ruta especificada. Por favor vuelva a cargar el archivo", vbCritical)

                'Obetemos la ruta donde esta el archivo
                Dim archivo As New OpenFileDialog
                archivo.Filter = "Archivo PDF|*.pdf"

                If archivo.ShowDialog = DialogResult.OK Then
                    ruta_archivo = archivo.FileName
                    arreglo2 = {dgdatos.Rows(fila).Cells(11 + swich_entregados).Value, ruta_archivo}
                    tbl_mora_update(arreglo2, "sp_tbl_mora_elemento_update")
                    check_entregados.Checked = False
                    reload()



                End If

            End If

        Else
            'Si no hay ruta en el registro
            MsgBox("El archivo PDF no se ha adjuntado aún. Por favor cargue el archivo.", vbCritical)
            'Obetemos la ruta donde esta el archivo
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo PDF|*.pdf"

            If archivo.ShowDialog = DialogResult.OK Then
                ruta_archivo = archivo.FileName
                arreglo2 = {dgdatos.Rows(fila).Cells(11 + swich_entregados).Value, ruta_archivo}
                tbl_mora_update(arreglo2, "sp_tbl_mora_elemento_update")
                check_entregados.Checked = False
                reload()
            End If
        End If
    End Function


    Private Sub dgdatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellClick

        If e.RowIndex = -1 Then
            Return
        Else
            Select Case e.ColumnIndex
            'Sacamos de mora el elementos
                Case -1
                    Return
                Case 0
                    If MessageBox.Show("Está seguro que el elemento ya fue entregado por el cliente en buen estado. Una vez aceptado, el elemento volverá a estar disponible.", "Devolver elemento", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                        fila = dgdatos.CurrentRow.Index

                        'Obtenemos el valor de disponibles del elemento
                        datos = SelectElemento(dgdatos.Rows(fila).Cells(3).Value, 1)
                        'Sumamos la cantidad que habia disponible y la cantidad que estaba en mora
                        Dim disponible = dgdatos.Rows(fila).Cells(5).Value + datos.rows(0)(2)

                        'actualizos el elemento
                        UpdateDispoElemento(dgdatos.Rows(fila).Cells(3).Value, disponible)
                        MsgBox("El elemento está nuevamente disponible para su uso.", vbInformation)

                        'Cambiamos la fecha de salida y el estado del elemento 
                        arreglo2 = {dgdatos.Rows(fila).Cells(11).Value, Date.Now}
                        tbl_mora_elemento_delete(arreglo2, "sp_tbl_mora_elemento_delete")
                        reload()

                        'Validamos si hay mas elementos en mora
                        fila = dgdatos.Rows.Count
                        If fila = 0 Then
                            arreglo2 = {cod_mora, Date.Now}
                            tbl_mora_delete(arreglo2, "sp_tbl_moral_delete")
                            MsgBox("El cliente ha salido de mora, ya que entregó todos los elementos que debía.", vbInformation)

                            With frm_mora
                                .reload()
                            End With
                        End If
                        'recargamos los datos
                        reload()

                    End If
                Case 1
                    Cursor = Cursors.WaitCursor
                    fila = dgdatos.CurrentRow.Index
                    With frm_mora

                        'Ocultamos el boton del reporte
                        .btnexportar.Visible = False
                        'validamos si el swich_H esta activo
                        If .swich_H = 1 Then
                            'esta funcion me carga los archivos pDF
                            archivos(fila)
                        Else
                            If swich_entregados = 1 Then
                                'esta funcion me carga los archivos pDF
                                archivos(fila)
                            Else
                                'Elementos que aun estan en mora
                                archivos(fila)
                            End If

                        End If
                    End With
                    Cursor = Cursors.Default
            End Select
        End If


    End Sub
End Class