Module exportar_plantilla
    Public datos, total As Object
    Function descargar_plantilla(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount 'Obtenemos el numero de columnas

            Dim NRow As Integer = ElGrid.RowCount 'Obtenemos el numero de filas

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

            frm_clientes.Cursor = Cursors.Default

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            frm_clientes.Cursor = Cursors.Default
            Return False

        End Try

        Return True

    End Function

    Function descargar_plantilla_elementos(ByVal ElGrid As DataGridView) As Boolean


        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            datos = CargarDatos("sp_tbl_centroActual_select")
            tabla = New DataTable
            tabla = datos.tables("datos")

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add

            'exHoja.Cells.Item(1, 1) = ""
            exHoja.Cells.Item(2, 8) = "REPORTE DE ELEMENTOS EN INVENTARIO"
            exHoja.Cells.Item(3, 1) = ""
            exHoja.Cells.Item(4, 8) = "CENTRO DE FORMACION :"
            exHoja.Cells.Item(5, 8) = "FECHA : "
            exHoja.Cells.Item(4, 9) = tabla(0)(1)
            exHoja.Cells.Item(5, 9) = Date.Now
            exHoja.Cells.Item(6, 1) = ""
            exHoja.Cells.Item(7, 1) = ""



            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount 'Obtenemos el numero de columnas

            Dim NRow As Integer = ElGrid.RowCount 'Obtenemos el numero de filas

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(8, i) = ElGrid.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 9, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(2).Font.Bold = 1
            exHoja.Rows.Item(4).Font.Bold = 1
            exHoja.Rows.Item(5).Font.Bold = 1
            exHoja.Rows.Item(8).Font.Bold = 1
            exHoja.Cells.Item(NRow + 10, NCol - 1).font.bold = 1

            exHoja.Rows.Item(2).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

            frm_clientes.Cursor = Cursors.Default

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            frm_clientes.Cursor = Cursors.Default
            Return False

        End Try

        Return True


    End Function

    Function descargar_plantilla_bajas(ByVal ElGrid As DataGridView, ByRef titulo As String) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet




        Try

            datos = CargarDatos("sp_tbl_centroActual_select")
            tabla = New DataTable
            tabla = datos.tables("datos")

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add

            'Validamos que tipo de baja nos envian ,dependiendo de ello se escribe el titulo del excel
            exHoja.Cells.Item(2, 6) = titulo


            exHoja.Cells.Item(3, 1) = ""
            exHoja.Cells.Item(4, 6) = "CENTRO DE FORMACION :"
            exHoja.Cells.Item(5, 6) = "FECHA : "
            exHoja.Cells.Item(4, 7) = tabla(0)(1)
            exHoja.Cells.Item(5, 7) = Date.Now
            exHoja.Cells.Item(6, 1) = ""
            exHoja.Cells.Item(7, 1) = ""



            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount 'Obtenemos el numero de columnas

            Dim NRow As Integer = ElGrid.RowCount 'Obtenemos el numero de filas

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(8, i) = ElGrid.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 9, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next




            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(2).Font.Bold = 1
            exHoja.Rows.Item(4).Font.Bold = 1
            exHoja.Rows.Item(5).Font.Bold = 1
            exHoja.Rows.Item(8).Font.Bold = 1
            exHoja.Cells.Item(NRow + 10, NCol - 1).font.bold = 1

            exHoja.Rows.Item(2).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

            frm_clientes.Cursor = Cursors.Default

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            frm_clientes.Cursor = Cursors.Default
            Return False

        End Try

        Return True

    End Function

    Function descargar_plantilla_detalle_mora(ByVal ElGrid As DataGridView, ByRef titulo As String, ByVal arreglo As Object) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet




        Try

            datos = CargarDatos("sp_tbl_centroActual_select")
            tabla = New DataTable
            tabla = datos.tables("datos")

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add

            'Validamos que tipo de baja nos envian ,dependiendo de ello se escribe el titulo del excel
            exHoja.Cells.Item(2, 6) = titulo


            exHoja.Cells.Item(3, 1) = ""
            exHoja.Cells.Item(4, 6) = "CENTRO DE FORMACION :"
            exHoja.Cells.Item(5, 6) = "FECHA : "
            exHoja.Cells.Item(4, 7) = tabla(0)(1)
            exHoja.Cells.Item(5, 7) = Date.Now
            exHoja.Cells.Item(6, 1) = ""
            exHoja.Cells.Item(7, 1) = ""

            'mostramos el nombre del cliente
            'Documento
            exHoja.Cells.Item(8, 1) = "DOCUMENTO"
            exHoja.Cells.Item(8, 2) = arreglo(0)

            'NOMBRES
            exHoja.Cells.Item(8, 3) = "NOMBRES"
            exHoja.Cells.Item(8, 4) = arreglo(1)

            'FICHA
            exHoja.Cells.Item(8, 5) = "FICHA"
            exHoja.Cells.Item(8, 6) = arreglo(2)

            'PROGRAMA
            exHoja.Cells.Item(8, 7) = "PROGRAMA"
            exHoja.Cells.Item(8, 8) = arreglo(3)


            'DEJAMOS DOS FILAS DE ESPACIO ENTRE LA INFORMACION Y LA TABLA
            exHoja.Cells.Item(9, 1) = ""
            exHoja.Cells.Item(10, 1) = ""

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount 'Obtenemos el numero de columnas

            Dim NRow As Integer = ElGrid.RowCount 'Obtenemos el numero de filas

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(11, i) = ElGrid.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 12, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next


            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(2).Font.Bold = 1
            exHoja.Rows.Item(4).Font.Bold = 1
            exHoja.Rows.Item(5).Font.Bold = 1
            exHoja.Rows.Item(11).Font.Bold = 1

            exHoja.Cells.Item(8, 1).font.bold = 1
            exHoja.Cells.Item(8, 3).font.bold = 1
            exHoja.Cells.Item(8, 5).font.bold = 1
            exHoja.Cells.Item(8, 7).font.bold = 1


            exHoja.Rows.Item(2).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

            frm_clientes.Cursor = Cursors.Default

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            frm_clientes.Cursor = Cursors.Default
            Return False

        End Try

        Return True

    End Function

    Function plantilla_elementos_prestamo_externo(ByVal ElGrid As DataGridView, ByVal OtroGrid As DataGridView)

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        'Try

        datos = CargarDatos("sp_tbl_centroActual_select")
        tabla = New DataTable

        tabla = datos.tables("datos")

        'Añadimos el Libro al programa, y la hoja al libro

        exLibro = exApp.Workbooks.Add

        exHoja = exLibro.Worksheets.Add

        'exHoja.Cells.Item(1, 1) = ""
        exHoja.Cells.Item(2, 2) = "ELEMENTOS DEVOLUTIVOS HERRAMIENTAS/MEDIOS AUDIO VISUALES QUE SE VAN A RETIRAR "
        exHoja.Cells.Item(3, 1) = ""
        exHoja.Cells.Item(4, 2) = "CENTRO DE FORMACION:             " & tabla(0)(1)
        exHoja.Cells.Item(5, 2) = "FECHA:           " & Date.Now
        exHoja.Cells.Item(6, 1) = ""
        exHoja.Cells.Item(7, 1) = ""

        ' ¿Cuantas columnas y cuantas filas?

        Dim NCol As Integer = ElGrid.ColumnCount 'Obtenemos el numero de columnas

        Dim NRow As Integer = ElGrid.RowCount 'Obtenemos el numero de filas

        'Aqui recorremos todas las filas, y por cada fila todas las columnas

        'y vamos escribiendo.

        For i As Integer = 1 To NCol
            exHoja.Cells.Item(8, i) = ElGrid.Columns(i - 1).HeaderText.ToString
        Next

        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                exHoja.Cells.Item(Fila + 9, Col + 1) = ElGrid.Item(Col, Fila).Value.ToString
            Next
        Next
            NRow = NRow + 9

        exHoja.Cells.Item(NRow + 1, 1) = ""
        exHoja.Cells.Item(NRow + 2, 1) = ""



        exHoja.Cells.Item(NRow + 2, 2) = "ELEMENTOS CONSUMO HERRAMIENTAS/MEDIOS AUDIO VISUALES QUE SE VAN A RETIRAR "
        exHoja.Cells.Item(NRow + 3, 1) = ""
        exHoja.Cells.Item(NRow + 4, 1) = ""

        Dim Ult As Integer = NRow + 5

        Dim NCol2 As Integer = OtroGrid.ColumnCount 'Obtenemos el numero de columnas

        Dim NRow2 As Integer = OtroGrid.RowCount 'Obtenemos el numero de filas

        'Aqui recorremos todas las filas, y por cada fila todas las columnas

        'y vamos escribiendo.

        For i As Integer = 1 To NCol2
            exHoja.Cells.Item(Ult, i) = OtroGrid.Columns(i - 1).HeaderText.ToString
        Next

        For Fila As Integer = 0 To NRow2 - 1
            For Col As Integer = 0 To NCol2 - 1
                exHoja.Cells.Item(Fila + Ult + 1, Col + 1) = OtroGrid.Item(Col, Fila).Value.ToString
            Next
        Next


        'Titulo en negrita, Alineado al centro y que el tamaño de la columna

        'se ajuste al texto

        exHoja.Rows.Item(2).Font.Bold = 1
        exHoja.Rows.Item(4).Font.Bold = 1
        exHoja.Rows.Item(5).Font.Bold = 1
        exHoja.Rows.Item(8).Font.Bold = 1

        exHoja.Rows.Item(NRow + 2).Font.Bold = 1

        exHoja.Rows.Item(2).HorizontalAlignment = 3

        exHoja.Columns.AutoFit()

        'Aplicación visible

        exApp.Application.Visible = True

        exHoja = Nothing
        exLibro = Nothing
        exLibro = Nothing

        exApp = Nothing

        frm_clientes.Cursor = Cursors.Default

        'Catch ex As Exception

        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        '    frm_clientes.Cursor = Cursors.Default
        '    Return False

        'End Try
        Return True
    End Function
End Module
