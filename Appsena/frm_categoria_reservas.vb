Public Class frm_categoria_reservas
    Dim colores, arreglo, datos, fila, codigo As Object
    Private Sub btncolor_Click(sender As Object, e As EventArgs) Handles btncolor.Click
        'Obtenemos el color del colordialog
        With color_categoria
            .ShowDialog()
            btncolor.BaseColor = .Color
            btncolor.OnHoverBaseColor = .Color
            colores = .Color.ToArgb
        End With

    End Sub

    Function reload()
        'Cargamos los datos de la tabla
        datos = CargarDatos("sp_tbl_categoria_reservas_select")
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"

        fila = dgdatos.Rows.Count

        'Remplazamos el nombre del  color por el correspondiente
        For i = 0 To fila - 1
            dgdatos.Rows(i).Cells(3).Style.BackColor = Color.FromArgb(dgdatos.Rows(i).Cells(3).Value)
            dgdatos.Rows(i).Cells(3).Style.ForeColor = Color.FromArgb(dgdatos.Rows(i).Cells(3).Value)
        Next

        'Damos el ancho a las siguientes coolumnas
        dgdatos.Columns(1).Width = 50
        dgdatos.Columns(3).Width = 50
        dgdatos.Columns(5).Width = 50
        dgdatos.Columns(3).ReadOnly = True
        dgdatos.Columns(4).Visible = False

    End Function

    Private Sub frm_categoria_reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
        txtcategoria.Focus()
    End Sub

    Private Sub dgdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                If MsgBox("¿Seguro que desea eliminar este registro?", vbYesNo) = vbYes Then
                    fila = dgdatos.CurrentRow.Index 'Me dice enque fila se hizo el click
                    delete_tbl_categoria_reserva(dgdatos.Rows(fila).Cells(1).Value, "sp_tbl_categoria_reserva_delete", 0)
                    reload()
                End If
        End Select
    End Sub

    Private Sub btnactualiazar_Click(sender As Object, e As EventArgs) Handles btnactualiazar.Click
        'Validamos que los campos esten llenos
        If txtcategoria.Text = "" Then
            MsgBox("Debe llenar todos los campos.", vbCritical)
            txtcategoria.Focus()
        Else
            'Guardamos los datos 
            arreglo = {codigo, txtcategoria.Text, colores, ntope.Value}
            update_tbl_categoria_reserva(arreglo, "sp_tbl_categoria_reservas_update")
            limpiarcampos()
            btnactualiazar.Visible = False
            btnguardar.Visible = True
            color_categoria.Reset()
            reload()
        End If
    End Sub

    Function limpiarcampos()
        txtcategoria.Text = ""
        ntope.Value = 0
        color_categoria.Reset()
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'Validamos que los campos esten llenos
        If txtcategoria.Text = "" Then
            MsgBox("Debe llenar todos los campos.", vbCritical)
            txtcategoria.Focus()
        Else
            'Guardamos los datos 
            arreglo = {txtcategoria.Text, colores, ntope.Value}
            insert_tbl_categoria_reservas(arreglo, "sp_tbl_categoria_reservas_insert")
            limpiarcampos()
            color_categoria.Reset()
            reload()
        End If
    End Sub

    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        'obtenemos los datos de la fila donde se dio el doubloe clik
        fila = dgdatos.CurrentRow.Index
        codigo = dgdatos.Rows(fila).Cells(1).Value
        txtcategoria.Text = dgdatos.Rows(fila).Cells(2).Value
        colores = dgdatos.Rows(fila).Cells(3).Value
        ntope.Value = dgdatos.Rows(fila).Cells(5).Value
        btncolor.BaseColor = Color.FromArgb(dgdatos.Rows(fila).Cells(3).Value)
        btnactualiazar.Visible = True
        btnguardar.Visible = False
    End Sub
End Class