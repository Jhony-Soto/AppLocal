Imports System.IO

Public Class MainForm
    Public sRuta As String
    Private Sub cmdCapturar_Click_1(sender As Object, e As EventArgs) Handles cmdCapturar.Click
        'llama la funcion del formulario que captura la foto
        WebcamForm.CapturarCliente()
        WebcamForm.ClosePreviewWindow()
        Me.Close()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebcamForm.OpenPreviewWindowCliente()
    End Sub
End Class
