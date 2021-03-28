Imports Guna.UI
Public Class frm_calendario
    Dim datos, array, hora, colores As Object
    Private pnlguna As New List(Of Guna.UI.WinForms.GunaShadowPanel) 'este es el panel que crearemos de guna  en generardias()
    Private fechaActual As DateTime = DateTime.Today 'esta variable me toma la fecha actual
    Private fecha_hoy As DateTime = DateTime.Today 'esta variable me toma la fecha actual

    Public Sub frm_Reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarDias(42) 'esta funcion crea el numero de paneles que le enviemos
        fecha_de_hoy() 'esta funcion obtiene la fecha actual
        Me.AutoScroll = True
    End Sub

    Function GenerarDias(totaldias)
        'Limpiamos el panel y los label de los datos anteriores para que no se me cargue con los nuevos
        flowpaneldias.Controls.Clear() 'flowpanel es el panel que me contiene los paneles de cada uno de los dias
        pnlguna.Clear() 'este el es label que me muestra el numero de cada dia

        For i = 1 To totaldias
            Dim paneldia As New Guna.UI.WinForms.GunaShadowPanel 'creamos el panel que vamos a usar es de guna ui
            paneldia.Name = $"pnldia{i}"  'Le damos en nombre al panel 
            paneldia.Size = New Size(200, 140) 'le damos tamaño al panel 
            paneldia.BackColor = Color.White 'Color al panel
            paneldia.BorderStyle = BorderStyle.FixedSingle 'especificamos el tipo de bordes
            paneldia.Cursor = Cursors.Hand 'el estilo del cursor que se veral al pasar el mouse
            paneldia.AutoScroll = True
            AddHandler paneldia.Click, AddressOf Agregar_reserva 'Esta linea le definimos un evento a un control (paneldia.click) y llamamos la funcion que se desplegara al hacerlo
            flowpaneldias.Controls.Add(paneldia)
            pnlguna.Add(paneldia)
        Next

    End Function

    Private Sub Agregar_reserva(ByVal sender As Object, e As EventArgs)
        Dim dia As Integer = CType(sender, Guna.UI.WinForms.GunaShadowPanel).Tag 'Obtenemos el tag = dia en el que se dio el click
        If dia <> 0 Then 'validamos que el dia sea diferente a 0
            Dim dato = New DateTime(fechaActual.Year, fechaActual.Month, dia) 'loa variable lleva la fecha en la que se dio el click ejemplo 12-11-2019

            'Validamos que no se hagal la reserva en dias anteriores ala fecha actual
            If dato < fecha_hoy Then
                MsgBox("Las reservas deben hacerse para días posteriores a la fecha de hoy.", vbCritical)
            Else
                ''esta codigo indica que vamos a trabjar con los controles del formulario frm_reservas
                With frm_reservas
                    .pickerfecha_reserva.Value = dato 'le asigamos la fecha al control del formulario que estamos utilizxndo
                    .ShowDialog() 'abrimos el formulario
                End With
            End If
        End If

    End Sub


    Public Sub Mostrarfecha()
        lblheaderfecha.Text = fechaActual.ToString("MMMM, yyyy") 'Llevamos al label el nombre del mes y el año actual
        Dim primer_dia As Integer = primer_dia_mes() 'asignamos a la variable el primer dia del mes que obtuvimos de la funcion que llamamos 1/11/2019
        Dim totaldias As Integer = total_dias_mes() 'capturamos en una variable el total de dias del mes
        agregar_label_dias_mes(primer_dia, totaldias) 'llamamos la funcion que colocara el label a cada panel dependiendo del total de dias del mes
        cargar_dia_reserva(primer_dia) 'esta funcion me muestra en el calendario los dias que tiene una reserva
    End Sub

    Private Function primer_dia_mes() As Integer
        'con esta funcion sacamos el primer dia del mes
        Dim dia_mes As DateTime = New Date(fechaActual.Year, fechaActual.Month, 1)
        Return dia_mes.DayOfWeek + 1 'retornamos el primer dia que es 1 y le sumamos otro 1
    End Function

    Private Function total_dias_mes() As Integer
        'esta funcion me cuenta el numero de dias que tiene el mes 
        Dim primer_dia As DateTime = New Date(fechaActual.Year, fechaActual.Month, 1) 'Obtengo el primer dia del mes 1/11/2019
        Return primer_dia.AddMonths(1).AddDays(-1).Day 'Le suamos un mes a la fecha (1/12/2019) y le restamos un dia para saber hasta que dia va el mes actual (30/11/2019)
    End Function


    Private Sub agregar_label_dias_mes(ByVal primer_dia As Integer, ByVal totaldias As Integer)
        'limpiamos todos los paneles de labels de tag y de background
        For Each lbl As Guna.UI.WinForms.GunaShadowPanel In pnlguna
            lbl.Controls.Clear()
            lbl.Tag = 0
            lbl.BackColor = Color.White

        Next

        'este para colocara los label a cada uno de los paneles dependiendo el total de dias que tenga el mes
        For i As Integer = 1 To totaldias
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            pnlguna((i - 1) + (primer_dia - 1)).Tag = i 'Le damos el tag al panel dependiendo el numero del dia (i)
            pnlguna((i - 1) + (primer_dia - 1)).Controls.Add(lbl)

            'validamos si el dia en el que va el for es igual al dia de hoy ,le colocamos un color direrente a ese panel 
            If New Date(fechaActual.Year, fechaActual.Month, i) = Date.Today Then
                pnlguna((i - 1) + (primer_dia - 1)).BackColor = Color.FromArgb(110, 238, 160)
            End If

        Next
    End Sub


    Private Sub MesAnteorir()
        fechaActual = fechaActual.AddMonths(-1) 'le esta un mes a la fecha actual
        Mostrarfecha() 'llamamos a esta funcion que desplegara el resto de las fucciones
    End Sub


    Private Sub SiguienteFecha()
        fechaActual = fechaActual.AddMonths(1) 'le suma otro mes a la fecha
        Mostrarfecha() 'llama  a la funcion para que esta deplegue el resto de funciones dependiendo de la fecha
    End Sub

    Private Sub fecha_de_hoy()
        fechaActual = DateTime.Today 'Obtenemos la fecha actual
        Mostrarfecha() 'Llamamos a estafuncion que definira el total de dias del mes actual y esa desplegara el resto de las funciones
    End Sub

    Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
        MesAnteorir() 'esta funcion de vulve al mes anterior
    End Sub

    Private Sub btnsiguente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        SiguienteFecha() 'esta funcion me lleva la mes siguiente
    End Sub

    Private Sub linkhistorial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub btnhistorial_Click(sender As Object, e As EventArgs) Handles btnhistorial.Click
        CerrarConfig()
        CerrarPestañas()
        BajarNivel(frm_historial_reservas)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        btnhistorial_Click(Nothing, Nothing)
    End Sub

    'CARGO EN  EL CALENDARIO LOS DIAS QUE TIENE UN ARESERVA
    Public Sub cargar_dia_reserva(primer_dia_mes)
        Dim dia_inicial As DateTime = New Date(fechaActual.Year, fechaActual.Month, 1) 'obtenemos el primer dia del mes
        Dim Dia_final As DateTime = dia_inicial.AddMonths(1).AddDays(-1) 'Obtenemos el dia final del mes actual


        Dim datos = dia_reservas(dia_inicial, Dia_final, "sp_dias_con_reservas") 'Llamamos la funcion y le enviamos las fechas como parametros

        tabla = New DataTable
        tabla = datos.tables("datos")
        Dim filas = tabla.Rows.Count
        'Validamos si la consulta encontro reservas entre las dos fechas
        If filas <> 0 Then

            For Each row As DataRow In tabla.Rows
                Dim fecha_prestamo As DateTime = DateTime.Parse(row("fecha_prestamo"))
                hora = Format$(fecha_prestamo, "H:mm")
                colores = row("color")

                Dim link As New LinkLabel
                link.Tag = row("codigo")
                link.Name = $"link{row("codigo")}"
                link.Text = hora & " - " & row("Nombre")
                link.Size = New Size(110, 22)
                link.Font = New Font("Microsoft Sans Serif", 10)
                link.LinkBehavior = LinkBehavior.NeverUnderline
                Dim ColorNormal As Color
                ColorNormal = ColorTranslator.FromOle(colores)

                link.BackColor = Color.FromArgb(colores)

                Dim coecolor = 0.2126 * (ColorNormal.R + 0.7152) * (ColorNormal.G + 0.0722) * (ColorNormal.B)
                If coecolor > 100 Then
                    link.LinkColor = Color.Black
                Else
                    link.LinkColor = Color.White
                End If



                ToolTip1.SetToolTip(link, hora & " - " & row("Nombre") & " - " & row("categoria"))
                link.Dock = DockStyle.Bottom
                AddHandler link.Click, AddressOf abrir_detalle_reserva

                pnlguna((fecha_prestamo.Day - 1) + (primer_dia_mes - 1)).Controls.Add(link) 'agrega un link a cada panel donde hay una reserva
            Next
        End If
    End Sub

    Private Sub abrir_detalle_reserva(sender As Object, e As EventArgs)
        codreserva = CType(sender, LinkLabel).Tag 'Obtenemosz el codigo de la reserva 
        datos = Reserva_selectPK(codreserva, "sp_tbl_reserva_selecPK") 'enviamos a la funcion los porametros y gurdamnos en una variable lo que nos devuelve
        'guardamos en una tabla los datos para asi manipularlos de una mejor manera
        tabla = New DataTable
        tabla = datos.tables("datos")

        Dim registros = tabla.Rows.Count 'contamos el nmero de filas que tiene la tabla
        If registros <> 0 Then
            hora = Format$(tabla(0)(7), "H:mm")

            With frm_detalle_reserva
                .fecha_reserva.Value = tabla(0)(6)
                codcliente = tabla(0)(1)
                .pickerfecha_prestamo.Value = tabla(0)(7)
                .picker_hora.Text = hora
                .lblcliente.Text = tabla(0)(2)
                .picker_hora_devolucion.Value = tabla(0)(8)
                .txttipo_prestamo.Text = tabla(0)(4)
                ReDim .arreglo(2)
                tipo_prestamo = tabla(0)(3)

                .txtbuscadorficha.Text = tabla(0)(12)
                .codficha = tabla(0)(11)

                .txtcategoria_reserva.Text = tabla(0)(10)
                .categoria = tabla(0)(9)

                .txtbuscador.Focus()
                .ShowDialog()
            End With
        End If
    End Sub

End Class