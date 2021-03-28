Imports System.IO
Public Class frm_bajas
    Dim swich_H, swich_A, arreglo, swich_D, row, titulo, swich_C As Object
    Private Sub frm_bajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Controls
            AddHandler control.MouseClick, AddressOf frm_bajas__Click
        Next
        txtbuscador.Focus()
        'Fecha actual para los contorles datetime picker
        picker_dia_inicial.Value = Date.Now
        picker_dia_final.Value = Date.Now
    End Sub

    'Este Sub permite cerrar el panel de configuracion si se encuentra abierto
    Private Sub frm_bajas__Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If frmDashBoard.pnlConfiguracion.Visible = True Then
            frmDashBoard.pnlConfiguracion.Visible = False
        End If
    End Sub

    Public Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        titulo = "HISTORIAL DE ELEMENTOS QUE ESTUVIERON EN BAJA."
        'se mostraran el historial de los elementos que han estado en baja
        datos = Select_1ParametroInt("sp_tbl_bajas_select", txtbuscador.Text)
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'datagrid oculto que se utiliza para exportar a excel
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"


        dgdatos.Columns(0).Visible = False 'Celda para eliminar el elemento
        dgdatos.Columns(1).Visible = True 'celda para ver el PDF
        dgdatos.Columns(2).Visible = False 'codigo de la baja
        dgdatos.Columns(7).Visible = True 'fecah de reintegro
        dgdatos.Columns(10).Visible = False 'ruta del pdf
        lblestado.Text = "Historial de elementos que estuvieron en baja."

        'colocamos el swich en 1
        swich_H = 1
        'colocamos el otro swich en 0
        swich_A = 0
        'colocamos el otro swich en 0
        swich_D = 0


        'Hacemos visisble el group con los tipos de bajas
        group_tipos.Visible = True

    End Sub

    Public Sub BajasActualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasActualesToolStripMenuItem.Click
        titulo = "ELEMENTOS EN BAJA TEMPORAL."
        'Ocualtamos el group con las bajas
        group_tipos.Visible = False
        pnl_fechas.Visible = False
        'se mostraran lo elementos que actualmente estan en baja
        datos = Select_1ParametroInt("sp_tbl_bajas_selectPK", txtbuscador.Text)
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'datagrid oculto que se utiliza para exportar a excel
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"

        dgdatos.Columns(0).Visible = True
        dgdatos.Columns(1).Visible = False
        dgdatos.Columns(2).Visible = False
        dgdatos.Columns(7).Visible = False
        dgdatos.Columns(10).Visible = False 'ruta del pdf
        dgdatos.Columns(3).Visible = True
        lblestado.Text = "Elementos actualmente en baja temporal."
        'colocamos el swich en 1
        swich_A = 1
        'colocamos el otro swich en 0
        swich_H = 0
        'colocamos el otro swich en 0
        swich_D = 0
    End Sub

    Private Sub check_reintegros_CheckedChanged(sender As Object, e As EventArgs) Handles check_reintegros.CheckedChanged
        If check_reintegros.Checked = True Then

            check_definitivas.Checked = False
            'se mostraran el historial de los elementos que han estado en baja
            datos = Select_1ParametroInt("sp_tbl_bajas_select_reintegrados", txtbuscador.Text)
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'datagrid oculto que se utiliza para exportar a excel
            dgexportar.DataSource = datos
            dgexportar.DataMember = "datos"
            titulo = "ELEMENTOS REINTEGRADOS."

            dgdatos.Columns(0).Visible = False 'Celda para eliminar el elemento
            dgdatos.Columns(1).Visible = False 'celda para ver el PDF
            dgdatos.Columns(2).Visible = False 'codigo de la baja
            dgdatos.Columns(7).Visible = True 'fecah de reintegro
            dgdatos.Columns(10).Visible = False 'ruta del pdf
        Else
            'Cargamos de nuevo el historial de bajas
            HistorialToolStripMenuItem_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub check_definitivas_CheckedChanged(sender As Object, e As EventArgs) Handles check_definitivas.CheckedChanged
        If check_definitivas.Checked = True Then

            check_reintegros.Checked = False
            'se mostraran el historial de los elementos que han estado en baja
            datos = Select_1ParametroInt("sp_tbl_bajas_select_definitivos", txtbuscador.Text)
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'datagrid oculto que se utiliza para exportar a excel
            dgexportar.DataSource = datos
            dgexportar.DataMember = "datos"
            titulo = "ELEMENTOS EN BAJA DEFINITIVA."

            dgdatos.Columns(0).Visible = False 'Celda para eliminar el elemento
            dgdatos.Columns(1).Visible = True 'celda para ver el PDF
            dgdatos.Columns(2).Visible = False 'codigo de la baja
            dgdatos.Columns(7).Visible = False 'fecah de reintegro
            dgdatos.Columns(10).Visible = False 'ruta del pdf
        Else
            'Cargamos de nuevo el historial de bajas
            HistorialToolStripMenuItem_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub btnregrsar_Click(sender As Object, e As EventArgs)
        btnexportar.Visible = True
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        'Buscamos los datos entre las dos fechas seleccionadas
        arreglo = {txtbuscador.Text, picker_dia_inicial.Value, picker_dia_final.Value}
        datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_elementos_consumidos")
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"
    End Sub

    Public Sub ElementosConsumidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementosConsumidosToolStripMenuItem.Click
        'Elementos consumidos 
        swich_C = 1
        dgdatos.Columns(1).Visible = False
        lblestado.Text = "Elementos consumidos"
        titulo = "ELEMENTOS CONSUMIDOS"
        group_tipos.Visible = False
        pnl_fechas.Visible = True
        pnl_fechas.Visible = True

        arreglo = {txtbuscador.Text, picker_dia_inicial.Value, picker_dia_final.Value}
        datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_elementos_consumidos")
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        dgdatos.Columns(0).Visible = False

    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Cursor = Cursors.WaitCursor
        ''Descargamos la plantilla con los datos 
        descargar_plantilla_bajas(dgexportar, titulo)
        Cursor = Cursors.Default
    End Sub

    Private Sub dgdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick

        If e.RowIndex = -1 Then
            Return
        Else
            Select Case e.ColumnIndex
                Case 0
                    row = dgdatos.CurrentRow.Index
                    'Validamos qu si se desee sacar el elemnto de las bajas
                    If MessageBox.Show("Esta seguro que desea sacar el elemento de las bajas? Al hacerlo volverá a estar disponible para los préstamos.", "Sacar elemento de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                        ''se inserta la fecha de reintegro
                        arreglo = {dgdatos.Rows(row).Cells(2).Value, Date.Now}
                        tbl_bajas_update(arreglo, "sp_tbl_bajas_update")

                        'consultamos si el elemento tiene estado 0
                        datos = Select_1ParametroInt("sp_tbl_elementos_select2", dgdatos.Rows(row).Cells(3).Value)
                        tabla = New DataTable
                        tabla = datos.tables("datos")

                        If tabla.Rows.Count > 0 Then
                            'cambiamos la disponibilida del elemento
                            UpdateDispoElemento(dgdatos.Rows(row).Cells(3).Value, tabla(0)(5) + dgdatos.Rows(row).Cells(8).Value)
                            BajasActualesToolStripMenuItem_Click(Nothing, Nothing)
                            MsgBox("Se sacó de baja exitosamente el elemento", vbInformation)
                        Else
                            'cambiamos el estado del elemento a 1
                            arreglo = {dgdatos.Rows(row).Cells(3).Value, "1"}
                            tbl_elementos_delete(arreglo, "sp_tbl_elemento_delete", "sacó de baja ")
                            BajasActualesToolStripMenuItem_Click(Nothing, Nothing)
                        End If

                    End If

                Case 1
                    Cursor = Cursors.WaitCursor
                    row = dgdatos.CurrentRow.Index
                    'validamos que el registro tenga informacion
                    btnexportar.Visible = False
                    If dgdatos.Rows(row).Cells(10).Value IsNot DBNull.Value Then
                        If File.Exists(dgdatos.Rows(row).Cells(10).Value) Then
                            Process.Start(dgdatos.Rows(row).Cells(10).Value)
                        Else
                            MsgBox("No se encontro el archivo PDF", vbCritical)
                        End If
                    Else
                        MsgBox("No se adjunto el archivo PDF", vbCritical)
                    End If
                    Cursor = Cursors.Default

            End Select
        End If



    End Sub

    Public Sub BajasDefinitivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasDefinitivasToolStripMenuItem.Click
        titulo = "ELEMENTOS EN BAJA DEFINITIVA."
        'Ocualtamos el group con los tipos de  bajas
        group_tipos.Visible = False
        pnl_fechas.Visible = False
        'se mostraran lo elementos que actualmente estan en baja
        datos = Select_1ParametroInt("sp_tbl_bajas_definitivas_selectPK_", txtbuscador.Text)
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'datagrid oculto que se utiliza para exportar a excel
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"

        dgdatos.Columns(0).Visible = False 'Celda para eliminar el elemento
        dgdatos.Columns(1).Visible = True 'celda para ver el PDF
        dgdatos.Columns(7).Visible = False 'fecah de reintegro
        dgdatos.Columns(10).Visible = False 'ruta del pdf
        dgdatos.Columns(2).Visible = False 'coidgo de la baja
        lblestado.Text = "Elementos  en baja definitiva."
        'colocamos el swich en 1
        swich_A = 0
        'colocamos el otro swich en 0
        swich_H = 0
        'colocamos el otro swich en 0
        swich_D = 1
    End Sub

    Public Sub items_historial_Click(sender As Object, e As EventArgs) Handles items_historial.Click
        'Abrimos el formulario de buscar elemento
        With frm_buscar_elemento
            .ShowDialog()
        End With
    End Sub

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        If swich_A = 1 Then
            titulo = "ELEMENTOS EN BAJA TEMPORAL."
            'Mostramos los elementos que actualmente estan en baja
            datos = Select_1ParametroInt("sp_tbl_bajas_selectPK", txtbuscador.Text)
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'datagrid oculto que se utiliza para exportar a excel
            dgexportar.DataSource = datos
            dgexportar.DataMember = "datos"

            dgdatos.Columns(0).Visible = True 'celda para eliminar de la baja
            dgdatos.Columns(1).Visible = False 'celda para ver pdf
            dgdatos.Columns(2).Visible = False 'codigo de la baja
            dgdatos.Columns(7).Visible = False 'fecha de reintegro

        Else
            If swich_H = 1 Then
                'Mostramos las bajas reintegradas
                If check_reintegros.Checked = True Then
                    titulo = "ELEMENTOS REINTEGRADOS."
                    datos = Select_1ParametroInt("sp_tbl_bajas_select_reintegrados", txtbuscador.Text)
                    dgdatos.DataSource = datos
                    dgdatos.DataMember = "datos"

                    'datagrid oculto que se utiliza para exportar a excel
                    dgexportar.DataSource = datos
                    dgexportar.DataMember = "datos"

                    dgdatos.Columns(1).Visible = False 'celda para ver el PDF
                Else
                    'mostramos las bajas definitivas
                    If check_definitivas.Checked = True Then
                        titulo = "ELEMENTOS EN BAJA DEFINITIVA."
                        datos = Select_1ParametroInt("sp_tbl_bajas_select_definitivos", txtbuscador.Text)
                        dgdatos.DataSource = datos
                        dgdatos.DataMember = "datos"

                        'datagrid oculto que se utiliza para exportar a excel
                        dgexportar.DataSource = datos
                        dgexportar.DataMember = "datos"

                        dgdatos.Columns(7).Visible = False 'fecah de reintegro
                        dgdatos.Columns(1).Visible = True 'celda para ver pdf
                    Else
                        'mostramos el historial de los elementos que estuvieron en baja
                        titulo = "HISTORIAL DE ELEMENTOS QUE ESTUVIERON EN BAJA."
                        datos = Select_1ParametroInt("sp_tbl_bajas_select", txtbuscador.Text)
                        dgdatos.DataSource = datos
                        dgdatos.DataMember = "datos"

                        'datagrid oculto que se utiliza para exportar a excel
                        dgexportar.DataSource = datos
                        dgexportar.DataMember = "datos"

                        dgdatos.Columns(1).Visible = True 'celda para ver pdf
                    End If

                End If

                dgdatos.Columns(0).Visible = False 'celda para eliminar de la baja
                dgdatos.Columns(2).Visible = False 'codigo de la baja
                dgdatos.Columns(7).Visible = True 'fecha de reintegro
                dgdatos.Columns(10).Visible = False 'pdf


            Else
                If swich_D = 1 Then
                    titulo = "ELEMENTOS EN BAJA DEFINITIVA."
                    'Mostramos las bajas definitivas
                    datos = Select_1ParametroInt("sp_tbl_bajas_definitivas_selectPK_", txtbuscador.Text)
                    dgdatos.DataSource = datos
                    dgdatos.DataMember = "datos"

                    'datagrid oculto que se utiliza para exportar a excel
                    dgexportar.DataSource = datos
                    dgexportar.DataMember = "datos"

                    dgdatos.Columns(0).Visible = False 'celda para eliminar de la baja
                    dgdatos.Columns(1).Visible = True 'celda  para ver el pdf
                    dgdatos.Columns(7).Visible = False 'fecha de reintegro

                    dgdatos.Columns(2).Visible = False 'codigo de la baja
                Else
                    If swich_C = 1 Then
                        arreglo = {txtbuscador.Text, picker_dia_inicial.Value, picker_dia_final.Value}
                        datos = tbl_logeo_select_fechas(arreglo, "sp_tbl_elementos_consumidos")
                        dgexportar.DataSource = datos
                        dgexportar.DataMember = "datos"
                        dgdatos.DataSource = datos
                        dgdatos.DataMember = "datos"
                    End If
                End If
            End If
        End If
    End Sub


End Class