Imports System.ComponentModel

Public Class frmMovimientos_EConsumo
    Public CantElementos, Filas, Suma As Integer
    Public ElementoCons(0, 7), Observaciones() As Object
    Public swCant, swEntUn As Byte
    Public NomElem As String
    Public Str As String
    Public strarr() As String
    Public Cont As Integer


    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub btnSi_CheckedChanged(sender As Object, e As EventArgs) Handles btnSi.CheckedChanged
        Me.Size = New Size(535, 312)
        txtObservaciones.Visible = True
        lblSeconsumio.Visible = True
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        If swCant = 1 Then
            If txtCantidad.Text = "" Or txtCantidad.Text = "0" Then
                For i = 0 To Filas
                    ElementoCons(i, 5) = DBNull.Value
                    EntregarElementos({ElementoCons(i, 0), ElementoCons(i, 1), ElementoCons(i, 2), ElementoCons(i, 3), ElementoCons(i, 4), ElementoCons(i, 5), "0", ElementoCons(i, 7)})
                    datos = SelectElemento(ElementoCons(0, 1), 1) 'Se consulta el elemento actualizado
                    Suma = ElementoCons(0, 2) + datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                    UpdateDispoElemento(ElementoCons(0, 1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                    Suma = 0 'Se reinicia la 
                Next
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnNo_CheckedChanged(sender As Object, e As EventArgs) Handles btnNo.CheckedChanged
        Me.Size = New Size(535, 175)
        txtObservaciones.Visible = False
        lblSeconsumio.Visible = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Select Case swCant
            Case 1
                If txtCantidad.Text = "" Or txtCantidad.Text = "0" Then
                    For i = 0 To Filas
                        ElementoCons(i, 5) = DBNull.Value
                        EntregarElementos({ElementoCons(i, 0), ElementoCons(i, 1), ElementoCons(i, 2), ElementoCons(i, 3), ElementoCons(i, 4), ElementoCons(i, 5), "0", ElementoCons(i, 7)})
                        datos = SelectElemento(ElementoCons(0, 1), 1) 'Se consulta el elemento actualizado
                        Suma = ElementoCons(0, 2) + datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                        UpdateDispoElemento(ElementoCons(0, 1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                        Suma = 0 'Se reinicia la 
                    Next
                Else
                    'SE VALIDA SI TIENE UNA OBSERVACION 
                    If txtObservaciones.Text = "" Or txtObservaciones.Text = "Debe especificar por cada unidad en qué se consumió el elemento" Then
                        MessageBox.Show("Por favor especifique en que se consumio el elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtObservaciones.Focus()
                        Return
                    Else
                        'SE DIVIDEN LAS OBSERVACIONES
                        ReDim Observaciones(txtCantidad.Text - 1)
                        Str = txtObservaciones.Text
                        Cont = 0
                        strarr = Str.Split(",")
                        For Each s As String In strarr
                            Cont = Cont + 1
                        Next
                    End If
                    'VALIDAR QUE LA CANTIDAD PARA ENVIAR A CONSUMO NO SEA MAYOR QUE LA CANTIDAD DEL ELEMENTO PRESTADO
                    If txtCantidad.Text > CantElementos Then
                        MessageBox.Show("La cantidad de elementos consumidos es mayor a la cantidad que el cliente prestó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCantidad.Focus()
                        Return
                    Else
                        'VALIDAR QUE LA CANTIDAD DE OBSERVACIONES NO SEA MAYOR A LA CANTIDAD DE ELEMENTO EN CONSUMO
                        If Cont > txtCantidad.Text Then
                            MessageBox.Show("La cantidad de observaciones es mayor a la cantidad del elemento consumido." & vbNewLine & "Si desea hacer varias observaciones a un solo elemento,puede separar las observaciones con un guión. ( - ) u otro caracter " & vbNewLine & "Si desea hacer observaciones para cada elemento, debe separar con una coma. ( , )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtObservaciones.Focus()
                            Return
                        Else
                            Cont = 0
                            strarr = Str.Split(",")
                            For Each s As String In strarr
                                Observaciones(Cont) = s
                                Cont = Cont + 1
                            Next

                            'SE GUARDA LAS OBSERVACIONES EN CADA UNO DE LOS ELEMENTOS CONSUMIDOS
                            For i = 0 To Observaciones.Length - 1
                                ElementoCons(i, 5) = Observaciones(i)
                            Next

                            For i = 0 To Filas
                                If ElementoCons(i, 5) Is DBNull.Value Then
                                    EntregarElementos({ElementoCons(i, 0), ElementoCons(i, 1), ElementoCons(i, 2), ElementoCons(i, 3), ElementoCons(i, 4), ElementoCons(i, 5), "0", ElementoCons(i, 7)})
                                    datos = SelectElemento(ElementoCons(0, 1), 1) 'Se consulta el elemento actualizado
                                    Suma = ElementoCons(0, 2) + datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                                    UpdateDispoElemento(ElementoCons(0, 1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                                    Suma = 0 'Se reinicia la 

                                Else
                                    EntregarElementos({ElementoCons(i, 0), ElementoCons(i, 1), ElementoCons(i, 2), ElementoCons(i, 3), ElementoCons(i, 4), ElementoCons(i, 5), "2", ElementoCons(i, 7)})
                                End If
                            Next
                        End If
                    End If
                End If
            Case 0
                If btnSi.Checked = True Then
                    If txtObservaciones.Text = "" Or txtObservaciones.Text = "Debe especificar por cada unidad en qué se consumió el elemento" Then
                        MessageBox.Show("Por favor especifique en que se consumio el elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtObservaciones.Focus()
                        Return
                    Else
                        ElementoCons(0, 6) = "2" 'Se cambia el estado del elemento
                        'Se entrega el elemento pero no se devuelve a la disponibilidad
                        ElementoCons(0, 5) = txtObservaciones.Text
                        EntregarElementos({ElementoCons(0, 0), ElementoCons(0, 1), ElementoCons(0, 2), ElementoCons(0, 3), ElementoCons(0, 4), ElementoCons(0, 5), "2", ElementoCons(0, 7)})
                    End If
                Else
                    ElementoCons(0, 6) = "0" 'Se cambia el estado del elemento
                    ElementoCons(0, 5) = DBNull.Value
                    EntregarElementos({ElementoCons(0, 0), ElementoCons(0, 1), ElementoCons(0, 2), ElementoCons(0, 3), ElementoCons(0, 4), ElementoCons(0, 5), "0", ElementoCons(0, 7)})
                    datos = SelectElemento(ElementoCons(0, 1), 1) 'Se consulta el elemento actualizado
                    Suma = ElementoCons(0, 2) + datos.rows(0)(2) 'Se suma el elemento entregado a la disponibilidad del mismo
                    UpdateDispoElemento(ElementoCons(0, 1), Suma) 'Se agrega la suma de la disponibilidad al elemento
                    Suma = 0 'Se reinicia la 
                End If
        End Select



        'TERMINAR LA ENTREGA DE ELEMENTOS POR CONSUMO

        swCant = 0

        'frmMovimientos_Detalle_EntregarUno.CargarFormulario(ElementoCons(0, 0), ElementoCons(0, 1), ElementoCons(0, 4), 1, frmMovimientos_detalle.lblDocidNom.Text, 1)
        Me.Close()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub frmMovimientos_EConsumo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        btnSi.Checked = True
        txtObservaciones.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub frmMovimientos_EConsumo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case swCant
            Case 1
                lblPregunta.Text = "¿Cuántos elementos se consumieron completamente?"
                txtCantidad.Visible = True
                btnSi.Visible = False
                btnNo.Visible = False
            Case 0
                lblPregunta.Text = "¿El elemento se consumió completamente?"
                txtCantidad.Visible = False
                btnSi.Visible = True
                btnNo.Visible = True
        End Select
        'Nombre del elemento
        lblElemento.Text = NomElem
        'lblElemento.Text =
        txtObservaciones.Text = "Debe especificar por cada unidad en qué se consumió el elemento"
        txtObservaciones.ForeColor = Color.DarkGray

    End Sub

    Private Sub txtObservaciones_GotFocus(sender As Object, e As EventArgs) Handles txtObservaciones.GotFocus
        If txtObservaciones.Text = "Debe especificar por cada unidad en qué se consumió el elemento" Then
            txtObservaciones.Text = ""
            txtObservaciones.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtObservaciones_LostFocus(sender As Object, e As EventArgs) Handles txtObservaciones.LostFocus
        If txtObservaciones.Text = "" Then
            txtObservaciones.Text = "Debe especificar por cada unidad en qué se consumió el elemento"
            txtObservaciones.ForeColor = Color.DarkGray
        End If
    End Sub
End Class