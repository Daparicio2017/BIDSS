Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Windows.Forms


Public Class CValidar

    Dim conexion As New SqlConnection("server=DEGA-HP;Initial Catalog=BIDSS;Integrated Security=True ;database=BIDSS.bak ")
    Private _response As Object

    Private Property Response As Object
        Get
            Return _response
        End Get
        Set(value As Object)
            _response = value
        End Set
    End Property

    Public Shared Function valdidarpassword(ByVal Contraseña As String) As Boolean

        If (Contraseña Is Nothing) Then Return False


        If (Contraseña.Length < 8) Then Return False

        Dim numero As Boolean
        Dim lmayus As Boolean


        For Each c As Char In Contraseña

            If (Char.IsDigit(c)) Then
                numero = True
                Continue For
            End If

            If (c = c.ToString().ToUpper()) Then
                lmayus = True
            End If
        Next

        Return ((numero) And (lmayus))

    End Function
    Public Shared Function valdidarmayusculas(ByVal user As String) As String

        If (user Is Nothing) Then Return False
        Dim lmayus As Boolean
        For Each c As Char In user
            If (c = c.ToString().ToUpper()) Then
                lmayus = True
            End If
        Next

        Return (lmayus)

    End Function
    Public Shared Function valdidarnombreuser(ByVal nombreuser As String) As String

        If (nombreuser Is Nothing) Then Return False
        Dim lmayus As Boolean
        For Each c As Char In nombreuser
            If (c = c.ToString().ToUpper()) Then
                lmayus = True
            End If
        Next
        Return (lmayus)

    End Function
    Public Function validarintentos() As SqlDataReader
        conexion.Open()
        Dim comando As New SqlClient.SqlCommand
        Dim buscar As SqlDataReader
        comando.Connection = conexion
        comando.CommandText = "Intentos"
        comando.CommandType = CommandType.StoredProcedure
        buscar = comando.ExecuteReader
        comando = Nothing
        Return (buscar)
    End Function
    'Public Function validarusuario(ByVal usuario As String, ByVal contraseña As String) As SqlDataReader
    'conexion.Open()
    'Dim comando As New SqlClient.SqlCommand
    'Dim buscar As SqlDataReader
    'comando.Connection = conexion
    'comando.CommandText = "validar_user"
    'comando.CommandType = CommandType.StoredProcedure
    'comando.Parameters.AddWithValue("@usuario", usuario)
    'comando.Parameters.AddWithValue("@contraseña", contraseña)
    'buscar = comando.ExecuteReader
    'comando = Nothing
    'Return (buscar)
    'End Function

    Public Sub bloquearuser(ByVal usuario As String)
        conexion.Open()
        Dim comando As New SqlClient.SqlCommand
        comando.Connection = conexion
        comando.CommandText = "bloquear_user"
        comando.Parameters.AddWithValue("@usuario", usuario)
        comando.CommandType = CommandType.StoredProcedure
        comando.ExecuteNonQuery()

    End Sub


    Public Sub respuestas(ByVal id As Integer, ByVal resp As String, ByVal usuario As String, ByVal preg_c As Integer)
        Try
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            Dim Comando As New SqlClient.SqlCommand()
            Comando.Connection = conexion
            Comando.CommandText = "respuestas_seguridad"
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id_user", SqlDbType.Int).Value =
                Comando.Parameters.Add("@resp".ToUpper, SqlDbType.VarChar).Value = resp
            Comando.Parameters.Add("@usuario".ToUpper, SqlDbType.VarChar).Value = usuario.ToUpper
            Comando.Parameters.Add("@preg_c".ToUpper, SqlDbType.VarChar).Value = preg_c
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error Insertar Usuario : " & ex.Message, MsgBoxStyle.Critical, "usuarios")
        End Try
    End Sub




    Public Function preguntas(ByVal id As Integer, ByVal usuario As String) As SqlDataReader

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If

        Dim Comando As New SqlClient.SqlCommand()
        Dim buscar As SqlDataReader
        Comando.Connection = conexion
        Comando.CommandText = "confirma_preguntas"
        Comando.CommandType = CommandType.StoredProcedure
        Comando.Parameters.Add("@id", SqlDbType.Int).Value = id
        Comando.Parameters.Add("@usuario".ToUpper, SqlDbType.VarChar).Value = usuario.ToUpper
        buscar = Comando.ExecuteReader
        Comando = Nothing
        Return (buscar)
    End Function
    Public Property nombre() As String
        Get
            Return m_nombre
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                Throw New Exception("Nombre del Usuario en Blanco, Porfavor Ingresar los Datos ")
            Else
                m_nombre = value
            End If

        End Set
    End Property
    Public Property password() As String
        Get
            Return m_password
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                Throw New Exception("Password Esta en Blanco, Porfavor Ingresar los Datos")
            Else
                m_password = value
            End If
        End Set
    End Property
    Public Property password2() As String
        Get
            Return m_password2
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                Throw New Exception("Campo Esta en Blanco, Porfavor Ingresar los Datos ")
            Else
                m_password2 = value
            End If
        End Set
    End Property
    Public Property mail() As String
        Get
            Return m_mail
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                Throw New Exception("Campo Correo Esta en Blanco, Porfavor Ingresar los Datos ")
            Else
                m_mail = value
            End If
        End Set
    End Property




End Class
