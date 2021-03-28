Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop 'esta libreria serve para poder importar archivos excel
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Module Importar_excel


    Sub importarExcel(ByVal datagrid As DataGridView) 'recibe como parametro el nombre del datagrid donde se mostrara el archivo excel
        frm_elementos.Cursor = Cursors.WaitCursor
        Dim myFileDialog As New OpenFileDialog() 'agregamos un a ventana de dialogo la cual me abrira mis archivos del pc
        Dim hoja_excel As String = "" 'esta variable sera la que me almacene el nombre de la hoja que se va abrir

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        'validamos que el filedialog tenga una ruta
        If myFileDialog.FileName.ToString <> "" Then
            Dim ruta As String = myFileDialog.FileName.ToString 'guardamos la ruta del archivo excel en esta variable

            Dim dataset_excel As New DataSet 'creamo un datase
            Dim adaptador_excel As OleDbDataAdapter 'creamos un adaptador
            Dim conexion_excel As OleDbConnection 'variable de conexion

            hoja_excel = InputBox("Digite el nombre de la Hoja que desea importar", "Complete") 'Obtenemos el nombre de la hoja de excel
            conexion_excel = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ruta & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'") 'Creamo la conexion con la ruta que obtuvimos en el filedialog

            Try
                adaptador_excel = New OleDbDataAdapter("SELECT * FROM  [" & hoja_excel & "$]", conexion_excel) 'realizamos la consulta para traer todos los registros del archivo excel

                conexion_excel.Open() 'abrimos la conexion
                adaptador_excel.Fill(dataset_excel, "datos") 'llebamos el dataset con los datos que trae el adptador 


                datagrid.DataSource = dataset_excel
                datagrid.DataMember = "datos"

                conexion_excel.Close()
                MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")

            Catch ex As Exception
            conexion_excel.Close()
            MsgBox("Inserte un nombre valido de la Hoja que desea importar", vbCritical)
            End Try

        End If

    End Sub


End Module
