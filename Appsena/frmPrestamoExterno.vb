Public Class frmPrestamoExterno
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub frmPrestamoExterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tamaño del formulario
        '
        Dim sz As Size = Me.Size

        ' Creamos un nuevo Bitmap con el tamaño y la resolución
        ' del objeto Graphics del formulario.
        '
        Using img As New Bitmap(sz.Width, sz.Height, Me.CreateGraphics)

            ' Dibujamos el formulario
            '
            Me.DrawToBitmap(img, New Rectangle(New Point(0, 0), sz))

            ' Guardamos el mapa de bits como archivo JPEG.
            '
            Dim RutaFoto As Object
            Dim Ruta As String
            RutaFoto = RutaFotos()

            Ruta = RutaFoto.rows(0)(0) & lblDocidNom.Text & "_Prestamo_Externo" & ".jpg"
            MsgBox(Ruta)
            img.Save(Ruta, Imaging.ImageFormat.Jpeg)

        End Using
        Me.Close()

    End Sub
End Class