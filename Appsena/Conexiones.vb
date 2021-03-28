Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
'librerias para Encriptar
Imports System.Security.Cryptography
Imports System.Text

Module Conexiones

    '--------------------------------------------------------------------------------
    '--------------------COMANDOS PARA LA CONEXION A MYSQL---------------------------
    '--------------------------------------------------------------------------------
    Public conexionMS As New MySqlConnection("server=localhost;database=Banco_Sena_mysql;user id=root;password=;")
    Public comandoMS As MySqlCommand
    Public AdaptadorMS As MySqlDataAdapter
    Public LectorMS As MySqlDataReader
    ''*****************************************************


    Public SESSION(10) As Object
    'Variable que Tendra la conexion
    Public conexionSQL As New SqlConnection("Data source=DESKTOP-7GVHR1M\SQLEXPRESS;Initial Catalog=Banco_Sena;integrated security=true")
    'Variable que que llevara los las consultas
    Public comandos As SqlCommand
    'variable para el adaptador de sql
    Public adaptador As SqlDataAdapter
    'variables para el datareader que es solo para lectura
    Public lectura As SqlDataReader
    'varianles para el dataset
    Public dataset As DataSet
    'variable para guardar los datos en tablas
    Public tabla, tablapres As DataTable


    'VARIABLES PARA ENCRIPTAR CONTRASEÑAS EN LA BASE DE DATOS
    Public des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Public hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Public myKey As String = "contrasenia" 'Clave secreta(puede alterarse)

    'Funcion para el Encriptado de Cadenas de Texto
    Public Function Encriptar(ByVal texto As String) As String

        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function

    'Funcion para el Desencriptado de Cadenas de Texto
    Public Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function

    Public Function EstadoConexion() As Boolean

        ' Returns True if connection is available
        ' Replace www.yoursite.com with a site that
        ' is guaranteed to be online - perhaps your
        ' corporate site, or microsoft.com
        Dim objUrl As New System.Uri("https://www.google.com")
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False
            objWebReq = Nothing
            Return False
        End Try
    End Function

End Module
