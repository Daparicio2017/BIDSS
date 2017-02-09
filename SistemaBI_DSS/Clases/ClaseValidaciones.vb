
Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Windows.Forms


Public Class ClaseValidaciones
    Dim conexion As New SqlConnection("server=ArielAlvarenga;Initial Catalog=SISTEMABIDSSV1;Integrated Security=True")
    Private _response As Object
    Private Property Response As Object
        Get
            Return _response
        End Get
        Set(value As Object)
            _response = value
        End Set
    End Property
    Public Shared Function Validarpassword(ByVal contraseña As String) As Boolean
        If (contraseña Is Nothing) Then Return False
        If (contraseña.Length < 8) Then Return False
        Dim numero As Boolean
        Dim lmayus As Boolean
        For Each c As Char In contraseña
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
    Public Shared Function valdidarmayusculas(ByVal user As String) As Boolean

        If (user Is Nothing) Then Return False
        Dim lmayus As Boolean
        For Each c As Char In user
            If (c = c.ToString().ToUpper()) Then
                lmayus = True
            End If
        Next

        Return (lmayus)

    End Function
    Public Shared Function valdidarnombreuser(ByVal nombreuser As String) As Boolean

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
        comando.CommandText = "intentos"
        comando.CommandType = CommandType.StoredProcedure
        buscar = comando.ExecuteReader
        comando = Nothing
        Return (buscar)
    End Function
    Public Function validarusuario(ByVal usuario As String, ByVal contraseña As String) As SqlDataReader
        conexion.Open()
        Dim comando As New SqlClient.SqlCommand
        Dim buscar As SqlDataReader
        comando.Connection = conexion
        comando.CommandText = "validar_user"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@usuario", usuario)
        comando.Parameters.AddWithValue("@contraseña", contraseña)
        buscar = comando.ExecuteReader
        comando = Nothing
        Return (buscar)
    End Function

    Public Sub bloquearuser(ByVal usuario As String)
        conexion.Open()
        Dim comando As New SqlClient.SqlCommand
        comando.Connection = conexion
        comando.CommandText = "bloquear_user"
        comando.Parameters.AddWithValue("@usuario", usuario)
        comando.CommandType = CommandType.StoredProcedure
        comando.ExecuteNonQuery()

    End Sub

End Class
