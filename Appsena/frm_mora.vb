Imports System.IO
Public Class frm_mora
    Public datos, arreglo, cod_mora, swich_H, titulo As Object
    Private Sub frm_mora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
        swich_H = 0
        txtbuscador.Focus()
    End Sub

    Function reload()
        titulo = "CLIENTES ACTUALMENTE EN MORA."
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_mora_select")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Cargamos el datagrid que se expoprta con la misma informacion
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"

        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(6).Visible = False


        For i = 0 To dgdatos.Rows.Count - 1
            If dgdatos.Rows(i).Cells(8).Value = 0 Then
                dgdatos.Rows(i).Cells(8).Value = "No"
                dgdatos.Rows(i).Cells(8).Style.ForeColor = Color.Red
            Else
                dgdatos.Rows(i).Cells(8).Value = "Si"
                dgdatos.Rows(i).Cells(8).Style.ForeColor = Color.Green
            End If
        Next


    End Function

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        If swich_H = 1 Then

            'Buscamos los elementos saldados
            datos = Select_1ParametroInt("sp_tbl_mora_select_saldadosPK", txtbuscador.Text)
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'Cargamos el datagrid que se expoprta con la misma informacion
            dgexportar.DataSource = datos
            dgexportar.DataMember = "datos"

            dgdatos.Columns(0).Visible = False
            dgdatos.Columns(6).Visible = True

        Else
            'Buscador automatico
            datos = Select_1ParametroInt("sp_tbl_mora_select_PK2", txtbuscador.Text)
            dgdatos.DataSource = datos
            dgdatos.DataMember = "datos"

            'Cargamos el datagrid que se expoprta con la misma informacion
            dgexportar.DataSource = datos
            dgexportar.DataMember = "datos"

            dgdatos.Columns(0).Visible = False
            dgdatos.Columns(6).Visible = False

        End If


        For i = 0 To dgdatos.Rows.Count - 1
            If dgdatos.Rows(i).Cells(8).Value = 0 Then
                dgdatos.Rows(i).Cells(8).Value = "No"
                dgdatos.Rows(i).Cells(8).Style.ForeColor = Color.Red
            Else
                dgdatos.Rows(i).Cells(8).Value = "Si"
                dgdatos.Rows(i).Cells(8).Style.ForeColor = Color.Green
            End If
        Next


    End Sub

    Public Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'Obtenemos la fila en la cual se dio el dobleclick 
        Dim fila = dgdatos.CurrentRow.Index

        If swich_H = 1 Then
            'enviamos los datos la formulario que mostrar el detalle del historial de la mora
            With frm_detalle_mora
                .cod_mora = dgdatos.Rows(fila).Cells(0).Value
                .lblcliente.Text = dgdatos.Rows(fila).Cells(2).Value
                .activos.Visible = False
                .check_entregados.Visible = False
                .check_entregados.Checked = True

                'este arreglo nos servira para mostrar los datos del cliente en el reporte de excel del detalle de la mora
                .datos_cliente = {dgexportar.Rows(fila).Cells(1).Value,'Documento
                            dgexportar.Rows(fila).Cells(2).Value, 'Nombre
                            dgexportar.Rows(fila).Cells(3).Value, 'ficha
                            dgexportar.Rows(fila).Cells(4).Value'Porgrama
                            }

                .check_entregados_CheckedChanged(Nothing, Nothing)
                .ShowDialog()
            End With

        Else
            'enviamos los datos la formulario que mostrar el detalle de la mora
            With frm_detalle_mora
                'Nombre del cliente 
                .lblcliente.Text = dgdatos.Rows(fila).Cells(2).Value
                .cod_mora = dgdatos.Rows(fila).Cells(0).Value
                .check_entregados.Checked = False

                'este arreglo nos servira para mostrar los datos del cliente en el reporte de excel del detalle de la mora
                .datos_cliente = {dgexportar.Rows(fila).Cells(1).Value,'Documento
                    dgexportar.Rows(fila).Cells(2).Value, 'Nombre
                    dgexportar.Rows(fila).Cells(3).Value, 'ficha
                    dgexportar.Rows(fila).Cells(4).Value'Porgrama
                    }

                .reload()
                .ShowDialog()
            End With
        End If




    End Sub

    Private Sub ClientesEnMoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesEnMoraToolStripMenuItem.Click

        reload() 'cargamos las moras activas
        swich_H = 0
        lblmora.Visible = True
        lblsaldado.Visible = False

    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Cursor = Cursors.WaitCursor
        ''Descargamos la plantilla con los datos 
        descargar_plantilla_bajas(dgexportar, titulo)
        Cursor = Cursors.Default

    End Sub

    Private Sub HistorialDeMorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HisorialDeMorasToolStripMenuItem.Click
        titulo = "HISTORIAL DE CLIENTES QUE ESTUVIERON EN MORA." 'titulo que enviamos a la funcion exportar excel
        lblmora.Visible = False
        lblsaldado.Visible = True
        swich_H = 1
        'Cargamos los datos desde la funcion a la cual enviamos el procedimiento
        datos = CargarDatos("sp_tbl_mora_saldados")
        'los datos que recivimos de la funcion los mostramos en el datagrid
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        'Cargamos el datagrid que se expoprta con la misma informacion
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"

        dgdatos.Columns(0).Visible = False
        dgdatos.Columns(6).Visible = True


        lblmora.Visible = False
        lblsaldado.Visible = True

    End Sub

    Private Sub btnregrsar_Click(sender As Object, e As EventArgs)
        btnexportar.Visible = True 'botton de exportar excel
        dgdatos_DoubleClick(Nothing, Nothing)

    End Sub

End Class