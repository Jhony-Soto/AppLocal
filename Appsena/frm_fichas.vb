Public Class frm_fichas
    Dim datos, arreglo, fila, titulo, swich_eliminadas, swich_moroso As Object
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
        FichasActualesToolStripMenuItem_Click(Nothing, Nothing)
    End Sub


    Private Sub reload()
        'Obtenemos las fichas activas de la base de datos
        datos = Select_1ParametroInt("sp_tbl_ficha_select", txtbuscador.Text)
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"


        dgdatos.Columns(0).Visible = True
        dgdatos.Columns(3).Visible = True


        'Cambiamos el estado de la sincronizacion por 0=no y 1=si
        For i = 0 To datos.tables("datos").rows.count - 1
            If dgdatos.Rows(i).Cells(4).Value = 0 Then
                dgdatos.Rows(i).Cells(4).Value = "NO"
                dgdatos.Rows(i).Cells(4).Style.ForeColor = Color.Red
            Else
                dgdatos.Rows(i).Cells(4).Value = "SI"
                dgdatos.Rows(i).Cells(4).Style.ForeColor = Color.Green
            End If
        Next




        'Este es el data grid que se exporta
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"
        titulo = "FICHAS Y PROGRAMAS ACTUALES"

        btnregistros.Text = dgdatos.RowCount

        'Obtenemos la URL de la ficha
        datos = CargarDatos("sp_tbl_configuracion_select")
        tabla = New DataTable
        tabla = datos.tables("datos")

        If tabla(0)(10) IsNot DBNull.Value Then
            txtenlace.Text = tabla(0)(10) 'Url de la ficha
        Else
            pnl_enlace.Visible = True
        End If


        btnexportar.Visible = True
        txtcodigo.Text = ""
        txtprograma.Text = ""
    End Sub

    Private Sub btnguardarficha_Click(sender As Object, e As EventArgs) Handles btnguardarficha.Click
        'Creamos una nueva ficha
        If txtcodigo.Text = "" And txtprograma.Text = "" Then
            MsgBox("Campos vacíos, por favor llene todos los campos obligatorios.", vbCritical)
        Else
            arreglo = {txtcodigo.Text, txtprograma.Text, txtenlace.Text & txtcodigo.Text}
            datos = insert_update_tbl_ficha(arreglo, "sp_tbl_ficha_insert", "guardo")
            If datos = 0 Then
                MsgBox("La ficha ya existe, por favor verificar de nuevo la informacion", vbCritical)
            End If
            reload()
            panel_registro.Visible = False
            txtcodigo.Text = ""
            txtprograma.Text = ""
            Label1.Visible = True
            txtbuscador.Visible = True
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        panel_registro.Visible = True
        Label1.Visible = False
        txtbuscador.Visible = False
        btnexportar.Visible = False

        txtruta_enlace.Visible = False
    End Sub

    Private Sub cerrar_panel_Click(sender As Object, e As EventArgs) Handles cerrar_panel.Click
        panel_registro.Visible = False
        Label1.Visible = True
        txtbuscador.Visible = True
        btnguardarficha.Visible = True
        btn_actualizarficha.Visible = False
        txtcodigo.Text = ""
        txtprograma.Text = ""
        txtcodigo.Enabled = True
        btnexportar.Visible = True
        txtruta_enlace.Visible = True
    End Sub


    Private Sub frm_fichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()

        panel_registro.Visible = False
        txtbuscador.Visible = True
        Label1.Visible = True
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub txtbuscador_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        If swich_eliminadas = 1 Then
            datos = Buscador_keyUp(txtbuscador.Text, "sp_tbl_fichas_eliminadas") ' esta funcion nos busca automaticamente por codigo o nombre del elemento
        Else
            datos = Buscador_keyUp(txtbuscador.Text, "sp_tbl_ficha_select") ' esta funcion nos busca automaticamente por codigo o nombre del elemento
        End If


        tabla = New DataTable
        tabla = datos.tables("datos")

        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"
        btnregistros.Text = dgdatos.RowCount


        'Cambiamos el estado de la sincronizacion por 0=no y 1=si
        For i = 0 To datos.tables("datos").rows.count - 1
            If dgdatos.Rows(i).Cells(4).Value = 0 Then
                dgdatos.Rows(i).Cells(4).Value = "NO"
                dgdatos.Rows(i).Cells(4).Style.ForeColor = Color.Red
            Else
                dgdatos.Rows(i).Cells(4).Value = "SI"
                dgdatos.Rows(i).Cells(4).Style.ForeColor = Color.Green
            End If
        Next

    End Sub



    Private Sub btn_actualizarficha_Click(sender As Object, e As EventArgs) Handles btn_actualizarficha.Click
        'Creamos una nueva ficha
        If txtcodigo.Text = "" And txtprograma.Text = "" Then
            MsgBox("Campos vacíos, por favor llene todos los campos obligatorios.", vbCritical)
        Else
            arreglo = {txtcodigo.Text, txtprograma.Text, txtruta_enlace.text}
            datos = insert_update_tbl_ficha(arreglo, "sp_tbl_ficha_update", "actualizo")
            If datos = 0 Then
                MsgBox("La ficha ya existe, por favor verificar de nuevo la informacion", vbCritical)
            End If
            reload()
            txtcodigo.Text = ""
            txtprograma.Text = ""
            btnguardarficha.Visible = True
            btn_actualizarficha.Visible = False
            panel_registro.Visible = False
            txtcodigo.Enabled = True
            txtbuscador.Visible = True
            Label1.Visible = True
            btnexportar.Visible = True
        End If
    End Sub

    Private Sub dgdatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdatos.CellClick
        'eliminar Ficha
        If e.RowIndex = -1 Then
            Return
        Else
            fila = dgdatos.CurrentRow.Index
            Select Case e.ColumnIndex
                Case 0
                    'Preguntamos si esta seguro en eliminar la ficha 
                    If MessageBox.Show("¿Esta seguro que desea eliminar la ficha" & vbLf &
                                           dgdatos.Rows(fila).Cells(1).Value & " - " & dgdatos.Rows(fila).Cells(2).Value &
                                           ". Al hacerlo también se eliminarán todos los aprendices que pertenecen a ella. ?",
                                       "Eliminar Ficha", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then

                        'validamos que ningunos de los aprenidces esten en mora
                        datos = Select_1ParametroInt("sp_tbl_clientesXficha", dgdatos.Rows(fila).Cells(1).Value)
                        tabla = New DataTable
                        tabla = datos.tables("datos")

                        If tabla.Rows.Count > 0 Then

                            For i = 0 To tabla.Rows.Count - 1
                                'Validamos que el aprendiz no este ne mora
                                datos = Select_1ParametroInt("sp_tbl_mora_select_PK2", tabla(i)(0))
                                If datos.tables("datos").rows.count = 0 Then
                                    datos = tbl_cliente_delete(tabla(i)(0), "sp_tbl_cliente_delete")
                                Else
                                    'Si hay algun moroso activam,os el swic
                                    swich_moroso = 1
                                End If
                            Next
                            'Si no hay ningun moroso en la ficha ,eliminamos la ficha
                            If swich_moroso <> 1 Then
                                eliminar_aprendicesXficha("sp_tbl_ficha_delete", dgdatos.Rows(fila).Cells(1).Value)
                            Else
                                MsgBox("Se eliminaron los aprendices de la ficha " & dgdatos.Rows(fila).Cells(1).Value & " los cuales no estan reportados en mora", vbInformation)
                            End If

                        Else
                            eliminar_aprendicesXficha("sp_tbl_ficha_delete", dgdatos.Rows(fila).Cells(1).Value)
                        End If

                        reload()
                    End If

            End Select
        End If

    End Sub

    Private Sub dgdatos_DoubleClick(sender As Object, e As EventArgs) Handles dgdatos.DoubleClick
        fila = dgdatos.CurrentRow.Index

        If swich_eliminadas <> 1 Then
            'Ocultamos el buscador
            txtbuscador.Visible = False
            Label1.Visible = False

            txtcodigo.Text = dgdatos.Rows(fila).Cells(1).Value
            txtcodigo.Enabled = False
            txtprograma.Text = dgdatos.Rows(fila).Cells(2).Value
            btnguardarficha.Visible = False
            btn_actualizarficha.Visible = True
            panel_registro.Visible = True

            If dgdatos.Rows(fila).Cells(3).Value Is DBNull.Value Then
                If txtenlace.Text <> "" Then
                    txtruta_enlace.Text = txtenlace.Text & dgdatos.Rows(fila).Cells(1).Value
                End If
            Else
                txtruta_enlace.Text = ""
                dgdatos.Rows(fila).Cells(3).Value = ""
                txtruta_enlace.Text = txtenlace.Text & dgdatos.Rows(fila).Cells(1).Value
            End If
            btnexportar.Visible = False
        End If
    End Sub

    '=============================================================================================================================================================
    '================================================================ARRASTRAR UN FORMULARIO======================================================================
    '=============================================================================================================================================================
    Public ex, ey, Operacion As Integer

    Private Sub URLParaElRegistroEnLaWebToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles URLParaElRegistroEnLaWebToolStripMenuItem1.Click
        'Obtenemos los datos del administrador principál
        datos = CargarDatos("sp_tbl_administrador_tipo_admin")
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Si el usuario es el administrador principal
        If SESSION(0) = tabla(0)(0) Then
            pnl_enlace.Visible = True
        Else
            MsgBox("No tienes permiso para ingresar en esta opcion.", vbCritical)
        End If
    End Sub

    Private Sub btn_guardarenlace_Click(sender As Object, e As EventArgs) Handles btn_guardarenlace.Click
        'Guardamos el enlaze para donde se registran los aprendizes en la web
        If txtenlace.Text <> "" Then
            'Se guardar el enlaze
            Select_1ParametroInt("sp_tbl_configuracion_URL", txtenlace.Text & "/aprendiz/nuevoaprendiz/")
            MsgBox("Se guardo el enlace correctamente", vbInformation)

            txtenlace.Enabled = False
            pnl_enlace.Visible = False
            reload()
        Else
            MsgBox("El campo de enlace esta vacio,por favor diligencielo.", vbCritical)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtenlace.Enabled = True
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles cerrar_panel_enlace.Click
        pnl_enlace.Visible = False
        txtenlace.Enabled = False
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Cursor = Cursors.WaitCursor
        ''Descargamos la plantilla con los datos 
        descargar_plantilla_bajas(dgexportar, titulo)
        Cursor = Cursors.Default
    End Sub

    Private Sub FichasEliminadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichasEliminadasToolStripMenuItem.Click
        'Item de fichas eliminadas
        btnagregar.Visible = False
        lbltitulo_fichas.Visible = True
        pnl_header.Visible = True
        swich_eliminadas = 1
        btnexportar.Location = New Point(26, 175)
        eliminadas() 'ESTA FUNCION ME CARGA LAS FICHAS ELIMINADAS
    End Sub


    Private Sub FichasActualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichasActualesToolStripMenuItem.Click
        'Item de fichas actuales
        btnagregar.Visible = True
        lbltitulo_fichas.Visible = False
        pnl_header.Visible = False
        swich_eliminadas = 0

        btnexportar.Location = New Point(176, 175)
        reload()
    End Sub

    Function eliminadas()
        'Obtenemos las fichas activas de la base de datos
        datos = Select_1ParametroInt("sp_tbl_fichas_eliminadas", txtbuscador.Text)
        dgdatos.DataSource = datos
        dgdatos.DataMember = "datos"


        'Este es el data grid que se exporta
        dgexportar.DataSource = datos
        dgexportar.DataMember = "datos"
        titulo = "FICHAS ELIMINADAS"

        dgdatos.Columns(0).Visible = False

        'Cambiamos el estado de la sincronizacion por 0=no y 1=si
        For i = 0 To datos.tables("datos").rows.count - 1
            If dgdatos.Rows(i).Cells(4).Value = 0 Then
                dgdatos.Rows(i).Cells(4).Value = "NO"
            Else
                dgdatos.Rows(i).Cells(4).Value = "SI"
            End If
        Next

        btnregistros.Text = dgdatos.RowCount
    End Function

    Private Sub GunaCircleButton1_Click_1(sender As Object, e As EventArgs)

        txtruta_enlace.Enabled = False
    End Sub

    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_header.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_header.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_header.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '=============================================================================================================================================================
    '=============================================================================================================================================================
    '=============================================================================================================================================================
End Class