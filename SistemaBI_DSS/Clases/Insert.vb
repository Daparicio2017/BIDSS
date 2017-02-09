Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Windows.Forms

Public Class insert
    Friend conexion As New SqlConnection("server=ArielAlvarenga\SQLEXPRESSS;Initial Catalog=MUTUAL;Integrated Security=True ;database=sistema_bidss ")

    Public Sub insert_usuario(ByVal usuario As String, ByVal nombre_usuario As String, ByVal contraseña As String, ByVal id_rol As Integer,
                               ByVal correo_electronico As String)
        Try
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()

            End If
            Dim Comando As New SqlClient.SqlCommand()
            Comando.Connection = conexion
            Comando.CommandText = "sp_Insertar_Actuliza_usuarios"
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@usuario".ToUpper, SqlDbType.VarChar).Value = usuario.ToUpper
            Comando.Parameters.Add("@nombre_usuario".ToUpper, SqlDbType.VarChar).Value = nombre_usuario.ToUpper
            'Comando.Parameters.Add("@estado_usuario".ToUpper, SqlDbType.VarChar).Value = estado.ToUpper
            Comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña
            Comando.Parameters.Add("@id_rol", SqlDbType.Int).Value = id_rol
            Comando.Parameters.Add("@correo_electronico", SqlDbType.VarChar).Value = correo_electronico

            Comando.ExecuteNonQuery()
            MsgBox("usuario Agregado Corectamente", MsgBoxStyle.OkOnly, "usuario")


        Catch ex As Exception
            MsgBox("Error insertar usuario : " & ex.Message, MsgBoxStyle.Critical, "usuarios")
        End Try
    End Sub

End Class
