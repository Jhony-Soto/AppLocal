Imports System.Runtime.InteropServices
Imports System.IO

Public Class WebcamForm

    Dim DATOS As IDataObject
    Dim IMAGEN As Image
    Dim CARPETA As String
    Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
    Dim DIRECTORIO As String = "C:\Users\SALVADOR\Desktop\" ' AQUI COLOCA LA RUTA A TU ESCRITORIO
    Dim DESTINO As String
    Dim CONTADOR As Integer = 1
    Dim CARPETAS_DIARIAS As String
    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean


    'Open View
    Public Sub OpenPreviewWindow()

        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
           480, VISOR.Handle.ToInt32, 0)

        ' Connect to device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale

            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, VISOR.Width, VISOR.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

        Else
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)

        End If
    End Sub
    Public Sub OpenPreviewWindowCliente()

        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 600, _
           480, MainForm.PicFoto.Handle.ToInt32, 0)

        ' Connect to device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale

            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, MainForm.PicFoto.Width, MainForm.PicFoto.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

        Else
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)

        End If
    End Sub

    Public Sub CapturarCliente()
        ' Copy image to clipboard
        '
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Get image from clipboard and convert it to a bitmap
        '
        DATOS = Clipboard.GetDataObject()

        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        MainForm.PicFoto.Image = IMAGEN


        imagenmemoria = New MemoryStream(Imagen_Bytes(IMAGEN))




        Select Case formu
            Case 1
                frmConfigCuenta.ptbFotoAdmin.Image = Image.FromStream(imagenmemoria)
                imagenmemoria.Close()

            Case 2
                frm_registrarme.ptbFotoAdmin.Image = Image.FromStream(imagenmemoria)
                imagenmemoria.Close()

            Case 3
                frm_registro_update.ptbFotocliente.Image = Image.FromStream(imagenmemoria)
                imagenmemoria.Close()

            Case 4
                frm_insert_update_elemento.ptbFotoelemento.Image = Image.FromStream(imagenmemoria)
                imagenmemoria.Close()

        End Select



        GUARDAR.Visible = True
    End Sub

    Public Sub ClosePreviewWindow()
        '
        ' Disconnect from device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, 0, 0)
        '
        ' close window
        '
        DestroyWindow(hHwnd)
    End Sub

    Private Sub INICIAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INICIAR.Click
        'Load And Capture Device
        OpenPreviewWindow()
        INICIAR.Visible = False
        CAPTURAR.Visible = True
        GRABAR.Visible = True
        FGRABAR.Visible = True
        SERIE.Visible = True
        FSERIE.Visible = True
        FORMATO.Visible = True
    End Sub

    Private Sub CAPTURAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAPTURAR.Click
        ' Copy image to clipboard
        '
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Get image from clipboard and convert it to a bitmap
        '
        DATOS = Clipboard.GetDataObject()

        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        PCAPTURA.Image = IMAGEN
        GUARDAR.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub ButtonSERIEDIARIA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSERIEDIARIA.Click
        CARPETAS_DIARIAS = Application.StartupPath.ToString
        CARPETAS_DIARIAS = CARPETAS_DIARIAS.Replace("\bin\Debug", "\CARPETAS DIARIAS\")

        Try
            My.Computer.FileSystem.CreateDirectory(CARPETAS_DIARIAS)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Timer1.Enabled = True
    End Sub

    Private Sub ButtonFINSERIEDIARIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFINSERIEDIARIA.Click
        Timer1.Enabled = False
    End Sub

    Private Sub ButtonELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonELIMINAR.Click
        CARPETAS_DIARIAS = Application.StartupPath.ToString
        CARPETAS_DIARIAS = CARPETAS_DIARIAS.Replace("\bin\Debug", "\CARPETAS DIARIAS\")
        Try
            My.Computer.FileSystem.DeleteDirectory(CARPETAS_DIARIAS, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Reloj_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reloj.Tick

    End Sub


    Private Sub SERIE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERIE.Click
        CARPETA = InputBox("¿COMO QUIERES QUE SE LLAME LA CARPETA?.¡¡SE SITUARA EN EL ESCRITORIO!!", "CARPETA", DateString)
        DESTINO = DIRECTORIO & CARPETA
        My.Computer.FileSystem.CreateDirectory(DESTINO)
        Reloj.Enabled = True
        SERIE.Visible = False
        FSERIE.Visible = True
    End Sub


    Private Sub GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDAR.Click
        'Set Save Dialog

        SFD.FileName = FECHA
        SFD.Title = "GUARDAR IMAGEN"

        SFD.Filter = "Jpeg|*.jpg"

        'If File Name Not Equal "" then Save The File
        If SFD.ShowDialog = DialogResult.OK Then

            IMAGEN.Save(SFD.FileName, Imaging.ImageFormat.Jpeg)

        End If

        GUARDAR.Visible = False
    End Sub

End Class
