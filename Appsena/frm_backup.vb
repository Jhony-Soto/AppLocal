Imports System.IO
Imports System.Data.SqlClient
Public Class frm_backup
    Dim fecha, dia, arreglo, datos, ruta As Object

    Private Sub radio_lunes_CheckedChanged(sender As Object, e As EventArgs) Handles radio_lunes.CheckedChanged
        'Enviamos el dia de la semana elegido
        dia_semana(Lunes)
        dia = 1
    End Sub

    Private Sub radio_martes_CheckedChanged(sender As Object, e As EventArgs) Handles radio_martes.CheckedChanged
        'Enviamos el dia de la semana elegido
        dia_semana(Martes)
        dia = 2
    End Sub

    Private Sub radio_miercoles_CheckedChanged(sender As Object, e As EventArgs) Handles radio_miercoles.CheckedChanged
        'Enviamos el dia de la semana elegido
        dia_semana(Miercoles)
        dia = 3
    End Sub

    Private Sub radio_jueves_CheckedChanged(sender As Object, e As EventArgs) Handles radio_jueves.CheckedChanged
        'Enviamos el dia de la semana elegido
        dia_semana(Jueves)
        dia = 4
    End Sub

    Private Sub radio_viernes_CheckedChanged(sender As Object, e As EventArgs) Handles radio_viernes.CheckedChanged
        'Enviamos el dia de la semana elegido
        dia_semana(Viernes)
        dia = 5
    End Sub

    Private Sub radio_trimestral_CheckedChanged(sender As Object, e As EventArgs) Handles radio_trimestral.CheckedChanged
        'Muestra la opcion de fecha que marco el usuario
        fechas(radio_trimestral, radio_trimestral.Tag)
    End Sub

    Private Sub radio_semestral_CheckedChanged(sender As Object, e As EventArgs) Handles radio_semestral.CheckedChanged
        'Muestra la opcion de fecha que marco el usuario
        fechas(radio_semestral, radio_semestral.Tag)
    End Sub

    Private Sub btn_archivo_Click(sender As Object, e As EventArgs) Handles btn_archivo.Click
        'Abrimos el explorador para buscar la ruta donde se guardar la copia de seguridad
        Dim carpeta As New FolderBrowserDialog

        If carpeta.ShowDialog = DialogResult.OK Then
            ruta = carpeta.SelectedPath
            txtbackup.Text = ruta & "\"
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'Guardamos la fecha elejida por el usuario
        'Validamos que los radio buttom de fechas y semana esten seleccionados
        If fecha Is Nothing And dia Is Nothing Then
            MsgBox("Debe seleccionar una fecha y un dia para que el sistema realize la copia de seguridad.", vbCritical)
        Else
            guardar_fechas()

        End If
    End Sub

    Private Sub guardar_fechas()
        ReDim arreglo(3)
        Dim dia_actual = Date.Now.DayOfWeek

        'realizamos las operaciones con los dias de la semana para obtener la fecha exacta en las que se hara la copia de seguridad
        arreglo(0) = fecha
        If dia < Date.Now.DayOfWeek Then
            'Si el dia elegido es menor  a la fecha actual
            Select Case dia
                Case 1
                    arreglo(1) = Date.Now.AddDays(-(dia_actual - dia))

                Case 2
                    arreglo(1) = Date.Now.AddDays(-(dia_actual - dia))

                Case 3
                    arreglo(1) = Date.Now.AddDays(-(dia_actual - dia))

                Case 4
                    arreglo(1) = Date.Now.AddDays(-(dia_actual - dia))

                Case 5
                    arreglo(1) = Date.Now.AddDays(-(dia_actual - dia))

            End Select

        Else
            'Si el dia elegido es mayor  a la fecha actual
            If dia > Date.Now.DayOfWeek Then
                arreglo(1) = Date.Now.AddDays(+(dia - dia_actual)).Date
            Else
                arreglo(1) = Date.Now.Date
            End If
        End If

        'Enciamos los datos a la funcion para que los guade en la bd
        arreglo(2) = txtbackup.Text
        tbl_configuracion_backup(arreglo, "sp_tbl_configuracion_backup")

        frm_backup_Load(Nothing, Nothing)

    End Sub

    Private Sub frm_backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datos = CargarDatos("sp_tbl_configuracion_select")
        tabla = New DataTable
        tabla = datos.tables("datos")

        'Validamos la consulta nos devolvio registros
        If tabla(0)(9) IsNot DBNull.Value Then
            txtbackup.Text = tabla(0)(9)
            ruta = tabla(0)(9)
        End If

        If tabla(0)(6) IsNot DBNull.Value Then
            'Marcamos en el radio butttom  el tipo de fecha
            Select Case tabla(0)(6)
                Case 1
                    radio_semanal.Checked = True
                Case 2
                    radio_mensual.Checked = True
                Case 3
                    radio_trimestral.Checked = True
                Case 4
                    radio_semestral.Checked = True
            End Select

            'marcamos en el radio buttom el dia de la seman
            Dim dia_elegido As Date = tabla(0)(7).date
            Select Case dia_elegido.DayOfWeek
                Case 1
                    radio_lunes.Checked = True
                Case 2
                    radio_martes.Checked = True
                Case 3
                    radio_miercoles.Checked = True
                Case 4
                    radio_jueves.Checked = True
                Case 5
                    radio_viernes.Checked = True

            End Select
        End If

    End Sub

    Private Sub btn_generar_copia_Click(sender As Object, e As EventArgs) Handles btn_generar_copia.Click
        If txtbackup.Text <> "" Then
            Cursor = Cursors.WaitCursor
            Dim nombre_backup = "BackUp_Banco_sena_" & Date.Now.Day & Date.Now.Month & Date.Now.Year & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second & ".bak" 'Nomabre de la copia de seguridad

            conexionSQL.Open()
            Try
                comandos = New SqlCommand("BACKUP DATABASE Banco_Sena TO DISK ='" & ruta & nombre_backup & "'", conexionSQL) 'Strin con el que se genera la copia de seguridad

                comandos.ExecuteNonQuery()
                conexionSQL.Close()
                MsgBox("Se genero la copia de seguridad correctamente." & vbLf & "Se abrirá la ruta donde se guardó.", vbInformation)
                conexionSQL.Close()
                Process.Start("explorer.exe", ruta) 'Abrios la ruta donde se guardo la copia desde el explorador de archivos
            Catch ex As SqlException
                If ex.Number = 3201 Then
                    conexionSQL.Close()
                    MsgBox("La ruta especificada no pertenece a la carpeta SQL SERVER para las copias de seguridad", vbCritical)
                End If
            End Try
            Cursor = Cursors.Default
        Else
            MsgBox("La ruta especificada no pertenece a la carpeta SQL SERVER para las copias de seguridad", vbCritical)
        End If


    End Sub

    Private Sub radio_mensual_CheckedChanged(sender As Object, e As EventArgs) Handles radio_mensual.CheckedChanged
        'Muestra la opcion de fecha que marco el usuario
        fechas(radio_mensual, radio_mensual.Tag)
    End Sub

    Private Sub radio_semanal_CheckedChanged(sender As Object, e As EventArgs) Handles radio_semanal.CheckedChanged
        'Muestra la opcion de fecha que marco el usuario
        fechas(radio_semanal, radio_semanal.Tag)
    End Sub

    Function fechas(radio_fecha, tag)
        lbl_inicio.Visible = False
        lblestado1.Visible = True
        lbl_fecha.Visible = True
        lbl_fecha.Text = radio_fecha.text
        fecha = tag
    End Function

    Function dia_semana(dia)
        lblestado2.Visible = True
        lbl_dia.Text = dia.text
        lbl_dia.Visible = True
    End Function
End Class