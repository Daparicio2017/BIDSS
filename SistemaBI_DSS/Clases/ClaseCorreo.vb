Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Net
Imports System.Net.Mail




Public Class ClaseCorreo
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim cor As New Clase_Conexion
    Private correo As String
    Private id_usuario As Integer

    'Devuelve el nombre completo del usuario atenticado

    Public Property EMAIl() As String
        Get
            Return Me.correo
        End Get
        Set(value As String)
            Me.correo = value
        End Set
    End Property

    Public Function consultar_correo_username(ByVal usuario As String) As Boolean
        Try
            If cor.conexion.State <> ConnectionState.Open Then
                cor.conectado()
            End If

            Dim objetoComando As New SqlClient.SqlCommand
            objetoComando.Connection = cor.conexion
            objetoComando.CommandText = "sp_Consultar_Correo"
            objetoComando.CommandType = CommandType.StoredProcedure
            objetoComando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario

            Dim objetoDataReader As SqlClient.SqlDataReader
            objetoDataReader = objetoComando.ExecuteReader(CommandBehavior.CloseConnection)
            If objetoDataReader.HasRows Then
                objetoDataReader.Read()
                correo = objetoDataReader.GetValue(0)
                id_usuario = objetoDataReader.GetValue(1)
                objetoDataReader.Close()
                objetoComando = Nothing
                Return True
            Else
                objetoDataReader.Close()
                objetoComando = Nothing
            End If
            objetoDataReader.Close()
            objetoComando = Nothing

        Catch ex As Exception
            MsgBox("ALERTA", +ex.Message, MsgBoxStyle.Critical)

        End Try
        Return False

    End Function

    Public Function socket(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String) As Boolean
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))


            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            envios.Host = "smtp.gmail.com"
            envios.Port = 587

            envios.EnableSsl = True
            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente", MsgBoxStyle.Information, "mensaje")
            Return True


        Catch ex As Exception
            MsgBox("No se pudo enviar su contraseña al correo", MsgBoxStyle.Critical, "ERROR")
            Return False
        End Try


    End Function

End Class
