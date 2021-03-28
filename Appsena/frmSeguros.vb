Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.FileSystem

Public Class frmSeguros
    Dim RutaFormatos, pnllayout, boton As Object
    Dim SWPanel, SWEdit As Byte
    Dim Ruta As String

    Public ex, ey, Operacion As Integer
    Public Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario
    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    '===================================================================================================================================================


    Private Function SubirFormato(pnl As Guna.UI.WinForms.GunaPanel, btn As Guna.UI.WinForms.GunaCircleButton)
        Dim result As New OpenFileDialog
        ' Test result.
        result.Filter = "Imágenes JPG|*.jpg|Imagenes PNG|*.png|Documento PDF|*.pdf|Tipo TIFF|*.tiff|All files (*.*)|*.*"
        If result.ShowDialog = DialogResult.OK Then
            Ruta = result.FileName
            pnl.BackgroundImage = My.Resources.file_100px
            pnl.BackgroundImageLayout = ImageLayout.Center
            'Se habilita el panel para establecer la fecha nueva del seguro y se amplia el frm para que este se pueda visualizar
            gbxFechaLimite.Visible = True
            SWEdit = 1
            Me.Size = New Size(656, 420)
            btn.Visible = False
            If btn Is btnagg2 Then
                SWPanel = 2
            Else
                SWPanel = 3
            End If
        Else
            SWPanel = 0
            Ruta = Nothing
        End If
    End Function

    Private Function IsFileOpen(filePath As String) As Boolean
        Dim rtnvalue As Boolean = False
        Try
            Dim fs As System.IO.FileStream = System.IO.File.OpenWrite(filePath)
            fs.Close()
        Catch ex As System.IO.IOException
            rtnvalue = True
        End Try
        Return rtnvalue
    End Function

    'Private Function ValidarBotones(btn)
    '    If btn Is btnagg3 Then
    '        If GunaPanel2.BackgroundImage IsNot Nothing Then
    '            Return 1
    '        Else
    '            Return 0
    '        End If
    '    Else
    '        If GunaPanel3.BackgroundImage IsNot Nothing Then
    '            Return 1
    '        Else
    '            Return 0
    '        End If
    '    End If
    'End Function

    Private Sub btnagg2_Click(sender As Object, e As EventArgs) Handles btnagg2.Click
        RutaFormatos = RutaFotos() 'Se consulta las rutas de los formatos
        AbrirArchivos(RutaFormatos.rows(0)(12)) 'Se abre el formato nuevo
        pnllayout = GunaPanel2
        boton = btnagg2
        TimerFile.Start()
    End Sub

    Private Sub btnagg3_Click(sender As Object, e As EventArgs) Handles btnagg3.Click
        RutaFormatos = RutaFotos() 'Se consulta las rutas de los formatos
        AbrirArchivos(RutaFormatos.rows(0)(12)) 'Se abre el formato nuevo
        pnllayout = GunaPanel3
        boton = btnagg3
        TimerFile.Start()
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As MouseEventArgs) Handles GunaPanel1.DoubleClick
        If GunaPanel1.BackgroundImage IsNot Nothing Then
            AbrirArchivos(MaestroPrestamo.rows(0)(8))
        End If
    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As MouseEventArgs) Handles GunaPanel2.DoubleClick
        If GunaPanel1.BackgroundImage IsNot Nothing Then
            AbrirArchivos(MaestroPrestamo.rows(0)(9))
        End If
    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As MouseEventArgs) Handles GunaPanel3.DoubleClick
        If GunaPanel1.BackgroundImage IsNot Nothing Then
            AbrirArchivos(MaestroPrestamo.rows(0)(10))
        End If
    End Sub

    Private Sub frmSeguros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 8 To 10
            If MaestroPrestamo.rows(0)(i) IsNot DBNull.Value Then
                Select Case i
                    Case 8
                        GunaPanel1.BackgroundImage = My.Resources.file_100px
                        GunaPanel1.BackgroundImageLayout = ImageLayout.Center
                        btnagg1.Visible = False

                    Case 9
                        GunaPanel2.BackgroundImage = My.Resources.file_100px
                        GunaPanel2.BackgroundImageLayout = ImageLayout.Center
                        btnagg2.Visible = False


                    Case 10
                        GunaPanel3.BackgroundImage = My.Resources.file_100px
                        GunaPanel3.BackgroundImageLayout = ImageLayout.Center
                        btnagg3.Visible = False

                End Select
            End If
        Next
        SWEdit = 0
        Me.Size = New Size(656, 326)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If SWEdit = 1 Then
            'VALIDAR FECHAS
            MsgBox(MaestroPrestamo.rows(0)(0).ToString)
            If dtpFechaLimit.Value > MaestroPrestamo.rows(0)(7) Then
                If dtpFechaLimit.Value <= MaestroPrestamo.rows(0)(7).addmonths(1) And dtpFechaLimit.Value > MaestroPrestamo.rows(0)(7) Then
                    Dim NewFechaLimit As DateTime
                    If SWPanel = 2 Then
                        NewFechaLimit = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
                        InsertUpdatePrestamo({MaestroPrestamo.rows(0)(0), NewFechaLimit, Ruta, "2"}, "sp_tbl_prestamo_updateseguro")
                    ElseIf SWPanel = 3 Then
                        NewFechaLimit = dtpFechaLimit.Value.ToShortDateString & " " & dtpFechaLimitHora.Value.ToShortTimeString
                        InsertUpdatePrestamo({MaestroPrestamo.rows(0)(0), NewFechaLimit, Ruta, "3"}, "sp_tbl_prestamo_updateseguro")
                    End If
                Else
                    MessageBox.Show("No se puede renovar el seguro ya que la fecha limite es mayor a un mes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("La fecha limite del seguro es menor a la ultima fecha limite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If




        Me.Close()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub TimerFile_Tick(sender As Object, e As EventArgs) Handles TimerFile.Tick
        Dim EstadoArch As Object
        EstadoArch = IsFileOpen(RutaFormatos.rows(0)(12))
        If EstadoArch = False Then
            TimerFile.Stop()
            SubirFormato(pnllayout, boton)

        End If
    End Sub

    Private Sub frmSeguros_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GunaPanel1.BackgroundImage = Nothing
        btnagg1.Visible = True

        GunaPanel2.BackgroundImage = Nothing
        btnagg2.Visible = True

        GunaPanel3.BackgroundImage = Nothing
        btnagg3.Visible = True
        SWEdit = 0
        gbxFechaLimite.Visible = False
    End Sub
End Class