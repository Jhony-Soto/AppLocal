Imports System.ComponentModel

Public Class frmMovimientos_CambiarElemento_Cantidad
    Public click As Integer
    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        txtDocumento.Text = ""
        Me.Close()
    End Sub

End Class